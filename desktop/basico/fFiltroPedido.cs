/*
 * Projeto  : SoftPlace
 * Sistema  : Pedido
 * Programa : fFiltroPedido - Filtro de Pedido
 * Autor    : Ricardo Costa Xavier
 * Data     : 17/02/09
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using templates;
using classes;

namespace basico
{
	public partial class frmFiltroPedido : tConsulta
	{
		public string fornecedor;
		public string vendedor;
		public string idt_dataI;
		public DateTime dataI;
		public string idt_dataF;
		public DateTime dataF;		
		public string idt_ou_entrega;
		public string idt_nao_entregues;
		public short dias_nao_entregues;
		public string idt_entrega_previstaI;
		public DateTime entrega_previstaI;
		public string idt_entrega_previstaF;
		public DateTime entrega_previstaF;
		public string idt_entrega_realI;
		public DateTime entrega_realI;
		public string idt_entrega_realF;
		public DateTime entrega_realF;
		public string idt_ou_montagem;
		public string idt_nao_montados;
		public short dias_nao_montados;		
		public string idt_montagem_previstaI;
		public DateTime montagem_previstaI;
		public string idt_montagem_previstaF;
		public DateTime montagem_previstaF;
		public string idt_montagem_realI;
		public DateTime montagem_realI;
		public string idt_montagem_realF;
		public DateTime montagem_realF;
		public string idt_omitir_anos_anteriores;
		public string idt_sem_previsao;
		public string idt_pendentes_consultor;
		public string idt_pendentes_vendedor;
		public string cliente;
		public string consultor;
		public string pedido_fornec;
		public string nf_fornec;
		public string observacao;
		public bool result;
		public string idt_cadastroI;
		public DateTime cadastroI;
		public string idt_cadastroF;
		public DateTime cadastroF;
		public string vlr_inicial;
		public string vlr_final;
		public string numero_pedido;
		public string caracteristica;
		
		public frmFiltroPedido()
		{
			InitializeComponent();
			edtCodigo.CharacterCasing = CharacterCasing.Upper;			
			result = false;
			fornecedor = "";
			vendedor = "";
			idt_dataI = "N";
			dataI = DateTime.Now;			
			idt_dataF = "N";
			dataF = DateTime.Now;						
			idt_ou_entrega = "N";
			idt_nao_entregues = "N";
			dias_nao_entregues = 0;
			idt_entrega_previstaI = "N";
			entrega_previstaI = DateTime.Now;
			idt_entrega_previstaF = "N";
			entrega_previstaF = DateTime.Now;
			idt_entrega_realI = "N";
			entrega_realI = DateTime.Now;
			idt_entrega_realF = "N";
			entrega_realF = DateTime.Now;
			idt_ou_montagem = "N";
			idt_nao_montados = "N";
			dias_nao_montados = 0;
			idt_montagem_previstaI = "N";
			montagem_previstaI = DateTime.Now;
			idt_montagem_previstaF = "N";
			montagem_previstaF = DateTime.Now;
			idt_montagem_realI = "N";
			montagem_realI = DateTime.Now;
			idt_montagem_realF = "N";
			montagem_realF = DateTime.Now;
			idt_omitir_anos_anteriores = "S";
			idt_sem_previsao = "N";
			idt_pendentes_consultor = "N";
			idt_pendentes_vendedor = "N";
			cliente = "";
			consultor = "";			
			pedido_fornec = "0";
			nf_fornec = "0";
			observacao = "";
			idt_cadastroI = "N";
			cadastroI = DateTime.Now;
			idt_cadastroF = "N";
			cadastroF = DateTime.Now;
			vlr_inicial = "";
			vlr_final = "";
			numero_pedido = "";
		}
		
		void InicializaValores()
		{
			edtCodigo.Text = fornecedor;
			dtpDataI.Value = dataI;
			dtpDataI.Checked = idt_dataI == "S";			
			dtpDataF.Value = dataF;
			dtpDataF.Checked = idt_dataF == "S";						
			chkOuEntrega.Checked = idt_ou_entrega == "S";			
			chkNaoEntregues.Checked = idt_nao_entregues == "S";			
			edtNaoEntregues.Text = dias_nao_entregues.ToString();
			chkOuMontagem.Checked = idt_ou_montagem == "S";			
			chkNaoMontados.Checked = idt_nao_montados == "S";			
			edtNaoMontados.Text = dias_nao_montados.ToString();
			dtpEntregaPrevistaI.Value = entrega_previstaI;
			dtpEntregaPrevistaI.Checked = idt_entrega_previstaI == "S";			
			dtpEntregaPrevistaF.Value = entrega_previstaF;
			dtpEntregaPrevistaF.Checked = idt_entrega_previstaF == "S";			
			dtpEntregaRealI.Value = entrega_realI;
			dtpEntregaRealI.Checked = idt_entrega_realI == "S";			
			dtpEntregaRealF.Value = entrega_realF;
			dtpEntregaRealF.Checked = idt_entrega_realF == "S";			
			dtpMontagemPrevistaI.Value = montagem_previstaI;
			dtpMontagemPrevistaI.Checked = idt_montagem_previstaI == "S";			
			dtpMontagemPrevistaF.Value = montagem_previstaF;
			dtpMontagemPrevistaF.Checked = idt_montagem_previstaF == "S";			
			dtpMontagemRealI.Value = montagem_realI;
			dtpMontagemRealI.Checked = idt_montagem_realI == "S";			
			dtpMontagemRealF.Value = montagem_realF;
			dtpMontagemRealF.Checked = idt_montagem_realF == "S";			
			chkAnosAnteriores.Checked = idt_omitir_anos_anteriores == "S";
			chkSemPrevisao.Checked = idt_sem_previsao == "S";
			chkPendentesConsultor.Checked = idt_pendentes_consultor == "S";
			chkPendentesVendedor.Checked = idt_pendentes_vendedor == "S";
			cbxUsuarios.Text = vendedor;
			edtCliente.Text = cliente;
			edtConsultor.Text = consultor;
			edtPedidoFornec.Text = pedido_fornec;
			edtNFFornec.Text = nf_fornec;
			edtObservacao.Text = observacao;
			dtpCadastroI.Value = cadastroI;
			dtpCadastroI.Checked = idt_cadastroI == "S";			
			dtpCadastroF.Value = cadastroF;
			dtpCadastroF.Checked = idt_cadastroF == "S";
			edtVlrInicial.Text = vlr_inicial;
			edtVlrFinal.Text = vlr_final;
			edtPedido.Text = numero_pedido;
		}
		
		void BtnLimpaClick(object sender, EventArgs e)
		{
			edtCodigo.Text = "";
			dtpDataI.Checked = false;
			dtpDataF.Checked = false;
			chkOuEntrega.Checked = false;
			chkNaoEntregues.Checked = false;
			edtNaoEntregues.Text = "0";
			chkOuMontagem.Checked = false;
			chkNaoMontados.Checked = false;
			edtNaoMontados.Text = "0";			
			dtpEntregaPrevistaI.Checked = false;
			dtpEntregaPrevistaF.Checked = false;
			dtpEntregaRealI.Checked = false;
			dtpEntregaRealF.Checked = false;
			dtpMontagemPrevistaI.Checked = false;
			dtpMontagemPrevistaF.Checked = false;
			dtpMontagemRealI.Checked = false;
			dtpMontagemRealF.Checked = false;
			if (Globais.bAdministrador)
				cbxUsuarios.Text = "";
			else
				cbxUsuarios.Text = Globais.sUsuario;
			edtCliente.Text = "";
			edtConsultor.Text = "";
			edtPedidoFornec.Text = "";
			edtNFFornec.Text = "";
			edtObservacao.Text = "";
			dtpCadastroI.Checked = false;			
			dtpCadastroF.Checked = false;
			edtVlrInicial.Text = "";
			edtVlrFinal.Text = "";
			edtPedido.Text = "";
		}
		
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			fornecedor = edtCodigo.Text;
			idt_dataI = dtpDataI.Checked ? "S" : "N";
			dataI = dtpDataI.Value;
			idt_dataF = dtpDataF.Checked ? "S" : "N";
			dataF = dtpDataF.Value;			
			idt_ou_entrega = chkOuEntrega.Checked ? "S" : "N";
			idt_nao_entregues = chkNaoEntregues.Checked ? "S" : "N";
			dias_nao_entregues = Globais.StrToShort(edtNaoEntregues.Text);
			idt_ou_montagem = chkOuMontagem.Checked ? "S" : "N";
			idt_nao_montados = chkNaoMontados.Checked ? "S" : "N";
			dias_nao_montados = Globais.StrToShort(edtNaoMontados.Text);
			idt_entrega_previstaI = dtpEntregaPrevistaI.Checked ? "S" : "N";
			entrega_previstaI = dtpEntregaPrevistaI.Value;
			idt_entrega_previstaF = dtpEntregaPrevistaF.Checked ? "S" : "N";
			entrega_previstaF = dtpEntregaPrevistaF.Value;
			idt_entrega_realI = dtpEntregaRealI.Checked ? "S" : "N";
			entrega_realI = dtpEntregaRealI.Value;
			idt_entrega_realF = dtpEntregaRealF.Checked ? "S" : "N";
			entrega_realF = dtpEntregaRealF.Value;
			idt_montagem_previstaI = dtpMontagemPrevistaI.Checked ? "S" : "N";
			montagem_previstaI = dtpMontagemPrevistaI.Value;
			idt_montagem_previstaF = dtpMontagemPrevistaF.Checked ? "S" : "N";
			montagem_previstaF = dtpMontagemPrevistaF.Value;
			idt_montagem_realI = dtpMontagemRealI.Checked ? "S" : "N";
			montagem_realI = dtpMontagemRealI.Value;
			idt_montagem_realF = dtpMontagemRealF.Checked ? "S" : "N";
			idt_omitir_anos_anteriores = chkAnosAnteriores.Checked ? "S" : "N";
			idt_sem_previsao = chkSemPrevisao.Checked ? "S" : "N";
			idt_pendentes_consultor = chkPendentesConsultor.Checked ? "S" : "N";
			idt_pendentes_vendedor = chkPendentesVendedor.Checked ? "S" : "N";
			montagem_realF = dtpMontagemRealF.Value;
			vendedor = cbxUsuarios.Text;
			cliente = edtCliente.Text;
			consultor = edtConsultor.Text;
			pedido_fornec = edtPedidoFornec.Text;
			nf_fornec = edtNFFornec.Text;
			observacao = edtObservacao.Text;
			idt_cadastroI = dtpCadastroI.Checked ? "S" : "N";
			cadastroI = dtpCadastroI.Value;
			idt_cadastroF = dtpCadastroF.Checked ? "S" : "N";
			cadastroF = dtpCadastroF.Value;
			result = true;
			float valor = 0;
			float.TryParse(edtVlrInicial.Text, out valor);
			vlr_inicial = (valor != 0) ? valor.ToString() : "";
			float.TryParse(edtVlrFinal.Text, out valor);
			vlr_final = (valor != 0) ? valor.ToString() : "";
			numero_pedido = edtPedido.Text;
			caracteristica = cbxCaracteristicas.Text;
			Close();
		}
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			result = false;
			Close();
		}
		
		void BtnFornecedorClick(object sender, EventArgs e)
		{
			cControleAcesso acesso = new cControleAcesso();
			frmCadParceiros frmCad = new frmCadParceiros(true);
			frmCad.where = "where IDT_FORNECEDOR='S'";
			frmCad.codigo = edtCodigo.Text;
			frmCad.ReadOnly = !acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fCadParceiros");
			frmCad.ShowDialog();
			if (frmCad.result)
				edtCodigo.Text = frmCad.edtCodigo.Text;			
		}
		
		void FrmFiltroOrcamentoShown(object sender, EventArgs e)
		{
			InicializaValores();			
		}
		
		void FrmFiltroOrcamentoLoad(object sender, EventArgs e)
		{
			if (cbxUsuarios.Items.Count == 0)
			{
				cUsuarios usuarios = new cUsuarios();
				this.Cursor = Cursors.WaitCursor;
				usuarios.Carrega(cbxUsuarios);
				this.Cursor = Cursors.Default;
			}
		}
		
		void BtnClienteClick(object sender, EventArgs e)
		{
			cControleAcesso acesso = new cControleAcesso();
			frmCadParceiros frmCad = new frmCadParceiros(true);
			frmCad.where = "where IDT_CLIENTE='S'";
			frmCad.codigo = edtCliente.Text;
			frmCad.ReadOnly = !acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fCadParceiros");
			frmCad.ShowDialog();
			if (frmCad.result)
				edtCliente.Text = frmCad.edtCodigo.Text;			
		}
		
		void BtnConsultorClick(object sender, EventArgs e)
		{
			cControleAcesso acesso = new cControleAcesso();
			frmCadParceiros frmCad = new frmCadParceiros(true);
			frmCad.where = "where IDT_CONSULTOR='S'";
			frmCad.codigo = edtConsultor.Text;
			frmCad.ReadOnly = !acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fCadParceiros");
			frmCad.ShowDialog();
			if (frmCad.result)
				edtConsultor.Text = frmCad.edtCodigo.Text;			
		}
		
		void ChkOuEntregaCheckedChanged(object sender, EventArgs e)
		{
			if (chkOuEntrega.Checked)
			{
				dtpEntregaPrevistaI.Checked = true;
				dtpEntregaPrevistaF.Checked = true;
				dtpEntregaRealI.Checked = true;
				dtpEntregaRealF.Checked = true;
			}
		}
		
		void ChkOuMontagemCheckedChanged(object sender, EventArgs e)
		{
			if (chkOuMontagem.Checked)
			{
				dtpMontagemPrevistaI.Checked = true;
				dtpMontagemPrevistaF.Checked = true;
				dtpMontagemRealI.Checked = true;
				dtpMontagemRealF.Checked = true;
			}			
		}
		
		void EdtCodigoTextChanged(object sender, EventArgs e)
		{
			cbxCaracteristicas.Items.Clear();
			cCaracteristicas caracteristicas = new cCaracteristicas();
			this.Cursor = Cursors.WaitCursor;
			caracteristicas.Carrega(cbxCaracteristicas, edtCodigo.Text);
			this.Cursor = Cursors.Default;
			cbxCaracteristicas.Text = "";				
		}
	}
}
