/*
 * Usuário: Ricardo
 * Data: 22/03/2008
 * Hora: 1:07
 * 
 */
namespace templates
{
	partial class frmLogin
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
			this.btnCancela = new System.Windows.Forms.Button();
			this.btnConfirma = new System.Windows.Forms.Button();
			this.edtSenha = new System.Windows.Forms.TextBox();
			this.edtUsuario = new System.Windows.Forms.TextBox();
			this.lblSenha = new System.Windows.Forms.Label();
			this.pnlDados = new System.Windows.Forms.Panel();
			this.cbxFiliais = new System.Windows.Forms.ComboBox();
			this.lblFilial = new System.Windows.Forms.Label();
			this.lblUsuario = new System.Windows.Forms.Label();
			this.pnlDados.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(223, 125);
			this.btnCancela.Name = "btnCancela";
			this.btnCancela.Size = new System.Drawing.Size(100, 25);
			this.btnCancela.TabIndex = 5;
			this.btnCancela.Text = "Cancela";
			this.btnCancela.UseVisualStyleBackColor = true;
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(120, 125);
			this.btnConfirma.Name = "btnConfirma";
			this.btnConfirma.Size = new System.Drawing.Size(100, 25);
			this.btnConfirma.TabIndex = 4;
			this.btnConfirma.Text = "Confirma";
			this.btnConfirma.UseVisualStyleBackColor = true;
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// edtSenha
			// 
			this.edtSenha.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtSenha.Location = new System.Drawing.Point(80, 50);
			this.edtSenha.MaxLength = 10;
			this.edtSenha.Name = "edtSenha";
			this.edtSenha.Size = new System.Drawing.Size(76, 20);
			this.edtSenha.TabIndex = 2;
			this.edtSenha.Text = "012345678901234567890123456789";
			this.edtSenha.UseSystemPasswordChar = true;
			// 
			// edtUsuario
			// 
			this.edtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
			this.edtUsuario.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtUsuario.Location = new System.Drawing.Point(80, 20);
			this.edtUsuario.MaxLength = 20;
			this.edtUsuario.Name = "edtUsuario";
			this.edtUsuario.Size = new System.Drawing.Size(146, 20);
			this.edtUsuario.TabIndex = 1;
			this.edtUsuario.Text = "0123456789";
			// 
			// lblSenha
			// 
			this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSenha.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblSenha.Location = new System.Drawing.Point(10, 50);
			this.lblSenha.Name = "lblSenha";
			this.lblSenha.Size = new System.Drawing.Size(60, 20);
			this.lblSenha.TabIndex = 1;
			this.lblSenha.Text = "Senha";
			this.lblSenha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// pnlDados
			// 
			this.pnlDados.BackColor = System.Drawing.SystemColors.ControlLight;
			this.pnlDados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlDados.Controls.Add(this.cbxFiliais);
			this.pnlDados.Controls.Add(this.lblFilial);
			this.pnlDados.Controls.Add(this.btnCancela);
			this.pnlDados.Controls.Add(this.btnConfirma);
			this.pnlDados.Controls.Add(this.edtSenha);
			this.pnlDados.Controls.Add(this.edtUsuario);
			this.pnlDados.Controls.Add(this.lblSenha);
			this.pnlDados.Controls.Add(this.lblUsuario);
			this.pnlDados.Location = new System.Drawing.Point(5, 5);
			this.pnlDados.Name = "pnlDados";
			this.pnlDados.Size = new System.Drawing.Size(333, 160);
			this.pnlDados.TabIndex = 6;
			// 
			// cbxFiliais
			// 
			this.cbxFiliais.FormattingEnabled = true;
			this.cbxFiliais.Location = new System.Drawing.Point(80, 80);
			this.cbxFiliais.Name = "cbxFiliais";
			this.cbxFiliais.Size = new System.Drawing.Size(244, 21);
			this.cbxFiliais.TabIndex = 3;
			// 
			// lblFilial
			// 
			this.lblFilial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFilial.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblFilial.Location = new System.Drawing.Point(10, 80);
			this.lblFilial.Name = "lblFilial";
			this.lblFilial.Size = new System.Drawing.Size(60, 20);
			this.lblFilial.TabIndex = 5;
			this.lblFilial.Text = "Filial";
			this.lblFilial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblUsuario
			// 
			this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsuario.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblUsuario.Location = new System.Drawing.Point(10, 20);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(60, 20);
			this.lblUsuario.TabIndex = 0;
			this.lblUsuario.Text = "Usuário";
			this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// frmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(342, 169);
			this.Controls.Add(this.pnlDados);
			this.Name = "frmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Acesso ao Sistema";
			this.Load += new System.EventHandler(this.FrmLoginLoad);
			this.Shown += new System.EventHandler(this.FrmLoginShown);
			this.pnlDados.ResumeLayout(false);
			this.pnlDados.PerformLayout();
			this.ResumeLayout(false);
		}
		public System.Windows.Forms.ComboBox cbxFiliais;
		public System.Windows.Forms.Label lblFilial;
		private System.Windows.Forms.Panel pnlDados;
		private System.Windows.Forms.Label lblUsuario;
		private System.Windows.Forms.Label lblSenha;
		private System.Windows.Forms.TextBox edtUsuario;
		private System.Windows.Forms.TextBox edtSenha;
		private System.Windows.Forms.Button btnConfirma;
		private System.Windows.Forms.Button btnCancela;
	}
}
