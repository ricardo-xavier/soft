/*
 * Projeto  : SoftPlace
 * Sistema  : CPD
 * Programa : fCadItens - Cadastro de Itens do Orcamento
 * Autor    : Ricardo Costa Xavier
 * Data     : 04/06/08
 * 
 * 22/11/14 - Ricardo - marcar com laranja os itens com valor de tabela diferente do atual
 * 
 * 04/05/2017 - reposicionar por area + produto para itens de orcamento
 * 
 * 21/03/2018 - Ricardo - reordenar após inclusão/alteração
 * 
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using templates;
using classes;
using System.IO;
using basico;

namespace orcamento
{
	public partial class frmCadItens : tCadastroSimples
	{
		private cOrcamentos orcamento;
		private string sArea;
		private cTabelas tabelas;
		public string fornecedor;
		public DateTime data;
		public short cod_orcamento;
		public string cliente;
		public string tabela;
		public string formula;
		public string formula_orcamento;
		public bool pedido;
		private Image image;		
		private float preco_tabela;		
		private float preco_unitario;
		private float preco_formula;
		private float ipi;
		private float per_frete;
		private string ultimo_produto;
		private string ultimo_subcodigo;
		private bool item_especial;
		private bool item_generico;
		private bool acessoProdutos;
		private string col_sorted;
		private SortOrder ord_sorted;		
		
		void AlteraComponentes()
		{
			dgvCadastro.Top += 25;			
			btnUp.Top += 25;
			btnDown.Top += 25;
			dgvCadastro.Width = 600;
			dgvCadastro.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCadastroRowEnter);			
		}
		
		void InicializaCampos()
		{
			edtArea.Text = sArea;
			edtDescricao.Text = "0";
			edtProduto.Text = "";
			edtSubCodigo.Text = "";
			edtQtde.Text = "1";
			edtMedidas.Text = "";
			edtPrecoFormula.Text = "0,00";
			edtPrecoGenerico.Text = "0,00";
			preco_tabela = 0;
			preco_unitario = 0;
			preco_formula = 0;
			edtPrecoTotal.Text = "0,00";
			ckbEspecial.Checked = false;
			ckbGenerico.Checked = false;
			item_especial = false;
			item_generico = false;
			imgProduto.Image = null;
			edtDescricaoProd.Text = "";
			edtTexto.Text = "";
			edtEspecificos.Text = "";
			edtCodigo.Text = "-";
		}
		
		public void SetaEdicaoLocal(bool enabled)
		{
			btnDuplica.Enabled = !enabled;
			edtArea.Enabled = enabled;
			edtDescricao.Enabled = false;
			edtProduto.Enabled = enabled;
			edtSubCodigo.Enabled = enabled;
			edtDescricaoProd.Enabled = enabled;
			edtTexto.Enabled = enabled;
			edtEspecificos.Enabled = enabled;
			edtQtde.Enabled = enabled;
			edtMedidas.Enabled = enabled;
			if (edtMedidas.Enabled)
				edtMedidas.Enabled = item_especial;
			edtPrecoGenerico.Enabled = enabled;
			if (edtPrecoGenerico.Enabled)
				edtPrecoGenerico.Enabled = item_generico;
			edtPrecoFormula.Enabled = enabled;
			if (edtPrecoFormula.Enabled)
				edtPrecoFormula.Enabled = item_especial;
			edtPrecoTotal.Enabled = false;			
			ckbEspecial.Enabled = enabled;
			btnProduto.Enabled = enabled && acessoProdutos;
			btnPesquisaRapida.Enabled = enabled;
			if (pedido)
			{
				btnInclui.Enabled = false;
				btnExclui.Enabled = false;
				btnAltera.Enabled = false;
				btnDuplica.Enabled = false;
			}
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
		
		public void AtualizaDadosLocal(int i)
		{
			item_especial = ckbEspecial.Checked = dgvCadastro.Rows[i].Cells["Especial"].Value.ToString().Trim().Equals("S");
			item_generico = ckbGenerico.Checked = dgvCadastro.Rows[i].Cells["Genérico"].Value.ToString().Trim().Equals("S");
			edtArea.Text = dgvCadastro.Rows[i].Cells["Área"].Value.ToString().Trim();							
			edtDescricao.Text = dgvCadastro.Rows[i].Cells["Seq"].Value.ToString().Trim();			
			edtProduto.Text = dgvCadastro.Rows[i].Cells["Produto"].Value.ToString().Trim();			
			edtSubCodigo.Text = dgvCadastro.Rows[i].Cells["Sub-Código"].Value.ToString().Trim();									
			edtDescricaoProd.Text = dgvCadastro.Rows[i].Cells["Descrição"].Value.ToString().Trim();									
			edtTexto.Text = dgvCadastro.Rows[i].Cells["Texto"].Value.ToString().Trim();
			edtEspecificos.Text = dgvCadastro.Rows[i].Cells["Específicos"].Value.ToString().Trim();
			ultimo_produto = edtProduto.Text.Trim();
			ultimo_subcodigo = edtSubCodigo.Text.Trim();
			edtQtde.Text = dgvCadastro.Rows[i].Cells["Qtde"].Value.ToString().Trim();
			edtMedidas.Text = dgvCadastro.Rows[i].Cells["Medidas"].Value.ToString().Trim();
			preco_formula = Globais.StrToFloat(dgvCadastro.Rows[i].Cells["Preço"].Value.ToString());
			preco_unitario = Globais.StrToFloat(dgvCadastro.Rows[i].Cells["Preço Unitário"].Value.ToString());		
			preco_tabela = Globais.StrToFloat(dgvCadastro.Rows[i].Cells["Preço Tabela"].Value.ToString());
			if (item_generico)
				edtPrecoGenerico.Text = preco_tabela.ToString("#,###,##0.00");			
			else
				edtPrecoGenerico.Text = 0.ToString("#,###,##0.00");
			edtPrecoFormula.Text = preco_formula.ToString("#,###,##0.00");
			float total = Globais.Arredonda(preco_formula) * Globais.StrToInt(edtQtde.Text);
			edtPrecoTotal.Text = total.ToString("#,###,##0.00");
			MostraImagem();
		}
		
		public frmCadItens()
		{
			InitializeComponent();
			AlteraComponentes();			
		}
		
		void FCadItensLoad(object sender, EventArgs e)
		{
			cControleAcesso acesso = new cControleAcesso();
			acessoProdutos = Globais.bAdministrador || acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fCadProdutos");
			orcamento = new cOrcamentos();						
			per_frete = orcamento.Frete(fornecedor, data, cod_orcamento);
			orcamento.CarregaItens(dgvCadastro, fornecedor, data, cod_orcamento, formula, tabela);
			Colore();
			if (pedido)
			{
				foreach (DataGridViewRow row in dgvCadastro.Rows)
				{
					DataGridViewCell cell;
					
					cell = row.Cells["Especial"];
					if (cell.Value.ToString().Equals("S"))
					{
						cell = row.Cells["Preço Unitário"];
						float preco = Globais.StrToFloat(cell.Value.ToString());
						// desfaz formula						
						Globais.DesfazFormula(ref preco, formula, ipi, per_frete, 0);
						/*
						float fator=0;
						for (int i=formula_orcamento.Trim().Length-4; i>=0; i-=4)
						{
							if (formula_orcamento[i] == 'x')
							{
								fator = (Globais.StrToFloat(formula_orcamento.Substring(i+1, 3)) - 1) * 100;
							}
							if (formula_orcamento.Substring(i, 4).CompareTo("+IPI") == 0)
							{
								fator = ipi;
							}
							else
							{
								fator = Globais.StrToFloat(formula_orcamento.Substring(i, 4));
							}
							preco = (preco * 100) / (100 + fator);
						}
						*/
						// refaz parte do pedido
						Globais.CalculaFormula(ref preco, formula, ipi, per_frete, 0);
						/*
						for (int i=0; i<formula.Trim().Length; i+=4)
						{
							if (formula[i] == 'x')
							{
								fator = Globais.StrToFloat(formula.Substring(i+1, 3));
								preco *= fator;
								continue;
							}
							if (formula.Substring(i, 4).CompareTo("+IPI") == 0)
							{
								fator = ipi;
								preco += (preco * fator / (float)100);
							}
							else
							{
								fator = Globais.StrToFloat(formula.Substring(i, 4));
								preco += (preco * fator / (float)100);
							}
						}
						*/
						cell.Value = preco;
						cell = row.Cells["Preço"];
						cell.Value = preco;
					}
				}
			}
			
			if (dgvCadastro.Rows.Count > 0)
				AtualizaDadosLocal(0);
			lblOrcamento.Text = "Orçamento: " + fornecedor.Trim() + " - " + data.ToString("d/M/yyyy") + " - " + cod_orcamento +
				"        Cliente: " + cliente;
			tabelas = new cTabelas();
			DesabilitaEdicao();								
			SetaEdicaoLocal(false);				
			ultimo_produto = "";
			ultimo_subcodigo = "";
			col_sorted = "";
			ord_sorted = SortOrder.Ascending;
			
		}
		
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			string area = edtArea.Text.Trim();
			sArea = area;
			if (area.CompareTo("") == 0)
			{
				MessageBox.Show("Área", "Campo obrigatório", 
				                MessageBoxButtons.OK, 
				                MessageBoxIcon.Warning);
				edtArea.Focus();
				return;
			}
			string produto = edtProduto.Text.Trim();
			if (produto.CompareTo("") == 0)
			{
				MessageBox.Show("Produto", "Campo obrigatório", 
				                MessageBoxButtons.OK, 
				                MessageBoxIcon.Warning);
				edtProduto.Focus();
				return;
			}
			int qtde;
			if (!int.TryParse(edtQtde.Text, out qtde) || (qtde == 0))
			{
				MessageBox.Show("Quantidade", "Campo obrigatório", 
				                MessageBoxButtons.OK, 
				                MessageBoxIcon.Warning);
				edtQtde.Focus();
				return;
			}
			string msg="";
			string especial;
			bool result;
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
			especial = item_especial ? "S" : "N";
			if (item_especial)
				preco_unitario = Globais.StrToFloat(edtPrecoFormula.Text);
			if (acao == 'i')
				result = orcamento.IncluiItem(fornecedor, data, cod_orcamento,
				                              area, produto, edtSubCodigo.Text, (short)qtde,
				                              edtMedidas.Text, 
				                              preco_unitario,
				                              //StrToFloat(edtPrecoUnitario.Text),
				                              preco_tabela,
				                              especial, 
				                              edtDescricaoProd.Text,
				                              edtTexto.Text,
				                              edtEspecificos.Text,
				                              ref msg);
			else
				result = orcamento.AlteraItem(fornecedor, data, cod_orcamento,
				                              area, Globais.StrToShort(edtDescricao.Text),
				                              produto, edtSubCodigo.Text, (short)qtde,
				                              edtMedidas.Text, 
				                              preco_unitario,
				                              //StrToFloat(edtPrecoUnitario.Text),
				                              preco_tabela,
				                              especial, 
				                              edtDescricaoProd.Text,
				                              edtTexto.Text,
				                              edtEspecificos.Text,
				                              ref msg);
			if (!result)
			{
				if (acao == 'i')
					MessageBox.Show(edtProduto.Text+"\n"+msg, "Erro na inclusão do item", MessageBoxButtons.OK, MessageBoxIcon.Error);
				else
					MessageBox.Show(edtProduto.Text+"\n"+msg, "Erro na alteração do item", MessageBoxButtons.OK, MessageBoxIcon.Error);				
			}
			orcamento.CarregaItens(dgvCadastro, fornecedor, data, cod_orcamento, formula, tabela);
			Colore();		

			Grid.Sort(dgvCadastro, col_sorted, ord_sorted);					
			
			int selecionado = ProcuraItem(area, produto);
			if (selecionado >= 0)
			{
				dgvCadastro.Rows[selecionado].Cells[0].Selected = true;
				AtualizaDados(selecionado);
				AtualizaDadosLocal(selecionado);				
			}
			DesabilitaEdicao();
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
		
		void BtnIncluiClick(object sender, EventArgs e)
		{
			item_especial = false;
			item_generico = false;
			SetaEdicaoLocal(true);
			InicializaCampos();
			edtArea.Focus();
		}
		
		void CalculaPreco()
		{
			string produto = edtProduto.Text.Trim();
			string subcod = edtSubCodigo.Text.Trim();
			int qtde;
			int.TryParse(edtQtde.Text.Trim(), out qtde);
			if ((produto.Length == 0) || (tabela.Length == 0)) return;
			if (tabelas == null) return;
			preco_tabela = tabelas.Preco(fornecedor, tabela, produto, subcod);
			if (ckbGenerico.Checked)
			{
				preco_tabela = Globais.StrToFloat(edtPrecoGenerico.Text);
				edtPrecoGenerico.Text = preco_tabela.ToString("#,###,##0.00");
			}
			if (!item_especial)
			{
				preco_unitario = preco_tabela;
				preco_formula = preco_unitario;
				Globais.CalculaFormula(ref preco_formula, formula, ipi, per_frete, 0);
				edtPrecoFormula.Text = preco_formula.ToString("#,###,##0.00");
			}
			else
			{
				if (!pedido)
				{
					preco_unitario = Globais.StrToFloat(edtPrecoFormula.Text);
					preco_formula = preco_unitario;
				}
				else
				{
				}
			}
			//preco_formula += (preco_formula * ipi / 100F);
			if (qtde > 0)
				edtPrecoTotal.Text = (Globais.Arredonda(preco_formula) * qtde).ToString("#,###,##0.00");
		}
		
		void EdtProdutoTextChanged(object sender, EventArgs e)
		{
			cProdutos produtos = new cProdutos();
			ipi = produtos.IPI(fornecedor, edtProduto.Text, edtSubCodigo.Text);			
			CalculaPreco();
			string descricao="";
			string texto="";
			edtMedidas.Text = produtos.Medidas_Descricao(fornecedor, edtProduto.Text, edtSubCodigo.Text, ref descricao, ref texto);
			if (edtProduto.Text.Trim().CompareTo(ultimo_produto) != 0)
			{
				ultimo_produto = edtProduto.Text;
				edtDescricaoProd.Text = descricao;
				edtTexto.Text = texto;
			}
			MostraImagem();
			if (!ckbEspecial.Checked)
				CalculaPreco();					
			/*
			if (gbxPesquisa.Visible) return;
			if (edtProduto.Text.Trim().Length > 0) return;
			edtCodigoProduto.Text = "";
			edtDescricaoProduto.Text = "";
			gbxPesquisa.Visible = true;			
			edtDescricaoProduto.Focus();
			*/
			//if (!gbxPesquisa.Visible) return;
			//ProcuraProduto(edtProduto.Text.Trim(), 0);
			//CalculaPreco();
			//MostraMedidas();
			//MostraImagem();
		}
		
		void EdtQtdeTextChanged(object sender, EventArgs e)
		{
			CalculaPreco();
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
		
		void BtnProdutoClick(object sender, EventArgs e)
		{
			cControleAcesso acesso = new cControleAcesso();
			/*
			if (!acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fConProduts")) return;				
			frmConProdutos frm = new frmConProdutos();
			frm.fornecedor = fornecedor;
			frm.ShowDialog();
			if (frm.cancela) return;
			*/
			
			frmCadProdutos frmCad = new frmCadProdutos(true);
			//frmCad.where = frm.filtro;
			frmCad.where = "";
			frmCad.xCodigo = edtProduto.Text;
			frmCad.where =
					"where cod_produto in (select cod_produto from precos where cod_parceiro='" + fornecedor + 
					"' and cod_tabela='" + tabela + "' and vlr_preco <> 0)";
				
			frmCad.ReadOnly = !acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fCadParceiros");
			frmCad.ShowDialog();
			if (frmCad.result)
			{
				edtProduto.Text = frmCad.edtCodigo.Text;
				edtSubCodigo.Text = frmCad.edtSubCodigo.Text;
				ckbGenerico.Checked = frmCad.chkGenerico.Checked;
				edtPrecoGenerico.Enabled = ckbGenerico.Checked;
			}
			edtMedidas.Focus();
		}
		
		void EdtSubCodigoTextChanged(object sender, EventArgs e)
		{
			cProdutos produtos = new cProdutos();
			ipi = produtos.IPI(fornecedor, edtProduto.Text, edtSubCodigo.Text);			
			CalculaPreco();
			string descricao="";
			string texto="";
			edtMedidas.Text = produtos.Medidas_Descricao(fornecedor, edtProduto.Text, edtSubCodigo.Text, ref descricao, ref texto);
			if (edtSubCodigo.Text.Trim().CompareTo(ultimo_subcodigo) != 0)
			{
				ultimo_subcodigo = edtSubCodigo.Text;
				edtDescricaoProd.Text = descricao;
				edtTexto.Text = texto;
			}
			MostraImagem();
			if (!ckbEspecial.Checked)
				CalculaPreco();			
		}
		
		public void Posiciona(string area, string codigo, string subcodigo)
		{
			for (int i=0; i<dgvCadastro.Rows.Count; i++)
			{
				string _area = dgvCadastro.Rows[i].Cells[0].Value.ToString().Trim();
				string _codigo = dgvCadastro.Rows[i].Cells[1].Value.ToString().Trim();
				string _subcodigo = dgvCadastro.Rows[i].Cells[2].Value.ToString().Trim();
				if ((_area.CompareTo(area) == 0) &&
				    (_codigo.CompareTo(codigo) == 0) &&
				    (_subcodigo.CompareTo(subcodigo) == 0))
				{
					dgvCadastro.Rows[i].Cells[0].Selected = true;
					return;
				}
			}
		}
			
		void BtnAlteraClick(object sender, EventArgs e)
		{
			if (acao == 'c') return;			
			SetaEdicaoLocal(true);
			Posiciona(edtArea.Text, edtCodigo.Text, edtSubCodigo.Text);
		}
		
		void BtnExcluiClick(object sender, EventArgs e)
		{
			string msg="";
			bool result;
			if (acao == 'c') return;
			result = orcamento.ExcluiItem(fornecedor, data, cod_orcamento, edtArea.Text.Trim(), Globais.StrToShort(edtDescricao.Text), ref msg);
			if (!result)
			{
				MessageBox.Show(edtDescricao.Text, "Erro na exclusão do item", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			orcamento.CarregaItens(dgvCadastro, fornecedor, data, cod_orcamento, formula, tabela);
			Colore();			
			if (dgvCadastro.Rows.Count == 0)
			{
				InicializaCampos();
			}
		}
		
		void CkbEspecialCheckedChanged(object sender, EventArgs e)
		{
			edtMedidas.Enabled = ckbEspecial.Checked;			
			edtPrecoFormula.Enabled = ckbEspecial.Checked;
			item_especial = ckbEspecial.Checked;
			if (!item_especial)
				CalculaPreco();
		}
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			SetaEdicaoLocal(false);
		}
		
		void PesquisaRapida()
		{
			fPesquisaRapida frm = new fPesquisaRapida(fornecedor, tabela);
			frm.ShowDialog();
			if (frm.result)
			{
				edtProduto.Text = frm.codigo;
				edtSubCodigo.Text = frm.subcod;
				ckbGenerico.Checked = frm.generico;
				edtPrecoGenerico.Enabled = ckbGenerico.Checked;
			}
			edtMedidas.Focus();
		}
		
		void EdtProdutoEnter(object sender, EventArgs e)
		{
			if (edtProduto.Text.Trim().Length > 0) return;
			PesquisaRapida();
			/*			
			edtCodigoProduto.Text = "";
			edtDescricaoProduto.Text = "";
			gbxPesquisa.Visible = true;			
			edtDescricaoProduto.Focus();
			//dgvProdutos.Sort(dgvProdutos.Columns[2], System.ComponentModel.ListSortDirection.Ascending);
			if (ProcuraProduto(edtProduto.Text.Trim(), 0) >= 0)
			{
				int i = dgvProdutos.CurrentRow.Index;
				edtDescricaoProduto.Text = dgvProdutos.Rows[i].Cells["Descrição"].Value.ToString().Trim();
			}
			else edtDescricaoProduto.Text = "";
			*/
			//lblProduto.Text = "Descrição";
			//int i = dgvProdutos.CurrentRow.Index;
			//edtProduto.Text = dgvProdutos.Rows[i].Cells["Descrição"].Value.ToString().Trim();
		}
		
		void EdtProdutoLeave(object sender, EventArgs e)
		{
			//dgvProdutos.Visible = false;
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
			//if (!item_especial || pedido)
			if (!item_especial)
			{
				Globais.MostraFormula(ref preco, formula, ipi, 0, 0, tab);
			}
			else
			{
				preco = preco_unitario;
				tab.Rows.Add(new object[] {"Especial", preco});								
			}
			//preco += (preco * ipi / 100F);
			//tab.Rows.Add(new object[] {"IPI +"+ipi.ToString("#0")+"%", preco});
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
		
		void EdtPrecoFormulaTextChanged(object sender, EventArgs e)
		{
			CalculaPreco();
		}
		
		void BtnDuplicaClick(object sender, EventArgs e)
		{
			if (dgvCadastro.Rows.Count == 0) return;
			fEntradaItem frm = new fEntradaItem();
			frm.Text = "Entre com o código da nova área";
			frm.lblItem.Text = "Nova Área";
			frm.edtItem.CharacterCasing = CharacterCasing.Upper;
			frm.ShowDialog();
			cOrcamentos o = new cOrcamentos();
			o.Duplica(fornecedor, data, cod_orcamento, edtArea.Text.Trim(), frm.edtItem.Text);
			o.CarregaItens(dgvCadastro, fornecedor, data, cod_orcamento, formula, tabela);
			Colore();			
			if (dgvCadastro.Rows.Count > 0)
				AtualizaDadosLocal(0);
			Posiciona(edtArea.Text, edtCodigo.Text, edtSubCodigo.Text);			
		}
		
		void BtnQrcodeClick(object sender, EventArgs e)
		{
			string url = "https://chart.googleapis.com/chart?chs=150x150&cht=qr&chl=http://softplacemoveis.dyndns.org:8080/softws/softws/item/"
				+ fornecedor.Trim() + "/" + data.ToString("yyyy-MM-dd") + "/" + cod_orcamento.ToString() + "/" + edtArea.Text.Trim() + "/" + edtDescricao.Text.Trim();
			System.Diagnostics.Process.Start(TiraAcentosUrl(url));
		}
		
		string TiraAcentosUrl(string s)
		{
			return s.Replace("Ç", "%c3%87")
				.Replace("Á", "%c3%81")
				.Replace("É", "%c3%89")
				.Replace("Í", "%c3%8d")
				.Replace("Ó", "%c3%93")
				.Replace("Ú", "%c3%9a")
				.Replace("Â", "%c3%82")
				.Replace("Ê", "%c3%8a")
				.Replace("Ô", "%c3%94")
				.Replace("À", "%c3%80")
				.Replace("Ã", "%c3%83");
		}
		
		private void Colore()
		{
			foreach (DataGridViewRow row in dgvCadastro.Rows)
			{
				float preco_tabela = Globais.StrToFloat(row.Cells["Preço Tabela"].Value.ToString());
				float preco_atual_tabela = Globais.StrToFloat(row.Cells["Preço Atual Tabela"].Value.ToString());
				DataGridViewCell cellPreco = row.Cells["Preço"];
				DataGridViewCell cellProduto = row.Cells["Produto"];
				cellPreco.Style.BackColor = cellProduto.Style.BackColor;
				cellPreco.Style.SelectionBackColor = cellProduto.Style.SelectionBackColor;
				if (preco_tabela != preco_atual_tabela)
				{
					cellPreco.Style.BackColor = Color.Orange;
					cellPreco.Style.SelectionBackColor = Color.Orange;
				}
			}
		}
		
		void EdtPrecoGenericoTextChanged(object sender, EventArgs e)
		{
			
		}
		void EdtPrecoGenericoLeave(object sender, EventArgs e)
		{
			CalculaPreco();
		}
	}
}
