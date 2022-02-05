/*
 * Projeto  : SoftPlace
 * Sistema  : Orcamento
 * Programa : fConsultaPreco - Consulta de precos
 * Autor    : Ricardo Costa Xavier
 * Data     : 25/10/08
 * 
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using templates;
using classes;
using System.IO;
using basico;

namespace orcamento
{
	public partial class fConsultaPreco : Form
	{
		float preco_tabela;
		float preco_unitario;
		float preco_formula;
		float ipi;		
		float per_frete;
		string formula;
		string fornecedor;
		string tabela;
		string caracteristica;
		private cTabelas tabelas;
		private Image image;		
		
		public fConsultaPreco()
		{
			InitializeComponent();
			preco_tabela = 0;
			preco_unitario = 0;
			preco_formula = 0;
			ipi = 0;			
			per_frete = 0;
			formula= "";
			fornecedor = "";
			tabela = "";
			caracteristica = "";
			tabelas = new cTabelas();
		}
		
		void PesquisaRapida()
		{
			fPesquisaRapida frm = new fPesquisaRapida(fornecedor, tabela);
			frm.ShowDialog();
			if (frm.result)
			{
				edtProduto.Text = frm.codigo;
				edtSubCodigo.Text = frm.subcod;
			}
		}
		
		void BtnPesquisaRapidaClick(object sender, EventArgs e)
		{
			PesquisaRapida();
		}
		
		void BtnCalculoMouseEnter(object sender, EventArgs e)
		{
			dgvFormula.Visible = true;
			float preco = preco_tabela;
			DataTable tab = new DataTable();
			tab.Columns.Add("Percentual", typeof(string));
			tab.Columns.Add("Valor", typeof(float));
			tab.Rows.Add(new object[] {"Tabela", preco_tabela});
			Globais.MostraFormula(ref preco, formula, ipi, per_frete, 0, tab);
			/*
			float fator;
			for (int i=0; i<formula.Trim().Length; i+=4)
			{
				if (formula[i] == 'x')
				{
					fator = Globais.StrToFloat(formula.Substring(i+1, 3));
					preco *= fator;
					tab.Rows.Add(new object[] {formula.Substring(i, 4), preco});
					continue;
				}
				if (formula.Substring(i, 4).CompareTo("+IPI") == 0)
				{
					fator = ipi;
					preco += (preco * fator / (float)100);
					tab.Rows.Add(new object[] {"IPI +" + ipi.ToString("#0") + "%", preco});
				}
				else
				{
					fator = Globais.StrToFloat(formula.Substring(i, 4));
					preco += (preco * fator / (float)100);
					tab.Rows.Add(new object[] {formula.Substring(i, 4)+"%", preco});				
				}
			}
			*/
			int qtde=0;
			int.TryParse(edtQtde.Text, out qtde);
			preco = Globais.Arredonda(preco) * qtde;
			tab.Rows.Add(new object[] {"x"+edtQtde.Text, preco});							
			dgvFormula.DataSource = tab;
			dgvFormula.Columns["Percentual"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			dgvFormula.Columns["Valor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;			
			dgvFormula.Columns["Valor"].DefaultCellStyle.Format = "###,###,##0.00";
		}
		
		void BtnCalculoMouseLeave(object sender, EventArgs e)
		{
			dgvFormula.Visible = false;
		}
		
		void BtnFornecedorClick(object sender, EventArgs e)
		{
			cControleAcesso acesso = new cControleAcesso();
			frmCadParceiros frmCad = new frmCadParceiros(true);
			frmCad.where = "";
			frmCad.bFornecedores = true;
			frmCad.codigo = edtFornecedor.Text;
			frmCad.ReadOnly = !acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fCadParceiros");
			frmCad.ShowDialog();
			if (frmCad.result)
			{
				edtFornecedor.Text = frmCad.edtCodigo.Text;
				CarregaCaracteristicas();
				CarregaTabelas();
			}
		}
		
		void CarregaCaracteristicas()
		{
			cCaracteristicas caracteristicas = new cCaracteristicas();
			cbxCaracteristicas.Items.Clear();
			this.Cursor = Cursors.WaitCursor;
			caracteristicas.Carrega(cbxCaracteristicas, edtFornecedor.Text);
			this.Cursor = Cursors.Default;
		}
		
		void CarregaTabelas()
		{
			cTabelas tabelas = new cTabelas();
			this.Cursor = Cursors.WaitCursor;
			tabelas.Carrega(cbxTabelas, edtFornecedor.Text);
			this.Cursor = Cursors.Default;
			if (cbxTabelas.Items.Count > 0)
				cbxTabelas.Text = cbxTabelas.Items[cbxTabelas.Items.Count-1].ToString();
			else
				cbxTabelas.Text = "";				
		}
		
		void EdtFornecedorLeave(object sender, EventArgs e)
		{
			CarregaCaracteristicas();
			CarregaTabelas();
			cCaracteristicas caracteristicas = new cCaracteristicas();
			formula = caracteristicas.Formula(fornecedor, caracteristica);
			float limiar = caracteristicas.Limiar(fornecedor, caracteristica);
			edtLimiar.Text = limiar.ToString("###0.00");
		}
		
		void EdtSubCodigoTextChanged(object sender, EventArgs e)
		{
			cProdutos produtos = new cProdutos();
			ipi = produtos.IPI(fornecedor, edtProduto.Text, edtSubCodigo.Text);			
			CalculaPreco();
			MostraImagem();
		}
		
		void CalculaPreco()
		{
			string produto = edtProduto.Text.Trim();
			string subcod = edtSubCodigo.Text.Trim();
			int qtde;
			int.TryParse(edtQtde.Text.Trim(), out qtde);
			if ((fornecedor.Length == 0) || (caracteristica.Length == 0) || (produto.Length == 0) || (tabela.Length == 0)) return;
			if (tabelas == null) return;
			preco_tabela = tabelas.Preco(fornecedor, tabela, produto, subcod);
			preco_unitario = preco_tabela;
			cOrcamentos orcamento = new cOrcamentos();
			per_frete = cCaracteristicas.Frete(fornecedor, caracteristica);
			preco_formula = preco_unitario;
			Globais.CalculaFormula(ref preco_formula, formula, ipi, per_frete, 0);
			edtPrecoFormula.Text = preco_formula.ToString("#,###,##0.00");
			if (qtde > 0)
				edtPrecoTotal.Text = (Globais.Arredonda(preco_formula) * qtde).ToString("#,###,##0.00");
		}
		
		void EdtFornecedorTextChanged(object sender, EventArgs e)
		{
			fornecedor = edtFornecedor.Text.Trim();
			CalculaPreco();
		}
		
		void CbxTabelasSelectedIndexChanged(object sender, EventArgs e)
		{
			tabela = cbxTabelas.SelectedItem.ToString().Trim();
			CalculaPreco();
		}
		
		void CbxCaracteristicasSelectedIndexChanged(object sender, EventArgs e)
		{
			caracteristica = cbxCaracteristicas.SelectedItem.ToString().Trim();
			cCaracteristicas caracteristicas = new cCaracteristicas();
			formula = caracteristicas.Formula(fornecedor, caracteristica);
			float limiar = caracteristicas.Limiar(fornecedor, caracteristica);
			edtLimiar.Text = limiar.ToString("###0.00");
			CalculaPreco();
		}
		
		void EdtQtdeTextChanged(object sender, EventArgs e)
		{
			CalculaPreco();
		}
		
		void BtnFechaClick(object sender, EventArgs e)
		{
			Close();
		}
		
		public void MostraImagem()
		{
			imgProduto.Image = null;
			string img = "imagens\\" + edtProduto.Text + edtSubCodigo.Text + ".jpg";
			image = null;
			if (File.Exists(img))
				image = Image.FromFile(img);
			else
			{
				img = "imagens\\" + edtProduto.Text + edtSubCodigo.Text + ".bmp";
				if (File.Exists(img))
					image = Image.FromFile(img);
			}
		}
		
		void ImgProdutoPaint(object sender, PaintEventArgs e)
		{
			if (image != null)
			{
				int h = image.Height;
				int w = image.Width;
				while ((w > 200) || (h > 150)) 
				{
					w = (int)(w * 0.9);
					h = (int)(h * 0.9);
				}
				e.Graphics.DrawImage(image, 5, 5, w, h);
			}
		}
		
		void EdtProdutoTextChanged(object sender, EventArgs e)
		{
			cProdutos produtos = new cProdutos();
			ipi = produtos.IPI(fornecedor, edtProduto.Text, edtSubCodigo.Text);			
			CalculaPreco();
			MostraImagem();
		}
		
		void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			string url = "https://chart.googleapis.com/chart?chs=150x150&cht=qr&chl=http://softplacemoveis.dyndns.org:8080/softws/softws/produto/"
			                                 + fornecedor + "/" + edtProduto.Text + "/" + edtSubCodigo.Text + "/" + tabela + "/" + caracteristica.Replace("%", "%2525");
			System.Diagnostics.Process.Start(url);
		}
		void BtnQrcodeClick(object sender, EventArgs e)
		{
			string url = "https://chart.googleapis.com/chart?chs=150x150&cht=qr&chl=http://softplacemoveis.dyndns.org:8080/softws/softws/produto/"
			                                 + fornecedor + "/" + edtProduto.Text + "/" + edtSubCodigo.Text + "/" + tabela + "/" + caracteristica.Replace("%", "%2525");
			System.Diagnostics.Process.Start(url);
		}
	}
}
