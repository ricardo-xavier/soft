/*
 * Criado por SharpDevelop.
 * Usuário: Ricardo
 * Data: 22/07/2008
 * Hora: 22:57
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace pagar
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
			this.btnParceiro = new System.Windows.Forms.Button();
			this.edtParceiro = new System.Windows.Forms.TextBox();
			this.lblParceiro = new System.Windows.Forms.Label();
			this.lblUsuario = new System.Windows.Forms.Label();
			this.edtUsuario = new System.Windows.Forms.TextBox();
			this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
			this.lblEntrada = new System.Windows.Forms.Label();
			this.btnFuncionario = new System.Windows.Forms.Button();
			this.edtFuncionario = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
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
			this.edtDocOrigem = new System.Windows.Forms.TextBox();
			this.btnCancela = new System.Windows.Forms.Button();
			this.btnConfirma = new System.Windows.Forms.Button();
			this.cbxCodNaturezas = new System.Windows.Forms.ComboBox();
			this.cbxCodFormas = new System.Windows.Forms.ComboBox();
			this.btnNaturezas = new System.Windows.Forms.Button();
			this.gbxPagamento = new System.Windows.Forms.GroupBox();
			this.btnFormas = new System.Windows.Forms.Button();
			this.edtDocGerado = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.cbxFormas = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.edtPago = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.dtpPagamento = new System.Windows.Forms.DateTimePicker();
			this.label14 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.gbxPendencia = new System.Windows.Forms.GroupBox();
			this.edtObservacao = new System.Windows.Forms.TextBox();
			this.btnPendencias = new System.Windows.Forms.Button();
			this.cbxPendencias = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cbxCodPendencias = new System.Windows.Forms.ComboBox();
			this.cbxPedidos = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.btnLote = new System.Windows.Forms.Button();
			this.rbtSemiFixa = new System.Windows.Forms.RadioButton();
			this.gbxPagamento.SuspendLayout();
			this.gbxPendencia.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblCodigo
			// 
			this.lblCodigo.ForeColor = System.Drawing.Color.Red;
			this.lblCodigo.Location = new System.Drawing.Point(10, 10);
			this.lblCodigo.Name = "lblCodigo";
			this.lblCodigo.Size = new System.Drawing.Size(80, 20);
			this.lblCodigo.TabIndex = 84;
			this.lblCodigo.Text = "Código";
			this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtCodigo
			// 
			this.edtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtCodigo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtCodigo.Location = new System.Drawing.Point(95, 10);
			this.edtCodigo.MaxLength = 6;
			this.edtCodigo.Name = "edtCodigo";
			this.edtCodigo.ReadOnly = true;
			this.edtCodigo.Size = new System.Drawing.Size(49, 20);
			this.edtCodigo.TabIndex = 0;
			this.edtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btnParceiro
			// 
			this.btnParceiro.Image = ((System.Drawing.Image)(resources.GetObject("btnParceiro.Image")));
			this.btnParceiro.Location = new System.Drawing.Point(250, 68);
			this.btnParceiro.Name = "btnParceiro";
			this.btnParceiro.Size = new System.Drawing.Size(36, 23);
			this.btnParceiro.TabIndex = 4;
			this.btnParceiro.UseVisualStyleBackColor = true;
			this.btnParceiro.Click += new System.EventHandler(this.BtnParceiroClick);
			// 
			// edtParceiro
			// 
			this.edtParceiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtParceiro.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtParceiro.Location = new System.Drawing.Point(95, 70);
			this.edtParceiro.MaxLength = 20;
			this.edtParceiro.Name = "edtParceiro";
			this.edtParceiro.Size = new System.Drawing.Size(146, 20);
			this.edtParceiro.TabIndex = 3;
			this.edtParceiro.TextChanged += new System.EventHandler(this.EdtParceiroTextChanged);
			// 
			// lblParceiro
			// 
			this.lblParceiro.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblParceiro.Location = new System.Drawing.Point(10, 70);
			this.lblParceiro.Name = "lblParceiro";
			this.lblParceiro.Size = new System.Drawing.Size(80, 20);
			this.lblParceiro.TabIndex = 100;
			this.lblParceiro.Text = "Parceiro";
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
			this.edtUsuario.TabIndex = 1;
			// 
			// dtpEntrada
			// 
			this.dtpEntrada.CustomFormat = "dd/MM/yyyy";
			this.dtpEntrada.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpEntrada.Location = new System.Drawing.Point(415, 40);
			this.dtpEntrada.Name = "dtpEntrada";
			this.dtpEntrada.Size = new System.Drawing.Size(110, 20);
			this.dtpEntrada.TabIndex = 2;
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
			// btnFuncionario
			// 
			this.btnFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("btnFuncionario.Image")));
			this.btnFuncionario.Location = new System.Drawing.Point(570, 68);
			this.btnFuncionario.Name = "btnFuncionario";
			this.btnFuncionario.Size = new System.Drawing.Size(36, 23);
			this.btnFuncionario.TabIndex = 6;
			this.btnFuncionario.UseVisualStyleBackColor = true;
			this.btnFuncionario.Click += new System.EventHandler(this.BtnFuncionarioClick);
			// 
			// edtFuncionario
			// 
			this.edtFuncionario.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtFuncionario.Location = new System.Drawing.Point(415, 70);
			this.edtFuncionario.MaxLength = 20;
			this.edtFuncionario.Name = "edtFuncionario";
			this.edtFuncionario.Size = new System.Drawing.Size(146, 20);
			this.edtFuncionario.TabIndex = 5;
			this.edtFuncionario.TextChanged += new System.EventHandler(this.EdtParceiroTextChanged);
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(330, 70);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 20);
			this.label1.TabIndex = 106;
			this.label1.Text = "Funcionário";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
			this.dtpVencimento.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label3.Location = new System.Drawing.Point(330, 100);
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
			this.cbxNaturezas.Location = new System.Drawing.Point(415, 100);
			this.cbxNaturezas.Name = "cbxNaturezas";
			this.cbxNaturezas.Size = new System.Drawing.Size(166, 22);
			this.cbxNaturezas.TabIndex = 8;
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
			this.label5.Location = new System.Drawing.Point(330, 130);
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
			this.edtValor.Location = new System.Drawing.Point(415, 130);
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
			this.label8.Text = "Doc Origem";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtDocOrigem
			// 
			this.edtDocOrigem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtDocOrigem.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtDocOrigem.Location = new System.Drawing.Point(95, 160);
			this.edtDocOrigem.MaxLength = 50;
			this.edtDocOrigem.Name = "edtDocOrigem";
			this.edtDocOrigem.Size = new System.Drawing.Size(216, 20);
			this.edtDocOrigem.TabIndex = 13;
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(537, 402);
			this.btnCancela.Name = "btnCancela";
			this.btnCancela.Size = new System.Drawing.Size(100, 25);
			this.btnCancela.TabIndex = 24;
			this.btnCancela.Text = "C&ancela";
			this.btnCancela.UseVisualStyleBackColor = true;
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(431, 402);
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
			this.cbxCodNaturezas.Location = new System.Drawing.Point(7, 360);
			this.cbxCodNaturezas.Name = "cbxCodNaturezas";
			this.cbxCodNaturezas.Size = new System.Drawing.Size(166, 22);
			this.cbxCodNaturezas.TabIndex = 127;
			this.cbxCodNaturezas.Visible = false;
			// 
			// cbxCodFormas
			// 
			this.cbxCodFormas.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxCodFormas.FormattingEnabled = true;
			this.cbxCodFormas.Location = new System.Drawing.Point(24, 360);
			this.cbxCodFormas.Name = "cbxCodFormas";
			this.cbxCodFormas.Size = new System.Drawing.Size(166, 22);
			this.cbxCodFormas.TabIndex = 128;
			this.cbxCodFormas.Visible = false;
			// 
			// btnNaturezas
			// 
			this.btnNaturezas.Image = ((System.Drawing.Image)(resources.GetObject("btnNaturezas.Image")));
			this.btnNaturezas.Location = new System.Drawing.Point(590, 98);
			this.btnNaturezas.Name = "btnNaturezas";
			this.btnNaturezas.Size = new System.Drawing.Size(36, 23);
			this.btnNaturezas.TabIndex = 9;
			this.btnNaturezas.UseVisualStyleBackColor = true;
			this.btnNaturezas.Click += new System.EventHandler(this.BtnNaturezasClick);
			// 
			// gbxPagamento
			// 
			this.gbxPagamento.Controls.Add(this.btnFormas);
			this.gbxPagamento.Controls.Add(this.edtDocGerado);
			this.gbxPagamento.Controls.Add(this.label11);
			this.gbxPagamento.Controls.Add(this.cbxFormas);
			this.gbxPagamento.Controls.Add(this.label12);
			this.gbxPagamento.Controls.Add(this.edtPago);
			this.gbxPagamento.Controls.Add(this.label13);
			this.gbxPagamento.Controls.Add(this.dtpPagamento);
			this.gbxPagamento.Controls.Add(this.label14);
			this.gbxPagamento.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.gbxPagamento.Location = new System.Drawing.Point(10, 214);
			this.gbxPagamento.Name = "gbxPagamento";
			this.gbxPagamento.Size = new System.Drawing.Size(637, 84);
			this.gbxPagamento.TabIndex = 18;
			this.gbxPagamento.TabStop = false;
			this.gbxPagamento.Text = "Pagamento";
			// 
			// btnFormas
			// 
			this.btnFormas.Image = ((System.Drawing.Image)(resources.GetObject("btnFormas.Image")));
			this.btnFormas.Location = new System.Drawing.Point(270, 47);
			this.btnFormas.Name = "btnFormas";
			this.btnFormas.Size = new System.Drawing.Size(36, 23);
			this.btnFormas.TabIndex = 3;
			this.btnFormas.UseVisualStyleBackColor = true;
			this.btnFormas.Click += new System.EventHandler(this.BtnFormasClick);
			// 
			// edtDocGerado
			// 
			this.edtDocGerado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtDocGerado.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtDocGerado.Location = new System.Drawing.Point(415, 49);
			this.edtDocGerado.MaxLength = 50;
			this.edtDocGerado.Name = "edtDocGerado";
			this.edtDocGerado.Size = new System.Drawing.Size(216, 20);
			this.edtDocGerado.TabIndex = 4;
			// 
			// label11
			// 
			this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label11.Location = new System.Drawing.Point(330, 49);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(80, 20);
			this.label11.TabIndex = 133;
			this.label11.Text = "Doc Gerado";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
			this.label12.Text = "Forma Pagto";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtPago
			// 
			this.edtPago.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtPago.Location = new System.Drawing.Point(415, 19);
			this.edtPago.MaxLength = 12;
			this.edtPago.Name = "edtPago";
			this.edtPago.Size = new System.Drawing.Size(90, 20);
			this.edtPago.TabIndex = 1;
			this.edtPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.edtPago.TextChanged += new System.EventHandler(this.EdtValorTextChanged);
			this.edtPago.Click += new System.EventHandler(this.EdtValorClick);
			this.edtPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EdtValorKeyPress);
			this.edtPago.Enter += new System.EventHandler(this.EdtValorEnter);
			// 
			// label13
			// 
			this.label13.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label13.Location = new System.Drawing.Point(330, 19);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(80, 20);
			this.label13.TabIndex = 131;
			this.label13.Text = "Valor Pago";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpPagamento
			// 
			this.dtpPagamento.CustomFormat = "dd/MM/yyyy";
			this.dtpPagamento.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpPagamento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpPagamento.Location = new System.Drawing.Point(95, 19);
			this.dtpPagamento.Name = "dtpPagamento";
			this.dtpPagamento.ShowCheckBox = true;
			this.dtpPagamento.Size = new System.Drawing.Size(110, 20);
			this.dtpPagamento.TabIndex = 0;
			// 
			// label14
			// 
			this.label14.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label14.Location = new System.Drawing.Point(10, 19);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(80, 20);
			this.label14.TabIndex = 130;
			this.label14.Text = "Pagamento";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// button1
			// 
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(312, 189);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(36, 23);
			this.button1.TabIndex = 17;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// gbxPendencia
			// 
			this.gbxPendencia.Controls.Add(this.edtObservacao);
			this.gbxPendencia.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.gbxPendencia.Location = new System.Drawing.Point(10, 304);
			this.gbxPendencia.Name = "gbxPendencia";
			this.gbxPendencia.Size = new System.Drawing.Size(453, 80);
			this.gbxPendencia.TabIndex = 19;
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
			// btnPendencias
			// 
			this.btnPendencias.Image = ((System.Drawing.Image)(resources.GetObject("btnPendencias.Image")));
			this.btnPendencias.Location = new System.Drawing.Point(590, 158);
			this.btnPendencias.Name = "btnPendencias";
			this.btnPendencias.Size = new System.Drawing.Size(36, 23);
			this.btnPendencias.TabIndex = 15;
			this.btnPendencias.UseVisualStyleBackColor = true;
			this.btnPendencias.Click += new System.EventHandler(this.BtnPendenciasClick);
			// 
			// cbxPendencias
			// 
			this.cbxPendencias.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxPendencias.FormattingEnabled = true;
			this.cbxPendencias.Location = new System.Drawing.Point(415, 160);
			this.cbxPendencias.Name = "cbxPendencias";
			this.cbxPendencias.Size = new System.Drawing.Size(166, 22);
			this.cbxPendencias.TabIndex = 14;
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label6.Location = new System.Drawing.Point(330, 160);
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
			this.cbxCodPendencias.Location = new System.Drawing.Point(39, 360);
			this.cbxCodPendencias.Name = "cbxCodPendencias";
			this.cbxCodPendencias.Size = new System.Drawing.Size(166, 22);
			this.cbxCodPendencias.TabIndex = 134;
			this.cbxCodPendencias.Visible = false;
			// 
			// cbxPedidos
			// 
			this.cbxPedidos.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxPedidos.FormattingEnabled = true;
			this.cbxPedidos.Location = new System.Drawing.Point(95, 190);
			this.cbxPedidos.Name = "cbxPedidos";
			this.cbxPedidos.Size = new System.Drawing.Size(211, 22);
			this.cbxPedidos.TabIndex = 16;
			// 
			// label7
			// 
			this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label7.Location = new System.Drawing.Point(10, 190);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 20);
			this.label7.TabIndex = 140;
			this.label7.Text = "Pedidos";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnLote
			// 
			this.btnLote.Location = new System.Drawing.Point(325, 402);
			this.btnLote.Name = "btnLote";
			this.btnLote.Size = new System.Drawing.Size(100, 25);
			this.btnLote.TabIndex = 20;
			this.btnLote.Text = "&Lote";
			this.btnLote.UseVisualStyleBackColor = true;
			this.btnLote.Click += new System.EventHandler(this.BtnLoteClick);
			// 
			// rbtSemiFixa
			// 
			this.rbtSemiFixa.Location = new System.Drawing.Point(222, 130);
			this.rbtSemiFixa.Name = "rbtSemiFixa";
			this.rbtSemiFixa.Size = new System.Drawing.Size(75, 22);
			this.rbtSemiFixa.TabIndex = 11;
			this.rbtSemiFixa.TabStop = true;
			this.rbtSemiFixa.Text = "Semi-fixa";
			this.rbtSemiFixa.UseVisualStyleBackColor = true;
			// 
			// fCadTitulo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(642, 439);
			this.Controls.Add(this.rbtSemiFixa);
			this.Controls.Add(this.btnLote);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.cbxPedidos);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.cbxCodPendencias);
			this.Controls.Add(this.btnPendencias);
			this.Controls.Add(this.cbxPendencias);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.gbxPendencia);
			this.Controls.Add(this.gbxPagamento);
			this.Controls.Add(this.btnNaturezas);
			this.Controls.Add(this.cbxCodFormas);
			this.Controls.Add(this.cbxCodNaturezas);
			this.Controls.Add(this.btnCancela);
			this.Controls.Add(this.btnConfirma);
			this.Controls.Add(this.edtDocOrigem);
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
			this.Controls.Add(this.btnFuncionario);
			this.Controls.Add(this.edtFuncionario);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblEntrada);
			this.Controls.Add(this.dtpEntrada);
			this.Controls.Add(this.edtUsuario);
			this.Controls.Add(this.lblUsuario);
			this.Controls.Add(this.btnParceiro);
			this.Controls.Add(this.edtParceiro);
			this.Controls.Add(this.lblParceiro);
			this.Controls.Add(this.edtCodigo);
			this.Controls.Add(this.lblCodigo);
			this.Name = "fCadTitulo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sistema SOFT - Inclusão de Título";
			this.Load += new System.EventHandler(this.FCadTituloLoad);
			this.Shown += new System.EventHandler(this.FCadTituloShown);
			this.gbxPagamento.ResumeLayout(false);
			this.gbxPagamento.PerformLayout();
			this.gbxPendencia.ResumeLayout(false);
			this.gbxPendencia.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		public System.Windows.Forms.RadioButton rbtSemiFixa;
		public System.Windows.Forms.Button btnLote;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label7;
		public System.Windows.Forms.ComboBox cbxPedidos;
		public System.Windows.Forms.ComboBox cbxCodPendencias;
		private System.Windows.Forms.Label label6;
		public System.Windows.Forms.ComboBox cbxPendencias;
		private System.Windows.Forms.Button btnPendencias;
		public System.Windows.Forms.TextBox edtObservacao;
		private System.Windows.Forms.GroupBox gbxPendencia;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.GroupBox gbxPagamento;
		private System.Windows.Forms.Button btnNaturezas;
		private System.Windows.Forms.Button btnFormas;
		public System.Windows.Forms.ComboBox cbxFormas;
		public System.Windows.Forms.ComboBox cbxCodFormas;
		public System.Windows.Forms.ComboBox cbxCodNaturezas;
		public System.Windows.Forms.ComboBox cbxNaturezas;
		public System.Windows.Forms.TextBox edtDocGerado;
		public System.Windows.Forms.TextBox edtDocOrigem;
		public System.Windows.Forms.TextBox edtPago;
		public System.Windows.Forms.DateTimePicker dtpPagamento;
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
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.TextBox edtFuncionario;
		private System.Windows.Forms.Button btnFuncionario;
		private System.Windows.Forms.Label lblEntrada;
		public System.Windows.Forms.DateTimePicker dtpEntrada;
		public System.Windows.Forms.TextBox edtUsuario;
		private System.Windows.Forms.Label lblUsuario;
		private System.Windows.Forms.Label lblParceiro;
		public System.Windows.Forms.TextBox edtParceiro;
		private System.Windows.Forms.Button btnParceiro;
		public System.Windows.Forms.TextBox edtCodigo;
		private System.Windows.Forms.Label lblCodigo;
	}
}
