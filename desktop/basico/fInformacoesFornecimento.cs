/*
 * Projeto  : SoftPlace
 * Sistema  : Basico
 * Programa : fInformacoesFornecimento - Informações de Fornecimento
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
	public partial class fInformacoesFornecimento : tCadastroSimples
	{
		private cInformacoesFornecimento informacoes;
		
		void AlteraComponentes()
		{
			edtCodigo.CharacterCasing = CharacterCasing.Upper;
		}
		
		
		void InicializaCampos()
		{
			edtCodigo.Text = "";
			edtDescricao.Text = "";
		}
		
		public fInformacoesFornecimento()
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
				result = informacoes.Inclui(codigo, edtDescricao.Text, ref msg);
			else
				result = informacoes.Altera(codigo, edtDescricao.Text, ref msg);
			if (!result)
			{
				if (acao == 'i')
					MessageBox.Show(codigo+"\n"+msg, "Erro na inclusão da informação de fornecimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
				else
					MessageBox.Show(codigo+"\n"+msg, "Erro na alteração da informação de fornecimento", MessageBoxButtons.OK, MessageBoxIcon.Error);				
			}
			this.Cursor = Cursors.WaitCursor;
			informacoes.Carrega(dgvCadastro);
			this.Cursor = Cursors.Default;
			int selecionado = Procura(codigo, true);
			if (selecionado >= 0)
			{
				dgvCadastro.Rows[selecionado].Cells[0].Selected = true;
				AtualizaDados(selecionado);
			}
			DesabilitaEdicao();
		}

		void fInformacoesFornecimentoLoad(object sender, EventArgs e)
		{
			informacoes = new cInformacoesFornecimento();
			this.Cursor = Cursors.WaitCursor;
			informacoes.Carrega(dgvCadastro);		
			this.Cursor = Cursors.Default;			
		}
		
		void BtnExcluiClick(object sender, EventArgs e)
		{
			string msg="";
			bool result;
			if (acao == 'c') return;
			string codigo = edtCodigo.Text.Trim();
			result = informacoes.Exclui(codigo, ref msg);
			if (!result)
			{
				MessageBox.Show(codigo + "\r\n" + Globais.ErroExclusao("Informação encontrada", msg), "Erro na exclusão da informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			this.Cursor = Cursors.WaitCursor;
			informacoes.Carrega(dgvCadastro);
			this.Cursor = Cursors.Default;
			if (dgvCadastro.Rows.Count == 0)
			{
				InicializaCampos();
			}			
		}
	}
}
