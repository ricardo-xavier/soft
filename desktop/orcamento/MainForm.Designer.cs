/*
 * Criado por SharpDevelop.
 * Usuário: Ricardo
 * Data: 24/05/2008
 * Hora: 20:09
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace orcamento
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.dgvCadastro = new System.Windows.Forms.DataGridView();
			this.btnInclui = new System.Windows.Forms.Button();
			this.btnExclui = new System.Windows.Forms.Button();
			this.btnAltera = new System.Windows.Forms.Button();
			this.btnItens = new System.Windows.Forms.Button();
			this.btnFecha = new System.Windows.Forms.Button();
			this.edtResumo = new System.Windows.Forms.TextBox();
			this.lblResumo = new System.Windows.Forms.Label();
			this.lblObservacao = new System.Windows.Forms.Label();
			this.edtObservacao = new System.Windows.Forms.TextBox();
			this.lblTotal = new System.Windows.Forms.Label();
			this.lblRegistros = new System.Windows.Forms.Label();
			this.edtRegistros = new System.Windows.Forms.TextBox();
			this.btnCliente = new System.Windows.Forms.Button();
			this.btnFornecedor = new System.Windows.Forms.Button();
			this.btnConsultor = new System.Windows.Forms.Button();
			this.edtTotal = new System.Windows.Forms.TextBox();
			this.btnGera = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.edtTabela = new System.Windows.Forms.TextBox();
			this.gbxAnexos = new System.Windows.Forms.GroupBox();
			this.btnAbrirAnexo = new System.Windows.Forms.Button();
			this.dgvAnexos = new System.Windows.Forms.DataGridView();
			this.linkLabel3 = new System.Windows.Forms.LinkLabel();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.btnCadAnexos = new System.Windows.Forms.Button();
			this.btnCopia = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.edtPerComissao = new System.Windows.Forms.TextBox();
			this.edtVlrComissao = new System.Windows.Forms.TextBox();
			this.edtUsuario = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.dtpData = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.btnProdutos = new System.Windows.Forms.Button();
			this.btnPedido = new System.Windows.Forms.Button();
			this.cbxSituacoes = new System.Windows.Forms.ComboBox();
			this.edtCaracteristica = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnDown = new System.Windows.Forms.Button();
			this.btnUp = new System.Windows.Forms.Button();
			this.label16 = new System.Windows.Forms.Label();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.btnFiltro = new System.Windows.Forms.Button();
			this.edtLocaliza = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.edtRacional = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvCadastro)).BeginInit();
			this.gbxAnexos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAnexos)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvCadastro
			// 
			this.dgvCadastro.AllowUserToAddRows = false;
			this.dgvCadastro.AllowUserToDeleteRows = false;
			this.dgvCadastro.AllowUserToResizeColumns = false;
			this.dgvCadastro.AllowUserToResizeRows = false;
			this.dgvCadastro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvCadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvCadastro.DefaultCellStyle = dataGridViewCellStyle1;
			this.dgvCadastro.Location = new System.Drawing.Point(12, 39);
			this.dgvCadastro.MultiSelect = false;
			this.dgvCadastro.Name = "dgvCadastro";
			this.dgvCadastro.RowHeadersVisible = false;
			this.dgvCadastro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCadastro.Size = new System.Drawing.Size(910, 396);
			this.dgvCadastro.TabIndex = 6;
			this.dgvCadastro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCadastroCellClick);
			this.dgvCadastro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCadastroCellContentClick);
			this.dgvCadastro.CurrentCellDirtyStateChanged += new System.EventHandler(this.DgvCadastroCurrentCellDirtyStateChanged);
			this.dgvCadastro.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCadastroRowEnter);
			this.dgvCadastro.Sorted += new System.EventHandler(this.DgvCadastroSorted);
			// 
			// btnInclui
			// 
			this.btnInclui.Location = new System.Drawing.Point(175, 653);
			this.btnInclui.Name = "btnInclui";
			this.btnInclui.Size = new System.Drawing.Size(100, 25);
			this.btnInclui.TabIndex = 7;
			this.btnInclui.Text = "&Inclui";
			this.btnInclui.UseVisualStyleBackColor = true;
			this.btnInclui.Click += new System.EventHandler(this.BtnIncluiClick);
			// 
			// btnExclui
			// 
			this.btnExclui.Location = new System.Drawing.Point(281, 653);
			this.btnExclui.Name = "btnExclui";
			this.btnExclui.Size = new System.Drawing.Size(100, 25);
			this.btnExclui.TabIndex = 8;
			this.btnExclui.Text = "&Exclui";
			this.btnExclui.UseVisualStyleBackColor = true;
			this.btnExclui.Click += new System.EventHandler(this.BtnExcluiClick);
			// 
			// btnAltera
			// 
			this.btnAltera.Location = new System.Drawing.Point(387, 653);
			this.btnAltera.Name = "btnAltera";
			this.btnAltera.Size = new System.Drawing.Size(100, 25);
			this.btnAltera.TabIndex = 9;
			this.btnAltera.Text = "&Altera";
			this.btnAltera.UseVisualStyleBackColor = true;
			this.btnAltera.Click += new System.EventHandler(this.BtnAlteraClick);
			// 
			// btnItens
			// 
			this.btnItens.Location = new System.Drawing.Point(493, 653);
			this.btnItens.Name = "btnItens";
			this.btnItens.Size = new System.Drawing.Size(100, 25);
			this.btnItens.TabIndex = 10;
			this.btnItens.Text = "I&tens";
			this.btnItens.UseVisualStyleBackColor = true;
			this.btnItens.Click += new System.EventHandler(this.BtnItensClick);
			// 
			// btnFecha
			// 
			this.btnFecha.Location = new System.Drawing.Point(819, 653);
			this.btnFecha.Name = "btnFecha";
			this.btnFecha.Size = new System.Drawing.Size(100, 25);
			this.btnFecha.TabIndex = 13;
			this.btnFecha.Text = "&Fecha";
			this.btnFecha.UseVisualStyleBackColor = true;
			this.btnFecha.Click += new System.EventHandler(this.BtnFechaClick);
			// 
			// edtResumo
			// 
			this.edtResumo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtResumo.Location = new System.Drawing.Point(88, 463);
			this.edtResumo.Name = "edtResumo";
			this.edtResumo.ReadOnly = true;
			this.edtResumo.Size = new System.Drawing.Size(426, 20);
			this.edtResumo.TabIndex = 13;
			// 
			// lblResumo
			// 
			this.lblResumo.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblResumo.Location = new System.Drawing.Point(11, 463);
			this.lblResumo.Name = "lblResumo";
			this.lblResumo.Size = new System.Drawing.Size(70, 20);
			this.lblResumo.TabIndex = 66;
			this.lblResumo.Text = "Resumo";
			this.lblResumo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblObservacao
			// 
			this.lblObservacao.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblObservacao.Location = new System.Drawing.Point(11, 493);
			this.lblObservacao.Name = "lblObservacao";
			this.lblObservacao.Size = new System.Drawing.Size(70, 20);
			this.lblObservacao.TabIndex = 67;
			this.lblObservacao.Text = "Observação";
			this.lblObservacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtObservacao
			// 
			this.edtObservacao.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtObservacao.Location = new System.Drawing.Point(88, 494);
			this.edtObservacao.Multiline = true;
			this.edtObservacao.Name = "edtObservacao";
			this.edtObservacao.ReadOnly = true;
			this.edtObservacao.Size = new System.Drawing.Size(426, 60);
			this.edtObservacao.TabIndex = 68;
			this.edtObservacao.DoubleClick += new System.EventHandler(this.EdtObservacaoDoubleClick);
			// 
			// lblTotal
			// 
			this.lblTotal.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblTotal.Location = new System.Drawing.Point(728, 463);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(70, 20);
			this.lblTotal.TabIndex = 69;
			this.lblTotal.Text = "Total";
			this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblRegistros
			// 
			this.lblRegistros.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblRegistros.Location = new System.Drawing.Point(726, 493);
			this.lblRegistros.Name = "lblRegistros";
			this.lblRegistros.Size = new System.Drawing.Size(70, 20);
			this.lblRegistros.TabIndex = 70;
			this.lblRegistros.Text = "Registros";
			this.lblRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtRegistros
			// 
			this.edtRegistros.BackColor = System.Drawing.SystemColors.Info;
			this.edtRegistros.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtRegistros.Location = new System.Drawing.Point(804, 493);
			this.edtRegistros.Name = "edtRegistros";
			this.edtRegistros.ReadOnly = true;
			this.edtRegistros.Size = new System.Drawing.Size(115, 20);
			this.edtRegistros.TabIndex = 71;
			this.edtRegistros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btnCliente
			// 
			this.btnCliente.Location = new System.Drawing.Point(608, 7);
			this.btnCliente.Name = "btnCliente";
			this.btnCliente.Size = new System.Drawing.Size(100, 25);
			this.btnCliente.TabIndex = 4;
			this.btnCliente.Text = "Cliente";
			this.btnCliente.UseVisualStyleBackColor = true;
			this.btnCliente.Click += new System.EventHandler(this.BtnClienteClick);
			// 
			// btnFornecedor
			// 
			this.btnFornecedor.Location = new System.Drawing.Point(502, 7);
			this.btnFornecedor.Name = "btnFornecedor";
			this.btnFornecedor.Size = new System.Drawing.Size(100, 25);
			this.btnFornecedor.TabIndex = 3;
			this.btnFornecedor.Text = "Fornecedor";
			this.btnFornecedor.UseVisualStyleBackColor = true;
			this.btnFornecedor.Click += new System.EventHandler(this.BtnFornecedorClick);
			// 
			// btnConsultor
			// 
			this.btnConsultor.Location = new System.Drawing.Point(714, 7);
			this.btnConsultor.Name = "btnConsultor";
			this.btnConsultor.Size = new System.Drawing.Size(100, 25);
			this.btnConsultor.TabIndex = 5;
			this.btnConsultor.Text = "Consultor";
			this.btnConsultor.UseVisualStyleBackColor = true;
			this.btnConsultor.Click += new System.EventHandler(this.BtnConsultorClick);
			// 
			// edtTotal
			// 
			this.edtTotal.BackColor = System.Drawing.SystemColors.Info;
			this.edtTotal.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtTotal.Location = new System.Drawing.Point(804, 463);
			this.edtTotal.Name = "edtTotal";
			this.edtTotal.ReadOnly = true;
			this.edtTotal.Size = new System.Drawing.Size(115, 20);
			this.edtTotal.TabIndex = 6;
			this.edtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btnGera
			// 
			this.btnGera.Location = new System.Drawing.Point(599, 653);
			this.btnGera.Name = "btnGera";
			this.btnGera.Size = new System.Drawing.Size(100, 25);
			this.btnGera.TabIndex = 11;
			this.btnGera.Text = "I&mprime";
			this.btnGera.UseVisualStyleBackColor = true;
			this.btnGera.Click += new System.EventHandler(this.BtnGeraClick);
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(11, 593);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 20);
			this.label1.TabIndex = 72;
			this.label1.Text = "Tabela";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtTabela
			// 
			this.edtTabela.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtTabela.Location = new System.Drawing.Point(89, 593);
			this.edtTabela.Name = "edtTabela";
			this.edtTabela.ReadOnly = true;
			this.edtTabela.Size = new System.Drawing.Size(146, 20);
			this.edtTabela.TabIndex = 73;
			// 
			// gbxAnexos
			// 
			this.gbxAnexos.BackColor = System.Drawing.SystemColors.Control;
			this.gbxAnexos.Controls.Add(this.btnAbrirAnexo);
			this.gbxAnexos.Controls.Add(this.dgvAnexos);
			this.gbxAnexos.Controls.Add(this.linkLabel3);
			this.gbxAnexos.Controls.Add(this.linkLabel2);
			this.gbxAnexos.Controls.Add(this.linkLabel1);
			this.gbxAnexos.Controls.Add(this.btnCadAnexos);
			this.gbxAnexos.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.gbxAnexos.Location = new System.Drawing.Point(529, 442);
			this.gbxAnexos.Name = "gbxAnexos";
			this.gbxAnexos.Size = new System.Drawing.Size(200, 155);
			this.gbxAnexos.TabIndex = 117;
			this.gbxAnexos.TabStop = false;
			this.gbxAnexos.Text = "Anexos";
			// 
			// btnAbrirAnexo
			// 
			this.btnAbrirAnexo.BackColor = System.Drawing.SystemColors.Control;
			this.btnAbrirAnexo.ForeColor = System.Drawing.SystemColors.InfoText;
			this.btnAbrirAnexo.Location = new System.Drawing.Point(7, 118);
			this.btnAbrirAnexo.Name = "btnAbrirAnexo";
			this.btnAbrirAnexo.Size = new System.Drawing.Size(83, 25);
			this.btnAbrirAnexo.TabIndex = 11;
			this.btnAbrirAnexo.Text = "Abre";
			this.btnAbrirAnexo.UseVisualStyleBackColor = false;
			this.btnAbrirAnexo.Click += new System.EventHandler(this.BtnAbrirAnexoClick);
			// 
			// dgvAnexos
			// 
			this.dgvAnexos.AllowUserToAddRows = false;
			this.dgvAnexos.AllowUserToDeleteRows = false;
			this.dgvAnexos.AllowUserToOrderColumns = true;
			this.dgvAnexos.AllowUserToResizeColumns = false;
			this.dgvAnexos.AllowUserToResizeRows = false;
			this.dgvAnexos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAnexos.ColumnHeadersVisible = false;
			this.dgvAnexos.Location = new System.Drawing.Point(5, 19);
			this.dgvAnexos.Name = "dgvAnexos";
			this.dgvAnexos.RowHeadersVisible = false;
			this.dgvAnexos.Size = new System.Drawing.Size(188, 92);
			this.dgvAnexos.TabIndex = 9;
			this.dgvAnexos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAnexosCellDoubleClick);
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
			this.btnCadAnexos.ForeColor = System.Drawing.SystemColors.InfoText;
			this.btnCadAnexos.Location = new System.Drawing.Point(96, 118);
			this.btnCadAnexos.Name = "btnCadAnexos";
			this.btnCadAnexos.Size = new System.Drawing.Size(83, 25);
			this.btnCadAnexos.TabIndex = 0;
			this.btnCadAnexos.Text = "Cadastro";
			this.btnCadAnexos.UseVisualStyleBackColor = false;
			this.btnCadAnexos.Click += new System.EventHandler(this.BtnCadAnexosClick);
			// 
			// btnCopia
			// 
			this.btnCopia.Location = new System.Drawing.Point(705, 653);
			this.btnCopia.Name = "btnCopia";
			this.btnCopia.Size = new System.Drawing.Size(100, 25);
			this.btnCopia.TabIndex = 118;
			this.btnCopia.Text = "&Copia";
			this.btnCopia.UseVisualStyleBackColor = true;
			this.btnCopia.Click += new System.EventHandler(this.BtnCopiaClick);
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label2.Location = new System.Drawing.Point(308, 593);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 20);
			this.label2.TabIndex = 119;
			this.label2.Text = "CV";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtPerComissao
			// 
			this.edtPerComissao.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtPerComissao.Location = new System.Drawing.Point(384, 593);
			this.edtPerComissao.Name = "edtPerComissao";
			this.edtPerComissao.ReadOnly = true;
			this.edtPerComissao.Size = new System.Drawing.Size(41, 20);
			this.edtPerComissao.TabIndex = 120;
			this.edtPerComissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// edtVlrComissao
			// 
			this.edtVlrComissao.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtVlrComissao.Location = new System.Drawing.Point(437, 593);
			this.edtVlrComissao.Name = "edtVlrComissao";
			this.edtVlrComissao.ReadOnly = true;
			this.edtVlrComissao.Size = new System.Drawing.Size(77, 20);
			this.edtVlrComissao.TabIndex = 121;
			this.edtVlrComissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// edtUsuario
			// 
			this.edtUsuario.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtUsuario.Location = new System.Drawing.Point(368, 563);
			this.edtUsuario.Name = "edtUsuario";
			this.edtUsuario.ReadOnly = true;
			this.edtUsuario.Size = new System.Drawing.Size(146, 20);
			this.edtUsuario.TabIndex = 123;
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label3.Location = new System.Drawing.Point(11, 563);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 20);
			this.label3.TabIndex = 122;
			this.label3.Text = "Alteração";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpData
			// 
			this.dtpData.CustomFormat = "dd/MM/yyyy HH:mm:ss";
			this.dtpData.Enabled = false;
			this.dtpData.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpData.Location = new System.Drawing.Point(89, 563);
			this.dtpData.Name = "dtpData";
			this.dtpData.Size = new System.Drawing.Size(170, 20);
			this.dtpData.TabIndex = 124;
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label4.Location = new System.Drawing.Point(292, 563);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 20);
			this.label4.TabIndex = 125;
			this.label4.Text = "Usuário";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnProdutos
			// 
			this.btnProdutos.Location = new System.Drawing.Point(820, 7);
			this.btnProdutos.Name = "btnProdutos";
			this.btnProdutos.Size = new System.Drawing.Size(100, 25);
			this.btnProdutos.TabIndex = 126;
			this.btnProdutos.Text = "Preços";
			this.btnProdutos.UseVisualStyleBackColor = true;
			this.btnProdutos.Click += new System.EventHandler(this.BtnProdutosClick);
			// 
			// btnPedido
			// 
			this.btnPedido.Location = new System.Drawing.Point(819, 622);
			this.btnPedido.Name = "btnPedido";
			this.btnPedido.Size = new System.Drawing.Size(100, 25);
			this.btnPedido.TabIndex = 127;
			this.btnPedido.Text = "&Gera Pedido";
			this.btnPedido.UseVisualStyleBackColor = true;
			this.btnPedido.Click += new System.EventHandler(this.BtnPedidoClick);
			// 
			// cbxSituacoes
			// 
			this.cbxSituacoes.FormattingEnabled = true;
			this.cbxSituacoes.Location = new System.Drawing.Point(426, 149);
			this.cbxSituacoes.Name = "cbxSituacoes";
			this.cbxSituacoes.Size = new System.Drawing.Size(121, 21);
			this.cbxSituacoes.TabIndex = 128;
			this.cbxSituacoes.Visible = false;
			// 
			// edtCaracteristica
			// 
			this.edtCaracteristica.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtCaracteristica.Location = new System.Drawing.Point(88, 623);
			this.edtCaracteristica.Name = "edtCaracteristica";
			this.edtCaracteristica.ReadOnly = true;
			this.edtCaracteristica.Size = new System.Drawing.Size(146, 20);
			this.edtCaracteristica.TabIndex = 130;
			this.edtCaracteristica.MouseEnter += new System.EventHandler(this.EdtCaracteristicaMouseEnter);
			this.edtCaracteristica.MouseLeave += new System.EventHandler(this.EdtCaracteristicaMouseLeave);
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label5.Location = new System.Drawing.Point(6, 623);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(75, 20);
			this.label5.TabIndex = 129;
			this.label5.Text = "Característica";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnDown
			// 
			this.btnDown.Image = ((System.Drawing.Image)(resources.GetObject("btnDown.Image")));
			this.btnDown.Location = new System.Drawing.Point(282, 8);
			this.btnDown.Name = "btnDown";
			this.btnDown.Size = new System.Drawing.Size(36, 25);
			this.btnDown.TabIndex = 160;
			this.btnDown.UseVisualStyleBackColor = true;
			this.btnDown.Click += new System.EventHandler(this.BtnDownClick);
			// 
			// btnUp
			// 
			this.btnUp.Image = ((System.Drawing.Image)(resources.GetObject("btnUp.Image")));
			this.btnUp.Location = new System.Drawing.Point(322, 8);
			this.btnUp.Name = "btnUp";
			this.btnUp.Size = new System.Drawing.Size(36, 25);
			this.btnUp.TabIndex = 161;
			this.btnUp.UseVisualStyleBackColor = true;
			this.btnUp.Click += new System.EventHandler(this.BtnUpClick);
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(14, 9);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(60, 20);
			this.label16.TabIndex = 159;
			this.label16.Text = "Localiza";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnRefresh
			// 
			this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
			this.btnRefresh.Location = new System.Drawing.Point(405, 8);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(36, 25);
			this.btnRefresh.TabIndex = 156;
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.BtnRefreshClick);
			// 
			// btnFiltro
			// 
			this.btnFiltro.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltro.Image")));
			this.btnFiltro.Location = new System.Drawing.Point(365, 8);
			this.btnFiltro.Name = "btnFiltro";
			this.btnFiltro.Size = new System.Drawing.Size(36, 25);
			this.btnFiltro.TabIndex = 157;
			this.btnFiltro.UseVisualStyleBackColor = true;
			this.btnFiltro.Click += new System.EventHandler(this.BtnFiltroClick);
			// 
			// edtLocaliza
			// 
			this.edtLocaliza.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtLocaliza.Location = new System.Drawing.Point(80, 10);
			this.edtLocaliza.MaxLength = 30;
			this.edtLocaliza.Name = "edtLocaliza";
			this.edtLocaliza.Size = new System.Drawing.Size(195, 20);
			this.edtLocaliza.TabIndex = 155;
			this.edtLocaliza.TextChanged += new System.EventHandler(this.EdtLocalizaTextChanged);
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.Red;
			this.label13.Location = new System.Drawing.Point(11, 442);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(461, 18);
			this.label13.TabIndex = 162;
			this.label13.Text = "Marque as caixas de checagem para selecionar orçamentos para impressão consolidad" +
	"a";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// edtRacional
			// 
			this.edtRacional.BackColor = System.Drawing.SystemColors.Info;
			this.edtRacional.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtRacional.Location = new System.Drawing.Point(174, 320);
			this.edtRacional.Multiline = true;
			this.edtRacional.Name = "edtRacional";
			this.edtRacional.Size = new System.Drawing.Size(546, 240);
			this.edtRacional.TabIndex = 163;
			this.edtRacional.Visible = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(934, 682);
			this.Controls.Add(this.edtRacional);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.btnDown);
			this.Controls.Add(this.btnUp);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.btnFiltro);
			this.Controls.Add(this.edtLocaliza);
			this.Controls.Add(this.edtCaracteristica);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cbxSituacoes);
			this.Controls.Add(this.btnPedido);
			this.Controls.Add(this.btnProdutos);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dtpData);
			this.Controls.Add(this.edtUsuario);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.edtVlrComissao);
			this.Controls.Add(this.edtPerComissao);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.gbxAnexos);
			this.Controls.Add(this.edtTabela);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnGera);
			this.Controls.Add(this.edtTotal);
			this.Controls.Add(this.btnConsultor);
			this.Controls.Add(this.btnFornecedor);
			this.Controls.Add(this.btnCliente);
			this.Controls.Add(this.edtRegistros);
			this.Controls.Add(this.lblRegistros);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.edtObservacao);
			this.Controls.Add(this.lblObservacao);
			this.Controls.Add(this.lblResumo);
			this.Controls.Add(this.edtResumo);
			this.Controls.Add(this.btnFecha);
			this.Controls.Add(this.btnItens);
			this.Controls.Add(this.btnAltera);
			this.Controls.Add(this.btnExclui);
			this.Controls.Add(this.btnInclui);
			this.Controls.Add(this.btnCopia);
			this.Controls.Add(this.dgvCadastro);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sistema SOFT - Orçamento - v2.9.0 (10/04/22)";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgvCadastro)).EndInit();
			this.gbxAnexos.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvAnexos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		public System.Windows.Forms.Button btnAbrirAnexo;
		private System.Windows.Forms.Label label16;
		public System.Windows.Forms.Button btnUp;
		public System.Windows.Forms.Button btnDown;
		private System.Windows.Forms.Label label13;
		public System.Windows.Forms.TextBox edtRacional;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox edtCaracteristica;
		private System.Windows.Forms.ComboBox cbxSituacoes;
		private System.Windows.Forms.Button btnRefresh;
		public System.Windows.Forms.Button btnPedido;
		public System.Windows.Forms.Button btnProdutos;
		private System.Windows.Forms.TextBox edtUsuario;
		private System.Windows.Forms.Label label4;
		public System.Windows.Forms.DateTimePicker dtpData;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox edtPerComissao;
		private System.Windows.Forms.TextBox edtVlrComissao;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.Button button1;		
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.LinkLabel linkLabel2;
		private System.Windows.Forms.LinkLabel linkLabel3;
		private System.Windows.Forms.DataGridView dgvAnexos;
		private System.Windows.Forms.GroupBox gbxAnexos;
		private System.Windows.Forms.TextBox edtTabela;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.Button btnGera;
		private System.Windows.Forms.TextBox edtTotal;
		public System.Windows.Forms.Button btnFornecedor;
		public System.Windows.Forms.Button btnConsultor;
		public System.Windows.Forms.Button btnCliente;
		public System.Windows.Forms.Button btnExclui;
		public System.Windows.Forms.Button btnAltera;
		public System.Windows.Forms.Button btnItens;
		public System.Windows.Forms.Button btnFecha;
		private System.Windows.Forms.Button btnFiltro;
		private System.Windows.Forms.Label lblObservacao;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Label lblRegistros;
		private System.Windows.Forms.TextBox edtRegistros;
		private System.Windows.Forms.TextBox edtResumo;
		private System.Windows.Forms.TextBox edtObservacao;
		private System.Windows.Forms.Label lblResumo;
		public System.Windows.Forms.Button btnInclui;
		public System.Windows.Forms.TextBox edtLocaliza;
		public System.Windows.Forms.DataGridView dgvCadastro;
		public System.Windows.Forms.Button btnCadAnexos;
		public System.Windows.Forms.Button btnCopia;
	}
}
