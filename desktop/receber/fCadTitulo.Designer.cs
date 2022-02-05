/*
 * Criado por SharpDevelop.
 * Usuário: Ricardo
 * Data: 22/07/2008
 * Hora: 22:57
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace receber
{
	partial class fCadTitulo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCadTitulo));
			this.lblCodigo = new System.Windows.Forms.Label();
			this.edtCodigo = new System.Windows.Forms.TextBox();
			this.edtParceiro = new System.Windows.Forms.TextBox();
			this.lblParceiro = new System.Windows.Forms.Label();
			this.lblUsuario = new System.Windows.Forms.Label();
			this.edtUsuario = new System.Windows.Forms.TextBox();
			this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
			this.lblEntrada = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dtpVencimento = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.cbxNaturezas = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.rbtVariavel = new System.Windows.Forms.RadioButton();
			this.rbtFixo = new System.Windows.Forms.RadioButton();
			this.edtValor = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.btnCancela = new System.Windows.Forms.Button();
			this.btnConfirma = new System.Windows.Forms.Button();
			this.cbxCodNaturezas = new System.Windows.Forms.ComboBox();
			this.cbxCodFormas = new System.Windows.Forms.ComboBox();
			this.gbxRecebimento = new System.Windows.Forms.GroupBox();
			this.btnFormas = new System.Windows.Forms.Button();
			this.cbxFormas = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.edtRecebido = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.dtpRecebimento = new System.Windows.Forms.DateTimePicker();
			this.label14 = new System.Windows.Forms.Label();
			this.gbxPendencia = new System.Windows.Forms.GroupBox();
			this.edtObservacao = new System.Windows.Forms.TextBox();
			this.cbxPendencias = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cbxCodPendencias = new System.Windows.Forms.ComboBox();
			this.edtSequencia = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.btnCliente = new System.Windows.Forms.Button();
			this.btnNatureza = new System.Windows.Forms.Button();
			this.btnPendencias = new System.Windows.Forms.Button();
			this.gbxCancelamento = new System.Windows.Forms.GroupBox();
			this.edtMotivo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.ckbCancelado = new System.Windows.Forms.CheckBox();
			this.btnPedido = new System.Windows.Forms.Button();
			this.cbxPedidos = new System.Windows.Forms.ComboBox();
			this.btnLote = new System.Windows.Forms.Button();
			this.gbxRecebimento.SuspendLayout();
			this.gbxPendencia.SuspendLayout();
			this.gbxCancelamento.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblCodigo
			// 
			this.lblCodigo.ForeColor = System.Drawing.Color.Red;
			this.lblCodigo.Location = new System.Drawing.Point(10, 10);
			this.lblCodigo.Name = "lblCodigo";
			this.lblCodigo.Size = new System.Drawing.Size(80, 20);
			this.lblCodigo.TabIndex = 84;
			this.lblCodigo.Text = "Nota Fiscal";
			this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtCodigo
			// 
			this.edtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtCodigo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtCodigo.Location = new System.Drawing.Point(95, 10);
			this.edtCodigo.MaxLength = 11;
			this.edtCodigo.Name = "edtCodigo";
			this.edtCodigo.Size = new System.Drawing.Size(83, 20);
			this.edtCodigo.TabIndex = 0;
			this.edtCodigo.Text = "12345678901";
			// 
			// edtParceiro
			// 
			this.edtParceiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtParceiro.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtParceiro.Location = new System.Drawing.Point(95, 70);
			this.edtParceiro.MaxLength = 20;
			this.edtParceiro.Name = "edtParceiro";
			this.edtParceiro.Size = new System.Drawing.Size(146, 20);
			this.edtParceiro.TabIndex = 4;
			// 
			// lblParceiro
			// 
			this.lblParceiro.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblParceiro.Location = new System.Drawing.Point(10, 70);
			this.lblParceiro.Name = "lblParceiro";
			this.lblParceiro.Size = new System.Drawing.Size(80, 20);
			this.lblParceiro.TabIndex = 100;
			this.lblParceiro.Text = "Cliente";
			this.lblParceiro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblUsuario
			// 
			this.lblUsuario.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblUsuario.Location = new System.Drawing.Point(10, 40);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(80, 20);
			this.lblUsuario.TabIndex = 101;
			this.lblUsuario.Text = "Usuário";
			this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtUsuario
			// 
			this.edtUsuario.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtUsuario.Location = new System.Drawing.Point(95, 40);
			this.edtUsuario.MaxLength = 20;
			this.edtUsuario.Name = "edtUsuario";
			this.edtUsuario.ReadOnly = true;
			this.edtUsuario.Size = new System.Drawing.Size(146, 20);
			this.edtUsuario.TabIndex = 2;
			// 
			// dtpEntrada
			// 
			this.dtpEntrada.CustomFormat = "dd/MM/yyyy";
			this.dtpEntrada.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpEntrada.Location = new System.Drawing.Point(415, 40);
			this.dtpEntrada.Name = "dtpEntrada";
			this.dtpEntrada.Size = new System.Drawing.Size(110, 20);
			this.dtpEntrada.TabIndex = 3;
			// 
			// lblEntrada
			// 
			this.lblEntrada.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblEntrada.Location = new System.Drawing.Point(330, 40);
			this.lblEntrada.Name = "lblEntrada";
			this.lblEntrada.Size = new System.Drawing.Size(80, 20);
			this.lblEntrada.TabIndex = 103;
			this.lblEntrada.Text = "Entrada";
			this.lblEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label2.Location = new System.Drawing.Point(10, 100);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 20);
			this.label2.TabIndex = 107;
			this.label2.Text = "Vencimento";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpVencimento
			// 
			this.dtpVencimento.CustomFormat = "dd/MM/yyyy";
			this.dtpVencimento.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpVencimento.Location = new System.Drawing.Point(95, 100);
			this.dtpVencimento.Name = "dtpVencimento";
			this.dtpVencimento.Size = new System.Drawing.Size(110, 20);
			this.dtpVencimento.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label3.Location = new System.Drawing.Point(330, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 20);
			this.label3.TabIndex = 108;
			this.label3.Text = "Natureza";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxNaturezas
			// 
			this.cbxNaturezas.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxNaturezas.FormattingEnabled = true;
			this.cbxNaturezas.Location = new System.Drawing.Point(415, 68);
			this.cbxNaturezas.Name = "cbxNaturezas";
			this.cbxNaturezas.Size = new System.Drawing.Size(166, 22);
			this.cbxNaturezas.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label4.Location = new System.Drawing.Point(10, 130);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 20);
			this.label4.TabIndex = 110;
			this.label4.Text = "Tipo";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label5.Location = new System.Drawing.Point(330, 98);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 20);
			this.label5.TabIndex = 112;
			this.label5.Text = "Valor Previsto";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// rbtVariavel
			// 
			this.rbtVariavel.Location = new System.Drawing.Point(150, 130);
			this.rbtVariavel.Name = "rbtVariavel";
			this.rbtVariavel.Size = new System.Drawing.Size(75, 22);
			this.rbtVariavel.TabIndex = 11;
			this.rbtVariavel.TabStop = true;
			this.rbtVariavel.Text = "Variável";
			this.rbtVariavel.UseVisualStyleBackColor = true;
			// 
			// rbtFixo
			// 
			this.rbtFixo.Location = new System.Drawing.Point(95, 130);
			this.rbtFixo.Name = "rbtFixo";
			this.rbtFixo.Size = new System.Drawing.Size(75, 22);
			this.rbtFixo.TabIndex = 10;
			this.rbtFixo.TabStop = true;
			this.rbtFixo.Text = "Fixo";
			this.rbtFixo.UseVisualStyleBackColor = true;
			// 
			// edtValor
			// 
			this.edtValor.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtValor.Location = new System.Drawing.Point(415, 98);
			this.edtValor.MaxLength = 12;
			this.edtValor.Name = "edtValor";
			this.edtValor.Size = new System.Drawing.Size(90, 20);
			this.edtValor.TabIndex = 12;
			this.edtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.edtValor.TextChanged += new System.EventHandler(this.EdtValorTextChanged);
			this.edtValor.Click += new System.EventHandler(this.EdtValorClick);
			this.edtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EdtValorKeyPress);
			this.edtValor.Enter += new System.EventHandler(this.EdtValorEnter);
			// 
			// label8
			// 
			this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label8.Location = new System.Drawing.Point(10, 160);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(80, 20);
			this.label8.TabIndex = 120;
			this.label8.Text = "Pedidos";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(531, 417);
			this.btnCancela.Name = "btnCancela";
			this.btnCancela.Size = new System.Drawing.Size(100, 25);
			this.btnCancela.TabIndex = 23;
			this.btnCancela.Text = "C&ancela";
			this.btnCancela.UseVisualStyleBackColor = true;
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(531, 389);
			this.btnConfirma.Name = "btnConfirma";
			this.btnConfirma.Size = new System.Drawing.Size(100, 25);
			this.btnConfirma.TabIndex = 22;
			this.btnConfirma.Text = "&Confirma";
			this.btnConfirma.UseVisualStyleBackColor = true;
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// cbxCodNaturezas
			// 
			this.cbxCodNaturezas.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxCodNaturezas.FormattingEnabled = true;
			this.cbxCodNaturezas.Location = new System.Drawing.Point(425, 313);
			this.cbxCodNaturezas.Name = "cbxCodNaturezas";
			this.cbxCodNaturezas.Size = new System.Drawing.Size(166, 22);
			this.cbxCodNaturezas.TabIndex = 127;
			this.cbxCodNaturezas.Visible = false;
			// 
			// cbxCodFormas
			// 
			this.cbxCodFormas.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxCodFormas.FormattingEnabled = true;
			this.cbxCodFormas.Location = new System.Drawing.Point(442, 313);
			this.cbxCodFormas.Name = "cbxCodFormas";
			this.cbxCodFormas.Size = new System.Drawing.Size(166, 22);
			this.cbxCodFormas.TabIndex = 128;
			this.cbxCodFormas.Visible = false;
			// 
			// gbxRecebimento
			// 
			this.gbxRecebimento.Controls.Add(this.btnFormas);
			this.gbxRecebimento.Controls.Add(this.cbxFormas);
			this.gbxRecebimento.Controls.Add(this.label12);
			this.gbxRecebimento.Controls.Add(this.edtRecebido);
			this.gbxRecebimento.Controls.Add(this.label13);
			this.gbxRecebimento.Controls.Add(this.dtpRecebimento);
			this.gbxRecebimento.Controls.Add(this.label14);
			this.gbxRecebimento.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.gbxRecebimento.Location = new System.Drawing.Point(0, 190);
			this.gbxRecebimento.Name = "gbxRecebimento";
			this.gbxRecebimento.Size = new System.Drawing.Size(637, 84);
			this.gbxRecebimento.TabIndex = 16;
			this.gbxRecebimento.TabStop = false;
			this.gbxRecebimento.Text = "Recebimento";
			// 
			// btnFormas
			// 
			this.btnFormas.Image = ((System.Drawing.Image)(resources.GetObject("btnFormas.Image")));
			this.btnFormas.Location = new System.Drawing.Point(267, 47);
			this.btnFormas.Name = "btnFormas";
			this.btnFormas.Size = new System.Drawing.Size(36, 23);
			this.btnFormas.TabIndex = 138;
			this.btnFormas.UseVisualStyleBackColor = true;
			this.btnFormas.Click += new System.EventHandler(this.BtnFormasClick);
			// 
			// cbxFormas
			// 
			this.cbxFormas.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxFormas.FormattingEnabled = true;
			this.cbxFormas.Location = new System.Drawing.Point(95, 49);
			this.cbxFormas.Name = "cbxFormas";
			this.cbxFormas.Size = new System.Drawing.Size(166, 22);
			this.cbxFormas.TabIndex = 2;
			// 
			// label12
			// 
			this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label12.Location = new System.Drawing.Point(12, 49);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(80, 20);
			this.label12.TabIndex = 132;
			this.label12.Text = "Forma Recebto";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtRecebido
			// 
			this.edtRecebido.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtRecebido.Location = new System.Drawing.Point(415, 19);
			this.edtRecebido.MaxLength = 12;
			this.edtRecebido.Name = "edtRecebido";
			this.edtRecebido.Size = new System.Drawing.Size(90, 20);
			this.edtRecebido.TabIndex = 1;
			this.edtRecebido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.edtRecebido.TextChanged += new System.EventHandler(this.EdtValorTextChanged);
			this.edtRecebido.Click += new System.EventHandler(this.EdtValorClick);
			this.edtRecebido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EdtValorKeyPress);
			this.edtRecebido.Enter += new System.EventHandler(this.EdtValorEnter);
			// 
			// label13
			// 
			this.label13.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label13.Location = new System.Drawing.Point(330, 19);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(80, 20);
			this.label13.TabIndex = 131;
			this.label13.Text = "Valor Recebido";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpRecebimento
			// 
			this.dtpRecebimento.CustomFormat = "dd/MM/yyyy";
			this.dtpRecebimento.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpRecebimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpRecebimento.Location = new System.Drawing.Point(95, 19);
			this.dtpRecebimento.Name = "dtpRecebimento";
			this.dtpRecebimento.ShowCheckBox = true;
			this.dtpRecebimento.Size = new System.Drawing.Size(110, 20);
			this.dtpRecebimento.TabIndex = 0;
			// 
			// label14
			// 
			this.label14.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label14.Location = new System.Drawing.Point(10, 19);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(80, 20);
			this.label14.TabIndex = 130;
			this.label14.Text = "Recebimento";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// gbxPendencia
			// 
			this.gbxPendencia.Controls.Add(this.edtObservacao);
			this.gbxPendencia.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.gbxPendencia.Location = new System.Drawing.Point(0, 280);
			this.gbxPendencia.Name = "gbxPendencia";
			this.gbxPendencia.Size = new System.Drawing.Size(453, 80);
			this.gbxPendencia.TabIndex = 17;
			this.gbxPendencia.TabStop = false;
			this.gbxPendencia.Text = "Observação";
			// 
			// edtObservacao
			// 
			this.edtObservacao.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtObservacao.Location = new System.Drawing.Point(14, 17);
			this.edtObservacao.Multiline = true;
			this.edtObservacao.Name = "edtObservacao";
			this.edtObservacao.Size = new System.Drawing.Size(426, 60);
			this.edtObservacao.TabIndex = 23;
			this.edtObservacao.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.EdtObservacaoMouseDoubleClick);
			// 
			// cbxPendencias
			// 
			this.cbxPendencias.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxPendencias.FormattingEnabled = true;
			this.cbxPendencias.Location = new System.Drawing.Point(415, 128);
			this.cbxPendencias.Name = "cbxPendencias";
			this.cbxPendencias.Size = new System.Drawing.Size(166, 22);
			this.cbxPendencias.TabIndex = 14;
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label6.Location = new System.Drawing.Point(330, 130);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 20);
			this.label6.TabIndex = 133;
			this.label6.Text = "Pendência";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxCodPendencias
			// 
			this.cbxCodPendencias.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxCodPendencias.FormattingEnabled = true;
			this.cbxCodPendencias.Location = new System.Drawing.Point(457, 313);
			this.cbxCodPendencias.Name = "cbxCodPendencias";
			this.cbxCodPendencias.Size = new System.Drawing.Size(166, 22);
			this.cbxCodPendencias.TabIndex = 134;
			this.cbxCodPendencias.Visible = false;
			// 
			// edtSequencia
			// 
			this.edtSequencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtSequencia.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtSequencia.Location = new System.Drawing.Point(257, 10);
			this.edtSequencia.MaxLength = 6;
			this.edtSequencia.Name = "edtSequencia";
			this.edtSequencia.Size = new System.Drawing.Size(49, 20);
			this.edtSequencia.TabIndex = 1;
			this.edtSequencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label7
			// 
			this.label7.ForeColor = System.Drawing.Color.Red;
			this.label7.Location = new System.Drawing.Point(192, 10);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(60, 20);
			this.label7.TabIndex = 136;
			this.label7.Text = "Sequência";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnCliente
			// 
			this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
			this.btnCliente.Location = new System.Drawing.Point(247, 68);
			this.btnCliente.Name = "btnCliente";
			this.btnCliente.Size = new System.Drawing.Size(36, 23);
			this.btnCliente.TabIndex = 5;
			this.btnCliente.UseVisualStyleBackColor = true;
			this.btnCliente.Click += new System.EventHandler(this.BtnClienteClick);
			// 
			// btnNatureza
			// 
			this.btnNatureza.Image = ((System.Drawing.Image)(resources.GetObject("btnNatureza.Image")));
			this.btnNatureza.Location = new System.Drawing.Point(587, 66);
			this.btnNatureza.Name = "btnNatureza";
			this.btnNatureza.Size = new System.Drawing.Size(36, 23);
			this.btnNatureza.TabIndex = 8;
			this.btnNatureza.UseVisualStyleBackColor = true;
			this.btnNatureza.Click += new System.EventHandler(this.BtnNaturezaClick);
			// 
			// btnPendencias
			// 
			this.btnPendencias.Image = ((System.Drawing.Image)(resources.GetObject("btnPendencias.Image")));
			this.btnPendencias.Location = new System.Drawing.Point(587, 125);
			this.btnPendencias.Name = "btnPendencias";
			this.btnPendencias.Size = new System.Drawing.Size(36, 23);
			this.btnPendencias.TabIndex = 15;
			this.btnPendencias.UseVisualStyleBackColor = true;
			this.btnPendencias.Click += new System.EventHandler(this.BtnPendenciasClick);
			// 
			// gbxCancelamento
			// 
			this.gbxCancelamento.Controls.Add(this.edtMotivo);
			this.gbxCancelamento.Controls.Add(this.label1);
			this.gbxCancelamento.Controls.Add(this.ckbCancelado);
			this.gbxCancelamento.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.gbxCancelamento.Location = new System.Drawing.Point(0, 370);
			this.gbxCancelamento.Name = "gbxCancelamento";
			this.gbxCancelamento.Size = new System.Drawing.Size(525, 75);
			this.gbxCancelamento.TabIndex = 18;
			this.gbxCancelamento.TabStop = false;
			this.gbxCancelamento.Text = "Cancelamento";
			// 
			// edtMotivo
			// 
			this.edtMotivo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtMotivo.Location = new System.Drawing.Point(86, 50);
			this.edtMotivo.MaxLength = 60;
			this.edtMotivo.Name = "edtMotivo";
			this.edtMotivo.Size = new System.Drawing.Size(426, 20);
			this.edtMotivo.TabIndex = 121;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(0, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 20);
			this.label1.TabIndex = 122;
			this.label1.Text = "Motivo";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ckbCancelado
			// 
			this.ckbCancelado.Location = new System.Drawing.Point(10, 19);
			this.ckbCancelado.Name = "ckbCancelado";
			this.ckbCancelado.Size = new System.Drawing.Size(104, 24);
			this.ckbCancelado.TabIndex = 0;
			this.ckbCancelado.Text = "Cancelado";
			this.ckbCancelado.UseVisualStyleBackColor = true;
			// 
			// btnPedido
			// 
			this.btnPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnPedido.Image")));
			this.btnPedido.Location = new System.Drawing.Point(317, 158);
			this.btnPedido.Name = "btnPedido";
			this.btnPedido.Size = new System.Drawing.Size(36, 23);
			this.btnPedido.TabIndex = 13;
			this.btnPedido.UseVisualStyleBackColor = true;
			this.btnPedido.Click += new System.EventHandler(this.Button1Click);
			// 
			// cbxPedidos
			// 
			this.cbxPedidos.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxPedidos.FormattingEnabled = true;
			this.cbxPedidos.Location = new System.Drawing.Point(95, 159);
			this.cbxPedidos.Name = "cbxPedidos";
			this.cbxPedidos.Size = new System.Drawing.Size(211, 22);
			this.cbxPedidos.TabIndex = 12;
			// 
			// btnLote
			// 
			this.btnLote.Location = new System.Drawing.Point(531, 358);
			this.btnLote.Name = "btnLote";
			this.btnLote.Size = new System.Drawing.Size(100, 25);
			this.btnLote.TabIndex = 21;
			this.btnLote.Text = "&Lote";
			this.btnLote.UseVisualStyleBackColor = true;
			this.btnLote.Click += new System.EventHandler(this.BtnLoteClick);
			// 
			// fCadTitulo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(642, 452);
			this.Controls.Add(this.btnLote);
			this.Controls.Add(this.cbxPedidos);
			this.Controls.Add(this.btnPedido);
			this.Controls.Add(this.gbxCancelamento);
			this.Controls.Add(this.btnCliente);
			this.Controls.Add(this.btnPendencias);
			this.Controls.Add(this.btnNatureza);
			this.Controls.Add(this.edtSequencia);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.cbxCodPendencias);
			this.Controls.Add(this.cbxPendencias);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.gbxPendencia);
			this.Controls.Add(this.gbxRecebimento);
			this.Controls.Add(this.cbxCodFormas);
			this.Controls.Add(this.cbxCodNaturezas);
			this.Controls.Add(this.btnCancela);
			this.Controls.Add(this.btnConfirma);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.edtValor);
			this.Controls.Add(this.rbtVariavel);
			this.Controls.Add(this.rbtFixo);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cbxNaturezas);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dtpVencimento);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblEntrada);
			this.Controls.Add(this.dtpEntrada);
			this.Controls.Add(this.edtUsuario);
			this.Controls.Add(this.lblUsuario);
			this.Controls.Add(this.edtParceiro);
			this.Controls.Add(this.lblParceiro);
			this.Controls.Add(this.edtCodigo);
			this.Controls.Add(this.lblCodigo);
			this.Name = "fCadTitulo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sistema SOFT - Inclusão de Título";
			this.Load += new System.EventHandler(this.FCadTituloLoad);
			this.Shown += new System.EventHandler(this.FCadTituloShown);
			this.gbxRecebimento.ResumeLayout(false);
			this.gbxRecebimento.PerformLayout();
			this.gbxPendencia.ResumeLayout(false);
			this.gbxPendencia.PerformLayout();
			this.gbxCancelamento.ResumeLayout(false);
			this.gbxCancelamento.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		public System.Windows.Forms.Button btnLote;
		public System.Windows.Forms.ComboBox cbxPedidos;
		private System.Windows.Forms.Button btnPedido;
		public System.Windows.Forms.TextBox edtMotivo;
		private System.Windows.Forms.CheckBox ckbCancelado;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox gbxCancelamento;
		private System.Windows.Forms.Button btnFormas;
		private System.Windows.Forms.Button btnPendencias;
		private System.Windows.Forms.Button btnNatureza;
		private System.Windows.Forms.Button btnCliente;
		public System.Windows.Forms.DateTimePicker dtpRecebimento;
		public System.Windows.Forms.TextBox edtRecebido;
		public System.Windows.Forms.TextBox edtSequencia;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.GroupBox gbxRecebimento;
		public System.Windows.Forms.ComboBox cbxCodPendencias;
		private System.Windows.Forms.Label label6;
		public System.Windows.Forms.ComboBox cbxPendencias;
		public System.Windows.Forms.TextBox edtObservacao;
		private System.Windows.Forms.GroupBox gbxPendencia;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		public System.Windows.Forms.ComboBox cbxFormas;
		public System.Windows.Forms.ComboBox cbxCodFormas;
		public System.Windows.Forms.ComboBox cbxCodNaturezas;
		public System.Windows.Forms.ComboBox cbxNaturezas;
		public System.Windows.Forms.Button btnConfirma;
		public System.Windows.Forms.Button btnCancela;
		private System.Windows.Forms.Label label8;
		public System.Windows.Forms.TextBox edtValor;
		private System.Windows.Forms.RadioButton rbtFixo;
		public System.Windows.Forms.RadioButton rbtVariavel;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.DateTimePicker dtpVencimento;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblEntrada;
		public System.Windows.Forms.DateTimePicker dtpEntrada;
		public System.Windows.Forms.TextBox edtUsuario;
		private System.Windows.Forms.Label lblUsuario;
		private System.Windows.Forms.Label lblParceiro;
		public System.Windows.Forms.TextBox edtParceiro;
		public System.Windows.Forms.TextBox edtCodigo;
		private System.Windows.Forms.Label lblCodigo;
	}
}
