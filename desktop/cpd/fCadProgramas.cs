/*
 * Projeto  : SoftPlace
 * Sistema  : CPD
 * Programa : fCadProgramas - Cadastro de Programas
 * Autor    : Ricardo Costa Xavier
 * Data     : 22/03/2008
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using templates;
using classes;

namespace cpd
{
	public partial class frmCadProgramas : tCadastroSimples
	{
		public int sistema;
		public string des_sistema;
		private cProgramas programas;
		
		void AlteraComponentes()
		{
			dgvCadastro.Top += 25;
			btnUp.Top += 25;
			btnDown.Top += 25;
			edtCodigo.MaxLength = 20;
		}
		
		void InicializaCampos()
		{
			edtCodigo.Text = "";
			edtDescricao.Text = "";
		}
		
		public frmCadProgramas()
		{
			InitializeComponent();
			AlteraComponentes();
		}
		
		void FrmCadProgramasLoad(object sender, EventArgs e)
		{
			programas = new cProgramas();
			this.Cursor = Cursors.WaitCursor;
			programas.Carrega(dgvCadastro, sistema);
			this.Cursor = Cursors.Default;
			DesabilitaEdicao();					
			lblSistema.Text = "Sistema: " + sistema + " - " + des_sistema;				
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
				result = programas.Inclui(sistema, codigo, edtDescricao.Text, ref msg);
			else
				result = programas.Altera(sistema, codigo, edtDescricao.Text, ref msg);
			if (!result)
			{
				if (acao == 'i')
					MessageBox.Show(codigo+"\n"+msg, "Erro na inclusão do programa", MessageBoxButtons.OK, MessageBoxIcon.Error);
				else
					MessageBox.Show(codigo+"\n"+msg, "Erro na alteração do programa", MessageBoxButtons.OK, MessageBoxIcon.Error);				
			}
			this.Cursor = Cursors.WaitCursor;
			programas.Carrega(dgvCadastro, sistema);
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
			result = programas.Exclui(sistema, edtCodigo.Text, ref msg);
			if (!result)
			{
				MessageBox.Show(edtCodigo.Text, "Erro na exclusão do programa", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			this.Cursor = Cursors.WaitCursor;
			programas.Carrega(dgvCadastro, sistema);
			this.Cursor = Cursors.Default;
			if (dgvCadastro.Rows.Count == 0)
			{
				InicializaCampos();
			}
		}
	}
}
