/*
 * Criado por SharpDevelop.
 * Usuário: Ricardo
 * Data: 15/10/2014
 * Hora: 20:31
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace acao
{
	partial class fCadAcao
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCadAcao));
			this.edtSequencia = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnCliente = new System.Windows.Forms.Button();
			this.edtCliente = new System.Windows.Forms.TextBox();
			this.lblCliente = new System.Windows.Forms.Label();
			this.btnCancela = new System.Windows.Forms.Button();
			this.btnConfirma = new System.Windows.Forms.Button();
			this.edtObra = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dtpPrevisao = new System.Windows.Forms.DateTimePicker();
			this.label14 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnConsultor = new System.Windows.Forms.Button();
			this.edtConsultor = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.edtOrigem = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cbxSituacao = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.cbxVendedor = new System.Windows.Forms.ComboBox();
			this.btnOrigem = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.edtConcorrentes = new System.Windows.Forms.TextBox();
			this.edtObservacao = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnGrupo = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// edtSequencia
			// 
			this.edtSequencia.BackColor = System.Drawing.SystemColors.Control;
			this.edtSequencia.Enabled = false;
			this.edtSequencia.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtSequencia.Location = new System.Drawing.Point(90, 12);
			this.edtSequencia.MaxLength = 50;
			this.edtSequencia.Name = "edtSequencia";
			this.edtSequencia.Size = new System.Drawing.Size(76, 20);
			this.edtSequencia.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(9, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 20);
			this.label1.TabIndex = 85;
			this.label1.Text = "Código";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnCliente
			// 
			this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
			this.btnCliente.Location = new System.Drawing.Point(262, 51);
			this.btnCliente.Name = "btnCliente";
			this.btnCliente.Size = new System.Drawing.Size(36, 23);
			this.btnCliente.TabIndex = 30;
			this.btnCliente.UseVisualStyleBackColor = true;
			this.btnCliente.Click += new System.EventHandler(this.BtnClienteClick);
			// 
			// edtCliente
			// 
			this.edtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtCliente.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtCliente.Location = new System.Drawing.Point(102, 53);
			this.edtCliente.MaxLength = 50;
			this.edtCliente.Name = "edtCliente";
			this.edtCliente.ReadOnly = true;
			this.edtCliente.Size = new System.Drawing.Size(146, 20);
			this.edtCliente.TabIndex = 20;
			// 
			// lblCliente
			// 
			this.lblCliente.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCliente.Location = new System.Drawing.Point(12, 52);
			this.lblCliente.Name = "lblCliente";
			this.lblCliente.Size = new System.Drawing.Size(80, 20);
			this.lblCliente.TabIndex = 96;
			this.lblCliente.Text = "Cliente";
			this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(345, 480);
			this.btnCancela.Name = "btnCancela";
			this.btnCancela.Size = new System.Drawing.Size(100, 25);
			this.btnCancela.TabIndex = 150;
			this.btnCancela.Text = "Cancela";
			this.btnCancela.UseVisualStyleBackColor = true;
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(240, 480);
			this.btnConfirma.Name = "btnConfirma";
			this.btnConfirma.Size = new System.Drawing.Size(100, 25);
			this.btnConfirma.TabIndex = 140;
			this.btnConfirma.Text = "Confirma";
			this.btnConfirma.UseVisualStyleBackColor = true;
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// edtObra
			// 
			this.edtObra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtObra.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtObra.Location = new System.Drawing.Point(102, 78);
			this.edtObra.MaxLength = 50;
			this.edtObra.Name = "edtObra";
			this.edtObra.Size = new System.Drawing.Size(146, 20);
			this.edtObra.TabIndex = 40;
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label2.Location = new System.Drawing.Point(12, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 20);
			this.label2.TabIndex = 176;
			this.label2.Text = "Obra";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpPrevisao
			// 
			this.dtpPrevisao.CustomFormat = "dd/MM/yyyy";
			this.dtpPrevisao.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpPrevisao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpPrevisao.Location = new System.Drawing.Point(102, 103);
			this.dtpPrevisao.Name = "dtpPrevisao";
			this.dtpPrevisao.Size = new System.Drawing.Size(110, 20);
			this.dtpPrevisao.TabIndex = 50;
			// 
			// label14
			// 
			this.label14.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label14.Location = new System.Drawing.Point(12, 102);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(80, 20);
			this.label14.TabIndex = 178;
			this.label14.Text = "Previsão";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label4.Location = new System.Drawing.Point(12, 128);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 20);
			this.label4.TabIndex = 183;
			this.label4.Text = "Vendedor";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnConsultor
			// 
			this.btnConsultor.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultor.Image")));
			this.btnConsultor.Location = new System.Drawing.Point(262, 152);
			this.btnConsultor.Name = "btnConsultor";
			this.btnConsultor.Size = new System.Drawing.Size(36, 23);
			this.btnConsultor.TabIndex = 100;
			this.btnConsultor.UseVisualStyleBackColor = true;
			this.btnConsultor.Click += new System.EventHandler(this.BtnConsultorClick);
			// 
			// edtConsultor
			// 
			this.edtConsultor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtConsultor.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtConsultor.Location = new System.Drawing.Point(102, 154);
			this.edtConsultor.MaxLength = 50;
			this.edtConsultor.Name = "edtConsultor";
			this.edtConsultor.ReadOnly = true;
			this.edtConsultor.Size = new System.Drawing.Size(146, 20);
			this.edtConsultor.TabIndex = 90;
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label5.Location = new System.Drawing.Point(12, 153);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 20);
			this.label5.TabIndex = 186;
			this.label5.Text = "Consultor";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtOrigem
			// 
			this.edtOrigem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtOrigem.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtOrigem.Location = new System.Drawing.Point(102, 179);
			this.edtOrigem.MaxLength = 50;
			this.edtOrigem.Name = "edtOrigem";
			this.edtOrigem.ReadOnly = true;
			this.edtOrigem.Size = new System.Drawing.Size(146, 20);
			this.edtOrigem.TabIndex = 110;
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label6.Location = new System.Drawing.Point(12, 178);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 20);
			this.label6.TabIndex = 188;
			this.label6.Text = "Origem";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxSituacao
			// 
			this.cbxSituacao.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxSituacao.FormattingEnabled = true;
			this.cbxSituacao.IntegralHeight = false;
			this.cbxSituacao.Location = new System.Drawing.Point(102, 204);
			this.cbxSituacao.Name = "cbxSituacao";
			this.cbxSituacao.Size = new System.Drawing.Size(166, 22);
			this.cbxSituacao.TabIndex = 120;
			// 
			// label12
			// 
			this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label12.Location = new System.Drawing.Point(12, 203);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(80, 20);
			this.label12.TabIndex = 190;
			this.label12.Text = "Situação";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxVendedor
			// 
			this.cbxVendedor.BackColor = System.Drawing.SystemColors.Window;
			this.cbxVendedor.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxVendedor.FormattingEnabled = true;
			this.cbxVendedor.Location = new System.Drawing.Point(102, 129);
			this.cbxVendedor.Name = "cbxVendedor";
			this.cbxVendedor.Size = new System.Drawing.Size(166, 22);
			this.cbxVendedor.TabIndex = 70;
			this.cbxVendedor.Text = "12345678901234567890";
			// 
			// btnOrigem
			// 
			this.btnOrigem.Image = ((System.Drawing.Image)(resources.GetObject("btnOrigem.Image")));
			this.btnOrigem.Location = new System.Drawing.Point(262, 177);
			this.btnOrigem.Name = "btnOrigem";
			this.btnOrigem.Size = new System.Drawing.Size(36, 23);
			this.btnOrigem.TabIndex = 115;
			this.btnOrigem.UseVisualStyleBackColor = true;
			this.btnOrigem.Click += new System.EventHandler(this.BtnOrigemClick);
			// 
			// label7
			// 
			this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label7.Location = new System.Drawing.Point(12, 228);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 20);
			this.label7.TabIndex = 192;
			this.label7.Text = "Observação";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtConcorrentes
			// 
			this.edtConcorrentes.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtConcorrentes.Location = new System.Drawing.Point(102, 348);
			this.edtConcorrentes.Multiline = true;
			this.edtConcorrentes.Name = "edtConcorrentes";
			this.edtConcorrentes.Size = new System.Drawing.Size(343, 112);
			this.edtConcorrentes.TabIndex = 130;
			// 
			// edtObservacao
			// 
			this.edtObservacao.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtObservacao.Location = new System.Drawing.Point(101, 229);
			this.edtObservacao.Multiline = true;
			this.edtObservacao.Name = "edtObservacao";
			this.edtObservacao.Size = new System.Drawing.Size(343, 112);
			this.edtObservacao.TabIndex = 135;
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label3.Location = new System.Drawing.Point(12, 347);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 20);
			this.label3.TabIndex = 194;
			this.label3.Text = "Concorrentes";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.edtSequencia);
			this.groupBox1.Location = new System.Drawing.Point(12, 7);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(432, 38);
			this.groupBox1.TabIndex = 196;
			this.groupBox1.TabStop = false;
			// 
			// btnGrupo
			// 
			this.btnGrupo.Location = new System.Drawing.Point(304, 51);
			this.btnGrupo.Name = "btnGrupo";
			this.btnGrupo.Size = new System.Drawing.Size(53, 23);
			this.btnGrupo.TabIndex = 31;
			this.btnGrupo.Text = "Grupo";
			this.btnGrupo.UseVisualStyleBackColor = true;
			this.btnGrupo.Click += new System.EventHandler(this.Button1Click);
			// 
			// fCadAcao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(456, 517);
			this.Controls.Add(this.btnGrupo);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.edtObservacao);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.edtConcorrentes);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.btnOrigem);
			this.Controls.Add(this.cbxVendedor);
			this.Controls.Add(this.cbxSituacao);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.edtOrigem);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnConsultor);
			this.Controls.Add(this.edtConsultor);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dtpPrevisao);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.edtObra);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnCancela);
			this.Controls.Add(this.btnConfirma);
			this.Controls.Add(this.btnCliente);
			this.Controls.Add(this.edtCliente);
			this.Controls.Add(this.lblCliente);
			this.Name = "fCadAcao";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ação Comercial";
			this.Load += new System.EventHandler(this.FCadAcaoLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.TextBox edtConcorrentes;
		private System.Windows.Forms.Button btnOrigem;
		public System.Windows.Forms.TextBox edtObservacao;
		private System.Windows.Forms.Label label7;
		public System.Windows.Forms.ComboBox cbxVendedor;
		public System.Windows.Forms.ComboBox cbxSituacao;
		public System.Windows.Forms.TextBox edtOrigem;
		public System.Windows.Forms.TextBox edtConsultor;
		private System.Windows.Forms.Button btnConsultor;
		public System.Windows.Forms.DateTimePicker dtpPrevisao;
		public System.Windows.Forms.TextBox edtObra;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.Button btnConfirma;
		public System.Windows.Forms.Button btnCancela;
		private System.Windows.Forms.Label lblCliente;
		public System.Windows.Forms.TextBox edtCliente;
		private System.Windows.Forms.Button btnCliente;
		public System.Windows.Forms.TextBox edtSequencia;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnGrupo;
	}
}
