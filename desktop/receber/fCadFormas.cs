/*
 * Projeto  : SoftPlace
 * Sistema  : Cadastros Basicos
 * Programa : fCadFormas - Cadastro de Formas de Recebimento
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

namespace receber
{
	public partial class fCadFormas : tCadastroSimples
	{
		private cFormasRecebimento formas;
		private string col_sorted;
		private SortOrder ord_sorted;								
		public bool result;
		public string codigo;
		
		void AlteraComponentes()
		{
			dgvCadastro.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCadastroRowEnter);
		}				
		
		public fCadFormas(bool duplo)
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
				result = formas.Inclui(codigo, edtDescricao.Text, ativo, ref msg);
			else
				result = formas.Altera(codigo, edtDescricao.Text, ativo, ref msg);
			if (!result)
			{
				if (acao == 'i')
					MessageBox.Show(codigo+"\n"+msg, "Erro na inclusão da forma de recebimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
				else
					MessageBox.Show(codigo+"\n"+msg, "Erro na alteração da forma de recebimento", MessageBoxButtons.OK, MessageBoxIcon.Error);				
			}
			this.Cursor = Cursors.WaitCursor;
			formas.Carrega(dgvCadastro);
			this.Cursor = Cursors.Default;
			Sort(col_sorted, ord_sorted);
			int selecionado = Procura(codigo, true);
			if (selecionado >= 0)
			{
				dgvCadastro.Rows[selecionado].Cells[0].Selected = true;
				AtualizaDados(selecionado);
			}
			DesabilitaEdicao();
			SetaEdicaoLocal(false);
		}
		
		void FCadFormasLoad(object sender, EventArgs e)
		{
			formas = new cFormasRecebimento();
			this.Cursor = Cursors.WaitCursor;
			formas.Carrega(dgvCadastro);				
			this.Cursor = Cursors.Default;
			SetaEdicaoLocal(false);	
		}
		
		void BtnExcluiClick(object sender, EventArgs e)
		{
			string msg="";
			bool result;
			if (acao == 'c') return;
			result = formas.Exclui(edtCodigo.Text, ref msg);
			if (!result)
			{
				MessageBox.Show(edtCodigo.Text, "Erro na exclusão da forma de recebimento", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			this.Cursor = Cursors.WaitCursor;
			formas.Carrega(dgvCadastro);
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
