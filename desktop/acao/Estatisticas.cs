using System;
using System.Drawing;
using System.Windows.Forms;

namespace acao
{
	public partial class Estatisticas : Form
	{
		
		private string vendedor;
		
		public Estatisticas(string vendedor)
		{
			this.vendedor = vendedor;
			InitializeComponent();
			int nTotalAcoes = 0;
			float vTotalAcoes = 0;
			int nConcretizadas = 0;
			float vConcretizadas = 0;
			int pConcretizadas = 0;
			int nTotalOrcamentos = 0;
			float vTotalOrcamentos = 0;			
			int nConcretizados = 0;
			float vConcretizados = 0;
			int pConcretizados = 0;			
			AcaoDAO.Estatisticas(dgvAcoes, dgvOrcamentos, vendedor, 
			                     ref nTotalAcoes, ref vTotalAcoes,
			                     ref nConcretizadas, ref vConcretizadas, ref pConcretizadas,
			                     ref nTotalOrcamentos, ref vTotalOrcamentos);
			lblQtdTotalAcoes.Text = nTotalAcoes.ToString();
			lblVlrAcoes.Text = vTotalAcoes.ToString("###,###,##0.00");
			lblQtdConcretizadas.Text = nConcretizadas.ToString();
			lblVlrConcretizadas.Text = vConcretizadas.ToString("###,###,##0.00");
			lblPerConcretizadas.Text = pConcretizadas.ToString();
			lblQtdTotalOrcamentos.Text = nTotalOrcamentos.ToString();
			lblVlrOrcamentos.Text = vTotalOrcamentos.ToString("###,###,##0.00");			
			lblQtdConcretizados.Text = nConcretizados.ToString();
			lblVlrConcretizados.Text = vConcretizados.ToString("###,###,##0.00");
			lblPerConcretizados.Text = pConcretizados.ToString();		
			lblProbabilidade.Text = (pConcretizados * pConcretizadas / 100).ToString();
			Text = "Vendedor: " + vendedor;
		}
		
		void BtnFechaClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void DgvOrcamentosMouseDoubleClick(object sender, MouseEventArgs e)
		{
			DataGridView.HitTestInfo hti = dgvOrcamentos.HitTest(e.X, e.Y);
			if (hti.RowIndex == -1)
			{
				return;
			}
			int i = hti.RowIndex;
			string situacao = dgvOrcamentos.Rows[i].Cells["Situação"].Value.ToString();
			string xx = situacao;
			string yy = vendedor;
			
			string[] args = new string[2];
			args[0] = vendedor;
			args[1] = situacao;
			orcamento.MainForm frm = new orcamento.MainForm(args);
			frm.ShowDialog();				
		}
	}
}
