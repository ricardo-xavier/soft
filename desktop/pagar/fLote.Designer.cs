/*
 * Criado por SharpDevelop.
 * Usuário: Ricardo
 * Data: 10/05/2010
 * Hora: 21:01
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace pagar
{
	partial class fLote
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
			this.cbxFrequencia = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.edtRepeticoes = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.btnCancela = new System.Windows.Forms.Button();
			this.btnConfirma = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.dtpLimite = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// cbxFrequencia
			// 
			this.cbxFrequencia.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxFrequencia.FormattingEnabled = true;
			this.cbxFrequencia.Location = new System.Drawing.Point(101, 12);
			this.cbxFrequencia.Name = "cbxFrequencia";
			this.cbxFrequencia.Size = new System.Drawing.Size(171, 22);
			this.cbxFrequencia.TabIndex = 141;
			// 
			// label7
			// 
			this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label7.Location = new System.Drawing.Point(16, 12);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 20);
			this.label7.TabIndex = 142;
			this.label7.Text = "Frequência";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtRepeticoes
			// 
			this.edtRepeticoes.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtRepeticoes.Location = new System.Drawing.Point(101, 40);
			this.edtRepeticoes.MaxLength = 12;
			this.edtRepeticoes.Name = "edtRepeticoes";
			this.edtRepeticoes.Size = new System.Drawing.Size(20, 20);
			this.edtRepeticoes.TabIndex = 143;
			this.edtRepeticoes.Text = "1";
			this.edtRepeticoes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label13
			// 
			this.label13.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label13.Location = new System.Drawing.Point(16, 40);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(80, 20);
			this.label13.TabIndex = 144;
			this.label13.Text = "Repetições";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(172, 110);
			this.btnCancela.Name = "btnCancela";
			this.btnCancela.Size = new System.Drawing.Size(100, 25);
			this.btnCancela.TabIndex = 146;
			this.btnCancela.Text = "C&ancela";
			this.btnCancela.UseVisualStyleBackColor = true;
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(66, 110);
			this.btnConfirma.Name = "btnConfirma";
			this.btnConfirma.Size = new System.Drawing.Size(100, 25);
			this.btnConfirma.TabIndex = 145;
			this.btnConfirma.Text = "&Confirma";
			this.btnConfirma.UseVisualStyleBackColor = true;
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(16, 70);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 20);
			this.label1.TabIndex = 147;
			this.label1.Text = "Limite";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpLimite
			// 
			this.dtpLimite.Checked = false;
			this.dtpLimite.CustomFormat = "dd/MM/yyyy";
			this.dtpLimite.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpLimite.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpLimite.Location = new System.Drawing.Point(100, 70);
			this.dtpLimite.Name = "dtpLimite";
			this.dtpLimite.ShowCheckBox = true;
			this.dtpLimite.Size = new System.Drawing.Size(110, 20);
			this.dtpLimite.TabIndex = 148;
			this.dtpLimite.ValueChanged += new System.EventHandler(this.DtpLimiteValueChanged);
			// 
			// fLote
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(285, 147);
			this.Controls.Add(this.dtpLimite);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCancela);
			this.Controls.Add(this.btnConfirma);
			this.Controls.Add(this.edtRepeticoes);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.cbxFrequencia);
			this.Controls.Add(this.label7);
			this.Name = "fLote";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Inclusão de Títulos em Lote";
			this.Load += new System.EventHandler(this.FLoteLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		public System.Windows.Forms.DateTimePicker dtpLimite;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.TextBox edtRepeticoes;
		public System.Windows.Forms.Button btnConfirma;
		public System.Windows.Forms.Button btnCancela;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label7;
		public System.Windows.Forms.ComboBox cbxFrequencia;
	}
}
