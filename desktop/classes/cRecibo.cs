using System;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using FirebirdSql.Data.FirebirdClient;
using System.Data;

namespace classes
{
	public static class cRecibo
	{

		private static void salta2(PdfPTable table, int n) 
		{
			PdfPCell cell = new PdfPCell(new Phrase(new Chunk("xxxxxxxxxxxx", FontFactory.GetFont(BaseFont.HELVETICA, 16))));
			cell.BorderWidth = 0;
			while (n-- > 0)
				table.AddCell(cell);					
		}
		
		private static void salta(PdfPTable table, int n) 
		{
			PdfPCell cell = new PdfPCell(new Phrase(new Chunk("", FontFactory.GetFont(BaseFont.HELVETICA, 16))));
			cell.BorderWidth = 0;
			while (n-- > 0)
				table.AddCell(cell);					
		}
		
		public static bool gera(string arquivo, string nf, short seq)
		{
			FileStream fs = new FileStream(arquivo, FileMode.Create);
			Document doc = new Document(PageSize.LETTER);
			float altura = PageSize.LETTER.Height - doc.TopMargin - doc.BottomMargin;
			float largura = PageSize.LETTER.Width - doc.LeftMargin - doc.RightMargin;
			PdfWriter writer = PdfWriter.GetInstance(doc, fs);
			doc.Open();
			GeraRecibo(doc, writer, nf, seq, PageSize.LETTER.Height-doc.TopMargin);

			PdfContentByte buf = writer.DirectContent;
			buf.SetLineDash(3f, 3f);
			buf.MoveTo(0, PageSize.LETTER.Height/2);
			buf.LineTo(PageSize.LETTER.Width, PageSize.LETTER.Height/2);
			buf.Stroke();			
			
			GeraRecibo(doc, writer, nf, seq, PageSize.LETTER.Height/2-30);
			doc.Close();
			return true;						
		}		
		
		public static bool GeraRecibo(Document doc, PdfWriter writer, string nf, short seq, float y0)
		{
			PdfPTable table = new PdfPTable(1);
			table.WidthPercentage = 100;
			//table.HorizontalAlignment = Element.ALIGN_CENTER;
			PdfPCell cell;
			Chunk chunk;
			
			string logo = "imagens\\logo_rel.jpg";
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
			catch
			{
				chunk = new Chunk("");
			}
			cell = new PdfPCell(new Phrase(chunk));
			cell.BorderWidth = 0;
			cell.HorizontalAlignment = Element.ALIGN_CENTER;
			table.AddCell(cell);		
			
			cell = new PdfPCell(new Phrase(new Chunk("RECIBO NRO " + nf, FontFactory.GetFont(BaseFont.HELVETICA, 16))));
			cell.BorderWidth = 0;
			cell.HorizontalAlignment = Element.ALIGN_CENTER;
			table.AddCell(cell);		
			
			salta(table, 2);
			
			string cliente = "";
			string cpf_cnpj = "";
			double valor = 0;
			DateTime data = DateTime.Now;
			DateTime vencimento = DateTime.Now;
			string natureza = "";
			string forma = "";
			string sql = 
				"select " +
				"       a.COD_CLIENTE, " +
				"       b.IDT_FISJUR, " +
				"       b.NRO_CPF_CNPJ," +
				"       a.VLR_RECEBIDO," +
				"       a.DAT_VENCIMENTO," + 
				"       c.DES_NATUREZA," + 
				"       d.DES_FORMA," + 
				"       a.DAT_RECEBIMENTO " + 
				"from TITULOS_RECEBER a " +
				"inner join PARCEIROS b on b.COD_PARCEIRO=a.COD_CLIENTE " +
				"inner join NATUREZAS_RECEBIMENTO c on c.COD_NATUREZA=a.COD_NATUREZA " +
				"inner join FORMAS_RECEBIMENTO d on d.COD_FORMA=a.COD_FORMA " +
				"where a.NRO_NF='" + nf + "' and SEQ_TITULO=" + seq.ToString();
			FbCommand cmd = new FbCommand(sql, Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			while (reader.Read())
			{
				cliente = reader.GetString(0).Trim();
				string fj = reader.GetString(1).Trim();
				if (fj.Equals("F"))
					cpf_cnpj = CPF.PoeEdicao(reader.GetString(2).Trim());
				else
					cpf_cnpj = CNPJ.PoeEdicao(reader.GetString(2).Trim());
				valor = reader.GetDouble(3);
				vencimento = reader.GetDateTime(4);
				natureza = reader.GetString(5).Trim();
				forma = reader.GetString(6).Trim();
				data = reader.GetDateTime(7);
			}
			
			NumeroPorExtenso extenso = new NumeroPorExtenso((decimal)valor);
			
			string texto = 
				"      Recebi de " + cliente + ", " + cpf_cnpj + ", a quantia de " + valor.ToString("#,###,##0.00") + "(" + extenso.ToString() + 
				") referente ao vencimento " + vencimento.ToString("d/M/yyyy");
			
			
			string sql2 = 
				"select " +
				"       a.COD_FORNECEDOR, " +
				"       a.DAT_ORCAMENTO," +
				"       a.COD_ORCAMENTO," +
				"       a.COD_PEDIDO " +
				"from PEDIDOS_RECEBIDOS a " +
				//"inner join PEDIDOS b on b.COD_FORNECEDOR=a.COD_FORNECEDOR and b.DAT_ORCAMENTO=a.DAT_ORCAMENTO and b.COD_ORCAMENTO=a.COD_ORCAMENTO and b.COD_PEDIDO=a.COD_PEDIDO " +
				"where a.NRO_NF='" + nf + "' and SEQ_TITULO=" + seq.ToString();
			FbCommand cmd2 = new FbCommand(sql2, Globais.bd);
			FbDataReader reader2 = cmd2.ExecuteReader(CommandBehavior.Default);
			string pedidos="";
			while (reader2.Read())
			{				
				string fornecedor = reader2.GetString(0).Trim();
				DateTime dataorc = reader2.GetDateTime(1);
				short orcamento = reader2.GetInt16(2);
				short pedido = reader2.GetInt16(3);
				
				if (!pedidos.Equals(""))
					pedidos += ", ";
				pedidos += fornecedor +
					" " +
					dataorc.Month.ToString() +
					"/" +
					dataorc.Year.ToString() +
					" " +
					orcamento +
					"-" +
					pedido;				
			}
			reader2.Close();
			
			if (!pedidos.Equals("")) 
				texto += ", dos pedidos (" + pedidos + ")";
			texto += ", através de " +forma + ".";
			cell = new PdfPCell(new Phrase(new Chunk(texto, FontFactory.GetFont(BaseFont.HELVETICA, 12))));
			cell.BorderWidth = 0;
			cell.HorizontalAlignment = Element.ALIGN_LEFT;
			table.AddCell(cell);		
			
			salta(table, 5);
			
			string[] meses = {"janeiro", "fevereiro", "março", "abril", "maio", "junho", "julho", "agosto", "setembro", "outubro", "novembro", "dezembro" };			
			cell = new PdfPCell(new Phrase(new Chunk(data.Day + " de " + meses[data.Month-1] + " de " + data.Year, FontFactory.GetFont(BaseFont.HELVETICA, 12))));
			cell.BorderWidth = 0;
			cell.HorizontalAlignment = Element.ALIGN_CENTER;
			table.AddCell(cell);					

			salta(table, 5);			
			
			cell = new PdfPCell(new Phrase(new Chunk(data.ToString("          _________________________________________________________"), FontFactory.GetFont(BaseFont.HELVETICA, 12))));
			cell.BorderWidth = 0;
			table.AddCell(cell);					
			
			salta(table, 3);			
			
			cell = new PdfPCell(new Phrase(new Chunk("             Nome:", FontFactory.GetFont(BaseFont.HELVETICA, 12))));
			cell.BorderWidth = 0;
			table.AddCell(cell);								
			
			salta(table, 3);

			cell = new PdfPCell(new Phrase(new Chunk("             Cargo:", FontFactory.GetFont(BaseFont.HELVETICA, 12))));
			cell.BorderWidth = 0;
			table.AddCell(cell);											
												
			//doc.Add(table);						
			table.TotalWidth = PageSize.LETTER.Width - doc.LeftMargin - doc.RightMargin;
			table.WriteSelectedRows(0, -1, doc.LeftMargin, y0, writer.DirectContent);
			return true;			
		}
	}
}
