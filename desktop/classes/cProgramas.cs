/*
 * Projeto  : SoftPlace
 * Programa : cProgramas - Classe de Programas
 * Autor    : Ricardo Costa Xavier
 * Data     : 25/03/2008
 */
using System;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;

namespace classes
{
	public class cProgramas
	{
		public cProgramas()
		{
		}
		
		public void Carrega(DataGridView grid, int sistema)
		{
			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			adapter.SelectCommand = new FbCommand("select COD_PROGRAMA," +
			                                      "       DES_PROGRAMA " +
			                                      "from PROGRAMAS " +
			                                      "where COD_SISTEMA=" + sistema + " " +
			                                      "order by COD_PROGRAMA", 
			                                      Globais.bd);
			adapter.Fill(table);
			table.Columns[0].ColumnName = "Código";
			table.Columns[1].ColumnName = "Descrição";
			grid.DataSource = table;
		}
		
		public bool Inclui(int sistema, string codigo, string descricao, ref string msg)
		{
			string sql = "insert into PROGRAMAS values(" +
						 sistema + "," +
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
		
		public bool Altera(int sistema, string codigo, string descricao, ref string msg)
		{
			string sql = "update PROGRAMAS set " +
						 "DES_PROGRAMA='" + descricao + "' " + 
				    	 "where COD_SISTEMA=" + sistema + " " +
				    	 "and COD_PROGRAMA='" + codigo + "'";
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
		
		public bool Exclui(int sistema, string codigo, ref string msg)
		{
			string sql = "delete from PROGRAMAS " +
						 "where COD_SISTEMA=" + sistema + " and " +
						 "      COD_PROGRAMA='" + codigo + "'";
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
