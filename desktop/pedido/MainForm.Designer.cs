/*
 * Criado por SharpDevelop.
 * Usuário: Ricardo
 * Data: 04/02/2009
 * Hora: 21:19
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace pedido
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnFiltro = new System.Windows.Forms.Button();
			this.btnFecha = new System.Windows.Forms.Button();
			this.btnAltera = new System.Windows.Forms.Button();
			this.btnExclui = new System.Windows.Forms.Button();
			this.edtLocaliza = new System.Windows.Forms.TextBox();
			this.dgvCadastro = new System.Windows.Forms.DataGridView();
			this.edtObservacao = new System.Windows.Forms.TextBox();
			this.lblObservacao = new System.Windows.Forms.Label();
			this.gbxEntrega = new System.Windows.Forms.GroupBox();
			this.chkEntregaReal = new System.Windows.Forms.CheckBox();
			this.chkEntregaPrevista = new System.Windows.Forms.CheckBox();
			this.dtpEntregaReal = new System.Windows.Forms.DateTimePicker();
			this.dtpEntregaPrevista = new System.Windows.Forms.DateTimePicker();
			this.gbxMontagem = new System.Windows.Forms.GroupBox();
			this.chkMontagemReal = new System.Windows.Forms.CheckBox();
			this.chkMontagemPrevista = new System.Windows.Forms.CheckBox();
			this.btnAgendar = new System.Windows.Forms.Button();
			this.dtpMontagemReal = new System.Windows.Forms.DateTimePicker();
			this.dtpMontagemPrevista = new System.Windows.Forms.DateTimePicker();
			this.btnImprime = new System.Windows.Forms.Button();
			this.edtTotal = new System.Windows.Forms.TextBox();
			this.edtRegistros = new System.Windows.Forms.TextBox();
			this.lblRegistros = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.edtVlrCV = new System.Windows.Forms.TextBox();
			this.edtPerCV = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.edtVlrCC = new System.Windows.Forms.TextBox();
			this.edtPerCC = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.btnItens = new System.Windows.Forms.Button();
			this.btnConfirma = new System.Windows.Forms.Button();
			this.btnCancela = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.cbxCondicoesPagto = new System.Windows.Forms.ComboBox();
			this.btnTransportadora = new System.Windows.Forms.Button();
			this.edtTransportadora = new System.Windows.Forms.TextBox();
			this.btnConsultor = new System.Windows.Forms.Button();
			this.btnFornecedor = new System.Windows.Forms.Button();
			this.btnCliente = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.edtUsuario = new System.Windows.Forms.TextBox();
			this.dtpAlteracao = new System.Windows.Forms.DateTimePicker();
			this.label9 = new System.Windows.Forms.Label();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.gbxAnexos = new System.Windows.Forms.GroupBox();
			this.btnAbrirAnexo = new System.Windows.Forms.Button();
			this.dgvAnexos = new System.Windows.Forms.DataGridView();
			this.linkLabel3 = new System.Windows.Forms.LinkLabel();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.btnCadAnexos = new System.Windows.Forms.Button();
			this.btnXeceber = new System.Windows.Forms.Button();
			this.btnPagar = new System.Windows.Forms.Button();
			this.btnAlteraValor = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label12 = new System.Windows.Forms.Label();
			this.edtNFFornec = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.edtPedidoFornec = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.edtSinal = new System.Windows.Forms.TextBox();
			this.grpFrete = new System.Windows.Forms.GroupBox();
			this.edtValorFrete = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.rbtFornecedor = new System.Windows.Forms.RadioButton();
			this.rbtCliente = new System.Windows.Forms.RadioButton();
			this.dgvTitulos = new System.Windows.Forms.DataGridView();
			this.label13 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.edtCaracteristica = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.btnDown = new System.Windows.Forms.Button();
			this.btnUp = new System.Windows.Forms.Button();
			this.btnComissao = new System.Windows.Forms.Button();
			this.btnListaComissao = new System.Windows.Forms.Button();
			this.edtRacional = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.btnPendenteConsultor = new System.Windows.Forms.Button();
			this.btnPendenteVendedor = new System.Windows.Forms.Button();
			this.chkTodos = new System.Windows.Forms.CheckBox();
			this.edtComissao = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvCadastro)).BeginInit();
			this.gbxEntrega.SuspendLayout();
			this.gbxMontagem.SuspendLayout();
			this.gbxAnexos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAnexos)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.grpFrete.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTitulos)).BeginInit();
			this.SuspendLayout();
			// 
			// btnFiltro
			// 
			this.btnFiltro.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltro.Image")));
			this.btnFiltro.Location = new System.Drawing.Point(364, 8);
			this.btnFiltro.Name = "btnFiltro";
			this.btnFiltro.Size = new System.Drawing.Size(36, 25);
			this.btnFiltro.TabIndex = 4;
			this.btnFiltro.UseVisualStyleBackColor = true;
			this.btnFiltro.Click += new System.EventHandler(this.BtnFiltroClick);
			// 
			// btnFecha
			// 
			this.btnFecha.Location = new System.Drawing.Point(820, 652);
			this.btnFecha.Name = "btnFecha";
			this.btnFecha.Size = new System.Drawing.Size(100, 30);
			this.btnFecha.TabIndex = 16;
			this.btnFecha.Text = "&Fecha";
			this.btnFecha.UseVisualStyleBackColor = true;
			this.btnFecha.Click += new System.EventHandler(this.BtnFechaClick);
			// 
			// btnAltera
			// 
			this.btnAltera.Location = new System.Drawing.Point(502, 652);
			this.btnAltera.Name = "btnAltera";
			this.btnAltera.Size = new System.Drawing.Size(100, 30);
			this.btnAltera.TabIndex = 13;
			this.btnAltera.Text = "&Altera";
			this.btnAltera.UseVisualStyleBackColor = true;
			this.btnAltera.Click += new System.EventHandler(this.BtnAlteraClick);
			// 
			// btnExclui
			// 
			this.btnExclui.Location = new System.Drawing.Point(396, 652);
			this.btnExclui.Name = "btnExclui";
			this.btnExclui.Size = new System.Drawing.Size(100, 30);
			this.btnExclui.TabIndex = 12;
			this.btnExclui.Text = "&Exclui";
			this.btnExclui.UseVisualStyleBackColor = true;
			this.btnExclui.Click += new System.EventHandler(this.BtnExcluiClick);
			// 
			// edtLocaliza
			// 
			this.edtLocaliza.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtLocaliza.Location = new System.Drawing.Point(79, 10);
			this.edtLocaliza.MaxLength = 30;
			this.edtLocaliza.Name = "edtLocaliza";
			this.edtLocaliza.Size = new System.Drawing.Size(195, 20);
			this.edtLocaliza.TabIndex = 0;
			this.edtLocaliza.TextChanged += new System.EventHandler(this.EdtLocalizaTextChanged);
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
			this.dgvCadastro.Location = new System.Drawing.Point(12, 37);
			this.dgvCadastro.MultiSelect = false;
			this.dgvCadastro.Name = "dgvCadastro";
			this.dgvCadastro.RowHeadersVisible = false;
			this.dgvCadastro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCadastro.Size = new System.Drawing.Size(910, 332);
			this.dgvCadastro.TabIndex = 6;
			this.dgvCadastro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCadastroCellClick);
			this.dgvCadastro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCadastroCellContentClick);
			this.dgvCadastro.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCadastroCellMouseEnter);
			this.dgvCadastro.CurrentCellDirtyStateChanged += new System.EventHandler(this.DgvCadastroCurrentCellDirtyStateChanged);
			this.dgvCadastro.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCadastroRowEnter);
			this.dgvCadastro.Sorted += new System.EventHandler(this.DgvCadastroSorted);
			// 
			// edtObservacao
			// 
			this.edtObservacao.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtObservacao.Location = new System.Drawing.Point(88, 511);
			this.edtObservacao.Multiline = true;
			this.edtObservacao.Name = "edtObservacao";
			this.edtObservacao.ReadOnly = true;
			this.edtObservacao.Size = new System.Drawing.Size(451, 45);
			this.edtObservacao.TabIndex = 34;
			this.edtObservacao.DoubleClick += new System.EventHandler(this.EdtObservacaoDoubleClick);
			// 
			// lblObservacao
			// 
			this.lblObservacao.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblObservacao.Location = new System.Drawing.Point(13, 511);
			this.lblObservacao.Name = "lblObservacao";
			this.lblObservacao.Size = new System.Drawing.Size(70, 25);
			this.lblObservacao.TabIndex = 69;
			this.lblObservacao.Text = "Observação";
			this.lblObservacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// gbxEntrega
			// 
			this.gbxEntrega.Controls.Add(this.chkEntregaReal);
			this.gbxEntrega.Controls.Add(this.chkEntregaPrevista);
			this.gbxEntrega.Controls.Add(this.dtpEntregaReal);
			this.gbxEntrega.Controls.Add(this.dtpEntregaPrevista);
			this.gbxEntrega.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.gbxEntrega.Location = new System.Drawing.Point(8, 391);
			this.gbxEntrega.Name = "gbxEntrega";
			this.gbxEntrega.Size = new System.Drawing.Size(423, 55);
			this.gbxEntrega.TabIndex = 30;
			this.gbxEntrega.TabStop = false;
			this.gbxEntrega.Text = "Entrega";
			// 
			// chkEntregaReal
			// 
			this.chkEntregaReal.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.chkEntregaReal.Location = new System.Drawing.Point(215, 20);
			this.chkEntregaReal.Name = "chkEntregaReal";
			this.chkEntregaReal.Size = new System.Drawing.Size(80, 20);
			this.chkEntregaReal.TabIndex = 2;
			this.chkEntregaReal.Text = "Realizada";
			this.chkEntregaReal.UseVisualStyleBackColor = true;
			// 
			// chkEntregaPrevista
			// 
			this.chkEntregaPrevista.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.chkEntregaPrevista.Location = new System.Drawing.Point(13, 20);
			this.chkEntregaPrevista.Name = "chkEntregaPrevista";
			this.chkEntregaPrevista.Size = new System.Drawing.Size(80, 20);
			this.chkEntregaPrevista.TabIndex = 0;
			this.chkEntregaPrevista.Text = "Prevista";
			this.chkEntregaPrevista.UseVisualStyleBackColor = true;
			// 
			// dtpEntregaReal
			// 
			this.dtpEntregaReal.Checked = false;
			this.dtpEntregaReal.CustomFormat = "dd/MM/yyyy";
			this.dtpEntregaReal.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpEntregaReal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpEntregaReal.Location = new System.Drawing.Point(300, 20);
			this.dtpEntregaReal.Name = "dtpEntregaReal";
			this.dtpEntregaReal.Size = new System.Drawing.Size(110, 20);
			this.dtpEntregaReal.TabIndex = 3;
			// 
			// dtpEntregaPrevista
			// 
			this.dtpEntregaPrevista.CalendarFont = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpEntregaPrevista.Checked = false;
			this.dtpEntregaPrevista.CustomFormat = "dd/MM/yyyy";
			this.dtpEntregaPrevista.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpEntregaPrevista.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpEntregaPrevista.Location = new System.Drawing.Point(100, 20);
			this.dtpEntregaPrevista.Name = "dtpEntregaPrevista";
			this.dtpEntregaPrevista.Size = new System.Drawing.Size(110, 20);
			this.dtpEntregaPrevista.TabIndex = 1;
			// 
			// gbxMontagem
			// 
			this.gbxMontagem.Controls.Add(this.chkMontagemReal);
			this.gbxMontagem.Controls.Add(this.chkMontagemPrevista);
			this.gbxMontagem.Controls.Add(this.btnAgendar);
			this.gbxMontagem.Controls.Add(this.dtpMontagemReal);
			this.gbxMontagem.Controls.Add(this.dtpMontagemPrevista);
			this.gbxMontagem.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.gbxMontagem.Location = new System.Drawing.Point(8, 451);
			this.gbxMontagem.Name = "gbxMontagem";
			this.gbxMontagem.Size = new System.Drawing.Size(528, 55);
			this.gbxMontagem.TabIndex = 32;
			this.gbxMontagem.TabStop = false;
			this.gbxMontagem.Text = "Montagem";
			// 
			// chkMontagemReal
			// 
			this.chkMontagemReal.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.chkMontagemReal.Location = new System.Drawing.Point(215, 20);
			this.chkMontagemReal.Name = "chkMontagemReal";
			this.chkMontagemReal.Size = new System.Drawing.Size(80, 20);
			this.chkMontagemReal.TabIndex = 2;
			this.chkMontagemReal.Text = "Realizada";
			this.chkMontagemReal.UseVisualStyleBackColor = true;
			// 
			// chkMontagemPrevista
			// 
			this.chkMontagemPrevista.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.chkMontagemPrevista.Location = new System.Drawing.Point(13, 20);
			this.chkMontagemPrevista.Name = "chkMontagemPrevista";
			this.chkMontagemPrevista.Size = new System.Drawing.Size(80, 20);
			this.chkMontagemPrevista.TabIndex = 0;
			this.chkMontagemPrevista.Text = "Prevista";
			this.chkMontagemPrevista.UseVisualStyleBackColor = true;
			// 
			// btnAgendar
			// 
			this.btnAgendar.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnAgendar.Location = new System.Drawing.Point(416, 15);
			this.btnAgendar.Name = "btnAgendar";
			this.btnAgendar.Size = new System.Drawing.Size(100, 30);
			this.btnAgendar.TabIndex = 4;
			this.btnAgendar.Text = "Agendar";
			this.btnAgendar.UseVisualStyleBackColor = true;
			this.btnAgendar.Click += new System.EventHandler(this.BtnAgendarClick);
			// 
			// dtpMontagemReal
			// 
			this.dtpMontagemReal.Checked = false;
			this.dtpMontagemReal.CustomFormat = "dd/MM/yyyy";
			this.dtpMontagemReal.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpMontagemReal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpMontagemReal.Location = new System.Drawing.Point(300, 20);
			this.dtpMontagemReal.Name = "dtpMontagemReal";
			this.dtpMontagemReal.Size = new System.Drawing.Size(110, 20);
			this.dtpMontagemReal.TabIndex = 3;
			// 
			// dtpMontagemPrevista
			// 
			this.dtpMontagemPrevista.Checked = false;
			this.dtpMontagemPrevista.CustomFormat = "dd/MM/yyyy";
			this.dtpMontagemPrevista.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpMontagemPrevista.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpMontagemPrevista.Location = new System.Drawing.Point(100, 20);
			this.dtpMontagemPrevista.Name = "dtpMontagemPrevista";
			this.dtpMontagemPrevista.Size = new System.Drawing.Size(110, 20);
			this.dtpMontagemPrevista.TabIndex = 1;
			// 
			// btnImprime
			// 
			this.btnImprime.Location = new System.Drawing.Point(714, 652);
			this.btnImprime.Name = "btnImprime";
			this.btnImprime.Size = new System.Drawing.Size(100, 30);
			this.btnImprime.TabIndex = 15;
			this.btnImprime.Text = "&Imprime";
			this.btnImprime.UseVisualStyleBackColor = true;
			this.btnImprime.Click += new System.EventHandler(this.BtnImprimeClick);
			// 
			// edtTotal
			// 
			this.edtTotal.BackColor = System.Drawing.SystemColors.Info;
			this.edtTotal.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtTotal.Location = new System.Drawing.Point(807, 375);
			this.edtTotal.Name = "edtTotal";
			this.edtTotal.ReadOnly = true;
			this.edtTotal.Size = new System.Drawing.Size(115, 20);
			this.edtTotal.TabIndex = 54;
			this.edtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// edtRegistros
			// 
			this.edtRegistros.BackColor = System.Drawing.SystemColors.Info;
			this.edtRegistros.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtRegistros.Location = new System.Drawing.Point(807, 401);
			this.edtRegistros.Name = "edtRegistros";
			this.edtRegistros.ReadOnly = true;
			this.edtRegistros.Size = new System.Drawing.Size(115, 20);
			this.edtRegistros.TabIndex = 56;
			this.edtRegistros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lblRegistros
			// 
			this.lblRegistros.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblRegistros.Location = new System.Drawing.Point(731, 398);
			this.lblRegistros.Name = "lblRegistros";
			this.lblRegistros.Size = new System.Drawing.Size(70, 25);
			this.lblRegistros.TabIndex = 88;
			this.lblRegistros.Text = "Registros";
			this.lblRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblTotal
			// 
			this.lblTotal.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblTotal.Location = new System.Drawing.Point(731, 375);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(70, 25);
			this.lblTotal.TabIndex = 87;
			this.lblTotal.Text = "Total";
			this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtVlrCV
			// 
			this.edtVlrCV.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtVlrCV.Location = new System.Drawing.Point(630, 511);
			this.edtVlrCV.Name = "edtVlrCV";
			this.edtVlrCV.ReadOnly = true;
			this.edtVlrCV.Size = new System.Drawing.Size(77, 20);
			this.edtVlrCV.TabIndex = 49;
			this.edtVlrCV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// edtPerCV
			// 
			this.edtPerCV.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtPerCV.Location = new System.Drawing.Point(582, 511);
			this.edtPerCV.Name = "edtPerCV";
			this.edtPerCV.ReadOnly = true;
			this.edtPerCV.Size = new System.Drawing.Size(41, 20);
			this.edtPerCV.TabIndex = 48;
			this.edtPerCV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.edtPerCV.MouseEnter += new System.EventHandler(this.EdtPerCVMouseEnter);
			this.edtPerCV.MouseLeave += new System.EventHandler(this.EdtPerCVMouseLeave);
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label6.Location = new System.Drawing.Point(546, 511);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(30, 20);
			this.label6.TabIndex = 122;
			this.label6.Text = "CV";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtVlrCC
			// 
			this.edtVlrCC.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtVlrCC.Location = new System.Drawing.Point(630, 541);
			this.edtVlrCC.Name = "edtVlrCC";
			this.edtVlrCC.ReadOnly = true;
			this.edtVlrCC.Size = new System.Drawing.Size(77, 20);
			this.edtVlrCC.TabIndex = 52;
			this.edtVlrCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// edtPerCC
			// 
			this.edtPerCC.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtPerCC.Location = new System.Drawing.Point(582, 541);
			this.edtPerCC.Name = "edtPerCC";
			this.edtPerCC.ReadOnly = true;
			this.edtPerCC.Size = new System.Drawing.Size(41, 20);
			this.edtPerCC.TabIndex = 50;
			this.edtPerCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.edtPerCC.MouseEnter += new System.EventHandler(this.EdtPerCCMouseEnter);
			this.edtPerCC.MouseLeave += new System.EventHandler(this.EdtPerCCMouseLeave);
			// 
			// label7
			// 
			this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label7.Location = new System.Drawing.Point(546, 541);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(30, 20);
			this.label7.TabIndex = 125;
			this.label7.Text = "CC";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnItens
			// 
			this.btnItens.Location = new System.Drawing.Point(608, 652);
			this.btnItens.Name = "btnItens";
			this.btnItens.Size = new System.Drawing.Size(100, 30);
			this.btnItens.TabIndex = 14;
			this.btnItens.Text = "&Itens";
			this.btnItens.UseVisualStyleBackColor = true;
			this.btnItens.Click += new System.EventHandler(this.BtnItensClick);
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(714, 620);
			this.btnConfirma.Name = "btnConfirma";
			this.btnConfirma.Size = new System.Drawing.Size(100, 30);
			this.btnConfirma.TabIndex = 46;
			this.btnConfirma.Text = "&Confirma";
			this.btnConfirma.UseVisualStyleBackColor = true;
			this.btnConfirma.Visible = false;
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(820, 620);
			this.btnCancela.Name = "btnCancela";
			this.btnCancela.Size = new System.Drawing.Size(100, 30);
			this.btnCancela.TabIndex = 47;
			this.btnCancela.Text = "C&ancela";
			this.btnCancela.UseVisualStyleBackColor = true;
			this.btnCancela.Visible = false;
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
			// 
			// label10
			// 
			this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label10.Location = new System.Drawing.Point(0, 590);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(90, 20);
			this.label10.TabIndex = 135;
			this.label10.Text = "Condição Pagto";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label11
			// 
			this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label11.Location = new System.Drawing.Point(311, 591);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(80, 25);
			this.label11.TabIndex = 138;
			this.label11.Text = "Transportadora";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxCondicoesPagto
			// 
			this.cbxCondicoesPagto.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxCondicoesPagto.FormattingEnabled = true;
			this.cbxCondicoesPagto.Location = new System.Drawing.Point(88, 591);
			this.cbxCondicoesPagto.Name = "cbxCondicoesPagto";
			this.cbxCondicoesPagto.Size = new System.Drawing.Size(202, 22);
			this.cbxCondicoesPagto.TabIndex = 40;
			// 
			// btnTransportadora
			// 
			this.btnTransportadora.Image = ((System.Drawing.Image)(resources.GetObject("btnTransportadora.Image")));
			this.btnTransportadora.Location = new System.Drawing.Point(548, 589);
			this.btnTransportadora.Name = "btnTransportadora";
			this.btnTransportadora.Size = new System.Drawing.Size(36, 23);
			this.btnTransportadora.TabIndex = 44;
			this.btnTransportadora.UseVisualStyleBackColor = true;
			this.btnTransportadora.Click += new System.EventHandler(this.BtnTransportadoraClick);
			// 
			// edtTransportadora
			// 
			this.edtTransportadora.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtTransportadora.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtTransportadora.Location = new System.Drawing.Point(396, 591);
			this.edtTransportadora.MaxLength = 50;
			this.edtTransportadora.Name = "edtTransportadora";
			this.edtTransportadora.ReadOnly = true;
			this.edtTransportadora.Size = new System.Drawing.Size(146, 20);
			this.edtTransportadora.TabIndex = 42;
			// 
			// btnConsultor
			// 
			this.btnConsultor.Location = new System.Drawing.Point(821, 5);
			this.btnConsultor.Name = "btnConsultor";
			this.btnConsultor.Size = new System.Drawing.Size(100, 25);
			this.btnConsultor.TabIndex = 22;
			this.btnConsultor.Text = "Consultor";
			this.btnConsultor.UseVisualStyleBackColor = true;
			this.btnConsultor.Click += new System.EventHandler(this.BtnConsultorClick);
			// 
			// btnFornecedor
			// 
			this.btnFornecedor.Location = new System.Drawing.Point(609, 5);
			this.btnFornecedor.Name = "btnFornecedor";
			this.btnFornecedor.Size = new System.Drawing.Size(100, 25);
			this.btnFornecedor.TabIndex = 18;
			this.btnFornecedor.Text = "Fornecedor";
			this.btnFornecedor.UseVisualStyleBackColor = true;
			this.btnFornecedor.Click += new System.EventHandler(this.BtnFornecedorClick);
			// 
			// btnCliente
			// 
			this.btnCliente.Location = new System.Drawing.Point(715, 5);
			this.btnCliente.Name = "btnCliente";
			this.btnCliente.Size = new System.Drawing.Size(100, 25);
			this.btnCliente.TabIndex = 20;
			this.btnCliente.Text = "Cliente";
			this.btnCliente.UseVisualStyleBackColor = true;
			this.btnCliente.Click += new System.EventHandler(this.BtnClienteClick);
			// 
			// label8
			// 
			this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label8.Location = new System.Drawing.Point(13, 560);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(70, 25);
			this.label8.TabIndex = 129;
			this.label8.Text = "Alteração";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtUsuario
			// 
			this.edtUsuario.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtUsuario.Location = new System.Drawing.Point(396, 561);
			this.edtUsuario.Name = "edtUsuario";
			this.edtUsuario.ReadOnly = true;
			this.edtUsuario.Size = new System.Drawing.Size(146, 20);
			this.edtUsuario.TabIndex = 38;
			// 
			// dtpAlteracao
			// 
			this.dtpAlteracao.CustomFormat = "dd/MM/yyyy HH:mm:ss";
			this.dtpAlteracao.Enabled = false;
			this.dtpAlteracao.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpAlteracao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpAlteracao.Location = new System.Drawing.Point(88, 560);
			this.dtpAlteracao.Name = "dtpAlteracao";
			this.dtpAlteracao.Size = new System.Drawing.Size(170, 20);
			this.dtpAlteracao.TabIndex = 36;
			// 
			// label9
			// 
			this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label9.Location = new System.Drawing.Point(321, 561);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(70, 25);
			this.label9.TabIndex = 132;
			this.label9.Text = "Usuário";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnRefresh
			// 
			this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
			this.btnRefresh.Location = new System.Drawing.Point(404, 8);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(36, 25);
			this.btnRefresh.TabIndex = 4;
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.BtnRefreshClick);
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
			this.gbxAnexos.Location = new System.Drawing.Point(714, 436);
			this.gbxAnexos.Name = "gbxAnexos";
			this.gbxAnexos.Size = new System.Drawing.Size(200, 138);
			this.gbxAnexos.TabIndex = 139;
			this.gbxAnexos.TabStop = false;
			this.gbxAnexos.Text = "Anexos";
			// 
			// btnAbrirAnexo
			// 
			this.btnAbrirAnexo.BackColor = System.Drawing.SystemColors.Control;
			this.btnAbrirAnexo.ForeColor = System.Drawing.SystemColors.InfoText;
			this.btnAbrirAnexo.Location = new System.Drawing.Point(4, 108);
			this.btnAbrirAnexo.Name = "btnAbrirAnexo";
			this.btnAbrirAnexo.Size = new System.Drawing.Size(83, 25);
			this.btnAbrirAnexo.TabIndex = 10;
			this.btnAbrirAnexo.Text = "Abre";
			this.btnAbrirAnexo.UseVisualStyleBackColor = false;
			this.btnAbrirAnexo.Click += new System.EventHandler(this.BtnAbrirAnexoClick);
			// 
			// dgvAnexos
			// 
			this.dgvAnexos.AllowUserToAddRows = false;
			this.dgvAnexos.AllowUserToDeleteRows = false;
			this.dgvAnexos.AllowUserToResizeColumns = false;
			this.dgvAnexos.AllowUserToResizeRows = false;
			this.dgvAnexos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAnexos.ColumnHeadersVisible = false;
			this.dgvAnexos.Location = new System.Drawing.Point(4, 15);
			this.dgvAnexos.Name = "dgvAnexos";
			this.dgvAnexos.ReadOnly = true;
			this.dgvAnexos.RowHeadersVisible = false;
			this.dgvAnexos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
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
			this.btnCadAnexos.Location = new System.Drawing.Point(93, 108);
			this.btnCadAnexos.Name = "btnCadAnexos";
			this.btnCadAnexos.Size = new System.Drawing.Size(83, 25);
			this.btnCadAnexos.TabIndex = 11;
			this.btnCadAnexos.Text = "Cadastro";
			this.btnCadAnexos.UseVisualStyleBackColor = false;
			this.btnCadAnexos.Click += new System.EventHandler(this.BtnCadAnexosClick);
			// 
			// btnXeceber
			// 
			this.btnXeceber.Location = new System.Drawing.Point(287, 652);
			this.btnXeceber.Name = "btnXeceber";
			this.btnXeceber.Size = new System.Drawing.Size(100, 30);
			this.btnXeceber.TabIndex = 11;
			this.btnXeceber.Text = "&Faturamento";
			this.btnXeceber.UseVisualStyleBackColor = true;
			this.btnXeceber.Click += new System.EventHandler(this.BtnXeceberClick);
			this.btnXeceber.MouseEnter += new System.EventHandler(this.BtnXeceberMouseEnter);
			this.btnXeceber.MouseLeave += new System.EventHandler(this.BtnXeceberMouseLeave);
			// 
			// btnPagar
			// 
			this.btnPagar.Location = new System.Drawing.Point(181, 652);
			this.btnPagar.Name = "btnPagar";
			this.btnPagar.Size = new System.Drawing.Size(100, 30);
			this.btnPagar.TabIndex = 10;
			this.btnPagar.Text = "&Pagar";
			this.btnPagar.UseVisualStyleBackColor = true;
			this.btnPagar.Click += new System.EventHandler(this.BtnPagarClick);
			this.btnPagar.MouseEnter += new System.EventHandler(this.BtnPagarMouseEnter);
			this.btnPagar.MouseLeave += new System.EventHandler(this.BtnPagarMouseLeave);
			// 
			// btnAlteraValor
			// 
			this.btnAlteraValor.Location = new System.Drawing.Point(55, 652);
			this.btnAlteraValor.Name = "btnAlteraValor";
			this.btnAlteraValor.Size = new System.Drawing.Size(120, 30);
			this.btnAlteraValor.TabIndex = 9;
			this.btnAlteraValor.Text = "Altera &Valor/Pedido";
			this.btnAlteraValor.UseVisualStyleBackColor = true;
			this.btnAlteraValor.Click += new System.EventHandler(this.BtnAlteraValorClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.edtNFFornec);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.edtPedidoFornec);
			this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.groupBox1.Location = new System.Drawing.Point(546, 398);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(159, 80);
			this.groupBox1.TabIndex = 45;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Fornecedor";
			// 
			// label12
			// 
			this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label12.Location = new System.Drawing.Point(2, 44);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(60, 20);
			this.label12.TabIndex = 145;
			this.label12.Text = "NF";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtNFFornec
			// 
			this.edtNFFornec.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtNFFornec.Location = new System.Drawing.Point(68, 45);
			this.edtNFFornec.MaxLength = 8;
			this.edtNFFornec.Name = "edtNFFornec";
			this.edtNFFornec.ReadOnly = true;
			this.edtNFFornec.Size = new System.Drawing.Size(62, 20);
			this.edtNFFornec.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label5.Location = new System.Drawing.Point(2, 18);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(60, 20);
			this.label5.TabIndex = 143;
			this.label5.Text = "Pedido";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtPedidoFornec
			// 
			this.edtPedidoFornec.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtPedidoFornec.Location = new System.Drawing.Point(68, 19);
			this.edtPedidoFornec.Name = "edtPedidoFornec";
			this.edtPedidoFornec.ReadOnly = true;
			this.edtPedidoFornec.Size = new System.Drawing.Size(69, 20);
			this.edtPedidoFornec.TabIndex = 0;
			// 
			// label14
			// 
			this.label14.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label14.Location = new System.Drawing.Point(602, 571);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(60, 25);
			this.label14.TabIndex = 144;
			this.label14.Text = "Sinal";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtSinal
			// 
			this.edtSinal.Enabled = false;
			this.edtSinal.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtSinal.Location = new System.Drawing.Point(668, 571);
			this.edtSinal.Name = "edtSinal";
			this.edtSinal.Size = new System.Drawing.Size(40, 20);
			this.edtSinal.TabIndex = 145;
			// 
			// grpFrete
			// 
			this.grpFrete.Controls.Add(this.edtValorFrete);
			this.grpFrete.Controls.Add(this.label1);
			this.grpFrete.Controls.Add(this.rbtFornecedor);
			this.grpFrete.Controls.Add(this.rbtCliente);
			this.grpFrete.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.grpFrete.Location = new System.Drawing.Point(339, 614);
			this.grpFrete.Name = "grpFrete";
			this.grpFrete.Size = new System.Drawing.Size(368, 35);
			this.grpFrete.TabIndex = 146;
			this.grpFrete.TabStop = false;
			this.grpFrete.Text = "Frete";
			// 
			// edtValorFrete
			// 
			this.edtValorFrete.BackColor = System.Drawing.SystemColors.Window;
			this.edtValorFrete.Enabled = false;
			this.edtValorFrete.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtValorFrete.Location = new System.Drawing.Point(243, 9);
			this.edtValorFrete.MaxLength = 20;
			this.edtValorFrete.Name = "edtValorFrete";
			this.edtValorFrete.Size = new System.Drawing.Size(111, 20);
			this.edtValorFrete.TabIndex = 165;
			this.edtValorFrete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(195, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 25);
			this.label1.TabIndex = 164;
			this.label1.Text = "Valor";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// rbtFornecedor
			// 
			this.rbtFornecedor.Location = new System.Drawing.Point(98, 11);
			this.rbtFornecedor.Name = "rbtFornecedor";
			this.rbtFornecedor.Size = new System.Drawing.Size(99, 22);
			this.rbtFornecedor.TabIndex = 1;
			this.rbtFornecedor.Text = "Fornecedor";
			this.rbtFornecedor.UseVisualStyleBackColor = true;
			// 
			// rbtCliente
			// 
			this.rbtCliente.Checked = true;
			this.rbtCliente.Location = new System.Drawing.Point(12, 11);
			this.rbtCliente.Name = "rbtCliente";
			this.rbtCliente.Size = new System.Drawing.Size(80, 22);
			this.rbtCliente.TabIndex = 0;
			this.rbtCliente.TabStop = true;
			this.rbtCliente.Text = "Cliente";
			this.rbtCliente.UseVisualStyleBackColor = true;
			// 
			// dgvTitulos
			// 
			this.dgvTitulos.AllowUserToAddRows = false;
			this.dgvTitulos.AllowUserToDeleteRows = false;
			this.dgvTitulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTitulos.ColumnHeadersVisible = false;
			this.dgvTitulos.Location = new System.Drawing.Point(268, 153);
			this.dgvTitulos.Name = "dgvTitulos";
			this.dgvTitulos.RowHeadersVisible = false;
			this.dgvTitulos.Size = new System.Drawing.Size(254, 216);
			this.dgvTitulos.TabIndex = 147;
			this.dgvTitulos.Visible = false;
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.Red;
			this.label13.Location = new System.Drawing.Point(8, 370);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(450, 18);
			this.label13.TabIndex = 148;
			this.label13.Text = "Marque as caixas de checagem para selecionar pedidos para impressão consolidada";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// button1
			// 
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(444, 8);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(36, 25);
			this.button1.TabIndex = 4;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// edtCaracteristica
			// 
			this.edtCaracteristica.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtCaracteristica.Location = new System.Drawing.Point(88, 622);
			this.edtCaracteristica.Name = "edtCaracteristica";
			this.edtCaracteristica.ReadOnly = true;
			this.edtCaracteristica.Size = new System.Drawing.Size(146, 20);
			this.edtCaracteristica.TabIndex = 150;
			this.edtCaracteristica.MouseEnter += new System.EventHandler(this.EdtCaracteristicaMouseEnter);
			this.edtCaracteristica.MouseLeave += new System.EventHandler(this.EdtCaracteristicaMouseLeave);
			// 
			// label15
			// 
			this.label15.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label15.Location = new System.Drawing.Point(6, 622);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(75, 20);
			this.label15.TabIndex = 149;
			this.label15.Text = "Característica";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(13, 9);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(60, 20);
			this.label16.TabIndex = 152;
			this.label16.Text = "Localiza";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnDown
			// 
			this.btnDown.Image = ((System.Drawing.Image)(resources.GetObject("btnDown.Image")));
			this.btnDown.Location = new System.Drawing.Point(281, 8);
			this.btnDown.Name = "btnDown";
			this.btnDown.Size = new System.Drawing.Size(36, 25);
			this.btnDown.TabIndex = 153;
			this.btnDown.UseVisualStyleBackColor = true;
			this.btnDown.Click += new System.EventHandler(this.BtnDownClick);
			// 
			// btnUp
			// 
			this.btnUp.Image = ((System.Drawing.Image)(resources.GetObject("btnUp.Image")));
			this.btnUp.Location = new System.Drawing.Point(321, 8);
			this.btnUp.Name = "btnUp";
			this.btnUp.Size = new System.Drawing.Size(36, 25);
			this.btnUp.TabIndex = 154;
			this.btnUp.UseVisualStyleBackColor = true;
			this.btnUp.Click += new System.EventHandler(this.BtnUpClick);
			// 
			// btnComissao
			// 
			this.btnComissao.Location = new System.Drawing.Point(713, 588);
			this.btnComissao.Name = "btnComissao";
			this.btnComissao.Size = new System.Drawing.Size(100, 30);
			this.btnComissao.TabIndex = 155;
			this.btnComissao.Text = "Co&missão";
			this.btnComissao.UseVisualStyleBackColor = true;
			this.btnComissao.Visible = false;
			this.btnComissao.Click += new System.EventHandler(this.BtnComissaoClick);
			// 
			// btnListaComissao
			// 
			this.btnListaComissao.Location = new System.Drawing.Point(820, 588);
			this.btnListaComissao.Name = "btnListaComissao";
			this.btnListaComissao.Size = new System.Drawing.Size(100, 30);
			this.btnListaComissao.TabIndex = 156;
			this.btnListaComissao.Text = "Lista Com&issão";
			this.btnListaComissao.UseVisualStyleBackColor = true;
			this.btnListaComissao.Visible = false;
			// 
			// edtRacional
			// 
			this.edtRacional.BackColor = System.Drawing.SystemColors.Info;
			this.edtRacional.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtRacional.Location = new System.Drawing.Point(13, 167);
			this.edtRacional.Multiline = true;
			this.edtRacional.Name = "edtRacional";
			this.edtRacional.Size = new System.Drawing.Size(546, 200);
			this.edtRacional.TabIndex = 157;
			this.edtRacional.Visible = false;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(577, 7);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(31, 23);
			this.button2.TabIndex = 160;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Visible = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// btnPendenteConsultor
			// 
			this.btnPendenteConsultor.Image = ((System.Drawing.Image)(resources.GetObject("btnPendenteConsultor.Image")));
			this.btnPendenteConsultor.Location = new System.Drawing.Point(486, 8);
			this.btnPendenteConsultor.Name = "btnPendenteConsultor";
			this.btnPendenteConsultor.Size = new System.Drawing.Size(36, 25);
			this.btnPendenteConsultor.TabIndex = 161;
			this.btnPendenteConsultor.UseVisualStyleBackColor = true;
			this.btnPendenteConsultor.Click += new System.EventHandler(this.BtnPendenteConsultorClick);
			// 
			// btnPendenteVendedor
			// 
			this.btnPendenteVendedor.Image = ((System.Drawing.Image)(resources.GetObject("btnPendenteVendedor.Image")));
			this.btnPendenteVendedor.Location = new System.Drawing.Point(528, 8);
			this.btnPendenteVendedor.Name = "btnPendenteVendedor";
			this.btnPendenteVendedor.Size = new System.Drawing.Size(36, 25);
			this.btnPendenteVendedor.TabIndex = 162;
			this.btnPendenteVendedor.UseVisualStyleBackColor = true;
			this.btnPendenteVendedor.Click += new System.EventHandler(this.BtnPendenteVendedorClick);
			// 
			// chkTodos
			// 
			this.chkTodos.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkTodos.Location = new System.Drawing.Point(424, 370);
			this.chkTodos.Name = "chkTodos";
			this.chkTodos.Size = new System.Drawing.Size(140, 24);
			this.chkTodos.TabIndex = 163;
			this.chkTodos.Text = "Marca/desmarca todos";
			this.chkTodos.UseVisualStyleBackColor = true;
			this.chkTodos.CheckedChanged += new System.EventHandler(this.ChkTodosCheckedChanged);
			// 
			// edtComissao
			// 
			this.edtComissao.BackColor = System.Drawing.SystemColors.Info;
			this.edtComissao.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtComissao.Location = new System.Drawing.Point(582, 564);
			this.edtComissao.Multiline = true;
			this.edtComissao.Name = "edtComissao";
			this.edtComissao.Size = new System.Drawing.Size(231, 52);
			this.edtComissao.TabIndex = 164;
			this.edtComissao.Visible = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(934, 686);
			this.Controls.Add(this.edtComissao);
			this.Controls.Add(this.btnPendenteVendedor);
			this.Controls.Add(this.btnPendenteConsultor);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.edtRacional);
			this.Controls.Add(this.chkTodos);
			this.Controls.Add(this.btnListaComissao);
			this.Controls.Add(this.btnComissao);
			this.Controls.Add(this.btnDown);
			this.Controls.Add(this.btnUp);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.edtCaracteristica);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.dgvTitulos);
			this.Controls.Add(this.grpFrete);
			this.Controls.Add(this.edtSinal);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnAlteraValor);
			this.Controls.Add(this.btnPagar);
			this.Controls.Add(this.btnXeceber);
			this.Controls.Add(this.gbxAnexos);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.btnConsultor);
			this.Controls.Add(this.btnFornecedor);
			this.Controls.Add(this.btnCliente);
			this.Controls.Add(this.btnTransportadora);
			this.Controls.Add(this.edtTransportadora);
			this.Controls.Add(this.cbxCondicoesPagto);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.btnCancela);
			this.Controls.Add(this.btnConfirma);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.dtpAlteracao);
			this.Controls.Add(this.edtUsuario);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.btnItens);
			this.Controls.Add(this.edtVlrCC);
			this.Controls.Add(this.edtPerCC);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.edtVlrCV);
			this.Controls.Add(this.edtPerCV);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.edtTotal);
			this.Controls.Add(this.edtRegistros);
			this.Controls.Add(this.lblRegistros);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.btnImprime);
			this.Controls.Add(this.gbxMontagem);
			this.Controls.Add(this.gbxEntrega);
			this.Controls.Add(this.edtObservacao);
			this.Controls.Add(this.lblObservacao);
			this.Controls.Add(this.btnFiltro);
			this.Controls.Add(this.btnFecha);
			this.Controls.Add(this.btnAltera);
			this.Controls.Add(this.btnExclui);
			this.Controls.Add(this.edtLocaliza);
			this.Controls.Add(this.dgvCadastro);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sistema SOFT - Pedidos - v2.6.2 (23/07/22)";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgvCadastro)).EndInit();
			this.gbxEntrega.ResumeLayout(false);
			this.gbxMontagem.ResumeLayout(false);
			this.gbxAnexos.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvAnexos)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.grpFrete.ResumeLayout(false);
			this.grpFrete.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTitulos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		public System.Windows.Forms.TextBox edtComissao;
		public System.Windows.Forms.Button btnAbrirAnexo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox edtValorFrete;
		private System.Windows.Forms.Button btnPendenteVendedor;
		private System.Windows.Forms.Button btnPendenteConsultor;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.CheckBox chkTodos;
		public System.Windows.Forms.TextBox edtRacional;		
		public System.Windows.Forms.Button btnListaComissao;
		public System.Windows.Forms.Button btnComissao;
		private System.Windows.Forms.CheckBox chkMontagemPrevista;
		private System.Windows.Forms.CheckBox chkMontagemReal;
		private System.Windows.Forms.CheckBox chkEntregaReal;
		private System.Windows.Forms.CheckBox chkEntregaPrevista;
		public System.Windows.Forms.Button btnUp;
		public System.Windows.Forms.Button btnDown;
		private System.Windows.Forms.Label label16;
		public System.Windows.Forms.Button btnAgendar;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox edtCaracteristica;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.RadioButton rbtCliente;
		public System.Windows.Forms.RadioButton rbtFornecedor;
		private System.Windows.Forms.GroupBox grpFrete;
		private System.Windows.Forms.TextBox edtSinal;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.DataGridView dgvTitulos;
		private System.Windows.Forms.TextBox edtNFFornec;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.GroupBox groupBox1;
		public System.Windows.Forms.Button btnAlteraValor;
		public System.Windows.Forms.Button btnPagar;
		private System.Windows.Forms.TextBox edtPedidoFornec;
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.Button btnXeceber;
		public System.Windows.Forms.Button btnCadAnexos;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.LinkLabel linkLabel2;
		private System.Windows.Forms.LinkLabel linkLabel3;
		private System.Windows.Forms.DataGridView dgvAnexos;
		private System.Windows.Forms.GroupBox gbxAnexos;
		private System.Windows.Forms.Button btnRefresh;
		public System.Windows.Forms.Button btnItens;
		public System.Windows.Forms.Button btnCliente;
		public System.Windows.Forms.Button btnFornecedor;
		public System.Windows.Forms.Button btnConsultor;
		public System.Windows.Forms.TextBox edtTransportadora;
		private System.Windows.Forms.Button btnTransportadora;
		public System.Windows.Forms.ComboBox cbxCondicoesPagto;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		public System.Windows.Forms.Button btnCancela;
		public System.Windows.Forms.Button btnConfirma;
		private System.Windows.Forms.DateTimePicker dtpMontagemReal;
		private System.Windows.Forms.DateTimePicker dtpMontagemPrevista;
		private System.Windows.Forms.DateTimePicker dtpEntregaReal;
		private System.Windows.Forms.DateTimePicker dtpEntregaPrevista;
		private System.Windows.Forms.TextBox edtVlrCC;
		public System.Windows.Forms.Button btnImprime;
		private System.Windows.Forms.TextBox edtVlrCV;
		private System.Windows.Forms.TextBox edtPerCV;
		private System.Windows.Forms.TextBox edtPerCC;
		public System.Windows.Forms.DateTimePicker dtpAlteracao;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox edtUsuario;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Label lblRegistros;
		private System.Windows.Forms.TextBox edtRegistros;
		private System.Windows.Forms.TextBox edtTotal;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox gbxMontagem;
		private System.Windows.Forms.GroupBox gbxEntrega;
		private System.Windows.Forms.Label lblObservacao;
		private System.Windows.Forms.TextBox edtObservacao;
		public System.Windows.Forms.DataGridView dgvCadastro;
		public System.Windows.Forms.TextBox edtLocaliza;
		public System.Windows.Forms.Button btnExclui;
		public System.Windows.Forms.Button btnAltera;
		public System.Windows.Forms.Button btnFecha;
		private System.Windows.Forms.Button btnFiltro;
	}
}
