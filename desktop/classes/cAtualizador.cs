/*
 * Atualizador automático da base de dados
 * Autor: Ricardo Costa Xavier
 * Data : 16/07/2011
 * 
 * 23/08/2015 - atualização dos bancos da NEO e BHTENNIS
 * 04/10/2015 - inclusão do idt_generico na tabela de produtos
 */

using System;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using System.Windows.Forms;

namespace classes
{
	/// <summary>
	/// Atualizador automático da base de dados
	/// </summary>
	public class cAtualizador
	{		
		int atualizacoes=0;
		public cAtualizador()
		{
			if (!DataNascimentoParceiros()) return;
			if (!DataNascimentoContatos()) return;
			if (!DataNascimentoFuncionarios()) return;
			if (!IdtIpiCaracteristicas()) return;
			if (!IdentidadeCpfFuncionarios()) return;
			if (!IdtAtivoTabelaPrecos()) return;
			if (!AvisosPedido()) return;
			if (!SeqSistema()) return;
			if (!Mensagens()) return;
			if (!AcoesComerciais()) return;
			if (!IdtsSituacoes()) return;
			if (!TraceWeb()) return;
			if (!ProdutoGenerico()) return;
			if (!DiretorioFilial()) return;
			if (atualizacoes > 0) 
			{
				MessageBox.Show("Banco de dados atualizado com sucesso:\r\n" + 
				                "Foram feitas " + atualizacoes.ToString() + " atualizações no banco de dados",
				                "Atualização do banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		
		/// <summary>
		/// Criação das tabelas de Trace e Web
		/// TRACE
		/// GEN_TRACE
		/// SESSOES
		/// WEB
		/// HISTORICO_SITE
		/// 23/08/2015
		/// </summary>
		/// <returns>true=OK</returns>
		private bool TraceWeb()
		{
			string sql="";
			try
			{
				sql = "select first 1 SEQ from TRACE";
				FbCommand cmd = new FbCommand(sql, Globais.bd);
				FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
				reader.Close();
				return true;
			}
			catch
			{
				try 
				{
					sql = "create table TRACE("
						+ " SEQ                             INTEGER Not Null"
						+ ",DATAHORA                        TIMESTAMP"
						+ ",USUAARIO                        CHAR(20)"
						+ ",MENSAGEM                        VARCHAR(100))";
					FbCommand cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					
					sql = "create generator GEN_TRACE";
					cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					
					sql = "create table SESSOES("
						+ " DAT_ABERTURA                    DATE"
						+ ",COD_SESSAO                      CHAR(32)"
						+ ",COD_USUARIO                     CHAR(20))";
					cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					
					sql = "create table WEB("
						+ " COD_USUARIO                     CHAR(20) Not Null"
						+ ",DES_SENHA                       CHAR(32)"
						+ ",NRO_ACESSOS                     INTEGER"
						+ ",DAT_ULTIMO_ACESSO               DATE"
						+ ",constraint PK_WEB primary key(COD_USUARIO))";
					cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					
					sql = "create table HISTORICO_SITE("
						+ " DATA                            TIMESTAMP Not Null"
						+ ",SESSAO                          CHAR(32)"
						+ ",CLIENTE                         CHAR(20)"
						+ ",IP                              CHAR(32)"
						+ ",USUARIO                         CHAR(20)"
						+ ",DATA_SAIDA                      TIMESTAMP"
						+ ",constraint PK_HISTORICO_SITE primary key(DATA, SESSAO))";
					cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					
					atualizacoes++;
					return true;
				}
				catch (Exception e)
				{
					Log.Grava(Globais.sUsuario, "erro:" + e.Message);
					MessageBox.Show("Erro na execução do comando:\r\n" + sql + "\r\n" + e.Message,
					                "Erro na atualização do banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
			}			
		}				
		
		/// <summary>
		/// Criação das tabelas de ações comerciais
		/// ACOES_COMERCIAIS
		/// AGENDAMENTOS_ACOES
		/// PRODUTOS_ACAO
		/// PRODUTOS_POR_ACAO
		/// SITUACOES_ACAO
		/// ORIGENS
		/// GEN_ACAO_COMERCIAL
		/// 23/08/2015
		/// </summary>
		/// <returns>true=OK</returns>
		private bool AcoesComerciais()
		{
			string sql="";
			try
			{
				sql = "select first 1 SEQ_ACAO from ACOES_COMERCIAIS";
				FbCommand cmd = new FbCommand(sql, Globais.bd);
				FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
				reader.Close();
				return true;
			}
			catch
			{
				try 
				{
					sql = "create table ACOES_COMERCIAIS("
						+ " SEQ_ACAO                        INTEGER Not Null"
						+ ",COD_CLIENTE                     CHAR(20)"
						+ ",DES_OBRA                        CHAR(30)"
						+ ",DAT_PREVISAO                    DATE"
						+ ",COD_VENDEDOR                    CHAR(20)"
						+ ",COD_CONSULTOR                   CHAR(20)"
						+ ",IDT_SITUACAO                    CHAR(2)"
						+ ",TXT_OBSERVACAO                  VARCHAR(4000)"
						+ ",COD_ORIGEM                      CHAR(10)"
						+ ",TXT_CONCORRENTES                VARCHAR(4000)"
						+ ",DAT_PRIM_CONTATO                DATE"
						+ ",DAT_ULT_CONTATO                 DATE"
						+ ",constraint PK_ACOES_COMERCIAIS primary key(SEQ_ACAO))";
					FbCommand cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					
					sql = "create table AGENDAMENTOS_ACOES("
						+ " SEQ_ACAO                        INTEGER Not Null"
						+ ",COD_USUARIO                     CHAR(20)"
						+ ",DAT_AGENDAMENTO                 TIMESTAMP"
						+ ",constraint PK_AGENDAMENTOS_ACOES primary key(SEQ_ACAO, COD_USUARIO, DAT_AGENDAMENTO))";
					cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					
					sql = "create table PRODUTOS_ACAO("
						+ " COD_PRODUTO                     CHAR(10) Not Null"
						+ ",DES_PRODUTO                     CHAR(50)"
						+ ",constraint PK_PRODUTOS_ACAO primary key(COD_PRODUTO))";
					cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					
					sql = "create table PRODUTOS_POR_ACAO("
						+ " SEQ_ACAO                        INTEGER Not Null"
						+ ",COD_PRODUTO                     CHAR(10)"
						+ ",constraint PK_PRODUTOS_POR_ACAO primary key(SEQ_ACAO, COD_PRODUTO))";
					cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					
					sql = "create table SITUACOES_ACAO("
						+ " COD_SITUACAO                    CHAR(2) Not Null"
						+ ",DES_SITUACAO                    CHAR(50)"
						+ ",IDT_APRESENTA_AUTOM             CHAR(1)"
						+ ",IDT_CONCRETIZADA                CHAR(1)"
						+ ",constraint PK_SITUACOES_ACAO primary key(COD_SITUACAO))";
					cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					
					sql = "create table ORIGENS("
						+ " COD_ORIGEM                      CHAR(10) Not Null"
						+ ",DES_ORIGEM                      CHAR(50)"
						+ ",constraint PK_ORIGENS primary key(COD_ORIGEM))";
					cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					
					sql = "create generator GEN_ACAO_COMERCIAL";
					cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					
					atualizacoes++;
					return true;
				}
				catch (Exception e)
				{
					Log.Grava(Globais.sUsuario, "erro:" + e.Message);
					MessageBox.Show("Erro na execução do comando:\r\n" + sql + "\r\n" + e.Message,
					                "Erro na atualização do banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
			}			
		}		
		
		/// <summary>
		/// Inclusão dos campos IDT_AVISO e IDT_CONCRETIZADO na tabela SITUACOES
		/// 23/08/2015
		/// </summary>
		/// <returns>true=OK</returns>
		private bool IdtsSituacoes()
		{
			string sql="";
			try
			{
				sql = "select first 1 IDT_AVISO from SITUACOES";
				FbCommand cmd = new FbCommand(sql, Globais.bd);
				FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
				reader.Close();
				return true;
			}
			catch
			{
				try 
				{
					sql = "alter table SITUACOES add IDT_AVISO char(1)";
					FbCommand cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					
					sql = "alter table SITUACOES add IDT_CONCRETIZADO char(1)";
					cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					
					sql = "update SITUACOES set IDT_AVISO='N',IDT_CONCRETIZADO='N'";
					cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					
					atualizacoes++;
					return true;
				}
				catch (Exception e)
				{
					Log.Grava(Globais.sUsuario, "erro:" + e.Message);
					MessageBox.Show("Erro na execução do comando:\r\n" + sql + "\r\n" + e.Message,
					                "Erro na atualização do banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
			}			
		}		
		
		/// <summary>
		/// Inclusão do campo SEQ na tabela SISTEMAS
		/// 23/08/2015
		/// </summary>
		/// <returns>true=OK</returns>
		private bool SeqSistema()
		{
			string sql="";
			try
			{
				sql = "select first 1 SEQ from SISTEMAS";
				FbCommand cmd = new FbCommand(sql, Globais.bd);
				FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
				reader.Close();
				return true;
			}
			catch
			{
				try 
				{
					sql = "alter table SISTEMAS add SEQ integer";
					FbCommand cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					
					sql = "update SISTEMAS set SEQ=COD_SISTEMA where COD_SISTEMA < 4";
					cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					
					sql = "update SISTEMAS set SEQ=COD_SISTEMA+1 where COD_SISTEMA >= 4";
					cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();					
					
					sql = "insert into SISTEMAS values (9, 'Ação Comercial', 'acao', 4)";
					cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();		
					
					atualizacoes++;
					return true;
				}
				catch (Exception e)
				{
					Log.Grava(Globais.sUsuario, "erro:" + e.Message);
					MessageBox.Show("Erro na execução do comando:\r\n" + sql + "\r\n" + e.Message,
					                "Erro na atualização do banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
			}			
		}		
		
		/// <summary>
		/// Criação da tabela MENSAGENS
		/// 23/08/2015
		/// </summary>
		/// <returns>true=OK</returns>
		private bool Mensagens()
		{
			string sql="";
			try
			{
				sql = "select first 1 DATA from MENSAGENS";
				FbCommand cmd = new FbCommand(sql, Globais.bd);
				FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
				reader.Close();
				return true;
			}
			catch
			{
				try 
				{
					sql = "create table MENSAGENS("
						+ " DATA      TIMESTAMP Not Null"
						+ ",USUARIO   CHAR(20)"
						+ ",MENSAGEM  VARCHAR(1000))";
					FbCommand cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					
					atualizacoes++;
					return true;
				}
				catch (Exception e)
				{
					Log.Grava(Globais.sUsuario, "erro:" + e.Message);
					MessageBox.Show("Erro na execução do comando:\r\n" + sql + "\r\n" + e.Message,
					                "Erro na atualização do banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
			}			
		}		

		/// <summary>
		/// Inclusão do campo DAT_NASCIMENTO na tabela PARCEIROS
		/// 16/07/2011
		/// </summary>
		/// <returns>true=OK</returns>
		private bool DataNascimentoParceiros()
		{
			string sql="";
			try
			{
				sql = "select first 1 DAT_NASCIMENTO from PARCEIROS";
				FbCommand cmd = new FbCommand(sql, Globais.bd);
				FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
				reader.Close();
				return true;
			}
			catch
			{
				try 
				{
					sql = "alter table PARCEIROS add DAT_NASCIMENTO date";
					FbCommand cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					sql = "update PARCEIROS set DAT_NASCIMENTO=null";
					cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					atualizacoes++;
					return true;
				}
				catch (Exception e)
				{
					Log.Grava(Globais.sUsuario, "erro:" + e.Message);
					MessageBox.Show("Erro na execução do comando:\r\n" + sql + "\r\n" + e.Message,
					                "Erro na atualização do banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
			}			
		}
		
		/// <summary>
		/// Inclusão do campo DAT_NASCIMENTO na tabela CONTATOS
		/// 16/07/2011
		/// </summary>
		/// <returns>true=OK</returns>
		private bool DataNascimentoContatos()
		{
			string sql="";
			try
			{
				sql = "select first 1 DAT_NASCIMENTO from CONTATOS";
				FbCommand cmd = new FbCommand(sql, Globais.bd);
				FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
				reader.Close();
				return true;
			}
			catch
			{
				try 
				{
					sql = "alter table CONTATOS add DAT_NASCIMENTO date";
					FbCommand cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					sql = "update CONTATOS set DAT_NASCIMENTO=null";
					cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					atualizacoes++;
					return true;
				}
				catch (Exception e)
				{
					Log.Grava(Globais.sUsuario, "erro:" + e.Message);
					MessageBox.Show("Erro na execução do comando:\r\n" + sql + "\r\n" + e.Message,
					                "Erro na atualização do banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
			}			
		}		
		
		/// <summary>
		/// Inclusão do campo DAT_NASCIMENTO na tabela FUNCIONARIOS
		/// 16/07/2011
		/// </summary>
		/// <returns>true=OK</returns>
		private bool DataNascimentoFuncionarios()
		{
			string sql="";
			try
			{
				sql = "select first 1 DAT_NASCIMENTO from FUNCIONARIOS";
				FbCommand cmd = new FbCommand(sql, Globais.bd);
				FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
				reader.Close();
				return true;
			}
			catch
			{
				try 
				{
					sql = "alter table FUNCIONARIOS add DAT_NASCIMENTO date";
					FbCommand cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					sql = "update FUNCIONARIOS set DAT_NASCIMENTO=null";
					cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					atualizacoes++;
					return true;
				}
				catch (Exception e)
				{
					Log.Grava(Globais.sUsuario, "erro:" + e.Message);
					MessageBox.Show("Erro na execução do comando:\r\n" + sql + "\r\n" + e.Message,
					                "Erro na atualização do banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
			}			
		}				
		
		/// <summary>
		/// Inclusão do campo IDT_IPI na tabela CARACTERISTICAS
		/// 16/07/2011
		/// </summary>
		/// <returns>true=OK</returns>
		private bool IdtIpiCaracteristicas()
		{
			string sql="";
			try
			{
				sql = "select first 1 IDT_IPI from CARACTERISTICAS";
				FbCommand cmd = new FbCommand(sql, Globais.bd);
				FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
				reader.Close();
				return true;
			}
			catch
			{
				try 
				{
					sql = "alter table CARACTERISTICAS add IDT_IPI char(1)";
					FbCommand cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					sql = "update CARACTERISTICAS set IDT_IPI='S'";
					cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					atualizacoes++;
					return true;
				}
				catch (Exception e)
				{
					Log.Grava(Globais.sUsuario, "erro:" + e.Message);
					MessageBox.Show("Erro na execução do comando:\r\n" + sql + "\r\n" + e.Message,
					                "Erro na atualização do banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
			}			
		}
		
		/// <summary>
		/// Inclusão dos campos NRO_IDENTIDADE e NRO_CPF na tabela FUNCIONARIOS
		/// 16/07/2011
		/// </summary>
		/// <returns>true=OK</returns>
		private bool IdentidadeCpfFuncionarios()
		{
			string sql="";
			try
			{
				sql = "select first 1 NRO_IDENTIDADE from FUNCIONARIOS";
				FbCommand cmd = new FbCommand(sql, Globais.bd);
				FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
				reader.Close();
				return true;
			}
			catch
			{
				try 
				{
					sql = "alter table FUNCIONARIOS add NRO_IDENTIDADE char(11)";
					FbCommand cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					sql = "alter table FUNCIONARIOS add NRO_CPF char(15)";
					cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					atualizacoes++;
					return true;
				}
				catch (Exception e)
				{
					Log.Grava(Globais.sUsuario, "erro:" + e.Message);
					MessageBox.Show("Erro na execução do comando:\r\n" + sql + "\r\n" + e.Message,
					                "Erro na atualização do banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
			}			
		}
		
		/// <summary>
		/// Inclusão dos campos IDT_ATIVO na tabela TAB_PRECOS
		/// 17/01/2012
		/// </summary>
		/// <returns>true=OK</returns>
		private bool IdtAtivoTabelaPrecos()
		{
			string sql="";
			try
			{
				sql = "select first 1 IDT_ATIVO from TAB_PRECOS";
				FbCommand cmd = new FbCommand(sql, Globais.bd);
				FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
				reader.Close();
				return true;
			}
			catch
			{
				try 
				{
					sql = "alter table TAB_PRECOS add IDT_ATIVO char(1)";
					FbCommand cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					sql = "update TAB_PRECOS set IDT_ATIVO='S'";
					cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					atualizacoes++;
					return true;
				}
				catch (Exception e)
				{
					Log.Grava(Globais.sUsuario, "erro:" + e.Message);
					MessageBox.Show("Erro na execução do comando:\r\n" + sql + "\r\n" + e.Message,
					                "Erro na atualização do banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
			}			
		}
		
		
		/// <summary>
		/// Inclusão dos campos de pedidos na tabela AVISOS
		/// 12/02/2012
		/// </summary>
		/// <returns>true=OK</returns>
		private bool AvisosPedido()
		{
			/*
alter table avisos drop DIAS_CONFIRMACAO_ENTREGA;
alter table avisos drop FREQUENCIA_CONFIRMACAO_ENTREGA;
alter table avisos drop DIA_CONFIRMACAO_ENTREGA;
alter table avisos drop DIAS_ENTREGA;
alter table avisos drop FREQUENCIA_ENTREGA;
alter table avisos drop DIA_ENTREGA;
alter table avisos drop DIAS_MONTAGEM;
alter table avisos drop FREQUENCIA_MONTAGEM;
alter table avisos drop DIA_MONTAGEM;
alter table avisos drop DIAS_FATURAMENTO;
alter table avisos drop FREQUENCIA_FATURAMENTO;
alter table avisos drop DIA_FATURAMENTO;

update avisos set ultima_verificacao='02/11/2012';
commit;
*/
			string sql="";
			try
			{
				sql = "select first 1 DIAS_CONFIRMACAO_ENTREGA from AVISOS";
				FbCommand cmd = new FbCommand(sql, Globais.bd);
				FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
				reader.Close();
				return true;
			}
			catch
			{
				try 
				{
					sql = "alter table AVISOS add DIAS_CONFIRMACAO_ENTREGA smallint";
					FbCommand cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					sql = "update AVISOS set DIAS_CONFIRMACAO_ENTREGA=0";
					cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					sql = "alter table AVISOS add FREQUENCIA_CONFIRMACAO_ENTREGA char(1)";
					cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					sql = "update AVISOS set FREQUENCIA_CONFIRMACAO_ENTREGA='S'";
					cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					sql = "alter table AVISOS add DIA_CONFIRMACAO_ENTREGA smallint";
					cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					sql = "update AVISOS set DIA_CONFIRMACAO_ENTREGA=1";
					cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					
					sql = "alter table AVISOS add DIAS_ENTREGA smallint";
					cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					sql = "update AVISOS set DIAS_ENTREGA=0";
					cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					sql = "alter table AVISOS add FREQUENCIA_ENTREGA char(1)";
					cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					sql = "update AVISOS set FREQUENCIA_ENTREGA='S'";
					cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					sql = "alter table AVISOS add DIA_ENTREGA smallint";
					cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					sql = "update AVISOS set DIA_ENTREGA=1";
					cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					
					sql = "alter table AVISOS add DIAS_MONTAGEM smallint";
					cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					sql = "update AVISOS set DIAS_MONTAGEM=0";
					cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					sql = "alter table AVISOS add FREQUENCIA_MONTAGEM char(1)";
					cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					sql = "update AVISOS set FREQUENCIA_MONTAGEM='S'";
					cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					sql = "alter table AVISOS add DIA_MONTAGEM smallint";
					cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					sql = "update AVISOS set DIA_MONTAGEM=1";
					cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					
					sql = "alter table AVISOS add DIAS_FATURAMENTO smallint";
					cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					sql = "update AVISOS set DIAS_FATURAMENTO=0";
					cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					sql = "alter table AVISOS add FREQUENCIA_FATURAMENTO char(1)";
					cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					sql = "update AVISOS set FREQUENCIA_FATURAMENTO='S'";
					cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					sql = "alter table AVISOS add DIA_FATURAMENTO smallint";
					cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					sql = "update AVISOS set DIA_FATURAMENTO=1";
					cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					atualizacoes++;
					return true;
				}
				catch (Exception e)
				{
					Log.Grava(Globais.sUsuario, "erro:" + e.Message);
					MessageBox.Show("Erro na execução do comando:\r\n" + sql + "\r\n" + e.Message,
					                "Erro na atualização do banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
			}			
		}
		
		/// <summary>
		/// Inclusão do campo IDT_GENERICO na tabela PRODUTOS
		/// 04/10/2015
		/// </summary>
		/// <returns>true=OK</returns>
		private bool ProdutoGenerico()
		{
			string sql="";
			try
			{
				sql = "select first 1 IDT_GENERICO from PRODUTOS";
				FbCommand cmd = new FbCommand(sql, Globais.bd);
				FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
				reader.Close();
				return true;
			}
			catch
			{
				try 
				{
					sql = "alter table PRODUTOS add IDT_GENERICO char(1)";
					FbCommand cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					sql = "update PRODUTOS set IDT_GENERICO='N'";
					cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					atualizacoes++;
					return true;
				}
				catch (Exception e)
				{
					Log.Grava(Globais.sUsuario, "erro:" + e.Message);
					MessageBox.Show("Erro na execução do comando:\r\n" + sql + "\r\n" + e.Message,
					                "Erro na atualização do banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
			}			
		}
		
		/// <summary>
		/// Inclusão do campo DES_DIRETORIO na tabela FILIAIS
		/// 02/11/2015
		/// </summary>
		/// <returns>true=OK</returns>
		private bool DiretorioFilial()
		{
			string sql="";
			try
			{
				sql = "select first 1 DES_DIRETORIO from FILIAIS";
				FbCommand cmd = new FbCommand(sql, Globais.bd);
				FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
				reader.Close();
				return true;
			}
			catch
			{
				try 
				{
					sql = "alter table FILIAIS add DES_DIRETORIO char(50)";
					FbCommand cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					sql = "update FILIAIS set DES_DIRETORIO=''";
					cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
					atualizacoes++;
					return true;
				}
				catch (Exception e)
				{
					Log.Grava(Globais.sUsuario, "erro:" + e.Message);
					MessageBox.Show("Erro na execução do comando:\r\n" + sql + "\r\n" + e.Message,
					                "Erro na atualização do banco de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
			}			
		}
	}
	
}
