/*
 * Usuário: Ricardo
 * Data: 02/04/2008
 * Hora: 22:17
 * 
 */
namespace cpd
{
	partial class frmCadSistemas
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
			this.btnProgramas = new System.Windows.Forms.Button();
			this.pnlEdicao.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnConfirma
			// 
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// edtCodigo
			// 
			this.edtCodigo.Size = new System.Drawing.Size(27, 20);
			// 
			// btnExclui
			// 
			this.btnExclui.Click += new System.EventHandler(this.BtnExcluiClick);
			// 
			// btnProgramas
			// 
			this.btnProgramas.Location = new System.Drawing.Point(320, 160);
			this.btnProgramas.Name = "btnProgramas";
			this.btnProgramas.Size = new System.Drawing.Size(100, 25);
			this.btnProgramas.TabIndex = 6;
			this.btnProgramas.Text = "Programas";
			this.btnProgramas.UseVisualStyleBackColor = true;
			this.btnProgramas.Click += new System.EventHandler(this.BtnProgramasClick);
			// 
			// frmCadSistemas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.ClientSize = new System.Drawing.Size(434, 334);
			this.Controls.Add(this.btnProgramas);
			this.Name = "frmCadSistemas";
			this.Text = "Cadastro de Sistemas";
			this.Load += new System.EventHandler(this.FrmCadSistemasLoad);
			this.Controls.SetChildIndex(this.edtLocaliza, 0);
			this.Controls.SetChildIndex(this.btnLocaliza, 0);
			this.Controls.SetChildIndex(this.btnProgramas, 0);
			this.Controls.SetChildIndex(this.btnInclui, 0);
			this.Controls.SetChildIndex(this.btnExclui, 0);
			this.Controls.SetChildIndex(this.btnAltera, 0);
			this.Controls.SetChildIndex(this.btnFecha, 0);
			this.Controls.SetChildIndex(this.pnlEdicao, 0);
			this.pnlEdicao.ResumeLayout(false);
			this.pnlEdicao.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnProgramas;
	}
}
