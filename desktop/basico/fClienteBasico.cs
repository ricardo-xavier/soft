/*
 * Projeto  : SoftPlace
 * Sistema  : CPD
 * Programa : fClienteBasico - Cadastro Basico de Cliente
 * Autor    : Ricardo Costa Xavier
 * Data     : 13/10/08
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using classes;

namespace basico
{
	public partial class fClienteBasico : Form
	{
		public bool result;
		
		public fClienteBasico()
		{
			InitializeComponent();
			result = false;
		}
		
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			if (btnConfirma.Text.CompareTo("Seleciona") == 0)
			{
				result = true;
				Close();
				return;
			}
			if (edtCodigo.Text.Trim().Length == 0)
			{
				MessageBox.Show("Código", "Campo obrigatório", 
				                MessageBoxButtons.OK, 
				                MessageBoxIcon.Warning);
				edtCodigo.Focus();
				return;
			}
			if (edtRazao.Text.Trim().Length == 0)
			{
				MessageBox.Show("Código", "Campo obrigatório", 
				                MessageBoxButtons.OK, 
				                MessageBoxIcon.Warning);
				edtCodigo.Focus();
				return;
			}
			string msg = "";
			cParceiros parceiros = new cParceiros();
			result = parceiros.IncluiRapido(edtCodigo.Text,
			                       edtRazao.Text,
			                       FONE.TiraEdicao(edtFone1.Text),
			                       FONE.TiraEdicao(edtFone2.Text),
			                       FONE.TiraEdicao(edtCelular.Text),
			                       FONE.TiraEdicao(edtFAX.Text),
			                       edtEmail.Text,
			                       ref msg);
			if (!result)
			{
				MessageBox.Show(edtCodigo.Text+"\n"+msg, "Erro na inclusão do cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			if (edtContato.Text.Trim().Length == 0)
			{
				cContatos contatos = new cContatos();
				result = contatos.Inclui(edtCodigo.Text,
				                edtContato.Text,
				                edtNome.Text,
				                FONE.TiraEdicao(edtFoneContato1.Text),
				                FONE.TiraEdicao(edtFoneContato2.Text),
				                FONE.TiraEdicao(edtCelularContato.Text),
				                FONE.TiraEdicao(edtEmailContato.Text),
				                edtPapel.Text, false, DateTime.Now,
				                "S", ref msg);
				if (!result)
				{
					MessageBox.Show(edtContato.Text+"\n"+msg, "Erro na inclusão do contato", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			result = true;
			Close();
		}
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void EdtCodigoLeave(object sender, EventArgs e)
		{
			Parceiro parceiro = new Parceiro();
			if (!parceiro.Le(edtCodigo.Text)) return;
			edtRazao.Text = parceiro.getNome();
			edtFone1.Text = FONE.PoeEdicao(parceiro.getFone1());
			edtFone2.Text = FONE.PoeEdicao(parceiro.getFone2());
			edtCelular.Text = FONE.PoeEdicao(parceiro.getCelular());
			edtFAX.Text = FONE.PoeEdicao(parceiro.getFax());
			edtEmail.Text = parceiro.getEmail();
			btnCancela.Visible = false;
			btnConfirma.Text = "Seleciona";
			parceiro.ListaContatos(edtCodigo.Text, true);
			if (parceiro.contatos.Count == 0) return;
			foreach (Contato contato in parceiro.contatos)
			{
				edtContato.Text = contato.getCodigo();
				edtFoneContato1.Text = FONE.PoeEdicao(contato.getFone1());
				edtFoneContato2.Text = FONE.PoeEdicao(contato.getFone2());
				edtCelularContato.Text = FONE.PoeEdicao(contato.getCelular());
				edtEmailContato.Text = contato.getEmail();
				edtPapel.Text = contato.getPapel();
				break;
			}
		}
		
		void EdtFone1Enter(object sender, EventArgs e)
		{
			((TextBox)sender).Text = FONE.TiraEdicao(((TextBox)sender).Text);
		}
		
		void EdtFone1Leave(object sender, EventArgs e)
		{
			((TextBox)sender).Text = FONE.PoeEdicao(((TextBox)sender).Text);
		}
	}
}
