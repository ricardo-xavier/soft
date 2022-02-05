using System;
using System.Windows.Forms;
using templates;
using classes;
using basico;
using System.Collections.Generic;

namespace acao
{
	public partial class Filtro : tConsulta
	{
		public bool result;
		public string cliente;
		public string consultor;
		public string origem;
		public string vendedor;
		public List<string> situacoes;
		public string idt_previsaoI;
		public DateTime previsaoI;
		public string idt_previsaoF;
		public DateTime previsaoF;		
		
		public Filtro()
		{
			InitializeComponent();
			cbxVendedores.Text = Globais.sUsuario;
			situacoes = new List<string>();
		}
		
		void FiltroLoad(object sender, EventArgs e)
		{
			cUsuarios usuarios = new cUsuarios();
			this.Cursor = Cursors.WaitCursor;
			AcaoDAO.CarregaVendedores(cbxVendedores);
			this.Cursor = Cursors.Default;
			cbxVendedores.Text = Globais.bAdministrador ? "" : Globais.sUsuario;			
			edtDescricao.Width = edtCodigo.Width;
			
			cSituacoesAcao sit = new cSituacoesAcao();
			sit.CarregaFiltro(dgvSituacoes, false);
			foreach (DataGridViewRow row in dgvSituacoes.Rows)
			{				
				row.Cells["Seleciona"].Value = 
					situacoes.Contains(row.Cells["Código"].Value.ToString());
			}
			
			dtpPrevisaoI.Checked = (idt_previsaoI != null) && idt_previsaoI.Equals("S");
			dtpPrevisaoF.Checked = (idt_previsaoF != null) && idt_previsaoF.Equals("S");
		}
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			result = false;
			Close();
		}
		
		void BtnLimpaClick(object sender, EventArgs e)
		{
			edtCodigo.Text = "";
			edtDescricao.Text = "";
			edtOrigem.Text = "";
			cbxVendedores.Text = Globais.bAdministrador ? "" : Globais.sUsuario;
			dtpPrevisaoI.Checked = false;
			dtpPrevisaoF.Checked = false;
			foreach (DataGridViewRow row in dgvSituacoes.Rows)
			{
				row.Cells["Seleciona"].Value = false;
			}
			chkTodas.Checked = false;
		}
		
		void BtnClienteClick(object sender, EventArgs e)
		{
			cControleAcesso acesso = new cControleAcesso();
			frmCadParceiros frmCad = new frmCadParceiros(true);
			frmCad.where = "";
			frmCad.bClientes = true;
			frmCad.bConsultores = true;
			frmCad.bFornecedores = true;
			frmCad.codigo = edtCodigo.Text;
			frmCad.ReadOnly = !acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fCadParceiros");
			frmCad.ShowDialog();
			if (frmCad.result)
			{
				edtCodigo.Text = frmCad.edtCodigo.Text;
			}
		}
		
		void BtnConsultorClick(object sender, EventArgs e)
		{
			cControleAcesso acesso = new cControleAcesso();
			frmCadParceiros frmCad = new frmCadParceiros(true);
			frmCad.where = "";
			frmCad.bConsultores = true;
			frmCad.codigo = edtDescricao.Text;
			frmCad.ReadOnly = !acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fCadParceiros");
			frmCad.ShowDialog();
			if (frmCad.result)
			{
				edtDescricao.Text = frmCad.edtCodigo.Text;
			}			
		}
		
		void BtnOrigemClick(object sender, EventArgs e)
		{
			cControleAcesso acesso = new cControleAcesso();
			frmCadOrigens frmCad = new frmCadOrigens(true);
			frmCad.ShowDialog();
			if (frmCad.result)
			{
				edtOrigem.Text = frmCad.edtCodigo.Text;
			}			
		}
		
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			cliente = edtCodigo.Text;
			consultor = edtDescricao.Text;
			origem = edtOrigem.Text;;
			vendedor = cbxVendedores.Text;
			situacoes.Clear();
			foreach (DataGridViewRow row in dgvSituacoes.Rows)
			{
				if (!(bool) row.Cells["Seleciona"].Value)
				{
					continue;
				}
				situacoes.Add(row.Cells["Código"].Value.ToString());
			}
			idt_previsaoI = dtpPrevisaoI.Checked ? "S" : "N";
			previsaoI = dtpPrevisaoI.Value;			
			idt_previsaoF = dtpPrevisaoF.Checked ? "S" : "N";
			previsaoF = dtpPrevisaoF.Value;
			result = true;
			Close();
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
