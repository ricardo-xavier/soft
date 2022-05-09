/*
 * Projeto  : SoftPlace
 * Programa : cControleAcesso - Classe para Controle de Acesso
 * Autor    : Ricardo Costa Xavier
 * Data     : 03/04/08
 */
using System;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;

namespace classes
{
	public class cControleAcesso
	{
		public cControleAcesso()
		{
		}
		
		public bool IncluiFilial(string usuario, string filial, ref string msg)
		{
			string sql = "insert into USUARIOS_FILIAIS values(" +
						 "'"  + usuario + "'," +
						 "'"  + filial + "')";
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
		
		public bool ExcluiFilial(string usuario, string filial, ref string msg)
		{
			string sql = "delete from USUARIOS_FILIAIS " +
						 "where COD_USUARIO='"  + usuario + "' and " +
						 "COD_FILIAL='"  + filial + "'";
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
		
		public bool IncluiSistema(string usuario, string filial, int sistema, ref string msg)
		{
			string sql = "insert into USUARIOS_SISTEMAS values(" +
						 "'"  + usuario + "'," +
						 "'"  + filial + "'," +				
						 sistema + ")";
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
		
		public bool ExcluiSistema(string usuario, string filial, int sistema, ref string msg)
		{
			string sql = "delete from USUARIOS_SISTEMAS " +
						 "where COD_USUARIO='"  + usuario + "' and " +
						 "      COD_FILIAL='"  + filial + "' and " +
						 "      COD_SISTEMA="  + sistema;
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
		
		public bool IncluiPrograma(string usuario, string filial, int sistema, string programa, ref string msg)
		{
			string sql = "insert into USUARIOS_PROGRAMAS values(" +
						 "'"  + usuario + "'," +
						 "'"  + filial + "'," +				
						 sistema + "," +
						 "'"  + programa + "')";
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
		
		public bool ExcluiPrograma(string usuario, string filial, int sistema, string programa, ref string msg)
		{
			string sql = "delete from USUARIOS_PROGRAMAS " +
						 "where COD_USUARIO='"  + usuario + "' and " +
						 "      COD_FILIAL='"  + filial + "' and " +
						 "      COD_SISTEMA="  + sistema + " and " +
						 "      COD_PROGRAMA='"  + programa + "'";
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
		
		public bool PermissaoFilial(string usuario, string filial)
		{
			if (Globais.bAdministrador) return true;
			FbCommand cmd =  new FbCommand("select 1 " + 
			                               "from USUARIOS_FILIAIS " +
			                               "where COD_USUARIO='" + usuario + "' and " +
			                               "      COD_FILIAL='" + filial + "'",
			                               Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			if (!reader.Read())
			{
				reader.Close();
				return false;
			}
			reader.Close();			
			return true;
		}
		
		public bool PermissaoSistema(string usuario, string filial, int sistema)
		{
			if (Globais.bAdministrador) return true;
			FbCommand cmd =  new FbCommand("select 1 " +
			                               "from USUARIOS_SISTEMAS " +
			                               "where COD_USUARIO='" + usuario + "' and " +
			                               "      COD_FILIAL='" + filial + "' and " +
			                               "      COD_SISTEMA=" + sistema.ToString(),
			                               Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			if (!reader.Read())
			{
				reader.Close();
				return false;
			}
			reader.Close();			
			return true;
		}
		
		public bool PermissaoPrograma(string usuario, string filial, int sistema, string programa)
		{
			if (Globais.bAdministrador) return true;
			FbCommand cmd =  new FbCommand("select 1 " +
			                               "from USUARIOS_PROGRAMAS " +
			                               "where COD_USUARIO='" + usuario + "' and " +
			                               "      COD_FILIAL='" + filial + "' and " +   
			                               "      COD_SISTEMA=" + sistema.ToString() + " and " +
			                               "      COD_PROGRAMA='" + programa + "'",
			                               Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			if (!reader.Read())
			{
				reader.Close();
				return false;
			}
			reader.Close();			
			return true;
		}		
	}
}
