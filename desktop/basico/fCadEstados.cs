/*
 * Projeto  : SoftPlace
 * Sistema  : Cadastros Basicos
 * Programa : fCadEstados - Cadastro de Estados
 * Autor    : Ricardo Costa Xavier
 * Data     : 05/04/08
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using templates;
using classes;

namespace basico
{
	public partial class frmCadEstados : tCadastroSimples
	{
		private cEstados estados;
		
		void AlteraComponentes()
		{
			edtCodigo.CharacterCasing = CharacterCasing.Upper;
		}

		void InicializaCampos()
		{
			edtCodigo.Text = "";
			edtDescricao.Text = "";
		}
				
		public frmCadEstados()
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
				result = estados.Inclui(codigo, edtDescricao.Text, ref msg);
			else
				result = estados.Altera(codigo, edtDescricao.Text, ref msg);
			if (!result)
			{
				if (acao == 'i')
					MessageBox.Show(codigo+"\n"+msg, "Erro na inclusão do estado", MessageBoxButtons.OK, MessageBoxIcon.Error);
				else
					MessageBox.Show(codigo+"\n"+msg, "Erro na alteração do estado", MessageBoxButtons.OK, MessageBoxIcon.Error);				
			}
			this.Cursor = Cursors.WaitCursor;
			estados.Carrega(dgvCadastro);
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
			result = estados.Exclui(edtCodigo.Text, ref msg);
			if (!result)
			{
				MessageBox.Show(edtCodigo.Text + "\r\n" + Globais.ErroExclusao("Estado encontrado", msg), "Erro na exclusão do estado", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			this.Cursor = Cursors.WaitCursor;
			estados.Carrega(dgvCadastro);
			this.Cursor = Cursors.Default;
			if (dgvCadastro.Rows.Count == 0)
			{
				InicializaCampos();
			}			
		}
		
		void FEstadosLoad(object sender, EventArgs e)
		{
			estados = new cEstados();
			this.Cursor = Cursors.WaitCursor;
			estados.Carrega(dgvCadastro);		
			this.Cursor = Cursors.Default;
		}
	}
}
