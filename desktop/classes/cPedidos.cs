/*
 * Projeto  : SoftPlace
 * Programa : cPedidos - Classe de Pedidos
 * Autor    : Ricardo Costa Xavier
 * Data     : 04/02/09
 */
using System;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using System.IO;
using pdf;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace classes
{
	public class cPedidos
	{
		
		public static void AlteraValorInicial(string fornecedor, DateTime data, short orcamento, short codigo, float valor)
		{
			string sql = 
					"update PEDIDOS " +
					"set vlr_inicial="  + valor.ToString().Replace(',','.') + " " +
					"where " +
					"COD_FORNECEDOR='"  + fornecedor + "' and " +				
					"DAT_ORCAMENTO='"  + data.ToString("M/d/yyyy") + "' and " +				
					"COD_ORCAMENTO=" + orcamento + " and " +
					"COD_PEDIDO=" + codigo;
			FbCommand cmd = new FbCommand(sql, Globais.bd);
			try
			{
				Log.Grava(Globais.sUsuario, cmd.CommandText);
				cmd.ExecuteNonQuery();
			}
			catch
			{
			}
		}
			
		public static void CorrigeAgendamentos()
		{
			FbCommand cmd =  new FbCommand("select " +
			                     "a.COD_USUARIO," +
			                     "a.DAT_AGENDAMENTO," +
			                     "a.DAT_PREVISAO," +
			                     "a.DES_PENDENCIA " +
			                     "from agenda a " +
			                     "where a.DES_PENDENCIA like 'Montagem Pedido:%'",
				                 Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			int total=0;
			int erros=0;
			while (reader.Read())
			{
				string COD_USUARIO = reader.GetString(0);
				DateTime DAT_AGENDAMENTO = reader.GetDateTime(1);
				DateTime DAT_PREVISAO = reader.GetDateTime(1);
				string DES_PENDENCIA = reader.GetString(3);
				string[] partes = DES_PENDENCIA.Split(' ');
				if (partes.Length < 6) continue;				
				string COD_FORNECEDOR = partes[2];
				DateTime DAT_ORCAMENTO;
				DateTime.TryParse(partes[3], out DAT_ORCAMENTO);
				if (DAT_ORCAMENTO.Year == 1) continue;
				short COD_ORCAMENTO;
				short.TryParse(partes[4], out COD_ORCAMENTO);
				int NRO_PEDIDO;
				int.TryParse(partes[5], out NRO_PEDIDO);
				total++;
				if (LeAgendamento(COD_FORNECEDOR, DAT_ORCAMENTO, COD_ORCAMENTO, COD_USUARIO, DAT_AGENDAMENTO)) continue;
				erros++;
				IncluiAgendamento(COD_FORNECEDOR, DAT_ORCAMENTO, COD_ORCAMENTO, 1, COD_USUARIO, DAT_AGENDAMENTO, DAT_PREVISAO);
			}
			reader.Close();
			
		}
		
		public static void AlteraSenhas()
		{
			FbCommand cmd =  new FbCommand("select " +
			                     "COD_PARCEIRO,NRO_CPF_CNPJ " +
			                     "from PARCEIROS " +
			                     "where IDT_CLIENTE='S'",
				                 Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			while (reader.Read())
			{
				string COD_PARCEIRO = reader.GetString(0).Trim();
				string NRO_CPF_CNPJ = reader.GetString(1).Trim();
				cCriptografia c = new cCriptografia();
				string senha = c.Criptografa(NRO_CPF_CNPJ);						
				string sql = 
					"insert into WEB (COD_USUARIO,DES_SENHA) values(" +
						"'"  + COD_PARCEIRO + "'," +
						"'"  + senha + "')";
				cmd = new FbCommand(sql, Globais.bd);
				Log.Grava(Globais.sUsuario, cmd.CommandText);
				cmd.ExecuteNonQuery();
			}
			reader.Close();			
		}		
		
		public cPedidos()
		{
		}

		private string MontaWhere(
		                    string fornecedor,
							string vendedor,
							string idt_ou_entrega,
							string idt_nao_entregues,
							short dias_nao_entregues,
							string idt_entrega_previstaI,
							DateTime entrega_previstaI,
							string idt_entrega_previstaF,
							DateTime entrega_previstaF,
							string idt_entrega_realI,
							DateTime entrega_realI,
							string idt_entrega_realF,
							DateTime entrega_realF,
							string idt_ou_montagem,
							string idt_nao_montados,
							short dias_nao_montados,							
							string idt_montagem_previstaI,
							DateTime montagem_previstaI,
							string idt_montagem_previstaF,
							DateTime montagem_previstaF,
							string idt_montagem_realI,
							DateTime montagem_realI,
							string idt_montagem_realF,
							DateTime montagem_realF,
							string cliente,
							string consultor,
							string filtro_dinheiro,
							string filtro_recebidos,
							string _pedido_fornec,
							string _nf_fornec,
							string observacao,
							string idt_dataI,
							DateTime dataI,
							string idt_dataF,
							DateTime dataF,
							string idt_omitir_anos_anteriores,
							string idt_sem_previsao,
							string idt_pendentes_consultor,
							string idt_pendentes_vendedor,
							string idt_cadastroI,
							DateTime cadastroI,
							string idt_cadastroF,
							DateTime cadastroF,
							string vlr_inicial,
							string vlr_final,
							string numero_pedido,
							string caracteristica,
							ref string join)
		{
			string where = "where ";
			join="";
			int pedido_fornec=0;
			int nf_fornec=0;
			int.TryParse(_pedido_fornec, out pedido_fornec);
			int.TryParse(_nf_fornec, out nf_fornec);
			
			if (filtro_dinheiro.Trim().Length > 0)
			{
				where = where + filtro_dinheiro;
			}
			if (idt_pendentes_consultor[0] == 'S')
			{
				where = where + "a.idt_consultor<>'S' and ";
			}				
			if (idt_pendentes_vendedor[0] == 'S')
			{
				where = where + "a.idt_vendedor<>'S' and ";
			}								
			if (fornecedor.Length > 0)
			{
				where = where + "a.cod_fornecedor='" + fornecedor + "' and ";
			}
			if (idt_dataI[0] == 'S')
			{
				where = where + "a.dat_pedido >= '" + dataI.ToString("M/d/yyyy") + "' and ";
			}
			if (idt_dataF[0] == 'S')
			{
				where = where + "a.dat_pedido <= '" + dataF.ToString("M/d/yyyy") + "' and ";
			}				
			if (idt_ou_entrega[0] == 'S')
			{
				where = where + "((";
				where = where + "a.dat_entrega >= '" + entrega_previstaI.ToString("M/d/yyyy") + "' and ";
				where = where + "a.dat_entrega <= '" + entrega_previstaF.ToString("M/d/yyyy") + "'";
				where = where + ") or ";
				where = where + "(";
				where = where + "a.dat_real_entrega >= '" + entrega_realI.ToString("M/d/yyyy") + "' and ";
				where = where + "a.dat_real_entrega <= '" + entrega_realF.ToString("M/d/yyyy") + "'";
				where = where + ")) and ";
			}
			else
			{
				if (idt_entrega_previstaI[0] == 'S')
				{
					where = where + "a.dat_entrega >= '" + entrega_previstaI.ToString("M/d/yyyy") + "' and ";
				}
				if (idt_entrega_previstaF[0] == 'S')
				{
					where = where + "a.dat_entrega <= '" + entrega_previstaF.ToString("M/d/yyyy") + "' and ";
				}
				if ((idt_entrega_previstaI[0] == 'S') || (idt_entrega_previstaF[0] == 'S')) {
					if ((idt_entrega_realI[0] == 'N') && (idt_entrega_realF[0] == 'N') && (idt_nao_entregues[0] == 'N')) {
						where = where + "a.IDT_DAT_REAL_ENTREGA = 'N' and ";
					}
				}
				if (idt_entrega_realI[0] == 'S')
				{
					where = where + "a.dat_real_entrega >= '" + entrega_realI.ToString("M/d/yyyy") + "' and ";
				}
				if (idt_entrega_realF[0] == 'S')
				{
					where = where + "a.dat_real_entrega <= '" + entrega_realF.ToString("M/d/yyyy") + "' and ";
				}
			}
			if (idt_nao_entregues[0] == 'S') {
				dias_nao_entregues *= -1;
				where = where + "a.IDT_DAT_REAL_ENTREGA = 'N' and " +
					"a.dat_entrega <= '" + DateTime.Now.AddDays(dias_nao_entregues).ToString("M/d/yyyy") +
					"' and ";
			}
			if (idt_ou_montagem[0] == 'S')
			{
				where = where + "((";
				where = where + "a.dat_montagem >= '" + montagem_previstaI.ToString("M/d/yyyy") + "' and ";
				where = where + "a.dat_montagem <= '" + montagem_previstaF.ToString("M/d/yyyy") + "'";
				where = where + ") or ";
				where = where + "(";
				where = where + "a.dat_real_montagem >= '" + montagem_realI.ToString("M/d/yyyy") + "' and ";
				where = where + "a.dat_real_montagem <= '" + montagem_realF.ToString("M/d/yyyy") + "'";
				where = where + ")) and ";
			}				
			else
			{
				if (idt_montagem_previstaI[0] == 'S')
				{
					where = where + "a.dat_montagem >= '" + montagem_previstaI.ToString("M/d/yyyy") + "' and ";
				}
				if (idt_montagem_previstaF[0] == 'S')
				{
					where = where + "a.dat_montagem <= '" + montagem_previstaF.ToString("M/d/yyyy") + "' and ";
				}
				if ((idt_montagem_previstaI[0] == 'S') || (idt_montagem_previstaF[0] == 'S')) {
					if ((idt_montagem_realI[0] == 'N') && (idt_montagem_realF[0] == 'N') && (idt_nao_montados[0] == 'N')) {
						where = where + "a.IDT_DAT_REAL_MONTAGEM = 'N' and ";
					}
				}					
				if (idt_montagem_realI[0] == 'S')
				{
					where = where + "a.dat_real_montagem >= '" + montagem_realI.ToString("M/d/yyyy") + "' and ";
				}
				if (idt_montagem_realF[0] == 'S')
				{
					where = where + "a.dat_real_montagem <= '" + montagem_realF.ToString("M/d/yyyy") + "' and ";
				}
			}
			if (idt_nao_montados[0] == 'S') {
				dias_nao_montados *= -1;
				where = where + "a.IDT_DAT_REAL_MONTAGEM = 'N' and " +
					"a.dat_montagem <= '" + DateTime.Now.AddDays(dias_nao_montados).ToString("M/d/yyyy") +
					"' and ";
			}				
			if (cliente.Length > 0) 
			{
				where = where + "b.cod_cliente='" + cliente + "' and ";
			}
			if (consultor.Length > 0) 
			{
				where = where + "b.cod_consultor='" + consultor + "' and ";
			}
			if (vendedor.Length > 0) 
			{
				where = where + "b.cod_vendedor='" + vendedor + "' and ";
			}				
			if (pedido_fornec != 0)
			{
				where = where + "a.NRO_PEDIDO_FORNEC=" + pedido_fornec.ToString() + " and ";
			}
			if (nf_fornec != 0)
			{
				where = where + "a.NRO_NF_FORNEC=" + nf_fornec.ToString() + " and ";
			}
			if (observacao.Length > 0) 
			{
				where = where + "(upper(tira_acentos(substring(a.OBSERVACAO from 1 for 250))) like '%" + Acentuacao.TiraAcentos(observacao).ToUpper() + "%' or "
					+ "upper(tira_acentos(substring(a.OBSERVACAO from 251 for 250))) like '%" + Acentuacao.TiraAcentos(observacao).ToUpper() + "%' or "
					+ "upper(tira_acentos(substring(a.OBSERVACAO from 501 for 250))) like '%" + Acentuacao.TiraAcentos(observacao).ToUpper() + "%' or "
					+ "upper(tira_acentos(substring(a.OBSERVACAO from 751 for 250))) like '%" + Acentuacao.TiraAcentos(observacao).ToUpper() + "%') and ";
			}			
			if (idt_omitir_anos_anteriores.Equals("S"))
			{
				DateTime data0 = DateTime.Parse("01/01/" + DateTime.Now.Year.ToString());
				where = where + "not (a.IDT_DAT_REAL_ENTREGA='S' and a.IDT_DAT_REAL_MONTAGEM='S' and (" +
					"a.IDT_RECEBIDO='S' or exists(select 1 from pedidos_recebidos d where d.COD_FORNECEDOR=a.COD_FORNECEDOR and d.DAT_ORCAMENTO=a.DAT_ORCAMENTO and d.COD_ORCAMENTO=a.COD_ORCAMENTO and d.COD_PEDIDO=a.COD_PEDIDO and d.DAT_ORCAMENTO<'" + data0.ToString("M/d/yyyy") + "'))) and ";
			}
			if (idt_sem_previsao.Equals("S"))
			{
				where = where + "(a.IDT_DAT_REAL_ENTREGA = 'S' and a.IDT_RECEBIDO <> 'S' and " +
					"not exists(select 1 from pedidos_recebidos d where d.COD_FORNECEDOR=a.COD_FORNECEDOR and d.DAT_ORCAMENTO=a.DAT_ORCAMENTO and d.COD_ORCAMENTO=a.COD_ORCAMENTO and d.COD_PEDIDO=a.COD_PEDIDO)) and ";
			}
			if ((idt_cadastroI[0] == 'S') || (idt_cadastroF[0] == 'S'))
			{
				if ((idt_cadastroI[0] == 'S') && (idt_cadastroF[0] == 'S'))
					join = "inner join PARCEIROS p on p.COD_PARCEIRO=b.COD_CLIENTE and (" +
						"p.dat_cadastro >= '" + cadastroI.ToString("M/d/yyyy") + "' and " +
						"p.dat_cadastro <= '" + cadastroF.ToString("M/d/yyyy") + "') ";
				else
				if (idt_cadastroI[0] == 'S')
					join = "inner join PARCEIROS p on p.COD_PARCEIRO=b.COD_CLIENTE and (" +
						"p.dat_cadastro >= '" + cadastroI.ToString("M/d/yyyy") + "') ";
				else
					join = "inner join PARCEIROS p on p.COD_PARCEIRO=b.COD_CLIENTE and (" +
						"p.dat_cadastro <= '" + cadastroF.ToString("M/d/yyyy") + "') ";		
			}
			if (!vlr_inicial.Trim().Equals(""))
			{
				where = where + "a.vlr_pedido >= " + vlr_inicial.Replace(",", ".") + " and ";
			}
			if (!vlr_final.Trim().Equals(""))
			{
				where = where + "a.vlr_pedido <= " + vlr_final.Replace(",", ".") + " and ";
			}			
			if (!numero_pedido.Trim().Equals(""))
			{
				where = where + "a.nro_pedido = " + numero_pedido + " and ";
			}						
			if (!caracteristica.Trim().Equals(""))
			{
				where = where + "b.cod_caracteristica = '" + caracteristica + "' and ";
			}
			return where;
		}
			
		public void Carrega(DataGridView grid,
		                    string fornecedor,
							string vendedor,
							string idt_ou_entrega,
							string idt_nao_entregues,
							short dias_nao_entregues,
							string idt_entrega_previstaI,
							DateTime entrega_previstaI,
							string idt_entrega_previstaF,
							DateTime entrega_previstaF,
							string idt_entrega_realI,
							DateTime entrega_realI,
							string idt_entrega_realF,
							DateTime entrega_realF,
							string idt_ou_montagem,
							string idt_nao_montados,
							short dias_nao_montados,							
							string idt_montagem_previstaI,
							DateTime montagem_previstaI,
							string idt_montagem_previstaF,
							DateTime montagem_previstaF,
							string idt_montagem_realI,
							DateTime montagem_realI,
							string idt_montagem_realF,
							DateTime montagem_realF,
							string cliente,
							string consultor,
							string filtro_dinheiro,
							string filtro_recebidos,
							string _pedido_fornec,
							string _nf_fornec,
							string observacao,
							string idt_dataI,
							DateTime dataI,
							string idt_dataF,
							DateTime dataF,
							string idt_omitir_anos_anteriores,
							string idt_sem_previsao,
							string idt_pendentes_consultor,
							string idt_pendentes_vendedor,
							string idt_cadastroI,
							DateTime cadastroI,
							string idt_cadastroF,
							DateTime cadastroF,
							string vlr_inicial,
							string vlr_final,
							string numero_pedido,
							string caracteristica
						)
		{
			string join = "";
			string where = MontaWhere(
		                    fornecedor,
							vendedor,
							idt_ou_entrega,
							idt_nao_entregues,
							dias_nao_entregues,
							idt_entrega_previstaI,
							entrega_previstaI,
							idt_entrega_previstaF,
							entrega_previstaF,
							idt_entrega_realI,
							entrega_realI,
							idt_entrega_realF,
							entrega_realF,
							idt_ou_montagem,
							idt_nao_montados,
							dias_nao_montados,							
							idt_montagem_previstaI,
							montagem_previstaI,
							idt_montagem_previstaF,
							montagem_previstaF,
							idt_montagem_realI,
							montagem_realI,
							idt_montagem_realF,
							montagem_realF,
							cliente,
							consultor,
							filtro_dinheiro,
							filtro_recebidos,
							_pedido_fornec,
							_nf_fornec,
							observacao,
							idt_dataI,
							dataI,
							idt_dataF,
							dataF,
							idt_omitir_anos_anteriores,
							idt_sem_previsao,
							idt_pendentes_consultor,
							idt_pendentes_vendedor,
							idt_cadastroI,
							cadastroI,
							idt_cadastroF,
							cadastroF,
							vlr_inicial,
							vlr_final,
							numero_pedido,
							caracteristica,
							ref join);
			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			string sql =
				"select  " +
				"a.COD_FORNECEDOR," +       // 0
				"a.DAT_ORCAMENTO," +        // 1
				"substring(a.COD_ORCAMENTO from 1)," +        // 2
				"a.NRO_PEDIDO," +           // 3
				"b.COD_CLIENTE," +	       // 4			
				"a.VLR_PEDIDO," +           // 5
				"a.COD_USUARIO," +          // 6
				"a.DAT_PEDIDO," +           // 7
				"b.COD_VENDEDOR," +         // 8
				"b.COD_CONSULTOR," +        // 9
				"a.DAT_ENTREGA," +          // 10
				"a.IDT_DAT_ENTREGA," +      // 11
				"a.DAT_REAL_ENTREGA," +     // 12
				"a.IDT_DAT_REAL_ENTREGA," + // 13
				"a.DAT_MONTAGEM," +         // 14
				"a.IDT_DAT_MONTAGEM," +     // 15
				"a.DAT_REAL_MONTAGEM," +    // 16
				"a.IDT_DAT_REAL_MONTAGEM," +// 17
				"a.OBSERVACAO," +           // 18
				"a.DAT_ALTERACAO," +        // 19
				"a.COD_CONDICAO," +         // 20
				"a.COD_TRANSPORTADORA," +   // 21
				"b.COD_CARACTERISTICA," +   // 22
				"b.COD_TABELA," +           // 23				
				"a.COD_FORNECEDOR," +       // 24 fornecedor do orçamento	
				"b.VLR_ORCAMENTO," +        // 25
				"b.VLR_DESCONTO," +         // 26
				"b.PER_CONSULTOR," +        // 27
				"c.PER_LIMIAR," +           // 28
				//"   coalesce((select first 1 'S' from titulos_receber d where d.COD_FORNECEDOR=a.COD_FORNECEDOR and d.DAT_ORCAMENTO=a.DAT_ORCAMENTO and d.COD_ORCAMENTO=a.COD_ORCAMENTO and d.COD_PEDIDO=a.NRO_PEDIDO), 'N')," +				
				"coalesce((select first 1 'S' from pedidos_recebidos d where d.COD_FORNECEDOR=a.COD_FORNECEDOR and d.DAT_ORCAMENTO=a.DAT_ORCAMENTO and d.COD_ORCAMENTO=a.COD_ORCAMENTO and d.COD_PEDIDO=a.COD_PEDIDO), 'N')," +				
				"' '," +                    // 30 sinal
				"a.COD_PEDIDO," +           // 31
				"a.NRO_PEDIDO_FORNEC," +    // 32
				"a.NRO_NF_FORNEC," +        // 33
				"a.SEQ_TITULO_FORNEC," +    // 34				
				"' '," +                    // 35 entrega								
				"' '," +                    // 36 montagem
				"a.IDT_FRETE," +            // 37
				"a.IDT_RECEBIDO," +         // 38
				"c.txt_racional," +         // 39
				"' '," +                    // 40 chave
				"a.PER_VENDEDOR," +         // 41
				"a.PER_CONSULTOR," +        // 42
				"a.PER_FILIAL," +           // 43				
				"a.IDT_VENDEDOR," +         // 44 
				"a.IDT_CONSULTOR," +        // 45
				"a.IDT_FILIAL," +           // 46								
				"a.JUS_VENDEDOR," +         // 47
				"a.JUS_CONSULTOR," +        // 48
				"a.JUS_FILIAL," +           // 49												
				"' '," +                    // 50 alterado
				"c.PER_FILIAL," +           // 51				
				"a.VLR_INICIAL," +          // 52
				"a.VLR_FRETE  " +           // 53
				//"a.NRO_NF as NF_SERVICO " + // 54
				"from PEDIDOS a, ORCAMENTOS b, CARACTERISTICAS c " +
				join +

				/*
				"left join PEDIDOS_RECEBIDOS r " +
				"  on r.COD_FORNECEDOR = a.COD_FORNECEDOR and " +
				"     r.DAT_ORCAMENTO = a.DAT_ORCAMENTO and " +
				"     r.COD_ORCAMENTO = a.COD_ORCAMENTO and " +
				"     r.COD_PEDIDO = a.COD_PEDIDO " +
				*/

				where +
				"b.COD_FORNECEDOR = a.COD_FORNECEDOR and " +
				"b.DAT_ORCAMENTO = a.DAT_ORCAMENTO and " +
				"b.COD_ORCAMENTO = a.COD_ORCAMENTO and " +
				"c.COD_FORNECEDOR = b.COD_FORNECEDOR and c.COD_CARACTERISTICA = b.COD_CARACTERISTICA " +
				//filtro_recebidos + " " +
				"order by " +
				"a.COD_FORNECEDOR,a.DAT_ORCAMENTO,a.COD_ORCAMENTO,a.COD_PEDIDO";
			adapter.SelectCommand = new FbCommand(sql, Globais.bd);
			StreamWriter sw = new StreamWriter(new FileStream("c:\\soft\\teste.sql", FileMode.Create));
			sw.WriteLine(sql);
			sw.Close();
			                                   
			//Trace.IniciaComando();
			int n = adapter.Fill(table);
			//Trace.FinalizaComando(adapter.SelectCommand.CommandText, n);
			
			table.Columns[0].ColumnName = "Fornecedor";			
			table.Columns[1].ColumnName = "Data";
			table.Columns[2].ColumnName = "Orçamento";
			table.Columns[3].ColumnName = "Ped";	
			table.Columns[4].ColumnName = "Cliente";			
			table.Columns[5].ColumnName = "Valor";
			table.Columns[6].ColumnName = "Usuário";
			table.Columns[7].ColumnName = "Data_Pedido";
			table.Columns[8].ColumnName = "Vendedor";
			table.Columns[9].ColumnName = "Consultor";
			table.Columns[10].ColumnName = "Data Entrega";
			table.Columns[11].ColumnName = "IDT Data Entrega";
			table.Columns[12].ColumnName = "Data Real Entrega";
			table.Columns[13].ColumnName = "IDT Data Real Entrega";
			table.Columns[14].ColumnName = "Data Montagem";
			table.Columns[15].ColumnName = "IDT Data Montagem";
			table.Columns[16].ColumnName = "Data Real Montagem";
			table.Columns[17].ColumnName = "IDT Data Real Montagem";
			table.Columns[18].ColumnName = "Observação";
			table.Columns[19].ColumnName = "Data Alteração";
			table.Columns[20].ColumnName = "Condição Pagto";
			table.Columns[21].ColumnName = "Transportadora";
			table.Columns[22].ColumnName = "Característica";
			table.Columns[23].ColumnName = "Tabela";
			table.Columns[24].ColumnName = "Fornecedor Orçamento";			
			table.Columns[25].ColumnName = "Valor Itens";
			table.Columns[26].ColumnName = "Desconto";
			table.Columns[27].ColumnName = "Comissão Consultor";
			table.Columns[28].ColumnName = "Limiar";
			table.Columns[29].ColumnName = "R";
			table.Columns[30].ColumnName = "Sinal";
			table.Columns[31].ColumnName = "CodPedido";
			table.Columns[32].ColumnName = "Pedido Fornec";
			table.Columns[33].ColumnName = "NF Fornec";
			table.Columns[34].ColumnName = "Seq Fornec";
			table.Columns[35].ColumnName = "Entrega";
			table.Columns[36].ColumnName = "Montagem";
			table.Columns[37].ColumnName = "Frete";
			table.Columns[38].ColumnName = "Recebido";
			table.Columns[39].ColumnName = "Racional";
			table.Columns[40].ColumnName = "Chave";
			table.Columns[41].ColumnName = "PerVendedor";
			table.Columns[42].ColumnName = "PerConsultor";
			table.Columns[43].ColumnName = "PerFilial";
			table.Columns[44].ColumnName = "IdtVendedor";
			table.Columns[45].ColumnName = "IdtConsultor";
			table.Columns[46].ColumnName = "IdtFilial";
			table.Columns[47].ColumnName = "JusVendedor";
			table.Columns[48].ColumnName = "JusConsultor";
			table.Columns[49].ColumnName = "JusFilial";
			table.Columns[50].ColumnName = "A";
			table.Columns[51].ColumnName = "Comissão Filial";
			table.Columns[52].ColumnName = "Valor Inicial";
			table.Columns[53].ColumnName = "Valor Frete";
			bool b=true;
			DataColumn check = new DataColumn("S", b.GetType());
			table.Columns.Add(check);			
			
			grid.DataSource = table;
			grid.Columns["Chave"].Visible = false;
			grid.Columns["Data"].Visible = false;
			grid.Columns["Usuário"].Visible = false;
			grid.Columns["Data Entrega"].Visible = false;
			grid.Columns["IDT Data Entrega"].Visible = false;
			grid.Columns["Data Real Entrega"].Visible = false;
			grid.Columns["IDT Data Real Entrega"].Visible = false;
			grid.Columns["Data Montagem"].Visible = false;
			grid.Columns["IDT Data Montagem"].Visible = false;
			grid.Columns["Data Real Montagem"].Visible = false;
			grid.Columns["IDT Data Real Montagem"].Visible = false;
			grid.Columns["Observação"].Visible = false;
			grid.Columns["Data Alteração"].Visible = false;
			grid.Columns["Condição Pagto"].Visible = false;
			grid.Columns["Transportadora"].Visible = false;
			grid.Columns["Característica"].Visible = false;
			grid.Columns["Tabela"].Visible = false;
			grid.Columns["Fornecedor Orçamento"].Visible = false;
			grid.Columns["Valor Itens"].Visible = false;
			grid.Columns["Desconto"].Visible = false;
			grid.Columns["Comissão Consultor"].Visible = false;
			grid.Columns["Limiar"].Visible = false;
			grid.Columns["CodPedido"].Visible = false;
			grid.Columns["Pedido Fornec"].Visible = false;
			grid.Columns["NF Fornec"].Visible = false;
			grid.Columns["Seq Fornec"].Visible = false;
			grid.Columns["Sinal"].Visible = false;
			grid.Columns["Frete"].Visible = false;
			grid.Columns["Recebido"].Visible = false;
			grid.Columns["Racional"].Visible = false;
			grid.Columns["PerVendedor"].Visible = false;
			grid.Columns["PerConsultor"].Visible = false;
			grid.Columns["PerFilial"].Visible = false;
			grid.Columns["IdtVendedor"].Visible = false;
			grid.Columns["IdtConsultor"].Visible = false;
			grid.Columns["IdtFilial"].Visible = false;
			grid.Columns["JusVendedor"].Visible = false;
			grid.Columns["JusConsultor"].Visible = false;
			grid.Columns["JusFilial"].Visible = false;
			grid.Columns["Comissão Filial"].Visible = false;
			grid.Columns["Valor Inicial"].Visible = false;
			grid.Columns["Valor Frete"].Visible = false;
			grid.Columns["Valor"].DefaultCellStyle.Format = "###,###,##0.00";
			grid.Columns["Valor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			grid.Columns["Sinal"].Width = 40;
			grid.Columns["Sinal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;			
			grid.Columns["Valor Itens"].DefaultCellStyle.Format = "###,###,##0.00";
			grid.Columns["Ped"].Width = 40;
			grid.Columns["Cliente"].Width = 110;
			grid.Columns["Entrega"].Width = 76;
			grid.Columns["Montagem"].Width = 76;
			grid.Columns["Data_Pedido"].Width = 80;
			grid.Columns["Orçamento"].Width = 60;
			grid.Columns["Fornecedor"].Width = 90;
			grid.Columns["Orçamento"].Width = 100;
			grid.Columns["Valor"].Width = 80;
						
			grid.Columns["R"].Width = 20;			
			grid.Columns["A"].Width = 20;
			grid.Columns["S"].Width = 20;			
			
			foreach (DataGridViewRow row in grid.Rows)
			{
				row.Cells["Chave"].Value = 
					row.Cells["Fornecedor"].Value.ToString().Trim() +
					row.Cells["Data"].Value.ToString().Trim() +
					row.Cells["Orçamento"].Value.ToString().Trim() +
					row.Cells["Ped"].Value.ToString().Trim();
			}
		}
		
		public void CarregaSelecao(DataGridView grid,
		                    string fornecedor,
							string vendedor,
							string idt_ou_entrega,
							string idt_nao_entregues,
							short dias_nao_entregues,
							string idt_entrega_previstaI,
							DateTime entrega_previstaI,
							string idt_entrega_previstaF,
							DateTime entrega_previstaF,
							string idt_entrega_realI,
							DateTime entrega_realI,
							string idt_entrega_realF,
							DateTime entrega_realF,
							string idt_ou_montagem,
							string idt_nao_montados,
							short dias_nao_montados,							
							string idt_montagem_previstaI,
							DateTime montagem_previstaI,
							string idt_montagem_previstaF,
							DateTime montagem_previstaF,
							string idt_montagem_realI,
							DateTime montagem_realI,
							string idt_montagem_realF,
							DateTime montagem_realF,
							string cliente,
							string consultor,
							string filtro_dinheiro,
							string filtro_recebidos,
							string _pedido_fornec,
							string _nf_fornec,
							string observacao,
							string idt_dataI,
							DateTime dataI,
							string idt_dataF,
							DateTime dataF,
							string idt_omitir_anos_anteriores,
							string idt_sem_previsao,
							string idt_pendentes_consultor,
							string idt_pendentes_vendedor,
							string idt_cadastroI,
							DateTime cadastroI,
							string idt_cadastroF,
							DateTime cadastroF
						)
		{
			string join = "";
			string where = MontaWhere(
		                    fornecedor,
							vendedor,
							idt_ou_entrega,
							idt_nao_entregues,
							dias_nao_entregues,
							idt_entrega_previstaI,
							entrega_previstaI,
							idt_entrega_previstaF,
							entrega_previstaF,
							idt_entrega_realI,
							entrega_realI,
							idt_entrega_realF,
							entrega_realF,
							idt_ou_montagem,
							idt_nao_montados,
							dias_nao_montados,							
							idt_montagem_previstaI,
							montagem_previstaI,
							idt_montagem_previstaF,
							montagem_previstaF,
							idt_montagem_realI,
							montagem_realI,
							idt_montagem_realF,
							montagem_realF,
							cliente,
							consultor,
							filtro_dinheiro,
							filtro_recebidos,
							_pedido_fornec,
							_nf_fornec,
							observacao,
							idt_dataI,
							dataI,
							idt_dataF,
							dataF,
							idt_omitir_anos_anteriores,
							idt_sem_previsao,
							idt_pendentes_consultor,
							idt_pendentes_vendedor,
							idt_cadastroI,
							cadastroI,
							idt_cadastroF,
							cadastroF,
							"", "", "", // vlr_ini, vlr_fim, nro_pedido
							"", // caracteristica
							ref join);
			if (where.Equals("where ") || where.EndsWith(" and "))
			{
				where = where + "(1=1) ";
			}
			
			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			string sql =
				"select " +
				"a.COD_FORNECEDOR," +       // 0
				"a.DAT_ORCAMENTO," +        // 1
				"substring(a.COD_ORCAMENTO from 1)," +        // 2
				"a.NRO_PEDIDO," +           // 3
				"b.COD_CLIENTE," +	       // 4			
				"a.VLR_PEDIDO," +           // 5
				"a.COD_USUARIO," +          // 6
				"a.DAT_PEDIDO," +           // 7
				"b.COD_VENDEDOR," +         // 8
				"b.COD_CONSULTOR," +        // 9
				"a.COD_PEDIDO," +           // 10				
				"a.COD_FORNECEDOR " +       // 11 fornecedor do orçamento					
				"from PEDIDOS a " +
				"inner join ORCAMENTOS b on " +
				"b.COD_FORNECEDOR = a.COD_FORNECEDOR and " +
				"b.DAT_ORCAMENTO = a.DAT_ORCAMENTO and " +
				"b.COD_ORCAMENTO = a.COD_ORCAMENTO " +				
				where +
				filtro_recebidos + 
				"order by " +
				"a.COD_FORNECEDOR,a.DAT_ORCAMENTO,a.COD_ORCAMENTO,a.COD_PEDIDO";
			adapter.SelectCommand = new FbCommand(sql, Globais.bd);
			StreamWriter sw = new StreamWriter(new FileStream("c:\\soft\\teste.sql", FileMode.Create));
			sw.WriteLine(sql);
			sw.Close();
			                                   
			adapter.Fill(table);
			table.Columns[0].ColumnName = "Fornecedor";			
			table.Columns[1].ColumnName = "Data";
			table.Columns[2].ColumnName = "Orçamento";
			table.Columns[3].ColumnName = "Ped";	
			table.Columns[4].ColumnName = "Cliente";			
			table.Columns[5].ColumnName = "Valor";
			table.Columns[6].ColumnName = "Usuário";
			table.Columns[7].ColumnName = "Data_Pedido";
			table.Columns[8].ColumnName = "Vendedor";
			table.Columns[9].ColumnName = "Consultor";
			table.Columns[10].ColumnName = "CodPedido";		
			table.Columns[11].ColumnName = "Fornecedor Orçamento";	
			bool b=true;
			DataColumn check = new DataColumn("S", b.GetType());
			table.Columns.Add(check);
			
			grid.DataSource = table;
			grid.Columns["CodPedido"].Visible = false;
			grid.Columns["Fornecedor Orçamento"].Visible = false;
			grid.Columns["Valor"].DefaultCellStyle.Format = "###,###,##0.00";
			grid.Columns["Valor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			grid.Columns["Ped"].Width = 40;
			grid.Columns["Cliente"].Width = 120;
			grid.Columns["Orçamento"].Width = 100;
			grid.Columns["S"].Width = 20;
		}		
		
		public bool Inclui(string fornecedor, DateTime data, short orcamento, short codigo, float valor,
		                   string usuario, DateTime data_pedido,
		                   DateTime dat_entrega, string idt_entrega,
		                   DateTime dat_montagem, string idt_montagem,
		                   string condicao, string transportadora, string servico, string idt_frete,
		                   ref int nro_pedido, ref string msg)
		{
			FbCommand cmd;
			if (codigo == 1) 
			{
				nro_pedido = 1;
				cmd = new FbCommand("select nro_pedido from parceiros " +
				    	            "where cod_parceiro='" + fornecedor + "'",
			                        Globais.bd);
				FbDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
				if (reader.Read())
				{
					if (!reader.IsDBNull(0))
						nro_pedido = reader.GetInt32(0) + 1;
				}
				reader.Close();
				cmd = new FbCommand("update parceiros set nro_pedido=" + nro_pedido + " " +
				    	        	"where cod_parceiro='" + fornecedor + "'",
			                    	Globais.bd);
				Log.Grava(Globais.sUsuario, cmd.CommandText);
				cmd.ExecuteNonQuery();
			}
			
			string sql = 
				"insert into PEDIDOS values(" +
					"'"  + fornecedor + "'," +
					"'"  + data.ToString("M/d/yyyy") + "'," +
					orcamento + "," +
					codigo + "," +
					valor.ToString().Replace(',','.') + "," +
					"'"  + usuario + "'," +
					"'"  + data_pedido.ToString("M/d/yyyy") + "'," +
					"'"  + dat_entrega.ToString("M/d/yyyy") + "'," +
					"'"  + idt_entrega + "'," +
					"'"  + dat_entrega.ToString("M/d/yyyy") + "'," +
					"'N'," +
					"'"  + dat_montagem.ToString("M/d/yyyy") + "'," +
					"'"  + idt_montagem + "'," +
					"'"  + dat_montagem.ToString("M/d/yyyy") + "'," +
					"'N'," +
					"'" + servico + "'," +  // OBSERVACAO
					"'"  + data_pedido.ToString("M/d/yyyy") + "'," +
					"'"  + condicao + "'," +
					"'"  + transportadora + "'," +
					nro_pedido + ", 0, 0, 0," +
//					"'" + idt_frete + "', 'N', 0, 0, 0)";
					"'" + idt_frete + "', 'N', 0, 0, 0, 'N', 'N', 'N', '', '', ''," +
					valor.ToString().Replace(',','.') + "," +
					"0)";
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
			msg = "OK";
			return true;
		}
	
		public bool Altera(string fornecedor, DateTime data, short orcamento, short codigo, 
		                   DateTime entrega_prevista, string idt_entrega_prevista,
		                   DateTime entrega_real, string idt_entrega_real,
		                   DateTime montagem_prevista, string idt_montagem_prevista,
		                   DateTime montagem_real, string idt_montagem_real,
		                   string observacao, string condicao, string transportadora, 
		                   int pedido_fornec, int nf_fornec, //int seq_fornec,
		                   string idt_frete, ref string msg)
		{
			int n=0;
			string sql = 
					"update PEDIDOS " +
					"set " +
					"OBSERVACAO='" + observacao + "' " + 				
					"where " +
					"COD_FORNECEDOR='"  + fornecedor + "' and " +				
					"DAT_ORCAMENTO='"  + data.ToString("M/d/yyyy") + "' and " +				
					"COD_ORCAMENTO=" + orcamento + " and " +
					"COD_PEDIDO=" + codigo;				
			FbCommand cmd = new FbCommand(sql, Globais.bd);
			try
			{
				Log.Grava(Globais.sUsuario, cmd.CommandText);
				n = cmd.ExecuteNonQuery();
			}
			catch (Exception err)
			{
				Log.Grava(Globais.sUsuario, "erro:" + err.Message);
				msg = err.Message;
				return false;
			}
			
			sql = 
					"update PEDIDOS " +
					"set " +
					"DAT_ENTREGA='" + entrega_prevista.ToString("M/d/yyyy") + "'," + 
					"IDT_DAT_ENTREGA='" + idt_entrega_prevista + "'," + 
					"DAT_REAL_ENTREGA='" + entrega_real.ToString("M/d/yyyy") + "'," + 
					"IDT_DAT_REAL_ENTREGA='" + idt_entrega_real + "'," + 
					"DAT_MONTAGEM='" + montagem_prevista.ToString("M/d/yyyy") + "'," + 
					"IDT_DAT_MONTAGEM='" + idt_montagem_prevista + "'," + 
					"DAT_REAL_MONTAGEM='" + montagem_real.ToString("M/d/yyyy") + "'," + 
					"IDT_DAT_REAL_MONTAGEM='" + idt_montagem_real + "'," + 
					"DAT_ALTERACAO='" + DateTime.Today.Date.ToString("M/d/yyyy") + "'," + 
					"COD_CONDICAO='" + condicao + "'," + 
					"COD_TRANSPORTADORA='" + transportadora + "'," + 
					"NRO_PEDIDO_FORNEC=" + pedido_fornec + "," +
					"NRO_NF_FORNEC=" + nf_fornec + "," +
					"IDT_FRETE='" + idt_frete + "' " +				
					"where " +
					"COD_FORNECEDOR='"  + fornecedor + "' and " +				
					"DAT_ORCAMENTO='"  + data.ToString("M/d/yyyy") + "' and " +				
					"COD_ORCAMENTO=" + orcamento;
			cmd = new FbCommand(sql, Globais.bd);
			try
			{
				Log.Grava(Globais.sUsuario, cmd.CommandText);
				n = cmd.ExecuteNonQuery();
			}
			catch (Exception err)
			{
				Log.Grava(Globais.sUsuario, "erro:" + err.Message);
				msg = err.Message;
				return false;
			}
			msg = "OK" + n.ToString();
			return true;
		}
		
		public bool AlteraValor(string fornecedor, DateTime data, short orcamento, short codigo, float valor, short nro_pedido, string consultor, string idt_recebido)
		{
			string svalor = valor.ToString().Replace(',', '.');
			string sql = 
					"update PEDIDOS " +
					"set vlr_pedido="  + svalor + "," +								
					"    nro_pedido="  + nro_pedido + "," +
					"    idt_recebido='"  + idt_recebido + "' " +
					"where " +
					"COD_FORNECEDOR='"  + fornecedor + "' and " +				
					"DAT_ORCAMENTO='"  + data.ToString("M/d/yyyy") + "' and " +				
					"COD_ORCAMENTO=" + orcamento + " and " +
					"COD_PEDIDO=" + codigo;

			FbCommand cmd = new FbCommand(sql, Globais.bd);
			try
			{
				Log.Grava(Globais.sUsuario, cmd.CommandText);
				cmd.ExecuteNonQuery();
			}
			catch (Exception)
			{
				return false;
			}
			sql = 	"update ORCAMENTOS " +
					"set COD_CONSULTOR='"  + consultor + "' " +
					"where " +
					"COD_FORNECEDOR='"  + fornecedor + "' and " +				
					"DAT_ORCAMENTO='"  + data.ToString("M/d/yyyy") + "' and " +				
					"COD_ORCAMENTO=" + orcamento;
			cmd = new FbCommand(sql, Globais.bd);
			try
			{
				Log.Grava(Globais.sUsuario, cmd.CommandText);
				cmd.ExecuteNonQuery();
			}
			catch (Exception)
			{
				return false;
			}
			return true;
		}
		
		public bool AlteraIdtConsultor(string fornecedor, DateTime data, short orcamento, short codigo, bool idt)
		{
			string sidt = idt ? "S" : "N";
			string sql = 
					"update PEDIDOS " +
					"set idt_consultor='"  + sidt + "' " +								
					"where " +
					"COD_FORNECEDOR='"  + fornecedor + "' and " +				
					"DAT_ORCAMENTO='"  + data.ToString("M/d/yyyy") + "' and " +				
					"COD_ORCAMENTO=" + orcamento + " and " +
					"COD_PEDIDO=" + codigo;

			FbCommand cmd = new FbCommand(sql, Globais.bd);
			try
			{
				Log.Grava(Globais.sUsuario, cmd.CommandText);
				cmd.ExecuteNonQuery();
			}
			catch (Exception)
			{
				return false;
			}
			return true;
		}
		
		public bool AlteraIdtFilial(string fornecedor, DateTime data, short orcamento, short codigo, bool idt)
		{
			string sidt = idt ? "S" : "N";
			string sql = 
					"update PEDIDOS " +
					"set idt_filial='"  + sidt + "' " +								
					"where " +
					"COD_FORNECEDOR='"  + fornecedor + "' and " +				
					"DAT_ORCAMENTO='"  + data.ToString("M/d/yyyy") + "' and " +				
					"COD_ORCAMENTO=" + orcamento + " and " +
					"COD_PEDIDO=" + codigo;

			FbCommand cmd = new FbCommand(sql, Globais.bd);
			try
			{
				Log.Grava(Globais.sUsuario, cmd.CommandText);
				cmd.ExecuteNonQuery();
			}
			catch (Exception)
			{
				return false;
			}
			return true;
		}
		
		public bool AlteraIdtVendedor(string fornecedor, DateTime data, short orcamento, short codigo, bool idt)
		{
			string sidt = idt ? "S" : "N";
			string sql = 
					"update PEDIDOS " +
					"set idt_vendedor='"  + sidt + "' " +								
					"where " +
					"COD_FORNECEDOR='"  + fornecedor + "' and " +				
					"DAT_ORCAMENTO='"  + data.ToString("M/d/yyyy") + "' and " +				
					"COD_ORCAMENTO=" + orcamento + " and " +
					"COD_PEDIDO=" + codigo;

			FbCommand cmd = new FbCommand(sql, Globais.bd);
			try
			{
				Log.Grava(Globais.sUsuario, cmd.CommandText);
				cmd.ExecuteNonQuery();
			}
			catch (Exception)
			{
				return false;
			}
			return true;
		}
		
		public bool AlteraPerVendedor(string fornecedor, DateTime data, short orcamento, short codigo, float per, string justificativa)
		{
			string svalor = per.ToString().Replace(',', '.');
			string sql = 
					"update PEDIDOS " +
					"set per_vendedor="  + svalor;
			if (justificativa != null)
				sql = sql + ",jus_vendedor='" + justificativa + "'";
			sql = sql +
					" where " +
					"COD_FORNECEDOR='"  + fornecedor + "' and " +				
					"DAT_ORCAMENTO='"  + data.ToString("M/d/yyyy") + "' and " +				
					"COD_ORCAMENTO=" + orcamento + " and " +
					"COD_PEDIDO=" + codigo;
			FbCommand cmd = new FbCommand(sql, Globais.bd);
			try
			{
				Log.Grava(Globais.sUsuario, cmd.CommandText);
				cmd.ExecuteNonQuery();
			}
			catch (Exception)
			{
				return false;
			}
			return true;
		}		
		
		public bool AlteraPerFilial(string fornecedor, DateTime data, short orcamento, short codigo, float per, string justificativa)
		{
			string svalor = per.ToString().Replace(',', '.');
			string sql = 
					"update PEDIDOS " +
					"set per_filial="  + svalor;
			if (justificativa != null)
				sql = sql + ",jus_filial='" + justificativa + "'";
			sql = sql +
					" where " +
					"COD_FORNECEDOR='"  + fornecedor + "' and " +				
					"DAT_ORCAMENTO='"  + data.ToString("M/d/yyyy") + "' and " +				
					"COD_ORCAMENTO=" + orcamento + " and " +
					"COD_PEDIDO=" + codigo;

			FbCommand cmd = new FbCommand(sql, Globais.bd);
			try
			{
				Log.Grava(Globais.sUsuario, cmd.CommandText);
				cmd.ExecuteNonQuery();
			}
			catch (Exception)
			{
				return false;
			}
			return true;
		}		
		
		public bool AlteraPerConsultor(string fornecedor, DateTime data, short orcamento, short codigo, float per, string justificativa)
		{
			string svalor = per.ToString().Replace(',', '.');
			string sql = 
					"update PEDIDOS " +
					"set per_consultor="  + svalor;
			if (justificativa != null)
				sql = sql + ",jus_consultor='" + justificativa + "'";
			sql = sql +
					" where " +
					"COD_FORNECEDOR='"  + fornecedor + "' and " +				
					"DAT_ORCAMENTO='"  + data.ToString("M/d/yyyy") + "' and " +				
					"COD_ORCAMENTO=" + orcamento + " and " +
					"COD_PEDIDO=" + codigo;

			FbCommand cmd = new FbCommand(sql, Globais.bd);
			try
			{
				Log.Grava(Globais.sUsuario, cmd.CommandText);
				cmd.ExecuteNonQuery();
			}
			catch (Exception)
			{
				return false;
			}
			return true;
		}		
		
		public bool Exclui(string fornecedor, DateTime data, short orcamento)
		{
			string sql = 
				"delete from PEDIDOS where " +
					"COD_FORNECEDOR='"  + fornecedor + "' and " +				
					"DAT_ORCAMENTO='"  + data.ToString("M/d/yyyy") + "' and " +				
					"COD_ORCAMENTO=" + orcamento;
			FbCommand cmd = new FbCommand(sql, Globais.bd);
			try
			{
				Log.Grava(Globais.sUsuario, cmd.CommandText);
				cmd.ExecuteNonQuery();
			}
			catch (Exception)
			{
				return false;
			}
			return true;
		}
		
		public bool Existe(string fornecedor, DateTime data, short orcamento)
		{
			FbCommand cmd =  new FbCommand("select COD_PEDIDO " +
			                               "from PEDIDOS " +
										   "where COD_FORNECEDOR='" + fornecedor + "' and " +
										   "      DAT_ORCAMENTO='" + data.ToString("M/d/yyyy") + "' and " +
				        				   "      COD_ORCAMENTO=" + orcamento,
			                               Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			if (reader.Read())
			{
				reader.Close();
				return true;
			}
			reader.Close();
			return false;
		}
		
		public string VerificaRecebido(string fornecedor, DateTime data, short orcamento, short pedido)
		{
			FbCommand cmd =  new FbCommand(
				"select 1 from titulos_receber " +
				"where COD_FORNECEDOR='" + fornecedor + "' and " +
				"      DAT_ORCAMENTO='" + data.ToString("M/d/yyyy") + "' and " +
				"      COD_ORCAMENTO=" + orcamento.ToString() + " and " +
				"      COD_PEDIDO=" + pedido.ToString(),
				Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			if (reader.Read())
			{
				reader.Close();
				return "S";
			}
			reader.Close();
			return "N";
		}		
		
		public static float FretePedido(string fornecedor, DateTime data, short orcamento, short pedido)
		{
			float frete=0;
			FbCommand cmd =  new FbCommand(
				"select VLR_FRETE from pedidos " +
				"where COD_FORNECEDOR='" + fornecedor + "' and " +
				"      DAT_ORCAMENTO='" + data.ToString("M/d/yyyy") + "' and " +
				"      COD_ORCAMENTO=" + orcamento.ToString() + " and " +
				"      COD_PEDIDO=" + pedido.ToString(),
				Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			if (reader.Read())
			{
				frete = reader.IsDBNull(0) ? 0 : reader.GetFloat(0);
			}
			reader.Close();
			return frete;
		}				

		public static bool AlteraFrete(string fornecedor, DateTime data, short orcamento, short codigo, float frete)
		{
			string sfrete = frete.ToString().Replace(',', '.');
			string sql = 
					"update PEDIDOS " +
					"set vlr_frete="  + sfrete + " " +								
					"where " +
					"COD_FORNECEDOR='"  + fornecedor + "' and " +				
					"DAT_ORCAMENTO='"  + data.ToString("M/d/yyyy") + "' and " +				
					"COD_ORCAMENTO=" + orcamento + " and " +
					"COD_PEDIDO=" + codigo;

			FbCommand cmd = new FbCommand(sql, Globais.bd);
			try
			{
				Log.Grava(Globais.sUsuario, cmd.CommandText);
				cmd.ExecuteNonQuery();
			}
			catch (Exception)
			{
				return false;
			}
			return true;
		}		
		
		public bool Lista(DataGridView dgv, bool bValor, bool bQuebrar, bool bDetalhar, string titulo)
		{
			string sql = "select pr.NRO_NF, tr.DAT_EMISSAO " +
				"from PEDIDOS_RECEBIDOS pr " +
				"inner join TITULOS_RECEBER tr " +
				"on tr.NRO_NF = pr.NRO_NF and tr.SEQ_TITULO = pr.SEQ_TITULO " +
				"where pr.COD_FORNECEDOR = @fornecedor " +
				"  and pr.DAT_ORCAMENTO = @data " +
				"  and pr.COD_ORCAMENTO = @orcamento " +
				"  and pr.COD_PEDIDO = @pedido ";
			FbCommand cmd = new FbCommand(sql, Globais.bd);
			cmd.Parameters.Add("@fornecedor", FbDbType.Char, 20);
			cmd.Parameters.Add("@data", FbDbType.Date);
			cmd.Parameters.Add("@orcamento", FbDbType.SmallInt);
			cmd.Parameters.Add("@pedido", FbDbType.SmallInt);
			cmd.Prepare();
				
			PDF pdf = new PDF("pedidos.pdf");
			pdf.Abre();
			int cols = bValor ? 13 : 11;
			
			pdf.CriaTabela(3, 0);
			string imagem;
			if (!Globais.sUsuario.Equals("web"))				
				imagem = "imagens\\logo_rel.jpg";
			else
				imagem = "imagens/logo_rel.jpg";
			pdf.AdicionaCelula(imagem, 1000, 1000);
			if (titulo.Trim().Length == 0)
				pdf.AdicionaCelula("Listagem de Pedidos", BaseFont.HELVETICA_BOLD, 16);
			else
				pdf.AdicionaCelula(titulo, BaseFont.HELVETICA_BOLD, 16);
			pdf.AdicionaCelula("", BaseFont.HELVETICA_BOLD, 16);
			pdf.AdicionaTabela();
			pdf.CriaTabela(cols, 0);
			pdf.AdicionaCelulaLinha("Fornecedor", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, 2);
			pdf.AdicionaCelulaLinha("Orçamento", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, 2);
			pdf.AdicionaCelulaLinha("Ped", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, 1);
			pdf.AdicionaCelulaLinha("Vendedor", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, 2);
			pdf.AdicionaCelulaLinha("Cliente", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, 2);
			pdf.AdicionaCelulaLinha("Consultor", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, 2);
			pdf.AdicionaCelulaLinha("Valor", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 2);
			double total=0;
			string caracteristica_anterior = "?";
			int linhas_caracteristica = 0;
			double total_caracteristica = 0;
			//foreach (DataGridViewRow row in dgv.Rows)
			for (int r=0; r<dgv.Rows.Count; r++)
			{
				DataGridViewRow row = dgv.Rows[r];
				if (bQuebrar)
				{
					string caracteristica = row.Cells["Característica"].Value.ToString();
					if (!caracteristica.Equals(caracteristica_anterior))
					{
						if (linhas_caracteristica > 0)
						{
							if (bValor) 
							{
								pdf.AdicionaCelulaLinhaTopo("Total " + caracteristica_anterior, BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, 2);
								pdf.AdicionaCelulaLinhaTopo("", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, 9);
								pdf.AdicionaCelulaLinhaTopo(total_caracteristica.ToString("#,###,##0.00"), BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 2);
							}
							
							pdf.AdicionaTabela();							
						}
						linhas_caracteristica = 0;
						total_caracteristica = 0;
						caracteristica_anterior = caracteristica;
						
						pdf.CriaTabela(1, 0);
						pdf.AdicionaCelulaLinha("Característica de Venda: " + caracteristica, BaseFont.HELVETICA_BOLD, 8, Color.LIGHT_GRAY, 1);
						pdf.AdicionaTabela();
						
						pdf.CriaTabela(cols, 0);
						pdf.AdicionaCelulaLinha("Fornecedor", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, 2);
						pdf.AdicionaCelulaLinha("Orçamento", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, 2);
						pdf.AdicionaCelulaLinha("Ped", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, 1);
						pdf.AdicionaCelulaLinha("Vendedor", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, 2);
						pdf.AdicionaCelulaLinha("Cliente", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, 2);
						pdf.AdicionaCelulaLinha("Consultor", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, 2);
						pdf.AdicionaCelulaLinha("Valor", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 2);
					}
				}
				linhas_caracteristica++;
				pdf.AdicionaCelula(row.Cells["Fornecedor"].Value.ToString(), BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 2);
				pdf.AdicionaCelula(row.Cells["Orçamento"].Value.ToString(), BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 2);
				pdf.AdicionaCelula(row.Cells["Ped"].Value.ToString(), BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 1);
				pdf.AdicionaCelula(row.Cells["Vendedor"].Value.ToString(), BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 2);
				pdf.AdicionaCelula(row.Cells["Cliente"].Value.ToString(), BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 2);
				pdf.AdicionaCelula(row.Cells["Consultor"].Value.ToString(), BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 2);

				double valor = double.Parse(row.Cells["Valor"].Value.ToString());
				double valor_produto = valor;
				double valor_servico = 0;
				DataGridViewRow proximo = null;
				if (bDetalhar) 
				{
					if (r < (dgv.Rows.Count - 1))
					{
						proximo = dgv.Rows[r + 1];
						if (proximo.Cells["Fornecedor"].Value.ToString().Equals("SERVICO"))
						{
							valor_servico = double.Parse(proximo.Cells["Valor"].Value.ToString());
							valor += valor_servico;
							r++;
						}
						else
						{
							proximo = null;
						}
					}
				}
				
				pdf.AdicionaCelula(valor.ToString("#,###,##0.00"), BaseFont.HELVETICA, 6, Element.ALIGN_RIGHT, 2);
				if (bValor) total += valor;
				total_caracteristica += valor;
				
				if (bDetalhar) 
				{
					pdf.AdicionaCelula("", BaseFont.HELVETICA, 6, Color.LIGHT_GRAY, 1);
					pdf.AdicionaCelula("Faturamento", BaseFont.HELVETICA, 6, Color.LIGHT_GRAY, 1);
					pdf.AdicionaCelula("Pedido", BaseFont.HELVETICA, 6, Color.LIGHT_GRAY, 1);
					pdf.AdicionaCelula("NF", BaseFont.HELVETICA, 6, Color.LIGHT_GRAY, 1);
					pdf.AdicionaCelula("Valor", BaseFont.HELVETICA, 6, Color.LIGHT_GRAY, 1);
					pdf.AdicionaCelula("", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, cols-5);
					
					pdf.AdicionaCelula("", BaseFont.HELVETICA, 6, Color.LIGHT_GRAY, 1);
					pdf.AdicionaCelula(row.Cells["Fornecedor"].Value.ToString(), BaseFont.HELVETICA, 6, Color.LIGHT_GRAY, 1);
					pdf.AdicionaCelula(row.Cells["Pedido Fornec"].Value.ToString(), BaseFont.HELVETICA, 6, Color.LIGHT_GRAY, 1);
					pdf.AdicionaCelula(row.Cells["NF Fornec"].Value.ToString(), BaseFont.HELVETICA, 6, Color.LIGHT_GRAY, 1);
					pdf.AdicionaCelula(valor_produto.ToString("#,###,##0.00"), BaseFont.HELVETICA, 6, Element.ALIGN_RIGHT, 1);
					pdf.AdicionaCelula("", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, cols-5);
					if (proximo != null)
					{
						string fornecedor = row.Cells["Fornecedor Orçamento"].Value.ToString();
						cmd.Parameters["@fornecedor"].Value = row.Cells["Fornecedor Orçamento"].Value;
						DateTime data = DateTime.Parse(row.Cells["Data"].Value.ToString());
						cmd.Parameters["@data"].Value = row.Cells["Data"].Value;
						string orcamento = row.Cells["Orçamento"].Value.ToString();
						cmd.Parameters["@orcamento"].Value = int.Parse(orcamento.Split('-')[1]);
						string codPedido = row.Cells["CodPedido"].Value.ToString();
						cmd.Parameters["@pedido"].Value = 2;
						
						FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
						String nroNf = "";
						DateTime datEmissao = DateTime.Now;
						if (reader.Read())
						{
							nroNf = reader.GetString(0);
							datEmissao = reader.GetDateTime(1);
						}
						reader.Close();
						
						pdf.AdicionaCelula("", BaseFont.HELVETICA, 6, Color.LIGHT_GRAY, 1);
						pdf.AdicionaCelula("SOFTPLACE", BaseFont.HELVETICA, 6, Color.LIGHT_GRAY, 1);						
						pdf.AdicionaCelula(datEmissao.ToString("dd/MM/yyyy"), BaseFont.HELVETICA, 6, Color.LIGHT_GRAY, 1);
						pdf.AdicionaCelula(nroNf, BaseFont.HELVETICA, 6, Color.LIGHT_GRAY, 1);
						pdf.AdicionaCelula(valor_servico.ToString("#,###,##0.00"), BaseFont.HELVETICA, 6, Element.ALIGN_RIGHT, 1);
						pdf.AdicionaCelula("", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, cols-5);
					}
				}
			}
			
			if (bValor) 
			{

				if (bQuebrar && (linhas_caracteristica > 0))
				{
					pdf.AdicionaCelulaLinhaTopo("Total " + caracteristica_anterior, BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, 2);
					pdf.AdicionaCelulaLinhaTopo("", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, 9);
					pdf.AdicionaCelulaLinhaTopo(total_caracteristica.ToString("#,###,##0.00"), BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 2);
				}
				
				pdf.AdicionaCelulaLinhaTopo("Total Geral", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, 2);
				pdf.AdicionaCelulaLinhaTopo("", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, 9);
				pdf.AdicionaCelulaLinhaTopo(total.ToString("#,###,##0.00"), BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 2);
			}
			pdf.AdicionaTabela();			
			pdf.Fecha();
			return true;
		}
		
		public Cabecalho1_Pedido DadosCabecalho1(string fornecedor_pedido, string fornecedor, DateTime data, short orcamento, short codigo)		
		{
			Cabecalho1_Pedido cab1 = new Cabecalho1_Pedido();
			if (!Globais.sUsuario.Equals("web"))				
				cab1.logo = "imagens\\logo_rel.jpg";
			else
				cab1.logo = "imagens/logo_rel.jpg";
			cab1.fornecedor_pedido = fornecedor_pedido;
			cab1.fornecedor = fornecedor;
			cab1.data = data;
			cab1.orcamento = orcamento;
			
			FbCommand cmd =  new FbCommand("select b.DES_CONDICAO," +
			                               "       a.COD_TRANSPORTADORA," +
			                               "       a.VLR_PEDIDO," +
			                               "       a.NRO_PEDIDO " +
			                     		   "from PEDIDOS a " +
			                     		   "left outer join CONDICOES_PAGTO b on b.COD_CONDICAO=a.COD_CONDICAO " +			                     		   
			                     		   "where a.cod_fornecedor='" + fornecedor + "' and " +
				                 		   "      a.dat_orcamento='" + data.ToString("M/d/yyyy") + "' and " +
				                 		   "      a.cod_orcamento=" + orcamento + " and " +
				                 		   "      a.COD_PEDIDO=" + codigo,
			                     		   Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			cab1.condicao_pagto = "";
			cab1.transportadora = "";
			if (reader.Read())
			{
				cab1.condicao_pagto = !reader.IsDBNull(0) ? reader.GetString(0).Trim() : "";
				cab1.transportadora = !reader.IsDBNull(1) ? reader.GetString(1).Trim() : "";
				cab1.valor = !reader.IsDBNull(2) ? reader.GetFloat(2) : 0;
				cab1.nro_pedido = !reader.IsDBNull(3) ? reader.GetInt32(3) : 0;
			}
			reader.Close();
			return cab1;
		}
		
		public Cabecalho2_Pedido DadosCabecalho2(string fornecedor, DateTime data, short orcamento, bool servico)
		{
			string cliente="a.COD_CLIENTE ";
			if (servico)
			{
				cliente = "'SERVICO' ";
			}
			Cabecalho2_Pedido cab2 = new Cabecalho2_Pedido();
			FbCommand cmd =  new FbCommand("select b.NOM_PARCEIRO," +
			                               "       b.NRO_CPF_CNPJ," +
			                               "       b.DES_LOGRADOURO," +
			                               "       b.NRO_ENDERECO," +
			                               "       b.DES_COMPLEMENTO," +
			                               "       b.NOM_BAIRRO," +
			                               "       b.NOM_CIDADE," +
			                               "       b.COD_ESTADO," +
			                               "       b.NRO_CEP," +			                               
			                               "       b.NRO_INSCRICAO_ESTADUAL," +
			                               "       b.DES_LOGRADOURO_ENTREGA," +
			                               "       b.NRO_ENDERECO_ENTREGA," +
			                               "       b.DES_COMPLEMENTO_ENTREGA," +
			                               "       b.NOM_BAIRRO_ENTREGA," +
			                               "       b.NOM_CIDADE_ENTREGA," +
			                               "       b.COD_ESTADO_ENTREGA," +
			                               "       b.NRO_CEP_ENTREGA," +			                               			                               
			                               "       b.NRO_INSCRICAO_MUNICIPAL," +
			                               "       c.NOM_CONTATO," +
			                               "       c.NRO_FONE1," +
			                               "       c.DES_EMAIL," +
			                               "       a.COD_VENDEDOR," +
                                           "       b.IDT_FISJUR," +
                                           "       a.VLR_DESCONTO," +
			                               "       b.DES_LOGRADOURO_COBRANCA," +                                           
			                               "       b.NRO_ENDERECO_COBRANCA," +
			                               "       b.DES_COMPLEMENTO_COBRANCA," +
			                               "       b.NOM_BAIRRO_COBRANCA," +
			                               "       b.NOM_CIDADE_COBRANCA," +
			                               "       b.COD_ESTADO_COBRANCA," +
			                               "       b.NRO_CEP_COBRANCA, " +		
			                               "       c.NRO_FONE2," +
			                               "       c.NRO_CELULAR, " +
			                               "       f.DES_EMAIL as email_vendedor, " +
			                               "       b.NRO_FONE1 as fone1_parceiro," +
			                               "       b.NRO_FONE2 as fone2_parceiro," +
			                               "       b.NRO_CELULAR as celular_parceiro " +			                               
			                     		   "from ORCAMENTOS a " +
			                     		   "left outer join PARCEIROS b on b.COD_PARCEIRO=" + cliente +
			                     		   "left outer join CONTATOS c on c.COD_PARCEIRO=" + cliente + " and c.COD_CONTATO=a.COD_CONTATO " +
			                     		   "left outer join FUNCIONARIOS f on f.COD_FUNCIONARIO=a.COD_VENDEDOR " +
			                     		   "where cod_fornecedor='" + fornecedor + "' and " +
				                 		   "      dat_orcamento='" + data.ToString("M/d/yyyy") + "' and " +
				                 		   "      cod_orcamento=" + orcamento,
			                               /*
			                     		   "from ORCAMENTOS a, PARCEIROS b, CONTATOS c " +
			                     		   "where cod_fornecedor='" + fornecedor + "' and " +
				                 		   "      dat_orcamento='" + data.ToString("M/d/yyyy") + "' and " +
				                 		   "      cod_orcamento=" + orcamento + " and " +
				                 		   "      b.COD_PARCEIRO=a.COD_CLIENTE and " +
				                 		   "      c.COD_CONTATO=a.COD_CONTATO",
				                 		   */
			                     		   Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			if (reader.Read())
			{
				cab2.cliente = !reader.IsDBNull(0) ? reader.GetString(0).Trim() : "";
				if (!reader.IsDBNull(22))
				{
					string tipo = reader.GetString(22).Trim();
					if (tipo[0] == 'F')
					{
						cab2.cnpj = !reader.IsDBNull(1) ? CPF.PoeEdicao(reader.GetString(1).Trim()) : "";
					}
					else
					{
						cab2.cnpj = !reader.IsDBNull(1) ? CNPJ.PoeEdicao(reader.GetString(1).Trim()) : "";
					}
				}
				else
				{
					cab2.cnpj = !reader.IsDBNull(1) ? CPF.PoeEdicao(reader.GetString(1).Trim()) : "";
				}
				cab2.endereco = !reader.IsDBNull(2) ? reader.GetString(2).Trim() : "";
				cab2.numero = !reader.IsDBNull(3) ? reader.GetString(3).Trim() : "";
				cab2.compl = !reader.IsDBNull(4) ? reader.GetString(4).Trim() : "";
				cab2.bairro = !reader.IsDBNull(5) ? reader.GetString(5).Trim() : "";
				cab2.cidade = !reader.IsDBNull(6) ? reader.GetString(6).Trim() : "";
				cab2.estado = !reader.IsDBNull(7) ? reader.GetString(7).Trim() : "";
				cab2.cep = !reader.IsDBNull(8) ? reader.GetString(8).Trim() : "";
				cab2.ie = !reader.IsDBNull(9) ? reader.GetString(9).Trim() : "";
				cab2.entrega = !reader.IsDBNull(10) ? reader.GetString(10).Trim() : "";
				cab2.numero_entrega = !reader.IsDBNull(11) ? reader.GetString(11).Trim() : "";
				cab2.compl_entrega = !reader.IsDBNull(12) ? reader.GetString(12).Trim() : "";
				cab2.bairro_entrega = !reader.IsDBNull(13) ? reader.GetString(13).Trim() : "";
				cab2.cidade_entrega = !reader.IsDBNull(14) ? reader.GetString(14).Trim() : "";
				cab2.estado_entrega = !reader.IsDBNull(15) ? reader.GetString(15).Trim() : "";
				cab2.cep_entrega = !reader.IsDBNull(16) ? reader.GetString(16).Trim() : "";
				cab2.im = !reader.IsDBNull(17) ? reader.GetString(17).Trim() : "";
				cab2.contato = !reader.IsDBNull(18) ? reader.GetString(18).Trim() : "";
				cab2.fone = !reader.IsDBNull(19) ? reader.GetString(19).Trim() : "";
				cab2.email = !reader.IsDBNull(20) ? reader.GetString(20).Trim() : "";
				cab2.vendedor = !reader.IsDBNull(21) ? reader.GetString(21).Trim() : "";
				cab2.vlr_desconto = !reader.IsDBNull(23) ? reader.GetFloat(23) : 0;
				cab2.cobranca = !reader.IsDBNull(24) ? reader.GetString(24).Trim() : "";
				cab2.numero_cobranca = !reader.IsDBNull(25) ? reader.GetString(25).Trim() : "";
				cab2.compl_cobranca = !reader.IsDBNull(26) ? reader.GetString(26).Trim() : "";
				cab2.bairro_cobranca = !reader.IsDBNull(27) ? reader.GetString(27).Trim() : "";
				cab2.cidade_cobranca = !reader.IsDBNull(28) ? reader.GetString(28).Trim() : "";
				cab2.estado_cobranca = !reader.IsDBNull(29) ? reader.GetString(29).Trim() : "";
				cab2.cep_cobranca = !reader.IsDBNull(30) ? reader.GetString(30).Trim() : "";
				cab2.fone2 = !reader.IsDBNull(31) ? reader.GetString(31).Trim() : "";
				cab2.celular = !reader.IsDBNull(32) ? reader.GetString(32).Trim() : "";
				cab2.email_vendedor = !reader.IsDBNull(33) ? reader.GetString(33).Trim() : "";
				cab2.fone1_parceiro = !reader.IsDBNull(34) ? reader.GetString(34).Trim() : "";
				cab2.fone2_parceiro = !reader.IsDBNull(35) ? reader.GetString(35).Trim() : "";
				cab2.celular_parceiro = !reader.IsDBNull(36) ? reader.GetString(36).Trim() : "";
			}
			else
			{
				cab2.cliente = "";
				cab2.cnpj = "";
				cab2.endereco = "";
				cab2.ie = "";
				cab2.entrega = "";
				cab2.cobranca = "";
				cab2.im = "";
				cab2.contato = "";
				cab2.fone = "";
				cab2.email = "";
				cab2.vendedor = "";
				cab2.vlr_desconto = 0;
			}
			reader.Close();
			return cab2;
		}
		
		public bool Gera(string fornecedor_pedido, string fornecedor, DateTime data, short cod_orcamento, short codigo, string formula, string formula_orcamento, string arquivo, string observacao, cPedidoPDF pdf_pedido, bool mostrar_subcodigo, bool mostrar_valores, bool destacar_ipi)
		{
			cOrcamentoPDF pdf_orcamento = new cOrcamentoPDF();
			cOrcamentos orcamento = new cOrcamentos();
			//cPedidoPDF pdf_pedido = new cPedidoPDF();
			pdf_pedido.cab1 = DadosCabecalho1(fornecedor_pedido, fornecedor, data, cod_orcamento, codigo);
			pdf_pedido.cab2 = DadosCabecalho2(fornecedor, data, cod_orcamento, false);
            if (formula.CompareTo(formula_orcamento) != 0)
                pdf_pedido.cab2.vlr_desconto = 0;
			if (codigo == 1)
				orcamento.DadosAreas(fornecedor, data, cod_orcamento, formula, true, formula_orcamento, ref pdf_orcamento, false);
			pdf_pedido.Gera(pdf_orcamento.areas, observacao, mostrar_subcodigo, mostrar_valores, destacar_ipi);
			return true;
		}
		
		public bool GeraFabrica(string fornecedor_pedido, string fornecedor, DateTime data, short cod_orcamento, short codigo, string formula, string formula_orcamento, string arquivo, string observacao, bool mostrar_valores, bool mostrar_subcodigo)
		{
			PedidoFabricaPDF pdf = new PedidoFabricaPDF();			
			FbCommand cmd =  new FbCommand("select " +
			                               "p.NRO_PEDIDO_FORNEC," +
			                               "f.NOM_PARCEIRO," +
			                               "f.DES_LOGRADOURO," +
			                               "f.NRO_ENDERECO," +
			                               "f.NOM_CIDADE," +
			                               "f.COD_ESTADO," +
			                               "f.NRO_FONE1," +
			                               "f.NRO_FAX," +
			                               "f.NRO_CEP," +
			                               "f.DES_EMAIL," +
			                               "p.NRO_PEDIDO," +
			                               "p.COD_TRANSPORTADORA," +
			                               "p.IDT_FRETE " +
			                     		   "from PEDIDOS p " +
			                     		   "left outer join PARCEIROS f on f.COD_PARCEIRO=p.COD_FORNECEDOR " +			                     		   
			                     		   "where p.COD_FORNECEDOR='" + fornecedor + "' and " +
				                 		   "      p.DAT_ORCAMENTO='" + data.ToString("M/d/yyyy") + "' and " +
				                 		   "      p.COD_ORCAMENTO=" + cod_orcamento + " and " +
				                 		   "      p.COD_PEDIDO=" + codigo,
			                     		   Globais.bd);
			pdf.COD_FORNECEDOR = fornecedor;
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			if (reader.Read())
			{
				pdf.NRO_PEDIDO_FORNEC = !reader.IsDBNull(0) ? reader.GetInt16(0) : (short)0;
				pdf.NOM_PARCEIRO = !reader.IsDBNull(1) ? reader.GetString(1).Trim() : "";
				pdf.DES_LOGRADOURO = !reader.IsDBNull(2) ? reader.GetString(2).Trim() : "";
				pdf.NRO_ENDERECO = !reader.IsDBNull(3) ? reader.GetString(3).Trim() : "";
				pdf.NOM_CIDADE = !reader.IsDBNull(4) ? reader.GetString(4).Trim() : "";
				pdf.COD_ESTADO = !reader.IsDBNull(5) ? reader.GetString(5).Trim() : "";
				pdf.NRO_FONE1 = !reader.IsDBNull(6) ? reader.GetString(6).Trim() : "";
				pdf.NRO_FAX = !reader.IsDBNull(7) ? reader.GetString(7).Trim() : "";
				pdf.NRO_CEP = !reader.IsDBNull(8) ? reader.GetString(8).Trim() : "";
				pdf.DES_EMAIL = !reader.IsDBNull(9) ? reader.GetString(9).Trim() : "";				
				pdf.NRO_PEDIDO = !reader.IsDBNull(10) ? reader.GetInt16(10) : (short)0;
				pdf.COD_TRANSPORTADORA = !reader.IsDBNull(11) ? reader.GetString(11).Trim() : "";
				pdf.IDT_FRETE = !reader.IsDBNull(12) ? reader.GetString(12)[0] : 'C';
			}
			reader.Close();
			
			cPedidoPDF pdf_pedido = new cPedidoPDF();			
			pdf_pedido.cab2 = DadosCabecalho2(fornecedor, data, cod_orcamento, false);
			cOrcamentos orcamento = new cOrcamentos();
			cOrcamentoPDF pdf_orcamento = new cOrcamentoPDF();
			orcamento.DadosAreas(fornecedor, data, cod_orcamento, formula, true, formula_orcamento, ref pdf_orcamento, false);			
			pdf_pedido.cab2.observacao = observacao;
			pdf.Gera(arquivo, pdf_pedido.cab2, pdf_orcamento, mostrar_valores, mostrar_subcodigo);
			return true;
		}

		public static void SetaDatas(string COD_FORNECEDOR, DateTime DAT_ORCAMENTO, short COD_ORCAMENTO, short COD_PEDIDO, DateTime DAT_EMISSAO)
		{
			string sql;
			FbCommand cmd;
			//FbDataReader reader;
			
			// numero de dias para montagem
			short QTD_DIAS=0;
			/*
			sql = "select c.QTD_DIAS from orcamentos o, caracteristicas c where " +
				"o.COD_FORNECEDOR='" + COD_FORNECEDOR + "' and " +
				"o.DAT_ORCAMENTO='" + DAT_ORCAMENTO.ToString("M/d/yyyy") + "' and " +
				"o.COD_ORCAMENTO=" + COD_ORCAMENTO + " and " +
				"c.COD_FORNECEDOR=o.COD_FORNECEDOR and " +
				"c.COD_CARACTERISTICA=o.COD_CARACTERISTICA";
			cmd =  new FbCommand(sql, Globais.bd);
			reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			if (reader.Read())
			{
				QTD_DIAS = !reader.IsDBNull(0) ? reader.GetInt16(0) : (short)0;
			}
			reader.Close();
			*/
		
			// atualiza a data de entrega
			DateTime entrega = DAT_EMISSAO;
			sql = "update PEDIDOS set " +
					"DAT_REAL_ENTREGA='" + entrega.ToString("M/d/yyyy") + "'," + 
					"IDT_DAT_REAL_ENTREGA='S' " + 
					"where " +
					"COD_FORNECEDOR='"  + COD_FORNECEDOR + "' and " +				
					"DAT_ORCAMENTO='"  + DAT_ORCAMENTO.ToString("M/d/yyyy") + "' and " +				
					"COD_ORCAMENTO=" + COD_ORCAMENTO + " and " +
					//"COD_PEDIDO=" + COD_PEDIDO + " and " +
					"IDT_DAT_REAL_ENTREGA='N'";
			cmd = new FbCommand(sql, Globais.bd);
			try
			{
				Log.Grava(Globais.sUsuario, cmd.CommandText);
				cmd.ExecuteNonQuery();
			}
			catch (Exception e)
			{
				Log.Grava(Globais.sUsuario, "erro:" + e.Message);
				string msg = e.Message;
			}

			// atualiza a data de montagem
			DateTime montagem = DAT_EMISSAO.AddDays(QTD_DIAS);			
			sql = "update PEDIDOS set " +
					"DAT_REAL_MONTAGEM='" + montagem.ToString("M/d/yyyy") + "'," + 
					"IDT_DAT_REAL_MONTAGEM='S' " + 
					"where " +
					"COD_FORNECEDOR='"  + COD_FORNECEDOR + "' and " +				
					"DAT_ORCAMENTO='"  + DAT_ORCAMENTO.ToString("M/d/yyyy") + "' and " +				
					"COD_ORCAMENTO=" + COD_ORCAMENTO + " and " +
					//"COD_PEDIDO=" + COD_PEDIDO + " and " +
					"IDT_DAT_REAL_MONTAGEM='N'";
			cmd = new FbCommand(sql, Globais.bd);
			try
			{
				Log.Grava(Globais.sUsuario, cmd.CommandText);
				cmd.ExecuteNonQuery();
			}
			catch (Exception e)
			{
				Log.Grava(Globais.sUsuario, "erro:" + e.Message);
				string msg = e.Message;
			}
		}

		public static bool LeAgendamento(string fornecedor, DateTime data, short orcamento, short pedido, ref string usuario_agenda, ref DateTime data_agenda)
		{
			FbCommand cmd =  new FbCommand(
				"select COD_USUARIO,DAT_AGENDAMENTO from pedidos_agenda " +
				"where COD_FORNECEDOR='" + fornecedor + "' and " +
				"      DAT_ORCAMENTO='" + data.ToString("M/d/yyyy") + "' and " +
				"      COD_ORCAMENTO=" + orcamento.ToString() + " and " +
				"      COD_PEDIDO=" + pedido.ToString(),
				Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			if (reader.Read())
			{
				usuario_agenda = reader.GetString(0);
				data_agenda = reader.GetDateTime(1);
				reader.Close();
				return true;
			}
			reader.Close();
			return false;
		}		
		
		public static bool LeAgendamento(string COD_FORNECEDOR, DateTime DAT_ORCAMENTO, short COD_ORCAMENTO, string COD_USUARIO, DateTime DAT_AGENDAMENTO)
		{
			FbCommand cmd =  new FbCommand(
				"select 1 from pedidos_agenda " +
				"where COD_FORNECEDOR='" + COD_FORNECEDOR + "' and " +
				"      DAT_ORCAMENTO='" + DAT_ORCAMENTO.ToString("M/d/yyyy") + "' and " +
				"      COD_ORCAMENTO=" + COD_ORCAMENTO.ToString() + " and " +
				"      COD_USUARIO='" + COD_USUARIO + "' and " +
				"      DAT_AGENDAMENTO='" + DAT_AGENDAMENTO.ToString("M/d/yyyy HH:mm:ss") + "'",
				Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			if (reader.Read())
			{
				return true;
			}
			reader.Close();
			return false;
		}				
		
		public static void IncluiAgendamento(string fornecedor, DateTime data, short orcamento, short pedido, string usuario_agenda, DateTime data_agenda, DateTime data_montagem)
		{
			FbCommand cmd =  new FbCommand(
				"insert into pedidos_agenda values(" +
				"'" + fornecedor + "', " +
				"'" + data.ToString("M/d/yyyy") + "', " +
				orcamento.ToString() + ", " +
				pedido.ToString() + ", " +
				"'" + usuario_agenda + "', " +
				"'" + data_agenda.ToString("M/d/yyyy HH:mm:ss") + "')",
				Globais.bd);
			Log.Grava(Globais.sUsuario, cmd.CommandText);
			cmd.ExecuteNonQuery();			
			cmd =  new FbCommand(
				"update pedidos set " +
				"IDT_DAT_MONTAGEM = 'S', " +
				"DAT_MONTAGEM = '" + data_montagem.ToString("M/d/yyyy") + "' " +
				"where COD_FORNECEDOR='" + fornecedor + "' and " +
				"      DAT_ORCAMENTO='" + data.ToString("M/d/yyyy") + "' and " +
				"      COD_ORCAMENTO=" + orcamento.ToString() + " and " +
				//"      COD_PEDIDO=" + pedido.ToString() + " and " +
				"     IDT_DAT_REAL_MONTAGEM = 'N'",
				Globais.bd);
			Log.Grava(Globais.sUsuario, cmd.CommandText);
			cmd.ExecuteNonQuery();						
		}		
		
		public static void SolucionaAgendamento(string fornecedor, DateTime data, short orcamento, short pedido, DateTime data_solucao)
		{
			FbCommand cmd =  new FbCommand(
				"update pedidos set " +
				"IDT_DAT_REAL_MONTAGEM = 'S', " +
				"DAT_REAL_MONTAGEM = '" + data_solucao.ToString("M/d/yyyy") + "' " +
				"where COD_FORNECEDOR='" + fornecedor + "' and " +
				"      DAT_ORCAMENTO='" + data.ToString("M/d/yyyy") + "' and " +
				"      COD_ORCAMENTO=" + orcamento.ToString() + " and " +
				//"      COD_PEDIDO=" + pedido.ToString() + " and " +
				"     IDT_DAT_REAL_MONTAGEM = 'N'",
				Globais.bd);
			Log.Grava(Globais.sUsuario, cmd.CommandText);
			cmd.ExecuteNonQuery();			
		}								
		
		public static void SolucionaAgendamento(string usuario, DateTime data, DateTime data_solucao)
		{
			FbCommand cmd =  new FbCommand(
				"select COD_FORNECEDOR,DAT_ORCAMENTO,COD_ORCAMENTO from pedidos_agenda " +
				"where COD_USUARIO='" + usuario + "' and " +
				"      DAT_AGENDAMENTO='" + data.ToString("M/d/yyyy HH:mm:ss") + "'",
				Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			if (reader.Read())
			{
				string fornecedor = reader.GetString(0);
				DateTime data_orcamento = reader.GetDateTime(1);
				short orcamento = reader.GetInt16(2);
				SolucionaAgendamento(fornecedor, data_orcamento, orcamento, 1, data_solucao);
			}
			reader.Close();
		}										
		
		public bool ListaComissao(DataGridView dgv, bool por_vendedor, bool por_consultor, bool por_filial, bool somente_pago, bool somente_pagar, string titulo, bool justificativas)
		{
			ComissaoPDF pdf = new ComissaoPDF();			
			pdf.Gera(dgv, por_vendedor, por_consultor, por_filial, somente_pago, somente_pagar, titulo, justificativas, "comissao.pdf");
			return true;		
		}

		public static float RateiaFrete(string fornecedor, DateTime data, short orcamento, short pedido, ref float vlr_frete)
		{
			FbCommand cmd =  new FbCommand(
				"select count(*) from PEDIDOS " +
				"where COD_FORNECEDOR='" + fornecedor + "' and " +
				"      DAT_ORCAMENTO='" + data.ToString("M/d/yyyy") + "' and " +
				"      COD_ORCAMENTO=" + orcamento.ToString() + " and " +
				"      COD_PEDIDO=" + pedido.ToString(),
				Globais.bd);			
			int itens=0;
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			if (reader.Read())
			{
				itens = reader.GetInt32(0);
			}
			reader.Close();			
			return vlr_frete / itens;
		}

		public static bool CV(string fornecedor, DateTime data, short orcamento, short pedido,
		                         ref string jus, ref float per)
		{
			FbCommand cmd =  new FbCommand(	"select JUS_VENDEDOR,PER_VENDEDOR " +
			                               	"from PEDIDOS " +
										   	"where COD_FORNECEDOR='" + fornecedor + "' and " +
										   	"      DAT_ORCAMENTO='" + data.ToString("M/d/yyyy") + "' and " +
											"COD_ORCAMENTO=" + orcamento + " and " +
											"COD_PEDIDO=" + pedido + " and " +
											"PER_VENDEDOR > 0 ",
			                               Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			if (reader.Read())
			{
				jus = reader.GetString(0);
				per = reader.GetFloat(1);
				reader.Close();
				return true;
			}
			reader.Close();
			return false;
		}	
		
		public static bool CC(string fornecedor, DateTime data, short orcamento, short pedido,
		                         ref string jus, ref float per)
		{
			FbCommand cmd =  new FbCommand(	"select JUS_CONSULTOR,PER_CONSULTOR " +
			                               	"from PEDIDOS " +
										   	"where COD_FORNECEDOR='" + fornecedor + "' and " +
										   	"      DAT_ORCAMENTO='" + data.ToString("M/d/yyyy") + "' and " +
											"COD_ORCAMENTO=" + orcamento + " and " +
											"COD_PEDIDO=" + pedido + " and " +
											"PER_CONSULTOR > 0",
			                               Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			if (reader.Read())
			{
				jus = reader.GetString(0);
				per = reader.GetFloat(1);
				reader.Close();
				return true;
			}
			reader.Close();
			return false;
		}	
	}
}

