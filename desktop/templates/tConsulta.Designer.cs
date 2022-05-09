/*
 * Usuário: Ricardo
 * Data: 17/04/2008
 * Hora: 23:19
 * 
 */
namespace templates
{
	partial class tConsulta
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.edtDescricao = new System.Windows.Forms.TextBox();
			this.edtCodigo = new System.Windows.Forms.TextBox();
			this.lblDescricao = new System.Windows.Forms.Label();
			this.lblCodigo = new System.Windows.Forms.Label();
			this.btnConfirma = new System.Windows.Forms.Button();
			this.btnCancela = new System.Windows.Forms.Button();
			this.btnLimpa = new System.Windows.Forms.Button();
			this.lblTitulo = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.edtDescricao);
			this.panel1.Controls.Add(this.edtCodigo);
			this.panel1.Controls.Add(this.lblDescricao);
			this.panel1.Controls.Add(this.lblCodigo);
			this.panel1.Location = new System.Drawing.Point(12, 48);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(364, 204);
			this.panel1.TabIndex = 0;
			// 
			// edtDescricao
			// 
			this.edtDescricao.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtDescricao.Location = new System.Drawing.Point(115, 40);
			this.edtDescricao.MaxLength = 30;
			this.edtDescricao.Name = "edtDescricao";
			this.edtDescricao.Size = new System.Drawing.Size(216, 20);
			this.edtDescricao.TabIndex = 7;
			// 
			// edtCodigo
			// 
			this.edtCodigo.BackColor = System.Drawing.SystemColors.Info;
			this.edtCodigo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtCodigo.Location = new System.Drawing.Point(115, 10);
			this.edtCodigo.MaxLength = 10;
			this.edtCodigo.Name = "edtCodigo";
			this.edtCodigo.Size = new System.Drawing.Size(76, 20);
			this.edtCodigo.TabIndex = 6;
			// 
			// lblDescricao
			// 
			this.lblDescricao.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblDescricao.Location = new System.Drawing.Point(10, 40);
			this.lblDescricao.Name = "lblDescricao";
			this.lblDescricao.Size = new System.Drawing.Size(100, 20);
			this.lblDescricao.TabIndex = 5;
			this.lblDescricao.Text = "Descrição";
			this.lblDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblCodigo
			// 
			this.lblCodigo.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCodigo.Location = new System.Drawing.Point(10, 10);
			this.lblCodigo.Name = "lblCodigo";
			this.lblCodigo.Size = new System.Drawing.Size(100, 20);
			this.lblCodigo.TabIndex = 4;
			this.lblCodigo.Text = "Código";
			this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(398, 45);
			this.btnConfirma.Name = "btnConfirma";
			this.btnConfirma.Size = new System.Drawing.Size(100, 25);
			this.btnConfirma.TabIndex = 8;
			this.btnConfirma.Text = "&Confirma";
			this.btnConfirma.UseVisualStyleBackColor = true;
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(398, 76);
			this.btnCancela.Name = "btnCancela";
			this.btnCancela.Size = new System.Drawing.Size(100, 25);
			this.btnCancela.TabIndex = 9;
			this.btnCancela.Text = "C&ancela";
			this.btnCancela.UseVisualStyleBackColor = true;
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
			// 
			// btnLimpa
			// 
			this.btnLimpa.Location = new System.Drawing.Point(398, 107);
			this.btnLimpa.Name = "btnLimpa";
			this.btnLimpa.Size = new System.Drawing.Size(100, 25);
			this.btnLimpa.TabIndex = 10;
			this.btnLimpa.Text = "&Limpa";
			this.btnLimpa.UseVisualStyleBackColor = true;
			this.btnLimpa.Click += new System.EventHandler(this.BtnLimpaClick);
			// 
			// lblTitulo
			// 
			this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitulo.Location = new System.Drawing.Point(12, 9);
			this.lblTitulo.Name = "lblTitulo";
			this.lblTitulo.Size = new System.Drawing.Size(364, 26);
			this.lblTitulo.TabIndex = 11;
			this.lblTitulo.Text = "Seleção de ";
			// 
			// tConsulta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(510, 264);
			this.Controls.Add(this.lblTitulo);
			this.Controls.Add(this.btnLimpa);
			this.Controls.Add(this.btnCancela);
			this.Controls.Add(this.btnConfirma);
			this.Controls.Add(this.panel1);
			this.Name = "tConsulta";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "tConsulta";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
		}
		public System.Windows.Forms.Label lblCodigo;
		public System.Windows.Forms.Label lblDescricao;
		public System.Windows.Forms.TextBox edtCodigo;
		public System.Windows.Forms.TextBox edtDescricao;
		public System.Windows.Forms.Label lblTitulo;
		public System.Windows.Forms.Button btnLimpa;
		public System.Windows.Forms.Button btnCancela;
		public System.Windows.Forms.Button btnConfirma;
		public System.Windows.Forms.Panel panel1;
	}
}
