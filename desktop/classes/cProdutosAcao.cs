/*
 * Projeto  : SoftPlace
 * Programa : cProdutosAcao - Classe de Produtos - Ação Comercial
 * Autor    : Ricardo Costa Xavier
 * Data     : 07/12/14
 * 
create table produtos_acao(
cod_produto char(10) not null,
des_produto char(50),
constraint pk_produtos_acao primary key(cod_produto));

 */
using System;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;

namespace classes
{
	public class cProdutosAcao
	{
		public cProdutosAcao()
		{
		}
		
		public void Carrega(DataGridView grid)
		{
			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			adapter.SelectCommand = new FbCommand("select COD_PRODUTO, " +
			                                      "       DES_PRODUTO, " +
			                                      "       IDT_ATIVO " +
			                                      "from PRODUTOS_ACAO " +
			                                      "order by COD_PRODUTO", 
			                                      Globais.bd);
			adapter.Fill(table);
			table.Columns[0].ColumnName = "Código";
			table.Columns[1].ColumnName = "Descrição";
			table.Columns[2].ColumnName = "Ativo";
			grid.DataSource = table;
			grid.Columns["Ativo"].Width = 40;
		}
		
		public void Carrega(DataGridView grid, int acao)
		{
			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			adapter.SelectCommand = new FbCommand("select a.COD_PRODUTO, " +
			                                      "       a.DES_PRODUTO, " +
			                                      "       b.SEQ_ACAO " +
			                                      "from PRODUTOS_ACAO a " +
												  "left join PRODUTOS_POR_ACAO b "  +
												  "on b.COD_PRODUTO = a.COD_PRODUTO " +
												  "and b.SEQ_ACAO = " + acao.ToString(),
			                                      Globais.bd);
			adapter.Fill(table);
			table.Columns[0].ColumnName = "Código";
			table.Columns[1].ColumnName = "Descrição";
			table.Columns[2].ColumnName = "Ação";
			grid.DataSource = table;
			grid.Columns["Ação"].Visible = false;			
			bool b=true;
			DataColumn check = new DataColumn("Seleciona", b.GetType());
			table.Columns.Add(check);			
			foreach (DataGridViewRow row in grid.Rows)
			{
				row.Cells["Seleciona"].Value = (row.Cells["Ação"].Value != null)
					&& !row.Cells["Ação"].Value.ToString().Trim().Equals("");
			}
		}

		public bool Atualiza(DataGridView grid, int acao, ref string msg)
		{
			string sql = "delete from PRODUTOS_POR_ACAO " + 
				"where SEQ_ACAO=" + acao.ToString();
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
			foreach (DataGridViewRow row in grid.Rows)
			{
				if (!(bool) row.Cells["Seleciona"].Value)
				{
					continue;
				}
				sql = "insert into PRODUTOS_POR_ACAO values(" + 
					acao.ToString() + ", '" + row.Cells["Código"].Value + "')";
				cmd = new FbCommand(sql, Globais.bd);
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
			}
			return true;
		}
		
		public void Carrega(ComboBox cbx)
		{
			string codigo;
			FbCommand cmd =  new FbCommand("select COD_PRODUTO " +
			                               "from PRODUTOS_ACAO " +
			                               "where IDT_ATIVO='S' " +
			                               "order by COD_PRODUTO", 
			                               Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			while (reader.Read())
			{
				codigo = reader.GetString(0).Trim();
				cbx.Items.Add(codigo);
			}
			reader.Close();
		}
		
		public bool Inclui(string codigo, string descricao, bool ativo, ref string msg)
		{
			string sativo = ativo ? "S" : "N";
			string sql = "insert into PRODUTOS_ACAO values(" +
						 "'"  + codigo + "'," +
						 "'"  + descricao + "'," +
						 "'"  + sativo + "')";
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
		
		public bool Altera(string codigo, string descricao, bool ativo, ref string msg)
		{
			string sativo = ativo ? "S" : "N";
			string sql = "update PRODUTOS_ACAO set " +
						 "DES_PRODUTO='" + descricao + "', " +
						 "IDT_ATIVO='" + sativo + "' " +				
				    	 "where COD_PRODUTO='" + codigo + "'";
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
			string sql = "delete from PRODUTOS_ACAO " + 
						 "where COD_PRODUTO='" + codigo + "'";
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
