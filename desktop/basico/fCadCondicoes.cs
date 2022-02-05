/*
 * Projeto  : SoftPlace
 * Sistema  : Pedidos
 * Programa : fCadCondicoes - Cadastro de Condições de Pagamento
 * Autor    : Ricardo Costa Xavier
 * Data     : 14/02/09
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using templates;
using classes;

namespace basico
{
	public partial class frmCadCondicoes : tCadastroSimples
	{
		private cCondicoesPagto condicoes;
		
		void AlteraComponentes()
		{
			edtCodigo.CharacterCasing = CharacterCasing.Upper;
			dgvCadastro.Width += 50;
			dgvCadastro.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCadastroRowEnter);
		}

		void InicializaCampos()
		{
			edtCodigo.Text = "";
			edtDescricao.Text = "";
			ckbAtiva.Checked = true;
		}
				
		public frmCadCondicoes()
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
				result = condicoes.Inclui(codigo, edtDescricao.Text, ckbAtiva.Checked, ref msg);
			else
				result = condicoes.Altera(codigo, edtDescricao.Text, ckbAtiva.Checked, ref msg);
			if (!result)
			{
				if (acao == 'i')
					MessageBox.Show(codigo+"\n"+msg, "Erro na inclusão da condição", MessageBoxButtons.OK, MessageBoxIcon.Error);
				else
					MessageBox.Show(codigo+"\n"+msg, "Erro na alteração da condição", MessageBoxButtons.OK, MessageBoxIcon.Error);				
			}
			this.Cursor = Cursors.WaitCursor;
			condicoes.Carrega(dgvCadastro);
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
			result = condicoes.Exclui(edtCodigo.Text, ref msg);
			if (!result)
			{
				MessageBox.Show(edtCodigo.Text + "\r\n" + Globais.ErroExclusao("Condição encontrada", msg), "Erro na exclusão da condição", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			this.Cursor = Cursors.WaitCursor;
			condicoes.Carrega(dgvCadastro);
			this.Cursor = Cursors.Default;
			if (dgvCadastro.Rows.Count == 0)
			{
				InicializaCampos();
			}			
		}
		
		void FCondicoesLoad(object sender, EventArgs e)
		{
			condicoes = new cCondicoesPagto();
			this.Cursor = Cursors.WaitCursor;
			condicoes.Carrega(dgvCadastro);		
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
