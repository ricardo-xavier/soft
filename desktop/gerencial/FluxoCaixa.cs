/*
 * Sistema Gerencial
 * Fluxo de Caixa
 * Autor: Ricardo Costa Xavier
 * Data : 30/06/2010
 */
using System;
using FirebirdSql.Data.FirebirdClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data;
using classes;
using pdf;

namespace gerencial
{
	/// <summary>
	/// Fluxo de Caixa
	/// </summary>
	public class FluxoCaixa
	{
		public FluxoCaixa()
		{
		}
		
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
			table.AddCell(cell);
			return table;
		}		

		private PdfPTable Parte12(string titulo, bool idt_inicial, DateTime data_inicial, bool idt_final, DateTime data_final)
		{
			Tabela table = new Tabela(1);
			Celula cell;
			Chunk chunk;
			chunk = new Chunk(titulo, FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 16));
			cell = new Celula(new Phrase(chunk));
			cell.Padding = 1;
			//cell.Colspan = 11;
			table.AddCell(cell);
			if (idt_inicial || idt_final)
			{
				string periodo = "Período: ";
				if (idt_inicial && idt_final)
				{
					periodo += "de " + data_inicial.ToString("dd/MM/yyyy") + " até " + data_final.ToString("dd/MM/yyyy");
				}
				else
				{
					if (idt_inicial)
					{
						periodo += "a partir de " + data_inicial.ToString("dd/MM/yyyy");
					}
					else
					{
						periodo += "até " + data_final.ToString("dd/MM/yyyy");
					}
				}					
				chunk = new Chunk(periodo, FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 14));
				cell = new Celula(new Phrase(chunk));
				cell.Padding = 1;
				//cell.Colspan = 11;
				table.AddCell(cell);				
			}

			return table;
		}
		
		private PdfPTable Parte13()
		{
			Tabela table = new Tabela(1);
			Celula cell;
			cell = new Celula(Frase("DATA: ", DateTime.Now.ToString("dd/MM/yyyyy"), 10));			
			table.AddCell(cell);
			cell = new Celula(Frase("FILIAL: ", Globais.sFilial, 10));			
			table.AddCell(cell);
			return table;
		}
		
		public void Parte1(PDF pdf, string titulo, bool idt_inicial, DateTime data_inicial, bool idt_final, DateTime data_final)
		{
			Tabela table = new Tabela(22);
			PdfPCell cell;
			
			cell = new PdfPCell();
			cell.AddElement(Parte11());
			cell.Colspan = 4;
			table.AddCell(cell);
			
			cell = new PdfPCell();
			cell.AddElement(Parte12(titulo, idt_inicial, data_inicial, idt_final, data_final));
			cell.Colspan = 11;
			table.AddCell(cell);

			cell = new PdfPCell();
			cell.AddElement(Parte13());
			cell.Colspan = 7;
			table.AddCell(cell);

			pdf.doc.Add(table);
		}
		
		public void AdicionaCelula(Tabela tabela, string texto, string BaseFont_, int tamanho, int alinhamento, int colunas)
		{
			Chunk chunk = new Chunk(texto, FontFactory.GetFont(BaseFont_, tamanho));
			PdfPCell cell = new PdfPCell(new Paragraph(chunk));
			cell.HorizontalAlignment = alinhamento;	
			cell.Colspan = colunas;
			tabela.AddCell(cell);
		}		
		
		public void AdicionaCelula(Tabela tabela, string texto, string BaseFont_, int tamanho, iTextSharp.text.Color cor, int colunas)
		{
			Chunk chunk = new Chunk(texto, FontFactory.GetFont(BaseFont_, tamanho));
			PdfPCell cell = new PdfPCell(new Paragraph(chunk));
			cell.BackgroundColor = cor;
			cell.Colspan = colunas;
			tabela.AddCell(cell);
		}		
		
		public void AdicionaCelula(Tabela tabela, string texto, string BaseFont_, int tamanho, Color cor, int alinhamento, int colunas)
		{
			Chunk chunk = new Chunk(texto, FontFactory.GetFont(BaseFont_, tamanho));
			PdfPCell cell = new PdfPCell(new Paragraph(chunk));
			cell.BackgroundColor = cor;
			cell.HorizontalAlignment = alinhamento;				
			cell.Colspan = colunas;
			tabela.AddCell(cell);
		}
				
		public bool Gera(string arquivo, string titulo, float valor_inicial, bool idt_inicial, DateTime data_inicial, bool idt_final, DateTime data_final,
		                bool vencimento)
		{	
			PDF pdf = new PDF(arquivo);
			pdf.Abre();
			Parte1(pdf, titulo, idt_inicial, data_inicial, idt_final, data_final);
			
			string whereP1="where P.DAT_PAGAMENTO is not null ";
			string whereR1="where R.DAT_RECEBIMENTO is not null ";
			string whereP2="where P.DAT_PAGAMENTO is null and P.DAT_VENCIMENTO is not null ";
			string whereR2="where R.DAT_RECEBIMENTO is null and R.DAT_VENCIMENTO is not null ";
			
			if (idt_inicial || idt_final) 
			{
				if (idt_inicial && idt_final)
				{
					whereP1 += "and (P.DAT_PAGAMENTO between '" + data_inicial.ToString("M/d/yyyy") + "' and '" + data_final.ToString("M/d/yyyy") + "') ";
					whereR1 += "and (R.DAT_RECEBIMENTO between '" + data_inicial.ToString("M/d/yyyy") + "' and '" + data_final.ToString("M/d/yyyy") + "') ";
					whereP2 += "and (P.DAT_VENCIMENTO between '" + data_inicial.ToString("M/d/yyyy") + "' and '" + data_final.ToString("M/d/yyyy") + "') ";
					whereR2 += "and (R.DAT_VENCIMENTO between '" + data_inicial.ToString("M/d/yyyy") + "' and '" + data_final.ToString("M/d/yyyy") + "') ";
				}
				else
				{
					if (idt_inicial)
					{
						whereP1 += "and (P.DAT_PAGAMENTO >= '" + data_inicial.ToString("M/d/yyyy") + "') ";
						whereR1 += "and (R.DAT_RECEBIMENTO >= '" + data_inicial.ToString("M/d/yyyy") + "') ";				
						whereP2 += "and (P.DAT_VENCIMENTO >= '" + data_inicial.ToString("M/d/yyyy") + "') ";
						whereR2 += "and (R.DAT_VENCIMENTO >= '" + data_inicial.ToString("M/d/yyyy") + "') ";						
					}
					else
					{
						whereP1 += "and (P.DAT_PAGAMENTO <= '" + data_final.ToString("M/d/yyyy") + "') ";
						whereR1 += "and (R.DAT_RECEBIMENTO <= '" + data_final.ToString("M/d/yyyy") + "') ";		
						whereP2 += "and (P.DAT_VENCIMENTO <= '" + data_final.ToString("M/d/yyyy") + "') ";
						whereR2 += "and (R.DAT_VENCIMENTO <= '" + data_final.ToString("M/d/yyyy") + "') ";												
					}
				}
			}
			string sql = 
				"select 'P'," +
				"P.DAT_PAGAMENTO," +
				"P.VLR_PAGO," +				
				"P.COD_PARCEIRO," +
				"P.COD_TITULO," +
				"0," +
				"N.DES_NATUREZA," +
				"P.COD_FORMA," +
				"P.COD_DOC_ORIGEM," +
				"P.COD_DOC_GERADO," +
				"P.COD_FUNCIONARIO " +
				"from TITULOS_PAGAR P " +
				"inner join naturezas_pagamento N on N.COD_NATUREZA=P.COD_NATUREZA " +
				whereP1 +
				
				"union " +
				"select 'P'," +
				"P.DAT_VENCIMENTO," +
				"P.VLR_PAGO," +				
				"P.COD_PARCEIRO," +
				"P.COD_TITULO," +
				"0," +
				"N.DES_NATUREZA," +
				"P.COD_FORMA," +
				"P.COD_DOC_ORIGEM," +
				"P.COD_DOC_GERADO," +
				"P.COD_FUNCIONARIO " +
				"from TITULOS_PAGAR P " +
				"inner join naturezas_pagamento N on N.COD_NATUREZA=P.COD_NATUREZA " +
				whereP2 +
				
				"union " +
				"select 'R'," +
				"R.DAT_RECEBIMENTO," +
				"R.VLR_RECEBIDO," +
				"R.COD_CLIENTE," +
				"R.NRO_NF," +
				"R.SEQ_TITULO," +
				"N.DES_NATUREZA," +
				"R.COD_FORMA," +
				"''," +
				"''," +
				"'' " +
				"from TITULOS_RECEBER R " +
				"inner join naturezas_recebimento N on N.COD_NATUREZA=R.COD_NATUREZA " +
				whereR1 +
								
				"union " +
				"select 'R'," +
				"R.DAT_VENCIMENTO," +
				"R.VLR_RECEBIDO," +
				"R.COD_CLIENTE," +
				"R.NRO_NF," +
				"R.SEQ_TITULO," +
				"N.DES_NATUREZA," +
				"R.COD_FORMA," +
				"''," +
				"''," +
				"'' " +
				"from TITULOS_RECEBER R " +
				"inner join naturezas_recebimento N on N.COD_NATUREZA=R.COD_NATUREZA " +
				whereR2 +
				
				"order by 2";				
			FbCommand cmd = new FbCommand(sql, Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			
			string tipo;			
			float valor;
			float debito;
			float credito;
			float total=valor_inicial;
			float tot_deb=0;
			float tot_cre=0;
			DateTime data;
			string parceiro;
			string titulo_nf;
			string gerado;
			string funcionario;
			string natureza;
			string forma;
			Tabela table = new Tabela(11);
			AdicionaCelula(table, "Saldo Inicial", BaseFont.HELVETICA_BOLD, 8, Color.GRAY, 10);
			AdicionaCelula(table, total.ToString("#,###,##0.00"), BaseFont.HELVETICA, 8, Color.GRAY, Element.ALIGN_RIGHT, 1);
			AdicionaCelula(table, "Data", BaseFont.HELVETICA_BOLD, 8, iTextSharp.text.Color.LIGHT_GRAY, 1);
			AdicionaCelula(table, "Doc Origem", BaseFont.HELVETICA_BOLD, 8, iTextSharp.text.Color.LIGHT_GRAY, 1);
			AdicionaCelula(table, "Doc Gerado", BaseFont.HELVETICA_BOLD, 8, iTextSharp.text.Color.LIGHT_GRAY, 1);
			AdicionaCelula(table, "Parceiro/Funcionário", BaseFont.HELVETICA_BOLD, 8, iTextSharp.text.Color.LIGHT_GRAY, 2);
			AdicionaCelula(table, "Natureza", BaseFont.HELVETICA_BOLD, 8, iTextSharp.text.Color.LIGHT_GRAY, 2);
			AdicionaCelula(table, "Forma Pagto", BaseFont.HELVETICA_BOLD, 8, iTextSharp.text.Color.LIGHT_GRAY, 1);
			AdicionaCelula(table, "Débito", BaseFont.HELVETICA_BOLD, 8, iTextSharp.text.Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 1);
			AdicionaCelula(table, "Crédito", BaseFont.HELVETICA_BOLD, 8, iTextSharp.text.Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 1);
			AdicionaCelula(table, "Saldo", BaseFont.HELVETICA_BOLD, 8, iTextSharp.text.Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 1);
			
			while (reader.Read())
			{
				tipo = reader.GetString(0);
				data = reader.GetDateTime(1);
				valor = reader.GetFloat(2);
				parceiro = reader.GetString(3);
				natureza = reader.GetString(6);
				forma = reader.GetString(7);
				gerado = reader.GetString(9);
				funcionario = reader.GetString(10);
				if (tipo.Equals("P"))
				{
					total -= valor;
					tot_deb += valor;
					debito = valor;					
					credito = 0;
					titulo_nf = reader.GetString(8);
				}
				else
				{
					total += valor;
					tot_cre += valor;
					debito = 0;
					credito = valor;					
					titulo_nf = reader.GetString(4).Trim() + "/" + reader.GetInt16(5).ToString();
				}				
				AdicionaCelula(table, data.ToString("dd/MM/yyyy"), BaseFont.HELVETICA, 8, Element.ALIGN_LEFT, 1);
				AdicionaCelula(table, titulo_nf, BaseFont.HELVETICA, 8, Element.ALIGN_LEFT, 1);
				AdicionaCelula(table, gerado, BaseFont.HELVETICA, 8, Element.ALIGN_LEFT, 1);
				AdicionaCelula(table, parceiro.Trim()+funcionario, BaseFont.HELVETICA, 8, Element.ALIGN_LEFT, 2);
				AdicionaCelula(table, natureza, BaseFont.HELVETICA, 8, Element.ALIGN_LEFT, 2);
				AdicionaCelula(table, forma, BaseFont.HELVETICA, 8, Element.ALIGN_LEFT, 1);
				AdicionaCelula(table, debito.ToString("#,###,##0.00"), BaseFont.HELVETICA, 8, Element.ALIGN_RIGHT, 1);
				AdicionaCelula(table, credito.ToString("#,###,##0.00"), BaseFont.HELVETICA, 8, Element.ALIGN_RIGHT, 1);
				AdicionaCelula(table, total.ToString("#,###,##0.00"), BaseFont.HELVETICA, 8, Element.ALIGN_RIGHT, 1);
			}
			AdicionaCelula(table, "Saldo Final", BaseFont.HELVETICA_BOLD, 8, Color.GRAY, 8);
			AdicionaCelula(table, tot_deb.ToString("#,###,##0.00"), BaseFont.HELVETICA, 8, Color.GRAY, Element.ALIGN_RIGHT, 1);
			AdicionaCelula(table, tot_cre.ToString("#,###,##0.00"), BaseFont.HELVETICA, 8, Color.GRAY, Element.ALIGN_RIGHT, 1);
			AdicionaCelula(table, total.ToString("#,###,##0.00"), BaseFont.HELVETICA, 8, Color.GRAY, Element.ALIGN_RIGHT, 1);
			pdf.doc.Add(table);
			reader.Close();			
			pdf.Fecha();
			return true;
		}
	}
}
