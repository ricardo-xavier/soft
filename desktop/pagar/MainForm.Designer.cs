/*
 * Criado por SharpDevelop.
 * Usuário: Ricardo
 * Data: 20/07/2008
 * Hora: 9:30
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace pagar
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.mnuPagar = new System.Windows.Forms.MenuStrip();
			this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mniSair = new System.Windows.Forms.ToolStripMenuItem();
			this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mniNaturezas = new System.Windows.Forms.ToolStripMenuItem();
			this.formasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mniPendencias = new System.Windows.Forms.ToolStripMenuItem();
			this.gráficosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mniGraficoNatureza = new System.Windows.Forms.ToolStripMenuItem();
			this.minTendencia = new System.Windows.Forms.ToolStripMenuItem();
			this.mniFixoVariavel = new System.Windows.Forms.ToolStripMenuItem();
			this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mniSobre = new System.Windows.Forms.ToolStripMenuItem();
			this.gbxFiltro = new System.Windows.Forms.GroupBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dtpEmissaoF = new System.Windows.Forms.DateTimePicker();
			this.dtpEmissaoI = new System.Windows.Forms.DateTimePicker();
			this.cbxCodPendencias = new System.Windows.Forms.ComboBox();
			this.gbxPendencias = new System.Windows.Forms.GroupBox();
			this.cbxFiltroPendencias = new System.Windows.Forms.ComboBox();
			this.btnLimpa = new System.Windows.Forms.Button();
			this.btnAplica = new System.Windows.Forms.Button();
			this.gbxPagamento = new System.Windows.Forms.GroupBox();
			this.dtpPagamentoF = new System.Windows.Forms.DateTimePicker();
			this.dtpPagamentoI = new System.Windows.Forms.DateTimePicker();
			this.gbxVencimento = new System.Windows.Forms.GroupBox();
			this.dtpVencimentoF = new System.Windows.Forms.DateTimePicker();
			this.dtpVencimentoI = new System.Windows.Forms.DateTimePicker();
			this.gbxParceiro = new System.Windows.Forms.GroupBox();
			this.btnParceiro = new System.Windows.Forms.Button();
			this.edtParceiro = new System.Windows.Forms.TextBox();
			this.gbxTipos = new System.Windows.Forms.GroupBox();
			this.cbxFiltroTipos = new System.Windows.Forms.ComboBox();
			this.cbxCodFormas = new System.Windows.Forms.ComboBox();
			this.gbxForma = new System.Windows.Forms.GroupBox();
			this.cbxFiltroFormas = new System.Windows.Forms.ComboBox();
			this.cbxCodNaturezas = new System.Windows.Forms.ComboBox();
			this.gbxNatureza = new System.Windows.Forms.GroupBox();
			this.chkTodas = new System.Windows.Forms.CheckBox();
			this.clbFiltroNaturezas = new System.Windows.Forms.CheckedListBox();
			this.cbxFiltroNaturezas = new System.Windows.Forms.ComboBox();
			this.gbxSituacao = new System.Windows.Forms.GroupBox();
			this.cbxFiltroSituacao = new System.Windows.Forms.ComboBox();
			this.dgvCadastro = new System.Windows.Forms.DataGridView();
			this.edtLocaliza = new System.Windows.Forms.TextBox();
			this.btnLocaliza = new System.Windows.Forms.Button();
			this.btnInclui = new System.Windows.Forms.Button();
			this.btnExclui = new System.Windows.Forms.Button();
			this.btnAltera = new System.Windows.Forms.Button();
			this.btnFecha = new System.Windows.Forms.Button();
			this.edtTotal = new System.Windows.Forms.TextBox();
			this.edtRegistros = new System.Windows.Forms.TextBox();
			this.lblRegistros = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.edtObservacao = new System.Windows.Forms.TextBox();
			this.btnPaga = new System.Windows.Forms.Button();
			this.btnImprime = new System.Windows.Forms.Button();
			this.edtDocGerado = new System.Windows.Forms.TextBox();
			this.edtForma = new System.Windows.Forms.TextBox();
			this.btnUp = new System.Windows.Forms.Button();
			this.btnDown = new System.Windows.Forms.Button();
			this.edtFixoVariavel = new System.Windows.Forms.TextBox();
			this.edtTotalPago = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.edtTotalPagar = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.imgSoftplace)).BeginInit();
			this.mnuPagar.SuspendLayout();
			this.gbxFiltro.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.gbxPendencias.SuspendLayout();
			this.gbxPagamento.SuspendLayout();
			this.gbxVencimento.SuspendLayout();
			this.gbxParceiro.SuspendLayout();
			this.gbxTipos.SuspendLayout();
			this.gbxForma.SuspendLayout();
			this.gbxNatureza.SuspendLayout();
			this.gbxSituacao.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCadastro)).BeginInit();
			this.SuspendLayout();
			// 
			// mnuPagar
			// 
			this.mnuPagar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.arquivoToolStripMenuItem,
			this.cadastroToolStripMenuItem,
			this.gráficosToolStripMenuItem,
			this.ajudaToolStripMenuItem});
			this.mnuPagar.Location = new System.Drawing.Point(0, 0);
			this.mnuPagar.Name = "mnuPagar";
			this.mnuPagar.Size = new System.Drawing.Size(934, 24);
			this.mnuPagar.TabIndex = 3;
			this.mnuPagar.Text = "menuStrip1";
			// 
			// arquivoToolStripMenuItem
			// 
			this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.mniSair});
			this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
			this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.arquivoToolStripMenuItem.Text = "&Arquivo";
			// 
			// mniSair
			// 
			this.mniSair.Name = "mniSair";
			this.mniSair.Size = new System.Drawing.Size(93, 22);
			this.mniSair.Text = "&Sair";
			this.mniSair.Click += new System.EventHandler(this.SairToolStripMenuItemClick);
			// 
			// cadastroToolStripMenuItem
			// 
			this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.mniNaturezas,
			this.formasToolStripMenuItem,
			this.mniPendencias});
			this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
			this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
			this.cadastroToolStripMenuItem.Text = "&Cadastro";
			// 
			// mniNaturezas
			// 
			this.mniNaturezas.Name = "mniNaturezas";
			this.mniNaturezas.Size = new System.Drawing.Size(134, 22);
			this.mniNaturezas.Text = "&Naturezas";
			this.mniNaturezas.Click += new System.EventHandler(this.MniNaturezasClick);
			// 
			// formasToolStripMenuItem
			// 
			this.formasToolStripMenuItem.Name = "formasToolStripMenuItem";
			this.formasToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.formasToolStripMenuItem.Text = "&Formas";
			this.formasToolStripMenuItem.Click += new System.EventHandler(this.FormasToolStripMenuItemClick);
			// 
			// mniPendencias
			// 
			this.mniPendencias.Name = "mniPendencias";
			this.mniPendencias.Size = new System.Drawing.Size(134, 22);
			this.mniPendencias.Text = "&Pendências";
			this.mniPendencias.Click += new System.EventHandler(this.MniPendenciasClick);
			// 
			// gráficosToolStripMenuItem
			// 
			this.gráficosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.mniGraficoNatureza,
			this.minTendencia,
			this.mniFixoVariavel});
			this.gráficosToolStripMenuItem.Name = "gráficosToolStripMenuItem";
			this.gráficosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
			this.gráficosToolStripMenuItem.Text = "Gráficos";
			// 
			// mniGraficoNatureza
			// 
			this.mniGraficoNatureza.Name = "mniGraficoNatureza";
			this.mniGraficoNatureza.Size = new System.Drawing.Size(146, 22);
			this.mniGraficoNatureza.Text = "Por Natureza";
			this.mniGraficoNatureza.Click += new System.EventHandler(this.MniGraficoNaturezaClick);
			// 
			// minTendencia
			// 
			this.minTendencia.Name = "minTendencia";
			this.minTendencia.Size = new System.Drawing.Size(146, 22);
			this.minTendencia.Text = "Tendência";
			this.minTendencia.Click += new System.EventHandler(this.MinTendenciaClick);
			// 
			// mniFixoVariavel
			// 
			this.mniFixoVariavel.Name = "mniFixoVariavel";
			this.mniFixoVariavel.Size = new System.Drawing.Size(146, 22);
			this.mniFixoVariavel.Text = "&Fixo x Variável";
			this.mniFixoVariavel.Click += new System.EventHandler(this.MniFixoVariavelClick);
			// 
			// ajudaToolStripMenuItem
			// 
			this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.mniSobre});
			this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
			this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.ajudaToolStripMenuItem.Text = "Aj&uda";
			// 
			// mniSobre
			// 
			this.mniSobre.Name = "mniSobre";
			this.mniSobre.Size = new System.Drawing.Size(104, 22);
			this.mniSobre.Text = "&Sobre";
			this.mniSobre.Click += new System.EventHandler(this.SobreToolStripMenuItemClick);
			// 
			// gbxFiltro
			// 
			this.gbxFiltro.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.gbxFiltro.Controls.Add(this.groupBox1);
			this.gbxFiltro.Controls.Add(this.cbxCodPendencias);
			this.gbxFiltro.Controls.Add(this.gbxPendencias);
			this.gbxFiltro.Controls.Add(this.btnLimpa);
			this.gbxFiltro.Controls.Add(this.btnAplica);
			this.gbxFiltro.Controls.Add(this.gbxPagamento);
			this.gbxFiltro.Controls.Add(this.gbxVencimento);
			this.gbxFiltro.Controls.Add(this.gbxParceiro);
			this.gbxFiltro.Controls.Add(this.gbxTipos);
			this.gbxFiltro.Controls.Add(this.cbxCodFormas);
			this.gbxFiltro.Controls.Add(this.gbxForma);
			this.gbxFiltro.Controls.Add(this.cbxCodNaturezas);
			this.gbxFiltro.Controls.Add(this.gbxNatureza);
			this.gbxFiltro.Controls.Add(this.gbxSituacao);
			this.gbxFiltro.Location = new System.Drawing.Point(10, 30);
			this.gbxFiltro.Name = "gbxFiltro";
			this.gbxFiltro.Size = new System.Drawing.Size(245, 593);
			this.gbxFiltro.TabIndex = 0;
			this.gbxFiltro.TabStop = false;
			this.gbxFiltro.Text = "Filtro";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dtpEmissaoF);
			this.groupBox1.Controls.Add(this.dtpEmissaoI);
			this.groupBox1.Location = new System.Drawing.Point(10, 507);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(227, 34);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Entrada";
			// 
			// dtpEmissaoF
			// 
			this.dtpEmissaoF.CustomFormat = "dd/MM/yyyy";
			this.dtpEmissaoF.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpEmissaoF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpEmissaoF.Location = new System.Drawing.Point(117, 14);
			this.dtpEmissaoF.Name = "dtpEmissaoF";
			this.dtpEmissaoF.ShowCheckBox = true;
			this.dtpEmissaoF.Size = new System.Drawing.Size(110, 20);
			this.dtpEmissaoF.TabIndex = 17;
			// 
			// dtpEmissaoI
			// 
			this.dtpEmissaoI.CustomFormat = "dd/MM/yyyy";
			this.dtpEmissaoI.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpEmissaoI.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpEmissaoI.Location = new System.Drawing.Point(5, 14);
			this.dtpEmissaoI.Name = "dtpEmissaoI";
			this.dtpEmissaoI.ShowCheckBox = true;
			this.dtpEmissaoI.Size = new System.Drawing.Size(110, 20);
			this.dtpEmissaoI.TabIndex = 15;
			// 
			// cbxCodPendencias
			// 
			this.cbxCodPendencias.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxCodPendencias.FormattingEnabled = true;
			this.cbxCodPendencias.Location = new System.Drawing.Point(6, 524);
			this.cbxCodPendencias.Name = "cbxCodPendencias";
			this.cbxCodPendencias.Size = new System.Drawing.Size(166, 22);
			this.cbxCodPendencias.TabIndex = 131;
			this.cbxCodPendencias.Visible = false;
			// 
			// gbxPendencias
			// 
			this.gbxPendencias.Controls.Add(this.cbxFiltroPendencias);
			this.gbxPendencias.Location = new System.Drawing.Point(10, 326);
			this.gbxPendencias.Name = "gbxPendencias";
			this.gbxPendencias.Size = new System.Drawing.Size(227, 44);
			this.gbxPendencias.TabIndex = 4;
			this.gbxPendencias.TabStop = false;
			this.gbxPendencias.Text = "Pendência";
			// 
			// cbxFiltroPendencias
			// 
			this.cbxFiltroPendencias.FormattingEnabled = true;
			this.cbxFiltroPendencias.Location = new System.Drawing.Point(6, 15);
			this.cbxFiltroPendencias.Name = "cbxFiltroPendencias";
			this.cbxFiltroPendencias.Size = new System.Drawing.Size(215, 21);
			this.cbxFiltroPendencias.TabIndex = 0;
			// 
			// btnLimpa
			// 
			this.btnLimpa.Location = new System.Drawing.Point(139, 553);
			this.btnLimpa.Name = "btnLimpa";
			this.btnLimpa.Size = new System.Drawing.Size(100, 25);
			this.btnLimpa.TabIndex = 10;
			this.btnLimpa.Text = "&Limpa";
			this.btnLimpa.UseVisualStyleBackColor = true;
			this.btnLimpa.Click += new System.EventHandler(this.BtnLimpaClick);
			// 
			// btnAplica
			// 
			this.btnAplica.Location = new System.Drawing.Point(33, 553);
			this.btnAplica.Name = "btnAplica";
			this.btnAplica.Size = new System.Drawing.Size(100, 25);
			this.btnAplica.TabIndex = 9;
			this.btnAplica.Text = "&Aplica";
			this.btnAplica.UseVisualStyleBackColor = true;
			this.btnAplica.Click += new System.EventHandler(this.BtnAplicaClick);
			// 
			// gbxPagamento
			// 
			this.gbxPagamento.Controls.Add(this.dtpPagamentoF);
			this.gbxPagamento.Controls.Add(this.dtpPagamentoI);
			this.gbxPagamento.Location = new System.Drawing.Point(10, 468);
			this.gbxPagamento.Name = "gbxPagamento";
			this.gbxPagamento.Size = new System.Drawing.Size(227, 35);
			this.gbxPagamento.TabIndex = 7;
			this.gbxPagamento.TabStop = false;
			this.gbxPagamento.Text = "Pagamento";
			// 
			// dtpPagamentoF
			// 
			this.dtpPagamentoF.CustomFormat = "dd/MM/yyyy";
			this.dtpPagamentoF.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpPagamentoF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpPagamentoF.Location = new System.Drawing.Point(117, 12);
			this.dtpPagamentoF.Name = "dtpPagamentoF";
			this.dtpPagamentoF.ShowCheckBox = true;
			this.dtpPagamentoF.Size = new System.Drawing.Size(110, 20);
			this.dtpPagamentoF.TabIndex = 17;
			// 
			// dtpPagamentoI
			// 
			this.dtpPagamentoI.CustomFormat = "dd/MM/yyyy";
			this.dtpPagamentoI.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpPagamentoI.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpPagamentoI.Location = new System.Drawing.Point(5, 12);
			this.dtpPagamentoI.Name = "dtpPagamentoI";
			this.dtpPagamentoI.ShowCheckBox = true;
			this.dtpPagamentoI.Size = new System.Drawing.Size(110, 20);
			this.dtpPagamentoI.TabIndex = 15;
			// 
			// gbxVencimento
			// 
			this.gbxVencimento.Controls.Add(this.dtpVencimentoF);
			this.gbxVencimento.Controls.Add(this.dtpVencimentoI);
			this.gbxVencimento.Location = new System.Drawing.Point(10, 429);
			this.gbxVencimento.Name = "gbxVencimento";
			this.gbxVencimento.Size = new System.Drawing.Size(227, 37);
			this.gbxVencimento.TabIndex = 6;
			this.gbxVencimento.TabStop = false;
			this.gbxVencimento.Text = "Vencimento ";
			// 
			// dtpVencimentoF
			// 
			this.dtpVencimentoF.CustomFormat = "dd/MM/yyyy";
			this.dtpVencimentoF.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpVencimentoF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpVencimentoF.Location = new System.Drawing.Point(117, 12);
			this.dtpVencimentoF.Name = "dtpVencimentoF";
			this.dtpVencimentoF.ShowCheckBox = true;
			this.dtpVencimentoF.Size = new System.Drawing.Size(110, 20);
			this.dtpVencimentoF.TabIndex = 17;
			// 
			// dtpVencimentoI
			// 
			this.dtpVencimentoI.CustomFormat = "dd/MM/yyyy";
			this.dtpVencimentoI.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpVencimentoI.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpVencimentoI.Location = new System.Drawing.Point(5, 12);
			this.dtpVencimentoI.Name = "dtpVencimentoI";
			this.dtpVencimentoI.ShowCheckBox = true;
			this.dtpVencimentoI.Size = new System.Drawing.Size(110, 20);
			this.dtpVencimentoI.TabIndex = 15;
			// 
			// gbxParceiro
			// 
			this.gbxParceiro.Controls.Add(this.btnParceiro);
			this.gbxParceiro.Controls.Add(this.edtParceiro);
			this.gbxParceiro.Location = new System.Drawing.Point(10, 376);
			this.gbxParceiro.Name = "gbxParceiro";
			this.gbxParceiro.Size = new System.Drawing.Size(227, 44);
			this.gbxParceiro.TabIndex = 5;
			this.gbxParceiro.TabStop = false;
			this.gbxParceiro.Text = "Parceiro";
			// 
			// btnParceiro
			// 
			this.btnParceiro.Image = ((System.Drawing.Image)(resources.GetObject("btnParceiro.Image")));
			this.btnParceiro.Location = new System.Drawing.Point(160, 13);
			this.btnParceiro.Name = "btnParceiro";
			this.btnParceiro.Size = new System.Drawing.Size(36, 23);
			this.btnParceiro.TabIndex = 1;
			this.btnParceiro.UseVisualStyleBackColor = true;
			this.btnParceiro.Click += new System.EventHandler(this.BtnParceiroClick);
			// 
			// edtParceiro
			// 
			this.edtParceiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtParceiro.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtParceiro.Location = new System.Drawing.Point(6, 15);
			this.edtParceiro.MaxLength = 20;
			this.edtParceiro.Name = "edtParceiro";
			this.edtParceiro.Size = new System.Drawing.Size(146, 20);
			this.edtParceiro.TabIndex = 0;
			// 
			// gbxTipos
			// 
			this.gbxTipos.Controls.Add(this.cbxFiltroTipos);
			this.gbxTipos.Location = new System.Drawing.Point(10, 276);
			this.gbxTipos.Name = "gbxTipos";
			this.gbxTipos.Size = new System.Drawing.Size(227, 44);
			this.gbxTipos.TabIndex = 3;
			this.gbxTipos.TabStop = false;
			this.gbxTipos.Text = "Tipo";
			// 
			// cbxFiltroTipos
			// 
			this.cbxFiltroTipos.FormattingEnabled = true;
			this.cbxFiltroTipos.Location = new System.Drawing.Point(6, 15);
			this.cbxFiltroTipos.Name = "cbxFiltroTipos";
			this.cbxFiltroTipos.Size = new System.Drawing.Size(215, 21);
			this.cbxFiltroTipos.TabIndex = 0;
			// 
			// cbxCodFormas
			// 
			this.cbxCodFormas.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxCodFormas.FormattingEnabled = true;
			this.cbxCodFormas.Location = new System.Drawing.Point(71, 523);
			this.cbxCodFormas.Name = "cbxCodFormas";
			this.cbxCodFormas.Size = new System.Drawing.Size(166, 22);
			this.cbxCodFormas.TabIndex = 129;
			this.cbxCodFormas.Visible = false;
			// 
			// gbxForma
			// 
			this.gbxForma.Controls.Add(this.cbxFiltroFormas);
			this.gbxForma.Location = new System.Drawing.Point(10, 228);
			this.gbxForma.Name = "gbxForma";
			this.gbxForma.Size = new System.Drawing.Size(227, 44);
			this.gbxForma.TabIndex = 2;
			this.gbxForma.TabStop = false;
			this.gbxForma.Text = "Forma";
			// 
			// cbxFiltroFormas
			// 
			this.cbxFiltroFormas.FormattingEnabled = true;
			this.cbxFiltroFormas.Location = new System.Drawing.Point(6, 15);
			this.cbxFiltroFormas.Name = "cbxFiltroFormas";
			this.cbxFiltroFormas.Size = new System.Drawing.Size(215, 21);
			this.cbxFiltroFormas.TabIndex = 0;
			// 
			// cbxCodNaturezas
			// 
			this.cbxCodNaturezas.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxCodNaturezas.FormattingEnabled = true;
			this.cbxCodNaturezas.Location = new System.Drawing.Point(33, 523);
			this.cbxCodNaturezas.Name = "cbxCodNaturezas";
			this.cbxCodNaturezas.Size = new System.Drawing.Size(166, 22);
			this.cbxCodNaturezas.TabIndex = 128;
			this.cbxCodNaturezas.Visible = false;
			// 
			// gbxNatureza
			// 
			this.gbxNatureza.Controls.Add(this.chkTodas);
			this.gbxNatureza.Controls.Add(this.clbFiltroNaturezas);
			this.gbxNatureza.Controls.Add(this.cbxFiltroNaturezas);
			this.gbxNatureza.Location = new System.Drawing.Point(10, 56);
			this.gbxNatureza.Name = "gbxNatureza";
			this.gbxNatureza.Size = new System.Drawing.Size(227, 166);
			this.gbxNatureza.TabIndex = 1;
			this.gbxNatureza.TabStop = false;
			this.gbxNatureza.Text = "Natureza";
			// 
			// chkTodas
			// 
			this.chkTodas.Checked = true;
			this.chkTodas.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkTodas.Location = new System.Drawing.Point(79, 140);
			this.chkTodas.Name = "chkTodas";
			this.chkTodas.Size = new System.Drawing.Size(143, 24);
			this.chkTodas.TabIndex = 86;
			this.chkTodas.Text = "Marca/Desmarca Todas";
			this.chkTodas.UseVisualStyleBackColor = true;
			this.chkTodas.CheckedChanged += new System.EventHandler(this.ChkTodasCheckedChanged);
			// 
			// clbFiltroNaturezas
			// 
			this.clbFiltroNaturezas.FormattingEnabled = true;
			this.clbFiltroNaturezas.Location = new System.Drawing.Point(6, 14);
			this.clbFiltroNaturezas.Name = "clbFiltroNaturezas";
			this.clbFiltroNaturezas.ScrollAlwaysVisible = true;
			this.clbFiltroNaturezas.Size = new System.Drawing.Size(216, 124);
			this.clbFiltroNaturezas.TabIndex = 85;
			// 
			// cbxFiltroNaturezas
			// 
			this.cbxFiltroNaturezas.FormattingEnabled = true;
			this.cbxFiltroNaturezas.Location = new System.Drawing.Point(6, 19);
			this.cbxFiltroNaturezas.Name = "cbxFiltroNaturezas";
			this.cbxFiltroNaturezas.Size = new System.Drawing.Size(215, 21);
			this.cbxFiltroNaturezas.TabIndex = 0;
			this.cbxFiltroNaturezas.Visible = false;
			// 
			// gbxSituacao
			// 
			this.gbxSituacao.Controls.Add(this.cbxFiltroSituacao);
			this.gbxSituacao.Location = new System.Drawing.Point(10, 12);
			this.gbxSituacao.Name = "gbxSituacao";
			this.gbxSituacao.Size = new System.Drawing.Size(227, 44);
			this.gbxSituacao.TabIndex = 0;
			this.gbxSituacao.TabStop = false;
			this.gbxSituacao.Text = "Situação";
			// 
			// cbxFiltroSituacao
			// 
			this.cbxFiltroSituacao.FormattingEnabled = true;
			this.cbxFiltroSituacao.Location = new System.Drawing.Point(6, 15);
			this.cbxFiltroSituacao.Name = "cbxFiltroSituacao";
			this.cbxFiltroSituacao.Size = new System.Drawing.Size(215, 21);
			this.cbxFiltroSituacao.TabIndex = 0;
			// 
			// dgvCadastro
			// 
			this.dgvCadastro.AllowUserToAddRows = false;
			this.dgvCadastro.AllowUserToDeleteRows = false;
			this.dgvCadastro.AllowUserToResizeColumns = false;
			this.dgvCadastro.AllowUserToResizeRows = false;
			this.dgvCadastro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvCadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCadastro.Location = new System.Drawing.Point(260, 60);
			this.dgvCadastro.MultiSelect = false;
			this.dgvCadastro.Name = "dgvCadastro";
			this.dgvCadastro.ReadOnly = true;
			this.dgvCadastro.RowHeadersVisible = false;
			this.dgvCadastro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCadastro.Size = new System.Drawing.Size(670, 420);
			this.dgvCadastro.TabIndex = 3;
			this.dgvCadastro.Sorted += new System.EventHandler(this.DgvCadastroSorted);
			// 
			// edtLocaliza
			// 
			this.edtLocaliza.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtLocaliza.Location = new System.Drawing.Point(260, 33);
			this.edtLocaliza.MaxLength = 30;
			this.edtLocaliza.Name = "edtLocaliza";
			this.edtLocaliza.Size = new System.Drawing.Size(195, 20);
			this.edtLocaliza.TabIndex = 1;
			this.edtLocaliza.TextChanged += new System.EventHandler(this.EdtLocalizaTextChanged);
			// 
			// btnLocaliza
			// 
			this.btnLocaliza.Location = new System.Drawing.Point(461, 30);
			this.btnLocaliza.Name = "btnLocaliza";
			this.btnLocaliza.Size = new System.Drawing.Size(100, 25);
			this.btnLocaliza.TabIndex = 2;
			this.btnLocaliza.Text = "&Localiza";
			this.btnLocaliza.UseVisualStyleBackColor = true;
			this.btnLocaliza.Click += new System.EventHandler(this.BtnLocalizaClick);
			// 
			// btnInclui
			// 
			this.btnInclui.Location = new System.Drawing.Point(516, 583);
			this.btnInclui.Name = "btnInclui";
			this.btnInclui.Size = new System.Drawing.Size(100, 25);
			this.btnInclui.TabIndex = 6;
			this.btnInclui.Text = "&Inclui";
			this.btnInclui.UseVisualStyleBackColor = true;
			this.btnInclui.Click += new System.EventHandler(this.BtnIncluiClick);
			// 
			// btnExclui
			// 
			this.btnExclui.Location = new System.Drawing.Point(622, 583);
			this.btnExclui.Name = "btnExclui";
			this.btnExclui.Size = new System.Drawing.Size(100, 25);
			this.btnExclui.TabIndex = 7;
			this.btnExclui.Text = "&Exclui";
			this.btnExclui.UseVisualStyleBackColor = true;
			this.btnExclui.Click += new System.EventHandler(this.BtnExcluiClick);
			// 
			// btnAltera
			// 
			this.btnAltera.Location = new System.Drawing.Point(728, 583);
			this.btnAltera.Name = "btnAltera";
			this.btnAltera.Size = new System.Drawing.Size(100, 25);
			this.btnAltera.TabIndex = 8;
			this.btnAltera.Text = "&Altera";
			this.btnAltera.UseVisualStyleBackColor = true;
			this.btnAltera.Click += new System.EventHandler(this.BtnAlteraClick);
			// 
			// btnFecha
			// 
			this.btnFecha.Location = new System.Drawing.Point(834, 583);
			this.btnFecha.Name = "btnFecha";
			this.btnFecha.Size = new System.Drawing.Size(100, 25);
			this.btnFecha.TabIndex = 9;
			this.btnFecha.Text = "&Fecha";
			this.btnFecha.UseVisualStyleBackColor = true;
			this.btnFecha.Click += new System.EventHandler(this.BtnFechaClick);
			// 
			// edtTotal
			// 
			this.edtTotal.BackColor = System.Drawing.SystemColors.Info;
			this.edtTotal.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtTotal.Location = new System.Drawing.Point(840, 510);
			this.edtTotal.Name = "edtTotal";
			this.edtTotal.ReadOnly = true;
			this.edtTotal.Size = new System.Drawing.Size(90, 20);
			this.edtTotal.TabIndex = 72;
			this.edtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// edtRegistros
			// 
			this.edtRegistros.BackColor = System.Drawing.SystemColors.Info;
			this.edtRegistros.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtRegistros.Location = new System.Drawing.Point(840, 487);
			this.edtRegistros.Name = "edtRegistros";
			this.edtRegistros.ReadOnly = true;
			this.edtRegistros.Size = new System.Drawing.Size(48, 20);
			this.edtRegistros.TabIndex = 75;
			this.edtRegistros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lblRegistros
			// 
			this.lblRegistros.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblRegistros.Location = new System.Drawing.Point(708, 486);
			this.lblRegistros.Name = "lblRegistros";
			this.lblRegistros.Size = new System.Drawing.Size(126, 20);
			this.lblRegistros.TabIndex = 74;
			this.lblRegistros.Text = "Títulos Selecionados";
			this.lblRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblTotal
			// 
			this.lblTotal.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblTotal.Location = new System.Drawing.Point(764, 509);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(70, 20);
			this.lblTotal.TabIndex = 73;
			this.lblTotal.Text = "Total";
			this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtObservacao
			// 
			this.edtObservacao.Enabled = false;
			this.edtObservacao.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtObservacao.Location = new System.Drawing.Point(260, 490);
			this.edtObservacao.Multiline = true;
			this.edtObservacao.Name = "edtObservacao";
			this.edtObservacao.Size = new System.Drawing.Size(426, 40);
			this.edtObservacao.TabIndex = 76;
			// 
			// btnPaga
			// 
			this.btnPaga.Location = new System.Drawing.Point(413, 583);
			this.btnPaga.Name = "btnPaga";
			this.btnPaga.Size = new System.Drawing.Size(100, 25);
			this.btnPaga.TabIndex = 5;
			this.btnPaga.Text = "&Paga";
			this.btnPaga.UseVisualStyleBackColor = true;
			this.btnPaga.Click += new System.EventHandler(this.BtnPagaClick);
			// 
			// btnImprime
			// 
			this.btnImprime.Location = new System.Drawing.Point(307, 583);
			this.btnImprime.Name = "btnImprime";
			this.btnImprime.Size = new System.Drawing.Size(100, 25);
			this.btnImprime.TabIndex = 4;
			this.btnImprime.Text = "I&mprime";
			this.btnImprime.UseVisualStyleBackColor = true;
			this.btnImprime.Click += new System.EventHandler(this.BtnImprimeClick);
			// 
			// edtDocGerado
			// 
			this.edtDocGerado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtDocGerado.Enabled = false;
			this.edtDocGerado.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtDocGerado.Location = new System.Drawing.Point(412, 536);
			this.edtDocGerado.MaxLength = 50;
			this.edtDocGerado.Name = "edtDocGerado";
			this.edtDocGerado.Size = new System.Drawing.Size(216, 20);
			this.edtDocGerado.TabIndex = 77;
			// 
			// edtForma
			// 
			this.edtForma.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtForma.Enabled = false;
			this.edtForma.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtForma.Location = new System.Drawing.Point(260, 536);
			this.edtForma.MaxLength = 50;
			this.edtForma.Name = "edtForma";
			this.edtForma.Size = new System.Drawing.Size(146, 20);
			this.edtForma.TabIndex = 78;
			// 
			// btnUp
			// 
			this.btnUp.Image = ((System.Drawing.Image)(resources.GetObject("btnUp.Image")));
			this.btnUp.Location = new System.Drawing.Point(609, 30);
			this.btnUp.Name = "btnUp";
			this.btnUp.Size = new System.Drawing.Size(36, 23);
			this.btnUp.TabIndex = 4;
			this.btnUp.UseVisualStyleBackColor = true;
			this.btnUp.Click += new System.EventHandler(this.BtnUpClick);
			// 
			// btnDown
			// 
			this.btnDown.Image = ((System.Drawing.Image)(resources.GetObject("btnDown.Image")));
			this.btnDown.Location = new System.Drawing.Point(567, 30);
			this.btnDown.Name = "btnDown";
			this.btnDown.Size = new System.Drawing.Size(36, 23);
			this.btnDown.TabIndex = 3;
			this.btnDown.UseVisualStyleBackColor = true;
			this.btnDown.Click += new System.EventHandler(this.BtnDownClick);
			// 
			// edtFixoVariavel
			// 
			this.edtFixoVariavel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtFixoVariavel.Enabled = false;
			this.edtFixoVariavel.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtFixoVariavel.Location = new System.Drawing.Point(634, 536);
			this.edtFixoVariavel.MaxLength = 50;
			this.edtFixoVariavel.Name = "edtFixoVariavel";
			this.edtFixoVariavel.Size = new System.Drawing.Size(71, 20);
			this.edtFixoVariavel.TabIndex = 79;
			this.edtFixoVariavel.Text = "VARIÁVEL";
			// 
			// edtTotalPago
			// 
			this.edtTotalPago.BackColor = System.Drawing.SystemColors.Info;
			this.edtTotalPago.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtTotalPago.Location = new System.Drawing.Point(840, 533);
			this.edtTotalPago.Name = "edtTotalPago";
			this.edtTotalPago.ReadOnly = true;
			this.edtTotalPago.Size = new System.Drawing.Size(90, 20);
			this.edtTotalPago.TabIndex = 80;
			this.edtTotalPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label7
			// 
			this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label7.Location = new System.Drawing.Point(764, 532);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(70, 20);
			this.label7.TabIndex = 81;
			this.label7.Text = "Total Pago";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtTotalPagar
			// 
			this.edtTotalPagar.BackColor = System.Drawing.SystemColors.Info;
			this.edtTotalPagar.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtTotalPagar.Location = new System.Drawing.Point(840, 557);
			this.edtTotalPagar.Name = "edtTotalPagar";
			this.edtTotalPagar.ReadOnly = true;
			this.edtTotalPagar.Size = new System.Drawing.Size(90, 20);
			this.edtTotalPagar.TabIndex = 80;
			this.edtTotalPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label8
			// 
			this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label8.Location = new System.Drawing.Point(744, 556);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(90, 20);
			this.label8.TabIndex = 83;
			this.label8.Text = "Total a Pagar";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.ClientSize = new System.Drawing.Size(934, 635);
			this.Controls.Add(this.edtTotalPagar);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.edtTotalPago);
			this.Controls.Add(this.edtFixoVariavel);
			this.Controls.Add(this.btnDown);
			this.Controls.Add(this.btnUp);
			this.Controls.Add(this.edtForma);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.edtDocGerado);
			this.Controls.Add(this.btnImprime);
			this.Controls.Add(this.btnPaga);
			this.Controls.Add(this.edtObservacao);
			this.Controls.Add(this.edtTotal);
			this.Controls.Add(this.edtRegistros);
			this.Controls.Add(this.edtLocaliza);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.btnLocaliza);
			this.Controls.Add(this.lblRegistros);
			this.Controls.Add(this.btnFecha);
			this.Controls.Add(this.btnAltera);
			this.Controls.Add(this.btnExclui);
			this.Controls.Add(this.btnInclui);
			this.Controls.Add(this.dgvCadastro);
			this.Controls.Add(this.gbxFiltro);
			this.Controls.Add(this.mnuPagar);
			this.MainMenuStrip = this.mnuPagar;
			this.Name = "MainForm";
			this.Text = "Sistema SOFT  - Contas a Pagar - v2.1.1 (03/01/21)";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.Shown += new System.EventHandler(this.MainFormShown);
			this.Controls.SetChildIndex(this.mnuPagar, 0);
			this.Controls.SetChildIndex(this.gbxFiltro, 0);
			this.Controls.SetChildIndex(this.dgvCadastro, 0);
			this.Controls.SetChildIndex(this.btnInclui, 0);
			this.Controls.SetChildIndex(this.btnExclui, 0);
			this.Controls.SetChildIndex(this.btnAltera, 0);
			this.Controls.SetChildIndex(this.btnFecha, 0);
			this.Controls.SetChildIndex(this.lblRegistros, 0);
			this.Controls.SetChildIndex(this.btnLocaliza, 0);
			this.Controls.SetChildIndex(this.lblTotal, 0);
			this.Controls.SetChildIndex(this.edtLocaliza, 0);
			this.Controls.SetChildIndex(this.edtRegistros, 0);
			this.Controls.SetChildIndex(this.edtTotal, 0);
			this.Controls.SetChildIndex(this.edtObservacao, 0);
			this.Controls.SetChildIndex(this.btnPaga, 0);
			this.Controls.SetChildIndex(this.btnImprime, 0);
			this.Controls.SetChildIndex(this.edtDocGerado, 0);
			this.Controls.SetChildIndex(this.label7, 0);
			this.Controls.SetChildIndex(this.edtForma, 0);
			this.Controls.SetChildIndex(this.btnUp, 0);
			this.Controls.SetChildIndex(this.btnDown, 0);
			this.Controls.SetChildIndex(this.edtFixoVariavel, 0);
			this.Controls.SetChildIndex(this.edtTotalPago, 0);
			this.Controls.SetChildIndex(this.label8, 0);
			this.Controls.SetChildIndex(this.edtTotalPagar, 0);
			this.Controls.SetChildIndex(this.imgSoftplace, 0);
			((System.ComponentModel.ISupportInitialize)(this.imgSoftplace)).EndInit();
			this.mnuPagar.ResumeLayout(false);
			this.mnuPagar.PerformLayout();
			this.gbxFiltro.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.gbxPendencias.ResumeLayout(false);
			this.gbxPagamento.ResumeLayout(false);
			this.gbxVencimento.ResumeLayout(false);
			this.gbxParceiro.ResumeLayout(false);
			this.gbxParceiro.PerformLayout();
			this.gbxTipos.ResumeLayout(false);
			this.gbxForma.ResumeLayout(false);
			this.gbxNatureza.ResumeLayout(false);
			this.gbxSituacao.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvCadastro)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		public System.Windows.Forms.DateTimePicker dtpEmissaoF;
		public System.Windows.Forms.DateTimePicker dtpEmissaoI;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox chkTodas;
		private System.Windows.Forms.CheckedListBox clbFiltroNaturezas;
		public System.Windows.Forms.TextBox edtFixoVariavel;
		private System.Windows.Forms.ComboBox cbxFiltroPendencias;
		private System.Windows.Forms.GroupBox gbxPendencias;
		public System.Windows.Forms.ComboBox cbxCodPendencias;
		private System.Windows.Forms.Button btnUp;
		private System.Windows.Forms.Button btnDown;
		private System.Windows.Forms.ToolStripMenuItem mniFixoVariavel;
		private System.Windows.Forms.ToolStripMenuItem minTendencia;
		public System.Windows.Forms.TextBox edtForma;
		public System.Windows.Forms.TextBox edtDocGerado;
		public System.Windows.Forms.Button btnImprime;
		public System.Windows.Forms.Button btnPaga;
		public System.Windows.Forms.TextBox edtObservacao;
		private System.Windows.Forms.ToolStripMenuItem mniPendencias;
		private System.Windows.Forms.ToolStripMenuItem mniGraficoNatureza;
		private System.Windows.Forms.ToolStripMenuItem gráficosToolStripMenuItem;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Label lblRegistros;
		private System.Windows.Forms.TextBox edtRegistros;
		private System.Windows.Forms.TextBox edtTotal;
		public System.Windows.Forms.Button btnAplica;
		public System.Windows.Forms.Button btnLimpa;
		public System.Windows.Forms.DateTimePicker dtpVencimentoI;
		public System.Windows.Forms.DateTimePicker dtpVencimentoF;
		private System.Windows.Forms.GroupBox gbxVencimento;
		public System.Windows.Forms.DateTimePicker dtpPagamentoI;
		public System.Windows.Forms.DateTimePicker dtpPagamentoF;
		private System.Windows.Forms.GroupBox gbxPagamento;
		public System.Windows.Forms.TextBox edtParceiro;
		private System.Windows.Forms.Button btnParceiro;
		private System.Windows.Forms.GroupBox gbxParceiro;
		private System.Windows.Forms.GroupBox gbxTipos;
		private System.Windows.Forms.ComboBox cbxFiltroTipos;
		private System.Windows.Forms.ComboBox cbxFiltroFormas;
		private System.Windows.Forms.GroupBox gbxForma;
		public System.Windows.Forms.ComboBox cbxCodFormas;
		public System.Windows.Forms.ComboBox cbxCodNaturezas;
		private System.Windows.Forms.ComboBox cbxFiltroNaturezas;
		private System.Windows.Forms.GroupBox gbxNatureza;
		private System.Windows.Forms.GroupBox gbxSituacao;
		private System.Windows.Forms.ComboBox cbxFiltroSituacao;
		public System.Windows.Forms.Button btnFecha;
		public System.Windows.Forms.Button btnAltera;
		public System.Windows.Forms.Button btnExclui;
		public System.Windows.Forms.Button btnInclui;
		public System.Windows.Forms.Button btnLocaliza;
		public System.Windows.Forms.TextBox edtLocaliza;
		public System.Windows.Forms.DataGridView dgvCadastro;
		private System.Windows.Forms.GroupBox gbxFiltro;
		private System.Windows.Forms.ToolStripMenuItem formasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mniNaturezas;
		private System.Windows.Forms.ToolStripMenuItem mniSobre;
		private System.Windows.Forms.ToolStripMenuItem mniSair;
		private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
		private System.Windows.Forms.MenuStrip mnuPagar;
		private System.Windows.Forms.TextBox edtTotalPago;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox edtTotalPagar;
		private System.Windows.Forms.Label label8;
	}
}
