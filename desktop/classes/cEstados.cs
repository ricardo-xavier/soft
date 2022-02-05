/*
 * Projeto  : SoftPlace
 * Programa : cEstados - Classe de Estados
 * Autor    : Ricardo Costa Xavier
 * Data     : 05/04/08
 */
using System;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;

namespace classes
{
	public class cEstados
	{
		public cEstados()
		{
		}
		
		public void Carrega(DataGridView grid)
		{
			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			adapter.SelectCommand = new FbCommand("select COD_ESTADO,NOM_ESTADO " +
			                                      "from ESTADOS " +
			                                      "order by COD_ESTADO", 
			                                      Globais.bd);
			adapter.Fill(table);
			table.Columns[0].ColumnName = "Código";
			table.Columns[1].ColumnName = "Nome";
			grid.DataSource = table;
		}
		
		public void Carrega(ComboBox cbx)
		{
			string codigo;
			FbCommand cmd =  new FbCommand("select COD_ESTADO " +
			                               "from ESTADOS " + 
			                               "order by COD_ESTADO", 
			                               Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			while (reader.Read())
			{
				codigo = reader.GetString(0).Trim();
				cbx.Items.Add(codigo);
			}
			reader.Close();
		}
		
		public bool Inclui(string codigo, string nome, ref string msg)
		{
			string sql = "insert into ESTADOS values(" +
						 "'"  + codigo + "'," +
						 "'"  + nome + "')";
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
		
		public bool Altera(string codigo, string nome, ref string msg)
		{
			string sql = "update ESTADOS set " +
						 "NOM_ESTADO='" + nome + "' " + 
				    	 "where COD_ESTADO='" + codigo + "'";
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
			string sql = "delete from ESTADOS " +
						 "where COD_ESTADO='" + codigo + "'";
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
