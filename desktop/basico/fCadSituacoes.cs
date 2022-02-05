/*
 * Projeto  : SoftPlace
 * Sistema  : Pedidos
 * Programa : fCadSituacoes - Situacoes do Orcamento
 * Autor    : Ricardo Costa Xavier
 * Data     : 11/04/09
 */
using System;
using System.Windows.Forms;
using templates;
using classes;

namespace basico
{
	public partial class frmCadSituacoes : tCadastroSimples
	{
		private cSituacoes situacoes;
		
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
			chkDefault.Checked = false;
			chkAviso.Checked = false;
			chkConcretizado.Checked = false;
			ckbAtiva.Checked = true;
		}
		
		void DgvCadastroRowEnter(object sender, DataGridViewCellEventArgs e)
		{
			AtualizaDadosLocal(e.RowIndex);
		}
		
		public void SetaEdicaoLocal(bool enabled)
		{
			chkDefault.Enabled = enabled;
			chkAviso.Enabled = enabled;
			chkConcretizado.Enabled = enabled;
			ckbAtiva.Enabled = enabled;
		}		
		
		public void AtualizaDadosLocal(int i)
		{
			chkDefault.Checked = (dgvCadastro.Rows[i].Cells[2].Value.ToString().CompareTo("S") == 0);
			chkAviso.Checked = (dgvCadastro.Rows[i].Cells[3].Value.ToString().CompareTo("S") == 0);
			chkConcretizado.Checked = (dgvCadastro.Rows[i].Cells[4].Value.ToString().CompareTo("S") == 0);
			ckbAtiva.Checked = dgvCadastro.Rows[i].Cells[5].Value.ToString().Trim().Equals("S");
		}
		
		public frmCadSituacoes()
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
				result = situacoes.Inclui(codigo, edtDescricao.Text, chkDefault.Checked?"S":"N", chkAviso.Checked?"S":"N", chkConcretizado.Checked?"S":"N", ckbAtiva.Checked, ref msg);
			else
				result = situacoes.Altera(codigo, edtDescricao.Text, chkDefault.Checked?"S":"N", chkAviso.Checked?"S":"N", chkConcretizado.Checked?"S":"N", ckbAtiva.Checked, ref msg);
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
			situacoes = new cSituacoes();
			this.Cursor = Cursors.WaitCursor;
			situacoes.Carrega(dgvCadastro);		
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
	}
}
