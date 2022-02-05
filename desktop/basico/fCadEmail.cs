using System;
using System.Windows.Forms;
using classes;

namespace basico
{
	public partial class fCadEmail : Form
	{
		
		private cEmailApp prms;
		
		public fCadEmail()
		{
			InitializeComponent();
			prms = new cEmailApp();
			prms.Recupera();
			edtRemetente.Text = prms.remetente;
			edtUsuario.Text = prms.usuario;
			edtSenha.Text = prms.senha;
			edtDestinatarios.Text = prms.destinatarios;
			edtAssunto.Text = prms.assunto;
			edtTexto.Text = prms.texto;
		}
		
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			prms.remetente = edtRemetente.Text.Trim();
			prms.usuario = edtUsuario.Text.Trim();
			prms.senha = edtSenha.Text.Trim();
			prms.destinatarios = edtDestinatarios.Text.Trim();
			prms.assunto = edtAssunto.Text.Trim();
			prms.texto = edtTexto.Text.Trim();
			prms.Atualiza();
			Close();
		}
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
