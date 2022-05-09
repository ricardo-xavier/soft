/*
 * Usuário: Ricardo
 * Data: 17/04/2008
 * Hora: 23:29
 * 
 */
namespace orcamento
{
	partial class frmFiltroOrcamento
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFiltroOrcamento));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnFornecedor = new System.Windows.Forms.Button();
			this.cbxUsuarios = new System.Windows.Forms.ComboBox();
			this.lblVendedor = new System.Windows.Forms.Label();
			this.btnCliente = new System.Windows.Forms.Button();
			this.edtCliente = new System.Windows.Forms.TextBox();
			this.lblCliente = new System.Windows.Forms.Label();
			this.btnConsultor = new System.Windows.Forms.Button();
			this.edtConsultor = new System.Windows.Forms.TextBox();
			this.lblConsultor = new System.Windows.Forms.Label();
			this.cbxCaracteristicas = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.edtAnoF = new System.Windows.Forms.TextBox();
			this.udMesF = new System.Windows.Forms.NumericUpDown();
			this.edtAnoI = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.udMesI = new System.Windows.Forms.NumericUpDown();
			this.ckbData = new System.Windows.Forms.CheckBox();
			this.label9 = new System.Windows.Forms.Label();
			this.dtpCadastroF = new System.Windows.Forms.DateTimePicker();
			this.label13 = new System.Windows.Forms.Label();
			this.dtpCadastroI = new System.Windows.Forms.DateTimePicker();
			this.chkTodas = new System.Windows.Forms.CheckBox();
			this.dgvSituacoes = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.edtResumo = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.udMesF)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.udMesI)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvSituacoes)).BeginInit();
			this.SuspendLayout();
			// 
			// lblCodigo
			// 
			this.lblCodigo.Text = "Fornecedor";
			// 
			// lblDescricao
			// 
			this.lblDescricao.Location = new System.Drawing.Point(13, 76);
			this.lblDescricao.Text = "Mês/Ano";
			this.lblDescricao.Visible = false;
			// 
			// edtCodigo
			// 
			this.edtCodigo.MaxLength = 20;
			this.edtCodigo.Size = new System.Drawing.Size(146, 20);
			this.edtCodigo.TabIndex = 0;
			this.edtCodigo.TextChanged += new System.EventHandler(this.EdtCodigoTextChanged);
			// 
			// edtDescricao
			// 
			this.edtDescricao.BackColor = System.Drawing.SystemColors.Info;
			this.edtDescricao.Location = new System.Drawing.Point(165, 76);
			this.edtDescricao.MaxLength = 4;
			this.edtDescricao.ReadOnly = true;
			this.edtDescricao.Size = new System.Drawing.Size(34, 20);
			this.edtDescricao.TabIndex = 3;
			this.edtDescricao.Text = "2008";
			this.edtDescricao.Visible = false;
			// 
			// lblTitulo
			// 
			this.lblTitulo.Text = "Filtro de Orçamentos";
			// 
			// btnLimpa
			// 
			this.btnLimpa.Location = new System.Drawing.Point(697, 109);
			this.btnLimpa.Click += new System.EventHandler(this.BtnLimpaClick);
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(697, 78);
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(697, 47);
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.edtResumo);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.chkTodas);
			this.panel1.Controls.Add(this.dgvSituacoes);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.dtpCadastroF);
			this.panel1.Controls.Add(this.label13);
			this.panel1.Controls.Add(this.dtpCadastroI);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Controls.Add(this.cbxCaracteristicas);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.btnConsultor);
			this.panel1.Controls.Add(this.edtConsultor);
			this.panel1.Controls.Add(this.lblConsultor);
			this.panel1.Controls.Add(this.btnCliente);
			this.panel1.Controls.Add(this.edtCliente);
			this.panel1.Controls.Add(this.lblCliente);
			this.panel1.Controls.Add(this.cbxUsuarios);
			this.panel1.Controls.Add(this.lblVendedor);
			this.panel1.Controls.Add(this.btnFornecedor);
			this.panel1.Size = new System.Drawing.Size(679, 379);
			this.panel1.Controls.SetChildIndex(this.lblCodigo, 0);
			this.panel1.Controls.SetChildIndex(this.lblDescricao, 0);
			this.panel1.Controls.SetChildIndex(this.edtCodigo, 0);
			this.panel1.Controls.SetChildIndex(this.edtDescricao, 0);
			this.panel1.Controls.SetChildIndex(this.btnFornecedor, 0);
			this.panel1.Controls.SetChildIndex(this.lblVendedor, 0);
			this.panel1.Controls.SetChildIndex(this.cbxUsuarios, 0);
			this.panel1.Controls.SetChildIndex(this.lblCliente, 0);
			this.panel1.Controls.SetChildIndex(this.edtCliente, 0);
			this.panel1.Controls.SetChildIndex(this.btnCliente, 0);
			this.panel1.Controls.SetChildIndex(this.lblConsultor, 0);
			this.panel1.Controls.SetChildIndex(this.edtConsultor, 0);
			this.panel1.Controls.SetChildIndex(this.btnConsultor, 0);
			this.panel1.Controls.SetChildIndex(this.label6, 0);
			this.panel1.Controls.SetChildIndex(this.cbxCaracteristicas, 0);
			this.panel1.Controls.SetChildIndex(this.groupBox1, 0);
			this.panel1.Controls.SetChildIndex(this.dtpCadastroI, 0);
			this.panel1.Controls.SetChildIndex(this.label13, 0);
			this.panel1.Controls.SetChildIndex(this.dtpCadastroF, 0);
			this.panel1.Controls.SetChildIndex(this.label9, 0);
			this.panel1.Controls.SetChildIndex(this.label3, 0);
			this.panel1.Controls.SetChildIndex(this.dgvSituacoes, 0);
			this.panel1.Controls.SetChildIndex(this.chkTodas, 0);
			this.panel1.Controls.SetChildIndex(this.label4, 0);
			this.panel1.Controls.SetChildIndex(this.edtResumo, 0);
			// 
			// btnFornecedor
			// 
			this.btnFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("btnFornecedor.Image")));
			this.btnFornecedor.Location = new System.Drawing.Point(270, 8);
			this.btnFornecedor.Name = "btnFornecedor";
			this.btnFornecedor.Size = new System.Drawing.Size(36, 23);
			this.btnFornecedor.TabIndex = 1;
			this.btnFornecedor.UseVisualStyleBackColor = true;
			this.btnFornecedor.Click += new System.EventHandler(this.BtnFornecedorClick);
			// 
			// cbxUsuarios
			// 
			this.cbxUsuarios.BackColor = System.Drawing.SystemColors.Window;
			this.cbxUsuarios.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxUsuarios.FormattingEnabled = true;
			this.cbxUsuarios.Location = new System.Drawing.Point(115, 100);
			this.cbxUsuarios.Name = "cbxUsuarios";
			this.cbxUsuarios.Size = new System.Drawing.Size(166, 22);
			this.cbxUsuarios.TabIndex = 4;
			// 
			// lblVendedor
			// 
			this.lblVendedor.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblVendedor.Location = new System.Drawing.Point(10, 100);
			this.lblVendedor.Name = "lblVendedor";
			this.lblVendedor.Size = new System.Drawing.Size(100, 20);
			this.lblVendedor.TabIndex = 12;
			this.lblVendedor.Text = "Vendedor";
			this.lblVendedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnCliente
			// 
			this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
			this.btnCliente.Location = new System.Drawing.Point(270, 128);
			this.btnCliente.Name = "btnCliente";
			this.btnCliente.Size = new System.Drawing.Size(36, 23);
			this.btnCliente.TabIndex = 6;
			this.btnCliente.UseVisualStyleBackColor = true;
			this.btnCliente.Click += new System.EventHandler(this.BtnClienteClick);
			// 
			// edtCliente
			// 
			this.edtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtCliente.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtCliente.Location = new System.Drawing.Point(115, 130);
			this.edtCliente.MaxLength = 50;
			this.edtCliente.Name = "edtCliente";
			this.edtCliente.Size = new System.Drawing.Size(146, 20);
			this.edtCliente.TabIndex = 5;
			// 
			// lblCliente
			// 
			this.lblCliente.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCliente.Location = new System.Drawing.Point(10, 130);
			this.lblCliente.Name = "lblCliente";
			this.lblCliente.Size = new System.Drawing.Size(100, 20);
			this.lblCliente.TabIndex = 94;
			this.lblCliente.Text = "Cliente";
			this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnConsultor
			// 
			this.btnConsultor.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultor.Image")));
			this.btnConsultor.Location = new System.Drawing.Point(270, 158);
			this.btnConsultor.Name = "btnConsultor";
			this.btnConsultor.Size = new System.Drawing.Size(36, 23);
			this.btnConsultor.TabIndex = 10;
			this.btnConsultor.UseVisualStyleBackColor = true;
			this.btnConsultor.Click += new System.EventHandler(this.BtnConsultorClick);
			// 
			// edtConsultor
			// 
			this.edtConsultor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtConsultor.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtConsultor.Location = new System.Drawing.Point(115, 160);
			this.edtConsultor.MaxLength = 50;
			this.edtConsultor.Name = "edtConsultor";
			this.edtConsultor.Size = new System.Drawing.Size(146, 20);
			this.edtConsultor.TabIndex = 9;
			// 
			// lblConsultor
			// 
			this.lblConsultor.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblConsultor.Location = new System.Drawing.Point(10, 160);
			this.lblConsultor.Name = "lblConsultor";
			this.lblConsultor.Size = new System.Drawing.Size(100, 20);
			this.lblConsultor.TabIndex = 100;
			this.lblConsultor.Text = "Consultor";
			this.lblConsultor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxCaracteristicas
			// 
			this.cbxCaracteristicas.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxCaracteristicas.FormattingEnabled = true;
			this.cbxCaracteristicas.Location = new System.Drawing.Point(115, 190);
			this.cbxCaracteristicas.Name = "cbxCaracteristicas";
			this.cbxCaracteristicas.Size = new System.Drawing.Size(166, 22);
			this.cbxCaracteristicas.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label6.Location = new System.Drawing.Point(10, 190);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 20);
			this.label6.TabIndex = 102;
			this.label6.Text = "Carac. Venda";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.edtAnoF);
			this.groupBox1.Controls.Add(this.udMesF);
			this.groupBox1.Controls.Add(this.edtAnoI);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.udMesI);
			this.groupBox1.Controls.Add(this.ckbData);
			this.groupBox1.Location = new System.Drawing.Point(10, 40);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(347, 57);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			// 
			// edtAnoF
			// 
			this.edtAnoF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtAnoF.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtAnoF.Location = new System.Drawing.Point(246, 35);
			this.edtAnoF.MaxLength = 4;
			this.edtAnoF.Name = "edtAnoF";
			this.edtAnoF.Size = new System.Drawing.Size(34, 20);
			this.edtAnoF.TabIndex = 4;
			// 
			// udMesF
			// 
			this.udMesF.BackColor = System.Drawing.SystemColors.Window;
			this.udMesF.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.udMesF.Location = new System.Drawing.Point(203, 35);
			this.udMesF.Maximum = new decimal(new int[] {
			13,
			0,
			0,
			0});
			this.udMesF.Name = "udMesF";
			this.udMesF.Size = new System.Drawing.Size(40, 20);
			this.udMesF.TabIndex = 3;
			this.udMesF.Value = new decimal(new int[] {
			12,
			0,
			0,
			0});
			this.udMesF.ValueChanged += new System.EventHandler(this.UdMesFValueChanged);
			// 
			// edtAnoI
			// 
			this.edtAnoI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtAnoI.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtAnoI.Location = new System.Drawing.Point(109, 35);
			this.edtAnoI.MaxLength = 4;
			this.edtAnoI.Name = "edtAnoI";
			this.edtAnoI.Size = new System.Drawing.Size(34, 20);
			this.edtAnoI.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label2.Location = new System.Drawing.Point(149, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 20);
			this.label2.TabIndex = 113;
			this.label2.Text = "a";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(13, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 20);
			this.label1.TabIndex = 112;
			this.label1.Text = "de";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// udMesI
			// 
			this.udMesI.BackColor = System.Drawing.SystemColors.Window;
			this.udMesI.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.udMesI.Location = new System.Drawing.Point(66, 35);
			this.udMesI.Maximum = new decimal(new int[] {
			13,
			0,
			0,
			0});
			this.udMesI.Name = "udMesI";
			this.udMesI.Size = new System.Drawing.Size(40, 20);
			this.udMesI.TabIndex = 1;
			this.udMesI.Value = new decimal(new int[] {
			12,
			0,
			0,
			0});
			this.udMesI.ValueChanged += new System.EventHandler(this.UdMesValueChanged);
			// 
			// ckbData
			// 
			this.ckbData.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.ckbData.Location = new System.Drawing.Point(66, 10);
			this.ckbData.Name = "ckbData";
			this.ckbData.Size = new System.Drawing.Size(130, 24);
			this.ckbData.TabIndex = 0;
			this.ckbData.Text = "Data de Emissão";
			this.ckbData.UseVisualStyleBackColor = true;
			// 
			// label9
			// 
			this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label9.Location = new System.Drawing.Point(519, 130);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(25, 20);
			this.label9.TabIndex = 114;
			this.label9.Text = "até";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpCadastroF
			// 
			this.dtpCadastroF.Checked = false;
			this.dtpCadastroF.CustomFormat = "dd/MM/yyyy";
			this.dtpCadastroF.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpCadastroF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpCadastroF.Location = new System.Drawing.Point(554, 130);
			this.dtpCadastroF.Name = "dtpCadastroF";
			this.dtpCadastroF.ShowCheckBox = true;
			this.dtpCadastroF.Size = new System.Drawing.Size(110, 20);
			this.dtpCadastroF.TabIndex = 8;
			// 
			// label13
			// 
			this.label13.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label13.Location = new System.Drawing.Point(314, 130);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(80, 20);
			this.label13.TabIndex = 113;
			this.label13.Text = "Cadastrado de";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpCadastroI
			// 
			this.dtpCadastroI.Checked = false;
			this.dtpCadastroI.CustomFormat = "dd/MM/yyyy";
			this.dtpCadastroI.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpCadastroI.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpCadastroI.Location = new System.Drawing.Point(399, 130);
			this.dtpCadastroI.Name = "dtpCadastroI";
			this.dtpCadastroI.ShowCheckBox = true;
			this.dtpCadastroI.Size = new System.Drawing.Size(110, 20);
			this.dtpCadastroI.TabIndex = 7;
			// 
			// chkTodas
			// 
			this.chkTodas.Location = new System.Drawing.Point(365, 315);
			this.chkTodas.Name = "chkTodas";
			this.chkTodas.Size = new System.Drawing.Size(144, 24);
			this.chkTodas.TabIndex = 124;
			this.chkTodas.Text = "Marca/Desmarca Todas";
			this.chkTodas.UseVisualStyleBackColor = true;
			this.chkTodas.CheckedChanged += new System.EventHandler(this.ChkTodasCheckedChanged);
			// 
			// dgvSituacoes
			// 
			this.dgvSituacoes.AllowUserToAddRows = false;
			this.dgvSituacoes.AllowUserToDeleteRows = false;
			this.dgvSituacoes.AllowUserToResizeColumns = false;
			this.dgvSituacoes.AllowUserToResizeRows = false;
			this.dgvSituacoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvSituacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvSituacoes.DefaultCellStyle = dataGridViewCellStyle1;
			this.dgvSituacoes.Location = new System.Drawing.Point(115, 220);
			this.dgvSituacoes.MultiSelect = false;
			this.dgvSituacoes.Name = "dgvSituacoes";
			this.dgvSituacoes.RowHeadersVisible = false;
			this.dgvSituacoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSituacoes.Size = new System.Drawing.Size(394, 90);
			this.dgvSituacoes.TabIndex = 123;
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label3.Location = new System.Drawing.Point(9, 220);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 20);
			this.label3.TabIndex = 125;
			this.label3.Text = "Situação";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtResumo
			// 
			this.edtResumo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtResumo.Location = new System.Drawing.Point(115, 342);
			this.edtResumo.MaxLength = 50;
			this.edtResumo.Name = "edtResumo";
			this.edtResumo.Size = new System.Drawing.Size(394, 20);
			this.edtResumo.TabIndex = 126;
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label4.Location = new System.Drawing.Point(10, 342);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 20);
			this.label4.TabIndex = 127;
			this.label4.Text = "Resumo";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// frmFiltroOrcamento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(804, 452);
			this.Name = "frmFiltroOrcamento";
			this.Text = "Filtro de Orçamentos";
			this.Load += new System.EventHandler(this.FrmFiltroOrcamentoLoad);
			this.Shown += new System.EventHandler(this.FrmFiltroOrcamentoShown);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.udMesF)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.udMesI)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvSituacoes)).EndInit();
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.DateTimePicker dtpCadastroI;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.DateTimePicker dtpCadastroF;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.NumericUpDown udMesI;
		public System.Windows.Forms.TextBox edtAnoI;
		private System.Windows.Forms.NumericUpDown udMesF;
		public System.Windows.Forms.TextBox edtAnoF;
		private System.Windows.Forms.CheckBox ckbData;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label6;
		public System.Windows.Forms.ComboBox cbxCaracteristicas;
		private System.Windows.Forms.Label lblConsultor;
		public System.Windows.Forms.TextBox edtConsultor;
		private System.Windows.Forms.Button btnConsultor;
		private System.Windows.Forms.Label lblCliente;
		public System.Windows.Forms.TextBox edtCliente;
		private System.Windows.Forms.Button btnCliente;
		private System.Windows.Forms.Label lblVendedor;
		public System.Windows.Forms.ComboBox cbxUsuarios;
		private System.Windows.Forms.Button btnFornecedor;
		public System.Windows.Forms.CheckBox chkTodas;
		public System.Windows.Forms.DataGridView dgvSituacoes;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.TextBox edtResumo;
		private System.Windows.Forms.Label label4;
	}
}
