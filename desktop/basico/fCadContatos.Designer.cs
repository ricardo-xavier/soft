/*
 * Usuário: Ricardo
 * Data: 13/04/2008
 * Hora: 21:26
 * 
 */
namespace basico
{
	partial class frmCadContatos
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
			this.ckbAtivo = new System.Windows.Forms.CheckBox();
			this.edtEmail = new System.Windows.Forms.TextBox();
			this.lblEmail = new System.Windows.Forms.Label();
			this.edtFone2 = new System.Windows.Forms.TextBox();
			this.edtFone1 = new System.Windows.Forms.TextBox();
			this.lblFone = new System.Windows.Forms.Label();
			this.lblPapel = new System.Windows.Forms.Label();
			this.edtPapel = new System.Windows.Forms.TextBox();
			this.lblParceiro = new System.Windows.Forms.Label();
			this.lblCelular = new System.Windows.Forms.Label();
			this.edtCelular = new System.Windows.Forms.TextBox();
			this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
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
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(390, 169);
			this.btnCancela.TabIndex = 12;
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(280, 169);
			this.btnConfirma.TabIndex = 11;
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// edtCodigo
			// 
			this.edtCodigo.Location = new System.Drawing.Point(95, 10);
			this.edtCodigo.MaxLength = 20;
			this.edtCodigo.Size = new System.Drawing.Size(146, 20);
			// 
			// edtDescricao
			// 
			this.edtDescricao.Location = new System.Drawing.Point(95, 40);
			this.edtDescricao.MaxLength = 50;
			this.edtDescricao.Size = new System.Drawing.Size(356, 20);
			// 
			// lblCodigo
			// 
			this.lblCodigo.Size = new System.Drawing.Size(80, 20);
			// 
			// lblDescricao
			// 
			this.lblDescricao.Size = new System.Drawing.Size(80, 20);
			this.lblDescricao.Text = "*Nome";
			// 
			// pnlEdicao
			// 
			this.pnlEdicao.Controls.Add(this.dtpNascimento);
			this.pnlEdicao.Controls.Add(this.label1);
			this.pnlEdicao.Controls.Add(this.lblCelular);
			this.pnlEdicao.Controls.Add(this.edtCelular);
			this.pnlEdicao.Controls.Add(this.edtPapel);
			this.pnlEdicao.Controls.Add(this.lblPapel);
			this.pnlEdicao.Controls.Add(this.ckbAtivo);
			this.pnlEdicao.Controls.Add(this.edtEmail);
			this.pnlEdicao.Controls.Add(this.lblEmail);
			this.pnlEdicao.Controls.Add(this.edtFone2);
			this.pnlEdicao.Controls.Add(this.edtFone1);
			this.pnlEdicao.Controls.Add(this.lblFone);
			this.pnlEdicao.Location = new System.Drawing.Point(10, 225);
			this.pnlEdicao.Size = new System.Drawing.Size(506, 207);
			this.pnlEdicao.TabIndex = 8;
			this.pnlEdicao.Controls.SetChildIndex(this.lblCodigo, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblDescricao, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtCodigo, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtDescricao, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.btnConfirma, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.btnCancela, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblFone, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtFone1, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtFone2, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblEmail, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtEmail, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.ckbAtivo, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblPapel, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtPapel, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtCelular, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblCelular, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.label1, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.dtpNascimento, 0);
			// 
			// btnFecha
			// 
			this.btnFecha.Location = new System.Drawing.Point(412, 159);
			// 
			// btnAltera
			// 
			this.btnAltera.Location = new System.Drawing.Point(412, 129);
			this.btnAltera.Click += new System.EventHandler(this.BtnAlteraClick);
			// 
			// btnExclui
			// 
			this.btnExclui.Location = new System.Drawing.Point(412, 99);
			this.btnExclui.Click += new System.EventHandler(this.BtnExcluiClick);
			// 
			// btnInclui
			// 
			this.btnInclui.Location = new System.Drawing.Point(412, 69);
			this.btnInclui.Click += new System.EventHandler(this.BtnIncluiClick);
			// 
			// ckbAtivo
			// 
			this.ckbAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ckbAtivo.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.ckbAtivo.Location = new System.Drawing.Point(346, 130);
			this.ckbAtivo.Name = "ckbAtivo";
			this.ckbAtivo.Size = new System.Drawing.Size(128, 24);
			this.ckbAtivo.TabIndex = 9;
			this.ckbAtivo.Text = "Ativo";
			this.ckbAtivo.UseVisualStyleBackColor = true;
			// 
			// edtEmail
			// 
			this.edtEmail.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtEmail.Location = new System.Drawing.Point(95, 100);
			this.edtEmail.MaxLength = 50;
			this.edtEmail.Name = "edtEmail";
			this.edtEmail.Size = new System.Drawing.Size(356, 20);
			this.edtEmail.TabIndex = 7;
			// 
			// lblEmail
			// 
			this.lblEmail.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblEmail.Location = new System.Drawing.Point(10, 100);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(80, 20);
			this.lblEmail.TabIndex = 76;
			this.lblEmail.Text = "email";
			this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtFone2
			// 
			this.edtFone2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtFone2.Location = new System.Drawing.Point(210, 70);
			this.edtFone2.MaxLength = 13;
			this.edtFone2.Name = "edtFone2";
			this.edtFone2.Size = new System.Drawing.Size(97, 20);
			this.edtFone2.TabIndex = 5;
			this.edtFone2.Leave += new System.EventHandler(this.EdtFone2Leave);
			this.edtFone2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EdtNUMERICOKeyPress);
			this.edtFone2.Enter += new System.EventHandler(this.EdtFone2Enter);
			// 
			// edtFone1
			// 
			this.edtFone1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtFone1.Location = new System.Drawing.Point(95, 70);
			this.edtFone1.MaxLength = 13;
			this.edtFone1.Name = "edtFone1";
			this.edtFone1.Size = new System.Drawing.Size(97, 20);
			this.edtFone1.TabIndex = 4;
			this.edtFone1.Leave += new System.EventHandler(this.EdtFone1Leave);
			this.edtFone1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EdtNUMERICOKeyPress);
			this.edtFone1.Enter += new System.EventHandler(this.EdtFone1Enter);
			// 
			// lblFone
			// 
			this.lblFone.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblFone.Location = new System.Drawing.Point(10, 70);
			this.lblFone.Name = "lblFone";
			this.lblFone.Size = new System.Drawing.Size(80, 20);
			this.lblFone.TabIndex = 75;
			this.lblFone.Text = "Fone";
			this.lblFone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblPapel
			// 
			this.lblPapel.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblPapel.Location = new System.Drawing.Point(10, 130);
			this.lblPapel.Name = "lblPapel";
			this.lblPapel.Size = new System.Drawing.Size(80, 20);
			this.lblPapel.TabIndex = 77;
			this.lblPapel.Text = "Papel";
			this.lblPapel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtPapel
			// 
			this.edtPapel.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtPapel.Location = new System.Drawing.Point(95, 130);
			this.edtPapel.MaxLength = 30;
			this.edtPapel.Name = "edtPapel";
			this.edtPapel.Size = new System.Drawing.Size(216, 20);
			this.edtPapel.TabIndex = 8;
			// 
			// lblParceiro
			// 
			this.lblParceiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblParceiro.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblParceiro.Location = new System.Drawing.Point(12, 8);
			this.lblParceiro.Name = "lblParceiro";
			this.lblParceiro.Size = new System.Drawing.Size(300, 20);
			this.lblParceiro.TabIndex = 25;
			this.lblParceiro.Text = "Parceiro:";
			this.lblParceiro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblCelular
			// 
			this.lblCelular.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCelular.Location = new System.Drawing.Point(320, 70);
			this.lblCelular.Name = "lblCelular";
			this.lblCelular.Size = new System.Drawing.Size(60, 20);
			this.lblCelular.TabIndex = 79;
			this.lblCelular.Text = "Celular";
			this.lblCelular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtCelular
			// 
			this.edtCelular.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtCelular.Location = new System.Drawing.Point(387, 70);
			this.edtCelular.MaxLength = 14;
			this.edtCelular.Name = "edtCelular";
			this.edtCelular.Size = new System.Drawing.Size(104, 20);
			this.edtCelular.TabIndex = 6;
			this.edtCelular.Leave += new System.EventHandler(this.EdtCelularLeave);
			this.edtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EdtNUMERICOKeyPress);
			this.edtCelular.Enter += new System.EventHandler(this.EdtCelularEnter);
			// 
			// dtpNascimento
			// 
			this.dtpNascimento.Checked = false;
			this.dtpNascimento.CustomFormat = "dd/MM/yyyy";
			this.dtpNascimento.Enabled = false;
			this.dtpNascimento.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpNascimento.Location = new System.Drawing.Point(95, 160);
			this.dtpNascimento.Name = "dtpNascimento";
			this.dtpNascimento.ShowCheckBox = true;
			this.dtpNascimento.Size = new System.Drawing.Size(108, 20);
			this.dtpNascimento.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(10, 160);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 20);
			this.label1.TabIndex = 129;
			this.label1.Text = "Nascimento";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// frmCadContatos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(527, 441);
			this.Controls.Add(this.lblParceiro);
			this.Name = "frmCadContatos";
			this.Text = "Cadastros Básicos - Contatos";
			this.Load += new System.EventHandler(this.FrmCadContatosLoad);
			this.Controls.SetChildIndex(this.btnUp, 0);
			this.Controls.SetChildIndex(this.btnDown, 0);
			this.Controls.SetChildIndex(this.btnInclui, 0);
			this.Controls.SetChildIndex(this.btnExclui, 0);
			this.Controls.SetChildIndex(this.btnAltera, 0);
			this.Controls.SetChildIndex(this.btnFecha, 0);
			this.Controls.SetChildIndex(this.pnlEdicao, 0);
			this.Controls.SetChildIndex(this.edtLocaliza, 0);
			this.Controls.SetChildIndex(this.btnLocaliza, 0);
			this.Controls.SetChildIndex(this.lblParceiro, 0);
			this.pnlEdicao.ResumeLayout(false);
			this.pnlEdicao.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.DateTimePicker dtpNascimento;
		private System.Windows.Forms.TextBox edtCelular;
		private System.Windows.Forms.Label lblCelular;
		private System.Windows.Forms.Label lblParceiro;
		private System.Windows.Forms.TextBox edtPapel;
		private System.Windows.Forms.Label lblFone;
		private System.Windows.Forms.TextBox edtFone1;
		private System.Windows.Forms.TextBox edtFone2;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.TextBox edtEmail;
		private System.Windows.Forms.CheckBox ckbAtivo;
		private System.Windows.Forms.Label lblPapel;
	}
}
