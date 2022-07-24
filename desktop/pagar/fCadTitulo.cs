/*
 * Projeto  : SoftPlace
 * Sistema  : Orcamentos
 * Programa : frmCadTitulo - Inclusao/Alteracao de Titulo
 * Autor    : Ricardo Costa Xavier
 * Data     : 22/07/08
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using System.Collections;
using classes;
using basico;

namespace pagar
{
	public partial class fCadTitulo : Form
	{
		private char acao;
		private bool show;
		private int codigo;
		public bool result;
		private int v;
		
		private int IndiceCodigo(ComboBox cbx, string cod)
		{
			int n=0;
			foreach (string s in cbx.Items)
			{
				if (s.Trim().CompareTo(cod.Trim()) == 0)
					return n;
				n++;
			}
			return -1;
		}
		
		private void CarregaNaturezas()
		{
			cNaturezasPagamento naturezas = new cNaturezasPagamento();
			this.Cursor = Cursors.WaitCursor;
			naturezas.Carrega(cbxNaturezas, cbxCodNaturezas);
			this.Cursor = Cursors.Default;
		}
		
		private void CarregaFormas()
		{
			cFormas formas = new cFormas();
			this.Cursor = Cursors.WaitCursor;
			formas.Carrega(cbxFormas, cbxCodFormas);
			this.Cursor = Cursors.Default;
		}
		
		private void CarregaPendencias()
		{
			cPendencias pendencias = new cPendencias();
			this.Cursor = Cursors.WaitCursor;
			pendencias.Carrega(cbxPendencias, cbxCodPendencias);
			this.Cursor = Cursors.Default;
		}
		
		public fCadTitulo(char acao, int codigo)
		{
			InitializeComponent();
			this.acao = acao;
			this.codigo = codigo;
		}
		
		void FCadTituloLoad(object sender, EventArgs e)
		{
			v = -1;
			show = false;
			result = false;
			if (acao == 'i')
			{
				Text = "Sistema SOFT - Inclusão de Título";
				edtCodigo.Text = "0";
				edtUsuario.Text = Globais.sUsuario;
				dtpEntrada.Value = DateTime.Now;
				dtpVencimento.Value = DateTime.Now;
				dtpPagamento.Value = DateTime.Now;
				dtpPagamento.Checked = false;
				rbtFixo.Checked = true;
				rbtVariavel.Checked = false;
				rbtSemiFixa.Checked = false;
				float valor=0;
				edtValor.Text = valor.ToString("#,###,##0.00");
				edtPago.Text = valor.ToString("#,###,##0.00");
				CarregaNaturezas();
				cbxNaturezas.Text = "";
				CarregaFormas();
				cbxFormas.Text = "";
				CarregaPendencias();
				cbxPendencias.Text = "";
			}
			else
			{
				Text = "Sistema SOFT - Alteração de Título";
				//btnLote.Visible = false;
				cTitulosPagar titulos = new cTitulosPagar();
				titulos.Le(codigo);
				edtCodigo.Text = titulos.COD_TITULO.ToString();
				edtUsuario.Text = titulos.COD_USUARIO;
				dtpEntrada.Value = titulos.DAT_EMISSAO;
				dtpVencimento.Value = titulos.DAT_VENCIMENTO;
				edtParceiro.Text = titulos.COD_PARCEIRO;
				edtFuncionario.Text = titulos.COD_FUNCIONARIO;
				edtDocOrigem.Text = titulos.COD_DOC_ORIGEM;
				edtDocGerado.Text = titulos.COD_DOC_GERADO;
				edtObservacao.Text = titulos.TXT_OBSERVACAO;
				if (titulos.chkDAT_PAGAMENTO)
				{
					dtpPagamento.Value = titulos.DAT_PAGAMENTO;
					dtpPagamento.Checked = true;
				}
				else 
				{
					dtpPagamento.Value = DateTime.Now;
					dtpPagamento.Checked = false;
				}
				rbtFixo.Checked = titulos.IDT_TIPO[0] == 'F';
				rbtVariavel.Checked = titulos.IDT_TIPO[0] == 'V';
				rbtSemiFixa.Checked = titulos.IDT_TIPO[0] == 'S';
				edtValor.Text = titulos.VLR_PREVISTO.ToString("#,###,##0.00");
				edtPago.Text = titulos.VLR_PAGO.ToString("#,###,##0.00");
				CarregaNaturezas();
				cbxCodNaturezas.Text = titulos.COD_NATUREZA;
				int n = IndiceCodigo(cbxCodNaturezas, titulos.COD_NATUREZA);
				cbxNaturezas.Text = (n >= 0) ? cbxNaturezas.Items[n].ToString() : "";
				CarregaFormas();
				cbxCodFormas.Text = titulos.COD_FORMA;
				int f = IndiceCodigo(cbxCodFormas, titulos.COD_FORMA);
				cbxFormas.Text = (f >= 0) ? cbxFormas.Items[f].ToString() : "";
				CarregaPendencias();
				cbxCodPendencias.Text = titulos.COD_PENDENCIA;
				int p = IndiceCodigo(cbxCodPendencias, titulos.COD_PENDENCIA);
				cbxPendencias.Text = (p >= 0) ? cbxPendencias.Items[p].ToString() : "";
				dtpVencimento.Focus();
				
				titulos.CarregaPedidos(codigo, cbxPedidos);
				if (cbxPedidos.Items.Count > 0)
					cbxPedidos.Text = cbxPedidos.Items[0].ToString();
			}
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
		
		void BtnFuncionarioClick(object sender, EventArgs e)
		{
			frmCadFuncionarios frmCad = new frmCadFuncionarios(true);
			frmCad.ShowDialog();
			if (frmCad.result)
			{
				edtFuncionario.Text = frmCad.edtCodigo.Text;
			}
			edtFuncionario.Focus();
		}
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void FCadTituloShown(object sender, EventArgs e)
		{
			if (!show)
			{
				if (acao == 'i')
					edtParceiro.Focus();
				else
					dtpVencimento.Focus();
				show = true;
			}
		}
		
		bool Valida()
		{
			if (cbxNaturezas.Text.Trim().Length == 0)
			{
				MessageBox.Show("Natureza", "Campo Obrigatório", 
				                MessageBoxButtons.OK, 
				                MessageBoxIcon.Warning);
				cbxNaturezas.Focus();
				return false;
			}						
			cParceiros parceiros = new cParceiros();
			if ((edtParceiro.Text.Trim().Length > 0) && !parceiros.Existe(edtParceiro.Text.Trim()))
			{
				MessageBox.Show(edtParceiro.Text, "Parceiro não Cadastrado", 
				                MessageBoxButtons.OK, 
				                MessageBoxIcon.Warning);
				edtParceiro.Focus();
				return false;
			}
			cFuncionarios funcionarios = new cFuncionarios();
			if ((edtFuncionario.Text.Trim().Length > 0) && !funcionarios.Existe(edtFuncionario.Text.Trim()))
			{
				MessageBox.Show(edtFuncionario.Text, "Funcionário não Cadastrado", 
				                MessageBoxButtons.OK, 
				                MessageBoxIcon.Warning);
				edtFuncionario.Focus();
				return false;
			}
			if ((edtParceiro.Text.Trim().Length + edtFuncionario.Text.Trim().Length) == 0)
			{
				MessageBox.Show("Parceiro ou Funcionário", "Campo Obrigatório", 
				                MessageBoxButtons.OK, 
				                MessageBoxIcon.Warning);
				edtParceiro.Focus();
				return false;
			}		
			return true;
		}
		
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			if (!Valida()) return;
			float valor = Globais.StrToFloat(edtValor.Text);
			float pago = Globais.StrToFloat(edtPago.Text);
			string msg="";
			cTitulosPagar titulos = new cTitulosPagar();
			int n = cbxNaturezas.SelectedIndex;	
			string natureza = (n >= 0) ? cbxCodNaturezas.Items[n].ToString() : "";
			int f = cbxFormas.SelectedIndex;	
			string forma = (f >= 0) ? cbxCodFormas.Items[f].ToString() : "";
			int p = cbxPendencias.SelectedIndex;	
			string pendencia = (p >= 0) ? cbxCodPendencias.Items[p].ToString() : "";
			ArrayList pedidos = new ArrayList();
			foreach (string pedido in cbxPedidos.Items)
			{
				pedidos.Add(pedido);
			}			
			string tipo = "F";
			if (rbtVariavel.Checked) tipo = "V";
			if (rbtSemiFixa.Checked) tipo = "S";			
			if (acao == 'i')
			{
				int codigo=0;
				result = titulos.Inclui(edtUsuario.Text,
				               dtpEntrada.Value,
				               dtpVencimento.Value,
				               edtParceiro.Text,
				               edtFuncionario.Text,
				               natureza,
				               tipo,
				               valor,
				               dtpPagamento.Checked,
				               dtpPagamento.Value,
				               pago,
				               forma,
				               edtDocOrigem.Text,
				               edtDocGerado.Text,
				               pendencia,
				               edtObservacao.Text,
				               pedidos,				               
				               ref msg,
				               ref codigo);
				if (!result)
				{
					MessageBox.Show(msg, "Erro na inclusão"+"\n"+msg, 
				                	MessageBoxButtons.OK, 
				                	MessageBoxIcon.Warning);
				}
			}
			else
			{
				result = titulos.Altera(codigo,
							   edtUsuario.Text,
				               dtpEntrada.Value,
				               dtpVencimento.Value,
				               edtParceiro.Text,
				               edtFuncionario.Text,
				               natureza,
				               tipo,
				               valor,
				               dtpPagamento.Checked,
				               dtpPagamento.Value,
				               pago,
				               forma,
				               edtDocOrigem.Text,
				               edtDocGerado.Text,
				               pendencia,
				               edtObservacao.Text,
				               pedidos,
				               ref msg);				
				if (!result)
				{
					MessageBox.Show(msg, "Erro na alteração", 
				                	MessageBoxButtons.OK, 
				                	MessageBoxIcon.Warning);
				}
			}
			Close();
		}
		
		void BtnNaturezasClick(object sender, EventArgs e)
		{
			fCadNaturezas frmCad = new fCadNaturezas(true);
			frmCad.ShowDialog();
			if (frmCad.result)
			{
				CarregaNaturezas();
				cbxCodNaturezas.Text = frmCad.codigo;
				int n = cbxCodNaturezas.SelectedIndex;
				cbxNaturezas.Text = (n >= 0) ? cbxNaturezas.Items[n].ToString() : "";
			}
			cbxNaturezas.Focus();
		}
		
		void BtnFormasClick(object sender, EventArgs e)
		{
			fCadFormas frmCad = new fCadFormas(true);
			frmCad.ShowDialog();
			if (frmCad.result)
			{
				CarregaFormas();
				cbxCodFormas.Text = frmCad.codigo;
				int f = cbxCodFormas.SelectedIndex;
				cbxFormas.Text = (f >= 0) ? cbxFormas.Items[f].ToString() : "";
			}
			cbxFormas.Focus();
		}
		
		void EdtObservacaoMouseDoubleClick(object sender, MouseEventArgs e)
		{
			frmEditaMemo frm = new frmEditaMemo();
			frm.Text = "Pendência";
			frm.edtMemo.Text = edtObservacao.Text;
			frm.ShowDialog();
			if (frm.ok)
			{
				edtObservacao.Text = frm.edtMemo.Text;
			}
		}
		
		void BtnPendenciasClick(object sender, EventArgs e)
		{
			fCadPendencias frmCad = new fCadPendencias(true);
			frmCad.ShowDialog();
			if (frmCad.result)
			{
				CarregaPendencias();
				cbxCodPendencias.Text = frmCad.codigo;
				int n = cbxCodPendencias.SelectedIndex;
				cbxPendencias.Text = (n >= 0) ? cbxPendencias.Items[n].ToString() : "";
			}
			cbxPendencias.Focus();
		}
		
		void EdtValorKeyPress(object sender, KeyPressEventArgs e)
		{
			if ("0123456789,".IndexOf(e.KeyChar) < 0)
			{
				e.Handled = true;
				return;
			}
			int v = ((TextBox)sender).Text.IndexOf(',');
			int p = ((TextBox)sender).SelectionStart;
			if (e.KeyChar == ',')
			{
				if (v > 0)
				{
					((TextBox)sender).SelectionStart = v + 1;
					e.Handled = true;
				}
				return;
			}
			else
			{
				if (v > 0) 
				{
					if (p == (v + 1))
					{
						string s = ((TextBox)sender).Text;
						string s1 = s.Substring(0, p);
						string s2 = s.Substring(p+1);
						s = s1 + e.KeyChar + s2;
						((TextBox)sender).Text = s;
						((TextBox)sender).SelectionStart = p + 1;
						e.Handled = true;
						return;
					}
					else
					if (p == (v + 2))
					{
						string s = ((TextBox)sender).Text;
						string s1 = s.Substring(0, p);						
						s = s1 + e.KeyChar;
						((TextBox)sender).Text = s;
						((TextBox)sender).SelectionStart = p;
						e.Handled = true;
						return;
					}
				}
			}
		}
		
		void EdtValorEnter(object sender, EventArgs e)
		{
			v = ((TextBox)sender).Text.IndexOf(',');
			if (v > 0)
				((TextBox)sender).SelectionStart = v;
		}
		
		void EdtValorTextChanged(object sender, EventArgs e)
		{
			string s1 = ((TextBox)sender).Text;
			double valor;
			if (double.TryParse(s1, out valor))
			{
				string s2 = valor.ToString("#,###,##0.00");
				if (s2.CompareTo(s1) != 0)
				{
					int x = s2.Length - s1.Length;
					int p = ((TextBox)sender).SelectionStart;
					if ((s1.IndexOf(',') < 0) && (s2.IndexOf(',') >= 0))
					{
						((TextBox)sender).Text = s2;						
						((TextBox)sender).SelectionStart = s2.IndexOf(',');
					}
					else
					{
						((TextBox)sender).Text = s2;						
						((TextBox)sender).SelectionStart = p + x;
					}
				}
			}
		}
		
		void EdtParceiroTextChanged(object sender, EventArgs e)
		{
			edtFuncionario.Enabled = (edtParceiro.Text.Trim().Length == 0);
			edtParceiro.Enabled = (edtFuncionario.Text.Trim().Length == 0);
			btnFuncionario.Enabled = edtFuncionario.Enabled;
			btnParceiro.Enabled =  edtParceiro.Enabled;
		}
		
		void EdtValorClick(object sender, EventArgs e)
		{
			if (v > 0)
			{
				((TextBox)sender).SelectionStart = v;
				v = -1;
			}
			
		}
		
		void BtnPedidoClick(object sender, EventArgs e)
		{
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			float valor = Globais.StrToFloat(edtPago.Text);
			if (valor == 0)
				valor = Globais.StrToFloat(edtValor.Text);
			fSelecionaPedido frm = new fSelecionaPedido(valor);
			foreach (string pedido in cbxPedidos.Items)
			{
				frm.selecionados.Add(pedido);
			}
			frm.ShowDialog();
			if (frm.result)
			{
				cbxPedidos.Items.Clear();
				foreach (string selecionado in frm.selecionados)
				{
					cbxPedidos.Items.Add(selecionado);
				}
				if (cbxPedidos.Items.Count > 0)
				{
					cbxPedidos.Text = cbxPedidos.Items[0].ToString();
				}
				else
				{
					cbxPedidos.Text = "";
				}
			}
			btnConfirma.Focus();			
		}
		
		void BtnLoteClick(object sender, EventArgs e)
		{
			if (!Valida()) return;
			
			fLote frm = new fLote();
			if (frm.ShowDialog() == DialogResult.Cancel) return;
			
			float valor = Globais.StrToFloat(edtValor.Text);
			float pago = Globais.StrToFloat(edtPago.Text);
			string msg="";
			cTitulosPagar titulos = new cTitulosPagar();
			int n = cbxNaturezas.SelectedIndex;	
			string natureza = (n >= 0) ? cbxCodNaturezas.Items[n].ToString() : "";
			int f = cbxFormas.SelectedIndex;	
			string forma = (f >= 0) ? cbxCodFormas.Items[f].ToString() : "";
			int p = cbxPendencias.SelectedIndex;	
			string pendencia = (p >= 0) ? cbxCodPendencias.Items[p].ToString() : "";
			ArrayList pedidos = new ArrayList();
			foreach (string pedido in cbxPedidos.Items)
			{
				pedidos.Add(pedido);
			}			
			
			int repeticoes = frm.repeticoes;
			string frequencia = frm.frequencia;
			DateTime limite = frm.limite;
			bool idt_limite = frm.idt_limite;
			DateTime vencimento = dtpVencimento.Value;
			string texto = "";
			int codigo=0;
			int r=0;
			while ((repeticoes-- > 0) || idt_limite)
			{
				if (idt_limite && (vencimento > limite)) break;
				r++;
				string tipo = "F";
				if (rbtVariavel.Checked) tipo = "V";
				if (rbtSemiFixa.Checked) tipo = "S";							
				result = titulos.Inclui(edtUsuario.Text,
			               dtpEntrada.Value,
			               vencimento,
			               edtParceiro.Text,
			               edtFuncionario.Text,
			               natureza,
			               tipo,
			               valor,
			               dtpPagamento.Checked,
			               dtpPagamento.Value,
			               pago,
			               forma,
			               edtDocOrigem.Text,
			               edtDocGerado.Text,
			               pendencia,
			               edtObservacao.Text,
			               pedidos,				               
			               ref msg,
			               ref codigo);
				texto = texto + "\r\n" + codigo.ToString() + " - " + vencimento.ToString("d/M/yyyy");				
				if (frequencia.Equals("Semanal"))
				{
					vencimento = vencimento.AddDays(7);
				}
				else
				if (frequencia.Equals("Quinzenal"))
				{
					vencimento = vencimento.AddDays(15);
				}					
				else
				if (frequencia.Equals("Mensal"))
				{
					vencimento = vencimento.AddMonths(1);
				}					
				else
				if (frequencia.Equals("Anual"))
				{
					vencimento = vencimento.AddYears(1);
				}									
			}
			string titulo = "Foram gerados " + r.ToString() + " títulos";			
			MessageBox.Show(texto, titulo);
			Close();
		}
		void CbxPedidosSelectedIndexChanged(object sender, EventArgs e)
		{
	
		}
	}
}
