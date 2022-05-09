/*
 * Created by SharpDevelop.
 * User: Ricardo.Xavier
 * Date: 16/09/2020
 * Time: 09:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace basico
{
	partial class fCadEmail
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox edtRemetente;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox edtUsuario;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox edtSenha;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox edtDestinatarios;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox edtTexto;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnConfirma;
		private System.Windows.Forms.Button btnCancela;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox edtAssunto;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.edtRemetente = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.edtUsuario = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.edtSenha = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.edtDestinatarios = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.edtTexto = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btnConfirma = new System.Windows.Forms.Button();
			this.btnCancela = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.edtAssunto = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Remetente";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtRemetente
			// 
			this.edtRemetente.Location = new System.Drawing.Point(99, 15);
			this.edtRemetente.Name = "edtRemetente";
			this.edtRemetente.Size = new System.Drawing.Size(431, 20);
			this.edtRemetente.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(13, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Usuário";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtUsuario
			// 
			this.edtUsuario.Location = new System.Drawing.Point(99, 50);
			this.edtUsuario.Name = "edtUsuario";
			this.edtUsuario.Size = new System.Drawing.Size(185, 20);
			this.edtUsuario.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(290, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Senha";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtSenha
			// 
			this.edtSenha.Location = new System.Drawing.Point(376, 50);
			this.edtSenha.Name = "edtSenha";
			this.edtSenha.PasswordChar = '*';
			this.edtSenha.Size = new System.Drawing.Size(100, 20);
			this.edtSenha.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(13, 83);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Destinatários";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtDestinatarios
			// 
			this.edtDestinatarios.Location = new System.Drawing.Point(99, 85);
			this.edtDestinatarios.Multiline = true;
			this.edtDestinatarios.Name = "edtDestinatarios";
			this.edtDestinatarios.Size = new System.Drawing.Size(430, 74);
			this.edtDestinatarios.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(13, 204);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Texto";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtTexto
			// 
			this.edtTexto.AcceptsReturn = true;
			this.edtTexto.Location = new System.Drawing.Point(99, 206);
			this.edtTexto.Multiline = true;
			this.edtTexto.Name = "edtTexto";
			this.edtTexto.Size = new System.Drawing.Size(430, 74);
			this.edtTexto.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.Color.Red;
			this.label6.Location = new System.Drawing.Point(99, 283);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(430, 23);
			this.label6.TabIndex = 10;
			this.label6.Text = "Macros: $DATA$, $CLIENTE$";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(373, 317);
			this.btnConfirma.Name = "btnConfirma";
			this.btnConfirma.Size = new System.Drawing.Size(75, 23);
			this.btnConfirma.TabIndex = 13;
			this.btnConfirma.Text = "Confirma";
			this.btnConfirma.UseVisualStyleBackColor = true;
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(454, 317);
			this.btnCancela.Name = "btnCancela";
			this.btnCancela.Size = new System.Drawing.Size(75, 23);
			this.btnCancela.TabIndex = 15;
			this.btnCancela.Text = "Cancela";
			this.btnCancela.UseVisualStyleBackColor = true;
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(13, 172);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 23);
			this.label7.TabIndex = 13;
			this.label7.Text = "Assunto";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtAssunto
			// 
			this.edtAssunto.Location = new System.Drawing.Point(99, 175);
			this.edtAssunto.Name = "edtAssunto";
			this.edtAssunto.Size = new System.Drawing.Size(431, 20);
			this.edtAssunto.TabIndex = 9;
			// 
			// fCadEmail
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(542, 353);
			this.Controls.Add(this.edtAssunto);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.btnCancela);
			this.Controls.Add(this.btnConfirma);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.edtTexto);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.edtDestinatarios);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.edtSenha);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.edtUsuario);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.edtRemetente);
			this.Controls.Add(this.label1);
			this.Name = "fCadEmail";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Email para o APP";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
