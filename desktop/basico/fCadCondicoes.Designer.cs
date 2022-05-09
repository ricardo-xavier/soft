/*
 * Usuário: Ricardo
 * Data: 05/04/2008
 * Hora: 23:06
 * 
 */
namespace basico
{
	partial class frmCadCondicoes
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.CheckBox ckbAtiva;
		
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
			this.ckbAtiva = new System.Windows.Forms.CheckBox();
			this.pnlEdicao.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(371, 95);
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(261, 95);
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// edtDescricao
			// 
			this.edtDescricao.MaxLength = 50;
			this.edtDescricao.Size = new System.Drawing.Size(356, 20);
			// 
			// pnlEdicao
			// 
			this.pnlEdicao.Controls.Add(this.ckbAtiva);
			this.pnlEdicao.Size = new System.Drawing.Size(478, 130);
			this.pnlEdicao.Controls.SetChildIndex(this.lblCodigo, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblDescricao, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtCodigo, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtDescricao, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.btnConfirma, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.btnCancela, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.ckbAtiva, 0);
			// 
			// btnFecha
			// 
			this.btnFecha.Location = new System.Drawing.Point(383, 128);
			// 
			// btnAltera
			// 
			this.btnAltera.Location = new System.Drawing.Point(383, 98);
			this.btnAltera.Click += new System.EventHandler(this.BtnAlteraClick);
			// 
			// btnExclui
			// 
			this.btnExclui.Location = new System.Drawing.Point(383, 68);
			this.btnExclui.Click += new System.EventHandler(this.BtnExcluiClick);
			// 
			// btnInclui
			// 
			this.btnInclui.Location = new System.Drawing.Point(383, 38);
			this.btnInclui.Click += new System.EventHandler(this.BtnIncluiClick);
			// 
			// ckbAtiva
			// 
			this.ckbAtiva.Checked = true;
			this.ckbAtiva.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ckbAtiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ckbAtiva.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.ckbAtiva.Location = new System.Drawing.Point(115, 66);
			this.ckbAtiva.Name = "ckbAtiva";
			this.ckbAtiva.Size = new System.Drawing.Size(128, 24);
			this.ckbAtiva.TabIndex = 22;
			this.ckbAtiva.Text = "Ativa";
			this.ckbAtiva.UseVisualStyleBackColor = true;
			// 
			// frmCadCondicoes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.ClientSize = new System.Drawing.Size(495, 334);
			this.Name = "frmCadCondicoes";
			this.Text = "Pedidos - Condições de Pagamento";
			this.Load += new System.EventHandler(this.FCondicoesLoad);
			this.pnlEdicao.ResumeLayout(false);
			this.pnlEdicao.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
