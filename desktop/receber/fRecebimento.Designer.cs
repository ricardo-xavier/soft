/*
 * Criado por SharpDevelop.
 * Usuário: Ricardo
 * Data: 02/08/2008
 * Hora: 21:48
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace receber
{
	partial class fRecebimento
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fRecebimento));
			this.btnFormas = new System.Windows.Forms.Button();
			this.btnConfirma = new System.Windows.Forms.Button();
			this.btnCancela = new System.Windows.Forms.Button();
			this.cbxFormas = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.dtpRecebimento = new System.Windows.Forms.DateTimePicker();
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
			this.btnConfirma.Location = new System.Drawing.Point(105, 68);
			this.btnConfirma.Name = "btnConfirma";
			this.btnConfirma.Size = new System.Drawing.Size(100, 25);
			this.btnConfirma.TabIndex = 4;
			this.btnConfirma.Text = "&Confirma";
			this.btnConfirma.UseVisualStyleBackColor = true;
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(211, 68);
			this.btnCancela.Name = "btnCancela";
			this.btnCancela.Size = new System.Drawing.Size(100, 25);
			this.btnCancela.TabIndex = 5;
			this.btnCancela.Text = "C&ancela";
			this.btnCancela.UseVisualStyleBackColor = true;
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
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
			this.label12.Text = "Forma Recebto";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpRecebimento
			// 
			this.dtpRecebimento.CustomFormat = "dd/MM/yyyy";
			this.dtpRecebimento.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpRecebimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpRecebimento.Location = new System.Drawing.Point(95, 10);
			this.dtpRecebimento.Name = "dtpRecebimento";
			this.dtpRecebimento.Size = new System.Drawing.Size(110, 20);
			this.dtpRecebimento.TabIndex = 0;
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
			this.cbxCodFormas.Location = new System.Drawing.Point(0, 83);
			this.cbxCodFormas.Name = "cbxCodFormas";
			this.cbxCodFormas.Size = new System.Drawing.Size(166, 22);
			this.cbxCodFormas.TabIndex = 143;
			this.cbxCodFormas.Visible = false;
			// 
			// fRecebimento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(323, 104);
			this.Controls.Add(this.cbxCodFormas);
			this.Controls.Add(this.btnFormas);
			this.Controls.Add(this.btnConfirma);
			this.Controls.Add(this.btnCancela);
			this.Controls.Add(this.cbxFormas);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.dtpRecebimento);
			this.Controls.Add(this.label14);
			this.Name = "fRecebimento";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Recebimento";
			this.Load += new System.EventHandler(this.FRecebimentoLoad);
			this.ResumeLayout(false);
		}
		public System.Windows.Forms.DateTimePicker dtpRecebimento;
		public System.Windows.Forms.ComboBox cbxCodFormas;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label12;
		public System.Windows.Forms.ComboBox cbxFormas;
		public System.Windows.Forms.Button btnCancela;
		public System.Windows.Forms.Button btnConfirma;
		private System.Windows.Forms.Button btnFormas;
	}
}
