/*
 * Usuário: Ricardo
 * Data: 21/04/2008
 * Hora: 10:42
 * 
 */
namespace agenda
{
	partial class frmAgenda
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgenda));
			this.gbxFiltro = new System.Windows.Forms.GroupBox();
			this.chkApp = new System.Windows.Forms.CheckBox();
			this.gbxParceiro = new System.Windows.Forms.GroupBox();
			this.btnAplica = new System.Windows.Forms.Button();
			this.btnFiltroParceiro = new System.Windows.Forms.Button();
			this.edtFiltroParceiro = new System.Windows.Forms.TextBox();
			this.gbxNatureza = new System.Windows.Forms.GroupBox();
			this.cbxFiltroNaturezas = new System.Windows.Forms.ComboBox();
			this.gbxResponsavel = new System.Windows.Forms.GroupBox();
			this.cbxFiltroResponsaveis = new System.Windows.Forms.ComboBox();
			this.lblDataInicial = new System.Windows.Forms.Label();
			this.gbxPessoal = new System.Windows.Forms.GroupBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.cbxPessoal = new System.Windows.Forms.ComboBox();
			this.gbxUsuario = new System.Windows.Forms.GroupBox();
			this.cbxFiltroUsuarios = new System.Windows.Forms.ComboBox();
			this.calAgenda = new System.Windows.Forms.MonthCalendar();
			this.dtpAgenda = new System.Windows.Forms.DateTimePicker();
			this.lblParceiro = new System.Windows.Forms.Label();
			this.edtParceiro = new System.Windows.Forms.TextBox();
			this.btnParceiros = new System.Windows.Forms.Button();
			this.gbxPendencia = new System.Windows.Forms.GroupBox();
			this.edtPendencia = new System.Windows.Forms.TextBox();
			this.gbxSolucao = new System.Windows.Forms.GroupBox();
			this.btnApp = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.dtpEncerrado = new System.Windows.Forms.DateTimePicker();
			this.dtpSolucao = new System.Windows.Forms.DateTimePicker();
			this.edtSolucao = new System.Windows.Forms.TextBox();
			this.lblContato = new System.Windows.Forms.Label();
			this.edtContato = new System.Windows.Forms.TextBox();
			this.btnContatos = new System.Windows.Forms.Button();
			this.cbxUsuarios = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cbxPrioridades = new System.Windows.Forms.ComboBox();
			this.cbxNaturezas = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.gbxAnexos = new System.Windows.Forms.GroupBox();
			this.btnAbreAnexo = new System.Windows.Forms.Button();
			this.dgvAnexos = new System.Windows.Forms.DataGridView();
			this.linkLabel8 = new System.Windows.Forms.LinkLabel();
			this.linkLabel7 = new System.Windows.Forms.LinkLabel();
			this.linkLabel6 = new System.Windows.Forms.LinkLabel();
			this.linkLabel5 = new System.Windows.Forms.LinkLabel();
			this.linkLabel4 = new System.Windows.Forms.LinkLabel();
			this.linkLabel3 = new System.Windows.Forms.LinkLabel();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.btnCadAnexos = new System.Windows.Forms.Button();
			this.edtUsuario = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.ckbCancelado = new System.Windows.Forms.CheckBox();
			this.ckbPessoal = new System.Windows.Forms.CheckBox();
			this.dtpCodigo = new System.Windows.Forms.DateTimePicker();
			this.btnEmail = new System.Windows.Forms.Button();
			this.imgClientes = new System.Windows.Forms.PictureBox();
			this.btnImprime = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.pnlEdicao.SuspendLayout();
			this.gbxFiltro.SuspendLayout();
			this.gbxParceiro.SuspendLayout();
			this.gbxNatureza.SuspendLayout();
			this.gbxResponsavel.SuspendLayout();
			this.gbxPessoal.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.gbxUsuario.SuspendLayout();
			this.gbxPendencia.SuspendLayout();
			this.gbxSolucao.SuspendLayout();
			this.gbxAnexos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAnexos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgClientes)).BeginInit();
			this.SuspendLayout();
			// 
			// btnUp
			// 
			this.btnUp.Location = new System.Drawing.Point(610, 11);
			this.btnUp.Margin = new System.Windows.Forms.Padding(4);
			// 
			// btnDown
			// 
			this.btnDown.Location = new System.Drawing.Point(568, 11);
			this.btnDown.Margin = new System.Windows.Forms.Padding(4);
			// 
			// btnLocaliza
			// 
			this.btnLocaliza.Location = new System.Drawing.Point(462, 10);
			this.btnLocaliza.Margin = new System.Windows.Forms.Padding(4);
			// 
			// edtLocaliza
			// 
			this.edtLocaliza.Location = new System.Drawing.Point(262, 14);
			this.edtLocaliza.Margin = new System.Windows.Forms.Padding(4);
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(403, 376);
			this.btnCancela.Margin = new System.Windows.Forms.Padding(4);
			this.btnCancela.TabIndex = 20;
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(293, 376);
			this.btnConfirma.Margin = new System.Windows.Forms.Padding(4);
			this.btnConfirma.TabIndex = 19;
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// edtCodigo
			// 
			this.edtCodigo.Enabled = false;
			this.edtCodigo.Location = new System.Drawing.Point(330, 10);
			this.edtCodigo.Margin = new System.Windows.Forms.Padding(4);
			this.edtCodigo.Size = new System.Drawing.Size(139, 20);
			this.edtCodigo.TabIndex = 3;
			// 
			// edtDescricao
			// 
			this.edtDescricao.Location = new System.Drawing.Point(80, 40);
			this.edtDescricao.Margin = new System.Windows.Forms.Padding(4);
			this.edtDescricao.ReadOnly = true;
			this.edtDescricao.Size = new System.Drawing.Size(146, 20);
			this.edtDescricao.TabIndex = 1;
			this.edtDescricao.Visible = false;
			// 
			// lblCodigo
			// 
			this.lblCodigo.Location = new System.Drawing.Point(255, 10);
			this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCodigo.Size = new System.Drawing.Size(70, 20);
			// 
			// lblDescricao
			// 
			this.lblDescricao.Location = new System.Drawing.Point(268, 40);
			this.lblDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDescricao.Size = new System.Drawing.Size(60, 20);
			this.lblDescricao.Text = "Previsão";
			// 
			// pnlEdicao
			// 
			this.pnlEdicao.Controls.Add(this.dtpCodigo);
			this.pnlEdicao.Controls.Add(this.ckbPessoal);
			this.pnlEdicao.Controls.Add(this.ckbCancelado);
			this.pnlEdicao.Controls.Add(this.label4);
			this.pnlEdicao.Controls.Add(this.label3);
			this.pnlEdicao.Controls.Add(this.edtUsuario);
			this.pnlEdicao.Controls.Add(this.cbxNaturezas);
			this.pnlEdicao.Controls.Add(this.label2);
			this.pnlEdicao.Controls.Add(this.cbxPrioridades);
			this.pnlEdicao.Controls.Add(this.label1);
			this.pnlEdicao.Controls.Add(this.cbxUsuarios);
			this.pnlEdicao.Controls.Add(this.btnContatos);
			this.pnlEdicao.Controls.Add(this.edtContato);
			this.pnlEdicao.Controls.Add(this.lblContato);
			this.pnlEdicao.Controls.Add(this.gbxSolucao);
			this.pnlEdicao.Controls.Add(this.gbxPendencia);
			this.pnlEdicao.Controls.Add(this.btnParceiros);
			this.pnlEdicao.Controls.Add(this.edtParceiro);
			this.pnlEdicao.Controls.Add(this.lblParceiro);
			this.pnlEdicao.Controls.Add(this.dtpAgenda);
			this.pnlEdicao.Location = new System.Drawing.Point(262, 200);
			this.pnlEdicao.Margin = new System.Windows.Forms.Padding(4);
			this.pnlEdicao.Size = new System.Drawing.Size(525, 412);
			this.pnlEdicao.Controls.SetChildIndex(this.dtpAgenda, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblParceiro, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtParceiro, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.btnParceiros, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.gbxPendencia, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.gbxSolucao, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblContato, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtContato, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.btnContatos, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.cbxUsuarios, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.label1, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.cbxPrioridades, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.label2, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.cbxNaturezas, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtUsuario, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.label3, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.label4, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.ckbCancelado, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.ckbPessoal, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.dtpCodigo, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.btnConfirma, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.btnCancela, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblCodigo, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblDescricao, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtCodigo, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtDescricao, 0);
			// 
			// btnFecha
			// 
			this.btnFecha.Location = new System.Drawing.Point(795, 99);
			this.btnFecha.Margin = new System.Windows.Forms.Padding(4);
			this.btnFecha.Size = new System.Drawing.Size(140, 25);
			// 
			// btnAltera
			// 
			this.btnAltera.Location = new System.Drawing.Point(795, 69);
			this.btnAltera.Margin = new System.Windows.Forms.Padding(4);
			this.btnAltera.Size = new System.Drawing.Size(140, 25);
			this.btnAltera.Click += new System.EventHandler(this.BtnAlteraClick);
			// 
			// btnExclui
			// 
			this.btnExclui.Location = new System.Drawing.Point(795, 39);
			this.btnExclui.Margin = new System.Windows.Forms.Padding(4);
			this.btnExclui.Size = new System.Drawing.Size(140, 25);
			this.btnExclui.Click += new System.EventHandler(this.BtnExcluiClick);
			// 
			// btnInclui
			// 
			this.btnInclui.Location = new System.Drawing.Point(795, 9);
			this.btnInclui.Margin = new System.Windows.Forms.Padding(4);
			this.btnInclui.Size = new System.Drawing.Size(140, 25);
			this.btnInclui.Click += new System.EventHandler(this.BtnIncluiClick);
			// 
			// gbxFiltro
			// 
			this.gbxFiltro.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.gbxFiltro.Controls.Add(this.chkApp);
			this.gbxFiltro.Controls.Add(this.gbxParceiro);
			this.gbxFiltro.Controls.Add(this.gbxNatureza);
			this.gbxFiltro.Controls.Add(this.gbxResponsavel);
			this.gbxFiltro.Controls.Add(this.lblDataInicial);
			this.gbxFiltro.Controls.Add(this.gbxPessoal);
			this.gbxFiltro.Controls.Add(this.gbxUsuario);
			this.gbxFiltro.Controls.Add(this.calAgenda);
			this.gbxFiltro.Location = new System.Drawing.Point(10, 10);
			this.gbxFiltro.Name = "gbxFiltro";
			this.gbxFiltro.Size = new System.Drawing.Size(245, 590);
			this.gbxFiltro.TabIndex = 8;
			this.gbxFiltro.TabStop = false;
			this.gbxFiltro.Text = "Filtro";
			// 
			// chkApp
			// 
			this.chkApp.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkApp.Location = new System.Drawing.Point(16, 473);
			this.chkApp.Name = "chkApp";
			this.chkApp.Size = new System.Drawing.Size(133, 24);
			this.chkApp.TabIndex = 7;
			this.chkApp.Text = "Encerrados pelo APP";
			this.chkApp.UseVisualStyleBackColor = true;
			// 
			// gbxParceiro
			// 
			this.gbxParceiro.Controls.Add(this.btnAplica);
			this.gbxParceiro.Controls.Add(this.btnFiltroParceiro);
			this.gbxParceiro.Controls.Add(this.edtFiltroParceiro);
			this.gbxParceiro.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.gbxParceiro.Location = new System.Drawing.Point(10, 500);
			this.gbxParceiro.Name = "gbxParceiro";
			this.gbxParceiro.Size = new System.Drawing.Size(227, 84);
			this.gbxParceiro.TabIndex = 6;
			this.gbxParceiro.TabStop = false;
			this.gbxParceiro.Text = "Parceiro";
			// 
			// btnAplica
			// 
			this.btnAplica.BackColor = System.Drawing.SystemColors.Control;
			this.btnAplica.Location = new System.Drawing.Point(94, 46);
			this.btnAplica.Name = "btnAplica";
			this.btnAplica.Size = new System.Drawing.Size(100, 25);
			this.btnAplica.TabIndex = 2;
			this.btnAplica.Text = "Aplica";
			this.btnAplica.UseVisualStyleBackColor = false;
			this.btnAplica.Click += new System.EventHandler(this.BtnAplicaClick);
			// 
			// btnFiltroParceiro
			// 
			this.btnFiltroParceiro.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltroParceiro.Image")));
			this.btnFiltroParceiro.Location = new System.Drawing.Point(158, 17);
			this.btnFiltroParceiro.Name = "btnFiltroParceiro";
			this.btnFiltroParceiro.Size = new System.Drawing.Size(36, 23);
			this.btnFiltroParceiro.TabIndex = 1;
			this.btnFiltroParceiro.UseVisualStyleBackColor = true;
			this.btnFiltroParceiro.Click += new System.EventHandler(this.Button1Click);
			// 
			// edtFiltroParceiro
			// 
			this.edtFiltroParceiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtFiltroParceiro.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtFiltroParceiro.Location = new System.Drawing.Point(6, 19);
			this.edtFiltroParceiro.MaxLength = 20;
			this.edtFiltroParceiro.Name = "edtFiltroParceiro";
			this.edtFiltroParceiro.Size = new System.Drawing.Size(146, 20);
			this.edtFiltroParceiro.TabIndex = 0;
			// 
			// gbxNatureza
			// 
			this.gbxNatureza.Controls.Add(this.cbxFiltroNaturezas);
			this.gbxNatureza.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.gbxNatureza.Location = new System.Drawing.Point(10, 413);
			this.gbxNatureza.Name = "gbxNatureza";
			this.gbxNatureza.Size = new System.Drawing.Size(227, 54);
			this.gbxNatureza.TabIndex = 5;
			this.gbxNatureza.TabStop = false;
			this.gbxNatureza.Text = "Natureza";
			// 
			// cbxFiltroNaturezas
			// 
			this.cbxFiltroNaturezas.FormattingEnabled = true;
			this.cbxFiltroNaturezas.Location = new System.Drawing.Point(6, 19);
			this.cbxFiltroNaturezas.Name = "cbxFiltroNaturezas";
			this.cbxFiltroNaturezas.Size = new System.Drawing.Size(215, 21);
			this.cbxFiltroNaturezas.TabIndex = 1;
			this.cbxFiltroNaturezas.SelectedIndexChanged += new System.EventHandler(this.CbxFiltroNaturezasSelectedIndexChanged);
			// 
			// gbxResponsavel
			// 
			this.gbxResponsavel.Controls.Add(this.cbxFiltroResponsaveis);
			this.gbxResponsavel.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.gbxResponsavel.Location = new System.Drawing.Point(10, 276);
			this.gbxResponsavel.Name = "gbxResponsavel";
			this.gbxResponsavel.Size = new System.Drawing.Size(227, 54);
			this.gbxResponsavel.TabIndex = 2;
			this.gbxResponsavel.TabStop = false;
			this.gbxResponsavel.Text = "Responsável";
			// 
			// cbxFiltroResponsaveis
			// 
			this.cbxFiltroResponsaveis.FormattingEnabled = true;
			this.cbxFiltroResponsaveis.Location = new System.Drawing.Point(6, 19);
			this.cbxFiltroResponsaveis.Name = "cbxFiltroResponsaveis";
			this.cbxFiltroResponsaveis.Size = new System.Drawing.Size(215, 21);
			this.cbxFiltroResponsaveis.TabIndex = 0;
			this.cbxFiltroResponsaveis.SelectedIndexChanged += new System.EventHandler(this.CbxFiltroResponsaveisSelectedIndexChanged);
			// 
			// lblDataInicial
			// 
			this.lblDataInicial.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblDataInicial.Location = new System.Drawing.Point(10, 16);
			this.lblDataInicial.Name = "lblDataInicial";
			this.lblDataInicial.Size = new System.Drawing.Size(100, 23);
			this.lblDataInicial.TabIndex = 4;
			this.lblDataInicial.Text = "Data Inicial";
			this.lblDataInicial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// gbxPessoal
			// 
			this.gbxPessoal.Controls.Add(this.groupBox1);
			this.gbxPessoal.Controls.Add(this.cbxPessoal);
			this.gbxPessoal.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.gbxPessoal.Location = new System.Drawing.Point(10, 347);
			this.gbxPessoal.Name = "gbxPessoal";
			this.gbxPessoal.Size = new System.Drawing.Size(227, 54);
			this.gbxPessoal.TabIndex = 3;
			this.gbxPessoal.TabStop = false;
			this.gbxPessoal.Text = "Pessoal";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Location = new System.Drawing.Point(10, 100);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(227, 54);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Pessoal";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(6, 19);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(215, 21);
			this.comboBox1.TabIndex = 0;
			// 
			// cbxPessoal
			// 
			this.cbxPessoal.FormattingEnabled = true;
			this.cbxPessoal.Location = new System.Drawing.Point(6, 19);
			this.cbxPessoal.Name = "cbxPessoal";
			this.cbxPessoal.Size = new System.Drawing.Size(215, 21);
			this.cbxPessoal.TabIndex = 0;
			this.cbxPessoal.SelectedIndexChanged += new System.EventHandler(this.CbxPessoalSelectedIndexChanged);
			// 
			// gbxUsuario
			// 
			this.gbxUsuario.Controls.Add(this.cbxFiltroUsuarios);
			this.gbxUsuario.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.gbxUsuario.Location = new System.Drawing.Point(10, 209);
			this.gbxUsuario.Name = "gbxUsuario";
			this.gbxUsuario.Size = new System.Drawing.Size(227, 54);
			this.gbxUsuario.TabIndex = 1;
			this.gbxUsuario.TabStop = false;
			this.gbxUsuario.Text = "Usuário";
			// 
			// cbxFiltroUsuarios
			// 
			this.cbxFiltroUsuarios.FormattingEnabled = true;
			this.cbxFiltroUsuarios.Location = new System.Drawing.Point(6, 19);
			this.cbxFiltroUsuarios.Name = "cbxFiltroUsuarios";
			this.cbxFiltroUsuarios.Size = new System.Drawing.Size(215, 21);
			this.cbxFiltroUsuarios.TabIndex = 0;
			this.cbxFiltroUsuarios.SelectedIndexChanged += new System.EventHandler(this.CbxFiltroUsuariosSelectedIndexChanged);
			// 
			// calAgenda
			// 
			this.calAgenda.Location = new System.Drawing.Point(10, 40);
			this.calAgenda.Name = "calAgenda";
			this.calAgenda.TabIndex = 0;
			this.calAgenda.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.CalAgendaDateChanged);
			// 
			// dtpAgenda
			// 
			this.dtpAgenda.CustomFormat = "dd/MM/yyyy HH:mm:ss";
			this.dtpAgenda.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpAgenda.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpAgenda.Location = new System.Drawing.Point(333, 40);
			this.dtpAgenda.Name = "dtpAgenda";
			this.dtpAgenda.Size = new System.Drawing.Size(170, 20);
			this.dtpAgenda.TabIndex = 6;
			// 
			// lblParceiro
			// 
			this.lblParceiro.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblParceiro.Location = new System.Drawing.Point(10, 70);
			this.lblParceiro.Name = "lblParceiro";
			this.lblParceiro.Size = new System.Drawing.Size(60, 20);
			this.lblParceiro.TabIndex = 64;
			this.lblParceiro.Text = "Parceiro";
			this.lblParceiro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtParceiro
			// 
			this.edtParceiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtParceiro.Enabled = false;
			this.edtParceiro.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtParceiro.Location = new System.Drawing.Point(75, 70);
			this.edtParceiro.MaxLength = 20;
			this.edtParceiro.Name = "edtParceiro";
			this.edtParceiro.Size = new System.Drawing.Size(146, 20);
			this.edtParceiro.TabIndex = 7;
			this.edtParceiro.Leave += new System.EventHandler(this.EdtParceiroLeave);
			// 
			// btnParceiros
			// 
			this.btnParceiros.Image = ((System.Drawing.Image)(resources.GetObject("btnParceiros.Image")));
			this.btnParceiros.Location = new System.Drawing.Point(227, 69);
			this.btnParceiros.Name = "btnParceiros";
			this.btnParceiros.Size = new System.Drawing.Size(36, 23);
			this.btnParceiros.TabIndex = 8;
			this.btnParceiros.UseVisualStyleBackColor = true;
			this.btnParceiros.Click += new System.EventHandler(this.BtnParceirosClick);
			this.btnParceiros.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnParceirosMouseClick);
			// 
			// gbxPendencia
			// 
			this.gbxPendencia.Controls.Add(this.edtPendencia);
			this.gbxPendencia.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.gbxPendencia.Location = new System.Drawing.Point(10, 130);
			this.gbxPendencia.Name = "gbxPendencia";
			this.gbxPendencia.Size = new System.Drawing.Size(490, 114);
			this.gbxPendencia.TabIndex = 15;
			this.gbxPendencia.TabStop = false;
			this.gbxPendencia.Text = "Descrição";
			// 
			// edtPendencia
			// 
			this.edtPendencia.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtPendencia.Location = new System.Drawing.Point(14, 17);
			this.edtPendencia.Multiline = true;
			this.edtPendencia.Name = "edtPendencia";
			this.edtPendencia.Size = new System.Drawing.Size(470, 90);
			this.edtPendencia.TabIndex = 23;
			this.edtPendencia.DoubleClick += new System.EventHandler(this.EdtPendenciaDoubleClick);
			// 
			// gbxSolucao
			// 
			this.gbxSolucao.Controls.Add(this.btnApp);
			this.gbxSolucao.Controls.Add(this.label5);
			this.gbxSolucao.Controls.Add(this.dtpEncerrado);
			this.gbxSolucao.Controls.Add(this.dtpSolucao);
			this.gbxSolucao.Controls.Add(this.edtSolucao);
			this.gbxSolucao.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.gbxSolucao.Location = new System.Drawing.Point(10, 250);
			this.gbxSolucao.Name = "gbxSolucao";
			this.gbxSolucao.Size = new System.Drawing.Size(490, 110);
			this.gbxSolucao.TabIndex = 16;
			this.gbxSolucao.TabStop = false;
			this.gbxSolucao.Text = "Solução";
			// 
			// btnApp
			// 
			this.btnApp.Image = ((System.Drawing.Image)(resources.GetObject("btnApp.Image")));
			this.btnApp.Location = new System.Drawing.Point(452, 18);
			this.btnApp.Name = "btnApp";
			this.btnApp.Size = new System.Drawing.Size(36, 23);
			this.btnApp.TabIndex = 70;
			this.btnApp.UseVisualStyleBackColor = true;
			this.btnApp.Click += new System.EventHandler(this.BtnAppClick);
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label5.Location = new System.Drawing.Point(203, 19);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(60, 20);
			this.label5.TabIndex = 69;
			this.label5.Text = "Encerrado";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpEncerrado
			// 
			this.dtpEncerrado.Checked = false;
			this.dtpEncerrado.CustomFormat = "dd/MM/yyyy HH:mm:ss";
			this.dtpEncerrado.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpEncerrado.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpEncerrado.Location = new System.Drawing.Point(263, 19);
			this.dtpEncerrado.Name = "dtpEncerrado";
			this.dtpEncerrado.ShowCheckBox = true;
			this.dtpEncerrado.Size = new System.Drawing.Size(186, 20);
			this.dtpEncerrado.TabIndex = 2;
			// 
			// dtpSolucao
			// 
			this.dtpSolucao.CustomFormat = "dd/MM/yyyy HH:mm:ss";
			this.dtpSolucao.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpSolucao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpSolucao.Location = new System.Drawing.Point(14, 19);
			this.dtpSolucao.Name = "dtpSolucao";
			this.dtpSolucao.ShowCheckBox = true;
			this.dtpSolucao.Size = new System.Drawing.Size(186, 20);
			this.dtpSolucao.TabIndex = 0;
			// 
			// edtSolucao
			// 
			this.edtSolucao.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtSolucao.Location = new System.Drawing.Point(14, 45);
			this.edtSolucao.Multiline = true;
			this.edtSolucao.Name = "edtSolucao";
			this.edtSolucao.Size = new System.Drawing.Size(470, 60);
			this.edtSolucao.TabIndex = 1;
			this.edtSolucao.DoubleClick += new System.EventHandler(this.EdtSolucaoDoubleClick);
			// 
			// lblContato
			// 
			this.lblContato.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblContato.Location = new System.Drawing.Point(265, 70);
			this.lblContato.Name = "lblContato";
			this.lblContato.Size = new System.Drawing.Size(60, 20);
			this.lblContato.TabIndex = 65;
			this.lblContato.Text = "Contato";
			this.lblContato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtContato
			// 
			this.edtContato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtContato.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtContato.Location = new System.Drawing.Point(330, 70);
			this.edtContato.MaxLength = 20;
			this.edtContato.Name = "edtContato";
			this.edtContato.Size = new System.Drawing.Size(146, 20);
			this.edtContato.TabIndex = 9;
			this.edtContato.DoubleClick += new System.EventHandler(this.EdtContatoDoubleClick);
			// 
			// btnContatos
			// 
			this.btnContatos.Image = ((System.Drawing.Image)(resources.GetObject("btnContatos.Image")));
			this.btnContatos.Location = new System.Drawing.Point(482, 69);
			this.btnContatos.Name = "btnContatos";
			this.btnContatos.Size = new System.Drawing.Size(36, 23);
			this.btnContatos.TabIndex = 10;
			this.btnContatos.UseVisualStyleBackColor = true;
			this.btnContatos.Click += new System.EventHandler(this.BtnContatosClick);
			// 
			// cbxUsuarios
			// 
			this.cbxUsuarios.BackColor = System.Drawing.SystemColors.Window;
			this.cbxUsuarios.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxUsuarios.FormattingEnabled = true;
			this.cbxUsuarios.Location = new System.Drawing.Point(75, 40);
			this.cbxUsuarios.Name = "cbxUsuarios";
			this.cbxUsuarios.Size = new System.Drawing.Size(166, 22);
			this.cbxUsuarios.TabIndex = 5;
			this.cbxUsuarios.Text = "12345678901234567890";
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(10, 100);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 20);
			this.label1.TabIndex = 66;
			this.label1.Text = "Prioridade";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxPrioridades
			// 
			this.cbxPrioridades.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxPrioridades.FormattingEnabled = true;
			this.cbxPrioridades.Location = new System.Drawing.Point(75, 100);
			this.cbxPrioridades.Name = "cbxPrioridades";
			this.cbxPrioridades.Size = new System.Drawing.Size(130, 22);
			this.cbxPrioridades.TabIndex = 12;
			// 
			// cbxNaturezas
			// 
			this.cbxNaturezas.FormattingEnabled = true;
			this.cbxNaturezas.Location = new System.Drawing.Point(330, 100);
			this.cbxNaturezas.Name = "cbxNaturezas";
			this.cbxNaturezas.Size = new System.Drawing.Size(107, 21);
			this.cbxNaturezas.TabIndex = 13;
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label2.Location = new System.Drawing.Point(255, 100);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 20);
			this.label2.TabIndex = 68;
			this.label2.Text = "Natureza";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// gbxAnexos
			// 
			this.gbxAnexos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.gbxAnexos.Controls.Add(this.btnAbreAnexo);
			this.gbxAnexos.Controls.Add(this.dgvAnexos);
			this.gbxAnexos.Controls.Add(this.linkLabel8);
			this.gbxAnexos.Controls.Add(this.linkLabel7);
			this.gbxAnexos.Controls.Add(this.linkLabel6);
			this.gbxAnexos.Controls.Add(this.linkLabel5);
			this.gbxAnexos.Controls.Add(this.linkLabel4);
			this.gbxAnexos.Controls.Add(this.linkLabel3);
			this.gbxAnexos.Controls.Add(this.linkLabel2);
			this.gbxAnexos.Controls.Add(this.linkLabel1);
			this.gbxAnexos.Controls.Add(this.btnCadAnexos);
			this.gbxAnexos.Location = new System.Drawing.Point(788, 200);
			this.gbxAnexos.Name = "gbxAnexos";
			this.gbxAnexos.Size = new System.Drawing.Size(200, 412);
			this.gbxAnexos.TabIndex = 10;
			this.gbxAnexos.TabStop = false;
			this.gbxAnexos.Text = "Anexos";
			// 
			// btnAbreAnexo
			// 
			this.btnAbreAnexo.BackColor = System.Drawing.SystemColors.Control;
			this.btnAbreAnexo.Location = new System.Drawing.Point(6, 347);
			this.btnAbreAnexo.Name = "btnAbreAnexo";
			this.btnAbreAnexo.Size = new System.Drawing.Size(140, 25);
			this.btnAbreAnexo.TabIndex = 10;
			this.btnAbreAnexo.Text = "Abre";
			this.btnAbreAnexo.UseVisualStyleBackColor = false;
			this.btnAbreAnexo.Click += new System.EventHandler(this.BtnAbreAnexoClick);
			// 
			// dgvAnexos
			// 
			this.dgvAnexos.AllowUserToAddRows = false;
			this.dgvAnexos.AllowUserToDeleteRows = false;
			this.dgvAnexos.AllowUserToResizeColumns = false;
			this.dgvAnexos.AllowUserToResizeRows = false;
			this.dgvAnexos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAnexos.ColumnHeadersVisible = false;
			this.dgvAnexos.Location = new System.Drawing.Point(5, 19);
			this.dgvAnexos.Name = "dgvAnexos";
			this.dgvAnexos.RowHeadersVisible = false;
			this.dgvAnexos.Size = new System.Drawing.Size(138, 319);
			this.dgvAnexos.TabIndex = 9;
			// 
			// linkLabel8
			// 
			this.linkLabel8.Location = new System.Drawing.Point(6, 230);
			this.linkLabel8.Name = "linkLabel8";
			this.linkLabel8.Size = new System.Drawing.Size(150, 25);
			this.linkLabel8.TabIndex = 8;
			this.linkLabel8.TabStop = true;
			this.linkLabel8.Text = "linkLabel8";
			this.linkLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.linkLabel8.Visible = false;
			this.linkLabel8.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel8LinkClicked);
			// 
			// linkLabel7
			// 
			this.linkLabel7.Location = new System.Drawing.Point(6, 200);
			this.linkLabel7.Name = "linkLabel7";
			this.linkLabel7.Size = new System.Drawing.Size(150, 25);
			this.linkLabel7.TabIndex = 7;
			this.linkLabel7.TabStop = true;
			this.linkLabel7.Text = "linkLabel7";
			this.linkLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.linkLabel7.Visible = false;
			this.linkLabel7.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel7LinkClicked);
			// 
			// linkLabel6
			// 
			this.linkLabel6.Location = new System.Drawing.Point(5, 170);
			this.linkLabel6.Name = "linkLabel6";
			this.linkLabel6.Size = new System.Drawing.Size(150, 25);
			this.linkLabel6.TabIndex = 6;
			this.linkLabel6.TabStop = true;
			this.linkLabel6.Text = "linkLabel6";
			this.linkLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.linkLabel6.Visible = false;
			this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel6LinkClicked);
			// 
			// linkLabel5
			// 
			this.linkLabel5.Location = new System.Drawing.Point(5, 140);
			this.linkLabel5.Name = "linkLabel5";
			this.linkLabel5.Size = new System.Drawing.Size(150, 25);
			this.linkLabel5.TabIndex = 5;
			this.linkLabel5.TabStop = true;
			this.linkLabel5.Text = "linkLabel5";
			this.linkLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.linkLabel5.Visible = false;
			this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel5LinkClicked);
			// 
			// linkLabel4
			// 
			this.linkLabel4.Location = new System.Drawing.Point(5, 110);
			this.linkLabel4.Name = "linkLabel4";
			this.linkLabel4.Size = new System.Drawing.Size(150, 25);
			this.linkLabel4.TabIndex = 4;
			this.linkLabel4.TabStop = true;
			this.linkLabel4.Text = "linkLabel4";
			this.linkLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.linkLabel4.Visible = false;
			this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel4LinkClicked);
			// 
			// linkLabel3
			// 
			this.linkLabel3.Location = new System.Drawing.Point(5, 80);
			this.linkLabel3.Name = "linkLabel3";
			this.linkLabel3.Size = new System.Drawing.Size(150, 25);
			this.linkLabel3.TabIndex = 3;
			this.linkLabel3.TabStop = true;
			this.linkLabel3.Text = "linkLabel3";
			this.linkLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.linkLabel3.Visible = false;
			this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel3LinkClicked);
			// 
			// linkLabel2
			// 
			this.linkLabel2.Location = new System.Drawing.Point(5, 50);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(150, 25);
			this.linkLabel2.TabIndex = 2;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "linkLabel2";
			this.linkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.linkLabel2.Visible = false;
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel2LinkClicked);
			// 
			// linkLabel1
			// 
			this.linkLabel1.Location = new System.Drawing.Point(5, 20);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(150, 25);
			this.linkLabel1.TabIndex = 1;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "linkLabel1";
			this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.linkLabel1.Visible = false;
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
			// 
			// btnCadAnexos
			// 
			this.btnCadAnexos.BackColor = System.Drawing.SystemColors.Control;
			this.btnCadAnexos.Location = new System.Drawing.Point(5, 378);
			this.btnCadAnexos.Name = "btnCadAnexos";
			this.btnCadAnexos.Size = new System.Drawing.Size(140, 25);
			this.btnCadAnexos.TabIndex = 0;
			this.btnCadAnexos.Text = "Cadastro";
			this.btnCadAnexos.UseVisualStyleBackColor = false;
			this.btnCadAnexos.Click += new System.EventHandler(this.BtnCadAnexosClick);
			// 
			// edtUsuario
			// 
			this.edtUsuario.BackColor = System.Drawing.SystemColors.Info;
			this.edtUsuario.Enabled = false;
			this.edtUsuario.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtUsuario.Location = new System.Drawing.Point(75, 10);
			this.edtUsuario.MaxLength = 50;
			this.edtUsuario.Name = "edtUsuario";
			this.edtUsuario.Size = new System.Drawing.Size(146, 20);
			this.edtUsuario.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.Color.Red;
			this.label3.Location = new System.Drawing.Point(10, 10);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 20);
			this.label3.TabIndex = 72;
			this.label3.Text = "Usuário";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label4.Location = new System.Drawing.Point(0, 40);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 20);
			this.label4.TabIndex = 73;
			this.label4.Text = "Responsável";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ckbCancelado
			// 
			this.ckbCancelado.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.ckbCancelado.Location = new System.Drawing.Point(105, 376);
			this.ckbCancelado.Name = "ckbCancelado";
			this.ckbCancelado.Size = new System.Drawing.Size(100, 22);
			this.ckbCancelado.TabIndex = 18;
			this.ckbCancelado.Text = "Cancelado";
			this.ckbCancelado.UseVisualStyleBackColor = true;
			// 
			// ckbPessoal
			// 
			this.ckbPessoal.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.ckbPessoal.Location = new System.Drawing.Point(24, 376);
			this.ckbPessoal.Name = "ckbPessoal";
			this.ckbPessoal.Size = new System.Drawing.Size(70, 22);
			this.ckbPessoal.TabIndex = 17;
			this.ckbPessoal.Text = "Pessoal";
			this.ckbPessoal.UseVisualStyleBackColor = true;
			// 
			// dtpCodigo
			// 
			this.dtpCodigo.CustomFormat = "dd/MM/yyyy HH:mm:ss";
			this.dtpCodigo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpCodigo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpCodigo.Location = new System.Drawing.Point(330, 10);
			this.dtpCodigo.Name = "dtpCodigo";
			this.dtpCodigo.Size = new System.Drawing.Size(170, 20);
			this.dtpCodigo.TabIndex = 74;
			// 
			// btnEmail
			// 
			this.btnEmail.Image = ((System.Drawing.Image)(resources.GetObject("btnEmail.Image")));
			this.btnEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEmail.Location = new System.Drawing.Point(795, 129);
			this.btnEmail.Name = "btnEmail";
			this.btnEmail.Size = new System.Drawing.Size(140, 25);
			this.btnEmail.TabIndex = 7;
			this.btnEmail.Text = "email";
			this.btnEmail.UseVisualStyleBackColor = true;
			this.btnEmail.Click += new System.EventHandler(this.BtnEmailClick);
			// 
			// imgClientes
			// 
			this.imgClientes.Image = ((System.Drawing.Image)(resources.GetObject("imgClientes.Image")));
			this.imgClientes.Location = new System.Drawing.Point(652, 12);
			this.imgClientes.Name = "imgClientes";
			this.imgClientes.Size = new System.Drawing.Size(22, 22);
			this.imgClientes.TabIndex = 6;
			this.imgClientes.TabStop = false;
			this.imgClientes.Click += new System.EventHandler(this.ImgClientesClick);
			// 
			// btnImprime
			// 
			this.btnImprime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnImprime.Location = new System.Drawing.Point(795, 160);
			this.btnImprime.Name = "btnImprime";
			this.btnImprime.Size = new System.Drawing.Size(140, 25);
			this.btnImprime.TabIndex = 8;
			this.btnImprime.Text = "Imprime";
			this.btnImprime.UseVisualStyleBackColor = true;
			this.btnImprime.Click += new System.EventHandler(this.BtnImprimeClick);
			// 
			// frmAgenda
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(945, 614);
			this.Controls.Add(this.btnImprime);
			this.Controls.Add(this.btnEmail);
			this.Controls.Add(this.gbxAnexos);
			this.Controls.Add(this.gbxFiltro);
			this.Controls.Add(this.imgClientes);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "frmAgenda";
			this.Text = "Sistema SOFT - Agenda  - v2.4.0 (05/02/22)";
			this.Load += new System.EventHandler(this.FrmAgendaLoad);
			this.Controls.SetChildIndex(this.imgClientes, 0);
			this.Controls.SetChildIndex(this.btnDown, 0);
			this.Controls.SetChildIndex(this.btnUp, 0);
			this.Controls.SetChildIndex(this.gbxFiltro, 0);
			this.Controls.SetChildIndex(this.gbxAnexos, 0);
			this.Controls.SetChildIndex(this.btnEmail, 0);
			this.Controls.SetChildIndex(this.btnExclui, 0);
			this.Controls.SetChildIndex(this.btnInclui, 0);
			this.Controls.SetChildIndex(this.btnFecha, 0);
			this.Controls.SetChildIndex(this.btnAltera, 0);
			this.Controls.SetChildIndex(this.pnlEdicao, 0);
			this.Controls.SetChildIndex(this.edtLocaliza, 0);
			this.Controls.SetChildIndex(this.btnLocaliza, 0);
			this.Controls.SetChildIndex(this.btnImprime, 0);
			this.pnlEdicao.ResumeLayout(false);
			this.pnlEdicao.PerformLayout();
			this.gbxFiltro.ResumeLayout(false);
			this.gbxParceiro.ResumeLayout(false);
			this.gbxParceiro.PerformLayout();
			this.gbxNatureza.ResumeLayout(false);
			this.gbxResponsavel.ResumeLayout(false);
			this.gbxPessoal.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.gbxUsuario.ResumeLayout(false);
			this.gbxPendencia.ResumeLayout(false);
			this.gbxPendencia.PerformLayout();
			this.gbxSolucao.ResumeLayout(false);
			this.gbxSolucao.PerformLayout();
			this.gbxAnexos.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvAnexos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgClientes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.Button btnAbreAnexo;
		private System.Windows.Forms.Button btnImprime;
		private System.Windows.Forms.Button btnAplica;
		private System.Windows.Forms.Button btnFiltroParceiro;
		public System.Windows.Forms.TextBox edtFiltroParceiro;
		private System.Windows.Forms.GroupBox gbxParceiro;
		private System.Windows.Forms.ComboBox cbxFiltroNaturezas;
		private System.Windows.Forms.GroupBox gbxNatureza;
		private System.Windows.Forms.PictureBox imgClientes;
		private System.Windows.Forms.Button btnEmail;
		private System.Windows.Forms.ComboBox cbxFiltroResponsaveis;
		private System.Windows.Forms.GroupBox gbxResponsavel;
		private System.Windows.Forms.DateTimePicker dtpCodigo;
		private System.Windows.Forms.CheckBox ckbCancelado;
		private System.Windows.Forms.TextBox edtUsuario;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dgvAnexos;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.LinkLabel linkLabel3;
		private System.Windows.Forms.LinkLabel linkLabel4;
		private System.Windows.Forms.LinkLabel linkLabel5;
		private System.Windows.Forms.LinkLabel linkLabel6;
		private System.Windows.Forms.LinkLabel linkLabel7;
		private System.Windows.Forms.LinkLabel linkLabel8;
		private System.Windows.Forms.Button btnCadAnexos;
		private System.Windows.Forms.GroupBox gbxAnexos;
		private System.Windows.Forms.LinkLabel linkLabel2;
		private System.Windows.Forms.ComboBox cbxPrioridades;
		private System.Windows.Forms.ComboBox cbxNaturezas;
		private System.Windows.Forms.Button btnParceiros;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbxUsuarios;
		private System.Windows.Forms.ComboBox cbxFiltroUsuarios;
		private System.Windows.Forms.TextBox edtContato;
		private System.Windows.Forms.Button btnContatos;
		private System.Windows.Forms.Label lblContato;
		private System.Windows.Forms.Label lblDataInicial;
		private System.Windows.Forms.MonthCalendar calAgenda;
		private System.Windows.Forms.DateTimePicker dtpSolucao;
		private System.Windows.Forms.ComboBox cbxPessoal;
		private System.Windows.Forms.TextBox edtSolucao;
		private System.Windows.Forms.TextBox edtPendencia;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox gbxUsuario;
		private System.Windows.Forms.GroupBox gbxPessoal;
		private System.Windows.Forms.GroupBox gbxPendencia;
		private System.Windows.Forms.GroupBox gbxSolucao;
		private System.Windows.Forms.CheckBox ckbPessoal;
		private System.Windows.Forms.TextBox edtParceiro;
		private System.Windows.Forms.Label lblParceiro;
		private System.Windows.Forms.DateTimePicker dtpAgenda;
		private System.Windows.Forms.GroupBox gbxFiltro;
		private System.Windows.Forms.CheckBox chkApp;
		private System.Windows.Forms.Button btnApp;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dtpEncerrado;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}
