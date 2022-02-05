/*
 * Usuário: Ricardo
 * Data: 23/03/2008
 * Hora: 23:17
 * 
 */
namespace cpd
{
	partial class frmCadProgramas
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
			this.lblSistema = new System.Windows.Forms.Label();
			this.pnlEdicao.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnLocaliza
			// 
			this.btnLocaliza.Location = new System.Drawing.Point(210, 35);
			// 
			// edtLocaliza
			// 
			this.edtLocaliza.Location = new System.Drawing.Point(10, 39);
			// 
			// btnConfirma
			// 
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// edtCodigo
			// 
			this.edtCodigo.Size = new System.Drawing.Size(146, 20);
			// 
			// pnlEdicao
			// 
			this.pnlEdicao.Location = new System.Drawing.Point(10, 225);
			// 
			// btnFecha
			// 
			this.btnFecha.Location = new System.Drawing.Point(320, 155);
			// 
			// btnAltera
			// 
			this.btnAltera.Location = new System.Drawing.Point(320, 125);
			// 
			// btnExclui
			// 
			this.btnExclui.Location = new System.Drawing.Point(320, 95);
			this.btnExclui.Click += new System.EventHandler(this.BtnExcluiClick);
			// 
			// btnInclui
			// 
			this.btnInclui.Location = new System.Drawing.Point(320, 65);
			// 
			// lblSistema
			// 
			this.lblSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSistema.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblSistema.Location = new System.Drawing.Point(12, 8);
			this.lblSistema.Name = "lblSistema";
			this.lblSistema.Size = new System.Drawing.Size(300, 20);
			this.lblSistema.TabIndex = 24;
			this.lblSistema.Text = "Sistema:";
			this.lblSistema.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// frmCadProgramas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.ClientSize = new System.Drawing.Size(434, 359);
			this.Controls.Add(this.lblSistema);
			this.Name = "frmCadProgramas";
			this.Text = "CPD - Cadastro de Programas";
			this.Load += new System.EventHandler(this.FrmCadProgramasLoad);
			this.Controls.SetChildIndex(this.edtLocaliza, 0);
			this.Controls.SetChildIndex(this.btnLocaliza, 0);
			this.Controls.SetChildIndex(this.btnFecha, 0);
			this.Controls.SetChildIndex(this.lblSistema, 0);
			this.Controls.SetChildIndex(this.btnInclui, 0);
			this.Controls.SetChildIndex(this.btnExclui, 0);
			this.Controls.SetChildIndex(this.btnAltera, 0);
			this.Controls.SetChildIndex(this.pnlEdicao, 0);
			this.pnlEdicao.ResumeLayout(false);
			this.pnlEdicao.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblSistema;
	}
}
