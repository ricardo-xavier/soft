/*
 * Projeto  : SoftPlace
 * Programa : cCaracteristicas - Classe de Caracteristicas de Venda
 * Autor    : Ricardo Costa Xavier
 * Data     : 31/05/08
 */
using System;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using System.Drawing;
using System.IO;

namespace classes
{
	public class cCaracteristicas
	{
		public cCaracteristicas()
		{
		}
		
		public void Carrega(DataGridView grid, bool ativos)
		{
			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			string where = ativos ? "where IDT_ATIVO='S' " : "";
			adapter.SelectCommand = new FbCommand("select COD_FORNECEDOR," +        // 0
			                                      "       COD_CARACTERISTICA," +    // 1
			                                      "       DES_FORMULA," +           // 2
			                                      "       DES_FORMULA_PEDIDO," +    // 3
			                                      "       PER_CONSULTOR," +         // 4
			                                      "       PER_VENDEDOR," +		    // 5	                                      
			                                      "       PER_LIMIAR," +		    // 6	                                      			                                      
			                                      "       TXT_OBSERVACAO," +        // 7
			                                      "       TXT_RACIONAL," +          // 8
			                                      "       TXT_SERVICO," +           // 9
			                                      "       IDT_ATIVO," +             // 10
			                                      "       QTD_DIAS," +              // 11
			                                      "       DES_DESCONTO_VENPRO," +   // 12
			                                      "       DES_DESCONTO_VENSER," +   // 13
			                                      "       DES_DESCONTO_CONPRO," +   // 14			                                      
			                                      "       DES_DESCONTO_CONSER," +   // 15			                                      
			                                      "       DES_DESCONTO_FILPRO," +   // 16			                                      
			                                      "       DES_DESCONTO_FILSER," +   // 17			                                      			   
			                                      "       PER_FILIAL," +		    // 18	                                      
			                                      "       PER_FRETE," +		    	// 19
			                                      "       COD_INTRODUCAO," +	   	// 20			                                      
			                                      "       COD_INFORMACAO_FORNECIMENTO," + // 21
			                                      "       COD_TERMO_GARANTIA," +	// 22
			                                      "       COD_CONDICAO_MONTAGEM," +	// 23                
			                                      "       COD_TERMO_APROVACAO," +	// 24
			                                      "       IDT_IPI " +	            // 25
			                                      "from CARACTERISTICAS " + 
			                                      where +
			                                      "order by COD_FORNECEDOR,COD_CARACTERISTICA", 
			                                      Globais.bd);
			adapter.Fill(table);
			table.Columns[0].ColumnName = "Fornecedor";
			table.Columns[1].ColumnName = "Código";
			table.Columns[2].ColumnName = "Fórmula";
			table.Columns[3].ColumnName = "Fórmula Pedido";
			table.Columns[9].ColumnName = "Serviço";
			table.Columns[11].ColumnName = "Dias";
			table.Columns[12].ColumnName = "VenPro";
			table.Columns[13].ColumnName = "VenSer";
			table.Columns[14].ColumnName = "ConPro";
			table.Columns[15].ColumnName = "ConSer";
			table.Columns[16].ColumnName = "FilPro";
			table.Columns[17].ColumnName = "FilSer";
			table.Columns[19].ColumnName = "Frete";
			table.Columns[20].ColumnName = "Introdução";			
			table.Columns[21].ColumnName = "Informação Fornecimento";			
			table.Columns[22].ColumnName = "Termo Garantia";
			table.Columns[23].ColumnName = "Condição Montagem";			
			table.Columns[24].ColumnName = "Termo Aprovação";
			table.Columns[25].ColumnName = "Imprime IPI";			
			grid.DataSource = table;
			grid.Columns[4].Visible = false;
			grid.Columns[5].Visible = false;
			grid.Columns[6].Visible = false;
			grid.Columns[7].Visible = false;
			grid.Columns[8].Visible = false;
			grid.Columns[9].Visible = false;
			grid.Columns[10].Visible = false;
			grid.Columns[11].Visible = false;
			grid.Columns[12].Visible = false;
			grid.Columns[13].Visible = false;
			grid.Columns[14].Visible = false;
			grid.Columns[15].Visible = false;
			grid.Columns[16].Visible = false;
			grid.Columns[17].Visible = false;
			grid.Columns[18].Visible = false;
			grid.Columns[19].Visible = false;
			grid.Columns[20].Visible = false;
			grid.Columns[21].Visible = false;
			grid.Columns[22].Visible = false;
			grid.Columns[23].Visible = false;
			grid.Columns[24].Visible = false;
			grid.Columns[25].Visible = false;			
		}
		
		public void Carrega(ComboBox cbx, string parceiro)
		{
			string codigo;
			FbCommand cmd =  new FbCommand("select COD_CARACTERISTICA " +
			                               "from CARACTERISTICAS " +
				    	 				   "where COD_FORNECEDOR='" + parceiro + "' and IDT_ATIVO='S' " +			                               
			                               "order by COD_CARACTERISTICA", 
			                               Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			while (reader.Read())
			{
				codigo = reader.GetString(0).Trim();
				cbx.Items.Add(codigo);
			}
			reader.Close();
		}	
		
		public string Observacao(string parceiro, string codigo)
		{
			string observacao="";
			FbCommand cmd =  new FbCommand("select TXT_OBSERVACAO " +
			                               "from CARACTERISTICAS " +
				    	 				   "where COD_FORNECEDOR='" + parceiro + "' and " +			                               
				    	 				   "      COD_CARACTERISTICA='" + codigo + "'",
			                               Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			if (reader.Read())
			{
				observacao = reader.GetString(0).Trim();
			}
			reader.Close();
			return observacao;
		}		
		
		public string Formula(string parceiro, string codigo)
		{
			string formula="";
			FbCommand cmd =  new FbCommand("select DES_FORMULA " +
			                               "from CARACTERISTICAS " +
				    	 				   "where COD_FORNECEDOR='" + parceiro + "' and " +			                               
				    	 				   "      COD_CARACTERISTICA='" + codigo + "'",
			                               Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			if (reader.Read())
			{
				formula = reader.GetString(0).Trim();
			}
			reader.Close();
			return formula;
		}		
		
		public string FormulaPedido(string parceiro, string codigo, ref bool destacar_ipi)
		{
			string formula="", formula_pedido="";
			FbCommand cmd =  new FbCommand("select DES_FORMULA,DES_FORMULA_PEDIDO,IDT_IPI " +
			                               "from CARACTERISTICAS " +
				    	 				   "where COD_FORNECEDOR='" + parceiro + "' and " +			                               
				    	 				   "      COD_CARACTERISTICA='" + codigo + "'",
			                               Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			if (reader.Read())
			{
				formula = reader.GetString(0).Trim();
				formula_pedido = reader.GetString(1).Trim();
				if (formula_pedido.Length == 0)
				{
					formula_pedido = formula;
				}
				destacar_ipi = !reader.GetString(2).Trim().Equals("N");
			}
			reader.Close();
			return formula_pedido;
		}		
		
		public void FormulasComissao(string parceiro, string codigo, ref string venpro, ref string venser, ref string conpro, ref string conser, ref string filpro, ref string filser)
		{
			FbCommand cmd =  new FbCommand("select " +
											"DES_DESCONTO_VENPRO," +
											"DES_DESCONTO_VENSER," +
											"DES_DESCONTO_CONPRO," +
											"DES_DESCONTO_CONSER," +
											"DES_DESCONTO_FILPRO," +
											"DES_DESCONTO_FILSER " +
											"from CARACTERISTICAS " +
											"where COD_FORNECEDOR='" + parceiro + "' and " +			                               
											"      COD_CARACTERISTICA='" + codigo + "'",
											Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			if (reader.Read())
			{
				venpro = reader.GetString(0).Trim();
				venser = reader.GetString(1).Trim();
				conpro = reader.GetString(2).Trim();
				conser = reader.GetString(3).Trim();
				filpro = reader.GetString(4).Trim();
				filser = reader.GetString(5).Trim();
			}
			reader.Close();
		}		
		
		public float DiferencaFormulas(string fornecedor, string caracteristica, DateTime data, short orcamento, ref string servico)
		{
			string formula="", formula_pedido="";
			float total_orcamento=0, total_pedido=0;
			FbCommand cmd =  new FbCommand("select DES_FORMULA,DES_FORMULA_PEDIDO,TXT_SERVICO " +
			                               "from CARACTERISTICAS " +
				    	 				   "where COD_FORNECEDOR='" + fornecedor + "' and " +			                               
				    	 				   "      COD_CARACTERISTICA='" + caracteristica + "'",
			                               Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			if (reader.Read())
			{
				formula = !reader.IsDBNull(0) ? reader.GetString(0).Trim() : "";
				formula_pedido = !reader.IsDBNull(1) ? reader.GetString(1).Trim() : "";
				servico = !reader.IsDBNull(2) ? reader.GetString(2).Trim() : "";
			}
			reader.Close();
			if (formula_pedido.Length == 0) return 0f;
			if (formula_pedido.CompareTo(formula) == 0) return 0f;
			
			string sql = "select " +
			             "       a.cod_produto," +
			             "       a.sub_codigo," +				
			             "       a.qtd_item," +
						 "       a.vlr_preco," +
						 "       a.vlr_preco_tabela, " +				
						 "       a.idt_especial," +				
						 "       b.per_ipi " +
			             "from itens a, produtos b " +
			             "where a.cod_fornecedor='" + fornecedor + "' and " +
				         "      a.dat_orcamento='" + data.ToString("M/d/yyyy") + "' and " +
				         "      a.cod_orcamento=" + orcamento + " and " +				
				         "      a.cod_fornecedor=b.cod_parceiro and " +
				         "      a.cod_produto=b.cod_produto and " +
				         "      a.sub_codigo=b.sub_codigo " +								
			             "order by a.cod_area,a.seq_item";
			
			cmd =  new FbCommand(sql, Globais.bd);
			reader = cmd.ExecuteReader(CommandBehavior.Default);
			string codigo;
			string sub_codigo;
			short qtd;
			float preco_unitario;
			float preco_tabela;
			bool especial;
			float ipi;
			//float fator;
			//float preco;
			while (reader.Read())
			{
				float valor_orcamento=0, valor_pedido=0;				
				codigo = reader.GetString(0).Trim();
				sub_codigo = reader.GetString(1).Trim();
				qtd = reader.GetInt16(2);
				preco_unitario = reader.GetFloat(3) * qtd;
				preco_tabela = reader.GetFloat(4) * qtd;
				especial = reader.GetString(5).Trim().CompareTo("S") == 0;;
				ipi = reader.GetFloat(6);
				if (especial)
				{
					// desfaz formula
					preco_tabela = preco_unitario;
					Globais.DesfazFormula(ref preco_tabela, formula, ipi, 0, 0);
					/*
					for (int i=formula.Trim().Length-4; i>=0; i-=4)
					{
						if (formula[i] == 'x')
						{
							fator = (Globais.StrToFloat(formula.Substring(i+1, 3)) - 1) * 100;
						}
						if (formula.Substring(i, 4).CompareTo("+IPI") == 0)
						{
							fator = ipi;
						}
						else
						{
							fator = Globais.StrToFloat(formula.Substring(i, 4));
						}
						preco_tabela = (preco_tabela * 100) / (100 + fator);
					}
					*/
				}
				//if (!especial)
				//{
					valor_orcamento = preco_tabela;
					valor_pedido = preco_tabela;
					float per_frete = cCaracteristicas.Frete(fornecedor, caracteristica);
					Globais.CalculaFormula(ref valor_orcamento, formula, ipi, per_frete, 0);
					/*
					for (int i=0; i<formula.Trim().Length; i+=4)
					{
						if (formula[i] == 'x')
						{
							fator = Globais.StrToFloat(formula.Substring(i+1, 3));
							valor_orcamento *= fator;
							continue;
						}
						if (formula.Substring(i, 4).CompareTo("+IPI") == 0)
						{
							fator = ipi;
							valor_orcamento += (valor_orcamento * fator / (float)100);
						}
						else
						{
							fator = Globais.StrToFloat(formula.Substring(i, 4));
							valor_orcamento += (valor_orcamento * fator / (float)100);
						}
					}
					*/
					Globais.CalculaFormula(ref valor_pedido, formula_pedido, ipi, per_frete, 0);
					/*
					for (int i=0; i<formula_pedido.Trim().Length; i+=4)
					{
						if (formula_pedido[i] == 'x')
						{
							fator = Globais.StrToFloat(formula_pedido.Substring(i+1, 3));
							valor_pedido *= fator;
							continue;
						}
						if (formula_pedido.Substring(i, 4).CompareTo("+IPI") == 0)
						{
							fator = ipi;
							valor_pedido += (valor_pedido * fator / (float)100);
						}
						else
						{
							fator = Globais.StrToFloat(formula_pedido.Substring(i, 4));
							valor_pedido += (valor_pedido * fator / (float)100);
						}
					}
					*/
/*					
				}
				else
				{
					preco = preco_unitario;
					valor_orcamento += preco;
					valor_pedido += preco;
				}
*/				
				total_orcamento += valor_orcamento;
				total_pedido += valor_pedido;
			}
			reader.Close();
			return total_orcamento-total_pedido;
		}		
		
		public float Limiar(string parceiro, string codigo)
		{
			float limiar=0;
			FbCommand cmd =  new FbCommand("select PER_LIMIAR " +
			                               "from CARACTERISTICAS " +
				    	 				   "where COD_FORNECEDOR='" + parceiro + "' and " +			                               
				    	 				   "      COD_CARACTERISTICA='" + codigo + "'",
			                               Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			if (reader.Read())
			{
				limiar = reader.GetFloat(0);
			}
			reader.Close();
			return limiar;
		}		
		
		public short DiasMontagem(string parceiro, string codigo)
		{
			short dias=0;
			FbCommand cmd =  new FbCommand("select QTD_DIAS " +
			                               "from CARACTERISTICAS " +
				    	 				   "where COD_FORNECEDOR='" + parceiro + "' and " +			                               
				    	 				   "      COD_CARACTERISTICA='" + codigo + "'",
			                               Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			if (reader.Read())
			{
				dias = reader.GetInt16(0);
			}
			reader.Close();
			return dias;
		}		
		
		public float Comissao(string parceiro, string codigo)
		{
			float comissao=0;
			FbCommand cmd =  new FbCommand("select PER_VENDEDOR " +
			                               "from CARACTERISTICAS " +
				    	 				   "where COD_FORNECEDOR='" + parceiro + "' and " +			                               
				    	 				   "      COD_CARACTERISTICA='" + codigo + "'",
			                               Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			if (reader.Read())
			{
				comissao = reader.GetFloat(0);
			}
			reader.Close();
			return comissao;
		}		
		
		public float ComissaoConsultor(string parceiro, string codigo)
		{
			float comissao=0;
			FbCommand cmd =  new FbCommand("select PER_CONSULTOR " +
			                               "from CARACTERISTICAS " +
				    	 				   "where COD_FORNECEDOR='" + parceiro + "' and " +			                               
				    	 				   "      COD_CARACTERISTICA='" + codigo + "'",
			                               Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			if (reader.Read())
			{
				comissao = reader.GetFloat(0);
			}
			reader.Close();
			return comissao;
		}		

		public bool Inclui(string parceiro, string codigo, string formula, string formula_pedido, float consultor, float vendedor, float filial, float limiar, string observacao, string racional, string servico, string ativo, short dias, string venpro, string venser, string conpro, string conser, string filpro, string filser, float frete, 
		                   string introducao, string informacao_fornecimento, string termo_garantia,  string condicao_montagem, string termo_aprovacao,
		                   string idt_ipi, ref string msg)
		{
			string sconsultor = consultor.ToString().Replace(',', '.');
			string svendedor = vendedor.ToString().Replace(',', '.');
			string sfilial = filial.ToString().Replace(',', '.');
			string slimiar = limiar.ToString().Replace(',', '.');
			string sfrete = frete.ToString().Replace(',', '.');
			string sql = "insert into CARACTERISTICAS values(" +
						 "'"  + parceiro + "'," +				
						 "'"  + codigo + "'," +
						 "'"  + formula + "'," +
						 sconsultor + "," +				
						 svendedor + "," +
						 slimiar + "," +				
						 "@observacao," +
						 "@racional," +
						 "'" + ativo + "'," +
						 "'"  + formula_pedido + "'," +				
						 "'"  + servico + "'," +
						 dias + "," +
						 "'"  + venpro + "'," +
						 "'"  + venser + "'," +
						 "'"  + conpro + "'," +
						 "'"  + conser + "'," +
						 "'"  + filpro + "'," +
						 "'"  + filser + "'," +
						 svendedor + "," +
						 sfrete + "," +
						 "'"  + introducao + "'," +
						 "'"  + informacao_fornecimento + "'," +
						 "'"  + termo_garantia + "'," +
						 "'"  + condicao_montagem + "'," +
						 "'"  + termo_aprovacao + "'," +
						 "'"  + idt_ipi + "'" +				
						 ")";
			FbCommand cmd = new FbCommand(sql, Globais.bd);
			try
			{
				cmd.Parameters.Add("@observacao", FbDbType.VarChar, 4000);
				cmd.Parameters.Add("@racional", FbDbType.VarChar, 4000);
				cmd.Parameters["@observacao"].Value = observacao;
				cmd.Parameters["@racional"].Value = racional;
				cmd.Prepare();
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
		
		public bool Altera(string parceiro, string codigo, string formula, string formula_pedido, float consultor, float vendedor, float filial, float limiar, string observacao, string racional, string servico, string ativo, short dias, string venpro, string venser, string conpro, string conser, string filpro, string filser, float frete, 
		                   string introducao, string informacao_fornecimento, string termo_garantia,  string condicao_montagem, string termo_aprovacao,
		                   string idt_ipi, ref string msg)
		{
			string sconsultor = consultor.ToString().Replace(',', '.');
			string svendedor = vendedor.ToString().Replace(',', '.');
			string sfilial = filial.ToString().Replace(',', '.');			
			string slimiar = limiar.ToString().Replace(',', '.');
			string sfrete = frete.ToString().Replace(',', '.');			
			string sql = "update CARACTERISTICAS set " +
						 "DES_FORMULA='" + formula + "'," + 
						 "DES_FORMULA_PEDIDO='" + formula_pedido + "'," + 
						 "PER_CONSULTOR=" + sconsultor + "," + 
						 "PER_VENDEDOR=" + svendedor + "," + 				
						 "PER_FILIAL=" + sfilial + "," + 								
						 "PER_LIMIAR=" + slimiar + "," + 								
						 "TXT_OBSERVACAO=@observacao," + 
						 "TXT_RACIONAL=@racional," + 
						 "TXT_SERVICO='" + servico + "'," + 
						 "IDT_ATIVO='" + ativo + "'," + 
						 "QTD_DIAS=" + dias + "," + 				
						 "DES_DESCONTO_VENPRO='" + venpro + "'," + 
						 "DES_DESCONTO_VENSER='" + venser + "'," + 
						 "DES_DESCONTO_CONPRO='" + conpro + "'," + 
						 "DES_DESCONTO_CONSER='" + conser + "'," + 
						 "DES_DESCONTO_FILPRO='" + filpro + "'," + 
						 "DES_DESCONTO_FILSER='" + filser + "'," + 
						 "PER_FRETE=" + sfrete + "," + 			
						 "COD_INTRODUCAO='" + introducao + "'," +
						 "COD_INFORMACAO_FORNECIMENTO='" + informacao_fornecimento + "'," +
						 "COD_TERMO_GARANTIA='" + termo_garantia + "'," +
						 "COD_CONDICAO_MONTAGEM='" + condicao_montagem + "'," +
						 "COD_TERMO_APROVACAO='" + termo_aprovacao + "'," +
						 "IDT_IPI='" + idt_ipi + "' " +				
				    	 "where COD_FORNECEDOR='" + parceiro + "' and " +
				    	 "      COD_CARACTERISTICA='" + codigo + "'";
			FbCommand cmd = new FbCommand(sql, Globais.bd);
			try
			{
				cmd.Parameters.Add("@observacao", FbDbType.VarChar, 4000);
				cmd.Parameters.Add("@racional", FbDbType.VarChar, 4000);
				cmd.Parameters["@observacao"].Value = observacao;
				cmd.Parameters["@racional"].Value = racional;
				cmd.Prepare();
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
			string sql = "delete from CARACTERISTICAS " +
				    	 "where COD_FORNECEDOR='" + parceiro + "' and " +
				    	 "      COD_CARACTERISTICA='" + codigo + "'";
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
		
		public bool Copia(string novo, string parceiro, string codigo, string formula, string formula_pedido, float consultor, float vendedor, float filial, float limiar, string observacao, string racional, string servico, string ativo, short dias, string venpro, string venser, string conpro, string conser, string filpro, string filser, float frete, 
		                  string introducao, string fornecimento, string garantia, string condicao, string aceite, string imprime_ipi, ref string msg)
		{
			string sconsultor = consultor.ToString().Replace(',', '.');
			string svendedor = vendedor.ToString().Replace(',', '.');
			string sfilial = filial.ToString().Replace(',', '.');			
			string slimiar = limiar.ToString().Replace(',', '.');
			string sfrete = frete.ToString().Replace(',', '.');
			string sql = "insert into CARACTERISTICAS values(" +
						 "'"  + parceiro + "'," +				
						 "'"  + novo + "'," +
						 "'"  + formula + "'," +
						 sconsultor + "," +				
						 svendedor + "," +
						 slimiar + "," +				
						 "@observacao," +
						 "@racional," +
						 "'" + ativo + "'," +
						 "'"  + formula_pedido + "'," +			
						 "'" + servico + "'," +
						 dias + "," + 
						 "'" + venpro + "'," +
						 "'" + venser + "'," +
						 "'" + conpro + "'," +
						 "'" + conser + "'," +
						 "'" + filpro + "'," +
						 "'" + filser + "'," +
						 sfilial + "," +
						 sfrete + "," +
						 "'" + introducao + "'," +
						 "'" + fornecimento + "'," +
						 "'" + garantia + "'," + 
				         "'" + condicao + "'," +
						 "'" + aceite + "'," +
						 "'" + imprime_ipi + "'" +				
						 ")";
			
			FbCommand cmd = new FbCommand(sql, Globais.bd);
			try
			{
				cmd.Parameters.Add("@observacao", FbDbType.VarChar, 4000);
				cmd.Parameters.Add("@racional", FbDbType.VarChar, 4000);
				cmd.Parameters["@observacao"].Value = observacao;
				cmd.Parameters["@racional"].Value = racional;
				cmd.Prepare();
				Log.Grava(Globais.sUsuario, cmd.CommandText);
				cmd.ExecuteNonQuery();				
			}
			catch (Exception err)
			{
				Log.Grava(Globais.sUsuario, "erro:" + err.Message);
				msg = err.Message;
				StreamWriter sw = new StreamWriter(new FileStream("c:\\soft\\soft.log", FileMode.Create));
				sw.WriteLine(sql);
				sw.WriteLine(msg);
				sw.Close();
				return false;
			}
			
			sql = "select QTD_LIMIAR,PER_COMISSAO " +
			             "from COMISSAO_LIMIAR " +
			             "where cod_fornecedor='" + parceiro + "' and " +
						 "      cod_caracteristica='" + codigo + "' " +
			             "order by QTD_LIMIAR";
			cmd = new FbCommand(sql, Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			float comissao=0;
			short qtd_limiar=0;
			cComissaoLimiar comissao_limiar = new cComissaoLimiar();
			while (reader.Read())
			{
				qtd_limiar = reader.GetInt16(0);
				comissao = reader.GetFloat(1);
				comissao_limiar.Inclui(parceiro, novo, qtd_limiar, comissao, ref msg);
			}
			reader.Close();
			
			msg = "OK";
			return true;
		}
	
		public static float Frete(string fornecedor, string caracteristica)
		{
			float per_frete=0;
			string sql = "select PER_FRETE from caracteristicas " +
				"where cod_fornecedor='" + fornecedor + "' and " +
				"      cod_caracteristica='" + caracteristica + "'";
			FbCommand cmd = new FbCommand(sql, Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			if (reader.Read())
				per_frete = reader.IsDBNull(0) ? 0 : reader.GetFloat(0);
			reader.Close();
			return per_frete;
		}				
	}
}
