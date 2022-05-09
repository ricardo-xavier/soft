/*
 * Projeto  : SoftPlace
 * Sistema  : CPD
 * Programa : fCadFuncionarios - Cadastro de Funcionarios
 * Autor    : Ricardo Costa Xavier
 * Data     : 08/04/08
 */
using System;
using System.Windows.Forms;
using templates;
using classes;

namespace basico
{
	public partial class frmCadFuncionarios : tCadastroSimples
	{
		private cFuncionarios funcionarios;
		public bool result;		
		
		void AlteraComponentes()
		{
			edtCodigo.MaxLength = 20;
			dgvCadastro.Width = 580;
			dgvCadastro.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCadastroRowEnter);
		}
		
		void InicializaCampos()
		{
			edtCodigo.Text = "";
			edtDescricao.Text = "";
			edtLogradouro.Text = "";
			edtNumero.Text = "";
			edtComplemento.Text = "";
			edtBairro.Text = "";
			edtCidade.Text = "";
			cbxEstados.SelectedIndex = (cbxEstados.Items.Count > 0) ? 0 : -1;
			edtCEP.Text = CEP.PoeEdicao("");
			edtFone1.Text = FONE.PoeEdicao("");
			edtFone2.Text = FONE.PoeEdicao("");
			edtFone3.Text = CELULAR.PoeEdicao("");			
			cbxCargos.SelectedIndex = (cbxCargos.Items.Count > 0) ? 0 : -1;			
			edtEmail.Text = "";
			dtpNascimento.Value = DateTime.Now;			
			dtpNascimento.Checked = false;			
			edtIdentidade.Text = "";
			edtCPF.Text = CPF.PoeEdicao("");
			ckbAtivo.Checked = true;			
		}		
		
		public void SetaEdicaoLocal(bool enabled)
		{
			edtLogradouro.Enabled = enabled;
			edtNumero.Enabled = enabled;
			edtComplemento.Enabled = enabled;
			edtBairro.Enabled = enabled;
			edtCidade.Enabled = enabled;
			cbxEstados.Enabled = enabled;
			edtCEP.Enabled = enabled;
			edtFone1.Enabled = enabled;
			edtFone2.Enabled = enabled;
			edtFone3.Enabled = enabled;
			cbxCargos.Enabled = enabled;
			edtEmail.Enabled = enabled;
			ckbAtivo.Enabled = enabled;
			dtpNascimento.Enabled = enabled;
			edtIdentidade.Enabled = enabled;
			edtCPF.Enabled = enabled;
		}
		
		public void AtualizaDadosLocal(int i)
		{
			edtLogradouro.Text = dgvCadastro.Rows[i].Cells[2].Value.ToString().Trim();
			edtNumero.Text = dgvCadastro.Rows[i].Cells[3].Value.ToString().Trim();
			edtComplemento.Text = dgvCadastro.Rows[i].Cells[4].Value.ToString().Trim();
			edtBairro.Text = dgvCadastro.Rows[i].Cells[5].Value.ToString().Trim();
			edtCidade.Text = dgvCadastro.Rows[i].Cells[6].Value.ToString().Trim();
			cbxEstados.Text = dgvCadastro.Rows[i].Cells[7].Value.ToString().Trim();
			edtCEP.Text = CEP.PoeEdicao(dgvCadastro.Rows[i].Cells[8].Value.ToString().Trim());
			edtFone1.Text = FONE.PoeEdicao(dgvCadastro.Rows[i].Cells[9].Value.ToString().Trim());
			edtFone2.Text = FONE.PoeEdicao(dgvCadastro.Rows[i].Cells[10].Value.ToString().Trim());
			edtFone3.Text = CELULAR.PoeEdicao(dgvCadastro.Rows[i].Cells[11].Value.ToString().Trim());			
			cbxCargos.Text = dgvCadastro.Rows[i].Cells[12].Value.ToString().Trim();
			edtEmail.Text = dgvCadastro.Rows[i].Cells[13].Value.ToString().Trim();		
			ckbAtivo.Checked = (dgvCadastro.Rows[i].Cells[14].Value.ToString().CompareTo("S") == 0);			
			try {
				dtpNascimento.Value = DateTime.Parse(dgvCadastro.Rows[i].Cells[15].Value.ToString());			
				dtpNascimento.Checked = true;
			}
			catch {
				dtpNascimento.Value = DateTime.Now;
				dtpNascimento.Checked = false;
			}			
			edtIdentidade.Text = dgvCadastro.Rows[i].Cells[16].Value.ToString().Trim();
			edtCPF.Text = CPF.PoeEdicao(dgvCadastro.Rows[i].Cells[17].Value.ToString().Trim());			
		}		
		
		public frmCadFuncionarios(bool duplo)
		{
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
			string idt_ativo = (ckbAtivo.Checked ? "S" : "N");			
			if (acao == 'i')
				result = funcionarios.Inclui(codigo, edtDescricao.Text, 
										edtLogradouro.Text,
										edtNumero.Text,
										edtComplemento.Text,
										edtBairro.Text,
										edtCidade.Text,
										cbxEstados.Text,
										CEP.TiraEdicao(edtCEP.Text),
										FONE.TiraEdicao(edtFone1.Text),
										FONE.TiraEdicao(edtFone2.Text),
										CELULAR.TiraEdicao(edtFone3.Text),										
										cbxCargos.Text,
										edtEmail.Text,
										dtpNascimento.Checked,
										dtpNascimento.Value,																				
										edtIdentidade.Text,
										CPF.TiraEdicao(edtCPF.Text),
										idt_ativo,
				                        ref msg);
			else
				result = funcionarios.Altera(codigo, edtDescricao.Text,
										edtLogradouro.Text,
										edtNumero.Text,										
										edtComplemento.Text,
										edtBairro.Text,
										edtCidade.Text,
										cbxEstados.Text,
										CEP.TiraEdicao(edtCEP.Text),
										FONE.TiraEdicao(edtFone1.Text),
										FONE.TiraEdicao(edtFone2.Text),
										CELULAR.TiraEdicao(edtFone3.Text),										
										cbxCargos.Text,
										edtEmail.Text,
										dtpNascimento.Checked,
										dtpNascimento.Value,																				
										edtIdentidade.Text,
										CPF.TiraEdicao(edtCPF.Text),
										idt_ativo,
				                        ref msg);
			if (!result)
			{
				if (acao == 'i')
					MessageBox.Show(codigo+"\n"+msg, "Erro na inclusão do funcionário", MessageBoxButtons.OK, MessageBoxIcon.Error);
				else
					MessageBox.Show(codigo+"\n"+msg, "Erro na alteração do funcionário", MessageBoxButtons.OK, MessageBoxIcon.Error);				
			}
			this.Cursor = Cursors.WaitCursor;
			funcionarios.Carrega(dgvCadastro);
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
			result = funcionarios.Exclui(edtCodigo.Text, ref msg);
			if (!result)
			{
				MessageBox.Show(edtCodigo.Text + "\r\n" + Globais.ErroExclusao("Funcionário encontrado", msg), "Erro na exclusão do funcionário", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			this.Cursor = Cursors.WaitCursor;
			funcionarios.Carrega(dgvCadastro);
			this.Cursor = Cursors.Default;
			if (dgvCadastro.Rows.Count == 0)
			{
				InicializaCampos();
			}			
		}
		
		void FrmCadFuncionariosLoad(object sender, EventArgs e)
		{
			funcionarios = new cFuncionarios();
			this.Cursor = Cursors.WaitCursor;
			funcionarios.Carrega(dgvCadastro);
			this.Cursor = Cursors.Default;
			cEstados estados = new cEstados();
			this.Cursor = Cursors.WaitCursor;
			estados.Carrega(cbxEstados);
			this.Cursor = Cursors.Default;
			cCargos cargos = new cCargos();
			this.Cursor = Cursors.WaitCursor;
			cargos.Carrega(cbxCargos);
			this.Cursor = Cursors.Default;
			SetaEdicaoLocal(false);			
			result = false;
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
		
		void EdtFone3Enter(object sender, EventArgs e)
		{
			edtFone3.Text = CELULAR.TiraEdicao(edtFone3.Text);
		}
		
		void EdtFone3Leave(object sender, EventArgs e)
		{
			edtFone3.Text = CELULAR.PoeEdicao(edtFone3.Text);
		}
		
		void EdtCEPEnter(object sender, EventArgs e)
		{
			edtCEP.Text = CEP.TiraEdicao(edtCEP.Text);
		}
		
		void EdtCEPLeave(object sender, EventArgs e)
		{
			edtCEP.Text = CEP.PoeEdicao(edtCEP.Text);
		}
		
		void BtnFechaClick(object sender, EventArgs e)
		{
			result = false;
		}
		
		void dgvCadastroCellDoubleClick(object sender, DataGridViewCellEventArgs e)		
		{
			result = true;
			Close();
		}
		
		void EdtCPFEnter(object sender, EventArgs e)
		{
			edtCPF.Text = CPF.TiraEdicao(edtCPF.Text);
		}
		
		void EdtCPFLeave(object sender, EventArgs e)
		{
			edtCPF.Text = CPF.PoeEdicao(edtCPF.Text);
		}
	}
}
