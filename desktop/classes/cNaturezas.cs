/*
 * Projeto  : SoftPlace
 * Programa : cNaturezas - Classe de Naturezas
 * Autor    : Ricardo Costa Xavier
 * Data     : 25/04/08
 */
using System;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;

namespace classes
{
	public class cNaturezas
	{
		public cNaturezas()
		{
		}
		
		public void Carrega(DataGridView grid)
		{
			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			adapter.SelectCommand = new FbCommand("select COD_NATUREZA, " +
			                                      "       DES_NATUREZA, " +
			                                      "       IDT_ATIVA " +
			                                      "from NATUREZAS " +
			                                      "order by COD_NATUREZA", 
			                                      Globais.bd);
			adapter.Fill(table);
			table.Columns[0].ColumnName = "Código";
			table.Columns[1].ColumnName = "Descrição";
			table.Columns[2].ColumnName = "Ativa";
			grid.DataSource = table;
			grid.Columns["Ativa"].Width = 40;
		}
		
		public void Carrega(ComboBox cbx)
		{
			string codigo;			
			FbCommand cmd =  new FbCommand("select COD_NATUREZA " +
			                               "from NATUREZAS " +
			                               "where IDT_ATIVA='S' " +
			                               "order by COD_NATUREZA", 
			                               Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			while (reader.Read())
			{
				codigo = reader.GetString(0).Trim();
				cbx.Items.Add(codigo);
			}
			reader.Close();
		}
		
		public bool Inclui(string codigo, string descricao, bool ativa, ref string msg)
		{
			string sativa = ativa ? "S" : "N";
			string sql = "insert into NATUREZAS values(" +
						 "'"  + codigo + "'," +
				         "'"  + descricao + "'," +
						 "'"  + sativa + "')";
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
		
		public bool Altera(string codigo, string descricao, bool ativa, ref string msg)
		{
			string sativa = ativa ? "S" : "N";
			string sql = "update NATUREZAS set " +
						 "DES_NATUREZA='" + descricao + "', " + 
				         "IDT_ATIVA='" + sativa + "' " + 
				    	 "where COD_NATUREZA='" + codigo + "'";
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
			string sql = "delete from NATUREZAS " + 
						 "where COD_NATUREZA='" + codigo + "'";
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
