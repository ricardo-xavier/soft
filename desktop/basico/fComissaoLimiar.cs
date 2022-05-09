/*
 * Projeto  : SoftPlace
 * Sistema  : Cadastros Basicos
 * Programa : fComissaoLimiar - Cadastro de Cargos
 * Autor    : Ricardo Costa Xavier
 * Data     : 07/04/08
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
	public partial class fComissaoLimiar : tCadastroSimples
	{
		private cComissaoLimiar comissao;
		private string fornecedor;
		private string caracteristica;
		
		void AlteraComponentes()
		{
			edtCodigo.CharacterCasing = CharacterCasing.Upper;
			dgvCadastro.Top += 30;
		}

		void InicializaCampos()
		{
			edtCodigo.Text = "0";
			edtDescricao.Text = "0,00";
		}
				
		public fComissaoLimiar(string fornecedor, string caracteristica)
		{
			InitializeComponent();
			this.fornecedor = fornecedor;
			this.caracteristica = caracteristica;
			lblCaracteristica.Text = fornecedor + " - " + caracteristica;
			AlteraComponentes();
		}
		
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			string msg="";
			bool result;
			short limiar = Globais.StrToShort(edtCodigo.Text);
			float valor = Globais.StrToFloat(edtDescricao.Text);
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
				result = comissao.Inclui(fornecedor, caracteristica, limiar, valor, ref msg);
			else
				result = comissao.Altera(fornecedor, caracteristica, limiar, valor, ref msg);
			if (!result)
			{
				if (acao == 'i')
					MessageBox.Show(limiar.ToString()+"\n"+msg, "Erro na inclusão da comissão", MessageBoxButtons.OK, MessageBoxIcon.Error);
				else
					MessageBox.Show(limiar.ToString()+"\n"+msg, "Erro na alteração da comissão", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			this.Cursor = Cursors.WaitCursor;
			comissao.Carrega(fornecedor, caracteristica, dgvCadastro);
			this.Cursor = Cursors.Default;
			int selecionado = Procura(limiar.ToString(), true);
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
			result = comissao.Exclui(fornecedor, caracteristica, Globais.StrToShort(edtCodigo.Text), ref msg);
			if (!result)
			{
				MessageBox.Show(edtCodigo.Text + "\r\n" + Globais.ErroExclusao("Comissão encontrada", msg), "Erro na exclusão da comissão", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			this.Cursor = Cursors.WaitCursor;
			comissao.Carrega(fornecedor, caracteristica, dgvCadastro);
			this.Cursor = Cursors.Default;
			if (dgvCadastro.Rows.Count == 0)
			{
				InicializaCampos();
			}			
		}
		
		void FComissaoLimiarLoad(object sender, EventArgs e)
		{
			comissao = new cComissaoLimiar();
			this.Cursor = Cursors.WaitCursor;
			comissao.Carrega(fornecedor, caracteristica, dgvCadastro);			
			this.Cursor = Cursors.Default;
		}
		
		void BtnIncluiClick(object sender, EventArgs e)
		{
			
		}
	}
}
