/*
 * Seleciona parâmetros para impressão do pedido
 * Usuário: Ricardo
 * Histórico:
 * 02/06/09 - versão inicial
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace agenda
{
	public partial class fParametrosImpressao : Form
	{
		public bool result;
		public string titulo;
		public DateTime dataInicial;
		public bool idtInicial;
		public DateTime dataFinal;
		public bool idtFinal;
		
		public fParametrosImpressao()
		{
			InitializeComponent();
			result = false;			
		}
		
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			result = true;
			titulo = edtTitulo.Text;
			dataInicial = dtpI.Value;
			idtInicial = dtpI.Checked;
			dataFinal = dtpF.Value;
			idtFinal = dtpF.Checked;
			Close();
		}
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			Close();
		}
		
		
		void FParametrosImpressaoLoad(object sender, EventArgs e)
		{
			edtTitulo.Text = titulo;
			dtpI.Value = dataInicial;
			dtpF.Value = dataFinal;						
		}
	}
}
