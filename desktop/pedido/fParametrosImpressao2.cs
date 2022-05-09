/*
 * Seleciona parâmetros para impressão do pedido
 * Autor: Ricardo Costa Xavier
 * Histórico:
 * 09/09/09 - versão inicial
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace pedido
{
	public partial class fParametrosImpressao2 : Form
	{
		public bool result;
		public bool listagem;
		public bool fabrica;		
		public bool consolidado;
		public bool mostrar_valores;
		public bool mostrar_subcodigo;
		public bool por_item;
		public bool por_pedido;
		public bool por_cliente;
		public bool por_fabrica;		
		public string observacao_fabrica;
		public bool quebrar_caracteristica;
		public bool detalhes;
		public string titulo;
		
		public fParametrosImpressao2()
		{
			InitializeComponent();
			result = false;						
		}
		
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			result = true;
			listagem = rbtListagem.Checked;
			fabrica = rbtFabrica.Checked;
			consolidado = chkConsolidado.Checked;
			mostrar_valores = chkMostrarValores.Checked;
			mostrar_subcodigo = chkMostrarSubCodigo.Checked;
			por_item = chkPorItem.Checked;
			por_pedido = chkPorPedido.Checked;
			por_cliente= chkPorCliente.Checked;
			por_fabrica = chkPorFabrica.Checked;
			observacao_fabrica = edtObservacao.Text;
			quebrar_caracteristica = chkQuebraCaracteristica.Checked;
			detalhes = chkDetalhes.Checked;
			titulo = edtTitulo.Text;
			Close();			
		}
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			Close();
		}
				
		void RbtPedidoCheckedChanged(object sender, EventArgs e)
		{
			if (rbtFabrica.Checked)
			{
				chkConsolidado.Checked = false;
				rbtListagem.Checked = false;
				rbtFabrica.Checked = false;
			}						
		}		
		
		void RbtListagemCheckedChanged(object sender, EventArgs e)
		{
			if (rbtListagem.Checked)
			{
				chkConsolidado.Checked = false;
				rbtPedido.Checked = false;
				rbtFabrica.Checked = false;				
			}			
		}
		
		void RbtFabricaCheckedChanged(object sender, EventArgs e)
		{
			if (rbtFabrica.Checked)
			{
				chkConsolidado.Checked = false;
				rbtPedido.Checked = false;
				rbtListagem.Checked = false;
			}			
		}
		
		void ChkConsolidadoCheckedChanged(object sender, EventArgs e)
		{
			if (!rbtPedido.Checked) 
			{
				chkConsolidado.Checked = false;			
			}
		}
	}
}
