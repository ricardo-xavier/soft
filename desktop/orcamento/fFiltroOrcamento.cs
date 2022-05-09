/*
 * Projeto  : SoftPlace
 * Sistema  : CPD
 * Programa : fFiltroOrcamento - Filtro de Orcamento
 * Autor    : Ricardo Costa Xavier
 * Data     : 03/06/08
 * 
 * 14/10/15 - grid com check para situações
 */
using System;
using System.Windows.Forms;
using templates;
using classes;
using basico;
using System.Collections.Generic;

namespace orcamento
{
	public partial class frmFiltroOrcamento : tConsulta
	{
		public string fornecedor;
		public bool filtrar_data;
		public int mesi;
		public int anoi;
		public int mesf;
		public int anof;
		public string vendedor;
		public string cliente;
		public string consultor;
		public string caracteristica;
		public List<string> situacoes;
		public bool result;
		public string idt_cadastroI;
		public DateTime cadastroI;
		public string idt_cadastroF;
		public DateTime cadastroF;		
		private string vendedorAcao;
		private string situacaoAcao;
		public string resumo;
		
		public frmFiltroOrcamento(bool acao, string vendedorAcao, string situacaoAcao)
		{
			InitializeComponent();
			if (acao) {
				edtCliente.Enabled = false;
				btnCliente.Enabled = false;
			}
			edtCodigo.CharacterCasing = CharacterCasing.Upper;			
			idt_cadastroI = "N";
			cadastroI = DateTime.Now;
			idt_cadastroF = "N";
			cadastroF = DateTime.Now;	
			situacoes = new List<string>();		
			
			this.vendedorAcao = vendedorAcao;
			this.situacaoAcao = situacaoAcao;

			cSituacoes sit = new cSituacoes();
			sit.CarregaFiltro(dgvSituacoes);
		}
		
		void InicializaValores()
		{
			edtCodigo.Text = fornecedor;
			ckbData.Checked = filtrar_data;
			udMesI.Value = mesi;
			udMesF.Value = mesf;
			edtAnoI.Text = anoi.ToString();
			edtAnoF.Text = anof.ToString();
			cbxUsuarios.Text = vendedor;
			if (vendedorAcao != null) {
				cbxUsuarios.Text = vendedorAcao;
			}
			edtCliente.Text = cliente;
			edtConsultor.Text = consultor;
			cCaracteristicas caracteristicas = new cCaracteristicas();
			this.Cursor = Cursors.WaitCursor;
			cbxCaracteristicas.Items.Clear();
			caracteristicas.Carrega(cbxCaracteristicas, fornecedor);
			this.Cursor = Cursors.Default;
			cbxCaracteristicas.Text = caracteristica;
			dtpCadastroI.Value = cadastroI;
			dtpCadastroI.Checked = idt_cadastroI == "S";			
			dtpCadastroF.Value = cadastroF;
			dtpCadastroF.Checked = idt_cadastroF == "S";		
			edtResumo.Text = resumo;
		}
		
		void BtnLimpaClick(object sender, EventArgs e)
		{
			edtCodigo.Text = "";
			ckbData.Checked = false;
			udMesI.Value = DateTime.Today.Month;
			udMesF.Value = DateTime.Today.Month;
			edtAnoI.Text = DateTime.Today.Year.ToString();
			edtAnoF.Text = DateTime.Today.Year.ToString();
			if (vendedorAcao == null)
			{
				if (Globais.bAdministrador)
					cbxUsuarios.Text = "";
				else
					cbxUsuarios.Text = Globais.sUsuario;
			} else {
				cbxUsuarios.Text = vendedorAcao;
			}
			if (edtCliente.Enabled) {
				edtCliente.Text = "";
			}
			edtConsultor.Text = "";
			cbxCaracteristicas.Items.Clear();
			cbxCaracteristicas.Text = "";
			if (!dgvSituacoes.ReadOnly)
			{
				foreach (DataGridViewRow row in dgvSituacoes.Rows)
				{
					row.Cells["Seleciona"].Value = false;
				}
			}
			dtpCadastroI.Checked = false;			
			dtpCadastroF.Checked = false;				
			edtResumo.Text = "";
		}
		
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			situacoes.Clear();
			foreach (DataGridViewRow row in dgvSituacoes.Rows)
			{
				if (!(bool) row.Cells["Seleciona"].Value)
				{
					continue;
				}
				situacoes.Add(row.Cells["Código"].Value.ToString());
			}
			
			fornecedor = edtCodigo.Text;
			filtrar_data = ckbData.Checked;
			mesi = (int)udMesI.Value;
			mesf = (int)udMesF.Value;
			anoi = Globais.StrToInt(edtAnoI.Text);
			anof = Globais.StrToInt(edtAnoF.Text);
			vendedor = cbxUsuarios.Text;
			cliente = edtCliente.Text;
			consultor = edtConsultor.Text;
			caracteristica = cbxCaracteristicas.Text;
			result = true;
			idt_cadastroI = dtpCadastroI.Checked ? "S" : "N";
			cadastroI = dtpCadastroI.Value;			
			idt_cadastroF = dtpCadastroF.Checked ? "S" : "N";
			cadastroF = dtpCadastroF.Value;				
			resumo = edtResumo.Text;
			Close();
		}
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			result = false;
			Close();
		}
		
		void UdMesValueChanged(object sender, EventArgs e)
		{
			int ano;
			if (udMesI.Value == 13)
			{
				udMesI.Value = 1;
				ano = Globais.StrToInt(edtAnoI.Text) + 1;
				edtAnoI.Text = ano.ToString();
			}
			if (udMesI.Value == 0)
			{
				udMesI.Value = 12;
				ano = Globais.StrToInt(edtAnoI.Text) - 1;
				if (ano < 0) ano = 0;
				edtAnoI.Text = ano.ToString();
			}
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
			//string nome = dgvSituacoes.Columns[5].Name;
			dgvSituacoes.Columns["Código"].Visible = false;
			//DataGridViewColumn col = dgvSituacoes.Columns["Seleciona"];
			//dgvSituacoes.Columns["Seleciona"].Width = 64;			
			
			if (cbxUsuarios.Items.Count == 0) {
				if (vendedorAcao == null) {
					cUsuarios usuarios = new cUsuarios();
					this.Cursor = Cursors.WaitCursor;
					usuarios.Carrega(cbxUsuarios);
					this.Cursor = Cursors.Default;
				} else {
					cbxUsuarios.Items.Add(vendedorAcao);
				}
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
			frmCad.where = "where IDT_CONSULTOR='S'";
			frmCad.codigo = edtConsultor.Text;
			frmCad.ReadOnly = !acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fCadParceiros");
			frmCad.ShowDialog();
			if (frmCad.result)
				edtConsultor.Text = frmCad.edtCodigo.Text;
		}
		
		void EdtCodigoTextChanged(object sender, EventArgs e)
		{
			cCaracteristicas caracteristicas = new cCaracteristicas();
			this.Cursor = Cursors.WaitCursor;
			cbxCaracteristicas.Items.Clear();
			caracteristicas.Carrega(cbxCaracteristicas, edtCodigo.Text);
			this.Cursor = Cursors.Default;
		}
		
		void UdMesFValueChanged(object sender, EventArgs e)
		{
			int ano;
			if (udMesF.Value == 13)
			{
				udMesF.Value = 1;
				ano = Globais.StrToInt(edtAnoF.Text) + 1;
				edtAnoF.Text = ano.ToString();
			}
			if (udMesF.Value == 0)
			{
				udMesF.Value = 12;
				ano = Globais.StrToInt(edtAnoF.Text) - 1;
				if (ano < 0) ano = 0;
				edtAnoF.Text = ano.ToString();
			}
		}
		
		void ChkTodasCheckedChanged(object sender, EventArgs e)
		{
			situacoes.Clear();
			foreach (DataGridViewRow row in dgvSituacoes.Rows)
			{
				row.Cells["Seleciona"].Value = chkTodas.Checked;
				if (!chkTodas.Checked)
				{
					situacoes.Add(row.Cells["Código"].Value.ToString());
				}
			}			
		}
	}
}
