/*
 * Criado por SharpDevelop.
 * Usuário: Ricardo
 * Data: 29/05/2008
 * Hora: 22:38
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace orcamento
{
	partial class frmCadOrcamento
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadOrcamento));
			this.lblVendedor = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.edtFornecedor = new System.Windows.Forms.TextBox();
			this.btnFornecedor = new System.Windows.Forms.Button();
			this.lblData = new System.Windows.Forms.Label();
			this.dtpData = new System.Windows.Forms.DateTimePicker();
			this.edtCodigo = new System.Windows.Forms.TextBox();
			this.lblCodigo = new System.Windows.Forms.Label();
			this.lblCliente = new System.Windows.Forms.Label();
			this.edtCliente = new System.Windows.Forms.TextBox();
			this.btnCliente = new System.Windows.Forms.Button();
			this.lblContato = new System.Windows.Forms.Label();
			this.edtContato = new System.Windows.Forms.TextBox();
			this.btnContato = new System.Windows.Forms.Button();
			this.lblConsultor = new System.Windows.Forms.Label();
			this.edtConsultor = new System.Windows.Forms.TextBox();
			this.btnConsultor = new System.Windows.Forms.Button();
			this.cbxCaracteristicas = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.edtResumo = new System.Windows.Forms.TextBox();
			this.lblResumo = new System.Windows.Forms.Label();
			this.gbxPendencia = new System.Windows.Forms.GroupBox();
			this.edtObservacao = new System.Windows.Forms.TextBox();
			this.lblSituacao = new System.Windows.Forms.Label();
			this.cbxSituacao = new System.Windows.Forms.ComboBox();
			this.btnCancela = new System.Windows.Forms.Button();
			this.btnConfirma = new System.Windows.Forms.Button();
			this.cbxUsuarios = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cbxTabelas = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.edtValor = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.edtDesconto = new System.Windows.Forms.TextBox();
			this.edtTotal = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnItens = new System.Windows.Forms.Button();
			this.edtPercent = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.edtPerConsultor = new System.Windows.Forms.TextBox();
			this.edtVlrConsultor = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.btnLimpaConsultor = new System.Windows.Forms.Button();
			this.gbxPendencia.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblVendedor
			// 
			this.lblVendedor.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblVendedor.Location = new System.Drawing.Point(10, 40);
			this.lblVendedor.Name = "lblVendedor";
			this.lblVendedor.Size = new System.Drawing.Size(80, 20);
			this.lblVendedor.TabIndex = 4;
			this.lblVendedor.Text = "Vendedor";
			this.lblVendedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(10, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 20);
			this.label1.TabIndex = 83;
			this.label1.Text = "Fornecedor";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtFornecedor
			// 
			this.edtFornecedor.BackColor = System.Drawing.SystemColors.Control;
			this.edtFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtFornecedor.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtFornecedor.Location = new System.Drawing.Point(100, 10);
			this.edtFornecedor.MaxLength = 50;
			this.edtFornecedor.Name = "edtFornecedor";
			this.edtFornecedor.Size = new System.Drawing.Size(146, 20);
			this.edtFornecedor.TabIndex = 0;
			this.edtFornecedor.TextChanged += new System.EventHandler(this.EdtFornecedorTextChanged);
			this.edtFornecedor.Leave += new System.EventHandler(this.EdtFornecedorLeave);
			// 
			// btnFornecedor
			// 
			this.btnFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("btnFornecedor.Image")));
			this.btnFornecedor.Location = new System.Drawing.Point(260, 8);
			this.btnFornecedor.Name = "btnFornecedor";
			this.btnFornecedor.Size = new System.Drawing.Size(36, 23);
			this.btnFornecedor.TabIndex = 2;
			this.btnFornecedor.UseVisualStyleBackColor = true;
			this.btnFornecedor.Click += new System.EventHandler(this.BtnFornecedorClick);
			// 
			// lblData
			// 
			this.lblData.ForeColor = System.Drawing.Color.Red;
			this.lblData.Location = new System.Drawing.Point(310, 10);
			this.lblData.Name = "lblData";
			this.lblData.Size = new System.Drawing.Size(110, 20);
			this.lblData.TabIndex = 87;
			this.lblData.Text = "Data";
			this.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpData
			// 
			this.dtpData.CustomFormat = "dd/MM/yyyy HH:mm:ss";
			this.dtpData.Enabled = false;
			this.dtpData.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpData.Location = new System.Drawing.Point(430, 10);
			this.dtpData.Name = "dtpData";
			this.dtpData.Size = new System.Drawing.Size(170, 20);
			this.dtpData.TabIndex = 4;
			// 
			// edtCodigo
			// 
			this.edtCodigo.BackColor = System.Drawing.SystemColors.Control;
			this.edtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtCodigo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtCodigo.Location = new System.Drawing.Point(660, 10);
			this.edtCodigo.MaxLength = 50;
			this.edtCodigo.Name = "edtCodigo";
			this.edtCodigo.ReadOnly = true;
			this.edtCodigo.Size = new System.Drawing.Size(48, 20);
			this.edtCodigo.TabIndex = 6;
			// 
			// lblCodigo
			// 
			this.lblCodigo.ForeColor = System.Drawing.Color.Red;
			this.lblCodigo.Location = new System.Drawing.Point(615, 10);
			this.lblCodigo.Name = "lblCodigo";
			this.lblCodigo.Size = new System.Drawing.Size(40, 20);
			this.lblCodigo.TabIndex = 89;
			this.lblCodigo.Text = "Código";
			this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblCliente
			// 
			this.lblCliente.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCliente.Location = new System.Drawing.Point(10, 70);
			this.lblCliente.Name = "lblCliente";
			this.lblCliente.Size = new System.Drawing.Size(80, 20);
			this.lblCliente.TabIndex = 91;
			this.lblCliente.Text = "Cliente";
			this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtCliente
			// 
			this.edtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtCliente.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtCliente.Location = new System.Drawing.Point(100, 70);
			this.edtCliente.MaxLength = 50;
			this.edtCliente.Name = "edtCliente";
			this.edtCliente.ReadOnly = true;
			this.edtCliente.Size = new System.Drawing.Size(146, 20);
			this.edtCliente.TabIndex = 10;
			// 
			// btnCliente
			// 
			this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
			this.btnCliente.Location = new System.Drawing.Point(260, 68);
			this.btnCliente.Name = "btnCliente";
			this.btnCliente.Size = new System.Drawing.Size(36, 23);
			this.btnCliente.TabIndex = 12;
			this.btnCliente.UseVisualStyleBackColor = true;
			this.btnCliente.Click += new System.EventHandler(this.BtnClienteClick);
			// 
			// lblContato
			// 
			this.lblContato.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblContato.Location = new System.Drawing.Point(310, 70);
			this.lblContato.Name = "lblContato";
			this.lblContato.Size = new System.Drawing.Size(110, 20);
			this.lblContato.TabIndex = 94;
			this.lblContato.Text = "Contato";
			this.lblContato.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtContato
			// 
			this.edtContato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtContato.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtContato.Location = new System.Drawing.Point(430, 70);
			this.edtContato.MaxLength = 50;
			this.edtContato.Name = "edtContato";
			this.edtContato.Size = new System.Drawing.Size(146, 20);
			this.edtContato.TabIndex = 16;
			// 
			// btnContato
			// 
			this.btnContato.Image = ((System.Drawing.Image)(resources.GetObject("btnContato.Image")));
			this.btnContato.Location = new System.Drawing.Point(590, 68);
			this.btnContato.Name = "btnContato";
			this.btnContato.Size = new System.Drawing.Size(36, 23);
			this.btnContato.TabIndex = 18;
			this.btnContato.UseVisualStyleBackColor = true;
			this.btnContato.Click += new System.EventHandler(this.BtnContatoClick);
			// 
			// lblConsultor
			// 
			this.lblConsultor.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblConsultor.Location = new System.Drawing.Point(10, 100);
			this.lblConsultor.Name = "lblConsultor";
			this.lblConsultor.Size = new System.Drawing.Size(80, 20);
			this.lblConsultor.TabIndex = 97;
			this.lblConsultor.Text = "Consultor";
			this.lblConsultor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtConsultor
			// 
			this.edtConsultor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtConsultor.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtConsultor.Location = new System.Drawing.Point(100, 100);
			this.edtConsultor.MaxLength = 50;
			this.edtConsultor.Name = "edtConsultor";
			this.edtConsultor.ReadOnly = true;
			this.edtConsultor.Size = new System.Drawing.Size(146, 20);
			this.edtConsultor.TabIndex = 20;
			this.edtConsultor.TextChanged += new System.EventHandler(this.EdtConsultorTextChanged);
			// 
			// btnConsultor
			// 
			this.btnConsultor.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultor.Image")));
			this.btnConsultor.Location = new System.Drawing.Point(260, 98);
			this.btnConsultor.Name = "btnConsultor";
			this.btnConsultor.Size = new System.Drawing.Size(36, 23);
			this.btnConsultor.TabIndex = 22;
			this.btnConsultor.UseVisualStyleBackColor = true;
			this.btnConsultor.Click += new System.EventHandler(this.BtnConsultorClick);
			// 
			// cbxCaracteristicas
			// 
			this.cbxCaracteristicas.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxCaracteristicas.FormattingEnabled = true;
			this.cbxCaracteristicas.Location = new System.Drawing.Point(430, 130);
			this.cbxCaracteristicas.Name = "cbxCaracteristicas";
			this.cbxCaracteristicas.Size = new System.Drawing.Size(166, 22);
			this.cbxCaracteristicas.TabIndex = 28;
			this.cbxCaracteristicas.SelectedIndexChanged += new System.EventHandler(this.CbxCaracteristicasSelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label6.Location = new System.Drawing.Point(310, 130);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(110, 20);
			this.label6.TabIndex = 100;
			this.label6.Text = "Característica Venda";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtResumo
			// 
			this.edtResumo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtResumo.Location = new System.Drawing.Point(100, 160);
			this.edtResumo.MaxLength = 50;
			this.edtResumo.Name = "edtResumo";
			this.edtResumo.Size = new System.Drawing.Size(426, 20);
			this.edtResumo.TabIndex = 30;
			// 
			// lblResumo
			// 
			this.lblResumo.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblResumo.Location = new System.Drawing.Point(30, 160);
			this.lblResumo.Name = "lblResumo";
			this.lblResumo.Size = new System.Drawing.Size(60, 20);
			this.lblResumo.TabIndex = 102;
			this.lblResumo.Text = "Resumo";
			this.lblResumo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// gbxPendencia
			// 
			this.gbxPendencia.Controls.Add(this.edtObservacao);
			this.gbxPendencia.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.gbxPendencia.Location = new System.Drawing.Point(90, 190);
			this.gbxPendencia.Name = "gbxPendencia";
			this.gbxPendencia.Size = new System.Drawing.Size(453, 80);
			this.gbxPendencia.TabIndex = 32;
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
			this.edtObservacao.TabIndex = 32;
			this.edtObservacao.DoubleClick += new System.EventHandler(this.EdtObservacaoDoubleClick);
			// 
			// lblSituacao
			// 
			this.lblSituacao.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblSituacao.Location = new System.Drawing.Point(30, 290);
			this.lblSituacao.Name = "lblSituacao";
			this.lblSituacao.Size = new System.Drawing.Size(60, 20);
			this.lblSituacao.TabIndex = 106;
			this.lblSituacao.Text = "Situação";
			this.lblSituacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxSituacao
			// 
			this.cbxSituacao.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxSituacao.FormattingEnabled = true;
			this.cbxSituacao.Location = new System.Drawing.Point(100, 290);
			this.cbxSituacao.Name = "cbxSituacao";
			this.cbxSituacao.Size = new System.Drawing.Size(130, 22);
			this.cbxSituacao.TabIndex = 34;
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(608, 433);
			this.btnCancela.Name = "btnCancela";
			this.btnCancela.Size = new System.Drawing.Size(100, 25);
			this.btnCancela.TabIndex = 52;
			this.btnCancela.Text = "C&ancela";
			this.btnCancela.UseVisualStyleBackColor = true;
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(502, 433);
			this.btnConfirma.Name = "btnConfirma";
			this.btnConfirma.Size = new System.Drawing.Size(100, 25);
			this.btnConfirma.TabIndex = 50;
			this.btnConfirma.Text = "&Confirma";
			this.btnConfirma.UseVisualStyleBackColor = true;
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// cbxUsuarios
			// 
			this.cbxUsuarios.BackColor = System.Drawing.SystemColors.Window;
			this.cbxUsuarios.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxUsuarios.FormattingEnabled = true;
			this.cbxUsuarios.Location = new System.Drawing.Point(100, 40);
			this.cbxUsuarios.Name = "cbxUsuarios";
			this.cbxUsuarios.Size = new System.Drawing.Size(166, 22);
			this.cbxUsuarios.TabIndex = 8;
			this.cbxUsuarios.Text = "12345678901234567890";
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label2.Location = new System.Drawing.Point(10, 130);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 20);
			this.label2.TabIndex = 107;
			this.label2.Text = "Tabela Preços";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxTabelas
			// 
			this.cbxTabelas.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxTabelas.FormattingEnabled = true;
			this.cbxTabelas.Location = new System.Drawing.Point(100, 130);
			this.cbxTabelas.Name = "cbxTabelas";
			this.cbxTabelas.Size = new System.Drawing.Size(166, 22);
			this.cbxTabelas.TabIndex = 26;
			this.cbxTabelas.SelectedIndexChanged += new System.EventHandler(this.CbxTabelasSelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label3.Location = new System.Drawing.Point(480, 290);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 20);
			this.label3.TabIndex = 108;
			this.label3.Text = "Valor";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtValor
			// 
			this.edtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtValor.Enabled = false;
			this.edtValor.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtValor.Location = new System.Drawing.Point(618, 290);
			this.edtValor.MaxLength = 50;
			this.edtValor.Name = "edtValor";
			this.edtValor.Size = new System.Drawing.Size(90, 20);
			this.edtValor.TabIndex = 36;
			this.edtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label4.Location = new System.Drawing.Point(480, 320);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 20);
			this.label4.TabIndex = 110;
			this.label4.Text = "Desconto";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtDesconto
			// 
			this.edtDesconto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtDesconto.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtDesconto.Location = new System.Drawing.Point(618, 320);
			this.edtDesconto.MaxLength = 50;
			this.edtDesconto.Name = "edtDesconto";
			this.edtDesconto.Size = new System.Drawing.Size(90, 20);
			this.edtDesconto.TabIndex = 40;
			this.edtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.edtDesconto.TextChanged += new System.EventHandler(this.EdtDescontoTextChanged);
			this.edtDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EdtDescontoKeyPress);
			// 
			// edtTotal
			// 
			this.edtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtTotal.Enabled = false;
			this.edtTotal.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtTotal.Location = new System.Drawing.Point(618, 380);
			this.edtTotal.MaxLength = 50;
			this.edtTotal.Name = "edtTotal";
			this.edtTotal.Size = new System.Drawing.Size(90, 20);
			this.edtTotal.TabIndex = 46;
			this.edtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label5.Location = new System.Drawing.Point(480, 380);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(60, 20);
			this.label5.TabIndex = 113;
			this.label5.Text = "Total";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnItens
			// 
			this.btnItens.Location = new System.Drawing.Point(396, 433);
			this.btnItens.Name = "btnItens";
			this.btnItens.Size = new System.Drawing.Size(100, 25);
			this.btnItens.TabIndex = 48;
			this.btnItens.Text = "I&tens";
			this.btnItens.UseVisualStyleBackColor = true;
			this.btnItens.Click += new System.EventHandler(this.BtnItensClick);
			// 
			// edtPercent
			// 
			this.edtPercent.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtPercent.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtPercent.Location = new System.Drawing.Point(550, 320);
			this.edtPercent.MaxLength = 50;
			this.edtPercent.Name = "edtPercent";
			this.edtPercent.Size = new System.Drawing.Size(41, 20);
			this.edtPercent.TabIndex = 38;
			this.edtPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.edtPercent.TextChanged += new System.EventHandler(this.EdtPercentTextChanged);
			this.edtPercent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EdtDescontoKeyPress);
			// 
			// label7
			// 
			this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label7.Location = new System.Drawing.Point(600, 320);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(12, 20);
			this.label7.TabIndex = 115;
			this.label7.Text = "%";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label8.Location = new System.Drawing.Point(601, 350);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(12, 20);
			this.label8.TabIndex = 119;
			this.label8.Text = "%";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtPerConsultor
			// 
			this.edtPerConsultor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtPerConsultor.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtPerConsultor.Location = new System.Drawing.Point(551, 350);
			this.edtPerConsultor.MaxLength = 50;
			this.edtPerConsultor.Name = "edtPerConsultor";
			this.edtPerConsultor.Size = new System.Drawing.Size(41, 20);
			this.edtPerConsultor.TabIndex = 42;
			this.edtPerConsultor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.edtPerConsultor.TextChanged += new System.EventHandler(this.EdtPerConsultorTextChanged);
			// 
			// edtVlrConsultor
			// 
			this.edtVlrConsultor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtVlrConsultor.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtVlrConsultor.Location = new System.Drawing.Point(619, 350);
			this.edtVlrConsultor.MaxLength = 50;
			this.edtVlrConsultor.Name = "edtVlrConsultor";
			this.edtVlrConsultor.Size = new System.Drawing.Size(90, 20);
			this.edtVlrConsultor.TabIndex = 44;
			this.edtVlrConsultor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.edtVlrConsultor.TextChanged += new System.EventHandler(this.EdtVlrConsultorTextChanged);
			this.edtVlrConsultor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EdtVlrConsultorKeyPress);
			// 
			// label9
			// 
			this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label9.Location = new System.Drawing.Point(481, 350);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(60, 20);
			this.label9.TabIndex = 118;
			this.label9.Text = "Consultor";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnLimpaConsultor
			// 
			this.btnLimpaConsultor.Location = new System.Drawing.Point(302, 96);
			this.btnLimpaConsultor.Name = "btnLimpaConsultor";
			this.btnLimpaConsultor.Size = new System.Drawing.Size(57, 25);
			this.btnLimpaConsultor.TabIndex = 24;
			this.btnLimpaConsultor.Text = "&Limpa";
			this.btnLimpaConsultor.UseVisualStyleBackColor = true;
			this.btnLimpaConsultor.Click += new System.EventHandler(this.BtnLimpaConsultorClick);
			// 
			// frmCadOrcamento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(721, 470);
			this.Controls.Add(this.btnLimpaConsultor);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.edtPerConsultor);
			this.Controls.Add(this.edtVlrConsultor);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.edtPercent);
			this.Controls.Add(this.btnItens);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.edtTotal);
			this.Controls.Add(this.edtDesconto);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.edtValor);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cbxTabelas);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cbxUsuarios);
			this.Controls.Add(this.btnCancela);
			this.Controls.Add(this.btnConfirma);
			this.Controls.Add(this.lblSituacao);
			this.Controls.Add(this.cbxSituacao);
			this.Controls.Add(this.gbxPendencia);
			this.Controls.Add(this.edtResumo);
			this.Controls.Add(this.lblResumo);
			this.Controls.Add(this.cbxCaracteristicas);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnConsultor);
			this.Controls.Add(this.edtConsultor);
			this.Controls.Add(this.lblConsultor);
			this.Controls.Add(this.btnContato);
			this.Controls.Add(this.edtContato);
			this.Controls.Add(this.lblContato);
			this.Controls.Add(this.btnCliente);
			this.Controls.Add(this.edtCliente);
			this.Controls.Add(this.lblCliente);
			this.Controls.Add(this.edtCodigo);
			this.Controls.Add(this.lblCodigo);
			this.Controls.Add(this.dtpData);
			this.Controls.Add(this.lblData);
			this.Controls.Add(this.btnFornecedor);
			this.Controls.Add(this.edtFornecedor);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblVendedor);
			this.Name = "frmCadOrcamento";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sistema SOFT - Inclusão de Orçamento ";
			this.Load += new System.EventHandler(this.FrmCadOrcamentoLoad);
			this.gbxPendencia.ResumeLayout(false);
			this.gbxPendencia.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		public System.Windows.Forms.Button btnLimpaConsultor;
		public System.Windows.Forms.TextBox edtVlrConsultor;
		public System.Windows.Forms.TextBox edtPerConsultor;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		public System.Windows.Forms.TextBox edtPercent;
		private System.Windows.Forms.Label label7;
		public System.Windows.Forms.Button btnItens;
		public System.Windows.Forms.TextBox edtDesconto;
		public System.Windows.Forms.TextBox edtTotal;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		public System.Windows.Forms.TextBox edtValor;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.ComboBox cbxTabelas;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.TextBox edtObservacao;
		public System.Windows.Forms.ComboBox cbxUsuarios;
		public System.Windows.Forms.Button btnConfirma;
		public System.Windows.Forms.Button btnCancela;
		public System.Windows.Forms.ComboBox cbxSituacao;
		private System.Windows.Forms.Label lblSituacao;
		private System.Windows.Forms.GroupBox gbxPendencia;
		private System.Windows.Forms.Label lblResumo;
		public System.Windows.Forms.TextBox edtResumo;
		private System.Windows.Forms.Label label6;
		public System.Windows.Forms.ComboBox cbxCaracteristicas;
		private System.Windows.Forms.Button btnConsultor;
		public System.Windows.Forms.TextBox edtConsultor;
		private System.Windows.Forms.Label lblConsultor;
		private System.Windows.Forms.Button btnContato;
		public System.Windows.Forms.TextBox edtContato;
		private System.Windows.Forms.Label lblContato;
		private System.Windows.Forms.Button btnCliente;
		public System.Windows.Forms.TextBox edtCliente;
		private System.Windows.Forms.Label lblCliente;
		private System.Windows.Forms.Label lblCodigo;
		public System.Windows.Forms.TextBox edtCodigo;
		public System.Windows.Forms.DateTimePicker dtpData;
		private System.Windows.Forms.Label lblData;
		private System.Windows.Forms.Button btnFornecedor;
		public System.Windows.Forms.TextBox edtFornecedor;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblVendedor;
	}
}
