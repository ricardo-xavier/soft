/*
 * Projeto  : SoftPlace
 * Sistema  : Cadastros Basicos
 * Programa : fCadOrigens - Cadastro de Origens - Ação Comercial
 * Autor    : Ricardo Costa Xavier
 * Data     : 07/12/14
 */
using System;
using System.Windows.Forms;
using templates;
using classes;

namespace basico
{
	public partial class frmCadOrigens : tCadastroSimples
	{
		private cOrigens origens;
		public bool result;
		private bool ativas;
		
		void AlteraComponentes()
		{
			edtCodigo.CharacterCasing = CharacterCasing.Upper;
			dgvCadastro.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCadastroRowEnter);
		}

		void InicializaCampos()
		{
			edtCodigo.Text = "";
			edtDescricao.Text = "";
			ckbAtiva.Checked = true;
		}
		
		void DgvCadastroRowEnter(object sender, DataGridViewCellEventArgs e)
		{
			AtualizaDadosLocal(e.RowIndex);
		}
		
		public void SetaEdicaoLocal(bool enabled)
		{
			ckbAtiva.Enabled = enabled;
		}

		public void AtualizaDadosLocal(int i)
		{
			ckbAtiva.Checked = dgvCadastro.Rows[i].Cells[2].Value.ToString().Trim().Equals("S");
		}

		public frmCadOrigens(bool duplo)
		{
			InitializeComponent();
			AlteraComponentes();
			result = false;
			ativas = duplo;
			if (duplo) {
				// ação
				dgvCadastro.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCadastroCellDoubleClick);
			}
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
				result = origens.Inclui(codigo, edtDescricao.Text, ckbAtiva.Checked, ref msg);
			else
				result = origens.Altera(codigo, edtDescricao.Text, ckbAtiva.Checked, ref msg);
			if (!result)
			{
				if (acao == 'i')
					MessageBox.Show(codigo+"\n"+msg, "Erro na inclusão da origem", MessageBoxButtons.OK, MessageBoxIcon.Error);
				else
					MessageBox.Show(codigo+"\n"+msg, "Erro na alteração da origem", MessageBoxButtons.OK, MessageBoxIcon.Error);				
			}
			this.Cursor = Cursors.WaitCursor;
			origens.Carrega(dgvCadastro, ativas);
			this.Cursor = Cursors.Default;
			int selecionado = Procura(codigo, true);
			if (selecionado >= 0)
			{
				dgvCadastro.Rows[selecionado].Cells[0].Selected = true;
				AtualizaDados(selecionado);
			}
			DesabilitaEdicao();
			SetaEdicaoLocal(false);
		}
		
		void BtnExcluiClick(object sender, EventArgs e)
		{
			string msg="";
			bool result;
			if (acao == 'c') return;
			result = origens.Exclui(edtCodigo.Text, ref msg);
			if (!result)
			{
				MessageBox.Show(edtCodigo.Text + "\r\n" + Globais.ErroExclusao("Origem encontrada", msg), "Erro na exclusão da origem", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			this.Cursor = Cursors.WaitCursor;
			origens.Carrega(dgvCadastro, ativas);
			this.Cursor = Cursors.Default;
			if (dgvCadastro.Rows.Count == 0)
			{
				InicializaCampos();
			}			
		}
		
		void FrmCadOrigensLoad(object sender, EventArgs e)
		{
			origens = new cOrigens();
			this.Cursor = Cursors.WaitCursor;
			origens.Carrega(dgvCadastro, ativas);			
			this.Cursor = Cursors.Default;
			SetaEdicaoLocal(false);
		}
		
		void BtnIncluiClick(object sender, EventArgs e)
		{
			SetaEdicaoLocal(true);	
		}
		
		void BtnAlteraClick(object sender, EventArgs e)
		{
			SetaEdicaoLocal(true);	
		}
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			SetaEdicaoLocal(false);
		}		
		
		void dgvCadastroCellDoubleClick(object sender, DataGridViewCellEventArgs e)		
		{
			result = true;
			Close();
		}				
	}
}
