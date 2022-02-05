/*
 * Projeto  : SoftPlace
 * Sistema  : Orcamentos
 * Programa : fRecebimento - Recebimento de Titulos
 * Autor    : Ricardo Costa Xavier
 * Data     : 24/08/08
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using classes;
using basico;

namespace receber
{
	public partial class fRecebimento : Form
	{
		public bool result;
		private string where;
		
		public fRecebimento(string filtro)
		{
			where = filtro;
			InitializeComponent();
		}
		
		private void CarregaFormas()
		{
			cFormasRecebimento formas = new cFormasRecebimento();
			this.Cursor = Cursors.WaitCursor;
			formas.Carrega(cbxFormas, cbxCodFormas);
			this.Cursor = Cursors.Default;
		}
		
		void FRecebimentoLoad(object sender, EventArgs e)
		{
			result = false;
			CarregaFormas();
			cbxFormas.Text = "";
			dtpRecebimento.Value = DateTime.Now;
		}
		
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			string msg="";
			int f = cbxFormas.SelectedIndex;	
			string forma = (f >= 0) ? cbxCodFormas.Items[f].ToString() : "";
			cTitulosXeceber titulos = new cTitulosXeceber();
			titulos.Recebe(dtpRecebimento.Value, forma, where, ref msg);
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
