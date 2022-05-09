/*
 * Geração de Pedido
 * Usuário: Ricardo
 * Data: 21/02/09
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using templates;
using classes;
using basico;
using System.Collections;

namespace orcamento
{
	public partial class fGeraPedido : Form
	{
		private float dif;
		private string fornecedor;
		private DateTime data;
		private short orcamento;
		private float vlr_itens;
		private float vlr_desconto;
		private string servico;
		private int sinal;
		private string cliente;
		private short dias;
		public bool result;
		
		public fGeraPedido(float dif, string fornecedor, DateTime data, short orcamento, float vlr_itens, float vlr_desconto, string servico, int sinal, string cliente, short dias)
		{
			InitializeComponent();
			this.dif = dif;
			this.fornecedor = fornecedor;
			this.data = data;
			this.orcamento = orcamento;
			this.vlr_itens = vlr_itens;
			this.vlr_desconto = vlr_desconto;
			this.servico = servico;
			this.sinal = sinal;
			this.cliente = cliente;
			this.dias = dias;
			
			if (dif > 0)
			{
				float produtos = vlr_itens - dif;
				float servicos = dif - vlr_desconto;
				edtProdutos.Text = produtos.ToString("#,###,##0.00");
				edtServicos.Text = servicos.ToString("#,###,##0.00");
			}
			else
			{
				float produtos = vlr_itens - vlr_desconto;
				float servicos = 0;
				edtProdutos.Text = produtos.ToString("#,###,##0.00");
				edtServicos.Text = servicos.ToString("#,###,##0.00");
			}
			edtSinal.Text = sinal.ToString("####0");
			edtSinal.BackColor = Color.Yellow;
			if (sinal > 0)
				edtSinal.BackColor = Color.Green;
			else
			if (sinal < 0)
				edtSinal.BackColor = Color.Red;
			
			dtpEntrega.Value = DateTime.Now.AddDays(30);
			dtpMontagem.Value = DateTime.Now.AddDays(30 + dias);
			dtpEntrega.Checked = true;
			dtpMontagem.Checked = true;
			
			cCondicoesPagto condicoes = new cCondicoesPagto();
			this.Cursor = Cursors.WaitCursor;
			condicoes.CarregaComDescricao(cbxCondicoesPagto);
			this.Cursor = Cursors.Default;
		}
		
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			// verifica se os dados do cliente estão preenchidos
			cParceiro parceiro = new cParceiro();

			string mensagem="";			
			for (;;)
			{
				mensagem = "";
				if (!parceiro.Le(cliente))
				{
					MessageBox.Show("Cliente não cadastrado");
					return;
				}
				
				if (parceiro.NOM_PARCEIRO.Length == 0)
					mensagem = "NOME não preenchido";
				
				if (parceiro.NRO_CPF_CNPJ.Length == 0)
					mensagem = mensagem + "\nCPF/CNPJ não preenchido";
			        
				bool entrega=false;
				if (parceiro.DES_LOGRADOURO_ENTREGA.Length == 0)
				{
					if (parceiro.DES_LOGRADOURO.Length == 0)	
						mensagem = mensagem + "\nLOGRADOURO não preenchido";
				}
				else entrega = true;
			
				if (!entrega)
				{
					if (parceiro.NRO_ENDERECO.Length == 0)
						mensagem = mensagem + "\nNRO não preenchido";
					if (parceiro.NOM_BAIRRO.Length == 0)
						mensagem = mensagem + "\nBAIRRO não preenchido";
					if (parceiro.NOM_CIDADE.Length == 0)
						mensagem = mensagem + "\nCIDADE não preenchido";
					if (parceiro.COD_ESTADO.Length == 0)
						mensagem = mensagem + "\nESTADO não preenchido";
					if (parceiro.NRO_CEP.Length == 0)
						mensagem = mensagem + "\nCEP não preenchido";
				}
				else 
				{
					if (parceiro.NRO_ENDERECO_ENTREGA.Length == 0)
						mensagem = mensagem + "\nNRO não preenchido";
					if (parceiro.NOM_BAIRRO_ENTREGA.Length == 0)
						mensagem = mensagem + "\nBAIRRO não preenchido";
					if (parceiro.NOM_CIDADE_ENTREGA.Length == 0)
						mensagem = mensagem + "\nCIDADE não preenchida";
					if (parceiro.COD_ESTADO_ENTREGA.Length == 0)
						mensagem = mensagem + "\nESTADO não preenchido";
					if (parceiro.NRO_CEP_ENTREGA.Length == 0)
						mensagem = mensagem + "\nCEP não preenchido";
				}
			                                                        
				if ((parceiro.NRO_FONE1.Length == 0) &&
				    (parceiro.NRO_CELULAR.Length == 0))
					mensagem = mensagem + "\nFONE não preenchido";
				
				if (mensagem.Length == 0) break;
				DialogResult r = MessageBox.Show(mensagem, "Atualizar cadastro?", 
			                                 	MessageBoxButtons.YesNo, 
			                                 	MessageBoxIcon.Question);
				if (r == DialogResult.No) break;
				
				cControleAcesso acesso = new cControleAcesso();
				frmCadParceiros frmCad = new frmCadParceiros(true);
				frmCad.where = "where COD_PARCEIRO='" + cliente + "'";
				frmCad.ReadOnly = !acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fCadParceiros");
				frmCad.ShowDialog();
			}
			if (mensagem.Length != 0) return;
			
			cOrcamentos orc = new cOrcamentos();
			ArrayList itens = orc.VerificaEspecificos(fornecedor, data, orcamento);
			if (itens.Count > 0)
			{
				mensagem = "Itens sem código específico:";
				foreach (string item in itens)
				{
					mensagem = mensagem + "\n" + item;
				}
				MessageBox.Show(mensagem, "Erro na consistência");
				return;
			}

			
			string msg="";
			cPedidos pedidos = new cPedidos();
			string cod_condicao=cbxCondicoesPagto.Text.Trim();
			if (cod_condicao.Length > 10)
			{
				cod_condicao = cbxCondicoesPagto.Text.Substring(0,10).Trim();
			}
			int nro_pedido=0;
			string idt_frete = rbtCliente.Checked ? "C" : "F";
			if (dif > 0)
			{
				result = pedidos.Inclui(fornecedor, data, orcamento, 1, vlr_itens-dif, Globais.sUsuario, DateTime.Now, 
				                        dtpEntrega.Value, dtpEntrega.Checked ? "S" : "N",
				                        dtpMontagem.Value, dtpMontagem.Checked ? "S" : "N",
				                        cod_condicao, edtTransportadora.Text, "", idt_frete,
				                        ref nro_pedido, ref msg);
			}
			else
			{
				result = pedidos.Inclui(fornecedor, data, orcamento, 1, vlr_itens-vlr_desconto, Globais.sUsuario, DateTime.Now,
				                        dtpEntrega.Value, dtpEntrega.Checked ? "S" : "N",
				                        dtpMontagem.Value, dtpMontagem.Checked ? "S" : "N",
				                        cod_condicao, edtTransportadora.Text, "", idt_frete,
				                        ref nro_pedido, ref msg);
			}
			if (!result)
			{
				MessageBox.Show("Pedido\n"+msg, "Erro na geração do pedido", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			
			if (dif > 0)
			{
				// se as fórmulas forem diferentes gera pedido de serviços para SOFTPLACE
				pedidos.Inclui(fornecedor, data, orcamento, 2, dif-vlr_desconto, Globais.sUsuario, DateTime.Now,
				               dtpEntrega.Value, dtpEntrega.Checked ? "S" : "N",
				               dtpMontagem.Value, dtpMontagem.Checked ? "S" : "N",
				               cod_condicao, edtTransportadora.Text, servico, idt_frete,
				               ref nro_pedido, ref msg);
				
				if (!result)
				{
					MessageBox.Show("Serviços\n"+msg, "Erro na geração do pedido", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				MessageBox.Show("Pedidos gerados com sucesso");
			}
			else MessageBox.Show("Pedido gerado com sucesso");
			Close();
		}
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			result = false;
			Close();
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
		
		void FGeraPedidoLoad(object sender, EventArgs e)
		{
			dtpEntrega.Checked = false;
			dtpMontagem.Checked = false;
		}
	}
}
