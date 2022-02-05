/*
 * Projeto  : SoftPlace
 * Sistema  : Cadastros Basicos
 * Programa : fCadProdutosAcao - Cadastro de Produtos - Ação Comercial
 * Autor    : Ricardo Costa Xavier
 * Data     : 07/12/14
 */
using System;
using System.Windows.Forms;
using templates;
using classes;

namespace basico
{
	public partial class frmCadProdutosAcao : tCadastroSimples
	{
		private cProdutosAcao produtos;
		public bool result;
		
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
		
		void DgvCadastroRowEnter(object sender, DataGridViewCellEventArgs e)
		{
			AtualizaDadosLocal(e.RowIndex);
		}
		
		public void SetaEdicaoLocal(bool enabled)
		{
			ckbAtivo.Enabled = enabled;
		}		
		
		public void AtualizaDadosLocal(int i)
		{
			ckbAtivo.Checked = dgvCadastro.Rows[i].Cells[2].Value.ToString().Trim().Equals("S");
		}
				
		public frmCadProdutosAcao(bool duplo)
		{
			InitializeComponent();
			AlteraComponentes();
			result = false;
			if (duplo)
				dgvCadastro.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCadastroCellDoubleClick);
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
				result = produtos.Inclui(codigo, edtDescricao.Text, ckbAtivo.Checked, ref msg);
			else
				result = produtos.Altera(codigo, edtDescricao.Text, ckbAtivo.Checked, ref msg);
			if (!result)
			{
				if (acao == 'i')
					MessageBox.Show(codigo+"\n"+msg, "Erro na inclusão do produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
				else
					MessageBox.Show(codigo+"\n"+msg, "Erro na alteração do produto", MessageBoxButtons.OK, MessageBoxIcon.Error);				
			}
			this.Cursor = Cursors.WaitCursor;
			produtos.Carrega(dgvCadastro);
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
			result = produtos.Exclui(edtCodigo.Text, ref msg);
			if (!result)
			{
				MessageBox.Show(edtCodigo.Text + "\r\n" + Globais.ErroExclusao("Produto encontrado", msg), "Erro na exclusão do produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			this.Cursor = Cursors.WaitCursor;
			produtos.Carrega(dgvCadastro);
			this.Cursor = Cursors.Default;
			if (dgvCadastro.Rows.Count == 0)
			{
				InicializaCampos();
			}			
		}
		
		void FrmCadProdutosAcaoLoad(object sender, EventArgs e)
		{
			produtos = new cProdutosAcao();
			this.Cursor = Cursors.WaitCursor;
			produtos.Carrega(dgvCadastro);			
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
