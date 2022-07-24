using System;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using classes;
using System.Collections.Generic;

/*
 create table ACOES_COMERCIAIS (
 SEQ_ACAO integer not null,
 COD_CLIENTE char(20),
 DES_OBRA char(30),
 DAT_PREVISAO date,
 COD_VENDEDOR char(20),
 COD_CONSULTOR char(20),
 IDT_SITUACAO char(1),
 TXT_OBSERVACAO varchar(4000),
 COD_ORIGEM char(10), 
 TXT_CONCORRENTES varchar(4000),
 DAT_PRIM_CONTATO date,
 DAT_ULT_CONTATO date,
 constraint PK_ACOES_COMERCIAIS primary key(SEQ_ACAO));
 */

namespace acao
{
	public class AcaoDAO
	{
		public static void Carrega(DataGridView grid,
			string cliente,
			string consultor,
			string origem,
			string vendedor,
			List<string> situacoes,
			string idt_previsaoI,
			DateTime previsaoI,
			string idt_previsaoF,
			DateTime previsaoF)
		{
			Log.Grava("debug", "carrega: " + DateTime.Now.ToString());
			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			string where = "";
			if ((vendedor != null) && (vendedor.Trim().Length > 0))
			{
				where = "where a.COD_VENDEDOR = '" + vendedor.Trim() + "' ";
			}
			if ((cliente != null) && (cliente.Trim().Length > 0))
			{
				if (where.Equals(""))
					where = "where ";
				else
					where += "and ";
				where += "(a.COD_CLIENTE = '" + cliente.Trim() 
					+ "' or a.SEQ_ACAO in (select SEQ_ACAO from CLIENTES_ACAO c where c.COD_CLIENTE = '" + cliente.Trim() + "'))";
			}
			if ((consultor != null) && (consultor.Trim().Length > 0))
			{
				if (where.Equals(""))
					where = "where ";
				else
					where += "and ";
				where += "a.COD_CONSULTOR = '" + consultor.Trim() + "' ";
			}
			if ((origem != null) && (origem.Trim().Length > 0))
			{
				if (where.Equals(""))
					where = "where ";
				else
					where += "and ";
				where += "a.COD_ORIGEM = '" + origem.Trim() + "' ";
			}
			if ((situacoes != null) && (situacoes.Count > 0))
			{
				if (where.Equals(""))
					where = "where ";
				else
					where += "and ";
				where += "a.IDT_SITUACAO in (";
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
			}
			else
			{
				if (where.Equals(""))
					where = "where ";
				else
					where += "and ";
				where += "a.IDT_SITUACAO in (select COD_SITUACAO from SITUACOES_ACAO where IDT_APRESENTA_AUTOM='S')";
			}
			if ((idt_previsaoI != null) && idt_previsaoI.Equals("S"))
			{
				if (where.Equals(""))
					where = "where ";
				else
					where += "and ";				
				where += "a.DAT_PREVISAO >= '" + previsaoI.ToString("M/d/yyyy") + "' ";
			}
			if ((idt_previsaoF != null) && idt_previsaoF.Equals("S"))
			{
				if (where.Equals(""))
					where = "where ";
				else
					where += "and ";				
				where += "a.DAT_PREVISAO <= '" + previsaoF.ToString("M/d/yyyy") + "' ";
			}			
			
			adapter.SelectCommand = new FbCommand("select a.SEQ_ACAO, \r\n" + // 0
			                                      "       a.COD_CLIENTE, \r\n" + // 1
												  "       a.DES_OBRA , \r\n" + // 2
												  "       a.DAT_PREVISAO, " + // 3
 												  "       (select first 1 PRODUTOS from p_produtos_acao(a.SEQ_ACAO)), \r\n" + // 4 produtos
												  "       a.COD_VENDEDOR, \r\n" + // 5
												  "       a.COD_CONSULTOR, \r\n" + // 6
												  "       o.DES_ORIGEM, \r\n" + // 7
												  "       s.DES_SITUACAO, \r\n" + // 8
												  "       a.TXT_OBSERVACAO, \r\n" + // 9
			                                      "       ' ', \r\n" +  // chave 10
			                                      "       a.COD_ORIGEM, \r\n" + // 11
			                                      "       a.IDT_SITUACAO, \r\n" + // 12
												  "       a.TXT_CONCORRENTES, " + // 13
												  "       (select first 1 DAT_PREVISAO from agenda ag where (ag.COD_PARCEIRO = a.COD_CLIENTE or ag.COD_PARCEIRO in (select ca.COD_CLIENTE from CLIENTES_ACAO ca where ca.SEQ_ACAO = a.SEQ_ACAO)) and ag.DAT_PREVISAO < cast('Now' as timestamp) and ag.DAT_SOLUCAO is null), \r\n" + // 14
												  "       (select first 1 DAT_PREVISAO from agenda ag where (ag.COD_PARCEIRO = a.COD_CLIENTE or ag.COD_PARCEIRO in (select ca.COD_CLIENTE from CLIENTES_ACAO ca where ca.SEQ_ACAO = a.SEQ_ACAO))  and ag.DAT_PREVISAO > cast('Now' as timestamp) and ag.DAT_SOLUCAO is null),  \r\n" + // 15
												  "       (select first 1 DAT_PREVISAO from agenda ag where (ag.COD_PARCEIRO = a.COD_CLIENTE or ag.COD_PARCEIRO in (select ca.COD_CLIENTE from CLIENTES_ACAO ca where ca.SEQ_ACAO = a.SEQ_ACAO))  and ag.DAT_SOLUCAO is null),  \r\n" + // 16
												  "       (select min(DAT_AGENDAMENTO) from AGENDAMENTOS_ACOES aa where aa.SEQ_ACAO = a.SEQ_ACAO), \r\n" + // 17 
												  "       (select max(DAT_CONTATO) from AGENDAMENTOS_ACOES aa where aa.SEQ_ACAO = a.SEQ_ACAO), \r\n" + // 18 
												  "       0,  \r\n" + //19 TempoSemRetorno
												  "       p.NOM_PARCEIRO, \r\n" + //20
												  "       (select first 1 CLIENTES from p_clientes_acao(a.SEQ_ACAO)) \r\n" + // 21 clientes
			                                      "from ACOES_COMERCIAIS a \r\n" +
			                                      "left outer join ORIGENS o " +
			                                      "  on o.COD_ORIGEM = a.COD_ORIGEM \r\n" +
			                                      "left outer join SITUACOES_ACAO s \r\n" +
			                                      "  on s.COD_SITUACAO = a.IDT_SITUACAO \r\n" +
			                                      "left outer join PARCEIROS p \r\n" +
			                                      "  on p.COD_PARCEIRO = a.COD_CLIENTE \r\n" +			                                      
			                                      where + " \r\n" +
			                                      "order by a.SEQ_ACAO", 
			                                      Globais.bd);
			adapter.Fill(table);
			table.Columns[0].ColumnName = "Cod";
			table.Columns[1].ColumnName = "Cliente";
			table.Columns[2].ColumnName = "Obra";
			table.Columns[3].ColumnName = "Previsão";
			table.Columns[4].ColumnName = "Produtos";
			table.Columns[5].ColumnName = "Vendedor";
			table.Columns[6].ColumnName = "Consultor";
			table.Columns[7].ColumnName = "Origem";
			table.Columns[8].ColumnName = "Situação";
			table.Columns[9].ColumnName = "Observação";
			table.Columns[10].ColumnName = "Chave";
			table.Columns[11].ColumnName = "CodOrigem";
			table.Columns[12].ColumnName = "CodSituacao";
			table.Columns[13].ColumnName = "Concorrentes";
			table.Columns[14].ColumnName = "Menor";
			table.Columns[15].ColumnName = "Maior";
			table.Columns[16].ColumnName = "Igual";
			table.Columns[17].ColumnName = "1o Contato";
			table.Columns[18].ColumnName = "Último";
			table.Columns[19].ColumnName = "TempoSemRetorno";
			table.Columns[20].ColumnName = "!Nome";
			table.Columns[21].ColumnName = "!Grupo";
			grid.DataSource = table;
			bool b = true;
			DataColumn check = new DataColumn("S", b.GetType());
			table.Columns.Add(check);
			grid.Columns["S"].Visible = false;
			grid.Columns["Observação"].Visible = false;
			grid.Columns["Chave"].Visible = false;
			grid.Columns["CodOrigem"].Visible = false;
			grid.Columns["CodSituacao"].Visible = false;
			grid.Columns["Concorrentes"].Visible = false;
			grid.Columns["Menor"].Visible = false;
			grid.Columns["Maior"].Visible = false;
			grid.Columns["Igual"].Visible = false;
			grid.Columns["TempoSemRetorno"].Visible = false;
			grid.Columns["!Nome"].Visible = false;
			grid.Columns["!Grupo"].Visible = false;
			
			grid.Columns["Cod"].Width = 40;
			
			/*
			string sql = "select a.COD_PRODUTO, p.DES_PRODUTO " +
			             "from PRODUTOS_POR_ACAO a " +
			             "inner join PRODUTOS_ACAO p " +
			             "on p.COD_PRODUTO = a.COD_PRODUTO " +
				"where a.SEQ_ACAO=@seq";
			FbCommand cmd = new FbCommand(sql, Globais.bd);
			cmd.Parameters.Add("@seq", FbDbType.Integer);
			cmd.Prepare();
			*/
									
			foreach (DataGridViewRow row in grid.Rows)
			{
				if (!row.Cells["Cliente"].Value.ToString().Trim().Equals(row.Cells["!Grupo"].Value.ToString().Trim()))
				{
					if (row.Cells["!Grupo"].Value.ToString().Trim().Length > 0) {
					string nome = row.Cells["!Grupo"].Value.ToString();
					string clo = row.Cells["Cliente"].Value.ToString();
					string cod = row.Cells["Cod"].Value.ToString();
					
					Console.WriteLine(cod);
					}
				}
					
				if (row.Cells["Último"].Value.ToString().Equals(""))
				{
					row.Cells["Último"].Value = row.Cells["1o Contato"].Value;
				}
				if (row.Cells["1o Contato"].Value.GetType().FullName.Contains("Date"))
				{
					DateTime contato = (DateTime)row.Cells["1o Contato"].Value;
					TimeSpan ts = DateTime.Now - contato;
					row.Cells["1o Contato"].ToolTipText = contato.ToString("d/M/yyyy") + 
						"\r\nTempo de Negócio: " + ts.Days + " dias";
				} 
				else
				{
					row.Cells["1o Contato"].ToolTipText = "";
				}
				if (row.Cells["Último"].Value.GetType().FullName.Contains("Date"))
				{
					DateTime contato = (DateTime)row.Cells["Último"].Value;
					TimeSpan ts = DateTime.Now - contato;
					string cor = "";
					if (ts.Days > 30) {
						cor = "\r\nLaranja quando sem contato a mais de 30 dias.";
					}
					row.Cells["Último"].ToolTipText = contato.ToString("d/M/yyyy") +
						"\r\nTempo sem Retorno: " + ts.Days + " dias. " + cor;
					row.Cells["TempoSemRetorno"].Value = ts.Days;
				}
				else
				{
					row.Cells["Último"].ToolTipText = "";
					row.Cells["TempoSemRetorno"].Value = 0;
				}
				
				row.Cells["Chave"].Value = 
					row.Cells["Cod"].Value.ToString().Trim();
				
				if (row.Cells["Produtos"].Value != null)
				{
					row.Cells["Produtos"].Value = 
						row.Cells["Produtos"].Value.ToString().Trim();
				}
				
				/*
				cmd.Parameters["@seq"].Value = row.Cells["Cod"].Value;
				FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
				while (reader.Read())
				{
					row.Cells["Produtos"].Value += 
						reader.GetString(0).Trim() + " - " +
						reader.GetString(1).Trim() + "\r\n";
				}
				reader.Close();
				*/
			}
			Log.Grava("debug", "fim: " + DateTime.Now.ToString());
		}
		
		public static void ClientesAcao(DataGridView grid, string where)
		{
			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			adapter.SelectCommand = new FbCommand("select COD_CLIENTE, NRO_CPF_CNPJ " +
			                                      "from CLIENTES_ACAO a " +
												  "inner join PARCEIROS b " +
												  "on b.COD_PARCEIRO = a.COD_CLIENTE " +  
			                                      where +
			                                      " order by COD_CLIENTE",
			                                      Globais.bd);
			adapter.Fill(table);
			table.Columns[0].ColumnName = "Cliente";
			table.Columns[1].ColumnName = "Cpf/Cnpj";
			grid.DataSource = table;
		}		
		
		public static string ClientesAcaoIn(string seq)
		{
			FbCommand cmd = new FbCommand("select COD_CLIENTE " +
			                              "from CLIENTES_ACAO " +
			                              "where SEQ_ACAO=" + seq,
			                              Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			string resp = "";
			while (reader.Read()) {
				string cliente = reader.GetString(0).Trim();
				resp += ",'" + cliente.Trim() + "'";
			}
			reader.Close();
			return resp;
		}				
		
		public static int AcaoCliente(string codCliente)
		{
			FbCommand cmd = new FbCommand("select SEQ_ACAO " +
			                              "from ACOES_COMERCIAIS " +
			                              "where COD_CLIENTE='" + codCliente.Trim() + "'",
			                              Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			int resp = 0;
			if (reader.Read()) {
				resp = reader.GetInt32(0);
			}
			reader.Close();
			if (resp != 0) {
				return resp;
			}

			cmd = new FbCommand("select SEQ_ACAO " +
			                    "from CLIENTES_ACAO " +
			                    "where COD_CLIENTE='" + codCliente.Trim() + "'",
			                    Globais.bd);
			reader = cmd.ExecuteReader(CommandBehavior.Default);
			if (reader.Read()) {
				resp = reader.GetInt32(0);
			}
			reader.Close();
			return resp;
		}				
		
		public static void IncluiClienteAcao(int seq, string cliente) 
		{
			string sql = "insert into CLIENTES_ACAO values(" +
				seq + ", '" + cliente + "')"; 			
			FbCommand cmd = new FbCommand(sql, Globais.bd);
			Log.Grava(Globais.sUsuario, cmd.CommandText);
			cmd.ExecuteNonQuery();
		}
		
		public static void AtualizaClientesAcao(int seq, DataGridView grid) 
		{
			string sql = "delete from CLIENTES_ACAO where SEQ_ACAO=" + seq.ToString();
			FbCommand cmd = new FbCommand(sql, Globais.bd);
			Log.Grava(Globais.sUsuario, cmd.CommandText);
			cmd.ExecuteNonQuery();			
			foreach (DataGridViewRow row in grid.Rows)
			{
				IncluiClienteAcao(seq, row.Cells[0].Value.ToString());
			}
		}		
				
		public static void ClientesDisponiveis(DataGridView grid, string where)
		{
			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			adapter.SelectCommand = new FbCommand("select COD_PARCEIRO, NRO_CPF_CNPJ " +
			                                      "from PARCEIROS " + where +
			                                      " order by COD_PARCEIRO",
			                                      Globais.bd);
			adapter.Fill(table);
			table.Columns[0].ColumnName = "Cliente";
			table.Columns[1].ColumnName = "Cpf/Cnpj";
			grid.DataSource = table;
		}
		
		public static bool VerificaOrcamento(string cliente, string seq)
		{
			string clientes = "'" + cliente.Trim() + "'" + ClientesAcaoIn(seq);
			FbCommand cmd =  new FbCommand("select first 1 COD_ORCAMENTO " +
			                               "from ORCAMENTOS " +
			                               "where COD_CLIENTE in (" + clientes + ")",
			                               Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			bool existe = reader.Read();
			reader.Close();
			return existe;
		}
		
		public static void CarregaContatos(DataGridView grid, string cliente, string seq) 
		{
			string clientes = "'" + cliente.Trim() + "'" + ClientesAcaoIn(seq);
			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			adapter.SelectCommand = new FbCommand("select NOM_CONTATO, " + // 0
			                                      "       NRO_FONE1, " + // 1
												  "       NRO_CELULAR, " + // 2
												  "       DES_EMAIL, " + // 3
 												  "       DES_PAPEL, " + // 4 
												  "       DAT_NASCIMENTO, " + // 5
												  "       COD_CONTATO " + // 6
			                                      "from CONTATOS " +
			                                      "where COD_PARCEIRO in (" + clientes + ") " +
			                                      "and IDT_ATIVO = 'S'", 
			                                      Globais.bd);
			adapter.Fill(table);
			table.Columns[0].ColumnName = "Nome";
			table.Columns[1].ColumnName = "Fone";
			table.Columns[2].ColumnName = "Celular";
			table.Columns[3].ColumnName = "Email";
			table.Columns[4].ColumnName = "Papel";
			table.Columns[5].ColumnName = "Nascimento";
			table.Columns[6].ColumnName = "CodContato";
			grid.DataSource = table;
			grid.Columns["Nascimento"].Visible = false;
			grid.Columns["CodContato"].Visible = false;
			
			foreach (DataGridViewRow row in grid.Rows)
			{
				row.Cells["Fone"].Value = 
					FONE.PoeEdicao(row.Cells["Fone"].Value.ToString());
				row.Cells["Celular"].Value = 
					CELULAR.PoeEdicao(row.Cells["Celular"].Value.ToString());
			}
		}
		
		public static void CarregaParceiro(DataGridView grid, string cliente) 
		{
			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			adapter.SelectCommand = new FbCommand("select NOM_PARCEIRO, " + // 0
			                                      "       NRO_FONE1, " + // 1
												  "       NRO_CELULAR, " + // 2
												  "       DES_EMAIL, " + // 3
 												  "       '.', " + // 4 
												  "       DAT_NASCIMENTO, " + // 5
												  "       COD_PARCEIRO " + // 6
			                                      "from PARCEIROS " +
			                                      "where COD_PARCEIRO='" + cliente + "' " +
			                                      "and IDT_ATIVO = 'S'", 
			                                      Globais.bd);
			adapter.Fill(table);
			table.Columns[0].ColumnName = "Nome";
			table.Columns[1].ColumnName = "Fone";
			table.Columns[2].ColumnName = "Celular";
			table.Columns[3].ColumnName = "Email";
			table.Columns[4].ColumnName = "Papel";
			table.Columns[5].ColumnName = "Nascimento";
			table.Columns[6].ColumnName = "CodContato";
			grid.DataSource = table;
			grid.Columns["Nascimento"].Visible = false;
			grid.Columns["CodContato"].Visible = false;
			
			foreach (DataGridViewRow row in grid.Rows)
			{
				row.Cells["Fone"].Value = 
					FONE.PoeEdicao(row.Cells["Fone"].Value.ToString());
				row.Cells["Celular"].Value = 
					CELULAR.PoeEdicao(row.Cells["Celular"].Value.ToString());
			}
		}
		
		public static void CarregaHistorico(DataGridView grid, string cliente, string contato, int seqAcao)
		{
			string clientes = "'" + cliente.Trim() + "'" + ClientesAcaoIn(seqAcao.ToString());
			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			adapter.SelectCommand = new FbCommand("select a.DAT_AGENDAMENTO, " + // 0
			                                      "       a.DAT_PREVISAO, " + // 1
												  "       a.DAT_SOLUCAO, " + // 2
												  "       a.COD_RESPONSAVEL, " + // 3
												  "       a.COD_USUARIO, " + // 4
												  "       a.COD_NATUREZA," + // 5
												  "       a.COD_CONTATO, " + // 6
												  "       ' ', " + // 7
												  "       a.DAT_SOLUCAO,  " + // 8
												  "       (select 1 from AGENDAMENTOS_ACOES aa " +
												  "               where aa.SEQ_ACAO = " + seqAcao + " and " +
												  "               aa.COD_USUARIO = a.COD_USUARIO and " +
												  "               aa.DAT_AGENDAMENTO =a.DAT_AGENDAMENTO) "+
												  "               as PERTENCE_ACAO " + // 9
			                                      "from AGENDA a " +
			                                      "where a.COD_PARCEIRO in (" + clientes + ") ",
			                                      //"and COD_CONTATO='" + contato + "' ",
			                                      Globais.bd);
			adapter.Fill(table);
			table.Columns[0].ColumnName = "Agendamento";
			table.Columns[1].ColumnName = "Previsão";
			table.Columns[2].ColumnName = "Realização";
			table.Columns[3].ColumnName = "Responsável";
			table.Columns[4].ColumnName = "CodUsuario";
			table.Columns[5].ColumnName = "Natureza";
			table.Columns[6].ColumnName = "Contato";
			table.Columns[7].ColumnName = "Situação";
			table.Columns[8].ColumnName = "Solução";
			table.Columns[9].ColumnName = "PertenceAcao";
			grid.DataSource = table;
			grid.Columns["Agendamento"].Visible = false;
			grid.Columns["CodUsuario"].Visible = false;
			grid.Columns["Solução"].Visible = false;
			grid.Columns["PertenceAcao"].Visible = false;			
		}		
		
		public static void CarregaHistoricoPorUsuario(DataGridView grid, string usuario)
		{
			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			adapter.SelectCommand = new FbCommand("select a.DAT_AGENDAMENTO, " + // 0
			                                      "       a.DAT_PREVISAO, " + // 1
												  "       a.COD_PARCEIRO, " + // 2
												  "       a.COD_USUARIO, " + // 3
												  "       a.COD_NATUREZA," + // 4
												  "       a.COD_CONTATO, " + // 5
												  "       p.NRO_FONE1, " + // 6												  
												  "       a.DES_PENDENCIA, " + // 7
												  "       ' ', " + // 8
												  "       c.NRO_FONE1 as FONE_CONTATO " + // 9																								  
			                                      "from AGENDA a " +
			                                      "left outer join PARCEIROS p " +
			                                      "on p.COD_PARCEIRO = a.COD_PARCEIRO " +
			                                      "left outer join CONTATOS c " +
			                                      "on c.COD_PARCEIRO = a.COD_PARCEIRO " +
			                                      "   and c.COD_CONTATO =  a.COD_CONTATO " +                                      
			                                      "where a.COD_RESPONSAVEL='" + usuario + "' " +
			                                      "  and a.DAT_SOLUCAO is null " +
			                                      "  order by a.DAT_PREVISAO",
			                                      Globais.bd);
			adapter.Fill(table);
			table.Columns[0].ColumnName = "Agendamento";
			table.Columns[1].ColumnName = "Previsão";
			table.Columns[2].ColumnName = "Parceiro";
			table.Columns[3].ColumnName = "CodUsuario";
			table.Columns[4].ColumnName = "Natureza";
			table.Columns[5].ColumnName = "Contato";
			table.Columns[6].ColumnName = "Fone";			
			table.Columns[7].ColumnName = "Pendência";			
			table.Columns[8].ColumnName = "Situação";
			table.Columns[9].ColumnName = "FoneContato";

			grid.DataSource = table;
			grid.Columns["Agendamento"].Visible = false;
			grid.Columns["CodUsuario"].Visible = false;
			grid.Columns["Pendência"].Visible = false;
			grid.Columns["FoneContato"].Visible = false;
			grid.Columns["Parceiro"].Width = 200;
			grid.Columns["Situação"].Width = 80;
			foreach (DataGridViewRow row in grid.Rows)
			{
				if (row.Cells["FoneContato"].Value != null) {
					row.Cells["Fone"].Value = row.Cells["FoneContato"].Value;
				}
				if (row.Cells["Fone"].Value != null) {
					row.Cells["Fone"].Value = 
						FONE.PoeEdicao(row.Cells["Fone"].Value.ToString());
				}
			}
		}

		public static void Estatisticas(DataGridView dgvAcoes, DataGridView dgvOrcamentos, string usuario,
		                               ref int nTotalAcoes,
		                               ref float vTotalAcoes,
		                               ref int nConcretizadas, 
		                               ref float vConcretizadas,
		                               ref int pConcretizadas,
		                               ref int nTotalOrcamentos,
		                               ref float vTotalOrcamentos		                               
		                              )
		{
			int n;
			float v;
			
			string whereVendedor = "";
			if (!usuario.Trim().Equals(""))
			{
				whereVendedor = " and COD_VENDEDOR = '" + usuario.Trim() + "'";
			}
			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			adapter.SelectCommand = new FbCommand("select s.DES_SITUACAO, s.IDT_CONCRETIZADA, " +
			                                      "0 as N, " +
												  "0 as Valor, " +
			                                      "' ', s.COD_SITUACAO  " +
			                                      "from situacoes_acao s order by s.DES_SITUACAO",
			                                      Globais.bd);
			adapter.Fill(table);
			table.Columns[0].ColumnName = "Situação";
			table.Columns[1].ColumnName = "Concretizada";
			table.Columns[2].ColumnName = "Ações";
			table.Columns[3].ColumnName = "Valor";
			table.Columns[4].ColumnName = "%";
			table.Columns[5].ColumnName = "CodSituacao";
			dgvAcoes.DataSource = table;
			dgvAcoes.Columns["Situação"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			dgvAcoes.Columns["Situação"].Width = 250;
			dgvAcoes.Columns["Ações"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			dgvAcoes.Columns["%"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			dgvAcoes.Columns["Valor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			dgvAcoes.Columns["Valor"].DefaultCellStyle.Format = "###,###,##0.00";			
			dgvAcoes.Columns["Concretizada"].Visible = false;
			dgvAcoes.Columns["Valor"].Visible = false;
			dgvAcoes.Columns["Ações"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
			dgvAcoes.Columns["%"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
			dgvAcoes.Columns["Valor"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
			dgvAcoes.Columns["CodSituacao"].Visible = false;
			
			nTotalAcoes = 0;
			vTotalAcoes = 0;
			nConcretizadas = 0;
			vConcretizadas = 0;
			
			foreach (DataGridViewRow row in dgvAcoes.Rows)
			{
				n = 0; // numero de orcamentos de todos os clientes da acao
				v = 0;
				int nAcoes= 0; // numero de acoes com a situacao
				
				string sql1 = "select SEQ_ACAO, COD_CLIENTE " +
					"from ACOES_COMERCIAIS " +
					"where " +
					"IDT_SITUACAO = '" + row.Cells["CodSituacao"].Value.ToString().Trim() + "' " +
					whereVendedor;
				FbCommand cmd1 =  new FbCommand(sql1, Globais.bd);
				FbDataReader reader1 = cmd1.ExecuteReader(CommandBehavior.Default);
				while (reader1.Read())
				{
					int seq = reader1.GetInt32(0);
					string clientes = "'" + reader1.GetString(1).Trim() + "'";
					nAcoes++;
					
					string sql2 = "select COD_CLIENTE " +
						"from CLIENTES_ACAO " +
						"where SEQ_ACAO = " + seq.ToString();
					FbCommand cmd2 =  new FbCommand(sql2, Globais.bd);
					FbDataReader reader2 = cmd2.ExecuteReader(CommandBehavior.Default);
					while (reader2.Read())
					{
						clientes += ",'" + reader2.GetString(0) + "'";
					}
					reader2.Close();
					
					string sql3 = "select count(VLR_ORCAMENTO) as N, " +
						"coalesce(sum(VLR_ORCAMENTO), 0) as VLR " +
						"from ORCAMENTOS " +
						"where COD_CLIENTE in (" + clientes + ")";
					FbCommand cmd3 =  new FbCommand(sql3, Globais.bd);
					FbDataReader reader3 = cmd3.ExecuteReader(CommandBehavior.Default);
					if (reader3.Read())
					{
						n += reader3.GetInt32(0);
						v += reader3.GetFloat(1);
					}
					reader3.Close();
				}
				row.Cells["Ações"].Value = nAcoes;
				row.Cells["Valor"].Value = v;
				nTotalAcoes += nAcoes;
				vTotalAcoes += v;				
				
				if (row.Cells["Concretizada"].Value.ToString().Equals("S"))
				{
					nConcretizadas += nAcoes;
					vConcretizadas += v;
				}
			}
			
			pConcretizadas = nTotalAcoes > 0
				? (int) (nConcretizadas * 100 / nTotalAcoes)
				: 0;
			
			foreach (DataGridViewRow row in dgvAcoes.Rows)
			{
				n =  0;
				int.TryParse(row.Cells["Ações"].Value.ToString(), out n);
				int percentual = nTotalAcoes > 0
					? (int) (n * 100 / nTotalAcoes)
					: 0;
				row.Cells["%"].Value = percentual.ToString();
			}
			
			adapter = new FbDataAdapter();
			table = new DataTable();
			adapter.SelectCommand = new FbCommand("select DES_SITUACAO,IDT_CONCRETIZADO, "
				+ "0 as QTDE, "
				+ "0 as VALOR, "
				+ "' ', COD_SITUACAO from SITUACOES order by COD_SITUACAO",
				Globais.bd);
			adapter.Fill(table);
			table.Columns[0].ColumnName = "Situação";
			table.Columns[1].ColumnName = "Concretizado";
			table.Columns[2].ColumnName = "Orçamentos";
			table.Columns[3].ColumnName = "Valor";
			table.Columns[4].ColumnName = "%";
			table.Columns[5].ColumnName = "CodSituacao";
			dgvOrcamentos.DataSource = table;
			dgvOrcamentos.Columns["Situação"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			dgvOrcamentos.Columns["Situação"].Width = 250;			
			//dgvOrcamentos.Columns["Valor"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			//dgvOrcamentos.Columns["Valor"].Width = 120;						
			dgvOrcamentos.Columns["Orçamentos"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			dgvOrcamentos.Columns["%"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			dgvOrcamentos.Columns["Valor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;			
			dgvOrcamentos.Columns["Valor"].DefaultCellStyle.Format = "#,###,##0.00";
			dgvOrcamentos.Columns["Concretizado"].Visible = false;
			dgvOrcamentos.Columns["%"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
			dgvOrcamentos.Columns["Orçamentos"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
			dgvOrcamentos.Columns["Valor"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
			dgvOrcamentos.Columns["CodSituacao"].Visible = false;
			dgvOrcamentos.Columns["%"].Visible = false;
			
			nTotalOrcamentos = 0;
			vTotalOrcamentos = 0;
			
			foreach (DataGridViewRow row in dgvOrcamentos.Rows)
			{
				n = 0;
				v = 0;
				
				string sql3 = "select count(VLR_ORCAMENTO) as N, " +
					"coalesce(sum(VLR_ORCAMENTO), 0) - coalesce(sum(VLR_DESCONTO), 0) as VLR " +
					"from ORCAMENTOS " +
					"where COD_VENDEDOR = '" + usuario.Trim() + "'" + " and " +
					"COD_SITUACAO ='" + row.Cells["CodSituacao"].Value.ToString().Trim() + "'";
				FbCommand cmd3 =  new FbCommand(sql3, Globais.bd);
				FbDataReader reader3 = cmd3.ExecuteReader(CommandBehavior.Default);
				if (reader3.Read())
				{
					n += reader3.GetInt32(0);
					v += reader3.GetFloat(1);
				}
				reader3.Close();
				
				row.Cells["Orçamentos"].Value = n;
				row.Cells["Valor"].Value = v;
				nTotalOrcamentos += n;
				vTotalOrcamentos += v;										
			
			}
			
		}
		
		public static void Estatisticas2(DataGridView dgvAcoes, DataGridView dgvOrcamentos, string usuario,
		                               ref int nTotalAcoes,
		                               ref float vTotalAcoes,
		                               ref int nConcretizadas, 
		                               ref float vConcretizadas,
		                               ref int pConcretizadas,
		                               ref int nTotalOrcamentos,
		                               ref float vTotalOrcamentos,
		                               ref int nConcretizados, 
		                               ref float vConcretizados,
		                               ref int pConcretizados                      
		                              )
		{
			string whereVendedor = "";
			if (!usuario.Trim().Equals(""))
			{
				whereVendedor = " a.COD_VENDEDOR = '" + usuario.Trim() + "' and";
			}
			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			adapter.SelectCommand = new FbCommand("select s.DES_SITUACAO, s.IDT_CONCRETIZADA, " +
			                                      "(select count(*) from acoes_comerciais a " +
			                                      " where" + whereVendedor + " a.IDT_SITUACAO = s.COD_SITUACAO) as N, " +
												  "(select sum(VLR_ORCAMENTO) from orcamentos o " +
												  " inner join ACOES_COMERCIAIS a on a.IDT_SITUACAO = s.COD_SITUACAO " +
												  " where" + whereVendedor + " o.COD_CLIENTE = a.COD_CLIENTE) as Valor, " +
			                                      "' ' " +
			                                      "from situacoes_acao s order by  s.DES_SITUACAO",
			                                      //"union select 'Concretizadas', 'N', 0, ' ' from rdb$database ",
			                                      Globais.bd);
			adapter.Fill(table);
			table.Columns[0].ColumnName = "Situação";
			table.Columns[1].ColumnName = "Concretizada";
			table.Columns[2].ColumnName = "Ações";
			table.Columns[3].ColumnName = "Valor";
			table.Columns[4].ColumnName = "%";
			dgvAcoes.DataSource = table;
			dgvAcoes.Columns["Situação"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			dgvAcoes.Columns["Situação"].Width = 250;
			dgvAcoes.Columns["Ações"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			dgvAcoes.Columns["%"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			dgvAcoes.Columns["Valor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			dgvAcoes.Columns["Valor"].DefaultCellStyle.Format = "###,###,##0.00";			
			dgvAcoes.Columns["Concretizada"].Visible = false;
			dgvAcoes.Columns["Valor"].Visible = false;
			dgvAcoes.Columns["Ações"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
			dgvAcoes.Columns["%"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
			dgvAcoes.Columns["Valor"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
			nTotalAcoes = 0;
			vTotalAcoes = 0;
			nConcretizadas = 0;
			vConcretizadas = 0;
			foreach (DataGridViewRow row in dgvAcoes.Rows)
			{
				int n = 0;
				int.TryParse(row.Cells["Ações"].Value.ToString(), out n);
				nTotalAcoes += n;
				float v =  0;
				float.TryParse(row.Cells["Valor"].Value.ToString(), out v);
				vTotalAcoes += v;				
				if (row.Cells["Concretizada"].Value.ToString().Equals("S"))
				{
					nConcretizadas += n;
					vConcretizadas += v;
				}
			}
			pConcretizadas = (int) (nConcretizadas * 100 / nTotalAcoes);
			foreach (DataGridViewRow row in dgvAcoes.Rows)
			{
				//if (!row.Cells["Situação"].Value.ToString().Equals("Concretizada")) {
				int n =  0;
				int.TryParse(row.Cells["Ações"].Value.ToString(), out n);
				int percentual = (int) (n * 100 / nTotalAcoes);
				row.Cells["%"].Value = percentual.ToString();
				//}
			}
			/*
			foreach (DataGridViewRow row in dgvAcoes.Rows)
			{
				if (row.Cells["Situação"].Value.ToString().Equals("Concretizada")) {
					row.Cells["Ações"].Value = concretizadas.ToString();					
					int n =  int.Parse(row.Cells["Ações"].Value.ToString());
					int percentual = (int) (n * 100 / total);
					row.Cells["%"].Value = percentual.ToString();
				}
			}
			*/


			adapter = new FbDataAdapter();
			table = new DataTable();
			whereVendedor = "";
			if (!usuario.Trim().Equals(""))
			{
				whereVendedor = " o.COD_VENDEDOR = '" + usuario.Trim() + "' and";
			}			
			adapter.SelectCommand = new FbCommand("select DES_SITUACAO,IDT_CONCRETIZADO, "
				+ "(select count(*) from orcamentos o inner join ACOES_COMERCIAIS a on a.COD_CLIENTE = o.COD_CLIENTE "
				+ "where" + whereVendedor + " o.COD_SITUACAO=SITUACOES.COD_SITUACAO) as QTDE, "
				+ "(select sum(VLR_ORCAMENTO) from orcamentos o inner join ACOES_COMERCIAIS a on a.COD_CLIENTE = o.COD_CLIENTE "
				+ "where" + whereVendedor + " o.COD_SITUACAO=SITUACOES.COD_SITUACAO) as VALOR, "
				+ "' ' from SITUACOES order by COD_SITUACAO",
				Globais.bd);
			adapter.Fill(table);
			table.Columns[0].ColumnName = "Situação";
			table.Columns[1].ColumnName = "Concretizado";
			table.Columns[2].ColumnName = "Orçamentos";
			table.Columns[3].ColumnName = "Valor";
			table.Columns[4].ColumnName = "%";
			dgvOrcamentos.DataSource = table;
			dgvOrcamentos.Columns["Situação"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			dgvOrcamentos.Columns["Situação"].Width = 250;			
			dgvOrcamentos.Columns["Valor"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			dgvOrcamentos.Columns["Valor"].Width = 120;						
			dgvOrcamentos.Columns["Orçamentos"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			dgvOrcamentos.Columns["%"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			dgvOrcamentos.Columns["Valor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;			
			dgvOrcamentos.Columns["Valor"].DefaultCellStyle.Format = "#,###,##0.00";
			dgvOrcamentos.Columns["Concretizado"].Visible = false;
			dgvOrcamentos.Columns["%"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
			dgvOrcamentos.Columns["Orçamentos"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
			dgvOrcamentos.Columns["Valor"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
			
			nTotalOrcamentos = 0;
			vTotalOrcamentos = 0;
			nConcretizados = 0;
			vConcretizados = 0;
			foreach (DataGridViewRow row in dgvOrcamentos.Rows)
			{
				int n =  0;
				int.TryParse(row.Cells["Orçamentos"].Value.ToString(), out n);
				nTotalOrcamentos += n;
				float v = 0;
				float.TryParse(row.Cells["Valor"].Value.ToString(), out v);
				vTotalOrcamentos += v;				
				if (row.Cells["Concretizado"].Value.ToString().Equals("S"))
				{
					nConcretizados += n;
					vConcretizados += v;
				}
			}
			pConcretizados = (int) (nConcretizados * 100 / nTotalOrcamentos);
			foreach (DataGridViewRow row in dgvOrcamentos.Rows)
			{
				int n = 0;
				int.TryParse(row.Cells["Orçamentos"].Value.ToString(), out n);
				int percentual = (int) (n * 100 / nTotalOrcamentos);
				row.Cells["%"].Value = percentual.ToString();
			}
			
		}
		
		public static void CarregaVendedores(ComboBox cbx)
		{
			FbCommand fbCommand = new FbCommand(
				"select distinct COD_VENDEDOR from ACOES_COMERCIAIS "
				+ "order by COD_VENDEDOR", 
				Globais.bd);
			FbDataReader fbDataReader = fbCommand.ExecuteReader(CommandBehavior.Default);
			while (fbDataReader.Read()) {
				string item = fbDataReader.GetString(0).Trim();
				cbx.Items.Add(item);
			}
			fbDataReader.Close();
		}
		
		public static void Inclui(AcaoComercial acao) 
		{
			string sql = "insert into ACOES_COMERCIAIS values(" +
				"gen_id(GEN_ACAO_COMERCIAL, 1)," +
				"'"  + acao.CodCliente + "', " +
				"'"  + acao.DesObra + "', " +
				"'"  + acao.DatPrevisao.ToString("M/d/yyyy") + "', " +
				"'"  + acao.CodVendedor + "', " +
				"'"  + acao.CodConsultor + "', " +
				"'"  + acao.IdtSituacao + "', " +
				"'"  + acao.TxtObservacao + "', " +
				"'"  + acao.CodOrigem + "', " +
				"'"  + acao.TxtConcorrentes + "', " +
				"'"  + DateTime.Now.ToString("M/d/yyyy") + "', " +
				"null)";
 			
			FbCommand cmd = new FbCommand(sql, Globais.bd);
			Log.Grava(Globais.sUsuario, cmd.CommandText);
			cmd.ExecuteNonQuery();
			
			sql = "select gen_id(GEN_ACAO_COMERCIAL, 0) from rdb$database";
			cmd = new FbCommand(sql, Globais.bd);			
			FbDataReader reader = cmd.ExecuteReader();
			if (reader.Read())
			{
				acao.SeqAcao = reader.GetInt32(0);
			}
			reader.Close();
		}
		
		public static void Altera(AcaoComercial acao) 
		{
			string sql = "update ACOES_COMERCIAIS set " +
				"COD_CLIENTE = '"  + acao.CodCliente + "', " +
				"DES_OBRA = '"  + acao.DesObra + "', " +
				"DAT_PREVISAO = '"  + acao.DatPrevisao.ToString("M/d/yyyy") + "', " +
				"COD_VENDEDOR = '"  + acao.CodVendedor + "', " +
				"COD_CONSULTOR = '"  + acao.CodConsultor + "', " +
				"COD_ORIGEM = '"  + acao.CodOrigem + "', " +
				"IDT_SITUACAO = '"  + acao.IdtSituacao + "', " +
				"TXT_OBSERVACAO = '"  + acao.TxtObservacao + "', " +
				"TXT_CONCORRENTES = '"  + acao.TxtConcorrentes + "' " +
				"where SEQ_ACAO = "  + acao.SeqAcao + "";
 			
			FbCommand cmd = new FbCommand(sql, Globais.bd);
			Log.Grava(Globais.sUsuario, cmd.CommandText);
			cmd.ExecuteNonQuery();
		}		
		
		public static void Exclui(AcaoComercial acao) 
		{
			string sql = "delete from ACOES_COMERCIAIS " +
				"where SEQ_ACAO = " + acao.SeqAcao.ToString();
			FbCommand cmd = new FbCommand(sql, Globais.bd);
			Log.Grava(Globais.sUsuario, cmd.CommandText);
			cmd.ExecuteNonQuery();
			
			sql = "delete from CLIENTES_ACAO " +
				"where SEQ_ACAO = " + acao.SeqAcao.ToString();
			cmd = new FbCommand(sql, Globais.bd);
			Log.Grava(Globais.sUsuario, cmd.CommandText);
			cmd.ExecuteNonQuery();
			
		}
		
		public AcaoDAO()
		{
		}

	}
}