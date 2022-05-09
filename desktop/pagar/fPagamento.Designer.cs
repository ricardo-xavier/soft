/*
 * Criado por SharpDevelop.
 * Usuário: Ricardo
 * Data: 02/08/2008
 * Hora: 21:48
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace pagar
{
	partial class fPagamento
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPagamento));
			this.btnFormas = new System.Windows.Forms.Button();
			this.btnConfirma = new System.Windows.Forms.Button();
			this.btnCancela = new System.Windows.Forms.Button();
			this.edtDocGerado = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.cbxFormas = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.dtpPagamento = new System.Windows.Forms.DateTimePicker();
			this.label14 = new System.Windows.Forms.Label();
			this.cbxCodFormas = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// btnFormas
			// 
			this.btnFormas.Image = ((System.Drawing.Image)(resources.GetObject("btnFormas.Image")));
			this.btnFormas.Location = new System.Drawing.Point(270, 38);
			this.btnFormas.Name = "btnFormas";
			this.btnFormas.Size = new System.Drawing.Size(36, 23);
			this.btnFormas.TabIndex = 2;
			this.btnFormas.UseVisualStyleBackColor = true;
			this.btnFormas.Click += new System.EventHandler(this.BtnFormasClick);
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(105, 105);
			this.btnConfirma.Name = "btnConfirma";
			this.btnConfirma.Size = new System.Drawing.Size(100, 25);
			this.btnConfirma.TabIndex = 4;
			this.btnConfirma.Text = "&Confirma";
			this.btnConfirma.UseVisualStyleBackColor = true;
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(211, 105);
			this.btnCancela.Name = "btnCancela";
			this.btnCancela.Size = new System.Drawing.Size(100, 25);
			this.btnCancela.TabIndex = 5;
			this.btnCancela.Text = "C&ancela";
			this.btnCancela.UseVisualStyleBackColor = true;
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
			// 
			// edtDocGerado
			// 
			this.edtDocGerado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtDocGerado.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtDocGerado.Location = new System.Drawing.Point(95, 70);
			this.edtDocGerado.MaxLength = 50;
			this.edtDocGerado.Name = "edtDocGerado";
			this.edtDocGerado.Size = new System.Drawing.Size(216, 20);
			this.edtDocGerado.TabIndex = 3;
			// 
			// label11
			// 
			this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label11.Location = new System.Drawing.Point(10, 70);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(80, 20);
			this.label11.TabIndex = 142;
			this.label11.Text = "Doc Gerado";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxFormas
			// 
			this.cbxFormas.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxFormas.FormattingEnabled = true;
			this.cbxFormas.Location = new System.Drawing.Point(95, 40);
			this.cbxFormas.Name = "cbxFormas";
			this.cbxFormas.Size = new System.Drawing.Size(166, 22);
			this.cbxFormas.TabIndex = 1;
			// 
			// label12
			// 
			this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label12.Location = new System.Drawing.Point(10, 40);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(80, 20);
			this.label12.TabIndex = 141;
			this.label12.Text = "Forma Pagto";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpPagamento
			// 
			this.dtpPagamento.CustomFormat = "dd/MM/yyyy";
			this.dtpPagamento.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpPagamento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpPagamento.Location = new System.Drawing.Point(95, 10);
			this.dtpPagamento.Name = "dtpPagamento";
			this.dtpPagamento.Size = new System.Drawing.Size(110, 20);
			this.dtpPagamento.TabIndex = 0;
			// 
			// label14
			// 
			this.label14.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label14.Location = new System.Drawing.Point(10, 10);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(80, 20);
			this.label14.TabIndex = 140;
			this.label14.Text = "Data";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxCodFormas
			// 
			this.cbxCodFormas.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxCodFormas.FormattingEnabled = true;
			this.cbxCodFormas.Location = new System.Drawing.Point(1, 121);
			this.cbxCodFormas.Name = "cbxCodFormas";
			this.cbxCodFormas.Size = new System.Drawing.Size(166, 22);
			this.cbxCodFormas.TabIndex = 143;
			this.cbxCodFormas.Visible = false;
			// 
			// fPagamento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(323, 145);
			this.Controls.Add(this.cbxCodFormas);
			this.Controls.Add(this.btnFormas);
			this.Controls.Add(this.btnConfirma);
			this.Controls.Add(this.btnCancela);
			this.Controls.Add(this.edtDocGerado);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.cbxFormas);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.dtpPagamento);
			this.Controls.Add(this.label14);
			this.Name = "fPagamento";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pagamento";
			this.Load += new System.EventHandler(this.FPagamentoLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		public System.Windows.Forms.ComboBox cbxCodFormas;
		private System.Windows.Forms.Label label14;
		public System.Windows.Forms.DateTimePicker dtpPagamento;
		private System.Windows.Forms.Label label12;
		public System.Windows.Forms.ComboBox cbxFormas;
		private System.Windows.Forms.Label label11;
		public System.Windows.Forms.TextBox edtDocGerado;
		public System.Windows.Forms.Button btnCancela;
		public System.Windows.Forms.Button btnConfirma;
		private System.Windows.Forms.Button btnFormas;
	}
}
