/*
 * Projeto  : SoftPlace
 * Sistema  : CPD
 * Programa : fCadUsuarios - Cadastro de Usuarios
 * Autor    : Ricardo Costa Xavier
 * Data     : 01/04/08
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using templates;
using classes;

namespace cpd
{
	public partial class frmCadUsuarios : tCadastroSimples
	{
		private cUsuarios usuarios;
		
		void AlteraComponentes()
		{
			edtCodigo.MaxLength = 20;
			dgvCadastro.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCadastroRowEnter);
		}
		
		void InicializaCampos()
		{
			edtCodigo.Text = "";
			edtDescricao.Text = "";
			edtSenha.Text = "";
			edtConfirma.Text = "";
			ckbAdministrador.Checked = false;
			ckbAtivo.Checked = true;
		}
		
		public frmCadUsuarios()
		{
			InitializeComponent();
			AlteraComponentes();
		}
		
		public void DesabilitaEdicaoLocal()
		{
			edtSenha.Enabled = false;
			edtConfirma.Enabled = false;
			ckbAdministrador.Enabled = false;
			ckbAtivo.Enabled = false;
			btnAlteraSenha.Enabled = true;
			edtSenha.Enabled = false;
			edtConfirma.Enabled = false;
		}
		
		public void HabilitaEdicaoLocal() 
		{
			edtSenha.Enabled = true;
			edtConfirma.Enabled = true;
			ckbAdministrador.Enabled = true;
			ckbAtivo.Enabled = true;
			btnAlteraSenha.Enabled = false;
			edtSenha.Enabled = (acao == 'i');
			edtConfirma.Enabled = (acao == 'i');
		}		

		public void AtualizaDadosLocal(int i)
		{
			//edtSenha.Text = dgvCadastro.Rows[i].Cells[2].Value.ToString().Trim();
			//edtConfirma.Text = dgvCadastro.Rows[i].Cells[2].Value.ToString().Trim();
			edtSenha.Text = "";
			edtConfirma.Text = "";			
			ckbAdministrador.Checked = (dgvCadastro.Rows[i].Cells[3].Value.ToString().CompareTo("S") == 0);
			ckbAtivo.Checked = (dgvCadastro.Rows[i].Cells[4].Value.ToString().CompareTo("S") == 0);		
		}
		
		void FrmCadUsuariosLoad(object sender, EventArgs e)
		{
			usuarios = new cUsuarios();
			this.Cursor = Cursors.WaitCursor;
			usuarios.Carrega(dgvCadastro, "");
			this.Cursor = Cursors.Default;
			DesabilitaEdicaoLocal();			
		}
		
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			string msg="";
			bool   result;
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
			if (edtSenha.Text.Trim().CompareTo(edtConfirma.Text.Trim()) != 0)
			{
				MessageBox.Show("Senhas diferentes", "", 
				                MessageBoxButtons.OK, 
				                MessageBoxIcon.Warning);
				edtCodigo.Focus();
				return;
			}
			string idt_adm = (ckbAdministrador.Checked ? "S" : "N");
			string idt_ativo = (ckbAtivo.Checked ? "S" : "N");
			cCriptografia c = new cCriptografia();
			string senha = c.Criptografa(edtSenha.Text);		
			if (acao == 'i')
				result = usuarios.Inclui(codigo, edtDescricao.Text, senha, idt_adm, idt_ativo, ref msg);
			else
			if (acao == 'a')				
				result = usuarios.Altera(codigo, edtDescricao.Text, idt_adm, idt_ativo, ref msg);
			else
				result = usuarios.AlteraSenha(codigo, senha, ref msg);				
			if (!result)
			{
				if (acao == 'i')
					MessageBox.Show(codigo+"\n"+msg, "Erro na inclusão do usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
				else
					MessageBox.Show(codigo+"\n"+msg, "Erro na alteração do usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);				
			}
			this.Cursor = Cursors.WaitCursor;
			usuarios.Carrega(dgvCadastro, "");
			this.Cursor = Cursors.Default;
			int selecionado = Procura(codigo, true);
			if (selecionado >= 0)
			{
				dgvCadastro.Rows[selecionado].Cells[0].Selected = true;
				AtualizaDados(selecionado);
				AtualizaDadosLocal(selecionado);
			}
			DesabilitaEdicao();
			DesabilitaEdicaoLocal();
		}
		
		void BtnExcluiClick(object sender, EventArgs e)
		{
			string msg="";
			bool result;
			if (acao == 'c') return;
			if (edtCodigo.Text.Trim().CompareTo("admin") == 0)
			{
				MessageBox.Show("admin", "Esse usuário não pode ser excluido", 
				                MessageBoxButtons.OK, 
				                MessageBoxIcon.Warning);
				return;
			}
			result = usuarios.Exclui(edtCodigo.Text, ref msg);
			if (!result)
			{
				MessageBox.Show(edtCodigo.Text, "Erro na exclusão do usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			this.Cursor = Cursors.WaitCursor;
			usuarios.Carrega(dgvCadastro, "");
			this.Cursor = Cursors.Default;
			if (dgvCadastro.Rows.Count == 0)
			{
				InicializaCampos();
			}
		}
		
		void BtnIncluiClick(object sender, EventArgs e)
		{
			HabilitaEdicaoLocal();
			InicializaCampos();
		}
		
		void BtnAlteraClick(object sender, EventArgs e)
		{
			if (acao == 'c') return;
			HabilitaEdicaoLocal();
		}
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			DesabilitaEdicaoLocal();
		}
		
		void DgvCadastroRowEnter(object sender, DataGridViewCellEventArgs e)
		{
			AtualizaDadosLocal(e.RowIndex);
		}
		
		void BtnAlteraSenhaClick(object sender, EventArgs e)
		{
			btnInclui.Enabled = false;
			btnExclui.Enabled = false;
			btnAltera.Enabled = false;
			btnAlteraSenha.Enabled = false;
			btnFecha.Enabled = false;
			dgvCadastro.Enabled = false;
			edtSenha.Enabled = true;
			edtConfirma.Enabled = true;
			btnConfirma.Enabled = true;
			btnCancela.Enabled = true;
			acao = 's';
			edtSenha.Focus();
		}
	}
}
