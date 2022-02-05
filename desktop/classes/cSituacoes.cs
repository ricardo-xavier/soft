/*
 * Projeto  : SoftPlace
 * Programa : cSituacaoes - Classe de Situações
 * Autor    : Ricardo Costa Xavier
 * Data     : 11/04/09
 */
using System;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;

namespace classes
{
	public class cSituacoes
	{
		public cSituacoes()
		{
		}
		
		public void Carrega(DataGridView grid)
		{
			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			adapter.SelectCommand = new FbCommand("select COD_SITUACAO, " +
			                                      "       DES_SITUACAO, " +
			                                      "       IDT_DEFAULT, " +
			                                      "       IDT_AVISO, " +
			                                      "       IDT_CONCRETIZADO, " +
			                                      "       IDT_ATIVA " +
			                                      "from SITUACOES " +
			                                      "order by COD_SITUACAO", 
			                                      Globais.bd);
			adapter.Fill(table);
			table.Columns[0].ColumnName = "Código";
			table.Columns[1].ColumnName = "Descrição";
			table.Columns[2].ColumnName = "Aut";
			table.Columns[3].ColumnName = "Aviso";
			table.Columns[4].ColumnName = "Concretizado";
			table.Columns[5].ColumnName = "Ativa";
			grid.DataSource = table;
			grid.Columns[3].Visible = false;
			grid.Columns["Ativa"].Width = 40;
		}
		
		public void CarregaFiltro(DataGridView grid)
		{
			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			adapter.SelectCommand = new FbCommand("select COD_SITUACAO, " +
			                                      "       DES_SITUACAO, " +
			                                      "       IDT_DEFAULT, " +
			                                      "       IDT_AVISO, " +
			                                      "       IDT_CONCRETIZADO " +
			                                      "from SITUACOES " +
			                                      "where IDT_ATIVA='S' " +
			                                      "order by COD_SITUACAO", 
			                                      Globais.bd);
			adapter.Fill(table);
			table.Columns[0].ColumnName = "Código";
			table.Columns[1].ColumnName = "Descrição";
			table.Columns[2].ColumnName = "Aut";
			table.Columns[3].ColumnName = "Aviso";
			table.Columns[4].ColumnName = "Concretizado";
			grid.DataSource = table;
			grid.Columns["Código"].Visible = false;
			grid.Columns["Aut"].Visible = false;
			grid.Columns["Aviso"].Visible = false;
			grid.Columns["Concretizado"].Visible = false;
			
			bool b=true;
			DataColumn check = new DataColumn("Seleciona", b.GetType());
			table.Columns.Add(check);			
			foreach (DataGridViewRow row in grid.Rows)
			{
				row.Cells["Seleciona"].Value = false;
			}			
		}
		
		
		public void Carrega(ComboBox cbx)
		{
			string codigo, descricao;
			FbCommand cmd =  new FbCommand("select COD_SITUACAO,DES_SITUACAO " +
			                               "from SITUACOES " +
			                               "where IDT_ATIVA='S' " +
			                               "order by COD_SITUACAO", 
			                               Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			while (reader.Read())
			{
				codigo = reader.GetString(0).Trim();
				descricao = reader.GetString(1).Trim();
				cbx.Items.Add(codigo + " " + descricao);
			}
			reader.Close();
		}
		
		public bool Inclui(string codigo, string descricao, string idt_default, 
		                   string idt_aviso, string idt_concretizado, bool ativa, ref string msg)
		{
			string sativa = ativa ? "S" : "N";
			string sql = "insert into SITUACOES values(" +
						 "'"  + codigo + "'," +
						 "'"  + descricao + "'," +
						 "'"  + idt_default + "'," +
						 "'"  + idt_aviso + "'," +
				         "'"  + idt_concretizado + "'," +
						 "'"  + sativa + "')";
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
		
		public bool Altera(string codigo, string descricao, string idt_default, 
		                   string idt_aviso, string idt_concretizado, bool ativa, ref string msg)
		{
			string sativa = ativa ? "S" : "N";
			string sql = "update SITUACOES set " +
						 "DES_SITUACAO='" + descricao + "'," + 
						 "IDT_DEFAULT='" + idt_default + "', " + 
						 "IDT_AVISO='" + idt_aviso + "', " + 
						 "IDT_CONCRETIZADO='" + idt_concretizado + "', " + 
						 "IDT_ATIVA='" + sativa + "' " + 
				    	 "where COD_SITUACAO='" + codigo + "'";
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
		
		public bool Exclui(string codigo, ref string msg)
		{
			string sql = "delete from SITUACOES " + 
						 "where COD_SITUACAO='" + codigo + "'";
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
	}
}
