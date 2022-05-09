/*
 * Classe para geração de PDF com iTextSharp
 * Autor: Ricardo Costa Xavier
 * Data: 11/06/08
 * 
 */

using System;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace pdf
{
	public class PDF
	{
		public Document doc;
		private PdfWriter writer;
		private PdfContentByte buf;
		private float altura_pagina;
		private float largura_pagina;
		public Table tabela;

		public PDF(string arquivo)
		{
			FileStream fs = new FileStream(arquivo, FileMode.Create);
			doc = new Document(PageSize.LETTER.Rotate());
			writer = PdfWriter.GetInstance(doc, fs);
			altura_pagina = PageSize.LETTER.Height;
			largura_pagina = PageSize.LETTER.Width;
		}
		
		public void Abre()
		{
			doc.Open();
			buf = writer.DirectContent;
		}
		
		public void Fecha()
		{
			doc.Close();
		}
		
		public void AdicionaTexto(int x, int y, string texto, string BaseFont_, int tamanho)
		{
			buf.SetFontAndSize(BaseFont.CreateFont(BaseFont_, BaseFont.CP1252, BaseFont.NOT_EMBEDDED), tamanho);
			buf.BeginText();
			buf.SetTextMatrix(x, altura_pagina-y);
			buf.ShowText(texto);
			buf.EndText(); 			
		}

		public void CriaTabela(int colunas) 
		{
			tabela = new Table(colunas);
			tabela.Cellspacing = 1;
			tabela.WidthPercentage = 100;
		}
		
		public void CriaTabela(int colunas, int borda) 
		{
			tabela = new Table(colunas);
			tabela.Cellspacing = 1;
			tabela.SpaceInsideCell = 0;
			tabela.SpaceBetweenCells = 1;
			tabela.DefaultVerticalAlignment = Element.ALIGN_TOP;
			tabela.WidthPercentage = 100;
			tabela.BorderWidth = borda;
			tabela.DefaultCellBorderWidth = borda;
			
		}
		
		public void AdicionaCelula(string texto, string BaseFont_, int tamanho)
		{
			Chunk chunk =  new Chunk(texto, FontFactory.GetFont(BaseFont_, tamanho));
			tabela.AddCell(new Paragraph(chunk));
		}
		
		
		public void AdicionaCelula(string texto, string BaseFont_, int tamanho, int alinhamento)
		{
			Chunk chunk = new Chunk(texto, FontFactory.GetFont(BaseFont_, tamanho));
			Cell cell = new Cell(new Paragraph(chunk));
			cell.HorizontalAlignment = alinhamento;	
			cell.BorderWidth = tabela.BorderWidth;
			tabela.AddCell(cell);
		}
		
		public void AdicionaCelula(string texto, string BaseFont_, int tamanho, int alinhamento, int colunas)
		{
			Chunk chunk = new Chunk(texto, FontFactory.GetFont(BaseFont_, tamanho));
			Cell cell = new Cell(new Paragraph(chunk));
			cell.HorizontalAlignment = alinhamento;	
			cell.Colspan = colunas;
			cell.BorderWidth = tabela.BorderWidth;
			tabela.AddCell(cell);
		}
		
		public void AdicionaCelulaLinha(string texto, string BaseFont_, int tamanho, int alinhamento, int colunas)
		{
			Chunk chunk = new Chunk(texto, FontFactory.GetFont(BaseFont_, tamanho));
			Cell cell = new Cell(new Paragraph(chunk));
			cell.HorizontalAlignment = alinhamento;	
			cell.Colspan = colunas;
			cell.BorderWidthBottom = 1;
			tabela.AddCell(cell);
		}
		
		public void AdicionaCelulaLinha(string texto, string BaseFont_, int tamanho, int colunas)
		{
			Chunk chunk = new Chunk(texto, FontFactory.GetFont(BaseFont_, tamanho));
			Cell cell = new Cell(new Paragraph(chunk));
			cell.Colspan = colunas;
			cell.BorderWidthBottom = 1;
			tabela.AddCell(cell);
		}
		
		public void AdicionaCelula(string texto, string BaseFont_, int tamanho, int alinhamento, int colunas, float gray)
		{
			Chunk chunk = new Chunk(texto, FontFactory.GetFont(BaseFont_, tamanho));
			Cell cell = new Cell(new Paragraph(chunk));
			cell.HorizontalAlignment = alinhamento;	
			cell.Colspan = colunas;
			cell.BorderWidth = tabela.BorderWidth;
			cell.GrayFill = gray;
			tabela.AddCell(cell);
		}		
		
		public void AdicionaCelula(string texto, string BaseFont_, int tamanho, Color cor)
		{
			Chunk chunk = new Chunk(texto, FontFactory.GetFont(BaseFont_, tamanho));
			Cell cell = new Cell(new Paragraph(chunk));
			//cell.BackgroundColor = cor;
			cell.BorderWidth = tabela.BorderWidth;
			tabela.AddCell(cell);
		}
		
		public void AdicionaCelulaLinha(string texto, string BaseFont_, int tamanho, Color cor, int colunas)
		{
			Chunk chunk = new Chunk(texto, FontFactory.GetFont(BaseFont_, tamanho));
			Cell cell = new Cell(new Paragraph(chunk));
			cell.Colspan = colunas;			
			cell.BorderWidthBottom = 1;
			tabela.AddCell(cell);
		}
		
		public void AdicionaCelulaLinha(string texto, string BaseFont_, int tamanho, Color cor, int alinhamento, int colunas)
		{
			Chunk chunk = new Chunk(texto, FontFactory.GetFont(BaseFont_, tamanho));
			Cell cell = new Cell(new Paragraph(chunk));
			cell.Colspan = colunas;			
			cell.BorderWidthBottom = 1;
			cell.HorizontalAlignment = alinhamento;				
			tabela.AddCell(cell);
		}
		
		public void AdicionaCelulaLinhaTopo(string texto, string BaseFont_, int tamanho, Color cor, int colunas)
		{
			Chunk chunk = new Chunk(texto, FontFactory.GetFont(BaseFont_, tamanho));
			Cell cell = new Cell(new Paragraph(chunk));
			cell.Colspan = colunas;			
			cell.BorderWidthTop = 1;
			tabela.AddCell(cell);
		}
		
		public void AdicionaCelulaLinhaTopo(string texto, string BaseFont_, int tamanho, Color cor, int alinhamento, int colunas)
		{
			Chunk chunk = new Chunk(texto, FontFactory.GetFont(BaseFont_, tamanho));
			Cell cell = new Cell(new Paragraph(chunk));
			cell.Colspan = colunas;			
			cell.BorderWidthTop = 1;
			cell.HorizontalAlignment = alinhamento;				
			tabela.AddCell(cell);
		}
		
		public void AdicionaCelula(string texto, string BaseFont_, int tamanho, Color cor, int colunas)
		{
			Chunk chunk = new Chunk(texto, FontFactory.GetFont(BaseFont_, tamanho));
			Cell cell = new Cell(new Paragraph(chunk));
			//cell.BackgroundColor = cor;
			cell.Colspan = colunas;
			cell.BorderWidth = tabela.BorderWidth;
			tabela.AddCell(cell);
		}
		
		public void AdicionaCelula(string texto, string BaseFont_, int tamanho, Color cor, int alinhamento, int colunas)
		{
			Chunk chunk = new Chunk(texto, FontFactory.GetFont(BaseFont_, tamanho));
			Cell cell = new Cell(new Paragraph(chunk));
			//cell.BackgroundColor = cor;
			cell.HorizontalAlignment = alinhamento;				
			cell.Colspan = colunas;
			cell.BorderWidth = tabela.BorderWidth;
			tabela.AddCell(cell);
		}
		
		public void AdicionaCelulaSemBorda(string texto, int colunas)
		{
			Chunk chunk = new Chunk(texto);
			Cell cell = new Cell(new Paragraph(chunk));
			cell.Colspan = colunas;
			cell.BorderWidth = 0;
			tabela.AddCell(cell);
		}
		
		public void AdicionaCelula(string imagem, int largura, int altura)
		{
			Image img;
			try
			{
				img = Image.GetInstance(imagem);			
			}
			catch (Exception e)
			{
				string msg=e.Message;
				tabela.AddCell(new Paragraph(""));
				return;
			}
			float w=img.Width;
			float h=img.Height;
			while ((w > largura) || (h > altura))
			{
				w *= 0.9F;
				h *= 0.9F;
			}
			img.ScaleAbsolute(w, h);
			Chunk chunk = new Chunk(img, 0, 0);
			tabela.AddCell(new Paragraph(chunk));
		}
		
		public void AdicionaCelula(Table tabela, string imagem, int largura, int altura)
		{
			Image img;
			try
			{
				img = Image.GetInstance(imagem);			
			}
			catch (Exception e)
			{
				string msg=e.Message;
				tabela.AddCell(new Paragraph(""));
				return;
			}
			float w=img.Width;
			float h=img.Height;
			while ((w > largura) || (h > altura))
			{
				w *= 0.9F;
				h *= 0.9F;
			}
			img.ScaleAbsolute(w, h);
			Chunk chunk = new Chunk(img, 0, 0);
			tabela.AddCell(new Paragraph(chunk));
		}
		
		public void AdicionaCelula(string imagem, int largura, int altura, int colunas)
		{
			Image img;
			try
			{
				img = Image.GetInstance(imagem);			
			}
			catch (Exception e)
			{
				string msg=e.Message;
				Cell _cell = new Cell(new Paragraph(""));
				_cell.Colspan = colunas;
				_cell.BorderWidth = tabela.BorderWidth;
				tabela.AddCell(_cell);
				return;
			}
			if (img == null) return;
			float w=img.Width;
			float h=img.Height;
			while ((w > largura) || (h > altura))
			{
				w *= 0.9F;
				h *= 0.9F;
			}
			img.ScaleAbsolute(w, h);
			Chunk chunk = new Chunk(img, 0, 0);
			Cell cell = new Cell(new Paragraph(chunk));
			cell.Colspan = colunas;
			cell.BorderWidth = tabela.BorderWidth;
			tabela.AddCell(cell);
		}
		
		public void AdicionaTabela()
		{
			doc.Add(tabela);
		}
		
		public void AdicionaImagem(string imagem)
		{
			Image img;
			try
			{
				img = Image.GetInstance(imagem);			
			}
			catch (Exception e)
			{
				string msg=e.Message;
				tabela.AddCell(new Paragraph(""));
				return;
			}
			if (img == null) return;			
			doc.Add(img);
		}
		
	}
}
