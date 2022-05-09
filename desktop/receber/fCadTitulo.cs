/*
 * Projeto  : SoftPlace
 * Sistema  : Faturamento
 * Programa : frmCadTitulo - Inclusao/Alteracao de Titulo
 * Autor    : Ricardo Costa Xavier
 * Data     : 23/08/08
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using classes;
using basico;
using templates;
using System.Collections;
using pagar;

namespace receber
{
	public partial class fCadTitulo : Form
	{
		private char acao;
		private bool show;
		private string nf;
		private short seq;
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
			cNaturezasRecebimento naturezas = new cNaturezasRecebimento();
			this.Cursor = Cursors.WaitCursor;
			naturezas.Carrega(cbxNaturezas, cbxCodNaturezas);
			this.Cursor = Cursors.Default;
		}
		
		private void CarregaFormas()
		{
			cFormasRecebimento formas = new cFormasRecebimento();
			this.Cursor = Cursors.WaitCursor;
			formas.Carrega(cbxFormas, cbxCodFormas);
			this.Cursor = Cursors.Default;
		}
		
		private void CarregaPendencias()
		{
			cPendenciasRecebimento pendencias = new cPendenciasRecebimento();
			this.Cursor = Cursors.WaitCursor;
			pendencias.Carrega(cbxPendencias, cbxCodPendencias);
			this.Cursor = Cursors.Default;
		}
		
		public fCadTitulo(char acao, string nf, short seq)
		{
			InitializeComponent();
			this.acao = acao;
			this.nf = nf;
			this.seq = seq;
		}
		
		void FCadTituloLoad(object sender, EventArgs e)
		{
			v = -1;
			show = false;
			result = false;
			if (acao == 'i')
			{
				Text = "Sistema SOFT - Inclusão de Título";
				edtCodigo.Text = "";
				edtSequencia.Text = "0";
				edtUsuario.Text = Globais.sUsuario;
				dtpEntrada.Value = DateTime.Now;
				dtpVencimento.Value = DateTime.Now;
				dtpRecebimento.Value = DateTime.Now;
				dtpRecebimento.Checked = false;
				rbtFixo.Checked = false;
				rbtVariavel.Checked = true;
				float valor=0;
				edtValor.Text = valor.ToString("#,###,##0.00");
				edtRecebido.Text = valor.ToString("#,###,##0.00");
				CarregaNaturezas();
				cbxNaturezas.Text = "";
				CarregaFormas();
				cbxFormas.Text = "";
				CarregaPendencias();
				cbxPendencias.Text = "";
				ckbCancelado.Checked = false;
				edtMotivo.Text = "";
			}
			else
			{
				Text = "Sistema SOFT - Alteração de Título";
				edtCodigo.ReadOnly = true;
				edtSequencia.ReadOnly = true;
				cTitulosXeceber titulos = new cTitulosXeceber();
				cTituloXeceber titulo = new cTituloXeceber();
				titulos.Le(nf, seq, ref titulo);
				edtCodigo.Text = titulo.NRO_NF.ToString();
				edtSequencia.Text = titulo.SEQ_TITULO.ToString();
				edtUsuario.Text = titulo.COD_USUARIO;
				dtpEntrada.Value = titulo.DAT_EMISSAO;
				dtpVencimento.Value = titulo.DAT_VENCIMENTO;
				edtParceiro.Text = titulo.COD_CLIENTE;
				//edtPedido.Text = titulo.CHAVE_PEDIDO;
				edtObservacao.Text = titulo.TXT_OBSERVACAO;
				if (titulo.chkDAT_RECEBIMENTO)
				{
					dtpRecebimento.Value = titulo.DAT_RECEBIMENTO;
					dtpRecebimento.Checked = true;
				}
				else 
				{
					dtpRecebimento.Value = DateTime.Now;
					dtpRecebimento.Checked = false;
				}
				rbtFixo.Checked = titulo.IDT_TIPO[0] == 'F';
				rbtVariavel.Checked = titulo.IDT_TIPO[0] == 'V';
				edtValor.Text = titulo.VLR_PREVISTO.ToString("#,###,##0.00");
				edtRecebido.Text = titulo.VLR_RECEBIDO.ToString("#,###,##0.00");
				CarregaNaturezas();
				cbxCodNaturezas.Text = titulo.COD_NATUREZA;
				int n = IndiceCodigo(cbxCodNaturezas, titulo.COD_NATUREZA);
				cbxNaturezas.Text = (n >= 0) ? cbxNaturezas.Items[n].ToString() : "";
				CarregaFormas();
				cbxCodFormas.Text = titulo.COD_FORMA;
				int f = IndiceCodigo(cbxCodFormas, titulo.COD_FORMA);
				cbxFormas.Text = (f >= 0) ? cbxFormas.Items[f].ToString() : "";
				CarregaPendencias();
				cbxCodPendencias.Text = titulo.COD_PENDENCIA;
				int p = IndiceCodigo(cbxCodPendencias, titulo.COD_PENDENCIA);
				cbxPendencias.Text = (p >= 0) ? cbxPendencias.Items[p].ToString() : "";
				dtpVencimento.Focus();
				ckbCancelado.Checked = titulo.IDT_CANCELADO[0] == 'S';
				edtMotivo.Text = titulo.DES_MOTIVO;
				titulos.CarregaPedidos(titulo.NRO_NF, titulo.SEQ_TITULO, cbxPedidos);
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
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void FCadTituloShown(object sender, EventArgs e)
		{
			if (!show)
			{
				if (acao == 'i')
					edtCodigo.Focus();
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
			nf="";
			nf = edtCodigo.Text.Trim();
			if (nf.Equals(""))
			{
				MessageBox.Show("Nota Fiscal", "Campo Obrigatório", 
				                MessageBoxButtons.OK, 
				                MessageBoxIcon.Warning);
				edtCodigo.Focus();
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
			if (edtParceiro.Text.Trim().Length == 0)
			{
				MessageBox.Show("Cliente", "Campo Obrigatório", 
				                MessageBoxButtons.OK, 
				                MessageBoxIcon.Warning);
				edtParceiro.Focus();
				return false;
			}
			if (ckbCancelado.Checked && (edtMotivo.Text.Trim().Length == 0))
			{
				MessageBox.Show("Motivo", "Campo Obrigatório", 
				                MessageBoxButtons.OK, 
				                MessageBoxIcon.Warning);
				edtMotivo.Focus();
				return false;
			}			
			return true;
		}
		
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			if (!Valida()) return;
			float valor = Globais.StrToFloat(edtValor.Text);
			float recebido = Globais.StrToFloat(edtRecebido.Text);
			string msg="";
			cTitulosXeceber titulos = new cTitulosXeceber();
			int n = cbxNaturezas.SelectedIndex;	
			string natureza = (n >= 0) ? cbxCodNaturezas.Items[n].ToString() : "";
			int f = cbxFormas.SelectedIndex;	
			string forma = (f >= 0) ? cbxCodFormas.Items[f].ToString() : "";
			int p = cbxPendencias.SelectedIndex;	
			string pendencia = (p >= 0) ? cbxCodPendencias.Items[p].ToString() : "";
			//string fornecedor="";
			//DateTime data = DateTime.Now;
			//short orcamento=0;
			//short pedido=0;
			//if (cbxPedidos.Text.Trim().Length > 0)
			//{
				//string[] partes = cbxPedidos.Text.Split(' ');
				//fornecedor = partes[0];
				//data = DateTime.Parse(partes[1]);
				//orcamento = Globais.StrToShort(partes[2]);
				//pedido = Globais.StrToShort(partes[3]);
			//}
			ArrayList pedidos = new ArrayList();
			foreach (string pedido in cbxPedidos.Items)
			{
				pedidos.Add(pedido);
			}
			string tipo = "F";
			if (rbtVariavel.Checked) tipo = "V";
			if (acao == 'i')
			{
				result = titulos.Inclui(nf,
				               Globais.StrToShort(edtSequencia.Text),
							   edtUsuario.Text,
				               dtpEntrada.Value,
				               dtpVencimento.Value,
				               edtParceiro.Text,
				               natureza,
				               tipo,
				               pedidos,
				               valor,
				               dtpRecebimento.Checked,
				               dtpRecebimento.Value,
				               recebido,
				               forma,
				               pendencia,
				               edtObservacao.Text,
				               ckbCancelado.Checked ? "S" : "N",
				               edtMotivo.Text,
				               ref msg);
				if (!result)
				{
					MessageBox.Show(msg, "Erro na inclusão"+"\n"+msg, 
				                	MessageBoxButtons.OK, 
				                	MessageBoxIcon.Warning);
				}
			}
			else
			{
				result = titulos.Altera(nf,
				               Globais.StrToShort(edtSequencia.Text),
							   edtUsuario.Text,
				               dtpEntrada.Value,
				               dtpVencimento.Value,
				               edtParceiro.Text,
				               natureza,
				               tipo,
				               pedidos,
				               valor,
				               dtpRecebimento.Checked,
				               dtpRecebimento.Value,
				               recebido,
				               forma,
				               pendencia,
				               edtObservacao.Text,
				               ckbCancelado.Checked ? "S" : "N",
				               edtMotivo.Text,
							   //fornecedor,
							   //data,
							   //orcamento,
							   //pedido,
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
		
		void EdtValorClick(object sender, EventArgs e)
		{
			if (v > 0)
			{
				((TextBox)sender).SelectionStart = v;
				v = -1;
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
		
		void BtnNaturezaClick(object sender, EventArgs e)
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
		
		void Button1Click(object sender, EventArgs e)
		{
			fSelecionaPedido frm = new fSelecionaPedido(0);
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
				//edtPedido.Text = frm.pedido;
			}
			dtpRecebimento.Focus();
		}
		
		void BtnLimpaClick(object sender, EventArgs e)
		{
			//edtPedido.Text = "";
		}		
		
		void BtnLoteClick(object sender, EventArgs e)
		{
			if (!Valida()) return;
			
			fLote frm = new fLote();
			if (frm.ShowDialog() == DialogResult.Cancel) return;
			
			float valor = Globais.StrToFloat(edtValor.Text);
			float recebido = Globais.StrToFloat(edtRecebido.Text);
			string msg="";
			cTitulosXeceber titulos = new cTitulosXeceber();
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
			short codigo = Globais.StrToShort(edtSequencia.Text);
			int r=0;
			while ((repeticoes-- > 0) || idt_limite)
			{
				if (idt_limite && (vencimento > limite)) break;
				r++;
				string tipo = "F";
				if (rbtVariavel.Checked) tipo = "V";
				result = titulos.Inclui(nf,
				               codigo,
							   edtUsuario.Text,
				               dtpEntrada.Value,
				               vencimento,
				               edtParceiro.Text,
				               natureza,
				               tipo,
				               pedidos,
				               valor,
				               dtpRecebimento.Checked,
				               dtpRecebimento.Value,
				               recebido,
				               forma,
				               pendencia,
				               edtObservacao.Text,
				               ckbCancelado.Checked ? "S" : "N",
				               edtMotivo.Text,
				               ref msg);
				codigo++;
				
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
	}
}
