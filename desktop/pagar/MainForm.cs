/*
/*
 * Projeto  : SoftPlace
 * Sistema  : Contas a Pagar
 * Programa : MainForm - Form Principal
 * Autor    : Ricardo Costa Xavier
 * Data     : 20/07/08
 * 
 * Histórico:
 * 19/06/2013 - se vier pedido no main, carregar somente os registros do pedido
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using templates;
using classes;
using basico;

namespace pagar
{
	public partial class MainForm : tMenu
	{
		private cTitulosPagar titulos;
		private string where;
		private bool bShow;
		private int selecionado;
		private char dir;
		private string titulo_pedido;
		private string col_sorted;
		private SortOrder ord_sorted;				
		
		[STAThread]
		public static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new MainForm(args));
		}
		
		public MainForm(string[] args)
		{
			int len = args.Length;
			InitializeComponent();
			if (args.Length > 3)
				titulo_pedido = args[3];//int.Parse(args[3]);
			else
				titulo_pedido = "";
			if (args.Length > 0) 
			{
				login = false;
				Globais.sUsuario = args[0];
				Globais.sFilial = args[1];
				Globais.bAdministrador = args[2][0] == 'S';
			}
			else login = true;
			dgvCadastro.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCadastroRowEnter);
			selecionado = 0;
			dir = 'd';
		}
		
		void MniSairClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void MniSobreClick(object sender, EventArgs e)
		{
			fSobre frm = new fSobre();
			frm.ShowDialog();
		}
		
		void SairToolStripMenuItemClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void SobreToolStripMenuItemClick(object sender, EventArgs e)
		{
			fSobre frm = new fSobre();
			frm.ShowDialog();
		}
		
		void MniNaturezasClick(object sender, EventArgs e)
		{
			fCadNaturezas frm = new fCadNaturezas(false);
			frm.ShowDialog();
		}
		
		void FormasToolStripMenuItemClick(object sender, EventArgs e)
		{
			fCadFormas frm = new fCadFormas(false);
			frm.ShowDialog();
		}
		
		void MontaWhere()
		{
			//string s = Globais.sUsuario;
			//if (s.Trim().Length == 0) return;
			where="";
			string data = DateTime.Today.ToString("M/d/yyyy");
			if (cbxFiltroSituacao.Text.Trim().CompareTo("Pagos") == 0)
				where = "where (a.DAT_PAGAMENTO is not null";
			if (cbxFiltroSituacao.Text.Trim().CompareTo("Abertos") == 0)
				where = "where (a.DAT_PAGAMENTO is null";
			if (cbxFiltroSituacao.Text.Trim().CompareTo("Atrasados") == 0)
				where = "where ((a.DAT_PAGAMENTO is null) and (a.DAT_VENCIMENTO < '" + data + "')";
			bool todas = clbFiltroNaturezas.Items.Count == clbFiltroNaturezas.CheckedIndices.Count;
			if (!todas)
			{
				if (where.Length > 0)
					where += " and a.COD_NATUREZA in (";
				else
					where = "where (a.COD_NATUREZA in (";				
				bool primeira=true;
				foreach (int i in clbFiltroNaturezas.CheckedIndices)
				{
					if (!primeira) 
					{
						where = where + ",";
					}
					else
					{
						primeira = false;
					}
					string natureza = cbxCodNaturezas.Items[i].ToString();
					where = where + "'" + natureza + "'";
				}				
				where = where + ")";
			}
			/*
			if (cbxFiltroNaturezas.Text.Trim().CompareTo("Todas") != 0)	
			{
				if (where.Length > 0)
					where += " and a.COD_NATUREZA='";
				else
					where = "where a.COD_NATUREZA='";
				int n = cbxFiltroNaturezas.SelectedIndex;
				where += cbxCodNaturezas.Items[n].ToString() + "'";
			}
			*/
			if (!cbxFiltroFormas.Text.Trim().Equals("Todas") && !cbxFiltroFormas.Text.Trim().Equals(""))	
			{
				if (where.Length > 0)
					where += " and a.COD_FORMA='";
				else
					where = "where (a.COD_FORMA='";
				int f = cbxFiltroFormas.SelectedIndex;
				where += cbxCodFormas.Items[f].ToString() + "'";
			}
			if (!cbxFiltroPendencias.Text.Trim().Equals("Todas") && !cbxFiltroPendencias.Text.Trim().Equals(""))	
			{
				if (where.Length > 0)
					where += " and a.COD_PENDENCIA='";
				else
					where = "where (a.COD_PENDENCIA='";
				int f = cbxFiltroPendencias.SelectedIndex;
				where += cbxCodPendencias.Items[f].ToString() + "'";
			}
			if (!cbxFiltroTipos.Text.Trim().Equals("Todos"))	
			{
				if (where.Length > 0)
					where += " and a.IDT_TIPO='";
				else
					where = "where (a.IDT_TIPO='";
				if (cbxFiltroTipos.Text.Length > 0)
					where += cbxFiltroTipos.Text[0] + "'";
			}
			if (edtParceiro.Text.Trim().Length > 0)
			{
				if (where.Length > 0)
					where += string.Format(" and ((a.COD_PARCEIRO='{0}') or (a.COD_FUNCIONARIO='{0}'))", edtParceiro.Text.Trim(), edtParceiro.Text.Trim());
				else
					where += string.Format("where (((a.COD_PARCEIRO='{0}') or (a.COD_FUNCIONARIO='{0}'))", edtParceiro.Text.Trim(), edtParceiro.Text.Trim());
			}
			if (dtpVencimentoI.Checked || dtpVencimentoF.Checked)
			{
				if (where.Length > 0)				
					where += " and ";
				else
					where = "where (";
				if (dtpVencimentoI.Checked && dtpVencimentoF.Checked)
				{
					string datai = "'" + dtpVencimentoI.Value.ToString("M/d/yyyy") + "'";
					string dataf = "'" + dtpVencimentoF.Value.ToString("M/d/yyyy") + "'";
					if (datai.CompareTo(dataf) == 0)
						where += "a.DAT_VENCIMENTO=" + datai;
					else
						where += "a.DAT_VENCIMENTO between " + datai + " and " + dataf;
				}
				else
				if (dtpVencimentoI.Checked)
				{
					string datai = "'" + dtpVencimentoI.Value.ToString("M/d/yyyy") + "'";
					where += "a.DAT_VENCIMENTO >= " + datai;
				}
				else
				{
					string dataf = "'" + dtpVencimentoF.Value.ToString("M/d/yyyy") + "'";
					where += "a.DAT_VENCIMENTO <= " + dataf;
				}
			}
			if (dtpPagamentoI.Checked || dtpPagamentoF.Checked)
			{
				if (where.Length > 0)				
					where += " and ";
				else
					where = "where (";
				if (dtpPagamentoI.Checked && dtpPagamentoF.Checked)
				{
					string datai = "'" + dtpPagamentoI.Value.ToString("M/d/yyyy") + "'";
					string dataf = "'" + dtpPagamentoF.Value.ToString("M/d/yyyy") + "'";
					if (datai.CompareTo(dataf) == 0)
						where += "a.DAT_PAGAMENTO=" + datai;
					else
						where += "a.DAT_PAGAMENTO between " + datai + " and " + dataf;
				}
				else
				if (dtpPagamentoI.Checked)
				{
					string datai = "'" + dtpPagamentoI.Value.ToString("M/d/yyyy") + "'";
					where += "a.DAT_PAGAMENTO >= " + datai;
				}
				else
				{
					string dataf = "'" + dtpPagamentoF.Value.ToString("M/d/yyyy") + "'";
					where += "a.DAT_PAGAMENTO <= " + dataf;
				}
			}
			if (dtpEmissaoI.Checked || dtpEmissaoF.Checked)
			{
				if (where.Length > 0)				
					where += " and ";
				else
					where = "where (";
				if (dtpEmissaoI.Checked && dtpEmissaoF.Checked)
				{
					string datai = "'" + dtpEmissaoI.Value.ToString("M/d/yyyy") + "'";
					string dataf = "'" + dtpEmissaoF.Value.ToString("M/d/yyyy") + "'";
					if (datai.CompareTo(dataf) == 0)
						where += "a.DAT_EMISSAO=" + datai;
					else
						where += "a.DAT_EMISSAO between " + datai + " and " + dataf;
				}
				else
				if (dtpEmissaoI.Checked)
				{
					string datai = "'" + dtpEmissaoI.Value.ToString("M/d/yyyy") + "'";
					where += "a.DAT_EMISSAO >= " + datai;
				}
				else
				{
					string dataf = "'" + dtpEmissaoF.Value.ToString("M/d/yyyy") + "'";
					where += "a.DAT_EMISSAO <= " + dataf;
				}
			}			
			if (where.Length > 0)
			{
				where = where + ")";
			}
			if (!titulo_pedido.Equals(""))
			{
				//if (where.Length > 0)
				//{
					//where = where + " or (";
				//}
				//else
				//{
					//where = "where (";
				//}
				where = "where COD_TITULO in (" + titulo_pedido + ")";
			}
		}	
			
		void CarregaTitulos()
		{
			MontaWhere();
			this.Cursor = Cursors.WaitCursor;
			titulos.Carrega(dgvCadastro, where);
			this.Cursor = Cursors.Default;
			Colore();
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			imgSoftplace.Visible = false;
			cbxFiltroSituacao.Items.Add("Pagos");
			cbxFiltroSituacao.Items.Add("Abertos");
			cbxFiltroSituacao.Items.Add("Atrasados");
			cbxFiltroSituacao.Items.Add("Todos");
			cbxFiltroSituacao.Text = "Abertos";
			bShow = true;
			
			cNaturezasPagamento naturezas = new cNaturezasPagamento();
			this.Cursor = Cursors.WaitCursor;
			naturezas.Carrega(cbxFiltroNaturezas, cbxCodNaturezas);
			foreach (string s in cbxFiltroNaturezas.Items)
				clbFiltroNaturezas.Items.Add(s, true);			
			this.Cursor = Cursors.Default;
			cbxFiltroNaturezas.Items.Add("Todas");
			cbxCodNaturezas.Items.Add("Todas");
			cbxFiltroNaturezas.Text = "Todas";			
			
			cFormas formas = new cFormas();
			this.Cursor = Cursors.WaitCursor;
			formas.Carrega(cbxFiltroFormas, cbxCodFormas);
			this.Cursor = Cursors.Default;
			cbxFiltroFormas.Items.Add("Todas");
			cbxCodFormas.Items.Add("Todas");
			cbxFiltroFormas.Text = "Todas";			
			
			cPendencias pendencias = new cPendencias();
			this.Cursor = Cursors.WaitCursor;
			pendencias.Carrega(cbxFiltroPendencias, cbxCodPendencias);
			this.Cursor = Cursors.Default;
			cbxFiltroPendencias.Items.Add("Todas");
			cbxCodPendencias.Items.Add("Todas");
			cbxFiltroPendencias.Text = "Todas";			
			
			cbxFiltroTipos.Items.Add("Todos");
			cbxFiltroTipos.Items.Add("Fixo");
			cbxFiltroTipos.Items.Add("Variável");
			cbxFiltroTipos.Items.Add("Semi-fixa");
			cbxFiltroTipos.Text = "Todos";			
			
			edtParceiro.Text = "";
			
			dtpVencimentoI.Value = DateTime.Now;
			dtpVencimentoF.Value = DateTime.Now;
			dtpPagamentoI.Value = DateTime.Now;
			dtpPagamentoF.Value = DateTime.Now;
			dtpEmissaoI.Value = DateTime.Now;
			dtpEmissaoF.Value = DateTime.Now;			
			dtpVencimentoI.Checked = false;
			dtpVencimentoF.Checked = false;
			dtpPagamentoI.Checked = false;
			dtpPagamentoF.Checked = false;
			dtpEmissaoI.Checked = false;
			dtpEmissaoF.Checked = false;			
			
			col_sorted = "";
			ord_sorted = SortOrder.Ascending;						
		}
		
		void BtnIncluiClick(object sender, EventArgs e)
		{
			fCadTitulo frm = new fCadTitulo('i', 0);
			frm.ShowDialog();
			if (frm.result)
			{
				CarregaTitulos();
				Grid.Sort(dgvCadastro, col_sorted, ord_sorted);									
				int i = dgvCadastro.Rows.Count- 1;
				if (i >= 0) dgvCadastro.Rows[i].Cells["Parceiro"].Selected = true;
			}
			
		}
		
		void BtnFechaClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void BtnExcluiClick(object sender, EventArgs e)
		{
			if (dgvCadastro.Rows.Count == 0) return;
			int i = dgvCadastro.CurrentRow.Index;						
			int codigo = Globais.StrToInt(dgvCadastro.Rows[i].Cells["Código"].Value.ToString());
			DialogResult r = MessageBox.Show(codigo.ToString(), "Confirma a exclusão?",
			                                 MessageBoxButtons.YesNo, 
			                                 MessageBoxIcon.Question);
			if (r == DialogResult.No) return;	
			string msg="";
			if (titulos.Exclui(codigo, ref msg))
			{
				CarregaTitulos();				
				Grid.Sort(dgvCadastro, col_sorted, ord_sorted);				
			}
		}
		
		void BtnAlteraClick(object sender, EventArgs e)
		{
			if (dgvCadastro.Rows.Count == 0) return;
			int i = dgvCadastro.CurrentRow.Index;						
			int codigo = Globais.StrToInt(dgvCadastro.Rows[i].Cells["Código"].Value.ToString());
			fCadTitulo frm = new fCadTitulo('a', codigo);
			frm.ShowDialog();
			if (frm.result)
			{
				CarregaTitulos();
				Grid.Sort(dgvCadastro, col_sorted, ord_sorted);								
				for (i=0; i<dgvCadastro.Rows.Count; i++)
				{
					int cod = Globais.StrToInt(dgvCadastro.Rows[i].Cells["Código"].Value.ToString());
					if (cod == codigo)
					{
						dgvCadastro.Rows[i].Cells["Parceiro"].Selected = true;
						break;
					}
				}
			}
		}
		
		void Colore()
		{
			float total=0;
			float pago=0;
			int registros=0;
			string s;
			foreach (DataGridViewRow row in  dgvCadastro.Rows)
			{
				registros++;
				if (row.Cells["Valor"].Value != null)
				{
					s = row.Cells["Valor"].Value.ToString().Trim();
					total += Globais.StrToFloat(s);
				}
				if (row.Cells["Pago"].Value != null)
				{
					s = row.Cells["Pago"].Value.ToString().Trim();
					pago += Globais.StrToFloat(s);
				}
				
				string funcionario = row.Cells["Funcionário"].Value.ToString().Trim();
				if (funcionario.Length > 0)
					row.Cells["Parceiro"].Value = funcionario;
					
				DataGridViewCell cell = row.Cells["Situação"];
				string pagamento = row.Cells["Pagamento"].Value.ToString().Trim();
				cell.Style.ForeColor = Color.Black;
				cell.Style.SelectionForeColor = Color.Black;
				if (pagamento.CompareTo("") == 0)
				{
					DateTime vencimento = DateTime.Parse(row.Cells["Vencimento"].Value.ToString());
					if (vencimento.Date < DateTime.Today.Date) 
					{
						cell.Style.BackColor = Color.Red;
						cell.Style.SelectionBackColor = Color.Red;
						cell.Value = "Atrasado";
					}
					else
					if (vencimento.Date > DateTime.Today.Date) 
					{
						cell.Style.BackColor = Color.Green;
						cell.Style.SelectionBackColor = Color.Green;
						cell.Value = "Aberto";
					}
					else
					{
						cell.Style.BackColor = Color.Yellow;
						cell.Style.SelectionBackColor = Color.Yellow;
						cell.Value = "Hoje";
					}
				}
				else 
				{
					cell.Style.BackColor = Color.White;
					cell.Style.SelectionBackColor = Color.White;
					cell.Value = "Pago";
				}
			}			
			float pagar = total - pago;
			edtTotal.Text = total.ToString("#,###,##0.00");
			edtTotalPago.Text = pago.ToString("#,###,##0.00");		
			edtTotalPagar.Text = pagar.ToString("#,###,##0.00");						
			edtRegistros.Text = registros.ToString();
		}
		
		void BtnAplicaClick(object sender, EventArgs e)
		{
			titulo_pedido = "";
			CarregaTitulos();
		}
		
		void BtnParceiroClick(object sender, EventArgs e)
		{
			cControleAcesso acesso = new cControleAcesso();			
			frmCadParceiros frmCad = new frmCadParceiros(true);
			frmCad.where = "";
			frmCad.codigo = edtParceiro.Text;
			frmCad.ReadOnly = !acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fCadParceiros");
			frmCad.ShowDialog();
			if (frmCad.result)
			{
				edtParceiro.Text = frmCad.edtCodigo.Text;
			}
			edtParceiro.Focus();
		}
		
		void BtnLimpaClick(object sender, EventArgs e)
		{
			for (int i=0; i<clbFiltroNaturezas.Items.Count; i++)
			{
				clbFiltroNaturezas.SetItemChecked(i, true);
			}			
			cbxFiltroSituacao.Text = "Todas";
			cbxFiltroNaturezas.Text = "Todas";
			cbxFiltroFormas.Text = "Todas";
			cbxFiltroPendencias.Text = "Todas";
			cbxFiltroTipos.Text = "Todos";
			edtParceiro.Text = "";
			dtpVencimentoI.Value = DateTime.Now;
			dtpVencimentoF.Value = DateTime.Now;
			dtpPagamentoI.Value = DateTime.Now;
			dtpPagamentoF.Value = DateTime.Now;
			dtpEmissaoI.Value = DateTime.Now;
			dtpEmissaoF.Value = DateTime.Now;			
			dtpVencimentoI.Checked = false;
			dtpVencimentoF.Checked = false;
			dtpPagamentoI.Checked = false;
			dtpPagamentoF.Checked = false;
			dtpEmissaoI.Checked = false;
			dtpEmissaoF.Checked = false;			
			CarregaTitulos();
			Grid.Sort(dgvCadastro, col_sorted, ord_sorted);							
		}
		
		void MniGraficoNaturezaClick(object sender, EventArgs e)
		{
			fGraficoNatureza frm = new fGraficoNatureza('p');
			frm.ShowDialog();
		}
		
		void MniPendenciasClick(object sender, EventArgs e)
		{
			fCadPendencias frm = new fCadPendencias(false);
			frm.ShowDialog();
		}
		
		void DgvCadastroRowEnter(object sender, DataGridViewCellEventArgs e)
		{
			edtObservacao.Text = dgvCadastro.Rows[e.RowIndex].Cells["Observação"].Value.ToString();	
			edtForma.Text = dgvCadastro.Rows[e.RowIndex].Cells["Forma"].Value.ToString();	
			edtDocGerado.Text = dgvCadastro.Rows[e.RowIndex].Cells["Doc Gerado"].Value.ToString();	
			if (dgvCadastro.Rows[e.RowIndex].Cells["Tipo"].Value.ToString().Trim().CompareTo("F") == 0)
				edtFixoVariavel.Text = "FIXO";
			if (dgvCadastro.Rows[e.RowIndex].Cells["Tipo"].Value.ToString().Trim().CompareTo("V") == 0)
				edtFixoVariavel.Text = "VARIÁVEL";
			if (dgvCadastro.Rows[e.RowIndex].Cells["Tipo"].Value.ToString().Trim().CompareTo("S") == 0)
				edtFixoVariavel.Text = "SEMI-FIXA";			
			string funcionario = dgvCadastro.Rows[e.RowIndex].Cells["Funcionário"].Value.ToString().Trim();
			if (funcionario.Length > 0)
				dgvCadastro.Columns[1].HeaderText = "Funcionário";
			else
				dgvCadastro.Columns[1].HeaderText = "Parceiro";
		}
		
		void BtnImprimeClick(object sender, EventArgs e)
		{
			fSelecaoQuebra frmq = new fSelecaoQuebra();
			frmq.ShowDialog();
			if (frmq.quebra == 'c') return;
			fEntradaItem frm = new fEntradaItem();
			frm.Text = "Entre com o título do relatório";
			frm.lblItem.Text = "Título";
			frm.ShowDialog();
			//string pdf = "c:\\softplace\\pagar.pdf";
			string pdf = "pagar.pdf";
			if (titulos.Gera(where, pdf, frm.edtItem.Text, frmq.quebra))
				System.Diagnostics.Process.Start("explorer", pdf);
		}
		
		void BtnPagaClick(object sender, EventArgs e)
		{
			DialogResult r = MessageBox.Show("Confirma o pagamento de todos os títulos selecionados?", "",
			                                 MessageBoxButtons.YesNo, 
			                                 MessageBoxIcon.Question);
			if (r == DialogResult.No) return;	
			fPagamento frm = new fPagamento(where);
			frm.ShowDialog();
			if (frm.result)
			{
				CarregaTitulos();
				Grid.Sort(dgvCadastro, col_sorted, ord_sorted);								
			}
		}
		
		void MainFormShown(object sender, EventArgs e)
		{
			if (!bShow) return;
			cControleAcesso acesso = new cControleAcesso();
			if (!Globais.bAdministrador &&  !acesso.PermissaoSistema(Globais.sUsuario, Globais.sFilial, 5))
			{
				MessageBox.Show("Usuário sem permissão para esse Sistema", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Close();
			}
			bShow = false;
			titulos = new cTitulosPagar();
			CarregaTitulos();
			if (!titulo_pedido.Equals(""))
			{
				for (int i=0; i<dgvCadastro.Rows.Count; i++)
				{
					int t = int.Parse(dgvCadastro.Rows[i].Cells["Código"].Value.ToString());
					string[] titulos_pedido = titulo_pedido.Split(',');
					foreach (string titulo in titulos_pedido)
					{
						if (t == int.Parse(titulo))
						{
							dgvCadastro.Rows[i].Cells[0].Selected = true;
							dgvCadastro.CurrentCell = dgvCadastro.Rows[i].Cells[0];						
							break;
						}
					}
				}
			}
		}
		
		void MinTendenciaClick(object sender, EventArgs e)
		{
			fGraficoTendencia frm = new fGraficoTendencia('p');
			frm.ShowDialog();
		}
		
		public int ProcuraLinha(int i, string buf)
		{
			for (int j=0; j<dgvCadastro.Columns.Count; j++)
			{
				string s1 = dgvCadastro.Rows[i].Cells[j].Value.ToString().ToUpper().Trim();
				string s2 = buf.ToUpper().Trim();
				if (s2.CompareTo("*") == 0) return -1;
				string s3;
				if (s2.StartsWith("*")) 
				{
					if (s2.EndsWith("*")) // *XXXXX*
					{
						s3 = s2.Substring(1, s2.Length-2);
						if (s1.Contains(s3)) return i;
					}
					else // *XXXXX
					{
						s3 = s2.Substring(1, s2.Length-1);
						if (s1.EndsWith(s3)) return i;
					}
				}
				else 
				{
					if (s2.EndsWith("*")) // XXXXX*
					{
						s3 = s2.Substring(0, s2.Length-1);
						if (s1.StartsWith(s3)) return i;
					}
					else // XXXXX
					{
						if (s1.CompareTo(s2) == 0) return i;
					}
				}
			}
			return -1;
		}
		
		public int Procura(string buf)
		{
			int r=-1;
			if (selecionado > dgvCadastro.Rows.Count)
				selecionado = dgvCadastro.Rows.Count;
			if (dir == 'd')
			{
				for (int i=selecionado+1; i<dgvCadastro.Rows.Count; i++)
					if ((r = ProcuraLinha(i, buf)) >= 0) break;
			}
			else
			{
				for (int i=selecionado-1; i>=0; i--)
					if ((r = ProcuraLinha(i, buf)) >= 0) break;
			}
			return r;
		}
		
		void BtnLocalizaClick(object sender, EventArgs e)
		{
			selecionado = 0;
			dir = 'd';
			int i = Procura(edtLocaliza.Text);
			if (i >= 0)
			{
				dgvCadastro.Rows[i].Cells[1].Selected = true;
			}
		}
		
		void MniFixoVariavelClick(object sender, EventArgs e)
		{
			fGraficoFixoVariavel frm = new fGraficoFixoVariavel('p');
			frm.ShowDialog();
		}
		
		void EdtLocalizaTextChanged(object sender, EventArgs e)
		{
			selecionado = 0;
			dir = 'd';
			if (edtLocaliza.Text.Trim().Length == 0)
			{
				if (dgvCadastro.Rows.Count == 0) return;
				dgvCadastro.Rows[0].Cells[1].Selected = true;
				return;
			}
			int i=-1;
			if (edtLocaliza.Text.IndexOf('*') == -1)
				i = Procura(edtLocaliza.Text+"*");
			else
				i = Procura(edtLocaliza.Text);
			if (i >= 0)
			{
				int n = dgvCadastro.Rows.Count;
				for (int c=0; c<dgvCadastro.Rows[i].Cells.Count; c++)
				{
					if (dgvCadastro.Rows[i].Cells[c].Visible)
					{
						dgvCadastro.Rows[i].Cells[c].Selected = true;
						break;
					}
				}
			}
		}
		
		void BtnDownClick(object sender, EventArgs e)
		{
			if (dgvCadastro.Rows.Count == 0) return;
			selecionado = dgvCadastro.CurrentRow.Index;						
			dir = 'd';
			int i=-1;
			if (edtLocaliza.Text.IndexOf('*') == -1)
				i = Procura(edtLocaliza.Text+"*");
			else
				i = Procura(edtLocaliza.Text);
			if (i >= 0)
			{
				dgvCadastro.Rows[i].Cells[1].Selected = true;
			}
		}
		
		void BtnUpClick(object sender, EventArgs e)
		{
			if (dgvCadastro.Rows.Count == 0) return;
			selecionado = dgvCadastro.CurrentRow.Index;						
			dir = 's';
			int i=-1;
			if (edtLocaliza.Text.IndexOf('*') == -1)
				i = Procura(edtLocaliza.Text+"*");
			else
				i = Procura(edtLocaliza.Text);
			if (i >= 0)
			{
				dgvCadastro.Rows[i].Cells[1].Selected = true;
			}
		}
		
		void DgvCadastroSorted(object sender, EventArgs e)
		{
			col_sorted = dgvCadastro.SortedColumn.HeaderText;
			ord_sorted = dgvCadastro.SortOrder;			
			Colore();
		}
		
		void ChkTodasCheckedChanged(object sender, EventArgs e)
		{
			for (int i=0; i<clbFiltroNaturezas.Items.Count; i++)
			{
				clbFiltroNaturezas.SetItemChecked(i, chkTodas.Checked);
			}			
		}
	}
}
