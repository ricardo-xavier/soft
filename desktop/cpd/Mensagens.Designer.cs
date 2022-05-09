/*
 * Created by SharpDevelop.
 * User: ricar_000
 * Date: 07/07/2015
 * Time: 20:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace cpd
{
	partial class Mensagens
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox tbMensagem;
		public System.Windows.Forms.Button btnConfirma;
		public System.Windows.Forms.Button btnCancela;
		
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
			this.tbMensagem = new System.Windows.Forms.TextBox();
			this.btnConfirma = new System.Windows.Forms.Button();
			this.btnCancela = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tbMensagem
			// 
			this.tbMensagem.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.tbMensagem.Location = new System.Drawing.Point(12, 12);
			this.tbMensagem.Multiline = true;
			this.tbMensagem.Name = "tbMensagem";
			this.tbMensagem.Size = new System.Drawing.Size(263, 235);
			this.tbMensagem.TabIndex = 73;
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(281, 12);
			this.btnConfirma.Name = "btnConfirma";
			this.btnConfirma.Size = new System.Drawing.Size(100, 25);
			this.btnConfirma.TabIndex = 141;
			this.btnConfirma.Text = "Confirma";
			this.btnConfirma.UseVisualStyleBackColor = true;
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(281, 43);
			this.btnCancela.Name = "btnCancela";
			this.btnCancela.Size = new System.Drawing.Size(100, 25);
			this.btnCancela.TabIndex = 151;
			this.btnCancela.Text = "Cancela";
			this.btnCancela.UseVisualStyleBackColor = true;
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
			// 
			// Mensagens
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(387, 261);
			this.Controls.Add(this.btnCancela);
			this.Controls.Add(this.btnConfirma);
			this.Controls.Add(this.tbMensagem);
			this.Name = "Mensagens";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mensagens";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
