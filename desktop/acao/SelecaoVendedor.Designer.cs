/*
 * Criado por SharpDevelop.
 * Usuário: ricar_000
 * Data: 05/07/2015
 * Hora: 0:04
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace acao
{
	partial class SelecaoVendedor
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
			this.label1 = new System.Windows.Forms.Label();
			this.cbxVendedores = new System.Windows.Forms.ComboBox();
			this.btnCancela = new System.Windows.Forms.Button();
			this.btnConfirma = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(17, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Vendedor";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cbxVendedores
			// 
			this.cbxVendedores.FormattingEnabled = true;
			this.cbxVendedores.Location = new System.Drawing.Point(85, 16);
			this.cbxVendedores.Name = "cbxVendedores";
			this.cbxVendedores.Size = new System.Drawing.Size(206, 21);
			this.cbxVendedores.TabIndex = 1;
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(191, 54);
			this.btnCancela.Name = "btnCancela";
			this.btnCancela.Size = new System.Drawing.Size(100, 25);
			this.btnCancela.TabIndex = 10;
			this.btnCancela.Text = "C&ancela";
			this.btnCancela.UseVisualStyleBackColor = true;
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(85, 54);
			this.btnConfirma.Name = "btnConfirma";
			this.btnConfirma.Size = new System.Drawing.Size(100, 25);
			this.btnConfirma.TabIndex = 9;
			this.btnConfirma.Text = "&Confirma";
			this.btnConfirma.UseVisualStyleBackColor = true;
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// SelecaoVendedor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(300, 87);
			this.Controls.Add(this.btnCancela);
			this.Controls.Add(this.btnConfirma);
			this.Controls.Add(this.cbxVendedores);
			this.Controls.Add(this.label1);
			this.Name = "SelecaoVendedor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Seleciona Vendedor";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ComboBox cbxVendedores;
		public System.Windows.Forms.Button btnConfirma;
		public System.Windows.Forms.Button btnCancela;
		private System.Windows.Forms.Label label1;
	}
}
