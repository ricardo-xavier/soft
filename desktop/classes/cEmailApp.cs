using System;
using System.Data;
using FirebirdSql.Data.FirebirdClient;

namespace classes
{

	/*
	create table EMAIL_APP(
	remetente varchar(100),
	usuario varchar(100),
	senha char(32),
	destinatarios varchar(500),
	assunto varchar(100),
	texto varchar(500));
	 */
	public class cEmailApp
	{

		public string remetente;
		public string usuario;
		public string senha;
		public string destinatarios;
		public string assunto;
		public string texto;
						
		/// <summary>
		/// Recupera a configuração de email, se não encontrar inicializa e inclui
		/// </summary>
		public void Recupera()
		{
			FbCommand cmd =  new FbCommand("select " +
			                         "  REMETENTE," + //0
			                         "  USUARIO," + //1
			                         "  SENHA," + //2
			                         "  DESTINATARIOS," + //3
			                         "  ASSUNTO," + //4
			                         "  TEXTO " + //5
			                         "from EMAIL_APP ",
			                         Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			if (reader.Read())
			{
				remetente = reader.GetString(0).Trim();
				usuario = reader.GetString(1).Trim();
				senha= reader.GetString(2).Trim();
				destinatarios = reader.GetString(3).Trim();
				assunto = reader.GetString(4).Trim();
				texto = reader.GetString(5).Trim();
			}
			else 
			{
				remetente = "softplacemoveisbh@gmail.com";
				usuario = "softplacemoveisbh";
				senha = "soft101010";
				destinatarios = "fabiana.ferrari@softplacemoveis.com.br";
				assunto = "[SOFTPLACE] Encerramento Agendamento $DATA$ $CLIENTE$";
				texto = "Esse email foi enviado automaticamente pelo SoftApp da SOFTPLACE.\r\n"
					+ "Em anexo, relatório de encerramento do agendamento $DATA$ $CLIENTE$";
				Inclui();
			}
			reader.Close();			
		}
		
		/// <summary>
		/// Inclui uma configuração
		/// </summary>
		private void Inclui()
		{
			string sql = "insert into EMAIL_APP values(" +
				"'" + remetente + "'," +
				"'" + usuario + "'," +
				"'" + senha + "'," +
				"'" + destinatarios + "'," +
				"'" + assunto + "'," +
				"'" + texto + "')";
			FbCommand cmd = new FbCommand(sql, Globais.bd);
			try
			{
				Log.Grava(Globais.sUsuario, cmd.CommandText);
				cmd.ExecuteNonQuery();
			}
			catch (Exception e)
			{
				Log.Grava(Globais.sUsuario, "erro:" + e.Message);
			}
		}		
		
		/// <summary>
		/// Atualiza uma configuração
		/// </summary>
		public void Atualiza()
		{
			Exclui();
			Inclui();
		}
		
		/// <summary>
		/// Exclui uma configuração
		/// </summary>		
		private void Exclui()
		{
			const string sql = "delete from EMAIL_APP";
			FbCommand cmd = new FbCommand(sql, Globais.bd);
			try
			{
				Log.Grava(Globais.sUsuario, cmd.CommandText);
				cmd.ExecuteNonQuery();
			}
			catch (Exception e)
			{
				Log.Grava(Globais.sUsuario, "erro:" + e.Message);
			}
		}				
		
	}
}
