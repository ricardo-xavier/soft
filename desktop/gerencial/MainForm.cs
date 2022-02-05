/*
 * Sistema Gerencial
 * Menu Principal
 * Autor: Ricardo Costa Xavier
 * Data : 27/06/2010
 * 
 * 21/03/2018 - v1.9.0 - Ricardo - por data de vencimento(lançamentos futuros)
 * 18/04/2018 - v1.9.1 - Ricardo - o check de lançamentos futuros estava invisivel
 * 25/04/2018 - v1.9.2 - Ricardo - correção na montagem do sql com vencimento = true
 *
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using templates;
using classes;

namespace gerencial
{
	/// <summary>
	/// Menu Principal
	/// </summary>
	public partial class MainForm : tMenu
	{
		private bool bShow;
		
		[STAThread]
		public static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm(args));
		}
		
		public MainForm(string[] args)
		{
			InitializeComponent();
			admin = false;
			if (args.Length > 0) 
			{
				login = false;
				Globais.sUsuario = args[0];
				Globais.sFilial = args[1];
				Globais.bAdministrador = args[2][0] == 'S';
			}
			else login = true;
			bShow = true;
		}
		
		void MainFormShown(object sender, EventArgs e)
		{
			if (!bShow) return;
			cControleAcesso acesso = new cControleAcesso();
			if (!Globais.bAdministrador &&  !acesso.PermissaoSistema(Globais.sUsuario, Globais.sFilial, 8))
			{
				MessageBox.Show("Usuário sem permissão para esse Sistema", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Close();
			}
			bShow = false;			
		}
		
		void BtnFluxoCaixaClick(object sender, EventArgs e)
		{
			fParamFluxoCaixa frm = new fParamFluxoCaixa();
			if (frm.ShowDialog() != DialogResult.OK) return;
			FluxoCaixa fluxo = new FluxoCaixa();
			fluxo.Gera("fluxo_caixa.pdf", frm.titulo, frm.valor_inicial, frm.idt_inicial, frm.data_inicial, frm.idt_final, frm.data_final, frm.chkVencimento.Checked);
			System.Diagnostics.Process.Start("explorer", "fluxo_caixa.pdf");
		}
		
		void BtnCurvaVendedorClick(object sender, EventArgs e)
		{
			fParamFluxoCaixa frm = new fParamFluxoCaixa();
			frm.Text = "Parâmetros para Impressão Curva Vendedor";
			frm.edtTitulo.Text = "Curva Vendedor";
			frm.lblValor.Visible = false;
			frm.edtValor.Visible = false;
			frm.chkPagos.Visible = true;
			frm.chkAbertos.Visible = true;		
			frm.chkVencimento.Visible = true;
			if (frm.ShowDialog() != DialogResult.OK) return;			
			Curva curva = new Curva();
			curva.Gera('v', "curva_vendedor.pdf", frm.titulo, frm.idt_inicial, frm.data_inicial, frm.idt_final, frm.data_final, frm.chkPagos.Checked, frm.chkAbertos.Checked);
			System.Diagnostics.Process.Start("explorer", "curva_vendedor.pdf");			
		}
		
		void BtnCurvaConsultorClick(object sender, EventArgs e)
		{
			fParamFluxoCaixa frm = new fParamFluxoCaixa();
			frm.Text = "Parâmetros para Impressão Curva Consultor";
			frm.edtTitulo.Text = "Curva Consultor";
			frm.lblValor.Visible = false;
			frm.edtValor.Visible = false;
			frm.chkPagos.Visible = true;
			frm.chkAbertos.Visible = true;
			if (frm.ShowDialog() != DialogResult.OK) return;			
			Curva curva = new Curva();
			curva.Gera('c', "curva_consultor.pdf", frm.titulo, frm.idt_inicial, frm.data_inicial, frm.idt_final, frm.data_final, frm.chkPagos.Checked, frm.chkAbertos.Checked);
			System.Diagnostics.Process.Start("explorer", "curva_consultor.pdf");						
		}
		
		void BtnCurvaFornecedorClick(object sender, EventArgs e)
		{
			fParamFluxoCaixa frm = new fParamFluxoCaixa();
			frm.Text = "Parâmetros para Impressão Curva Fornecedor";
			frm.edtTitulo.Text = "Curva Fornecedor";
			frm.lblValor.Visible = false;
			frm.edtValor.Visible = false;
			if (frm.ShowDialog() != DialogResult.OK) return;			
			Curva curva = new Curva();
			curva.Gera('f', "curva_fornecedor.pdf", frm.titulo, frm.idt_inicial, frm.data_inicial, frm.idt_final, frm.data_final, true, true);
			System.Diagnostics.Process.Start("explorer", "curva_fornecedor.pdf");									
		}
		
		void BtnAvisosClick(object sender, EventArgs e)
		{
			fAvisos frm = new fAvisos();
			frm.ShowDialog();
		}
	}
}
