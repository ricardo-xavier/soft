/*
 * Projeto  : SoftPlace
 * Programa : cProdutos - Classe de Produtos
 * Autor    : Ricardo Costa Xavier
 * Data     : 22/04/2008
 */
using System;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using System.IO;

namespace classes
{
	public class cProdutos
	{
		public cProdutos()
		{
		}
		
		public void Carrega(DataGridView grid, string where)
		{
			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			adapter.SelectCommand = new FbCommand("select COD_PARCEIRO," +
			                                      "       COD_PRODUTO," +			                                      			                                      			                                      
			                                      "       SUB_CODIGO," +			                                      			                                      
			                                      "       DES_PRODUTO," +			                                      
			                                      "       TXT_PRODUTO," +
			                                      "       DES_MEDIDA, " +			                                      			                                      
			                                      "       PER_IPI, " +
			                                      "       IDT_GENERICO " +
			                                      "from PRODUTOS " + 
			                                      where + " " +			                                      
			                                      //"where cod_parceiro='FLEXFORM' " +
			                                      "order by COD_PRODUTO,SUB_CODIGO", 
			                                      Globais.bd);
			adapter.Fill(table);
			table.Columns[0].ColumnName = "Parceiro";			
			table.Columns[1].ColumnName = "Código";
			table.Columns[2].ColumnName = "Sub-Código";
			table.Columns[3].ColumnName = "Descrição";
			table.Columns[4].ColumnName = "Texto";
			table.Columns[5].ColumnName = "Medidas";
			table.Columns[6].ColumnName = "IPI";
			table.Columns[7].ColumnName = "Genérico";
			grid.DataSource = table;
			grid.Columns[3].Visible = false;			
			grid.Columns[4].Visible = false;
			grid.Columns[5].Visible = false;			
			grid.Columns[6].Visible = false;		
			grid.Columns[7].Visible = false;
		}
		
		public void CarregaAlterados(DataGridView grid)
		{
			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			FbCommand cmd = new FbCommand("select COD_PRODUTO," +			                                      			                                      			                                      
			                              "       SUB_CODIGO," +
			                              "       DES_PRODUTO," +			
			                              "       TXT_PRODUTO," +
			                              "       DES_MEDIDA " +
			                              "from PRODUTOS " + 
			                              "where COD_PARCEIRO='FLEXFORM' " +
			                              "order by COD_PRODUTO,SUB_CODIGO", 
			                              Globais.bd);
			
			string parametros = "User=SYSDBA;" +
								"Password=masterkey;" +
								"Database=c:\\soft\\SISTEMA\\producao\\softplace_bh.fdb";
			FbConnection bd = new FbConnection(parametros);
			try {
				Log.Grava(Globais.sUsuario, parametros);
				bd.Open();
			}
			catch {
				
			}
			
			DataTable tab = new DataTable();
			tab.Columns.Add("Código", typeof(string));
			tab.Columns.Add("Sub-Código", typeof(string));
			tab.Columns.Add("Nome", typeof(string));
			tab.Columns.Add("edt2", typeof(string));
			tab.Columns.Add("edt3", typeof(string));
			tab.Columns.Add("edt4", typeof(string));
			tab.Columns.Add("edt5", typeof(string));
			tab.Columns.Add("edt6", typeof(string));
			int tot=0, alt=0;//inc=0
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			while (reader.Read()) {
				tot++;
				string COD_PRODUTO = reader.GetString(0).Trim();
				string SUB_CODIGO = reader.GetString(1).Trim();
				string DES_PRODUTO = reader.GetString(2).Trim();
				string TXT_PRODUTO = reader.GetString(3).Trim();
				string DES_MEDIDA = reader.GetString(4).Trim();
				string imagem="imagens\\" + COD_PRODUTO + SUB_CODIGO + ".jpg";
				if (!File.Exists(imagem)) {
						tab.Rows.Add(new object[] {COD_PRODUTO, SUB_CODIGO, DES_PRODUTO, DES_PRODUTO, DES_MEDIDA, DES_MEDIDA, TXT_PRODUTO, TXT_PRODUTO });						
						alt++;					
				}
				/*
				FbCommand cmd2=null;
				try {
					cmd2= new FbCommand("select COD_PRODUTO," +			                                      			                                      			                                      
				                              "       SUB_CODIGO," +
				                              "       DES_PRODUTO," +			
				                              "       TXT_PRODUTO," +
			    	                          "       DES_MEDIDA " +
			        	                      "from PRODUTOS " + 
			            	                  "where COD_PARCEIRO='FLEXFORM' " +
			            	                  "and COD_PRODUTO='" + COD_PRODUTO + "' " +
			            	                  "and SUB_CODIGO='" + SUB_CODIGO + "' ",
			                    	          bd);
				}
				catch {
					
				}
				FbDataReader reader2 = cmd2.ExecuteReader(CommandBehavior.SingleRow);
				if (reader2.Read()) {
					string DES_PRODUTO2 = reader2.GetString(2).Trim();
					string TXT_PRODUTO2 = reader2.GetString(3).Trim();
					string DES_MEDIDA2 = reader2.GetString(4).Trim();					
					if (!DES_PRODUTO.Equals(DES_PRODUTO2) ||
					    !TXT_PRODUTO.Equals(TXT_PRODUTO2) ||
					    !DES_MEDIDA.Equals(DES_MEDIDA2)) {
						tab.Rows.Add(new object[] {COD_PRODUTO, SUB_CODIGO, DES_PRODUTO, DES_PRODUTO2, DES_MEDIDA, DES_MEDIDA2, TXT_PRODUTO, TXT_PRODUTO2 });						
						alt++;
					}					    					
				}
				else {
					//tab.Rows.Add(new object[] {COD_PRODUTO, SUB_CODIGO, DES_PRODUTO});						
					inc++;
				}
				reader2.Close();
				*/
			}
			reader.Close();
			
			bd.Close();
			grid.DataSource = tab;
			grid.Columns[3].Visible = false;
			grid.Columns[4].Visible = false;
			grid.Columns[5].Visible = false;
			grid.Columns[6].Visible = false;
			grid.Columns[7].Visible = false;
		}
		
		public void Carrega(DataGridView grid, ref DataTable table, string where)
		{
			table = new DataTable();
			FbDataAdapter adapter = new FbDataAdapter();
			adapter.SelectCommand = new FbCommand("select COD_PARCEIRO," +
			                                      "       COD_PRODUTO," +			                                      			                                      			                                      
			                                      "       SUB_CODIGO," +			                                      			                                      
			                                      "       DES_PRODUTO," +			                                      
			                                      "       TXT_PRODUTO," +
			                                      "       DES_MEDIDA, " +			                                      			                                      
			                                      "       PER_IPI, " +			
			                                      "       IDT_GENERICO " +
			                                      "from PRODUTOS " + 
			                                      where + " " +			                                      
			                                      //"where cod_parceiro='FLEXFORM' " +
			                                      "order by COD_PRODUTO,SUB_CODIGO", 
			                                      Globais.bd);
			adapter.Fill(table);
			table.Columns[0].ColumnName = "Parceiro";			
			table.Columns[1].ColumnName = "Código";
			table.Columns[2].ColumnName = "Sub-Código";
			table.Columns[3].ColumnName = "Descrição";
			table.Columns[4].ColumnName = "Texto";
			table.Columns[5].ColumnName = "Medidas";
			table.Columns[6].ColumnName = "IPI";
			table.Columns[7].ColumnName = "Genérico";
			grid.DataSource = table;
			grid.Columns[3].Visible = false;			
			grid.Columns[4].Visible = false;
			grid.Columns[5].Visible = false;			
			grid.Columns[6].Visible = false;						
			grid.Columns[7].Visible = false;						
		}
		
		public void ProdutosFornenedor(DataGridView grid, string fornecedor, string tabela, ref DataTable table)
		{
			FbDataAdapter adapter = new FbDataAdapter();
			if (table == null)
			{
				table = new DataTable();
				string verifica_preco="";
				if (tabela.Trim().Length > 0)
					verifica_preco = "  inner join PRECOS pre on PRE.COD_PARCEIRO=pro.COD_PARCEIRO " +
						"and PRE.COD_PRODUTO=pro.COD_PRODUTO " +
						"and PRE.SUB_CODIGO=pro.SUB_CODIGO " +
						"and PRE.COD_TABELA='" + tabela.Trim() + "' " +
						"and PRE.VLR_PRECO <> 0 ";
					//verifica_preco = "  and cod_produto in (select cod_produto from precos where cod_parceiro='" + fornecedor + 
						//"' and cod_tabela='" + tabela + "' and vlr_preco <> 0)";
				adapter.SelectCommand = new FbCommand("select pro.COD_PRODUTO," +			                                      			                                      			                                      
			                                      "       pro.SUB_CODIGO," +			                                      			                                      
			                                      "       pro.DES_PRODUTO," + 
			                                      "       pro.DES_MEDIDA," +
			                                      "       pro.TXT_PRODUTO, " +
			                                      "       pro.IDT_GENERICO " +
			                                      "from PRODUTOS pro " + 
			                                      verifica_preco + " " +
			                                      "where pro.COD_PARCEIRO='" + fornecedor + "' " +			                                      
			                                      //verifica_preco + " " +
			                                      "order by pro.COD_PRODUTO,pro.SUB_CODIGO", 
			                                      Globais.bd);
				adapter.Fill(table);
				table.Columns[0].ColumnName = "Código";
				table.Columns[1].ColumnName = "Sub-Código";			
				table.Columns[2].ColumnName = "Descrição";
				table.Columns[3].ColumnName = "Medidas";
				table.Columns[4].ColumnName = "Detalhada";
				table.Columns[5].ColumnName = "Genérico";
			}
			grid.DataSource = table;
			grid.Columns[3].Visible = false;			
			grid.Columns[4].Visible = false;
			grid.Columns[5].Visible = false;
		}
		
		public string Descricao(string cod_produto, string sub_codigo)
		{
			FbCommand cmd;
			FbDataReader reader;
			string descricao="";
			
			cmd =  new FbCommand("select des_produto " +
			                     "from PRODUTOS " +
			                     "where cod_produto='" + cod_produto + "' and " +
				                 "      sub_codigo='" + sub_codigo + "'",
			                     Globais.bd);
			reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			if (reader.Read())
				descricao = reader.GetString(0).Trim();
			reader.Close();
			return descricao;
		}
		
		public bool Inclui(string parceiro, string codigo, string sub_codigo, string descricao, string texto, string medida, float ipi, 
		                   string generico, ref string msg)
		{
			string sipi = ipi.ToString().Replace(',', '.');
			string sql = "insert into PRODUTOS values(" +
						 "'"  + parceiro + "'," +				
						 "'"  + codigo + "'," +
						 "'"  + sub_codigo + "'," +				
						 "'"  + descricao + "'," +
						 "'"  + texto + "'," +
						 "'"  + medida + "'," +
						 sipi + "," + 
						 "'"  + generico + "'" +
				")";
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
		
		public bool Altera(string parceiro, string codigo, string sub_codigo, string descricao, string texto, string medida, float ipi, 
		                   string generico, ref string msg)
		{
			string sipi = ipi.ToString().Replace(',', '.');
			string sql = "update PRODUTOS set " +
						 "DES_PRODUTO='" + descricao + "', " + 
				  		 "TXT_PRODUTO='" + texto  + "', " + 
				    	 "PER_IPI=" + sipi  + ", " +
				    	 "DES_MEDIDA='" + medida  + "', " +				
					     "IDT_GENERICO='" + generico  + "' " +		
				    	 "where COD_PARCEIRO='" + parceiro + "' and " +
				    	 "      COD_PRODUTO='" + codigo + "' and " +				
				    	 "      SUB_CODIGO='" + sub_codigo + "'";
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
		
		public string Medidas_Descricao(string parceiro, string codigo, string sub_codigo, ref string descricao, ref string texto)
		{
			FbCommand cmd =  new FbCommand("select DES_MEDIDA,DES_PRODUTO,TXT_PRODUTO from PRODUTOS " +
								    	   "where COD_PARCEIRO='" + parceiro + "' and " +
								    	   "      COD_PRODUTO='" + codigo + "' and " +				
				    	 				   "      SUB_CODIGO='" + sub_codigo + "'",
			                               Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			if (!reader.Read())
			{
				reader.Close();				
				return "";
			}
			string medidas = reader.GetString(0).Trim();
			descricao = reader.GetString(1).Trim();
			texto = reader.GetString(2).Trim();
			reader.Close();			
			return medidas;
		}		
		
		public float IPI(string parceiro, string codigo, string sub_codigo)
		{
			FbCommand cmd =  new FbCommand("select PER_IPI from PRODUTOS " +
								    	   "where COD_PARCEIRO='" + parceiro + "' and " +
								    	   "      COD_PRODUTO='" + codigo + "' and " +				
				    	 				   "      SUB_CODIGO='" + sub_codigo + "'",
			                               Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			if (!reader.Read())
			{
				reader.Close();				
				return 0F;
			}
			float ipi = reader.GetFloat(0);
			reader.Close();			
			return ipi;
		}		
		
		public bool Exclui(string parceiro, string codigo, string sub_codigo, ref string msg)
		{
			string sql = "delete from PRODUTOS " +
				    	 "where COD_PARCEIRO='" + parceiro + "' and " +
				    	 "      COD_PRODUTO='" + codigo + "' and " +				
				    	 "      SUB_CODIGO='" + sub_codigo + "'";
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
