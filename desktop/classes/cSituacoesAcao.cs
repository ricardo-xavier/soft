/*
 * Projeto  : SoftPlace
 * Programa : cSituacaoesAcao - Classe de Situações das Ações Comerciais
 * Autor    : Ricardo Costa Xavier
 * Data     : 25/01/2015
 */
using System;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;

namespace classes
{
	public class cSituacoesAcao
	{
		public cSituacoesAcao()
		{
		}
		
		public void Carrega(DataGridView grid)
		{
			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			adapter.SelectCommand = new FbCommand("select COD_SITUACAO, " +
			                                      "       DES_SITUACAO,  " +
			                                      "       IDT_APRESENTA_AUTOM, " +
			                                      "       IDT_CONCRETIZADA, " +
			                                      "       IDT_ATIVA " +
			                                      "from SITUACOES_ACAO " +
			                                      "order by COD_SITUACAO",
			                                      Globais.bd);
			adapter.Fill(table);
			table.Columns[0].ColumnName = "Código";
			table.Columns[1].ColumnName = "Descrição";
			table.Columns[2].ColumnName = "ApresentaAutom";
			table.Columns[3].ColumnName = "Concretizada";
			table.Columns[4].ColumnName = "Ativa";
			grid.DataSource = table;
			grid.Columns["ApresentaAutom"].Visible = false;
			grid.Columns["Concretizada"].Visible = false;
			grid.Columns["Ativa"].Width = 40;
		}
		
		public void CarregaFiltro(DataGridView grid, bool codigo)
		{
			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			adapter.SelectCommand = new FbCommand("select COD_SITUACAO, " +
			                                      "       DES_SITUACAO,  " +
			                                      "       IDT_APRESENTA_AUTOM, " +
			                                      "       IDT_CONCRETIZADA, " +
			                                      "       IDT_ATIVA " +
			                                      "from SITUACOES_ACAO " +
			                                      "order by COD_SITUACAO",
			                                      Globais.bd);
			adapter.Fill(table);
			table.Columns[0].ColumnName = "Código";
			table.Columns[1].ColumnName = "Descrição";
			table.Columns[2].ColumnName = "ApresentaAutom";
			table.Columns[3].ColumnName = "Concretizada";
			table.Columns[4].ColumnName = "Ativa";
			grid.DataSource = table;
			if (!codigo) {
				grid.Columns["Código"].Visible = codigo;
			}
 			grid.Columns["ApresentaAutom"].Visible = false;
			grid.Columns["Concretizada"].Visible = false;
			grid.Columns["Ativa"].Width = 40;
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
			                               "from SITUACOES_ACAO " +
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
		
		public bool Inclui(string codigo, string descricao, 
		                   bool apresenta_autom,
		                   bool concretizada,
		                   bool ativa,
		                   ref string msg)
		{
			string sativa = ativa ? "S" : "N";
			string sql = "insert into SITUACOES_ACAO values(" +
						 "'"  + codigo + "'," +
						 "'"  + descricao + "'," +
						 "'"  + (apresenta_autom ? "S" : "N") + "'," +
						 "'"  + (concretizada ? "S" : "N") + "', " +
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
		
		public bool Altera(string codigo, string descricao, 
		                   bool apresenta_autom, 
		                   bool concretizada,
		                   bool ativa,
		                   ref string msg)
		{
			string sativa = ativa ? "S" : "N";
			string sql = "update SITUACOES_ACAO set " +
						 "DES_SITUACAO='" + descricao + "', " + 
						 "IDT_APRESENTA_AUTOM='" + (apresenta_autom ? "S" : "N") + "'," + 
						 "IDT_CONCRETIZADA='" + (concretizada ? "S" : "N") + "', " +
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
			string sql = "delete from SITUACOES_ACAO " + 
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
