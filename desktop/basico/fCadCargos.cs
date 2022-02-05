/*
 * Projeto  : SoftPlace
 * Sistema  : Cadastros Basicos
 * Programa : fCadCargos - Cadastro de Cargos
 * Autor    : Ricardo Costa Xavier
 * Data     : 07/04/08
 */
using System;
using System.Windows.Forms;
using templates;
using classes;

namespace basico
{
	public partial class frmCadCargos : tCadastroSimples
	{
		private cCargos cargos;
		
		void AlteraComponentes()
		{
			edtCodigo.CharacterCasing = CharacterCasing.Upper;
			dgvCadastro.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCadastroRowEnter);
		}

		void InicializaCampos()
		{
			edtCodigo.Text = "";
			edtDescricao.Text = "";
			ckbAtivo.Checked = true;
		}
				
		public frmCadCargos()
		{
			InitializeComponent();
			AlteraComponentes();
		}
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			DesabilitaEdicaoLocal();
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
				result = cargos.Inclui(codigo, edtDescricao.Text, ckbAtivo.Checked, ref msg);
			else
				result = cargos.Altera(codigo, edtDescricao.Text, ckbAtivo.Checked, ref msg);
			if (!result)
			{
				if (acao == 'i')
					MessageBox.Show(codigo+"\n"+msg, "Erro na inclusão do cargo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				else
					MessageBox.Show(codigo+"\n"+msg, "Erro na alteração do cargo", MessageBoxButtons.OK, MessageBoxIcon.Error);				
			}
			this.Cursor = Cursors.WaitCursor;
			cargos.Carrega(dgvCadastro);
			this.Cursor = Cursors.Default;
			int selecionado = Procura(codigo, true);
			if (selecionado >= 0)
			{
				dgvCadastro.Rows[selecionado].Cells[0].Selected = true;
				AtualizaDados(selecionado);
			}
			DesabilitaEdicao();
		}
		
		void BtnExcluiClick(object sender, EventArgs e)
		{
			string msg="";
			bool result;
			if (acao == 'c') return;
			result = cargos.Exclui(edtCodigo.Text, ref msg);
			if (!result)
			{
				MessageBox.Show(edtCodigo.Text + "\r\n" + Globais.ErroExclusao("Cargo encontrado", msg), "Erro na exclusão do cargo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			this.Cursor = Cursors.WaitCursor;
			cargos.Carrega(dgvCadastro);
			this.Cursor = Cursors.Default;
			if (dgvCadastro.Rows.Count == 0)
			{
				InicializaCampos();
			}			
		}
		
		void FrmCadCargosLoad(object sender, EventArgs e)
		{
			cargos = new cCargos();
			this.Cursor = Cursors.WaitCursor;
			cargos.Carrega(dgvCadastro);			
			this.Cursor = Cursors.Default;
			DesabilitaEdicaoLocal();
		}
		
		void BtnIncluiClick(object sender, EventArgs e)
		{
			HabilitaEdicaoLocal();
		}
		
		void BtnAlteraClick(object sender, EventArgs e)
		{
			HabilitaEdicaoLocal();
		}
	
		void DgvCadastroRowEnter(object sender, DataGridViewCellEventArgs e)
		{
			AtualizaDadosLocal(e.RowIndex);
		}	

		public void AtualizaDadosLocal(int i)
		{
			ckbAtivo.Checked = dgvCadastro.Rows[i].Cells[2].Value.ToString().Trim().Equals("S");
		}
		
		public void HabilitaEdicaoLocal() 
		{
			ckbAtivo.Enabled = true;
		}			
		
		public void DesabilitaEdicaoLocal() 
		{
			ckbAtivo.Enabled = false;
		}			
	
	}
}
