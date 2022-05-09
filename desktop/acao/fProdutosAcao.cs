using System;
using System.Drawing;
using System.Windows.Forms;
using classes;

namespace acao
{
	public partial class fProdutosAcao : Form
	{
		private int seqAcao;
		
		public fProdutosAcao(int seqAcao)
		{
			InitializeComponent();
			this.seqAcao = seqAcao;
			
			cProdutosAcao produtosAcao = new cProdutosAcao();
			this.Cursor = Cursors.WaitCursor;
			produtosAcao.Carrega(dgvCadastro, seqAcao);
			this.Cursor = Cursors.Default;
		}
		
		void BtnFechaClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			cProdutosAcao produtosAcao = new cProdutosAcao();
			string msg = "";
			bool ret = produtosAcao.Atualiza(dgvCadastro, seqAcao, ref msg);
			if (!ret)
			{
				MessageBox.Show("Erro na atualização:\n" + msg);
				return;
			}
			Close();
		}
	}
}
