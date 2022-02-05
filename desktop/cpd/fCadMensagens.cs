/*
 * Projeto  : SoftPlace
 * Sistema  : CPD
 * Programa : fCadMensagens - Cadastro de Mensagens
 * Autor    : Ricardo Costa Xavier
 * Data     : 13/10/15
 */
using System;
using System.Windows.Forms;
using templates;
using classes;

namespace cpd
{
	public partial class fCadMensagens : tCadastroSimples
	{
		private cMensagens mensagens;
		
		void AlteraComponentes()
		{
			edtCodigo.CharacterCasing = CharacterCasing.Upper;
			dgvCadastro.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCadastroRowEnter);
		}
		
		
		void InicializaCampos()
		{
			edtCodigo.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
			edtDescricao.Text = Globais.sUsuario;
			edtMensagem.Text = "";
		}
		
		public void SetaEdicaoLocal(bool enabled)
		{
			edtCodigo.Enabled = false;
			edtDescricao.Enabled = false;
			edtMensagem.Enabled = enabled;
		}
		
		public void AtualizaDadosLocal(int i)
		{
			edtMensagem.Text = dgvCadastro.Rows[i].Cells[2].Value.ToString().Trim();		
		}
		
		public fCadMensagens()
		{
			InitializeComponent();
			AlteraComponentes();
		}
		
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			string msg="";
			bool result;
			string codigo = edtCodigo.Text.Trim();
			if (acao == 'I') 
			{
				acao = 'i';
				return;
			}
			if (acao == 'A') 
			{
				acao = 'a';
				return;
			}
			if (acao == 'i')
				result = mensagens.Inclui(edtMensagem.Text, ref msg);
			else
				result = mensagens.Altera(codigo, edtDescricao.Text.Trim(), edtMensagem.Text, ref msg);
			if (!result)
			{
				if (acao == 'i')
					MessageBox.Show(codigo+"\n"+msg, "Erro na inclusão da mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
				else
					MessageBox.Show(codigo+"\n"+msg, "Erro na alteração da mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);				
			}
			this.Cursor = Cursors.WaitCursor;
			mensagens.Carrega(dgvCadastro);
			this.Cursor = Cursors.Default;
			int selecionado = Procura(codigo, true);
			if (selecionado >= 0)
			{
				dgvCadastro.Rows[selecionado].Cells[0].Selected = true;
				AtualizaDados(selecionado);
				AtualizaDadosLocal(selecionado);
			}
			DesabilitaEdicao();
			SetaEdicaoLocal(false);	
		}

		void fCadMensagensLoad(object sender, EventArgs e)
		{
			mensagens = new cMensagens();
			this.Cursor = Cursors.WaitCursor;
			mensagens.Carrega(dgvCadastro);		
			this.Cursor = Cursors.Default;			
			SetaEdicaoLocal(false);		
		}
		
		void BtnExcluiClick(object sender, EventArgs e)
		{
			string msg="";
			bool result;
			if (acao == 'c') return;
			string codigo = edtCodigo.Text.Trim();
			result = mensagens.Exclui(codigo, edtDescricao.Text.Trim(), ref msg);
			if (!result)
			{
				MessageBox.Show(codigo + "\r\n" + Globais.ErroExclusao("Mensagem não encontrada", msg), "Erro na exclusão da mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			this.Cursor = Cursors.WaitCursor;
			mensagens.Carrega(dgvCadastro);
			this.Cursor = Cursors.Default;
			if (dgvCadastro.Rows.Count == 0)
			{
				InicializaCampos();
			}						
		}
		
		void DgvCadastroRowEnter(object sender, DataGridViewCellEventArgs e)
		{
			AtualizaDadosLocal(e.RowIndex);
		}		
		
		void BtnIncluiClick(object sender, EventArgs e)
		{
			SetaEdicaoLocal(true);
			InicializaCampos();
			edtMensagem.Focus();
		}
		
		void BtnAlteraClick(object sender, EventArgs e)
		{
			if (acao == 'c') return;
			SetaEdicaoLocal(true);
			edtMensagem.Focus();
		}
		
		
		
	}
}
