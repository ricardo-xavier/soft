/*
 * Projeto  : SoftPlace
 * Programa : cTermosAprovacao - Termos de Aprovação e Aceite
 * Autor    : Ricardo Costa Xavier
 * Data     : 05/03/11
 */
using System;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;

namespace classes
{
	public class cTermosAprovacao
	{
		public cTermosAprovacao()
		{
		}
		
		public void Carrega(DataGridView grid)
		{
			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			adapter.SelectCommand = new FbCommand("select COD_TERMO, " +
			                                      "       DES_TERMO " +
			                                      "from TERMOS_APROVACAO " +
			                                      "order by COD_TERMO", 
			                                      Globais.bd);
			adapter.Fill(table);
			table.Columns[0].ColumnName = "Código";
			table.Columns[1].ColumnName = "Descrição";
			grid.DataSource = table;
			grid.Columns["Descrição"].Visible = false;
		}
		
		public void Carrega(ComboBox cbx)
		{
			string codigo;
			FbCommand cmd =  new FbCommand("select COD_TERMO " +
			                               "from TERMOS_APROVACAO " +
			                               "order by COD_TERMO", 
			                               Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			while (reader.Read())
			{
				codigo = reader.GetString(0).Trim();
				cbx.Items.Add(codigo);
			}
			reader.Close();
		}	
		
		
		public bool Inclui(string codigo, string descricao, ref string msg)
		{
			string sql = "insert into TERMOS_APROVACAO values(" +
						 "'"  + codigo + "'," +
						 "'"  + descricao + "')";
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
		
		public bool Altera(string codigo, string descricao, ref string msg)
		{
			string sql = "update TERMOS_APROVACAO set " +
						 "DES_TERMO='" + descricao + "' " + 
				    	 "where COD_TERMO='" + codigo + "'";
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
			string sql = "delete from TERMOS_APROVACAO " + 
						 "where COD_TERMO='" + codigo + "'";
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
