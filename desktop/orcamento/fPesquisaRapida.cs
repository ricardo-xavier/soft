/*
 * Criado por SharpDevelop.
 * Usuário: Ricardo
 * Data: 20/06/2008
 * Hora: 20:10
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using classes;

namespace orcamento
{
	public partial class fPesquisaRapida : Form
	{
		public string codigo;
		public string subcod;
		public bool generico;
		public bool result; 
		
		public fPesquisaRapida(string fornecedor, string tabela)
		{
			InitializeComponent();
			
			cProdutos produtos = new cProdutos();			
			foreach (ProdutosTabela prodtab in ProdutosTabelas.lista)
			{
				if ((prodtab.fornecedor.CompareTo(fornecedor) == 0) &&
				    (prodtab.tabela.CompareTo(tabela) == 0))
				{
					produtos.ProdutosFornenedor(dgvProdutos, fornecedor, tabela, ref prodtab.table);		
					return;
				}
			}
			ProdutosTabela nova = new ProdutosTabela(fornecedor, tabela);
			produtos.ProdutosFornenedor(dgvProdutos, fornecedor, tabela, ref nova.table);
			ProdutosTabelas.lista.Add(nova);
		}
		
		public int ProcuraProduto(string buf, int c)
		{
			if (dgvProdutos.Rows.Count == 0) return -1;
			int i;
			string s2 = buf.ToUpper().Trim();			
			if (s2.Length == 0) return -1;
			for (i=0; i<dgvProdutos.Rows.Count; i++)
			{
				string s1 = dgvProdutos.Rows[i].Cells[c].Value.ToString().ToUpper().Trim();
				string s3 = s2.Substring(0, s2.Length);
				if (s1.StartsWith(s3))
				{
					dgvProdutos.Rows[i].Cells[0].Selected = true;
					return i;
				}
			}
			dgvProdutos.Rows[0].Cells[0].Selected = true;
			return -1;
		}
		
		void EdtDescricaoProdutoTextChanged(object sender, EventArgs e)
		{
			ProcuraProduto(edtDescricaoProduto.Text.Trim(), 2);			
		}
		
		void EdtCodigoProdutoTextChanged(object sender, EventArgs e)
		{
			ProcuraProduto(edtCodigoProduto.Text.Trim(), 0);			
		}
		
		void DgvProdutosDoubleClick(object sender, EventArgs e)
		{
			if (dgvProdutos.Rows.Count == 0) return;
			int i = dgvProdutos.CurrentRow.Index;
			codigo = dgvProdutos.Rows[i].Cells["Código"].Value.ToString().Trim();
			subcod = dgvProdutos.Rows[i].Cells["Sub-Código"].Value.ToString().Trim();
			generico = dgvProdutos.Rows[i].Cells["Genérico"].Value.ToString().Trim().Equals("S");
			result = true;
			Close();
		}
		
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			if (dgvProdutos.Rows.Count == 0) return;
			int i = dgvProdutos.CurrentRow.Index;
			codigo = dgvProdutos.Rows[i].Cells["Código"].Value.ToString().Trim();
			subcod = dgvProdutos.Rows[i].Cells["Sub-Código"].Value.ToString().Trim();
			generico = dgvProdutos.Rows[i].Cells["Genérico"].Value.ToString().Trim().Equals("S");
			result = true;
			Close();
		}
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			result = false;
			Close();
		}
		
		void DgvProdutosRowEnter(object sender, DataGridViewCellEventArgs e)
		{
			edtMedidas.Text = dgvProdutos.Rows[e.RowIndex].Cells["Medidas"].Value.ToString();
			edtTexto.Text = dgvProdutos.Rows[e.RowIndex].Cells["Detalhada"].Value.ToString();
		}
	}
}
