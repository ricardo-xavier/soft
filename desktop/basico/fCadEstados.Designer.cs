/*
 * Usuário: Ricardo
 * Data: 05/04/2008
 * Hora: 23:06
 * 
 */
namespace basico
{
	partial class frmCadEstados
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
			this.pnlEdicao.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnConfirma
			// 
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// edtCodigo
			// 
			this.edtCodigo.Size = new System.Drawing.Size(20, 20);
			// 
			// lblDescricao
			// 
			this.lblDescricao.Text = "*Nome";
			// 
			// btnExclui
			// 
			this.btnExclui.Click += new System.EventHandler(this.BtnExcluiClick);
			// 
			// frmCadEstados
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.ClientSize = new System.Drawing.Size(434, 334);
			this.Name = "frmCadEstados";
			this.Text = "Cadastros Básicos - Estados";
			this.Load += new System.EventHandler(this.FEstadosLoad);
			this.pnlEdicao.ResumeLayout(false);
			this.pnlEdicao.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
	}
}
