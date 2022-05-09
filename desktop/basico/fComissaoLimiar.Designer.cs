/*
 * Usuário: Ricardo
 * Data: 07/04/2008
 * Hora: 23:31
 * 
 */
namespace basico
{
	partial class fComissaoLimiar
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
			this.lblCaracteristica = new System.Windows.Forms.Label();
			this.pnlEdicao.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnUp
			// 
			this.btnUp.Location = new System.Drawing.Point(359, 40);
			// 
			// btnDown
			// 
			this.btnDown.Location = new System.Drawing.Point(317, 40);
			// 
			// btnLocaliza
			// 
			this.btnLocaliza.Location = new System.Drawing.Point(210, 40);
			// 
			// edtLocaliza
			// 
			this.edtLocaliza.Location = new System.Drawing.Point(10, 44);
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(310, 41);
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(310, 10);
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// edtCodigo
			// 
			this.edtCodigo.Size = new System.Drawing.Size(27, 20);
			// 
			// edtDescricao
			// 
			this.edtDescricao.Size = new System.Drawing.Size(41, 20);
			// 
			// lblCodigo
			// 
			this.lblCodigo.Text = "Limiar";
			// 
			// lblDescricao
			// 
			this.lblDescricao.Text = "Comissão";
			// 
			// pnlEdicao
			// 
			this.pnlEdicao.Location = new System.Drawing.Point(10, 230);
			this.pnlEdicao.Size = new System.Drawing.Size(420, 77);
			// 
			// btnFecha
			// 
			this.btnFecha.Location = new System.Drawing.Point(320, 160);
			// 
			// btnAltera
			// 
			this.btnAltera.Location = new System.Drawing.Point(320, 130);
			// 
			// btnExclui
			// 
			this.btnExclui.Location = new System.Drawing.Point(320, 100);
			this.btnExclui.Click += new System.EventHandler(this.BtnExcluiClick);
			// 
			// btnInclui
			// 
			this.btnInclui.Location = new System.Drawing.Point(320, 70);
			this.btnInclui.Click += new System.EventHandler(this.BtnIncluiClick);
			// 
			// lblCaracteristica
			// 
			this.lblCaracteristica.Location = new System.Drawing.Point(12, 9);
			this.lblCaracteristica.Name = "lblCaracteristica";
			this.lblCaracteristica.Size = new System.Drawing.Size(410, 23);
			this.lblCaracteristica.TabIndex = 10;
			this.lblCaracteristica.Text = "label1";
			this.lblCaracteristica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// fComissaoLimiar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.ClientSize = new System.Drawing.Size(434, 315);
			this.Controls.Add(this.lblCaracteristica);
			this.Name = "fComissaoLimiar";
			this.Text = "Cadastros Básicos - Comissão x Limiar";
			this.Load += new System.EventHandler(this.FComissaoLimiarLoad);
			this.Controls.SetChildIndex(this.lblCaracteristica, 0);
			this.Controls.SetChildIndex(this.btnInclui, 0);
			this.Controls.SetChildIndex(this.btnExclui, 0);
			this.Controls.SetChildIndex(this.btnAltera, 0);
			this.Controls.SetChildIndex(this.btnFecha, 0);
			this.Controls.SetChildIndex(this.pnlEdicao, 0);
			this.Controls.SetChildIndex(this.edtLocaliza, 0);
			this.Controls.SetChildIndex(this.btnLocaliza, 0);
			this.Controls.SetChildIndex(this.btnUp, 0);
			this.Controls.SetChildIndex(this.btnDown, 0);
			this.pnlEdicao.ResumeLayout(false);
			this.pnlEdicao.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblCaracteristica;
	}
}
