/*
 * Sistema Soft - trace
 * Autor : Ricardo Costa Xavier
 * Data  : 09/10/2011
 */
using System;
using FirebirdSql.Data.FirebirdClient;

namespace classes
{
	public static class trace
	{
		public static void grava(string msg) {
			string sql = "insert into TRACE values(gen_id(gen_trace, 1)," + 
				"'" + DateTime.Now.ToString("M/d/yyyy HH:mm:ss") + "'," +
				"'" + Globais.sUsuario + "'," +
				"'" + msg + "')";
			FbCommand cmd = new FbCommand(sql, Globais.bd);
			try
			{
				Log.Grava(Globais.sUsuario, cmd.CommandText);
				cmd.ExecuteNonQuery();
			}
			catch {}
		}
	}
}
