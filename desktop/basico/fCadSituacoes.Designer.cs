/*
 * Usuário: Ricardo
 * Data: 05/04/2008
 * Hora: 23:06
 * 
 */
namespace basico
{
	partial class frmCadSituacoes
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
			this.chkDefault = new System.Windows.Forms.CheckBox();
			this.chkAviso = new System.Windows.Forms.CheckBox();
			this.chkConcretizado = new System.Windows.Forms.CheckBox();
			this.ckbAtiva = new System.Windows.Forms.CheckBox();
			this.pnlEdicao.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(371, 155);
			this.btnCancela.TabIndex = 10;
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(261, 155);
			this.btnConfirma.TabIndex = 9;
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// edtCodigo
			// 
			this.edtCodigo.Size = new System.Drawing.Size(13, 20);
			// 
			// edtDescricao
			// 
			this.edtDescricao.MaxLength = 50;
			this.edtDescricao.Size = new System.Drawing.Size(356, 20);
			// 
			// pnlEdicao
			// 
			this.pnlEdicao.Controls.Add(this.ckbAtiva);
			this.pnlEdicao.Controls.Add(this.chkConcretizado);
			this.pnlEdicao.Controls.Add(this.chkAviso);
			this.pnlEdicao.Controls.Add(this.chkDefault);
			this.pnlEdicao.Size = new System.Drawing.Size(478, 194);
			this.pnlEdicao.Controls.SetChildIndex(this.lblCodigo, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblDescricao, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtCodigo, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtDescricao, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.btnConfirma, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.btnCancela, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.chkDefault, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.chkAviso, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.chkConcretizado, 0);
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
			// chkDefault
			// 
			this.chkDefault.Checked = true;
			this.chkDefault.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkDefault.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkDefault.Location = new System.Drawing.Point(115, 70);
			this.chkDefault.Name = "chkDefault";
			this.chkDefault.Size = new System.Drawing.Size(183, 24);
			this.chkDefault.TabIndex = 4;
			this.chkDefault.Text = "Apresentar automaticamente";
			this.chkDefault.UseVisualStyleBackColor = true;
			// 
			// chkAviso
			// 
			this.chkAviso.Checked = true;
			this.chkAviso.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkAviso.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkAviso.Location = new System.Drawing.Point(115, 97);
			this.chkAviso.Name = "chkAviso";
			this.chkAviso.Size = new System.Drawing.Size(183, 24);
			this.chkAviso.TabIndex = 7;
			this.chkAviso.Text = "Gerar aviso";
			this.chkAviso.UseVisualStyleBackColor = true;
			// 
			// chkConcretizado
			// 
			this.chkConcretizado.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkConcretizado.Location = new System.Drawing.Point(115, 125);
			this.chkConcretizado.Name = "chkConcretizado";
			this.chkConcretizado.Size = new System.Drawing.Size(183, 24);
			this.chkConcretizado.TabIndex = 8;
			this.chkConcretizado.Text = "Concretizado";
			this.chkConcretizado.UseVisualStyleBackColor = true;
			// 
			// ckbAtiva
			// 
			this.ckbAtiva.Checked = true;
			this.ckbAtiva.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ckbAtiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ckbAtiva.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.ckbAtiva.Location = new System.Drawing.Point(115, 155);
			this.ckbAtiva.Name = "ckbAtiva";
			this.ckbAtiva.Size = new System.Drawing.Size(128, 24);
			this.ckbAtiva.TabIndex = 23;
			this.ckbAtiva.Text = "Ativa";
			this.ckbAtiva.UseVisualStyleBackColor = true;
			// 
			// frmCadSituacoes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.ClientSize = new System.Drawing.Size(495, 406);
			this.Name = "frmCadSituacoes";
			this.Text = "Situações do Orçamento";
			this.Load += new System.EventHandler(this.FSituacoesLoad);
			this.pnlEdicao.ResumeLayout(false);
			this.pnlEdicao.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.CheckBox chkConcretizado;
		private System.Windows.Forms.CheckBox chkAviso;
		private System.Windows.Forms.CheckBox chkDefault;
		private System.Windows.Forms.CheckBox ckbAtiva;
	}
}
