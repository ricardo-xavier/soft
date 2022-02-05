/*
 * Projeto  : SoftPlace
 * Programa : cCargos - Classe de Cargos
 * Autor    : Ricardo Costa Xavier
 * Data     : 07/04/08
 */
using System;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;

namespace classes
{
	public class cCargos
	{
		public cCargos()
		{
		}
		
		public void Carrega(DataGridView grid)
		{
			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			adapter.SelectCommand = new FbCommand("select COD_CARGO, " +
			                                      "       DES_CARGO, " +
                                                  "       IDT_ATIVO " +
  			                                      "from CARGOS " +
			                                      "order by COD_CARGO", 
			                                      Globais.bd);
			adapter.Fill(table);
			table.Columns[0].ColumnName = "Código";
			table.Columns[1].ColumnName = "Descrição";
			table.Columns[2].ColumnName = "Ativo";
			grid.DataSource = table;
			grid.Columns["Ativo"].Width = 40;
		}
		
		public void Carrega(ComboBox cbx)
		{
			string codigo;
			FbCommand cmd =  new FbCommand("select COD_CARGO " +
			                               "from CARGOS " +
			                               "where IDT_ATIVO != 'N' " +
			                               "order by COD_CARGO", 
			                               Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			while (reader.Read())
			{
				codigo = reader.GetString(0).Trim();
				cbx.Items.Add(codigo);
			}
			reader.Close();
		}
		
		public bool Inclui(string codigo, string descricao, bool ativo, ref string msg)
		{
			string sativo = ativo ? "S" : "N";
			string sql = "insert into CARGOS values(" +
				"'"  + codigo + "'," +
				"'"  + descricao + "'," +
				"'"  + sativo + "')";
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
		
		public bool Altera(string codigo, string descricao, bool ativo, ref string msg)
		{
			string sativo = ativo ? "S" : "N";
			string sql = "update CARGOS set " +
						 "DES_CARGO='" + descricao + "', " +
                         "IDT_ativo='" + sativo + "' " +				
				    	 "where COD_CARGO='" + codigo + "'";
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
			string sql = "delete from CARGOS " + 
						 "where COD_CARGO='" + codigo + "'";
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
