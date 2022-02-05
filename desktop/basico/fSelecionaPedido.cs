/*
 * Criado por SharpDevelop.
 * Usuário: Ricardo
 * Data: 16/05/2009
 * Hora: 10:41
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using classes;
using System.Collections;

namespace basico
{
	public partial class fSelecionaPedido : Form
	{
		private frmFiltroPedido frmFiltro;
		public bool result;
		public string pedido;
		public ArrayList selecionados;
		private float valor;
		
		public fSelecionaPedido(float valor)
		{
			InitializeComponent();
			Grid.Inicializa();
			this.valor = valor;
			
			result = false;
			selecionados = new ArrayList();
		}
		
		void CarregaPedidos()
		{
			string filtro_selecionados="";
			foreach (string selecionado in selecionados)
			{
				string[] partes = selecionado.Split(' ');
				string fornecedor_sel = partes[0].Trim();
				DateTime data_sel = DateTime.Parse(partes[1].Trim());
				string orcamento_sel = partes[2].Trim();
				string pedido_sel = partes[3].Trim();
					
				filtro_selecionados = filtro_selecionados + 
					" or (a.COD_FORNECEDOR='" + fornecedor_sel + "' and " +
					"a.DAT_ORCAMENTO='" + data_sel.ToString("M/d/yyyy") + "' and " +
					"a.COD_ORCAMENTO=" + orcamento_sel + " and " +
					"a.COD_PEDIDO=" + pedido_sel + ")";
			}
			
			cPedidos pedidos = new cPedidos();
			this.Cursor = Cursors.WaitCursor;
			pedidos.CarregaSelecao(dgvCadastro,
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
							"", 
							filtro_selecionados, 
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
							frmFiltro.cadastroF);														
			foreach (DataGridViewRow row in dgvCadastro.Rows)
			{
				row.Selected = false;
			}
			SetChecks();
			this.Cursor = Cursors.Default;
		}
		
		void FSelecionaPedidoLoad(object sender, EventArgs e)
		{
			frmFiltro = new frmFiltroPedido();
			CarregaPedidos();
			Colore();
		}

		short CodOrcamento(string orcamento)
		{
			if (orcamento.Contains("/"))
				return Globais.StrToShort(orcamento.Substring(10));
			else
				return Globais.StrToShort(orcamento);
		}
		
		void Colore()
		{
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
				
				if (row.Cells["CodPedido"].Value != null)
				{
					short codpedido = Globais.StrToShort(row.Cells["CodPedido"].Value.ToString());
					if (codpedido == 2)
					{
						row.Cells["Fornecedor"].Value = "SERVICO";
					}
				}
			}
		}
		
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			if (dgvCadastro.Rows.Count == 0) return;
			result = true;
			GetChecks();
			Close();
		}
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void DgvCadastroDoubleClick(object sender, EventArgs e)
		{
			if (dgvCadastro.Rows.Count == 0) return;
			int i = dgvCadastro.CurrentRow.Index;	
			DataGridViewRow row = dgvCadastro.Rows[i];
			pedido =	row.Cells["Fornecedor Orçamento"].Value.ToString().Trim() + " " +
						DateTime.Parse(row.Cells["Data"].Value.ToString()).ToString("d/M/yyyy") + " " +
						row.Cells["Orçamento"].Value.ToString().Substring(10) + " " +
						row.Cells["CodPedido"].Value.ToString();
			result = true;
			Close();
		}
		
		void DgvCadastroCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dgvCadastro.Rows.Count == 0) return;
			selecionados.Clear();
			DataGridViewRow row = dgvCadastro.CurrentRow;
			pedido =	row.Cells["Fornecedor Orçamento"].Value.ToString().Trim() + " " +
						DateTime.Parse(row.Cells["Data"].Value.ToString()).ToString("d/M/yyyy") + " " +
						row.Cells["Orçamento"].Value.ToString().Substring(10) + " " +
						row.Cells["CodPedido"].Value.ToString();
			selecionados.Add(pedido);
			result = true;
			Close();			
		}
		
		void SetChecks()
		{
			foreach (DataGridViewRow row in dgvCadastro.Rows)
			{
				string fornecedor = row.Cells["Fornecedor"].Value.ToString().Trim();
				DateTime data = DateTime.Parse(row.Cells["Data"].Value.ToString().Trim());
				short orcamento = CodOrcamento(row.Cells["Orçamento"].Value.ToString().Trim());
				string pedido = row.Cells["CodPedido"].Value.ToString().Trim();
				row.Cells["S"].Value = false;
				row.DefaultCellStyle.BackColor = Color.White;
			
				foreach (string selecionado in selecionados)
				{
					string[] partes = selecionado.Split(' ');
					string fornecedor_sel = partes[0].Trim();
					DateTime data_sel = DateTime.Parse(partes[1].Trim());
					short orcamento_sel = CodOrcamento(partes[2].Trim());
					string pedido_sel = partes[3].Trim();
					
					if ((fornecedor.Equals(fornecedor_sel)) &&
					    (data == data_sel)  &&
					    (orcamento.Equals(orcamento_sel)) &&
					    (pedido.Equals(pedido_sel)))
					{
						row.DefaultCellStyle.BackColor = Color.SkyBlue;
						row.Cells["S"].Value = true;
						break;
					}					
				}
			}			
		}
		
		void GetChecks()
		{
			selecionados.Clear();
			foreach (DataGridViewRow row in dgvCadastro.Rows)
			{
				if ((bool)row.Cells["S"].Value)
				{
					pedido =	row.Cells["Fornecedor Orçamento"].Value.ToString().Trim() + " " +
								DateTime.Parse(row.Cells["Data"].Value.ToString()).ToString("d/M/yyyy") + " " +
								row.Cells["Orçamento"].Value.ToString().Substring(10) + " " +
								row.Cells["CodPedido"].Value.ToString();
					selecionados.Add(pedido);					
				}
			}			
		}		
		
		void DgvCadastroCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if ((bool)dgvCadastro.CurrentRow.Cells["S"].Value)
			{
				string fornecedor = dgvCadastro.CurrentRow.Cells["Fornecedor Orçamento"].Value.ToString().Trim();
				DateTime data = DateTime.Parse(dgvCadastro.CurrentRow.Cells["Data"].Value.ToString().Trim());
				short orcamento = CodOrcamento(dgvCadastro.CurrentRow.Cells["Orçamento"].Value.ToString().Trim());
				string pedido = dgvCadastro.CurrentRow.Cells["CodPedido"].Value.ToString().Trim();				
				
				if (valor > 0)
				{
					DialogResult r = MessageBox.Show("Despesa de Frete?", "Despesa de Frete?", 
			                                 		MessageBoxButtons.YesNo, 
			                                 		MessageBoxIcon.Question);
					if (r == DialogResult.Yes) {						
						float frete = cPedidos.FretePedido(fornecedor, data, orcamento, short.Parse(pedido));
						fFrete frm = new fFrete();
						frm.frete_atual = frete;
						frm.valor = valor;
						frm.ShowDialog();
						if (frm.result) 
						{
							cPedidos.AlteraFrete(fornecedor, data, orcamento, short.Parse(pedido), frm.novo_frete);
						}
					}
				}				
				
				cTitulosPagar titulosp = new cTitulosPagar();				
				ArrayList listap = titulosp.CarregaPorPedidoHint(fornecedor, data, orcamento, short.Parse(pedido));
				cTitulosXeceber titulosr = new cTitulosXeceber();				
				ArrayList listar = titulosr.CarregaPorPedidoHint(fornecedor, data, orcamento, short.Parse(pedido), true);						
				if ((listap.Count > 0) || (listar.Count > 0))
				{	
					string msg="";
					if (listap.Count > 0)
					{
						msg = msg + "Pedido já relacionado com as despesas:";
						foreach (string titulo in listap) 
						{
							msg = msg + "\n" + titulo;
						}
					}
					if (listar.Count > 0)
					{
						if (listap.Count > 0)
						{
							msg = msg + "\n";
						}
						msg = msg + "Pedido já relacionado com as receitas:";
						foreach (string titulo in listar) 
						{
							msg = msg + "\n" + titulo;
						}
					}					
					MessageBox.Show(msg);
					//dgvCadastro.CurrentRow.Cells["S"].Value = false;
					//dgvCadastro.CurrentRow.Cells["Fornecedor"].Selected = true;
					//DgvCadastroCellContentClick(sender, e);
					return;
				}
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
		
		void DgvCadastroSorted(object sender, EventArgs e)
		{
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
		}
		
		void BtnFiltroClick(object sender, EventArgs e)
		{
			frmFiltro.ShowDialog();
			if (frmFiltro.result)
			{
				CarregaPedidos();			
				Colore();
			}
		}
		
		void EdtLocalizaTextChanged(object sender, EventArgs e)
		{
			Grid.Localiza(dgvCadastro, edtLocaliza.Text.Trim());
		}
		
		void BtnDownClick(object sender, EventArgs e)
		{
			Grid.Proximo(dgvCadastro, edtLocaliza.Text.Trim());		
		}
		
		void BtnUpClick(object sender, EventArgs e)
		{
			Grid.Anterior(dgvCadastro, edtLocaliza.Text.Trim());		
		}
		
		void DgvCadastroCellClick(object sender, DataGridViewCellEventArgs e)
		{
			Grid.selecionado = e.RowIndex;
			Grid.col = e.ColumnIndex;			
		}
	}
}
