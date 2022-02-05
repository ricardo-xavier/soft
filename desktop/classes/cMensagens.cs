using System;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;

namespace classes
{
	public class cMensagens
	{
		public cMensagens()
		{
		}
		
		public void Carrega(DataGridView grid)
		{
			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			adapter.SelectCommand = new FbCommand("select DATA, " +
			                                      "       USUARIO, " +
			                                      "       MENSAGEM " +
			                                      "from MENSAGENS " +
			                                      "order by DATA desc", 
			                                      Globais.bd);
			adapter.Fill(table);
			table.Columns[0].ColumnName = "Data";
			table.Columns[1].ColumnName = "Usuário";
			table.Columns[2].ColumnName = "Mensagem";
			grid.DataSource = table;
			grid.Columns["Mensagem"].Visible = false;
		}		
		
		public static string UltimaMensagem() {
			string texto = "";
			string sql = "select first 1 DATA, MENSAGEM from mensagens order by DATA desc";
			FbCommand cmd =  new FbCommand(sql, Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			if (reader.Read())
			{
				texto += reader.GetString(1).Trim();
			}
			reader.Close();			
			return texto;
		}
		
		public static void Insere(string texto) {
			string sql = "insert into MENSAGENS values(" +
				"'"  + DateTime.Now.ToString("M/d/yyyy HH:mm:ss") + "', " +
				"'"  + Globais.sUsuario + "', " +
				"'"  + texto + "')";
			FbCommand cmd = new FbCommand(sql, Globais.bd);
			Log.Grava(Globais.sUsuario, cmd.CommandText);
			cmd.ExecuteNonQuery();
		}
		
		public bool Inclui(string texto, ref string msg)
		{
			string sql = "insert into MENSAGENS values(" +
				"'"  + DateTime.Now.ToString("M/d/yyyy HH:mm:ss") + "', " +
				"'"  + Globais.sUsuario + "', " +
				"'"  + texto + "')";
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
		
		public bool Altera(string data, string usuario, string texto, ref string msg)
		{
			DateTime dt = DateTime.Parse(data);
			string sql = "update MENSAGENS set " +
						 "MENSAGEM='" + texto + "' " + 
				    	 "where DATA='" +  dt.ToString("M/d/yyyy HH:mm:ss") + "' and USUARIO = '" + usuario + "'";
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
		
		public bool Exclui(string data, string usuario, ref string msg)
		{
			DateTime dt = DateTime.Parse(data);
			string sql = "delete from MENSAGENS " +
				    	 "where DATA='" +  dt.ToString("M/d/yyyy HH:mm:ss") + "' and USUARIO = '" + usuario + "'";
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
