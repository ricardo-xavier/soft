/*
 * Projeto  : SoftPlace
 * Programa : cTitulosPagar - Classe de Titulos a Pagar
 * Autor    : Ricardo Costa Xavier
 * Data     : 21/07/08
 */
using System;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using System.Collections;
using System.IO;
using pdf;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace classes
{
	public class cTitulosPagar
	{
		public int COD_TITULO;
		public string COD_USUARIO;
		public DateTime DAT_EMISSAO;
		public DateTime DAT_VENCIMENTO;
		public string COD_PARCEIRO;
		public string COD_FUNCIONARIO;
		public string COD_NATUREZA;
		public string IDT_TIPO;
		public float VLR_PREVISTO;
		public bool chkDAT_PAGAMENTO;
		public DateTime DAT_PAGAMENTO;
		public float VLR_PAGO;
		public string COD_FORMA;
		public string COD_DOC_ORIGEM;
		public string COD_DOC_GERADO;
		public string COD_PENDENCIA;
		public string TXT_OBSERVACAO;
		
		public cTitulosPagar()
		{
		}
		
		public void Carrega(DataGridView grid, string where)
		{
			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			string sql = 
				"select " +
				"       a.DAT_VENCIMENTO," +  // 0				
				"       a.COD_TITULO," +      // 1
				"       a.COD_PARCEIRO," +    // 2
				"       b.DES_NATUREZA," +    // 3
				"       a.VLR_PREVISTO," +    // 4
				"       a.VLR_PAGO," +        // 5
				"       a.DAT_PAGAMENTO," +   // 6
				"       c.DES_PENDENCIA," +   // 7
				"       a.TXT_OBSERVACAO,"+   // 8
				"       d.DES_FORMA," +       // 0
				"       a.COD_DOC_GERADO,"+   // 10
				"       a.COD_FUNCIONARIO," + // 11
				"       ' '," +				  // 12
				"       a.IDT_TIPO " +	      // 13
				"from TITULOS_PAGAR a " +
				"left outer join NATUREZAS_PAGAMENTO b " +
				"on b.COD_NATUREZA = a.COD_NATUREZA " +
				"left outer join PENDENCIAS c " +
				"on c.COD_PENDENCIA = a.COD_PENDENCIA " +
				"left outer join FORMAS_PAGAMENTO d " +
				"on d.COD_FORMA = a.COD_FORMA " +				
				where + " " +
				"order by a.DAT_VENCIMENTO,a.COD_TITULO";
			adapter.SelectCommand = new FbCommand(sql, Globais.bd);
			adapter.Fill(table);
			table.Columns[0].ColumnName = "Vencimento";
			table.Columns[1].ColumnName = "Código";
			table.Columns[2].ColumnName = "Parceiro";			
			table.Columns[3].ColumnName = "Natureza";				
			table.Columns[4].ColumnName = "Valor";
			table.Columns[5].ColumnName = "Pago";
			table.Columns[6].ColumnName = "Pagamento";
			table.Columns[7].ColumnName = "Pendência";
			table.Columns[8].ColumnName = "Observação";
			table.Columns[9].ColumnName = "Forma";
			table.Columns[10].ColumnName = "Doc Gerado";
			table.Columns[11].ColumnName = "Funcionário";
			table.Columns[12].ColumnName = "Situação";
			table.Columns[13].ColumnName = "Tipo";
			grid.DataSource = table;
			grid.Columns["Código"].Visible = false;	
			grid.Columns["Observação"].Visible = false;	
			grid.Columns["Forma"].Visible = false;	
			grid.Columns["Doc Gerado"].Visible = false;	
			grid.Columns["Funcionário"].Visible = false;	
			grid.Columns["Tipo"].Visible = false;	
			grid.Columns["Valor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			grid.Columns["Valor"].DefaultCellStyle.Format = "#,###,##0.00";
			grid.Columns["Pago"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			grid.Columns["Pago"].DefaultCellStyle.Format = "#,###,##0.00";			
		}
		
		public bool Le(int codigo)
		{
			string sql = 
				"select COD_USUARIO," +
				"       DAT_EMISSAO," +
				"       DAT_VENCIMENTO," +
				"       COD_PARCEIRO," +
				"       COD_FUNCIONARIO," +
				"       COD_NATUREZA," +
				"       IDT_TIPO," +
				"       VLR_PREVISTO," +
				"       DAT_PAGAMENTO," +
				"       VLR_PAGO," +
				"       COD_FORMA," +
				"       COD_DOC_ORIGEM," +
				"       COD_DOC_GERADO," +
				"       COD_PENDENCIA," +
				"       TXT_OBSERVACAO " +				
				"from TITULOS_PAGAR " +
				"where COD_TITULO=" + codigo;
			FbCommand cmd = new FbCommand(sql, Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			if (reader.Read())
			{
				COD_TITULO = codigo;
				COD_USUARIO = !reader.IsDBNull(0) ? reader.GetString(0).Trim() : "";
				DAT_EMISSAO = !reader.IsDBNull(1) ? reader.GetDateTime(1) : DateTime.Now;
				DAT_VENCIMENTO = !reader.IsDBNull(2) ? reader.GetDateTime(2) : DateTime.Now;
				COD_PARCEIRO = !reader.IsDBNull(3) ? reader.GetString(3).Trim() : "";
				COD_FUNCIONARIO = !reader.IsDBNull(4) ? reader.GetString(4).Trim() : "";
				COD_NATUREZA = !reader.IsDBNull(5) ? reader.GetString(5).Trim() : "";
				IDT_TIPO = !reader.IsDBNull(6) ? reader.GetString(6).Trim() : "F";
				VLR_PREVISTO = !reader.IsDBNull(7) ? reader.GetFloat(7) : 0;
				chkDAT_PAGAMENTO = !reader.IsDBNull(8);
				DAT_PAGAMENTO = !reader.IsDBNull(8) ? reader.GetDateTime(8) : DateTime.Now;
				VLR_PAGO = !reader.IsDBNull(9) ? reader.GetFloat(9) : 0;
				COD_FORMA = !reader.IsDBNull(10) ? reader.GetString(10).Trim() : "";
				COD_DOC_ORIGEM = !reader.IsDBNull(11) ? reader.GetString(11).Trim() : "";
				COD_DOC_GERADO = !reader.IsDBNull(12) ? reader.GetString(12).Trim() : "";
				COD_PENDENCIA = !reader.IsDBNull(13) ? reader.GetString(13).Trim() : "";
				TXT_OBSERVACAO = !reader.IsDBNull(14) ? reader.GetString(14).Trim() : "";
				reader.Close();
				return true;
			}
			reader.Close();
			return false;
		}
		
		public bool Inclui(
			string COD_USUARIO, 
			DateTime DAT_EMISSAO, 
			DateTime DAT_VENCIMENTO,
			string COD_PARCEIRO,
			string COD_FUNCIONARIO,
			string COD_NATUREZA,
			string IDT_TIPO,
			float VLR_PREVISTO,
			bool chkDAT_PAGAMENTO,
			DateTime DAT_PAGAMENTO,
			float VLR_PAGO,
			string COD_FORMA,
			string COD_DOC_ORIGEM,
			string COD_DOC_GERADO,
			string COD_PENDENCIA,
			string TXT_OBSERVACAO,
			ArrayList pedidos,
			ref string msg,
			ref int codigo)
		{
			codigo=1;
			string data = chkDAT_PAGAMENTO ? "'" + DAT_PAGAMENTO.ToString("M/d/yyyy")  + "'" : "null";
			string natureza = COD_NATUREZA.Length > 0 ? "'" + COD_NATUREZA + "'": "null";
			string forma = COD_FORMA.Length > 0 ? "'" + COD_FORMA + "'": "null";
			FbCommand cmd = new FbCommand("select max(COD_TITULO) from TITULOS_PAGAR ", Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			if (reader.Read())
			{
				if (!reader.IsDBNull(0))
					codigo = reader.GetInt32(0) + 1;
			}
			reader.Close();

			string fk_pendencia;
			if (COD_PENDENCIA.Trim().Length > 0)
				fk_pendencia = "'" + COD_PENDENCIA + "'";
			else
				fk_pendencia = "null";
			string sql = 
				"insert into TITULOS_PAGAR values(" +
				codigo + "," +
				"'"  + COD_USUARIO + "'," +
				"'"  + DAT_EMISSAO.ToString("M/d/yyyy") + "'," +
				"'"  + DAT_VENCIMENTO.ToString("M/d/yyyy") + "'," +
				"'"  + COD_PARCEIRO + "'," +
				"'"  + COD_FUNCIONARIO + "'," +
				natureza + "," +
				"'"  + IDT_TIPO + "'," +
				VLR_PREVISTO.ToString().Replace(',','.') + "," +
				data + "," +
				VLR_PAGO.ToString().Replace(',','.') + "," +
				forma + "," +
				"'"  + COD_DOC_ORIGEM + "'," +
				"'"  + COD_DOC_GERADO + "'," +
				fk_pendencia + "," +				
				"'"  + TXT_OBSERVACAO + "')";
			FbCommand cmd2 = new FbCommand(sql, Globais.bd);
			try
			{
				Log.Grava(Globais.sUsuario, cmd2.CommandText);
				cmd2.ExecuteNonQuery();
			}
			catch (Exception err)
			{
				Log.Grava(Globais.sUsuario, "erro:" + err.Message);
				msg = err.Message;
				return false;
			}
			
			foreach (string ped in pedidos)
			{
				string fornecedor_ped = "";
				DateTime data_ped = DateTime.Now;
				string orcamento_ped = "";
				string pedido_ped = "";
				Globais.SeparaPedido(ped, ref fornecedor_ped, ref data_ped, ref orcamento_ped, ref pedido_ped);
				sql = "insert into pedidos_pagos values(" +
						"'" + fornecedor_ped + "'," +
						"'" + data_ped.ToString("M/d/yyyy") + "'," +
						orcamento_ped + "," +
						pedido_ped + "," +
						codigo + ")";
				cmd = new FbCommand(sql, Globais.bd);
				try
				{
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
				}
				catch (Exception err)
				{
					Log.Grava(Globais.sUsuario, "erro:" + err.Message);
					msg = err.Message;
					return false;
				}
			}
			
			msg = "OK";
			return true;
		}
		
		
		public bool Altera(
			int COD_TITULO,
			string COD_USUARIO, 
			DateTime DAT_EMISSAO, 
			DateTime DAT_VENCIMENTO,
			string COD_PARCEIRO,
			string COD_FUNCIONARIO,
			string COD_NATUREZA,
			string IDT_TIPO,
			float VLR_PREVISTO,
			bool chkDAT_PAGAMENTO,
			DateTime DAT_PAGAMENTO,
			float VLR_PAGO,
			string COD_FORMA,
			string COD_DOC_ORIGEM,
			string COD_DOC_GERADO,
			string COD_PENDENCIA,
			string TXT_OBSERVACAO,
			ArrayList pedidos,
			ref string msg)
		{
			string data = chkDAT_PAGAMENTO ? "'" + DAT_PAGAMENTO.ToString("M/d/yyyy")  + "'" : "null";			
			string natureza = COD_NATUREZA.Length > 0 ? "'" + COD_NATUREZA + "'": "null";
			string forma = COD_FORMA.Length > 0 ? "'" + COD_FORMA + "'": "null";
			string fk_pendencia;
			if (COD_PENDENCIA.Trim().Length > 0)
				fk_pendencia = "'" + COD_PENDENCIA + "'";
			else
				fk_pendencia = "null";
			string sql = 
				"update TITULOS_PAGAR set " +
				"COD_USUARIO='"  + COD_USUARIO + "'," +
				"DAT_EMISSAO='"  + DAT_EMISSAO.ToString("M/d/yyyy") + "'," +
				"DAT_VENCIMENTO='"  + DAT_VENCIMENTO.ToString("M/d/yyyy") + "'," +
				"COD_PARCEIRO='"  + COD_PARCEIRO + "'," +
				"COD_FUNCIONARIO='"  + COD_FUNCIONARIO + "'," +
				"COD_NATUREZA="  + natureza + "," +
				"IDT_TIPO='"  + IDT_TIPO + "'," +
				"VLR_PREVISTO=" + VLR_PREVISTO.ToString().Replace(',','.') + "," +
				"DAT_PAGAMENTO="  + data + "," +
				"VLR_PAGO=" + VLR_PAGO.ToString().Replace(',','.') + "," +
				"COD_FORMA="  + forma + "," +
				"COD_DOC_ORIGEM='"  + COD_DOC_ORIGEM + "'," +
				"COD_DOC_GERADO='"  + COD_DOC_GERADO + "'," +
				"COD_PENDENCIA="  + fk_pendencia + "," +				
				"TXT_OBSERVACAO='"  + TXT_OBSERVACAO + "' " +
				"where COD_TITULO="  + COD_TITULO;
			FbCommand cmd = new FbCommand(sql, Globais.bd);
			try
			{
				Log.Grava(Globais.sUsuario, cmd.CommandText);
				cmd.ExecuteNonQuery();
			}
			catch (Exception err)
			{
				Log.Grava(Globais.sUsuario, "erro:" + err.Message);
				msg = err.Message;
				return false;
			}
			
			
			sql = "delete from pedidos_pagos " +
					"where COD_TITULO=" + COD_TITULO;
			cmd = new FbCommand(sql, Globais.bd);
			try
			{
				Log.Grava(Globais.sUsuario, cmd.CommandText);
				cmd.ExecuteNonQuery();
			}
			catch (Exception err)
			{
				Log.Grava(Globais.sUsuario, "erro:" + err.Message);
				msg = err.Message;
				return false;
			}
			
			foreach (string ped in pedidos)
			{
				string fornecedor_ped = "";
				DateTime data_ped = DateTime.Now;
				string orcamento_ped = "";
				string pedido_ped = "";
				Globais.SeparaPedido(ped, ref fornecedor_ped, ref data_ped, ref orcamento_ped, ref pedido_ped);
				sql = "insert into pedidos_pagos values(" +
						"'" + fornecedor_ped + "'," +
						"'" + data_ped.ToString("M/d/yyyy") + "'," +
						orcamento_ped + "," +
						pedido_ped + "," +
						COD_TITULO + ")";
				cmd = new FbCommand(sql, Globais.bd);
				try
				{
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
				}
				catch (Exception err)
				{
					Log.Grava(Globais.sUsuario, "erro:" + err.Message);
					msg = err.Message;
					return false;
				}
			}
			msg = "OK";
			return true;
		}
		
		public bool Exclui(int codigo, ref string msg)
		{
			string sql = "delete from TITULOS_PAGAR " +
						 "where COD_TITULO=" + codigo;
			FbCommand cmd = new FbCommand(sql, Globais.bd);
			try
			{
				Log.Grava(Globais.sUsuario, cmd.CommandText);
				cmd.ExecuteNonQuery();
			}
			catch (Exception err)
			{
				Log.Grava(Globais.sUsuario, "erro:" + err.Message);
				msg = err.Message;
				return false;
			}
			msg = "OK";
			return true;
		}
		
		public void AgrupaPorVencimento(DateTime dtini, DateTime dtfim, ref ArrayList valores, ref ArrayList descricoes, int N)
		{
			string datai = dtini.ToString("M/d/yyyy");
			string dataf = dtfim.ToString("M/d/yyyy");
			string sql = 
				"select b.DES_NATUREZA,sum(a.VLR_PREVISTO) " +
				"from TITULOS_PAGAR a, NATUREZAS_PAGAMENTO b " +
				"where a.COD_NATUREZA = b.COD_NATUREZA and " +
				"      a.DAT_VENCIMENTO between '" + datai + "' and '" + dataf + "' " +
				"group by b.DES_NATUREZA " +
				"order by 2 desc";
			FbCommand cmd = new FbCommand(sql, Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			int n=0;
			float outros=0;
			while (reader.Read())
			{
				if (++n > N) 
				{
					outros += reader.GetFloat(1);
				}
				else 
				{
					descricoes.Add(reader.GetString(0).Trim());
					valores.Add(reader.GetFloat(1));
				}
			}
			if (outros > 0) {
				descricoes.Add("Outros");
				valores.Add(outros);
			}
			reader.Close();
		}
		
		public void FixoVariavel(DateTime dtini, DateTime dtfim, ref ArrayList valores, ref ArrayList descricoes)
		{
			string datai = dtini.ToString("M/d/yyyy");
			string dataf = dtfim.ToString("M/d/yyyy");
			FbCommand cmd;
			FbDataReader reader;
			string sql;
			
			sql = 
				"select sum(VLR_PREVISTO) " +
				"from TITULOS_PAGAR " +
				"where DAT_VENCIMENTO between '" + datai + "' and '" + dataf + "' and " +
				"      IDT_TIPO='F'";
			cmd = new FbCommand(sql, Globais.bd);
			reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			descricoes.Add("Fixo");
			if (reader.Read())
				valores.Add(reader.GetFloat(0));
			else
				valores.Add(0f);
			reader.Close();
			
			sql = 
				"select sum(VLR_PREVISTO) " +
				"from TITULOS_PAGAR " +
				"where DAT_VENCIMENTO between '" + datai + "' and '" + dataf + "' and " +
				"      IDT_TIPO='V'";
			cmd = new FbCommand(sql, Globais.bd);
			reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			descricoes.Add("Variável");
			if (reader.Read())
				valores.Add(reader.GetFloat(0));
			else
				valores.Add(0f);
			reader.Close();

			sql = 
				"select sum(VLR_PREVISTO) " +
				"from TITULOS_PAGAR " +
				"where DAT_VENCIMENTO between '" + datai + "' and '" + dataf + "' and " +
				"      IDT_TIPO='S'";
			cmd = new FbCommand(sql, Globais.bd);
			reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			descricoes.Add("Semi-fixa");
			if (reader.Read())
				valores.Add(reader.GetFloat(0));
			else
				valores.Add(0f);
			reader.Close();			
		}
		
		public float SomaPorVencimento(string natureza, DateTime dtini, DateTime dtfim, ref ArrayList valores, ref ArrayList datas)
		{
			int mes=dtini.Month, ano=dtini.Year, n=0;
			string data;
			string datai;
			string dataf;
			string sql;
			float vlr, max=0;
			FbCommand cmd;
			FbDataReader reader;
			
			string[] meses = {"Jan", "Fev", "Mar", "Abr", "Mai", "Jun", "Jul", "Ago", "Set", "Out", "Nov", "Dec"};
			while ((ano < dtfim.Year) || ((ano == dtfim.Year) && (mes <= dtfim.Month)))
			{
				if (++n > 12) break;
				data = meses[mes-1];
				datai = mes.ToString() + "/1/" + ano.ToString();
				dataf = mes.ToString() + "/" + DateTime.DaysInMonth(ano, mes).ToString() + "/" + ano.ToString();
				sql = 
					"select sum(VLR_PREVISTO) " +
					"from TITULOS_PAGAR " +
					"where COD_NATUREZA = '" + natureza + "' and " +
					"      DAT_VENCIMENTO between '" + datai + "' and '" + dataf + "'";
				cmd = new FbCommand(sql, Globais.bd);
				reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
				if (reader.Read())
				{
					if (!reader.IsDBNull(0))
						vlr = reader.GetFloat(0);
					else
						vlr = 0;
					if (vlr > max) max = vlr;
					valores.Add(vlr);
				}
				else
					valores.Add(0F);				
				reader.Close();
				datas.Add(data);
				mes++;
				if (mes > 12)
				{
					mes = 1;
					ano++;
				}
			}
			return max;
		}
		
		public bool Paga(
			DateTime DAT_PAGAMENTO,
			string COD_FORMA,
			string COD_DOC_GERADO,
			string where,
			ref string msg)
		{
			string data = DAT_PAGAMENTO.ToString("M/d/yyyy");
			string forma = COD_FORMA.Length > 0 ? "'" + COD_FORMA + "'": "null";
			string sql = 
				"update TITULOS_PAGAR a set " +
				"a.DAT_PAGAMENTO='"  + data + "'," +
				"a.VLR_PAGO=VLR_PREVISTO," +
				"a.COD_FORMA="  + forma + "," +
				"a.COD_DOC_GERADO='"  + COD_DOC_GERADO + "' " +
				where;
			FbCommand cmd = new FbCommand(sql, Globais.bd);
			try
			{
				Log.Grava(Globais.sUsuario, cmd.CommandText);
				cmd.ExecuteNonQuery();
			}
			catch (Exception err)
			{
				Log.Grava(Globais.sUsuario, "erro:" + err.Message);
				msg = err.Message;
				return false;
			}
			msg = "OK";
			return true;
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

		private PdfPTable Parte12(string titulo)
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
			cell = new Celula(Frase("FILIAL: ", Globais.sFilial, 10));			
			table.AddCell(cell);
			return table;
		}
		
		private void Parte1(PDF pdf, string titulo)
		{
			Tabela table = new Tabela(22);
			PdfPCell cell;
			
			cell = new PdfPCell();
			cell.AddElement(Parte11());
			cell.Colspan = 4;
			table.AddCell(cell);
			
			cell = new PdfPCell();
			cell.AddElement(Parte12(titulo));
			cell.Colspan = 11;
			table.AddCell(cell);

			cell = new PdfPCell();
			cell.AddElement(Parte13());
			cell.Colspan = 7;
			table.AddCell(cell);

			pdf.doc.Add(table);
		}
		
		public bool Gera(string where, string arquivo, string titulo, char quebra)
		{
			FbCommand cmd;
			FbDataReader reader;
			string order="";
			bool quebrou;
			if (quebra == 'v')
				order = "order by a.DAT_VENCIMENTO";
			if (quebra == 'p')
				order = "order by a.DAT_PAGAMENTO";
			if (quebra == 'n')
				order = "order by a.COD_NATUREZA";			
			
			cmd =  new FbCommand("select a.DAT_VENCIMENTO," +
			                     "b.DES_NATUREZA," +
			                     "a.COD_PARCEIRO," +
			                     "a.COD_FUNCIONARIO," +
			                     "a.COD_DOC_ORIGEM," +
			                     "a.IDT_TIPO," +
			                     "a.DAT_EMISSAO," +
			                     "a.VLR_PREVISTO," +
			                     "a.VLR_PAGO," +
			                     "a.DAT_PAGAMENTO," +
			                     "c.DES_FORMA," +
			                     "a.COD_DOC_GERADO," +
			                     "a.TXT_OBSERVACAO " +
								 "from TITULOS_PAGAR a " +
								 "left outer join NATUREZAS_PAGAMENTO b " +
								 "on b.COD_NATUREZA = a.COD_NATUREZA " +
								 "left outer join FORMAS_PAGAMENTO c " +
								 "on c.COD_FORMA = a.COD_FORMA " +				
			                     where + " " + 
			                     order,
			                     Globais.bd);
			reader = cmd.ExecuteReader(CommandBehavior.Default);
			
			PDF pdf = new PDF(arquivo);
			pdf.Abre();
			Parte1(pdf, titulo);
			
			/*
			pdf.CriaTabela(2, 0);
			pdf.AdicionaCelula("imagens\\logo_rel.jpg", 1000, 1000);
			pdf.AdicionaCelula(titulo, BaseFont.HELVETICA_BOLD, 16);
			pdf.AdicionaTabela();
			*/
			
			int colunas = (quebra == 'n') ? 11 : 13;
			pdf.CriaTabela(colunas, 0);
			
			DateTime dataquebra = DateTime.Parse("01/01/1970");
			string naturezaquebra = "";
			
			string DES_NATUREZA;
			string DES_FORMA;
			float TotalPrevisto=-1;
			float TotalPago=-1;
			float TotalGeralPrevisto=0;
			float TotalGeralPago=0;
			bool datanula=false;
			while (reader.Read())
			{
				DAT_VENCIMENTO = !reader.IsDBNull(0) ? reader.GetDateTime(0) : DateTime.Now;									
				DES_NATUREZA = !reader.IsDBNull(1) ? reader.GetString(1).Trim() : "";
				COD_PARCEIRO = !reader.IsDBNull(2) ? reader.GetString(2).Trim() : "";
				COD_FUNCIONARIO = !reader.IsDBNull(3) ? reader.GetString(3).Trim() : "";
				COD_DOC_ORIGEM = !reader.IsDBNull(4) ? reader.GetString(4).Trim() : "";
				IDT_TIPO = !reader.IsDBNull(5) ? reader.GetString(5).Trim() : "F";
				DAT_EMISSAO = !reader.IsDBNull(6) ? reader.GetDateTime(6) : DateTime.Now;				
				VLR_PREVISTO = !reader.IsDBNull(7) ? reader.GetFloat(7) : 0;
				VLR_PAGO = !reader.IsDBNull(8) ? reader.GetFloat(8) : 0;
				datanula = reader.IsDBNull(9);
				DAT_PAGAMENTO = !reader.IsDBNull(9) ? reader.GetDateTime(9) : DateTime.Now;
				DES_FORMA = !reader.IsDBNull(10) ? reader.GetString(10).Trim() : "";
				COD_DOC_GERADO = !reader.IsDBNull(11) ? reader.GetString(11).Trim() : "";
				TXT_OBSERVACAO = !reader.IsDBNull(12) ? reader.GetString(12).Trim() : "";
				quebrou = false;
				if (quebra == 'v')
					quebrou = dataquebra.Date != DAT_VENCIMENTO.Date;
				if (quebra == 'p')
					quebrou = dataquebra.Date != DAT_PAGAMENTO.Date;
				if (quebra == 'n')
					quebrou = naturezaquebra != DES_NATUREZA;
				if (quebrou)
				{
					if ((TotalPrevisto != -1) || (TotalPago != -1)) {					
						pdf.AdicionaCelulaLinha("Total", BaseFont.HELVETICA_BOLD, 6, 2);						
						pdf.AdicionaCelulaLinha("", BaseFont.HELVETICA_BOLD, 6, colunas-7);	
						pdf.AdicionaCelulaLinha(TotalPrevisto.ToString("#,###,##0.00"), BaseFont.HELVETICA_BOLD, 6, Element.ALIGN_RIGHT, 1);	
						pdf.AdicionaCelulaLinha(TotalPago.ToString("#,###,##0.00"), BaseFont.HELVETICA_BOLD, 6, Element.ALIGN_RIGHT, 1);	
						pdf.AdicionaCelulaLinha("", BaseFont.HELVETICA_BOLD, 6, 3);	
						TotalGeralPrevisto += TotalPrevisto;
						TotalGeralPago += TotalPago;
					}

					TotalPrevisto = 0;
					TotalPago = 0;
					
					if (quebra == 'v')
					{
						pdf.AdicionaCelula("Vencimento: " + DAT_VENCIMENTO.ToString("d/M/yyyy"), BaseFont.HELVETICA_BOLD, 6, Color.GRAY, colunas);
						dataquebra = DAT_VENCIMENTO;
					}
					if (quebra == 'p')
					{
						pdf.AdicionaCelula("Pagamento: " + DAT_PAGAMENTO.ToString("d/M/yyyy"), BaseFont.HELVETICA_BOLD, 6, Color.GRAY, colunas);
						dataquebra = DAT_PAGAMENTO;
					}
					if (quebra == 'n')
					{
						pdf.AdicionaCelula("Natureza: " + DES_NATUREZA, BaseFont.HELVETICA_BOLD, 6, Color.GRAY, colunas);
						naturezaquebra = DES_NATUREZA;
					}				

					pdf.AdicionaCelula("Parceiro", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, 3);
					pdf.AdicionaCelula("Doc Origem", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY);
					pdf.AdicionaCelula("Tipo", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY);
					pdf.AdicionaCelula("Emissão", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY);
					pdf.AdicionaCelula("Previsto", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 1);
					pdf.AdicionaCelula("Pago", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 1);
					if ((quebra == 'v') || (quebra == 'n'))
						pdf.AdicionaCelula("Pagto", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY);
					if (quebra == 'p')
						pdf.AdicionaCelula("Vencto", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY);
					pdf.AdicionaCelula("Forma", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY);
					pdf.AdicionaCelula("Doc Gerado", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY);
					if (colunas > 11) 
						pdf.AdicionaCelula("", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, colunas-11);
					
					pdf.AdicionaCelula("", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, 2);
					pdf.AdicionaCelula("Observação", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, colunas-2);
			
				}
				if (quebra != 'n')
				{
					pdf.AdicionaCelula(DES_NATUREZA, BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 2);
				}
				if (COD_PARCEIRO.Trim().Length > 0)
					pdf.AdicionaCelula(COD_PARCEIRO, BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 3);
				else
					pdf.AdicionaCelula(COD_FUNCIONARIO, BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 3);
				pdf.AdicionaCelula(COD_DOC_ORIGEM, BaseFont.HELVETICA, 6);
				switch (IDT_TIPO[0]) {
					case 'F':
						pdf.AdicionaCelula("Fixo", BaseFont.HELVETICA, 6);
						break;
					case 'V':
						pdf.AdicionaCelula("Variável", BaseFont.HELVETICA, 6);
						break;						
					case 'S':
						pdf.AdicionaCelula("Semi-fixa", BaseFont.HELVETICA, 6);
						break;												
				}
				pdf.AdicionaCelula(DAT_EMISSAO.ToString("d/M/yyyy"), BaseFont.HELVETICA, 6);
				pdf.AdicionaCelula(VLR_PREVISTO.ToString("#,###,##0.00"), BaseFont.HELVETICA, 6, Element.ALIGN_RIGHT, 1);
				pdf.AdicionaCelula(VLR_PAGO.ToString("#,###,##0.00"), BaseFont.HELVETICA, 6, Element.ALIGN_RIGHT, 1);
				if ((quebra == 'v') || (quebra == 'n'))
				{
					if (!datanula)
						pdf.AdicionaCelula(DAT_PAGAMENTO.ToString("d/M/yyyy"), BaseFont.HELVETICA, 6);
					else
						pdf.AdicionaCelula("-", BaseFont.HELVETICA, 6);
				}
				else
					pdf.AdicionaCelula(DAT_VENCIMENTO.ToString("d/M/yyyy"), BaseFont.HELVETICA, 6);
				pdf.AdicionaCelula(DES_FORMA, BaseFont.HELVETICA, 6);
				pdf.AdicionaCelula(COD_DOC_GERADO, BaseFont.HELVETICA, 6);
				pdf.AdicionaCelula("", BaseFont.HELVETICA, 6, Color.WHITE, 2);
				pdf.AdicionaCelula(TXT_OBSERVACAO, BaseFont.HELVETICA, 6, Color.WHITE, colunas-2);
				TotalPrevisto += VLR_PREVISTO;
				TotalPago += VLR_PAGO;
			}
			if ((TotalPrevisto != 0) || (TotalPago != 0)) {
				pdf.AdicionaCelulaLinha("Total", BaseFont.HELVETICA_BOLD, 6, 2);						
				pdf.AdicionaCelulaLinha("", BaseFont.HELVETICA_BOLD, 6, colunas-7);	
				pdf.AdicionaCelulaLinha(TotalPrevisto.ToString("#,###,##0.00"), BaseFont.HELVETICA_BOLD, 6, Element.ALIGN_RIGHT, 1);	
				pdf.AdicionaCelulaLinha(TotalPago.ToString("#,###,##0.00"), BaseFont.HELVETICA_BOLD, 6, Element.ALIGN_RIGHT, 1);	
				pdf.AdicionaCelulaLinha("", BaseFont.HELVETICA_BOLD, 6, 3);	
				TotalGeralPrevisto += TotalPrevisto;
				TotalGeralPago += TotalPago;
			}

			pdf.AdicionaCelulaLinha("Total Geral", BaseFont.HELVETICA_BOLD, 6, 2);						
			pdf.AdicionaCelulaLinha("", BaseFont.HELVETICA_BOLD, 6, colunas-7);	
			pdf.AdicionaCelulaLinha(TotalGeralPrevisto.ToString("#,###,##0.00"), BaseFont.HELVETICA_BOLD, 6, Element.ALIGN_RIGHT, 1);	
			pdf.AdicionaCelulaLinha(TotalGeralPago.ToString("#,###,##0.00"), BaseFont.HELVETICA_BOLD, 6, Element.ALIGN_RIGHT, 1);	
			pdf.AdicionaCelulaLinha("", BaseFont.HELVETICA_BOLD, 6,3);	
			
			reader.Close();			
			pdf.AdicionaTabela();			
			pdf.Fecha();
			return true;
		}
		
		/*
		public ArrayList CarregaPorPedido(string fornecedor, DateTime data, short orcamento, short pedido)
		{
			ArrayList lista = new ArrayList();
			string where =	"where COD_FORNECEDOR = '" + fornecedor + "' and " +
							"DAT_ORCAMENTO = '" + data.ToString("M/d/yyyy") + "' and " +
							"COD_ORCAMENTO = " + orcamento + " and " +
							"COD_PEDIDO = " + pedido;
			string sql = 
				"select " +
				"       COD_TITULO " +
				"from PEDIDOS_PAGOS " +
				where + " " +
				"order by COD_TITULO";
			FbCommand cmd = new FbCommand(sql, Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			while (reader.Read())
			{
				int cod = reader.GetInt32(0);
				lista.Add(cod.ToString("000000000"));
			}
			reader.Close();
			return lista;
		}
		*/
		
		public ArrayList CarregaPorPedidoHint(string fornecedor, DateTime data, short orcamento, short pedido)
		{
			ArrayList lista = new ArrayList();
			string where =	"where pp.COD_FORNECEDOR = '" + fornecedor + "' and " +
							"pp.DAT_ORCAMENTO = '" + data.ToString("M/d/yyyy") + "' and " +
							"pp.COD_ORCAMENTO = " + orcamento + " and " +
							"pp.COD_PEDIDO = " + pedido;
			string sql = 
				"select " +
				"       pp.COD_TITULO,t.DAT_EMISSAO,t.COD_PARCEIRO " +
				"from PEDIDOS_PAGOS pp " +
				"inner join TITULOS_PAGAR t on t.COD_TITULO=pp.COD_TITULO " +
				where + " " +
				"order by pp.COD_TITULO";
			FbCommand cmd = new FbCommand(sql, Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			while (reader.Read())
			{
				int cod = reader.GetInt32(0);
				DateTime emissao = reader.IsDBNull(1) ? reader.GetDateTime(1) : DateTime.Now;
				string parceiro = reader.GetString(2);
				lista.Add(cod.ToString("000000000") + " - " + emissao.ToString("dd/MM/yyyy") + " - " + parceiro);
			}
			reader.Close();
			return lista;
		}		
				
		public void CarregaPedidos(
			int codigo,
			ComboBox cbx)
		{
			FbCommand cmd =  new FbCommand("select " +
					"cod_fornecedor," +
					"dat_orcamento," +
					"cod_orcamento," +
					"cod_pedido " +
					"from pedidos_pagos " +
					"where COD_TITULO=" + codigo,
					Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			while (reader.Read())
			{
				string fornecedor = !reader.IsDBNull(0) ? reader.GetString(0).Trim() : "";
				DateTime data = !reader.IsDBNull(1) ? reader.GetDateTime(1) : DateTime.Now;
				int orcamento = !reader.IsDBNull(2) ? reader.GetInt32(2) : 0;
				int pedido = !reader.IsDBNull(3) ? reader.GetInt32(3) : 0;				
				string chave =	fornecedor + " " +
							data.ToString("d/M/yyyy") + " " +
							orcamento.ToString() + " " +
							pedido.ToString();
				cbx.Items.Add(chave);
			}
			reader.Close();
		}		
		
		public bool Lista(string nome_pdf, ArrayList descricoes, ArrayList valores, char origem)
		{
			PDF pdf = new PDF(nome_pdf);
			pdf.Abre();
			
			pdf.CriaTabela(2, 0);
			pdf.tabela.WidthPercentage = 80;
			pdf.AdicionaCelula("imagens\\logo_rel.jpg", 1000, 1000);
			if (origem == 'p')
				pdf.AdicionaCelula("Despesas por Natureza", BaseFont.HELVETICA_BOLD, 16);
			else
				pdf.AdicionaCelula("Receitas por Natureza", BaseFont.HELVETICA_BOLD, 16);
			pdf.AdicionaTabela();

			pdf.CriaTabela(3, 0);
			pdf.tabela.WidthPercentage = 40;
			pdf.AdicionaCelula("Natureza", BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, 2);
			pdf.AdicionaCelula("Valor", BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 1);

			double total=0;
			int i=0;
			foreach (string descricao in descricoes)
			{
				int j = 0;
				string valor="";
				foreach (float v in valores)
				{
					valor = v.ToString("#,###,##0.00");
					if (j++ == i) {
						total += v;						
						break;
					}
				}
				i++;
				//if ((i % 2) == 0)
				//{
				pdf.AdicionaCelula(descricao, BaseFont.HELVETICA, 8, Element.ALIGN_LEFT, 2);
				pdf.AdicionaCelula(valor, BaseFont.HELVETICA, 8, Element.ALIGN_RIGHT, 1);
				//}
				//else
				//{
					//pdf.AdicionaCelula(descricao, BaseFont.HELVETICA, 8, Element.ALIGN_LEFT, 2, 0.8f);
					//pdf.AdicionaCelula(valor, BaseFont.HELVETICA, 8, Element.ALIGN_RIGHT, 1, 0.8f);					
				//}
			}
			
			pdf.AdicionaCelulaLinha("Total", BaseFont.HELVETICA_BOLD, 8, 2);						
			pdf.AdicionaCelulaLinha(total.ToString("#,###,##0.00"), BaseFont.HELVETICA_BOLD, 8, Element.ALIGN_RIGHT, 1);	

			pdf.AdicionaTabela();			
			pdf.Fecha();
			return true;
		}

		public static void AdicionaCelula(Tabela tabela, string texto, string BaseFont_, int tamanho, int alinhamento, int colunas)
		{
			Chunk chunk = new Chunk(texto, FontFactory.GetFont(BaseFont_, tamanho));
			PdfPCell cell = new PdfPCell(new Paragraph(chunk));
			cell.HorizontalAlignment = alinhamento;	
			cell.Colspan = colunas;
			tabela.AddCell(cell);
		}		
		
		public static void AdicionaCelula(Tabela tabela, string texto, string BaseFont_, int tamanho, iTextSharp.text.Color cor, int colunas)
		{
			Chunk chunk = new Chunk(texto, FontFactory.GetFont(BaseFont_, tamanho));
			PdfPCell cell = new PdfPCell(new Paragraph(chunk));
			cell.BackgroundColor = cor;
			cell.Colspan = colunas;
			tabela.AddCell(cell);
		}		
		
		public static void AdicionaCelula(Tabela tabela, string texto, string BaseFont_, int tamanho, Color cor, int alinhamento, int colunas)
		{
			Chunk chunk = new Chunk(texto, FontFactory.GetFont(BaseFont_, tamanho));
			PdfPCell cell = new PdfPCell(new Paragraph(chunk));
			cell.BackgroundColor = cor;
			cell.HorizontalAlignment = alinhamento;				
			cell.Colspan = colunas;
			tabela.AddCell(cell);
		}
				
		public static void GeraDespesasNatureza(Document doc, DateTime inicio, DateTime fim)
		{
			Tabela table = new Tabela(5);			
			AdicionaCelula(table, "Natureza", BaseFont.HELVETICA_BOLD, 8, iTextSharp.text.Color.WHITE, 1);
			AdicionaCelula(table, "Descrição", BaseFont.HELVETICA_BOLD, 8, iTextSharp.text.Color.WHITE, 3);			
			AdicionaCelula(table, "Valor", BaseFont.HELVETICA_BOLD, 8, iTextSharp.text.Color.WHITE, Element.ALIGN_RIGHT, 1);			
			
			string datai = inicio.ToString("M/d/yyyy");
			string dataf = fim.ToString("M/d/yyyy");
			string sql = 
				"select b.COD_NATUREZA,b.DES_NATUREZA,sum(a.VLR_PREVISTO) " +
				"from TITULOS_PAGAR a, NATUREZAS_PAGAMENTO b " +
				"where a.COD_NATUREZA = b.COD_NATUREZA and " +
				"      a.DAT_VENCIMENTO between '" + datai + "' and '" + dataf + "' " +
				"group by b.COD_NATUREZA,b.DES_NATUREZA " +
				"order by 3 desc";
			FbCommand cmd = new FbCommand(sql, Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			float total=0;
			while (reader.Read())				
			{
				string codigo = reader.GetString(0);
				string descricao = reader.GetString(1);
				float valor = reader.GetFloat(2);
				total += valor;
				AdicionaCelula(table, codigo, BaseFont.HELVETICA, 8, Element.ALIGN_LEFT, 1);				
				AdicionaCelula(table, descricao, BaseFont.HELVETICA, 8, Element.ALIGN_LEFT, 3);
				AdicionaCelula(table, valor.ToString("#,###,##0.00"), BaseFont.HELVETICA, 8, Element.ALIGN_RIGHT, 1);
			}
			reader.Close();
			
			AdicionaCelula(table, "Total", BaseFont.HELVETICA_BOLD, 8, Color.WHITE, 4);						
			AdicionaCelula(table, total.ToString("#,###,##0.00"), BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 1);							
			doc.Add(table);
		}		

	}
}
