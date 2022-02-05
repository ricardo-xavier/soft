/*
 * Classe PedidoFabricaPDF
 * Gera um pedido de fabrica em PDF
 * Autor: Ricardo Costa Xavier
 * Histórico:
 * 02/06/09 - versão inicial
 */

using System;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Collections;

namespace classes
{
	public class Tabela: PdfPTable
	{
		public Tabela(int colunas): base(colunas)
		{
			this.WidthPercentage = 100;
		}
	}
	
	public class Celula: PdfPCell
	{
		public Celula(Phrase phrase): base(phrase)
		{
			this.BorderWidth = 0;
			this.FixedHeight = 20f;
			this.Padding = 4;
		}
	}
	
	public class CelulaCabecalho: PdfPCell
	{
		public CelulaCabecalho(Phrase phrase): base(phrase)
		{
			this.BorderWidth = 1;
			//this.GrayFill = 0.5f;
			this.FixedHeight = 20f;			
			this.Padding = 4;
		}
	}
	
	public class CelulaItem: PdfPCell
	{
		public CelulaItem(Phrase phrase): base(phrase)
		{
			this.BorderWidth = 1;
			this.FixedHeight = 20f;			
			this.Padding = 4;
		}
	}
	
	public class PedidoFabricaPDF
	{
		public string COD_FORNECEDOR;
		public short NRO_PEDIDO;
		public short NRO_PEDIDO_FORNEC;
		public string NOM_PARCEIRO;
		public string DES_LOGRADOURO;
		public string NRO_ENDERECO;
		public string NOM_CIDADE;
		public string COD_ESTADO;
		public string NRO_FONE1;
		public string NRO_FAX;
		public string NRO_CEP;
		public string DES_EMAIL;
		public char IDT_FRETE;
		public string COD_TRANSPORTADORA;
		
		private Document doc;
		private PdfWriter writer;
		private float total;

		private Phrase Frase(string texto, int tamanho)
		{
			Chunk chunk;
			Phrase phrase = new Phrase();
			chunk = new Chunk(texto, FontFactory.GetFont(BaseFont.HELVETICA, tamanho));
			phrase.Add(chunk);
			return phrase;
		}
		
		private Phrase Frase(string texto1, string texto2, int tamanho)
		{
			Chunk chunk;
			Phrase phrase = new Phrase();
			chunk = new Chunk(texto1, FontFactory.GetFont(BaseFont.HELVETICA, tamanho));
			phrase.Add(chunk);
			chunk = new Chunk(texto2, FontFactory.GetFont(BaseFont.HELVETICA_BOLD, tamanho));			
			phrase.Add(chunk);
			return phrase;
		}
		
		private PdfPTable Parte11()
		{
			Tabela table = new Tabela(1);
			PdfPCell cell;
			Chunk chunk;
			string logo = "imagens\\" + COD_FORNECEDOR + ".jpg";
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
			table.AddCell(cell);
			return table;
		}

		private PdfPTable Parte12()
		{
			Tabela table = new Tabela(11);
			Celula cell;
			Chunk chunk;
			chunk = new Chunk("PEDIDO DE FÁBRICA", FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 16));
			cell = new Celula(new Phrase(chunk));
			cell.Padding = 1;
			cell.Colspan = 11;
			table.AddCell(cell);
			
			cell = new Celula(new Phrase(""));
			cell.Padding = 1;
			cell.Colspan = 11;
			table.AddCell(cell);

			chunk = new Chunk("X", FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 16));
			cell = new Celula(new Phrase(chunk));
			cell.Colspan = 1;
			cell.BorderWidth = 1;
			table.AddCell(cell);
			
			chunk = new Chunk("PEDIDO DE VENDA", FontFactory.GetFont(BaseFont.HELVETICA, 8));
			cell = new Celula(new Phrase(chunk));
			cell.Colspan = 4;
			table.AddCell(cell);
			
			cell = new Celula(new Phrase(""));
			cell.Colspan = 1;
			cell.BorderWidth = 1;
			table.AddCell(cell);
			
			chunk = new Chunk("ASSISTÊNCIA TÉCNICA", FontFactory.GetFont(BaseFont.HELVETICA, 8));
			cell = new Celula(new Phrase(chunk));
			cell.Colspan = 5;
			table.AddCell(cell);
			
			cell = new Celula(new Phrase(""));			
			cell.Colspan = 11;
			table.AddCell(cell);
			
			cell = new Celula(new Phrase(""));
			cell.Colspan = 1;
			cell.BorderWidth = 1;
			table.AddCell(cell);
			
			chunk = new Chunk("ALTERÇÃO PEDIDO DE VENDA", FontFactory.GetFont(BaseFont.HELVETICA, 8));
			cell = new Celula(new Phrase(chunk));
			cell.Colspan = 10;
			table.AddCell(cell);
			return table;
		}
		
		private PdfPTable Parte13()
		{
			Tabela table = new Tabela(1);
			Celula cell;
			cell = new Celula(Frase("No PEDIDO FÁBRICA: ", NRO_PEDIDO_FORNEC.ToString(), 10));
			table.AddCell(cell);
			cell = new Celula(Frase("DATA: ", DateTime.Now.ToString("dd/MM/yyyyy"), 10));			
			table.AddCell(cell);
			cell = new Celula(Frase("REPRESENTANTE: ", Globais.sFilial, 10));
			table.AddCell(cell);
			return table;
		}
		
		private PdfPTable Parte14()
		{
			Tabela table = new Tabela(1);
			Celula cell;
			Chunk chunk;
			
			chunk = new Chunk(NOM_PARCEIRO, FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 10));
			cell = new Celula(new Phrase(chunk));
			cell.HorizontalAlignment = Element.ALIGN_RIGHT;
			table.AddCell(cell);
			
			chunk = new Chunk(DES_LOGRADOURO + "," + NRO_ENDERECO + " - " + NOM_CIDADE + " - " + COD_ESTADO, FontFactory.GetFont(BaseFont.HELVETICA, 10));
			cell = new Celula(new Phrase(chunk));
			cell.HorizontalAlignment = Element.ALIGN_RIGHT;
			table.AddCell(cell);

			chunk = new Chunk("Fone: " + FONE.PoeEdicao(NRO_FONE1) + " - Fax: " + FONE.PoeEdicao(NRO_FAX), FontFactory.GetFont(BaseFont.HELVETICA, 10));
			cell = new Celula(new Phrase(chunk));
			cell.HorizontalAlignment = Element.ALIGN_RIGHT;
			table.AddCell(cell);

			chunk = new Chunk("CEP: " + CEP.PoeEdicao(NRO_CEP) + " - " + DES_EMAIL, FontFactory.GetFont(BaseFont.HELVETICA, 10));
			cell = new Celula(new Phrase(chunk));
			cell.HorizontalAlignment = Element.ALIGN_RIGHT;
			table.AddCell(cell);
			return table;
		}
		
		private void Parte1()
		{
			Tabela table = new Tabela(31);
			PdfPCell cell;
			
			cell = new PdfPCell();
			cell.AddElement(Parte11());
			cell.Colspan = 4;
			table.AddCell(cell);
			
			cell = new PdfPCell();
			cell.AddElement(Parte12());
			cell.Colspan = 11;
			table.AddCell(cell);

			cell = new PdfPCell();
			cell.AddElement(Parte13());
			cell.Colspan = 7;
			table.AddCell(cell);

			cell = new PdfPCell();
			cell.AddElement(Parte14());
			cell.Colspan = 9;
			table.AddCell(cell);
			doc.Add(table);
		}

		private void Parte2(Cabecalho2_Pedido cab2)
		{
			Tabela table = new Tabela(31);			
			Celula cell;

			// linha1
			cell = new Celula(Frase("CLIENTE: ", cab2.cliente, 10));
			cell.Colspan = 22;
			table.AddCell(cell);
			
			cell = new Celula(Frase("CONTATO: ", cab2.contato, 10));
			cell.Colspan = 22;
			table.AddCell(cell);
			
			// linha2			
			cell = new Celula(Frase("ENDEREÇO: ", cab2.endereco + "," + cab2.numero, 10));
			cell.Colspan = 22;
			table.AddCell(cell);
			
			cell = new Celula(Frase("E-mail: ", cab2.email, 10));
			cell.Colspan = 9;
			table.AddCell(cell);
			
			// linha3
			cell = new Celula(Frase("BAIRRO: ", cab2.bairro, 10));
			cell.Colspan = 11;
			table.AddCell(cell);
			
			cell = new Celula(Frase("CIDADE: ", cab2.cidade, 10));
			cell.Colspan = 11;
			table.AddCell(cell);
			
			cell = new Celula(Frase("UF: ", cab2.estado, 10));
			cell.Colspan = 5;
			table.AddCell(cell);
			
			cell = new Celula(Frase("CEP: ", CEP.PoeEdicao(cab2.cep), 10));
			cell.Colspan = 4;
			table.AddCell(cell);

			// linha4
			cell = new Celula(Frase("CNPJ: ", cab2.cnpj, 10));
			cell.Colspan = 11;
			table.AddCell(cell);
			
			cell = new Celula(Frase("INCRIÇÃO ESTADUAL: ", cab2.ie, 10));
			cell.Colspan = 16;
			table.AddCell(cell);
			
			cell = new Celula(Frase("FONE: ", FONE.PoeEdicao(cab2.fone), 10));
			cell.Colspan = 4;
			table.AddCell(cell);
			
			// linha4
			if (cab2.entrega.Trim().Length > 0)
			{
				cell = new Celula(Frase("LOCAL DE ENTREGA: ", 
				                        cab2.entrega.Trim() + "," + cab2.numero_entrega.Trim() + " - " + 
				                        cab2.compl_entrega.Trim() + " - " +
				                        cab2.bairro_entrega.Trim() + " - " + cab2.cidade_entrega.Trim() + 
				                        cab2.estado_entrega.Trim() + " - " +
				                        CEP.PoeEdicao(cab2.cep_entrega), 10));
			}
			else
			{
				cell = new Celula(Frase("LOCAL DE ENTREGA: ", "IDEM", 10));
			}
			cell.Colspan = 31;
			table.AddCell(cell);
			
			// linha5
			if (cab2.cobranca.Trim().Length > 0)
			{
				cell = new Celula(Frase("LOCAL DE COBRANÇA: ", 
				                        cab2.cobranca.Trim() + "," + cab2.numero_cobranca.Trim() + " - " + 
				                        cab2.compl_cobranca.Trim() + " - " +
				                        cab2.bairro_cobranca.Trim() + " - " + cab2.cidade_cobranca.Trim() + 
				                        cab2.estado_cobranca.Trim() + " - " +
				                        CEP.PoeEdicao(cab2.cep_cobranca), 10));
			}
			else
			{
				cell = new Celula(Frase("LOCAL DE COBRANÇA: ", "IDEM", 10));
			}
			cell.Colspan = 31;
			table.AddCell(cell);
			
			// linha6
			cell = new Celula(Frase("FRETE: % ", 10));
			cell.Colspan = 5;
			table.AddCell(cell);

			if (IDT_FRETE == 'C')
			{
				cell = new Celula(new Phrase(""));
			}
			else
			{
				Chunk chunk = new Chunk("X", FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 16));				
				cell = new Celula(new Phrase(chunk));
			}
			cell.Colspan = 1;
			cell.BorderWidth = 1;
			table.AddCell(cell);
			
			cell = new Celula(Frase("FORNECEDOR", 10));
			cell.Colspan = 4;
			table.AddCell(cell);
			
			if (IDT_FRETE == 'C')			
			{
				Chunk chunk = new Chunk("X", FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 16));				
				cell = new Celula(new Phrase(chunk));
			}
			else
			{
				cell = new Celula(new Phrase(""));				
			}
			cell.Colspan = 1;
			cell.BorderWidth = 1;
			table.AddCell(cell);
		
			cell = new Celula(Frase("CLIENTE", 10));
			cell.Colspan = 4;
			table.AddCell(cell);
			
			cell = new Celula(Frase("TRANSPORTADORA: ", "", 10));
			cell.Colspan = 12;
			table.AddCell(cell);
			
			cell = new Celula(Frase("FONE: ", "", 10));
			cell.Colspan = 5;
			table.AddCell(cell);

			// linha7
			cell = new Celula(Frase("CONDIÇÕES DE PAGAMENTO: ", "", 10));
			cell.Colspan = 8;
			table.AddCell(cell);
			
			cell = new Celula(Frase("SINAL-R$ ", "", 10));
			cell.Colspan = 5;
			table.AddCell(cell);
			
			cell = new Celula(Frase("PARCELAS 1-R$ ", "", 10));
			cell.Colspan = 6;
			table.AddCell(cell);
			
			cell = new Celula(Frase("2-R$ ", "", 10));
			cell.Colspan = 4;
			table.AddCell(cell);
			
			cell = new Celula(Frase("3-R$ ", "", 10));
			cell.Colspan = 4;
			table.AddCell(cell);			
			
			cell = new Celula(Frase("4-R$ ", "", 10));
			cell.Colspan = 4;
			table.AddCell(cell);			
			
			// linha8
			cell = new Celula(Frase("SAÍDA DA FÁBRICA: ", "", 10));
			cell.Colspan = 19;
			table.AddCell(cell);			
			
			cell = new Celula(Frase("DESCONTO: ", "", 10));
			cell.Colspan = 5;
			table.AddCell(cell);			
			
			cell = new Celula(Frase("ENC FINANCEIRO: ", "", 10));
			cell.Colspan = 7;
			table.AddCell(cell);			
			doc.Add(table);
		}

		private void Parte3(ArrayList areas, bool mostrar_valores)
		{
			
			CelulaCabecalho cell;
			CelulaItem cellI;			
			Tabela table = new Tabela(mostrar_valores ? 31 : 24);
			
			// cabecalho
			cell = new CelulaCabecalho(Frase("ITEM", 10));
			cell.Colspan = 1;
			table.AddCell(cell);			
			
			cell = new CelulaCabecalho(Frase("QTD", 10));
			cell.Colspan = 1;
			table.AddCell(cell);
			
			cell = new CelulaCabecalho(Frase("COD FIXO", 10));
			cell.Colspan = 2;
			table.AddCell(cell);
			
			cell = new CelulaCabecalho(Frase("COD VARIÁVEL", 10));
			cell.Colspan = 5;
			table.AddCell(cell);
			
			cell = new CelulaCabecalho(Frase("DESCRIÇÃO", 10));
			cell.Colspan = 11;
			table.AddCell(cell);
			
			cell = new CelulaCabecalho(Frase("MEDIDA", 10));
			cell.Colspan = 4;
			table.AddCell(cell);
			
			if (mostrar_valores)
			{
				cell = new CelulaCabecalho(Frase("R$ UNIT S/IPI", 10));
				cell.Colspan = 3;
				cell.HorizontalAlignment = Element.ALIGN_RIGHT;
				table.AddCell(cell);
			
				cell = new CelulaCabecalho(Frase("IPI%", 10));
				cell.Colspan = 1;
				table.AddCell(cell);
			
				cell = new CelulaCabecalho(Frase("R$ TOTAL C/IPI", 10));
				cell.Colspan = 3;
				cell.HorizontalAlignment = Element.ALIGN_RIGHT;
				table.AddCell(cell);
			}
			
			total=0;
			int seq=0;
			foreach (Area area in areas)
			{
				foreach (Item item in area.itens)
				{
					// itens
					char letra = (char)((int)'A' + seq++);
					string s = letra.ToString();
					cellI = new CelulaItem(Frase(s, 10)); // item
					cellI.Colspan = 1;
					table.AddCell(cellI);			
			
					cellI = new CelulaItem(Frase(item.qtde.ToString(), 10)); // qtd
					cellI.Colspan = 1;
					table.AddCell(cellI);
			
					cellI = new CelulaItem(Frase(item.codigo, 10)); // fixo
					cellI.Colspan = 2;
					table.AddCell(cellI);
			
					cellI = new CelulaItem(Frase(item.especificos, 10)); // variavel
					cellI.Colspan = 5;
					table.AddCell(cellI);
			
					cellI = new CelulaItem(Frase(item.descricao, 10)); // descricao
					cellI.Colspan = 11;
					table.AddCell(cellI);
				
					cellI = new CelulaItem(Frase(item.medidas, 10)); // medida
					cellI.Colspan = 4;
					table.AddCell(cellI);
			
					if (mostrar_valores)
					{
						cellI = new CelulaItem(Frase(item.vlr_semipi.ToString("###,###,##0.00"), 10)); // sem ipi
						cellI.Colspan = 3;
						cellI.HorizontalAlignment = Element.ALIGN_RIGHT;
						table.AddCell(cellI);
			
						cellI = new CelulaItem(Frase(item.ipi.ToString(), 10)); // ipi
						cellI.Colspan = 1;
						table.AddCell(cellI);
			
						cellI = new CelulaItem(Frase(item.vlr_unitario.ToString("###,###,##0.00"), 10)); // com ipi
						cellI.Colspan = 3;
						cellI.HorizontalAlignment = Element.ALIGN_RIGHT;
						table.AddCell(cellI);
					}
					
					total += item.vlr_unitario;
				}
			}
			doc.Add(table);			
		}

		private  void Parte4(Cabecalho2_Pedido cab2, bool mostrar_valores)
		{
			Chunk chunk;
			Celula cell;
			Tabela table = new Tabela(31);

			// linha1
			cell = new Celula(Frase("", 10));
			cell.Colspan = mostrar_valores ? 22 : 31;
			table.AddCell(cell);

			if (mostrar_valores)
			{
				chunk = new Chunk("TOTAL GERAL COM IPI", FontFactory.GetFont(BaseFont.HELVETICA, 10));	
				cell = new Celula(new Phrase(chunk));
				cell.Colspan = 6;
				table.AddCell(cell);
			
				chunk = new Chunk(total.ToString("###,###,##0.00"), FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 10));	
				cell = new Celula(new Phrase(chunk));
				cell.HorizontalAlignment = Element.ALIGN_RIGHT;
				cell.BorderWidth = 1;
				cell.Colspan = 3;
				table.AddCell(cell);
			}

			// linha2
			chunk = new Chunk("No PEDIDO REPRESENTANTE", FontFactory.GetFont(BaseFont.HELVETICA, 10));	
			cell = new Celula(new Phrase(chunk));
			cell.Colspan = 4;
			table.AddCell(cell);
			
			chunk = new Chunk(NRO_PEDIDO.ToString(), FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 10));
			cell = new Celula(new Phrase(chunk));
			cell.Colspan = 4;
			cell.BorderWidth = 1;
			cell.HorizontalAlignment = Element.ALIGN_CENTER;
			table.AddCell(cell);
			
			cell = new Celula(new Phrase(""));
			cell.Colspan = 1;
			table.AddCell(cell);
			
			chunk = new Chunk("No O.C. CLIENTE", FontFactory.GetFont(BaseFont.HELVETICA, 10));	
			cell = new Celula(new Phrase(chunk));
			cell.Colspan = 4;
			table.AddCell(cell);
			
			cell = new Celula(new Phrase(""));
			cell.Colspan = 4;
			cell.BorderWidth = 1;
			table.AddCell(cell);
			
			cell = new Celula(new Phrase(""));
			cell.Colspan = 1;
			table.AddCell(cell);
			
			chunk = new Chunk("No PED ESPECIAL", FontFactory.GetFont(BaseFont.HELVETICA, 10));	
			cell = new Celula(new Phrase(chunk));
			cell.Colspan = 5;
			table.AddCell(cell);
			
			cell = new Celula(new Phrase(""));
			cell.Colspan = 4;
			cell.BorderWidth = 1;
			table.AddCell(cell);
			
			cell = new Celula(new Phrase(""));
			cell.Colspan = 4;
			table.AddCell(cell);

			// linha3
			string observacao = cab2.observacao;
			string[] linhas = observacao.Split('\n');
			int lin=0;
			foreach (string linha in linhas)
			{
				if (++lin == 1)
				{
					chunk = new Chunk("OBS: ", FontFactory.GetFont(BaseFont.HELVETICA, 10));					
				}
				else
				{
					chunk = new Chunk("", FontFactory.GetFont(BaseFont.HELVETICA, 10));					
				}
				cell = new Celula(new Phrase(chunk));
				cell.Colspan = 2;
				cell.VerticalAlignment = Element.ALIGN_BOTTOM;
				table.AddCell(cell);
				
				chunk = new Chunk(linha, FontFactory.GetFont(BaseFont.HELVETICA, 10));					
				cell = new Celula(new Phrase(chunk));
				cell.Colspan = 29;
				cell.VerticalAlignment = Element.ALIGN_BOTTOM;
				cell.BorderWidthBottom = 1;				
				table.AddCell(cell);
			}
/*			
			chunk = new Chunk("OBS:", FontFactory.GetFont(BaseFont.HELVETICA, 10));	
			cell = new Celula(new Phrase(chunk));
			cell.Colspan = 2;
			cell.VerticalAlignment = Element.ALIGN_BOTTOM;
			table.AddCell(cell);
			
			chunk = new Chunk(cab2.observacao, FontFactory.GetFont(BaseFont.HELVETICA, 10));	
			cell = new Celula(new Phrase(chunk));
			cell.Colspan = 29;
			cell.BorderWidthBottom = 1;
			table.AddCell(cell);
			
			// linha4
			cell = new Celula(new Phrase(""));
			cell.Colspan = 31;
			cell.BorderWidthBottom = 1;
			table.AddCell(cell);
*/						
			// linha5
			cell = new Celula(new Phrase(""));
			cell.Colspan = 31;
			table.AddCell(cell);
			
			chunk = new Chunk("PEDIDO APROVADO", FontFactory.GetFont(BaseFont.HELVETICA, 10));	
			cell = new Celula(new Phrase(chunk));
			cell.Colspan = 5;
			table.AddCell(cell);
			
			cell = new Celula(new Phrase(""));
			cell.Colspan = 1;
			cell.BorderWidth = 1;
			table.AddCell(cell);
			
			chunk = new Chunk("SIM", FontFactory.GetFont(BaseFont.HELVETICA, 10));	
			cell = new Celula(new Phrase(chunk));
			cell.Colspan = 2;
			table.AddCell(cell);
			
			cell = new Celula(new Phrase(""));
			cell.Colspan = 1;
			cell.BorderWidth = 1;
			table.AddCell(cell);
			
			chunk = new Chunk("NÃO", FontFactory.GetFont(BaseFont.HELVETICA, 10));	
			cell = new Celula(new Phrase(chunk));
			cell.Colspan = 2;
			table.AddCell(cell);
			
			chunk = new Chunk("ASS. CLIENTE:", FontFactory.GetFont(BaseFont.HELVETICA, 10));	
			cell = new Celula(new Phrase(chunk));
			cell.Colspan = 4;
			cell.VerticalAlignment = Element.ALIGN_BOTTOM;
			table.AddCell(cell);
			
			cell = new Celula(new Phrase(""));
			cell.Colspan = 6;
			cell.BorderWidthBottom = 1;
			table.AddCell(cell);
			
			chunk = new Chunk("ASS. REPRES:", FontFactory.GetFont(BaseFont.HELVETICA, 10));	
			cell = new Celula(new Phrase(chunk));
			cell.Colspan = 4;
			cell.VerticalAlignment = Element.ALIGN_BOTTOM;
			table.AddCell(cell);
			
			cell = new Celula(new Phrase(""));
			cell.Colspan = 6;
			cell.BorderWidthBottom = 1;
			table.AddCell(cell);
			
			doc.Add(table);
		}
		
		public void Gera(string arquivo, Cabecalho2_Pedido cab2, cOrcamentoPDF pdf_orcamento, bool mostrar_valores, bool mostrar_subcodigo)
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
			Parte1();
			Parte2(cab2);			
			Parte3(pdf_orcamento.areas, mostrar_valores);
			Parte4(cab2, mostrar_valores);
			doc.Close();
			fs.Close();
		}
	}
}
