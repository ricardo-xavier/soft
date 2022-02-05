/*
 * Projeto  : SoftPlace
 * Programa : cNaturezasPagamento - Classe de Naturezas de Pagamento
 * Autor    : Ricardo Costa Xavier
 * Data     : 20/07/08
 * 
 * Alteração: 10/02/11 - idt_ativo
 * 
 */
using System;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;

namespace classes
{
	public class cNaturezasPagamento
	{
		public cNaturezasPagamento()
		{
		}
		
		public void Carrega(DataGridView grid)
		{
			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			adapter.SelectCommand = new FbCommand("select COD_NATUREZA, " +
			                                      "       DES_NATUREZA," +
			                                      "       IDT_ATIVO " +
			                                      "from NATUREZAS_PAGAMENTO " +
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
			                               "from NATUREZAS_PAGAMENTO " +
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
			string sql = "insert into NATUREZAS_PAGAMENTO values(" +
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
			string sql = "update NATUREZAS_PAGAMENTO set " +
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
			string sql = "delete from NATUREZAS_PAGAMENTO " + 
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
