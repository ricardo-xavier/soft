/*
 * Projeto  : SoftPlace
 * Sistema  : Orcamentos
 * Programa : MainForm - Tela Inicial
 * Autor    : Ricardo Costa Xavier
 * Data     : 24/05/08
 * 
 * 16/11/14 - Ricardo - colorir de laranja se o preço da tabela foi alterado
 * 02/05/15 - Ricardo - chamada pela ação comercial
 * 
 * 07/05/15 - correção na carga por fora da ação(cliente nulo)
 *            se vier da ação não mostrar somente automáticas
 * 
 * 29/11/17 - 1.8.1 - correção da máscara de celular na impressão
 *                    mostar email do vendedor na impressão
 *                    calcular o preço no change do produto e subcod   
 * 
 * 21/03/2018 - 1.9.0 - reordenação de itens, email do vendedor na introdução
 * 
 * 18/04/2018 - 1.9.1 - redirecionamento do form e defaults da impressao
 * 
 * 28/07/2018 - 1.12.0 - chamada pelas estatísticas da ação
 * 
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using classes;
using basico;
using System.Collections;

namespace orcamento
{
	public partial class MainForm : Form
	{
		private string fornecedor;
		private string cliente;
		private string consultor;
		private cOrcamentos orcamento;
		private frmFiltroOrcamento frmFiltro;
		private string col_sorted;
		private SortOrder ord_sorted;
		private string chave_sel;
		private String clienteAcao;
		private String vendedorAcao;
		private String situacaoAcao;
		private bool alteracaoRestrita = false;
		
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
			Grid.Inicializa();
			
			if (args.Length == 2) 
			{
				vendedorAcao = args[0];
				situacaoAcao = args[1];
				btnInclui.Enabled = false;
				btnExclui.Enabled = false;
				alteracaoRestrita = true;
			}
			else 
			{
				if (args.Length > 0) 
				{
					//login = false;
					Globais.sUsuario = args[0];
					Globais.sFilial = args[1];
					Globais.bAdministrador = args[2][0] == 'S';
				}
				if (args.Length > 4) 
				{
					// 3 = -clienteacao
					clienteAcao = args[4];
				}
			}
			//else login = true;
			dgvCadastro.Width = 910;
			orcamento = new cOrcamentos();			
		}
		
		private void Colore()
		{
			double total = 0;
			int    registros=0;
			cPedidos pedido = new cPedidos();
			foreach (DataGridViewRow row in dgvCadastro.Rows)
			{
				short codigo = Globais.StrToShort(row.Cells["Cod"].Value.ToString());
				string fornecedor = row.Cells["Fornecedor"].Value.ToString();
				DateTime data = DateTime.Parse(row.Cells["Data"].Value.ToString());
				/*
				if (false)
				{
					row.Cells["P"].Value = pedido.Existe(fornecedor, data, codigo) ? "S" : "N";
					row.Cells["M"].Value = orcamento.Especial(fornecedor, data, codigo);
				}
				*/
/*				
				switch (row.Cells["Situação"].Value.ToString()[0])
				{
					case 'E': row.Cells["Situação"].Value = "Em Andamento"; break;
					case 'C': row.Cells["Situação"].Value = "Cancelado"; break;
					case 'S': row.Cells["Situação"].Value = "Substituido"; break;
					case 'F': row.Cells["Situação"].Value = "Fechado"; break;
				}
*/				

				DataGridViewCell cell = row.Cells["Sinal"];
				cell.Style.BackColor = Color.Yellow;
				cell.Style.SelectionBackColor = Color.Yellow;
				cell.Value = "0";
								
				if (row.Cells["Valor Itens"].Value != null)
				{
					float vlr_itens = Globais.StrToFloat(row.Cells["Valor Itens"].Value.ToString());
					float vlr_desconto = Globais.StrToFloat(row.Cells["Desconto"].Value.ToString());
					// colore de acordo com o limiar da caracteristica
					if ((row.Cells["Fornecedor"].Value != null) &&
					    (row.Cells["Característica"].Value != null))
					{
						float per_consultor = Globais.StrToFloat(row.Cells["Comissão Consultor"].Value.ToString());
						string caracteristica = row.Cells["Característica"].Value.ToString().Trim();
						float limiar = Globais.StrToFloat(row.Cells["Limiar"].Value.ToString());
						float sinal = orcamento.CalculaSinal(fornecedor, caracteristica, vlr_itens, vlr_desconto, per_consultor, limiar);
						cell.Value = sinal.ToString("#0");
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
					}
					total += (vlr_itens - vlr_desconto);
				}
				
				DataGridViewCell cellFornecedor = row.Cells["Fornecedor"];
				DataGridViewCell cellValor = row.Cells["Valor"];
				cellValor.Style.BackColor = cellFornecedor.Style.BackColor;
				cellValor.Style.SelectionBackColor = cellFornecedor.Style.SelectionBackColor;
				if (row.Cells["Preço Tabela Alterado"].Value != null)
				{
					int alterados = Globais.StrToInt(row.Cells["Preço Tabela Alterado"].Value.ToString());
					if (alterados > 0)
					{
						cellValor.Style.BackColor = Color.Orange;
						cellValor.Style.SelectionBackColor = Color.Orange;
					}
				}
				if (row.Cells["Tabela Ativa"].Value != null)
				{
					string ativa = row.Cells["Tabela Ativa"].Value.ToString();
					if (ativa.Equals("N"))
					{
						cellValor.Style.BackColor = Color.Red;
						cellValor.Style.SelectionBackColor = Color.Red;
					}
				}
				
				
				registros++;
			}
			edtTotal.Text = total.ToString("#,###,##0.00");
			edtRegistros.Text = registros.ToString();
		}
	
		void CarregaOrcamentos()
		{
			this.Cursor = Cursors.WaitCursor;
			orcamento.Carrega(dgvCadastro, frmFiltro.fornecedor.Trim(), 
			                  frmFiltro.filtrar_data ? frmFiltro.anoi : 0, frmFiltro.mesi,
			                  frmFiltro.anof, frmFiltro.mesf,
			                  frmFiltro.vendedor.Trim(), frmFiltro.cliente.Trim(),
			                  frmFiltro.consultor.Trim(), frmFiltro.caracteristica.Trim(),
			                  frmFiltro.situacoes,
						 	  frmFiltro.idt_cadastroI,
							  frmFiltro.cadastroI,
							  frmFiltro.idt_cadastroF,
							  frmFiltro.cadastroF, frmFiltro.resumo.Trim());
			                  
			this.Cursor = Cursors.Default;
			Colore();
			foreach (DataGridViewRow row in dgvCadastro.Rows)
			{
				row.Cells["S"].Value = false;			
			}			
			if (dgvCadastro.Rows.Count == 0) {
				LimpaDetalhes();
			} else {
				dgvAnexos.Visible = true;
			}
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			string sBanco="";
			string sUltimoUsuario="";
			string sUltimaFilial="";

			ProdutosTabelas.lista = new ArrayList();
			
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
			
			/*
			float per_comissao;
			cComissaoLimiar comissao = new cComissaoLimiar();
			per_comissao = comissao.Calcula("AIR.MICRO", "BH REVENDA", 1000, -20f);    // 0.15 -12
			per_comissao = comissao.Calcula("AIR.MICRO", "BH REVENDA", 1000, -12f);    // 0.15 -12
			per_comissao = comissao.Calcula("AIR.MICRO", "BH REVENDA", 1000, -11.6f);  // 0.15 -12
			per_comissao = comissao.Calcula("AIR.MICRO", "BH REVENDA", 1000, -11.4f);  // 0.31 -11
			per_comissao = comissao.Calcula("AIR.MICRO", "BH REVENDA", 1000, -7.01f);  // 0.92  -7 
			per_comissao = comissao.Calcula("AIR.MICRO", "BH REVENDA", 1000, -6.99f);  // 0.92  -7
			per_comissao = comissao.Calcula("AIR.MICRO", "BH REVENDA", 1000, -6.20f);  // 1.08  -6
			per_comissao = comissao.Calcula("AIR.MICRO", "BH REVENDA", 1000, 0f);      // 2.00   0
			per_comissao = comissao.Calcula("AIR.MICRO", "BH REVENDA", 1000, 0.4f);    // 2.00   0
			per_comissao = comissao.Calcula("AIR.MICRO", "BH REVENDA", 1000, 0.5f);    // 2.16   1
			per_comissao = comissao.Calcula("AIR.MICRO", "BH REVENDA", 1000, 0.6f);    // 2.16   1
			per_comissao = comissao.Calcula("AIR.MICRO", "BH REVENDA", 1000, 9.49f);   // 3.39   9
			per_comissao = comissao.Calcula("AIR.MICRO", "BH REVENDA", 1000, 9.50f);   // 3.54  10
			per_comissao = comissao.Calcula("AIR.MICRO", "BH REVENDA", 1000, 9.51f);   // 3.54  10
			per_comissao = comissao.Calcula("AIR.MICRO", "BH REVENDA", 1000, 10.49f);  // 3.54  10
			per_comissao = comissao.Calcula("AIR.MICRO", "BH REVENDA", 1000, 30.00f);  // 5.00  20
			*/
			
			//Globais.sUsuario = "fabiana.ferrari";
			//Globais.bAdministrador = true;
			//vendedorAcao = null;
			
			cControleAcesso acesso = new cControleAcesso();
			if (!Globais.bAdministrador &&  !acesso.PermissaoSistema(Globais.sUsuario, Globais.sFilial, 
			                                                         ((clienteAcao == null) && (vendedorAcao == null)) ? 4 : 10))
			{
				MessageBox.Show("Usuário sem permissão para esse Sistema", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Close();
				return;
			}
			
			//cSituacoes situacoes = new cSituacoes();
			//situacoes.Carrega(cbxSituacoes);
			
			frmFiltro = new frmFiltroOrcamento(clienteAcao != null, vendedorAcao, situacaoAcao);
			frmFiltro.fornecedor = "";
			frmFiltro.filtrar_data = false;
			frmFiltro.mesi = DateTime.Today.Month;
			frmFiltro.anoi = DateTime.Today.Year;
			frmFiltro.mesf = DateTime.Today.Month;
			frmFiltro.anof = DateTime.Today.Year;
			if (vendedorAcao == null) {
				if (Globais.bAdministrador)
					frmFiltro.vendedor = "";
				else
					frmFiltro.vendedor = Globais.sUsuario;
			} else {
				frmFiltro.vendedor = vendedorAcao;
			}
			frmFiltro.cliente = clienteAcao != null ? clienteAcao : "";			
			frmFiltro.consultor = "";
			frmFiltro.caracteristica = "";
			//frmFiltro.situacao = "E Em Andamento";
			frmFiltro.situacoes.Clear();
			foreach (DataGridViewRow row in frmFiltro.dgvSituacoes.Rows)
			{
				row.Cells["Seleciona"].Value = false;
				if (situacaoAcao == null) {
					if (clienteAcao == null) {
						if (row.Cells["Aut"].Value.Equals("S")) {
							row.Cells["Seleciona"].Value = true;	
							frmFiltro.situacoes.Add(row.Cells["Código"].Value.ToString());						
						}
					}
					else {
						row.Cells["Seleciona"].Value = true;
						frmFiltro.situacoes.Add(row.Cells["Código"].Value.ToString());
					}
				} else {
					string descricao = row.Cells["Descrição"].Value.ToString().Trim();
					if (descricao.Equals(situacaoAcao.Trim())) {
						row.Cells["Seleciona"].Value = true;
						frmFiltro.situacoes.Add(row.Cells["Código"].Value.ToString());	
					}
					frmFiltro.dgvSituacoes.ReadOnly = true;
					frmFiltro.chkTodas.Enabled = false;
				}
			}
			
			frmFiltro.idt_cadastroI = "N";
			frmFiltro.cadastroI = DateTime.Now;
			frmFiltro.idt_cadastroF = "N";
			frmFiltro.cadastroF = DateTime.Now;
			frmFiltro.resumo = "";
			//frmFiltro.ShowDialog();
			CarregaOrcamentos();
			col_sorted = "";
			ord_sorted = SortOrder.Ascending;
		}
		
		void DgvCadastroRowEnter(object sender, DataGridViewCellEventArgs e)
		{
			edtResumo.Text = dgvCadastro.Rows[e.RowIndex].Cells["Resumo"].Value.ToString();
			edtUsuario.Text = dgvCadastro.Rows[e.RowIndex].Cells["Usuário"].Value.ToString();
			dtpData.Value = DateTime.Parse(dgvCadastro.Rows[e.RowIndex].Cells["Data"].Value.ToString());
			edtObservacao.Text = dgvCadastro.Rows[e.RowIndex].Cells["Observação"].Value.ToString();
			edtTabela.Text = dgvCadastro.Rows[e.RowIndex].Cells["Tabela"].Value.ToString();
			edtCaracteristica.Text = dgvCadastro.Rows[e.RowIndex].Cells["Característica"].Value.ToString();
			fornecedor = dgvCadastro.Rows[e.RowIndex].Cells["Fornecedor"].Value.ToString();
			cliente = dgvCadastro.Rows[e.RowIndex].Cells["Cliente"].Value.ToString();
			consultor = dgvCadastro.Rows[e.RowIndex].Cells["Consultor"].Value.ToString();
			DateTime data = DateTime.Parse(dgvCadastro.Rows[e.RowIndex].Cells["Data"].Value.ToString());
			short codigo = Globais.StrToShort(dgvCadastro.Rows[e.RowIndex].Cells["Cod"].Value.ToString());
			CarregaAnexos(fornecedor, data, codigo);

			
			// seta a comissao de acordo com o limiar da caracteristica
			if ((dgvCadastro.Rows[e.RowIndex].Cells["Fornecedor"].Value != null) &&
				(dgvCadastro.Rows[e.RowIndex].Cells["Característica"].Value != null))
			{
				float vlr_itens = Globais.StrToFloat(dgvCadastro.Rows[e.RowIndex].Cells["Valor Itens"].Value.ToString());
				float vlr_desconto = Globais.StrToFloat(dgvCadastro.Rows[e.RowIndex].Cells["Desconto"].Value.ToString());
				float per_consultor = Globais.StrToFloat(dgvCadastro.Rows[e.RowIndex].Cells["Comissão Consultor"].Value.ToString());
				string caracteristica = dgvCadastro.Rows[e.RowIndex].Cells["Característica"].Value.ToString().Trim();
				float limiar = Globais.StrToFloat(dgvCadastro.Rows[e.RowIndex].Cells["Limiar"].Value.ToString());
				float sinal = orcamento.CalculaSinal(fornecedor, caracteristica, vlr_itens, vlr_desconto, per_consultor, limiar);
				cComissaoLimiar comissao = new cComissaoLimiar();
				float vlr_orcamento = vlr_itens - vlr_desconto;
				float per_comissao = comissao.Calcula(fornecedor, caracteristica, vlr_orcamento, sinal);
				edtPerComissao.Text = per_comissao.ToString("#0.00");
				edtVlrComissao.Text = (per_comissao * vlr_orcamento / 100f).ToString("###,##0.00");
			}
		}
		
		void LimpaDetalhes()
		{
			edtResumo.Text = "";
			edtUsuario.Text = "";
			dtpData.Value = DateTime.Now;
			edtObservacao.Text = "";
			edtTabela.Text = "";
			edtCaracteristica.Text = "";
			edtPerComissao.Text = "";
			edtVlrComissao.Text = "";
			dgvAnexos.Visible = false;
		}
		
		void BtnIncluiClick(object sender, EventArgs e)
		{
			frmCadOrcamento frm = new frmCadOrcamento();
			frm.acao = 'i';
			frm.ShowDialog();
			if (!frm.result) return;
			CarregaOrcamentos();
			Grid.Sort(dgvCadastro, col_sorted, ord_sorted);
			Grid.MarcaSelecionados(dgvCadastro);
			Grid.Posiciona(dgvCadastro, frm.fornecedor.Trim()+frm.data.Trim()+frm.codigo.Trim());
		}
		
		void BtnFechaClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void BtnClienteClick(object sender, EventArgs e)
		{
			if (dgvCadastro.Rows.Count == 0) return;
			cControleAcesso acesso = new cControleAcesso();
			if (!acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fConParceiros")) return;				
			frmCadParceiros frmCad = new frmCadParceiros(true);
			frmCad.where = "where COD_PARCEIRO='" + cliente + "'";
			frmCad.codigo = cliente;
			frmCad.ReadOnly = !acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fCadParceiros");
			frmCad.ShowDialog();
		}
		
		void BtnFornecedorClick(object sender, EventArgs e)
		{
			if (dgvCadastro.Rows.Count == 0) return;
			cControleAcesso acesso = new cControleAcesso();
			if (!acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fConParceiros")) return;				
			frmCadParceiros frmCad = new frmCadParceiros(true);
			frmCad.where = "where COD_PARCEIRO='" + fornecedor + "'";
			frmCad.codigo = fornecedor;
			frmCad.ReadOnly = !acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fCadParceiros");
			frmCad.ShowDialog();
		}
		
		void BtnAlteraClick(object sender, EventArgs e)
		{
			float valor, desconto, total;
			if (dgvCadastro.Rows.Count == 0) return;			
			int i = dgvCadastro.CurrentRow.Index;
			frmCadOrcamento frm = new frmCadOrcamento();
			frm.acao = 'a';
			frm.alteracaoRestrita = alteracaoRestrita;
			frm.edtFornecedor.Text = dgvCadastro.Rows[i].Cells["Fornecedor"].Value.ToString().Trim();
			frm.dtpData.Value = DateTime.Parse(dgvCadastro.Rows[i].Cells["Data"].Value.ToString());
			frm.edtCodigo.Text = dgvCadastro.Rows[i].Cells["Cod"].Value.ToString().Trim();
			frm.usuario = dgvCadastro.Rows[i].Cells["Vendedor"].Value.ToString().Trim();
			frm.edtCliente.Text = dgvCadastro.Rows[i].Cells["Cliente"].Value.ToString().Trim();
			frm.edtContato.Text = dgvCadastro.Rows[i].Cells["Contato"].Value.ToString().Trim();
			frm.edtConsultor.Text = dgvCadastro.Rows[i].Cells["Consultor"].Value.ToString().Trim();
			frm.tabela = dgvCadastro.Rows[i].Cells["Tabela"].Value.ToString().Trim();
			frm.caracteristica = dgvCadastro.Rows[i].Cells["Característica"].Value.ToString().Trim();
			frm.pedido = dgvCadastro.Rows[i].Cells["P"].Value.ToString().Trim();
			valor = Globais.StrToFloat(dgvCadastro.Rows[i].Cells["Valor Itens"].Value.ToString());
			desconto = Globais.StrToFloat(dgvCadastro.Rows[i].Cells["Desconto"].Value.ToString());
			float per_consultor = 0;
			float.TryParse(dgvCadastro.Rows[i].Cells["Comissão Consultor"].Value.ToString(), out per_consultor);
			//float per_consultor = (valor != 0) ? (vlr_consultor * 100f / valor) : 0;
			float vlr_consultor = (valor != 0) ? (per_consultor * valor / 100f) : 0;
			total = valor - desconto;
			frm.edtPerConsultor.Text = per_consultor.ToString("#0.00");
			frm.edtVlrConsultor.Text = vlr_consultor.ToString("#,###,##0.00");
			frm.edtValor.Text = valor.ToString("#,###,##0.00");
			frm.edtDesconto.Text = desconto.ToString("#,###,##0.00");
			frm.edtTotal.Text = total.ToString("#,###,##0.00");
			frm.edtResumo.Text = dgvCadastro.Rows[i].Cells["Resumo"].Value.ToString().Trim();
			frm.edtObservacao.Text = dgvCadastro.Rows[i].Cells["Observação"].Value.ToString().Trim();
			frm.situacao = dgvCadastro.Rows[i].Cells["Situação"].Value.ToString().Trim();
			frm.ShowDialog();
			string chave = dgvCadastro.Rows[i].Cells["Chave"].Value.ToString().Trim();
			CarregaOrcamentos();
			Grid.Sort(dgvCadastro, col_sorted, ord_sorted);					
			Grid.MarcaSelecionados(dgvCadastro);
			Grid.Posiciona(dgvCadastro, chave);
		}
		
		void BtnExcluiClick(object sender, EventArgs e)
		{
			if (dgvCadastro.Rows.Count == 0) return;
			int i = dgvCadastro.CurrentRow.Index;						
			int codigo = Globais.StrToInt(dgvCadastro.Rows[i].Cells["Cod"].Value.ToString());
			DialogResult r = MessageBox.Show(codigo.ToString(), "Confirma a exclusão?",
			                                 MessageBoxButtons.YesNo, 
			                                 MessageBoxIcon.Question);
			if (r == DialogResult.No) return;	
			string fornecedor = dgvCadastro.Rows[i].Cells["Fornecedor"].Value.ToString();
			string msg="";
			DateTime data = DateTime.Parse(dgvCadastro.Rows[i].Cells["Data"].Value.ToString());
			if (orcamento.Exclui(fornecedor, data, codigo, ref msg))
			{
				CarregaOrcamentos();				
				Grid.Sort(dgvCadastro, col_sorted, ord_sorted);					
				Grid.MarcaSelecionados(dgvCadastro);
			}			
		}
		
		void BtnFiltroClick(object sender, EventArgs e)
		{
			frmFiltro.ShowDialog();
			if (frmFiltro.result)
			{
				CarregaOrcamentos();
				Grid.Sort(dgvCadastro, col_sorted, ord_sorted);					
				Grid.MarcaSelecionados(dgvCadastro);
			}			
		}
		
		void BtnItensClick(object sender, EventArgs e)
		{
			if (dgvCadastro.Rows.Count == 0) return;
			int i = dgvCadastro.CurrentRow.Index;
			short codigo = Globais.StrToShort(dgvCadastro.Rows[i].Cells["Cod"].Value.ToString());
			string fornecedor = dgvCadastro.Rows[i].Cells["Fornecedor"].Value.ToString();
			DateTime data = DateTime.Parse(dgvCadastro.Rows[i].Cells["Data"].Value.ToString());
			string cliente = dgvCadastro.Rows[i].Cells["Cliente"].Value.ToString();			
			string caracteristica = dgvCadastro.Rows[i].Cells["Característica"].Value.ToString().Trim();			
			cCaracteristicas caracteristicas = new cCaracteristicas();
			string formula = caracteristicas.Formula(fornecedor, caracteristica);
			frmCadItens frm = new frmCadItens();
			frm.fornecedor = fornecedor;
			frm.data = data;
			frm.cod_orcamento = codigo;
			frm.cliente = cliente;
			frm.tabela = dgvCadastro.Rows[i].Cells["Tabela"].Value.ToString();
			frm.formula = formula;
			frm.pedido = dgvCadastro.Rows[i].Cells["P"].Value.ToString().Trim().Equals("S");
			frm.ShowDialog();
			string chave = dgvCadastro.Rows[i].Cells["Chave"].Value.ToString().Trim();
			CarregaOrcamentos();
			Grid.Sort(dgvCadastro, col_sorted, ord_sorted);			
			Grid.MarcaSelecionados(dgvCadastro);
			Grid.Posiciona(dgvCadastro, chave);
		}
		
		void BtnGeraClick(object sender, EventArgs e)
		{
			if (dgvCadastro.Rows.Count == 0) return;
			fParametrosImpressao frm = new fParametrosImpressao();
			frm.ShowDialog();
			if (!frm.result) return;
			bool foto = frm.foto;
			bool resumida = frm.resumida;
			bool detalhada = frm.detalhada;
			bool endereco_filial = frm.endereco_filial;
			bool mostrar_valores = frm.mostrar_valores;
			bool consolidado = frm.consolidado;
			bool consolidado_item = frm.consolidado_item;
			bool total_prod_serv = frm.total_prod_serv;
			bool mostrar_medidas = frm.mostrar_medidas;
			bool listagem = frm.listagem;
			
			if (!listagem)
			{
				int i = consolidado ? -1 : 	dgvCadastro.CurrentRow.Index;
				/*
				string cod_fornecedor = dgvCadastro.Rows[i].Cells["Fornecedor"].Value.ToString().Trim();
				DateTime dat_orcamento = DateTime.Parse(dgvCadastro.Rows[i].Cells["Data"].Value.ToString().Trim());
				short cod_orcamento = Globais.StrToShort(dgvCadastro.Rows[i].Cells["Cod"].Value.ToString());			
				string cod_caracteristica = dgvCadastro.Rows[i].Cells["Característica"].Value.ToString().Trim();
				string cod_cliente = dgvCadastro.Rows[i].Cells["Cliente"].Value.ToString().Trim();
				string cod_contato = dgvCadastro.Rows[i].Cells["Contato"].Value.ToString().Trim();
				string observacao = dgvCadastro.Rows[i].Cells["Observação"].Value.ToString().Trim();
				float desconto = Globais.StrToFloat(dgvCadastro.Rows[i].Cells["Desconto"].Value.ToString().Trim());
				*/
				cPropostaComercial.Gera(
					i, dgvCadastro,
					//cod_fornecedor, dat_orcamento, cod_orcamento, cod_caracteristica, cod_cliente, observacao, desconto,
					frm.introducao, frm.informacoes_fornecimento, frm.termo_garantia, frm.condicoes_montagem, frm.termo_aprovacao,
					foto, resumida, detalhada, endereco_filial, mostrar_valores, consolidado_item, total_prod_serv, mostrar_medidas);
				return;
			}			
			/*
			DialogResult r = MessageBox.Show("Mostra Imagens?", "",
			                                 MessageBoxButtons.YesNo, 
			                                 MessageBoxIcon.Question);
			*/
			//string pdf = "c:\\softplace\\" + fornecedor.Trim() + data.Year + data.Month + codigo + ".pdf";			
			if (listagem)
			{
				
				if (orcamento.Lista(dgvCadastro, frm.bFornecedor, frm.bData, frm.bCod, frm.bVendedor, frm.bCliente, frm.bConsultor, frm.bSituacao, frm.bValor, frm.bSinal, frm.bOrdenarCaracteristica))
					System.Diagnostics.Process.Start("explorer", "orcamentos.pdf");
			}
			/*
			else
			{
				cOrcamentoPDF pdf_orcamento = new cOrcamentoPDF();	
				if (!consolidado)
				{
					int i = dgvCadastro.CurrentRow.Index;
					string fornecedor = dgvCadastro.Rows[i].Cells["Fornecedor"].Value.ToString();
					DateTime data = DateTime.Parse(dgvCadastro.Rows[i].Cells["Data"].Value.ToString());
					short codigo = Globais.StrToShort(dgvCadastro.Rows[i].Cells["Cod"].Value.ToString());			
					string arqpdf = fornecedor.Trim() + data.Year + data.Month + codigo + ".pdf";
					string caracteristica = dgvCadastro.Rows[i].Cells["Característica"].Value.ToString().Trim();			
					cCaracteristicas caracteristicas = new cCaracteristicas();
					string formula = caracteristicas.Formula(fornecedor, caracteristica);					
					pdf_orcamento.Open(arqpdf);
					orcamento.Gera(pdf_orcamento, fornecedor, data, codigo, arqpdf, formula, foto, resumida, detalhada, endereco_filial, mostrar_valores, consolidado_item);
					pdf_orcamento.Close();
					System.Diagnostics.Process.Start("explorer", arqpdf);
				}
				else
				{
					string arqpdf = "orcamentos.pdf";					
					pdf_orcamento.Open(arqpdf);					
					foreach (DataGridViewRow row in dgvCadastro.Rows)
					{
						if (!(bool)row.Cells["S"].Value)
						{
							continue;
						}
						string fornecedor = row.Cells["Fornecedor"].Value.ToString();
						DateTime data = DateTime.Parse(row.Cells["Data"].Value.ToString());
						short codigo = Globais.StrToShort(row.Cells["Cod"].Value.ToString());			
						string caracteristica = row.Cells["Característica"].Value.ToString().Trim();			
						cCaracteristicas caracteristicas = new cCaracteristicas();
						string formula = caracteristicas.Formula(fornecedor, caracteristica);					
						orcamento.Gera(pdf_orcamento, fornecedor, data, codigo, arqpdf, formula, foto, resumida, detalhada, endereco_filial, mostrar_valores, consolidado_item);						
						pdf_orcamento.SaltaPagina();
					}
					pdf_orcamento.Close();
					System.Diagnostics.Process.Start("explorer", arqpdf);
				}
			}
			*/
		}
		
		public void CarregaAnexos(string fornecedor, DateTime data, int codigo) 
		{
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
			for (; i<3; i++)
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
			if (dgvCadastro.Rows.Count == 0) return;
			int i = dgvCadastro.CurrentRow.Index;
			short codigo = Globais.StrToShort(dgvCadastro.Rows[i].Cells["Cod"].Value.ToString());
			string fornecedor = dgvCadastro.Rows[i].Cells["Fornecedor"].Value.ToString();
			DateTime data = DateTime.Parse(dgvCadastro.Rows[i].Cells["Data"].Value.ToString());
			frmAnexosOrcamento frmCad = new frmAnexosOrcamento();
			frmCad.fornecedor = fornecedor;
			frmCad.data = data;
			frmCad.cod_orcamento = codigo;
			frmCad.ShowDialog();
			CarregaAnexos(fornecedor, data, codigo);
			dgvCadastro.Focus();
		}
		
		void AbreAnexo(string codigo)
		{
			if (dgvCadastro.Rows.Count == 0) return;
			int i = dgvCadastro.CurrentRow.Index;
			short cod_orcamento = Globais.StrToShort(dgvCadastro.Rows[i].Cells["Cod"].Value.ToString());
			string fornecedor = dgvCadastro.Rows[i].Cells["Fornecedor"].Value.ToString();
			DateTime data = DateTime.Parse(dgvCadastro.Rows[i].Cells["Data"].Value.ToString());
			string fn = orcamento.CarregaAnexo(fornecedor, data, cod_orcamento, codigo);
			System.Diagnostics.Process.Start("explorer", fn);
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
		
		void BtnCopiaClick(object sender, EventArgs e)
		{
			if (dgvCadastro.Rows.Count == 0) return;
			int i = dgvCadastro.CurrentRow.Index;
			short cod_orcamento = Globais.StrToShort(dgvCadastro.Rows[i].Cells["Cod"].Value.ToString());
			string fornecedor = dgvCadastro.Rows[i].Cells["Fornecedor"].Value.ToString();
			DateTime data = DateTime.Parse(dgvCadastro.Rows[i].Cells["Data"].Value.ToString());
			orcamento.Copia(fornecedor, data, cod_orcamento);
			string chave = dgvCadastro.Rows[i].Cells["Chave"].Value.ToString().Trim();
			CarregaOrcamentos();			
			Grid.Sort(dgvCadastro, col_sorted, ord_sorted);			
			Grid.MarcaSelecionados(dgvCadastro);
			Grid.Posiciona(dgvCadastro, chave);
		}
		
		void BtnConsultorClick(object sender, EventArgs e)
		{
			if (dgvCadastro.Rows.Count == 0) return;
			cControleAcesso acesso = new cControleAcesso();
			if (!acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fConParceiros")) return;				
			frmCadParceiros frmCad = new frmCadParceiros(true);
			frmCad.where = "where COD_PARCEIRO='" + consultor + "'";
			frmCad.codigo = consultor;
			frmCad.ReadOnly = !acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fCadParceiros");
			frmCad.ShowDialog();
		}
		
		void BtnProdutosClick(object sender, EventArgs e)
		{
			fConsultaPreco frm = new fConsultaPreco();
			frm.ShowDialog();
		}
		
		void DgvCadastroSorted(object sender, EventArgs e)
		{
			col_sorted = dgvCadastro.SortedColumn.HeaderText;
			ord_sorted = dgvCadastro.SortOrder;
			Colore();
			foreach (DataGridViewRow row in dgvCadastro.Rows)
			{
				if ((bool)row.Cells["S"].Value)
				{
					row.DefaultCellStyle.BackColor = Color.SkyBlue;
				}
				else
				{
					row.DefaultCellStyle.BackColor = Color.White;
				}			
			}
			Grid.Posiciona(dgvCadastro, chave_sel);
		}
		
		void DgvCadastroCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex == -1) return;
			Grid.selecionado = e.RowIndex;
			Grid.col = e.ColumnIndex;		
			chave_sel = 
				dgvCadastro.Rows[e.RowIndex].Cells["Fornecedor"].Value.ToString().Trim() +
				dgvCadastro.Rows[e.RowIndex].Cells["Data"].Value.ToString().Trim() +
				dgvCadastro.Rows[e.RowIndex].Cells["Cod"].Value.ToString().Trim();			
		}
				
		void BtnPedidoClick(object sender, EventArgs e)
		{
			if (dgvCadastro.Rows.Count == 0) return;
			int i = dgvCadastro.CurrentRow.Index;
			
			// pedidos com sinal negativo só podem ser gerados pelo administrador
			int sinal = int.Parse(dgvCadastro.Rows[i].Cells["Sinal"].Value.ToString());
			if ((sinal < 0) && !Globais.bAdministrador)
			{
				MessageBox.Show("Esse pedido precisa de autorização");
				return;
			}
			
			string fornecedor = dgvCadastro.Rows[i].Cells["Fornecedor"].Value.ToString().Trim();
			string caracteristica = dgvCadastro.Rows[i].Cells["Característica"].Value.ToString().Trim();
			DateTime data = DateTime.Parse(dgvCadastro.Rows[i].Cells["Data"].Value.ToString());
			short codigo = Globais.StrToShort(dgvCadastro.Rows[i].Cells["Cod"].Value.ToString());
			
			string especial = orcamento.Especial(fornecedor, data, codigo);
			if (especial.Equals("S") && !Globais.bAdministrador)
			{
				MessageBox.Show("Esse pedido precisa de autorização");
				return;
			}
			
			float vlr_itens = Globais.StrToFloat(dgvCadastro.Rows[i].Cells["Valor Itens"].Value.ToString());
			float vlr_desconto = Globais.StrToFloat(dgvCadastro.Rows[i].Cells["Desconto"].Value.ToString());
			string cliente = dgvCadastro.Rows[i].Cells["Cliente"].Value.ToString().Trim();
		
			cCaracteristicas caracteristicas = new cCaracteristicas();
			string servico="";
			float dif = caracteristicas.DiferencaFormulas(fornecedor, caracteristica, data, codigo, ref servico);
			short dias = caracteristicas.DiasMontagem(fornecedor, caracteristica);
			
			cPedidos pedidos = new cPedidos();
			if (pedidos.Existe(fornecedor, data, codigo))
			{
					MessageBox.Show("Já existe pedido para esse orçamento", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
			}
			
			fGeraPedido frm = new fGeraPedido(dif, fornecedor, data, codigo, vlr_itens, vlr_desconto, servico, sinal, cliente, dias);
			frm.ShowDialog();
			if (frm.result)
			{
				string msg="";
				if (!orcamento.AlteraStatus(fornecedor, data, codigo, 'F', ref msg))
				{
					MessageBox.Show("Erro na alteração da situação\r\r" + msg);
				}
				if (!orcamento.AlteraPedido(fornecedor, data, codigo, 'S'))
				{
					MessageBox.Show("Erro na alteração do IDT de pedido");
				}
				dgvCadastro.Rows[i].Cells["P"].Value = 'S';
				dgvCadastro.Rows[i].Cells["Situação"].Value = "Fechado";
			}
		}
		
		void BtnRefreshClick(object sender, EventArgs e)
		{
			if (dgvCadastro.Rows.Count == 0) 
			{
				CarregaOrcamentos();
				Grid.Sort(dgvCadastro, col_sorted, ord_sorted);					
				Grid.MarcaSelecionados(dgvCadastro);
				return;
			}
			int i = dgvCadastro.CurrentRow.Index;
			string fornecedor = dgvCadastro.Rows[i].Cells["Fornecedor"].Value.ToString();
			DateTime data = DateTime.Parse(dgvCadastro.Rows[i].Cells["Data"].Value.ToString());
			short codigo = Globais.StrToShort(dgvCadastro.Rows[i].Cells["Cod"].Value.ToString());			
			string chave = dgvCadastro.Rows[i].Cells["Chave"].Value.ToString().Trim();
			CarregaOrcamentos();
			Grid.Sort(dgvCadastro, col_sorted, ord_sorted);					
			Grid.MarcaSelecionados(dgvCadastro);
			Grid.Posiciona(dgvCadastro, chave);
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
				int l = s.Length;
				int x = (int)(s.Length / 77) ;
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
		
		void EdtLocalizaTextChanged(object sender, EventArgs e)
		{
			Grid.Localiza(dgvCadastro, edtLocaliza.Text.Trim());
			if (Grid.selecionado != -1)
			{
				DataGridViewCellEventArgs e2 = new DataGridViewCellEventArgs(Grid.col, Grid.selecionado);
				DgvCadastroCellClick(sender, e2);
			}			
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
			Grid.Proximo(dgvCadastro, edtLocaliza.Text.Trim());
			if (Grid.selecionado != -1)
			{
				DataGridViewCellEventArgs e2 = new DataGridViewCellEventArgs(Grid.col, Grid.selecionado);
				DgvCadastroCellClick(sender, e2);
			}						
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
				
		void BtnPropostaClick(object sender, EventArgs e)
		{
			
		}
	}
	
	public class ProdutosTabela
	{
		public string fornecedor;
		public string tabela;
		public DataTable table;
		
		public ProdutosTabela(string fornecedor, string tabela)
		{
			this.fornecedor = fornecedor;
			this.tabela = tabela;
			table = null;
		}
	}
	
	public static class ProdutosTabelas
	{
		public static ArrayList lista;
	}
}
