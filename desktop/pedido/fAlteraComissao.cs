/*
 * Altera o valor/pagamento da comissão
 * Autor: Ricardo Costa Xavier
 * Data : 15/02/10
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using basico;
using classes;

namespace pedido
{
	public partial class fAlteraComissao : Form
	{
		public bool result;
		public float total;
		public float percentual;
		public float valor;
		public bool pago;
		public string justificativa;
		private bool calculando;
	
		public fAlteraComissao()
		{
			InitializeComponent();
			result = false;
			calculando = false;
		}
		
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			result = true;
			pago = chkPago.Checked;
			justificativa = edtJustificativa.Text;
			percentual = Globais.StrToFloat(edtPercentual.Text);
			Close();
		}
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			result = false;
			Close();
		}
		
		void EdtPercentTextChanged(object sender, EventArgs e)
		{
			if (calculando) return;			
			float percentual = Globais.StrToFloat(edtPercentual.Text);
			float valor = total * percentual / 100F;
			calculando = true;
			edtValor.Text = valor.ToString("#,###,##0.00");				
			calculando = false;						
		}
		
		void EdtValorTextChanged(object sender, EventArgs e)
		{
			if (calculando) return;			
			float valor = Globais.StrToFloat(edtValor.Text);
			float percentual = valor * 100F / total;
			calculando = true;
			edtPercentual.Text = percentual.ToString("#0.00");
			calculando = false;						
		}
		
		void FAlteraComissaoLoad(object sender, EventArgs e)
		{
			valor = total * percentual / 100F;
			edtPercentual.Text = percentual.ToString("#0.00");
			edtValor.Text = valor.ToString("#,###,##0.00");
			edtJustificativa.Text = justificativa;
			chkPago.Checked = pago;			
		}
	}
}
