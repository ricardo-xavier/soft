/*
 * Projeto  : SoftPlace
 * Programa : cOrigens - Classe de Origens - Ação Comercial
 * Autor    : Ricardo Costa Xavier
 * Data     : 07/12/14
 * 
create table origens(
cod_origem char(10) not null,
des_origem char(50),
constraint pk_origens primary key(cod_origem));

 */
using System;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;

namespace classes
{
	public class cOrigens
	{
		public cOrigens()
		{
		}
		
		public void Carrega(DataGridView grid, bool ativas)
		{
			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			string where = "where IDT_ATIVA='S' ";
			adapter.SelectCommand = new FbCommand("select COD_ORIGEM, " +
			                                      "       DES_ORIGEM, " +
			                                      "       IDT_ATIVA " +
			                                      "from ORIGENS " +
			                                      where +
			                                      "order by COD_ORIGEM", 
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
			FbCommand cmd =  new FbCommand("select COD_ORIGEM " +
			                               "from ORIGENS " +
			                               "where IDT_ATIVA='S' " +
			                               "order by COD_ORIGEM", 
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
			string sql = "insert into ORIGENS values(" +
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
			string sql = "update ORIGENS set " +
						 "DES_ORIGEM='" + descricao + "', " +
						 "IDT_ATIVA='" + sativa + "' " + 				
				    	 "where COD_ORIGEM='" + codigo + "'";
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
			string sql = "delete from ORIGENS " + 
						 "where COD_ORIGEM='" + codigo + "'";
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
