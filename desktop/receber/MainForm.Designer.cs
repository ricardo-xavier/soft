/*
 * Criado por SharpDevelop.
 * Usuário: Ricardo
 * Data: 20/07/2008
 * Hora: 9:30
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace receber
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
			this.mnuXeceber = new System.Windows.Forms.MenuStrip();
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
			this.lblPedido = new System.Windows.Forms.Label();
			this.edtPedidoFiltro = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cbxFiltroCancelados = new System.Windows.Forms.ComboBox();
			this.cbxCodPendencias = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cbxFiltroPendencias = new System.Windows.Forms.ComboBox();
			this.btnLimpa = new System.Windows.Forms.Button();
			this.btnAplica = new System.Windows.Forms.Button();
			this.gbxVencimento = new System.Windows.Forms.GroupBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label2 = new System.Windows.Forms.Label();
			this.dtpVencimentoI = new System.Windows.Forms.DateTimePicker();
			this.dtpVencimentoF = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label3 = new System.Windows.Forms.Label();
			this.dtpRecebimentoI = new System.Windows.Forms.DateTimePicker();
			this.dtpRecebimentoF = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.label7 = new System.Windows.Forms.Label();
			this.dtpEmissaoI = new System.Windows.Forms.DateTimePicker();
			this.dtpEmissaoF = new System.Windows.Forms.DateTimePicker();
			this.label8 = new System.Windows.Forms.Label();
			this.gbxParceiro = new System.Windows.Forms.GroupBox();
			this.btnCliente = new System.Windows.Forms.Button();
			this.edtParceiro = new System.Windows.Forms.TextBox();
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
			this.btnRecebe = new System.Windows.Forms.Button();
			this.btnImprime = new System.Windows.Forms.Button();
			this.edtForma = new System.Windows.Forms.TextBox();
			this.btnUp = new System.Windows.Forms.Button();
			this.btnDown = new System.Windows.Forms.Button();
			this.edtFixoVariavel = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.edtPedido = new System.Windows.Forms.TextBox();
			this.edtTotalRecebido = new System.Windows.Forms.TextBox();
			this.edtTotalReceber = new System.Windows.Forms.TextBox();
			this.lblTotalRecebido = new System.Windows.Forms.Label();
			this.lblTotalReceber = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.imgSoftplace)).BeginInit();
			this.mnuXeceber.SuspendLayout();
			this.gbxFiltro.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.gbxVencimento.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.gbxParceiro.SuspendLayout();
			this.gbxForma.SuspendLayout();
			this.gbxNatureza.SuspendLayout();
			this.gbxSituacao.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCadastro)).BeginInit();
			this.SuspendLayout();
			// 
			// imgSoftplace
			// 
			this.imgSoftplace.Location = new System.Drawing.Point(420, 59);
			// 
			// mnuXeceber
			// 
			this.mnuXeceber.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.arquivoToolStripMenuItem,
			this.cadastroToolStripMenuItem,
			this.gráficosToolStripMenuItem,
			this.ajudaToolStripMenuItem});
			this.mnuXeceber.Location = new System.Drawing.Point(0, 0);
			this.mnuXeceber.Name = "mnuXeceber";
			this.mnuXeceber.Size = new System.Drawing.Size(988, 24);
			this.mnuXeceber.TabIndex = 3;
			this.mnuXeceber.Text = "menuStrip1";
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
			this.gbxFiltro.Controls.Add(this.lblPedido);
			this.gbxFiltro.Controls.Add(this.edtPedidoFiltro);
			this.gbxFiltro.Controls.Add(this.groupBox2);
			this.gbxFiltro.Controls.Add(this.cbxCodPendencias);
			this.gbxFiltro.Controls.Add(this.groupBox1);
			this.gbxFiltro.Controls.Add(this.btnLimpa);
			this.gbxFiltro.Controls.Add(this.btnAplica);
			this.gbxFiltro.Controls.Add(this.gbxVencimento);
			this.gbxFiltro.Controls.Add(this.gbxParceiro);
			this.gbxFiltro.Controls.Add(this.cbxCodFormas);
			this.gbxFiltro.Controls.Add(this.gbxForma);
			this.gbxFiltro.Controls.Add(this.cbxCodNaturezas);
			this.gbxFiltro.Controls.Add(this.gbxNatureza);
			this.gbxFiltro.Controls.Add(this.gbxSituacao);
			this.gbxFiltro.Location = new System.Drawing.Point(10, 30);
			this.gbxFiltro.Name = "gbxFiltro";
			this.gbxFiltro.Size = new System.Drawing.Size(245, 590);
			this.gbxFiltro.TabIndex = 0;
			this.gbxFiltro.TabStop = false;
			this.gbxFiltro.Text = "Filtro";
			// 
			// lblPedido
			// 
			this.lblPedido.Location = new System.Drawing.Point(0, 533);
			this.lblPedido.Name = "lblPedido";
			this.lblPedido.Size = new System.Drawing.Size(50, 23);
			this.lblPedido.TabIndex = 19;
			this.lblPedido.Text = "Pedido";
			this.lblPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtPedidoFiltro
			// 
			this.edtPedidoFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtPedidoFiltro.Enabled = false;
			this.edtPedidoFiltro.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtPedidoFiltro.Location = new System.Drawing.Point(53, 534);
			this.edtPedidoFiltro.MaxLength = 20;
			this.edtPedidoFiltro.Name = "edtPedidoFiltro";
			this.edtPedidoFiltro.Size = new System.Drawing.Size(184, 20);
			this.edtPedidoFiltro.TabIndex = 131;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cbxFiltroCancelados);
			this.groupBox2.Location = new System.Drawing.Point(10, 313);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(227, 42);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Cancelamento";
			// 
			// cbxFiltroCancelados
			// 
			this.cbxFiltroCancelados.FormattingEnabled = true;
			this.cbxFiltroCancelados.Location = new System.Drawing.Point(7, 16);
			this.cbxFiltroCancelados.Name = "cbxFiltroCancelados";
			this.cbxFiltroCancelados.Size = new System.Drawing.Size(215, 21);
			this.cbxFiltroCancelados.TabIndex = 0;
			// 
			// cbxCodPendencias
			// 
			this.cbxCodPendencias.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxCodPendencias.FormattingEnabled = true;
			this.cbxCodPendencias.Location = new System.Drawing.Point(6, 523);
			this.cbxCodPendencias.Name = "cbxCodPendencias";
			this.cbxCodPendencias.Size = new System.Drawing.Size(166, 22);
			this.cbxCodPendencias.TabIndex = 130;
			this.cbxCodPendencias.Visible = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cbxFiltroPendencias);
			this.groupBox1.Location = new System.Drawing.Point(10, 265);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(227, 45);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Pendência";
			// 
			// cbxFiltroPendencias
			// 
			this.cbxFiltroPendencias.FormattingEnabled = true;
			this.cbxFiltroPendencias.Location = new System.Drawing.Point(6, 19);
			this.cbxFiltroPendencias.Name = "cbxFiltroPendencias";
			this.cbxFiltroPendencias.Size = new System.Drawing.Size(215, 21);
			this.cbxFiltroPendencias.TabIndex = 0;
			// 
			// btnLimpa
			// 
			this.btnLimpa.Location = new System.Drawing.Point(131, 559);
			this.btnLimpa.Name = "btnLimpa";
			this.btnLimpa.Size = new System.Drawing.Size(100, 25);
			this.btnLimpa.TabIndex = 9;
			this.btnLimpa.Text = "&Limpa";
			this.btnLimpa.UseVisualStyleBackColor = true;
			this.btnLimpa.Click += new System.EventHandler(this.BtnLimpaClick);
			// 
			// btnAplica
			// 
			this.btnAplica.Location = new System.Drawing.Point(25, 559);
			this.btnAplica.Name = "btnAplica";
			this.btnAplica.Size = new System.Drawing.Size(100, 25);
			this.btnAplica.TabIndex = 8;
			this.btnAplica.Text = "&Aplica";
			this.btnAplica.UseVisualStyleBackColor = true;
			this.btnAplica.Click += new System.EventHandler(this.BtnAplicaClick);
			// 
			// gbxVencimento
			// 
			this.gbxVencimento.Controls.Add(this.tabControl1);
			this.gbxVencimento.Location = new System.Drawing.Point(10, 406);
			this.gbxVencimento.Name = "gbxVencimento";
			this.gbxVencimento.Size = new System.Drawing.Size(227, 120);
			this.gbxVencimento.TabIndex = 6;
			this.gbxVencimento.TabStop = false;
			this.gbxVencimento.Text = "Filtros por Datas";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new System.Drawing.Point(15, 19);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(200, 89);
			this.tabControl1.TabIndex = 19;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.dtpVencimentoI);
			this.tabPage1.Controls.Add(this.dtpVencimentoF);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(192, 63);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Vencimento";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 23);
			this.label2.TabIndex = 18;
			this.label2.Text = "Final";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpVencimentoI
			// 
			this.dtpVencimentoI.CustomFormat = "dd/MM/yyyy";
			this.dtpVencimentoI.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpVencimentoI.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpVencimentoI.Location = new System.Drawing.Point(54, 10);
			this.dtpVencimentoI.Name = "dtpVencimentoI";
			this.dtpVencimentoI.ShowCheckBox = true;
			this.dtpVencimentoI.Size = new System.Drawing.Size(110, 20);
			this.dtpVencimentoI.TabIndex = 15;
			// 
			// dtpVencimentoF
			// 
			this.dtpVencimentoF.CustomFormat = "dd/MM/yyyy";
			this.dtpVencimentoF.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpVencimentoF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpVencimentoF.Location = new System.Drawing.Point(54, 33);
			this.dtpVencimentoF.Name = "dtpVencimentoF";
			this.dtpVencimentoF.ShowCheckBox = true;
			this.dtpVencimentoF.Size = new System.Drawing.Size(110, 20);
			this.dtpVencimentoF.TabIndex = 17;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 23);
			this.label1.TabIndex = 16;
			this.label1.Text = "Inicial";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Controls.Add(this.dtpRecebimentoI);
			this.tabPage2.Controls.Add(this.dtpRecebimentoF);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(192, 63);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Recebimento";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(13, 31);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 23);
			this.label3.TabIndex = 18;
			this.label3.Text = "Final";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpRecebimentoI
			// 
			this.dtpRecebimentoI.CustomFormat = "dd/MM/yyyy";
			this.dtpRecebimentoI.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpRecebimentoI.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpRecebimentoI.Location = new System.Drawing.Point(54, 10);
			this.dtpRecebimentoI.Name = "dtpRecebimentoI";
			this.dtpRecebimentoI.ShowCheckBox = true;
			this.dtpRecebimentoI.Size = new System.Drawing.Size(110, 20);
			this.dtpRecebimentoI.TabIndex = 15;
			// 
			// dtpRecebimentoF
			// 
			this.dtpRecebimentoF.CustomFormat = "dd/MM/yyyy";
			this.dtpRecebimentoF.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpRecebimentoF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpRecebimentoF.Location = new System.Drawing.Point(54, 33);
			this.dtpRecebimentoF.Name = "dtpRecebimentoF";
			this.dtpRecebimentoF.ShowCheckBox = true;
			this.dtpRecebimentoF.Size = new System.Drawing.Size(110, 20);
			this.dtpRecebimentoF.TabIndex = 17;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(13, 8);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 23);
			this.label4.TabIndex = 16;
			this.label4.Text = "Inicial";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.label7);
			this.tabPage3.Controls.Add(this.dtpEmissaoI);
			this.tabPage3.Controls.Add(this.dtpEmissaoF);
			this.tabPage3.Controls.Add(this.label8);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(192, 63);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Emissão";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(21, 31);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(35, 23);
			this.label7.TabIndex = 22;
			this.label7.Text = "Final";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpEmissaoI
			// 
			this.dtpEmissaoI.CustomFormat = "dd/MM/yyyy";
			this.dtpEmissaoI.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpEmissaoI.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpEmissaoI.Location = new System.Drawing.Point(62, 10);
			this.dtpEmissaoI.Name = "dtpEmissaoI";
			this.dtpEmissaoI.ShowCheckBox = true;
			this.dtpEmissaoI.Size = new System.Drawing.Size(110, 20);
			this.dtpEmissaoI.TabIndex = 19;
			// 
			// dtpEmissaoF
			// 
			this.dtpEmissaoF.CustomFormat = "dd/MM/yyyy";
			this.dtpEmissaoF.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpEmissaoF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpEmissaoF.Location = new System.Drawing.Point(62, 33);
			this.dtpEmissaoF.Name = "dtpEmissaoF";
			this.dtpEmissaoF.ShowCheckBox = true;
			this.dtpEmissaoF.Size = new System.Drawing.Size(110, 20);
			this.dtpEmissaoF.TabIndex = 21;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(21, 8);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(35, 23);
			this.label8.TabIndex = 20;
			this.label8.Text = "Inicial";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// gbxParceiro
			// 
			this.gbxParceiro.Controls.Add(this.btnCliente);
			this.gbxParceiro.Controls.Add(this.edtParceiro);
			this.gbxParceiro.Location = new System.Drawing.Point(10, 358);
			this.gbxParceiro.Name = "gbxParceiro";
			this.gbxParceiro.Size = new System.Drawing.Size(227, 44);
			this.gbxParceiro.TabIndex = 5;
			this.gbxParceiro.TabStop = false;
			this.gbxParceiro.Text = "Cliente";
			// 
			// btnCliente
			// 
			this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
			this.btnCliente.Location = new System.Drawing.Point(160, 17);
			this.btnCliente.Name = "btnCliente";
			this.btnCliente.Size = new System.Drawing.Size(36, 23);
			this.btnCliente.TabIndex = 1;
			this.btnCliente.UseVisualStyleBackColor = true;
			this.btnCliente.Click += new System.EventHandler(this.BtnClienteClick);
			// 
			// edtParceiro
			// 
			this.edtParceiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtParceiro.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtParceiro.Location = new System.Drawing.Point(6, 19);
			this.edtParceiro.MaxLength = 20;
			this.edtParceiro.Name = "edtParceiro";
			this.edtParceiro.Size = new System.Drawing.Size(146, 20);
			this.edtParceiro.TabIndex = 0;
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
			this.gbxForma.Location = new System.Drawing.Point(10, 217);
			this.gbxForma.Name = "gbxForma";
			this.gbxForma.Size = new System.Drawing.Size(227, 46);
			this.gbxForma.TabIndex = 2;
			this.gbxForma.TabStop = false;
			this.gbxForma.Text = "Forma";
			// 
			// cbxFiltroFormas
			// 
			this.cbxFiltroFormas.FormattingEnabled = true;
			this.cbxFiltroFormas.Location = new System.Drawing.Point(6, 19);
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
			this.gbxNatureza.Location = new System.Drawing.Point(10, 69);
			this.gbxNatureza.Name = "gbxNatureza";
			this.gbxNatureza.Size = new System.Drawing.Size(227, 142);
			this.gbxNatureza.TabIndex = 1;
			this.gbxNatureza.TabStop = false;
			this.gbxNatureza.Text = "Natureza";
			// 
			// chkTodas
			// 
			this.chkTodas.Checked = true;
			this.chkTodas.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkTodas.Location = new System.Drawing.Point(78, 115);
			this.chkTodas.Name = "chkTodas";
			this.chkTodas.Size = new System.Drawing.Size(143, 24);
			this.chkTodas.TabIndex = 132;
			this.chkTodas.Text = "Marca/Desmarca Todas";
			this.chkTodas.UseVisualStyleBackColor = true;
			this.chkTodas.CheckedChanged += new System.EventHandler(this.ChkTodasCheckedChanged);
			// 
			// clbFiltroNaturezas
			// 
			this.clbFiltroNaturezas.FormattingEnabled = true;
			this.clbFiltroNaturezas.Location = new System.Drawing.Point(6, 19);
			this.clbFiltroNaturezas.Name = "clbFiltroNaturezas";
			this.clbFiltroNaturezas.ScrollAlwaysVisible = true;
			this.clbFiltroNaturezas.Size = new System.Drawing.Size(216, 94);
			this.clbFiltroNaturezas.TabIndex = 84;
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
			this.gbxSituacao.Location = new System.Drawing.Point(10, 13);
			this.gbxSituacao.Name = "gbxSituacao";
			this.gbxSituacao.Size = new System.Drawing.Size(227, 50);
			this.gbxSituacao.TabIndex = 0;
			this.gbxSituacao.TabStop = false;
			this.gbxSituacao.Text = "Situação";
			// 
			// cbxFiltroSituacao
			// 
			this.cbxFiltroSituacao.FormattingEnabled = true;
			this.cbxFiltroSituacao.Location = new System.Drawing.Point(6, 19);
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
			this.dgvCadastro.Size = new System.Drawing.Size(722, 420);
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
			this.btnInclui.Location = new System.Drawing.Point(564, 592);
			this.btnInclui.Name = "btnInclui";
			this.btnInclui.Size = new System.Drawing.Size(100, 25);
			this.btnInclui.TabIndex = 6;
			this.btnInclui.Text = "&Inclui";
			this.btnInclui.UseVisualStyleBackColor = true;
			this.btnInclui.Click += new System.EventHandler(this.BtnIncluiClick);
			// 
			// btnExclui
			// 
			this.btnExclui.Location = new System.Drawing.Point(670, 592);
			this.btnExclui.Name = "btnExclui";
			this.btnExclui.Size = new System.Drawing.Size(100, 25);
			this.btnExclui.TabIndex = 7;
			this.btnExclui.Text = "&Exclui";
			this.btnExclui.UseVisualStyleBackColor = true;
			this.btnExclui.Click += new System.EventHandler(this.BtnExcluiClick);
			// 
			// btnAltera
			// 
			this.btnAltera.Location = new System.Drawing.Point(776, 592);
			this.btnAltera.Name = "btnAltera";
			this.btnAltera.Size = new System.Drawing.Size(100, 25);
			this.btnAltera.TabIndex = 8;
			this.btnAltera.Text = "&Altera";
			this.btnAltera.UseVisualStyleBackColor = true;
			this.btnAltera.Click += new System.EventHandler(this.BtnAlteraClick);
			// 
			// btnFecha
			// 
			this.btnFecha.Location = new System.Drawing.Point(882, 592);
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
			this.edtTotal.Location = new System.Drawing.Point(840, 518);
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
			this.edtRegistros.Location = new System.Drawing.Point(840, 492);
			this.edtRegistros.Name = "edtRegistros";
			this.edtRegistros.ReadOnly = true;
			this.edtRegistros.Size = new System.Drawing.Size(48, 20);
			this.edtRegistros.TabIndex = 75;
			this.edtRegistros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lblRegistros
			// 
			this.lblRegistros.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblRegistros.Location = new System.Drawing.Point(708, 491);
			this.lblRegistros.Name = "lblRegistros";
			this.lblRegistros.Size = new System.Drawing.Size(126, 20);
			this.lblRegistros.TabIndex = 74;
			this.lblRegistros.Text = "Títulos Selecionados";
			this.lblRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblTotal
			// 
			this.lblTotal.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblTotal.Location = new System.Drawing.Point(764, 517);
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
			// btnRecebe
			// 
			this.btnRecebe.Location = new System.Drawing.Point(461, 592);
			this.btnRecebe.Name = "btnRecebe";
			this.btnRecebe.Size = new System.Drawing.Size(100, 25);
			this.btnRecebe.TabIndex = 5;
			this.btnRecebe.Text = "&Recebe";
			this.btnRecebe.UseVisualStyleBackColor = true;
			this.btnRecebe.Click += new System.EventHandler(this.BtnRecebeClick);
			// 
			// btnImprime
			// 
			this.btnImprime.Location = new System.Drawing.Point(355, 592);
			this.btnImprime.Name = "btnImprime";
			this.btnImprime.Size = new System.Drawing.Size(100, 25);
			this.btnImprime.TabIndex = 4;
			this.btnImprime.Text = "I&mprime";
			this.btnImprime.UseVisualStyleBackColor = true;
			this.btnImprime.Click += new System.EventHandler(this.BtnImprimeClick);
			// 
			// edtForma
			// 
			this.edtForma.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtForma.Enabled = false;
			this.edtForma.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtForma.Location = new System.Drawing.Point(363, 536);
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
			this.edtFixoVariavel.Location = new System.Drawing.Point(619, 536);
			this.edtFixoVariavel.MaxLength = 50;
			this.edtFixoVariavel.Name = "edtFixoVariavel";
			this.edtFixoVariavel.Size = new System.Drawing.Size(67, 20);
			this.edtFixoVariavel.TabIndex = 80;
			this.edtFixoVariavel.Text = "VARIÁVEL";
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label5.Location = new System.Drawing.Point(260, 536);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 20);
			this.label5.TabIndex = 81;
			this.label5.Text = "Forma Recebto";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label6.Location = new System.Drawing.Point(260, 561);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 20);
			this.label6.TabIndex = 82;
			this.label6.Text = "Pedido";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtPedido
			// 
			this.edtPedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtPedido.Enabled = false;
			this.edtPedido.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtPedido.Location = new System.Drawing.Point(363, 562);
			this.edtPedido.MaxLength = 50;
			this.edtPedido.Name = "edtPedido";
			this.edtPedido.Size = new System.Drawing.Size(323, 20);
			this.edtPedido.TabIndex = 83;
			// 
			// edtTotalRecebido
			// 
			this.edtTotalRecebido.BackColor = System.Drawing.SystemColors.Info;
			this.edtTotalRecebido.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtTotalRecebido.Location = new System.Drawing.Point(840, 544);
			this.edtTotalRecebido.Name = "edtTotalRecebido";
			this.edtTotalRecebido.ReadOnly = true;
			this.edtTotalRecebido.Size = new System.Drawing.Size(90, 20);
			this.edtTotalRecebido.TabIndex = 84;
			this.edtTotalRecebido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// edtTotalReceber
			// 
			this.edtTotalReceber.BackColor = System.Drawing.SystemColors.Info;
			this.edtTotalReceber.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtTotalReceber.Location = new System.Drawing.Point(840, 570);
			this.edtTotalReceber.Name = "edtTotalReceber";
			this.edtTotalReceber.ReadOnly = true;
			this.edtTotalReceber.Size = new System.Drawing.Size(90, 20);
			this.edtTotalReceber.TabIndex = 84;
			this.edtTotalReceber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lblTotalRecebido
			// 
			this.lblTotalRecebido.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblTotalRecebido.Location = new System.Drawing.Point(747, 543);
			this.lblTotalRecebido.Name = "lblTotalRecebido";
			this.lblTotalRecebido.Size = new System.Drawing.Size(87, 20);
			this.lblTotalRecebido.TabIndex = 85;
			this.lblTotalRecebido.Text = "Total Recebido";
			this.lblTotalRecebido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblTotalReceber
			// 
			this.lblTotalReceber.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblTotalReceber.Location = new System.Drawing.Point(747, 569);
			this.lblTotalReceber.Name = "lblTotalReceber";
			this.lblTotalReceber.Size = new System.Drawing.Size(87, 20);
			this.lblTotalReceber.TabIndex = 85;
			this.lblTotalReceber.Text = "Total a Receber";
			this.lblTotalReceber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.ClientSize = new System.Drawing.Size(988, 644);
			this.Controls.Add(this.edtTotalReceber);
			this.Controls.Add(this.edtTotalRecebido);
			this.Controls.Add(this.lblTotalReceber);
			this.Controls.Add(this.lblTotalRecebido);
			this.Controls.Add(this.edtPedido);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.edtFixoVariavel);
			this.Controls.Add(this.btnDown);
			this.Controls.Add(this.btnUp);
			this.Controls.Add(this.edtForma);
			this.Controls.Add(this.btnImprime);
			this.Controls.Add(this.btnRecebe);
			this.Controls.Add(this.edtObservacao);
			this.Controls.Add(this.edtTotal);
			this.Controls.Add(this.edtRegistros);
			this.Controls.Add(this.lblRegistros);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.edtLocaliza);
			this.Controls.Add(this.btnLocaliza);
			this.Controls.Add(this.btnFecha);
			this.Controls.Add(this.btnAltera);
			this.Controls.Add(this.btnExclui);
			this.Controls.Add(this.btnInclui);
			this.Controls.Add(this.dgvCadastro);
			this.Controls.Add(this.gbxFiltro);
			this.Controls.Add(this.mnuXeceber);
			this.MainMenuStrip = this.mnuXeceber;
			this.Name = "MainForm";
			this.Text = "Sistema SOFT - Faturamento - v2.1.0 (14/08/21))";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.Shown += new System.EventHandler(this.MainFormShown);
			this.Controls.SetChildIndex(this.mnuXeceber, 0);
			this.Controls.SetChildIndex(this.gbxFiltro, 0);
			this.Controls.SetChildIndex(this.dgvCadastro, 0);
			this.Controls.SetChildIndex(this.btnInclui, 0);
			this.Controls.SetChildIndex(this.btnExclui, 0);
			this.Controls.SetChildIndex(this.btnAltera, 0);
			this.Controls.SetChildIndex(this.btnFecha, 0);
			this.Controls.SetChildIndex(this.btnLocaliza, 0);
			this.Controls.SetChildIndex(this.edtLocaliza, 0);
			this.Controls.SetChildIndex(this.lblTotal, 0);
			this.Controls.SetChildIndex(this.lblRegistros, 0);
			this.Controls.SetChildIndex(this.edtRegistros, 0);
			this.Controls.SetChildIndex(this.edtTotal, 0);
			this.Controls.SetChildIndex(this.edtObservacao, 0);
			this.Controls.SetChildIndex(this.btnRecebe, 0);
			this.Controls.SetChildIndex(this.btnImprime, 0);
			this.Controls.SetChildIndex(this.edtForma, 0);
			this.Controls.SetChildIndex(this.btnUp, 0);
			this.Controls.SetChildIndex(this.btnDown, 0);
			this.Controls.SetChildIndex(this.imgSoftplace, 0);
			this.Controls.SetChildIndex(this.edtFixoVariavel, 0);
			this.Controls.SetChildIndex(this.label5, 0);
			this.Controls.SetChildIndex(this.label6, 0);
			this.Controls.SetChildIndex(this.edtPedido, 0);
			this.Controls.SetChildIndex(this.lblTotalRecebido, 0);
			this.Controls.SetChildIndex(this.lblTotalReceber, 0);
			this.Controls.SetChildIndex(this.edtTotalRecebido, 0);
			this.Controls.SetChildIndex(this.edtTotalReceber, 0);
			((System.ComponentModel.ISupportInitialize)(this.imgSoftplace)).EndInit();
			this.mnuXeceber.ResumeLayout(false);
			this.mnuXeceber.PerformLayout();
			this.gbxFiltro.ResumeLayout(false);
			this.gbxFiltro.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.gbxVencimento.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.gbxParceiro.ResumeLayout(false);
			this.gbxParceiro.PerformLayout();
			this.gbxForma.ResumeLayout(false);
			this.gbxNatureza.ResumeLayout(false);
			this.gbxSituacao.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvCadastro)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.Label lblTotalRecebido;
		private System.Windows.Forms.Label lblTotalReceber;
		private System.Windows.Forms.TextBox edtTotalRecebido;
		private System.Windows.Forms.TextBox edtTotalReceber;
		public System.Windows.Forms.DateTimePicker dtpEmissaoI;
		public System.Windows.Forms.DateTimePicker dtpEmissaoF;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.CheckBox chkTodas;
		private System.Windows.Forms.CheckedListBox clbFiltroNaturezas;
		public System.Windows.Forms.TextBox edtPedidoFiltro;
		private System.Windows.Forms.Label lblPedido;
		public System.Windows.Forms.TextBox edtPedido;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.TextBox edtFixoVariavel;
		private System.Windows.Forms.Button btnCliente;
		private System.Windows.Forms.ComboBox cbxFiltroCancelados;
		private System.Windows.Forms.GroupBox groupBox2;
		public System.Windows.Forms.ComboBox cbxCodPendencias;
		private System.Windows.Forms.ComboBox cbxFiltroPendencias;
		private System.Windows.Forms.GroupBox groupBox1;
		public System.Windows.Forms.DateTimePicker dtpRecebimentoF;
		public System.Windows.Forms.DateTimePicker dtpRecebimentoI;
		public System.Windows.Forms.Button btnRecebe;
		private System.Windows.Forms.Button btnUp;
		private System.Windows.Forms.Button btnDown;
		private System.Windows.Forms.ToolStripMenuItem mniFixoVariavel;
		private System.Windows.Forms.ToolStripMenuItem minTendencia;
		public System.Windows.Forms.TextBox edtForma;
		public System.Windows.Forms.Button btnImprime;
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
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.DateTimePicker dtpVencimentoF;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox gbxVencimento;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.TextBox edtParceiro;
		private System.Windows.Forms.GroupBox gbxParceiro;
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
		private System.Windows.Forms.MenuStrip mnuXeceber;
	}
}
