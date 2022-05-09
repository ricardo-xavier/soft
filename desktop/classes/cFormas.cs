/*
 * Projeto  : SoftPlace
 * Programa : cFormas - Classe de Formas de Pagamento
 * Autor    : Ricardo Costa Xavier
 * Data     : 20/07/08
 */
using System;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;

namespace classes
{
	public class cFormas
	{
		public cFormas()
		{
		}
		
		public void Carrega(DataGridView grid)
		{
			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			adapter.SelectCommand = new FbCommand("select COD_FORMA, " +
			                                      "       DES_FORMA," +
			                                      "       IDT_ATIVO " +
			                                      "from FORMAS_PAGAMENTO " +
			                                      "order by COD_FORMA", 
			                                      Globais.bd);
			adapter.Fill(table);
			table.Columns[0].ColumnName = "Código";
			table.Columns[1].ColumnName = "Descrição";
			table.Columns[2].ColumnName = "Ativo";
			grid.DataSource = table;
			grid.Columns["Código"].Width = 60;
			grid.Columns["Descrição"].Width = 150;
			grid.Columns["Ativo"].Width = 50;			
			//grid.Columns["Ativo"].Visible = false;
		}
		
		public void Carrega(ComboBox cbxDes, ComboBox cbxCod)
		{
			FbCommand cmd =  new FbCommand("select DES_FORMA,COD_FORMA " +
			                               "from FORMAS_PAGAMENTO " +
			                               "where IDT_ATIVO='S' " +
			                               "order by DES_FORMA", 
			                               Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			while (reader.Read())
			{
				cbxDes.Items.Add(reader.GetString(0).Trim());
				cbxCod.Items.Add(reader.GetString(1).Trim());
			}
			reader.Close();
		}
		
		public bool Inclui(string codigo, string descricao, string ativo, ref string msg)
		{
			string sql = "insert into FORMAS_PAGAMENTO values(" +
						 "'"  + codigo + "'," +
						 "'"  + descricao + "'," +
						 "'"  + ativo + "')";			
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
		
		public bool Altera(string codigo, string descricao, string ativo, ref string msg)
		{
			string sql = "update FORMAS_PAGAMENTO set " +
						 "DES_FORMA='" + descricao + "'," + 
						 "IDT_ATIVO='" + ativo + "' " + 
				    	 "where COD_FORMA='" + codigo + "'";
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
			string sql = "delete from FORMAS_PAGAMENTO " + 
						 "where COD_FORMA='" + codigo + "'";
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
