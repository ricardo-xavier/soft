/*
 * Projeto  : SoftPlace
 * Sistema  : CPD
 * Programa : fCadCaracteristicas - Cadastro de Caracteristicas de Vendas
 * Autor    : Ricardo Costa Xavier
 * Data     : 30/05/08
 * Alterações:
 * 30/01/10 - reposicionamento e manutenção da ordenação
 *            melhoria das mensagens de erro
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using templates;
using classes;

namespace basico
{
	public partial class frmCadCaracteristicas : tCadastroSimples
	{
		private cCaracteristicas caracteristicas;
		private string col_sorted;
		private SortOrder ord_sorted;		
		private string parceiro_sel;
		private string codigo_sel;
		private int primeira;
		
		void AlteraComponentes()
		{
			edtParceiro.CharacterCasing = CharacterCasing.Upper;			
			edtCodigo.CharacterCasing = CharacterCasing.Upper;
			dgvCadastro.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCadastroRowEnter);
			dgvCadastro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCadastroCellClick);
			dgvCadastro.Width += 420;
			dgvCadastro.Height += 44;
			primeira = 0;
		}
		
		void InicializaCampos()
		{
			edtParceiro.Text = "";			
			edtCodigo.Text = "";
			edtDescricao.Text = "";
			edtFormulaPedido.Text = "";
			edtConsultor.Text = "0,00";
			edtVendedor.Text = "0,00";
			edtFilial.Text = "0,00";
			edtLimiar.Text = "0,00";
			edtObservacao.Text = "";
			edtRacional.Text = "";
			edtServico.Text = "";
			edtDias.Text = "0";
			edtFrete.Text = "0,00";
			chkIPI.Checked = true;			
			chkAtivo.Checked = true;
			edtVendedorProdutos.Text = "";
			edtVendedorServicos.Text = "";
			edtConsultorProdutos.Text = "";
			edtConsultorServicos.Text = "";
			edtFilialProdutos.Text = "";
			edtFilialServicos.Text = "";
		}				
		
		public void SetaEdicaoLocal(bool enabled)
		{
			btnCopia.Enabled = !enabled;
			btnComissoes.Enabled = !enabled;
			edtParceiro.Enabled = enabled;			
			btnFornecedor.Enabled = enabled;						
			edtCodigo.Enabled = enabled;
			edtDescricao.Enabled = enabled;
			edtFormulaPedido.Enabled = enabled;
			edtConsultor.Enabled = enabled;
			edtVendedor.Enabled = enabled;			
			edtFilial.Enabled = enabled;			
			edtLimiar.Enabled = enabled;
			edtObservacao.Enabled = enabled;
			edtRacional.Enabled = enabled;
			edtServico.Enabled = enabled;
			edtDias.Enabled = enabled;
			edtFrete.Enabled = enabled;
			chkIPI.Enabled = enabled;			
			chkAtivo.Enabled = enabled;
			edtVendedorProdutos.Enabled = enabled;
			edtVendedorServicos.Enabled = enabled;
			edtConsultorProdutos.Enabled = enabled;
			edtConsultorServicos.Enabled = enabled;
			edtFilialProdutos.Enabled = enabled;
			edtFilialServicos.Enabled = enabled;
			cbxIntroducoes.Enabled = enabled;
			cbxInformacoesFornecimento.Enabled = enabled;
			cbxTermosGarantia.Enabled = enabled;
			cbxCondicoesMontagem.Enabled = enabled;
			cbxTermosAprovacao.Enabled = enabled;
		}
		
		public void AtualizaDadosLocal(int i)
		{
			float valor;
			edtParceiro.Text = dgvCadastro.Rows[i].Cells[0].Value.ToString().Trim();			
			edtCodigo.Text = dgvCadastro.Rows[i].Cells[1].Value.ToString().Trim();			
			edtDescricao.Text = dgvCadastro.Rows[i].Cells[2].Value.ToString().Trim();
			edtFormulaPedido.Text = dgvCadastro.Rows[i].Cells[3].Value.ToString().Trim();
			valor = Globais.StrToFloat(dgvCadastro.Rows[i].Cells[4].Value.ToString().Trim());
			edtConsultor.Text = valor.ToString("#0.00");
			valor = Globais.StrToFloat(dgvCadastro.Rows[i].Cells[5].Value.ToString().Trim());
			edtVendedor.Text = valor.ToString("#0.00");
			valor = Globais.StrToFloat(dgvCadastro.Rows[i].Cells[6].Value.ToString().Trim());
			edtLimiar.Text = valor.ToString("#0.00");
			edtObservacao.Text = dgvCadastro.Rows[i].Cells[7].Value.ToString().Trim();
			edtRacional.Text = dgvCadastro.Rows[i].Cells[8].Value.ToString().Trim();
			edtServico.Text = dgvCadastro.Rows[i].Cells[9].Value.ToString().Trim();
			chkAtivo.Checked = (dgvCadastro.Rows[i].Cells[10].Value.ToString().CompareTo("S") == 0);
			edtDias.Text = dgvCadastro.Rows[i].Cells[11].Value.ToString().Trim();						
			edtVendedorProdutos.Text = dgvCadastro.Rows[i].Cells[12].Value.ToString().Trim();
			edtVendedorServicos.Text = dgvCadastro.Rows[i].Cells[13].Value.ToString().Trim();
			edtConsultorProdutos.Text = dgvCadastro.Rows[i].Cells[14].Value.ToString().Trim();
			edtConsultorServicos.Text = dgvCadastro.Rows[i].Cells[15].Value.ToString().Trim();
			edtFilialProdutos.Text = dgvCadastro.Rows[i].Cells[16].Value.ToString().Trim();
			edtFilialServicos.Text = dgvCadastro.Rows[i].Cells[17].Value.ToString().Trim();
			valor = Globais.StrToFloat(dgvCadastro.Rows[i].Cells[18].Value.ToString().Trim());
			edtFilial.Text = valor.ToString("#0.00");
			valor = Globais.StrToFloat(dgvCadastro.Rows[i].Cells[19].Value.ToString().Trim());
			edtFrete.Text = valor.ToString("#0.00");			
			cbxIntroducoes.Text = dgvCadastro.Rows[i].Cells["Introdução"].Value.ToString().Trim();
			cbxInformacoesFornecimento.Text = dgvCadastro.Rows[i].Cells["Informação Fornecimento"].Value.ToString().Trim();
			cbxTermosGarantia.Text = dgvCadastro.Rows[i].Cells["Termo Garantia"].Value.ToString().Trim();
			cbxCondicoesMontagem.Text = dgvCadastro.Rows[i].Cells["Condição Montagem"].Value.ToString().Trim();			
			cbxTermosAprovacao.Text = dgvCadastro.Rows[i].Cells["Termo Aprovação"].Value.ToString().Trim();
			chkIPI.Checked = (dgvCadastro.Rows[i].Cells["Imprime IPI"].Value.ToString().CompareTo("S") == 0);						
		}
		
		public frmCadCaracteristicas()
		{
			InitializeComponent();
			AlteraComponentes();				
			this.dgvCadastro.Sorted += new System.EventHandler(this.DgvCadastroSorted);
			col_sorted = "";
			ord_sorted = SortOrder.Ascending;			
		}
					
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			string msg="";
			bool result;
			string parceiro = edtParceiro.Text.Trim();
			string codigo = edtCodigo.Text.Trim();
			if (edtParceiro.Text.Trim().CompareTo("") != 0)
			{
				cParceiros parceiros = new cParceiros();
				string des="", fisjur="";
				if (!parceiros.Procura(edtParceiro.Text, ref des, ref fisjur))
				{
					MessageBox.Show(edtParceiro.Text, "Parceiro não Cadastrado", 
				                	MessageBoxButtons.OK, 
				                	MessageBoxIcon.Warning);
					edtParceiro.Focus();
					return;				
				}
			}
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
			string imprime_ipi = chkIPI.Checked ? "S" : "N";
			string ativo = chkAtivo.Checked ? "S" : "N";
			if (acao == 'i')
				result = caracteristicas.Inclui(parceiro, codigo, edtDescricao.Text, edtFormulaPedido.Text, Globais.StrToFloat(edtConsultor.Text), Globais.StrToFloat(edtVendedor.Text),  Globais.StrToFloat(edtFilial.Text), Globais.StrToFloat(edtLimiar.Text), edtObservacao.Text, edtRacional.Text, edtServico.Text, ativo, Globais.StrToShort(edtDias.Text), 
								edtVendedorProdutos.Text,
								edtVendedorServicos.Text,
								edtConsultorProdutos.Text,
								edtConsultorServicos.Text,
								edtFilialProdutos.Text,
								edtFilialServicos.Text,
								Globais.StrToFloat(edtFrete.Text),
								cbxIntroducoes.Text,			
								cbxInformacoesFornecimento.Text,								
								cbxTermosGarantia.Text,
								cbxCondicoesMontagem.Text,																
								cbxTermosAprovacao.Text,
								imprime_ipi,
								ref msg);
			else
				result = caracteristicas.Altera(parceiro, codigo, edtDescricao.Text, edtFormulaPedido.Text, Globais.StrToFloat(edtConsultor.Text), Globais.StrToFloat(edtVendedor.Text),  Globais.StrToFloat(edtFilial.Text), Globais.StrToFloat(edtLimiar.Text), edtObservacao.Text, edtRacional.Text, edtServico.Text, ativo, Globais.StrToShort(edtDias.Text),
								edtVendedorProdutos.Text,
								edtVendedorServicos.Text,
								edtConsultorProdutos.Text,
								edtConsultorServicos.Text,
								edtFilialProdutos.Text,
								edtFilialServicos.Text,
								Globais.StrToFloat(edtFrete.Text),
								cbxIntroducoes.Text,			
								cbxInformacoesFornecimento.Text,								
								cbxTermosGarantia.Text,
								cbxCondicoesMontagem.Text,																
								cbxTermosAprovacao.Text,
								imprime_ipi,
								ref msg);
			if (!result)
			{
				if (acao == 'i')
					MessageBox.Show(parceiro + "-" + codigo + "\r\n" + msg, "Erro na inclusão da característica", MessageBoxButtons.OK, MessageBoxIcon.Error);
				else
					MessageBox.Show(parceiro + "-" + codigo + "\r\n" + msg, "Erro na alteração da característica", MessageBoxButtons.OK, MessageBoxIcon.Error);				
			}
			primeira = dgvCadastro.FirstDisplayedScrollingRowIndex;			
			this.Cursor = Cursors.WaitCursor;
			caracteristicas.Carrega(dgvCadastro, chkFiltroAtivos.Checked);
			this.Cursor = Cursors.Default;
			Sort(col_sorted, ord_sorted);
			int selecionado = Posiciona(parceiro.Trim(), codigo.Trim());
			if (selecionado >= 0)
			{
				AtualizaDados(selecionado);
				AtualizaDadosLocal(selecionado);				
			}
			if (primeira != -1) 
				dgvCadastro.FirstDisplayedScrollingRowIndex = primeira;
			DesabilitaEdicao();
			SetaEdicaoLocal(false);			
		}
		
		void BtnExcluiClick(object sender, EventArgs e)
		{
			string msg="";
			bool result;
			if (acao == 'c') return;
			string parceiro = edtParceiro.Text.Trim();
			string codigo = edtCodigo.Text.Trim();
			result = caracteristicas.Exclui(parceiro, codigo, ref msg);
			if (!result)
			{
				MessageBox.Show(parceiro + "-" + codigo + "\r\n" + Globais.ErroExclusao("Característica encontrada", msg), "Erro na exclusão da característica", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			this.Cursor = Cursors.WaitCursor;
			caracteristicas.Carrega(dgvCadastro, chkFiltroAtivos.Checked);
			this.Cursor = Cursors.Default;
			Sort(col_sorted, ord_sorted);
			if (dgvCadastro.Rows.Count == 0)
			{
				InicializaCampos();
			}
		}
		
		void FrmCadCaracteristicasLoad(object sender, EventArgs e)
		{
			caracteristicas = new cCaracteristicas();
			this.Cursor = Cursors.WaitCursor;
			caracteristicas.Carrega(dgvCadastro, chkFiltroAtivos.Checked);

			cIntroducoes introducoes = new cIntroducoes();
			introducoes.Carrega(cbxIntroducoes);

			cInformacoesFornecimento informacoes = new cInformacoesFornecimento();
			informacoes.Carrega(cbxInformacoesFornecimento);			
			
			cTermosAprovacao termos_aprovacao = new cTermosAprovacao();
			termos_aprovacao.Carrega(cbxTermosAprovacao);

			cCondicoesMontagem condicoes = new cCondicoesMontagem();
			condicoes.Carrega(cbxCondicoesMontagem);						
			
			cTermosGarantia termos_garantia = new cTermosGarantia();
			termos_garantia.Carrega(cbxTermosGarantia);			
								
			this.Cursor = Cursors.Default;
			SetaEdicaoLocal(false);					
		}
		
		void DgvCadastroRowEnter(object sender, DataGridViewCellEventArgs e)
		{
			AtualizaDadosLocal(e.RowIndex);
		}		
		
		void DgvCadastroCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex == -1) return;
			int i = e.RowIndex;
			parceiro_sel = dgvCadastro.Rows[i].Cells["Fornecedor"].Value.ToString().Trim();
			codigo_sel = dgvCadastro.Rows[i].Cells["Código"].Value.ToString().Trim();
		}		
		
		void BtnIncluiClick(object sender, EventArgs e)
		{
			SetaEdicaoLocal(true);
			InicializaCampos();
			edtParceiro.Focus();
		}
		
		private int Posiciona(string parceiro, string codigo)
		{
			for (int i=0; i<dgvCadastro.Rows.Count; i++)
			{
				dgvCadastro.Rows[i].Selected = true;					
				string _parceiro = dgvCadastro.Rows[i].Cells[0].Value.ToString().Trim();
				string _codigo = dgvCadastro.Rows[i].Cells[1].Value.ToString().Trim();
				if (_parceiro.Equals(parceiro) && _codigo.Equals(codigo))
				{
					dgvCadastro.Rows[i].Cells[0].Selected = true;					
					return i;
				}
			}
			return -1;
		}
		
		void BtnAlteraClick(object sender, EventArgs e)
		{
			if (acao == 'c') return;
			SetaEdicaoLocal(true);
			edtParceiro.Enabled = false;
			//Posiciona(edtParceiro.Text, edtCodigo.Text);
		}
		
		void BtnParceirosClick(object sender, EventArgs e)
		{
			cControleAcesso acesso = new cControleAcesso();
			if (!acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fConParceiros")) return;				
			frmConParceiros frm = new frmConParceiros();
			frm.ShowDialog();
			if (frm.cancela) return;
				
			frmCadParceiros frmCad = new frmCadParceiros(true);
			frmCad.where = frm.filtro;
			frmCad.ReadOnly = !acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fCadParceiros");
			frmCad.ShowDialog();
			edtParceiro.Text = frmCad.edtCodigo.Text;
			edtParceiro.Focus();
		}
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			SetaEdicaoLocal(false);
		}
		
		void EdtConsultorKeyPress(object sender, KeyPressEventArgs e)
		{
			TextBox edt = (TextBox)sender;
			if ((e.KeyChar == ',') && !edt.Text.Contains(","))
			{
				e.Handled = false;
				return;
			}
			if (e.KeyChar > 31 && (e.KeyChar < '0' || e.KeyChar > '9'))
			{
				e.Handled = true;
				return;
			}
		}
		
		void BtnComissoesClick(object sender, EventArgs e)
		{
			if (dgvCadastro.Rows.Count == 0) return;
			string parceiro = edtParceiro.Text.Trim();
			string codigo = edtCodigo.Text.Trim();
			fComissaoLimiar comissao = new fComissaoLimiar(parceiro, codigo);
			comissao.ShowDialog();
			/*
			int selecionado = Posiciona(edtParceiro.Text.Trim(), edtCodigo.Text.Trim());
			if (selecionado >= 0)
			{
				AtualizaDados(selecionado);
				AtualizaDadosLocal(selecionado);				
			}
			*/
		}
		
		void EdtCopiaClick(object sender, EventArgs e)
		{
			if (dgvCadastro.Rows.Count == 0) return;			
			string parceiro = edtParceiro.Text.Trim();
			string codigo = edtCodigo.Text.Trim();
			string ativo = chkAtivo.Checked ? "S" : "N";
			string imprime_ipi = chkIPI.Checked ? "S" : "N";
			fCodigoCopia frm = new fCodigoCopia(parceiro, codigo, edtDescricao.Text, edtFormulaPedido.Text, Globais.StrToFloat(edtConsultor.Text), Globais.StrToFloat(edtVendedor.Text),  Globais.StrToFloat(edtFilial.Text), Globais.StrToFloat(edtLimiar.Text), edtObservacao.Text, edtRacional.Text, edtServico.Text, ativo, Globais.StrToShort(edtDias.Text),
								edtVendedorProdutos.Text,
								edtVendedorServicos.Text,
								edtConsultorProdutos.Text,
								edtConsultorServicos.Text,
								edtFilialProdutos.Text,
								edtFilialServicos.Text,
								Globais.StrToFloat(edtFrete.Text),
								cbxIntroducoes.Text,			
								cbxInformacoesFornecimento.Text,								
								cbxTermosGarantia.Text,
								cbxCondicoesMontagem.Text,																
								cbxTermosAprovacao.Text,
								imprime_ipi
							);
			frm.ShowDialog();
			this.Cursor = Cursors.WaitCursor;
			caracteristicas.Carrega(dgvCadastro, chkFiltroAtivos.Checked);
			this.Cursor = Cursors.Default;
			Sort(col_sorted, ord_sorted);
			codigo_sel = frm.novo_codigo;
			int selecionado = Posiciona(parceiro, frm.novo_codigo);
			if (selecionado >= 0)
			{
				AtualizaDados(selecionado);
				AtualizaDadosLocal(selecionado);				
			}
		}
		
		void EdtObservacaoDoubleClick(object sender, EventArgs e)
		{
			frmEditaMemo frm = new frmEditaMemo();
			frm.Text = "Observação";
			frm.edtMemo.Text = edtObservacao.Text;
			frm.ShowDialog();
			if (frm.ok)
			{
				edtObservacao.Text = frm.edtMemo.Text;
			}
		}
		
		void EdtRacionalDoubleClick(object sender, EventArgs e)
		{
			frmEditaMemo frm = new frmEditaMemo();
			frm.Text = "Racional";
			frm.edtMemo.Text = edtRacional.Text;
			frm.ShowDialog();
			if (frm.ok)
			{
				edtRacional.Text = frm.edtMemo.Text;
			}
		}
		
		void ChkFiltroAtivoCheckedChanged(object sender, EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			caracteristicas.Carrega(dgvCadastro, chkFiltroAtivos.Checked);			
			this.Cursor = Cursors.Default;
		}
		
		void BtnFornecedorClick(object sender, EventArgs e)
		{
			cControleAcesso acesso = new cControleAcesso();
			frmCadParceiros frmCad = new frmCadParceiros(true);
			frmCad.where = "";
			frmCad.ReadOnly = !acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fCadParceiros");
			frmCad.ShowDialog();
			edtParceiro.Text = frmCad.edtCodigo.Text;
			edtParceiro.Focus();
			
		}
		
		void EdtServicoDoubleClick(object sender, EventArgs e)
		{
			frmEditaMemo frm = new frmEditaMemo();
			frm.Text = "Serviço";
			frm.edtMemo.Text = edtRacional.Text;
			frm.ShowDialog();
			if (frm.ok)
			{
				edtServico.Text = frm.edtMemo.Text;
			}
		}
		
		void DgvCadastroSorted(object sender, EventArgs e)
		{
			col_sorted = dgvCadastro.SortedColumn.HeaderText;
			ord_sorted = dgvCadastro.SortOrder;
			Posiciona(parceiro_sel, codigo_sel);
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
