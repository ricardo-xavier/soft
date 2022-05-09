/*
 * Criado por SharpDevelop.
 * Usuário: Ricardo
 * Data: 09/09/2009
 * Hora: 21:44
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace receber
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
			this.edtAtraso1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.edtAtraso2 = new System.Windows.Forms.TextBox();
			this.edtAtraso3 = new System.Windows.Forms.TextBox();
			this.rbtRecibo = new System.Windows.Forms.RadioButton();
			this.rbtRelatorio = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(429, 115);
			this.btnCancela.Name = "btnCancela";
			this.btnCancela.Size = new System.Drawing.Size(100, 25);
			this.btnCancela.TabIndex = 150;
			this.btnCancela.Text = "C&ancela";
			this.btnCancela.UseVisualStyleBackColor = true;
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(323, 115);
			this.btnConfirma.Name = "btnConfirma";
			this.btnConfirma.Size = new System.Drawing.Size(100, 25);
			this.btnConfirma.TabIndex = 140;
			this.btnConfirma.Text = "&Confirma";
			this.btnConfirma.UseVisualStyleBackColor = true;
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// edtTitulo
			// 
			this.edtTitulo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtTitulo.Location = new System.Drawing.Point(183, 12);
			this.edtTitulo.MaxLength = 50;
			this.edtTitulo.Name = "edtTitulo";
			this.edtTitulo.Size = new System.Drawing.Size(356, 20);
			this.edtTitulo.TabIndex = 6;
			// 
			// lblItem
			// 
			this.lblItem.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblItem.Location = new System.Drawing.Point(97, 11);
			this.lblItem.Name = "lblItem";
			this.lblItem.Size = new System.Drawing.Size(80, 20);
			this.lblItem.TabIndex = 126;
			this.lblItem.Text = "Título";
			this.lblItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtAtraso1
			// 
			this.edtAtraso1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtAtraso1.Location = new System.Drawing.Point(183, 38);
			this.edtAtraso1.MaxLength = 50;
			this.edtAtraso1.Name = "edtAtraso1";
			this.edtAtraso1.Size = new System.Drawing.Size(27, 20);
			this.edtAtraso1.TabIndex = 127;
			this.edtAtraso1.Text = "15";
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(97, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 20);
			this.label1.TabIndex = 128;
			this.label1.Text = "Dias Atraso";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtAtraso2
			// 
			this.edtAtraso2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtAtraso2.Location = new System.Drawing.Point(223, 38);
			this.edtAtraso2.MaxLength = 50;
			this.edtAtraso2.Name = "edtAtraso2";
			this.edtAtraso2.Size = new System.Drawing.Size(27, 20);
			this.edtAtraso2.TabIndex = 129;
			this.edtAtraso2.Text = "30";
			// 
			// edtAtraso3
			// 
			this.edtAtraso3.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtAtraso3.Location = new System.Drawing.Point(263, 38);
			this.edtAtraso3.MaxLength = 50;
			this.edtAtraso3.Name = "edtAtraso3";
			this.edtAtraso3.Size = new System.Drawing.Size(27, 20);
			this.edtAtraso3.TabIndex = 130;
			this.edtAtraso3.Text = "60";
			// 
			// rbtRecibo
			// 
			this.rbtRecibo.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.rbtRecibo.Location = new System.Drawing.Point(12, 101);
			this.rbtRecibo.Name = "rbtRecibo";
			this.rbtRecibo.Size = new System.Drawing.Size(75, 22);
			this.rbtRecibo.TabIndex = 132;
			this.rbtRecibo.TabStop = true;
			this.rbtRecibo.Text = "Recibo";
			this.rbtRecibo.UseVisualStyleBackColor = true;
			// 
			// rbtRelatorio
			// 
			this.rbtRelatorio.Checked = true;
			this.rbtRelatorio.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.rbtRelatorio.Location = new System.Drawing.Point(12, 12);
			this.rbtRelatorio.Name = "rbtRelatorio";
			this.rbtRelatorio.Size = new System.Drawing.Size(75, 22);
			this.rbtRelatorio.TabIndex = 1;
			this.rbtRelatorio.TabStop = true;
			this.rbtRelatorio.Text = "Relatório";
			this.rbtRelatorio.UseVisualStyleBackColor = true;
			// 
			// fParametrosImpressao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(551, 152);
			this.Controls.Add(this.rbtRecibo);
			this.Controls.Add(this.rbtRelatorio);
			this.Controls.Add(this.edtAtraso3);
			this.Controls.Add(this.edtAtraso2);
			this.Controls.Add(this.edtAtraso1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.edtTitulo);
			this.Controls.Add(this.lblItem);
			this.Controls.Add(this.btnCancela);
			this.Controls.Add(this.btnConfirma);
			this.Name = "fParametrosImpressao";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Parâmetros para Impressão do Faturamento";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.RadioButton rbtRelatorio;
		public System.Windows.Forms.RadioButton rbtRecibo;
		public System.Windows.Forms.TextBox edtAtraso3;
		public System.Windows.Forms.TextBox edtAtraso2;
		public System.Windows.Forms.Label label1;
		public System.Windows.Forms.TextBox edtAtraso1;
		public System.Windows.Forms.Label lblItem;
		public System.Windows.Forms.TextBox edtTitulo;
		public System.Windows.Forms.Button btnConfirma;
		public System.Windows.Forms.Button btnCancela;
	}
}
