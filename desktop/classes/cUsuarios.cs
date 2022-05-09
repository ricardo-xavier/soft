/*
 * Projeto  : SoftPlace
 * Programa : cUsuarios - Classe de Usuarios
 * Autor    : Ricardo Costa Xavier
 * Data     : 25/03/2008
 */
using System;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;

namespace classes
{
	public class cUsuarios
	{
		public cUsuarios()
		{
		}
		
		public void Carrega(DataGridView grid, string where)
		{
			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			adapter.SelectCommand = new FbCommand("select COD_USUARIO," +
			                                      "       NOM_USUARIO," +
			                                      "       DES_SENHA," +
			                                      "       IDT_ADMINISTRADOR," +
			                                      "       IDT_ATIVO " +
			                                      "from USUARIOS " + 
			                                      where + " " +
			                                      "order by COD_USUARIO", 
			                                      Globais.bd);
			adapter.Fill(table);
			table.Columns[0].ColumnName = "Código";
			table.Columns[1].ColumnName = "Nome";
			grid.DataSource = table;
			grid.Columns[2].Visible = false;
			grid.Columns[3].Visible = false;			
			grid.Columns[4].Visible = false;			
		}
		
		public void Carrega(ComboBox cbx)
		{
			string codigo;
			FbCommand cmd =  new FbCommand("select COD_USUARIO " +
			                               "from USUARIOS where IDT_ATIVO='S' " +
			                               "order by COD_USUARIO", 
			                               Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			while (reader.Read())
			{
				codigo = reader.GetString(0).Trim();
				cbx.Items.Add(codigo);
			}
			reader.Close();
		}		
		
		public bool Inclui(string codigo, string nome, string senha, string administrador, string ativo, ref string msg)
		{
			string sql = "insert into USUARIOS values(" +
						 "'"  + codigo + "'," +
						 "'"  + nome + "'," +
						 "'"  + senha + "'," +
						 "'"  + administrador + "'," +
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
		
		public bool Altera(string codigo, string nome, string administrador, string ativo, ref string msg)
		{
			string sql = "update USUARIOS set " +
						 "NOM_USUARIO='" + nome + "', " + 
				    	 "IDT_ADMINISTRADOR='" + administrador  + "', " +
				    	 "IDT_ATIVO='" + ativo  + "' " +				
				    	 "where COD_USUARIO='" + codigo + "'";
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
		
		public bool AlteraSenha(string codigo, string senha, ref string msg)
		{
			string sql = "update USUARIOS set " +
				  		 "DES_SENHA='" + senha  + "' " + 
				    	 "where COD_USUARIO='" + codigo + "'";
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
			string sql = "delete from USUARIOS " +
						 "where COD_USUARIO='" + codigo + "'";
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
