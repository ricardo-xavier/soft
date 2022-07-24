/*
 * Classe para manipulação de avisos
 * Autor: Ricardo Costa Xavier
 * Data : 19/11/2010
 * 
 * 2012-11-04 - estava faltando ')' no fim do select do ProcessaFaturamento
 * 
 * 2014-01-15 - enviar através da minha conta do gmail
 */
using System;
using System.Text;
using System.Data;
using FirebirdSql.Data.FirebirdClient;
using System.Net.Mail;
using System.Threading;
using System.IO;
using System.Net;
using System.Net.Security;

namespace classes
{
	
	public enum Frequencias: short {
		Diaria = (short)'D',
		Semanal = (short)'S',
		Mensal = (short)'M'
	};				
		
	public enum DiasSemana: short {
		Domingo,
		Segunda,
		Terça,
		Quarta,
		Quinta,
		Sexta,
		Sábado
	};				
	
	/// <summary>
	/// Classe para manipulação de avisos
	/// </summary>
	public class cAvisos
	{
		public string servidorSmtp;
		public short portaSmtp;
		public string usuarioSmtp;
		public string senhaSmtp;
		public string remetente;
		public short diasAgenda;
		public string frequenciaAgenda;
		public short diaAgenda;
		public short diasOrcamento;
		public string frequenciaOrcamento;
		public short diaOrcamento;
	
		public short diasConfirmacaoEntrega;
		public string frequenciaConfirmacaoEntrega;
		public short diaConfirmacaoEntrega;
		public short diasEntrega;
		public string frequenciaEntrega;
		public short diaEntrega;
		public short diasMontagem;
		public string frequenciaMontagem;
		public short diaMontagem;
		public short diasFaturamento;
		public string frequenciaFaturamento;
		public short diaFaturamento;
		
		public bool enviar_cabecalho;
		
		public DateTime ultimaVerificacao;
				
		public cAvisos()
		{
		}
						
		/// <summary>
		/// Carrega a configuração de avisos, se não encontrar inicializa e inclui
		/// </summary>
		public void Le()
		{
			FbCommand cmd =  new FbCommand("select " +
			                               "SERVIDOR_SMTP," + //0
			                               "PORTA_SMTP," + //1
			                               "USUARIO_SMTP," + //2
			                               "SENHA_SMTP," + //3
			                               "REMETENTE," + //4
			                               "DIAS_AGENDA," + //5
			                               "FREQUENCIA_AGENDA," + //6
			                               "DIA_AGENDA," + //7
			                               "DIAS_ORCAMENTO," + //8
			                               "FREQUENCIA_ORCAMENTO," + //9
			                               "DIA_ORCAMENTO," + //10
			                               "ULTIMA_VERIFICACAO," + //11
		                                   "DIAS_CONFIRMACAO_ENTREGA," + //12
			                               "FREQUENCIA_CONFIRMACAO_ENTREGA," + //13
			                               "DIA_CONFIRMACAO_ENTREGA," + //14
			                		       "DIAS_ENTREGA," + //15
			                               "FREQUENCIA_ENTREGA," + //16
			                               "DIA_ENTREGA," + //17
			                 		       "DIAS_MONTAGEM," + //18
			                               "FREQUENCIA_MONTAGEM," + //19
			                               "DIA_MONTAGEM," + //20
			              		           "DIAS_FATURAMENTO," + //21
			                               "FREQUENCIA_FATURAMENTO," + //22
			                               "DIA_FATURAMENTO " + //23
			                               "from AVISOS ",
			                               Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			if (reader.Read())
			{
				servidorSmtp = reader.GetString(0).Trim();
				portaSmtp = reader.GetInt16(1);
				usuarioSmtp = reader.GetString(2).Trim();
				senhaSmtp = reader.GetString(3).Trim();
				remetente = reader.GetString(4).Trim();
				diasAgenda = reader.GetInt16(5);
				frequenciaAgenda = reader.GetString(6).Trim();
				diaAgenda = reader.GetInt16(7);
				diasOrcamento = reader.GetInt16(8);
				frequenciaOrcamento = reader.GetString(9).Trim();
				diaOrcamento = reader.GetInt16(10);
				ultimaVerificacao = reader.GetDateTime(11);
				diasConfirmacaoEntrega = reader.GetInt16(12);
				frequenciaConfirmacaoEntrega = reader.GetString(13).Trim();
				diaConfirmacaoEntrega = reader.GetInt16(14);
				diasEntrega = reader.GetInt16(15);
				frequenciaEntrega = reader.GetString(16).Trim();
				diaEntrega = reader.GetInt16(17);
				diasMontagem = reader.GetInt16(18);
				frequenciaMontagem = reader.GetString(19).Trim();
				diaMontagem = reader.GetInt16(20);
				diasFaturamento = reader.GetInt16(21);
				frequenciaFaturamento = reader.GetString(22).Trim();
				diaFaturamento = reader.GetInt16(23);
			}
			else 
			{
				servidorSmtp = "";
				portaSmtp = 25;
				usuarioSmtp = "";
				senhaSmtp = "";
				remetente = "";
				diasAgenda = 0;
				frequenciaAgenda = "S";
				diaAgenda = 1;
				diasOrcamento = 0;
				frequenciaOrcamento = "S";
				diaOrcamento = 1;
				ultimaVerificacao = DateTime.Now;
				diasConfirmacaoEntrega = 0;
				frequenciaConfirmacaoEntrega = "S";
				diaConfirmacaoEntrega = 1;
				diasEntrega = 0;
				frequenciaEntrega = "S";
				diaEntrega = 1;
				diasMontagem = 0;
				frequenciaMontagem = "S";
				diaMontagem = 1;
				diasFaturamento = 0;
				frequenciaFaturamento = "S";
				diaFaturamento = 1;
				Inclui();
			}
			reader.Close();			
		}

		/// <summary>
		/// Inclui um aviso
		/// </summary>
		private void Inclui()
		{
			string sql = "insert into AVISOS values(" +
				"'" + servidorSmtp + "'," +
				portaSmtp.ToString() + "," +
				"'" + usuarioSmtp + "'," +
				"'" + senhaSmtp + "'," +
				"'" + remetente + "'," +
				diasAgenda + "," +
				"'" + frequenciaAgenda + "'," +
				diaAgenda + "," +
				diasOrcamento + "," +
				"'" + frequenciaOrcamento + "'," +
				diaOrcamento + "," +				
				"'"  + ultimaVerificacao.ToString("M/d/yyyy") + "'," +
				diasConfirmacaoEntrega + "," +
				"'" + frequenciaConfirmacaoEntrega + "'," +
				diaConfirmacaoEntrega + "," +
				diasEntrega + "," +
				"'" + frequenciaEntrega + "'," +
				diaEntrega + "," +
				diasMontagem + "," +
				"'" + frequenciaMontagem + "'," +
				diaMontagem + "," +
				diasFaturamento + "," +
				"'" + frequenciaFaturamento + "'," +
				diaFaturamento + ")";
			FbCommand cmd = new FbCommand(sql, Globais.bd);
			try
			{
				Log.Grava(Globais.sUsuario, cmd.CommandText);
				cmd.ExecuteNonQuery();
			}
			catch (Exception e)
			{
				Log.Grava(Globais.sUsuario, "erro:" + e.Message);
				string err = e.Message;
			}
		}		
		
		/// <summary>
		/// Grava um aviso
		/// </summary>
		/// <param name="msg">mensagem de sucesso ou erro</param>
		/// <returns>true(ok) false(erro)</returns>
		public bool Grava(ref string msg)		
		{
			string sql = "update AVISOS set " +
				"SERVIDOR_SMTP='" + servidorSmtp + "'," +
				"PORTA_SMTP=" + portaSmtp.ToString() + "," +
				"USUARIO_SMTP='" + usuarioSmtp + "'," +
				"SENHA_SMTP='" + senhaSmtp + "'," +
				"REMETENTE='" + remetente + "'," +
				"DIAS_AGENDA=" + diasAgenda.ToString() + "," +
				"FREQUENCIA_AGENDA='" + frequenciaAgenda + "'," +
				"DIA_AGENDA=" + diaAgenda.ToString() + "," +
				"DIAS_ORCAMENTO=" + diasOrcamento.ToString() + "," +
				"FREQUENCIA_ORCAMENTO='" + frequenciaOrcamento + "'," +
				"DIA_ORCAMENTO=" + diaOrcamento.ToString() + "," +				
				"ULTIMA_VERIFICACAO='" + ultimaVerificacao.ToString("M/d/yyyy") + "'," +
				"DIAS_CONFIRMACAO_ENTREGA=" + diasConfirmacaoEntrega.ToString() + "," +
				"FREQUENCIA_CONFIRMACAO_ENTREGA='" + frequenciaConfirmacaoEntrega + "'," +
				"DIA_CONFIRMACAO_ENTREGA=" + diaConfirmacaoEntrega.ToString() + "," +	
				"DIAS_ENTREGA=" + diasEntrega.ToString() + "," +
				"FREQUENCIA_ENTREGA='" + frequenciaEntrega + "'," +
				"DIA_ENTREGA=" + diaEntrega.ToString() + "," +	
				"DIAS_MONTAGEM=" + diasMontagem.ToString() + "," +
				"FREQUENCIA_MONTAGEM='" + frequenciaMontagem + "'," +
				"DIA_MONTAGEM=" + diaMontagem.ToString() + "," +	
				"DIAS_FATURAMENTO=" + diasFaturamento.ToString() + "," +
				"FREQUENCIA_FATURAMENTO='" + frequenciaFaturamento + "'," +
				"DIA_FATURAMENTO=" + diaFaturamento.ToString();
			FbCommand cmd = new FbCommand(sql, Globais.bd);
			try
			{
				Log.Grava(Globais.sUsuario, cmd.CommandText);
				cmd.ExecuteNonQuery();
				trace.grava("atualiza data verificacao: " + ultimaVerificacao.Date.ToString("M/d/yyyy"));
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
		
		/// <summary>
		/// Verifica/envia avisos
		/// </summary>
		public void Processa(System.Windows.Forms.Label label)
		{
			Le();
			//FIXME
			/**/
			if (ultimaVerificacao.Date.ToString("M/d/yyyy").Equals(DateTime.Now.ToString("M/d/yyyy")))
			{
				return;
			}
			/**/
			trace.grava("processa avisos: " + ultimaVerificacao.Date.ToString("M/d/yyyy"));
			ultimaVerificacao = DateTime.Now;
			string msg="";
			Grava(ref msg); 
			
			// Agenda
			bool processar_agenda=false;
			if (diasAgenda > 0)
			{
				switch ((short)frequenciaAgenda[0])
				{
					case (short)Frequencias.Diaria: 
						processar_agenda = true;
						break;
					case (short)Frequencias.Semanal:
						if ((short)DateTime.Now.DayOfWeek == diaAgenda)
						{
							processar_agenda = true; 
						}
						break;
					case (short)Frequencias.Mensal:
						if (DateTime.Now.Day == diaAgenda)
						{
							processar_agenda = true;
						}
						break;
				}
			}
			
			// Orçamento
			bool processar_orcamento=false;
			if (diasOrcamento > 0)
			{
				switch ((short)frequenciaOrcamento[0])
				{
					case (short)Frequencias.Diaria: 
						processar_orcamento = true;
						break;
					case (short)Frequencias.Semanal:
						if ((short)DateTime.Now.DayOfWeek == diaOrcamento)
						{
							processar_orcamento = true; 
						}
						break;
					case (short)Frequencias.Mensal:
						if (DateTime.Now.Day == diaOrcamento)
						{
							processar_orcamento = true;
						}
						break;
				}
			}
			
			// Pedido - Confirmação Entrega
			bool processar_confirmacao_entrega=false;
			if (diasConfirmacaoEntrega > 0)
			{
				switch ((short)frequenciaConfirmacaoEntrega[0])
				{
					case (short)Frequencias.Diaria: 
						processar_confirmacao_entrega = true;
						break;
					case (short)Frequencias.Semanal:
						if ((short)DateTime.Now.DayOfWeek == diaConfirmacaoEntrega)
						{
							processar_confirmacao_entrega = true; 
						}
						break;
					case (short)Frequencias.Mensal:
						if (DateTime.Now.Day == diaConfirmacaoEntrega)
						{
							processar_confirmacao_entrega = true;
						}
						break;
				}
			}
			
			// Pedido - Entrega
			bool processar_entrega=false;
			if (diasEntrega > 0)
			{
				switch ((short)frequenciaEntrega[0])
				{
					case (short)Frequencias.Diaria: 
						processar_entrega = true;
						break;
					case (short)Frequencias.Semanal:
						if ((short)DateTime.Now.DayOfWeek == diaEntrega)
						{
							processar_entrega = true; 
						}
						break;
					case (short)Frequencias.Mensal:
						if (DateTime.Now.Day == diaEntrega)
						{
							processar_entrega = true;
						}
						break;
				}
			}
			
			// Pedido - Montagem
			bool processar_montagem=false;
			if (diasMontagem > 0)
			{
				switch ((short)frequenciaMontagem[0])
				{
					case (short)Frequencias.Diaria: 
						processar_montagem = true;
						break;
					case (short)Frequencias.Semanal:
						if ((short)DateTime.Now.DayOfWeek == diaMontagem)
						{
							processar_montagem = true; 
						}
						break;
					case (short)Frequencias.Mensal:
						if (DateTime.Now.Day == diaMontagem)
						{
							processar_montagem = true;
						}
						break;
				}
			}
		
			// Pedido - faturamento
			bool processar_faturamento=false;
			if (diasFaturamento > 0)
			{
				switch ((short)frequenciaFaturamento[0])
				{
					case (short)Frequencias.Diaria: 
						processar_faturamento = true;
						break;
					case (short)Frequencias.Semanal:
						if ((short)DateTime.Now.DayOfWeek == diaFaturamento)
						{
							processar_faturamento = true; 
						}
						break;
					case (short)Frequencias.Mensal:
						if (DateTime.Now.Day == diaFaturamento)
						{
							processar_faturamento = true;
						}
						break;
				}
			}
			
			//FIXME
			/*
			processar_agenda = true;
			processar_orcamento = true;
			processar_confirmacao_entrega = true;
			processar_entrega = true;
			processar_montagem = true;
			processar_faturamento = true;
			*/
			
			if (!processar_agenda && !processar_orcamento && !processar_confirmacao_entrega && !processar_entrega && !processar_montagem && !processar_faturamento)
			{
				return;
			}
			TimeSpan dif = new TimeSpan();
			dif = TimeSpan.FromDays((double)diasAgenda);
			DateTime limiteAgenda = DateTime.Now.Subtract(dif);
			dif = TimeSpan.FromDays((double)diasOrcamento);
			DateTime limiteOrcamento = DateTime.Now.Subtract(dif);			
			dif = TimeSpan.FromDays((double)diasConfirmacaoEntrega);
			DateTime limiteConfirmacaoEntrega= DateTime.Now.Subtract(dif);			
			dif = TimeSpan.FromDays((double)diasEntrega);
			DateTime limiteEntrega= DateTime.Now.Subtract(dif);
			dif = TimeSpan.FromDays((double)diasMontagem);
			DateTime limiteMontagem= DateTime.Now.Subtract(dif);
			dif = TimeSpan.FromDays((double)diasFaturamento);
			DateTime limiteFaturamento= DateTime.Now.Subtract(dif);
			FbCommand cmd =  new FbCommand("select " +
			                               "COD_FUNCIONARIO," +
				                           "DES_EMAIL " +
				                           "from FUNCIONARIOS " +
				                           "where (DES_EMAIL is not null) and " +
				                           "      (DES_EMAIL <> '') and IDT_ATIVO = 'S'" +
				                           "order by COD_FUNCIONARIO",
				                           Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			while (reader.Read())
			{
				string codigo = reader.GetString(0);
				string email = reader.GetString(1);
				label.Text = "Verificando avisos para: " + codigo;
				label.Refresh();
				ProcessaFuncionario(codigo, email, limiteAgenda, limiteOrcamento, limiteConfirmacaoEntrega, limiteEntrega, limiteMontagem, limiteFaturamento);
			}
			reader.Close();
			trace.grava("fim do processamento de avisos");
		}
		
		public void cabecalho(string funcionario, StringBuilder html)
		{
			if (!enviar_cabecalho) return;
			enviar_cabecalho = false;
			FbCommand cmd =  new FbCommand("select NOM_FUNCIONARIO from funcionarios " +
			                               "where COD_FUNCIONARIO='" + funcionario + "'",
			                               Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			string nome = funcionario;
			if (reader.Read())
			{
				nome = reader.GetString(0);
			}						
			html.Append("<h3>" + nome + ",</h3>");
			html.Append("Foram identificados os seguintes problemas no sistema Soft:<br/>");
			reader.Close();
		}
		
		/// <summary>
		/// Verifica/envia avisos para um funcionario		
		/// </summary>
		/// <param name="funcionario">código do funcionário</param>
		/// <param name="email">email do funcionário</param>
		/// <param name="limiteAgenda">data limite para agendamentos</param>
		/// <param name="limiteOrcamento">data limite para orçamentos</param>
		public void ProcessaFuncionario(string funcionario, string email, DateTime limiteAgenda, DateTime limiteOrcamento,
		                               DateTime limiteConfirmacaoEntrega, DateTime limiteEntrega, DateTime limiteMontagem, DateTime limiteFaturamento)
		{
			enviar_cabecalho = true;
			trace.grava("processa funcionario: " + funcionario);
			StringBuilder html = new StringBuilder();
			html.Append("<htmt><body>");
			bool enviar_agenda = ProcessaAgendamentos(funcionario, limiteAgenda, html);
			bool enviar_orcamento = ProcessaOrcamentos(funcionario, limiteOrcamento, html);
			bool enviar_confirmacao_entrega = ProcessaConfirmacaoEntrega(funcionario, limiteConfirmacaoEntrega, html);
			bool enviar_entrega = ProcessaEntrega(funcionario, limiteEntrega, html);
			bool enviar_montagem = ProcessaMontagem(funcionario, limiteMontagem, html);
			bool enviar_faturamento = ProcessaFaturamento(funcionario, limiteFaturamento, html);
			if (enviar_agenda || enviar_orcamento || enviar_confirmacao_entrega || enviar_entrega || enviar_montagem || enviar_montagem || enviar_faturamento)
			{
				html.Append("<br/>Favor baixar agendamentos e cancelar/substituir orçamentos que não estão mais ativos<br/>");
				html.Append("<br/>De " + remetente);
				html.Append("</body></html>");
				trace.grava("envia email: " + email);
				//FIXME
				//EnviaEmail("ricardo.costa.xavier@gmail.com", html.ToString()); 		
				EnviaEmail(email, html.ToString()); 
			}
		}		
		
		/// <summary>
		/// Verifica agendamentos em aberto de um funcionário
		/// </summary>
		/// <param name="funcionario">código do funcionário</param>
		/// <param name="limite">data limite</param>
		/// <param name="html">texto do html</param>
		/// <returns></returns>
		public bool ProcessaAgendamentos(string funcionario, DateTime limite, StringBuilder html)
		{
			bool enviar=false;
			FbCommand cmd =  new FbCommand("select " +
			                               //"count(*) from AGENDA a " +
			                               /**/
			                               "a.DAT_AGENDAMENTO," + //0
			                               "a.DAT_PREVISAO," + //1
			                               "a.COD_NATUREZA," + //2
			                               "a.COD_PARCEIRO," + //3
			                               "a.DES_PENDENCIA," + //4
			                               "a.COD_CONTATO," + //5
			                               "c.NOM_CONTATO," + //6
			                               "c.NRO_FONE1," + //7
			                               "c.NRO_CELULAR," + //8
			                               "c.DES_EMAIL " + //9
			                               "from AGENDA a " +
			                               "left outer join CONTATOS c on " +
			                               "c.COD_PARCEIRO=a.COD_PARCEIRO and c.COD_CONTATO=a.COD_CONTATO " +
			                               /**/
			                               "where (a.COD_RESPONSAVEL='" + funcionario + "') and " +
			                               "      (a.DAT_SOLUCAO is null) and " +
			                               "      (a.IDT_CANCELADO <> 'S') and " +
			                               "      (a.DAT_PREVISAO < '" + limite.ToString("M/d/yyyy") + "') " +
			                               "order by a.DAT_PREVISAO",			                               
			                               Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			/*
			if (reader.Read())
			{
				int count = reader.GetInt32(0);
				if (count > 0) {
					cabecalho(funcionario, html);					
					enviar = true;			
					trace.grava("agendamentos: " + count.ToString());
					html.Append("Agendamentos abertos a mais de " + diasAgenda.ToString() + " dias = " + count.ToString() + "<br/>");
				}
			}			
			*/
			/**/
			while (reader.Read())
			{
				cabecalho(funcionario, html);
				if (!enviar)
				{
					enviar = true;
					html.Append("<h2><font color=\"blue\">Agendamentos abertos a mais de " + diasAgenda.ToString() + " dias</font></h2><br/>");
				}
				html.Append("Data: " + reader.GetDateTime(0).ToString("d/M/yyyy") + "<br/>");
				html.Append("Previsão: " + reader.GetDateTime(1).ToString("d/M/yyyy") + "<br/>");
				html.Append("Natureza: " + reader.GetString(2) + "<br/>");
				html.Append("Parceiro: " + reader.GetString(3) + "<br/>");
				if (reader.IsDBNull(6))
				{
					html.Append("Contato: " + reader.GetString(5) + "<br/>");
				}
				else
				{
					html.Append("Contato: " + reader.GetString(6) + "<br/>");
					html.Append("Fone: " + FONE.PoeEdicao(reader.GetString(7)) + " / " + FONE.PoeEdicao(reader.GetString(8)) + "<br/>");
					html.Append("Email: " + reader.GetString(9) + "<br/>");
				}
				html.Append("Pendência: " + "<br/>" + reader.GetString(4) + "<br/>");
				html.Append("<hr/>");
			}
			/**/
			reader.Close();
			return enviar;
		}		
		
		/// <summary>
		/// Verifica orçamentos em aberto de um funcionário
		/// </summary>
		/// <param name="funcionario">código do funcionário</param>
		/// <param name="limite">data limite</param>
		/// <param name="html">texto do html</param>
		/// <returns></returns>		
		public bool ProcessaOrcamentos(string funcionario, DateTime limite, StringBuilder html)		
		{
			bool enviar=false;
			FbCommand cmd =  new FbCommand("select " +
			                               //"count(*) from ORCAMENTOS o " +
			                               /**/
			                               "o.COD_FORNECEDOR," + //0
			                               "o.DAT_ORCAMENTO," + //1
			                               "o.COD_ORCAMENTO," + //2
			                               "o.COD_CLIENTE," + //3
			                               "o.DES_RESUMO," + //4
			                               "o.COD_CONTATO," + //5
			                               "c.NOM_CONTATO," + //6
			                               "c.NRO_FONE1," + //7
			                               "c.NRO_CELULAR," + //8
			                               "c.DES_EMAIL " + //9
			                               "from ORCAMENTOS o " +
			                               "left outer join CONTATOS c on " +
			                               "c.COD_PARCEIRO=o.COD_CLIENTE and c.COD_CONTATO=o.COD_CONTATO " +
			                               "inner join SITUACOES s on " +
			                               "s.COD_SITUACAO=o.COD_SITUACAO and s.IDT_AVISO='S' " +
			                               /**/
			                               "where (o.COD_VENDEDOR='" + funcionario + "') and " +
			                               "      (o.COD_SITUACAO not in ('C', 'S', 'F', 'P')) and " +
			                               "      (o.DAT_ORCAMENTO < '" + limite.ToString("M/d/yyyy") + "') " +
			                               "order by o.DAT_ORCAMENTO,o.COD_FORNECEDOR,o.COD_ORCAMENTO",
			                               Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			/*
			if (reader.Read())
			{
				int count = reader.GetInt32(0);
				if (count > 0) {
					enviar = true;					
					trace.grava("orcamentos: " + count.ToString());
					if (!enviar_agenda) cabecalho(funcionario, html);						
					html.Append("Orçamentos abertos a mais de " + diasOrcamento.ToString() + " dias = " + count.ToString() + "<br/>");					
				}
			}
			*/
			/**/
			while (reader.Read())
			{
				cabecalho(funcionario, html);
				if (!enviar)
				{
					enviar = true;
					html.Append("<h2><font color=\"blue\">Orçamentos abertos a mais de " + diasOrcamento.ToString() + " dias</font></h2><br/>");
				}
				html.Append("Orçamento: " + reader.GetString(0) + " - " + 
				            reader.GetDateTime(1).ToString("d/M/yyyy") + " - " +
				            reader.GetInt16(2).ToString() + "<br/>");
				html.Append("Cliente: " + reader.GetString(3) + "<br/>");
				if (reader.IsDBNull(6))
				{
					html.Append("Contato: " + reader.GetString(5) + "<br/>");
				}
				else
				{
					html.Append("Contato: " + reader.GetString(6) + "<br/>");
					html.Append("Fone: " + FONE.PoeEdicao(reader.GetString(7)) + " / " + FONE.PoeEdicao(reader.GetString(8)) + "<br/>");
					html.Append("Email: " + reader.GetString(9) + "<br/>");
				}
				html.Append("Resumo: " + "<br/>" + reader.GetString(4) + "<br/>");
				html.Append("<hr/>");
			}
			/**/
			reader.Close();
			return enviar;
		}

		/// <summary>
		/// Verifica pedidos sem confirmação de entrega
		/// </summary>
		/// <param name="funcionario">código do funcionário</param>
		/// <param name="limite">data limite</param>
		/// <param name="html">texto do html</param>
		/// <returns></returns>		
		public bool ProcessaConfirmacaoEntrega(string funcionario, DateTime limite, StringBuilder html)
		{	                              
			bool enviar=false;
			FbCommand cmd =  new FbCommand("select " +
			                               "p.COD_FORNECEDOR," + //0
			                               "p.DAT_ORCAMENTO," + //1
			                               "p.COD_ORCAMENTO," + //2
			                               "o.COD_CLIENTE," + //3			               			               
			                               "o.DES_RESUMO," + //4
			                               "o.COD_CONTATO," + //5
			                               "c.NOM_CONTATO," + //6
			                               "c.NRO_FONE1," + //7
			                               "c.NRO_CELULAR," + //8
			                               "c.DES_EMAIL," + //9
			                               "p.NRO_PEDIDO," + //10
			                               "p.DAT_ENTREGA " + //11            
			                               "from PEDIDOS p " +
			                               "inner join ORCAMENTOS o " +
			                               "on o.COD_FORNECEDOR=p.COD_FORNECEDOR and o.DAT_ORCAMENTO=p.DAT_ORCAMENTO and o.COD_ORCAMENTO=p.COD_ORCAMENTO " +
			                               "left outer join CONTATOS c on " +
			                               "c.COD_PARCEIRO=o.COD_CLIENTE and c.COD_CONTATO=o.COD_CONTATO " +
			                               "where (o.COD_VENDEDOR='" + funcionario + "') and " +
			                               "      (p.DAT_ENTREGA < '" + limite.ToString("M/d/yyyy") + "') and " +
			                               "      (p.IDT_DAT_ENTREGA <> 'S') and (p.IDT_DAT_REAL_ENTREGA <> 'S')" ,
			                               Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			/*
			if (reader.Read())
			{
				int count = reader.GetInt32(0);
				if (count > 0) {
					enviar = true;					
					trace.grava("pedidos: " + count.ToString());
					if (!enviar_agenda) cabecalho(funcionario, html);						
					html.Append("Pedidos sem confirmação de entrega a mais de " + diasOrcamento.ToString() + " dias = " + count.ToString() + "<br/>");					
				}
			}
			*/
			while (reader.Read())
			{
				cabecalho(funcionario, html);
				if (!enviar)
				{
					enviar = true;
					html.Append("<h2><font color=\"blue\">Pedidos sem confirmação de entrega a mais de " + diasOrcamento.ToString() + " dias</font></h2><br/>");
				}
				html.Append("Pedido: " + reader.GetString(0) + " - " + 
				            reader.GetDateTime(1).ToString("d/M/yyyy") + " - " +
				            reader.GetInt16(2).ToString() + " - " +
				            "Número: " + reader.GetInt16(10) + "<br/>");
				html.Append("Cliente: " + reader.GetString(3) + "<br/>");
				if (reader.IsDBNull(6))
				{
					html.Append("Contato: " + reader.GetString(5) + "<br/>");
				}
				else
				{
					html.Append("Contato: " + reader.GetString(6) + "<br/>");
					html.Append("Fone: " + FONE.PoeEdicao(reader.GetString(7)) + " / " + FONE.PoeEdicao(reader.GetString(8)) + "<br/>");
					html.Append("Email: " + reader.GetString(9) + "<br/>");
				}
				html.Append("Resumo: " + "<br/>" + reader.GetString(4) + "<br/>");
				html.Append("Data prevista de entrega: " + reader.GetDateTime(11).ToString("dd/MM/yyyy") + "<br/>");
				html.Append("<hr/>");
			}
			reader.Close();
			return enviar;
		}
		
		/// <summary>
		/// Verifica pedidos sem entrega
		/// </summary>
		/// <param name="funcionario">código do funcionário</param>
		/// <param name="limite">data limite</param>
		/// <param name="html">texto do html</param>
		/// <returns></returns>		
		public bool ProcessaEntrega(string funcionario, DateTime limite, StringBuilder html)
		{	                              
			bool enviar=false;
			FbCommand cmd =  new FbCommand("select " +
			                               "p.COD_FORNECEDOR," + //0
			                               "p.DAT_ORCAMENTO," + //1
			                               "p.COD_ORCAMENTO," + //2
			                               "o.COD_CLIENTE," + //3			               			               
			                               "o.DES_RESUMO," + //4
			                               "o.COD_CONTATO," + //5
			                               "c.NOM_CONTATO," + //6
			                               "c.NRO_FONE1," + //7
			                               "c.NRO_CELULAR," + //8
			                               "c.DES_EMAIL," + //9
			                               "p.NRO_PEDIDO," + //10
			                               "p.DAT_REAL_ENTREGA " + //11            
			                               "from PEDIDOS p " +
			                               "inner join ORCAMENTOS o " +
			                               "on o.COD_FORNECEDOR=p.COD_FORNECEDOR and o.DAT_ORCAMENTO=p.DAT_ORCAMENTO and o.COD_ORCAMENTO=p.COD_ORCAMENTO " +
			                               "left outer join CONTATOS c on " +
			                               "c.COD_PARCEIRO=o.COD_CLIENTE and c.COD_CONTATO=o.COD_CONTATO " +
			                               "where (o.COD_VENDEDOR='" + funcionario + "') and " +
			                               "      (p.DAT_REAL_ENTREGA < '" + limite.ToString("M/d/yyyy") + "') and " +
			                               "      (p.IDT_DAT_REAL_ENTREGA <> 'S' and p.IDT_DAT_ENTREGA = 'S')" ,
			                               Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			/*
			if (reader.Read())
			{
				int count = reader.GetInt32(0);
				if (count > 0) {
					enviar = true;					
					trace.grava("pedidos: " + count.ToString());
					if (!enviar_agenda) cabecalho(funcionario, html);						
					html.Append("Pedidos sem entrega a mais de " + diasOrcamento.ToString() + " dias = " + count.ToString() + "<br/>");					
				}
			}
			*/
			while (reader.Read())
			{
				cabecalho(funcionario, html);
				if (!enviar)
				{
					enviar = true;
					html.Append("<h2><font color=\"blue\">Pedidos sem entrega a mais de " + diasOrcamento.ToString() + " dias</font></h2><br/>");
				}
				html.Append("Pedido: " + reader.GetString(0) + " - " + 
				            reader.GetDateTime(1).ToString("d/M/yyyy") + " - " +
				            reader.GetInt16(2).ToString() + " - " +
				            "Número: " + reader.GetInt16(10) + "<br/>");
				html.Append("Cliente: " + reader.GetString(3) + "<br/>");
				if (reader.IsDBNull(6))
				{
					html.Append("Contato: " + reader.GetString(5) + "<br/>");
				}
				else
				{
					html.Append("Contato: " + reader.GetString(6) + "<br/>");
					html.Append("Fone: " + FONE.PoeEdicao(reader.GetString(7)) + " / " + FONE.PoeEdicao(reader.GetString(8)) + "<br/>");
					html.Append("Email: " + reader.GetString(9) + "<br/>");
				}
				html.Append("Resumo: " + "<br/>" + reader.GetString(4) + "<br/>");
				html.Append("Data de entrega: " + reader.GetDateTime(11).ToString("dd/MM/yyyy") + "<br/>");
				html.Append("<hr/>");
			}
			reader.Close();
			return enviar;
		}

		/// <summary>
		/// Verifica pedidos sem montagem
		/// </summary>
		/// <param name="funcionario">código do funcionário</param>
		/// <param name="limite">data limite</param>
		/// <param name="html">texto do html</param>
		/// <returns></returns>		
		public bool ProcessaMontagem(string funcionario, DateTime limite, StringBuilder html)
		{	                              
			bool enviar=false;
			FbCommand cmd =  new FbCommand("select " +
			                               "p.COD_FORNECEDOR," + //0
			                               "p.DAT_ORCAMENTO," + //1
			                               "p.COD_ORCAMENTO," + //2
			                               "o.COD_CLIENTE," + //3			               			               
			                               "o.DES_RESUMO," + //4
			                               "o.COD_CONTATO," + //5
			                               "c.NOM_CONTATO," + //6
			                               "c.NRO_FONE1," + //7
			                               "c.NRO_CELULAR," + //8
			                               "c.DES_EMAIL," + //9
			                               "p.NRO_PEDIDO," + //10
			                               "p.DAT_REAL_MONTAGEM " + //11            
			                               "from PEDIDOS p " +
			                               "inner join ORCAMENTOS o " +
			                               "on o.COD_FORNECEDOR=p.COD_FORNECEDOR and o.DAT_ORCAMENTO=p.DAT_ORCAMENTO and o.COD_ORCAMENTO=p.COD_ORCAMENTO " +
			                               "left outer join CONTATOS c on " +
			                               "c.COD_PARCEIRO=o.COD_CLIENTE and c.COD_CONTATO=o.COD_CONTATO " +
			                               "where (o.COD_VENDEDOR='" + funcionario + "') and " +
			                               "      (p.DAT_MONTAGEM < '" + limite.ToString("M/d/yyyy") + "') and " +
			                               "      (p.IDT_DAT_REAL_MONTAGEM <> 'S')" ,
			                               Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			/*
			if (reader.Read())
			{
				int count = reader.GetInt32(0);
				if (count > 0) {
					enviar = true;					
					trace.grava("pedidos: " + count.ToString());
					if (!enviar_agenda) cabecalho(funcionario, html);						
					html.Append("Pedidos sem montagem a mais de " + diasOrcamento.ToString() + " dias = " + count.ToString() + "<br/>");					
				}
			}
			*/
			while (reader.Read())
			{
				cabecalho(funcionario, html);
				if (!enviar)
				{
					enviar = true;
					html.Append("<h2><font color=\"blue\">Pedidos sem montagem a mais de " + diasOrcamento.ToString() + " dias</font></h2><br/>");
				}
				html.Append("Pedido: " + reader.GetString(0) + " - " + 
				            reader.GetDateTime(1).ToString("d/M/yyyy") + " - " +
				            reader.GetInt16(2).ToString() + " - " +
				            "Número: " + reader.GetInt16(10) + "<br/>");
				html.Append("Cliente: " + reader.GetString(3) + "<br/>");
				if (reader.IsDBNull(6))
				{
					html.Append("Contato: " + reader.GetString(5) + "<br/>");
				}
				else
				{
					html.Append("Contato: " + reader.GetString(6) + "<br/>");
					html.Append("Fone: " + FONE.PoeEdicao(reader.GetString(7)) + " / " + FONE.PoeEdicao(reader.GetString(8)) + "<br/>");
					html.Append("Email: " + reader.GetString(9) + "<br/>");
				}
				html.Append("Resumo: " + "<br/>" + reader.GetString(4) + "<br/>");
				html.Append("Data de montagem: " + reader.GetDateTime(11).ToString("dd/MM/yyyy") + "<br/>");
				html.Append("<hr/>");
			}
			reader.Close();
			return enviar;
		}
		
		/// <summary>
		/// Verifica pedidos sem faturamento
		/// </summary>
		/// <param name="funcionario">código do funcionário</param>
		/// <param name="limite">data limite</param>
		/// <param name="html">texto do html</param>
		/// <returns></returns>		
		public bool ProcessaFaturamento(string funcionario, DateTime limite, StringBuilder html)
		{	                              
			bool enviar=false;
			FbCommand cmd =  new FbCommand("select " +
			                               "p.COD_FORNECEDOR," + //0
			                               "p.DAT_ORCAMENTO," + //1
			                               "p.COD_ORCAMENTO," + //2
			                               "o.COD_CLIENTE," + //3			               			               
			                               "o.DES_RESUMO," + //4
			                               "o.COD_CONTATO," + //5
			                               "c.NOM_CONTATO," + //6
			                               "c.NRO_FONE1," + //7
			                               "c.NRO_CELULAR," + //8
			                               "c.DES_EMAIL," + //9
			                               "p.NRO_PEDIDO " + //10      
			                               "from PEDIDOS p " +
			                               "inner join ORCAMENTOS o " +
			                               "on o.COD_FORNECEDOR=p.COD_FORNECEDOR and o.DAT_ORCAMENTO=p.DAT_ORCAMENTO and o.COD_ORCAMENTO=p.COD_ORCAMENTO " +
			                               "left outer join CONTATOS c on " +
			                               "c.COD_PARCEIRO=o.COD_CLIENTE and c.COD_CONTATO=o.COD_CONTATO " +
			                               "where (o.COD_VENDEDOR='" + funcionario + "') and " +
			                               "      (p.DAT_PEDIDO < '" + limite.ToString("M/d/yyyy") + "') and " +
			                               "      (p.IDT_DAT_REAL_MONTAGEM <> 'S') and " +
			                               "      (p.IDT_RECEBIDO <> 'S') and " +
			                               "      not exists (select 1 from pedidos_pagos pp where pp.COD_FORNECEDOR=p.COD_FORNECEDOR and pp.DAT_ORCAMENTO=p.DAT_ORCAMENTO and pp.COD_ORCAMENTO=p.COD_ORCAMENTO and pp.COD_PEDIDO=p.COD_PEDIDO)",
			                               Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			/*
			if (reader.Read())
			{
				int count = reader.GetInt32(0);
				if (count > 0) {
					enviar = true;					
					trace.grava("pedidos: " + count.ToString());
					if (!enviar_agenda) cabecalho(funcionario, html);						
					html.Append("Pedidos sem faturamento a mais de " + diasOrcamento.ToString() + " dias = " + count.ToString() + "<br/>");					
				}
			}
			*/
			while (reader.Read())
			{
				cabecalho(funcionario, html);
				if (!enviar)
				{
					enviar = true;
					html.Append("<h2><font color=\"blue\">Pedidos sem faturamento a mais de " + diasOrcamento.ToString() + " dias</font></h2><br/>");
				}
				html.Append("Pedido: " + reader.GetString(0) + " - " + 
				            reader.GetDateTime(1).ToString("d/M/yyyy") + " - " +
				            reader.GetInt16(2).ToString() + " - " +
				            "Número: " + reader.GetInt16(10) + "<br/>");
				html.Append("Cliente: " + reader.GetString(3) + "<br/>");
				if (reader.IsDBNull(6))
				{
					html.Append("Contato: " + reader.GetString(5) + "<br/>");
				}
				else
				{
					html.Append("Contato: " + reader.GetString(6) + "<br/>");
					html.Append("Fone: " + FONE.PoeEdicao(reader.GetString(7)) + " / " + FONE.PoeEdicao(reader.GetString(8)) + "<br/>");
					html.Append("Email: " + reader.GetString(9) + "<br/>");
				}
				html.Append("Resumo: " + "<br/>" + reader.GetString(4) + "<br/>");
				html.Append("<hr/>");
			}
			reader.Close();
			return enviar;
		}
		
		/// <summary>
		/// Envia um email
		/// </summary>
		/// <param name="email">endereço de email</param>
		/// <param name="texto">texto do email</param>
		private void EnviaEmail(string email, string texto)
		{
			/*
            ServicePointManager.ServerCertificateValidationCallback =
                new RemoteCertificateValidationCallback(
                    delegate
                    { return true; }
                );
            */
			//Thread.Sleep(1000);
			//return;
			System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();
			//FIXME
			/*
			servidorSmtp = "smtp.gmail.com";
			portaSmtp = 587;
			usuarioSmtp = "softplacemoveisbh@gmail.com"; //"ricardo.costa.xavier@gmail.com";
			senhaSmtp = "soft101010";
			*/
			
			smtp.Host = servidorSmtp;
			smtp.Port = portaSmtp;
			smtp.EnableSsl = true;
			smtp.UseDefaultCredentials = false;
			smtp.Credentials = new System.Net.NetworkCredential(usuarioSmtp, senhaSmtp);
			System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage(remetente, email, 
			                                                                      "Avisos da semana " + DateTime.Now.ToString("d/M/yyyy"), 
			                                                                      texto);
			message.IsBodyHtml = true;	
			try {
				smtp.Send(message);				
			}
			catch (Exception e) {
				Log.Grava(Globais.sUsuario, "erro:" + e.Message);
				/**/
				StreamWriter sw = new StreamWriter("c:\\soft\\email.log");
				sw.WriteLine(smtp.Host);
				sw.WriteLine(smtp.Port);
				sw.WriteLine(usuarioSmtp);
				sw.WriteLine(senhaSmtp);
				sw.WriteLine(remetente);
				sw.WriteLine(email);
				while (e != null) {
					sw.WriteLine(e.Message);
					if (e.Message.Length > 100)
						trace.grava(e.Message.Substring(0, 100));
					else
						trace.grava(e.Message);
					e = e.InnerException;
				}
				sw.Close();
				/**/
				/*
				while (e != null) {
					string s = e.Message;
					e = e.InnerException;
				}
				
				if (e.Message.Length > 100)
					trace.grava(e.Message.Substring(0, 100));
				else
					trace.grava(e.Message);
				*/
			}
		}
	}
}
