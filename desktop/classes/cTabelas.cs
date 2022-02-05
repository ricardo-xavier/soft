/*
 * Projeto  : SoftPlace
 * Programa : cTabelas - Classe de Tabelas de Precos
 * Autor    : Ricardo Costa Xavier
 * Data     : 27/04/08
 */
using System;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using System.Drawing;

namespace classes
{
	public class cTabelas
	{
		public cTabelas()
		{
		}
		
		public void Carrega(DataGridView grid, bool somenteAtivas)
		{
			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			string where = somenteAtivas ? "where IDT_ATIVO='S' " : "";
			adapter.SelectCommand = new FbCommand("select COD_PARCEIRO," +
			                                      "       COD_TABELA," +
			                                      "       DES_TABELA, " +
			                                      "       IDT_DEFAULT, " +			                     
			                                      "       IDT_ATIVO " +
			                                      "from TAB_PRECOS " + 
			                                      where +
			                                      "order by COD_PARCEIRO,COD_TABELA", 
			                                      Globais.bd);
			adapter.Fill(table);
			table.Columns[0].ColumnName = "Parceiro";			
			table.Columns[1].ColumnName = "Código";
			table.Columns[2].ColumnName = "Descrição";
			table.Columns[3].ColumnName = "Default";
			table.Columns[4].ColumnName = "Ativa";
			grid.DataSource = table;
			grid.Columns[3].Visible = false;
			grid.Columns[4].Visible = false;
		}
		
		public void Carrega(ComboBox cbx, string fornecedor)
		{
			string codigo;
			FbCommand cmd =  new FbCommand("select COD_TABELA " +
			                               "from TAB_PRECOS " +
				    	 				   "where COD_PARCEIRO='" + fornecedor + "' and IDT_ATIVO='S' " +
			                               "order by IDT_DEFAULT,COD_TABELA", 
			                               Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			while (reader.Read())
			{
				codigo = reader.GetString(0).Trim();
				cbx.Items.Add(codigo);
			}
			reader.Close();
		}		
		
		public float Preco(string fornecedor, string tabela, string produto, string subcod)
		{
			float preco=0;
			FbCommand cmd =  new FbCommand("select VLR_PRECO " +
			                               "from PRECOS " +
						                   "where cod_parceiro='" + fornecedor + "' and " +
                     					   "      cod_tabela='" + tabela + "' and " +				
                     					   "      cod_produto='" + produto + "' and " +				                     					   
                     					   "      sub_codigo='" + subcod + "'",
			                               Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			if (reader.Read())
				preco = reader.GetFloat(0);
			reader.Close();
			return preco;
		}		
		
		public void CarregaPrecos(DataGridView grid, string parceiro, string tabela)
		{
			// insere com 0 os produtos que ainda não estão na tabela
			// delete from precos a where a.cod_tabela='PADRAO2008' and a.vlr_preco=0 and not exists(select 1 from precos b where b.cod_parceiro='TECNOFLEX' and b.cod_tabela='PADRAO' and b.cod_produto=a.cod_produto and b.sub_codigo=a.sub_codigo)
			// update precos a set a.vlr_preco = (select b.vlr_preco from precos b where b.cod_parceiro='TECNOFLEX' and b.cod_tabela='PADRAO' and b.cod_produto=a.cod_produto and b.sub_codigo=a.sub_codigo) where a.cod_parceiro='TECNOFLEX' and a.cod_tabela='PADRAO2008' and a.vlr_preco=0;
			string sql = "insert into precos select cod_parceiro,'" + tabela + "',cod_produto,sub_codigo,0 " +
						 "from produtos a where (a.cod_parceiro='" + parceiro + "' and " +
				         "not exists(select 1 from precos b " +
						 "           where b.cod_parceiro='" + parceiro + "' and " +
						 "                 b.cod_tabela='" + tabela + "' and " +				
						 "                 b.cod_parceiro=a.cod_parceiro and " +
						 "                 b.cod_produto=a.cod_produto and " +
						 "                 b.sub_codigo=a.sub_codigo))";
			FbCommand cmd = new FbCommand(sql, Globais.bd);
			//FileStream fs = new FileStream("softplace.log", FileMode.Create);
			//StreamWriter sw = new StreamWriter(fs);
			//sw.WriteLine(sql);
			//sw.Close();			
			try
			{
				Log.Grava(Globais.sUsuario, cmd.CommandText);
				cmd.ExecuteNonQuery();
			}
			catch (Exception err)
			{
				Log.Grava(Globais.sUsuario, "erro:" + err.Message);
				string msg = err.Message;
			}

			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			adapter.SelectCommand = new FbCommand("select a.COD_PRODUTO," +
			                                      "       a.SUB_CODIGO," +
			                                      "       b.DES_PRODUTO," +			                                      
			                                      "       b.DES_MEDIDA," +			                                      			                                      
			                                      "       a.VLR_PRECO," +			                                      
			                                      "       a.VLR_PRECO " +
			                                      "from PRECOS a, PRODUTOS b " + 
   						 				    	  "where a.COD_PARCEIRO='" + parceiro + "' and " +
				    	 						  "      a.COD_TABELA='" + tabela + "' and " +
												  "      b.cod_produto=a.cod_produto and " +
												  "      b.sub_codigo=a.sub_codigo " +
			                                      "order by a.COD_PRODUTO,a.SUB_CODIGO",
			                                      Globais.bd);
			adapter.Fill(table);
			table.Columns[0].ColumnName = "Código";			
			table.Columns[1].ColumnName = "Sub-Código";
			table.Columns[2].ColumnName = "Descrição";			
			table.Columns[3].ColumnName = "Medidas";						
			table.Columns[4].ColumnName = "Valor";
			table.Columns[5].ColumnName = "Novo Valor";			
			grid.DataSource = table;
			grid.Columns["Código"].ReadOnly = true;
			grid.Columns["Sub-Código"].ReadOnly = true;
			grid.Columns["Descrição"].ReadOnly = true;
			grid.Columns["Medidas"].ReadOnly = true;
			grid.Columns["Valor"].ReadOnly = true;
			grid.Columns["Novo Valor"].ReadOnly = false;			
			grid.Columns["Novo Valor"].DefaultCellStyle.BackColor = Color.FromName("info");
			grid.Columns["Valor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			grid.Columns["Novo Valor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			grid.Columns["Valor"].DefaultCellStyle.Format = "###,###,##0.00";			
			grid.Columns["Novo Valor"].DefaultCellStyle.Format = "###,###,##0.00";			
			grid.Columns["Código"].Width = 115;
			grid.Columns["Sub-Código"].Width = 80;
			grid.Columns["Descrição"].Width = 220;
			grid.Columns["Medidas"].Width = 115;
			grid.Columns["Valor"].Width = 94;
			grid.Columns["Novo Valor"].Width = 94;
		}

		private bool reseta_default(string parceiro)
		{
			string sql = "update TAB_PRECOS set " +
						 "IDT_DEFAULT='N' " + 
				    	 "where COD_PARCEIRO='" + parceiro + "'";
			FbCommand cmd = new FbCommand(sql, Globais.bd);
			try
			{
				Log.Grava(Globais.sUsuario, cmd.CommandText);
				cmd.ExecuteNonQuery();
			}
			catch (Exception err)
			{
				Log.Grava(Globais.sUsuario, "erro:" + err.Message);
				string msg = err.Message;				
				return false;
			}
			return true;
		}		

		public bool Inclui(string parceiro, string codigo, string descricao, string idt_default, string idt_ativo, ref string msg)
		{
			if (idt_default.CompareTo("S") == 0)
				reseta_default(parceiro);
			
			string sql = "insert into TAB_PRECOS values(" +
						 "'"  + parceiro + "'," +				
						 "'"  + codigo + "'," +
						 "'"  + descricao + "'," +
						 "'"  + idt_default + "'," +			
						 "'"  + idt_ativo + "')";	
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
		
		public bool Altera(string parceiro, string codigo, string descricao, string idt_default, string idt_ativo, ref string msg)
		{
			if (idt_default.CompareTo("S") == 0)
				reseta_default(parceiro);
			
			string sql = "update TAB_PRECOS set " +
						 "DES_TABELA='" + descricao + "'," + 
						 "IDT_DEFAULT='" + idt_default + "'," + 
						 "IDT_ATIVO='" + idt_ativo + "' " +
				    	 "where COD_PARCEIRO='" + parceiro + "' and " +
				    	 "      COD_TABELA='" + codigo + "'";
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
				
		public bool AlteraValor(string parceiro, string tabela, string codigo, string sub_codigo, string valor, ref string msg)
		{
			string sql = "update PRECOS set " +
						 "VLR_PRECO=? " +
				    	 "where COD_PARCEIRO='" + parceiro + "' and " +
				    	 "      COD_TABELA='" + tabela+ "' and " +
				    	 "      COD_PRODUTO='" + codigo + "' and " +
				    	 "      SUB_CODIGO='" + sub_codigo + "'";
			float f = Globais.StrToFloat(valor);// / 1.075f;
			FbCommand cmd = new FbCommand(sql, Globais.bd);
			FbParameter prm = cmd.Parameters.Add("VLR_PRECO", FbDbType.Decimal);
			prm.Direction = ParameterDirection.Output;
			prm.Value = f;
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
				
		public bool Exclui(string parceiro, string codigo, ref string msg)
		{
			string sql = "delete from TAB_PRECOS " +
				    	 "where COD_PARCEIRO='" + parceiro + "' and " +
				    	 "      COD_TABELA='" + codigo + "'";
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
