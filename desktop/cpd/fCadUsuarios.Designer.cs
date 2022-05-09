/*
 * Usuário: Ricardo
 * Data: 22/03/2008
 * Hora: 19:55
 * 
 */
namespace cpd
{
	partial class frmCadUsuarios
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
			this.edtConfirma = new System.Windows.Forms.TextBox();
			this.edtSenha = new System.Windows.Forms.TextBox();
			this.ckbAdministrador = new System.Windows.Forms.CheckBox();
			this.lblConfirmaSenha = new System.Windows.Forms.Label();
			this.lblSenha = new System.Windows.Forms.Label();
			this.ckbAtivo = new System.Windows.Forms.CheckBox();
			this.btnAlteraSenha = new System.Windows.Forms.Button();
			this.pnlEdicao.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(310, 140);
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(200, 140);
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// edtCodigo
			// 
			this.edtCodigo.Size = new System.Drawing.Size(146, 20);
			// 
			// lblDescricao
			// 
			this.lblDescricao.Text = "*Nome";
			// 
			// pnlEdicao
			// 
			this.pnlEdicao.Controls.Add(this.ckbAtivo);
			this.pnlEdicao.Controls.Add(this.edtConfirma);
			this.pnlEdicao.Controls.Add(this.edtSenha);
			this.pnlEdicao.Controls.Add(this.ckbAdministrador);
			this.pnlEdicao.Controls.Add(this.lblConfirmaSenha);
			this.pnlEdicao.Controls.Add(this.lblSenha);
			this.pnlEdicao.Size = new System.Drawing.Size(420, 170);
			this.pnlEdicao.Controls.SetChildIndex(this.lblCodigo, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblDescricao, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtCodigo, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtDescricao, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.btnConfirma, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.btnCancela, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblSenha, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblConfirmaSenha, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.ckbAdministrador, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtSenha, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtConfirma, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.ckbAtivo, 0);
			// 
			// btnFecha
			// 
			this.btnFecha.Location = new System.Drawing.Point(320, 160);
			this.btnFecha.TabIndex = 7;
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
			// edtConfirma
			// 
			this.edtConfirma.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtConfirma.Location = new System.Drawing.Point(281, 70);
			this.edtConfirma.MaxLength = 10;
			this.edtConfirma.Name = "edtConfirma";
			this.edtConfirma.Size = new System.Drawing.Size(76, 20);
			this.edtConfirma.TabIndex = 10;
			this.edtConfirma.UseSystemPasswordChar = true;
			// 
			// edtSenha
			// 
			this.edtSenha.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtSenha.Location = new System.Drawing.Point(115, 70);
			this.edtSenha.MaxLength = 10;
			this.edtSenha.Name = "edtSenha";
			this.edtSenha.Size = new System.Drawing.Size(76, 20);
			this.edtSenha.TabIndex = 9;
			this.edtSenha.UseSystemPasswordChar = true;
			// 
			// ckbAdministrador
			// 
			this.ckbAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ckbAdministrador.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.ckbAdministrador.Location = new System.Drawing.Point(115, 100);
			this.ckbAdministrador.Name = "ckbAdministrador";
			this.ckbAdministrador.Size = new System.Drawing.Size(151, 24);
			this.ckbAdministrador.TabIndex = 11;
			this.ckbAdministrador.Text = "Administrador";
			this.ckbAdministrador.UseVisualStyleBackColor = true;
			// 
			// lblConfirmaSenha
			// 
			this.lblConfirmaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblConfirmaSenha.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblConfirmaSenha.Location = new System.Drawing.Point(195, 70);
			this.lblConfirmaSenha.Name = "lblConfirmaSenha";
			this.lblConfirmaSenha.Size = new System.Drawing.Size(80, 20);
			this.lblConfirmaSenha.TabIndex = 13;
			this.lblConfirmaSenha.Text = "Confirma";
			this.lblConfirmaSenha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblSenha
			// 
			this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSenha.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblSenha.Location = new System.Drawing.Point(10, 70);
			this.lblSenha.Name = "lblSenha";
			this.lblSenha.Size = new System.Drawing.Size(100, 20);
			this.lblSenha.TabIndex = 12;
			this.lblSenha.Text = "Senha";
			this.lblSenha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ckbAtivo
			// 
			this.ckbAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ckbAtivo.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.ckbAtivo.Location = new System.Drawing.Point(229, 100);
			this.ckbAtivo.Name = "ckbAtivo";
			this.ckbAtivo.Size = new System.Drawing.Size(128, 24);
			this.ckbAtivo.TabIndex = 12;
			this.ckbAtivo.Text = "Ativo";
			this.ckbAtivo.UseVisualStyleBackColor = true;
			// 
			// btnAlteraSenha
			// 
			this.btnAlteraSenha.Location = new System.Drawing.Point(320, 130);
			this.btnAlteraSenha.Name = "btnAlteraSenha";
			this.btnAlteraSenha.Size = new System.Drawing.Size(100, 25);
			this.btnAlteraSenha.TabIndex = 6;
			this.btnAlteraSenha.Text = "Altera Senha";
			this.btnAlteraSenha.UseVisualStyleBackColor = true;
			this.btnAlteraSenha.Click += new System.EventHandler(this.BtnAlteraSenhaClick);
			// 
			// frmCadUsuarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.ClientSize = new System.Drawing.Size(434, 374);
			this.Controls.Add(this.btnAlteraSenha);
			this.Name = "frmCadUsuarios";
			this.Text = "CPD - Cadastro de Usuários";
			this.Load += new System.EventHandler(this.FrmCadUsuariosLoad);
			this.Controls.SetChildIndex(this.btnAlteraSenha, 0);
			this.Controls.SetChildIndex(this.btnFecha, 0);
			this.Controls.SetChildIndex(this.btnInclui, 0);
			this.Controls.SetChildIndex(this.btnExclui, 0);
			this.Controls.SetChildIndex(this.btnAltera, 0);
			this.Controls.SetChildIndex(this.pnlEdicao, 0);
			this.Controls.SetChildIndex(this.edtLocaliza, 0);
			this.Controls.SetChildIndex(this.btnLocaliza, 0);
			this.pnlEdicao.ResumeLayout(false);
			this.pnlEdicao.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnAlteraSenha;
		private System.Windows.Forms.CheckBox ckbAtivo;
		private System.Windows.Forms.Label lblSenha;
		private System.Windows.Forms.Label lblConfirmaSenha;
		private System.Windows.Forms.CheckBox ckbAdministrador;
		private System.Windows.Forms.TextBox edtSenha;
		private System.Windows.Forms.TextBox edtConfirma;
	}
}
