/*
 * Ao marcar pagar todos o IDT estava sendo alterado para 'S' mas o percentual continuava 0
 * Antes da alteração para aceitar pagar 0, o programa movia o calculado para o pago caso o paga estivesse 0
 * Programa alterado para gravar o valor calculado no pago ao marcar pagar todos
 * pendente: fazer um programa para acertar nas condições:
 * select count(*) from pedidos where IDT_VENDEDOR='S' and PER_VENDEDOR=0 and JUS_VENDEDOR=''; 1247
 * select count(*) from pedidos where IDT_consultor='S' and per_consultor=0 and jus_consultor=''; 242
 */


/*
 * Projeto  : SoftPlace
 * Sistema  : Pedidos
 * Programa : Comissao
 * Autor    : Ricardo Costa Xavier
 * Data     : 01/11/09
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using classes;
using System.Data;
using FirebirdSql.Data.FirebirdClient;

namespace pedido
{
	public partial class fComissao : Form
	{
		private DataGridView dgvSelecao;
		private bool pago_zerado=false;
		
		public fComissao(DataGridView dgvSelecao)
		{
			this.dgvSelecao = dgvSelecao;
			InitializeComponent();
			chkTodos.Visible = Globais.bAdministrador;
			btnAlteraComissao.Visible = Globais.bAdministrador;
		}
		
		short CodOrcamento(string orcamento)
		{
			if (orcamento.Contains("/"))
				return Globais.StrToShort(orcamento.Substring(10));
			else
				return Globais.StrToShort(orcamento);
		}		

		/*
		private void calcula_itens(string fornecedor, DateTime data, short orcamento, string formula, float per_calculo, ref float per_recalculo)
		{
			FbCommand cmd =  new FbCommand("select " +
			                     "       a.seq_item, " +
			                     "       a.qtd_item, " +
			                     "       a.idt_especial, " +			                     			                     
			                     "       a.vlr_preco, " +			                     
			                     "       b.per_ipi " +                    			                     
			                     "from ITENS a, PRODUTOS b " +
			                     "where a.cod_fornecedor='" + fornecedor + "' and " +
				                 "      a.dat_orcamento='" + data.ToString("M/d/yyyy") + "' and " +
				                 "      a.cod_orcamento=" + orcamento + " and " +
				         		 "      a.cod_fornecedor=b.cod_parceiro and " +
				         		 "      a.cod_produto=b.cod_produto and " +
				         		 "      a.sub_codigo=b.sub_codigo " +								
				                 "      order by a.seq_item",				         		 
				                 Globais.bd);
			float valor_recalculo = 0;
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			while (reader.Read())
			{
				short seq = (short)(!reader.IsDBNull(0) ? (int)reader.GetInt16(0) : 0);
				short qtd = (short)(!reader.IsDBNull(1) ? (int)reader.GetInt16(1) : 0);
				string especial = (reader.IsDBNull(2) ? reader.GetString(2) : "");
				float valor = (!reader.IsDBNull(3) ? (int)reader.GetFloat(3) : 0f);
				float ipi = (!reader.IsDBNull(4) ? (int)reader.GetFloat(4) : 0f);
				valor_recalculo = valor;
				Globais.CalculaFormula(ref valor_recalculo, formula, 0);
				per_recalculo = valor_recalculo * per_calculo / valor;
			}
			reader.Close();
		}
		*/
				
		void calcula()
		{
			cComissaoLimiar comissao_limiar = new cComissaoLimiar();			
			float tot_pedido=0;
			float tot_valor=0;
			float tot_calculo=0;
			float tot_recalculo=0;
			float tot_pago=0;
			float tot_comissao=0;
			float valor_pago=0;
			float valor_pagar=0;
			int n=0;
			if (rbtVendedor.Checked || rbtFilial.Checked)
			{
				dgvCadastro.Columns["Vendedor"].HeaderText = "Vendedor";
			}
			else
			{
				dgvCadastro.Columns["Vendedor"].HeaderText = "Consultor";
			}
			dgvCadastro.Rows.Clear();
			cCaracteristicas carac = new cCaracteristicas();
			int isel = 0;
			foreach (DataGridViewRow sel in dgvSelecao.Rows)
			{
				if (!(bool)sel.Cells["S"].Value)
				{
					isel++;
					continue;
				}

				int i = dgvCadastro.Rows.Add();
				DataGridViewRow row = dgvCadastro.Rows[i];
				row.Cells["isel"].Value = isel;
				DateTime data = DateTime.Parse(sel.Cells["Data"].Value.ToString());
				short orcamento = CodOrcamento(sel.Cells["Orçamento"].Value.ToString());
				
				float valor = Globais.StrToFloat(sel.Cells["Valor"].Value.ToString());
				string fornecedor = sel.Cells["Fornecedor Orçamento"].Value.ToString();
				string caracteristica = sel.Cells["Característica"].Value.ToString();
				string venpro="", venser="", conpro="", conser="", filpro="", filser="";
				carac.FormulasComissao(fornecedor, caracteristica, ref venpro, ref venser, ref conpro, ref conser, ref filpro, ref filser);
				float sinal = Globais.StrToFloat(sel.Cells["Sinal"].Value.ToString());
				int cod_pedido = Globais.StrToInt(sel.Cells["CodPedido"].Value.ToString());
	
				float vlr_frete = Globais.StrToFloat(sel.Cells["Valor Frete"].Value.ToString());
				float vlr_frete_item=0;
				float per_frete=0;
				if (vlr_frete > 0)
				{
					vlr_frete_item = cPedidos.RateiaFrete(fornecedor, data, orcamento, (short)cod_pedido, ref vlr_frete);
				}
				else
				{	
					per_frete = cCaracteristicas.Frete(fornecedor, caracteristica);
				}
				
				float per_pago=0;
				bool pago=false;
				string formula="";
				if (rbtVendedor.Checked)
				{
					pago = sel.Cells["IdtVendedor"].Value.ToString().Equals("S");					
					per_pago = Globais.StrToFloat(sel.Cells["PerVendedor"].Value.ToString());
					row.Cells["Justificativa"].Value = sel.Cells["JusVendedor"].Value.ToString();
					if (cod_pedido == 1)
					{
						formula = venpro;
					}
					else
					{
						formula = venser;
					}
					
				}
				if (rbtConsultor.Checked)
				{
					pago = sel.Cells["IdtConsultor"].Value.ToString().Equals("S");					
					per_pago = Globais.StrToFloat(sel.Cells["PerConsultor"].Value.ToString());
					row.Cells["Justificativa"].Value = sel.Cells["JusConsultor"].Value.ToString();					
					if (cod_pedido == 1)
					{
						formula = conpro;
					}
					else
					{
						formula = conser;
					}					
				}
				if (rbtFilial.Checked)
				{
					pago = sel.Cells["IdtFilial"].Value.ToString().Equals("S");					
					per_pago = Globais.StrToFloat(sel.Cells["PerFilial"].Value.ToString());
					row.Cells["Justificativa"].Value = sel.Cells["JusFilial"].Value.ToString();					
					if (cod_pedido == 1)
					{
						formula = venpro;
					}
					else
					{
						formula = venser;
					}					
				}
				float valor_pedido = valor;
				Globais.CalculaFormula(ref valor, formula, 0, per_frete, vlr_frete_item);
				isel++;
				float per_calculo=0;
				if (rbtConsultor.Checked)
					per_calculo = Globais.StrToFloat(sel.Cells["Comissão Consultor"].Value.ToString());
				else
				if (rbtFilial.Checked)
				{
					if (cod_pedido == 1)
					{
						per_calculo = Globais.StrToFloat(sel.Cells["Comissão Filial"].Value.ToString());
					}
					else
					{
						per_calculo = 100;
					}
				}
				else
					per_calculo = comissao_limiar.Calcula(fornecedor, caracteristica, valor, sinal);
				row.Cells["PG"].Value = pago;
				float valor_recalculo = valor;
				float per_recalculo = per_calculo;
				if (formula.Length > 0)
				{
					//calcula_itens(fornecedor, data, orcamento, formula, per_calculo, ref per_recalculo);
				}
				//if ((per_pago == 0) && !pago_zerado)
				if ((per_pago == 0) && !pago)
				{
					per_pago = per_calculo;
				}
				float comissao = per_pago * valor / 100f;
				bool pg = row.Cells["PG"].Value != null ? bool.Parse(row.Cells["PG"].Value.ToString()) : false;
				tot_pedido += valor_pedido;
				tot_valor += valor;
				tot_calculo += per_calculo;
				tot_recalculo += per_recalculo;
				tot_pago += per_pago;				
				tot_comissao += comissao;				
				if (!pg)
				{
					valor_pagar += comissao;				
				}
				else
				{
					valor_pago += comissao;				
				}
				n++;
				row.Cells["Fornecedor"].Value = sel.Cells["Fornecedor"].Value.ToString();									
				row.Cells["FornecedorOrcamento"].Value = sel.Cells["Fornecedor Orçamento"].Value.ToString();									
				row.Cells["Data"].Value = DateTime.Parse(sel.Cells["Data"].Value.ToString()).ToString("d/M/yyyy");
				row.Cells["Orcamento"].Value = sel.Cells["Orçamento"].Value.ToString();									
				row.Cells["Pedido"].Value = sel.Cells["Ped"].Value.ToString();					
				row.Cells["CodPedido"].Value = sel.Cells["CodPedido"].Value.ToString();					
				row.Cells["Cliente"].Value = sel.Cells["Cliente"].Value.ToString();					
				if (rbtVendedor.Checked || rbtFilial.Checked)
				{
					row.Cells["Vendedor"].Value = sel.Cells["Vendedor"].Value.ToString();					
				}
				else
				{
					row.Cells["Vendedor"].Value = sel.Cells["Consultor"].Value.ToString();					
				}
				row.Cells["ValorPedido"].Value = valor_pedido.ToString("#,###,##0.00");
				row.Cells["Valor"].Value = valor.ToString("#,###,##0.00");
				
				row.Cells["Calculo"].Value = per_calculo.ToString("#0.00");
				//row.Cells["Recalculo"].Value = per_recalculo.ToString("#0.00");
				row.Cells["Pago"].Value = per_pago.ToString("#0.00");
				row.Cells["Comissao"].Value = comissao.ToString("#,###,##0.00");					
				
				if (rbtVendedor.Checked)
					edtJustificativa.Text = sel.Cells["JusVendedor"].Value.ToString();
				if (rbtConsultor.Checked)
					edtJustificativa.Text = sel.Cells["JusConsultor"].Value.ToString();
				if (rbtFilial.Checked)
					edtJustificativa.Text = sel.Cells["JusFilial"].Value.ToString();							
				
			}
			edtTotPedido.Text= tot_pedido.ToString("#,###,##0.00");
			edtTotValor.Text= tot_valor.ToString("#,###,##0.00");
			if (n > 0)
			{
				edtTotCalculo.Text= (tot_calculo / n).ToString("#0.00");
				//edtTotRecalculo.Text= (tot_recalculo / n).ToString("#0.00");
				edtTotPago.Text= (tot_pago / n).ToString("#0.00");
			}
			else
			{
				edtTotCalculo.Text= 0.ToString("#0.00");
				//edtTotRecalculo.Text= (tot_recalculo / n).ToString("#0.00");
				edtTotPago.Text= 0.ToString("#0.00");				
			}
			edtTotComissao.Text= tot_comissao.ToString("#,###,##0.00");
			edtValorPago.Text= valor_pago.ToString("#,###,##0.00");
			edtValorPagar.Text= valor_pagar.ToString("#,###,##0.00");			
		}
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			calcula();			
		}		
			
		void BtnFechaClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void BtnAlteraComissaoClick(object sender, EventArgs e)
		{
			if (dgvCadastro.Rows.Count == 0) return;
			int i = dgvCadastro.CurrentRow.Index;			
			//float percentual_anterior = Globais.StrToFloat(dgvCadastro.Rows[i].Cells["Pago"].Value.ToString());
			fAlteraComissao frm = new fAlteraComissao();
			frm.total = Globais.StrToFloat(dgvCadastro.Rows[i].Cells["Valor"].Value.ToString());
			frm.percentual = Globais.StrToFloat(dgvCadastro.Rows[i].Cells["Pago"].Value.ToString());
			frm.pago = bool.Parse(dgvCadastro.Rows[i].Cells["PG"].Value.ToString());			
			frm.justificativa = dgvCadastro.Rows[i].Cells["Justificativa"].Value.ToString();		
			frm.ShowDialog();
			if (!frm.result) return;
			//pago_zerado = (percentual_anterior > 0.001) && (frm.percentual < 0.001);			
			pago_zerado = (frm.pago && (frm.percentual < 0.001));
			dgvCadastro.Rows[i].Cells["PG"].Value = frm.pago;
			dgvCadastro.Rows[i].Cells["Justificativa"].Value = frm.justificativa;
			string fornecedor = dgvCadastro.Rows[i].Cells["FornecedorOrcamento"].Value.ToString();			
			DateTime data = DateTime.Parse(dgvCadastro.Rows[i].Cells["Data"].Value.ToString());
			short orcamento = CodOrcamento(dgvCadastro.Rows[i].Cells["Orcamento"].Value.ToString());
			short pedido = Globais.StrToShort(dgvCadastro.Rows[i].Cells["CodPedido"].Value.ToString());
			cPedidos ped = new cPedidos();
			int isel = Globais.StrToInt(dgvCadastro.Rows[i].Cells["isel"].Value.ToString());			
			int nsel = dgvSelecao.Rows.Count;			
			if (rbtVendedor.Checked)
			{
				ped.AlteraPerVendedor(fornecedor, data, orcamento, pedido, frm.percentual, frm.justificativa);
				dgvSelecao.Rows[isel].Cells["PerVendedor"].Value = frm.percentual;
				dgvSelecao.Rows[isel].Cells["JusVendedor"].Value = frm.justificativa;
				ped.AlteraIdtVendedor(fornecedor, data, orcamento, pedido, frm.pago);
				dgvSelecao.Rows[isel].Cells["IdtVendedor"].Value = frm.pago ? "S" : "N";				
			}
			if (rbtConsultor.Checked)
			{
				ped.AlteraPerConsultor(fornecedor, data, orcamento, pedido, frm.percentual, frm.justificativa);
				dgvSelecao.Rows[isel].Cells["PerConsultor"].Value = frm.percentual;
				dgvSelecao.Rows[isel].Cells["JusConsultor"].Value = frm.justificativa;
				ped.AlteraIdtConsultor(fornecedor, data, orcamento, pedido, frm.pago);
				dgvSelecao.Rows[isel].Cells["IdtConsultor"].Value = frm.pago ? "S" : "N";				
			}
			if (rbtFilial.Checked)
			{
				ped.AlteraPerFilial(fornecedor, data, orcamento, pedido, frm.percentual, frm.justificativa);
				dgvSelecao.Rows[isel].Cells["PerFilial"].Value = frm.percentual;
				dgvSelecao.Rows[isel].Cells["JusFilial"].Value = frm.justificativa;
				ped.AlteraIdtFilial(fornecedor, data, orcamento, pedido, frm.pago);
				dgvSelecao.Rows[isel].Cells["IdtFilial"].Value = frm.pago ? "S" : "N";				
			}				
			calcula();			
			Posiciona(fornecedor, data, orcamento, pedido);
		}
		
		void RbtVendedorCheckedChanged(object sender, EventArgs e)
		{
			dgvCadastro.Rows.Clear();
		}
		
		void BtnImprimeClick(object sender, EventArgs e)
		{
			fParametrosImpressaoCom frm = new fParametrosImpressaoCom(dgvCadastro);
			frm.ShowDialog();		
			if (!frm.result) return;
			cPedidos pedidos = new cPedidos();
			if (pedidos.ListaComissao(dgvCadastro, rbtVendedor.Checked, rbtConsultor.Checked, rbtFilial.Checked, frm.somente_pago, frm.somente_pagar, frm.titulo, frm.justificativas))
				System.Diagnostics.Process.Start("explorer", "comissao.pdf");			
		}
		
		public void Posiciona(string fornecedor, DateTime data, short orcamento, short pedido)
		{
			for (int i=0; i<dgvCadastro.Rows.Count; i++)
			{
				string _fornecedor = dgvCadastro.Rows[i].Cells["Fornecedor"].Value.ToString();			
				DateTime _data = DateTime.Parse(dgvCadastro.Rows[i].Cells["Data"].Value.ToString());
				short _orcamento = CodOrcamento(dgvCadastro.Rows[i].Cells["Orcamento"].Value.ToString());
				short _pedido = Globais.StrToShort(dgvCadastro.Rows[i].Cells["CodPedido"].Value.ToString());
				if (_fornecedor.Equals(fornecedor) && (_data == data) && 
				    (_orcamento == orcamento) && (_pedido == pedido))
				{
					dgvCadastro.Rows[i].Cells[0].Selected = true;
					dgvCadastro.CurrentCell = dgvCadastro.Rows[i].Cells[0];
					return;
				}
			}
		}				

		void AlteraIdt(DataGridViewRow row, string pago, float percentual)
		{
			string fornecedor = row.Cells["Fornecedor Orçamento"].Value.ToString();						
			DateTime data = DateTime.Parse(row.Cells["Data"].Value.ToString());
			short orcamento = CodOrcamento(row.Cells["Orçamento"].Value.ToString());
			short pedido = Globais.StrToShort(row.Cells["CodPedido"].Value.ToString());			
			cPedidos ped = new cPedidos();
			if (rbtVendedor.Checked)
				ped.AlteraIdtVendedor(fornecedor, data, orcamento, pedido, pago.Equals("S"));
			if (rbtConsultor.Checked)
				ped.AlteraIdtConsultor(fornecedor, data, orcamento, pedido, pago.Equals("S"));
			if (rbtFilial.Checked)
				ped.AlteraIdtFilial(fornecedor, data, orcamento, pedido, pago.Equals("S"));
			if (pago.Equals("S")) {	
				if (rbtVendedor.Checked)
					ped.AlteraPerVendedor(fornecedor, data, orcamento, pedido, percentual, null);
				if (rbtConsultor.Checked)
					ped.AlteraPerConsultor(fornecedor, data, orcamento, pedido, percentual, null);
				if (rbtFilial.Checked)
					ped.AlteraPerFilial(fornecedor, data, orcamento, pedido, percentual, null);
			}
		}

		float ProcuraValorPago(int i) {
			foreach (DataGridViewRow row in dgvCadastro.Rows) {
				int isel = Globais.StrToInt(row.Cells["isel"].Value.ToString());
				if (isel == i) {
					float pago = Globais.StrToFloat(row.Cells["Pago"].Value.ToString());
					return pago;
				}
			}
			return 0;
		}
		
		void ChkTodosCheckedChanged(object sender, EventArgs e)
		{
			int i = 0;
			if (rbtVendedor.Checked)
			{
				if (chkTodos.Checked)
				{
					foreach (DataGridViewRow row in dgvSelecao.Rows)
					{
						if ((bool)row.Cells["S"].Value)
						{
							row.Cells["IdtVendedor"].Value = "S";
							float valor = ProcuraValorPago(i);
							AlteraIdt(row, "S", valor);
							row.Cells["PerVendedor"].Value = valor;
						}
						i++;						
					}
				}
				else
				{
					foreach (DataGridViewRow row in dgvSelecao.Rows)
					{
						if ((bool)row.Cells["S"].Value)
						{						
							row.Cells["IdtVendedor"].Value = "N";
							AlteraIdt(row, "N", 0);
						}
					}								
				}
			}			
			if (rbtConsultor.Checked)
			{
				if (chkTodos.Checked)
				{
					foreach (DataGridViewRow row in dgvSelecao.Rows)
					{
						if ((bool)row.Cells["S"].Value)
						{						
							row.Cells["IdtConsultor"].Value = "S";
							float valor = ProcuraValorPago(i);
							AlteraIdt(row, "S", valor);
							row.Cells["PerConsultor"].Value = valor;							
						}
						i++;
					}
				}
				else
				{
					foreach (DataGridViewRow row in dgvSelecao.Rows)
					{
						if ((bool)row.Cells["S"].Value)
						{												
							row.Cells["IdtConsultor"].Value = "N";
							AlteraIdt(row, "N", 0);
						}
					}								
				}
			}						
			if (rbtFilial.Checked)
			{
				if (chkTodos.Checked)
				{
					foreach (DataGridViewRow row in dgvSelecao.Rows)
					{
						if ((bool)row.Cells["S"].Value)
						{												
							row.Cells["IdtFilial"].Value = "S";
							float valor = ProcuraValorPago(i);
							AlteraIdt(row, "S", valor);
							row.Cells["PerFilial"].Value = valor;														
						}
						i++;
					}
				}
				else
				{
					foreach (DataGridViewRow row in dgvSelecao.Rows)
					{
						if ((bool)row.Cells["S"].Value)
						{												
							row.Cells["IdtFilial"].Value = "N";
							AlteraIdt(row, "N", 0);
						}
					}								
				}
			}									
			calcula();
		}
		
		void DgvCadastroRowEnter(object sender, DataGridViewCellEventArgs e)
		{
			if (dgvCadastro.Rows.Count == 0) return;
			int i=e.RowIndex;
			if (dgvCadastro.Rows[i].Cells["isel"].Value == null) return;
			int isel = Globais.StrToInt(dgvCadastro.Rows[i].Cells["isel"].Value.ToString());			
			if (rbtVendedor.Checked)
				edtJustificativa.Text = dgvSelecao.Rows[isel].Cells["JusVendedor"].Value.ToString();
			if (rbtConsultor.Checked)
				edtJustificativa.Text = dgvSelecao.Rows[isel].Cells["JusConsultor"].Value.ToString();
			if (rbtFilial.Checked)
				edtJustificativa.Text = dgvSelecao.Rows[isel].Cells["JusFilial"].Value.ToString();
		}
	}
}
