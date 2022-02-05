/*
 * Projeto  : SoftPlace
 * Sistema  : Orcamentos
 * Programa : frmCadOrcamento - Inclusao/Alteracao de Orcamento
 * Autor    : Ricardo Costa Xavier
 * Data     : 29/05/08
 * 
 * 22/02/04 - não deixar alterar a tabela e a característica se orçamento estiver fechado
 *            a situação só poderá ser alterada de fechada pelo administrador
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using classes;
using basico;

namespace orcamento
{
	public partial class frmCadOrcamento : Form
	{
		public char acao;
		public string usuario;
		public string tabela;
		public string caracteristica;
		public string situacao;
		public string pedido;
		public bool result;
		private bool calculando;
		
		private bool juridica;
		private bool carregando;
		
		public string fornecedor;
		public string data;
		public string codigo;
		
		public bool alteracaoRestrita;
		
		public frmCadOrcamento()
		{
			InitializeComponent();
			carregando = true;
			result = false;
		}
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			Close();
		}

		private bool Confirma()
		{
			string fornecedor = edtFornecedor.Text.Trim();
			if (fornecedor.CompareTo("") == 0)
			{
				MessageBox.Show("Fornecedor", "Campo obrigatório", 
				                MessageBoxButtons.OK, 
				                MessageBoxIcon.Warning);
				edtFornecedor.Focus();
				return false;
			}
			if (cbxUsuarios.Text.Trim().Length == 0)
			{
				MessageBox.Show("Vendedor", "Campo obrigatório", 
				                MessageBoxButtons.OK, 
				                MessageBoxIcon.Warning);
				cbxUsuarios.Focus();
				return false;
			}
			if (edtCliente.Text.Trim().Length == 0)
			{
				MessageBox.Show("Cliente", "Campo obrigatório", 
				                MessageBoxButtons.OK, 
				                MessageBoxIcon.Warning);
				edtCliente.Focus();
				return false;
			}
			if (cbxTabelas.Text.Trim().Length == 0)
			{
				MessageBox.Show("Tabela Preços", "Campo obrigatório", 
				                MessageBoxButtons.OK, 
				                MessageBoxIcon.Warning);
				cbxTabelas.Focus();
				return false;
			}
			if (cbxCaracteristicas.Text.Trim().Length == 0)
			{
				MessageBox.Show("Característica Venda", "Campo obrigatório", 
				                MessageBoxButtons.OK, 
				                MessageBoxIcon.Warning);
				cbxCaracteristicas.Focus();
				return false;
			}
			string msg="";
			int codigo = 0;
			cOrcamentos orcamentos = new cOrcamentos();
			float per_consultor = Globais.StrToFloat(edtPerConsultor.Text);
			if (acao == 'i')
			{
				result = orcamentos.Inclui(fornecedor, dtpData.Value, cbxUsuarios.Text, edtCliente.Text, edtContato.Text, edtConsultor.Text, cbxTabelas.Text, cbxCaracteristicas.Text, edtResumo.Text, edtObservacao.Text, cbxSituacao.Text.Substring(0, 1), per_consultor, ref msg, ref codigo);
				edtCodigo.Text = codigo.ToString();
			}
			else
			{
				codigo =  Globais.StrToInt(edtCodigo.Text);
				result = orcamentos.Altera(fornecedor, dtpData.Value, codigo, cbxUsuarios.Text, edtCliente.Text, edtContato.Text, edtConsultor.Text, cbxTabelas.Text, cbxCaracteristicas.Text, Globais.StrToFloat(edtDesconto.Text), edtResumo.Text, edtObservacao.Text, cbxSituacao.Text.Substring(0, 1), per_consultor, ref msg);
			}
			if (!result)
			{
				if (acao == 'i')
					MessageBox.Show(edtCodigo.Text+"\n"+msg, "Erro na inclusão do orçamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
				else
					MessageBox.Show(edtCodigo.Text+"\n"+msg, "Erro na alteração do orçamento", MessageBoxButtons.OK, MessageBoxIcon.Error);				
			}
			return result;
		}
		
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			if (!Confirma()) return;
			fornecedor = edtFornecedor.Text.Trim();
			data = dtpData.Value.ToString().Trim();
			codigo =  edtCodigo.Text.Trim();
			result = true;
			Close();
		}
		
		void BtnFornecedorClick(object sender, EventArgs e)
		{
			cControleAcesso acesso = new cControleAcesso();
			/*
			if (!acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fConParceiros")) return;				
			frmConParceiros frm = new frmConParceiros();
			frm.ckbCliente.Checked = false;
			frm.ckbConsultor.Checked = false;
			frm.ShowDialog();
			if (frm.cancela) return;
			*/
				
			frmCadParceiros frmCad = new frmCadParceiros(true);
			//frmCad.where = frm.filtro;
			frmCad.where = "";
			frmCad.bFornecedores = true;
			frmCad.codigo = edtFornecedor.Text;
			frmCad.ReadOnly = !acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fCadParceiros");
			frmCad.ShowDialog();
			if (frmCad.result)
			{
				edtFornecedor.Text = frmCad.edtCodigo.Text;
				//CarregaCaracteristicas();
				SelecionaFornecedor();
			}
		}
		
		void BtnClienteClick(object sender, EventArgs e)
		{
			cControleAcesso acesso = new cControleAcesso();
			/*
			if (!acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fConParceiros")) return;				
			frmConParceiros frm = new frmConParceiros();
			frm.ckbFornecedor.Checked = false;
			frm.ckbConsultor.Checked = false;
			frm.ShowDialog();
			if (frm.cancela) return;
			*/
				
			frmCadParceiros frmCad = new frmCadParceiros(true);
			//frmCad.where = frm.filtro;
			frmCad.where = "";
			frmCad.bClientes = true;
			frmCad.codigo = edtCliente.Text;
			frmCad.ReadOnly = !acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fCadParceiros");
			frmCad.ShowDialog();
			if (frmCad.result)
				edtCliente.Text = frmCad.edtCodigo.Text;
		}
		
		void BtnConsultorClick(object sender, EventArgs e)
		{
			cControleAcesso acesso = new cControleAcesso();
			/*
			if (!acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fConParceiros")) return;				
			frmConParceiros frm = new frmConParceiros();
			frm.ckbFornecedor.Checked = false;
			frm.ckbCliente.Checked = false;
			frm.ShowDialog();
			if (frm.cancela) return;
			*/
				
			frmCadParceiros frmCad = new frmCadParceiros(true);
			//frmCad.where = frm.filtro;
			frmCad.where = "";
			frmCad.bConsultores = true;
			frmCad.codigo = edtConsultor.Text;
			frmCad.ReadOnly = !acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fCadParceiros");
			frmCad.ShowDialog();
			if (frmCad.result)
			{
				edtConsultor.Text = frmCad.edtCodigo.Text;
				juridica = frmCad.rbtJuridica.Checked;
			}
		}
		
		void BtnContatoClick(object sender, EventArgs e)
		{
			cControleAcesso acesso = new cControleAcesso();			
			//if (!acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fConParceiros")) return;			
			frmCadContatos frm = new frmCadContatos(true);
			frm.ReadOnly = !acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fCadParceiros");
			frm.parceiro = edtCliente.Text;
			cParceiros parceiros = new cParceiros();
			string des="", fisjur="";
			parceiros.Procura(edtCliente.Text, ref des, ref fisjur);
			frm.des_parceiro = des;
			frm.juridica = juridica;
			frm.ShowDialog();				
			edtContato.Text = frm.edtCodigo.Text;
			edtContato.Focus();
		}
		
		void FrmCadOrcamentoLoad(object sender, EventArgs e)
		{
			calculando = false;
			if (acao == 'i')
			{
				edtFornecedor.Text = "";
				edtCodigo.Text = "0";
				cbxUsuarios.Text = "";
				edtCliente.Text = "";
				edtContato.Text = "";
				edtConsultor.Text = "";
				cbxCaracteristicas.Text = "";
				cbxTabelas.Text = "";
				edtResumo.Text = "";
				edtObservacao.Text = "";
				cbxSituacao.Text = "";
				edtValor.Text = "0,00";
				edtPercent.Text = "0,00";
				edtDesconto.Text = "0,00";
				edtTotal.Text = "0,00";
				edtPerConsultor.Text = "0,00";
				edtVlrConsultor.Text = "0,00";
				//edtPercent.Enabled = false;
				//edtDesconto.Enabled = false;
			}
			
			cUsuarios usuarios = new cUsuarios();
			this.Cursor = Cursors.WaitCursor;
			usuarios.Carrega(cbxUsuarios);
			this.Cursor = Cursors.Default;
			cbxUsuarios.Text = Globais.sUsuario;

			cSituacoes situacoes = new cSituacoes();
			situacoes.Carrega(cbxSituacao);
			//cbxSituacao.Items.Add("Em Andamento");
			//cbxSituacao.Items.Add("Cancelado");
			//cbxSituacao.Items.Add("Substituido");
			//cbxSituacao.Items.Add("Fechado");
			cbxSituacao.Text = "3 BAIXA Probabilidade";
			
			if (acao == 'a')
			{
				this.Text = "Alteração de Orçamento";
				if (pedido.CompareTo("S") == 0) {
					cbxSituacao.Enabled = false;
					edtPercent.Enabled = false;
					edtDesconto.Enabled = false;
					edtPerConsultor.Enabled = false;
					edtVlrConsultor.Enabled = false;
				}
				edtFornecedor.Enabled = false;
				cbxUsuarios.Text = usuario;
				cCaracteristicas caracteristicas = new cCaracteristicas();
				cbxCaracteristicas.Items.Clear();
				this.Cursor = Cursors.WaitCursor;
				caracteristicas.Carrega(cbxCaracteristicas, edtFornecedor.Text);
				this.Cursor = Cursors.Default;
				cbxCaracteristicas.Text = caracteristica;
				foreach (string item in cbxCaracteristicas.Items)
				{
					if (item.Trim().CompareTo(caracteristica.Trim()) == 0)
					{
						cbxCaracteristicas.Text = item;
						break;
					}
				}
				VerificaLimiar();
				
				foreach (string s in cbxSituacao.Items)
				{
					if (situacao == s.Substring(2))
					{
						cbxSituacao.Text = s;
						break;
					}
				}
				/*
				switch (situacao[0])
				{
					case 'E': cbxSituacao.Text = "Em Andamento"; break;
					case 'C': cbxSituacao.Text = "Cancelado"; break;
					case 'S': cbxSituacao.Text = "Substituido"; break;
					case 'F': cbxSituacao.Text = "Fechado"; break;					
				}
				*/
				cTabelas tabelas = new cTabelas();
				this.Cursor = Cursors.WaitCursor;
				tabelas.Carrega(cbxTabelas, edtFornecedor.Text);
				this.Cursor = Cursors.Default;
				cbxTabelas.Text = tabela;
				
				if (situacao[0] == 'F')
				{
					cbxTabelas.Enabled = false;
					cbxCaracteristicas.Enabled = false;
					if (!Globais.bAdministrador)
					{
						cbxSituacao.Enabled = false;
						edtPercent.Enabled = false;
						edtDesconto.Enabled = false;
						edtPerConsultor.Enabled = false;
						edtVlrConsultor.Enabled = false;						
					}
				}
			}
			
			if (alteracaoRestrita)
			{
				edtFornecedor.Enabled= false;
				dtpData.Enabled = false;
				edtCodigo.Enabled = false;
				cbxUsuarios.Enabled = false;
				edtCliente.Enabled = false;
				edtContato.Enabled = false;
				edtConsultor.Enabled = false;
				cbxCaracteristicas.Enabled = false;
				edtValor.Enabled = false;
				edtPercent.Enabled = false;
				edtDesconto.Enabled = false;
				edtTotal.Enabled = false;
				edtPerConsultor.Enabled = false;
				edtVlrConsultor.Enabled = false;
				btnFornecedor.Enabled = false;
				btnCliente.Enabled = false;
				btnConsultor.Enabled = false;
				btnContato.Enabled = false;
				btnLimpaConsultor.Enabled = false;
				cbxTabelas.Enabled = false;
				btnItens.Enabled = false;
				
				edtResumo.Enabled = true;
				edtObservacao.Enabled = true;
				cbxSituacao.Enabled = true;				
			}
			
			carregando = false;			
		}
		
		void EdtFornecedorTextChanged(object sender, EventArgs e)
		{
		}
		
		void CalculaValores()
		{
			cOrcamentos orcamentos = new cOrcamentos();
			float valor = orcamentos.RecalculaTotal(edtFornecedor.Text, dtpData.Value, Globais.StrToShort(edtCodigo.Text), cbxCaracteristicas.Text.Trim(), "");
			edtValor.Text = valor.ToString("#,###,##0.00");
			float total;
			total = Globais.StrToFloat(edtValor.Text) - Globais.StrToFloat(edtDesconto.Text);// - Globais.StrToFloat(edtVlrConsultor.Text);
			edtTotal.Text = total.ToString("#,###,##0.00");
		}
		
		void VerificaLimiar()
		{
			cCaracteristicas caracteristicas = new cCaracteristicas();				
			float limiar = caracteristicas.Limiar(edtFornecedor.Text.Trim(), cbxCaracteristicas.Text.Trim());
			float per = Globais.StrToFloat(edtPercent.Text) + Globais.StrToFloat(edtPerConsultor.Text);
			if (per > limiar)
				edtPercent.BackColor = Color.Red;
			else
			if (per < limiar)
				edtPercent.BackColor = Color.Green;
			else
				edtPercent.BackColor = Color.Yellow;
		}
		
		void CbxCaracteristicasSelectedIndexChanged(object sender, EventArgs e)
		{
			cCaracteristicas caracteristicas = new cCaracteristicas();
			if (edtObservacao.Text.Trim().Length == 0)
			{
				edtObservacao.Text = caracteristicas.Observacao(edtFornecedor.Text, cbxCaracteristicas.SelectedItem.ToString());
			}
			float per_comissao = Globais.StrToFloat(edtPerConsultor.Text);
			if ((per_comissao == 0) && (acao == 'i') && (edtConsultor.Text.Trim().Length > 0))
			{
				per_comissao  = caracteristicas.ComissaoConsultor(edtFornecedor.Text, cbxCaracteristicas.SelectedItem.ToString());
				edtPerConsultor.Text = per_comissao.ToString("#0.00");
			}
			CalculaValores();
		}
		
		void BtnItensClick(object sender, EventArgs e)
		{
			if (!Confirma()) return;
			acao = 'a';
			short codigo = Globais.StrToShort(edtCodigo.Text);
			string fornecedor = edtFornecedor.Text;
			DateTime data = dtpData.Value;
			string cliente = edtCliente.Text;
			frmCadItens frm = new frmCadItens();
			frm.pedido = (pedido != null) && pedido.Equals("S");
			frm.fornecedor = fornecedor;
			cCaracteristicas caracteristicas = new cCaracteristicas();				
			frm.formula = caracteristicas.Formula(fornecedor, cbxCaracteristicas.Text);
			frm.data = data;
			frm.cod_orcamento = codigo;
			frm.cliente = cliente;
			frm.tabela = cbxTabelas.Text;
			frm.ShowDialog();
			CalculaValores();
			string salva;
			salva = edtPercent.Text;
			calculando = true;
			edtPercent.Text = "";
			calculando = false;
			edtPercent.Text = salva;
			salva = edtPerConsultor.Text;
			calculando = true;
			edtPerConsultor.Text = "";
			calculando = false;
			edtPerConsultor.Text = salva;
		}
		
		void EdtDescontoTextChanged(object sender, EventArgs e)
		{
			if (calculando) return;
			float total;
			float valor;
			float desconto;
			//float comissao;
			if (!float.TryParse(edtValor.Text, out valor)) return;
			if (!float.TryParse(edtDesconto.Text, out desconto)) return;
			//if (!float.TryParse(edtVlrConsultor.Text, out comissao)) return;
			calculando = true;			
			total = valor - desconto;// - comissao;
			float percent = (valor > 0) ? (desconto * 100F / valor) : 0;
			edtTotal.Text = total.ToString("#,###,##0.00");
			edtPercent.Text = percent.ToString("#0.00");
			calculando = false;
			VerificaLimiar();
		}
		
		void EdtPercentTextChanged(object sender, EventArgs e)
		{
			if (calculando) return;
			float total;
			float valor;
			float percent;
			//float comissao;
			if (!float.TryParse(edtValor.Text, out valor)) return;
			if (!float.TryParse(edtPercent.Text, out percent)) return;
			//if (!float.TryParse(edtVlrConsultor.Text, out comissao)) return;
			calculando = true;			
			float desconto = valor * percent / 100.00F;
			total = valor - desconto;// - comissao;
			edtTotal.Text = total.ToString("#,###,##0.00");
			edtDesconto.Text = desconto.ToString("#,###,##0.00");			
			calculando = false;
			VerificaLimiar();
		}
		
		void EdtDescontoKeyPress(object sender, KeyPressEventArgs e)
		{
			TextBox edt = (TextBox)sender;
			if ((e.KeyChar == ',') && !edt.Text.Contains(","))
			{
				e.Handled = false;
				return;
			}
			if ((e.KeyChar == '-') && !edt.Text.Contains("-"))
			{
				if (edt.SelectionStart == 0)
				{
					e.Handled = false;
					return;
				}
			}			
			if (e.KeyChar > 31 && (e.KeyChar < '0' || e.KeyChar > '9'))
			{
				e.Handled = true;
				return;
			}
		}
		
		void EdtPerConsultorTextChanged(object sender, EventArgs e)
		{
			if (calculando) return;
			float total;
			float valor;
			float desconto;
			float percent;
			if (!float.TryParse(edtValor.Text, out valor)) return;
			if (!float.TryParse(edtDesconto.Text, out desconto)) return;
			if (!float.TryParse(edtPerConsultor.Text, out percent)) return;
			calculando = true;			
			float comissao = valor * percent / 100.00F;
			total = valor - desconto;// - comissao;
			edtTotal.Text = total.ToString("#,###,##0.00");
			edtVlrConsultor.Text = comissao.ToString("#,###,##0.00");			
			calculando = false;
			VerificaLimiar();
		}
		
		void EdtVlrConsultorTextChanged(object sender, EventArgs e)
		{
			if (calculando) return;
			float total;
			float valor;
			float desconto;
			float comissao;
			if (!float.TryParse(edtValor.Text, out valor)) return;
			if (!float.TryParse(edtDesconto.Text, out desconto)) return;
			if (!float.TryParse(edtVlrConsultor.Text, out comissao)) return;
			calculando = true;			
			total = valor - desconto;// - comissao;
			float percent = (valor > 0) ? (comissao * 100F / valor) : 0;
			edtTotal.Text = total.ToString("#,###,##0.00");
			edtPerConsultor.Text = percent.ToString("#0.00");
			calculando = false;
			VerificaLimiar();
		}

		void CarregaCaracteristicas()
		{
			cCaracteristicas caracteristicas = new cCaracteristicas();
			cbxCaracteristicas.Items.Clear();
			this.Cursor = Cursors.WaitCursor;
			caracteristicas.Carrega(cbxCaracteristicas, edtFornecedor.Text);
			this.Cursor = Cursors.Default;
		}
		
		void BtnNovoClick(object sender, EventArgs e)
		{
			fClienteBasico frmCad = new fClienteBasico();
			frmCad.ShowDialog();
			if (frmCad.result)
				edtCliente.Text = frmCad.edtCodigo.Text;
		}
		
		void SelecionaFornecedor()
		{
			if (edtFornecedor.Text.Trim().Length == 0) return;
			Parceiro parceiro = new Parceiro();
			if (!parceiro.Le(edtFornecedor.Text)) {
				MessageBox.Show(edtFornecedor.Text, "Fornecedor não cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
				edtFornecedor.Focus();
				return;
			}
			cCaracteristicas caracteristicas = new cCaracteristicas();
			cbxCaracteristicas.Items.Clear();
			this.Cursor = Cursors.WaitCursor;
			caracteristicas.Carrega(cbxCaracteristicas, edtFornecedor.Text);
			this.Cursor = Cursors.Default;
			cTabelas tabelas = new cTabelas();
			this.Cursor = Cursors.WaitCursor;
			tabelas.Carrega(cbxTabelas, edtFornecedor.Text);
			this.Cursor = Cursors.Default;
			if (acao == 'a')
				cbxTabelas.Text = tabela;
			else
			{
				if (cbxTabelas.Items.Count > 0)
					cbxTabelas.Text = cbxTabelas.Items[cbxTabelas.Items.Count-1].ToString();
				else
					cbxTabelas.Text = "";				
			}
		}
		
		void EdtFornecedorLeave(object sender, EventArgs e)
		{
			SelecionaFornecedor();
		}
		
		void EdtConsultorTextChanged(object sender, EventArgs e)
		{
			cCaracteristicas caracteristicas = new cCaracteristicas();
			float per_comissao = Globais.StrToFloat(edtPerConsultor.Text);
			if ((per_comissao == 0) && (acao == 'i') && (edtConsultor.Text.Trim().Length > 0))
			{
				per_comissao  = caracteristicas.ComissaoConsultor(edtFornecedor.Text, cbxCaracteristicas.Text);
				edtPerConsultor.Text = per_comissao.ToString("#0.00");
			}
			CalculaValores();
		}
		
		void CbxTabelasSelectedIndexChanged(object sender, EventArgs e)
		{
			if (carregando) return;
			cOrcamentos orcamentos = new cOrcamentos();
			if (cbxCaracteristicas.Text.Trim().Length == 0)
			{
				return;
			}
			float valor = orcamentos.RecalculaTotal(edtFornecedor.Text, dtpData.Value, Globais.StrToShort(edtCodigo.Text), cbxCaracteristicas.Text.Trim(), cbxTabelas.Text.Trim());
			edtValor.Text = valor.ToString("#,###,##0.00");
			float total;
			total = Globais.StrToFloat(edtValor.Text) - Globais.StrToFloat(edtDesconto.Text);// - Globais.StrToFloat(edtVlrConsultor.Text);
			edtTotal.Text = total.ToString("#,###,##0.00");
		}
		
		void EdtVlrConsultorKeyPress(object sender, KeyPressEventArgs e)
		{
			TextBox edt = (TextBox)sender;
			if ((e.KeyChar == ',') && !edt.Text.Contains(","))
			{
				e.Handled = false;
				return;
			}
			if ((e.KeyChar == '-') && !edt.Text.Contains("-"))
			{
				if (edt.SelectionStart == 0)
				{
					e.Handled = false;
					return;
				}
			}			
			if (e.KeyChar > 31 && (e.KeyChar < '0' || e.KeyChar > '9'))
			{
				e.Handled = true;
				return;
			}			
		}
		
		void BtnLimpaConsultorClick(object sender, EventArgs e)
		{
			edtConsultor.Text = "";
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
	}
}
