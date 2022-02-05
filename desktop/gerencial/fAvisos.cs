/*
 * Sistema Gerencial
 * Formulário para configuração de avisos
 * Autor: Ricardo Costa Xavier
 * Data : 19/11/2010
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using classes;

namespace gerencial
{
	/// <summary>
	/// Formulário para configuração de avisos
	/// </summary>
	public partial class fAvisos : Form
	{		
		private cAvisos avisos;
		
		public fAvisos()
		{
			InitializeComponent();
			avisos = new cAvisos();
		}
				
		void FAvisosLoad(object sender, EventArgs e)
		{			
			avisos.Le();
			
			// Smtp
			edtServidor.Text = avisos.servidorSmtp;
			edtPorta.Text = avisos.portaSmtp.ToString();
			edtUsuario.Text = avisos.usuarioSmtp;
			edtSenha.Text = avisos.senhaSmtp;
			edtRemetente.Text = avisos.remetente;

			// Agenda			
			foreach (string tipo in Enum.GetNames(typeof(Frequencias)))
			{
				cbxFrequenciaAgenda.Items.Add(tipo);
			}			
			cbxFrequenciaAgenda.Text = Enum.GetName(typeof(Frequencias), (int)avisos.frequenciaAgenda[0]);
			switch ((short)avisos.frequenciaAgenda[0])
			{
				case (short)Frequencias.Diaria: 
					label14.Visible = false;
					edtDiaAgenda.Visible = false;
					cbxDiaAgenda.Visible = false;
					break;
				case (short)Frequencias.Semanal: 
					label14.Text = "Dia da semana";
					edtDiaAgenda.Visible = false;
					cbxDiaAgenda.Visible = true;
					break;
				case (short)Frequencias.Mensal: 
					label14.Text = "Dia do mês";
					edtDiaAgenda.Visible = true;
					cbxDiaAgenda.Visible = false;
					break;
			}
			foreach (string dia in Enum.GetNames(typeof(DiasSemana)))
			{
				cbxDiaAgenda.Items.Add(dia);
			}
			cbxDiaAgenda.Text = Enum.GetName(typeof(DiasSemana), avisos.diaAgenda);			
			edtDiasAgenda.Text = avisos.diasAgenda.ToString();
			edtDiaAgenda.Text = avisos.diaAgenda.ToString();
			
			// Orçamento
			foreach (string tipo in Enum.GetNames(typeof(Frequencias)))
			{
				cbxFrequenciaOrcamento.Items.Add(tipo);
			}			
			cbxFrequenciaOrcamento.Text = Enum.GetName(typeof(Frequencias), (int)avisos.frequenciaOrcamento[0]);
			switch ((short)avisos.frequenciaOrcamento[0])
			{
				case (short)Frequencias.Diaria: 
					label24.Visible = false;
					edtDiaOrcamento.Visible = false;
					cbxDiaOrcamento.Visible = false;
					break;
				case (short)Frequencias.Semanal:
					label24.Text = "Dia da semana";
					edtDiaOrcamento.Visible = false;
					cbxDiaOrcamento.Visible = true;
					break;
				case (short)Frequencias.Mensal:
					label24.Text = "Dia do mês";
					edtDiaOrcamento.Visible = true;
					cbxDiaOrcamento.Visible = false;
					break;
			}
			foreach (string dia in Enum.GetNames(typeof(DiasSemana)))
			{
				cbxDiaOrcamento.Items.Add(dia);
			}
			cbxDiaOrcamento.Text = Enum.GetName(typeof(DiasSemana), avisos.diaOrcamento);			
			edtDiasOrcamento.Text = avisos.diasOrcamento.ToString();
			edtDiaOrcamento.Text = avisos.diaOrcamento.ToString();			
			
			// Pedido - Confirmação Entrega
			foreach (string tipo in Enum.GetNames(typeof(Frequencias)))
			{
				cbxFrequenciaConfirmacaoEntrega.Items.Add(tipo);
			}			
			cbxFrequenciaConfirmacaoEntrega.Text = Enum.GetName(typeof(Frequencias), (int)avisos.frequenciaConfirmacaoEntrega[0]);
			switch ((short)avisos.frequenciaConfirmacaoEntrega[0])
			{
				case (short)Frequencias.Diaria: 
					label1.Visible = false;
					edtDiaConfirmacaoEntrega.Visible = false;
					cbxDiaConfirmacaoEntrega.Visible = false;
					break;
				case (short)Frequencias.Semanal:
					label1.Text = "Dia da semana";
					edtDiaConfirmacaoEntrega.Visible = false;
					cbxDiaConfirmacaoEntrega.Visible = true;
					break;
				case (short)Frequencias.Mensal:
					label1.Text = "Dia do mês";
					edtDiaConfirmacaoEntrega.Visible = true;
					cbxDiaConfirmacaoEntrega.Visible = false;
					break;
			}
			foreach (string dia in Enum.GetNames(typeof(DiasSemana)))
			{
				cbxDiaConfirmacaoEntrega.Items.Add(dia);
			}
			cbxDiaConfirmacaoEntrega.Text = Enum.GetName(typeof(DiasSemana), avisos.diaConfirmacaoEntrega);			
			edtDiasConfirmacaoEntrega.Text = avisos.diasConfirmacaoEntrega.ToString();
			edtDiaConfirmacaoEntrega.Text = avisos.diaConfirmacaoEntrega.ToString();		
			
			// Pedido - Entrega
			foreach (string tipo in Enum.GetNames(typeof(Frequencias)))
			{
				cbxFrequenciaEntrega.Items.Add(tipo);
			}			
			cbxFrequenciaEntrega.Text = Enum.GetName(typeof(Frequencias), (int)avisos.frequenciaEntrega[0]);
			switch ((short)avisos.frequenciaEntrega[0])
			{
				case (short)Frequencias.Diaria: 
					label6.Visible = false;
					edtDiaEntrega.Visible = false;
					cbxDiaEntrega.Visible = false;
					break;
				case (short)Frequencias.Semanal:
					label6.Text = "Dia da semana";
					edtDiaEntrega.Visible = false;
					cbxDiaEntrega.Visible = true;
					break;
				case (short)Frequencias.Mensal:
					label6.Text = "Dia do mês";
					edtDiaEntrega.Visible = true;
					cbxDiaEntrega.Visible = false;
					break;
			}
			foreach (string dia in Enum.GetNames(typeof(DiasSemana)))
			{
				cbxDiaEntrega.Items.Add(dia);
			}
			cbxDiaEntrega.Text = Enum.GetName(typeof(DiasSemana), avisos.diaEntrega);			
			edtDiasEntrega.Text = avisos.diasEntrega.ToString();
			edtDiaEntrega.Text = avisos.diaEntrega.ToString();	
			
			// Pedido - Montagem
			foreach (string tipo in Enum.GetNames(typeof(Frequencias)))
			{
				cbxFrequenciaMontagem.Items.Add(tipo);
			}			
			cbxFrequenciaMontagem.Text = Enum.GetName(typeof(Frequencias), (int)avisos.frequenciaMontagem[0]);
			switch ((short)avisos.frequenciaMontagem[0])
			{
				case (short)Frequencias.Diaria: 
					label10.Visible = false;
					edtDiaMontagem.Visible = false;
					cbxDiaMontagem.Visible = false;
					break;
				case (short)Frequencias.Semanal:
					label10.Text = "Dia da semana";
					edtDiaMontagem.Visible = false;
					cbxDiaMontagem.Visible = true;
					break;
				case (short)Frequencias.Mensal:
					label10.Text = "Dia do mês";
					edtDiaMontagem.Visible = true;
					cbxDiaMontagem.Visible = false;
					break;
			}
			foreach (string dia in Enum.GetNames(typeof(DiasSemana)))
			{
				cbxDiaMontagem.Items.Add(dia);
			}
			cbxDiaMontagem.Text = Enum.GetName(typeof(DiasSemana), avisos.diaMontagem);			
			edtDiasMontagem.Text = avisos.diasMontagem.ToString();
			edtDiaMontagem.Text = avisos.diaMontagem.ToString();	
			
			// Pedido - Faturamento
			foreach (string tipo in Enum.GetNames(typeof(Frequencias)))
			{
				cbxFrequenciaFaturamento.Items.Add(tipo);
			}			
			cbxFrequenciaFaturamento.Text = Enum.GetName(typeof(Frequencias), (int)avisos.frequenciaFaturamento[0]);
			switch ((short)avisos.frequenciaFaturamento[0])
			{
				case (short)Frequencias.Diaria: 
					label18.Visible = false;
					edtDiaFaturamento.Visible = false;
					cbxDiaFaturamento.Visible = false;
					break;
				case (short)Frequencias.Semanal:
					label18.Text = "Dia da semana";
					edtDiaFaturamento.Visible = false;
					cbxDiaFaturamento.Visible = true;
					break;
				case (short)Frequencias.Mensal:
					label18.Text = "Dia do mês";
					edtDiaFaturamento.Visible = true;
					cbxDiaFaturamento.Visible = false;
					break;
			}
			foreach (string dia in Enum.GetNames(typeof(DiasSemana)))
			{
				cbxDiaFaturamento.Items.Add(dia);
			}
			cbxDiaFaturamento.Text = Enum.GetName(typeof(DiasSemana), avisos.diaFaturamento);			
			edtDiasFaturamento.Text = avisos.diasFaturamento.ToString();
			edtDiaFaturamento.Text = avisos.diaFaturamento.ToString();
		}
		
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			// Smtp
			avisos.servidorSmtp = edtServidor.Text;
			short.TryParse(edtPorta.Text, out avisos.portaSmtp);
			avisos.usuarioSmtp = edtUsuario.Text;
			avisos.senhaSmtp = edtSenha.Text;
			avisos.remetente = edtRemetente.Text;
			
			// Agenda
			short.TryParse(edtDiasAgenda.Text, out avisos.diasAgenda);
			avisos.frequenciaAgenda = cbxFrequenciaAgenda.Text.Substring(0, 1);
			switch ((short)avisos.frequenciaAgenda[0])
			{
				case (short)Frequencias.Diaria: 
					avisos.diaAgenda = 0; 
					break;
				case (short)Frequencias.Semanal: 
					avisos.diaAgenda = (short)Enum.Parse(typeof(DiasSemana), cbxDiaAgenda.Text);
					break;
				case (short)Frequencias.Mensal: 
					short.TryParse(edtDiaAgenda.Text, out avisos.diaAgenda);
					break;
			}
			
			// Orçamento
			short.TryParse(edtDiasOrcamento.Text, out avisos.diasOrcamento);
			avisos.frequenciaOrcamento = cbxFrequenciaOrcamento.Text.Substring(0, 1);
			switch ((short)avisos.frequenciaOrcamento[0])
			{
				case (short)Frequencias.Diaria: 
					avisos.diaOrcamento = 0; 
					break;
				case (short)Frequencias.Semanal: 
					avisos.diaOrcamento = (short)Enum.Parse(typeof(DiasSemana), cbxDiaOrcamento.Text);
					break;
				case (short)Frequencias.Mensal: 
					short.TryParse(edtDiaOrcamento.Text, out avisos.diaOrcamento);
					break;
			}			
			
			// Pedido - Confirmação Entrega
			short.TryParse(edtDiasConfirmacaoEntrega.Text, out avisos.diasConfirmacaoEntrega);
			avisos.frequenciaConfirmacaoEntrega = cbxFrequenciaConfirmacaoEntrega.Text.Substring(0, 1);
			switch ((short)avisos.frequenciaConfirmacaoEntrega[0])
			{
				case (short)Frequencias.Diaria: 
					avisos.diaConfirmacaoEntrega = 0; 
					break;
				case (short)Frequencias.Semanal: 
					avisos.diaConfirmacaoEntrega = (short)Enum.Parse(typeof(DiasSemana), cbxDiaConfirmacaoEntrega.Text);
					break;
				case (short)Frequencias.Mensal: 
					short.TryParse(edtDiaConfirmacaoEntrega.Text, out avisos.diaConfirmacaoEntrega);
					break;
			}
			
			// Pedido - Entrega
			short.TryParse(edtDiasEntrega.Text, out avisos.diasEntrega);
			avisos.frequenciaEntrega = cbxFrequenciaEntrega.Text.Substring(0, 1);
			switch ((short)avisos.frequenciaEntrega[0])
			{
				case (short)Frequencias.Diaria: 
					avisos.diaEntrega = 0; 
					break;
				case (short)Frequencias.Semanal: 
					avisos.diaEntrega = (short)Enum.Parse(typeof(DiasSemana), cbxDiaEntrega.Text);
					break;
				case (short)Frequencias.Mensal: 
					short.TryParse(edtDiaEntrega.Text, out avisos.diaEntrega);
					break;
			}
			
			// Pedido - Montagem
			short.TryParse(edtDiasMontagem.Text, out avisos.diasMontagem);
			avisos.frequenciaMontagem = cbxFrequenciaMontagem.Text.Substring(0, 1);
			switch ((short)avisos.frequenciaMontagem[0])
			{
				case (short)Frequencias.Diaria: 
					avisos.diaMontagem = 0; 
					break;
				case (short)Frequencias.Semanal: 
					avisos.diaMontagem = (short)Enum.Parse(typeof(DiasSemana), cbxDiaMontagem.Text);
					break;
				case (short)Frequencias.Mensal: 
					short.TryParse(edtDiaMontagem.Text, out avisos.diaMontagem);
					break;
			}			
			
			// Pedido - Faturamento
			short.TryParse(edtDiasFaturamento.Text, out avisos.diasFaturamento);
			avisos.frequenciaFaturamento = cbxFrequenciaFaturamento.Text.Substring(0, 1);
			switch ((short)avisos.frequenciaFaturamento[0])
			{
				case (short)Frequencias.Diaria: 
					avisos.diaFaturamento = 0; 
					break;
				case (short)Frequencias.Semanal: 
					avisos.diaFaturamento = (short)Enum.Parse(typeof(DiasSemana), cbxDiaFaturamento.Text);
					break;
				case (short)Frequencias.Mensal: 
					short.TryParse(edtDiaFaturamento.Text, out avisos.diaFaturamento);
					break;
			}	
			
			string msg="";
			if (!avisos.Grava(ref msg))
			{
				MessageBox.Show("Erro na gravação da configuração\r\n" + msg);				
			}
			Close();
		}
		
		void CbxFrequenciaAgendaSelectedIndexChanged(object sender, EventArgs e)
		{
			string frequenciaAgenda = cbxFrequenciaAgenda.Text.Substring(0, 1);
			switch ((short)frequenciaAgenda[0])
			{
				case (short)Frequencias.Diaria:
					label14.Visible = false;
					edtDiaAgenda.Visible = false;
					cbxDiaAgenda.Visible = false;
					break;
				case (short)Frequencias.Semanal: 
					label14.Text = "Dia da semana";
					edtDiaAgenda.Visible = false;
					cbxDiaAgenda.Visible = true;
					break;
				case (short)Frequencias.Mensal: 
					label14.Text = "Dia do mês";
					edtDiaAgenda.Visible = true;
					cbxDiaAgenda.Visible = false;					
					break;
			}			
		}
		
		void CbxFrequenciaOrcamentoSelectedIndexChanged(object sender, EventArgs e)
		{
			string frequenciaOrcamento = cbxFrequenciaOrcamento.Text.Substring(0, 1);
			switch ((short)frequenciaOrcamento[0])
			{
				case (short)Frequencias.Diaria:
					label24.Visible = false;
					edtDiaOrcamento.Visible = false;
					cbxDiaOrcamento.Visible = false;
					break;
				case (short)Frequencias.Semanal: 
					label24.Text = "Dia da semana";
					edtDiaOrcamento.Visible = false;
					cbxDiaOrcamento.Visible = true;
					break;
				case (short)Frequencias.Mensal: 
					label24.Text = "Dia do mês";
					edtDiaOrcamento.Visible = true;
					cbxDiaOrcamento.Visible = false;					
					break;
			}						
		}
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void CbxFrequenciaConfirmacaoEntregaSelectedIndexChanged(object sender, EventArgs e)
		{
			string frequenciaConfirmacaoEntrega = cbxFrequenciaConfirmacaoEntrega.Text.Substring(0, 1);
			switch ((short)frequenciaConfirmacaoEntrega[0])
			{
				case (short)Frequencias.Diaria:
					label1.Visible = false;
					edtDiaConfirmacaoEntrega.Visible = false;
					cbxDiaConfirmacaoEntrega.Visible = false;
					break;
				case (short)Frequencias.Semanal: 
					label1.Text = "Dia da semana";
					edtDiaConfirmacaoEntrega.Visible = false;
					cbxDiaConfirmacaoEntrega.Visible = true;
					break;
				case (short)Frequencias.Mensal: 
					label1.Text = "Dia do mês";
					edtDiaConfirmacaoEntrega.Visible = true;
					cbxDiaConfirmacaoEntrega.Visible = false;					
					break;
			}				
		}
		
		void CbxFrequenciaEntregaSelectedIndexChanged(object sender, EventArgs e)
		{
			string frequenciaEntrega = cbxFrequenciaEntrega.Text.Substring(0, 1);
			switch ((short)frequenciaEntrega[0])
			{
				case (short)Frequencias.Diaria:
					label6.Visible = false;
					edtDiaEntrega.Visible = false;
					cbxDiaEntrega.Visible = false;
					break;
				case (short)Frequencias.Semanal: 
					label6.Text = "Dia da semana";
					edtDiaEntrega.Visible = false;
					cbxDiaEntrega.Visible = true;
					break;
				case (short)Frequencias.Mensal: 
					label6.Text = "Dia do mês";
					edtDiaEntrega.Visible = true;
					cbxDiaEntrega.Visible = false;					
					break;
			}				
		}
		
		void CbxFrequenciaMontagemSelectedIndexChanged(object sender, EventArgs e)
		{
			string frequenciaMontagem = cbxFrequenciaMontagem.Text.Substring(0, 1);
			switch ((short)frequenciaMontagem[0])
			{
				case (short)Frequencias.Diaria:
					label10.Visible = false;
					edtDiaMontagem.Visible = false;
					cbxDiaMontagem.Visible = false;
					break;
				case (short)Frequencias.Semanal: 
					label10.Text = "Dia da semana";
					edtDiaMontagem.Visible = false;
					cbxDiaMontagem.Visible = true;
					break;
				case (short)Frequencias.Mensal: 
					label10.Text = "Dia do mês";
					edtDiaMontagem.Visible = true;
					cbxDiaMontagem.Visible = false;					
					break;
			}				
		}
		
		void CbxFrequenciaFaturamentoSelectedIndexChanged(object sender, EventArgs e)
		{
			string frequenciaFaturamento = cbxFrequenciaFaturamento.Text.Substring(0, 1);
			switch ((short)frequenciaFaturamento[0])
			{
				case (short)Frequencias.Diaria:
					label18.Visible = false;
					edtDiaFaturamento.Visible = false;
					cbxDiaFaturamento.Visible = false;
					break;
				case (short)Frequencias.Semanal: 
					label18.Text = "Dia da semana";
					edtDiaFaturamento.Visible = false;
					cbxDiaFaturamento.Visible = true;
					break;
				case (short)Frequencias.Mensal: 
					label18.Text = "Dia do mês";
					edtDiaFaturamento.Visible = true;
					cbxDiaFaturamento.Visible = false;					
					break;
			}				
		}
	}
}
