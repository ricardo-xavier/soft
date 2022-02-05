/*
 * Criado por SharpDevelop.
 * Usuário: Ricardo
 * Data: 08/09/2008
 * Hora: 22:00
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace classes
{
	partial class fEntradaItem
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
			this.edtItem = new System.Windows.Forms.TextBox();
			this.lblItem = new System.Windows.Forms.Label();
			this.btnConfirma = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// edtItem
			// 
			this.edtItem.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtItem.Location = new System.Drawing.Point(87, 12);
			this.edtItem.MaxLength = 50;
			this.edtItem.Name = "edtItem";
			this.edtItem.Size = new System.Drawing.Size(356, 20);
			this.edtItem.TabIndex = 123;
			// 
			// lblItem
			// 
			this.lblItem.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblItem.Location = new System.Drawing.Point(1, 11);
			this.lblItem.Name = "lblItem";
			this.lblItem.Size = new System.Drawing.Size(80, 20);
			this.lblItem.TabIndex = 124;
			this.lblItem.Text = "Título";
			this.lblItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(87, 38);
			this.btnConfirma.Name = "btnConfirma";
			this.btnConfirma.Size = new System.Drawing.Size(100, 25);
			this.btnConfirma.TabIndex = 125;
			this.btnConfirma.Text = "&Confirma";
			this.btnConfirma.UseVisualStyleBackColor = true;
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// fEntradaItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(452, 70);
			this.Controls.Add(this.btnConfirma);
			this.Controls.Add(this.edtItem);
			this.Controls.Add(this.lblItem);
			this.Name = "fEntradaItem";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "fEntradaItem";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		public System.Windows.Forms.Button btnConfirma;
		public System.Windows.Forms.Label lblItem;
		public System.Windows.Forms.TextBox edtItem;
	}
}
