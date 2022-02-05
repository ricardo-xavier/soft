/*
 * Gerador de Gráficos
 * Autor: Ricardo Costa Xavier
 * Data : 14/06/2010
 */
using System;
using System.Collections;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace classes
{
	/// <summary>
	/// Classe para geração de gráficos
	/// </summary>
	public static class Graficos
	{		
		private static Phrase Frase(string texto1, string texto2, int tamanho)
		{
			Chunk chunk;
			Phrase phrase = new Phrase();
			chunk = new Chunk(texto1, FontFactory.GetFont(BaseFont.HELVETICA, tamanho));
			phrase.Add(chunk);
			chunk = new Chunk(texto2, FontFactory.GetFont(BaseFont.HELVETICA_BOLD, tamanho));			
			phrase.Add(chunk);
			return phrase;
		}		
		
		private static PdfPTable Parte11()
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

		private static PdfPTable Parte12(string titulo, string sub_titulo)
		{
			Tabela table = new Tabela(1);
			Celula cell;
			Chunk chunk;
			chunk = new Chunk(titulo, FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 16));
			cell = new Celula(new Phrase(chunk));
			cell.Padding = 1;
			//cell.Colspan = 11;
			table.AddCell(cell);
			chunk = new Chunk(sub_titulo, FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 16));
			cell = new Celula(new Phrase(chunk));
			cell.Padding = 1;
			//cell.Colspan = 11;
			table.AddCell(cell);			
			return table;
		}
		
		private static PdfPTable Parte13()
		{
			Tabela table = new Tabela(1);
			Celula cell;
			cell = new Celula(Frase("DATA: ", DateTime.Now.ToString("dd/MM/yyyyy"), 10));			
			table.AddCell(cell);
			return table;
		}
		
		public static void Cabecalho(Document doc, string titulo, string sub_titulo)
		{
			Tabela table = new Tabela(22);
			PdfPCell cell;
			
			cell = new PdfPCell();
			cell.AddElement(Parte11());
			cell.Colspan = 4;
			table.AddCell(cell);			
			
			cell = new PdfPCell();
			cell.AddElement(Parte12(titulo, sub_titulo));
			cell.Colspan = 11;
			table.AddCell(cell);

			cell = new PdfPCell();
			cell.AddElement(Parte13());
			cell.Colspan = 7;
			table.AddCell(cell);

			doc.Add(table);
		}
		
		private static void Legenda(PdfContentByte cb, int i, float valor, string label, int[,] cores, float xCentro, float yCentro, float raio)
		{
			float h = PageSize.LETTER.Width; // paisagem
			float w = PageSize.LETTER.Height;
			float x = xCentro + raio + 200;
			float y = h - yCentro + raio - (22 * i);
			
			cb.SetRGBColorFill(0, 0, 0);
			cb.BeginText();
			cb.SetTextMatrix(x-100, y-10);
			cb.ShowText(valor.ToString("###,###,##0.00").PadLeft(14));
			cb.EndText();
			
			cb.BeginText();
			cb.SetTextMatrix(x+40, y-10);
			cb.ShowText(label);
			cb.EndText(); 					
			
			cb.SetRGBColorFill(cores[i,0], cores[i,1], cores[i,2]);			
			cb.MoveTo(x, y);
			cb.LineTo(x+20, y);
			cb.LineTo(x+20, y-10);
			cb.LineTo(x, y-10);
			cb.LineTo(x, y);
			cb.FillStroke();
		}
		
		public static void Pizza(PdfContentByte cb, ArrayList valores, ArrayList labels, float xCentro, float yCentro, float raio)
		{
			float h = PageSize.LETTER.Width; // paisagem
			float w = PageSize.LETTER.Height;
			cb.SetFontAndSize(BaseFont.CreateFont(BaseFont.COURIER, BaseFont.CP1252, BaseFont.NOT_EMBEDDED), 10);
			
			float total=0;			
			foreach (float valor in valores)
			{
				total += valor;
			}

			int[,] cores = new int[,] 
			{
				{ 255, 0, 0 },				
				{ 0, 255, 0 },
				{ 0, 0, 255 },
				{ 255, 255, 0 },
				{ 255, 0, 255 },
				{ 0, 255, 255 },
				{ 255, 128, 0 },
				{ 0, 255, 128 },
				{ 128, 0, 255 },
				{ 255, 128, 128 },
				{ 128, 255, 128 },
				{ 128, 128, 255 }				
			};

			int i = 0;      
			float _dx = 0;
			float _dy = 0;
			float _a = 0;
			foreach (float valor in valores)
			{
				float a = valor * 360 / total;
				double coseno = System.Math.Cos((a+_a) * System.Math.PI / 180);
				double seno = System.Math.Sin((a+_a) * System.Math.PI / 180);
				float dx = (float)(raio * coseno);
				float dy = (float)(raio * seno);
				if (valor != 0)
				{
					cb.SetRGBColorFill(cores[i,0], cores[i,1], cores[i,2]);
					cb.MoveTo(xCentro, h - yCentro);
					cb.LineTo(xCentro+_dx, h-yCentro+_dy);
					cb.Arc(xCentro-raio, h-yCentro+raio, xCentro+raio, h-yCentro-raio, _a, a);
					cb.LineTo(xCentro, h-yCentro);
					cb.FillStroke();		
				}
				_dx = dx;
				_dy = dy;
				_a += a;				
				Legenda(cb, i, valor, labels[i].ToString(), cores, xCentro, yCentro, raio);
				i++;
			}
		}
		
		public static void Barras(PdfContentByte cb, ArrayList valores, ArrayList labels, float y0, float max) 
		{				
			float h = PageSize.LETTER.Width; // paisagem
			float w = PageSize.LETTER.Height;
			cb.SetFontAndSize(BaseFont.CreateFont(BaseFont.COURIER, BaseFont.CP1252, BaseFont.NOT_EMBEDDED), 10);
			
			cb.MoveTo(110, h-10-y0);
			cb.LineTo(110, h-320-y0);
			for (int y=320; y>=20; y-=30)
			{
				cb.MoveTo(100, h-y-y0);
				cb.LineTo(620, h-y-y0);
			}
			for (int x=110; x<=620; x+=40)
			{
				cb.MoveTo(x, h-320-y0);
				cb.LineTo(x, h-325-y0);
			}			
			cb.FillStroke();					
			
			float vlr=100;
			while (vlr < max) vlr *= 2;
			float d = vlr / 10;			
			vlr = 0;
			for (int y=320; y>=20; y-=30)
			{
				cb.BeginText();
				cb.SetTextMatrix(10, h-y-y0);
				cb.ShowText(vlr.ToString("###,###,##0.00").PadLeft(14));
				vlr += d;
				cb.EndText();
			}
			
			int[,] cores = new int[,] 
			{
				{ 255, 0, 0 },				
				{ 0, 255, 0 },
				{ 0, 0, 255 },
				{ 255, 255, 0 },
				{ 255, 0, 255 },
				{ 0, 255, 255 },
				{ 255, 128, 0 },
				{ 0, 255, 128 },
				{ 128, 0, 255 },
				{ 255, 128, 128 },
				{ 128, 255, 128 },
				{ 128, 128, 255 }				
			};
			
			int i=0;
			foreach (float valor in valores)
			{
				Legenda(cb, i, valor, labels[i].ToString(), cores, 500, y0, 0);
				i++;
			}
			
			i = 0;
			int x1=115;
			int y1;
			foreach (string descricao in labels)
			{
				int j = 0;
				string valor="";
				foreach (float v in valores)
				{
					valor = v.ToString("#,###,##0.00");
					if (j++ == i) break;
				}
				
				cb.SetRGBColorFill(cores[i,0], cores[i,1], cores[i,2]);
				y1 = (int)(Globais.StrToFloat(valor) / d * 30);
				cb.Rectangle(x1, h-y0-319, 30, y1);
				cb.Fill();
				x1 += 40;
				i++;
			}			
		}
	}	
}
