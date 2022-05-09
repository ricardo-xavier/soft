using System;
using System.Windows.Forms;
using classes;

namespace cpd
{
	public partial class Mensagens : Form
	{
		public Mensagens()
		{
			InitializeComponent();
			tbMensagem.Text = cMensagens.UltimaMensagem();
		}
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			Close();
		}
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			cMensagens.Insere(tbMensagem.Text);
			Close();
		}
	}
}
