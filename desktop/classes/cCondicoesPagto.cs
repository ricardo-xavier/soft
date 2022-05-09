/*
 * Projeto  : SoftPlace
 * Programa : cCondicoesPagto - Classe de Condições de Pagamento
 * Autor    : Ricardo Costa Xavier
 * Data     : 14/02/09
 */
using System;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;

namespace classes
{
	public class cCondicoesPagto
	{
		public cCondicoesPagto()
		{
		}
		
		public void Carrega(DataGridView grid)
		{
			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			adapter.SelectCommand = new FbCommand("select COD_CONDICAO,DES_CONDICAO,IDT_ATIVA " +
			                                      "from CONDICOES_PAGTO " +
			                                      "order by COD_CONDICAO", 
			                                      Globais.bd);
			adapter.Fill(table);
			table.Columns[0].ColumnName = "Código";
			table.Columns[1].ColumnName = "Descrição";
			table.Columns[2].ColumnName = "Ativa";
			grid.DataSource = table;
			grid.Columns["Ativa"].Width = 40;
		}
		
		public void Carrega(ComboBox cbx)
		{
			string codigo;
			FbCommand cmd =  new FbCommand("select COD_CONDICAO " +
			                               "from CONDICOES_PAGTO " + 
			                               "where IDT_ATIVA='S' " +
			                               "order by COD_CONDICAO", 
			                               Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			while (reader.Read())
			{
				codigo = reader.GetString(0).Trim();
				cbx.Items.Add(codigo);
			}
			reader.Close();
		}
		
		public void CarregaComDescricao(ComboBox cbx)
		{
			string codigo, descricao;
			FbCommand cmd =  new FbCommand("select COD_CONDICAO,DES_CONDICAO " +
			                               "from CONDICOES_PAGTO " + 
			                               "where IDT_ATIVA='S' " +
			                               "order by COD_CONDICAO", 
			                               Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			while (reader.Read())
			{
				codigo = reader.GetString(0);
				descricao = reader.GetString(1).Trim();
				cbx.Items.Add(codigo + "|" + descricao);
			}
			reader.Close();
		}
		
		
		public bool Inclui(string codigo, string descricao, bool ativa, ref string msg)
		{
			string sativa = ativa ? "S" : "N";
			string sql = "insert into CONDICOES_PAGTO values(" +
						"'"  + codigo + "'," +
						"'"  + descricao + "'," + 
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
		
		public bool Altera(string codigo, string descricao, bool ativa, ref string msg)
		{
			string sativa = ativa ? "S" : "N";
			string sql = "update CONDICOES_PAGTO set " +
						 "DES_CONDICAO='" + descricao + "', " + 
				 		 "IDT_ATIVA='" + sativa + "' " + 
				    	 "where COD_CONDICAO='" + codigo + "'";
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
			string sql = "delete from CONDICOES_PAGTO " +
						 "where COD_CONDICAO='" + codigo + "'";
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
