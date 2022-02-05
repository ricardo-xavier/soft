/*
 * Usuário: Ricardo
 * Data: 17/04/2008
 * Hora: 23:29
 * 
 */
namespace basico
{
	partial class frmFiltroPedido
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFiltroPedido));
			this.cbxUsuarios = new System.Windows.Forms.ComboBox();
			this.lblVendedor = new System.Windows.Forms.Label();
			this.edtCliente = new System.Windows.Forms.TextBox();
			this.lblCliente = new System.Windows.Forms.Label();
			this.edtConsultor = new System.Windows.Forms.TextBox();
			this.lblConsultor = new System.Windows.Forms.Label();
			this.gbxEntrega = new System.Windows.Forms.GroupBox();
			this.label15 = new System.Windows.Forms.Label();
			this.edtNaoEntregues = new System.Windows.Forms.TextBox();
			this.chkNaoEntregues = new System.Windows.Forms.CheckBox();
			this.label6 = new System.Windows.Forms.Label();
			this.chkOuEntrega = new System.Windows.Forms.CheckBox();
			this.dtpEntregaRealF = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.dtpEntregaPrevistaF = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.dtpEntregaRealI = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.dtpEntregaPrevistaI = new System.Windows.Forms.DateTimePicker();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label16 = new System.Windows.Forms.Label();
			this.edtNaoMontados = new System.Windows.Forms.TextBox();
			this.chkNaoMontados = new System.Windows.Forms.CheckBox();
			this.chkOuMontagem = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.dtpMontagemRealF = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.dtpMontagemPrevistaF = new System.Windows.Forms.DateTimePicker();
			this.label7 = new System.Windows.Forms.Label();
			this.dtpMontagemRealI = new System.Windows.Forms.DateTimePicker();
			this.label8 = new System.Windows.Forms.Label();
			this.dtpMontagemPrevistaI = new System.Windows.Forms.DateTimePicker();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label12 = new System.Windows.Forms.Label();
			this.edtNFFornec = new System.Windows.Forms.TextBox();
			this.chkEntragaMontagem = new System.Windows.Forms.Label();
			this.edtPedidoFornec = new System.Windows.Forms.TextBox();
			this.edtObservacao = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label11 = new System.Windows.Forms.Label();
			this.dtpDataF = new System.Windows.Forms.DateTimePicker();
			this.label14 = new System.Windows.Forms.Label();
			this.dtpDataI = new System.Windows.Forms.DateTimePicker();
			this.btnFornecedor = new System.Windows.Forms.Button();
			this.btnCliente = new System.Windows.Forms.Button();
			this.btnConsultor = new System.Windows.Forms.Button();
			this.chkAnosAnteriores = new System.Windows.Forms.CheckBox();
			this.chkSemPrevisao = new System.Windows.Forms.CheckBox();
			this.label9 = new System.Windows.Forms.Label();
			this.dtpCadastroF = new System.Windows.Forms.DateTimePicker();
			this.label13 = new System.Windows.Forms.Label();
			this.dtpCadastroI = new System.Windows.Forms.DateTimePicker();
			this.chkPendentesConsultor = new System.Windows.Forms.CheckBox();
			this.chkPendentesVendedor = new System.Windows.Forms.CheckBox();
			this.label21 = new System.Windows.Forms.Label();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.label18 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.edtVlrFinal = new System.Windows.Forms.TextBox();
			this.edtVlrInicial = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.edtPedido = new System.Windows.Forms.TextBox();
			this.cbxCaracteristicas = new System.Windows.Forms.ComboBox();
			this.label20 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.gbxEntrega.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
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
			this.lblTitulo.Text = "Filtro de Pedidos";
			// 
			// btnLimpa
			// 
			this.btnLimpa.Location = new System.Drawing.Point(702, 114);
			this.btnLimpa.TabIndex = 6;
			this.btnLimpa.Click += new System.EventHandler(this.BtnLimpaClick);
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(702, 83);
			this.btnCancela.TabIndex = 4;
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(702, 52);
			this.btnConfirma.TabIndex = 2;
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.cbxCaracteristicas);
			this.panel1.Controls.Add(this.label20);
			this.panel1.Controls.Add(this.label19);
			this.panel1.Controls.Add(this.edtPedido);
			this.panel1.Controls.Add(this.groupBox4);
			this.panel1.Controls.Add(this.chkPendentesVendedor);
			this.panel1.Controls.Add(this.chkPendentesConsultor);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.chkSemPrevisao);
			this.panel1.Controls.Add(this.dtpCadastroF);
			this.panel1.Controls.Add(this.label13);
			this.panel1.Controls.Add(this.chkAnosAnteriores);
			this.panel1.Controls.Add(this.dtpCadastroI);
			this.panel1.Controls.Add(this.btnConsultor);
			this.panel1.Controls.Add(this.btnCliente);
			this.panel1.Controls.Add(this.btnFornecedor);
			this.panel1.Controls.Add(this.groupBox3);
			this.panel1.Controls.Add(this.edtObservacao);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.groupBox2);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Controls.Add(this.gbxEntrega);
			this.panel1.Controls.Add(this.edtConsultor);
			this.panel1.Controls.Add(this.lblConsultor);
			this.panel1.Controls.Add(this.edtCliente);
			this.panel1.Controls.Add(this.lblCliente);
			this.panel1.Controls.Add(this.cbxUsuarios);
			this.panel1.Controls.Add(this.lblVendedor);
			this.panel1.Location = new System.Drawing.Point(3, 51);
			this.panel1.Size = new System.Drawing.Size(693, 550);
			this.panel1.Controls.SetChildIndex(this.lblVendedor, 0);
			this.panel1.Controls.SetChildIndex(this.cbxUsuarios, 0);
			this.panel1.Controls.SetChildIndex(this.lblCliente, 0);
			this.panel1.Controls.SetChildIndex(this.edtCliente, 0);
			this.panel1.Controls.SetChildIndex(this.lblConsultor, 0);
			this.panel1.Controls.SetChildIndex(this.edtConsultor, 0);
			this.panel1.Controls.SetChildIndex(this.gbxEntrega, 0);
			this.panel1.Controls.SetChildIndex(this.groupBox1, 0);
			this.panel1.Controls.SetChildIndex(this.groupBox2, 0);
			this.panel1.Controls.SetChildIndex(this.label10, 0);
			this.panel1.Controls.SetChildIndex(this.edtObservacao, 0);
			this.panel1.Controls.SetChildIndex(this.groupBox3, 0);
			this.panel1.Controls.SetChildIndex(this.btnFornecedor, 0);
			this.panel1.Controls.SetChildIndex(this.btnCliente, 0);
			this.panel1.Controls.SetChildIndex(this.btnConsultor, 0);
			this.panel1.Controls.SetChildIndex(this.dtpCadastroI, 0);
			this.panel1.Controls.SetChildIndex(this.chkAnosAnteriores, 0);
			this.panel1.Controls.SetChildIndex(this.label13, 0);
			this.panel1.Controls.SetChildIndex(this.dtpCadastroF, 0);
			this.panel1.Controls.SetChildIndex(this.chkSemPrevisao, 0);
			this.panel1.Controls.SetChildIndex(this.label9, 0);
			this.panel1.Controls.SetChildIndex(this.chkPendentesConsultor, 0);
			this.panel1.Controls.SetChildIndex(this.chkPendentesVendedor, 0);
			this.panel1.Controls.SetChildIndex(this.groupBox4, 0);
			this.panel1.Controls.SetChildIndex(this.lblCodigo, 0);
			this.panel1.Controls.SetChildIndex(this.lblDescricao, 0);
			this.panel1.Controls.SetChildIndex(this.edtCodigo, 0);
			this.panel1.Controls.SetChildIndex(this.edtDescricao, 0);
			this.panel1.Controls.SetChildIndex(this.edtPedido, 0);
			this.panel1.Controls.SetChildIndex(this.label19, 0);
			this.panel1.Controls.SetChildIndex(this.label20, 0);
			this.panel1.Controls.SetChildIndex(this.cbxCaracteristicas, 0);
			// 
			// cbxUsuarios
			// 
			this.cbxUsuarios.BackColor = System.Drawing.SystemColors.Window;
			this.cbxUsuarios.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxUsuarios.FormattingEnabled = true;
			this.cbxUsuarios.Location = new System.Drawing.Point(114, 330);
			this.cbxUsuarios.Name = "cbxUsuarios";
			this.cbxUsuarios.Size = new System.Drawing.Size(166, 22);
			this.cbxUsuarios.TabIndex = 10;
			// 
			// lblVendedor
			// 
			this.lblVendedor.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblVendedor.Location = new System.Drawing.Point(9, 330);
			this.lblVendedor.Name = "lblVendedor";
			this.lblVendedor.Size = new System.Drawing.Size(100, 20);
			this.lblVendedor.TabIndex = 12;
			this.lblVendedor.Text = "Vendedor";
			this.lblVendedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtCliente
			// 
			this.edtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtCliente.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtCliente.Location = new System.Drawing.Point(114, 360);
			this.edtCliente.MaxLength = 50;
			this.edtCliente.Name = "edtCliente";
			this.edtCliente.Size = new System.Drawing.Size(146, 20);
			this.edtCliente.TabIndex = 18;
			// 
			// lblCliente
			// 
			this.lblCliente.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCliente.Location = new System.Drawing.Point(8, 360);
			this.lblCliente.Name = "lblCliente";
			this.lblCliente.Size = new System.Drawing.Size(100, 20);
			this.lblCliente.TabIndex = 94;
			this.lblCliente.Text = "Cliente";
			this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtConsultor
			// 
			this.edtConsultor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtConsultor.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtConsultor.Location = new System.Drawing.Point(114, 390);
			this.edtConsultor.MaxLength = 50;
			this.edtConsultor.Name = "edtConsultor";
			this.edtConsultor.Size = new System.Drawing.Size(146, 20);
			this.edtConsultor.TabIndex = 24;
			// 
			// lblConsultor
			// 
			this.lblConsultor.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblConsultor.Location = new System.Drawing.Point(9, 390);
			this.lblConsultor.Name = "lblConsultor";
			this.lblConsultor.Size = new System.Drawing.Size(100, 20);
			this.lblConsultor.TabIndex = 100;
			this.lblConsultor.Text = "Consultor";
			this.lblConsultor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// gbxEntrega
			// 
			this.gbxEntrega.Controls.Add(this.label15);
			this.gbxEntrega.Controls.Add(this.edtNaoEntregues);
			this.gbxEntrega.Controls.Add(this.chkNaoEntregues);
			this.gbxEntrega.Controls.Add(this.label6);
			this.gbxEntrega.Controls.Add(this.chkOuEntrega);
			this.gbxEntrega.Controls.Add(this.dtpEntregaRealF);
			this.gbxEntrega.Controls.Add(this.label5);
			this.gbxEntrega.Controls.Add(this.dtpEntregaPrevistaF);
			this.gbxEntrega.Controls.Add(this.label2);
			this.gbxEntrega.Controls.Add(this.dtpEntregaRealI);
			this.gbxEntrega.Controls.Add(this.label1);
			this.gbxEntrega.Controls.Add(this.dtpEntregaPrevistaI);
			this.gbxEntrega.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.gbxEntrega.Location = new System.Drawing.Point(58, 111);
			this.gbxEntrega.Name = "gbxEntrega";
			this.gbxEntrega.Size = new System.Drawing.Size(368, 105);
			this.gbxEntrega.TabIndex = 6;
			this.gbxEntrega.TabStop = false;
			this.gbxEntrega.Text = "Entrega";
			// 
			// label15
			// 
			this.label15.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label15.Location = new System.Drawing.Point(255, 73);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(28, 20);
			this.label15.TabIndex = 85;
			this.label15.Text = "dias";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtNaoEntregues
			// 
			this.edtNaoEntregues.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtNaoEntregues.Location = new System.Drawing.Point(235, 73);
			this.edtNaoEntregues.Name = "edtNaoEntregues";
			this.edtNaoEntregues.Size = new System.Drawing.Size(20, 20);
			this.edtNaoEntregues.TabIndex = 84;
			this.edtNaoEntregues.Text = "0";
			this.edtNaoEntregues.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// chkNaoEntregues
			// 
			this.chkNaoEntregues.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkNaoEntregues.Location = new System.Drawing.Point(80, 73);
			this.chkNaoEntregues.Name = "chkNaoEntregues";
			this.chkNaoEntregues.Size = new System.Drawing.Size(152, 24);
			this.chkNaoEntregues.TabIndex = 83;
			this.chkNaoEntregues.Text = "Não entregues há mais de";
			this.chkNaoEntregues.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label6.Location = new System.Drawing.Point(200, 50);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(25, 20);
			this.label6.TabIndex = 82;
			this.label6.Text = "até";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// chkOuEntrega
			// 
			this.chkOuEntrega.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkOuEntrega.Location = new System.Drawing.Point(370, 35);
			this.chkOuEntrega.Name = "chkOuEntrega";
			this.chkOuEntrega.Size = new System.Drawing.Size(155, 24);
			this.chkOuEntrega.TabIndex = 8;
			this.chkOuEntrega.Text = "Prevista ou Realizada";
			this.chkOuEntrega.UseVisualStyleBackColor = true;
			this.chkOuEntrega.Visible = false;
			this.chkOuEntrega.CheckedChanged += new System.EventHandler(this.ChkOuEntregaCheckedChanged);
			// 
			// dtpEntregaRealF
			// 
			this.dtpEntregaRealF.Checked = false;
			this.dtpEntregaRealF.CustomFormat = "dd/MM/yyyy";
			this.dtpEntregaRealF.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpEntregaRealF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpEntregaRealF.Location = new System.Drawing.Point(235, 50);
			this.dtpEntregaRealF.Name = "dtpEntregaRealF";
			this.dtpEntregaRealF.ShowCheckBox = true;
			this.dtpEntregaRealF.Size = new System.Drawing.Size(110, 20);
			this.dtpEntregaRealF.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label5.Location = new System.Drawing.Point(200, 20);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(25, 20);
			this.label5.TabIndex = 80;
			this.label5.Text = "até";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpEntregaPrevistaF
			// 
			this.dtpEntregaPrevistaF.Checked = false;
			this.dtpEntregaPrevistaF.CustomFormat = "dd/MM/yyyy";
			this.dtpEntregaPrevistaF.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpEntregaPrevistaF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpEntregaPrevistaF.Location = new System.Drawing.Point(235, 20);
			this.dtpEntregaPrevistaF.Name = "dtpEntregaPrevistaF";
			this.dtpEntregaPrevistaF.ShowCheckBox = true;
			this.dtpEntregaPrevistaF.Size = new System.Drawing.Size(110, 20);
			this.dtpEntregaPrevistaF.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label2.Location = new System.Drawing.Point(5, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 20);
			this.label2.TabIndex = 78;
			this.label2.Text = "Realizada de";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpEntregaRealI
			// 
			this.dtpEntregaRealI.Checked = false;
			this.dtpEntregaRealI.CustomFormat = "dd/MM/yyyy";
			this.dtpEntregaRealI.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpEntregaRealI.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpEntregaRealI.Location = new System.Drawing.Point(80, 50);
			this.dtpEntregaRealI.Name = "dtpEntregaRealI";
			this.dtpEntregaRealI.ShowCheckBox = true;
			this.dtpEntregaRealI.Size = new System.Drawing.Size(110, 20);
			this.dtpEntregaRealI.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(5, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 20);
			this.label1.TabIndex = 76;
			this.label1.Text = "Prevista de";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpEntregaPrevistaI
			// 
			this.dtpEntregaPrevistaI.Checked = false;
			this.dtpEntregaPrevistaI.CustomFormat = "dd/MM/yyyy";
			this.dtpEntregaPrevistaI.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpEntregaPrevistaI.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpEntregaPrevistaI.Location = new System.Drawing.Point(80, 20);
			this.dtpEntregaPrevistaI.Name = "dtpEntregaPrevistaI";
			this.dtpEntregaPrevistaI.ShowCheckBox = true;
			this.dtpEntregaPrevistaI.Size = new System.Drawing.Size(110, 20);
			this.dtpEntregaPrevistaI.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label16);
			this.groupBox1.Controls.Add(this.edtNaoMontados);
			this.groupBox1.Controls.Add(this.chkNaoMontados);
			this.groupBox1.Controls.Add(this.chkOuMontagem);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.dtpMontagemRealF);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.dtpMontagemPrevistaF);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.dtpMontagemRealI);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.dtpMontagemPrevistaI);
			this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.groupBox1.Location = new System.Drawing.Point(58, 222);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(368, 102);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Montagem";
			// 
			// label16
			// 
			this.label16.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label16.Location = new System.Drawing.Point(255, 76);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(28, 20);
			this.label16.TabIndex = 87;
			this.label16.Text = "dias";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtNaoMontados
			// 
			this.edtNaoMontados.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtNaoMontados.Location = new System.Drawing.Point(235, 76);
			this.edtNaoMontados.Name = "edtNaoMontados";
			this.edtNaoMontados.Size = new System.Drawing.Size(20, 20);
			this.edtNaoMontados.TabIndex = 86;
			this.edtNaoMontados.Text = "0";
			this.edtNaoMontados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// chkNaoMontados
			// 
			this.chkNaoMontados.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkNaoMontados.Location = new System.Drawing.Point(80, 76);
			this.chkNaoMontados.Name = "chkNaoMontados";
			this.chkNaoMontados.Size = new System.Drawing.Size(152, 24);
			this.chkNaoMontados.TabIndex = 83;
			this.chkNaoMontados.Text = "Não montados há mais de";
			this.chkNaoMontados.UseVisualStyleBackColor = true;
			// 
			// chkOuMontagem
			// 
			this.chkOuMontagem.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkOuMontagem.Location = new System.Drawing.Point(370, 34);
			this.chkOuMontagem.Name = "chkOuMontagem";
			this.chkOuMontagem.Size = new System.Drawing.Size(155, 24);
			this.chkOuMontagem.TabIndex = 8;
			this.chkOuMontagem.Text = "Prevista ou Realizada";
			this.chkOuMontagem.UseVisualStyleBackColor = true;
			this.chkOuMontagem.Visible = false;
			this.chkOuMontagem.CheckedChanged += new System.EventHandler(this.ChkOuMontagemCheckedChanged);
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label3.Location = new System.Drawing.Point(200, 50);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(25, 20);
			this.label3.TabIndex = 82;
			this.label3.Text = "até";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpMontagemRealF
			// 
			this.dtpMontagemRealF.Checked = false;
			this.dtpMontagemRealF.CustomFormat = "dd/MM/yyyy";
			this.dtpMontagemRealF.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpMontagemRealF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpMontagemRealF.Location = new System.Drawing.Point(235, 50);
			this.dtpMontagemRealF.Name = "dtpMontagemRealF";
			this.dtpMontagemRealF.ShowCheckBox = true;
			this.dtpMontagemRealF.Size = new System.Drawing.Size(110, 20);
			this.dtpMontagemRealF.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label4.Location = new System.Drawing.Point(200, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(25, 20);
			this.label4.TabIndex = 80;
			this.label4.Text = "até";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpMontagemPrevistaF
			// 
			this.dtpMontagemPrevistaF.Checked = false;
			this.dtpMontagemPrevistaF.CustomFormat = "dd/MM/yyyy";
			this.dtpMontagemPrevistaF.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpMontagemPrevistaF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpMontagemPrevistaF.Location = new System.Drawing.Point(235, 20);
			this.dtpMontagemPrevistaF.Name = "dtpMontagemPrevistaF";
			this.dtpMontagemPrevistaF.ShowCheckBox = true;
			this.dtpMontagemPrevistaF.Size = new System.Drawing.Size(110, 20);
			this.dtpMontagemPrevistaF.TabIndex = 2;
			// 
			// label7
			// 
			this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label7.Location = new System.Drawing.Point(5, 50);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(70, 20);
			this.label7.TabIndex = 78;
			this.label7.Text = "Realizada de";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpMontagemRealI
			// 
			this.dtpMontagemRealI.Checked = false;
			this.dtpMontagemRealI.CustomFormat = "dd/MM/yyyy";
			this.dtpMontagemRealI.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpMontagemRealI.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpMontagemRealI.Location = new System.Drawing.Point(80, 50);
			this.dtpMontagemRealI.Name = "dtpMontagemRealI";
			this.dtpMontagemRealI.ShowCheckBox = true;
			this.dtpMontagemRealI.Size = new System.Drawing.Size(110, 20);
			this.dtpMontagemRealI.TabIndex = 4;
			// 
			// label8
			// 
			this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label8.Location = new System.Drawing.Point(5, 20);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(70, 20);
			this.label8.TabIndex = 76;
			this.label8.Text = "Prevista de";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpMontagemPrevistaI
			// 
			this.dtpMontagemPrevistaI.Checked = false;
			this.dtpMontagemPrevistaI.CustomFormat = "dd/MM/yyyy";
			this.dtpMontagemPrevistaI.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpMontagemPrevistaI.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpMontagemPrevistaI.Location = new System.Drawing.Point(80, 20);
			this.dtpMontagemPrevistaI.Name = "dtpMontagemPrevistaI";
			this.dtpMontagemPrevistaI.ShowCheckBox = true;
			this.dtpMontagemPrevistaI.Size = new System.Drawing.Size(110, 20);
			this.dtpMontagemPrevistaI.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.edtNFFornec);
			this.groupBox2.Controls.Add(this.chkEntragaMontagem);
			this.groupBox2.Controls.Add(this.edtPedidoFornec);
			this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.groupBox2.Location = new System.Drawing.Point(437, 222);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(159, 80);
			this.groupBox2.TabIndex = 12;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Fornecedor";
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
			this.edtNFFornec.Name = "edtNFFornec";
			this.edtNFFornec.Size = new System.Drawing.Size(69, 20);
			this.edtNFFornec.TabIndex = 1;
			// 
			// chkEntragaMontagem
			// 
			this.chkEntragaMontagem.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkEntragaMontagem.Location = new System.Drawing.Point(2, 18);
			this.chkEntragaMontagem.Name = "chkEntragaMontagem";
			this.chkEntragaMontagem.Size = new System.Drawing.Size(60, 20);
			this.chkEntragaMontagem.TabIndex = 143;
			this.chkEntragaMontagem.Text = "Pedido";
			this.chkEntragaMontagem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtPedidoFornec
			// 
			this.edtPedidoFornec.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtPedidoFornec.Location = new System.Drawing.Point(68, 19);
			this.edtPedidoFornec.Name = "edtPedidoFornec";
			this.edtPedidoFornec.Size = new System.Drawing.Size(69, 20);
			this.edtPedidoFornec.TabIndex = 0;
			// 
			// edtObservacao
			// 
			this.edtObservacao.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtObservacao.Location = new System.Drawing.Point(114, 420);
			this.edtObservacao.MaxLength = 50;
			this.edtObservacao.Name = "edtObservacao";
			this.edtObservacao.Size = new System.Drawing.Size(375, 20);
			this.edtObservacao.TabIndex = 28;
			// 
			// label10
			// 
			this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label10.Location = new System.Drawing.Point(9, 419);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 20);
			this.label10.TabIndex = 103;
			this.label10.Text = "Observacao";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label11);
			this.groupBox3.Controls.Add(this.dtpDataF);
			this.groupBox3.Controls.Add(this.label14);
			this.groupBox3.Controls.Add(this.dtpDataI);
			this.groupBox3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.groupBox3.Location = new System.Drawing.Point(58, 43);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(368, 53);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Data do Pedido";
			// 
			// label11
			// 
			this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label11.Location = new System.Drawing.Point(200, 20);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(25, 20);
			this.label11.TabIndex = 80;
			this.label11.Text = "até";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpDataF
			// 
			this.dtpDataF.Checked = false;
			this.dtpDataF.CustomFormat = "dd/MM/yyyy";
			this.dtpDataF.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpDataF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDataF.Location = new System.Drawing.Point(235, 20);
			this.dtpDataF.Name = "dtpDataF";
			this.dtpDataF.ShowCheckBox = true;
			this.dtpDataF.Size = new System.Drawing.Size(110, 20);
			this.dtpDataF.TabIndex = 2;
			// 
			// label14
			// 
			this.label14.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label14.Location = new System.Drawing.Point(5, 20);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(70, 20);
			this.label14.TabIndex = 76;
			this.label14.Text = "De";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpDataI
			// 
			this.dtpDataI.Checked = false;
			this.dtpDataI.CustomFormat = "dd/MM/yyyy";
			this.dtpDataI.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpDataI.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDataI.Location = new System.Drawing.Point(80, 20);
			this.dtpDataI.Name = "dtpDataI";
			this.dtpDataI.ShowCheckBox = true;
			this.dtpDataI.Size = new System.Drawing.Size(110, 20);
			this.dtpDataI.TabIndex = 0;
			// 
			// btnFornecedor
			// 
			this.btnFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("btnFornecedor.Image")));
			this.btnFornecedor.Location = new System.Drawing.Point(268, 9);
			this.btnFornecedor.Name = "btnFornecedor";
			this.btnFornecedor.Size = new System.Drawing.Size(36, 23);
			this.btnFornecedor.TabIndex = 1;
			this.btnFornecedor.UseVisualStyleBackColor = true;
			this.btnFornecedor.Click += new System.EventHandler(this.BtnFornecedorClick);
			// 
			// btnCliente
			// 
			this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
			this.btnCliente.Location = new System.Drawing.Point(269, 360);
			this.btnCliente.Name = "btnCliente";
			this.btnCliente.Size = new System.Drawing.Size(36, 23);
			this.btnCliente.TabIndex = 18;
			this.btnCliente.UseVisualStyleBackColor = true;
			this.btnCliente.Click += new System.EventHandler(this.BtnClienteClick);
			// 
			// btnConsultor
			// 
			this.btnConsultor.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultor.Image")));
			this.btnConsultor.Location = new System.Drawing.Point(269, 388);
			this.btnConsultor.Name = "btnConsultor";
			this.btnConsultor.Size = new System.Drawing.Size(36, 23);
			this.btnConsultor.TabIndex = 26;
			this.btnConsultor.UseVisualStyleBackColor = true;
			this.btnConsultor.Click += new System.EventHandler(this.BtnConsultorClick);
			// 
			// chkAnosAnteriores
			// 
			this.chkAnosAnteriores.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkAnosAnteriores.Location = new System.Drawing.Point(116, 448);
			this.chkAnosAnteriores.Name = "chkAnosAnteriores";
			this.chkAnosAnteriores.Size = new System.Drawing.Size(373, 24);
			this.chkAnosAnteriores.TabIndex = 30;
			this.chkAnosAnteriores.Text = "Não mostrar pedidos fechados de anos anteriores";
			this.chkAnosAnteriores.UseVisualStyleBackColor = true;
			// 
			// chkSemPrevisao
			// 
			this.chkSemPrevisao.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkSemPrevisao.Location = new System.Drawing.Point(116, 471);
			this.chkSemPrevisao.Name = "chkSemPrevisao";
			this.chkSemPrevisao.Size = new System.Drawing.Size(373, 24);
			this.chkSemPrevisao.TabIndex = 32;
			this.chkSemPrevisao.Text = "Selecionar Pedidos Entregues sem Previsão de Recebimento";
			this.chkSemPrevisao.UseVisualStyleBackColor = true;
			// 
			// label9
			// 
			this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label9.Location = new System.Drawing.Point(516, 363);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(25, 20);
			this.label9.TabIndex = 86;
			this.label9.Text = "até";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpCadastroF
			// 
			this.dtpCadastroF.Checked = false;
			this.dtpCadastroF.CustomFormat = "dd/MM/yyyy";
			this.dtpCadastroF.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpCadastroF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpCadastroF.Location = new System.Drawing.Point(551, 363);
			this.dtpCadastroF.Name = "dtpCadastroF";
			this.dtpCadastroF.ShowCheckBox = true;
			this.dtpCadastroF.Size = new System.Drawing.Size(110, 20);
			this.dtpCadastroF.TabIndex = 22;
			// 
			// label13
			// 
			this.label13.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label13.Location = new System.Drawing.Point(311, 363);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(80, 20);
			this.label13.TabIndex = 85;
			this.label13.Text = "Cadastrado de";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpCadastroI
			// 
			this.dtpCadastroI.Checked = false;
			this.dtpCadastroI.CustomFormat = "dd/MM/yyyy";
			this.dtpCadastroI.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpCadastroI.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpCadastroI.Location = new System.Drawing.Point(396, 363);
			this.dtpCadastroI.Name = "dtpCadastroI";
			this.dtpCadastroI.ShowCheckBox = true;
			this.dtpCadastroI.Size = new System.Drawing.Size(110, 20);
			this.dtpCadastroI.TabIndex = 20;
			// 
			// chkPendentesConsultor
			// 
			this.chkPendentesConsultor.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkPendentesConsultor.Location = new System.Drawing.Point(116, 494);
			this.chkPendentesConsultor.Name = "chkPendentesConsultor";
			this.chkPendentesConsultor.Size = new System.Drawing.Size(373, 24);
			this.chkPendentesConsultor.TabIndex = 34;
			this.chkPendentesConsultor.Text = "Selecionar Pedidos sem Acerto % Consultor";
			this.chkPendentesConsultor.UseVisualStyleBackColor = true;
			// 
			// chkPendentesVendedor
			// 
			this.chkPendentesVendedor.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkPendentesVendedor.Location = new System.Drawing.Point(116, 517);
			this.chkPendentesVendedor.Name = "chkPendentesVendedor";
			this.chkPendentesVendedor.Size = new System.Drawing.Size(373, 24);
			this.chkPendentesVendedor.TabIndex = 36;
			this.chkPendentesVendedor.Text = "Selecionar Pedidos sem Acerto % Vendedor";
			this.chkPendentesVendedor.UseVisualStyleBackColor = true;
			// 
			// label21
			// 
			this.label21.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label21.Location = new System.Drawing.Point(5, 20);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(40, 20);
			this.label21.TabIndex = 76;
			this.label21.Text = "de";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// checkBox2
			// 
			this.checkBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.checkBox2.Location = new System.Drawing.Point(370, 35);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(155, 24);
			this.checkBox2.TabIndex = 8;
			this.checkBox2.Text = "Prevista ou Realizada";
			this.checkBox2.UseVisualStyleBackColor = true;
			this.checkBox2.Visible = false;
			// 
			// label18
			// 
			this.label18.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label18.Location = new System.Drawing.Point(20, 50);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(25, 20);
			this.label18.TabIndex = 82;
			this.label18.Text = "até";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label17
			// 
			this.label17.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label17.Location = new System.Drawing.Point(255, 73);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(28, 20);
			this.label17.TabIndex = 85;
			this.label17.Text = "dias";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.edtVlrFinal);
			this.groupBox4.Controls.Add(this.edtVlrInicial);
			this.groupBox4.Controls.Add(this.label17);
			this.groupBox4.Controls.Add(this.label18);
			this.groupBox4.Controls.Add(this.checkBox2);
			this.groupBox4.Controls.Add(this.label21);
			this.groupBox4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.groupBox4.Location = new System.Drawing.Point(432, 111);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(165, 83);
			this.groupBox4.TabIndex = 8;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Valor";
			// 
			// edtVlrFinal
			// 
			this.edtVlrFinal.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtVlrFinal.Location = new System.Drawing.Point(51, 50);
			this.edtVlrFinal.Name = "edtVlrFinal";
			this.edtVlrFinal.Size = new System.Drawing.Size(100, 20);
			this.edtVlrFinal.TabIndex = 87;
			this.edtVlrFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// edtVlrInicial
			// 
			this.edtVlrInicial.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtVlrInicial.Location = new System.Drawing.Point(51, 19);
			this.edtVlrInicial.Name = "edtVlrInicial";
			this.edtVlrInicial.Size = new System.Drawing.Size(100, 20);
			this.edtVlrInicial.TabIndex = 86;
			this.edtVlrInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label19
			// 
			this.label19.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label19.Location = new System.Drawing.Point(448, 62);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(60, 20);
			this.label19.TabIndex = 145;
			this.label19.Text = "Pedido";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtPedido
			// 
			this.edtPedido.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtPedido.Location = new System.Drawing.Point(514, 63);
			this.edtPedido.Name = "edtPedido";
			this.edtPedido.Size = new System.Drawing.Size(69, 20);
			this.edtPedido.TabIndex = 4;
			// 
			// cbxCaracteristicas
			// 
			this.cbxCaracteristicas.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxCaracteristicas.FormattingEnabled = true;
			this.cbxCaracteristicas.Location = new System.Drawing.Point(417, 11);
			this.cbxCaracteristicas.Name = "cbxCaracteristicas";
			this.cbxCaracteristicas.Size = new System.Drawing.Size(166, 22);
			this.cbxCaracteristicas.TabIndex = 146;
			// 
			// label20
			// 
			this.label20.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label20.Location = new System.Drawing.Point(312, 11);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(100, 20);
			this.label20.TabIndex = 147;
			this.label20.Text = "Carac. Venda";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// frmFiltroPedido
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(814, 604);
			this.Name = "frmFiltroPedido";
			this.Text = "Filtro de Pedidos";
			this.Load += new System.EventHandler(this.FrmFiltroOrcamentoLoad);
			this.Shown += new System.EventHandler(this.FrmFiltroOrcamentoShown);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.gbxEntrega.ResumeLayout(false);
			this.gbxEntrega.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.TextBox edtPedido;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox edtVlrInicial;
		private System.Windows.Forms.TextBox edtVlrFinal;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.CheckBox chkNaoEntregues;
		private System.Windows.Forms.TextBox edtNaoEntregues;
		private System.Windows.Forms.CheckBox chkNaoMontados;
		private System.Windows.Forms.TextBox edtNaoMontados;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.CheckBox chkPendentesConsultor;
		private System.Windows.Forms.CheckBox chkPendentesVendedor;
		private System.Windows.Forms.DateTimePicker dtpCadastroI;
		private System.Windows.Forms.DateTimePicker dtpCadastroF;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.CheckBox chkSemPrevisao;
		private System.Windows.Forms.CheckBox chkAnosAnteriores;
		private System.Windows.Forms.CheckBox chkOuMontagem;
		private System.Windows.Forms.CheckBox chkOuEntrega;
		private System.Windows.Forms.DateTimePicker dtpDataF;
		private System.Windows.Forms.DateTimePicker dtpDataI;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label chkEntragaMontagem;
		private System.Windows.Forms.TextBox edtPedidoFornec;
		private System.Windows.Forms.TextBox edtNFFornec;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label10;
		public System.Windows.Forms.TextBox edtObservacao;
		private System.Windows.Forms.Button btnConsultor;
		private System.Windows.Forms.Button btnCliente;
		private System.Windows.Forms.DateTimePicker dtpEntregaRealF;
		private System.Windows.Forms.DateTimePicker dtpEntregaRealI;
		private System.Windows.Forms.DateTimePicker dtpEntregaPrevistaI;
		private System.Windows.Forms.DateTimePicker dtpEntregaPrevistaF;
		private System.Windows.Forms.DateTimePicker dtpMontagemPrevistaI;
		private System.Windows.Forms.DateTimePicker dtpMontagemRealI;
		private System.Windows.Forms.DateTimePicker dtpMontagemPrevistaF;
		private System.Windows.Forms.DateTimePicker dtpMontagemRealF;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox gbxEntrega;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblConsultor;
		public System.Windows.Forms.TextBox edtConsultor;
		private System.Windows.Forms.Label lblCliente;
		public System.Windows.Forms.TextBox edtCliente;
		private System.Windows.Forms.Label lblVendedor;
		public System.Windows.Forms.ComboBox cbxUsuarios;
		private System.Windows.Forms.Button btnFornecedor;
		public System.Windows.Forms.ComboBox cbxCaracteristicas;
		private System.Windows.Forms.Label label20;
	}
}
