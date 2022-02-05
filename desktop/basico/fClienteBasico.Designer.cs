/*
 * Criado por SharpDevelop.
 * Usuário: Ricardo
 * Data: 13/10/2008
 * Hora: 20:17
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace basico
{
	partial class fClienteBasico
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
			this.edtFone2 = new System.Windows.Forms.TextBox();
			this.lblCelular = new System.Windows.Forms.Label();
			this.lblFone = new System.Windows.Forms.Label();
			this.edtFone1 = new System.Windows.Forms.TextBox();
			this.edtFAX = new System.Windows.Forms.TextBox();
			this.edtCelular = new System.Windows.Forms.TextBox();
			this.lblFAX = new System.Windows.Forms.Label();
			this.edtEmail = new System.Windows.Forms.TextBox();
			this.lblEmail = new System.Windows.Forms.Label();
			this.edtRazao = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.edtCodigo = new System.Windows.Forms.TextBox();
			this.btnCodigo = new System.Windows.Forms.Label();
			this.btnCancela = new System.Windows.Forms.Button();
			this.btnConfirma = new System.Windows.Forms.Button();
			this.gbxContato = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.edtCelularContato = new System.Windows.Forms.TextBox();
			this.edtPapel = new System.Windows.Forms.TextBox();
			this.lblPapel = new System.Windows.Forms.Label();
			this.edtEmailContato = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.edtFoneContato2 = new System.Windows.Forms.TextBox();
			this.edtFoneContato1 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.edtContato = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.edtNome = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.gbxContato.SuspendLayout();
			this.SuspendLayout();
			// 
			// edtFone2
			// 
			this.edtFone2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtFone2.Location = new System.Drawing.Point(215, 73);
			this.edtFone2.MaxLength = 13;
			this.edtFone2.Name = "edtFone2";
			this.edtFone2.Size = new System.Drawing.Size(97, 20);
			this.edtFone2.TabIndex = 3;
			this.edtFone2.Leave += new System.EventHandler(this.EdtFone1Leave);
			this.edtFone2.Enter += new System.EventHandler(this.EdtFone1Enter);
			// 
			// lblCelular
			// 
			this.lblCelular.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCelular.Location = new System.Drawing.Point(328, 73);
			this.lblCelular.Name = "lblCelular";
			this.lblCelular.Size = new System.Drawing.Size(60, 20);
			this.lblCelular.TabIndex = 79;
			this.lblCelular.Text = "Celular";
			this.lblCelular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblFone
			// 
			this.lblFone.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblFone.Location = new System.Drawing.Point(14, 73);
			this.lblFone.Name = "lblFone";
			this.lblFone.Size = new System.Drawing.Size(80, 20);
			this.lblFone.TabIndex = 77;
			this.lblFone.Text = "Fone";
			this.lblFone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtFone1
			// 
			this.edtFone1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtFone1.Location = new System.Drawing.Point(99, 73);
			this.edtFone1.MaxLength = 13;
			this.edtFone1.Name = "edtFone1";
			this.edtFone1.Size = new System.Drawing.Size(97, 20);
			this.edtFone1.TabIndex = 2;
			this.edtFone1.Leave += new System.EventHandler(this.EdtFone1Leave);
			this.edtFone1.Enter += new System.EventHandler(this.EdtFone1Enter);
			// 
			// edtFAX
			// 
			this.edtFAX.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtFAX.Location = new System.Drawing.Point(537, 73);
			this.edtFAX.MaxLength = 13;
			this.edtFAX.Name = "edtFAX";
			this.edtFAX.Size = new System.Drawing.Size(97, 20);
			this.edtFAX.TabIndex = 5;
			this.edtFAX.Leave += new System.EventHandler(this.EdtFone1Leave);
			this.edtFAX.Enter += new System.EventHandler(this.EdtFone1Enter);
			// 
			// edtCelular
			// 
			this.edtCelular.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtCelular.Location = new System.Drawing.Point(395, 73);
			this.edtCelular.MaxLength = 13;
			this.edtCelular.Name = "edtCelular";
			this.edtCelular.Size = new System.Drawing.Size(97, 20);
			this.edtCelular.TabIndex = 4;
			this.edtCelular.Leave += new System.EventHandler(this.EdtFone1Leave);
			this.edtCelular.Enter += new System.EventHandler(this.EdtFone1Enter);
			// 
			// lblFAX
			// 
			this.lblFAX.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblFAX.Location = new System.Drawing.Point(471, 73);
			this.lblFAX.Name = "lblFAX";
			this.lblFAX.Size = new System.Drawing.Size(60, 20);
			this.lblFAX.TabIndex = 78;
			this.lblFAX.Text = "FAX";
			this.lblFAX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtEmail
			// 
			this.edtEmail.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtEmail.Location = new System.Drawing.Point(99, 99);
			this.edtEmail.MaxLength = 50;
			this.edtEmail.Name = "edtEmail";
			this.edtEmail.Size = new System.Drawing.Size(356, 20);
			this.edtEmail.TabIndex = 6;
			// 
			// lblEmail
			// 
			this.lblEmail.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblEmail.Location = new System.Drawing.Point(14, 99);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(80, 20);
			this.lblEmail.TabIndex = 81;
			this.lblEmail.Text = "email";
			this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtRazao
			// 
			this.edtRazao.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtRazao.Location = new System.Drawing.Point(99, 47);
			this.edtRazao.MaxLength = 50;
			this.edtRazao.Name = "edtRazao";
			this.edtRazao.Size = new System.Drawing.Size(356, 20);
			this.edtRazao.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(14, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 20);
			this.label1.TabIndex = 83;
			this.label1.Text = "Razão";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtCodigo
			// 
			this.edtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtCodigo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtCodigo.Location = new System.Drawing.Point(99, 21);
			this.edtCodigo.MaxLength = 50;
			this.edtCodigo.Name = "edtCodigo";
			this.edtCodigo.Size = new System.Drawing.Size(146, 20);
			this.edtCodigo.TabIndex = 0;
			this.edtCodigo.Leave += new System.EventHandler(this.EdtCodigoLeave);
			// 
			// btnCodigo
			// 
			this.btnCodigo.ForeColor = System.Drawing.Color.Red;
			this.btnCodigo.Location = new System.Drawing.Point(14, 21);
			this.btnCodigo.Name = "btnCodigo";
			this.btnCodigo.Size = new System.Drawing.Size(80, 20);
			this.btnCodigo.TabIndex = 85;
			this.btnCodigo.Text = "Código";
			this.btnCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(541, 314);
			this.btnCancela.Name = "btnCancela";
			this.btnCancela.Size = new System.Drawing.Size(100, 25);
			this.btnCancela.TabIndex = 9;
			this.btnCancela.Text = "C&ancela";
			this.btnCancela.UseVisualStyleBackColor = true;
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(435, 314);
			this.btnConfirma.Name = "btnConfirma";
			this.btnConfirma.Size = new System.Drawing.Size(100, 25);
			this.btnConfirma.TabIndex = 8;
			this.btnConfirma.Text = "&Confirma";
			this.btnConfirma.UseVisualStyleBackColor = true;
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// gbxContato
			// 
			this.gbxContato.Controls.Add(this.label4);
			this.gbxContato.Controls.Add(this.edtCelularContato);
			this.gbxContato.Controls.Add(this.edtPapel);
			this.gbxContato.Controls.Add(this.lblPapel);
			this.gbxContato.Controls.Add(this.edtEmailContato);
			this.gbxContato.Controls.Add(this.label5);
			this.gbxContato.Controls.Add(this.edtFoneContato2);
			this.gbxContato.Controls.Add(this.edtFoneContato1);
			this.gbxContato.Controls.Add(this.label6);
			this.gbxContato.Controls.Add(this.edtContato);
			this.gbxContato.Controls.Add(this.label2);
			this.gbxContato.Controls.Add(this.edtNome);
			this.gbxContato.Controls.Add(this.label3);
			this.gbxContato.Location = new System.Drawing.Point(5, 140);
			this.gbxContato.Name = "gbxContato";
			this.gbxContato.Size = new System.Drawing.Size(646, 168);
			this.gbxContato.TabIndex = 7;
			this.gbxContato.TabStop = false;
			this.gbxContato.Text = "Contato";
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label4.Location = new System.Drawing.Point(372, 71);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 20);
			this.label4.TabIndex = 111;
			this.label4.Text = "Celular";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtCelularContato
			// 
			this.edtCelularContato.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtCelularContato.Location = new System.Drawing.Point(439, 71);
			this.edtCelularContato.MaxLength = 14;
			this.edtCelularContato.Name = "edtCelularContato";
			this.edtCelularContato.Size = new System.Drawing.Size(104, 20);
			this.edtCelularContato.TabIndex = 103;
			this.edtCelularContato.Leave += new System.EventHandler(this.EdtFone1Leave);
			this.edtCelularContato.Enter += new System.EventHandler(this.EdtFone1Enter);
			// 
			// edtPapel
			// 
			this.edtPapel.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtPapel.Location = new System.Drawing.Point(147, 131);
			this.edtPapel.MaxLength = 30;
			this.edtPapel.Name = "edtPapel";
			this.edtPapel.Size = new System.Drawing.Size(216, 20);
			this.edtPapel.TabIndex = 105;
			// 
			// lblPapel
			// 
			this.lblPapel.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblPapel.Location = new System.Drawing.Point(62, 131);
			this.lblPapel.Name = "lblPapel";
			this.lblPapel.Size = new System.Drawing.Size(80, 20);
			this.lblPapel.TabIndex = 110;
			this.lblPapel.Text = "Papel";
			this.lblPapel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtEmailContato
			// 
			this.edtEmailContato.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtEmailContato.Location = new System.Drawing.Point(147, 101);
			this.edtEmailContato.MaxLength = 50;
			this.edtEmailContato.Name = "edtEmailContato";
			this.edtEmailContato.Size = new System.Drawing.Size(356, 20);
			this.edtEmailContato.TabIndex = 104;
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label5.Location = new System.Drawing.Point(62, 101);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 20);
			this.label5.TabIndex = 109;
			this.label5.Text = "email";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtFoneContato2
			// 
			this.edtFoneContato2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtFoneContato2.Location = new System.Drawing.Point(262, 71);
			this.edtFoneContato2.MaxLength = 13;
			this.edtFoneContato2.Name = "edtFoneContato2";
			this.edtFoneContato2.Size = new System.Drawing.Size(97, 20);
			this.edtFoneContato2.TabIndex = 102;
			this.edtFoneContato2.Leave += new System.EventHandler(this.EdtFone1Leave);
			this.edtFoneContato2.Enter += new System.EventHandler(this.EdtFone1Enter);
			// 
			// edtFoneContato1
			// 
			this.edtFoneContato1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtFoneContato1.Location = new System.Drawing.Point(147, 71);
			this.edtFoneContato1.MaxLength = 13;
			this.edtFoneContato1.Name = "edtFoneContato1";
			this.edtFoneContato1.Size = new System.Drawing.Size(97, 20);
			this.edtFoneContato1.TabIndex = 101;
			this.edtFoneContato1.Leave += new System.EventHandler(this.EdtFone1Leave);
			this.edtFoneContato1.Enter += new System.EventHandler(this.EdtFone1Enter);
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label6.Location = new System.Drawing.Point(62, 71);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 20);
			this.label6.TabIndex = 108;
			this.label6.Text = "Fone";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtContato
			// 
			this.edtContato.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtContato.Location = new System.Drawing.Point(147, 19);
			this.edtContato.MaxLength = 50;
			this.edtContato.Name = "edtContato";
			this.edtContato.Size = new System.Drawing.Size(146, 20);
			this.edtContato.TabIndex = 99;
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label2.Location = new System.Drawing.Point(62, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 20);
			this.label2.TabIndex = 107;
			this.label2.Text = "Código";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtNome
			// 
			this.edtNome.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtNome.Location = new System.Drawing.Point(147, 45);
			this.edtNome.MaxLength = 50;
			this.edtNome.Name = "edtNome";
			this.edtNome.Size = new System.Drawing.Size(356, 20);
			this.edtNome.TabIndex = 100;
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label3.Location = new System.Drawing.Point(62, 45);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 20);
			this.label3.TabIndex = 106;
			this.label3.Text = "Nome";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// fClienteBasico
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(653, 348);
			this.Controls.Add(this.gbxContato);
			this.Controls.Add(this.btnCancela);
			this.Controls.Add(this.btnConfirma);
			this.Controls.Add(this.edtCodigo);
			this.Controls.Add(this.btnCodigo);
			this.Controls.Add(this.edtRazao);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.edtEmail);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.edtFone2);
			this.Controls.Add(this.lblCelular);
			this.Controls.Add(this.lblFone);
			this.Controls.Add(this.edtFone1);
			this.Controls.Add(this.edtFAX);
			this.Controls.Add(this.edtCelular);
			this.Controls.Add(this.lblFAX);
			this.Name = "fClienteBasico";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro Rápido de Cliente";
			this.gbxContato.ResumeLayout(false);
			this.gbxContato.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.GroupBox gbxContato;
		private System.Windows.Forms.TextBox edtNome;
		public System.Windows.Forms.Button btnConfirma;
		public System.Windows.Forms.Button btnCancela;
		private System.Windows.Forms.TextBox edtRazao;
		public System.Windows.Forms.TextBox edtCodigo;
		private System.Windows.Forms.TextBox edtContato;
		private System.Windows.Forms.TextBox edtCelularContato;
		private System.Windows.Forms.TextBox edtEmailContato;
		private System.Windows.Forms.TextBox edtFoneContato2;
		private System.Windows.Forms.TextBox edtFoneContato1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblPapel;
		private System.Windows.Forms.TextBox edtPapel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label btnCodigo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.TextBox edtEmail;
		private System.Windows.Forms.Label lblFAX;
		private System.Windows.Forms.TextBox edtCelular;
		private System.Windows.Forms.TextBox edtFAX;
		private System.Windows.Forms.TextBox edtFone1;
		private System.Windows.Forms.Label lblFone;
		private System.Windows.Forms.Label lblCelular;
		private System.Windows.Forms.TextBox edtFone2;
	}
}
