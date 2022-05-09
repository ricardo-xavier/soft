/*
 * Criado por SharpDevelop.
 * Usuário: Ricardo
 * Data: 21/08/2010
 * Hora: 19:56
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using classes;

namespace basico
{
	public partial class fFrete : Form
	{
		public float frete_atual;
		public float valor;
		public float novo_frete;		
		public bool result;
		
		public fFrete()
		{		
			InitializeComponent();
			result = false;
		}
		
		void FFreteLoad(object sender, EventArgs e)
		{
			edtAtual.Text = frete_atual.ToString("#,###,##0.00");
			float valor = this.valor;
			edtValor.Text = valor.ToString("#,###,##0.00");
			edtNovo.Text = valor.ToString("#,###,##0.00");
		}
		
		void EdtValorTextChanged(object sender, EventArgs e)
		{
			float valor = Globais.StrToFloat(edtValor.Text);
			if (chkAdicionar.Checked)
				novo_frete = frete_atual + valor;
			else
				novo_frete = valor;
			edtNovo.Text = novo_frete.ToString("#,###,##0.00");
		}
		
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			result = true;
			Close();
		}
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			result = false;
			Close();
		}
		
		void ChkAdicionarCheckedChanged(object sender, EventArgs e)
		{
			float valor = Globais.StrToFloat(edtValor.Text);
			if (chkAdicionar.Checked)
				novo_frete = frete_atual + valor;
			else
				novo_frete = valor;
			edtNovo.Text = novo_frete.ToString("#,###,##0.00");			
		}
	}
}
