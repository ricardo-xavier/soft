/*
 * Usuário: Ricardo
 * Data: 05/04/2008
 * Hora: 23:06
 * 
 */
namespace basico
{
	partial class frmCadSituacoesAcao
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
			this.chkApresentaAutom = new System.Windows.Forms.CheckBox();
			this.chkConcretizada = new System.Windows.Forms.CheckBox();
			this.ckbAtiva = new System.Windows.Forms.CheckBox();
			this.pnlEdicao.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(371, 131);
			this.btnCancela.TabIndex = 7;
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(261, 131);
			this.btnConfirma.TabIndex = 6;
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// edtCodigo
			// 
			this.edtCodigo.Size = new System.Drawing.Size(20, 20);
			// 
			// edtDescricao
			// 
			this.edtDescricao.MaxLength = 50;
			this.edtDescricao.Size = new System.Drawing.Size(356, 20);
			// 
			// pnlEdicao
			// 
			this.pnlEdicao.Controls.Add(this.ckbAtiva);
			this.pnlEdicao.Controls.Add(this.chkConcretizada);
			this.pnlEdicao.Controls.Add(this.chkApresentaAutom);
			this.pnlEdicao.Size = new System.Drawing.Size(478, 169);
			this.pnlEdicao.Controls.SetChildIndex(this.lblCodigo, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblDescricao, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtCodigo, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtDescricao, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.btnConfirma, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.btnCancela, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.chkApresentaAutom, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.chkConcretizada, 0);
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
			// chkApresentaAutom
			// 
			this.chkApresentaAutom.Checked = true;
			this.chkApresentaAutom.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkApresentaAutom.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkApresentaAutom.Location = new System.Drawing.Point(115, 69);
			this.chkApresentaAutom.Name = "chkApresentaAutom";
			this.chkApresentaAutom.Size = new System.Drawing.Size(183, 24);
			this.chkApresentaAutom.TabIndex = 4;
			this.chkApresentaAutom.Text = "Apresentar Automaticamente";
			this.chkApresentaAutom.UseVisualStyleBackColor = true;
			// 
			// chkConcretizada
			// 
			this.chkConcretizada.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkConcretizada.Location = new System.Drawing.Point(115, 99);
			this.chkConcretizada.Name = "chkConcretizada";
			this.chkConcretizada.Size = new System.Drawing.Size(183, 24);
			this.chkConcretizada.TabIndex = 5;
			this.chkConcretizada.Text = "Concretizado";
			this.chkConcretizada.UseVisualStyleBackColor = true;
			// 
			// ckbAtiva
			// 
			this.ckbAtiva.Checked = true;
			this.ckbAtiva.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ckbAtiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ckbAtiva.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.ckbAtiva.Location = new System.Drawing.Point(117, 129);
			this.ckbAtiva.Name = "ckbAtiva";
			this.ckbAtiva.Size = new System.Drawing.Size(128, 24);
			this.ckbAtiva.TabIndex = 24;
			this.ckbAtiva.Text = "Ativa";
			this.ckbAtiva.UseVisualStyleBackColor = true;
			// 
			// frmCadSituacoesAcao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.ClientSize = new System.Drawing.Size(495, 381);
			this.Name = "frmCadSituacoesAcao";
			this.Text = "Ações Comerciais - Situações";
			this.Load += new System.EventHandler(this.FSituacoesLoad);
			this.pnlEdicao.ResumeLayout(false);
			this.pnlEdicao.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.CheckBox chkConcretizada;
		private System.Windows.Forms.CheckBox chkApresentaAutom;
		private System.Windows.Forms.CheckBox ckbAtiva;
	}
}
