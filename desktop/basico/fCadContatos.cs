/*
 * Projeto  : SoftPlace
 * Sistema  : CPD
 * Programa : fCadContatos - Cadastro de Contatos
 * Autor    : Ricardo Costa Xavier
 * Data     : 13/04/08
 */
using System;
using System.Windows.Forms;
using templates;
using classes;

namespace basico
{
	public partial class frmCadContatos : tCadastroSimples
	{
		private cContatos contatos;
		public string parceiro;
		public string cod_contato;
		public string des_parceiro;
		public bool juridica;
		public bool ReadOnly;

		void AlteraComponentes()
		{
			dgvCadastro.Top += 25;			
			btnUp.Top += 25;
			btnDown.Top += 25;
			edtCodigo.CharacterCasing = CharacterCasing.Upper;
			dgvCadastro.Width = 380;
			dgvCadastro.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCadastroRowEnter);
		}

		void InicializaCampos()
		{
			edtCodigo.Text = "";
			edtDescricao.Text = "";
			edtFone1.Text = FONE.PoeEdicao("");
			edtFone2.Text = FONE.PoeEdicao("");
			edtCelular.Text = CELULAR.PoeEdicao("");			
			edtEmail.Text = "";
			edtPapel.Text = "";						
			dtpNascimento.Value = DateTime.Now;
			dtpNascimento.Checked = false;			
			ckbAtivo.Checked = true;
		}		
		
		public void SetaEdicaoLocal(bool enabled)
		{
			edtCodigo.Enabled = enabled;
			edtDescricao.Enabled = enabled;
			edtFone1.Enabled = enabled;
			edtFone2.Enabled = enabled;
			edtCelular.Enabled = enabled;			
			edtEmail.Enabled = enabled;
			edtPapel.Enabled = enabled;			
			ckbAtivo.Enabled = enabled;
			dtpNascimento.Enabled = enabled;
		}
		
		public void AtualizaDadosLocal(int i)
		{
			edtFone1.Text = FONE.PoeEdicao(dgvCadastro.Rows[i].Cells[2].Value.ToString().Trim());
			edtFone2.Text = FONE.PoeEdicao(dgvCadastro.Rows[i].Cells[3].Value.ToString().Trim());
			edtCelular.Text = CELULAR.PoeEdicao(dgvCadastro.Rows[i].Cells[4].Value.ToString().Trim());			
			edtEmail.Text = dgvCadastro.Rows[i].Cells[5].Value.ToString().Trim();		
			edtPapel.Text = dgvCadastro.Rows[i].Cells[6].Value.ToString().Trim();					
			ckbAtivo.Checked = (dgvCadastro.Rows[i].Cells[7].Value.ToString().Trim().CompareTo("S") == 0);
			try {
				dtpNascimento.Value = DateTime.Parse(dgvCadastro.Rows[i].Cells[8].Value.ToString());
				dtpNascimento.Checked = true;
			}
			catch {
				dtpNascimento.Value = DateTime.Now;
				dtpNascimento.Checked = false;
			}			
		}

		public frmCadContatos(bool duplo)
		{
			ReadOnly = false;			
			InitializeComponent();
			AlteraComponentes();
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
			string ativo = ckbAtivo.Checked ? "S" : "N";
			if (acao == 'i')
				result = contatos.Inclui(parceiro, codigo,
				                        edtDescricao.Text,
										FONE.TiraEdicao(edtFone1.Text),
										FONE.TiraEdicao(edtFone2.Text),
										CELULAR.TiraEdicao(edtCelular.Text),										
										edtEmail.Text,
										edtPapel.Text,				
										dtpNascimento.Checked,
										dtpNascimento.Value,										
										ativo,
				                        ref msg);
			else
				result = contatos.Altera(parceiro, codigo, edtDescricao.Text,
										FONE.TiraEdicao(edtFone1.Text),
										FONE.TiraEdicao(edtFone2.Text),
										CELULAR.TiraEdicao(edtCelular.Text),												
										edtEmail.Text,
										edtPapel.Text,										
										dtpNascimento.Checked,
										dtpNascimento.Value,										
										ativo,
				                        ref msg);
			if (!result)
			{
				if (acao == 'i')
					MessageBox.Show(codigo+"\n"+msg, "Erro na inclusão do contato", MessageBoxButtons.OK, MessageBoxIcon.Error);
				else
					MessageBox.Show(codigo+"\n"+msg, "Erro na alteração do contato", MessageBoxButtons.OK, MessageBoxIcon.Error);				
			}
			string where = "where COD_PARCEIRO='" + parceiro + "'";
			this.Cursor = Cursors.WaitCursor;
			contatos.Carrega(dgvCadastro, where);
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
			result = contatos.Exclui(parceiro, edtCodigo.Text, ref msg);
			if (!result)
			{
				MessageBox.Show(edtCodigo.Text + "\r\n" + Globais.ErroExclusao("Contato encontrado", msg), "Erro na exclusão do contato", MessageBoxButtons.OK, MessageBoxIcon.Error);				
				return;
			}
			string where = "where COD_PARCEIRO='" + parceiro + "'";			
			this.Cursor = Cursors.WaitCursor;
			contatos.Carrega(dgvCadastro, where);
			this.Cursor = Cursors.Default;
			if (dgvCadastro.Rows.Count == 0)
			{
				InicializaCampos();
			}
		}
		
		void FrmCadContatosLoad(object sender, EventArgs e)
		{
			if (ReadOnly)
			{
				btnConfirma.Visible = false;
				btnCancela.Visible = false;
				btnInclui.Visible = false;
				btnExclui.Visible = false;
				btnAltera.Visible = false;
				//btnFecha.Text = "Seleciona";
				btnFecha.Top += 30;
			}
			contatos = new cContatos();
			string where = "where COD_PARCEIRO='" + parceiro + "'";
			if (cod_contato != null)
				where += " and COD_CONTATO = '" + cod_contato + "'";
			this.Cursor = Cursors.WaitCursor;
			contatos.Carrega(dgvCadastro, where);
			this.Cursor = Cursors.Default;
			SetaEdicaoLocal(false);			
			lblParceiro.Text = "Parceiro: " + parceiro + " - " + des_parceiro;
			if (juridica)
				lblPapel.Text = "Papel";
			else
				lblPapel.Text = "Grau Afinidade";			
			
		}
		
		void DgvCadastroRowEnter(object sender, DataGridViewCellEventArgs e)
		{
			AtualizaDadosLocal(e.RowIndex);
		}
				
		void BtnIncluiClick(object sender, EventArgs e)
		{
			SetaEdicaoLocal(true);
			InicializaCampos();
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
		
		void EdtNUMERICOKeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar > 31 && (e.KeyChar < '0' || e.KeyChar > '9'))
			{
				e.Handled = true;
			}
		}
		
		void EdtFone1Enter(object sender, EventArgs e)
		{
			edtFone1.Text = FONE.TiraEdicao(edtFone1.Text);
		}
		
		void EdtFone1Leave(object sender, EventArgs e)
		{
			edtFone1.Text = FONE.PoeEdicao(edtFone1.Text);
		}
		
		void EdtFone2Enter(object sender, EventArgs e)
		{
			edtFone2.Text = FONE.TiraEdicao(edtFone2.Text);
		}
		
		void EdtFone2Leave(object sender, EventArgs e)
		{
			edtFone2.Text = FONE.PoeEdicao(edtFone2.Text);
		}
		
		void EdtCelularEnter(object sender, EventArgs e)
		{
			edtCelular.Text = CELULAR.TiraEdicao(edtCelular.Text);
		}
		
		void EdtCelularLeave(object sender, EventArgs e)
		{
			edtCelular.Text = CELULAR.PoeEdicao(edtCelular.Text);
		}
		
		void dgvCadastroCellDoubleClick(object sender, DataGridViewCellEventArgs e)		
		{
			Close();
		}
		
	}
}
