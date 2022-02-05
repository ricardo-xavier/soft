using System;
using System.Drawing;
using System.Windows.Forms;
using classes;

namespace acao
{
	public partial class SelecaoVendedor : Form
	{
		public string vendedor;
		
		public SelecaoVendedor()
		{
			InitializeComponent();
			cUsuarios usuarios = new cUsuarios();
			this.Cursor = Cursors.WaitCursor;
			AcaoDAO.CarregaVendedores(cbxVendedores);
			this.Cursor = Cursors.Default;			
		}
		
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			vendedor = cbxVendedores.Text;
			Close();
		}
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			vendedor = null;
			Close();
		}
	}
}
