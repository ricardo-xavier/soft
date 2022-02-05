/*
 * Gera um PDF de um pedido
 * Ricardo Costa Xavier
 * 15/02/09
 */

using System;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Collections;

namespace classes
{
	public class Cabecalho1_Pedido
	{
		public string logo;
		public string fornecedor_pedido;
		public string fornecedor;
		public DateTime data;
		public short orcamento;
		public string condicao_pagto;
		public string transportadora;
		public float valor;
		public int nro_pedido;

		public Cabecalho1_Pedido()
		{
		}
	}
	
	public class Cabecalho2_Pedido
	{
		public string cliente;
		public string cnpj;
		public string endereco;
		public string numero;
		public string compl;
		public string bairro;
		public string cidade;
		public string estado;
		public string cep;
		public string ie;
		public string entrega;
		public string numero_entrega;
		public string compl_entrega;
		public string bairro_entrega;
		public string cidade_entrega;
		public string estado_entrega;
		public string cep_entrega;		
		public string cobranca;
		public string numero_cobranca;
		public string compl_cobranca;
		public string bairro_cobranca;
		public string cidade_cobranca;
		public string estado_cobranca;
		public string cep_cobranca;		
		public string im;
		public string contato;
		public string fone;
		public string fone2;
		public string celular;
		public string email;
		public string vendedor;
		public string observacao;
		public float vlr_desconto;
		public string email_vendedor;
		public string fone1_parceiro;
		public string fone2_parceiro;
		public string celular_parceiro;

		public Cabecalho2_Pedido()
		{
		}
	}
	
	public class cPedidoPDF
	{
		public Document doc;
		private PdfWriter writer;
		public Cabecalho1_Pedido cab1;
		public Cabecalho2_Pedido cab2;

		public cPedidoPDF()
		{
		}
		
		public Cell Celula2(string texto, int colspan, bool titulo)
		{
			Chunk chunk = new Chunk(texto, FontFactory.GetFont(titulo ? BaseFont.HELVETICA_BOLD : BaseFont.HELVETICA, 10));
			Cell cell = new Cell(chunk);
			cell.Colspan = colspan;
			//cell.GrayFill = titulo ? 0.6f : 0.8f;
			//cell.BorderWidthTop = 2;
			//cell.BorderWidthRight = 4;
			//cell.BorderColor = Color.WHITE;
			//cell.BorderWidthTop = 1;
			cell.BorderWidth = 1;
			cell.BorderColor = Color.BLACK;
			cell.Leading = 10;
			return cell;
		}
		
		public Cell Celula2Bold(string texto, int colspan, bool titulo)
		{
			Chunk chunk = new Chunk(texto, FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 10));
			Cell cell = new Cell(chunk);
			cell.Colspan = colspan;
			//cell.GrayFill = titulo ? 0.6f : 0.8f;
			//cell.BorderWidthTop = 2;
			//cell.BorderWidthRight = 4;
			//cell.BorderColor = Color.WHITE;
			cell.BorderWidthTop = 1;
			cell.BorderColor = Color.BLACK;
			cell.Leading = 10;
			return cell;
		}		
		
		public Cell CelulaGrid(string texto, int colspan, bool titulo, bool valor)
		{
			Chunk chunk = new Chunk(texto, FontFactory.GetFont(titulo ? BaseFont.HELVETICA_BOLD : BaseFont.HELVETICA, 10));
			//if (titulo) 
				//chunk.SetUnderline(0.1f, -2f);
			Cell cell = new Cell(chunk);
			cell.Colspan = colspan;
			//cell.GrayFill = titulo ? 0.6f : 1f;
			cell.BorderWidth = 1;
			cell.Leading = 10;
			if (valor) cell.HorizontalAlignment = Element.ALIGN_RIGHT;
			return cell;
		}
		
		private void GeraCabecalho1()		
		{
			Table table = new Table(5);
			table.TableFitsPage = true;
			table.WidthPercentage = 100;
			table.BorderWidth = 0;			
			table.Padding = 4;
			Chunk chunk;
			Cell cell;

			// coluna1 - logo
			Image img=null;
			float largura=1000F;
			float altura=1000F;
			try
			{
				img = Image.GetInstance(cab1.logo);
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
			catch
			{
				chunk = new Chunk("");
			}
			cell = new Cell(chunk);
			cell.BorderWidth = 0;
			table.AddCell(cell);
			
			// coluna2 - pedido
			Paragraph par = new Paragraph();
			par.Add(new Chunk(cab1.fornecedor_pedido + "\r\n", FontFactory.GetFont(BaseFont.HELVETICA, 18)));
			par.Add(new Chunk("Pedido: ", FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 16)));
			par.Add(new Chunk(cab1.nro_pedido.ToString(), FontFactory.GetFont(BaseFont.HELVETICA, 16)));
			par.Add(new Chunk("  Data Orçamento: ", FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 16)));
			par.Add(new Chunk(cab1.data.ToString("d/M/yyyy"), FontFactory.GetFont(BaseFont.HELVETICA, 16)));
			//par.Add(new Chunk(cab1.fornecedor + "  " + cab1.data.ToString("d/M/yyyy") + "-" + cab1.nro_pedido.ToString(), FontFactory.GetFont(BaseFont.HELVETICA, 16)));
			cell = new Cell(par);
			cell.BorderWidth = 0;
			cell.HorizontalAlignment = Element.ALIGN_LEFT;
			cell.VerticalAlignment = Element.ALIGN_MIDDLE;
			cell.Colspan = 3;
			table.AddCell(cell);
			
			string logo;
			if (!Globais.sUsuario.Equals("web"))				
				logo = "imagens\\" + cab1.fornecedor + ".jpg";
			else {
				logo = "imagens/" + cab1.fornecedor + ".jpg";
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

			cell = new Cell(new Phrase(chunk));
			cell.BorderWidth = 0;
			cell.HorizontalAlignment = Element.ALIGN_RIGHT;			
			table.AddCell(cell);	
			
			doc.Add(table);
		}
		
		public Table GeraCabecalho2(bool bVendedor, string vendedor, string observacao)
		{
			Table table = new Table(6);
			table.TableFitsPage = true;
			table.BorderWidth = 1;
			table.Padding = 4;
			table.WidthPercentage = 100;
			table.Alignment = Element.ALIGN_LEFT;
			table.AddCell(Celula2("Cliente", 1, true));
			table.AddCell(Celula2(cab2.cliente, 3, false));
			table.AddCell(Celula2("CPF/CNPJ", 1, true));
			table.AddCell(Celula2(cab2.cnpj, 1, false));
			table.AddCell(Celula2("Endereço", 1, true));
			table.AddCell(Celula2(cab2.endereco.Trim() + " " + 
			                      cab2.numero.Trim() + " - " +
			                      cab2.compl.Trim() + "\r\n" +
			                      cab2.bairro.Trim() + " - " +
			                      cab2.cidade.Trim() + " - " +
			                      cab2.estado.Trim() + " - " +
			                      "CEP " + CEP.PoeEdicao(cab2.cep), 3, false));
			table.AddCell(Celula2("IE", 1, true));
			table.AddCell(Celula2(cab2.ie, 1, false));
			
			table.AddCell(Celula2("Local Entrega", 1, true));
			if (cab2.entrega.Trim().Length > 0) 
				table.AddCell(Celula2(cab2.entrega.Trim() + " " + 
				                      cab2.numero_entrega.Trim() + " - " +
				                      cab2.compl_entrega.Trim() + "\r\n" +
				                      cab2.bairro_entrega.Trim() + " - " +
			    	                  cab2.cidade_entrega.Trim() + " - " +
			        	              cab2.estado_entrega.Trim() + " - " +
			            	          "CEP " + CEP.PoeEdicao(cab2.cep), 3, false));
			else
				table.AddCell(Celula2(cab2.endereco.Trim() + " " + 
				                      cab2.numero.Trim() + " - " +
				                      cab2.compl.Trim() + "\r\n" +
				                      cab2.bairro.Trim() + " - " +
			    	                  cab2.cidade.Trim() + " - " +
			        	              cab2.estado.Trim() + " - " +
			            	          "CEP " + CEP.PoeEdicao(cab2.cep), 3, false));
			table.AddCell(Celula2("IM", 1, true));
			table.AddCell(Celula2(cab2.im, 1, false));
			
			table.AddCell(Celula2("Contato", 1, true));
			table.AddCell(Celula2(cab2.contato, 1, false));
			
			table.AddCell(Celula2("Fone", 1, true));
			string fones = FONES.Concatena(cab2.fone, cab2.fone2, cab2.celular, cab2.fone1_parceiro, cab2.fone2_parceiro, cab2.celular_parceiro);
			table.AddCell(Celula2(fones, 1, false));
			
			table.AddCell(Celula2("email", 1, true));
			table.AddCell(Celula2(cab2.email, 1, false));
			if (bVendedor)
			{
				table.AddCell(Celula2("Vendedor", 1, true));
				table.AddCell(Celula2(vendedor, 5, false));						
				table.AddCell(Celula2("Observações", 1, true));
				table.AddCell(Celula2Bold(observacao, 5, false));			
			}
			return table;
			//doc.Add(table);
		}
		
		public Table GeraItens(ArrayList areas, bool mostrar_valores, bool mostrar_subcodigo, float total_pedido, float total_desconto, bool destacar_ipi)
		{
			int colunas = 24;
			int col0 = 4;
			int col1 = 6;
			int col2 = 4;
			int col3 = 2;
			int col4 = 2;
			int col5 = 2;
			int col6 = 2;
			int col7 = 2;
			if (!destacar_ipi) {
				colunas = 18;
				col0 = 3;
				col2 = 3;
			}
			if (!mostrar_valores) {
				colunas = 12;
				col0 = 2;
				col1 = 5;
				col2 = 3;
			}
			Table table = new Table(colunas);
			
			table.Padding = 4;
			table.TableFitsPage = true;
			table.BorderWidth = 1;
			table.WidthPercentage = 100;
			table.Alignment = Element.ALIGN_LEFT;
			table.AddCell(CelulaGrid("Item", col0, true, false));
			table.AddCell(CelulaGrid("Descrição", col1, true, false));
			table.AddCell(CelulaGrid("Códigos Específicos", col2, true, false));
			table.AddCell(CelulaGrid("Qtde", col3, true, false));			
			if (mostrar_valores)
			{
				table.AddCell(CelulaGrid("Unitário", col4, true, true));
				table.AddCell(CelulaGrid("Total", col5, true, true));
				if (destacar_ipi) {
					table.AddCell(CelulaGrid("IPI", col6, true, true));
					table.AddCell(CelulaGrid("Total c/ IPI", col7, true, true));
				}
			}
			
			float total_tot=0;
			float total_ipi=0;
			float total_final=0;
			foreach (Area area in areas)
			{
				foreach (Item item in area.itens)
				{
					if (mostrar_subcodigo)
					{
						table.AddCell(CelulaGrid(item.codigo+"-"+item.subcodigo, col0, false, false));
					}
					else
					{
						table.AddCell(CelulaGrid(item.codigo, col0, false, false));
					}
					table.AddCell(CelulaGrid(item.descricao, col1, false, false));
					table.AddCell(CelulaGrid(item.especificos, col2, false, false));
					table.AddCell(CelulaGrid(item.qtde.ToString(), col3, false, false));					
					if (mostrar_valores)
					{			
						if (destacar_ipi) {
							table.AddCell(CelulaGrid(item.vlr_semipi.ToString("###,###,##0.00"), col4, false, true));
							table.AddCell(CelulaGrid((Globais.Arredonda(item.vlr_semipi*item.qtde)).ToString("###,###,##0.00"), col5, false, true));
							table.AddCell(CelulaGrid(item.ipi.ToString("#0.00")+"%", col6, false, true));
							table.AddCell(CelulaGrid((Globais.Arredonda(item.vlr_unitario*item.qtde)).ToString("###,###,##0.00"), col7, false, true));
						}
						else {
							table.AddCell(CelulaGrid(item.vlr_unitario.ToString("###,###,##0.00"), col4, false, true));
							table.AddCell(CelulaGrid((Globais.Arredonda(item.vlr_unitario*item.qtde)).ToString("###,###,##0.00"), col5, false, true));
						}
					}
					//table.AddCell(CelulaGrid((item.vlr_unitario*item.qtde*(1+(item.ipi/100))).ToString("###,###,##0.00"), 2, false, true));
					total_tot += (Globais.Arredonda(item.vlr_semipi*item.qtde));
					total_ipi += (Globais.Arredonda(item.vlr_semipi *item.ipi/100*item.qtde));
					float unitario = Globais.Arredonda(item.vlr_unitario);
					float f1 = Globais.Arredonda(item.vlr_unitario*item.qtde);
					float f2 = unitario*item.qtde;
					total_final += (Globais.Arredonda(item.vlr_unitario*item.qtde));
				}
			}
			if (!mostrar_valores)
			{
				return table;
			}

			if (destacar_ipi) {
				table.AddCell(CelulaGrid("Totais", colunas-6, true, false));
				table.AddCell(CelulaGrid(total_tot.ToString("###,###,##0.00"), 2, true, true));
				table.AddCell(CelulaGrid(total_ipi.ToString("###,###,##0.00"), 2, true, true));
			}
			else {
				table.AddCell(CelulaGrid("Totais", colunas-2, true, false));
			}
			table.AddCell(CelulaGrid(total_final.ToString("###,###,##0.00"), 2, true, true));            

			if (total_pedido == 0)
			{
				if (cab2.vlr_desconto > 0)
				{
					table.AddCell(CelulaGrid("Desconto", colunas-2, true, false));
					table.AddCell(CelulaGrid(cab2.vlr_desconto.ToString("###,###,##0.00"), 2, true, true));
					table.AddCell(CelulaGrid("Valor Final", colunas-2, true, false));
					table.AddCell(CelulaGrid((total_final - cab2.vlr_desconto).ToString("###,###,##0.00"), 2, true, true));
				}
				else
				{
					if (cab1.valor < total_final)
					{
						table.AddCell(CelulaGrid("Desconto", colunas-2, true, false));
						table.AddCell(CelulaGrid((total_final - cab1.valor).ToString("###,###,##0.00"), 2, true, true));
						table.AddCell(CelulaGrid("Valor Final", colunas-2, true, false));
						table.AddCell(CelulaGrid(cab1.valor.ToString("###,###,##0.00"), 2, true, true));
					}
					else
					if (cab1.valor > total_final)
					{
						table.AddCell(CelulaGrid("Ajuste", colunas-2, true, false));
						table.AddCell(CelulaGrid((cab1.valor - total_final).ToString("###,###,##0.00"), 2, true, true));
						table.AddCell(CelulaGrid("Valor Final", colunas-2, true, false));
						table.AddCell(CelulaGrid(cab1.valor.ToString("###,###,##0.00"), 2, true, true));
					}
				}
			}
			else
			{
				if (total_desconto > 0)
				{
					table.AddCell(CelulaGrid("Desconto", colunas-2, true, false));
					table.AddCell(CelulaGrid(total_desconto.ToString("###,###,##0.00"), 2, true, true));
					table.AddCell(CelulaGrid("Valor Final", colunas-2, true, false));
					table.AddCell(CelulaGrid((total_final - total_desconto).ToString("###,###,##0.00"), 2, true, true));
				}
				else
				{
					if (total_pedido < total_final)
					{
						table.AddCell(CelulaGrid("Desconto", colunas-2, true, false));
						table.AddCell(CelulaGrid((total_final - total_pedido).ToString("###,###,##0.00"), 2, true, true));
						table.AddCell(CelulaGrid("Valor Final", colunas-2, true, false));
						table.AddCell(CelulaGrid(total_pedido.ToString("###,###,##0.00"), 2, true, true));
					}
					else
					if (total_pedido > total_final)
					{
						table.AddCell(CelulaGrid("Ajuste", colunas-2, true, false));
						table.AddCell(CelulaGrid((total_pedido - total_final).ToString("###,###,##0.00"), 2, true, true));
						table.AddCell(CelulaGrid("Valor Final", colunas-2, true, false));
						table.AddCell(CelulaGrid(total_pedido.ToString("###,###,##0.00"), 2, true, true));
					}
				}				
			}

			return table;
			//doc.Add(table);			
		}
		
		private void GeraFinal()
		{
			Table table = new Table(6);
			table.TableFitsPage = true;
			table.BorderWidth = 0;
			table.Padding = 4;
			table.WidthPercentage = 100;
			table.Alignment = Element.ALIGN_LEFT;
			table.AddCell(Celula2("Condição Pagamento", 1, true));
			table.AddCell(Celula2(cab1.condicao_pagto, 5, false));
			table.AddCell(Celula2("Transportadora", 1, true));
			table.AddCell(Celula2(cab1.transportadora, 5, false));
			doc.Add(table);
		}
		
		public void Open(string arquivo)
		{
			FileStream fs;
			try
			{
				fs = new FileStream(arquivo, FileMode.Create);
			}
			catch 
			{
				return;
			}
			doc = new Document(PageSize.LETTER.Rotate());
			writer = PdfWriter.GetInstance(doc, fs);
			doc.Open();
		}
		
		public void Close()
		{
			doc.Close();			
		}
		
		public void SaltaPagina()
		{
			doc.NewPage();
		}
		
		public void Gera(ArrayList areas, string observacao, bool mostrar_subcodigo, bool mostrar_valores, bool destacar_ipi)
		{
			cab2.observacao = observacao;
			GeraCabecalho1();
			doc.Add(new Paragraph(""));
			
			Table table2 = GeraCabecalho2(false, "", "");
			table2.AddCell(Celula2("Vendedor", 1, true));
			table2.AddCell(Celula2(cab2.vendedor, 5, false));						
			table2.AddCell(Celula2("Observações", 1, true));
			table2.AddCell(Celula2Bold(cab2.observacao, 5, false));			
			doc.Add(table2);
			
			doc.Add(new Paragraph(""));
			if (cab1.fornecedor_pedido.CompareTo(cab1.fornecedor) == 0)
			{
				doc.Add(GeraItens(areas, mostrar_valores, mostrar_subcodigo, 0, 0, destacar_ipi));
				doc.Add(new Paragraph(""));
				GeraFinal();
			}
			else
			{
				Table table = new Table(1);
				table.Padding = 4;
				table.TableFitsPage = true;
				table.BorderWidth = 1;
				table.WidthPercentage = 100;
				table.Alignment = Element.ALIGN_LEFT;
				table.AddCell(CelulaGrid("Valor: " + cab1.valor.ToString("###,###,##0.00"), 1, false, false));
				table.AddCell(CelulaGrid(observacao, 1, false, false));
				doc.Add(table);			
			}
		}
	}
}
