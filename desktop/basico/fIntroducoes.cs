/*
 * Projeto  : SoftPlace
 * Sistema  : Basico
 * Programa : fIntroducoes - Introduções das Propostas
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
	public partial class fIntroducoes : tCadastroSimples
	{
		private cIntroducoes introducoes;
		
		void AlteraComponentes()
		{
			edtCodigo.CharacterCasing = CharacterCasing.Upper;
		}
		
		
		void InicializaCampos()
		{
			edtCodigo.Text = "";
			edtDescricao.Text = "";
		}
		
		public fIntroducoes()
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
				result = introducoes.Inclui(codigo, edtDescricao.Text, ref msg);
			else
				result = introducoes.Altera(codigo, edtDescricao.Text, ref msg);
			if (!result)
			{
				if (acao == 'i')
					MessageBox.Show(codigo+"\n"+msg, "Erro na inclusão da introdução", MessageBoxButtons.OK, MessageBoxIcon.Error);
				else
					MessageBox.Show(codigo+"\n"+msg, "Erro na alteração da introdução", MessageBoxButtons.OK, MessageBoxIcon.Error);				
			}
			this.Cursor = Cursors.WaitCursor;
			introducoes.Carrega(dgvCadastro);
			this.Cursor = Cursors.Default;
			int selecionado = Procura(codigo, true);
			if (selecionado >= 0)
			{
				dgvCadastro.Rows[selecionado].Cells[0].Selected = true;
				AtualizaDados(selecionado);
			}
			DesabilitaEdicao();
		}

		void fIntroducoesLoad(object sender, EventArgs e)
		{
			introducoes = new cIntroducoes();
			this.Cursor = Cursors.WaitCursor;
			introducoes.Carrega(dgvCadastro);		
			this.Cursor = Cursors.Default;			
		}
		
		void BtnExcluiClick(object sender, EventArgs e)
		{
			string msg="";
			bool result;
			if (acao == 'c') return;
			string codigo = edtCodigo.Text.Trim();
			result = introducoes.Exclui(codigo, ref msg);
			if (!result)
			{
				MessageBox.Show(codigo + "\r\n" + Globais.ErroExclusao("Introdução encontrada", msg), "Erro na exclusão da introdução", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			this.Cursor = Cursors.WaitCursor;
			introducoes.Carrega(dgvCadastro);
			this.Cursor = Cursors.Default;
			if (dgvCadastro.Rows.Count == 0)
			{
				InicializaCampos();
			}						
		}
	}
}
