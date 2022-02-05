/*
 * Projeto  : SoftPlace
 * Sistema  : Pagar
 * Programa : fLote - Inclusão de Títulos em Lote
 * Autor    : Ricardo Costa Xavier
 * Data     : 11/05/10
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace pagar
{
	public partial class fLote : Form
	{
		public int repeticoes;
		public string frequencia;
		public DateTime limite;
		public bool idt_limite;
		
		public fLote()
		{
			InitializeComponent();
		}
		
		void FLoteLoad(object sender, EventArgs e)
		{
			cbxFrequencia.Items.Add("Semanal");
			cbxFrequencia.Items.Add("Quinzenal");
			cbxFrequencia.Items.Add("Mensal");
			cbxFrequencia.Items.Add("Anual");
			cbxFrequencia.Text = "Mensal";
		}
		
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			frequencia = cbxFrequencia.Text;			
			int.TryParse(edtRepeticoes.Text, out repeticoes);
			limite = dtpLimite.Value;
			idt_limite = dtpLimite.Checked;
			DialogResult = DialogResult.OK;
			Close();
		}
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();			
		}
		
		void DtpLimiteValueChanged(object sender, EventArgs e)
		{
			edtRepeticoes.Enabled = !dtpLimite.Checked;
		}
	}
}
