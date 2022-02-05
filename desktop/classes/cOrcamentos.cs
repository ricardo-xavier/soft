/*
 * Projeto  : SoftPlace
 * Programa : cOrcamentos - Classe de Orcamentos
 * Autor    : Ricardo Costa Xavier
 * Data     : 24/05/08
 * 
 * 22/02/14 - na cópia do orçamento, o novo será criado em situação em andamento
 * 
 * 21/07/14 - quebra por caracteristica na listagem
 * 
 * 16/11/14 - Ricardo - verificar se o preço de tabela foi alterado
 * 22/11/14 - Ricardo - ao copiar um orçamento o novo deve ter idt_pedido = 'N'
 */
using System;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using System.IO;
using pdf;
using iTextSharp.text;
using iTextSharp.text.pdf;
using classes;
using System.Collections;
using System.Collections.Generic;

namespace classes
{
	public class cOrcamentos
	{
		public static string versao = "v2.0 (24/03/19)";
		
		public cOrcamentos()
		{
		}
		
		private void SetaIntervalo(int anoi, int mesi, int anof, int mesf, ref string datai, ref string dataf)
		{
			int dia;
			DateTime d = new DateTime();
			datai = mesi.ToString() + "/01/" + anoi.ToString();
			for (dia=31; dia>=28; dia--) 
			{
				dataf = dia.ToString() + "/" + mesf.ToString() + "/" + anof.ToString();
				if (DateTime.TryParse(dataf, out d)) break;
			}
			dataf = mesf.ToString() + "/" + dia.ToString() + "/" + anof.ToString();
		}
		
		public void Carrega(DataGridView grid, string fornecedor, int anoi, int mesi, 
		                    int anof, int mesf, string vendedor,
		                    string cliente, string consultor, string caracteristica, 
		                    List<string> situacoes,
							string idt_cadastroI,
							DateTime cadastroI,
							string idt_cadastroF,
							DateTime cadastroF, string resumo)		                   
		{
			string datai="", dataf="", where="";
			bool bwhere=false;
			if (anoi > 0) SetaIntervalo(anoi, mesi, anof, mesf, ref datai, ref dataf);
			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			
			where = "where ";
			if (fornecedor.Length > 0)
			{
				where = where + "a.cod_fornecedor='" + fornecedor + "'";
				bwhere = true;
			}
			if (anoi > 0) 
			{
				if (bwhere) where = where + " and ";
				where = where + "a.dat_orcamento between '" + datai + "' and '" + dataf + "'";
				bwhere = true;
			}
			if (vendedor.Length > 0) 
			{
				if (bwhere) where = where + " and ";
				where = where + "a.cod_vendedor='" + vendedor + "'";
				bwhere = true;
			}
			if (cliente.Length > 0) 
			{
				if (bwhere) where = where + " and ";
				if (cliente.Contains(",") || cliente.Contains("'"))
				{
					where = where + "a.cod_cliente in (" + cliente + ")";
				}
				else {
					where = where + "a.cod_cliente='" + cliente + "'";
				}
				bwhere = true;
			}
			if (consultor.Length > 0) 
			{
				if (bwhere) where = where + " and ";
				where = where + "a.cod_consultor='" + consultor + "'";
				bwhere = true;
			}
			if (resumo.Length > 0) 
			{
				if (bwhere) where = where + " and ";
				where = where + "upper(tira_acentos(a.des_resumo)) like '%" + Acentuacao.TiraAcentos(resumo).ToUpper() + "%'";
				bwhere = true;
			}			
			if (caracteristica.Length > 0) 
			{
				if (bwhere) where = where + " and ";
				where = where + "a.cod_caracteristica='" + caracteristica + "'";
				bwhere = true;
			}
			if ((situacoes != null) && (situacoes.Count > 0))
			{
				if (bwhere) where = where + " and ";
				where += "a.cod_situacao in (";
				bool primeira = true;
				foreach (string situacao in situacoes)
				{
					if (primeira)
						primeira = false;
					else
						where += ",";
					where += "'" + situacao.Trim() + "'";
				}
				where += ")";
				bwhere = true;
			}
			if (bwhere) where = where + " and ";
			where = where + "b.cod_fornecedor = a.cod_fornecedor and b.cod_caracteristica = a.cod_caracteristica";
			where = where + " and c.cod_situacao = a.cod_situacao";
			string join="";
			if ((idt_cadastroI[0] == 'S') || (idt_cadastroF[0] == 'S'))
			{
				if ((idt_cadastroI[0] == 'S') && (idt_cadastroF[0] == 'S'))
					join = "inner join PARCEIROS p on p.COD_PARCEIRO=a.COD_CLIENTE and (" +
						"p.dat_cadastro >= '" + cadastroI.ToString("M/d/yyyy") + "' and " +
						"p.dat_cadastro <= '" + cadastroF.ToString("M/d/yyyy") + "') ";
				else
				if (idt_cadastroI[0] == 'S')
					join = "inner join PARCEIROS p on p.COD_PARCEIRO=a.COD_CLIENTE and (" +
						"p.dat_cadastro >= '" + cadastroI.ToString("M/d/yyyy") + "') ";
				else
					join = "inner join PARCEIROS p on p.COD_PARCEIRO=a.COD_CLIENTE and (" +
						"p.dat_cadastro <= '" + cadastroF.ToString("M/d/yyyy") + "') ";		
			}
			
			//if (!bwhere) where = "";
			string sql = "select a.cod_fornecedor," +             // 0
			             "       a.dat_orcamento," +              // 1
			             "       a.cod_orcamento," +              // 2
			             "       a.cod_vendedor," +               // 3
						 "       a.cod_cliente," +                // 4
						 "       a.cod_contato," +		 	      // 5
						 "       a.cod_consultor," +              // 6
						 "       a.cod_tabela," +				  // 7
						 "       a.cod_caracteristica," +		  // 8
						 "       a.dat_alteracao," +              // 9
						 "       a.vlr_orcamento," +			  // 10
						 "       a.vlr_desconto," +			      // 11
						 "       a.des_resumo," +                 // 12
						 "       a.txt_observacao," +             // 13
						 "       c.des_situacao," +			      // 14
						 //"       vlr_orcamento-vlr_desconto-vlr_consultor," + // 15
						 "       a.vlr_orcamento-a.vlr_desconto," + // 15
					     "       a.idt_especial," +               // 16
				         "       a.idt_pedido," +                 // 17
						 "       ' '," +                          // 18
					     "       a.cod_usuario," +                // 19
						 "       a.per_consultor," +              // 20
						 "       b.per_limiar," +                 // 21
						 "       b.txt_racional," +               // 22
						 "       ' ', " +                         // 23 chave
				
						 // 24 - colore de laranja se o preço do item for diferente do preço na tabela
						 "(select count(*) from itens i " +
						 "inner join precos p " +
						 "on p.COD_PARCEIRO=i.COD_FORNECEDOR and p.COD_TABELA=a.COD_TABELA and p.COD_PRODUTO=i.COD_PRODUTO and p.SUB_CODIGO=i.SUB_CODIGO " +
						 "and p.VLR_PRECO <> i.VLR_PRECO_TABELA " +
						 "where i.COD_FORNECEDOR=a.COD_FORNECEDOR and i.COD_ORCAMENTO=a.COD_ORCAMENTO and i.DAT_ORCAMENTO=a.DAT_ORCAMENTO), " +

						 // 25 - colore de vermelho se a tabela tiver desativada
						 "t.IDT_ATIVO " +
				
			             "from orcamentos a, caracteristicas b, situacoes c " +
				
						 join + " " +
				
						 "inner join TAB_PRECOS t " +
						 "on t.COD_PARCEIRO=a.COD_FORNECEDOR and t.COD_TABELA=a.COD_TABELA " +
				
			             where + " " +
			             "order by cod_fornecedor,dat_orcamento,cod_orcamento";
			
			//Log.Grava("teste.ricardo", where);
			
			adapter.SelectCommand = new FbCommand(sql, Globais.bd);
			adapter.Fill(table);
			table.Columns[0].ColumnName = "Fornecedor";
			table.Columns[1].ColumnName = "Data";			
			table.Columns[2].ColumnName = "Cod";
			table.Columns[3].ColumnName = "Vendedor";				
			table.Columns[4].ColumnName = "Cliente";
			table.Columns[5].ColumnName = "Contato";			
			table.Columns[6].ColumnName = "Consultor";				
			table.Columns[7].ColumnName = "Tabela";										
			table.Columns[8].ColumnName = "Característica";															
			table.Columns[9].ColumnName = "Alteração";																			
			table.Columns[10].ColumnName = "Valor Itens";
			table.Columns[11].ColumnName = "Desconto";
			table.Columns[12].ColumnName = "Resumo";																						
			table.Columns[13].ColumnName = "Observação";
			table.Columns[14].ColumnName = "Situação";
			table.Columns[15].ColumnName = "Valor";
			table.Columns[16].ColumnName = "M";
			table.Columns[17].ColumnName = "P";
			table.Columns[18].ColumnName = "Sinal";			
			table.Columns[19].ColumnName = "Usuário";
			table.Columns[20].ColumnName = "Comissão Consultor";
			table.Columns[21].ColumnName = "Limiar";
			table.Columns[22].ColumnName = "Racional";
			table.Columns[23].ColumnName = "Chave";
			table.Columns[24].ColumnName = "Preço Tabela Alterado";
			table.Columns[25].ColumnName = "Tabela Ativa";
			grid.DataSource = table;
			
			grid.Columns["Chave"].Visible = false;
			grid.Columns["Contato"].Visible = false;			
			grid.Columns["Tabela"].Visible = false;						
			grid.Columns["Característica"].Visible = false;
			grid.Columns["Alteração"].Visible = false;
			grid.Columns["Valor Itens"].Visible = false;
			grid.Columns["Desconto"].Visible = false;			
			grid.Columns["Resumo"].Visible = false;
			grid.Columns["Observação"].Visible = false;
			grid.Columns["Usuário"].Visible = false;
			grid.Columns["Comissão Consultor"].Visible = false;
			grid.Columns["Limiar"].Visible = false;
			grid.Columns["Racional"].Visible = false;
			grid.Columns["Preço Tabela Alterado"].Visible = false;
			grid.Columns["Tabela Ativa"].Visible = false;
			bool b=true;
			DataColumn check = new DataColumn("S", b.GetType());
			table.Columns.Add(check);
			
			grid.Columns["Data"].Width = 64;									
			grid.Columns["Cod"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;			
			grid.Columns["Cod"].Width = 30;
			grid.Columns["Valor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			grid.Columns["Valor"].DefaultCellStyle.Format = "#,###,##0.00";
			grid.Columns["Valor"].Width = 80;
			grid.Columns["Situação"].Width = 94;
			grid.Columns["M"].Width = 20;
			grid.Columns["P"].Width = 20;
			grid.Columns["Sinal"].Width = 30;
			grid.Columns["Sinal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;			
			grid.Columns["S"].Width = 20;
			grid.Columns["Cliente"].Width = 140;
			
			foreach (DataGridViewRow row in grid.Rows)
			{
				row.Cells["Chave"].Value = 
					row.Cells["Fornecedor"].Value.ToString().Trim() +
					row.Cells["Data"].Value.ToString().Trim() +
					row.Cells["Cod"].Value.ToString().Trim();
			}			
		}
		
		public string Caracteristica(string fornecedor, DateTime data, short orcamento)
		{
			string formula="";
			FbCommand cmd =  new FbCommand("select COD_CARACTERISTICA " +
			                               "from ORCAMENTOS " +
							               "where cod_fornecedor='" + fornecedor + "' and " +
								           "      dat_orcamento='" + data.ToString("M/d/yyyy") + "' and " +
				         				   "      cod_orcamento=" + orcamento,
			                               Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			if (reader.Read())
			{
				formula = reader.GetString(0).Trim();
			}
			reader.Close();
			return formula;
		}		
		/*
		public float CalculaFormula(float preco, string formula, float ipi)
		{
			float fator;
			for (int i=0; i<formula.Trim().Length; i+=4)
			{
				if (formula[i] == 'x') {
					fator = Globais.StrToFloat(formula.Substring(i+1, 3));
					preco *= fator;
					continue;
				}
				if (formula.Substring(i, 4).CompareTo("+IPI") == 0)
				{
					fator = ipi;
				}
				else fator = Globais.StrToFloat(formula.Substring(i, 4));
				preco += (preco * fator / (float)100);
			}
			return preco;
		}
		*/
		
		public void CarregaItens(DataGridView grid, string fornecedor, DateTime data, short orcamento, string formula, string cod_tabela)
		{
			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			string sql = "select a.cod_area," +
			             "       a.seq_item," +			                                      
			             "       a.cod_produto," +
			             "       a.sub_codigo," +				
			             "       a.qtd_item," +
						 "       a.des_medidas," +
						 "       a.vlr_preco," +
						 "       a.idt_especial," +
						 "       a.vlr_preco_tabela, " +				
						 "       a.vlr_preco, " +
						 "       b.per_ipi," +
					     "       a.des_produto," +
						 "       a.txt_produto," +
						 "       a.cod_especificos," +
						 "       o.cod_caracteristica," +
						 "       p.vlr_preco, " + 
						 "       b.idt_generico " + 
			             "from itens a, produtos b, orcamentos o, precos p " +
			             "where a.cod_fornecedor='" + fornecedor + "' and " +
				         "      a.dat_orcamento='" + data.ToString("M/d/yyyy") + "' and " +
				         "      a.cod_orcamento=" + orcamento + " and " +
				         "      a.cod_fornecedor=b.cod_parceiro and " +
				         "      a.cod_produto=b.cod_produto and " +
				         "      a.sub_codigo=b.sub_codigo and " +
			             "      o.cod_fornecedor=a.cod_fornecedor and " +
				         "      o.dat_orcamento=a.dat_orcamento and " +
				         "      o.cod_orcamento=a.cod_orcamento and " +
						 "      p.cod_parceiro=b.cod_parceiro and " +
						 "      p.cod_tabela='" + cod_tabela + "' and " +
						 "      p.cod_produto=b.cod_produto and " +
						 "      p.sub_codigo=b.sub_codigo " +
			             "order by a.cod_area,a.seq_item";
			adapter.SelectCommand = new FbCommand(sql, Globais.bd);
			adapter.Fill(table);
			table.Columns[0].ColumnName = "Área";
			table.Columns[1].ColumnName = "Seq";
			table.Columns[2].ColumnName = "Produto";
			table.Columns[3].ColumnName = "Sub-Código";			
			table.Columns[4].ColumnName = "Qtde";
			table.Columns[6].ColumnName = "Preço";
			table.Columns[7].ColumnName = "Especial";
			// colunas escondidas			
			table.Columns[5].ColumnName = "Medidas";
			table.Columns[8].ColumnName = "Preço Tabela";
			table.Columns[9].ColumnName = "Preço Unitário";
			table.Columns[10].ColumnName = "IPI";
			table.Columns[11].ColumnName = "Descrição";
			table.Columns[12].ColumnName = "Texto";
			table.Columns[13].ColumnName = "Específicos";
			table.Columns[14].ColumnName = "Caracteristica";
			table.Columns[15].ColumnName = "Preço Atual Tabela";
			table.Columns[16].ColumnName = "Genérico";
			grid.DataSource = table;
			grid.Columns["Seq"].Visible = false;
			grid.Columns["Medidas"].Visible = false;
			grid.Columns["Preço Tabela"].Visible = false;	
			grid.Columns["Preço Unitário"].Visible = false;
			grid.Columns["IPI"].Visible = false;
			grid.Columns["Descrição"].Visible = false;
			grid.Columns["Texto"].Visible = false;
			grid.Columns["Específicos"].Visible = false;
			grid.Columns["Caracteristica"].Visible = false;
			grid.Columns["Preço Atual Tabela"].Visible = false;
			grid.Columns["Genérico"].Visible = false;
			grid.Columns["Qtde"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;			
			grid.Columns["Preço"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			grid.Columns["Preço"].DefaultCellStyle.Format = "###,###,##0.00";
			float preco_unitario, preco_formula, ipi;			
			for (int i=0; i<grid.Rows.Count; i++)
			{
				ipi = Globais.StrToFloat(grid.Rows[i].Cells["IPI"].Value.ToString());
				preco_unitario = Globais.StrToFloat(grid.Rows[i].Cells["Preço Unitário"].Value.ToString());				
				if (grid.Rows[i].Cells["Especial"].Value.ToString().Trim().CompareTo("S") != 0)
				{
					preco_formula = preco_unitario;
					string caracteristica = grid.Rows[i].Cells["Caracteristica"].Value.ToString();
					float per_frete = cCaracteristicas.Frete(fornecedor, caracteristica);
					Globais.CalculaFormula(ref preco_formula, formula, ipi, per_frete, 0);
				}
				else
					preco_formula = preco_unitario;
				//preco_formula += (preco_formula * ipi / 100F);
				grid.Rows[i].Cells["Preço"].Value = preco_formula;
			}
		}
				
		public bool Inclui(string fornecedor, DateTime data, string vendedor, string cliente, string contato, 
		                   string consultor, string tabela, string caracteristica, string resumo, string observacao,
		                   string situacao, float per_consultor,
		                   ref string msg, ref int cod_orcamento)
		{
			int codigo=1;
			string datai="", dataf="";
			short ano = (short)data.Year;
			short mes = (short)data.Month;
			SetaIntervalo(ano, mes, ano, mes, ref datai, ref dataf);
			FbCommand cmd = new FbCommand("select max(COD_ORCAMENTO) from ORCAMENTOS " +
				    	                  "where COD_FORNECEDOR='" + fornecedor + "' and " +
                                          "      DAT_ORCAMENTO between '" + datai + "' and '" + dataf + "'",
			                              Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			if (reader.Read())
			{
				if (!reader.IsDBNull(0))
					codigo = reader.GetInt32(0) + 1;
			}
			reader.Close();
			cod_orcamento = codigo;

			string fk_tabela;
			if (tabela.Trim().Length > 0)
				fk_tabela = "'" + tabela + "'";
			else
				fk_tabela = "null";
			string fk_caracteristica;
			if (caracteristica.Trim().Length > 0)
				fk_caracteristica = "'" + caracteristica + "'";
			else
				fk_caracteristica = "null";
			string sql = "insert into ORCAMENTOS values(" +
						 "'"  + fornecedor + "'," +				
						 "'"  + data.ToString("M/d/yyyy") + "'," +				
						 codigo + "," +
						 "'"  + vendedor + "'," +
						 "'"  + cliente + "'," +
						 "'"  + contato + "'," +				
						 "'"  + consultor + "'," +				
						 fk_tabela + "," +							
						 fk_caracteristica + "," +			
						 "'"  + DateTime.Today.Date.ToString("M/d/yyyy") + "'," +				
						 "0," +
						 "0," +				
						 "'"  + resumo + "'," +				
						 "'"  + observacao + "'," +				
						 "'"  + situacao + "'," +
						 "'"  + Globais.sUsuario + "'," +
						 per_consultor.ToString().Replace(',','.') + "," +
						 "'N'," + // especial
						 "'N')";  // pedido
			FbCommand cmd2 = new FbCommand(sql, Globais.bd);
			try
			{
				Log.Grava(Globais.sUsuario, cmd2.CommandText);
				cmd2.ExecuteNonQuery();
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
		
		public void Copia(string fornecedor, DateTime data, short orcamento)
		{
			int codigo=1;
			string datai="", dataf="";
			short ano = (short)DateTime.Today.Date.Year;
			short mes = (short)DateTime.Today.Date.Month;
			SetaIntervalo(ano, mes, ano, mes, ref datai, ref dataf);
			FbCommand cmd = new FbCommand("select max(COD_ORCAMENTO) from ORCAMENTOS " +
				    	                  "where COD_FORNECEDOR='" + fornecedor + "' and " +
                                          "      DAT_ORCAMENTO between '" + datai + "' and '" + dataf + "'",
			                              Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			if (reader.Read())
			{
				if (!reader.IsDBNull(0))
					codigo = reader.GetInt32(0) + 1;
			}
			reader.Close();

			string sql = "insert into ORCAMENTOS select " +
						"cod_fornecedor," +
						"'" + DateTime.Today.Date.ToString("M/d/yyyy") + "'," +
						codigo + "," +
						"cod_vendedor," +
						"cod_cliente," +
						"cod_contato," +
						"cod_consultor," +
						"cod_tabela," +
						"cod_caracteristica," +
						"dat_alteracao," +
						"vlr_orcamento," +
						"vlr_desconto," +
						"des_resumo," +
						"txt_observacao," +
						"'E'," +
				        "cod_usuario," + 
						"per_consultor," + 
						"idt_especial," + 
						"'N' " + //"idt_pedido " + 
						"from ORCAMENTOS " +
						"where cod_fornecedor='" + fornecedor + "' and " +
						"      dat_orcamento='" + data.ToString("M/d/yyyy") + "' and " +
				        "      cod_orcamento=" + orcamento;
			FbCommand cmd2 = new FbCommand(sql, Globais.bd);
			try
			{
				Log.Grava(Globais.sUsuario, cmd2.CommandText);
				cmd2.ExecuteNonQuery();
			}
			catch (Exception err)
			{
				Log.Grava(Globais.sUsuario, "erro:" + err.Message);
				string msg = err.Message;
			}
			
			sql = "insert into ITENS select " +
						"cod_fornecedor," +
						"'" + DateTime.Today.Date.ToString("M/d/yyyy") + "'," +
						codigo + "," +
						"cod_area," +
						"seq_item," +
						"cod_produto," +
						"sub_codigo," +
						"qtd_item," +
						"des_medidas," +
						"vlr_preco," +
						"idt_especial," +				
						"vlr_preco_tabela," +
					    "des_produto," +
						"txt_produto," +
						"cod_especificos " +
						"from ITENS " +
						"where cod_fornecedor='" + fornecedor + "' and " +
						"      dat_orcamento='" + data.ToString("M/d/yyyy") + "' and " +
				        "      cod_orcamento=" + orcamento;
			FbCommand cmd3 = new FbCommand(sql, Globais.bd);
			try
			{
				Log.Grava(Globais.sUsuario, cmd3.CommandText);
				cmd3.ExecuteNonQuery();
			}
			catch (Exception err)
			{
				Log.Grava(Globais.sUsuario, "erro:" + err.Message);
				string msg = err.Message;
			}
			
		}
		
		public float RecalculaTotal(string fornecedor, DateTime data, short orcamento, string p_caracteristica, string nova_tabela)
		{
			float total=0;
			short qtd;
			float preco_unitario, preco_formula, ipi=0;
			string formula, especial, caracteristica;
			cTabelas tabelas;
			
			cPedidos pedidos = new cPedidos();
			bool pedido = pedidos.Existe(fornecedor, data, orcamento);
			
			tabelas = new cTabelas();
			
			//preco_tabela = tabelas.Preco(fornecedor, tabela, produto, subcod);				
			if (p_caracteristica.Trim().Length > 0)
				caracteristica = p_caracteristica;
			else
				caracteristica = Caracteristica(fornecedor, data, orcamento);
			if (caracteristica.Trim().Length > 0)
			{
				cCaracteristicas caracteristicas = new cCaracteristicas();
				formula = caracteristicas.Formula(fornecedor, caracteristica).Trim();
			}
			else formula="";
			
			FbCommand cmd = new FbCommand("select a.qtd_item,a.vlr_preco,a.idt_especial,b.per_ipi," +
			                              "a.seq_item,a.cod_produto,a.sub_codigo " +
			                              "from ITENS a, PRODUTOS b " +
				 			              "where a.cod_fornecedor='" + fornecedor + "' and " +
				         				  "      a.dat_orcamento='" + data.ToString("M/d/yyyy") + "' and " +
				             			  "      a.cod_orcamento=" + orcamento + " and " +
				         				  "      a.cod_fornecedor=b.cod_parceiro and " +
				         				  "      a.cod_produto=b.cod_produto and " +
				         				  "      a.sub_codigo=b.sub_codigo ",
			                              Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			while (reader.Read())
			{
				qtd = reader.GetInt16(0);
				preco_unitario = reader.GetFloat(1);
				especial = reader.GetString(2).Trim();
				ipi = reader.GetFloat(3);
				if ((nova_tabela.Trim().Length > 0) && (especial.CompareTo("S") != 0))
				{
					short seq = reader.GetInt16(4);
					string codigo = reader.GetString(5).Trim();
					string subcod = reader.GetString(6).Trim();
					float novo_preco = tabelas.Preco(fornecedor, nova_tabela, codigo, subcod);
					//if ((novo_preco != 0) && (novo_preco != preco_unitario))
					//{
						AlteraPrecoItem(fornecedor, data, orcamento, seq, novo_preco);
						preco_unitario = novo_preco;
					//}
				}
				if ((especial.CompareTo("S") != 0) && (formula.Length > 0))
				{
					preco_formula = preco_unitario;
					float per_frete = cCaracteristicas.Frete(fornecedor, caracteristica);
					Globais.CalculaFormula(ref preco_formula, formula, ipi, per_frete, 0);
				}
				else
					preco_formula = preco_unitario;
				//preco_formula += (preco_formula * ipi / 100F);
				total += (qtd * preco_formula);
			}
			reader.Close();
			
			if (pedido) {
				return total;
			}
			
			string stotal = total.ToString().Replace(',', '.');
			string sql = "update ORCAMENTOS set vlr_orcamento=" + stotal + " " +
						 "where cod_fornecedor='"  + fornecedor + "' and " +							
						 "      dat_orcamento='"  + data.ToString("M/d/yyyy") + "' and " +				
						 "      cod_orcamento=" + orcamento;
			FbCommand cmd2 = new FbCommand(sql, Globais.bd);
			try
			{
				Log.Grava(Globais.sUsuario, cmd2.CommandText);
				cmd2.ExecuteNonQuery();
			}
			catch (Exception err)
			{
				Log.Grava(Globais.sUsuario, "erro:" + err.Message);
				string msg = err.Message;
			}
			return total;
		}
				
		public bool IncluiItem(string fornecedor, DateTime data, short orcamento,
		                       string area, string produto, string subcod, short qtd, string medidas,
		                       float preco, float preco_tabela, string especial, 
		                       string descricao, string texto, string especificos, ref string msg)
		{
			int codigo=1;
			FbCommand cmd = new FbCommand("select max(SEQ_ITEM) from ITENS " +
				 			              "where cod_fornecedor='" + fornecedor + "' and " +
				         				  "      dat_orcamento='" + data.ToString("M/d/yyyy") + "' and " +
				             			  "      cod_orcamento=" + orcamento, // + " and " +				
				             			  //"      cod_area='" + area + "'",
			                              Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			if (reader.Read())
			{
				if (!reader.IsDBNull(0))
					codigo = reader.GetInt32(0) + 1;
			}
			reader.Close();

			string sql = "insert into ITENS values(" +
						 "'"  + fornecedor + "'," +				
						 "'"  + data.ToString("M/d/yyyy") + "'," +				
						 orcamento + "," +
						 "'"  + area + "'," +
						 codigo + "," +		
						 "'"  + produto + "'," +
						 "'"  + subcod + "'," +				
						 qtd + "," +								
						 "'"  + medidas + "'," +
						 preco.ToString().Replace(',','.') + "," +												
						 "'"  + especial + "'," +
						 preco_tabela.ToString().Replace(',','.') + "," +
						 "'" + descricao + "'," +
						 "'" + texto + "'," +
						 "'" + especificos + "')";
			FbCommand cmd2 = new FbCommand(sql, Globais.bd);
			try
			{
				Log.Grava(Globais.sUsuario, cmd2.CommandText);
				cmd2.ExecuteNonQuery();
			}
			catch (Exception err)
			{
				Log.Grava(Globais.sUsuario, "erro:" + err.Message);
				msg = err.Message;
				return false;
			}
			msg = "OK";
			RecalculaTotal(fornecedor, data, orcamento, "", "");
			string idt_especial = Especial(fornecedor, data, orcamento);
			AlteraEspecial(fornecedor, data, orcamento, idt_especial[0]);
			return true;
		}	
		
		public bool AlteraItem(string fornecedor, DateTime data, short orcamento,
		                       string area, short codigo, string produto, string subcod, short qtd, string medidas,
		                       float preco, float preco_tabela, string especial, 
		                       string descricao, string texto, string especificos, ref string msg)
		{
			string spreco = preco.ToString().Replace(',', '.');
			string spreco_tabela = preco_tabela.ToString().Replace(',', '.');
			string sql = "update ITENS set " +
						 "cod_area='"  + area + "'," +
						 "cod_produto='"  + produto + "'," +
						 "sub_codigo='"  + subcod + "'," +				
						 "qtd_item=" + qtd + "," +								
						 "des_medidas='"  + medidas + "'," +
						 "vlr_preco=" + spreco + "," +												
						 "idt_especial='"  + especial + "'," +			
						 "vlr_preco_tabela=" + spreco_tabela + "," +
						 "des_produto='" + descricao + "'," +
						 "txt_produto='" + texto + "'," +
						 "cod_especificos='" + especificos + "' " +
			             "where cod_fornecedor='" + fornecedor + "' and " +
				         "      dat_orcamento='" + data.ToString("M/d/yyyy") + "' and " +
				         "      cod_orcamento=" + orcamento + " and " +
						 //"      cod_area='"  + area + "' and " +				
						 "      seq_item=" + codigo;
			FbCommand cmd2 = new FbCommand(sql, Globais.bd);
			try
			{
				Log.Grava(Globais.sUsuario, cmd2.CommandText);
				cmd2.ExecuteNonQuery();
			}
			catch (Exception err)
			{
				Log.Grava(Globais.sUsuario, "erro:" + err.Message);
				msg = err.Message;
				return false;
			}
			msg = "OK";
			RecalculaTotal(fornecedor, data, orcamento, "", "");
			string idt_especial = Especial(fornecedor, data, orcamento);
			AlteraEspecial(fornecedor, data, orcamento, idt_especial[0]);
			return true;
		}	
		
		bool AlteraPrecoItem(string fornecedor, DateTime data, short orcamento, short seq, float novo_preco)
		{
			string spreco = novo_preco.ToString().Replace(',', '.');
			string sql = "update ITENS set " +
						 "vlr_preco=" + spreco + "," +												
						 "vlr_preco_tabela=" + spreco + " " +
			             "where cod_fornecedor='" + fornecedor + "' and " +
				         "      dat_orcamento='" + data.ToString("M/d/yyyy") + "' and " +
				         "      cod_orcamento=" + orcamento + " and " +
						 "      seq_item=" + seq;
			FbCommand cmd2 = new FbCommand(sql, Globais.bd);
			try
			{
				Log.Grava(Globais.sUsuario, cmd2.CommandText);
				cmd2.ExecuteNonQuery();
			}
			catch (Exception)
			{
				return false;
			}
			return true;
		}	
		
		public bool Altera(string fornecedor, DateTime data, int codigo, string vendedor, string cliente, string contato, 
		                   string consultor, string tabela, string caracteristica, 
		                   float desconto, string resumo, string observacao,
		                   string situacao, float per_consultor, ref string msg)
		{
			string sdesconto = desconto.ToString().Replace(',', '.');			
			string fk_tabela;
			if (tabela.Trim().Length > 0)
				fk_tabela = "'" + tabela + "'";
			else
				fk_tabela = "null";
			string fk_caracteristica;
			if (caracteristica.Trim().Length > 0)
				fk_caracteristica = "'" + caracteristica + "'";
			else
				fk_caracteristica = "null";
			string sql = "update ORCAMENTOS set " +
						 "cod_vendedor='"  + vendedor + "'," +
						 "cod_cliente='"  + cliente + "'," +
						 "cod_contato='"  + contato + "'," +				
						 "cod_consultor='"  + consultor + "'," +				
						 "cod_tabela="  + fk_tabela + "," +							
						 "cod_caracteristica="  + fk_caracteristica + "," +			
						 "dat_alteracao='"  + DateTime.Today.Date.ToString("M/d/yyyy") + "'," +				
						 "vlr_desconto="  + sdesconto + "," +								
						 "des_resumo='"  + resumo + "'," +				
						 "txt_observacao='"  + observacao + "'," +				
						 "cod_situacao='"  + situacao + "'," +
						 "cod_usuario='"  + Globais.sUsuario + "'," +
						 "per_consultor="  + per_consultor.ToString().Replace(',','.') + " " +
						 "where cod_fornecedor='"  + fornecedor + "' and " +							
						 "      dat_orcamento='"  + data.ToString("M/d/yyyy") + "' and " +				
						 "      cod_orcamento=" + codigo;
						 	
			FbCommand cmd2 = new FbCommand(sql, Globais.bd);
			try
			{
				Log.Grava(Globais.sUsuario, cmd2.CommandText);
				cmd2.ExecuteNonQuery();
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
		
		public bool Exclui(string fornecedor, DateTime data, int codigo, ref string msg)
		{
			string sql = "delete from ORCAMENTOS " +
						 "where cod_fornecedor='"  + fornecedor + "' and " +							
						 "      dat_orcamento='"  + data.ToString("M/d/yyyy") + "' and " +				
						 "      cod_orcamento=" + codigo;
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
		
		public bool ExcluiItem(string fornecedor, DateTime data, int orcamento, string area, short codigo, ref string msg)
		{
			string sql = "delete from ITENS " +
			             "where cod_fornecedor='" + fornecedor + "' and " +
				         "      dat_orcamento='" + data.ToString("M/d/yyyy") + "' and " +
				         "      cod_orcamento=" + orcamento + " and " +
						 //"      cod_area='"  + area + "' and " +				
						 "      seq_item=" + codigo;
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
			RecalculaTotal(fornecedor, data, (short)orcamento, "", "");
			string idt_especial = Especial(fornecedor, data, (short)orcamento);
			AlteraEspecial(fornecedor, data, (short)orcamento, idt_especial[0]);
			return true;
		}		

		private void DadosParceiro(string codigo, ref string nome, ref string fone, ref string email)
		{
			FbCommand cmd;
			FbDataReader reader;
			
			cmd =  new FbCommand("select nom_parceiro, " +
			                     "       nro_fone1, " + 			                     
			                     "       des_email " +
			                     "from PARCEIROS  " +
			                     "where cod_parceiro='" + codigo.Trim() + "'",
			                     Globais.bd);
			reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			if (reader.Read())
			{
				nome = reader.GetString(0).Trim();
				fone = reader.GetString(1).Trim();
				email = reader.GetString(2).Trim();
			}
			else
			{
				nome = "";
				fone = "";
				email = "";
			}
			reader.Close();
		}

		private Cabecalho1 DadosCabecalho1(int orcamento, DateTime data, bool endereco_filial, string fornecedor)
		{
			Cabecalho1 cab1 = new Cabecalho1();
			cab1.logo = "imagens\\logo2.jpg";
			cab1.orcamento = orcamento;
			cab1.data = data;
			FbCommand cmd;
			if (endereco_filial)
			{
				cmd =  new FbCommand(
					"select nom_filial, " +
					"       des_logradouro, " + 
					"       nro_endereco, " + 			                     
					"       des_complemento, " + 			                     
					"       nro_cep, " + 			                     
					"       nro_fone1, " + 			                     
					"       nro_fax, " + 			                     
					"       des_email " + 			                     			                     
					"from FILIAIS " +
					"where cod_filial='" + Globais.sFilial + "'",
					Globais.bd);
			}
			else
			{
				cmd =  new FbCommand(
					"select NOM_PARCEIRO, " +
					"       des_logradouro, " + 
					"       nro_endereco, " + 			                     
					"       des_complemento, " + 			                     
					"       nro_cep, " + 			                     
					"       nro_fone1, " + 			                     
					"       nro_fax, " + 			                     
					"       des_email " + 			                     			                     
					"from parceiros " +
					"where cod_parceiro='" + fornecedor + "'",
					Globais.bd);
			}
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			if (reader.Read())
			{
				cab1.filial = !reader.IsDBNull(0) ? reader.GetString(0).Trim() : "";
				cab1.rua = !reader.IsDBNull(1) ? reader.GetString(1).Trim() : "";
				cab1.nro = !reader.IsDBNull(2) ? reader.GetString(2).Trim() : "";
				cab1.complemento = !reader.IsDBNull(3) ? reader.GetString(3).Trim() : "";
				cab1.cep = !reader.IsDBNull(4) ? reader.GetString(4).Trim() : "";
				cab1.fone = !reader.IsDBNull(5) ? reader.GetString(5).Trim() : "";
				cab1.fax = !reader.IsDBNull(6) ? reader.GetString(6).Trim() : "";
				cab1.email = !reader.IsDBNull(7) ? reader.GetString(7).Trim() : "";
			}
			else 
			{
				cab1.filial = "";
				cab1.rua = "";
				cab1.nro = "";
				cab1.complemento = "";
				cab1.cep = "";
				cab1.fone = "";
				cab1.fax = "";
				cab1.email = "";
			}
			reader.Close();
			
			return cab1;
		}
		
		public Cabecalho2 DadosCabecalho2(string fornecedor, string cod_cliente, string cod_contato, string cod_consultor, string cod_vendedor)
		{
			Cabecalho2 cab2 = new Cabecalho2();
			FbCommand cmd;
			FbDataReader reader;
			
			// fornecedor
			string fone="";
			string email="";
			DadosParceiro(fornecedor, ref cab2.fornecedor, ref fone, ref email);
			// cliente
			DadosParceiro(cod_cliente, ref cab2.cliente, ref fone, ref email);			
			//contato
			if (cod_contato != null) {
				cmd =  new FbCommand("select nom_contato, " +
				                     "       nro_fone1, " + 			                     
				                     "       des_email " +
				                     "from CONTATOS " +
			    	                 "where cod_parceiro='" + cod_cliente.Trim() + "' and " +
			        	             "      cod_contato='" + cod_contato.Trim() + "'",			                     
			            	         Globais.bd);
				reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
				if (reader.Read())
				{
					cab2.nom_contato = !reader.IsDBNull(0) ? reader.GetString(0).Trim() : "";
					cab2.fone_contato = !reader.IsDBNull(1) ? reader.GetString(1).Trim() : "";
					cab2.email_contato = !reader.IsDBNull(2) ? reader.GetString(2).Trim() : "";
				}
				else
				{
					cab2.nom_contato = "";
					cab2.fone_contato = "";
					cab2.email_contato = "";
				}
				reader.Close();
			}
			// consultor			
			if (cod_consultor != null)
				DadosParceiro(cod_consultor, ref cab2.nom_consultor, ref cab2.fone_consultor, ref cab2.email_consultor);
			// vendedor
			if (cod_vendedor != null) {
				cmd =  new FbCommand("select NOM_FUNCIONARIO,nro_fone1, " + 			                     
			                     	"       des_email " +
			                     	"from FUNCIONARIOS " +
			                     	"where cod_funcionario='" + cod_vendedor.Trim() + "'",
			                     	Globais.bd);
				reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
				if (reader.Read())
				{
					cab2.nom_vendedor = !reader.IsDBNull(0) ? reader.GetString(0).Trim() : "";
					cab2.fone_vendedor = !reader.IsDBNull(1) ? reader.GetString(1).Trim() : "";
					cab2.email_vendedor = !reader.IsDBNull(2) ? reader.GetString(2).Trim() : "";
				}
				else
				{
					cab2.nom_vendedor = "";
					cab2.fone_vendedor = "";
					cab2.email_vendedor = "";
				}
				reader.Close();				
			}
			
			return cab2;
		}
		
		private void DadosOrcamento(string fornecedor, DateTime data, int orcamento,
									ref string cod_cliente, ref string cod_contato, ref string cod_vendedor,
		                            ref string cod_consultor, ref float vlr_orcamento, ref float vlr_desconto, 
		                            ref string txt_observacao)
		{
			FbCommand cmd =  new FbCommand("select cod_cliente, " +
			                     		   "       cod_contato, " +
			                     		   "       cod_vendedor, " +
			                     		   "       cod_consultor, " +
			                     		   "       vlr_orcamento, " +
			                     		   "       vlr_desconto, " +			                     
			                     		   "       txt_observacao " +			                     			                     
			                     		   "from ORCAMENTOS " +
			                     		   "where cod_fornecedor='" + fornecedor + "' and " +
				                 		   "      dat_orcamento='" + data.ToString("M/d/yyyy") + "' and " +
				                 		   "      cod_orcamento=" + orcamento,
			                     		   Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			if (reader.Read())
			{
				cod_cliente = !reader.IsDBNull(0) ? reader.GetString(0).Trim() : "";
				cod_contato = !reader.IsDBNull(1) ? reader.GetString(1).Trim() : "";
				cod_vendedor = !reader.IsDBNull(2) ? reader.GetString(2).Trim() : "";
				cod_consultor = !reader.IsDBNull(3) ? reader.GetString(3).Trim() : "";
				vlr_orcamento = !reader.IsDBNull(4) ? reader.GetFloat(4) : 0F;;
				vlr_desconto = !reader.IsDBNull(5) ? reader.GetFloat(5) : 0F;
				txt_observacao = !reader.IsDBNull(6) ? reader.GetString(6).Trim() : "";
			}
			else
			{
				cod_cliente = "";
				cod_contato = "";
				cod_vendedor = "";
				cod_consultor = "";
				vlr_orcamento = 0F;
				vlr_desconto = 0F;				
				txt_observacao = "";
			}
			reader.Close();
		}

		public void DadosAreas(string fornecedor, DateTime data, int orcamento, string formula, bool pedido, string formula_orcamento, ref cOrcamentoPDF pdf, bool consolidar_item)
		{
			string cod_area="";
			string salva_area=".";			
			string order;
			if (!consolidar_item)
				order = "order by a.cod_area,a.cod_fornecedor,a.dat_orcamento,a.cod_orcamento,a.seq_item";
			else
				order = "order by a.cod_fornecedor,a.dat_orcamento,a.cod_orcamento,a.cod_produto,a.sub_codigo,a.cod_especificos";
			FbCommand cmd =  new FbCommand("select a.cod_area, " +
			                     "       a.seq_item, " +
			                     "       a.qtd_item, " +
			                     "       a.cod_produto, " +
			                     "       a.sub_codigo, " +
			                     "       a.des_medidas, " +			                     
			                     "       a.idt_especial, " +			                     			                     
			                     "       a.vlr_preco, " +			                     
			                     "       b.per_ipi, " +                    			                     
			                     "       a.des_produto, " +
			                     "       a.txt_produto," +
			                     "       a.cod_especificos," +
			                     "       o.cod_caracteristica " +
			                     "from ITENS a, PRODUTOS b, orcamentos o " +
			                     "where a.cod_fornecedor='" + fornecedor + "' and " +
				                 "      a.dat_orcamento='" + data.ToString("M/d/yyyy") + "' and " +
				                 "      a.cod_orcamento=" + orcamento + " and " +
				         		 "      a.cod_fornecedor=b.cod_parceiro and " +
				         		 "      a.cod_produto=b.cod_produto and " +
				         		 "      a.sub_codigo=b.sub_codigo and " +		
			             		 "      o.cod_fornecedor=a.cod_fornecedor and " +
				         		 "      o.dat_orcamento=a.dat_orcamento and " +
				         		 "      o.cod_orcamento=a.cod_orcamento " +				         		 
				                 order,
			                     Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			Area area=null;
			
			if (consolidar_item) 
			{
				area = new Area();
				area.codigo = "";
			}
			while (reader.Read())
			{
				cod_area = !reader.IsDBNull(0) ? reader.GetString(0).Trim() : "";
				if (!consolidar_item && !cod_area.Equals(salva_area))
				{
					if (area != null)
						pdf.areas.Add(area);
					area = new Area();
					area.codigo = cod_area;
					salva_area = cod_area;
				}
				Item item = new Item();
				item.seq = (short)(!reader.IsDBNull(1) ? (int)reader.GetInt16(1) : 0);
				item.qtde = (short)(!reader.IsDBNull(2) ? (int)reader.GetInt16(2) : 0);
				item.codigo = !reader.IsDBNull(3) ? reader.GetString(3).Trim() : "";
				item.subcodigo = !reader.IsDBNull(4) ? reader.GetString(4).Trim() : "";
				item.medidas = !reader.IsDBNull(5) ? reader.GetString(5).Trim() : "";
				string especial = !reader.IsDBNull(6) ? reader.GetString(6).Trim() : "N";
				item.vlr_unitario = !reader.IsDBNull(7) ? reader.GetFloat(7) : 0;
				item.vlr_semipi = item.vlr_unitario;
				float ipi = !reader.IsDBNull(8) ? reader.GetFloat(8) : 0;
				item.descricao = !reader.IsDBNull(9) ? reader.GetString(9).Trim() : "";
				item.texto = !reader.IsDBNull(10) ? reader.GetString(10).Trim() : "";
				item.especificos = !reader.IsDBNull(11) ? reader.GetString(11).Trim() : "";
				string caracteristica = !reader.IsDBNull(12) ? reader.GetString(12).Trim() : "";
				float per_frete = cCaracteristicas.Frete(fornecedor, caracteristica);
				if (especial.CompareTo("S") != 0)
				{
					Globais.CalculaFormula(ref item.vlr_unitario, formula, ipi, per_frete, 0);
					Globais.CalculaFormula(ref item.vlr_semipi, formula, 0, per_frete, 0);
				}
				else
				{
					if (pedido)
					{
						float preco = item.vlr_unitario;
						float semipi = item.vlr_unitario;
						// desfaz formula
						Globais.DesfazFormula(ref preco, formula_orcamento, ipi, per_frete, 0);
						Globais.DesfazFormula(ref semipi, formula_orcamento, 0, per_frete, 0);
						/*
						float fator=0;
						for (int i=formula_orcamento.Trim().Length-4; i>=0; i-=4)
						{
							if (formula_orcamento[i] == 'x')
							{
								fator = (Globais.StrToFloat(formula.Substring(i+1, 3)) - 1) * 100;
							}
							if (formula_orcamento.Substring(i, 4).CompareTo("+IPI") == 0)
							{
								fator = ipi;
							}
							else
							{
								fator = Globais.StrToFloat(formula_orcamento.Substring(i, 4));
							}
							preco = (preco * 100) / (100 + fator);
						}
						*/
						// refaz parte do pedido
						Globais.CalculaFormula(ref preco, formula, ipi, per_frete, 0);
						Globais.CalculaFormula(ref semipi, formula, 0, per_frete, 0);
						/*
						for (int i=0; i<formula.Trim().Length; i+=4)
						{
							if (formula[i] == 'x')
							{
								fator = Globais.StrToFloat(formula.Substring(i+1, 3));
								preco *= fator;
								continue;
							}
							if (formula.Substring(i, 4).CompareTo("+IPI") == 0)
							{
								fator = ipi;
								preco += (preco * fator / (float)100);
							}
							else
							{
								fator = Globais.StrToFloat(formula.Substring(i, 4));
								preco += (preco * fator / (float)100);
							}
						}
						*/
						item.vlr_unitario = preco;
						item.vlr_semipi = semipi;
					}
				}
				item.imagem = "imagens\\" + item.codigo + item.subcodigo + ".jpg";
				item.ipi = ipi;
				if (consolidar_item && (area.itens.Count > 0))
				{
					Item anterior = (Item)area.itens[area.itens.Count-1];
					if (anterior.codigo.Equals(item.codigo) &&
					    anterior.subcodigo.Equals(item.subcodigo) &&
					    anterior.especificos.Equals(item.especificos))
					{
						anterior.qtde += item.qtde;
					}
					else
					{
						area.itens.Add(item);
					}					
				}
				else
				{
					area.itens.Add(item);
				}
			}
			if (area != null)
				pdf.areas.Add(area);
			reader.Close();
		}
				
		public bool Gera(cOrcamentoPDF pdf_orcamento, string fornecedor, DateTime data, int orcamento, string arquivo, string formula, bool imagens, bool resumida, bool detalhada, bool endereco_filial, bool mostrar_valores, bool consolidar_item)
		{
			string cod_cliente="";
			string cod_contato="";
			string cod_vendedor="";			
			string cod_consultor="";
			float vlr_orcamento=0;
			float vlr_desconto=0;
			string txt_observacao="";
			DadosOrcamento(fornecedor, data, orcamento, ref cod_cliente, ref cod_contato, ref cod_consultor, ref cod_vendedor, ref vlr_orcamento, ref vlr_desconto, ref txt_observacao);
			//cOrcamentoPDF pdf_orcamento = new cOrcamentoPDF();
			pdf_orcamento.valor = vlr_orcamento;
			pdf_orcamento.desconto = vlr_desconto;
			pdf_orcamento.observacao = txt_observacao;
			pdf_orcamento.cab1 = DadosCabecalho1(orcamento, data, endereco_filial, fornecedor);
			pdf_orcamento.cab2 = DadosCabecalho2(fornecedor, cod_cliente, cod_contato, cod_vendedor, cod_consultor);
			DadosAreas(fornecedor, data, orcamento, formula, false, "", ref pdf_orcamento, consolidar_item);
			pdf_orcamento.Gera(arquivo, imagens, resumida, detalhada, mostrar_valores);
			return true;
		}
		
		public bool Lista(DataGridView dgv, bool bFornecedor, bool bData, bool bCod, bool bVendedor, bool bCliente, bool bConsultor, bool bSituacao, bool bValor, bool bSinal, bool bOrdenarCaracteristica)
		{
			string col_sorted = dgv.SortedColumn != null ? dgv.SortedColumn.HeaderText : null;
			if (bOrdenarCaracteristica)
				Grid.Sort(dgv, "Característica", SortOrder.Ascending);
			
			int cols=0;
			if (bFornecedor) cols += 2;
			if (bData) cols += 2;
			if (bCod) cols += 1;
			if (bVendedor) cols += 2;
			if (bCliente) cols += 2;
			if (bConsultor) cols += 2;
			if (bSituacao) cols += 2;
			if (bValor) cols += 2;
			if (bSinal) cols += 1;
			PDF pdf = new PDF("orcamentos.pdf");
			pdf.Abre();
			
			pdf.CriaTabela(2, 0);
			pdf.AdicionaCelula("imagens\\logo_rel.jpg", 1000, 1000);
			pdf.AdicionaCelula("Listagem de Orçamentos", BaseFont.HELVETICA_BOLD, 16);
			pdf.AdicionaTabela();
			
			pdf.CriaTabela(cols, 0);
			if (bFornecedor) pdf.AdicionaCelula("Fornecedor", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, 2);
			if (bData) pdf.AdicionaCelula("Data", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, 2);
			if (bCod) pdf.AdicionaCelula("Cod", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, 1);
			if (bVendedor) pdf.AdicionaCelula("Vendedor", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, 2);
			if (bCliente) pdf.AdicionaCelula("Cliente", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, 2);
			if (bConsultor) pdf.AdicionaCelula("Consultor", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, 2);
			if (bSituacao) pdf.AdicionaCelula("Situação", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, 2);
			if (bValor) pdf.AdicionaCelula("Valor", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 2);
			if (bSinal) pdf.AdicionaCelula("Sinal", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, 1);
			
																					
			double total=0;
			double total_caracteristica=0;
			string ultima_caracteristica = "";
			foreach (DataGridViewRow row in dgv.Rows)
			{
				if (bOrdenarCaracteristica && !ultima_caracteristica.Equals(row.Cells["Característica"].Value.ToString()))
				{
					if (total_caracteristica > 0)
					{
						pdf.AdicionaCelula("Total " + ultima_caracteristica, BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, 4);						
						pdf.AdicionaCelula("", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, bSinal ? cols - 7 : cols - 6);
						pdf.AdicionaCelula(total_caracteristica.ToString("#,###,##0.00"), BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 2);	
						if (bSinal) pdf.AdicionaCelula("", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, 1);							
						total_caracteristica = 0;
					}
					ultima_caracteristica = row.Cells["Característica"].Value.ToString();
					pdf.AdicionaCelula("Característica de venda: " + row.Cells["Característica"].Value.ToString(), BaseFont.HELVETICA_BOLD, 6, Element.ALIGN_LEFT, cols);
				}
				if (bFornecedor) pdf.AdicionaCelula(row.Cells["Fornecedor"].Value.ToString(), BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 2);
				if (bData) pdf.AdicionaCelula(DateTime.Parse(row.Cells["Data"].Value.ToString()).ToString("d/M/yyyy"), BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 2);
				if (bCod) pdf.AdicionaCelula(row.Cells["Cod"].Value.ToString(), BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 1);
				if (bVendedor) pdf.AdicionaCelula(row.Cells["Vendedor"].Value.ToString(), BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 2);
				if (bCliente) pdf.AdicionaCelula(row.Cells["Cliente"].Value.ToString(), BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 2);
				if (bConsultor) pdf.AdicionaCelula(row.Cells["Consultor"].Value.ToString(), BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 2);
				if (bSituacao) pdf.AdicionaCelula(row.Cells["Situação"].Value.ToString(), BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 2);
				if (bValor) 
				{
					double editado=0;
					double.TryParse(row.Cells["Valor"].Value.ToString(), out editado);
					pdf.AdicionaCelula(editado.ToString("#,###,##0.00"), BaseFont.HELVETICA, 6, Element.ALIGN_RIGHT, 2);
				}
				if (bSinal) pdf.AdicionaCelula(row.Cells["Sinal"].Value.ToString(), BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 1);
				if (bValor) 
				{
					total += double.Parse(row.Cells["Valor"].Value.ToString());
					total_caracteristica += double.Parse(row.Cells["Valor"].Value.ToString());
				}
			}
			
			if (bValor) 
			{
				if (bOrdenarCaracteristica && (total_caracteristica > 0))
				{
					pdf.AdicionaCelula("Total " + ultima_caracteristica, BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, 4);						
					pdf.AdicionaCelula("", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, bSinal ? cols - 7 : cols - 6);
					pdf.AdicionaCelula(total_caracteristica.ToString("#,###,##0.00"), BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 2);	
					if (bSinal) pdf.AdicionaCelula("", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, 1);							
					total_caracteristica = 0;
				}				
				pdf.AdicionaCelula("Total", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, 2);						
				pdf.AdicionaCelula("", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, bSinal ? cols - 5 : cols - 4);
				pdf.AdicionaCelula(total.ToString("#,###,##0.00"), BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 2);	
				if (bSinal) pdf.AdicionaCelula("", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, 1);	
			}
			
			pdf.AdicionaTabela();			
			pdf.Fecha();
			
			if (bOrdenarCaracteristica && (col_sorted != null))
				Grid.Sort(dgv, col_sorted, dgv.SortOrder);
			return true;
		}
		
		public void CarregaAnexos(DataGridView grid, string fornecedor, DateTime data, int orcamento)
		{
			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			adapter.SelectCommand = new FbCommand("select COD_ANEXO," +
												  "       DES_ARQ_ANEXO " +			                                      			                                      			                                      
			                                      "from ANEXOS_ORCAMENTO " +
			             				  		  "where cod_fornecedor='" + fornecedor + "' and " +
				         				  		  "      dat_orcamento='" + data.ToString("M/d/yyyy") + "' and " +
				         				   		  "      cod_orcamento=" + orcamento + " " +
			                                      "order by COD_ANEXO",
			                                      Globais.bd);
			adapter.Fill(table);			
			table.Columns[0].ColumnName = "Código";
			table.Columns[1].ColumnName = "Arquivo";
			grid.DataSource = table;
		}
		
		public string CarregaAnexo(string fornecedor, DateTime data, int orcamento, string codigo)
		{
			Byte[] conteudo;
			FileStream fs = null;
			FbCommand cmd = new FbCommand("select des_conteudo,des_arq_anexo from anexos_orcamento " +
			             				  "where cod_fornecedor='" + fornecedor + "' and " +
				         				  "      dat_orcamento='" + data.ToString("M/d/yyyy") + "' and " +
				         				  "      cod_orcamento=" + orcamento + " and " +				         				  
                          				  "      COD_ANEXO='" + codigo + "'",
			                              Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			if (!reader.Read()) return null;
			string arq = reader.GetString(1).Trim();
			string ext="";
			int i = arq.LastIndexOf('.');
			if (i > 0)
			{
				ext = arq.Substring(i, arq.Length-i);
			}
			conteudo = new Byte[(reader.GetBytes(0, 0, null, 0, int.MaxValue))];
			reader.GetBytes(0, 0, conteudo, 0, conteudo.Length);
			reader.Close();
			//fs = new FileStream("tmp_" + codigo + ext, FileMode.Create, FileAccess.Write); 
			fs = new FileStream("anexo"+orcamento.ToString()+codigo + ext, FileMode.Create, FileAccess.Write);
			fs.Write(conteudo, 0, conteudo.Length);
			fs.Close();
			//return "tmp_" + codigo + ext;
			return "anexo"+orcamento.ToString()+codigo + ext;
		}
		
		public bool IncluiAnexo(string fornecedor, DateTime data, int cod_orcamento,
		                   string codigo, string arquivo,
		                   ref string msg)
		{
			
			FileStream fs = new FileStream(arquivo, FileMode.OpenOrCreate, FileAccess.Read);
			byte[] conteudo= new byte[fs.Length];
			fs.Read(conteudo, 0, System.Convert.ToInt32(fs.Length));
			fs.Close();

			string sql = "insert into ANEXOS_ORCAMENTO values(" +
						 "'"  + fornecedor + "'," +								
						 "'"  + data.ToString("M/d/yyyy") + "'," +
						 cod_orcamento + "," +								
						 "'"  + codigo + "'," +				
						 "'"  + arquivo + "', ?)";
				
			FbCommand cmd = new FbCommand(sql, Globais.bd);
			FbParameter prm = cmd.Parameters.Add("blob", FbDbType.Binary, conteudo.Length);
			prm.Direction = ParameterDirection.Output;
			prm.Value = conteudo;
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
		
		public bool ExcluiAnexo(string fornecedor, DateTime data, int cod_orcamento, string codigo, ref string msg)
		{
			string sql = "delete from ANEXOS_ORCAMENTO " +
				    	 "where COD_FORNECEDOR='" + fornecedor + "' and " +
                         "      DAT_ORCAMENTO='" + data.ToString("M/d/yyyy") + "' and " +
                         "      COD_ORCAMENTO=" + cod_orcamento + " and " +
                         "      COD_ANEXO='" + codigo + "'";
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

		
		// Calcula o sinal indicador do orcamento
		public float CalculaSinal(string cod_fornecedor, string cod_caracteristica,
		                          float vlr_itens, float vlr_desconto, float per_consultor, float limiar)
		{
			cCaracteristicas caracteristica = new cCaracteristicas();
			//float limiar = caracteristica.Limiar(cod_fornecedor, cod_caracteristica);
			float per_desconto = (vlr_itens > 0) ? vlr_desconto * 100f / vlr_itens : 0;
			//float per_consultor = (vlr_itens > 0) ? vlr_consultor * 100f / vlr_itens : 0;
			float sinal = limiar - per_desconto - per_consultor;
			if ((sinal > -0.001f) && (sinal < 0.001f)) sinal = 0;
			return sinal;
		}
		
		public void OrdenaItens()
		{
			string salva_fornecedor, fornecedor;
			DateTime salva_data, data;
			short salva_orcamento, orcamento;
			short seq=-1, seq_item;
			string area;
			FbCommand cmd =  new FbCommand("select COD_FORNECEDOR, DAT_ORCAMENTO, COD_ORCAMENTO, COD_AREA, SEQ_ITEM " +
			                               "from ITENS " +
							               "order by COD_FORNECEDOR, DAT_ORCAMENTO, COD_ORCAMENTO, COD_AREA, SEQ_ITEM",
			                               Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			salva_fornecedor = "";
			salva_data = DateTime.Now.Date;
			salva_orcamento = -1;
			while (reader.Read())
			{
				fornecedor = reader.GetString(0).Trim();
				data = reader.GetDateTime(1);
				orcamento = reader.GetInt16(2);
				area = reader.GetString(3);
				seq_item = reader.GetInt16(4);
				if ((fornecedor.CompareTo(salva_fornecedor) != 0) ||
				    (data != salva_data) || 
				    (orcamento != salva_orcamento)) {
					salva_fornecedor = fornecedor;
					salva_data = data;
					salva_orcamento = orcamento;
					seq = 1;					
				}
				else seq++;
			
				string sql = "update ITENS set SEQ_ITEM=" + seq.ToString() + " " +
							 "where COD_FORNECEDOR='" + fornecedor + "' and "+
							 "      DAT_ORCAMENTO='" + data.ToString("M/d/yyyy") + "' and " +
							 "      COD_ORCAMENTO=" + orcamento.ToString() + " and " +
							 "      COD_AREA='" + area + "' and " +
							 "      SEQ_ITEM=" + seq_item.ToString();
				FbCommand cmd2 = new FbCommand(sql, Globais.bd);
				try
				{
					Log.Grava(Globais.sUsuario, cmd2.CommandText);
					cmd2.ExecuteNonQuery();
				}
				catch (Exception e)
				{
					Log.Grava(Globais.sUsuario, "erro:" + e.Message);
					string msg = e.Message;
				}
			}
			reader.Close();
		}		

		public void Duplica(string fornecedor, DateTime data, short orcamento, string area, string nova_area) 
		{
			string msg="";
			FbCommand cmd =  new FbCommand("select " +
			             "       cod_produto," +
			             "       sub_codigo," +				
			             "       qtd_item," +
						 "       des_medidas," +
						 "       vlr_preco," +
						 "       idt_especial," +
						 "       vlr_preco_tabela, " +				
					     "       des_produto," +
						 "       txt_produto," +
						 "       cod_especificos " +
			             "from itens " +
			             "where cod_fornecedor='" + fornecedor + "' and " +
				         "      dat_orcamento='" + data.ToString("M/d/yyyy") + "' and " +
				         "      cod_orcamento=" + orcamento + " and " +				
				         "      cod_area='" + area + "'",
				         Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			while (reader.Read())
			{
				string cod_produto = !reader.IsDBNull(0) ? reader.GetString(0).Trim() : "";
				string sub_codigo = !reader.IsDBNull(1) ? reader.GetString(1).Trim() : "";
				short qtd_item = !reader.IsDBNull(2) ? reader.GetInt16(2) : (short)0;
				string des_medidas = !reader.IsDBNull(3) ? reader.GetString(3).Trim() : "";
				float vlr_preco = !reader.IsDBNull(4) ? reader.GetFloat(4) : 0f;
				string idt_especial = !reader.IsDBNull(5) ? reader.GetString(5).Trim() : "";
				float vlr_preco_tabela = !reader.IsDBNull(6) ? reader.GetFloat(6) : 0f;
				string des_produto = !reader.IsDBNull(7) ? reader.GetString(7).Trim() : "";
				string txt_produto = !reader.IsDBNull(8) ? reader.GetString(8).Trim() : "";
				string especificos = !reader.IsDBNull(9) ? reader.GetString(9).Trim() : "";
				IncluiItem(fornecedor, data, orcamento,	nova_area, cod_produto, sub_codigo, qtd_item, des_medidas,
		                       vlr_preco, vlr_preco_tabela, idt_especial, 
		                       des_produto, txt_produto, especificos, ref msg);
			}
			reader.Close();
		}
		
		public ArrayList VerificaEspecificos(string fornecedor, DateTime data, short orcamento)
		{
			ArrayList itens = new ArrayList();
			FbCommand cmd =  new FbCommand("select " +
			             "       cod_produto " +
			             "from itens " +
			             "where cod_fornecedor='" + fornecedor + "' and " +
				         "      dat_orcamento='" + data.ToString("M/d/yyyy") + "' and " +
				         "      cod_orcamento=" + orcamento + " and " +				
				         "      cod_especificos=''",
				         Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			while (reader.Read())
			{
				string cod_produto = !reader.IsDBNull(0) ? reader.GetString(0).Trim() : "";
				itens.Add(cod_produto);
			}
			reader.Close();
			return itens;
		}		
		
		public string Especial(string fornecedor, DateTime data, short orcamento)
		{
			FbCommand cmd = new FbCommand("select 1 from ITENS " +
				 			              "where cod_fornecedor='" + fornecedor + "' and " +
				         				  "      dat_orcamento='" + data.ToString("M/d/yyyy") + "' and " +
				             			  "      cod_orcamento=" + orcamento + " and " +				
				             			  "      idt_especial='S'",
			                              Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			if (reader.Read())
			{
				reader.Close();
				return "S";
			}
			reader.Close();
			return "N";
		}
		
		public bool AlteraStatus(string fornecedor, DateTime data, short orcamento, char status, ref string msg)
		{
			string sql = "update ORCAMENTOS set " +
						 "cod_situacao='" + status + "' " +												
			             "where cod_fornecedor='" + fornecedor + "' and " +
				         "      dat_orcamento='" + data.ToString("M/d/yyyy") + "' and " +
				         "      cod_orcamento=" + orcamento;
			FbCommand cmd2 = new FbCommand(sql, Globais.bd);
			try
			{
				Log.Grava(Globais.sUsuario, cmd2.CommandText);
				cmd2.ExecuteNonQuery();
			}
			catch (Exception e)
			{
				Log.Grava(Globais.sUsuario, "erro:" + e.Message);
				msg = e.Message;
				return false;
			}
			return true;
		}			
		
		public bool AlteraEspecial(string fornecedor, DateTime data, short orcamento, char especial)
		{
			string sql = "update ORCAMENTOS set " +
						 "idt_especial='" + especial + "' " +												
			             "where cod_fornecedor='" + fornecedor + "' and " +
				         "      dat_orcamento='" + data.ToString("M/d/yyyy") + "' and " +
				         "      cod_orcamento=" + orcamento;
			FbCommand cmd2 = new FbCommand(sql, Globais.bd);
			try
			{
				Log.Grava(Globais.sUsuario, cmd2.CommandText);
				cmd2.ExecuteNonQuery();
			}
			catch (Exception)
			{
				return false;
			}
			return true;
		}			
		
		public bool AlteraPedido(string fornecedor, DateTime data, short orcamento, char pedido)
		{
			string sql = "update ORCAMENTOS set " +
						 "idt_pedido='" + pedido + "' " +												
			             "where cod_fornecedor='" + fornecedor + "' and " +
				         "      dat_orcamento='" + data.ToString("M/d/yyyy") + "' and " +
				         "      cod_orcamento=" + orcamento;
			FbCommand cmd2 = new FbCommand(sql, Globais.bd);
			try
			{
				Log.Grava(Globais.sUsuario, cmd2.CommandText);
				cmd2.ExecuteNonQuery();
			}
			catch (Exception)
			{
				return false;
			}
			return true;
		}			
		
		public float Frete(string fornecedor, DateTime data, short orcamento)
		{
			float per_frete=0;
			string sql = "select c.PER_FRETE from orcamentos o " +
				"inner join caracteristicas c on c.COD_FORNECEDOR=o.COD_FORNECEDOR and c.COD_CARACTERISTICA=o.COD_CARACTERISTICA " +
				"where o.cod_fornecedor='" + fornecedor + "' and " +
				"      o.dat_orcamento='" + data.ToString("M/d/yyyy") + "' and " +
				"      o.cod_orcamento=" + orcamento.ToString();
			FbCommand cmd = new FbCommand(sql, Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			if (reader.Read())
				per_frete = reader.IsDBNull(0) ? 0 : reader.GetFloat(0);
			reader.Close();
			return per_frete;
		}					
	}
}
