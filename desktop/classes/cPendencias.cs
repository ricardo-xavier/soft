/*
 * Projeto  : SoftPlace
 * Programa : cPendencias - Pendencias de Pagamento
 * Autor    : Ricardo Costa Xavier
 * Data     : 31/07/08
 */
using System;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;

namespace classes
{
	public class cPendencias
	{
		public cPendencias()
		{
		}
		
		public void Carrega(DataGridView grid)
		{
			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			adapter.SelectCommand = new FbCommand("select COD_PENDENCIA, " +
			                                      "       DES_PENDENCIA," +
			                                      "       IDT_ATIVO " +
			                                      "from PENDENCIAS " +
			                                      "order by COD_PENDENCIA", 
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
			FbCommand cmd =  new FbCommand("select DES_PENDENCIA,COD_PENDENCIA " +
			                               "from PENDENCIAS " +
			                               "where IDT_ATIVO='S' " +
			                               "order by DES_PENDENCIA", 
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
			string sql = "insert into PENDENCIAS values(" +
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
			string sql = "update PENDENCIAS set " +
						 "DES_PENDENCIA='" + descricao + "'," + 
						 "IDT_ATIVO='" + ativo + "' " + 				
				    	 "where COD_PENDENCIA='" + codigo + "'";
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
			string sql = "delete from PENDENCIAS " + 
						 "where COD_PENDENCIA='" + codigo + "'";
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
