using System;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using classes;

namespace cpd
{
	public class cParametros
	{
		public cParametros()
		{
		}
		
		public string GetIp() {
			string sql = "select IP from PARAMETROS";
			string ip = "192.168.56.1";
			FbCommand cmd =  new FbCommand(sql, Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			if (reader.Read())
			{
				ip = reader.GetString(0).Trim();
			}
			reader.Close();			
			return ip;
		}
		
		public bool Altera(string IP, ref string msg)
		{
			string sql = "update PARAMETROS set " +
						 "IP='" + IP + "'";
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
