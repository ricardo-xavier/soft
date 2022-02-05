/*
 * Usuário: Ricardo
 * Data: 07/04/2008
 * Hora: 23:31
 * 
 */
namespace basico
{
	partial class frmCadCargos
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.CheckBox ckbAtivo;
		
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
			this.ckbAtivo = new System.Windows.Forms.CheckBox();
			this.pnlEdicao.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCancela
			// 
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
			// 
			// btnConfirma
			// 
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// pnlEdicao
			// 
			this.pnlEdicao.Controls.Add(this.ckbAtivo);
			this.pnlEdicao.Controls.SetChildIndex(this.lblCodigo, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblDescricao, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtCodigo, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtDescricao, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.btnConfirma, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.btnCancela, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.ckbAtivo, 0);
			// 
			// btnAltera
			// 
			this.btnAltera.Click += new System.EventHandler(this.BtnAlteraClick);
			// 
			// btnExclui
			// 
			this.btnExclui.Click += new System.EventHandler(this.BtnExcluiClick);
			// 
			// btnInclui
			// 
			this.btnInclui.Click += new System.EventHandler(this.BtnIncluiClick);
			// 
			// ckbAtivo
			// 
			this.ckbAtivo.Checked = true;
			this.ckbAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ckbAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ckbAtivo.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.ckbAtivo.Location = new System.Drawing.Point(115, 66);
			this.ckbAtivo.Name = "ckbAtivo";
			this.ckbAtivo.Size = new System.Drawing.Size(128, 24);
			this.ckbAtivo.TabIndex = 4;
			this.ckbAtivo.Text = "Ativo";
			this.ckbAtivo.UseVisualStyleBackColor = true;
			// 
			// frmCadCargos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.ClientSize = new System.Drawing.Size(434, 334);
			this.Name = "frmCadCargos";
			this.Text = "Cadastros Básicos - Cargos";
			this.Load += new System.EventHandler(this.FrmCadCargosLoad);
			this.pnlEdicao.ResumeLayout(false);
			this.pnlEdicao.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
