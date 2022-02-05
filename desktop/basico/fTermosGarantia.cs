/*
 * Projeto  : SoftPlace
 * Sistema  : Basico
 * Programa : fTermosGarantia - Termos de Garantia
 * Autor    : Ricardo Costa Xavier
 * Data     : 02/03/11
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using templates;
using classes;

namespace basico
{
	public partial class fTermosGarantia : tCadastroSimples
	{
		private cTermosGarantia termos;
		
		void AlteraComponentes()
		{
			edtCodigo.CharacterCasing = CharacterCasing.Upper;
		}
		
		
		void InicializaCampos()
		{
			edtCodigo.Text = "";
			edtDescricao.Text = "";
		}
		
		public fTermosGarantia()
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
				result = termos.Inclui(codigo, edtDescricao.Text, ref msg);
			else
				result = termos.Altera(codigo, edtDescricao.Text, ref msg);
			if (!result)
			{
				if (acao == 'i')
					MessageBox.Show(codigo+"\n"+msg, "Erro na inclusão do termo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				else
					MessageBox.Show(codigo+"\n"+msg, "Erro na alteração do termo", MessageBoxButtons.OK, MessageBoxIcon.Error);				
			}
			this.Cursor = Cursors.WaitCursor;
			termos.Carrega(dgvCadastro);
			this.Cursor = Cursors.Default;
			int selecionado = Procura(codigo, true);
			if (selecionado >= 0)
			{
				dgvCadastro.Rows[selecionado].Cells[0].Selected = true;
				AtualizaDados(selecionado);
			}
			DesabilitaEdicao();
		}

		void FTermosGarantiaLoad(object sender, EventArgs e)
		{
			termos = new cTermosGarantia();
			this.Cursor = Cursors.WaitCursor;
			termos.Carrega(dgvCadastro);		
			this.Cursor = Cursors.Default;			
		}
		
		void BtnExcluiClick(object sender, EventArgs e)
		{
			string msg="";
			bool result;
			if (acao == 'c') return;
			string codigo = edtCodigo.Text.Trim();
			result = termos.Exclui(codigo, ref msg);
			if (!result)
			{
				MessageBox.Show(codigo + "\r\n" + Globais.ErroExclusao("Termo encontrado", msg), "Erro na exclusão do termo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			this.Cursor = Cursors.WaitCursor;
			termos.Carrega(dgvCadastro);
			this.Cursor = Cursors.Default;
			if (dgvCadastro.Rows.Count == 0)
			{
				InicializaCampos();
			}			
		}
	}
}
