/*
 * Projeto  : SoftPlace
 * Sistema  : Orcamentos
 * Programa : fPagamento - Pagamento de Titulos
 * Autor    : Ricardo Costa Xavier
 * Data     : 02/08/08
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using classes;
using basico;

namespace pagar
{
	public partial class fPagamento : Form
	{
		public bool result;
		private string where;
		
		public fPagamento(string filtro)
		{
			where = filtro;
			InitializeComponent();
		}
		
		private void CarregaFormas()
		{
			cFormas formas = new cFormas();
			this.Cursor = Cursors.WaitCursor;
			formas.Carrega(cbxFormas, cbxCodFormas);
			this.Cursor = Cursors.Default;
		}
		
		void FPagamentoLoad(object sender, EventArgs e)
		{
			result = false;
			CarregaFormas();
			cbxFormas.Text = "";
			dtpPagamento.Value = DateTime.Now;
		}
		
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			string msg="";
			int f = cbxFormas.SelectedIndex;	
			string forma = (f >= 0) ? cbxCodFormas.Items[f].ToString() : "";
			cTitulosPagar titulos = new cTitulosPagar();
			titulos.Paga(dtpPagamento.Value, forma, edtDocGerado.Text, where, ref msg);
			result = true;
			Close();
		}
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void BtnFormasClick(object sender, EventArgs e)
		{
			fCadFormas frmCad = new fCadFormas(true);
			frmCad.ShowDialog();
			if (frmCad.result)
			{
				CarregaFormas();
				cbxCodFormas.Text = frmCad.codigo;
				int f = cbxCodFormas.SelectedIndex;
				cbxFormas.Text = (f >= 0) ? cbxFormas.Items[f].ToString() : "";
			}
			cbxFormas.Focus();
		}
	}
}
