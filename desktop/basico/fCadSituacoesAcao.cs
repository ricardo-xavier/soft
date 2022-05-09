/*
 * Projeto  : SoftPlace
 * Sistema  : Pedidos
 * Programa : fCadSituacoesAcao - Situacoes das Ações Comerciais
 * Autor    : Ricardo Costa Xavier
 * Data     : 25/01/2015
 */
using System;
using System.Windows.Forms;
using templates;
using classes;

namespace basico
{
	public partial class frmCadSituacoesAcao : tCadastroSimples
	{
		private cSituacoesAcao situacoes;
		
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
			chkApresentaAutom.Checked = true;
			chkConcretizada.Checked = false;
			ckbAtiva.Checked = true;
		}
		
		public void SetaEdicaoLocal(bool enabled)
		{
			chkApresentaAutom.Enabled = enabled;
			chkConcretizada.Enabled = enabled;
			ckbAtiva.Enabled = enabled;
		}		
		
		public void AtualizaDadosLocal(int i)
		{
			chkApresentaAutom.Checked = dgvCadastro.Rows[i].Cells[2].Value.ToString().Trim().Equals("S");
			chkConcretizada.Checked = dgvCadastro.Rows[i].Cells[3].Value.ToString().Trim().Equals("S");
			ckbAtiva.Checked = dgvCadastro.Rows[i].Cells[4].Value.ToString().Trim().Equals("S");
		}
		
		public frmCadSituacoesAcao()
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
				result = situacoes.Inclui(codigo, edtDescricao.Text, chkApresentaAutom.Checked, chkConcretizada.Checked, ckbAtiva.Checked, ref msg);
			else
				result = situacoes.Altera(codigo, edtDescricao.Text, chkApresentaAutom.Checked, chkConcretizada.Checked, ckbAtiva.Checked, ref msg);
			if (!result)
			{
				if (acao == 'i')
					MessageBox.Show(codigo+"\n"+msg, "Erro na inclusão da situação", MessageBoxButtons.OK, MessageBoxIcon.Error);
				else
					MessageBox.Show(codigo+"\n"+msg, "Erro na alteração da situação", MessageBoxButtons.OK, MessageBoxIcon.Error);				
			}
			this.Cursor = Cursors.WaitCursor;
			situacoes.Carrega(dgvCadastro);
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
		
		void BtnExcluiClick(object sender, EventArgs e)
		{
			string msg="";
			bool result;
			if (acao == 'c') return;
			result = situacoes.Exclui(edtCodigo.Text, ref msg);
			if (!result)
			{
				MessageBox.Show(edtCodigo.Text + "\r\n" + Globais.ErroExclusao("Situação encontrada", msg), "Erro na exclusão da situação", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			this.Cursor = Cursors.WaitCursor;
			situacoes.Carrega(dgvCadastro);
			this.Cursor = Cursors.Default;
			if (dgvCadastro.Rows.Count == 0)
			{
				InicializaCampos();
			}			
		}
		
		void FSituacoesLoad(object sender, EventArgs e)
		{
			situacoes = new cSituacoesAcao();
			this.Cursor = Cursors.WaitCursor;
			situacoes.Carrega(dgvCadastro);		
			this.Cursor = Cursors.Default;
			SetaEdicaoLocal(false);
		}

		void DgvCadastroRowEnter(object sender, DataGridViewCellEventArgs e)
		{
			AtualizaDadosLocal(e.RowIndex);
		}
		
		void BtnIncluiClick(object sender, EventArgs e)
		{
			SetaEdicaoLocal(true);
			InicializaCampos();
			edtDescricao.Focus();			
		}
		
		void BtnAlteraClick(object sender, EventArgs e)
		{
			if (acao == 'c') return;
			SetaEdicaoLocal(true);		
		}
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			SetaEdicaoLocal(false);
		}
	}
}
