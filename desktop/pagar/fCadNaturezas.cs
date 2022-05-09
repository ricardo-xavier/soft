/*
 * Projeto  : SoftPlace
 * Sistema  : Cadastros Basicos
 * Programa : fCadNaturezas - Cadastro de Naturezas de Pagamento
 * Autor    : Ricardo Costa Xavier
 * Data     : 20/07/08
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using templates;
using classes;

namespace pagar
{
	public partial class fCadNaturezas : tCadastroSimples
	{
		private cNaturezasPagamento naturezas;
		private string col_sorted;
		private SortOrder ord_sorted;				
		public bool result;
		public string codigo;
		
		void AlteraComponentes()
		{
			//dgvCadastro.Width += 20;
			dgvCadastro.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCadastroRowEnter);
		}		
		
		public fCadNaturezas(bool duplo)
		{
			InitializeComponent();
			AlteraComponentes();						
			this.dgvCadastro.Sorted += new System.EventHandler(this.DgvCadastroSorted);
			col_sorted = "";
			ord_sorted = SortOrder.Ascending;						
			if (duplo)
				dgvCadastro.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCadastroCellDoubleClick);
		}
		
		void InicializaCampos()
		{
			edtCodigo.Text = "";
			edtDescricao.Text = "";
			chkAtivo.Checked = true;
		}
		
		public void SetaEdicaoLocal(bool enabled)
		{
			chkAtivo.Enabled = enabled;
		}
		
		public void AtualizaDadosLocal(int i)
		{
			chkAtivo.Checked = dgvCadastro.Rows[i].Cells["Ativo"].Value.ToString().Equals("S");
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
			string ativo = chkAtivo.Checked ? "S" : "N";
			if (acao == 'i')
				result = naturezas.Inclui(codigo, edtDescricao.Text, ativo,ref msg);
			else
				result = naturezas.Altera(codigo, edtDescricao.Text, ativo, ref msg);
			if (!result)
			{
				if (acao == 'i')
					MessageBox.Show(codigo+"\n"+msg, "Erro na inclusão da natureza", MessageBoxButtons.OK, MessageBoxIcon.Error);
				else
					MessageBox.Show(codigo+"\n"+msg, "Erro na alteração da natureza", MessageBoxButtons.OK, MessageBoxIcon.Error);				
			}
			this.Cursor = Cursors.WaitCursor;
			naturezas.Carrega(dgvCadastro);
			this.Cursor = Cursors.Default;
			Sort(col_sorted, ord_sorted);
			int selecionado = Procura(codigo, true);
			if (selecionado >= 0)
			{
				dgvCadastro.Rows[selecionado].Cells[0].Selected = true;
				AtualizaDados(selecionado);
				AtualizaDadosLocal(selecionado);
			}
			DesabilitaEdicao();
			SetaEdicaoLocal(false);			
		}
		
		void FCadNaturezasLoad(object sender, EventArgs e)
		{
			naturezas = new cNaturezasPagamento();
			this.Cursor = Cursors.WaitCursor;
			naturezas.Carrega(dgvCadastro);				
			this.Cursor = Cursors.Default;
			SetaEdicaoLocal(false);					
			result = false;
		}
		
		void BtnExcluiClick(object sender, EventArgs e)
		{
			string msg="";
			bool result;
			if (acao == 'c') return;
			result = naturezas.Exclui(edtCodigo.Text, ref msg);
			if (!result)
			{
				MessageBox.Show(edtCodigo.Text, "Erro na exclusão da natureza", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			this.Cursor = Cursors.WaitCursor;
			naturezas.Carrega(dgvCadastro);
			this.Cursor = Cursors.Default;
			Sort(col_sorted, ord_sorted);
			if (dgvCadastro.Rows.Count == 0)
			{
				InicializaCampos();
			}			
		}
		
		void dgvCadastroCellDoubleClick(object sender, DataGridViewCellEventArgs e)		
		{
			result = true;
			codigo = edtCodigo.Text;
			Close();
		}
		
		void BtnIncluiClick(object sender, EventArgs e)
		{
			SetaEdicaoLocal(true);
		}
		
		void BtnAlteraClick(object sender, EventArgs e)
		{
			SetaEdicaoLocal(true);
		}
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			SetaEdicaoLocal(false);
		}
		
		void DgvCadastroRowEnter(object sender, DataGridViewCellEventArgs e)
		{
			AtualizaDadosLocal(e.RowIndex);
		}				
		
		void DgvCadastroSorted(object sender, EventArgs e)
		{
			col_sorted = dgvCadastro.SortedColumn.HeaderText;
			ord_sorted = dgvCadastro.SortOrder;
		}		
		
		private void Sort(string coluna, SortOrder ordem)
		{
			if (coluna.Length > 0)
			{
				foreach (DataGridViewColumn col in dgvCadastro.Columns)				
				{
					if (col.HeaderText.Equals(coluna))
					{
						dgvCadastro.Sort(col, ordem == SortOrder.Ascending ?
			    	             System.ComponentModel.ListSortDirection.Ascending :
			        	         System.ComponentModel.ListSortDirection.Descending);
						break;
					}
				}
			}			
		}
		
	}
}
