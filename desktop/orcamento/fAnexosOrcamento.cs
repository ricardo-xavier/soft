/*
 * Projeto  : SoftPlace
 * Sistema  : CPD
 * Programa : fAnexosOrcamento - Cadastro de Anexos do Orcamento
 * Autor    : Ricardo Costa Xavier
 * Data     : 28/06/08
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using templates;
using classes;
using System.Runtime.InteropServices;
using System.Text;

namespace orcamento
{
	public partial class frmAnexosOrcamento : tCadastroSimples
	{
		public string fornecedor;
		public DateTime data;
		public int cod_orcamento;
		private cOrcamentos orcamento;
		
		[DllImport("mpr.dll")]
		public static extern int WNetGetUniversalName(
  			string lpLocalPath,
  			int dwInfoLevel,
  			ref StringBuilder lpBuffer,
  			ref int lpBufferSize);		
		
		const int UNIVERSAL_NAME_INFO_LEVEL = 1;
		const int ERROR_MORE_DATA = 234;		
		
		public string ConvertLocalPathToUnc(string localPath)
		{
			if (localPath.StartsWith("c:") || localPath.StartsWith("C:") 
			    || localPath.StartsWith("d:") || localPath.StartsWith("D:")) {
				return localPath;
			}
			cFiliais filiais = new cFiliais();
			string diretorio = filiais.Diretorio(Globais.sFilial);
			if ((diretorio != null) && (diretorio.Trim().Length > 0)) {
				return diretorio + localPath.Substring(2);
			}
  			StringBuilder buffer = new StringBuilder();
  			int size = 0;
  			int retVal = WNetGetUniversalName(localPath, UNIVERSAL_NAME_INFO_LEVEL,	ref buffer, ref size);
  			if (retVal == ERROR_MORE_DATA)
  			{
    			buffer = new StringBuilder(size);
    			retVal = WNetGetUniversalName(localPath, UNIVERSAL_NAME_INFO_LEVEL,	ref buffer, ref size);
    			if (retVal != 0)
    			{
      				return localPath;
    			}
  			}
  			else
  			{
    			return localPath;
  			}
  			return buffer.ToString();
		}		
		
		void AlteraComponentes()
		{
			btnAltera.Visible = false;
		}
		
		void InicializaCampos()
		{
			edtCodigo.Text = "";
			edtDescricao.Text = "";
		}
		
		public frmAnexosOrcamento()
		{
			InitializeComponent();
			AlteraComponentes();			
		}
		
		void FrmAnexosOrcamentoLoad(object sender, EventArgs e)
		{
			orcamento = new cOrcamentos();
			string codigo = edtCodigo.Text.Trim();
			orcamento.CarregaAnexos(dgvCadastro, fornecedor, data, cod_orcamento);
			DesabilitaEdicao();					
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
			result = orcamento.IncluiAnexo(fornecedor, data, cod_orcamento, codigo, edtDescricao.Text, ref msg);
			if (!result)
			{
				MessageBox.Show(codigo, "Erro na inclusão do anexo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			orcamento.CarregaAnexos(dgvCadastro, fornecedor, data, cod_orcamento);
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
			string codigo = edtCodigo.Text.Trim();			
			result = orcamento.ExcluiAnexo(fornecedor, data, cod_orcamento, codigo, ref msg);
			if (!result)
			{
				MessageBox.Show(edtCodigo.Text, "Erro na exclusão do anexo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			orcamento.CarregaAnexos(dgvCadastro, fornecedor, data, cod_orcamento);
			if (dgvCadastro.Rows.Count == 0)
			{
				InicializaCampos();
			}				
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			string s = (dlgOpen.ShowDialog() == DialogResult.OK) ? dlgOpen.FileName : null;
			if (s != null)
			{
				if ((s.Length > 1) && (s[1] == ':'))
				{
					s = ConvertLocalPathToUnc(s);
				}
				edtDescricao.Text = s;
			}
			edtDescricao.Focus();
		}
		
		void BtnIncluiClick(object sender, EventArgs e)
		{
			
		}
	}
}
