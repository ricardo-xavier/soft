/*
 * Projeto  : SoftPlace
 * Programa : cTitulosXeceber - Classe de Titulos a Xeceber
 * Autor    : Ricardo Costa Xavier
 * Data     : 21/08/08
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
	public class cTituloXeceber
	{
		public string NRO_NF;
		public short SEQ_TITULO;
		public string COD_USUARIO;
		public DateTime DAT_EMISSAO;
		public DateTime DAT_VENCIMENTO;
		public string COD_CLIENTE;
		public string COD_NATUREZA;
		public string IDT_TIPO;
		public float VLR_PREVISTO;
		public bool chkDAT_RECEBIMENTO;
		public DateTime DAT_RECEBIMENTO;
		public float VLR_RECEBIDO;
		public string COD_FORMA;
		public string COD_PENDENCIA;
		public string TXT_OBSERVACAO;
		public string IDT_CANCELADO;
		public string DES_MOTIVO;
		public string COD_FORNECEDOR;
		public DateTime DAT_ORCAMENTO;
		public short COD_ORCAMENTO;
		public short COD_PEDIDO;
		public string CHAVE_PEDIDO;
		
		public cTituloXeceber()
		{
		}
	}
	
	public class cTitulosXeceber
	{
		public static string versao = "v2.0 (24/03/19)";
		
		public cTitulosXeceber()
		{
		}
		
		public void Carrega(DataGridView grid, string where)
		{
			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			string sql = 
				"select " +
				"       a.DAT_VENCIMENTO," +  // 0				
				"       a.NRO_NF," +          // 1
				"       a.SEQ_TITULO," +      // 2
				"       a.COD_CLIENTE," +     // 3
				"       b.DES_NATUREZA," +    // 4
				"       a.VLR_PREVISTO," +    // 5
				"       a.VLR_RECEBIDO," +    // 6
				"       a.DAT_RECEBIMENTO," + // 7
				"       a.NRO_PEDIDO," +      // 8
				"       c.DES_PENDENCIA," +   // 9
				"       a.TXT_OBSERVACAO,"+   // 10
				"       d.DES_FORMA," +       // 11
				"       ' '," +				  // 12
				"       a.IDT_TIPO," +  	  // 13
				"       a.COD_FORNECEDOR," +  // 14
				"       a.DAT_ORCAMENTO," +   // 15
				"       a.COD_ORCAMENTO," +   // 16
				"       a.COD_PEDIDO " +      // 17	
				"from TITULOS_RECEBER a " +
				"left outer join NATUREZAS_RECEBIMENTO b " +
				"on b.COD_NATUREZA = a.COD_NATUREZA " +
				"left outer join PENDENCIAS_RECEBIMENTO c " +
				"on c.COD_PENDENCIA = a.COD_PENDENCIA " +
				"left outer join FORMAS_RECEBIMENTO d " +
				"on d.COD_FORMA = a.COD_FORMA " +				
				where + " " +
				"order by a.DAT_VENCIMENTO,a.NRO_NF,a.SEQ_TITULO";
			adapter.SelectCommand = new FbCommand(sql, Globais.bd);
			adapter.Fill(table);
			table.Columns[0].ColumnName = "Vencimento";
			table.Columns[1].ColumnName = "NF";
			table.Columns[2].ColumnName = "Seq";
			table.Columns[3].ColumnName = "Cliente";			
			table.Columns[4].ColumnName = "Natureza";				
			table.Columns[5].ColumnName = "Valor";
			table.Columns[6].ColumnName = "Recebido";
			table.Columns[7].ColumnName = "Recebimento";
			table.Columns[8].ColumnName = "Pedido";
			table.Columns[9].ColumnName = "Pendência";
			table.Columns[10].ColumnName = "Observação";
			table.Columns[11].ColumnName = "Forma";
			table.Columns[12].ColumnName = "Situação";
			table.Columns[13].ColumnName = "Tipo";
			table.Columns[14].ColumnName = "Fornecedor";
			table.Columns[15].ColumnName = "Data";
			table.Columns[16].ColumnName = "Orçamento";
			table.Columns[17].ColumnName = "CodPedido";
			grid.DataSource = table;
			grid.Columns["Observação"].Visible = false;	
			grid.Columns["Tipo"].Visible = false;	
			grid.Columns["Forma"].Visible = false;	
			grid.Columns["Fornecedor"].Visible = false;	
			grid.Columns["Data"].Visible = false;	
			grid.Columns["Orçamento"].Visible = false;	
			grid.Columns["CodPedido"].Visible = false;	
			grid.Columns["Pedido"].Visible = false;	
			grid.Columns["Valor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			grid.Columns["Valor"].DefaultCellStyle.Format = "#,###,##0.00";
			grid.Columns["Recebido"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			grid.Columns["Recebido"].DefaultCellStyle.Format = "#,###,##0.00";			
			grid.Columns["Seq"].Width = 30;
		}

		public void CarregaPorPedidoClick(DataGridView grid, string where)
		{
			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			string sql = 
				"select " +
				"       a.DAT_VENCIMENTO," +  // 0
				"       a.NRO_NF," +          // 1
				"       a.SEQ_TITULO," +      // 2
				"       a.COD_CLIENTE," +     // 3
				"       b.DES_NATUREZA," +    // 4
				"       a.VLR_PREVISTO," +    // 5
				"       a.VLR_RECEBIDO," +    // 6
				"       a.DAT_RECEBIMENTO," + // 7
				"       a.NRO_PEDIDO," +      // 8
				"       c.DES_PENDENCIA," +   // 9
				"       a.TXT_OBSERVACAO,"+   // 10
				"       d.DES_FORMA," +       // 11
				"       ' '," +				  // 12
				"       a.IDT_TIPO," +  	  // 13
				"       a.COD_FORNECEDOR," +  // 14
				"       a.DAT_ORCAMENTO," +   // 15
				"       a.COD_ORCAMENTO," +   // 16
				"       a.COD_PEDIDO " +      // 17
				"from TITULOS_RECEBER a " +
				"left outer join NATUREZAS_RECEBIMENTO b " +
				"on b.COD_NATUREZA = a.COD_NATUREZA " +
				"left outer join PENDENCIAS_RECEBIMENTO c " +
				"on c.COD_PENDENCIA = a.COD_PENDENCIA " +
				"left outer join FORMAS_RECEBIMENTO d " +
				"on d.COD_FORMA = a.COD_FORMA " +
				where + " " +
				"order by a.DAT_VENCIMENTO,a.NRO_NF,a.SEQ_TITULO";
			adapter.SelectCommand = new FbCommand(sql, Globais.bd);
			adapter.Fill(table);
			table.Columns[0].ColumnName = "Vencimento";
			table.Columns[1].ColumnName = "NF";
			table.Columns[2].ColumnName = "Seq";
			table.Columns[3].ColumnName = "Cliente";			
			table.Columns[4].ColumnName = "Natureza";				
			table.Columns[5].ColumnName = "Valor";
			table.Columns[6].ColumnName = "Recebido";
			table.Columns[7].ColumnName = "Recebimento";
			table.Columns[8].ColumnName = "Pedido";
			table.Columns[9].ColumnName = "Pendência";
			table.Columns[10].ColumnName = "Observação";
			table.Columns[11].ColumnName = "Forma";
			table.Columns[12].ColumnName = "Situação";
			table.Columns[13].ColumnName = "Tipo";
			table.Columns[14].ColumnName = "Fornecedor";
			table.Columns[15].ColumnName = "Data";
			table.Columns[16].ColumnName = "Orçamento";
			table.Columns[17].ColumnName = "CodPedido";
			grid.DataSource = table;
			grid.Columns["Observação"].Visible = false;	
			grid.Columns["Tipo"].Visible = false;	
			grid.Columns["Forma"].Visible = false;	
			grid.Columns["Fornecedor"].Visible = false;	
			grid.Columns["Data"].Visible = false;	
			grid.Columns["Orçamento"].Visible = false;	
			grid.Columns["CodPedido"].Visible = false;	
			grid.Columns["Pedido"].Visible = false;	
			grid.Columns["Valor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			grid.Columns["Valor"].DefaultCellStyle.Format = "#,###,##0.00";
			grid.Columns["Recebido"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			grid.Columns["Recebido"].DefaultCellStyle.Format = "#,###,##0.00";			
			grid.Columns["Seq"].Width = 30;			
		}
		
		public ArrayList CarregaPorPedidoHint(string fornecedor, DateTime data, short orcamento, short pedido, bool detalhes)
		{
			ArrayList lista = new ArrayList();
			string where =	"where pr.COD_FORNECEDOR = '" + fornecedor + "' and " +
							"pr.DAT_ORCAMENTO = '" + data.ToString("M/d/yyyy") + "' and " +
							"pr.COD_ORCAMENTO = " + orcamento + " and " +
							"pr.COD_PEDIDO = " + pedido;
			string sql = 
				"select " +
				"       pr.NRO_NF," +
				"       pr.SEQ_TITULO," +
				"       t.COD_CLIENTE," +
				"       t.DAT_EMISSAO " +
				//"from TITULOS_RECEBER " +
				"from PEDIDOS_RECEBIDOS pr " +
				"inner join TITULOS_RECEBER t on t.NRO_NF=pr.NRO_NF and t.SEQ_TITULO = pr.SEQ_TITULO " +
				where + " " +
				"order by pr.NRO_NF,pr.SEQ_TITULO";
			FbCommand cmd = new FbCommand(sql, Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			while (reader.Read())
			{
				string nf = reader.GetString(0).Trim();
				short seq = reader.GetInt16(1);
				string cliente = reader.GetString(2).Trim();
				DateTime emissao = reader.IsDBNull(3) ? reader.GetDateTime(3) : DateTime.Now;
				lista.Add(nf.PadLeft(9, '0') + seq.ToString("000000000"));
				if (detalhes)
					lista.Add(nf + "/" + seq.ToString() + "-" + cliente + "-" + emissao.ToString("dd/MM/yyyy"));				
			}
			reader.Close();
			return lista;
		}
		
		public void DadosRemessa(string filtro)
		{
			
		}
		
		public bool Le(string nf, short seq, ref cTituloXeceber titulo)
		{
			string sql = 
				"select COD_USUARIO," +
				"       DAT_EMISSAO," +
				"       DAT_VENCIMENTO," +
				"       COD_CLIENTE," +
				"       COD_NATUREZA," +
				"       IDT_TIPO," +
				"       VLR_PREVISTO," +
				"       DAT_RECEBIMENTO," +
				"       VLR_RECEBIDO," +
				"       COD_FORMA," +
				"       COD_PENDENCIA," +
				"       TXT_OBSERVACAO," +
				"       IDT_CANCELADO," +
				"       DES_MOTIVO," +
				"       COD_FORNECEDOR," +
				"       DAT_ORCAMENTO," +
				"       COD_ORCAMENTO," +
				"       COD_PEDIDO " +
				"from TITULOS_RECEBER " +
				"where NRO_NF='" + nf + "' and " +
				"      SEQ_TITULO=" + seq;
			FbCommand cmd = new FbCommand(sql, Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			if (reader.Read())
			{
				titulo = new cTituloXeceber();
				titulo.NRO_NF = nf;
				titulo.SEQ_TITULO = seq;
				titulo.COD_USUARIO = !reader.IsDBNull(0) ? reader.GetString(0).Trim() : "";
				titulo.DAT_EMISSAO = !reader.IsDBNull(1) ? reader.GetDateTime(1) : DateTime.Now;
				titulo.DAT_VENCIMENTO = !reader.IsDBNull(2) ? reader.GetDateTime(2) : DateTime.Now;
				titulo.COD_CLIENTE = !reader.IsDBNull(3) ? reader.GetString(3).Trim() : "";
				titulo.COD_NATUREZA = !reader.IsDBNull(4) ? reader.GetString(4).Trim() : "";
				titulo.IDT_TIPO = !reader.IsDBNull(5) ? reader.GetString(5).Trim() : "F";
				titulo.VLR_PREVISTO = !reader.IsDBNull(6) ? reader.GetFloat(6) : 0;
				titulo.chkDAT_RECEBIMENTO = !reader.IsDBNull(7);
				titulo.DAT_RECEBIMENTO = !reader.IsDBNull(7) ? reader.GetDateTime(7) : DateTime.Now;
				titulo.VLR_RECEBIDO = !reader.IsDBNull(8) ? reader.GetFloat(8) : 0;
				titulo.COD_FORMA = !reader.IsDBNull(9) ? reader.GetString(9).Trim() : "";
				titulo.COD_PENDENCIA = !reader.IsDBNull(10) ? reader.GetString(10).Trim() : "";
				titulo.TXT_OBSERVACAO = !reader.IsDBNull(11) ? reader.GetString(11).Trim() : "";
				titulo.IDT_CANCELADO = !reader.IsDBNull(12) ? reader.GetString(12).Trim() : "";
				titulo.DES_MOTIVO = !reader.IsDBNull(13) ? reader.GetString(13).Trim() : "";
				titulo.COD_FORNECEDOR = !reader.IsDBNull(14) ? reader.GetString(14).Trim() : "";
				titulo.DAT_ORCAMENTO = !reader.IsDBNull(15) ? reader.GetDateTime(15) : DateTime.Now;
				titulo.COD_ORCAMENTO = !reader.IsDBNull(16) ? reader.GetInt16(16) : (short)0;
				titulo.COD_PEDIDO = !reader.IsDBNull(17) ? reader.GetInt16(17) : (short)0;
				titulo.CHAVE_PEDIDO = "";
				if (titulo.COD_FORNECEDOR.Length > 0)
				{
					titulo.CHAVE_PEDIDO =	titulo.COD_FORNECEDOR.Trim() + " " +
											titulo.DAT_ORCAMENTO.ToString("d/M/yyyy") + " " +
											titulo.COD_ORCAMENTO.ToString() + " " +
											titulo.COD_PEDIDO.ToString();
				}
				reader.Close();
				return true;
			}
			reader.Close();
			return false;
		}
		
		public bool Inclui(
			string NRO_NF,
			short SEQ_TITULO,
			string COD_USUARIO, 
			DateTime DAT_EMISSAO, 
			DateTime DAT_VENCIMENTO,
			string COD_CLIENTE,
			string COD_NATUREZA,
			string IDT_TIPO,
			//string NRO_PEDIDO,
			ArrayList pedidos,
			float VLR_PREVISTO,
			bool chkDAT_RECEBIMENTO,
			DateTime DAT_RECEBIMENTO,
			float VLR_RECEBIDO,
			string COD_FORMA,
			string COD_PENDENCIA,
			string TXT_OBSERVACAO,
			string IDT_CANCELADO,
			string DES_MOTIVO,
			ref string msg)
		{
			//int seq=1;
			string data = chkDAT_RECEBIMENTO ? "'" + DAT_RECEBIMENTO.ToString("M/d/yyyy")  + "'" : "null";
			string natureza = COD_NATUREZA.Length > 0 ? "'" + COD_NATUREZA + "'": "null";
			string forma = COD_FORMA.Length > 0 ? "'" + COD_FORMA + "'": "null";
			/*			
			FbCommand cmd = new FbCommand("select max(SEQ_TITULO) from TITULOS_RECEBER where NRO_NF=" + NRO_NF, Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			if (reader.Read())
			{
				if (!reader.IsDBNull(0))
					seq = reader.GetInt16(0) + 1;
			}
			reader.Close();
			*/
			int seq=SEQ_TITULO;
			string NRO_PEDIDO="";
			if (pedidos.Count > 0)
				NRO_PEDIDO = (string)pedidos[0];
			string fk_pendencia;
			if (COD_PENDENCIA.Trim().Length > 0)
				fk_pendencia = "'" + COD_PENDENCIA + "'";
			else
				fk_pendencia = "null";
			string sql = 
				"insert into TITULOS_RECEBER values(" +
				"'" + NRO_NF + "'," +
				seq + "," +
				"'"  + COD_USUARIO + "'," +
				"'"  + DAT_EMISSAO.ToString("M/d/yyyy") + "'," +
				"'"  + DAT_VENCIMENTO.ToString("M/d/yyyy") + "'," +
				"'"  + COD_CLIENTE + "'," +
				natureza + "," +
				"'"  + IDT_TIPO + "'," +
				"'"  + NRO_PEDIDO + "'," +
				VLR_PREVISTO.ToString().Replace(',','.') + "," +
				data + "," +
				VLR_RECEBIDO.ToString().Replace(',','.') + "," +
				forma + "," +
				fk_pendencia + "," +
				"'"  + TXT_OBSERVACAO + "'," +
				"'"  + IDT_CANCELADO + "'," +
				"'"  + DES_MOTIVO + "', null, null, null, null)";
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
				sql = "insert into pedidos_recebidos values(" +
						"'" + fornecedor_ped + "'," +
						"'" + data_ped.ToString("M/d/yyyy") + "'," +
						orcamento_ped + "," +
						pedido_ped + "," +
						"'" + NRO_NF + "'," +
						SEQ_TITULO + ")";
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
				cPedidos.SetaDatas(fornecedor_ped, data_ped, short.Parse(orcamento_ped), short.Parse(pedido_ped), DAT_EMISSAO);
			}
			
			msg = "OK";
			return true;
		}
		
		
		public bool Altera(
			string NRO_NF,
			short SEQ_TITULO,
			string COD_USUARIO, 
			DateTime DAT_EMISSAO, 
			DateTime DAT_VENCIMENTO,
			string COD_CLIENTE,
			string COD_NATUREZA,
			string IDT_TIPO,
			//string NRO_PEDIDO,
			ArrayList pedidos,
			float VLR_PREVISTO,
			bool chkDAT_RECEBIMENTO,
			DateTime DAT_RECEBIMENTO,
			float VLR_RECEBIDO,
			string COD_FORMA,
			string COD_PENDENCIA,
			string TXT_OBSERVACAO,
			string IDT_CANCELADO,
			string DES_MOTIVO,
			//string COD_FORNECEDOR,
			//DateTime DAT_ORCAMENTO,
			//short COD_ORCAMENTO,
			//short COD_PEDIDO,
			ref string msg)
		{
			string pedido = "";
			if (pedidos.Count > 0)
			{
				string fornecedor_ped = "";
				DateTime data_ped = DateTime.Now;
				string orcamento_ped = "";
				string pedido_ped = "";
				Globais.SeparaPedido(pedidos[0].ToString(), ref fornecedor_ped, ref data_ped, ref orcamento_ped, ref pedido_ped);
				pedido =
					"COD_FORNECEDOR='"  + fornecedor_ped + "'," +
					"DAT_ORCAMENTO='"  + data_ped.ToString("M/d/yyyy") + "'," +
					"COD_ORCAMENTO="  + orcamento_ped + "," +
					"COD_PEDIDO="  + pedido_ped + " ";				
			}
			else
			{
				pedido =
					"COD_FORNECEDOR=null," +
					"DAT_ORCAMENTO=null," +				
					"COD_ORCAMENTO=null," +
					"COD_PEDIDO=null ";								
			}
			string data = chkDAT_RECEBIMENTO ? "'" + DAT_RECEBIMENTO.ToString("M/d/yyyy")  + "'" : "null";			
			string natureza = COD_NATUREZA.Length > 0 ? "'" + COD_NATUREZA + "'": "null";
			string forma = COD_FORMA.Length > 0 ? "'" + COD_FORMA + "'": "null";
			string fk_pendencia;
			if (COD_PENDENCIA.Trim().Length > 0)
				fk_pendencia = "'" + COD_PENDENCIA + "'";
			else
				fk_pendencia = "null";
			string NRO_PEDIDO="";
			if (pedidos.Count > 0)
				NRO_PEDIDO = (string)pedidos[0];			
			string sql = 
				"update TITULOS_RECEBER set " +
				"COD_USUARIO='"  + COD_USUARIO + "'," +
				"DAT_EMISSAO='"  + DAT_EMISSAO.ToString("M/d/yyyy") + "'," +
				"DAT_VENCIMENTO='"  + DAT_VENCIMENTO.ToString("M/d/yyyy") + "'," +
				"COD_CLIENTE='"  + COD_CLIENTE + "'," +
				"COD_NATUREZA="  + natureza + "," +
				"IDT_TIPO='"  + IDT_TIPO + "'," +
				"NRO_PEDIDO='"  + NRO_PEDIDO + "'," +
				"VLR_PREVISTO=" + VLR_PREVISTO.ToString().Replace(',','.') + "," +
				"DAT_RECEBIMENTO="  + data + "," +
				"VLR_RECEBIDO=" + VLR_RECEBIDO.ToString().Replace(',','.') + "," +
				"COD_FORMA="  + forma + "," +
				"COD_PENDENCIA="  + fk_pendencia + "," +				
				"TXT_OBSERVACAO='"  + TXT_OBSERVACAO + "'," +
				"IDT_CANCELADO='"  + IDT_CANCELADO + "'," +
				"DES_MOTIVO='"  + DES_MOTIVO + "'," +
				pedido;
			/*
			if (COD_FORNECEDOR.Trim().Length > 0)
			{
				sql = sql +	"," +
				"COD_FORNECEDOR='"  + COD_FORNECEDOR + "'," +
				"DAT_ORCAMENTO='"  + DAT_ORCAMENTO.ToString("M/d/yyyy") + "'," +				
				"COD_ORCAMENTO="  + COD_ORCAMENTO + "," +
				"COD_PEDIDO="  + COD_PEDIDO + " ";
			}
			*/
			sql = sql +
				"where NRO_NF='" + NRO_NF + "' and " +
				"      SEQ_TITULO=" + SEQ_TITULO;
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
			
			sql = "delete from pedidos_recebidos " +
					"where NRO_NF='" + NRO_NF + "' and " +
					"      SEQ_TITULO=" + SEQ_TITULO;
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
				sql = "insert into pedidos_recebidos values(" +
						"'" + fornecedor_ped + "'," +
						"'" + data_ped.ToString("M/d/yyyy") + "'," +
						orcamento_ped + "," +
						pedido_ped + "," +
						"'" + NRO_NF + "'," +
						SEQ_TITULO + ")";
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
				cPedidos.SetaDatas(fornecedor_ped, data_ped, short.Parse(orcamento_ped), short.Parse(pedido_ped), DAT_EMISSAO);
			}
			msg = "OK";
			return true;
		}
		
		public bool Exclui(string NRO_NF, short SEQ_TITULO, ref string msg)
		{
			string sql = "delete from TITULOS_RECEBER " +
						 "where NRO_NF='" + NRO_NF + "' and " +
						 "      SEQ_TITULO=" + SEQ_TITULO;

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
		
		public bool Desassocia(
			string NRO_NF,
			short SEQ_TITULO,
			ref string msg)
		{
			string sql = 
				"update TITULOS_RECEBER set " +
				"COD_FORNECEDOR=null, " +
				"DAT_ORCAMENTO=null, " +
				"COD_ORCAMENTO=null, " +
				"COD_PEDIDO=null " +
				"where NRO_NF='" + NRO_NF + "' and " +
				"      SEQ_TITULO=" + SEQ_TITULO;
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
		
		public bool Associa(
			string NRO_NF,
			short SEQ_TITULO,
			string fornecedor,
			DateTime data,
			string orcamento,
			string pedido,
			ref string msg)
		{
			string sql = 
				"update TITULOS_RECEBER set " +
				"COD_FORNECEDOR='" + fornecedor  + "'," +
				"DAT_ORCAMENTO='" + data.ToString("M/d/yyyy") + "'," +
				"COD_ORCAMENTO=" + orcamento + "," +
				"COD_PEDIDO=" + pedido + " " +
				"where NRO_NF='" + NRO_NF + "' and " +
				"      SEQ_TITULO=" + SEQ_TITULO;
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
/*			
			sql = 
				"select DAT_EMISSAO from TITULOS_RECEBER " +
				"where NRO_NF=" + NRO_NF + " and " +
				"      SEQ_TITULO=" + SEQ_TITULO;
			cmd = new FbCommand(sql, Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			if (reader.Read())
			{
				DateTime DAT_EMISSAO = !reader.IsDBNull(1) ? reader.GetDateTime(1) : DateTime.Now;
				cPedidos.SetaDatas(fornecedor, data, short.Parse(orcamento), short.Parse(pedido), DAT_EMISSAO);
			}
			reader.Close();
*/			
			msg = "OK";
			return true;
		}
		
		public void AgrupaPorVencimento(DateTime dtini, DateTime dtfim, ref ArrayList valores, ref ArrayList descricoes, int N)
		{
			string datai = dtini.ToString("M/d/yyyy");
			string dataf = dtfim.ToString("M/d/yyyy");
			string sql = 
				"select b.DES_NATUREZA,sum(a.VLR_PREVISTO) " +
				"from TITULOS_RECEBER a, NATUREZAS_RECEBIMENTO b " +
				"where a.COD_NATUREZA = b.COD_NATUREZA and " +
				"      a.DAT_VENCIMENTO between '" + datai + "' and '" + dataf + "' and " +
				"      a.IDT_CANCELADO <> 'S' " +
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
				"from TITULOS_RECEBER " +
				"where DAT_VENCIMENTO between '" + datai + "' and '" + dataf + "' and " +
				"      IDT_CANCELADO <> 'S' and " +
				"      IDT_TIPO='F'";
			cmd = new FbCommand(sql, Globais.bd);
			reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			descricoes.Add("Fixo");
			if (reader.Read())
				valores.Add(!reader.IsDBNull(0) ? reader.GetFloat(0) : 0f);
			else
				valores.Add(0f);
			reader.Close();
			
			sql = 
				"select sum(VLR_PREVISTO) " +
				"from TITULOS_RECEBER " +
				"where DAT_VENCIMENTO between '" + datai + "' and '" + dataf + "' and " +
				"      IDT_CANCELADO <> 'S' and " +
				"      IDT_TIPO='V'";
			cmd = new FbCommand(sql, Globais.bd);
			reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			descricoes.Add("Variável");
			if (reader.Read())
				valores.Add(!reader.IsDBNull(0) ? reader.GetFloat(0) : 0f);
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
				if (++n > 13) break;
				data = meses[mes-1];
				datai = mes.ToString() + "/1/" + ano.ToString();
				dataf = mes.ToString() + "/" + DateTime.DaysInMonth(ano, mes).ToString() + "/" + ano.ToString();
				sql = 
					"select sum(VLR_PREVISTO) " +
					"from TITULOS_RECEBER " +
					"where COD_NATUREZA = '" + natureza + "' and " +
					"      IDT_CANCELADO <> 'S' and " +
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
		
		public bool Recebe(
			DateTime DAT_RECEBIMENTO,
			string COD_FORMA,
			string where,
			ref string msg)
		{
			string data = DAT_RECEBIMENTO.ToString("M/d/yyyy");
			string forma = COD_FORMA.Length > 0 ? "'" + COD_FORMA + "'": "null";
			string sql = 
				"update TITULOS_RECEBER a set " +
				"a.DAT_RECEBIMENTO='"  + data + "'," +
				"a.VLR_RECEBIDO=VLR_PREVISTO," +
				"a.COD_FORMA="  + forma + " " +
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

		public bool Gera(string where, string arquivo, string _titulo, short quartil1, short quartil2, short quartil3, string order)
		{
			FbCommand cmd;
			FbDataReader reader;
						
			PDF pdf = new PDF(arquivo);
			pdf.Abre();
			Parte1(pdf, _titulo);
			
			/*
			pdf.CriaTabela(2, 0);
			pdf.AdicionaCelula("imagens\\logo_rel.jpg", 1000, 1000);
			pdf.AdicionaCelula(_titulo, BaseFont.HELVETICA_BOLD, 16);
			pdf.AdicionaTabela();
			*/
			
			float totalG1=0;
			float totalG2=0;	
			int N1=0;
			int N2=0;
			float[] totais;
			int[] titulos;
			
			totais = new float[10];
			titulos = new int[10];
			for (int i=0; i<5; i++) {
				totais[i] = 0;
				titulos[i] = 0;
			}

			/*
			int n=0;			
			for (int i=0; i<5; i++)
			{
				n = 0;
				string whereI="";
				TimeSpan tI, tF;
				DateTime dataI, dataF;				
				switch (i)
				{
					case 3:
						tI = new TimeSpan(quartil1, 0, 0, 0);
						dataI = DateTime.Now.Subtract(tI);
						dataF = DateTime.Now;
						whereI = where + " and (DAT_RECEBIMENTO is null) and (DAT_VENCIMENTO >= '" + dataI.ToString("MM/dd/yyyy") + "')" + 
							" and (DAT_VENCIMENTO < '" + dataF.ToString("MM/dd/yyyy") + "') ";						
						break;						
					case 2:
						tI = new TimeSpan(quartil2, 0, 0, 0);
						dataI = DateTime.Now.Subtract(tI);						
						tF = new TimeSpan(quartil1, 0, 0, 0);
						dataF = DateTime.Now.Subtract(tF);
						whereI = where + " and (DAT_RECEBIMENTO is null) and (DAT_VENCIMENTO >= '" + dataI.ToString("MM/dd/yyyy") + "')" + 
							" and (DAT_VENCIMENTO < '" + dataF.ToString("MM/dd/yyyy") + "') ";
						break;						
					case 1:
						tI = new TimeSpan(quartil3, 0, 0, 0);
						dataI = DateTime.Now.Subtract(tI);						
						tF = new TimeSpan(quartil2, 0, 0, 0);
						dataF = DateTime.Now.Subtract(tF);
						whereI = where + " and (DAT_RECEBIMENTO is null) and (DAT_VENCIMENTO >= '" + dataI.ToString("MM/dd/yyyy") + "')" + 
							" and (DAT_VENCIMENTO < '" + dataF.ToString("MM/dd/yyyy") + "') ";
						break;						
					case 0:
						tF = new TimeSpan(quartil3, 0, 0, 0);
						dataF = DateTime.Now.Subtract(tF);
						whereI = where + " and (DAT_RECEBIMENTO is null) and (DAT_VENCIMENTO < '" + dataF.ToString("MM/dd/yyyy") + "') ";
						break;												
					case 4:
						dataI = DateTime.Now;
						whereI = where + " and (DAT_RECEBIMENTO is null) and (DAT_VENCIMENTO >= '" + dataI.ToString("MM/dd/yyyy") + "') ";
						break;																		
				}
				*/
				string sql = 		"select " +
			                     	"a.NRO_NF," +
			                     	"a.SEQ_TITULO," +
			                     	"a.COD_CLIENTE," +
			                     	"b.DES_NATUREZA," +
			                     	"a.DAT_EMISSAO," +
			                     	"a.DAT_VENCIMENTO," +
			                     	"a.VLR_PREVISTO," +
			                     	"a.VLR_RECEBIDO," +
			                     	"a.DAT_RECEBIMENTO," +
			                     	"c.DES_FORMA," +
			                     	"a.TXT_OBSERVACAO " +
								 	"from TITULOS_RECEBER a " +
								 	"left outer join NATUREZAS_RECEBIMENTO b " +
								 	"on b.COD_NATUREZA = a.COD_NATUREZA " +
								 	"left outer join FORMAS_RECEBIMENTO c " +
								 	"on c.COD_FORMA = a.COD_FORMA " +	
			                     	//whereI + " " +
									where + " " +
									order;
			                     	//"order by a.DAT_VENCIMENTO";
				cmd =  new FbCommand(sql, Globais.bd);	

				TimeSpan t = new TimeSpan(quartil1, 0, 0, 0);
				DateTime t1 = DateTime.Now.Subtract(t);
				t = new TimeSpan(quartil2, 0, 0, 0);
				DateTime t2 = DateTime.Now.Subtract(t);
				t = new TimeSpan(quartil3, 0, 0, 0);
				DateTime t3 = DateTime.Now.Subtract(t);				
				
				/*
				FileStream fs = new FileStream("c:\\softplace\\faturamento.txt", FileMode.Append);
				StreamWriter sw = new StreamWriter(fs);
				sw.WriteLine("quartil: " + i+1);				
				sw.WriteLine(sql);
				*/

				reader = cmd.ExecuteReader(CommandBehavior.Default);		
				string DES_NATUREZA;
				string DES_FORMA;
				//float total1=0;
				//float total2=0;
								
				pdf.CriaTabela(23, 0);
				pdf.AdicionaCelula("NF", BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, 2);
				pdf.AdicionaCelula("Seq", BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, 1);
				pdf.AdicionaCelula("Cliente", BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, 3);
				pdf.AdicionaCelula("Natureza", BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, 3);
				pdf.AdicionaCelula("Emissão", BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, 2);
				pdf.AdicionaCelula("Vencimento", BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, 2);
				pdf.AdicionaCelula("Previsto", BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 2);
				pdf.AdicionaCelula("Recebido", BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 2);
				pdf.AdicionaCelula("Recebimento", BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, 2);
				pdf.AdicionaCelula("Atraso", BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 1);
				pdf.AdicionaCelula("Forma", BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, 3);
				pdf.AdicionaCelula("", BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, 3);
				pdf.AdicionaCelula("Observação", BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, 20);
				
				while (reader.Read())					
				{
					float valor = !reader.IsDBNull(6) ? reader.GetFloat(6) : 0;
					int atraso = 0;
					int ind = 0;
					if (reader.IsDBNull(8)) { // não recebido
						DateTime DAT_VENCIMENTO = reader.GetDateTime(5);
						atraso = DateTime.Now.Subtract(DAT_VENCIMENTO).Days;
						if (atraso <= 0) atraso = 0;
						if (atraso == 0)  ind = 1;
						else {
							if (atraso < quartil1) ind = 3;
							else {
								if (atraso < quartil2) ind = 5;
								else {
									if (atraso < quartil3) ind = 7;
									else ind = 9;
								}
							}
						}
						totalG2 += valor;						
						N2++;						
					}
					else {
						DateTime DAT_VENCIMENTO = reader.GetDateTime(5);
						DateTime DAT_RECEBIMENTO = reader.GetDateTime(8);
						atraso = DAT_RECEBIMENTO.Subtract(DAT_VENCIMENTO).Days;
						if (atraso <= 0) atraso = 0;
						if (atraso == 0)  ind = 0;
						else {
							if (atraso < quartil1) ind = 2;
							else {
								if (atraso < quartil2) ind = 4;
								else {
									if (atraso < quartil3) ind = 6;
									else ind = 8;
								}
							}
						}
						totalG1 += valor;						
						N1++;
					}
					totais[ind] += valor;
					titulos[ind]++;
					
					/*
					if (n == 0) {
						pdf.CriaTabela(1, 0);
						switch (i)
						{					
							case 3: pdf.AdicionaCelula("Títulos atrasados a menos de " + quartil1.ToString() + " dias", BaseFont.HELVETICA_BOLD, 8, Color.GRAY, 1); break;
							case 2: pdf.AdicionaCelula("Títulos com atraso entre " + quartil1.ToString() + " e " + quartil2.ToString() + " dias", BaseFont.HELVETICA_BOLD, 8, Color.GRAY, 1); break;
							case 1: pdf.AdicionaCelula("Títulos com atraso entre " + quartil2.ToString() + " e " + quartil3.ToString() + " dias", BaseFont.HELVETICA_BOLD, 8, Color.GRAY, 1); break;
							case 0: pdf.AdicionaCelula("Títulos atrasados a mais de " + quartil3.ToString() + " dias", BaseFont.HELVETICA_BOLD, 8, Color.GRAY, 1); break;
							case 4: pdf.AdicionaCelula("Títulos a vencer", BaseFont.HELVETICA_BOLD, 8, Color.GRAY, 1); break;					
						}
						pdf.AdicionaTabela();
			
						pdf.CriaTabela(23, 0);			
						pdf.AdicionaCelula("NF", BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, 2);
						pdf.AdicionaCelula("Seq", BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, 1);
						pdf.AdicionaCelula("Cliente", BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, 3);
						pdf.AdicionaCelula("Natureza", BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, 3);
						pdf.AdicionaCelula("Emissão", BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, 2);
						pdf.AdicionaCelula("Vencimento", BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, 2);
						pdf.AdicionaCelula("Previsto", BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 2);
						pdf.AdicionaCelula("Recebido", BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 2);
						pdf.AdicionaCelula("Recebimento", BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, 2);
						pdf.AdicionaCelula("Atraso", BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 1);
						pdf.AdicionaCelula("Forma", BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, 3);
						pdf.AdicionaCelula("", BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, 3);
						pdf.AdicionaCelula("Observação", BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, 20);
					}
					n++;
					N++;
					*/					
					cTituloXeceber titulo = new cTituloXeceber();
					titulo.NRO_NF = !reader.IsDBNull(0) ? reader.GetString(0).Trim() : "";
					titulo.SEQ_TITULO = (short)(!reader.IsDBNull(1) ? reader.GetInt32(1) : 0);
					titulo.COD_CLIENTE = !reader.IsDBNull(2) ? reader.GetString(2).Trim() : "";
					DES_NATUREZA = !reader.IsDBNull(3) ? reader.GetString(3).Trim() : "";
					titulo.DAT_EMISSAO = !reader.IsDBNull(4) ? reader.GetDateTime(4) : DateTime.Now;
					titulo.DAT_VENCIMENTO = !reader.IsDBNull(5) ? reader.GetDateTime(5) : DateTime.Now;
					titulo.VLR_PREVISTO = !reader.IsDBNull(6) ? reader.GetFloat(6) : 0;
					titulo.VLR_RECEBIDO = !reader.IsDBNull(7) ? reader.GetFloat(7) : 0;
					titulo.DAT_RECEBIMENTO = !reader.IsDBNull(8) ? reader.GetDateTime(8) : DateTime.MinValue;
					DES_FORMA = !reader.IsDBNull(9) ? reader.GetString(9).Trim() : "";
					titulo.TXT_OBSERVACAO = !reader.IsDBNull(10) ? reader.GetString(10).Trim() : "";
														
					pdf.AdicionaCelula(titulo.NRO_NF, BaseFont.HELVETICA, 8, Element.ALIGN_LEFT, 2);
					pdf.AdicionaCelula(titulo.SEQ_TITULO.ToString(), BaseFont.HELVETICA, 8, Element.ALIGN_LEFT, 1);
					pdf.AdicionaCelula(titulo.COD_CLIENTE, BaseFont.HELVETICA, 8, Element.ALIGN_LEFT, 3);
					pdf.AdicionaCelula(DES_NATUREZA, BaseFont.HELVETICA, 8, Element.ALIGN_LEFT, 3);
					pdf.AdicionaCelula(titulo.DAT_EMISSAO.ToString("d/M/yyyy"), BaseFont.HELVETICA, 8, Element.ALIGN_LEFT, 2);
					pdf.AdicionaCelula(titulo.DAT_VENCIMENTO.ToString("d/M/yyyy"), BaseFont.HELVETICA, 8, Element.ALIGN_LEFT, 2);
					pdf.AdicionaCelula(titulo.VLR_PREVISTO.ToString("#,###,##0.00"), BaseFont.HELVETICA, 8, Element.ALIGN_RIGHT, 2);
					pdf.AdicionaCelula(titulo.VLR_RECEBIDO.ToString("#,###,##0.00"), BaseFont.HELVETICA, 8, Element.ALIGN_RIGHT, 2);
					if (titulo.DAT_RECEBIMENTO != DateTime.MinValue)
						pdf.AdicionaCelula(titulo.DAT_RECEBIMENTO.ToString("d/M/yyyy"), BaseFont.HELVETICA, 8, Element.ALIGN_LEFT, 2);
					else
						pdf.AdicionaCelula("-", BaseFont.HELVETICA, 8, Element.ALIGN_LEFT, 2);
					pdf.AdicionaCelula(atraso.ToString(), BaseFont.HELVETICA, 8, Element.ALIGN_RIGHT, 1);
					pdf.AdicionaCelula(DES_FORMA, BaseFont.HELVETICA, 8, Element.ALIGN_LEFT, 3);
					pdf.AdicionaCelula("", BaseFont.HELVETICA, 8, Color.WHITE, 3);
					pdf.AdicionaCelula(titulo.TXT_OBSERVACAO, BaseFont.HELVETICA, 8, Color.WHITE, 20);
				
					//total1 += titulo.VLR_PREVISTO;
					//total2 += titulo.VLR_RECEBIDO;
				}
				/*
				if (n > 0) {
					pdf.AdicionaCelula("Total", BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, 2);						
					pdf.AdicionaCelula("", BaseFont.HELVETICA_BOLD, 8, Color.WHITE, 4);	
					pdf.AdicionaCelula(n.ToString() , BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 2);	
					pdf.AdicionaCelula(total1.ToString("#,###,##0.00"), BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 1);	
					pdf.AdicionaCelula(total2.ToString("#,###,##0.00"), BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 1);	
					pdf.AdicionaCelula("", BaseFont.HELVETICA_BOLD, 8, Color.WHITE, 4);	
					pdf.AdicionaTabela();										
					pdf.CriaTabela(1, 0);
					pdf.AdicionaCelulaSemBorda("", 1);
					pdf.AdicionaCelulaSemBorda("", 1);
					pdf.AdicionaTabela();					
				}
				sw.WriteLine("linhas: " + n.ToString());
				sw.WriteLine("==========================");
				sw.Close();								
				*/
				//totalG1 += total1;
				//totalG2 += total2;
				//totais[i] = total1;
				//titulos[i] = n;				
				reader.Close();
			//}
			pdf.AdicionaTabela();
			
			pdf.CriaTabela(1, 0);
			pdf.AdicionaCelulaSemBorda("", 1);
			pdf.AdicionaCelulaSemBorda("", 1);
			pdf.AdicionaCelulaSemBorda("", 1);			
			pdf.AdicionaCelulaSemBorda("", 1);
			pdf.AdicionaTabela();
			
			/*
			pdf.CriaTabela(11, 0);						
			for (int i=0; i<5; i++)
			{
				switch (i)
				{					
					case 3: pdf.AdicionaCelula("Títulos atrasados a menos de " + quartil1.ToString() + " dias", BaseFont.HELVETICA_BOLD, 8, Color.GRAY, 3); break;
					case 2: pdf.AdicionaCelula("Títulos com atraso entre " + quartil1.ToString() + " e " + quartil2.ToString() + " dias", BaseFont.HELVETICA_BOLD, 8, Color.GRAY, 3); break;
					case 1: pdf.AdicionaCelula("Títulos com atraso entre " + quartil2.ToString() + " e " + quartil3.ToString() + " dias", BaseFont.HELVETICA_BOLD, 8, Color.GRAY, 3); break;
					case 0: pdf.AdicionaCelula("Títulos atrasados a mais de " + quartil3.ToString() + " dias", BaseFont.HELVETICA_BOLD, 8, Color.GRAY, 3); break;
					case 4: pdf.AdicionaCelula("Títulos a vencer", BaseFont.HELVETICA_BOLD, 8, Color.GRAY, 3); break;					
				}
				
				pdf.AdicionaCelula(titulos[i].ToString(), BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 1);
				pdf.AdicionaCelula(totais[i].ToString("#,###,##0.00"), BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 1);
				pdf.AdicionaCelula("", BaseFont.HELVETICA_BOLD, 8, Color.WHITE, 6);					
			}
			
			pdf.AdicionaCelula("Total Geral", BaseFont.HELVETICA_BOLD, 8, Color.GRAY, 3);
			pdf.AdicionaCelula(N.ToString(), BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 1);
			pdf.AdicionaCelula(totalG1.ToString("#,###,##0.00"), BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 1);
			pdf.AdicionaCelula("", BaseFont.HELVETICA_BOLD, 8, Color.WHITE, 6);					
			pdf.AdicionaTabela();												
			*/
			
			pdf.CriaTabela(11, 0);
			pdf.AdicionaCelula("Liquidados", BaseFont.HELVETICA_BOLD, 8, Color.GRAY, Element.ALIGN_LEFT, 5);
			pdf.AdicionaCelula("", BaseFont.HELVETICA_BOLD, 8, Color.WHITE, 1);					
			pdf.AdicionaCelula("Em Aberto", BaseFont.HELVETICA_BOLD, 8, Color.GRAY, Element.ALIGN_LEFT, 5);
			
			pdf.AdicionaCelula("Em dia", BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, 3);
			pdf.AdicionaCelula(titulos[0].ToString(), BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 1);
			pdf.AdicionaCelula(totais[0].ToString("#,###,##0.00"), BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 1);
			pdf.AdicionaCelula("", BaseFont.HELVETICA_BOLD, 8, Color.WHITE, 1);					
			
			pdf.AdicionaCelula("A vencer", BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, 3);
			pdf.AdicionaCelula(titulos[1].ToString(), BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 1);
			pdf.AdicionaCelula(totais[1].ToString("#,###,##0.00"), BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 1);
			
			pdf.AdicionaCelula("Atrasados a menos de " + quartil1.ToString() + " dias", BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, 3);
			pdf.AdicionaCelula(titulos[2].ToString(), BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 1);
			pdf.AdicionaCelula(totais[2].ToString("#,###,##0.00"), BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 1);
			pdf.AdicionaCelula("", BaseFont.HELVETICA_BOLD, 8, Color.WHITE, 1);					
			
			pdf.AdicionaCelula("Atrasados a menos de " + quartil1.ToString() + " dias", BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, 3);
			pdf.AdicionaCelula(titulos[3].ToString(), BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 1);
			pdf.AdicionaCelula(totais[3].ToString("#,###,##0.00"), BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 1);
			
			pdf.AdicionaCelula("Atrasados entre " + quartil1.ToString() + " e " + quartil2.ToString() + " dias", BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, 3);
			pdf.AdicionaCelula(titulos[4].ToString(), BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 1);
			pdf.AdicionaCelula(totais[4].ToString("#,###,##0.00"), BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 1);
			pdf.AdicionaCelula("", BaseFont.HELVETICA_BOLD, 8, Color.WHITE, 1);					
			
			pdf.AdicionaCelula("Atrasados entre " + quartil1.ToString() + " e " + quartil2.ToString() + " dias", BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, 3);
			pdf.AdicionaCelula(titulos[5].ToString(), BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 1);
			pdf.AdicionaCelula(totais[5].ToString("#,###,##0.00"), BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 1);		
			
			pdf.AdicionaCelula("Atrasados entre " + quartil2.ToString() + " e " + quartil3.ToString() + " dias", BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, 3);
			pdf.AdicionaCelula(titulos[6].ToString(), BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 1);
			pdf.AdicionaCelula(totais[6].ToString("#,###,##0.00"), BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 1);		
			pdf.AdicionaCelula("", BaseFont.HELVETICA_BOLD, 8, Color.WHITE, 1);					
			
			pdf.AdicionaCelula("Atrasados entre " + quartil2.ToString() + " e " + quartil3.ToString() + " dias", BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, 3);
			pdf.AdicionaCelula(titulos[7].ToString(), BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 1);
			pdf.AdicionaCelula(totais[7].ToString("#,###,##0.00"), BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 1);		
			
			pdf.AdicionaCelula("Atrasados a mais de " + quartil3.ToString() + " dias", BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, 3);
			pdf.AdicionaCelula(titulos[8].ToString(), BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 1);
			pdf.AdicionaCelula(totais[8].ToString("#,###,##0.00"), BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 1);		
			pdf.AdicionaCelula("", BaseFont.HELVETICA_BOLD, 8, Color.WHITE, 1);					
			
			pdf.AdicionaCelula("Atrasados a mais de " + quartil3.ToString() + " dias", BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, 3);
			pdf.AdicionaCelula(titulos[9].ToString(), BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 1);
			pdf.AdicionaCelula(totais[9].ToString("#,###,##0.00"), BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 1);		
						
			pdf.AdicionaTabela();
						
			pdf.CriaTabela(11, 0);									
			pdf.AdicionaCelula("Total", BaseFont.HELVETICA_BOLD, 8, Color.GRAY, 3);
			pdf.AdicionaCelula(N1.ToString(), BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 1);
			pdf.AdicionaCelula(totalG1.ToString("#,###,##0.00"), BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 1);
			pdf.AdicionaCelula("", BaseFont.HELVETICA_BOLD, 8, Color.WHITE, 1);								
			pdf.AdicionaCelula("Total", BaseFont.HELVETICA_BOLD, 8, Color.GRAY, 3);
			pdf.AdicionaCelula(N2.ToString(), BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 1);
			pdf.AdicionaCelula(totalG2.ToString("#,###,##0.00"), BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 1);			
			pdf.AdicionaTabela();												
						
			pdf.Fecha();
			return true;
		}
		
		public void CarregaPedidos(
			string NRO_NF,
			short SEQ_TITULO,			
			ComboBox cbx)
		{
			FbCommand cmd =  new FbCommand("select " +
					"cod_fornecedor," +
					"dat_orcamento," +
					"cod_orcamento," +
					"cod_pedido " +
					"from pedidos_recebidos " +
					"where NRO_NF='" + NRO_NF + "' and " +
					"      SEQ_TITULO=" + SEQ_TITULO,
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

		public static void GeraDespesasNatureza(Document doc, DateTime inicio, DateTime fim)
		{
			Tabela table = new Tabela(5);			
			cTitulosPagar.AdicionaCelula(table, "Natureza", BaseFont.HELVETICA_BOLD, 8, iTextSharp.text.Color.LIGHT_GRAY, 1);
			cTitulosPagar.AdicionaCelula(table, "Descrição", BaseFont.HELVETICA_BOLD, 8, iTextSharp.text.Color.LIGHT_GRAY, 3);			
			cTitulosPagar.AdicionaCelula(table, "Valor", BaseFont.HELVETICA_BOLD, 8, iTextSharp.text.Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 1);			
			
			string datai = inicio.ToString("M/d/yyyy");
			string dataf = fim.ToString("M/d/yyyy");
			string sql = 
				"select b.COD_NATUREZA,b.DES_NATUREZA,sum(a.VLR_PREVISTO) " +
				"from TITULOS_RECEBER a, NATUREZAS_RECEBIMENTO b " +
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
				cTitulosPagar.AdicionaCelula(table, codigo, BaseFont.HELVETICA, 8, Element.ALIGN_LEFT, 1);				
				cTitulosPagar.AdicionaCelula(table, descricao, BaseFont.HELVETICA, 8, Element.ALIGN_LEFT, 3);
				cTitulosPagar.AdicionaCelula(table, valor.ToString("#,###,##0.00"), BaseFont.HELVETICA, 8, Element.ALIGN_RIGHT, 1);
			}
			reader.Close();
			
			cTitulosPagar.AdicionaCelula(table, "Total", BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, 4);						
			cTitulosPagar.AdicionaCelula(table, total.ToString("#,###,##0.00"), BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 1);							
			doc.Add(table);
		}		
		
	}
}
