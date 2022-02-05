/*
 * Relatorio Consolidado de Pedidos
 * Autor: Ricardo Costa Xavier
 * Data : 20/09/2009
 */

using System;
using System.IO;
using System.Windows.Forms;
using System.Data;
using FirebirdSql.Data.FirebirdClient;
using System.Collections;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Collections.Generic;

namespace classes
{
	public class DadosItem
	{
		public string COD_FORNECEDOR;
		public DateTime DAT_ORCAMENTO;
		public short COD_ORCAMENTO;
		public short COD_PEDIDO;
		public short NRO_PEDIDO;
		public string OBSERVACAO;
		public float VLR_PEDIDO;
		public string COD_CLIENTE;
		public string COD_CARACTERISTICA;
		public string COD_VENDEDOR;
		public float VLR_DESCONTO;
		public string NOM_PARCEIRO;
		public string DES_FORMULA;
		public string DES_FORMULA_PEDIDO;		
		
		public short SEQ_ITEM;
		public short QTD_ITEM;
		public string COD_PRODUTO;
		public string SUB_CODIGO;
		public string DES_MEDIDAS;
		public string IDT_ESPECIAL;
		public float VLR_PRECO;
		public float PER_IPI;
		public string DES_PRODUTO;
		public string TXT_PRODUTO;
		public string COD_ESPECIFICOS;
		
		public DadosItem()
		{
			
		}
	}
	
	public class DadosPedido
	{
		public string COD_FORNECEDOR;
		public DateTime DAT_ORCAMENTO;
		public short COD_ORCAMENTO;
		public short COD_PEDIDO;
		public short NRO_PEDIDO;
		public string OBSERVACAO;
		public float VLR_PEDIDO;
		public float VLR_INICIAL;		
		public string COD_CLIENTE;
		public string COD_CARACTERISTICA;
		public string COD_VENDEDOR;
		public float VLR_DESCONTO;
		public string NOM_PARCEIRO;
		public string DES_FORMULA;
		public string DES_FORMULA_PEDIDO;
		public ArrayList itens;
		
		public DadosPedido()
		{
			
		}
		
		public void CarregaItens()
		{
			itens = new ArrayList();
			FbCommand cmd =  new FbCommand("select " +
			                     "       a.SEQ_ITEM, " +
			                     "       a.QTD_ITEM, " +
			                     "       a.COD_PRODUTO, " +
			                     "       a.SUB_CODIGO, " +
			                     "       a.DES_MEDIDAS, " +			                     
			                     "       a.IDT_ESPECIAL, " +			                     			                     
			                     "       a.VLR_PRECO, " +			                     
			                     "       b.PER_IPI, " +                    			                     
			                     "       a.DES_PRODUTO, " +
			                     "       a.TXT_PRODUTO," +
			                     "       a.COD_ESPECIFICOS " +
			                     "from ITENS a, PRODUTOS b " +
			                     "where a.cod_fornecedor='" + COD_FORNECEDOR + "' and " +
				                 "      a.dat_orcamento='" + DAT_ORCAMENTO.ToString("M/d/yyyy") + "' and " +
				                 "      a.cod_orcamento=" + COD_ORCAMENTO + " and " +
				         		 "      a.cod_fornecedor=b.cod_parceiro and " +
				         		 "      a.cod_produto=b.cod_produto and " +
				         		 "      a.sub_codigo=b.sub_codigo " +								
				                 "      order by a.cod_produto,a.sub_codigo",				         		 
			                     Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			while (reader.Read())
			{
				DadosItem dados = new DadosItem();
				dados.SEQ_ITEM = reader.GetInt16(0);
				dados.QTD_ITEM = !reader.IsDBNull(1) ? reader.GetInt16(1) : (short)0;
				dados.COD_PRODUTO = !reader.IsDBNull(2) ? reader.GetString(2).Trim() : "";
				dados.SUB_CODIGO = !reader.IsDBNull(3) ? reader.GetString(3).Trim() : "";
				dados.DES_MEDIDAS = !reader.IsDBNull(4) ? reader.GetString(4).Trim() : "";
				dados.IDT_ESPECIAL = !reader.IsDBNull(5) ? reader.GetString(5).Trim() : "";
				dados.VLR_PRECO = !reader.IsDBNull(6) ? reader.GetFloat(6) : 0f;
				dados.PER_IPI = !reader.IsDBNull(7) ? reader.GetFloat(7) : 0f;
				dados.DES_PRODUTO = !reader.IsDBNull(8) ? reader.GetString(8).Trim() : "";
				dados.TXT_PRODUTO = !reader.IsDBNull(9) ? reader.GetString(9).Trim() : "";
				dados.COD_ESPECIFICOS = !reader.IsDBNull(10) ? reader.GetString(10).Trim() : "";
				//MessageBox.Show("Seq:" + dados.SEQ_ITEM.ToString());
				itens.Add(dados);
			}
			reader.Close();
		}
	}
			
	public class PedidoConsolidado2
	{
		private Document doc;
		private PdfWriter writer;
		
		private void CabecalhoRelatorio()		
		{
			Tabela table = new Tabela(4);
			PdfPCell cell;
			Chunk chunk;
			string logo = "imagens\\logo_rel.jpg";
			Image img;
			float largura=80F;
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
			catch
			{
				chunk = new Chunk("");
			}
			cell = new PdfPCell(new Phrase(chunk));
			cell.BorderWidth = 0;
			cell.BorderWidthBottom = 1;
			cell.Colspan = 1;
			table.AddCell(cell);
			
			cell = new PdfPCell(new Phrase(new Chunk("Relatório de Pedidos", FontFactory.GetFont(BaseFont.HELVETICA, 18))));
			cell.BorderWidth = 0;
			cell.BorderWidthBottom = 1;
			cell.Colspan = 2;
			cell.VerticalAlignment = Element.ALIGN_MIDDLE;
			cell.HorizontalAlignment = Element.ALIGN_CENTER;
			table.AddCell(cell);			
			
			cell = new PdfPCell(new Phrase(new Chunk(DateTime.Now.ToString("d/M/yyyy"), FontFactory.GetFont(BaseFont.HELVETICA, 18))));
			cell.BorderWidth = 0;
			cell.BorderWidthBottom = 1;
			cell.Colspan = 1;
			cell.VerticalAlignment = Element.ALIGN_MIDDLE;
			cell.HorizontalAlignment = Element.ALIGN_CENTER;
			table.AddCell(cell);						
			
			doc.Add(table);
		}		
		
		private void CabecalhoFornecedor(string COD_FORNECEDOR)
		{
			Tabela table = new Tabela(1);
			PdfPCell cell;
			doc.Add(new Paragraph(""));			
			doc.Add(new Paragraph(""));	
			cell = new PdfPCell(new Phrase(new Chunk("Fornecedor " + COD_FORNECEDOR.Trim())));
			cell.BorderWidth = 0;
			table.AddCell(cell);			
			doc.Add(table);			
		}				

		private void CabecalhoCliente(string COD_FORNECEDOR, DateTime DAT_ORCAMENTO, short COD_ORCAMENTO,  bool servico)
		{
			cPedidos pedido = new cPedidos();
			cPedidoPDF pedido_pdf = new cPedidoPDF();
			pedido_pdf.cab2 = pedido.DadosCabecalho2(COD_FORNECEDOR, DAT_ORCAMENTO, COD_ORCAMENTO, servico);
		
			Tabela table = new Tabela(6);
			
			table.AddCell(Celula2("Cliente", 1, true));
			table.AddCell(Celula2(pedido_pdf.cab2.cliente, 3, false));
			table.AddCell(Celula2("CPF/CNPJ", 1, true));
			table.AddCell(Celula2(pedido_pdf.cab2.cnpj, 1, false));
			
			table.AddCell(Celula2("Endereço", 1, true));
			table.AddCell(Celula2(pedido_pdf.cab2.endereco.Trim() + " " + 
			                      pedido_pdf.cab2.numero.Trim() + " - " +
			                      pedido_pdf.cab2.compl.Trim() + "\r\n" +
			                      pedido_pdf.cab2.bairro.Trim() + " - " +
			                      pedido_pdf.cab2.cidade.Trim() + " - " +
			                      pedido_pdf.cab2.estado.Trim() + " - " +
			                      "CEP " + CEP.PoeEdicao(pedido_pdf.cab2.cep), 3, false));
			table.AddCell(Celula2("IE", 1, true));
			table.AddCell(Celula2(pedido_pdf.cab2.ie, 1, false));
			
			table.AddCell(Celula2("Local Entrega", 1, true));
			if (pedido_pdf.cab2.entrega.Trim().Length > 0) 
				table.AddCell(Celula2(pedido_pdf.cab2.entrega.Trim() + " " + 
				                      pedido_pdf.cab2.numero_entrega.Trim() + " - " +
				                      pedido_pdf.cab2.compl_entrega.Trim() + "\r\n" +
				                      pedido_pdf.cab2.bairro_entrega.Trim() + " - " +
			    	                  pedido_pdf.cab2.cidade_entrega.Trim() + " - " +
			        	              pedido_pdf.cab2.estado_entrega.Trim() + " - " +
			            	          "CEP " + CEP.PoeEdicao(pedido_pdf.cab2.cep), 3, false));
			else
				table.AddCell(Celula2(pedido_pdf.cab2.endereco.Trim() + " " + 
				                      pedido_pdf.cab2.numero.Trim() + " - " +
				                      pedido_pdf.cab2.compl.Trim() + "\r\n" +
				                      pedido_pdf.cab2.bairro.Trim() + " - " +
			    	                  pedido_pdf.cab2.cidade.Trim() + " - " +
			        	              pedido_pdf.cab2.estado.Trim() + " - " +
			            	          "CEP " + CEP.PoeEdicao(pedido_pdf.cab2.cep), 3, false));
			table.AddCell(Celula2("IM", 1, true));
			table.AddCell(Celula2(pedido_pdf.cab2.im, 1, false));
			
			table.AddCell(Celula2("Contato", 1, true));
			table.AddCell(Celula2(pedido_pdf.cab2.contato, 1, false));
			
			table.AddCell(Celula2("Fone", 1, true));
			string fones = FONES.Concatena(pedido_pdf.cab2.fone, pedido_pdf.cab2.fone2, pedido_pdf.cab2.celular, pedido_pdf.cab2.fone1_parceiro, pedido_pdf.cab2.fone2_parceiro, pedido_pdf.cab2.celular_parceiro);
			table.AddCell(Celula2(fones, 1, false));
			
			table.AddCell(Celula2("email", 1, true));
			table.AddCell(Celula2(pedido_pdf.cab2.email, 1, false));
			doc.Add(table);
		}
		
		private void CabecalhoPedido(string COD_FORNECEDOR, DateTime DAT_ORCAMENTO, short COD_ORCAMENTO, int NRO_PEDIDO, string vendedor, string observacao)
		{
			Tabela table = new Tabela(1);
			PdfPCell cell;
			doc.Add(new Paragraph(""));			
			doc.Add(new Paragraph(""));	
			cell = new PdfPCell(new Phrase(new Chunk("Pedido " + COD_FORNECEDOR.Trim() + " - " + NRO_PEDIDO.ToString())));
			cell.BorderWidth = 0;
			table.AddCell(cell);			
			doc.Add(table);			
			
			table = new Tabela(6);
			table.AddCell(Celula2("Vendedor", 1, true));
			table.AddCell(Celula2(vendedor, 5, false));						
			table.AddCell(Celula2("Observações", 1, true));
			table.AddCell(Celula2(observacao, 5, false));			
			doc.Add(table);			
			
		}		
		
		private void CabecalhoTabela(Tabela table, bool mostrar_valores)
		{
			//doc.Add(new Paragraph(""));			
			//doc.Add(new Paragraph(""));	
			PdfPCell cell = CelulaGrid("", mostrar_valores ? 24 : 12, true, false);
			cell.BorderWidth = 0;
			table.AddCell(cell);
			
			table.AddCell(CelulaGrid("Item", mostrar_valores ? 4 : 2, true, false));
			table.AddCell(CelulaGrid("Descrição", mostrar_valores ? 6 : 5, true, false));
			table.AddCell(CelulaGrid("Códigos Específicos", mostrar_valores ? 4 : 3, true, false));
			table.AddCell(CelulaGrid("Qtde", 2, true, false));			
			if (mostrar_valores)
			{
				table.AddCell(CelulaGrid("Unitário", 2, true, true));
				table.AddCell(CelulaGrid("Total", 2, true, true));
				table.AddCell(CelulaGrid("IPI", 2, true, true));
				table.AddCell(CelulaGrid("Total c/ IPI", 2, true, true));
			}
		}

		private void RodapeFornecedor(string observacao)
		{
			Tabela table = new Tabela(6);
			table.AddCell(Celula2("Observações", 1, true));
			table.AddCell(Celula2(observacao, 5, false));	
			doc.Add(table);
		}

		private PdfPCell CelulaGrid(string texto, int colspan, bool titulo, bool valor)
		{
			Chunk chunk = new Chunk(texto, FontFactory.GetFont(titulo ? BaseFont.HELVETICA_BOLD : BaseFont.HELVETICA, 10));
			//chunk.SetUnderline(1f, -1f);
			PdfPCell cell = new PdfPCell(new Phrase(chunk));
			cell.Padding = 4;
			cell.Colspan = colspan;
			
			//cell.GrayFill = titulo ? 0.6f : 1f;
			cell.BorderWidth = 1;
			if (valor) cell.HorizontalAlignment = Element.ALIGN_RIGHT;
			return cell;
		}

		private void Totais(Tabela table, float total, float desconto, bool por_fabrica)
		{
			if (!por_fabrica)
			{
				table.AddCell(CelulaGrid("Desconto", 22, true, false));
				table.AddCell(CelulaGrid(desconto.ToString("###,###,##0.00"), 2, true, true));
			}
			table.AddCell(CelulaGrid("Valor Final", 22, true, false));
			table.AddCell(CelulaGrid((total - desconto).ToString("###,###,##0.00"), 2, true, true));
		}
		
		public PdfPCell Celula2(string texto, int colspan, bool titulo)
		{
			Chunk chunk = new Chunk(texto, FontFactory.GetFont(titulo ? BaseFont.HELVETICA_BOLD : BaseFont.HELVETICA, 10));
			PdfPCell cell = new PdfPCell(new Phrase(chunk));
			cell.Padding = 4;
			cell.Colspan = colspan;
			cell.BorderWidth = 1;
			//cell.GrayFill = titulo ? 0.6f : 0.8f;
			//cell.BorderWidthTop = 2;
			//cell.BorderWidthRight = 4;
			//cell.BorderColor = Color.WHITE;
			return cell;
		}		
		
		public PedidoConsolidado2(string arquivo, string filtro_pedidos, bool por_item, bool por_pedido, bool por_cliente, bool por_fabrica, bool mostrar_valores, bool mostrar_subcodigo, string observacao_fabrica, List<string> pedidosDestacarIpi)
		{
			#region seleciona pedidos
			ArrayList pedidos = new ArrayList();
			string sql = 
				"select " +
				"p.COD_FORNECEDOR,p.DAT_ORCAMENTO,p.COD_ORCAMENTO,p.COD_PEDIDO,p.NRO_PEDIDO,p.OBSERVACAO,p.VLR_PEDIDO," +
				"o.COD_CLIENTE,o.COD_CARACTERISTICA,o.COD_VENDEDOR,o.VLR_DESCONTO,c.NOM_PARCEIRO, " +
				"f.DES_FORMULA,f.DES_FORMULA_PEDIDO, " +
				"(select 1 from PEDIDOS p2 where p2.COD_FORNECEDOR=p.COD_FORNECEDOR and p2.DAT_ORCAMENTO=p.DAT_ORCAMENTO and p2.COD_ORCAMENTO=p.COD_ORCAMENTO and p2.COD_PEDIDO=2), " +
				"p.VLR_INICIAL " +				
				"from PEDIDOS p " +
				"inner join ORCAMENTOS o on o.COD_FORNECEDOR=p.COD_FORNECEDOR and o.DAT_ORCAMENTO=p.DAT_ORCAMENTO and o.COD_ORCAMENTO=p.COD_ORCAMENTO " +
				"inner join PARCEIROS c on c.COD_PARCEIRO=o.COD_CLIENTE " +
				"inner join CARACTERISTICAS f on f.COD_FORNECEDOR=o.COD_FORNECEDOR and f.COD_CARACTERISTICA=o.COD_CARACTERISTICA " +
				"where " + filtro_pedidos + " " +
				"order by p.COD_FORNECEDOR,p.DAT_ORCAMENTO,p.COD_ORCAMENTO,p.COD_PEDIDO";
			//StreamWriter sw = new StreamWriter(new FileStream("c:\\softplace\\softplace.log", FileMode.Create));
			//sw.WriteLine(sql);
			//sw.Close();
		
			FbCommand cmd =  new FbCommand(sql, Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			if (!por_fabrica) por_cliente = true;
			string ultimo_cliente="";
			while (reader.Read())
			{
				DadosPedido dados = new DadosPedido();
				dados.COD_FORNECEDOR = reader.GetString(0).Trim();
				dados.DAT_ORCAMENTO = reader.GetDateTime(1);
				dados.COD_ORCAMENTO = reader.GetInt16(2);
				dados.COD_PEDIDO = reader.GetInt16(3);
				dados.NRO_PEDIDO = !reader.IsDBNull(4) ? reader.GetInt16(4) : (short)0;
				//MessageBox.Show("Pedido:" + dados.NRO_PEDIDO.ToString());
				dados.OBSERVACAO = !reader.IsDBNull(5) ? reader.GetString(5).Trim() : "";	
				dados.VLR_PEDIDO = !reader.IsDBNull(6) ? reader.GetFloat(6) : 0f;	
				dados.VLR_INICIAL = !reader.IsDBNull(15) ? reader.GetFloat(15) : 0f;					
				dados.COD_CLIENTE = !reader.IsDBNull(7) ? reader.GetString(7).Trim() : "";	
				dados.COD_CARACTERISTICA = !reader.IsDBNull(8) ? reader.GetString(8).Trim() : "";
				dados.COD_VENDEDOR = !reader.IsDBNull(9) ? reader.GetString(9).Trim() : "";	
				dados.VLR_DESCONTO = !reader.IsDBNull(10) ? reader.GetFloat(10) : 0f;
				dados.NOM_PARCEIRO = !reader.IsDBNull(11) ? reader.GetString(11).Trim() : "";
				dados.DES_FORMULA = !reader.IsDBNull(12) ? reader.GetString(12).Trim() : "";
				dados.DES_FORMULA_PEDIDO = !reader.IsDBNull(13) ? reader.GetString(13).Trim() : "";
				if (dados.DES_FORMULA_PEDIDO.Length == 0) dados.DES_FORMULA_PEDIDO = dados.DES_FORMULA;
				if (!dados.COD_CLIENTE.Equals(ultimo_cliente))
				{
					if (!ultimo_cliente.Equals(""))
					{
						por_cliente = false;
					}
					ultimo_cliente = dados.COD_CLIENTE;
				}
				if (dados.COD_PEDIDO == 1)
				{
					if (!reader.IsDBNull(14))
					{
						dados.VLR_DESCONTO = 0;
					}
					dados.CarregaItens();
				}
				else
				{
					DadosItem item = new DadosItem();
					item.QTD_ITEM = 1;
					item.VLR_PRECO = dados.VLR_PEDIDO;
					item.COD_PRODUTO = "Serviço";
					item.SUB_CODIGO = "-";
					item.DES_PRODUTO = dados.OBSERVACAO;
					dados.itens = new ArrayList();
					dados.itens.Add(item);
				}
				pedidos.Add(dados);				
			}
			reader.Close();
			if (pedidos.Count == 0) return;
			#endregion
			
			#region ordena os itens
			SortedList pedidos_ord = new SortedList();
			string chave="";
			// #   fabrica  pedido   item
			// 0   0        0        0   
			// 1   0        0        1      
			// 2   0        1        0      
			// 3   0        1        1      
			// 4   1        0        0      
			// 5   1        0        1       
			// 6   1        1        0      
			// 7   1        1        1     
			string zera_desconto_fornecedor = "";
			DateTime zera_desconto_data = DateTime.Now;
			short zera_desconto_orcamento = 0;
			foreach (DadosPedido pedido in pedidos)
			{
				int i=0;
				if (pedido.itens != null)
				foreach (DadosItem item in pedido.itens)
				{
					i++;
					#region seta chave
					if (por_fabrica) // 4 5 6 7
					{
						if (por_pedido)  // 6 7
						{
							if (por_item)  // 7
							{
								// fabrica + pedido + item
								chave = pedido.COD_FORNECEDOR + pedido.DAT_ORCAMENTO.ToString("yyyy/MM/dd") + pedido.COD_ORCAMENTO.ToString("00000") + pedido.COD_PEDIDO.ToString("0") +
										item.COD_PRODUTO + item.SUB_CODIGO + item.COD_ESPECIFICOS +
										item.SEQ_ITEM;
							}
							else // 6
							{
								// fabrica + pedido
								chave = pedido.COD_FORNECEDOR + pedido.DAT_ORCAMENTO.ToString("yyyy/MM/dd") + pedido.COD_ORCAMENTO.ToString("00000") + pedido.COD_PEDIDO.ToString("0") +
										item.SEQ_ITEM;
							}
						}
						else // 4 5
						{
							if (por_item)  // 5
							{
								// fabrica + item
								chave = pedido.COD_FORNECEDOR +
										item.COD_PRODUTO + item.SUB_CODIGO + item.COD_ESPECIFICOS +
										pedido.COD_FORNECEDOR + pedido.DAT_ORCAMENTO.ToString("yyyy/MM/dd") + pedido.COD_ORCAMENTO.ToString("00000") + pedido.COD_PEDIDO.ToString("0") + item.SEQ_ITEM;
							}
							else // 4
							{
								// fabrica = fabrica + pedido
								chave = pedido.COD_FORNECEDOR + pedido.DAT_ORCAMENTO.ToString("yyyy/MM/dd") + pedido.COD_ORCAMENTO.ToString("00000") + pedido.COD_PEDIDO.ToString("0") +
										item.SEQ_ITEM;
							}
						}
					}
					else // 0 1 2 3
					{
						if (por_pedido)  // 2 3
						{
							if (por_item)  // 3
							{
								// pedido + item = fabrica + pedido + item
								chave = pedido.COD_FORNECEDOR + pedido.DAT_ORCAMENTO.ToString("yyyy/MM/dd") + pedido.COD_ORCAMENTO.ToString("00000") + pedido.COD_PEDIDO.ToString("0") +
										item.COD_PRODUTO + item.SUB_CODIGO + item.COD_ESPECIFICOS +
										item.SEQ_ITEM;
							}
							else // 2
							{
								// pedido = fabrica + pedido
								chave = pedido.COD_FORNECEDOR + pedido.DAT_ORCAMENTO.ToString("yyyy/MM/dd") + pedido.COD_ORCAMENTO.ToString("00000") + pedido.COD_PEDIDO.ToString("0") +
										item.SEQ_ITEM;
							}
						}
						else // 0 1
						{
							if (por_item)  // 1
							{
								// por item
								chave = item.COD_PRODUTO + item.SUB_CODIGO + item.COD_ESPECIFICOS +
										pedido.COD_FORNECEDOR + pedido.DAT_ORCAMENTO.ToString("yyyy/MM/dd") + pedido.COD_ORCAMENTO.ToString("00000") + pedido.COD_PEDIDO.ToString("0") + item.SEQ_ITEM;
							}
							else // 0
							{
								// nada = pedido
								chave = pedido.COD_FORNECEDOR + pedido.DAT_ORCAMENTO.ToString("yyyy/MM/dd") + pedido.COD_ORCAMENTO.ToString("00000") + pedido.COD_PEDIDO.ToString("0") +
										item.SEQ_ITEM;
							}
						}						
					}
					#endregion
							
					item.COD_FORNECEDOR = pedido.COD_FORNECEDOR;
					item.DAT_ORCAMENTO = pedido.DAT_ORCAMENTO;
					item.COD_ORCAMENTO = pedido.COD_ORCAMENTO;
					item.COD_PEDIDO = pedido.COD_PEDIDO;
					item.NRO_PEDIDO = pedido.NRO_PEDIDO;
					item.OBSERVACAO = pedido.OBSERVACAO;
					item.VLR_PEDIDO = pedido.VLR_PEDIDO;
					item.COD_CLIENTE = pedido.COD_CLIENTE;
					item.COD_CARACTERISTICA = pedido.COD_CARACTERISTICA;
					item.COD_VENDEDOR = pedido.COD_VENDEDOR;
					
					// o desconto será feito no primeiro item do pedido
					// alterado em 19/06/11
					// o consolidado estava ficando errado quando o valor do pedido era alterado					
					if (pedido.COD_FORNECEDOR.Equals(zera_desconto_fornecedor) &&
					    (pedido.DAT_ORCAMENTO == zera_desconto_data) &&
					    (pedido.COD_ORCAMENTO == zera_desconto_orcamento)) {
						// o desconto já foi feito no outro pedido desse orçamento
						pedido.VLR_DESCONTO = 0;
						pedido.VLR_INICIAL = pedido.VLR_PEDIDO; // evita duplicação do desconto nos próximos itens						
					}			
					bool deuDesconto = false;
					if (pedido.VLR_PEDIDO < pedido.VLR_INICIAL)
						item.VLR_DESCONTO = pedido.VLR_INICIAL - pedido.VLR_PEDIDO;
					else
					if (pedido.VLR_PEDIDO > pedido.VLR_INICIAL)
						item.VLR_DESCONTO = pedido.VLR_PEDIDO - pedido.VLR_INICIAL;						
					else {
						item.VLR_DESCONTO = pedido.VLR_DESCONTO;
						deuDesconto = true;
					}
					if ((item.VLR_DESCONTO > -0.2) && (item.VLR_DESCONTO < 0.2)) {
						item.VLR_DESCONTO = 0;			
						deuDesconto = false;
					}
					pedido.VLR_DESCONTO = 0;
					pedido.VLR_INICIAL = pedido.VLR_PEDIDO; // evita duplicação do desconto nos próximos itens
					if (deuDesconto) {
						zera_desconto_fornecedor = pedido.COD_FORNECEDOR;
						zera_desconto_data = pedido.DAT_ORCAMENTO;
						zera_desconto_orcamento = pedido.COD_ORCAMENTO;					
					}
					
					item.NOM_PARCEIRO = pedido.NOM_PARCEIRO;
					item.DES_FORMULA = pedido.DES_FORMULA;
					item.DES_FORMULA_PEDIDO = pedido.DES_FORMULA_PEDIDO;
					pedidos_ord.Add(chave, item);
					//MessageBox.Show(chave);
				}
			}
			#endregion
		
			FileStream fs;
			try
			{
				fs = new FileStream(arquivo, FileMode.Create);
				doc = new Document(PageSize.LETTER.Rotate());
				writer = PdfWriter.GetInstance(doc, fs);
				doc.Open();
				CabecalhoRelatorio();
				
				Tabela table ;//= new Tabela(mostrar_valores ? 24 : 12);
				string ultimo_fornecedor="";
				string ultimo_pedido="";
				DadosItem item0 = (DadosItem)pedidos_ord.GetByIndex(0);
				CabecalhoCliente(item0.COD_FORNECEDOR, item0.DAT_ORCAMENTO, item0.COD_ORCAMENTO, !por_cliente);
				if (por_fabrica)
				{
					CabecalhoFornecedor(item0.COD_FORNECEDOR);
				}
				if (por_pedido)
				{
					CabecalhoPedido(item0.COD_FORNECEDOR, item0.DAT_ORCAMENTO, item0.COD_ORCAMENTO, item0.NRO_PEDIDO, item0.COD_VENDEDOR, item0.OBSERVACAO);				
				}
				int itens_tabela=0;
				//doc.Add(table);
				
				table = new Tabela(mostrar_valores ? 24 : 12);
				CabecalhoTabela(table, mostrar_valores);
				float total=0;
				float desconto=0;
				for (int i=0; i<pedidos_ord.Count; i++)
				{
					DadosItem item = (DadosItem)pedidos_ord.GetByIndex(i);
					if (item.QTD_ITEM == 0) // item agrupado
					{
						continue;
					}
					
					string chave_fornecedor = item.COD_FORNECEDOR;
					string chave_pedido = item.DAT_ORCAMENTO.ToString("yyyy/MM/dd") + item.COD_ORCAMENTO.ToString("00000");
					
					string chaveDestacar = item.COD_FORNECEDOR.Trim() + ":" + item.DAT_ORCAMENTO.ToString("M/d/yyyy") + ":" + item.COD_ORCAMENTO.ToString() + ":"  + item.COD_PEDIDO.ToString();
					bool destacar = false;
					foreach (string aux in pedidosDestacarIpi)
					{
						if (aux.Equals(chaveDestacar))
						{
							destacar = true;
							break;
						}
					}
					if (!destacar) {
						if (item.PER_IPI > 0) {
							item.VLR_PRECO += (item.PER_IPI * item.VLR_PRECO / 100);
						}
						item.PER_IPI = 0;
					}
					
					#region agrupa por item
					if (por_item)
					{
						string chave_item = item.COD_PRODUTO + item.SUB_CODIGO + item.COD_ESPECIFICOS + item.VLR_PRECO.ToString();						
						for (int j=i+1; j<pedidos_ord.Count; j++)
						{
							DadosItem proximo = (DadosItem)pedidos_ord.GetByIndex(j);							    								
							string chave_proximo = proximo.COD_PRODUTO + proximo.SUB_CODIGO + proximo.COD_ESPECIFICOS + proximo.VLR_PRECO.ToString();
							if (chave_item.Equals(chave_proximo))
							{
								item.QTD_ITEM += proximo.QTD_ITEM;
								proximo.QTD_ITEM = 0;
							}
						}
					}
					#endregion
					
					bool quebrou_pedido=false;
					if (ultimo_fornecedor != chave_fornecedor)
					{
						if (por_fabrica)
						{
							if (itens_tabela > 0)
							{
								if (mostrar_valores) Totais(table, total, desconto, por_fabrica);
								total = 0;
								desconto = 0;
								doc.Add(table);
								RodapeFornecedor(observacao_fabrica);
								doc.NewPage();
								table = new Tabela(mostrar_valores ? 24 : 12);
								CabecalhoRelatorio();								
								CabecalhoFornecedor(item.COD_FORNECEDOR);
								if (por_pedido)
								{
									if (ultimo_pedido != chave_pedido)
									{
										quebrou_pedido = true;
										CabecalhoPedido(item.COD_FORNECEDOR, item.DAT_ORCAMENTO, item.COD_ORCAMENTO, item.NRO_PEDIDO, item.COD_VENDEDOR, item.OBSERVACAO);
										ultimo_pedido = chave_pedido;
									}
								}
								itens_tabela=0;
								CabecalhoTabela(table, mostrar_valores);
							}
						}
						
						ultimo_fornecedor = chave_fornecedor;
					}
					if (!quebrou_pedido && por_pedido && (ultimo_pedido != chave_pedido))
					{
							if (itens_tabela > 0)
							{
								if (mostrar_valores) Totais(table, total, desconto, por_fabrica);
								total = 0;
								desconto = 0;
								doc.Add(table);
								table = new Tabela(mostrar_valores ? 24 : 12);
								CabecalhoPedido(item.COD_FORNECEDOR, item.DAT_ORCAMENTO, item.COD_ORCAMENTO, item.NRO_PEDIDO, item.COD_VENDEDOR, item.OBSERVACAO);
								itens_tabela=0;
								CabecalhoTabela(table, mostrar_valores);
							}
						
						ultimo_pedido = chave_pedido;
					}

					desconto += item.VLR_DESCONTO;
					
					if (mostrar_subcodigo)
						table.AddCell(CelulaGrid(item.COD_PRODUTO + "-" + item.SUB_CODIGO, mostrar_valores ? 4 : 2, false, false));
					else
						table.AddCell(CelulaGrid(item.COD_PRODUTO, mostrar_valores ? 4 : 2, false, false));
					table.AddCell(CelulaGrid(item.DES_PRODUTO, mostrar_valores ? 6 : 5, false, false));
					table.AddCell(CelulaGrid(item.COD_ESPECIFICOS, mostrar_valores ? 4 : 3, false, false));
					table.AddCell(CelulaGrid(item.QTD_ITEM.ToString(), 2, false, false));
					
					float per_frete = cCaracteristicas.Frete(item.COD_FORNECEDOR, item.COD_CARACTERISTICA);
					if (mostrar_valores)
					{
						float ipi = item.PER_IPI;
						float preco = item.VLR_PRECO;
						float semipi = item.VLR_PRECO;
						if (item.COD_PEDIDO == 1)
						{
							if (!item.IDT_ESPECIAL.Equals("S"))
							{
								Globais.CalculaFormula(ref preco, item.DES_FORMULA_PEDIDO, ipi, per_frete, 0);
								Globais.CalculaFormula(ref semipi, item.DES_FORMULA_PEDIDO, 0, per_frete, 0);
							}
							else
							{
								// desfaz formula
								Globais.DesfazFormula(ref preco, item.DES_FORMULA, ipi, per_frete, 0);
								Globais.DesfazFormula(ref semipi, item.DES_FORMULA, ipi, per_frete, 0);
								// refaz parte do pedido
								Globais.CalculaFormula(ref preco, item.DES_FORMULA_PEDIDO, ipi, per_frete, 0);
								Globais.CalculaFormula(ref semipi, item.DES_FORMULA_PEDIDO, 0, per_frete, 0);
							}
						}
						else
						{
							ipi = 0;
						}
						total += preco*item.QTD_ITEM;
						
						table.AddCell(CelulaGrid(semipi.ToString("###,###,##0.00"), 2, false, true));
						table.AddCell(CelulaGrid((semipi*item.QTD_ITEM).ToString("###,###,##0.00"), 2, false, true));
						table.AddCell(CelulaGrid(ipi.ToString("#0.00")+"%", 2, false, true));
						table.AddCell(CelulaGrid((preco*item.QTD_ITEM).ToString("###,###,##0.00"), 2, false, true));
					}
					
					itens_tabela++;

				}
				if (itens_tabela > 0)
				{
					if (mostrar_valores) Totais(table, total, desconto, por_fabrica);
					total = 0;
					desconto = 0;
					doc.Add(table);
					if (por_fabrica)
					{
						RodapeFornecedor(observacao_fabrica);						
					}					
				}
				doc.Close();
				fs.Close();						
			}
			catch (Exception e)
			{
				Log.Grava(Globais.sUsuario, "erro:" + e.Message);
				MessageBox.Show("Erro na geração do relatório\r\n" + e.Message);
				return;
			}			
		}
	}
}
