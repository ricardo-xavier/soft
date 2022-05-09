using System;
using System.Drawing;
using System.Windows.Forms;

namespace acao
{
	public partial class fObservacao : Form
	{
		public fObservacao(String titulo, String texto)
		{
			InitializeComponent();
			this.Text = titulo;			
			edtObservacao.Text = texto;			
		}
		
		void BtnFechaClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
