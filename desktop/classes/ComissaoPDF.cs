/*
 * Classe ComissaoPDF
 * Gera relatório de comissões em PDF
 * Autor: Ricardo Costa Xavier
 * Histórico:
 * 15/02/10 - versão inicial
 */

using System;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Collections;
using System.Windows.Forms;

namespace classes
{

	public class ComissaoPDF
	{
		
		private Document doc;
		private PdfWriter writer;
		private float percentual_comissao;
		private int nitens;
		private float total_comissao;
		private float total_pedido;
		private float total_valor;
		private float total_pago;
		private float total_pagar;
		private bool por_vendedor;
		private bool por_consultor;
		private bool por_filial;		
		private bool mostra_pago;
		private bool mostra_pagar;
		private string vendedor;
		private string consultor;
		private string titulo;

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

		private PdfPTable Parte12()
		{
			Tabela table = new Tabela(1);
			Celula cell;
			Chunk chunk;
			chunk = new Chunk(titulo, FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 16));
			cell = new Celula(new Phrase(chunk));
			cell.Padding = 1;
			//cell.Colspan = 11;
			table.AddCell(cell);
			return table;
		}
		
		private PdfPTable Parte13()
		{
			Tabela table = new Tabela(1);
			Celula cell;
			cell = new Celula(Frase("DATA: ", DateTime.Now.ToString("dd/MM/yyyyy"), 10));			
			table.AddCell(cell);
			if (por_vendedor)
				cell = new Celula(Frase("VENDEDOR: ", vendedor, 10));
			else
			if (por_consultor)
				cell = new Celula(Frase("CONSULTOR: ", consultor, 10));
			else
			if (por_filial)
				cell = new Celula(Frase("FILIAL: ", Globais.sFilial, 10));			
			table.AddCell(cell);
			return table;
		}
		
		private void Parte1()
		{
			Tabela table = new Tabela(22);
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

			doc.Add(table);
		}

		private void Parte2(DataGridView dgv, bool justificativas)
		{
			CelulaCabecalho cell;
			CelulaItem cellI;			
			Tabela table = new Tabela(11);
			
			// cabecalho
			cell = new CelulaCabecalho(Frase("Fornecedor", 10));
			cell.Colspan = 2;
			table.AddCell(cell);			
			
			cell = new CelulaCabecalho(Frase("Data", 10));
			cell.Colspan = 1;
			table.AddCell(cell);
			
			cell = new CelulaCabecalho(Frase("Orçamento", 10));
			cell.Colspan = 1;
			table.AddCell(cell);
			
			cell = new CelulaCabecalho(Frase("Pedido", 10));
			cell.Colspan = 1;
			table.AddCell(cell);
			
			cell = new CelulaCabecalho(Frase("Cliente", 10));
			cell.Colspan = 2;
			table.AddCell(cell);
			
			cell = new CelulaCabecalho(Frase("Vlr Pedido", 10));
			cell.Colspan = 1;
			cell.HorizontalAlignment = Element.ALIGN_RIGHT;
			table.AddCell(cell);						
			
			cell = new CelulaCabecalho(Frase("Valor", 10));
			cell.Colspan = 1;
			cell.HorizontalAlignment = Element.ALIGN_RIGHT;
			table.AddCell(cell);			
			
			cell = new CelulaCabecalho(Frase("%Pago", 10));
			cell.Colspan = 1;
			cell.HorizontalAlignment = Element.ALIGN_RIGHT;
			table.AddCell(cell);
			
			cell = new CelulaCabecalho(Frase("Comissão", 10));
			cell.Colspan = 1;
			cell.HorizontalAlignment = Element.ALIGN_RIGHT;
			table.AddCell(cell);
			
			percentual_comissao=0;
			total_comissao=0;
			total_pedido=0;
			total_valor=0;
			total_pago=0;
			total_pagar=0;
			nitens=0;
			
			foreach (DataGridViewRow row in dgv.Rows)
			{
				/*
				if (!(bool)row.Cells["S"].Value)
				{
					continue;
				}
				bool pg=false;
				if (por_vendedor)
					pg = row.Cells["IdtVendedor"].Value.ToString().Equals("S");
				if (por_consultor)
					pg = row.Cells["IdtConsultor"].Value.ToString().Equals("S");
				if (por_filial)
					pg = row.Cells["IdtFilial"].Value.ToString().Equals("S");
				*/					
				bool pg = (bool)row.Cells["PG"].Value;
				
				if (!mostra_pagar && !pg) continue;
				if (!mostra_pago && pg) continue;
				cellI = new CelulaItem(Frase(row.Cells["Fornecedor"].Value.ToString(), 10));
				cellI.Colspan = 2;
				table.AddCell(cellI);

				cellI = new CelulaItem(Frase(row.Cells["Data"].Value.ToString(), 10));
				cellI.Colspan = 1;
				table.AddCell(cellI);
				
				cellI = new CelulaItem(Frase(row.Cells["Orcamento"].Value.ToString(), 10));
				cellI.Colspan = 1;
				table.AddCell(cellI);
				
				cellI = new CelulaItem(Frase(row.Cells["Pedido"].Value.ToString(), 10));
				cellI.Colspan = 1;
				table.AddCell(cellI);
				
				cellI = new CelulaItem(Frase(row.Cells["Cliente"].Value.ToString(), 10));
				cellI.Colspan = 2;
				table.AddCell(cellI);
				
				cellI = new CelulaItem(Frase(Globais.StrToFloat(row.Cells["ValorPedido"].Value.ToString()).ToString("#,###,##0.00"), 10));
				cellI.Colspan = 1;
				cellI.HorizontalAlignment = Element.ALIGN_RIGHT;
				table.AddCell(cellI);				
				
				cellI = new CelulaItem(Frase(Globais.StrToFloat(row.Cells["Valor"].Value.ToString()).ToString("#,###,##0.00"), 10));
				cellI.Colspan = 1;
				cellI.HorizontalAlignment = Element.ALIGN_RIGHT;
				table.AddCell(cellI);
				
				//cellI = new CelulaItem(Frase(Globais.StrToFloat(row.Cells["PerVendedor"].Value.ToString()).ToString("#0.00"), 10));
				cellI = new CelulaItem(Frase(Globais.StrToFloat(row.Cells["Pago"].Value.ToString()).ToString("#0.00"), 10));
				cellI.Colspan = 1;
				cellI.HorizontalAlignment = Element.ALIGN_RIGHT;
				table.AddCell(cellI);
				
				float comissao = Globais.StrToFloat(row.Cells["Comissao"].Value.ToString());				
				//float valor = Globais.StrToFloat(row.Cells["Valor"].Value.ToString());
				//float per_pago = Globais.StrToFloat(row.Cells["PerVendedor"].Value.ToString());
				//float comissao = per_pago * valor / 100f;
				cellI = new CelulaItem(Frase(comissao.ToString("#,###,##0.00"), 10));
				cellI.Colspan = 1;
				cellI.HorizontalAlignment = Element.ALIGN_RIGHT;
				table.AddCell(cellI);
				percentual_comissao += Globais.StrToFloat(row.Cells["Pago"].Value.ToString());
				total_comissao += comissao;	
				total_pedido += Globais.StrToFloat(row.Cells["ValorPedido"].Value.ToString());
				total_valor += Globais.StrToFloat(row.Cells["Valor"].Value.ToString());
				if ((bool)row.Cells["PG"].Value)
					total_pago += comissao;
				else
					total_pagar += comissao;
				
				if (justificativas) {
					string justificativa = row.Cells["Justificativa"].Value.ToString().Trim();
					if (justificativa.Length > 0) 
					{
						cellI = new CelulaItem(Frase("Justificativa: " + justificativa, 10));
						cellI.Colspan = 11;
						table.AddCell(cellI);					
					}
				}
				nitens++;
			}
			doc.Add(table);			
		}

		private void Parte3()
		{
			Tabela table = new Tabela(11);
			PdfPCell cell;
			
			cell = new CelulaCabecalho(Frase("Total", 10));
			cell.Colspan = 7;
			table.AddCell(cell);
			
			cell = new CelulaCabecalho(Frase(total_pedido.ToString("#,###,##0.00"), 10));
			cell.Colspan = 1;
			cell.HorizontalAlignment = Element.ALIGN_RIGHT;
			table.AddCell(cell);
			
			cell = new CelulaCabecalho(Frase(total_valor.ToString("#,###,##0.00"), 10));
			cell.Colspan = 1;
			cell.HorizontalAlignment = Element.ALIGN_RIGHT;
			table.AddCell(cell);
			
			float media = (percentual_comissao / nitens);
			cell = new CelulaCabecalho(Frase(media.ToString("#0.00"), 10));
			cell.Colspan = 1;
			cell.HorizontalAlignment = Element.ALIGN_RIGHT;
			table.AddCell(cell);			
			
			cell = new CelulaCabecalho(Frase(total_comissao.ToString("#,###,##0.00"), 10));
			cell.Colspan = 1;
			cell.HorizontalAlignment = Element.ALIGN_RIGHT;
			table.AddCell(cell);
			
			cell = new CelulaCabecalho(Frase("", 10));
			cell.Colspan = 9;
			table.AddCell(cell);
						
			cell = new CelulaCabecalho(Frase("Pago", 10));
			cell.Colspan = 1;
			cell.HorizontalAlignment = Element.ALIGN_RIGHT;
			table.AddCell(cell);			
			
			cell = new CelulaCabecalho(Frase(total_pago.ToString("#,###,##0.00"), 10));
			cell.Colspan = 1;
			cell.HorizontalAlignment = Element.ALIGN_RIGHT;
			table.AddCell(cell);
			//
			cell = new CelulaCabecalho(Frase("", 10));
			cell.Colspan = 9;
			table.AddCell(cell);
						
			cell = new CelulaCabecalho(Frase("Pagar", 10));
			cell.Colspan = 1;
			cell.HorizontalAlignment = Element.ALIGN_RIGHT;
			table.AddCell(cell);			
			
			cell = new CelulaCabecalho(Frase(total_pagar.ToString("#,###,##0.00"), 10));
			cell.Colspan = 1;
			cell.HorizontalAlignment = Element.ALIGN_RIGHT;
			table.AddCell(cell);						

			doc.Add(table);
		}
		
		public void Gera(DataGridView dgv, bool _por_vendedor, bool _por_consultor, bool _por_filial, bool _mostra_pago, bool _mostra_pagar, string _titulo, bool justificativas, string arquivo)
		{
			por_vendedor = _por_vendedor;
			por_consultor = _por_consultor;
			por_filial = _por_filial;		
			mostra_pago = _mostra_pago;
			mostra_pagar = _mostra_pagar;
			titulo = _titulo;
			
			foreach (DataGridViewRow row in dgv.Rows)
			{
				/*
				if (!(bool)row.Cells["S"].Value)
				{
					continue;
				}
				*/
				if (por_consultor)
				{
					vendedor = "";
					consultor = row.Cells["Vendedor"].Value.ToString();
				}
				else
				{
					vendedor = row.Cells["Vendedor"].Value.ToString();
					consultor = "";
				}
				break;
			}
			
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
			Parte2(dgv, justificativas);
			Parte3();			
			doc.Close();
			fs.Close();
		}
	}
}
