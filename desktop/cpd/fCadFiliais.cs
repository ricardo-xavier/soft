/*
 * Projeto  : SoftPlace
 * Sistema  : CPD
 * Programa : fCadFiliais - Cadastro de Filiais
 * Autor    : Ricardo Costa Xavier
 * Data     : 01/04/08
 */
using System;
using System.Windows.Forms;
using templates;
using classes;

namespace cpd
{
	public partial class frmCadFiliais : tCadastroSimples
	{
		private cFiliais filiais;
		
		void AlteraComponentes()
		{
			edtCodigo.MaxLength = 3;
			edtCodigo.CharacterCasing = CharacterCasing.Upper;
			dgvCadastro.Width = 580;
			dgvCadastro.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCadastroRowEnter);
		}
		
		void InicializaCampos()
		{
			edtCodigo.Text = "";
			edtDescricao.Text = "";
			edtCNPJ.Text = CNPJ.PoeEdicao("");
			edtInsEst.Text = "";
			edtInsMun.Text = "";
			edtLogradouro.Text = "";
			edtNumero.Text = "";
			edtComplemento.Text = "";
			edtBairro.Text = "";
			edtCidade.Text = "";
			cbxEstados.SelectedIndex = (cbxEstados.Items.Count > 0) ? 0 : -1;
			edtCEP.Text = CEP.PoeEdicao("");
			edtFone1.Text = FONE.PoeEdicao("");
			edtFone2.Text = FONE.PoeEdicao("");
			edtFAX.Text = FONE.PoeEdicao("");			
			edtEmail.Text = "";
			edtServidor.Text = "";
		}		
		
		public void SetaEdicaoLocal(bool enabled)
		{
			edtCNPJ.Enabled = enabled;
			edtInsEst.Enabled = enabled;
			edtInsMun.Enabled = enabled;
			edtLogradouro.Enabled = enabled;
			edtNumero.Enabled = enabled;
			edtComplemento.Enabled = enabled;
			edtBairro.Enabled = enabled;
			edtCidade.Enabled = enabled;
			cbxEstados.Enabled = enabled;
			edtCEP.Enabled = enabled;
			edtFone1.Enabled = enabled;
			edtFone2.Enabled = enabled;
			edtFAX.Enabled = enabled;			
			edtEmail.Enabled = enabled;
			edtServidor.Enabled = enabled;
		}
		
		public void AtualizaDadosLocal(int i)
		{
			edtCNPJ.Text = CNPJ.PoeEdicao(dgvCadastro.Rows[i].Cells[2].Value.ToString().Trim());
			edtInsEst.Text = dgvCadastro.Rows[i].Cells[3].Value.ToString().Trim();
			edtInsMun.Text = dgvCadastro.Rows[i].Cells[4].Value.ToString().Trim();
			edtLogradouro.Text = dgvCadastro.Rows[i].Cells[5].Value.ToString().Trim();
			edtNumero.Text = dgvCadastro.Rows[i].Cells[6].Value.ToString().Trim();
			edtComplemento.Text = dgvCadastro.Rows[i].Cells[7].Value.ToString().Trim();
			edtBairro.Text = dgvCadastro.Rows[i].Cells[8].Value.ToString().Trim();
			edtCidade.Text = dgvCadastro.Rows[i].Cells[9].Value.ToString().Trim();
			cbxEstados.Text = dgvCadastro.Rows[i].Cells[10].Value.ToString().Trim();
			edtCEP.Text = CEP.PoeEdicao(dgvCadastro.Rows[i].Cells[11].Value.ToString().Trim());
			edtFone1.Text = FONE.PoeEdicao(dgvCadastro.Rows[i].Cells[12].Value.ToString().Trim());
			edtFone2.Text = FONE.PoeEdicao(dgvCadastro.Rows[i].Cells[13].Value.ToString().Trim());
			edtFAX.Text = FONE.PoeEdicao(dgvCadastro.Rows[i].Cells[14].Value.ToString().Trim());			
			edtEmail.Text = dgvCadastro.Rows[i].Cells[15].Value.ToString().Trim();		
			edtServidor.Text = dgvCadastro.Rows[i].Cells[16].Value.ToString().Trim();	
		}

		public frmCadFiliais()
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
				result = filiais.Inclui(codigo, edtDescricao.Text, 
				                        CNPJ.TiraEdicao(edtCNPJ.Text),
										edtInsEst.Text,
										edtInsMun.Text,
										edtLogradouro.Text,
										edtNumero.Text,
										edtComplemento.Text,
										edtBairro.Text,
										edtCidade.Text,
										cbxEstados.Text,
										CEP.TiraEdicao(edtCEP.Text),
										FONE.TiraEdicao(edtFone1.Text),
										FONE.TiraEdicao(edtFone2.Text),
										FONE.TiraEdicao(edtFAX.Text),										
										edtEmail.Text,
										edtServidor.Text,
				                        ref msg);
			else
				result = filiais.Altera(codigo, edtDescricao.Text,
				                        CNPJ.TiraEdicao(edtCNPJ.Text),
										edtInsEst.Text,
										edtInsMun.Text,
										edtLogradouro.Text,
										edtNumero.Text,										
										edtComplemento.Text,
										edtBairro.Text,
										edtCidade.Text,
										cbxEstados.Text,
										CEP.TiraEdicao(edtCEP.Text),
										FONE.TiraEdicao(edtFone1.Text),
										FONE.TiraEdicao(edtFone2.Text),
										FONE.TiraEdicao(edtFAX.Text),																				
										edtEmail.Text,
										edtServidor.Text,
				                        ref msg);
			if (!result)
			{
				if (acao == 'i')
					MessageBox.Show(codigo+"\n"+msg, "Erro na inclusão da filial", MessageBoxButtons.OK, MessageBoxIcon.Error);
				else
					MessageBox.Show(codigo+"\n"+msg, "Erro na alteração da filial", MessageBoxButtons.OK, MessageBoxIcon.Error);				
			}
			this.Cursor = Cursors.WaitCursor;
			filiais.Carrega(dgvCadastro);
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
			result = filiais.Exclui(edtCodigo.Text, ref msg);
			if (!result)
			{
				MessageBox.Show(edtCodigo.Text, "Erro na exclusão da filial", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			this.Cursor = Cursors.WaitCursor;
			filiais.Carrega(dgvCadastro);
			this.Cursor = Cursors.Default;
			if (dgvCadastro.Rows.Count == 0)
			{
				InicializaCampos();
			}
		}
		
		void FrmCadFiliaisLoad(object sender, EventArgs e)
		{
			filiais = new cFiliais();
			this.Cursor = Cursors.WaitCursor;
			filiais.Carrega(dgvCadastro);
			this.Cursor = Cursors.Default;
			cEstados estados = new cEstados();
			this.Cursor = Cursors.WaitCursor;
			estados.Carrega(cbxEstados);
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
		
		void EdtCNPJEnter(object sender, EventArgs e)
		{
			edtCNPJ.Text = CNPJ.TiraEdicao(edtCNPJ.Text);
		}
		
		void EdtCNPJLeave(object sender, EventArgs e)
		{
			edtCNPJ.Text = CNPJ.PoeEdicao(edtCNPJ.Text);
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
		
		void EdtFAXEnter(object sender, EventArgs e)
		{
			edtFAX.Text = FONE.TiraEdicao(edtFAX.Text);
		}
		
		void EdtFAXLeave(object sender, EventArgs e)
		{
			edtFAX.Text = FONE.PoeEdicao(edtFAX.Text);
		}
				
		void EdtCEPEnter(object sender, EventArgs e)
		{
			edtCEP.Text = CEP.TiraEdicao(edtCEP.Text);
		}
		
		void EdtCEPLeave(object sender, EventArgs e)
		{
			edtCEP.Text = CEP.PoeEdicao(edtCEP.Text);
		}
	}
}
