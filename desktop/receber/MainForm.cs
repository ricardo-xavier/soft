/*
/*
 * Projeto  : SoftPlace
 * Sistema  : Faturamento
 * Programa : MainForm - Form Principal
 * Autor    : Ricardo Costa Xavier
 * Data     : 19/08/08
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using templates;
using classes;
using basico;

namespace receber
{
	public partial class MainForm : tMenu
	{
		private cTitulosXeceber titulos;
		private string where;
		private bool bShow;
		private int selecionado;
		private char dir;
		private string filtro_pedido;
		private string fornecedor;
		private DateTime data;
		private string orcamento;
		private string pedido;
		private string nro_pedido;
		public string nf;
		public short seq;
		public bool result;
		private string pedido_filtro;
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
			InitializeComponent();

			result = false;
			Text = Text + " " + args.Length;
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
			filtro_pedido = "";
			pedido_filtro = "";
			if (args.Length == 7)
			{
				fornecedor = args[3];
				data = DateTime.Parse(args[4]);
				orcamento = args[5];
				pedido = args[6];
				gbxFiltro.Enabled = false;
				filtro_pedido = "inner join pedidos_recebidos pr on pr.COD_FORNECEDOR = '" + fornecedor + "' and " +
					"pr.DAT_ORCAMENTO = '" + data.ToString("M/d/yyyy") + "' and " +
					"pr.COD_ORCAMENTO = " + orcamento + " and " +
					"pr.COD_PEDIDO = " + pedido + " and " +
					"pr.NRO_NF = a.NRO_NF and pr.SEQ_TITULO = a.SEQ_TITULO ";
				
				btnImprime.Visible = false;
				btnRecebe.Visible = false;
				btnAltera.Visible = false;
				btnExclui.SetBounds(btnExclui.Location.X+108, btnExclui.Location.Y, btnExclui.Width, btnExclui.Height);
				btnInclui.SetBounds(btnInclui.Location.X+108, btnInclui.Location.Y, btnInclui.Width, btnInclui.Height);
				btnInclui.Text = "Associa";
				btnExclui.Text = "Desassocia";
			}
			else
			if (args.Length == 8)
			{
				fornecedor = args[3];
				data = DateTime.Parse(args[4]);
				orcamento = args[5];
				pedido = args[6];
				nro_pedido = args[7];
				gbxFiltro.Enabled = false;
				filtro_pedido = "inner join pedidos_recebidos pr on pr.COD_FORNECEDOR = '" + fornecedor + "' and " +
					"pr.DAT_ORCAMENTO = '" + data.ToString("M/d/yyyy") + "' and " +
					"pr.COD_ORCAMENTO = " + orcamento + " and " +
					"pr.COD_PEDIDO = " + pedido + " and " +
					"pr.NRO_NF = a.NRO_NF and pr.SEQ_TITULO = a.SEQ_TITULO ";
				
				pedido_filtro = fornecedor +
					" " +
					data.Month.ToString() +
					"/" +
					data.Year.ToString() +
					" " +
					orcamento +
					"-" +
					pedido;
				edtPedidoFiltro.Text = pedido_filtro;
				gbxFiltro.Enabled = true;
			}
			else
			if (args.Length == 4)
			{
				gbxFiltro.Enabled = true;
				btnImprime.Visible = false;
				btnRecebe.Visible = false;
				btnInclui.Visible = false;
				btnExclui.Visible = false;
				btnAltera.Visible = false;
				btnFecha.Text = "Seleciona";
			}

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
		
		void CarregaTitulos()
		{
			string s = Globais.sUsuario;
			if (s.Trim().Length == 0) return;
			where="";
			string data = DateTime.Today.ToString("M/d/yyyy");
			if (cbxFiltroSituacao.Text.Trim().CompareTo("Recebidos") == 0)
				where = "where a.DAT_RECEBIMENTO is not null";
			if (cbxFiltroSituacao.Text.Trim().CompareTo("Abertos") == 0)
				where = "where a.DAT_RECEBIMENTO is null";
			if (cbxFiltroSituacao.Text.Trim().CompareTo("Atrasados") == 0)
				where = "where (a.DAT_RECEBIMENTO is null) and (a.DAT_VENCIMENTO < '" + data + "')";
			bool todas = clbFiltroNaturezas.Items.Count == clbFiltroNaturezas.CheckedIndices.Count;
			if (!todas)
			{
				if (where.Length > 0)
					where += " and a.COD_NATUREZA in (";
				else
					where = "where a.COD_NATUREZA in (";				
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
					where = "where a.COD_FORMA='";
				int f = cbxFiltroFormas.SelectedIndex;
				where += cbxCodFormas.Items[f].ToString() + "'";
			}
			if (!cbxFiltroPendencias.Text.Trim().Equals("Todas") && !cbxFiltroPendencias.Text.Trim().Equals(""))
			{
				if (where.Length > 0)
					where += " and a.COD_PENDENCIA='";
				else
					where = "where a.COD_PENDENCIA='";
				int f = cbxFiltroPendencias.SelectedIndex;
				where += cbxCodPendencias.Items[f].ToString() + "'";
			}
			if (!cbxFiltroPendencias.Text.Trim().Equals(""))
			{
				if (cbxFiltroPendencias.Text.Trim().Equals("Cancelados"))
				{
					if (where.Length > 0)
						where += " and a.IDT_CANCELADO='S'";
					else
						where = "where a.IDT_CANCELADO='S'";
				}
				if (cbxFiltroPendencias.Text.Trim().Equals("Não Cancelados"))
				{
					if (where.Length > 0)
						where += " and a.IDT_CANCELADO='N'";
					else
						where = "where a.IDT_CANCELADO='N'";
				}
			}
			if (edtParceiro.Text.Trim().Length > 0)
			{
				if (where.Length > 0)
					where += string.Format(" and (a.COD_CLIENTE='{0}')", edtParceiro.Text.Trim());
				else
					where += string.Format("where (a.COD_CLIENTE='{0}')", edtParceiro.Text.Trim());
			}
			if (dtpVencimentoI.Checked || dtpVencimentoF.Checked)
			{
				if (where.Length > 0)				
					where += " and ";
				else
					where = "where ";
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
			if (dtpRecebimentoI.Checked || dtpRecebimentoF.Checked)
			{
				if (where.Length > 0)				
					where += " and ";
				else
					where = "where ";
				if (dtpRecebimentoI.Checked && dtpRecebimentoF.Checked)
				{
					string datai = "'" + dtpRecebimentoI.Value.ToString("M/d/yyyy") + "'";
					string dataf = "'" + dtpRecebimentoF.Value.ToString("M/d/yyyy") + "'";
					if (datai.CompareTo(dataf) == 0)
						where += "a.DAT_RECEBIMENTO=" + datai;
					else
						where += "a.DAT_RECEBIMENTO between " + datai + " and " + dataf;
				}
				else
				if (dtpRecebimentoI.Checked)
				{
					string datai = "'" + dtpRecebimentoI.Value.ToString("M/d/yyyy") + "'";
					where += "a.DAT_RECEBIMENTO >= " + datai;
				}
				else
				{
					string dataf = "'" + dtpRecebimentoF.Value.ToString("M/d/yyyy") + "'";
					where += "a.DAT_RECEBIMENTO <= " + dataf;
				}
			}
			if (dtpEmissaoI.Checked || dtpEmissaoF.Checked)
			{
				if (where.Length > 0)				
					where += " and ";
				else
					where = "where ";
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
			if (filtro_pedido.Length > 0)
			{
				/*
				if (where.Length > 0)
					where += " and " + filtro_pedido;
				else
					where = "where " + filtro_pedido;;
				*/
				where = filtro_pedido;
			}
			this.Cursor = Cursors.WaitCursor;
			titulos.Carrega(dgvCadastro, where);
			this.Cursor = Cursors.Default;
			Colore();
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			imgSoftplace.Visible = false;
			cbxFiltroSituacao.Items.Add("Recebidos");
			cbxFiltroSituacao.Items.Add("Abertos");
			cbxFiltroSituacao.Items.Add("Atrasados");
			cbxFiltroSituacao.Items.Add("Todos");
			if (pedido_filtro.Length > 0)
				cbxFiltroSituacao.Text = "Todos";
			else
				cbxFiltroSituacao.Text = "Abertos";
			bShow = true;
			
			cNaturezasRecebimento naturezas = new cNaturezasRecebimento();
			this.Cursor = Cursors.WaitCursor;
			naturezas.Carrega(cbxFiltroNaturezas, cbxCodNaturezas);
			foreach (string s in cbxFiltroNaturezas.Items)
				clbFiltroNaturezas.Items.Add(s, true);
			this.Cursor = Cursors.Default;
			cbxFiltroNaturezas.Items.Add("Todas");
			cbxCodNaturezas.Items.Add("Todas");
			cbxFiltroNaturezas.Text = "Todas";			
			
			cFormasRecebimento formas = new cFormasRecebimento();
			this.Cursor = Cursors.WaitCursor;
			formas.Carrega(cbxFiltroFormas, cbxCodFormas);
			this.Cursor = Cursors.Default;
			cbxFiltroFormas.Items.Add("Todas");
			cbxCodFormas.Items.Add("Todas");
			cbxFiltroFormas.Text = "Todas";			
			
			cPendenciasRecebimento pendencias = new cPendenciasRecebimento();
			this.Cursor = Cursors.WaitCursor;
			pendencias.Carrega(cbxFiltroPendencias, cbxCodPendencias);
			this.Cursor = Cursors.Default;
			cbxFiltroPendencias.Items.Add("Todas");
			cbxCodPendencias.Items.Add("Todas");
			cbxFiltroPendencias.Text = "Todas";			
			
			cbxFiltroCancelados.Items.Add("Todos");
			cbxFiltroCancelados.Items.Add("Cancelados");
			cbxFiltroCancelados.Items.Add("Não Cancelados");
			cbxFiltroCancelados.Text = "Todos";			
						
			edtParceiro.Text = "";
			
			dtpVencimentoI.Value = DateTime.Now;
			dtpVencimentoF.Value = DateTime.Now;
			dtpRecebimentoI.Value = DateTime.Now;
			dtpRecebimentoF.Value = DateTime.Now;
			dtpEmissaoI.Value = DateTime.Now;
			dtpEmissaoF.Value = DateTime.Now;			
			dtpVencimentoI.Checked = false;
			dtpVencimentoF.Checked = false;
			dtpRecebimentoI.Checked = false;
			dtpRecebimentoF.Checked = false;
			dtpEmissaoI.Checked = false;
			dtpEmissaoF.Checked = false;			
			
			col_sorted = "";
			ord_sorted = SortOrder.Ascending;			
		}
		
		void BtnIncluiClick(object sender, EventArgs e)
		{
			if (filtro_pedido.Length == 0)
			{
				fCadTitulo frm = new fCadTitulo('i', "", 0);
				frm.ShowDialog();
				if (frm.result)
				{
					CarregaTitulos();
					Grid.Sort(dgvCadastro, col_sorted, ord_sorted);					
					int i = dgvCadastro.Rows.Count- 1;
					if (i >= 0) dgvCadastro.Rows[i].Cells["Vencimento"].Selected = true;
				}
			}
			else
			{
				string[] args = new string[4];
				args[0] = Globais.sUsuario;
				args[1] = Globais.sFilial;
				args[2] = Globais.bAdministrador ? "S" : "N";
				args[3] = "-";
				
				receber.MainForm frm = new receber.MainForm(args);
				frm.ShowDialog();
				string nf = frm.nf;
				short seq = frm.seq;
				string msg="";
				titulos.Associa(nf, seq, fornecedor, data, orcamento, pedido, ref msg);
				CarregaTitulos();
				Grid.Sort(dgvCadastro, col_sorted, ord_sorted);				
			}
		}
		
		void BtnFechaClick(object sender, EventArgs e)
		{
			if (dgvCadastro.Rows.Count > 0)
			{
				int i = dgvCadastro.CurrentRow.Index;									
				nf = dgvCadastro.Rows[i].Cells["NF"].Value.ToString().Trim();
				seq = Globais.StrToShort(dgvCadastro.Rows[i].Cells["Seq"].Value.ToString());
				result = true;
			}
			Close();
		}
		
		void BtnExcluiClick(object sender, EventArgs e)
		{
			if (dgvCadastro.Rows.Count == 0) return;
			int i = dgvCadastro.CurrentRow.Index;									
			string nf = dgvCadastro.Rows[i].Cells["NF"].Value.ToString().Trim();
			short seq = Globais.StrToShort(dgvCadastro.Rows[i].Cells["Seq"].Value.ToString());
			string msg="";			
			if (filtro_pedido.Length == 0)			
			{
				DialogResult r = MessageBox.Show(nf+"-"+seq.ToString(), "Confirma a exclusão?",
			                                 	MessageBoxButtons.YesNo, 
			                                 	MessageBoxIcon.Question);
				if (r == DialogResult.No) return;	
				if (titulos.Exclui(nf, seq, ref msg))
				{
					CarregaTitulos();				
					Grid.Sort(dgvCadastro, col_sorted, ord_sorted);									
				}
			}
			else
			{
				titulos.Desassocia(nf, seq, ref msg);
				CarregaTitulos();
				Grid.Sort(dgvCadastro, col_sorted, ord_sorted);								
			}
		}
		
		void BtnAlteraClick(object sender, EventArgs e)
		{
			if (dgvCadastro.Rows.Count == 0) return;
			int i = dgvCadastro.CurrentRow.Index;						
			string nf = dgvCadastro.Rows[i].Cells["NF"].Value.ToString().Trim();
			short seq = Globais.StrToShort(dgvCadastro.Rows[i].Cells["Seq"].Value.ToString());
			fCadTitulo frm = new fCadTitulo('a', nf, seq);
			frm.ShowDialog();
			if (frm.result)
			{
				CarregaTitulos();
				Grid.Sort(dgvCadastro, col_sorted, ord_sorted);				
				for (i=0; i<dgvCadastro.Rows.Count; i++)
				{
					string NF = dgvCadastro.Rows[i].Cells["NF"].Value.ToString().Trim();
					if (NF.Equals(nf))
					{
						dgvCadastro.Rows[i].Cells["Vencimento"].Selected = true;
						break;
					}
				}
			}
		}
		
		void Colore()
		{
			float total=0;
			float recebido=0;
			float receber=0;
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
				if (row.Cells["Recebido"].Value != null)
				{
					s = row.Cells["Recebido"].Value.ToString().Trim();
					recebido += Globais.StrToFloat(s);
				}
				
				DataGridViewCell cell = row.Cells["Situação"];
				string pagamento = row.Cells["Recebimento"].Value.ToString().Trim();
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
				row.Cells["Recebimento"].Value.ToString().Trim();
			}			
			edtTotal.Text = total.ToString("#,###,##0.00");
			edtTotalRecebido.Text = recebido.ToString("#,###,##0.00");
			receber = total - recebido;
			edtTotalReceber.Text = receber.ToString("#,###,##0.00");
			edtRegistros.Text = registros.ToString();
		}
		
		void BtnAplicaClick(object sender, EventArgs e)
		{
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
			edtParceiro.Text = "";
			dtpVencimentoI.Value = DateTime.Now;
			dtpVencimentoF.Value = DateTime.Now;
			dtpRecebimentoI.Value = DateTime.Now;
			dtpRecebimentoF.Value = DateTime.Now;
			dtpEmissaoI.Value = DateTime.Now;
			dtpEmissaoF.Value = DateTime.Now;			
			dtpVencimentoI.Checked = false;
			dtpVencimentoF.Checked = false;
			dtpRecebimentoI.Checked = false;
			dtpRecebimentoF.Checked = false;
			dtpEmissaoI.Checked = false;
			dtpEmissaoF.Checked = false;			
			edtPedidoFiltro.Text = "";
			filtro_pedido = "";
			CarregaTitulos();
		}
		
		void MniGraficoNaturezaClick(object sender, EventArgs e)
		{
			pagar.fGraficoNatureza frm = new pagar.fGraficoNatureza('r');
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
			if (dgvCadastro.Rows[e.RowIndex].Cells["Tipo"].Value.ToString().Trim().CompareTo("F") == 0)
				edtFixoVariavel.Text = "FIXO";
			if (dgvCadastro.Rows[e.RowIndex].Cells["Tipo"].Value.ToString().Trim().CompareTo("V") == 0)
				edtFixoVariavel.Text = "VARIÁVEL";
			edtPedido.Text = "";
			if (dgvCadastro.Rows[e.RowIndex].Cells["Fornecedor"].Value != null)
			{
				string fornecedor = dgvCadastro.Rows[e.RowIndex].Cells["Fornecedor"].Value.ToString().Trim();
				if (fornecedor.Length > 0)
				{
					DateTime data = DateTime.Parse(dgvCadastro.Rows[e.RowIndex].Cells["Data"].Value.ToString());
					edtPedido.Text = fornecedor +
						" " +
						data.Month.ToString() +
						"/" +
						data.Year.ToString() +
						" " +
						dgvCadastro.Rows[e.RowIndex].Cells["Orçamento"].Value.ToString().Trim() +
						"-" +
						dgvCadastro.Rows[e.RowIndex].Cells["CodPedido"].Value.ToString().Trim();
				}
			}
		}
		
		void BtnImprimeClick(object sender, EventArgs e)
		{
			fParametrosImpressao frm = new fParametrosImpressao();
			frm.ShowDialog();
			if (!frm.result) return;
			//string pdf = "c:\\softplace\\receber.pdf";
			string pdf = "receber.pdf";
			string order = "";
			if (col_sorted.Equals("Natureza"))
				order = "order by b.DES_NATUREZA";
			else
			if (col_sorted.Equals("Vencimento"))
				order = "order by a.DAT_VENCIMENTO";
			else
			if (col_sorted.Equals("NF"))
				order = "order by a.NRO_NF";			
			else
			if (col_sorted.Equals("Seq"))
				order = "order by a.SEQ_TITULO";						
			else
			if (col_sorted.Equals("Cliente"))
				order = "order by a.COD_CLIENTE";												
			else
			if (col_sorted.Equals("Valor"))
				order = "order by a.VLR_PREVISTO";															
			else
			if (col_sorted.Equals("Recebido"))
				order = "order by a.VLR_RECEBIDO";															
			else
			if (col_sorted.Equals("Recebimento"))
				order = "order by a.DAT_RECEBIMENTO";																		
			if ((ord_sorted == SortOrder.Descending) && !order.Equals(""))
				order += " desc";
			if (order.Equals(""))
				order = "order by a.DAT_VENCIMENTO";
			if (frm.relatorio)
			{
				if (titulos.Gera(where, pdf, frm.titulo, frm.quartil1, frm.quartil2, frm.quartil3, order))			
					System.Diagnostics.Process.Start("explorer", pdf);
			} 
			else
			{
				if (dgvCadastro.Rows.Count == 0) return;
				int i = dgvCadastro.CurrentRow.Index;									
				string nf = dgvCadastro.Rows[i].Cells["NF"].Value.ToString().Trim();
				short seq = Globais.StrToShort(dgvCadastro.Rows[i].Cells["Seq"].Value.ToString());									
				if (cRecibo.gera(pdf, nf, seq))			
				{
					System.Diagnostics.Process.Start("explorer", pdf);
				}
			}			
		}
		
		void BtnRecebeClick(object sender, EventArgs e)
		{
			DialogResult r = MessageBox.Show("Confirma o recebimento de todos os títulos selecionados?", "",
			                                 MessageBoxButtons.YesNo, 
			                                 MessageBoxIcon.Question);
			if (r == DialogResult.No) return;	
			fRecebimento frm = new fRecebimento(where);
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
			if (!Globais.bAdministrador &&  !acesso.PermissaoSistema(Globais.sUsuario, Globais.sFilial, 6))
			{
				MessageBox.Show("Usuário sem permissão para esse Sistema", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Close();
			}
			bShow = false;
			titulos = new cTitulosXeceber();
			CarregaTitulos();
		}
		
		void MinTendenciaClick(object sender, EventArgs e)
		{
			pagar.fGraficoTendencia frm = new pagar.fGraficoTendencia('r');
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
			if (dgvCadastro.Rows.Count == 0) return;
			int i0 = dgvCadastro.CurrentRow.Index;			
			selecionado = 0;
			dir = 'd';
			int i = Procura(edtLocaliza.Text);
			if (i >= 0)
			{
				dgvCadastro.Rows[i0].Cells[0].Selected = false;
				dgvCadastro.Rows[i].Cells[0].Selected = true;
				DataGridViewCellEventArgs e2 = new DataGridViewCellEventArgs(0, i);
				DgvCadastroRowEnter(sender, e2);
				
			}
		}
		
		void MniFixoVariavelClick(object sender, EventArgs e)
		{
			pagar.fGraficoFixoVariavel frm = new pagar.fGraficoFixoVariavel('r');
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
				dgvCadastro.Rows[i].Cells[1].Selected = true;
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
			
		void BtnClienteClick(object sender, EventArgs e)
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
		
		void MniParametrosClick(object sender, EventArgs e)
		{
			fParametrosRemessa frm = new fParametrosRemessa();
			frm.ShowDialog();
		}
		
		void GeraToolStripMenuItemClick(object sender, EventArgs e)
		{
			string arquivo="";
			cParametrosRemessa prms = new cParametrosRemessa();
			prms.Le();
			cRemessa remessa = new cRemessa();
			remessa.COD_EMPRESA = prms.COD_EMPRESA;
			remessa.NOM_EMPRESA = prms.NOM_EMPRESA;
			remessa.NRO_REMESSA = prms.NRO_REMESSA;
			if (remessa.GeraRemessa(ref arquivo, where))
			{
				MessageBox.Show("Arquivo gerado: " + arquivo);
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
