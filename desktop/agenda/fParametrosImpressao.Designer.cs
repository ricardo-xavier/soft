/*
 * Criado por SharpDevelop.
 * Usuário: Ricardo
 * Data: 19/10/2008
 * Hora: 8:48
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace agenda
{
	partial class fParametrosImpressao
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
			this.btnCancela = new System.Windows.Forms.Button();
			this.btnConfirma = new System.Windows.Forms.Button();
			this.edtTitulo = new System.Windows.Forms.TextBox();
			this.lblItem = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.dtpF = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.dtpI = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(348, 94);
			this.btnCancela.Name = "btnCancela";
			this.btnCancela.Size = new System.Drawing.Size(100, 25);
			this.btnCancela.TabIndex = 22;
			this.btnCancela.Text = "C&ancela";
			this.btnCancela.UseVisualStyleBackColor = true;
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(242, 94);
			this.btnConfirma.Name = "btnConfirma";
			this.btnConfirma.Size = new System.Drawing.Size(100, 25);
			this.btnConfirma.TabIndex = 20;
			this.btnConfirma.Text = "&Confirma";
			this.btnConfirma.UseVisualStyleBackColor = true;
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// edtTitulo
			// 
			this.edtTitulo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtTitulo.Location = new System.Drawing.Point(92, 12);
			this.edtTitulo.MaxLength = 50;
			this.edtTitulo.Name = "edtTitulo";
			this.edtTitulo.Size = new System.Drawing.Size(356, 20);
			this.edtTitulo.TabIndex = 127;
			// 
			// lblItem
			// 
			this.lblItem.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblItem.Location = new System.Drawing.Point(6, 11);
			this.lblItem.Name = "lblItem";
			this.lblItem.Size = new System.Drawing.Size(80, 20);
			this.lblItem.TabIndex = 128;
			this.lblItem.Text = "Título";
			this.lblItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label5.Location = new System.Drawing.Point(212, 47);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(25, 20);
			this.label5.TabIndex = 132;
			this.label5.Text = "até";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpF
			// 
			this.dtpF.Checked = false;
			this.dtpF.CustomFormat = "dd/MM/yyyy";
			this.dtpF.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpF.Location = new System.Drawing.Point(247, 47);
			this.dtpF.Name = "dtpF";
			this.dtpF.ShowCheckBox = true;
			this.dtpF.Size = new System.Drawing.Size(110, 20);
			this.dtpF.TabIndex = 130;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(17, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 20);
			this.label1.TabIndex = 131;
			this.label1.Text = "De";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpI
			// 
			this.dtpI.Checked = false;
			this.dtpI.CustomFormat = "dd/MM/yyyy";
			this.dtpI.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpI.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpI.Location = new System.Drawing.Point(92, 47);
			this.dtpI.Name = "dtpI";
			this.dtpI.ShowCheckBox = true;
			this.dtpI.Size = new System.Drawing.Size(110, 20);
			this.dtpI.TabIndex = 129;
			// 
			// fParametrosImpressao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(485, 129);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.dtpF);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dtpI);
			this.Controls.Add(this.edtTitulo);
			this.Controls.Add(this.lblItem);
			this.Controls.Add(this.btnCancela);
			this.Controls.Add(this.btnConfirma);
			this.Name = "fParametrosImpressao";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Parâmetros para Impressão";
			this.Load += new System.EventHandler(this.FParametrosImpressaoLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DateTimePicker dtpF;
		private System.Windows.Forms.DateTimePicker dtpI;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.Label lblItem;
		public System.Windows.Forms.TextBox edtTitulo;
		public System.Windows.Forms.Button btnConfirma;
		public System.Windows.Forms.Button btnCancela;
	}
}
