/*
 * Projeto  : SoftPlace
 * Sistema  : Basico
 * Programa : fCondicoesMontagem - Condições de Montagem
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
	public partial class fCondicoesMontagem : tCadastroSimples
	{
		private cCondicoesMontagem condicoes;
		
		void AlteraComponentes()
		{
			edtCodigo.CharacterCasing = CharacterCasing.Upper;
		}
		
		
		void InicializaCampos()
		{
			edtCodigo.Text = "";
			edtDescricao.Text = "";
		}
		
		public fCondicoesMontagem()
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
				result = condicoes.Inclui(codigo, edtDescricao.Text, ref msg);
			else
				result = condicoes.Altera(codigo, edtDescricao.Text, ref msg);
			if (!result)
			{
				if (acao == 'i')
					MessageBox.Show(codigo+"\n"+msg, "Erro na inclusão da condição de montagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
				else
					MessageBox.Show(codigo+"\n"+msg, "Erro na alteração da condição de montagem", MessageBoxButtons.OK, MessageBoxIcon.Error);				
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

		void fCondicoesMontagemLoad(object sender, EventArgs e)
		{
			condicoes = new cCondicoesMontagem();
			this.Cursor = Cursors.WaitCursor;
			condicoes.Carrega(dgvCadastro);		
			this.Cursor = Cursors.Default;			
		}
		
		void BtnExcluiClick(object sender, EventArgs e)
		{
			string msg="";
			bool result;
			if (acao == 'c') return;
			string codigo = edtCodigo.Text.Trim();
			result = condicoes.Exclui(codigo, ref msg);
			if (!result)
			{
				MessageBox.Show(codigo + "\r\n" + Globais.ErroExclusao("Condição encontrada", msg), "Erro na exclusão da condição", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
	}
}
