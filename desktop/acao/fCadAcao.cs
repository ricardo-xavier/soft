using System;
using System.Windows.Forms;
using classes;
using basico;

/*
 * 04/05/2017 - nao estava gravando os concorrentes
 */ 

namespace acao
{
	public partial class fCadAcao : Form
	{
		private int seq;
		private bool alteracao;
		private AcaoComercial acao;
		
		public int Seq
		{
			get { return seq; }
			set { seq = value; }
		}
		
		public bool Alteracao
		{
			get { return alteracao; }
			set { alteracao = value; }
		}
		
		public AcaoComercial Acao
		{
			get { return acao; }
			set { acao = value; }
		}
		
		public fCadAcao()
		{
			InitializeComponent();
		}
		
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			AcaoComercial acao = new AcaoComercial();			
			acao.CodCliente = edtCliente.Text.Trim();
			acao.DesObra = edtObra.Text.Trim();
			acao.DatPrevisao = dtpPrevisao.Value;
			acao.CodVendedor = cbxVendedor.Text.Trim();
			acao.CodConsultor = edtConsultor.Text.Trim();
			acao.CodOrigem = edtOrigem.Text.Trim();
			string[] partesSituacao = cbxSituacao.Text.Trim().Split(' ');
			acao.IdtSituacao = 
				(partesSituacao.Length > 1)
				? partesSituacao[0].Trim()
				: cbxSituacao.Text.Trim();			
			acao.TxtObservacao = edtObservacao.Text.Trim();
			acao.TxtConcorrentes = edtConcorrentes.Text.Trim();
			
			if (acao.IdtSituacao.Equals(""))
			{
				MessageBox.Show("Selecione uma situação", "Campo obrigatório",
			                	MessageBoxButtons.OK, 
			                	MessageBoxIcon.Warning);
				cbxSituacao.Focus();
				return;				
			}

			if (acao.CodOrigem.Equals(""))
			{
				MessageBox.Show("Selecione uma origem", "Campo obrigatório",
			                	MessageBoxButtons.OK, 
			                	MessageBoxIcon.Warning);
				edtOrigem.Focus();
				return;				
			}
			
			
			this.Cursor = Cursors.WaitCursor;
			try
			{
				if (!Alteracao)
				{
					
					int outraAcao = AcaoDAO.AcaoCliente(edtCliente.Text.Trim());
					if (outraAcao != 0) 
					{
						MessageBox.Show("Já existe outra ação para esse cliente\r\n" + outraAcao, "Aviso",  
				    	            MessageBoxButtons.OK, 
				    	            MessageBoxIcon.Warning);		
					}
					
					acao.SeqAcao = 0;
					AcaoDAO.Inclui(acao);
				}
				else
				{
					acao.SeqAcao = int.Parse(edtSequencia.Text.Trim());
					AcaoDAO.Altera(acao);
				}
			}
			catch (Exception ex)
			{
				Log.Grava(Globais.sUsuario, "erro:" + ex.Message);
				throw ex;
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
			seq = acao.SeqAcao;
			Close();
		}
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void BtnClienteClick(object sender, EventArgs e)
		{
			cControleAcesso acesso = new cControleAcesso();
			frmCadParceiros frmCad = new frmCadParceiros(true);
			frmCad.where = "";
			frmCad.bClientes = true;
			frmCad.codigo = edtCliente.Text;
			frmCad.ReadOnly = !acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fCadParceiros");
			frmCad.ShowDialog();
			if (frmCad.result)
			{
				edtCliente.Text = frmCad.edtCodigo.Text;
			}
		}
				
		void BtnConsultorClick(object sender, EventArgs e)
		{
			cControleAcesso acesso = new cControleAcesso();
			frmCadParceiros frmCad = new frmCadParceiros(true);
			frmCad.where = "";
			frmCad.bConsultores = true;
			frmCad.codigo = edtConsultor.Text;
			frmCad.ReadOnly = !acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fCadParceiros");
			frmCad.ShowDialog();
			if (frmCad.result)
			{
				edtConsultor.Text = frmCad.edtCodigo.Text;
			}
		}
		
		void FCadAcaoLoad(object sender, EventArgs e)
		{
			cUsuarios usuarios = new cUsuarios();
			this.Cursor = Cursors.WaitCursor;
			usuarios.Carrega(cbxVendedor);
			this.Cursor = Cursors.Default;
			cbxVendedor.Text = Globais.sUsuario;
			cSituacoesAcao situacoes = new cSituacoesAcao();
			situacoes.Carrega(cbxSituacao);
			
			btnGrupo.Visible = Alteracao;
			if (Alteracao)
			{
				edtSequencia.Text = acao.SeqAcao.ToString();
				edtCliente.Text = acao.CodCliente.Trim();
				edtObra.Text = acao.DesObra.Trim();
				dtpPrevisao.Value = acao.DatPrevisao;
				cbxVendedor.Text = acao.CodVendedor.Trim();
				edtConsultor.Text = acao.CodConsultor.Trim();
				edtOrigem.Text = acao.CodOrigem.Trim();
				edtObservacao.Text = acao.TxtObservacao.Trim();
				cbxSituacao.Text = acao.IdtSituacao;
				edtConcorrentes.Text = acao.TxtConcorrentes.Trim();
				foreach (string situacao in cbxSituacao.Items)
				{
					if (situacao.StartsWith(acao.IdtSituacao.Trim() + " "))
					{
						cbxSituacao.Text = situacao;
						break;
					}
				}
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
		
		void Button1Click(object sender, EventArgs e)
		{
			fCadGrupo frmCad = new fCadGrupo(acao.SeqAcao);
			frmCad.ShowDialog();
		}	
	}
}
