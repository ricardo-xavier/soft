/*
 * Projeto  : SoftPlace
 * Programa : cNaturezasRecebimento - Classe de Naturezas de Recebimento
 * Autor    : Ricardo Costa Xavier
 * Data     : 19/08/08
 */
using System;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;

namespace classes
{
	public class cNaturezasRecebimento
	{
		public cNaturezasRecebimento()
		{
		}
		
		public void Carrega(DataGridView grid)
		{
			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			adapter.SelectCommand = new FbCommand("select COD_NATUREZA, " +
			                                      "       DES_NATUREZA," +
			                                      "       IDT_ATIVO " +
			                                      "from NATUREZAS_RECEBIMENTO " +
			                                      "order by COD_NATUREZA", 
			                                      Globais.bd);
			adapter.Fill(table);
			table.Columns[0].ColumnName = "Código";
			table.Columns[1].ColumnName = "Descrição";
			table.Columns[2].ColumnName = "Ativo";
			grid.DataSource = table;
			grid.Columns["Código"].Width = 60;
			grid.Columns["Descrição"].Width = 150;
			grid.Columns["Ativo"].Width = 50;			
			//grid.Columns["Ativo"].Visible = false;
		}
		
		public void Carrega(ComboBox cbxDes, ComboBox cbxCod)
		{
			FbCommand cmd =  new FbCommand("select DES_NATUREZA,COD_NATUREZA " +
			                               "from NATUREZAS_RECEBIMENTO " +
			                               "where IDT_ATIVO='S' " +
			                               "order by DES_NATUREZA", 
			                               Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			while (reader.Read())
			{
				cbxDes.Items.Add(reader.GetString(0).Trim());
				cbxCod.Items.Add(reader.GetString(1).Trim());
			}
			reader.Close();
		}
		
		public bool Inclui(string codigo, string descricao, string ativo, ref string msg)
		{
			string sql = "insert into NATUREZAS_RECEBIMENTO values(" +
						 "'"  + codigo + "'," +
						 "'"  + descricao + "'," +
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
		
		public bool Altera(string codigo, string descricao, string ativo, ref string msg)
		{
			string sql = "update NATUREZAS_RECEBIMENTO set " +
						 "DES_NATUREZA='" + descricao + "'," + 
						 "IDT_ATIVO='" + ativo + "' " + 
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
			string sql = "delete from NATUREZAS_RECEBIMENTO " + 
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
