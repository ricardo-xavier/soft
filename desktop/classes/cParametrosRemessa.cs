/*
 * Projeto  : SoftPlace
 * Programa : cParametrosRemessa - Classe de Parametros de Remessa Bradesco
 * Autor    : Ricardo Costa Xavier
 * Data     : 06/09/08
 */
using System;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;

namespace classes
{
	public class cParametrosRemessa
	{
		public string COD_EMPRESA;
		public string NOM_EMPRESA;
		public int NRO_REMESSA;
		public int NRO_NOSSO;
		public int COD_CARTEIRA;
		public int COD_AGENCIA;
		public short DIG_AGENCIA;
		public int COD_CONTA;
		public short DIG_CONTA;
		public float PER_MULTA;
		public float VLR_BONIFICACAO;
		public float VLR_ATRASO;
		public short QTD_PRAZO_DESCONTO;
		public float VLR_DESCONTO;
		public string DES_MENSAGEM1;
		public string DES_MENSAGEM2;
		public string DES_MENSAGEM3;
		public string DES_MENSAGEM4;
		
		public cParametrosRemessa()
		{
		}
		
		public bool Le()
		{
			string sql = "select " +
				"COD_EMPRESA," +
				"NOM_EMPRESA," +
				"NRO_REMESSA," +
				"NRO_NOSSO," +
				"COD_CARTEIRA," +
				"COD_AGENCIA," +
				"DIG_AGENCIA," +
				"COD_CONTA," +
				"DIG_CONTA," +
				"PER_MULTA," +
				"VLR_BONIFICACAO," +
				"VLR_ATRASO," +
				"QTD_PRAZO_DESCONTO," +
				"VLR_DESCONTO," +
				"DES_MENSAGEM1," +
				"DES_MENSAGEM2," +
				"DES_MENSAGEM3," +
				"DES_MENSAGEM4 " +
				"from parametros_remessa";
			FbCommand cmd = new FbCommand(sql, Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			if (reader.Read())
			{
				COD_EMPRESA = reader.GetString(0).Trim();
				NOM_EMPRESA = reader.GetString(1).Trim();
				NRO_REMESSA = reader.GetInt32(2);
				NRO_NOSSO = reader.GetInt32(3);
				COD_CARTEIRA = reader.GetInt16(4);
				COD_AGENCIA = reader.GetInt32(5);
				DIG_AGENCIA = reader.GetInt16(6);
				COD_CONTA = reader.GetInt32(7);
				DIG_CONTA = reader.GetInt16(8);
				PER_MULTA = reader.GetFloat(9);
				VLR_BONIFICACAO = reader.GetFloat(10);
				VLR_ATRASO = reader.GetFloat(11);
				QTD_PRAZO_DESCONTO = reader.GetInt16(12);
				VLR_DESCONTO = reader.GetFloat(13);
				DES_MENSAGEM1 = reader.GetString(14).Trim();
				DES_MENSAGEM2 = reader.GetString(15).Trim();
				DES_MENSAGEM3 = reader.GetString(16).Trim();
				DES_MENSAGEM4 = reader.GetString(17).Trim();
				reader.Close();
				return true;
			}
			COD_EMPRESA = "";
			NOM_EMPRESA = "";
			NRO_REMESSA = 0;
			NRO_NOSSO = 0;
			COD_CARTEIRA = 0;
			COD_AGENCIA = 0;
			DIG_AGENCIA = 0;
			COD_CONTA = 0;
			DIG_CONTA = 0;
			PER_MULTA = 0;
			VLR_BONIFICACAO = 0;
			VLR_ATRASO = 0;
			QTD_PRAZO_DESCONTO = 0;
			VLR_DESCONTO = 0;
			DES_MENSAGEM1 = "";
			DES_MENSAGEM2 = "";
			DES_MENSAGEM3 = "";
			DES_MENSAGEM4 = "";
			reader.Close();
			sql = "insert into parametros_remessa values('','',0,0,0,0,0,0,0,0,0,0,0,0,'','','','')";
			cmd = new FbCommand(sql, Globais.bd);
			try
			{
				Log.Grava(Globais.sUsuario, cmd.CommandText);
				cmd.ExecuteNonQuery();
				return true;
			}
			catch 
			{
				return false;
			}
		}
		
		public bool Altera(ref string msg)
		{
			string sql = "update parametros_remessa set " +
				"COD_EMPRESA='" + COD_EMPRESA + "'," +
				"NOM_EMPRESA='" + NOM_EMPRESA + "'," +
				"NRO_REMESSA=" + NRO_REMESSA + "," +
				"NRO_NOSSO=" + NRO_NOSSO + "," +
				"COD_CARTEIRA=" + COD_CARTEIRA + "," +
				"COD_AGENCIA=" + COD_AGENCIA + "," +
				"DIG_AGENCIA=" + DIG_AGENCIA + "," +
				"COD_CONTA=" + COD_CONTA + "," +
				"DIG_CONTA=" + DIG_CONTA + "," +
				"PER_MULTA=" + PER_MULTA + "," +
				"VLR_BONIFICACAO=" + VLR_BONIFICACAO + "," +
				"VLR_ATRASO=" + VLR_ATRASO + "," +
				"QTD_PRAZO_DESCONTO=" + QTD_PRAZO_DESCONTO + "," +
				"VLR_DESCONTO=" + VLR_DESCONTO + "," +
				"DES_MENSAGEM1='" + DES_MENSAGEM1 + "'," +
				"DES_MENSAGEM2='" + DES_MENSAGEM2 + "'," +
				"DES_MENSAGEM3='" + DES_MENSAGEM3 + "'," +
				"DES_MENSAGEM4='" + DES_MENSAGEM4 + "'";
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
