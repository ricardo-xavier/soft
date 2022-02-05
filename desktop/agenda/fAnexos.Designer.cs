/*
 * Usuário: Ricardo
 * Data: 26/04/2008
 * Hora: 13:41
 * 
 */
namespace agenda
{
	partial class frmAnexos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnexos));
			this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
			this.btnNatureza = new System.Windows.Forms.Button();
			this.pnlEdicao.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnConfirma
			// 
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// edtCodigo
			// 
			this.edtCodigo.Location = new System.Drawing.Point(75, 10);
			this.edtCodigo.MaxLength = 20;
			this.edtCodigo.Size = new System.Drawing.Size(146, 20);
			// 
			// edtDescricao
			// 
			this.edtDescricao.Location = new System.Drawing.Point(75, 40);
			this.edtDescricao.MaxLength = 50;
			this.edtDescricao.Size = new System.Drawing.Size(286, 20);
			// 
			// lblCodigo
			// 
			this.lblCodigo.Size = new System.Drawing.Size(60, 20);
			// 
			// lblDescricao
			// 
			this.lblDescricao.Size = new System.Drawing.Size(60, 20);
			this.lblDescricao.Text = "Arquivo";
			// 
			// pnlEdicao
			// 
			this.pnlEdicao.Controls.Add(this.btnNatureza);
			this.pnlEdicao.Controls.SetChildIndex(this.lblCodigo, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblDescricao, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtCodigo, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtDescricao, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.btnConfirma, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.btnCancela, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.btnNatureza, 0);
			// 
			// btnExclui
			// 
			this.btnExclui.Click += new System.EventHandler(this.BtnExcluiClick);
			// 
			// btnNatureza
			// 
			this.btnNatureza.Image = ((System.Drawing.Image)(resources.GetObject("btnNatureza.Image")));
			this.btnNatureza.Location = new System.Drawing.Point(367, 37);
			this.btnNatureza.Name = "btnNatureza";
			this.btnNatureza.Size = new System.Drawing.Size(36, 23);
			this.btnNatureza.TabIndex = 71;
			this.btnNatureza.UseVisualStyleBackColor = true;
			this.btnNatureza.Click += new System.EventHandler(this.BtnNaturezaClick);
			// 
			// frmAnexos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(434, 334);
			this.Name = "frmAnexos";
			this.Text = "Agenda - Anexos";
			this.Load += new System.EventHandler(this.FrmAnexosLoad);
			this.pnlEdicao.ResumeLayout(false);
			this.pnlEdicao.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.OpenFileDialog dlgOpen;
		private System.Windows.Forms.Button btnNatureza;
	}
}
