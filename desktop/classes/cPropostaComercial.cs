/*
 * Impressão do Orçamento - Proposta Comercial
 * Data: 07/03/2011
 * Hora: 17:35
 * 
 * 29/03/2014 - Ricardo - possibilitar impressão de medidas
 * 29/03/2014 - Ricardo - numeração de itens
 * 29/03/2014 - Ricardo - mostrar todos os telefones do cliente
 * 29/03/2014 - Ricardo - opçao para não mostrar total de produtos e serviços
 * 29/03/2014 - Ricardo - não estava mostrando sub-total quando não mostrava imagens
 * 02/05/2014 - Ricardo - correção do sequenciador de itens
 * 09/07/2014 - Ricardo - sequencial de item em coluna separada
 *                        título Medidas alterado para Dimensões
 *                        não mostrar desconto zerado
 *                        mostrar número da página
 * 15/07/2014 - Ricardo - descrição em linha separada
 * 16/11/2014 - Ricardo - não mostrar sub-totais não mostrar valor
 * 
 * 21/03/2018 - Ricardo - mostrar o email do vendedor abaixo do nome
 *
 */

using System;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using System.Windows.Forms;
using System.Threading;

namespace classes {
	/// <summary>
	/// Description of cPropostaComercial.
	/// </summary>
	public static class cPropostaComercial {
		//private static bool saltaPagina=false;
		private static float total_itens=0;
		private static string filial;
		private static string rua;
		private static string nro;
		private static string complemento;
		private static string cep;
		private static string fone;
		private static string fax;
		private static string email;
		private static string nom_vendedor;
		private static string email_vendedor;
		private static string nom_cliente;
		private static int seq_item;
				
		private static void AdicionaTexto(Document doc, string texto) {
			string[] partes = texto.Split('\n');
			foreach (string parte in partes)
				doc.Add(new Paragraph(new Chunk(parte, FontFactory.GetFont(BaseFont.HELVETICA, 9))));
		}

		private static string NomeVendedor(string cod_vendedor) {
			string nome=cod_vendedor;
			FbCommand cmd = new FbCommand(
					"select NOM_FUNCIONARIO " +
					"from funcionarios " +
					"where COD_FUNCIONARIO='" + cod_vendedor + "'",
					Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);		
			if (reader.Read())
				nome = !reader.IsDBNull(0) ? reader.GetString(0).Trim() : "";
			reader.Close();									
			return nome;
		}
		
		private static void GeraIntroducao(Document doc, string cod_cliente, string cod_introducao, string cod_fornecedor, DateTime dat_orcamento, short cod_orcamento, string observacao_orcamento) {
			/*
			if (saltaPagina) {
				doc.NewPage();
				saltaPagina = false;
			}
			else saltaPagina = true;			
			*/
			seq_item = 0;
						
			FbCommand cmd = new FbCommand(
					"select des_introducao " +
					"from introducoes " +
					"where cod_introducao='" + cod_introducao + "'",
					Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			
			cPedidos pedidos = new cPedidos();
			Cabecalho2_Pedido cab2 = pedidos.DadosCabecalho2(cod_fornecedor, dat_orcamento, cod_orcamento, false);
			nom_vendedor = NomeVendedor(cab2.vendedor);
			email_vendedor = cab2.email_vendedor;
			nom_cliente = cab2.cliente;
			
			string[] meses = {"janeiro", "fevereiro", "março", "abril", "maio", "junho", "julho", "agosto", "setembro", "outubro", "novembro", "dezembro" };
			string local_data = "Belo Horizonte, " + DateTime.Today.Day + " de " + meses[DateTime.Today.Month-1] + " de " + DateTime.Today.Year;
			doc.Add(new Paragraph(new Chunk(local_data, FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 9))));			
			//doc.Add(new Paragraph(new Chunk("A Softplace\r\nAtt.", FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 9))));			
			doc.Add(new Paragraph(new Chunk("Prezado(a) Senhor(a) " + cab2.contato + ",", FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 9))));						
			
			string des_introducao="";
			if (reader.Read())
				des_introducao = !reader.IsDBNull(0) ? reader.GetString(0).Trim() : "";
			reader.Close();						
			AdicionaTexto(doc, des_introducao);
			
			doc.Add(new Paragraph(new Chunk("", FontFactory.GetFont(BaseFont.HELVETICA, 9))));									
			doc.Add(new Paragraph(new Chunk("Atenciosamente,", FontFactory.GetFont(BaseFont.HELVETICA, 9))));									
			doc.Add(new Paragraph(new Chunk(Globais.sFilial, FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 9))));									
			doc.Add(new Paragraph(new Chunk(nom_vendedor, FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 9))));							
			doc.Add(new Paragraph(new Chunk(email_vendedor, FontFactory.GetFont(BaseFont.HELVETICA, 9))));
			doc.Add(new Paragraph(new Chunk("", FontFactory.GetFont(BaseFont.HELVETICA, 9))));
			doc.Add(new Paragraph(new Chunk("", FontFactory.GetFont(BaseFont.HELVETICA, 9))));

			
			PdfPTable table = new PdfPTable(1);			
			table.SpacingBefore = 30f;
			table.WidthPercentage = 100;
			PdfPCell cell = new PdfPCell(new Phrase(new Chunk("Cliente", FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 9))));
			cell.BorderWidth = 0;
			cell.BorderWidthBottom = 1;
			//cell.BorderWidthTop = 1;
			table.AddCell(cell);
			doc.Add(table);			
			
			table = new PdfPTable(4);
			table.WidthPercentage = 100;
			
			cell = new PdfPCell(new Phrase(new Chunk("Nome:", FontFactory.GetFont(BaseFont.HELVETICA, 9))));
			cell.BorderWidth = 0;
			cell.HorizontalAlignment = Element.ALIGN_RIGHT;
			table.AddCell(cell);
			
			cell = new PdfPCell(new Phrase(new Chunk(cab2.cliente, FontFactory.GetFont(BaseFont.HELVETICA, 9))));
			cell.BorderWidth = 0;
			cell.Colspan = 3;
			table.AddCell(cell);			
						
			cell = new PdfPCell(new Phrase(new Chunk("Contato:", FontFactory.GetFont(BaseFont.HELVETICA, 9))));
			cell.BorderWidth = 0;
			cell.HorizontalAlignment = Element.ALIGN_RIGHT;
			table.AddCell(cell);
			
			cell = new PdfPCell(new Phrase(new Chunk(cab2.contato, FontFactory.GetFont(BaseFont.HELVETICA, 9))));
			cell.BorderWidth = 0;
			cell.Colspan = 3;
			table.AddCell(cell);			
			
			cell = new PdfPCell(new Phrase(new Chunk("Telefone:", FontFactory.GetFont(BaseFont.HELVETICA, 9))));
			cell.BorderWidth = 0;
			cell.HorizontalAlignment = Element.ALIGN_RIGHT;
			table.AddCell(cell);
			
			string fones = FONES.Concatena(cab2.fone, cab2.fone2, cab2.celular, cab2.fone1_parceiro, cab2.fone2_parceiro, cab2.celular_parceiro);
			cell = new PdfPCell(new Phrase(new Chunk(fones, FontFactory.GetFont(BaseFont.HELVETICA, 9))));
			cell.BorderWidth = 0;
			cell.Colspan = 3;
			table.AddCell(cell);									
			
			cell = new PdfPCell(new Phrase(new Chunk("e-mail", FontFactory.GetFont(BaseFont.HELVETICA, 9))));
			cell.BorderWidth = 0;
			cell.HorizontalAlignment = Element.ALIGN_RIGHT;
			table.AddCell(cell);			
			
			cell = new PdfPCell(new Phrase(new Chunk(cab2.email, FontFactory.GetFont(BaseFont.HELVETICA, 9))));
			cell.BorderWidth = 0;
			cell.Colspan = 3;
			table.AddCell(cell);									
			
			cell = new PdfPCell(new Phrase(new Chunk("Cidade/Estado:", FontFactory.GetFont(BaseFont.HELVETICA, 9))));
			cell.BorderWidth = 0;
			cell.HorizontalAlignment = Element.ALIGN_RIGHT;
			table.AddCell(cell);
			
			cell = new PdfPCell(new Phrase(new Chunk(cab2.cidade + "/" + cab2.estado, FontFactory.GetFont(BaseFont.HELVETICA, 9))));
			cell.BorderWidth = 0;
			cell.Colspan = 3;
			table.AddCell(cell);								
			
			cell = new PdfPCell(new Phrase(new Chunk("CNPJ/CPF", FontFactory.GetFont(BaseFont.HELVETICA, 9))));
			cell.BorderWidth = 0;
			cell.HorizontalAlignment = Element.ALIGN_RIGHT;
			table.AddCell(cell);			
			
			cell = new PdfPCell(new Phrase(new Chunk(cab2.cnpj, FontFactory.GetFont(BaseFont.HELVETICA, 9))));
			cell.BorderWidth = 0;
			cell.Colspan = 3;
			table.AddCell(cell);									
			
			cell = new PdfPCell(new Phrase(new Chunk("Inscrição Estadual:", FontFactory.GetFont(BaseFont.HELVETICA, 9))));
			cell.BorderWidth = 0;
			cell.HorizontalAlignment = Element.ALIGN_RIGHT;
			table.AddCell(cell);
			
			cell = new PdfPCell(new Phrase(new Chunk(cab2.ie, FontFactory.GetFont(BaseFont.HELVETICA, 9))));
			cell.BorderWidth = 0;
			cell.Colspan = 3;
			table.AddCell(cell);			
						
			doc.Add(table);						
			
			table = new PdfPTable(1);
			table.WidthPercentage = 100;
			table.SpacingBefore = 30f;
			cell = new PdfPCell(new Phrase(new Chunk("Condições Comerciais", FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 9))));
			cell.BorderWidth = 0;
			cell.BorderWidthBottom = 1;
			table.AddCell(cell);
			doc.Add(table);				
			AdicionaTexto(doc, observacao_orcamento);
			//AdicionaTexto(doc, txt_observacao);
			
		}

		private static float GravaItem(
				Document doc, int colunas,
				short qtd_item,
				float vlr_preco,
				string idt_especial,
				string cod_produto,
				string sub_codigo,
				float per_ipi,
				string des_produto,
				string txt_produto,
				float vlr_semipi,
				string formula_orcamento,
				float per_frete,
				bool imagens, bool resumida, bool detalhada, bool mostrar_valores,
				bool mostrar_medidas, string medidas,
				string generico, string cod_especifico
			)
		{
			Table table = new Table(colunas);
			table.BorderWidth = 0;
			table.WidthPercentage = 100;			
			
			if (!idt_especial.Equals("S"))
				Globais.CalculaFormula(ref vlr_preco, formula_orcamento, per_ipi, per_frete, 0);
			vlr_semipi = vlr_preco;
			//Globais.CalculaFormula(ref vlr_semipi, formula_orcamento, 0, per_frete, 0);
			Cell cell;
			
			int numcols = 0;			
			int numcolsantes = 0;
			seq_item++;
			cell = new Cell(new Phrase(new Chunk(seq_item.ToString(), FontFactory.GetFont(BaseFont.HELVETICA, 9))));
			cell.BorderWidth = 0;
			//cell.BorderWidthBottom = 1;
			//cell.UseBorderPadding = true;
			cell.Rowspan = 2;
			table.AddCell(cell);
			numcols += cell.Colspan;
			
			if (imagens)
			{
				string imagem;
				if (!Globais.sUsuario.Equals("web"))				
					imagem = "imagens\\" + cod_produto + sub_codigo + ".jpg";
				else {
					imagem = "imagens/" + cod_produto + sub_codigo + ".jpg";
					Console.WriteLine(imagem);
				}
				try	{
					Image img = Image.GetInstance(imagem);
					float w=img.Width;
					float h=img.Height;
					while ((w > 100) || (h > 100)) {
						w *= 0.9F;
						h *= 0.9F;
					}
					img.ScaleAbsolute(w, h);
					Chunk chunk = new Chunk(img, 0, 0);
					cell = new Cell(new Paragraph(chunk));					
				}
				catch (Exception e) {
					Console.WriteLine("erro " + e.Message);
					cell = new Cell(new Phrase(new Chunk("", FontFactory.GetFont(BaseFont.HELVETICA, 9))));
				}
				cell.BorderWidth = 0;
				cell.Colspan = 2;
				cell.Rowspan = 2;
				//cell.BorderWidthBottom = 1;
				//cell.UseBorderPadding = true;
				table.AddCell(cell);
				numcols += cell.Colspan;
			}
				
			cell = new Cell(new Phrase(new Chunk(qtd_item.ToString(), FontFactory.GetFont(BaseFont.HELVETICA, 9))));
			cell.BorderWidth = 0;
			//cell.BorderWidthBottom = 1;
			table.AddCell(cell);
			numcolsantes = numcols;
			numcols += cell.Colspan;
				
			cell = new Cell(new Phrase(new Chunk(cod_produto, FontFactory.GetFont(BaseFont.HELVETICA, 9))));
			cell.BorderWidth = 0;
			cell.Colspan = 1;
			//cell.BorderWidthBottom = 1;
			table.AddCell(cell);				
			numcols += cell.Colspan;			
				
			if (generico.Equals("S"))
				cell = new Cell(new Phrase(new Chunk(cod_especifico, FontFactory.GetFont(BaseFont.HELVETICA, 9))));
			else
				cell = new Cell(new Phrase(new Chunk(sub_codigo, FontFactory.GetFont(BaseFont.HELVETICA, 9))));
			cell.BorderWidth = 0;
			cell.Colspan = 1;
			//cell.BorderWidthBottom = 1;
			table.AddCell(cell);				
			numcols += cell.Colspan;
				
			if (mostrar_valores)
			{
				cell = new Cell(new Phrase(new Chunk(vlr_semipi.ToString("###,###,##0.00"), FontFactory.GetFont(BaseFont.HELVETICA, 9))));
				cell.BorderWidth = 0;
				cell.Colspan = 1;
				//cell.BorderWidthBottom = 1;
				cell.HorizontalAlignment = Element.ALIGN_RIGHT;
				table.AddCell(cell);			
				numcols += cell.Colspan;				
				
				cell = new Cell(new Phrase(new Chunk((vlr_semipi * qtd_item).ToString("###,###,##0.00"), FontFactory.GetFont(BaseFont.HELVETICA, 9))));
				cell.BorderWidth = 0;
				cell.Colspan = 1;
				//cell.BorderWidthBottom = 1;
				cell.HorizontalAlignment = Element.ALIGN_RIGHT;
				table.AddCell(cell);
				numcols += cell.Colspan;
			}

			if (resumida && detalhada)
			{
				cell = new Cell(new Phrase(new Chunk(txt_produto, FontFactory.GetFont(BaseFont.HELVETICA, 9))));
				cell.BorderWidth = 0;
				cell.Colspan = colunas;
				//cell.BorderWidthBottom = 1;
				table.AddCell(cell);				
				numcols += cell.Colspan;
			}
			
			/*
			cell = new Cell(new Phrase(new Chunk("", FontFactory.GetFont(BaseFont.HELVETICA, 9))));
			cell.BorderWidth = 0;
			cell.Colspan = numcolsantes;
			cell.BorderWidthBottom = 1;
			table.AddCell(cell);	
			*/				
			
			string texto = resumida ? des_produto : txt_produto;
			if (mostrar_medidas && (medidas.Trim().Length > 0))
				texto += "\r\nDimensões: " + medidas;
			cell = new Cell(new Phrase(new Chunk(texto, FontFactory.GetFont(BaseFont.HELVETICA, 9))));
			cell.BorderWidth = 0;
			cell.Colspan = numcols - numcolsantes;
			//cell.BorderWidthBottom = 1;
			//cell.UseBorderPadding = true;
			table.AddCell(cell);		

			cell = new Cell(new Phrase(new Chunk("______________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________", FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 9))));
			cell.BorderWidth = 0;
			cell.Colspan = numcols;
			cell.NoWrap = true;
			//FIXME cell.BorderWidthBottom = 1;
			//FIXME cell.UseBorderPadding = true;
			table.AddCell(cell);
			
			doc.Add(table);
			return vlr_semipi * qtd_item;
		}
		
		
		private static void GeraItensArea(Document doc, string cod_fornecedor, DateTime dat_orcamento, short cod_orcamento, string cod_area, string cod_caracteristica, 
		                                  bool imagens, bool resumida, bool detalhada, bool mostrar_valores, bool consolidar_itens, bool mostrar_medidas)
		{
			doc.Add(new Phrase(new Chunk("Área: " + cod_area, FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 9))));
				
			int colunas=4;
			if (imagens) colunas += 2;
			if (mostrar_valores) colunas += 2;
			
			Table table = new Table(colunas);
			table.BorderWidth = 0;
			table.WidthPercentage = 100;
			Cell cell;
			
			string order="";
			if (!consolidar_itens)
				order = "order by i.seq_item";
			else
				order = "order by p.cod_produto,p.sub_codigo";
			
			FbCommand cmd =  new FbCommand("select i.qtd_item," +
			                               "i.vlr_preco," +
			                               "i.idt_especial," +
			                     			"p.cod_produto, " +
			                     			"p.sub_codigo, " +
			                     			"p.per_ipi, " +
			                     			"i.des_produto, " +
			                     			"i.txt_produto, " +
			                     			"i.des_medidas, " +
			                     			"p.idt_generico, " +
			                     			"i.cod_especificos " +
			                     "from itens i " +
			                     "inner join produtos p " +
			                     "on p.COD_PARCEIRO=i.COD_FORNECEDOR and p.COD_PRODUTO=i.COD_PRODUTO and p.SUB_CODIGO=i.SUB_CODIGO " +
			                     "where i.cod_fornecedor='" + cod_fornecedor + "' and " +
				                 "      i.dat_orcamento='" + dat_orcamento.ToString("M/d/yyyy") + "' and " +
				                 "      i.cod_orcamento=" + cod_orcamento + " and " +
				                 "      i.cod_area='" + cod_area + "' " +		
				                 order,
			                     Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			
			cCaracteristicas caracteristicas = new cCaracteristicas();
			string formula_orcamento = caracteristicas.Formula(cod_fornecedor, cod_caracteristica);
			float per_frete = cCaracteristicas.Frete(cod_fornecedor, cod_caracteristica);
			float total = 0;
			
			short qtd_consolidado=0;			
			float vlr_preco_ant = 0;
			string idt_especial_ant = "";
			string cod_produto_ant  = "";
			string sub_codigo_ant  = "";
			float per_ipi_ant = 0;
			string des_produto_ant = "";
			string txt_produto_ant = "";
			string medidas_ant = "";
			float vlr_semipi_ant = 0;
			string idt_generico_ant = "";
			string cod_especificos_ant = "";
			
			while (reader.Read()) {
				short qtd_item = reader.GetInt16(0);
				float vlr_preco = reader.GetFloat(1);
				string idt_especial = reader.GetString(2).Trim();
				string cod_produto  = reader.GetString(3).Trim();
				string sub_codigo  = reader.GetString(4).Trim();
				float per_ipi = reader.GetFloat(5);
				string des_produto = reader.GetString(6).Trim();
				string txt_produto = reader.GetString(7).Trim();
				string medidas = reader.GetString(8).Trim();
				float vlr_semipi = vlr_preco;
				string idt_generico = reader.GetString(9).Trim();
				string cod_especificos = reader.GetString(10).Trim();
				if (!consolidar_itens)
					total += GravaItem(doc, colunas, qtd_item, vlr_preco, idt_especial, cod_produto, sub_codigo, per_ipi, des_produto, txt_produto, vlr_semipi,
					                   formula_orcamento, per_frete, imagens, resumida, detalhada, mostrar_valores, mostrar_medidas, medidas,
					                  idt_generico, cod_especificos);
				else
				{
					if ((qtd_consolidado > 0) && (!cod_produto.Equals(cod_produto_ant) || !sub_codigo.Equals(sub_codigo_ant)))
					{
						total += GravaItem(doc, colunas, qtd_consolidado, vlr_preco_ant, idt_especial_ant, cod_produto_ant, sub_codigo_ant, per_ipi_ant, des_produto_ant, txt_produto_ant, vlr_semipi_ant,
				    	              formula_orcamento, per_frete, imagens, resumida, detalhada, mostrar_valores, mostrar_medidas, medidas_ant,
				    	             idt_generico_ant, cod_especificos_ant);
						qtd_consolidado = 0;
					}
					qtd_consolidado += qtd_item;
					vlr_preco_ant = vlr_preco;
					idt_especial_ant = idt_especial;
					cod_produto_ant = cod_produto;
					sub_codigo_ant = sub_codigo;
					per_ipi_ant = per_ipi;
					des_produto_ant = des_produto;
					txt_produto_ant = txt_produto;
					medidas_ant = medidas;
					vlr_semipi_ant = vlr_semipi;
					idt_generico_ant = idt_generico;
					cod_especificos_ant = cod_especificos;
				}
			}
			if (consolidar_itens && (qtd_consolidado > 0))
			{
				total += GravaItem(doc, colunas, qtd_consolidado, vlr_preco_ant, idt_especial_ant, cod_produto_ant, sub_codigo_ant, per_ipi_ant, des_produto_ant, txt_produto_ant, vlr_semipi_ant,
									formula_orcamento, per_frete, imagens, resumida, detalhada, mostrar_valores, mostrar_medidas, medidas_ant,
								idt_generico_ant, cod_especificos_ant);
			}
			reader.Close();			
			total_itens += total;

			if (mostrar_valores)
			{
				cell = new Cell(new Phrase(new Chunk("", FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 9))));
				cell.BorderWidth = 0;
				cell.Colspan = colunas - 2;
				//FIXME cell.BorderWidthBottom = 1;
				//FIXME cell.UseBorderPadding = true;
				table.AddCell(cell);
			
				cell = new Cell(new Phrase(new Chunk("Sub-Total:", FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 9))));
				cell.BorderWidth = 0;
				cell.Colspan = 1;
				//FIXME cell.BorderWidthBottom = 1;
				//FIXME cell.UseBorderPadding = true;
				table.AddCell(cell);
						
				cell = new Cell(new Phrase(new Chunk(total.ToString("###,###,##0.00"), FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 9))));
				cell.BorderWidth = 0;
				cell.Colspan = 1;
				//FIXME cell.BorderWidthBottom = 1;
				//FIXME cell.UseBorderPadding = true;
				cell.HorizontalAlignment = Element.ALIGN_RIGHT;			
				table.AddCell(cell);

				cell = new Cell(new Phrase(new Chunk("______________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________", FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 9))));
				cell.BorderWidth = 0;
				cell.Colspan = colunas;
				cell.NoWrap = true;
				//FIXME cell.BorderWidthBottom = 1;
				//FIXME cell.UseBorderPadding = true;
				table.AddCell(cell);
			}
			
			doc.Add(table);					
		}
		
		private static void GeraItens(Document doc, string cod_fornecedor, DateTime dat_orcamento, short cod_orcamento, string cod_caracteristica,
		                              bool imagens, bool resumida, bool detalhada, bool mostrar_valores, bool consolidar_itens, bool mostrar_medidas, bool total_prod_serv)
		{
			/*
			if (saltaPagina) {
				doc.NewPage();
				saltaPagina = false;
			}
			else saltaPagina = true;			
			*/
			doc.NewPage();
			
			int colunas=4;
			if (imagens) colunas += 2;
			if (mostrar_valores) colunas += 2;
			
			PdfPTable table = new PdfPTable(colunas);
			table.WidthPercentage = 100;
			PdfPCell cell;

			cell = new PdfPCell(new Phrase(new Chunk("Item", FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 9))));
			cell.BorderWidth = 0;
			table.AddCell(cell);
			
			if (imagens)
			{
				cell = new PdfPCell(new Phrase(new Chunk("", FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 9))));
				cell.BorderWidth = 0;
				cell.Colspan = 2;
				table.AddCell(cell);
			}
			
			cell = new PdfPCell(new Phrase(new Chunk("Quant.", FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 9))));
			cell.BorderWidth = 0;
			table.AddCell(cell);
			
			cell = new PdfPCell(new Phrase(new Chunk("Modelo", FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 9))));
			cell.BorderWidth = 0;
			table.AddCell(cell);

			cell = new PdfPCell(new Phrase(new Chunk("", FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 9))));
			cell.BorderWidth = 0;
			table.AddCell(cell);
/*
			cell = new PdfPCell(new Phrase(new Chunk("Descrição", FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 9))));
			cell.BorderWidth = 0;
			cell.Colspan = 3;
			table.AddCell(cell);
*/
			if (mostrar_valores)
			{
				cell = new PdfPCell(new Phrase(new Chunk("Unitário", FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 9))));
				cell.BorderWidth = 0;
				table.AddCell(cell);
			
				cell = new PdfPCell(new Phrase(new Chunk("Total", FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 9))));
				cell.BorderWidth = 0;
				table.AddCell(cell);						
			}
			
			doc.Add(table);										
			
			doc.Add(new Paragraph(""));
			
			FbCommand cmd =  new FbCommand("select distinct i.cod_area " +
			                     "from itens i " +
			                     "inner join orcamentos o " +
			                     "on o.cod_fornecedor=i.cod_fornecedor " +
			                     "and o.dat_orcamento=i.dat_orcamento " +
			                     "and o.cod_orcamento=i.cod_orcamento " +
			                     "where i.cod_fornecedor='" + cod_fornecedor + "' and " +
				                 "      i.dat_orcamento='" + dat_orcamento.ToString("M/d/yyyy") + "' and " +
				                 "      i.cod_orcamento=" + cod_orcamento + " " +
				                 "order by i.cod_area,i.seq_item",
			                     Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			while (reader.Read())
				GeraItensArea(doc, cod_fornecedor, dat_orcamento, cod_orcamento, reader.GetString(0).Trim(), cod_caracteristica, imagens, resumida, detalhada, mostrar_valores, consolidar_itens, mostrar_medidas);
			reader.Close();
		}
		
		private static void GeraTotal(PdfWriter writer, Document doc, string txt_observacao, string observacao_orcamento, string cod_fornecedor, DateTime dat_orcamento, short cod_orcamento, string cod_caracteristica, float vlr_desconto, bool total_prod_serv) {						
			int pagina1 = writer.PageNumber;
			PdfPTable table0 = new PdfPTable(1);
			table0.WidthPercentage = 100;
			table0.KeepTogether = true;
			table0.DefaultCell.BorderWidth = 0;
			
			PdfPTable table = new PdfPTable(1);
			table.WidthPercentage = 100;
			PdfPCell cell = new PdfPCell(new Phrase(new Chunk("Total da Proposta", FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 9))));
			cell.BorderWidth = 0;
			//FIXME cell.BorderWidthBottom = 1;
			table.AddCell(cell);
			table0.AddCell(table);
			
			table = new PdfPTable(4);
			table.WidthPercentage = 100;
			
			string servico="";
			cCaracteristicas caracteristicas = new cCaracteristicas();
			float dif = caracteristicas.DiferencaFormulas(cod_fornecedor, cod_caracteristica, dat_orcamento, cod_orcamento, ref servico);
			//float total_produtos = (dif > 0) ? (total_itens - dif) : (total_itens - vlr_desconto);
			//float total_servicos = (dif > 0) ? (dif - vlr_desconto) : 0;
			float total_produtos = (dif > 0) ? (total_itens - dif) : total_itens;
			float total_servicos = (dif > 0) ? dif : 0;	

			if (total_prod_serv)
			{
				if (total_servicos > 0)
				{
					cell = new PdfPCell(new Phrase(new Chunk("Total Serviço:", FontFactory.GetFont(BaseFont.HELVETICA, 9))));
					cell.BorderWidth = 0;
					cell.HorizontalAlignment = Element.ALIGN_RIGHT;
					table.AddCell(cell);
			
					cell = new PdfPCell(new Phrase(new Chunk(total_servicos.ToString("###,###,##0.00"), FontFactory.GetFont(BaseFont.HELVETICA, 9))));
					cell.BorderWidth = 0;
					cell.Colspan = 3;
					table.AddCell(cell);				

					cell = new PdfPCell(new Phrase(new Chunk("Total Produto:", FontFactory.GetFont(BaseFont.HELVETICA, 9))));
					cell.BorderWidth = 0;
					cell.HorizontalAlignment = Element.ALIGN_RIGHT;
					table.AddCell(cell);
			
					cell = new PdfPCell(new Phrase(new Chunk(total_produtos.ToString("###,###,##0.00"), FontFactory.GetFont(BaseFont.HELVETICA, 9))));
					cell.BorderWidth = 0;
					cell.Colspan = 3;
					table.AddCell(cell);
				}
			
				if (vlr_desconto != 0)
				{
					cell = new PdfPCell(new Phrase(new Chunk("Desconto(-):", FontFactory.GetFont(BaseFont.HELVETICA, 9))));
					cell.BorderWidth = 0;
					cell.HorizontalAlignment = Element.ALIGN_RIGHT;
					table.AddCell(cell);
						
					cell = new PdfPCell(new Phrase(new Chunk(vlr_desconto.ToString("###,###,##0.00"), FontFactory.GetFont(BaseFont.HELVETICA, 9))));
					cell.BorderWidth = 0;
					cell.Colspan = 3;
					table.AddCell(cell);
				}
				
				if (vlr_desconto > 0) {								
					if (total_servicos > 0) {
						cell = new PdfPCell(new Phrase(new Chunk("Total Serviço:", FontFactory.GetFont(BaseFont.HELVETICA, 9))));
						cell.BorderWidth = 0;
						cell.HorizontalAlignment = Element.ALIGN_RIGHT;
						table.AddCell(cell);
			
						cell = new PdfPCell(new Phrase(new Chunk((total_servicos-vlr_desconto).ToString("###,###,##0.00"), FontFactory.GetFont(BaseFont.HELVETICA, 9))));
						cell.BorderWidth = 0;
						cell.Colspan = 3;
						table.AddCell(cell);									
					}
					else {
						cell = new PdfPCell(new Phrase(new Chunk("Total:", FontFactory.GetFont(BaseFont.HELVETICA, 9))));
						cell.BorderWidth = 0;
						cell.HorizontalAlignment = Element.ALIGN_RIGHT;
						table.AddCell(cell);
			
						cell = new PdfPCell(new Phrase(new Chunk((total_produtos-vlr_desconto).ToString("###,###,##0.00"), FontFactory.GetFont(BaseFont.HELVETICA, 9))));
						cell.BorderWidth = 0;
						cell.Colspan = 3;
						table.AddCell(cell);
					}
				}
			}
			else
			{
				cell = new PdfPCell(new Phrase(new Chunk("Total Proposta:", FontFactory.GetFont(BaseFont.HELVETICA, 9))));
				cell.BorderWidth = 0;
				cell.HorizontalAlignment = Element.ALIGN_RIGHT;
				table.AddCell(cell);
			
				cell = new PdfPCell(new Phrase(new Chunk((total_produtos+total_servicos).ToString("###,###,##0.00"), FontFactory.GetFont(BaseFont.HELVETICA, 9))));
				cell.BorderWidth = 0;
				cell.Colspan = 3;
				table.AddCell(cell);
					
				if (vlr_desconto != 0)
				{
					cell = new PdfPCell(new Phrase(new Chunk("Desconto(-):", FontFactory.GetFont(BaseFont.HELVETICA, 9))));
					cell.BorderWidth = 0;
					cell.HorizontalAlignment = Element.ALIGN_RIGHT;
					table.AddCell(cell);			
						
					cell = new PdfPCell(new Phrase(new Chunk(vlr_desconto.ToString("###,###,##0.00"), FontFactory.GetFont(BaseFont.HELVETICA, 9))));
					cell.BorderWidth = 0;
					cell.Colspan = 3;
					table.AddCell(cell);			
				}
			}

			cell = new PdfPCell(new Phrase(new Chunk("Total Geral:", FontFactory.GetFont(BaseFont.HELVETICA, 9))));
			cell.BorderWidth = 0;
			cell.HorizontalAlignment = Element.ALIGN_RIGHT;
			table.AddCell(cell);
			
			cell = new PdfPCell(new Phrase(new Chunk((total_produtos+total_servicos-vlr_desconto).ToString("###,###,##0.00"), FontFactory.GetFont(BaseFont.HELVETICA, 9))));
			cell.BorderWidth = 0;
			cell.Colspan = 3;
			table.AddCell(cell);
			table0.AddCell(table);
			
			doc.Add(table0);
			/*
			int pagina2 = writer.PageNumber;
			if (pagina1 == pagina2) {
				if (saltaPagina) {
					doc.NewPage();
					saltaPagina = false;
				}
				else saltaPagina = true;
			}
			*/
			
			/*
			table = new PdfPTable(1);
			table.WidthPercentage = 100;
			cell = new PdfPCell(new Phrase(new Chunk("Observações Gerais", FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 10))));
			cell.BorderWidth = 0;
			cell.BorderWidthBottom = 1;
			cell.BorderWidthTop = 1;
			table.AddCell(cell);
			doc.Add(table);				
			AdicionaTexto(doc, observacao_orcamento);									
			*/
			
			/*
			table = new PdfPTable(1);
			table.WidthPercentage = 100;
			cell = new PdfPCell(new Phrase(new Chunk("Condições Comerciais", FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 9))));
			cell.BorderWidth = 0;
			//FIXME cell.BorderWidthBottom = 1;
			//FIXME cell.BorderWidthTop = 1;
			table.AddCell(cell);
			doc.Add(table);				
			AdicionaTexto(doc, observacao_orcamento);
			//AdicionaTexto(doc, txt_observacao);
			*/
		}

		private static void GeraTitulo(Document doc, string titulo) {
			PdfPTable table = new PdfPTable(1);
			table.WidthPercentage = 100;
			PdfPCell cell = new PdfPCell(new Phrase(new Chunk(titulo.ToUpper(), FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 9))));
			cell.BorderWidth = 0;
			cell.BorderWidthBottom = 1;
			table.AddCell(cell);
			doc.Add(table);				
		}
		
		private static void GeraInformacoesFornecimento(Document doc, string cod_informacao) {
			string des_informacao = null;

			FbCommand cmd = new FbCommand(
					"select des_informacao " +
					"from informacoes_fornecimento " +
					"where cod_informacao='" + cod_informacao + "'",
					Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			if (reader.Read())
				des_informacao = !reader.IsDBNull(0) ? reader.GetString(0).Trim() : null;
			reader.Close();
			
			if (des_informacao == null) {
				return;
			}
			
			/*
			if (saltaPagina) {
				doc.NewPage();
				saltaPagina = false;
			}
			else saltaPagina = true;						
			*/
			doc.NewPage();
			
			GeraTitulo(doc, "Informações Gerais do Fornecimento");
			AdicionaTexto(doc, des_informacao);			
		}
		
		private static void GeraTermoGarantia(Document doc, string cod_termo) {
			
			FbCommand cmd = new FbCommand(
					"select des_termo " +
					"from termos_garantia " +
					"where cod_termo='" + cod_termo + "'",
					Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			string des_termo=null;
			if (reader.Read())
				des_termo = !reader.IsDBNull(0) ? reader.GetString(0).Trim() : null;
			reader.Close();						

			if (des_termo == null) {
				return;
			}

			/*
			if (saltaPagina) {
				doc.NewPage();
				saltaPagina = false;
			}
			else saltaPagina = true;			
			*/
			doc.NewPage();
			
			GeraTitulo(doc, "Termo de Garantia");
			AdicionaTexto(doc, des_termo);					
		}
		
		private static void GeraCondicoesMontagem(Document doc, string cod_condicao) {

			FbCommand cmd = new FbCommand(
					"select des_condicao " +
					"from condicoes_montagem " +
					"where cod_condicao='" + cod_condicao + "'",
					Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			string des_condicao=null;
			if (reader.Read())
				des_condicao = !reader.IsDBNull(0) ? reader.GetString(0).Trim() : null;
			reader.Close();						
			
			if (des_condicao == null) {
				return;
			}

			/*
			if (saltaPagina) {
				doc.NewPage();
				saltaPagina = false;
			}
			else saltaPagina = true;			
			*/
			doc.NewPage();
			
			GeraTitulo(doc, "Condições para Montagem");
			AdicionaTexto(doc, des_condicao);									
		}
		
		private static void GeraTermoAprovacao(Document doc, string cod_termo) {

			FbCommand cmd = new FbCommand(
					"select des_termo " +
					"from termos_aprovacao " +
					"where cod_termo='" + cod_termo + "'",
					Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			string des_termo=null;
			if (reader.Read())
				des_termo = !reader.IsDBNull(0) ? reader.GetString(0).Trim() : null;
			reader.Close();
			
			if (des_termo == null) {
				return;
			}

			/*
			if (saltaPagina) {
				doc.NewPage();
				saltaPagina = false;
			}
			else saltaPagina = true;
			*/
			doc.NewPage();

			GeraTitulo(doc, "Termo de Aprovação e Aceite");
			AdicionaTexto(doc, des_termo);						
			
			PdfPTable table = new PdfPTable(5);
			table.WidthPercentage = 100;
			
			PdfPCell cell = new PdfPCell(new Phrase(new Chunk("Cliente", FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 9))));
			cell.BorderWidth = 0;
			cell.BorderWidthTop = 1;
			cell.HorizontalAlignment = Element.ALIGN_RIGHT;
			table.AddCell(cell);			
			
			cell = new PdfPCell(new Phrase(new Chunk(nom_cliente, FontFactory.GetFont(BaseFont.HELVETICA, 9))));
			cell.BorderWidth = 0;
			cell.BorderWidthTop = 1;
			cell.Colspan = 4;
			table.AddCell(cell);
			
			cell = new PdfPCell(new Phrase(new Chunk("", FontFactory.GetFont(BaseFont.HELVETICA, 9))));
			cell.BorderWidth = 0;
			cell.Colspan = 5;
			table.AddCell(cell);						
			table.AddCell(cell);						
			table.AddCell(cell);
			table.AddCell(cell);						
			
			cell = new PdfPCell(new Phrase(new Chunk("Responsável", FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 9))));
			cell.BorderWidth = 0;
			cell.HorizontalAlignment = Element.ALIGN_RIGHT;
			table.AddCell(cell);
			
			cell = new PdfPCell(new Phrase(new Chunk("__________________________________________________", FontFactory.GetFont(BaseFont.HELVETICA, 9))));
			cell.BorderWidth = 0;
			cell.Colspan = 4;
			table.AddCell(cell);
			
			cell = new PdfPCell(new Phrase(new Chunk("", FontFactory.GetFont(BaseFont.HELVETICA, 9))));
			cell.BorderWidth = 0;
			cell.Colspan = 5;
			table.AddCell(cell);						
			table.AddCell(cell);						
			table.AddCell(cell);			
			table.AddCell(cell);						
			
			cell = new PdfPCell(new Phrase(new Chunk("Cargo", FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 9))));
			cell.BorderWidth = 0;
			cell.HorizontalAlignment = Element.ALIGN_RIGHT;
			table.AddCell(cell);
			
			cell = new PdfPCell(new Phrase(new Chunk("__________________________________________________", FontFactory.GetFont(BaseFont.HELVETICA, 9))));
			cell.BorderWidth = 0;
			cell.Colspan = 4;
			table.AddCell(cell);					
			
			cell = new PdfPCell(new Phrase(new Chunk("", FontFactory.GetFont(BaseFont.HELVETICA, 9))));
			cell.BorderWidth = 0;
			cell.Colspan = 5;
			table.AddCell(cell);						
			table.AddCell(cell);						
			table.AddCell(cell);
			table.AddCell(cell);						
			
			cell = new PdfPCell(new Phrase(new Chunk("Assinatura", FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 9))));
			cell.BorderWidth = 0;
			cell.HorizontalAlignment = Element.ALIGN_RIGHT;
			table.AddCell(cell);
			
			cell = new PdfPCell(new Phrase(new Chunk("__________________________________________________", FontFactory.GetFont(BaseFont.HELVETICA, 9))));
			cell.BorderWidth = 0;
			cell.Colspan = 4;
			table.AddCell(cell);					
			
			cell = new PdfPCell(new Phrase(new Chunk("", FontFactory.GetFont(BaseFont.HELVETICA, 9))));
			cell.BorderWidth = 0;
			cell.Colspan = 5;
			table.AddCell(cell);						
			table.AddCell(cell);						
			table.AddCell(cell);			
			table.AddCell(cell);						
						
			doc.Add(table);			
			table = new PdfPTable(5);
			table.WidthPercentage = 100;			
			
			cell = new PdfPCell(new Phrase(new Chunk("Representante", FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 9))));
			cell.BorderWidth = 0;
			cell.BorderWidthTop = 1;
			cell.HorizontalAlignment = Element.ALIGN_RIGHT;
			table.AddCell(cell);
			
			cell = new PdfPCell(new Phrase(new Chunk(Globais.sFilial, FontFactory.GetFont(BaseFont.HELVETICA, 9))));
			cell.BorderWidth = 0;
			cell.BorderWidthTop = 1;
			cell.Colspan = 4;
			table.AddCell(cell);
			
			cell = new PdfPCell(new Phrase(new Chunk("Consultor de vendas", FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 9))));
			cell.BorderWidth = 0;
			cell.HorizontalAlignment = Element.ALIGN_RIGHT;
			table.AddCell(cell);
			
			cell = new PdfPCell(new Phrase(new Chunk(nom_vendedor, FontFactory.GetFont(BaseFont.HELVETICA, 9))));
			cell.BorderWidth = 0;
			cell.Colspan = 4;
			table.AddCell(cell);				

			cell = new PdfPCell(new Phrase(new Chunk("e-mail", FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 9))));
			cell.BorderWidth = 0;
			cell.HorizontalAlignment = Element.ALIGN_RIGHT;
			table.AddCell(cell);
			
			cell = new PdfPCell(new Phrase(new Chunk(email_vendedor, FontFactory.GetFont(BaseFont.HELVETICA, 9))));
			cell.BorderWidth = 0;
			cell.Colspan = 4;
			table.AddCell(cell);				
			
			doc.Add(table);									
		}		
		
		private static void DadosRodape(string cod_fornecedor, bool endereco_filial) {
			FbCommand cmd;
			if (endereco_filial)
				cmd = new FbCommand(
						"select nom_filial, " +
						"       des_logradouro, " + 
						"       nro_endereco, " + 			                     
						"       des_complemento, " + 			                     
						"       nro_cep, " + 			                     
						"       nro_fone1, " + 			                     
						"       nro_fax, " + 			                     
						"       des_email " + 			                     			                     
						"from FILIAIS " +
						"where cod_filial='" + Globais.sFilial + "'",
						Globais.bd);
			else
				cmd = new FbCommand(				
						"select NOM_PARCEIRO, " +
						"       des_logradouro, " + 
						"       nro_endereco, " + 			                     
						"       des_complemento, " + 			                     
						"       nro_cep, " + 			                     
						"       nro_fone1, " + 			                     
						"       nro_fax, " + 			                     
						"       des_email " + 			                     			                     
						"from parceiros " +
						"where cod_parceiro='" + cod_fornecedor + "'",
						Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			if (reader.Read())
			{
				if (endereco_filial)
					filial = Globais.sFilial;
				else
					filial = !reader.IsDBNull(0) ? reader.GetString(0).Trim() : "";
				rua = !reader.IsDBNull(1) ? reader.GetString(1).Trim() : "";
				nro = !reader.IsDBNull(2) ? reader.GetString(2).Trim() : "";
				complemento = !reader.IsDBNull(3) ? reader.GetString(3).Trim() : "";
				cep = !reader.IsDBNull(4) ? reader.GetString(4).Trim() : "";
				fone = !reader.IsDBNull(5) ? reader.GetString(5).Trim() : "";
				fax = !reader.IsDBNull(6) ? reader.GetString(6).Trim() : "";
				email = !reader.IsDBNull(7) ? reader.GetString(7).Trim() : "";
			}
			reader.Close();			
		}
		
		private static string Rodape() {
			return
				filial + " - " +
				rua + "," + 
				nro + " " + 
				complemento + " - " +
				"CEP: " + CEP.PoeEdicao(cep) + 
				" - Fone: " + FONE.PoeEdicao(fone) + 
				" - Fax: " + FONE.PoeEdicao(fax) + " - " +
				email + " ";				
		}		

		public static void Gera(
			string cod_fornecedor, DateTime dat_orcamento, short cod_orcamento, string cod_caracteristica, string cod_cliente, string observacao_orcamento, float vlr_desconto,
			bool introducao, bool informacoes_fornecimento, bool termo_garantia, bool condicoes_montagem, bool termo_aprovacao,
			bool imagens, bool resumida, bool detalhada, bool endereco_filial, bool mostrar_valores, bool consolidar_itens, bool mostrar_medidas, bool total_prod_serv)
		{
			FileStream fs = new FileStream("proposta_comercial.pdf", FileMode.Create);
			Document doc = new Document(PageSize.LETTER);
			PdfWriter writer = PdfWriter.GetInstance(doc, fs);
			writer.PageEvent = new Eventos();
			float p1 = writer.GetVerticalPosition(false);
			//saltaPagina = false;
						
			bool aberto = false;
					
			total_itens=0;
			DadosRodape(cod_fornecedor, endereco_filial);
			DadosCabec.cod_fornecedor = cod_fornecedor;
			DadosCabec.dat_orcamento = dat_orcamento;
			DadosCabec.cod_orcamento = cod_orcamento;
			DadosCabec.cod_cliente = cod_cliente;
			FbCommand cmd = new FbCommand(
					"select txt_observacao, " +
					"       cod_introducao, " + 
					"       cod_informacao_fornecimento, " + 			                     
					"       cod_termo_garantia, " + 			                     
					"       cod_condicao_montagem, " + 			                     
					"       cod_termo_aprovacao " + 			                     
					"from caracteristicas " +
					"where cod_fornecedor='" + cod_fornecedor + "' and " +
					"      cod_caracteristica='" + cod_caracteristica + "'",
					Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			string txt_observacao="";
			string cod_introducao="";
			string cod_informacao_fornecimento="";
			string cod_termo_garantia="";
			string cod_condicao_montagem="";
			string cod_termo_aprovacao="";
			if (reader.Read())
			{
				txt_observacao = !reader.IsDBNull(0) ? reader.GetString(0).Trim() : "";
				cod_introducao = !reader.IsDBNull(1) ? reader.GetString(1).Trim() : "";
				cod_informacao_fornecimento = !reader.IsDBNull(2) ? reader.GetString(2).Trim() : "";
				cod_termo_garantia = !reader.IsDBNull(3) ? reader.GetString(3).Trim() : "";
				cod_condicao_montagem = !reader.IsDBNull(4) ? reader.GetString(4).Trim() : "";
				cod_termo_aprovacao = !reader.IsDBNull(5) ? reader.GetString(5).Trim() : "";
			}
			reader.Close();						
			HeaderFooter footer = new HeaderFooter(new Phrase(new Chunk(Rodape(), FontFactory.GetFont(BaseFont.HELVETICA, 8))), false);
			footer.Border = iTextSharp.text.Rectangle.TOP_BORDER;
			//doc.Footer = footer;
			if (!aberto)
			{
				doc.Open();
				aberto = true;
			}
			if (introducao) GeraIntroducao(doc, cod_cliente, cod_introducao, cod_fornecedor, dat_orcamento, cod_orcamento, observacao_orcamento);
			GeraItens(doc, cod_fornecedor, dat_orcamento, cod_orcamento, cod_caracteristica, imagens, resumida, detalhada, mostrar_valores, consolidar_itens, mostrar_medidas, total_prod_serv);
			if (mostrar_valores) GeraTotal(writer, doc, txt_observacao, observacao_orcamento, cod_fornecedor, dat_orcamento, cod_orcamento, cod_caracteristica, vlr_desconto, total_prod_serv);
			if (informacoes_fornecimento) GeraInformacoesFornecimento(doc, cod_informacao_fornecimento);
			if (termo_garantia) GeraTermoGarantia(doc, cod_termo_garantia);
			if (condicoes_montagem) GeraCondicoesMontagem(doc, cod_condicao_montagem);
			if (termo_aprovacao) GeraTermoAprovacao(doc, cod_termo_aprovacao);
			if (aberto)
			{
				doc.Close();
				if (!Globais.sUsuario.Equals("web"))				
					System.Diagnostics.Process.Start("proposta_comercial.pdf");
			}			
		}
		
		
		public static void Gera(
			int i, DataGridView dgv,
			//string cod_fornecedor, DateTime dat_orcamento, short cod_orcamento, string cod_caracteristica, string cod_cliente, string observacao_orcamento, float vlr_desconto,
			bool introducao, bool informacoes_fornecimento, bool termo_garantia, bool condicoes_montagem, bool termo_aprovacao,
			bool imagens, bool resumida, bool detalhada, bool endereco_filial, bool mostrar_valores, bool consolidar_itens, bool total_prod_serv, bool mostrar_medidas)
		{			
			string cod_fornecedor = "";
			DateTime dat_orcamento= DateTime.Now;
			short cod_orcamento = 0;
			for (int r=0; r<dgv.Rows.Count; r++)
			{
				DataGridViewRow row = dgv.Rows[r];
				if (i != -1) 
				{
					if (r != i) continue;
				}
				else
				{
					if (!(bool)row.Cells["S"].Value)
					{
						continue;
					}					
				}
				cod_fornecedor = row.Cells["Fornecedor"].Value.ToString().Trim();
				dat_orcamento = DateTime.Parse(row.Cells["Data"].Value.ToString().Trim());
				cod_orcamento = Globais.StrToShort(row.Cells["Cod"].Value.ToString());							
			}
			string pdf = "proposta_comercial.pdf";
			string destino = null;
			if (i != -1) {
				destino = cod_fornecedor + dat_orcamento.Year + dat_orcamento.Month + cod_orcamento + ".pdf";						
				pdf = "c:\\soft\\" + destino;
			}
			FileStream fs = new FileStream(pdf, FileMode.Create);
			Document doc = new Document(PageSize.LETTER);
			PdfWriter writer = PdfWriter.GetInstance(doc, fs);
			writer.PageEvent = new Eventos();
			//saltaPagina = false;
						
			bool aberto = false;
			for (int r=0; r<dgv.Rows.Count; r++)
			{
				DataGridViewRow row = dgv.Rows[r];
				if (i != -1) 
				{
					if (r != i) continue;
				}
				else
				{
					if (!(bool)row.Cells["S"].Value)
					{
						continue;
					}					
				}
				
				cod_fornecedor = row.Cells["Fornecedor"].Value.ToString().Trim();
				dat_orcamento = DateTime.Parse(row.Cells["Data"].Value.ToString().Trim());
				cod_orcamento = Globais.StrToShort(row.Cells["Cod"].Value.ToString());			
				string cod_caracteristica = row.Cells["Característica"].Value.ToString().Trim();
				string cod_cliente = row.Cells["Cliente"].Value.ToString().Trim();
				string cod_contato = row.Cells["Contato"].Value.ToString().Trim();
				string observacao_orcamento = row.Cells["Observação"].Value.ToString().Trim();
				float vlr_desconto = Globais.StrToFloat(row.Cells["Desconto"].Value.ToString().Trim());				
			
				total_itens=0;
				DadosRodape(cod_fornecedor, endereco_filial);
				DadosCabec.cod_fornecedor = cod_fornecedor;
				DadosCabec.dat_orcamento = dat_orcamento;
				DadosCabec.cod_orcamento = cod_orcamento;
				DadosCabec.cod_cliente = cod_cliente;
				
				FbCommand cmd = new FbCommand(
						"select txt_observacao, " +
						"       cod_introducao, " + 
						"       cod_informacao_fornecimento, " + 			                     
						"       cod_termo_garantia, " + 			                     
						"       cod_condicao_montagem, " + 			                     
						"       cod_termo_aprovacao " + 			                     
						"from caracteristicas " +
						"where cod_fornecedor='" + cod_fornecedor + "' and " +
						"      cod_caracteristica='" + cod_caracteristica + "'",
						Globais.bd);
				FbDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
				string txt_observacao="";
				string cod_introducao="";
				string cod_informacao_fornecimento="";
				string cod_termo_garantia="";
				string cod_condicao_montagem="";
				string cod_termo_aprovacao="";
				if (reader.Read())
				{
					txt_observacao = !reader.IsDBNull(0) ? reader.GetString(0).Trim() : "";
					cod_introducao = !reader.IsDBNull(1) ? reader.GetString(1).Trim() : "";
					cod_informacao_fornecimento = !reader.IsDBNull(2) ? reader.GetString(2).Trim() : "";
					cod_termo_garantia = !reader.IsDBNull(3) ? reader.GetString(3).Trim() : "";
					cod_condicao_montagem = !reader.IsDBNull(4) ? reader.GetString(4).Trim() : "";
					cod_termo_aprovacao = !reader.IsDBNull(5) ? reader.GetString(5).Trim() : "";
				}
				reader.Close();						
				
				HeaderFooter footer = new HeaderFooter(new Phrase(new Chunk(Rodape(), FontFactory.GetFont(BaseFont.HELVETICA, 8))), false);
				footer.Border = iTextSharp.text.Rectangle.TOP_BORDER;
				doc.Footer = footer;
				if (!aberto)
				{
					doc.Open();
					aberto = true;
				}
				if (introducao) GeraIntroducao(doc, cod_cliente, cod_introducao, cod_fornecedor, dat_orcamento, cod_orcamento, observacao_orcamento);
				GeraItens(doc, cod_fornecedor, dat_orcamento, cod_orcamento, cod_caracteristica, imagens, resumida, detalhada, mostrar_valores, consolidar_itens, mostrar_medidas, total_prod_serv);
				if (mostrar_valores) GeraTotal(writer, doc, txt_observacao, observacao_orcamento, cod_fornecedor, dat_orcamento, cod_orcamento, cod_caracteristica, vlr_desconto, total_prod_serv);
				if (informacoes_fornecimento) GeraInformacoesFornecimento(doc, cod_informacao_fornecimento);
				if (termo_garantia) GeraTermoGarantia(doc, cod_termo_garantia);
				if (condicoes_montagem) GeraCondicoesMontagem(doc, cod_condicao_montagem);
				if (termo_aprovacao) GeraTermoAprovacao(doc, cod_termo_aprovacao);
			}
			if (aberto)
			{
				doc.Close();
				if (!Globais.sUsuario.Equals("web")) {
					if (destino != null) {
						Transferencia.Salva(pdf, destino);
						Thread.Sleep(3000);
					}
					/*
					MessageBox.Show("PDF gerado com sucesso. Clique para abrir.", "Aviso",
			      	        	MessageBoxButtons.OK, 
			      	        	MessageBoxIcon.Information);	
					*/						
					System.Diagnostics.Process.Start(pdf);
				}
			}
		}
	}
	
	public static class DadosCabec
	{
		public static string cod_fornecedor;
		public static DateTime dat_orcamento;
		public static short cod_orcamento;	
		public static string cod_cliente;
	}
	
	public class Eventos:PdfPageEventHelper {		
		public Eventos() {
		}
		
		public override void OnStartPage(PdfWriter writer, Document doc) {
			PdfPTable table = new PdfPTable(4);
			table.WidthPercentage = 100;
			PdfPCell cell;
			Chunk chunk;
			
			string logo;
			if (!Globais.sUsuario.Equals("web"))				
				logo = "imagens\\logo_rel.jpg";
			else {
				logo = "imagens/logo_rel.jpg";
				Console.WriteLine(logo);
			}
			
			Image img;
			float largura=100F;
			float altura=100F;
			try
			{
				img = Image.GetInstance(logo);
				float w=img.Width;
				float h=img.Height;
				while ((w > largura) || (h > altura))
				{
					w *= 0.9F;
					h *= 0.9F;
				}
				img.ScaleAbsolute(w, h);
				chunk = new Chunk(img, 0, 0);
			}
			catch (Exception e)
			{
				Log.Grava(Globais.sUsuario, "erro:" + e.Message);
				Console.WriteLine("erro " + e.Message);
				chunk = new Chunk("");
			}
			cell = new PdfPCell(new Phrase(chunk));
			cell.PaddingTop = 0;
			cell.BorderWidth = 0;
			cell.BorderWidthBottom = 1;
			table.AddCell(cell);			
			
			cell = new PdfPCell(new Phrase(new Chunk("Proposta Comercial: " + DadosCabec.cod_orcamento + "-" + DadosCabec.dat_orcamento.Month + "/" + DadosCabec.dat_orcamento.Year + "\r\n" + DadosCabec.cod_cliente, FontFactory.GetFont(BaseFont.HELVETICA, 12))));
			cell.PaddingTop = 0;
			cell.BorderWidth = 0;
			cell.BorderWidthBottom = 1;
			cell.VerticalAlignment = Element.ALIGN_MIDDLE;
			cell.HorizontalAlignment = Element.ALIGN_CENTER;
			table.AddCell(cell);			
			
			cell = new PdfPCell(new Phrase(new Chunk("Pag: " + writer.PageNumber.ToString(), FontFactory.GetFont(BaseFont.HELVETICA, 12))));
			cell.PaddingTop = 0;
			cell.BorderWidth = 0;
			cell.BorderWidthBottom = 1;
			cell.VerticalAlignment = Element.ALIGN_MIDDLE;
			cell.HorizontalAlignment = Element.ALIGN_RIGHT;
			table.AddCell(cell);			
			
			string imagem = DadosCabec.cod_fornecedor;
			int pos = imagem.IndexOf(' ');
			if (pos > 0)
				imagem = imagem.Substring(0, pos);
						
			if (!Globais.sUsuario.Equals("web"))				
				logo = "imagens\\" + imagem + ".jpg";
			else {
				Console.WriteLine(logo);
				logo = "imagens/" + imagem + ".jpg";
			}

			try
			{
				img = Image.GetInstance(logo);
				float w=img.Width;
				float h=img.Height;
				while ((w > largura) || (h > altura))
				{
					w *= 0.9F;
					h *= 0.9F;
				}
				img.ScaleAbsolute(w, h);
				chunk = new Chunk(img, 0, 0);
			}
			catch (Exception e)
			{
				Log.Grava(Globais.sUsuario, "erro:" + e.Message);
				Console.WriteLine("erro " + e.Message);
				chunk = new Chunk("");
			}
			cell = new PdfPCell(new Phrase(chunk));
			cell.PaddingTop = 0;
			cell.BorderWidth = 0;
			cell.BorderWidthBottom = 1;
			cell.HorizontalAlignment = Element.ALIGN_RIGHT;			
			table.AddCell(cell);			
			
			doc.Add(table);			
		}				
	}
}
