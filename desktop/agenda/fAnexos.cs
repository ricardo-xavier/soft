/*
 * Projeto  : SoftPlace
 * Sistema  : CPD
 * Programa : fAnexos - Cadastro de Anexos da Agenda
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

namespace agenda
{
	public partial class frmAnexos : tCadastroSimples
	{
		public string usuario;
		public DateTime data_agendamento;
		private cAgenda agenda;
		
		void AlteraComponentes()
		{
			btnAltera.Visible = false;
		}
		
		void InicializaCampos()
		{
			edtCodigo.Text = "";
			edtDescricao.Text = "";
		}
		
		public frmAnexos()
		{
			InitializeComponent();
			AlteraComponentes();			
		}
		
		void FrmAnexosLoad(object sender, EventArgs e)
		{
			agenda = new cAgenda();
			string codigo = edtCodigo.Text.Trim();
			agenda.CarregaAnexos(dgvCadastro, usuario, data_agendamento);
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
			result = agenda.IncluiAnexo(usuario, data_agendamento, codigo, edtDescricao.Text, ref msg);
			if (!result)
			{
				MessageBox.Show(codigo, "Erro na inclusão do anexo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			agenda.CarregaAnexos(dgvCadastro, usuario, data_agendamento);
			int selecionado = Procura(codigo, true);
			if (selecionado >= 0)
			{
				dgvCadastro.Rows[selecionado].Cells[0].Selected = true;
				AtualizaDados(selecionado);
			}
			DesabilitaEdicao();
		}
		
		void BtnNaturezaClick(object sender, EventArgs e)
		{
			string s = (dlgOpen.ShowDialog() == DialogResult.OK) ? dlgOpen.FileName : null;
			if (s != null)
				edtDescricao.Text = s;
			edtDescricao.Focus();
		}
		
		void BtnExcluiClick(object sender, EventArgs e)
		{
			string msg="";
			bool result;
			if (acao == 'c') return;
			string codigo = edtCodigo.Text.Trim();			
			result = agenda.ExcluiAnexo(usuario, data_agendamento, codigo, ref msg);
			if (!result)
			{
				MessageBox.Show(edtCodigo.Text, "Erro na exclusão do anexo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			agenda.CarregaAnexos(dgvCadastro, usuario, data_agendamento);
			if (dgvCadastro.Rows.Count == 0)
			{
				InicializaCampos();
			}				
		}
	}
}
