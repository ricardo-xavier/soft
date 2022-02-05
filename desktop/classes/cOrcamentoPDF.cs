	/*
 * Gera um PDF de um orçamento
 * Ricardo Costa Xavier
 * 14/09/2008
 */

using System;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Collections;

namespace classes
{
	public class Cabecalho1
	{
		public string logo;
		public int orcamento;
		public DateTime data;
		public string filial;
		public string rua;
		public string nro;
		public string complemento;
		public string cep;
		public string fone;
		public string fax;
		public string email;

		public Cabecalho1()
		{
		}
	}
	
	public class Cabecalho2
	{
		public string fornecedor;
		public string cliente;
		public string nom_contato;
		public string email_contato;
		public string fone_contato;
		public string nom_consultor;
		public string email_consultor;
		public string fone_consultor;
		public string nom_vendedor;
		public string email_vendedor;
		public string fone_vendedor;

		public Cabecalho2()
		{
		}
	}
	
	public class Area
	{
		public string codigo;
		public ArrayList itens;
		
		public Area()
		{
			itens = new ArrayList();
		}
	}
	
	public class Item
	{
		public short seq;
		public short qtde;
		public string codigo;
		public string subcodigo;
		public string descricao;
		public string texto;
		public string medidas;
		public float vlr_unitario;
		public float vlr_semipi;
		public string imagem;
		public string especificos;
		public float ipi;
		public float frete;
		public float desconto;
		
		public Item()
		{
		}
	}
	
	public class cOrcamentoPDF
	{
		private Document doc;
		private PdfWriter writer;
		private float total_area;
		public Cabecalho1 cab1;
		public Cabecalho2 cab2;
		public ArrayList areas;
		public float valor;
		public float desconto;
		public string observacao;

		public cOrcamentoPDF()
		{
			areas = new ArrayList();
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
			areas = new ArrayList();
		}		
		
		public void Close()
		{
			doc.Close();
		}
		
		public void SaltaPagina()
		{
			doc.NewPage();
		}		
		
		private void GeraCabecalho1()
		{
			Table table = new Table(4);
			table.TableFitsPage = true;
			table.WidthPercentage = 100;
			table.BorderWidth = 0;			
			table.Padding = 1;
			Chunk chunk;
			Cell cell;

			// coluna1 - logo
			Image img;
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
			
			// coluna2 - orcamento
			Paragraph par = new Paragraph();
			par.Add(new Chunk(" orçamento:", FontFactory.GetFont(BaseFont.HELVETICA, 18)));
			par.Add(new Chunk(cab1.orcamento.ToString() + "\n\n", FontFactory.GetFont(BaseFont.HELVETICA, 22)));
			par.Add(new Chunk(" " + cab1.data.ToString("d/M/yyyy"), FontFactory.GetFont(BaseFont.HELVETICA, 18)));
			cell = new Cell(par);
			cell.BorderWidthTop = 1;
			cell.BorderWidthBottom = 1;
			cell.BorderWidthLeft = 1;
			cell.BorderWidthRight = 0;
			cell.HorizontalAlignment = Element.ALIGN_LEFT;
			cell.VerticalAlignment = Element.ALIGN_MIDDLE;
			table.AddCell(cell);
			
			// coluna3 - dados empresa
			string dados_empresa = 
				cab1.filial + " \n" +
				cab1.rua + "," + cab1.nro + " " + cab1.complemento + " \n" +
				"CEP: " + CEP.PoeEdicao(cab1.cep) + 
				" - Fone: " + FONE.PoeEdicao(cab1.fone) + 
				" - Fax: " + FONE.PoeEdicao(cab1.fax) + " \n" +
				cab1.email + " ";
			chunk =  new Chunk(dados_empresa, FontFactory.GetFont(BaseFont.HELVETICA, 10));
			cell = new Cell(chunk);
			cell.BorderWidthTop = 1;
			cell.BorderWidthBottom = 1;
			cell.BorderWidthLeft = 0;
			cell.BorderWidthRight = 1;
			cell.HorizontalAlignment = Element.ALIGN_RIGHT;
			cell.VerticalAlignment = Element.ALIGN_MIDDLE;
			cell.Colspan = 2;
			table.AddCell(cell);
			
			doc.Add(table);
		}
		
		public Cell Celula2(string texto, int colspan)
		{
			Chunk chunk = new Chunk(texto, FontFactory.GetFont(BaseFont.HELVETICA, 10));
			Cell cell = new Cell(chunk);
			cell.Colspan = colspan;
			cell.GrayFill = (colspan == 1) ? 0.6f : 0.8f;
			cell.BorderWidthTop = 2;
			cell.BorderWidthRight = 4;
			cell.BorderColor = Color.WHITE;
			cell.Leading = 10;
			return cell;
		}
		
		private void GeraCabecalho2()
		{
			Table table = new Table(10);
			table.TableFitsPage = true;
			table.BorderWidth = 0;
			table.Padding = 1;
			table.WidthPercentage = 100;
			table.Alignment = Element.ALIGN_LEFT;
			table.AddCell(Celula2("Fornecedor", 1));
			table.AddCell(Celula2(cab2.fornecedor, 9));
			table.AddCell(Celula2("Cliente", 1));
			table.AddCell(Celula2(cab2.cliente, 4));
			table.AddCell(Celula2("Contato", 1));
			table.AddCell(Celula2(cab2.nom_contato.Trim() + " / " + cab2.email_contato.Trim() + " / " + FONE.PoeEdicao(cab2.fone_contato), 4));
			table.AddCell(Celula2("Consultor", 1));
			table.AddCell(Celula2(cab2.nom_consultor.Trim() + " / " + cab2.email_consultor.Trim() + " / " + FONE.PoeEdicao(cab2.fone_consultor), 4));
			table.AddCell(Celula2("Vendedor", 1));
			table.AddCell(Celula2(cab2.nom_vendedor.Trim() + " / " + cab2.email_vendedor.Trim() + " / " + FONE.PoeEdicao(cab2.fone_vendedor), 4));
			doc.Add(table);
		}
		
		private void GeraCabecalhoArea(ref Table table, string area, bool imagens, bool mostrar_imagens)
		{
			Chunk chunk = new Chunk("Área: " + area, FontFactory.GetFont(BaseFont.HELVETICA, 10));
			Cell cell = new Cell(chunk);
			cell.BackgroundColor = Color.GREEN;
			cell.Leading = 10;		
			if (mostrar_imagens)
				cell.Colspan = imagens ? 19 : 15;
			else
				cell.Colspan = imagens ? 15 : 11;
			table.AddCell(cell);
		}

		public Cell CelulaCabecalho(string texto, int colspan)
		{
			Chunk chunk = new Chunk(texto, FontFactory.GetFont(BaseFont.HELVETICA, 10));
			Cell cell = new Cell(chunk);
			cell.Colspan = colspan;
			cell.GrayFill = 0.6f;
			cell.BorderWidth = 1;
			cell.Leading = 10;
			return cell;
		}
		
		private void GeraCabecalhoTabela(ref Table table, bool imagens, bool mostrar_valores)
		{
			table.AddCell(CelulaCabecalho("Item", 1));
			table.AddCell(CelulaCabecalho("Qtde", 1));
			table.AddCell(CelulaCabecalho("Código", 2));
			table.AddCell(CelulaCabecalho("Descrição", 5));
			table.AddCell(CelulaCabecalho("Medidas", 2));
			if (mostrar_valores)
			{
				table.AddCell(CelulaCabecalho("R$ Unitário", 2));
				table.AddCell(CelulaCabecalho("R$ Total", 2));
			}
			if (imagens)
				table.AddCell(CelulaCabecalho("Imagem", 4));
		}
		
		public Cell CelulaLinha(string texto, int colspan)
		{
			Chunk chunk = new Chunk(texto, FontFactory.GetFont(BaseFont.HELVETICA, 10));
			Cell cell = new Cell(chunk);
			cell.Colspan = colspan;
			cell.BorderWidth = 1;
			cell.Leading = 10;
			return cell;
		}
		
		public Cell CelulaLinhaValor(string texto, int colspan)
		{
			Chunk chunk = new Chunk(texto, FontFactory.GetFont(BaseFont.HELVETICA, 10));
			Cell cell = new Cell(chunk);
			cell.Colspan = colspan;
			cell.BorderWidth = 1;
			cell.Leading = 10;
			cell.HorizontalAlignment = Element.ALIGN_RIGHT;
			return cell;
		}
		
		private void GeraLinhaTabela(ref Table table, Item item, bool imagens, bool resumida, bool detalhada, bool mostrar_valores, int seq)
		{
			table.AddCell(CelulaLinha(seq.ToString(), 1));
			table.AddCell(CelulaLinha(item.qtde.ToString(), 1));
			table.AddCell(CelulaLinha(item.codigo + " " + item.subcodigo, 2));
			if (resumida)
				table.AddCell(CelulaLinha(item.descricao, 5));
			else
				table.AddCell(CelulaLinha(item.texto, 5));
			table.AddCell(CelulaLinha(item.medidas, 2));
			if (mostrar_valores) table.AddCell(CelulaLinhaValor(item.vlr_unitario.ToString("#,###,##0.00"), 2));
			//float total = Globais.Arredonda(item.vlr_unitario) * item.qtde;
			float total = item.vlr_unitario * item.qtde;
			total_area += total;
			if (mostrar_valores) table.AddCell(CelulaLinhaValor(total.ToString("#,###,##0.00"), 2));
			if (imagens) {
				Image img;
				try
				{
					img = Image.GetInstance(item.imagem);
				}
				catch (Exception)
				{
					table.AddCell(CelulaLinha("", 4));
					return;
				}
				float w=img.Width;
				float h=img.Height;
				//while ((w > 150) || (h > 200))
				while ((w > 90) || (h > 90))
				{
					w *= 0.9F;
					h *= 0.9F;
				}
				img.ScaleAbsolute(w, h);
				Chunk chunk = new Chunk(img, 0, 0);
				Cell cell = new Cell(new Paragraph(chunk));
				cell.Colspan = 4;
				cell.BorderWidth = 1;
				table.AddCell(cell);
			}
		}
		
		private void GeraLinhaDetalhe(ref Table table, Item item, bool imagens, bool mostrar_valores)		
		{
			table.AddCell(CelulaLinha("", 1));
			if (mostrar_valores)
				table.AddCell(CelulaLinha(item.texto, imagens ? 18 : 14));
			else
				table.AddCell(CelulaLinha(item.texto, imagens ? 14 : 10));
		}
			
		private void GeraTotal(ref Table table, bool imagens, string area)
		{
			Cell cell;
			Chunk chunk;
			
			cell = new Cell("");
			cell.Colspan = 9;
			cell.BorderWidth = 0;
			cell.Leading = 10;
			table.AddCell(cell);
			
			chunk = new Chunk("Total " + area, FontFactory.GetFont(BaseFont.HELVETICA, 10));
			cell = new Cell(chunk);
			cell.Colspan = 4;
			cell.BorderWidth = 1;
			cell.Leading = 10;
			cell.GrayFill = 0.8f;
			table.AddCell(cell);
			
			chunk = new Chunk(total_area.ToString("#,###,##0.00"), FontFactory.GetFont(BaseFont.HELVETICA, 10));
			cell = new Cell(chunk);
			cell.Colspan = 2;
			cell.BorderWidth = 1;
			cell.Leading = 10;
			cell.GrayFill = 0.6f;
			cell.HorizontalAlignment = Element.ALIGN_RIGHT;
			table.AddCell(cell);
			
			if (imagens)
			{
				cell = new Cell("");
				cell.Colspan = 4;
				cell.BorderWidth = 0;
				cell.Leading = 10;
				table.AddCell(cell);
			}
		}
		
		private void LinhaTotalGeral(ref Table table, bool imagens)
		{
			Cell cell;
			Chunk chunk;

			chunk = new Chunk(observacao, FontFactory.GetFont(BaseFont.HELVETICA, 10));
			cell = new Cell(chunk);
			cell.Colspan = 8;
			cell.Rowspan = 4;
			cell.BorderWidth = 1;
			table.AddCell(cell);
			
			cell = new Cell("");
			cell.Colspan = 1;
			cell.Rowspan = 3;
			cell.BorderWidth = 0;
			table.AddCell(cell);
			
			chunk = new Chunk("Total Geral", FontFactory.GetFont(BaseFont.HELVETICA, 10));
			cell = new Cell(chunk);
			cell.Colspan = 4;
			cell.BorderWidth = 1;
			cell.Leading = 10;
			cell.GrayFill = 0.8f;
			table.AddCell(cell);
			
			chunk = new Chunk(valor.ToString("#,###,##0.00"), FontFactory.GetFont(BaseFont.HELVETICA, 10));
			cell = new Cell(chunk);
			cell.Colspan = 2;
			cell.BorderWidth = 1;
			cell.Leading = 10;
			cell.GrayFill = 0.6f;
			cell.HorizontalAlignment = Element.ALIGN_RIGHT;
			table.AddCell(cell);
			
			if (imagens)
			{
				cell = new Cell("");
				cell.Colspan = 4;
				cell.Rowspan = 3;
				cell.BorderWidth = 0;
				cell.Leading = 10;
				table.AddCell(cell);
			}
		}
		
		private void LinhaDescontos(ref Table table)
		{
			Cell cell;
			Chunk chunk;
			
			chunk = new Chunk("Descontos", FontFactory.GetFont(BaseFont.HELVETICA, 10));
			cell = new Cell(chunk);
			cell.Colspan = 4;
			cell.BorderWidth = 1;
			cell.Leading = 10;
			cell.GrayFill = 0.8f;
			table.AddCell(cell);
			
			chunk = new Chunk(desconto.ToString("#,###,##0.00"), FontFactory.GetFont(BaseFont.HELVETICA, 10));
			cell = new Cell(chunk);
			cell.Colspan = 2;
			cell.BorderWidth = 1;
			cell.Leading = 10;
			cell.GrayFill = 0.6f;
			cell.HorizontalAlignment = Element.ALIGN_RIGHT;
			table.AddCell(cell);
		}
		
		private void LinhaValorOrcamento(ref Table table)			
		{
			Cell cell;
			Chunk chunk;
			
			chunk = new Chunk("Valor orçamento", FontFactory.GetFont(BaseFont.HELVETICA, 10));
			cell = new Cell(chunk);
			cell.Colspan = 4;
			cell.BorderWidth = 1;
			cell.Leading = 10;
			cell.GrayFill = 0.8f;
			table.AddCell(cell);
			
			chunk = new Chunk((valor - desconto).ToString("#,###,##0.00"), FontFactory.GetFont(BaseFont.HELVETICA, 10));
			cell = new Cell(chunk);
			cell.Colspan = 2;
			cell.BorderWidth = 1;
			cell.Leading = 10;
			cell.GrayFill = 0.6f;
			cell.HorizontalAlignment = Element.ALIGN_RIGHT;
			table.AddCell(cell);
		}
		
		private void GeraTotalGeral(bool imagens)
		{
			Table table = new Table(imagens ? 19 : 15);
			table.TableFitsPage = true;
			table.BorderWidth = 0;
			table.Padding = 2;
			table.WidthPercentage = 100;
			LinhaTotalGeral(ref table, imagens);
			LinhaDescontos(ref table);
			LinhaValorOrcamento(ref table);
			doc.Add(table);
		}
		
		public void Gera(string arquivo, bool imagens, bool resumida, bool detalhada, bool mostrar_valores)
		{
			GeraCabecalho1();
			doc.Add(new Paragraph(""));
			GeraCabecalho2();
			foreach (Area area in areas)
			{
				Table table;
				if (mostrar_valores)
					table = new Table(imagens ? 19 : 15);
				else
					table = new Table(imagens ? 15 : 11);
				table.TableFitsPage = true;
				table.BorderWidth = 0;
				table.Padding = 2;
				table.WidthPercentage = 100;
				total_area = 0;
				if (!area.codigo.Equals("")) GeraCabecalhoArea(ref table, area.codigo, imagens, mostrar_valores);
				GeraCabecalhoTabela(ref table, imagens, mostrar_valores);
				int seq=1;
				foreach (Item item in area.itens)
				{
					GeraLinhaTabela(ref table, item, imagens, resumida, detalhada, mostrar_valores, seq++);	
					if (resumida && detalhada)
						GeraLinhaDetalhe(ref table, item, imagens, mostrar_valores);
				}
				if (mostrar_valores & !area.codigo.Equals("")) GeraTotal(ref table, imagens, area.codigo);
				doc.Add(table);
				doc.Add(new Paragraph(""));
			}
			if (mostrar_valores) GeraTotalGeral(imagens);
		}
	}
}
