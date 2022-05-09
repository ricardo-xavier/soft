/*
 * Projeto  : SoftPlace
 * Sistema  : Cadastros Basicos
 * Programa : fCadNaturezas - Cadastro de Naturezas
 * Autor    : Ricardo Costa Xavier
 * Data     : 25/04/08
 */
using System;
using System.Windows.Forms;
using templates;
using classes;

namespace basico
{
	public partial class frmCadNaturezas : tCadastroSimples
	{
		private cNaturezas naturezas;
		
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
				
		public frmCadNaturezas()
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
				result = naturezas.Inclui(codigo, edtDescricao.Text, ckbAtiva.Checked, ref msg);
			else
				result = naturezas.Altera(codigo, edtDescricao.Text, ckbAtiva.Checked,  ref msg);
			if (!result)
			{
				if (acao == 'i')
					MessageBox.Show(codigo+"\n"+msg, "Erro na inclusão da natureza", MessageBoxButtons.OK, MessageBoxIcon.Error);
				else
					MessageBox.Show(codigo+"\n"+msg, "Erro na alteração da natureza", MessageBoxButtons.OK, MessageBoxIcon.Error);				
			}
			this.Cursor = Cursors.WaitCursor;
			naturezas.Carrega(dgvCadastro);
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
			result = naturezas.Exclui(edtCodigo.Text, ref msg);
			if (!result)
			{
				MessageBox.Show(edtCodigo.Text + "\r\n" + Globais.ErroExclusao("Natureza encontrada", msg), "Erro na exclusão da natureza", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			this.Cursor = Cursors.WaitCursor;
			naturezas.Carrega(dgvCadastro);
			this.Cursor = Cursors.Default;
			if (dgvCadastro.Rows.Count == 0)
			{
				InicializaCampos();
			}			
		}
		
		void FrmCadNaturezasLoad(object sender, EventArgs e)
		{
			naturezas = new cNaturezas();
			this.Cursor = Cursors.WaitCursor;
			naturezas.Carrega(dgvCadastro);				
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
			ckbAtiva.Checked = dgvCadastro.Rows[i].Cells[2].Value.ToString().Trim().Equals("S");
		}
		
		public void HabilitaEdicaoLocal() 
		{
			ckbAtiva.Enabled = true;
		}			
		
		public void DesabilitaEdicaoLocal() 
		{
			ckbAtiva.Enabled = false;
		}			
		
	}
}
