/*
 * Projeto  : SoftPlace
 * Programa : cInformacoesFornecimento - Informações de Fornecimento
 * Autor    : Ricardo Costa Xavier
 * Data     : 05/03/11
 */
using System;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;

namespace classes
{
	public class cInformacoesFornecimento
	{
		public cInformacoesFornecimento()
		{
		}
		
		public void Carrega(DataGridView grid)
		{
			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			adapter.SelectCommand = new FbCommand("select COD_INFORMACAO," +
			                                      "       DES_INFORMACAO " +
			                                      "from INFORMACOES_FORNECIMENTO " +
			                                      "order by COD_INFORMACAO", 
			                                      Globais.bd);
			adapter.Fill(table);
			table.Columns[0].ColumnName = "Código";
			table.Columns[1].ColumnName = "Descrição";
			grid.DataSource = table;
			grid.Columns["Descrição"].Visible = false;
		}
		
		public void Carrega(ComboBox cbx)
		{
			string codigo;
			FbCommand cmd =  new FbCommand("select COD_INFORMACAO " +
			                               "from INFORMACOES_FORNECIMENTO " +
			                               "order by COD_INFORMACAO", 
			                               Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			while (reader.Read())
			{
				codigo = reader.GetString(0).Trim();
				cbx.Items.Add(codigo);
			}
			reader.Close();
		}					
		
		public bool Inclui(string codigo, string descricao, ref string msg)
		{
			string sql = "insert into INFORMACOES_FORNECIMENTO values(" +
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
		
		public bool Altera(string codigo, string descricao, ref string msg)
		{
			string sql = "update INFORMACOES_FORNECIMENTO set " +
						 "DES_INFORMACAO='" + descricao + "' " + 
				    	 "where COD_INFORMACAO='" + codigo + "'";
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
			string sql = "delete from INFORMACOES_FORNECIMENTO " + 
						 "where COD_INFORMACAO='" + codigo + "'";
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
