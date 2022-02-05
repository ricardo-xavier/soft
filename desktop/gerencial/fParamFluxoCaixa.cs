/*
 * Sistema Gerencial
 * Parametros para Impressão do Fluxo de Caixa
 * Autor: Ricardo Costa Xavier
 * Data : 27/06/2010
 * 
 * 21/03/2018 - Ricardo - por data de vencimento(lançamentos futuros)
 * 
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace gerencial
{
	/// <summary>
	/// Parâmetros para Impressão do Fluxo de Caixa
	/// </summary>
	public partial class fParamFluxoCaixa : Form
	{
		public string titulo;
		public float valor_inicial;
		public bool idt_inicial;
		public DateTime data_inicial;
		public bool idt_final;
		public DateTime data_final;
		
		public fParamFluxoCaixa()
		{
			InitializeComponent();
			dtpDataI.Value = DateTime.Now;
			dtpDataF.Value = DateTime.Now;
		}
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			Close();
		}
		
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			titulo = edtTitulo.Text;
			float.TryParse(edtValor.Text, out valor_inicial);
			idt_inicial = dtpDataI.Checked;
			data_inicial = dtpDataI.Value;
			idt_final = dtpDataF.Checked;
			data_final = dtpDataF.Value;
			this.DialogResult = DialogResult.OK;
			Close();
		}
	}
}
