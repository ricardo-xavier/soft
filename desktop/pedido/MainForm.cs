/*
 * Projeto  : SoftPlace
 * Sistema  : Pedidos
 * Programa : MainForm - Tela Inicial
 * Autor    : Ricardo Costa Xavier
 * Data     : 04/02/09
 * 
 * Histórico:
 * 19/06/2013 - passagem de parâmetros para pagar corrigida para passar todos os títulos
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using templates;
using classes;
using basico;
using FirebirdSql.Data.FirebirdClient;
using System.Threading;
using orcamento;
using System.Data;
using System.Collections;

namespace pedido
{
	public partial class MainForm : Form
	{
		private frmFiltroPedido frmFiltro;
		static bool login;
		string filtro_dinheiro;
		private string col_sorted;
		private SortOrder ord_sorted;		
		private string chave_sel;
		
		[STAThread]
		public static void Main(string[] args)
		{
			if (args.Length > 0) 
			{
				login = false;
				Globais.sUsuario = args[0];
				Globais.sFilial = args[1];
				Globais.bAdministrador = args[2][0] == 'S';
			}
			else login = true;
			
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
		public MainForm()
		{
			InitializeComponent();
			toolTip1.SetToolTip(button1, "Selecionar pedidos entregues não recebidos");
			toolTip1.SetToolTip(btnPendenteConsultor, "Selecionar pedidos sem acerto % consultor");
			toolTip1.SetToolTip(btnPendenteVendedor, "Selecionar pedidos sem acerto % vendedor");
			Grid.Inicializa();
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			edtRacional.SetBounds(241, 470, edtRacional.Width, edtRacional.Height);
			dgvTitulos.SetBounds(398, 430, dgvTitulos.Width, dgvTitulos.Height);
			filtro_dinheiro = "";
			string sBanco="";
			string sUltimoUsuario="";
			string sUltimaFilial="";

			Globais.CarregaIni(ref sBanco, ref sUltimoUsuario, ref sUltimaFilial);
			string parametros = "User=SYSDBA;" +
								"Password=masterkey;" +
								"Database=" + sBanco;
			Globais.bd = new FbConnection(parametros);
			try
			{
				Log.Grava(Globais.sUsuario, parametros);
				Globais.bd.Open();
				//Trace.Verifica();
			}
			catch (Exception err)
			{
				Log.Grava(Globais.sUsuario, "erro:" + err.Message);
				MessageBox.Show("Erro na conexão com o banco de dados:\n" + sBanco +
				                "\n" + err.Message);
				Close();
				return;
			}						

			if (login)
			{
				frmLogin frm = new frmLogin();
				frm.admin = false;
				frm.sUltimoUsuario = sUltimoUsuario;
				frm.sUltimaFilial = sUltimaFilial;
				frm.ShowDialog();
				if (!frm.bOK)
				{
					Close();
					return;
				}
				else 
				{
					Globais.GravaIni(sBanco, sUltimoUsuario, sUltimaFilial);
				}
			
				cControleAcesso acesso = new cControleAcesso();
				if (!Globais.bAdministrador &&  !acesso.PermissaoSistema(Globais.sUsuario, Globais.sFilial, 7))			
				{
					MessageBox.Show("Usuário sem permissão para esse Sistema", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
					Close();
				}
			}
			
			cCondicoesPagto condicoes = new cCondicoesPagto();
			this.Cursor = Cursors.WaitCursor;
			condicoes.CarregaComDescricao(cbxCondicoesPagto);
			this.Cursor = Cursors.Default;
			frmFiltro = new frmFiltroPedido();
			frmFiltro.fornecedor = "";
			frmFiltro.vendedor = "";			
			frmFiltro.idt_dataI = "N";
			frmFiltro.dataI = DateTime.Now;
			frmFiltro.idt_dataF = "N";
			frmFiltro.dataF = DateTime.Now;
			frmFiltro.idt_ou_entrega = "N";
			frmFiltro.idt_nao_entregues = "N";
			frmFiltro.dias_nao_entregues = 0;
			frmFiltro.idt_entrega_previstaI = "N";
			frmFiltro.entrega_previstaI = DateTime.Now;
			frmFiltro.idt_entrega_previstaF = "N";
			frmFiltro.entrega_previstaF = DateTime.Now;
			frmFiltro.idt_entrega_realI = "N";
			frmFiltro.entrega_realI = DateTime.Now;
			frmFiltro.idt_entrega_realF = "N";
			frmFiltro.entrega_realF = DateTime.Now;
			frmFiltro.idt_ou_montagem = "N";
			frmFiltro.idt_nao_montados = "N";
			frmFiltro.dias_nao_montados = 0;			
			frmFiltro.idt_montagem_previstaI = "N";
			frmFiltro.montagem_previstaI = DateTime.Now;
			frmFiltro.idt_montagem_previstaF = "N";
			frmFiltro.montagem_previstaF = DateTime.Now;
			frmFiltro.idt_montagem_realI = "N";
			frmFiltro.montagem_realI = DateTime.Now;
			frmFiltro.idt_montagem_realF = "N";
			frmFiltro.montagem_realF = DateTime.Now;
			frmFiltro.idt_omitir_anos_anteriores = "S";
			frmFiltro.idt_sem_previsao = "N";
			frmFiltro.idt_pendentes_consultor = "N";			
			frmFiltro.idt_pendentes_vendedor = "N";						
			frmFiltro.cliente = "";
			frmFiltro.consultor = "";
			frmFiltro.pedido_fornec = "0";
			frmFiltro.nf_fornec = "0";
			frmFiltro.observacao = "";
			frmFiltro.idt_cadastroI = "N";
			frmFiltro.cadastroI = DateTime.Now;
			frmFiltro.idt_cadastroF = "N";
			frmFiltro.cadastroF = DateTime.Now;
			frmFiltro.vlr_inicial = "";
			frmFiltro.vlr_final = "";			
			frmFiltro.numero_pedido = "";
			frmFiltro.caracteristica = "";
			CarregaPedidos();	
			col_sorted = "";
			ord_sorted = SortOrder.Ascending;			
			HabilitaEdicao(false);
			btnConfirma.SetBounds(btnConfirma.Location.X, btnConfirma.Location.Y+32, btnConfirma.Width, btnConfirma.Height);
			btnCancela.SetBounds(btnCancela.Location.X, btnCancela.Location.Y+32, btnCancela.Width, btnCancela.Height);
			//btnListaComissao.SetBounds(btnComissao.Location.X, btnComissao.Location.Y-32, btnComissao.Width, btnComissao.Height);
			btnComissao.SetBounds(btnCancela.Location.X, btnCancela.Location.Y-32, btnCancela.Width, btnCancela.Height);			
			if (dgvCadastro.Rows.Count == 0) return;
			edtSinal.Text = dgvCadastro.Rows[0].Cells["Sinal"].Value.ToString().Trim();
			edtSinal.BackColor = dgvCadastro.Rows[0].Cells["Sinal"].Style.BackColor;
		}
		
		void CarregaPedidos()
		{
			//DateTime t1 = DateTime.Now;
			cPedidos pedidos = new cPedidos();
			this.Cursor = Cursors.WaitCursor;
			pedidos.Carrega(dgvCadastro,
							frmFiltro.fornecedor,
							frmFiltro.vendedor,
							frmFiltro.idt_ou_entrega,
							frmFiltro.idt_nao_entregues,
							frmFiltro.dias_nao_entregues,
							frmFiltro.idt_entrega_previstaI,
							frmFiltro.entrega_previstaI,
							frmFiltro.idt_entrega_previstaF,
							frmFiltro.entrega_previstaF,
							frmFiltro.idt_entrega_realI,
							frmFiltro.entrega_realI,
							frmFiltro.idt_entrega_realF,
							frmFiltro.entrega_realF,
							frmFiltro.idt_ou_montagem,
							frmFiltro.idt_nao_montados,
							frmFiltro.dias_nao_montados,							
							frmFiltro.idt_montagem_previstaI,
							frmFiltro.montagem_previstaI,
							frmFiltro.idt_montagem_previstaF,
							frmFiltro.montagem_previstaF,
							frmFiltro.idt_montagem_realI,
							frmFiltro.montagem_realI,
							frmFiltro.idt_montagem_realF,
							frmFiltro.montagem_realF,
							frmFiltro.cliente,
							frmFiltro.consultor,
							filtro_dinheiro, 
							"",
							frmFiltro.pedido_fornec,
							frmFiltro.nf_fornec,
							frmFiltro.observacao,
							frmFiltro.idt_dataI,
							frmFiltro.dataI,
							frmFiltro.idt_dataF,
							frmFiltro.dataF,
							frmFiltro.idt_omitir_anos_anteriores,
							frmFiltro.idt_sem_previsao,
							frmFiltro.idt_pendentes_consultor,
							frmFiltro.idt_pendentes_vendedor,
							frmFiltro.idt_cadastroI,
							frmFiltro.cadastroI,
							frmFiltro.idt_cadastroF,
							frmFiltro.cadastroF,
							frmFiltro.vlr_inicial,
							frmFiltro.vlr_final,
							frmFiltro.numero_pedido,
							frmFiltro.caracteristica);
			this.Cursor = Cursors.Default;
			foreach (DataGridViewRow row in dgvCadastro.Rows)
			{
				row.Cells["S"].Value = false;			
			}
			//DateTime t2 = DateTime.Now;
			//TimeSpan ts = t2.Subtract(t1);
			//MessageBox.Show("Carrega:" + ts.TotalSeconds.ToString());			
			Colore();
			if (dgvCadastro.Rows.Count == 0) {
				LimpaDetalhes();
			} else {
				dgvAnexos.Visible = true;
			}
		}
		
		void BtnFechaClick(object sender, EventArgs e)
		{
			Close();
		}
		
		short CodOrcamento(string orcamento)
		{
			if (orcamento.Contains("/"))
				return Globais.StrToShort(orcamento.Substring(10));
			else
				return Globais.StrToShort(orcamento);
		}
		
		void BtnExcluiClick(object sender, EventArgs e)
		{
			if (dgvCadastro.Rows.Count == 0) return;
			int i = dgvCadastro.CurrentRow.Index;
			short codigo = Globais.StrToShort(dgvCadastro.Rows[i].Cells["CodPedido"].Value.ToString());
			DateTime data = DateTime.Parse(dgvCadastro.Rows[i].Cells["Data"].Value.ToString());
			DateTime hoje = DateTime.Now;
			if (data.Date != hoje.Date) {
				if (!Globais.bAdministrador) {
					MessageBox.Show("Esse pedido só pode ser excluído pelo administrador");
					return;
				}
			}
			DialogResult r = MessageBox.Show(codigo.ToString(), "Confirma a exclusão?",
			                                 MessageBoxButtons.YesNo, 
			                                 MessageBoxIcon.Question);
			if (r == DialogResult.No) return;	
			
			string fornecedor = dgvCadastro.Rows[i].Cells["Fornecedor Orçamento"].Value.ToString().Trim();
			short orcamento = CodOrcamento(dgvCadastro.Rows[i].Cells["Orçamento"].Value.ToString());
		
			cPedidos pedidos = new cPedidos();
			if (pedidos.Exclui(fornecedor, data, orcamento))
			{
				string msg="";
				CarregaPedidos();
				Grid.Sort(dgvCadastro, col_sorted, ord_sorted);
				cOrcamentos orc = new cOrcamentos();
				orc.AlteraStatus(fornecedor, data, orcamento, 'E', ref msg);
				orc.AlteraPedido(fornecedor, data, orcamento, 'N');
			}
		}
		
		void DgvCadastroRowEnter(object sender, DataGridViewCellEventArgs e)
		{
			int i=e.RowIndex;
			edtSinal.Text = dgvCadastro.Rows[i].Cells["Sinal"].Value.ToString().Trim();
			edtSinal.BackColor = dgvCadastro.Rows[i].Cells["Sinal"].Style.BackColor;
			edtUsuario.Text = dgvCadastro.Rows[i].Cells["Usuário"].Value.ToString().Trim();			
			dtpEntregaPrevista.Value = DateTime.Parse(dgvCadastro.Rows[i].Cells["Data Entrega"].Value.ToString().Trim());
			chkEntregaPrevista.Checked = dgvCadastro.Rows[i].Cells["IDT Data Entrega"].Value.ToString().Trim().CompareTo("S") == 0;
			dtpEntregaReal.Value = DateTime.Parse(dgvCadastro.Rows[i].Cells["Data Real Entrega"].Value.ToString().Trim());
			chkEntregaReal.Checked = dgvCadastro.Rows[i].Cells["IDT Data Real Entrega"].Value.ToString().Trim().CompareTo("S") == 0;
			dtpMontagemPrevista.Value = DateTime.Parse(dgvCadastro.Rows[i].Cells["Data Montagem"].Value.ToString().Trim());
			chkMontagemPrevista.Checked = dgvCadastro.Rows[i].Cells["IDT Data Montagem"].Value.ToString().Trim().CompareTo("S") == 0;
			dtpMontagemReal.Value = DateTime.Parse(dgvCadastro.Rows[i].Cells["Data Real Montagem"].Value.ToString().Trim());
			chkMontagemReal.Checked = dgvCadastro.Rows[i].Cells["IDT Data Real Montagem"].Value.ToString().Trim().CompareTo("S") == 0;
			edtObservacao.Text = dgvCadastro.Rows[i].Cells["Observação"].Value.ToString().Trim();
			edtCaracteristica.Text = dgvCadastro.Rows[i].Cells["Característica"].Value.ToString().Trim();
			edtPedidoFornec.Text = dgvCadastro.Rows[i].Cells["Pedido Fornec"].Value.ToString().Trim();
			edtNFFornec.Text = dgvCadastro.Rows[i].Cells["NF Fornec"].Value.ToString().Trim();
			//edtSeqFornec.Text = dgvCadastro.Rows[i].Cells["Seq Fornec"].Value.ToString().Trim();
			dtpAlteracao.Value = DateTime.Parse(dgvCadastro.Rows[i].Cells["Data Alteração"].Value.ToString().Trim());			
			string condicao = dgvCadastro.Rows[i].Cells["Condição Pagto"].Value.ToString().Trim();
			cbxCondicoesPagto.Text = "";
			foreach (string item in cbxCondicoesPagto.Items)
			{
				string cod_condicao=item.Trim();
				if (cod_condicao.Length > 10)
				{
					cod_condicao =	item.Substring(0,10).Trim();
				}
				if (cod_condicao.CompareTo(condicao) == 0)
				{
					cbxCondicoesPagto.Text = item;
					break;
				}
			}
			edtTransportadora.Text = dgvCadastro.Rows[i].Cells["Transportadora"].Value.ToString().Trim();
			float valor_frete = Globais.StrToFloat(dgvCadastro.Rows[i].Cells["Valor Frete"].Value.ToString());
			edtValorFrete.Text = valor_frete.ToString("#,###,##0.00");
			if (dgvCadastro.Rows[i].Cells["Frete"].Value.ToString().Trim().CompareTo("C") == 0)
			{
				rbtCliente.Checked = true;
				rbtFornecedor.Checked = false;
			}
			else
			{
				rbtCliente.Checked = false;
				rbtFornecedor.Checked = true;
			}
			
			string fornecedor = dgvCadastro.Rows[i].Cells["Fornecedor Orçamento"].Value.ToString().Trim();
			DateTime data = DateTime.Parse(dgvCadastro.Rows[i].Cells["Data"].Value.ToString().Trim());
			short orcamento = CodOrcamento(dgvCadastro.Rows[i].Cells["Orçamento"].Value.ToString());
			CarregaAnexos(fornecedor, data, orcamento);			
			
			string caracteristica = dgvCadastro.Rows[i].Cells["Característica"].Value.ToString().Trim();			
			float sinal = Globais.StrToFloat(dgvCadastro.Rows[i].Cells["Sinal"].Value.ToString());
			float valor = Globais.StrToFloat(dgvCadastro.Rows[i].Cells["Valor"].Value.ToString());
			cComissaoLimiar comissao = new cComissaoLimiar();
			float per_comissao = comissao.Calcula(fornecedor, caracteristica, valor, sinal);
			edtPerCV.Text = per_comissao.ToString("#0.00");
			edtVlrCV.Text = (per_comissao * valor / 100f).ToString("###,##0.00");
			//cCaracteristicas caracteristicas = new cCaracteristicas();
			//per_comissao  = caracteristicas.ComissaoConsultor(fornecedor, caracteristica);
			per_comissao  = Globais.StrToFloat(dgvCadastro.Rows[i].Cells["Comissão Consultor"].Value.ToString());
			edtPerCC.Text = per_comissao.ToString("#0.00");
			edtVlrCC.Text = (per_comissao * valor / 100f).ToString("###,##0.00");
		}
		
		void LimpaDetalhes()
		{
			edtSinal.Text = "";
			edtUsuario.Text = "";
			dtpEntregaPrevista.Value = DateTime.Now;
			chkEntregaPrevista.Checked = false;
			dtpEntregaReal.Value = DateTime.Now;
			chkEntregaReal.Checked = false;
			dtpMontagemPrevista.Value = DateTime.Now;
			chkMontagemPrevista.Checked = false;
			dtpMontagemReal.Value = DateTime.Now;
			chkMontagemReal.Checked = false;
			edtObservacao.Text = "";
			edtCaracteristica.Text = "";
			edtPedidoFornec.Text = "";
			edtNFFornec.Text = "";
			dtpAlteracao.Value = DateTime.Now;
			cbxCondicoesPagto.Text = "";
			edtTransportadora.Text = "";
			edtValorFrete.Text = "";
			DateTime data = DateTime.Now;
			dgvAnexos.Visible = false;
			edtPerCV.Text = "";
			edtVlrCV.Text = "";
			edtPerCC.Text = "";
			edtVlrCC.Text = "";
		}		
		
		void HabilitaEdicao(bool habilita)
		{
			//dtpEntregaPrevista.Enabled = habilita;
			//dtpEntregaReal.Enabled = habilita;
			//dtpMontagemPrevista.Enabled = habilita;
			//dtpMontagemReal.Enabled = habilita;
			//dtpAlteracao.Enabled = habilita;			
			edtUsuario.ReadOnly = !habilita;
			cbxCondicoesPagto.Enabled = habilita;
			edtTransportadora.ReadOnly = !habilita;
			rbtCliente.Enabled = habilita;
			rbtFornecedor.Enabled = habilita;
			btnTransportadora.Enabled = habilita;
			edtObservacao.ReadOnly = !habilita;
			edtPedidoFornec.ReadOnly = !habilita;
			edtNFFornec.ReadOnly = !habilita;
			//edtSeqFornec.Enabled = habilita;
			dgvCadastro.Enabled = !habilita;
			edtLocaliza.Enabled = !habilita;
			btnFiltro.Enabled = !habilita;
			btnExclui.Visible = !habilita;
			btnXeceber.Visible = !habilita;
			btnPagar.Visible = !habilita;			
			btnAlteraValor.Visible = !habilita;			
			btnAltera.Visible = !habilita;
			btnItens.Visible = !habilita;
			btnImprime.Visible = !habilita;
			btnFecha.Visible = !habilita;
			btnConfirma.Visible = habilita;
			btnCancela.Visible = habilita;
			btnComissao.Visible = !habilita;
			//btnListaComissao.Visible = !habilita;
			chkTodos.Visible = !habilita;
		}
		
		private void Colore()
		{
			//DateTime t1 = DateTime.Now;
			double total = 0;
			int    registros=0;
			foreach (DataGridViewRow row in dgvCadastro.Rows)
			{
				DataGridViewCell cell = row.Cells["Sinal"];
				cell.Style.BackColor = Color.Yellow;
				cell.Style.SelectionBackColor = Color.Yellow;
				cell.Value = "0";
				
				row.Cells["A"].Value = "N";
				
				if (row.Cells["Recebido"].Value.ToString().CompareTo("S") == 0)
					row.Cells["R"].Value = "S";
				
				if (row.Cells["Data"].Value != null)
				{
					if (!row.Cells["Orçamento"].Value.ToString().Contains("/"))
					{
						int mes = DateTime.Parse(row.Cells["Data"].Value.ToString()).Month;
						int ano = DateTime.Parse(row.Cells["Data"].Value.ToString()).Year;
						string s = mes.ToString("0#") + "/" + ano.ToString("####") + " - "  + row.Cells["Orçamento"].Value.ToString();
						row.Cells["Orçamento"].Value = s;
					}
				}
				
				char idt_real;
				char idt_prevista;
				
				idt_real = row.Cells["IDT Data Real Entrega"].Value.ToString()[0];
				if (idt_real == 'S')
				{
					row.Cells["Entrega"].Value = DateTime.Parse(row.Cells["Data Real Entrega"].Value.ToString()).ToString("d/M/yyyy");
					row.Cells["Entrega"].Style.BackColor = Color.Gray;
				}
				else
				{
					idt_prevista = row.Cells["IDT Data Entrega"].Value.ToString()[0];					
					row.Cells["Entrega"].Value = DateTime.Parse(row.Cells["Data Entrega"].Value.ToString()).ToString("d/M/yyyy");
					if (idt_prevista == 'S')
						row.Cells["Entrega"].Style.BackColor = Color.FromArgb(192, 192, 0);
					else
						row.Cells["Entrega"].Style.BackColor = Color.White;
				}
				
				idt_real = row.Cells["IDT Data Real Montagem"].Value.ToString()[0];
				if (idt_real == 'S')
				{
					row.Cells["Montagem"].Value = DateTime.Parse(row.Cells["Data Real Montagem"].Value.ToString()).ToString("d/M/yyyy");
					row.Cells["Montagem"].Style.BackColor = Color.Gray;
				}
				else
				{
					idt_prevista = row.Cells["IDT Data Montagem"].Value.ToString()[0];					
					row.Cells["Montagem"].Value = DateTime.Parse(row.Cells["Data Montagem"].Value.ToString()).ToString("d/M/yyyy");
					if (idt_prevista == 'S')
						row.Cells["Montagem"].Style.BackColor = Color.FromArgb(192, 192, 0);
					else
						row.Cells["Montagem"].Style.BackColor = Color.White;
				}
				
				if (row.Cells["Valor"].Value != null)
				{
					float valor = Globais.StrToFloat(row.Cells["Valor"].Value.ToString());
					total += valor;

				}
				if (row.Cells["CodPedido"].Value != null)
				{
					short pedido = Globais.StrToShort(row.Cells["CodPedido"].Value.ToString());
					if (pedido == 2)
					{
						row.Cells["Fornecedor"].Value = "SERVICO";
					}
				}

				if (row.Cells["Valor Itens"].Value != null)
				{
					float vlr_itens = Globais.StrToFloat(row.Cells["Valor Itens"].Value.ToString());
					float vlr_desconto = Globais.StrToFloat(row.Cells["Desconto"].Value.ToString());
					// colore de acordo com o limiar da caracteristica
					if ((row.Cells["Fornecedor Orçamento"].Value != null) &&
					    (row.Cells["Característica"].Value != null))
					{
						float per_consultor = Globais.StrToFloat(row.Cells["Comissão Consultor"].Value.ToString());
						string fornecedor = row.Cells["Fornecedor Orçamento"].Value.ToString().Trim();
						string caracteristica = row.Cells["Característica"].Value.ToString().Trim();
						float limiar = Globais.StrToFloat(row.Cells["Limiar"].Value.ToString());
						cOrcamentos orcamento = new cOrcamentos();
						float sinal = orcamento.CalculaSinal(fornecedor, caracteristica, vlr_itens, vlr_desconto, per_consultor, limiar);
						cell.Value = sinal.ToString("#0.00");
						cell.Style.BackColor = Color.Yellow;
						cell.Style.SelectionBackColor = Color.Yellow;
						if (sinal > 0)
						{
							cell.Style.BackColor = Color.Green;
							cell.Style.SelectionBackColor = Color.Green;
						}
						else
						if (sinal < 0)
						{
							cell.Style.BackColor = Color.Red;
							cell.Style.SelectionBackColor = Color.Red;
						}
			
						/*
						string servico="";
						cCaracteristicas caracteristicas = new cCaracteristicas();
						DateTime data = DateTime.Parse(row.Cells["Data"].Value.ToString().Trim());
						short cod_orcamento = CodOrcamento(row.Cells["Orçamento"].Value.ToString());
						short codigo = short.Parse(row.Cells["CodPedido"].Value.ToString().Trim());
						float dif = caracteristicas.DiferencaFormulas(fornecedor, caracteristica, data, cod_orcamento, ref servico);
						float valor = Globais.StrToFloat(row.Cells["Valor"].Value.ToString());
						float valor_itens = Globais.StrToFloat(row.Cells["Valor Itens"].Value.ToString());
						float valor_desconto = Globais.StrToFloat(row.Cells["Desconto"].Value.ToString());
						float valor_esperado_produtos=valor_itens-valor_desconto;
						float valor_esperado_servicos=0;
						if (dif > 0)
						{
							valor_esperado_produtos = valor_itens - dif;
							valor_esperado_servicos = dif - valor_desconto;							
						}
						if (codigo == 1) 
						{
							dif = valor - valor_esperado_produtos;
							cPedidos.AlteraValorInicial(fornecedor, data, cod_orcamento, codigo, valor_esperado_produtos);
						}
						else
						{
							dif = valor - valor_esperado_servicos;
							cPedidos.AlteraValorInicial(fornecedor, data, cod_orcamento, codigo, valor_esperado_servicos);
						}
						*/

						float valor = Globais.StrToFloat(row.Cells["Valor"].Value.ToString());
						float valor_inicial = Globais.StrToFloat(row.Cells["Valor Inicial"].Value.ToString());
						float dif = valor - valor_inicial;
						
						if ((dif > 0.01) || (dif < -0.01))							
							row.Cells["A"].Value = "S " + valor_inicial.ToString("#,###,##0.00");
					}
				}
				registros++;
			}
			edtTotal.Text = total.ToString("#,###,##0.00");
			edtRegistros.Text = registros.ToString();
			//DateTime t2 = DateTime.Now;
			//TimeSpan ts = t2.Subtract(t1);
			//MessageBox.Show("Colore:" + ts.TotalSeconds.ToString());
		}
		
		void BtnAlteraClick(object sender, EventArgs e)
		{
			HabilitaEdicao(true);
			dtpEntregaPrevista.Focus();
		}
		
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			if (dgvCadastro.Rows.Count == 0) return;
			int i = dgvCadastro.CurrentRow.Index;
			string msg="";
			string fornecedor = dgvCadastro.Rows[i].Cells["Fornecedor Orçamento"].Value.ToString().Trim();
			DateTime data = DateTime.Parse(dgvCadastro.Rows[i].Cells["Data"].Value.ToString().Trim());
			short orcamento = CodOrcamento(dgvCadastro.Rows[i].Cells["Orçamento"].Value.ToString());
			short codigo = short.Parse(dgvCadastro.Rows[i].Cells["CodPedido"].Value.ToString().Trim());
			DateTime entrega_prevista = dtpEntregaPrevista.Value;
			string idt_entrega_prevista = chkEntregaPrevista.Checked ? "S" : "N";
			DateTime entrega_real = dtpEntregaReal.Value;
			string idt_entrega_real = chkEntregaReal.Checked ? "S" : "N";
			DateTime montagem_prevista = dtpMontagemPrevista.Value;
			string idt_montagem_prevista = chkMontagemPrevista.Checked ? "S" : "N";
			DateTime montagem_real = dtpMontagemReal.Value;
			string idt_montagem_real = chkMontagemReal.Checked ? "S" : "N";
			string observacao = edtObservacao.Text.Trim();
			int pedido_fornec = Globais.StrToInt(edtPedidoFornec.Text);
			int nf_fornec = Globais.StrToInt(edtNFFornec.Text);
			//int seq_fornec = Globais.StrToInt(edtSeqFornec.Text);
			string condicao=cbxCondicoesPagto.Text.Trim();;
			if (condicao.Length > 10)
			{
				condicao = cbxCondicoesPagto.Text.Substring(0,10).Trim();
			}
			string transportadora = edtTransportadora.Text.Trim();
			string idt_frete = rbtCliente.Checked ? "C" : "F";
			cPedidos pedidos = new cPedidos();
			bool result = pedidos.Altera(fornecedor, data, orcamento, codigo, 
		                   			entrega_prevista, idt_entrega_prevista,
		                   			entrega_real, idt_entrega_real,
		                   			montagem_prevista, idt_montagem_prevista,
		                   			montagem_real, idt_montagem_real,
		                   			observacao,
		                   			condicao, transportadora, 
		                   			pedido_fornec, nf_fornec, //seq_fornec,
		                   			idt_frete,
			                        ref msg);
			if (!result)
			{
				MessageBox.Show(codigo+"\n"+msg, "Erro na alteração do pedido", MessageBoxButtons.OK, MessageBoxIcon.Error);				
			}
			else
			{
				int i2=0;
				if (msg.StartsWith("OK") && (msg.Length > 2)) 
				{
					i2 = int.Parse(msg.Substring(2));
				}				
				dgvCadastro.Rows[i].Cells["Data Entrega"].Value = entrega_prevista;
				dgvCadastro.Rows[i].Cells["IDT Data Entrega"].Value =  idt_entrega_prevista;
				dgvCadastro.Rows[i].Cells["Data Real Entrega"].Value = entrega_real;
				dgvCadastro.Rows[i].Cells["IDT Data Real Entrega"].Value = idt_entrega_real;
				dgvCadastro.Rows[i].Cells["Data Montagem"].Value = montagem_prevista;
				dgvCadastro.Rows[i].Cells["IDT Data Montagem"].Value = idt_montagem_prevista;
				dgvCadastro.Rows[i].Cells["Data Real Montagem"].Value = montagem_real;
				dgvCadastro.Rows[i].Cells["IDT Data Real Montagem"].Value = idt_montagem_real;
				dgvCadastro.Rows[i].Cells["Observação"].Value = observacao;
				dgvCadastro.Rows[i].Cells["Condição Pagto"].Value = condicao;
				dgvCadastro.Rows[i].Cells["Transportadora"].Value = transportadora;
				dgvCadastro.Rows[i].Cells["Pedido Fornec"].Value = pedido_fornec;
				dgvCadastro.Rows[i].Cells["NF Fornec"].Value = nf_fornec;
				dgvCadastro.Rows[i].Cells["Frete"].Value = idt_frete;
				if (i2 == 2)
				{
					foreach (DataGridViewRow row in dgvCadastro.Rows)
					{
						string fornecedor2 = row.Cells["Fornecedor Orçamento"].Value.ToString().Trim();
						DateTime data2 = DateTime.Parse(row.Cells["Data"].Value.ToString().Trim());
						short orcamento2 = CodOrcamento(row.Cells["Orçamento"].Value.ToString());
						short codigo2 = short.Parse(row.Cells["CodPedido"].Value.ToString().Trim());
						if (fornecedor2.Equals(fornecedor) && (data2 == data) && (orcamento2 == orcamento) && (codigo2 != codigo))
						{
							row.Cells["Data Entrega"].Value = entrega_prevista;
							row.Cells["IDT Data Entrega"].Value =  idt_entrega_prevista;
							row.Cells["Data Real Entrega"].Value = entrega_real;
							row.Cells["IDT Data Real Entrega"].Value = idt_entrega_real;
							row.Cells["Data Montagem"].Value = montagem_prevista;
							row.Cells["IDT Data Montagem"].Value = idt_montagem_prevista;
							row.Cells["Data Real Montagem"].Value = montagem_real;
							row.Cells["IDT Data Real Montagem"].Value = idt_montagem_real;
							//row.Cells["Observação"].Value = observacao;
							row.Cells["Condição Pagto"].Value = condicao;
							row.Cells["Transportadora"].Value = transportadora;
							row.Cells["Pedido Fornec"].Value = pedido_fornec;
							row.Cells["NF Fornec"].Value = nf_fornec;
							row.Cells["Frete"].Value = idt_frete;					
							break;
						}
					}
				}
			}
			HabilitaEdicao(false);
			Colore();
		}
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			HabilitaEdicao(false);
		}
		
		void BtnImprimeClick(object sender, EventArgs e)
		{			
			if (dgvCadastro.Rows.Count == 0) return;
			fParametrosImpressao2 frm = new fParametrosImpressao2();
			frm.ShowDialog();
			//fParametrosImpressao frm = new fParametrosImpressao();
			//frm.ShowDialog();
			if (!frm.result) return;
			if (!frm.consolidado)
			{
				int i = dgvCadastro.CurrentRow.Index;
				string fornecedor_pedido = dgvCadastro.Rows[i].Cells["Fornecedor"].Value.ToString().Trim();
				string fornecedor = dgvCadastro.Rows[i].Cells["Fornecedor Orçamento"].Value.ToString().Trim();
				DateTime data = DateTime.Parse(dgvCadastro.Rows[i].Cells["Data"].Value.ToString().Trim());
				short orcamento = CodOrcamento(dgvCadastro.Rows[i].Cells["Orçamento"].Value.ToString());
				short codigo = short.Parse(dgvCadastro.Rows[i].Cells["CodPedido"].Value.ToString().Trim());
				string caracteristica = dgvCadastro.Rows[i].Cells["Característica"].Value.ToString().Trim();
				string pdf = fornecedor.Trim() + data.Year + data.Month + orcamento + "_" + codigo + ".pdf";
				string observacao = dgvCadastro.Rows[i].Cells["Observação"].Value.ToString().Trim();
				cPedidos pedidos = new cPedidos();
				if (frm.listagem)
				{
					col_sorted = "Característica";
					ord_sorted = SortOrder.Ascending;
					Grid.Sort(dgvCadastro, col_sorted, ord_sorted);
					if (pedidos.Lista(dgvCadastro, frm.mostrar_valores, frm.quebrar_caracteristica, frm.detalhes, frm.titulo))
					{
						Transferencia.Salva("pedidos.pdf", pdf);
						Thread.Sleep(3000);
						/*
						MessageBox.Show("PDF gerado com sucesso. Clique para abrir.", "Aviso",
		        	        	MessageBoxButtons.OK, 
		        	        	MessageBoxIcon.Information);		
						*/					
						System.Diagnostics.Process.Start("explorer", "pedidos.pdf");
					}
				}
				else
				{
					cCaracteristicas caracteristicas = new cCaracteristicas();
					string formula_orcamento = caracteristicas.Formula(fornecedor, caracteristica);
					bool destacar_ipi = true;
					string formula = caracteristicas.FormulaPedido(fornecedor, caracteristica, ref destacar_ipi);
					if (!frm.fabrica)
					{
						cPedidoPDF pdf_pedido = new cPedidoPDF();
						pdf_pedido.Open(pdf);
						if (pedidos.Gera(fornecedor_pedido, fornecedor, data, orcamento, codigo, formula, formula_orcamento, pdf, observacao, pdf_pedido, frm.mostrar_subcodigo, frm.mostrar_valores, destacar_ipi))
						{
							pdf_pedido.Close();
							Transferencia.Salva(pdf, pdf);
							Thread.Sleep(3000);
							/*
							MessageBox.Show("PDF gerado com sucesso. Clique para abrir.", "Aviso",
			        	        	MessageBoxButtons.OK, 
			        	        	MessageBoxIcon.Information);		
							*/					
							System.Diagnostics.Process.Start("explorer", pdf);
						}
						else
						{
							pdf_pedido.Close();
						}
					}
					else
					{
						if (pedidos.GeraFabrica(fornecedor_pedido, fornecedor, data, orcamento, codigo, formula, formula_orcamento, pdf, observacao, frm.mostrar_valores, frm.mostrar_subcodigo))
						{
							Transferencia.Salva(pdf, pdf);
							Thread.Sleep(3000);
							/*
							MessageBox.Show("PDF gerado com sucesso. Clique para abrir.", "Aviso",
			        	        	MessageBoxButtons.OK, 
			        	        	MessageBoxIcon.Information);	
							*/						
							System.Diagnostics.Process.Start("explorer", pdf);
						}
					}
				}
			}
			else
			{
				// consolidado
				string filtroPedidos="";
				List<string> pedidosDestacarIpi = new List<string>();
				foreach (DataGridViewRow row in dgvCadastro.Rows)
				{
					if (!(bool)row.Cells["S"].Value)
					{
						continue;
					}
					string fornecedor = row.Cells["Fornecedor Orçamento"].Value.ToString().Trim();
					DateTime data = DateTime.Parse(row.Cells["Data"].Value.ToString().Trim());
					short orcamento = CodOrcamento(row.Cells["Orçamento"].Value.ToString());
					short codigo = short.Parse(row.Cells["CodPedido"].Value.ToString().Trim());			

					string caracteristica = row.Cells["Característica"].Value.ToString().Trim();
					cCaracteristicas caracteristicas = new cCaracteristicas();
					string formula_orcamento = caracteristicas.Formula(fornecedor, caracteristica);					
					bool destacar_ipi = true;
					caracteristicas.FormulaPedido(fornecedor, caracteristica, ref destacar_ipi);
					if (destacar_ipi) {
						string chaveDestacar = fornecedor.Trim() + ":" + data.ToString("M/d/yyyy") + ":" + orcamento.ToString() + ":"  + codigo.ToString();
						pedidosDestacarIpi.Add(chaveDestacar);
					}

					if (filtroPedidos.Length > 0) 
					{
						filtroPedidos = filtroPedidos + " or ";
					}
					filtroPedidos = filtroPedidos + 
						"(" +
						"(p.COD_FORNECEDOR='" + fornecedor + "') and " +
						"(p.DAT_ORCAMENTO='" + data.ToString("M/d/yyyy") + "') and " +
						"(p.COD_ORCAMENTO=" + orcamento.ToString() + ") and " +
						"(p.COD_PEDIDO=" + codigo.ToString() + ") " +
						")";
				}				
				if (filtroPedidos.Length == 0)
				{
					MessageBox.Show("Nenhum pedido selecionado para impressão consolidada");
					return;	
				}
				string pdf = "pedidos.pdf";
				PedidoConsolidado2 pedido2 = new PedidoConsolidado2(pdf, filtroPedidos, frm.por_item, frm.por_pedido, frm.por_cliente, frm.por_fabrica, frm.mostrar_valores, frm.mostrar_subcodigo, frm.observacao_fabrica, pedidosDestacarIpi);				
				Transferencia.Salva(pdf, pdf);		
				Thread.Sleep(3000);
				/*
				MessageBox.Show("PDF gerado com sucesso. Clique para abrir.", "Aviso",
	        	        	MessageBoxButtons.OK, 
	        	        	MessageBoxIcon.Information);			
				*/				
				System.Diagnostics.Process.Start("explorer", pdf);		
				return;
				/*
				PedidoConsolidado pedido = new PedidoConsolidado(pdf, filtroPedidos, frm.por_item, frm.por_pedido, frm.por_cliente, frm.por_fabrica, frm.mostrar_valores, frm.mostrar_subcodigo, frm.observacao_fabrica);
				System.Diagnostics.Process.Start("explorer", pdf);				
				*/				
				/*
				cPedidos pedidos = new cPedidos();
				cPedidoPDF pdf_pedido = new cPedidoPDF();
				pdf_pedido.Open(pdf);
				bool primeiro=true;
				foreach (DataGridViewRow row in dgvCadastro.SelectedRows)
				{
					if (primeiro)
					{
						primeiro = false;
					}
					else
					{
						pdf_pedido.SaltaPagina();
					}
					string fornecedor_pedido = row.Cells["Fornecedor"].Value.ToString().Trim();
					string fornecedor = row.Cells["Fornecedor Orçamento"].Value.ToString().Trim();
					DateTime data = DateTime.Parse(row.Cells["Data"].Value.ToString().Trim());
					short orcamento = CodOrcamento(row.Cells["Orçamento"].Value.ToString());
					short codigo = short.Parse(row.Cells["CodPedido"].Value.ToString().Trim());
					string caracteristica = row.Cells["Característica"].Value.ToString().Trim();
					string observacao = row.Cells["Observação"].Value.ToString().Trim();
					cCaracteristicas caracteristicas = new cCaracteristicas();
					string formula_orcamento = caracteristicas.Formula(fornecedor, caracteristica);
					string formula = caracteristicas.FormulaPedido(fornecedor, caracteristica);
					pedidos.Gera(fornecedor_pedido, fornecedor, data, orcamento, codigo, formula, formula_orcamento, pdf, observacao, pdf_pedido);
				}
				pdf_pedido.Close();
				System.Diagnostics.Process.Start("explorer", pdf);
				*/
			}
		}
		
		void BtnTransportadoraClick(object sender, EventArgs e)
		{
			cControleAcesso acesso = new cControleAcesso();
			frmCadParceiros frmCad = new frmCadParceiros(true);
			frmCad.where = "";
			frmCad.bFornecedores = true;
			frmCad.codigo = edtTransportadora.Text;
			frmCad.ReadOnly = !acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fCadParceiros");
			frmCad.ShowDialog();
			if (frmCad.result)
			{
				edtTransportadora.Text = frmCad.edtCodigo.Text;
			}
		}
		
		void BtnFiltroClick(object sender, EventArgs e)
		{
			frmFiltro.ShowDialog();
			if (frmFiltro.result)
			{
				CarregaPedidos();
				Grid.Sort(dgvCadastro, col_sorted, ord_sorted);
			}
		}
		
		void BtnFornecedorClick(object sender, EventArgs e)
		{
			if (dgvCadastro.Rows.Count == 0) return;
			int i = dgvCadastro.CurrentRow.Index;
			string fornecedor = dgvCadastro.Rows[i].Cells["Fornecedor Orçamento"].Value.ToString().Trim();
			cControleAcesso acesso = new cControleAcesso();
			if (!acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fConParceiros")) return;				
			frmCadParceiros frmCad = new frmCadParceiros(true);
			frmCad.where = "where COD_PARCEIRO='" + fornecedor + "'";
			frmCad.codigo = fornecedor;
			frmCad.ReadOnly = !acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fCadParceiros");
			frmCad.ShowDialog();
		}
		
		void BtnClienteClick(object sender, EventArgs e)
		{
			if (dgvCadastro.Rows.Count == 0) return;
			int i = dgvCadastro.CurrentRow.Index;
			string cliente = dgvCadastro.Rows[i].Cells["Cliente"].Value.ToString().Trim();
			cControleAcesso acesso = new cControleAcesso();
			if (!acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fConParceiros")) return;				
			frmCadParceiros frmCad = new frmCadParceiros(true);
			frmCad.where = "where COD_PARCEIRO='" + cliente + "'";
			frmCad.codigo = cliente;
			frmCad.ReadOnly = !acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fCadParceiros");
			frmCad.ShowDialog();
		}
		
		void BtnConsultorClick(object sender, EventArgs e)
		{
			if (dgvCadastro.Rows.Count == 0) return;
			int i = dgvCadastro.CurrentRow.Index;
			string consultor = dgvCadastro.Rows[i].Cells["Consultor"].Value.ToString().Trim();
			cControleAcesso acesso = new cControleAcesso();
			if (!acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fConParceiros")) return;				
			frmCadParceiros frmCad = new frmCadParceiros(true);
			frmCad.where = "where COD_PARCEIRO='" + consultor + "'";
			frmCad.codigo = consultor;
			frmCad.ReadOnly = !acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fCadParceiros");
			frmCad.ShowDialog();
		}
		
		void BtnItensClick(object sender, EventArgs e)
		{
			if (dgvCadastro.Rows.Count == 0) return;
			int i = dgvCadastro.CurrentRow.Index;
			string fornecedor = dgvCadastro.Rows[i].Cells["Fornecedor Orçamento"].Value.ToString();		
			DateTime data = DateTime.Parse(dgvCadastro.Rows[i].Cells["Data"].Value.ToString());			
			short orcamento = CodOrcamento(dgvCadastro.Rows[i].Cells["Orçamento"].Value.ToString());
			string cliente = dgvCadastro.Rows[i].Cells["Cliente"].Value.ToString();			
			string caracteristica = dgvCadastro.Rows[i].Cells["Característica"].Value.ToString().Trim();			
			cCaracteristicas caracteristicas = new cCaracteristicas();
			string formula_orcamento = caracteristicas.Formula(fornecedor, caracteristica);
			bool destacar_ipi = true;
			string formula = caracteristicas.FormulaPedido(fornecedor, caracteristica, ref destacar_ipi);
			frmCadItens frm = new frmCadItens();
			frm.fornecedor = fornecedor;
			frm.data = data;
			frm.cod_orcamento = orcamento;
			frm.cliente = cliente;
			frm.tabela = dgvCadastro.Rows[i].Cells["Tabela"].Value.ToString();
			frm.formula = formula;
			frm.formula_orcamento = formula_orcamento;
			frm.pedido = true;
			frm.ShowDialog();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			filtro_dinheiro = "(a.IDT_DAT_REAL_ENTREGA = 'S' and " +
				"a.IDT_RECEBIDO <> 'S' and " +
				//"not exists(select 1 from titulos_receber d where d.COD_FORNECEDOR=a.COD_FORNECEDOR and d.DAT_ORCAMENTO=a.DAT_ORCAMENTO and d.COD_ORCAMENTO=a.COD_ORCAMENTO and d.COD_PEDIDO=a.NRO_PEDIDO) and ";
				"not exists(select 1 from pedidos_recebidos d where d.COD_FORNECEDOR=a.COD_FORNECEDOR and d.DAT_ORCAMENTO=a.DAT_ORCAMENTO and d.COD_ORCAMENTO=a.COD_ORCAMENTO and d.COD_PEDIDO=a.COD_PEDIDO)) and ";
			CarregaPedidos();
			Grid.Sort(dgvCadastro, col_sorted, ord_sorted);
			filtro_dinheiro = "";
		}

		public void CarregaAnexos(string fornecedor, DateTime data, int codigo) 
		{
			cOrcamentos orcamento = new cOrcamentos();
			orcamento.CarregaAnexos(dgvAnexos, fornecedor, data, codigo);
			dgvAnexos.Columns["Código"].Width = 183;
			dgvAnexos.Columns["Arquivo"].Visible = false;
			/*
			int n = dgvAnexos.Rows.Count;
			int i;
			for (i=0; i<n; i++)
			{
				switch (i) 
				{
					case 1: 
						linkLabel1.Visible = true;
						linkLabel1.Text = dgvAnexos.Rows[i-1].Cells[0].Value.ToString().Trim();
						break;
					case 2: 
						linkLabel2.Visible = true;
						linkLabel2.Text = dgvAnexos.Rows[i-1].Cells[0].Value.ToString().Trim();						
						break;
					case 3: 
						linkLabel3.Visible = true;
						linkLabel3.Text = dgvAnexos.Rows[i-1].Cells[0].Value.ToString().Trim();												
						break;
				}
			}
			for (; i<=3; i++)
			{
				switch (i) 
				{
					case 1: 
						linkLabel1.Visible = false;
						break;
					case 2: 
						linkLabel2.Visible = false;
						break;
					case 3: 
						linkLabel3.Visible = false;
						break;
				}
			}
			*/
		}
		
		void BtnCadAnexosClick(object sender, EventArgs e)
		{
			string dirCorrente = System.IO.Directory.GetCurrentDirectory();
			if (dgvCadastro.Rows.Count == 0) return;
			int i = dgvCadastro.CurrentRow.Index;
			string fornecedor = dgvCadastro.Rows[i].Cells["Fornecedor Orçamento"].Value.ToString().Trim();
			DateTime data = DateTime.Parse(dgvCadastro.Rows[i].Cells["Data"].Value.ToString().Trim());
			short codigo = CodOrcamento(dgvCadastro.Rows[i].Cells["Orçamento"].Value.ToString());
			frmAnexosOrcamento frmCad = new frmAnexosOrcamento();
			frmCad.fornecedor = fornecedor;
			frmCad.data = data;
			frmCad.cod_orcamento = codigo;
			frmCad.ShowDialog();
			CarregaAnexos(fornecedor, data, codigo);
			dgvCadastro.Focus();
			System.IO.Directory.SetCurrentDirectory(dirCorrente);
		}
		
		void AbreAnexo(string codigo)
		{
			string dirCorrente = System.IO.Directory.GetCurrentDirectory();			
			if (dgvCadastro.Rows.Count == 0) return;
			int i = dgvCadastro.CurrentRow.Index;
			string fornecedor = dgvCadastro.Rows[i].Cells["Fornecedor Orçamento"].Value.ToString().Trim();
			DateTime data = DateTime.Parse(dgvCadastro.Rows[i].Cells["Data"].Value.ToString().Trim());
			short cod_orcamento = CodOrcamento(dgvCadastro.Rows[i].Cells["Orçamento"].Value.ToString());			
			cOrcamentos orcamento = new cOrcamentos();			
			string fn = orcamento.CarregaAnexo(fornecedor, data, cod_orcamento, codigo);
			System.Diagnostics.Process.Start("explorer", fn);			
			System.IO.Directory.SetCurrentDirectory(dirCorrente);			
			//File.Delete(fn);
		}
		
		void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			AbreAnexo(linkLabel1.Text);
		}
		
		void LinkLabel2LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			AbreAnexo(linkLabel2.Text);
		}
		
		void LinkLabel3LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			AbreAnexo(linkLabel3.Text);			
		}
		
		void BtnXeceberClick(object sender, EventArgs e)
		{
			if (dgvCadastro.Rows.Count == 0) return;
			int i = dgvCadastro.CurrentRow.Index;
			string[] args = new string[8];
			args[0] = Globais.sUsuario;
			args[1] = Globais.sFilial;
			args[2] = Globais.bAdministrador ? "S" : "N";

			args[3] = dgvCadastro.Rows[i].Cells["Fornecedor Orçamento"].Value.ToString().Trim();
			args[4] = dgvCadastro.Rows[i].Cells["Data"].Value.ToString().Trim();
			args[5] = CodOrcamento(dgvCadastro.Rows[i].Cells["Orçamento"].Value.ToString()).ToString();
			args[6] = dgvCadastro.Rows[i].Cells["CodPedido"].Value.ToString().Trim();

			args[7] = dgvCadastro.Rows[i].Cells["Ped"].Value.ToString().Trim();
			
			receber.MainForm frm = new receber.MainForm(args);
			frm.ShowDialog();
			string chave = dgvCadastro.Rows[i].Cells["Chave"].Value.ToString().Trim();
			CarregaPedidos();
			Grid.Sort(dgvCadastro, col_sorted, ord_sorted);
			Grid.Posiciona(dgvCadastro, chave);			
		}
		
		void BtnAlteraValorClick(object sender, EventArgs e)
		{
			if (dgvCadastro.Rows.Count == 0) return;
			int i = dgvCadastro.CurrentRow.Index;
			string fornecedor = dgvCadastro.Rows[i].Cells["Fornecedor Orçamento"].Value.ToString().Trim();
			DateTime data = DateTime.Parse(dgvCadastro.Rows[i].Cells["Data"].Value.ToString());
			short orcamento = CodOrcamento(dgvCadastro.Rows[i].Cells["Orçamento"].Value.ToString());
			short pedido = Globais.StrToShort(dgvCadastro.Rows[i].Cells["CodPedido"].Value.ToString());
			float valor =  Globais.StrToFloat(dgvCadastro.Rows[i].Cells["Valor"].Value.ToString());
			short nro_pedido = Globais.StrToShort(dgvCadastro.Rows[i].Cells["Ped"].Value.ToString());
			string consultor = dgvCadastro.Rows[i].Cells["Consultor"].Value.ToString().Trim();
			string recebido = dgvCadastro.Rows[i].Cells["Recebido"].Value.ToString().Trim();
			//float per_comissao =  Globais.StrToFloat(dgvCadastro.Rows[i].Cells["Comissão"].Value.ToString());
			
			string sUsuario = Globais.sUsuario;
			bool bAdministrador = Globais.bAdministrador;
			string bFilial = Globais.sFilial;
			bool permitido = bAdministrador;
			if (!bAdministrador) {
				frmLogin frm = new frmLogin();
				frm.Text = "Usuário Administrador";
				frm.su = true;
				frm.admin = false;
				frm.sUltimoUsuario = "";
				frm.sUltimaFilial = "";
				frm.ShowDialog();
				Globais.sUsuario = sUsuario;
				Globais.bAdministrador = bAdministrador;
				Globais.sFilial = bFilial;
				if (frm.bOK) {
					permitido = true;
				}
			}
			if (permitido)
			{
				fAlteraValor frmalt = new fAlteraValor();
				frmalt.edtValor.Text = valor.ToString("#,###,##0.00");
				frmalt.edtPedido.Text = nro_pedido.ToString();
				frmalt.edtConsultor.Text = consultor;
				frmalt.ckbRecebido.Checked = (recebido.CompareTo("S") == 0);
				//frmalt.edtComissao.Text = per_comissao.ToString("#0.00");
				frmalt.ShowDialog();
				if (frmalt.result)
				{
					cPedidos cpedido = new cPedidos();
					valor = Globais.StrToFloat(frmalt.edtValor.Text);
					nro_pedido = Globais.StrToShort(frmalt.edtPedido.Text);
					consultor = frmalt.edtConsultor.Text;
					recebido = frmalt.ckbRecebido.Checked ? "S" : "N";
					//per_comissao = Globais.StrToFloat(frmalt.edtComissao.Text);					
					if (cpedido.AlteraValor(fornecedor, data, orcamento, pedido, valor, nro_pedido, consultor, recebido))
					{
						dgvCadastro.Rows[i].Cells["Valor"].Value = valor;
						//dgvCadastro.Rows[i].Cells["Comissão"].Value = per_comissao;
						dgvCadastro.Rows[i].Cells["Ped"].Value = nro_pedido;
						dgvCadastro.Rows[i].Cells["Consultor"].Value = consultor;
						if (frmalt.ckbRecebido.Checked)
						{
							dgvCadastro.Rows[i].Cells["R"].Value = "S";
							dgvCadastro.Rows[i].Cells["Recebido"].Value = "S";
						}
						else
						{
							dgvCadastro.Rows[i].Cells["R"].Value = cpedido.VerificaRecebido(fornecedor, data, orcamento, nro_pedido);
							dgvCadastro.Rows[i].Cells["Recebido"].Value = "N";
						}
						Colore();
					}
				}
			}
		}
		
		void BtnXeceberMouseEnter(object sender, EventArgs e)
		{
			if (dgvCadastro.Rows.Count == 0) return;
			int i = dgvCadastro.CurrentRow.Index;
			
			dgvTitulos.Visible = true;
			DataTable tab = new DataTable();
			tab.Columns.Add("NF", typeof(string));
			tab.Columns.Add("Seq", typeof(string));
			string fornecedor = dgvCadastro.Rows[i].Cells["Fornecedor Orçamento"].Value.ToString().Trim();
			DateTime data = DateTime.Parse(dgvCadastro.Rows[i].Cells["Data"].Value.ToString());
			short orcamento = CodOrcamento(dgvCadastro.Rows[i].Cells["Orçamento"].Value.ToString());
			short pedido = Globais.StrToShort(dgvCadastro.Rows[i].Cells["CodPedido"].Value.ToString());
			cTitulosXeceber titulos = new cTitulosXeceber();
			ArrayList lista = titulos.CarregaPorPedidoHint(fornecedor, data, orcamento, pedido, false);
			tab.Rows.Add(new object[] {"NF", "Seq"});
			foreach (string nf in lista)
			{
				//tab.Rows.Add(new object[] {int.Parse(nf.Substring(0,9)), int.Parse(nf.Substring(9, 9))});
				tab.Rows.Add(new object[] {nf.Substring(0,9), nf.Substring(9, 9)});
			}
			dgvTitulos.DataSource = tab;
			dgvTitulos.Columns["NF"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			dgvTitulos.Columns["Seq"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;			
		}
		
		void BtnXeceberMouseLeave(object sender, EventArgs e)
		{
			dgvTitulos.Visible = false;			
		}
		
		void DgvCadastroSorted(object sender, EventArgs e)
		{
			col_sorted = dgvCadastro.SortedColumn.HeaderText;
			ord_sorted = dgvCadastro.SortOrder;
			Colore();
			Grid.MarcaSelecionados(dgvCadastro);
			Grid.Posiciona(dgvCadastro, chave_sel);
		}
		
		void BtnRefreshClick(object sender, EventArgs e)
		{
			CarregaPedidos();
			Grid.Sort(dgvCadastro, col_sorted, ord_sorted);
		}
		
		void EdtCaracteristicaMouseEnter(object sender, EventArgs e)
		{
			if (dgvCadastro.Rows.Count == 0) return;			
			int i = dgvCadastro.CurrentRow.Index;
			edtRacional.Text = dgvCadastro.Rows[i].Cells["Racional"].Value.ToString();
			string[] lista = edtRacional.Text.Split('\n');
			int linhas = lista.Length;
			foreach (string s in lista)
			{
				int x = (int)(s.Length / 77);
				linhas += x;
			}
			if (linhas > 45) linhas = 45;
			int dy = linhas * 14 + 10;
			int y = 670 - dy;
			edtRacional.SetBounds(edtRacional.Location.X, y, edtRacional.Size.Width, dy);			
			edtRacional.Visible = true;										
		}
		
		void EdtCaracteristicaMouseLeave(object sender, EventArgs e)
		{
			edtRacional.Visible = false;			
		}
		
		void BtnPagarMouseEnter(object sender, EventArgs e)
		{
			if (dgvCadastro.Rows.Count == 0) return;
			int i = dgvCadastro.CurrentRow.Index;
			
			int n = dgvTitulos.Columns.Count;
			dgvTitulos.Visible = true;
			DataTable tab = new DataTable();
			tab.Columns.Add("Título", typeof(string));
			string fornecedor = dgvCadastro.Rows[i].Cells["Fornecedor Orçamento"].Value.ToString().Trim();
			DateTime data = DateTime.Parse(dgvCadastro.Rows[i].Cells["Data"].Value.ToString());
			short orcamento = CodOrcamento(dgvCadastro.Rows[i].Cells["Orçamento"].Value.ToString());
			short pedido = Globais.StrToShort(dgvCadastro.Rows[i].Cells["CodPedido"].Value.ToString());
			cTitulosPagar titulos = new cTitulosPagar();
			ArrayList lista = titulos.CarregaPorPedidoHint(fornecedor, data, orcamento, pedido);
			tab.Rows.Add(new object[] {"Título"});
			foreach (string titulo in lista)
			{
				//tab.Rows.Add(new object[] {int.Parse(titulo.Substring(0,9))});
				tab.Rows.Add(new object[] {titulo});
			}
			dgvTitulos.DataSource = tab;
			//dgvTitulos.Columns["Título"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			dgvTitulos.Columns["Título"].Width = 250;
		}
		
		void BtnPagarMouseLeave(object sender, EventArgs e)
		{
			dgvTitulos.Visible = false;						
		}
		
		void BtnPagarClick(object sender, EventArgs e)
		{
			if (dgvCadastro.Rows.Count == 0) return;
			int i = dgvCadastro.CurrentRow.Index;
			string[] args = new string[4];
			args[0] = Globais.sUsuario;
			args[1] = Globais.sFilial;
			args[2] = Globais.bAdministrador ? "S" : "N";
			
			string fornecedor = dgvCadastro.Rows[i].Cells["Fornecedor Orçamento"].Value.ToString().Trim();
			DateTime data = DateTime.Parse(dgvCadastro.Rows[i].Cells["Data"].Value.ToString());
			short orcamento = CodOrcamento(dgvCadastro.Rows[i].Cells["Orçamento"].Value.ToString());
			short pedido = Globais.StrToShort(dgvCadastro.Rows[i].Cells["CodPedido"].Value.ToString());
			cTitulosPagar titulos = new cTitulosPagar();
			ArrayList lista = titulos.CarregaPorPedidoHint(fornecedor, data, orcamento, pedido);
			string titulo="";
			foreach (string s in lista)
			{
				if (titulo.Length > 0)
					titulo += ",";
				titulo += s.Substring(0,9);
			}
			args[3] = titulo; 
			
			pagar.MainForm frm = new pagar.MainForm(args);
			frm.ShowDialog();
			string chave = dgvCadastro.Rows[i].Cells["Chave"].Value.ToString().Trim();
			CarregaPedidos();
			Grid.Sort(dgvCadastro, col_sorted, ord_sorted);
			Grid.Posiciona(dgvCadastro, chave);
		}
		
		void BtnAgendarClick(object sender, EventArgs e)
		{
			if (dgvCadastro.Rows.Count == 0) return;
			int i = dgvCadastro.CurrentRow.Index;
			string[] args = new string[11];
			args[0] = Globais.sUsuario;
			args[1] = Globais.sFilial;
			args[2] = Globais.bAdministrador ? "S" : "N";			
			string fornecedor = dgvCadastro.Rows[i].Cells["Fornecedor Orçamento"].Value.ToString().Trim();
			DateTime data = DateTime.Parse(dgvCadastro.Rows[i].Cells["Data"].Value.ToString());
			short orcamento = CodOrcamento(dgvCadastro.Rows[i].Cells["Orçamento"].Value.ToString());
			short pedido = Globais.StrToShort(dgvCadastro.Rows[i].Cells["CodPedido"].Value.ToString());
			args[3] = dgvCadastro.Rows[i].Cells["Fornecedor Orçamento"].Value.ToString().Trim();
			args[4] = dgvCadastro.Rows[i].Cells["Data"].Value.ToString().Trim();
			args[5] = CodOrcamento(dgvCadastro.Rows[i].Cells["Orçamento"].Value.ToString().Trim()).ToString();
			args[6] = dgvCadastro.Rows[i].Cells["CodPedido"].Value.ToString().Trim();
			args[7] = dgvCadastro.Rows[i].Cells["IDT Data Montagem"].Value.ToString().Trim();
			args[8] = dgvCadastro.Rows[i].Cells["Data Montagem"].Value.ToString().Trim();						
			args[9] = dgvCadastro.Rows[i].Cells["Cliente"].Value.ToString().Trim();
			args[10] = dgvCadastro.Rows[i].Cells["Ped"].Value.ToString().Trim();
			trace.grava("agendar: " + fornecedor + " " + data.ToString("d/M/yyyy") + " " + orcamento.ToString() + " " + pedido.ToString());
			agenda.frmAgenda frm = new agenda.frmAgenda(args);			
			frm.ShowDialog();
			string chave = dgvCadastro.Rows[i].Cells["Chave"].Value.ToString().Trim();
			CarregaPedidos();			
			Grid.Sort(dgvCadastro, col_sorted, ord_sorted);
			Grid.Posiciona(dgvCadastro, chave);
		}
		
		void DgvCadastroCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if ((bool)dgvCadastro.CurrentRow.Cells["S"].Value)
			{
				dgvCadastro.CurrentRow.DefaultCellStyle.BackColor = Color.SkyBlue;
			}
			else
			{
				dgvCadastro.CurrentRow.DefaultCellStyle.BackColor = Color.White;
			}						
		}
		
		void DgvCadastroCurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			dgvCadastro.CommitEdit(DataGridViewDataErrorContexts.Commit);			
		}
		
		void BtnDownClick(object sender, EventArgs e)
		{
			Grid.Proximo(dgvCadastro, edtLocaliza.Text.Trim());
			if (Grid.selecionado != -1)
			{
				DataGridViewCellEventArgs e2 = new DataGridViewCellEventArgs(Grid.col, Grid.selecionado);
				DgvCadastroCellClick(sender, e2);
			}			
		}
		
		void BtnUpClick(object sender, EventArgs e)
		{
			Grid.Anterior(dgvCadastro, edtLocaliza.Text.Trim());
			if (Grid.selecionado != -1)
			{
				DataGridViewCellEventArgs e2 = new DataGridViewCellEventArgs(Grid.col, Grid.selecionado);
				DgvCadastroCellClick(sender, e2);
			}			
		}		
		
		void EdtLocalizaTextChanged(object sender, EventArgs e)
		{
			Grid.Localiza(dgvCadastro, edtLocaliza.Text.Trim());
			if (Grid.selecionado != -1)
			{
				DataGridViewCellEventArgs e2 = new DataGridViewCellEventArgs(Grid.col, Grid.selecionado);
				DgvCadastroCellClick(sender, e2);
			}
		}
		
		void DgvCadastroCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex == -1) return;
			Grid.selecionado = e.RowIndex;
			Grid.col = e.ColumnIndex;
			chave_sel = 
				dgvCadastro.Rows[e.RowIndex].Cells["Fornecedor"].Value.ToString().Trim() +
				dgvCadastro.Rows[e.RowIndex].Cells["Data"].Value.ToString().Trim() +
				dgvCadastro.Rows[e.RowIndex].Cells["Orçamento"].Value.ToString().Trim() +
				dgvCadastro.Rows[e.RowIndex].Cells["Ped"].Value.ToString().Trim();
		}

		public void Posiciona(string fornecedor, string data, string orcamento, string pedido)
		{
			for (int i=0; i<dgvCadastro.Rows.Count; i++)
			{
				dgvCadastro.Rows[i].Cells[0].Selected = false;
			}
			for (int i=0; i<dgvCadastro.Rows.Count; i++)
			{
				string _fornecedor = dgvCadastro.Rows[i].Cells[0].Value.ToString().Trim();
				string _data = dgvCadastro.Rows[i].Cells[1].Value.ToString();
				string _orcamento = dgvCadastro.Rows[i].Cells[2].Value.ToString().Trim();
				string _pedido = dgvCadastro.Rows[i].Cells[3].Value.ToString().Trim();				
				if (_fornecedor.Equals(fornecedor) && _data.Equals(data) && 
				    _orcamento.Equals(orcamento) && _pedido.Equals(pedido))
				{
					dgvCadastro.Rows[i].Cells[0].Selected = true;
					dgvCadastro.CurrentCell = dgvCadastro.Rows[i].Cells[0];
					return;
				}
			}
			if (dgvCadastro.Rows.Count > 0)
			{
				dgvCadastro.Rows[0].Cells[0].Selected = true;
			}
		}		
		
		void BtnComissaoClick(object sender, EventArgs e)
		{
			bool selecionado=false;
			foreach (DataGridViewRow row in dgvCadastro.Rows)
			{
				if ((bool)row.Cells["S"].Value)
				{
					selecionado = true;
					break;
				}
			}
			if (!selecionado) return;
			
			/*
			string sUsuario = Globais.sUsuario;
			bool bAdministrador = Globais.bAdministrador;
			string bFilial = Globais.sFilial;
			frmLogin frm = new frmLogin();
			frm.Text = "Usuário Administrador";
			frm.su = true;
			frm.admin = false;
			frm.sUltimoUsuario = "";
			frm.sUltimaFilial = "";
			frm.ShowDialog();
			Globais.sUsuario = sUsuario;
			Globais.bAdministrador = bAdministrador;
			Globais.sFilial = bFilial;
			if (!frm.bOK) return;
			*/

			fComissao frmCom = new fComissao(dgvCadastro);
			frmCom.ShowDialog();
		}
/*		
		void BtnListaComissaoClick(object sender, EventArgs e)
		{
			bool selecionado=false;
			foreach (DataGridViewRow row in dgvCadastro.Rows)
			{
				if ((bool)row.Cells["S"].Value)
				{
					selecionado = true;
					break;
				}
			}
			if (!selecionado) return;
			fParametrosImpressaoCom frm = new fParametrosImpressaoCom(dgvCadastro);
			frm.ShowDialog();		
			if (!frm.result) return;
			cPedidos pedidos = new cPedidos();
			if (pedidos.ListaComissao(dgvCadastro, frm.por_vendedor, frm.por_consultor, frm.por_filial, frm.somente_pago, frm.somente_pagar, frm.titulo, frm.justificativas))
				System.Diagnostics.Process.Start("explorer", "comissao.pdf");
			
		}
*/		
		void ChkTodosCheckedChanged(object sender, EventArgs e)
		{
			if (chkTodos.Checked)
			{
				foreach (DataGridViewRow row in dgvCadastro.Rows)
				{
					row.Cells["S"].Value = true;
					row.DefaultCellStyle.BackColor = Color.SkyBlue;
				}				
			}
			else
			{
				foreach (DataGridViewRow row in dgvCadastro.Rows)
				{
					row.Cells["S"].Value = false;
					row.DefaultCellStyle.BackColor = Color.White;
				}								
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			cPedidos.CorrigeAgendamentos();
		}
		
		void DgvCadastroCellMouseEnter(object sender, DataGridViewCellEventArgs e)
		{
		}
		
		void BtnPendenteConsultorClick(object sender, EventArgs e)
		{
			frmFiltro.idt_pendentes_consultor = "S";
			CarregaPedidos();
			Grid.Sort(dgvCadastro, col_sorted, ord_sorted);			
			frmFiltro.idt_pendentes_consultor = "N";			
		}
		
		void BtnPendenteVendedorClick(object sender, EventArgs e)
		{
			frmFiltro.idt_pendentes_vendedor = "S";		
			CarregaPedidos();
			Grid.Sort(dgvCadastro, col_sorted, ord_sorted);			
			frmFiltro.idt_pendentes_vendedor = "N";					
		}
		
		void BtnAbrirAnexoClick(object sender, EventArgs e)
		{
			if (dgvAnexos.Rows.Count == 0) return;
			int i = dgvAnexos.CurrentRow.Index;
			AbreAnexo(dgvAnexos.Rows[i].Cells[0].Value.ToString().Trim());			
		}
		
		void DgvAnexosCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dgvAnexos.Rows.Count == 0) return;
			int i = dgvAnexos.CurrentRow.Index;
			AbreAnexo(dgvAnexos.Rows[i].Cells[0].Value.ToString().Trim());						
		}
		
		void EdtPerCCMouseLeave(object sender, EventArgs e)
		{
			edtComissao.Visible = false;
		}
		
		void EdtPerCVMouseEnter(object sender, EventArgs e)
		{
			if (dgvCadastro.Rows.Count == 0) return;
			int i = dgvCadastro.CurrentRow.Index;
			string fornecedor = dgvCadastro.Rows[i].Cells["Fornecedor Orçamento"].Value.ToString().Trim();
			DateTime data = DateTime.Parse(dgvCadastro.Rows[i].Cells["Data"].Value.ToString().Trim());
			short orcamento = CodOrcamento(dgvCadastro.Rows[i].Cells["Orçamento"].Value.ToString());
			short pedido = Globais.StrToShort(dgvCadastro.Rows[i].Cells["CodPedido"].Value.ToString());
			string jus = "";
			float per=0;
			if (cPedidos.CV(fornecedor, data, orcamento, pedido, ref jus, ref per))
			{
				edtComissao.Visible = true;
				edtComissao.Text = "Percentual pago: " + per.ToString("#0.00") + "\r\n" + jus;
			}
		}
		
		void EdtPerCVMouseLeave(object sender, EventArgs e)
		{
			edtComissao.Visible = false;
		}
		
		void EdtPerCCMouseEnter(object sender, EventArgs e)
		{
			if (dgvCadastro.Rows.Count == 0) return;
			int i = dgvCadastro.CurrentRow.Index;
			string fornecedor = dgvCadastro.Rows[i].Cells["Fornecedor Orçamento"].Value.ToString().Trim();
			DateTime data = DateTime.Parse(dgvCadastro.Rows[i].Cells["Data"].Value.ToString().Trim());
			short orcamento = CodOrcamento(dgvCadastro.Rows[i].Cells["Orçamento"].Value.ToString());
			short pedido = Globais.StrToShort(dgvCadastro.Rows[i].Cells["CodPedido"].Value.ToString());
			string jus = "";
			float per=0;
			if (cPedidos.CC(fornecedor, data, orcamento, pedido, ref jus, ref per))
			{
				edtComissao.Visible = true;
				edtComissao.Text = "Percentual pago: " + per.ToString("#0.00") + "\r\n" + jus;
			}		
		}
		
		void EdtObservacaoDoubleClick(object sender, EventArgs e)
		{
			frmEditaMemo frm = new frmEditaMemo();			
			frm.Text = "Observação";
			frm.edtMemo.Text = edtObservacao.Text;
			frm.edtMemo.ReadOnly = true;
			frm.btnCancela.Text = "Fecha";
			frm.btnConfirma.Visible = false;
			frm.ShowDialog();	
		}
	}
}
