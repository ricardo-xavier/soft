/*
 * Projeto  : SoftPlace
 * Sistema  : CPD
 * Programa : fCadSistemas - Cadastro de Sistemas
 * Autor    : Ricardo Costa Xavier
 * Data     : 22/03/2008
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using templates;
using classes;

namespace cpd
{
	public partial class frmCadSistemas : tCadastroSimples
	{
		private cSistemas sistemas;
		
		void AlteraComponentes()
		{
			btnFecha.Top += 30;
			btnFecha.TabIndex = 7;
			btnProgramas.Top -= 30;
			btnProgramas.TabIndex = 6;
			edtCodigo.MaxLength = 3;
		}
		
		void InicializaCampos()
		{
			edtCodigo.Text = "";
			edtDescricao.Text = "";
		}

		void DesabilitaEdicaoLocal()
		{
			btnProgramas.Enabled = true;			
		}
		
		void HabilitaEdicaoLocal()
		{
			btnProgramas.Enabled = false;
		}		
		
		public frmCadSistemas()
		{
			InitializeComponent();
			AlteraComponentes();
		}
		
		void FrmCadSistemasLoad(object sender, EventArgs e)
		{
			sistemas = new cSistemas();
			this.Cursor = Cursors.WaitCursor;
			sistemas.Carrega(dgvCadastro, "");
			this.Cursor = Cursors.Default;
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
				result = sistemas.Inclui(codigo, edtDescricao.Text, ref msg);
			else
				result = sistemas.Altera(codigo, edtDescricao.Text, ref msg);
			if (!result)
			{
				if (acao == 'i')
					MessageBox.Show(codigo+"\n"+msg, "Erro na inclusão do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
				else
					MessageBox.Show(codigo+"\n"+msg, "Erro na alteração do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);				
			}
			this.Cursor = Cursors.WaitCursor;
			sistemas.Carrega(dgvCadastro, "");
			this.Cursor = Cursors.Default;
			int selecionado = Procura(codigo, true);
			if (selecionado >= 0)
			{
				dgvCadastro.Rows[selecionado].Cells[0].Selected = true;
				AtualizaDados(selecionado);
			}
			DesabilitaEdicao();
			DesabilitaEdicaoLocal();					
		}
		
		void BtnExcluiClick(object sender, EventArgs e)
		{
			string msg="";
			bool result;
			if (acao == 'c') return;			
			result = sistemas.Exclui(edtCodigo.Text, ref msg);
			if (!result)
			{
				MessageBox.Show(edtCodigo.Text, "Erro na exclusão do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			this.Cursor = Cursors.WaitCursor;
			sistemas.Carrega(dgvCadastro, "");
			this.Cursor = Cursors.Default;
			if (dgvCadastro.Rows.Count == 0)
			{
				InicializaCampos();
			}			
		}
		
		void BtnProgramasClick(object sender, EventArgs e)
		{
			if (dgvCadastro.Rows.Count == 0) return;			
			frmCadProgramas frm = new frmCadProgramas();
			frm.sistema = Globais.StrToInt(edtCodigo.Text);
			frm.des_sistema = edtDescricao.Text;
			frm.ShowDialog();				
		}
	}
}
