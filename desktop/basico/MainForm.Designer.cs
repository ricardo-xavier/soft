/*
 * Usuário: Ricardo
 * Data: 05/04/2008
 * Hora: 17:41
 * 
 */
namespace basico
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.mnuBasico = new System.Windows.Forms.MenuStrip();
			this.mnuArquivo = new System.Windows.Forms.ToolStripMenuItem();
			this.mniSair = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuCadastro = new System.Windows.Forms.ToolStripMenuItem();
			this.mniCadEstados = new System.Windows.Forms.ToolStripMenuItem();
			this.mniCadCargos = new System.Windows.Forms.ToolStripMenuItem();
			this.mniFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
			this.mniParceiros = new System.Windows.Forms.ToolStripMenuItem();
			this.mniProdutos = new System.Windows.Forms.ToolStripMenuItem();
			this.mniTabelasPrecos = new System.Windows.Forms.ToolStripMenuItem();
			this.mniNaturezas = new System.Windows.Forms.ToolStripMenuItem();
			this.mniEmail = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuOrcamento = new System.Windows.Forms.ToolStripMenuItem();
			this.mniCaracteristicasVenda = new System.Windows.Forms.ToolStripMenuItem();
			this.mniCondicoesPagamento = new System.Windows.Forms.ToolStripMenuItem();
			this.mniSituacoesOrcamento = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuProposta = new System.Windows.Forms.ToolStripMenuItem();
			this.mniIntroducoes = new System.Windows.Forms.ToolStripMenuItem();
			this.mniInformacoesFornecimento = new System.Windows.Forms.ToolStripMenuItem();
			this.mniTermosGarantia = new System.Windows.Forms.ToolStripMenuItem();
			this.mniCondicoesMontagem = new System.Windows.Forms.ToolStripMenuItem();
			this.mniTermosAprovacao = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuAcao = new System.Windows.Forms.ToolStripMenuItem();
			this.mniOrigens = new System.Windows.Forms.ToolStripMenuItem();
			this.mniProdutosAcao = new System.Windows.Forms.ToolStripMenuItem();
			this.mniSituacoesAcao = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuAjuda = new System.Windows.Forms.ToolStripMenuItem();
			this.mniSobre = new System.Windows.Forms.ToolStripMenuItem();
			this.pnlResumo = new System.Windows.Forms.Panel();
			this.btnConsultaConsultores = new System.Windows.Forms.Button();
			this.btnConsultaFornecedores = new System.Windows.Forms.Button();
			this.btnConsultaClientes = new System.Windows.Forms.Button();
			this.edtConsultores = new System.Windows.Forms.TextBox();
			this.edtFornecedores = new System.Windows.Forms.TextBox();
			this.edtClientes = new System.Windows.Forms.TextBox();
			this.lblConsultores = new System.Windows.Forms.Label();
			this.lblFornecedores = new System.Windows.Forms.Label();
			this.lblClientes = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.imgSoftplace)).BeginInit();
			this.mnuBasico.SuspendLayout();
			this.pnlResumo.SuspendLayout();
			this.SuspendLayout();
			// 
			// mnuBasico
			// 
			this.mnuBasico.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.mnuArquivo,
									this.mnuCadastro,
									this.mnuOrcamento,
									this.mnuProposta,
									this.mnuAcao,
									this.mnuAjuda});
			this.mnuBasico.Location = new System.Drawing.Point(0, 0);
			this.mnuBasico.Name = "mnuBasico";
			this.mnuBasico.Size = new System.Drawing.Size(584, 24);
			this.mnuBasico.TabIndex = 3;
			this.mnuBasico.Text = "menuStrip1";
			// 
			// mnuArquivo
			// 
			this.mnuArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.mniSair});
			this.mnuArquivo.Name = "mnuArquivo";
			this.mnuArquivo.Size = new System.Drawing.Size(56, 20);
			this.mnuArquivo.Text = "&Arquivo";
			// 
			// mniSair
			// 
			this.mniSair.Name = "mniSair";
			this.mniSair.Size = new System.Drawing.Size(103, 22);
			this.mniSair.Text = "&Sair";
			this.mniSair.Click += new System.EventHandler(this.MniSairClick);
			// 
			// mnuCadastro
			// 
			this.mnuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.mniCadEstados,
									this.mniCadCargos,
									this.mniFuncionarios,
									this.mniParceiros,
									this.mniProdutos,
									this.mniTabelasPrecos,
									this.mniNaturezas,
			                        this.mniEmail});
			this.mnuCadastro.Name = "mnuCadastro";
			this.mnuCadastro.Size = new System.Drawing.Size(68, 20);
			this.mnuCadastro.Text = "&Cadastros";
			// 
			// mniCadEstados
			// 
			this.mniCadEstados.Name = "mniCadEstados";
			this.mniCadEstados.Size = new System.Drawing.Size(174, 22);
			this.mniCadEstados.Text = "&Estados";
			this.mniCadEstados.Click += new System.EventHandler(this.MniCadEstadosClick);
			// 
			// mniCadCargos
			// 
			this.mniCadCargos.Name = "mniCadCargos";
			this.mniCadCargos.Size = new System.Drawing.Size(174, 22);
			this.mniCadCargos.Text = "&Cargos";
			this.mniCadCargos.Click += new System.EventHandler(this.MniCadCargosClick);
			// 
			// mniFuncionarios
			// 
			this.mniFuncionarios.Name = "mniFuncionarios";
			this.mniFuncionarios.Size = new System.Drawing.Size(174, 22);
			this.mniFuncionarios.Text = "&Funcionários";
			this.mniFuncionarios.Click += new System.EventHandler(this.MniFuncionariosClick);
			// 
			// mniParceiros
			// 
			this.mniParceiros.Name = "mniParceiros";
			this.mniParceiros.Size = new System.Drawing.Size(174, 22);
			this.mniParceiros.Text = "&Parceiros";
			this.mniParceiros.Click += new System.EventHandler(this.MniParceirosClick);
			// 
			// mniProdutos
			// 
			this.mniProdutos.Name = "mniProdutos";
			this.mniProdutos.Size = new System.Drawing.Size(174, 22);
			this.mniProdutos.Text = "P&rodutos";
			this.mniProdutos.Click += new System.EventHandler(this.MniProdutosClick);
			// 
			// mniTabelasPrecos
			// 
			this.mniTabelasPrecos.Name = "mniTabelasPrecos";
			this.mniTabelasPrecos.Size = new System.Drawing.Size(174, 22);
			this.mniTabelasPrecos.Text = "&Tabelas de Preços";
			this.mniTabelasPrecos.Click += new System.EventHandler(this.MniTabelasPrecosClick);
			// 
			// mniNaturezas
			// 
			this.mniNaturezas.Name = "mniNaturezas";
			this.mniNaturezas.Size = new System.Drawing.Size(174, 22);
			this.mniNaturezas.Text = "&Naturezas Agenda";
			this.mniNaturezas.Click += new System.EventHandler(this.MniNaturezasClick);
			// 
			// mniEmail
			// 
			this.mniEmail.Name = "mniEmail";
			this.mniEmail.Size = new System.Drawing.Size(174, 22);
			this.mniEmail.Text = "&Email APP";
			this.mniEmail.Click += new System.EventHandler(this.MniEmailClick);			
			// 
			// mnuOrcamento
			// 
			this.mnuOrcamento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.mniCaracteristicasVenda,
									this.mniCondicoesPagamento,
									this.mniSituacoesOrcamento});
			this.mnuOrcamento.Name = "mnuOrcamento";
			this.mnuOrcamento.Size = new System.Drawing.Size(72, 20);
			this.mnuOrcamento.Text = "Orçamento";
			// 
			// mniCaracteristicasVenda
			// 
			this.mniCaracteristicasVenda.Name = "mniCaracteristicasVenda";
			this.mniCaracteristicasVenda.Size = new System.Drawing.Size(206, 22);
			this.mniCaracteristicasVenda.Text = "Características de Venda";
			this.mniCaracteristicasVenda.Click += new System.EventHandler(this.MniCaracteristicasVendaClick);
			// 
			// mniCondicoesPagamento
			// 
			this.mniCondicoesPagamento.Name = "mniCondicoesPagamento";
			this.mniCondicoesPagamento.Size = new System.Drawing.Size(206, 22);
			this.mniCondicoesPagamento.Text = "Condições de Pagamento";
			this.mniCondicoesPagamento.Click += new System.EventHandler(this.MniCondicoesPagamentoClick);
			// 
			// mniSituacoesOrcamento
			// 
			this.mniSituacoesOrcamento.Name = "mniSituacoesOrcamento";
			this.mniSituacoesOrcamento.Size = new System.Drawing.Size(206, 22);
			this.mniSituacoesOrcamento.Text = "Situações";
			this.mniSituacoesOrcamento.Click += new System.EventHandler(this.MniSituacoesOrcamentoClick);
			// 
			// mnuProposta
			// 
			this.mnuProposta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.mniIntroducoes,
									this.mniInformacoesFornecimento,
									this.mniTermosGarantia,
									this.mniCondicoesMontagem,
									this.mniTermosAprovacao});
			this.mnuProposta.Name = "mnuProposta";
			this.mnuProposta.Size = new System.Drawing.Size(62, 20);
			this.mnuProposta.Text = "Proposta";
			// 
			// mniIntroducoes
			// 
			this.mniIntroducoes.Name = "mniIntroducoes";
			this.mniIntroducoes.Size = new System.Drawing.Size(228, 22);
			this.mniIntroducoes.Text = "Introduções";
			this.mniIntroducoes.Click += new System.EventHandler(this.IntroduçãoToolStripMenuItemClick);
			// 
			// mniInformacoesFornecimento
			// 
			this.mniInformacoesFornecimento.Name = "mniInformacoesFornecimento";
			this.mniInformacoesFornecimento.Size = new System.Drawing.Size(228, 22);
			this.mniInformacoesFornecimento.Text = "Informações de Fornecimento";
			this.mniInformacoesFornecimento.Click += new System.EventHandler(this.InformaçõesDeFornecimentoToolStripMenuItemClick);
			// 
			// mniTermosGarantia
			// 
			this.mniTermosGarantia.Name = "mniTermosGarantia";
			this.mniTermosGarantia.Size = new System.Drawing.Size(228, 22);
			this.mniTermosGarantia.Text = "Termos de Garantia";
			this.mniTermosGarantia.Click += new System.EventHandler(this.TermoDeGarantiaToolStripMenuItemClick);
			// 
			// mniCondicoesMontagem
			// 
			this.mniCondicoesMontagem.Name = "mniCondicoesMontagem";
			this.mniCondicoesMontagem.Size = new System.Drawing.Size(228, 22);
			this.mniCondicoesMontagem.Text = "Condições para Montagem";
			this.mniCondicoesMontagem.Click += new System.EventHandler(this.CondiçõesParaMontagemToolStripMenuItemClick);
			// 
			// mniTermosAprovacao
			// 
			this.mniTermosAprovacao.Name = "mniTermosAprovacao";
			this.mniTermosAprovacao.Size = new System.Drawing.Size(228, 22);
			this.mniTermosAprovacao.Text = "Termos de Aprovação";
			this.mniTermosAprovacao.Click += new System.EventHandler(this.TermoDeAprovaçãoToolStripMenuItemClick);
			// 
			// mnuAcao
			// 
			this.mnuAcao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.mniOrigens,
									this.mniProdutosAcao,
									this.mniSituacoesAcao});
			this.mnuAcao.Name = "mnuAcao";
			this.mnuAcao.Size = new System.Drawing.Size(43, 20);
			this.mnuAcao.Text = "Ação";
			// 
			// mniOrigens
			// 
			this.mniOrigens.Name = "mniOrigens";
			this.mniOrigens.Size = new System.Drawing.Size(131, 22);
			this.mniOrigens.Text = "Origens";
			this.mniOrigens.Click += new System.EventHandler(this.MniOrigensClick);
			// 
			// mniProdutosAcao
			// 
			this.mniProdutosAcao.Name = "mniProdutosAcao";
			this.mniProdutosAcao.Size = new System.Drawing.Size(131, 22);
			this.mniProdutosAcao.Text = "Produtos";
			this.mniProdutosAcao.Click += new System.EventHandler(this.MniProdutosAcaoClick);
			// 
			// mniSituacoesAcao
			// 
			this.mniSituacoesAcao.Name = "mniSituacoesAcao";
			this.mniSituacoesAcao.Size = new System.Drawing.Size(131, 22);
			this.mniSituacoesAcao.Text = "Situações";
			this.mniSituacoesAcao.Click += new System.EventHandler(this.MniSituacoesAcaoClick);
			// 
			// mnuAjuda
			// 
			this.mnuAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.mniSobre});
			this.mnuAjuda.Name = "mnuAjuda";
			this.mnuAjuda.Size = new System.Drawing.Size(47, 20);
			this.mnuAjuda.Text = "Ajuda";
			// 
			// mniSobre
			// 
			this.mniSobre.Name = "mniSobre";
			this.mniSobre.Size = new System.Drawing.Size(113, 22);
			this.mniSobre.Text = "Sobre";
			this.mniSobre.Click += new System.EventHandler(this.MniSobreClick);
			// 
			// pnlResumo
			// 
			this.pnlResumo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlResumo.Controls.Add(this.btnConsultaConsultores);
			this.pnlResumo.Controls.Add(this.btnConsultaFornecedores);
			this.pnlResumo.Controls.Add(this.btnConsultaClientes);
			this.pnlResumo.Controls.Add(this.edtConsultores);
			this.pnlResumo.Controls.Add(this.edtFornecedores);
			this.pnlResumo.Controls.Add(this.edtClientes);
			this.pnlResumo.Controls.Add(this.lblConsultores);
			this.pnlResumo.Controls.Add(this.lblFornecedores);
			this.pnlResumo.Controls.Add(this.lblClientes);
			this.pnlResumo.Location = new System.Drawing.Point(100, 150);
			this.pnlResumo.Name = "pnlResumo";
			this.pnlResumo.Size = new System.Drawing.Size(303, 114);
			this.pnlResumo.TabIndex = 4;
			// 
			// btnConsultaConsultores
			// 
			this.btnConsultaConsultores.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultaConsultores.Image")));
			this.btnConsultaConsultores.Location = new System.Drawing.Point(240, 69);
			this.btnConsultaConsultores.Name = "btnConsultaConsultores";
			this.btnConsultaConsultores.Size = new System.Drawing.Size(36, 23);
			this.btnConsultaConsultores.TabIndex = 12;
			this.btnConsultaConsultores.UseVisualStyleBackColor = true;
			this.btnConsultaConsultores.Click += new System.EventHandler(this.BtnConsultaConsultoresClick);
			// 
			// btnConsultaFornecedores
			// 
			this.btnConsultaFornecedores.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultaFornecedores.Image")));
			this.btnConsultaFornecedores.Location = new System.Drawing.Point(240, 39);
			this.btnConsultaFornecedores.Name = "btnConsultaFornecedores";
			this.btnConsultaFornecedores.Size = new System.Drawing.Size(36, 23);
			this.btnConsultaFornecedores.TabIndex = 9;
			this.btnConsultaFornecedores.UseVisualStyleBackColor = true;
			this.btnConsultaFornecedores.Click += new System.EventHandler(this.BtnConsultaFornecedoresClick);
			// 
			// btnConsultaClientes
			// 
			this.btnConsultaClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultaClientes.Image")));
			this.btnConsultaClientes.Location = new System.Drawing.Point(240, 9);
			this.btnConsultaClientes.Name = "btnConsultaClientes";
			this.btnConsultaClientes.Size = new System.Drawing.Size(36, 23);
			this.btnConsultaClientes.TabIndex = 6;
			this.btnConsultaClientes.UseVisualStyleBackColor = true;
			this.btnConsultaClientes.Click += new System.EventHandler(this.BtnConsultaClientesClick);
			// 
			// edtConsultores
			// 
			this.edtConsultores.Location = new System.Drawing.Point(120, 70);
			this.edtConsultores.Name = "edtConsultores";
			this.edtConsultores.ReadOnly = true;
			this.edtConsultores.ShortcutsEnabled = false;
			this.edtConsultores.Size = new System.Drawing.Size(100, 20);
			this.edtConsultores.TabIndex = 11;
			// 
			// edtFornecedores
			// 
			this.edtFornecedores.Location = new System.Drawing.Point(120, 40);
			this.edtFornecedores.Name = "edtFornecedores";
			this.edtFornecedores.ReadOnly = true;
			this.edtFornecedores.Size = new System.Drawing.Size(100, 20);
			this.edtFornecedores.TabIndex = 8;
			// 
			// edtClientes
			// 
			this.edtClientes.Location = new System.Drawing.Point(120, 10);
			this.edtClientes.Name = "edtClientes";
			this.edtClientes.ReadOnly = true;
			this.edtClientes.Size = new System.Drawing.Size(100, 20);
			this.edtClientes.TabIndex = 5;
			// 
			// lblConsultores
			// 
			this.lblConsultores.Location = new System.Drawing.Point(10, 70);
			this.lblConsultores.Name = "lblConsultores";
			this.lblConsultores.Size = new System.Drawing.Size(100, 23);
			this.lblConsultores.TabIndex = 3;
			this.lblConsultores.Text = "Consultores";
			this.lblConsultores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblFornecedores
			// 
			this.lblFornecedores.Location = new System.Drawing.Point(10, 40);
			this.lblFornecedores.Name = "lblFornecedores";
			this.lblFornecedores.Size = new System.Drawing.Size(100, 23);
			this.lblFornecedores.TabIndex = 2;
			this.lblFornecedores.Text = "Fornecedores";
			this.lblFornecedores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblClientes
			// 
			this.lblClientes.Location = new System.Drawing.Point(10, 10);
			this.lblClientes.Name = "lblClientes";
			this.lblClientes.Size = new System.Drawing.Size(100, 23);
			this.lblClientes.TabIndex = 1;
			this.lblClientes.Text = "Clientes";
			this.lblClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.ClientSize = new System.Drawing.Size(584, 414);
			this.Controls.Add(this.pnlResumo);
			this.Controls.Add(this.mnuBasico);
			this.MainMenuStrip = this.mnuBasico;
			this.Name = "MainForm";
			this.Text = "Sistema SOFT - Cadastros Básicos - v2.3.2 (23/07/22)";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.Shown += new System.EventHandler(this.MainFormShown);
			this.Controls.SetChildIndex(this.imgSoftplace, 0);
			this.Controls.SetChildIndex(this.mnuBasico, 0);
			this.Controls.SetChildIndex(this.pnlResumo, 0);
			((System.ComponentModel.ISupportInitialize)(this.imgSoftplace)).EndInit();
			this.mnuBasico.ResumeLayout(false);
			this.mnuBasico.PerformLayout();
			this.pnlResumo.ResumeLayout(false);
			this.pnlResumo.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem mniSituacoesOrcamento;
		private System.Windows.Forms.ToolStripMenuItem mniCondicoesPagamento;
		private System.Windows.Forms.ToolStripMenuItem mniCaracteristicasVenda;
		private System.Windows.Forms.ToolStripMenuItem mnuOrcamento;
		private System.Windows.Forms.ToolStripMenuItem mniSituacoesAcao;
		private System.Windows.Forms.ToolStripMenuItem mniProdutosAcao;
		private System.Windows.Forms.ToolStripMenuItem mniOrigens;
		private System.Windows.Forms.ToolStripMenuItem mnuAcao;
		private System.Windows.Forms.ToolStripMenuItem mniIntroducoes;
		private System.Windows.Forms.ToolStripMenuItem mniInformacoesFornecimento;
		private System.Windows.Forms.ToolStripMenuItem mniTermosGarantia;
		private System.Windows.Forms.ToolStripMenuItem mniCondicoesMontagem;
		private System.Windows.Forms.ToolStripMenuItem mniTermosAprovacao;
		private System.Windows.Forms.ToolStripMenuItem mnuProposta;
		private System.Windows.Forms.ToolStripMenuItem mniNaturezas;
		private System.Windows.Forms.ToolStripMenuItem mniEmail;
		private System.Windows.Forms.ToolStripMenuItem mniTabelasPrecos;
		private System.Windows.Forms.ToolStripMenuItem mniProdutos;
		private System.Windows.Forms.ToolStripMenuItem mnuArquivo;
		private System.Windows.Forms.ToolStripMenuItem mnuCadastro;
		private System.Windows.Forms.ToolStripMenuItem mnuAjuda;
		private System.Windows.Forms.Panel pnlResumo;
		private System.Windows.Forms.Button btnConsultaConsultores;
		private System.Windows.Forms.Button btnConsultaFornecedores;
		private System.Windows.Forms.Button btnConsultaClientes;
		private System.Windows.Forms.TextBox edtConsultores;
		private System.Windows.Forms.TextBox edtFornecedores;
		private System.Windows.Forms.TextBox edtClientes;
		private System.Windows.Forms.Label lblConsultores;
		private System.Windows.Forms.Label lblFornecedores;
		private System.Windows.Forms.Label lblClientes;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.ToolStripMenuItem mniParceiros;
		private System.Windows.Forms.ToolStripMenuItem mniFuncionarios;
		private System.Windows.Forms.ToolStripMenuItem mniCadCargos;
		private System.Windows.Forms.ToolStripMenuItem mniCadEstados;
		private System.Windows.Forms.ToolStripMenuItem mniSobre;
		private System.Windows.Forms.ToolStripMenuItem mniSair;
		private System.Windows.Forms.MenuStrip mnuBasico;
	}
}
