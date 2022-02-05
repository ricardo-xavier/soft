
/*
 * Projeto  : SoftPlace
 * Sistema  : Cadastros Basicos
 * Programa : MainForm - Form Principal
 * Autor    : Ricardo Costa Xavier
 * Data     : 05/04/08
 * 
 * v1.5.3 02/05/14 - Ricardo - máscara de celular para 9 dígitos
 * v2.2.0 16/09/20 - Ricardo - parâmetros para envio de email pelo app
 */
using System;
using System.Windows.Forms;
using templates;
using classes;

namespace basico
{
	public partial class MainForm : tMenu
	{
		private cControleAcesso acesso;
		private bool bShow;
		
		[STAThread]
		public static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm(args));
		}
		
		bool VerificaAcesso(string programa)
		{
			if (!acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, programa))
			{
				MessageBox.Show("Usuário sem permissão para esse Programa", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}			
			return true;
		}
		
		public MainForm(string[] args)
		{
			InitializeComponent();
			admin = false;
			if (args.Length > 0) 
			{
				login = false;
				Globais.sUsuario = args[0];
				Globais.sFilial = args[1];
				Globais.bAdministrador = args[2][0] == 'S';
			}
			else login = true;
			acesso = new cControleAcesso();
			toolTip1.SetToolTip(btnConsultaClientes, "Consulta");
			toolTip1.SetToolTip(btnConsultaFornecedores, "Consulta");
			toolTip1.SetToolTip(btnConsultaConsultores, "Consulta");
			bShow = true;
		}
		
		public void Conta()
		{
			cParceiros parceiros = new cParceiros();
			edtClientes.Text = parceiros.NumClientes().ToString();
			edtFornecedores.Text = parceiros.NumFornecedores().ToString();
			edtConsultores.Text = parceiros.NumConsultores().ToString();
		}
		
		void MainFormShown(object sender, EventArgs e)
		{
			if (!bShow) return;
			if (!Globais.bAdministrador &&  !acesso.PermissaoSistema(Globais.sUsuario, Globais.sFilial, 2))
			{
				MessageBox.Show("Usuário sem permissão para esse Sistema", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Close();
			}
			Conta();
			bShow = false;
		}
		
		void MniSairClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void MniSobreClick(object sender, EventArgs e)
		{
			frmSobre frm = new frmSobre();
			frm.ShowDialog();
		}
		
		void MniCadEstadosClick(object sender, EventArgs e)
		{
			if (VerificaAcesso("fCadEstados"))
			{
				frmCadEstados frm = new frmCadEstados();
				frm.ShowDialog();
			}
		}
		
		void MniCadCargosClick(object sender, EventArgs e)
		{
			if (VerificaAcesso("fCadCargos"))
			{
				frmCadCargos frm = new frmCadCargos();
				frm.ShowDialog();
			}
		}
		
		void MniCadOrigensClick(object sender, EventArgs e)
		{
			if (VerificaAcesso("fCadOrigens"))
			{
				frmCadOrigens frm = new frmCadOrigens(false);
				frm.ShowDialog();
			}
		}		
		
		void MniCadProdutosAcaoClick(object sender, EventArgs e)
		{
			if (VerificaAcesso("fCadProdutosAcao"))
			{
				frmCadProdutosAcao frm = new frmCadProdutosAcao(false);
				frm.ShowDialog();
			}
		}				
		
		void MniFuncionariosClick(object sender, EventArgs e)
		{
			if (VerificaAcesso("fCadFuncionarios"))
			{
				frmCadFuncionarios frm = new frmCadFuncionarios(false);
				frm.ShowDialog();
			}
		}
		
		void MniParceirosClick(object sender, EventArgs e)
		{
			if (VerificaAcesso("fCadParceiros"))
			{
				frmCadParceiros frm = new frmCadParceiros(false);
				frm.ShowDialog();
				Conta();				
			}
		}
		
		void BtnConsultaClientesClick(object sender, EventArgs e)
		{
			if (VerificaAcesso("fCadParceiros"))
			{
				frmCadParceiros frm = new frmCadParceiros(false);
				frm.bClientes = true;
				frm.ShowDialog();
				Conta();
			}
		}
		
		void BtnConsultaFornecedoresClick(object sender, EventArgs e)
		{
			if (VerificaAcesso("fCadParceiros"))
			{
				frmCadParceiros frm = new frmCadParceiros(false);
				frm.bFornecedores = true;
				frm.ShowDialog();
			}
		}
		
		void BtnConsultaConsultoresClick(object sender, EventArgs e)
		{
			if (VerificaAcesso("fCadParceiros"))
			{
				frmCadParceiros frm = new frmCadParceiros(false);
				frm.bConsultores = true;
				frm.ShowDialog();
				Conta();				
			}
		}
		
		void MniConParceirosClick(object sender, EventArgs e)
		{
			if (VerificaAcesso("fCadParceiros"))
			{
				frmConParceiros frm = new frmConParceiros();
				frm.ShowDialog();
				if (frm.cancela) return;
				
				frmCadParceiros frmCad = new frmCadParceiros(false);
				frmCad.where = frm.filtro;
				frmCad.ReadOnly = true;
				frmCad.ShowDialog();
			}
		}
		
		void MniProdutosClick(object sender, EventArgs e)
		{
			if (VerificaAcesso("fCadProdutos"))
			{
				frmCadProdutos frm = new frmCadProdutos(false);
				frm.ShowDialog();
			}
		}
		
		void MniTabelasPrecosClick(object sender, EventArgs e)
		{
			if (VerificaAcesso("fCadTabelas"))
			{
				frmCadTabelas frm = new frmCadTabelas();
				frm.ShowDialog();
			}
		}
		
		void MniNaturezasClick(object sender, EventArgs e)
		{
			if (VerificaAcesso("fCadNaturezas"))
			{
				frmCadNaturezas frm = new frmCadNaturezas();
				frm.ShowDialog();
			}
		}
				
		void MniEmailClick(object sender, EventArgs e)
		{
			if (VerificaAcesso("fCadEmail"))
			{
				fCadEmail frm = new fCadEmail();
				frm.ShowDialog();
			}
		}

		void MniCaracteristicasClick(object sender, EventArgs e)
		{
		}
		
		void MniCondicoesClick(object sender, EventArgs e)
		{
		}
		
		void SituaçõesDoOrçamentoToolStripMenuItemClick(object sender, EventArgs e)
		{
		}
		
		void TermosDeGarantiaToolStripMenuItemClick(object sender, EventArgs e)
		{
		}
		
		void TermoDeGarantiaToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (VerificaAcesso("fTermosGarantia"))			
			{
				fTermosGarantia frm = new fTermosGarantia();
				frm.ShowDialog();
			}						
		}
		
		void IntroduçãoToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (VerificaAcesso("fIntroducoes"))			
			{
				fIntroducoes frm = new fIntroducoes();
				frm.ShowDialog();
			}
		}
		
		void InformaçõesDeFornecimentoToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (VerificaAcesso("fInformacoesFornec"))			
			{
				fInformacoesFornecimento frm = new fInformacoesFornecimento();
				frm.ShowDialog();
			}			
		}
		
		void CondiçõesParaMontagemToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (VerificaAcesso("fCondicoesMontagem"))			
			{
				fCondicoesMontagem frm = new fCondicoesMontagem();
				frm.ShowDialog();
			}			
		}
		
		void TermoDeAprovaçãoToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (VerificaAcesso("fTermosAprovacao"))			
			{
				fTermosAprovacao frm = new fTermosAprovacao();
				frm.ShowDialog();
			}									
		}

		/*
		void Button1Click(object sender, EventArgs e)
		{
			cProdutos c = new cProdutos();
			c.CarregaAlterados(grid);
		}
		
		void GridRowEnter(object sender, DataGridViewCellEventArgs e)
		{
			int i=e.RowIndex;
			edt1.Text = grid.Rows[i].Cells["Nome"].Value.ToString().Trim();			
			edt2.Text = grid.Rows[i].Cells["edt2"].Value.ToString().Trim();			
			edt3.Text = grid.Rows[i].Cells["edt3"].Value.ToString().Trim();			
			edt4.Text = grid.Rows[i].Cells["edt4"].Value.ToString().Trim();			
			edt5.Text = grid.Rows[i].Cells["edt5"].Value.ToString().Trim();			
			edt6.Text = grid.Rows[i].Cells["edt6"].Value.ToString().Trim();			
			if (edt1.Text.Equals(edt2.Text)) {
				edt1.Text = "";
				edt2.Text = "";
			}
			if (edt3.Text.Equals(edt4.Text)) {
				edt3.Text = "";
				edt4.Text = "";
			}
			if (edt5.Text.Equals(edt6.Text)) {
				edt5.Text = "";
				edt6.Text = "";
			}			
		}
		*/
		/*
		void MniImportarXMLTecnoflexClick(object sender, EventArgs e)
		{
			fImportarXMLTecnoflex frm = new fImportarXMLTecnoflex();
			frm.ShowDialog();			
		}
		*/
		
		void MainFormLoad(object sender, EventArgs e)
		{
		}
		
		void MniOrigensClick(object sender, EventArgs e)
		{
			if (VerificaAcesso("fCadOrigens"))
			{
				frmCadOrigens frm = new frmCadOrigens(false);
				frm.ShowDialog();
			}			
		}
		
		void MniProdutosAcaoClick(object sender, EventArgs e)
		{
			if (VerificaAcesso("fCadProdutosAcao"))
			{
				frmCadProdutosAcao frm = new frmCadProdutosAcao(false);
				frm.ShowDialog();
			}			
		}
		
		void MniSituacoesAcaoClick(object sender, EventArgs e)
		{
			if (VerificaAcesso("fCadSituacoesAcao"))
			{
				frmCadSituacoesAcao frm = new frmCadSituacoesAcao();
				frm.ShowDialog();
			}						
		}
		
		void MniCaracteristicasVendaClick(object sender, EventArgs e)
		{
			if (VerificaAcesso("fCadCaracteristicas"))
			{
				frmCadCaracteristicas frm = new frmCadCaracteristicas();
				frm.ShowDialog();
			}			
		}
		
		void MniCondicoesPagamentoClick(object sender, EventArgs e)
		{
			if (VerificaAcesso("fCadCondicoes"))			
			{
				frmCadCondicoes frm = new frmCadCondicoes();
				frm.ShowDialog();
			}			
		}
		
		void MniSituacoesOrcamentoClick(object sender, EventArgs e)
		{
			if (VerificaAcesso("fCadSituacoes"))			
			{
				frmCadSituacoes frm = new frmCadSituacoes();
				frm.ShowDialog();
			}			
		}
	}
}
