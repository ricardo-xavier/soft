/*
 * Criado por SharpDevelop.
 * Usuário: Ricardo
 * Data: 05/09/2008
 * Hora: 21:36
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace receber
{
	partial class fParametrosRemessa
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
			this.edtCodigo = new System.Windows.Forms.TextBox();
			this.lblCodigo = new System.Windows.Forms.Label();
			this.edtRazao = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.edtRemessa = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.edtNosso = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.edtCarteira = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.edtAgencia = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.edtConta = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.edtMulta = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.edtBonificacao = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.edtAtraso = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.edtDesconto = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.edtMsg1 = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.edtMsg2 = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.edtMsg3 = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.edtMsg4 = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.edtDVAgencia = new System.Windows.Forms.TextBox();
			this.edtDVConta = new System.Windows.Forms.TextBox();
			this.edtPrazo = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.btnCancela = new System.Windows.Forms.Button();
			this.btnConfirma = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// edtCodigo
			// 
			this.edtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtCodigo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtCodigo.Location = new System.Drawing.Point(93, 12);
			this.edtCodigo.MaxLength = 20;
			this.edtCodigo.Name = "edtCodigo";
			this.edtCodigo.Size = new System.Drawing.Size(146, 20);
			this.edtCodigo.TabIndex = 0;
			// 
			// lblCodigo
			// 
			this.lblCodigo.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCodigo.Location = new System.Drawing.Point(8, 12);
			this.lblCodigo.Name = "lblCodigo";
			this.lblCodigo.Size = new System.Drawing.Size(80, 20);
			this.lblCodigo.TabIndex = 86;
			this.lblCodigo.Text = "Cod Empresa";
			this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtRazao
			// 
			this.edtRazao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtRazao.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtRazao.Location = new System.Drawing.Point(93, 38);
			this.edtRazao.MaxLength = 30;
			this.edtRazao.Name = "edtRazao";
			this.edtRazao.Size = new System.Drawing.Size(216, 20);
			this.edtRazao.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(8, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 20);
			this.label1.TabIndex = 88;
			this.label1.Text = "Razão";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtRemessa
			// 
			this.edtRemessa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtRemessa.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtRemessa.Location = new System.Drawing.Point(93, 64);
			this.edtRemessa.MaxLength = 7;
			this.edtRemessa.Name = "edtRemessa";
			this.edtRemessa.Size = new System.Drawing.Size(55, 20);
			this.edtRemessa.TabIndex = 2;
			this.edtRemessa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label2.Location = new System.Drawing.Point(8, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 20);
			this.label2.TabIndex = 90;
			this.label2.Text = "Remessa";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtNosso
			// 
			this.edtNosso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtNosso.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtNosso.Location = new System.Drawing.Point(93, 90);
			this.edtNosso.MaxLength = 11;
			this.edtNosso.Name = "edtNosso";
			this.edtNosso.Size = new System.Drawing.Size(83, 20);
			this.edtNosso.TabIndex = 3;
			this.edtNosso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label3.Location = new System.Drawing.Point(8, 90);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 20);
			this.label3.TabIndex = 92;
			this.label3.Text = "Nosso Número";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtCarteira
			// 
			this.edtCarteira.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtCarteira.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtCarteira.Location = new System.Drawing.Point(93, 116);
			this.edtCarteira.MaxLength = 2;
			this.edtCarteira.Name = "edtCarteira";
			this.edtCarteira.Size = new System.Drawing.Size(20, 20);
			this.edtCarteira.TabIndex = 4;
			this.edtCarteira.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label4.Location = new System.Drawing.Point(8, 116);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 20);
			this.label4.TabIndex = 94;
			this.label4.Text = "Carteira";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtAgencia
			// 
			this.edtAgencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtAgencia.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtAgencia.Location = new System.Drawing.Point(93, 142);
			this.edtAgencia.MaxLength = 4;
			this.edtAgencia.Name = "edtAgencia";
			this.edtAgencia.Size = new System.Drawing.Size(34, 20);
			this.edtAgencia.TabIndex = 5;
			this.edtAgencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label5.Location = new System.Drawing.Point(8, 142);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 20);
			this.label5.TabIndex = 96;
			this.label5.Text = "Agência";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtConta
			// 
			this.edtConta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtConta.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtConta.Location = new System.Drawing.Point(93, 168);
			this.edtConta.MaxLength = 6;
			this.edtConta.Name = "edtConta";
			this.edtConta.Size = new System.Drawing.Size(48, 20);
			this.edtConta.TabIndex = 7;
			this.edtConta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label6.Location = new System.Drawing.Point(8, 168);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 20);
			this.label6.TabIndex = 98;
			this.label6.Text = "Conta";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtMulta
			// 
			this.edtMulta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtMulta.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtMulta.Location = new System.Drawing.Point(93, 194);
			this.edtMulta.MaxLength = 5;
			this.edtMulta.Name = "edtMulta";
			this.edtMulta.Size = new System.Drawing.Size(41, 20);
			this.edtMulta.TabIndex = 9;
			this.edtMulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label7
			// 
			this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label7.Location = new System.Drawing.Point(8, 194);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(80, 20);
			this.label7.TabIndex = 100;
			this.label7.Text = "Multa";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtBonificacao
			// 
			this.edtBonificacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtBonificacao.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtBonificacao.Location = new System.Drawing.Point(93, 220);
			this.edtBonificacao.MaxLength = 11;
			this.edtBonificacao.Name = "edtBonificacao";
			this.edtBonificacao.Size = new System.Drawing.Size(83, 20);
			this.edtBonificacao.TabIndex = 10;
			this.edtBonificacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label8
			// 
			this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label8.Location = new System.Drawing.Point(8, 220);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(80, 20);
			this.label8.TabIndex = 102;
			this.label8.Text = "Bonificação";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtAtraso
			// 
			this.edtAtraso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtAtraso.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtAtraso.Location = new System.Drawing.Point(93, 246);
			this.edtAtraso.MaxLength = 13;
			this.edtAtraso.Name = "edtAtraso";
			this.edtAtraso.Size = new System.Drawing.Size(97, 20);
			this.edtAtraso.TabIndex = 11;
			this.edtAtraso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label9
			// 
			this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label9.Location = new System.Drawing.Point(8, 246);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(80, 20);
			this.label9.TabIndex = 104;
			this.label9.Text = "Atraso";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtDesconto
			// 
			this.edtDesconto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtDesconto.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtDesconto.Location = new System.Drawing.Point(93, 272);
			this.edtDesconto.MaxLength = 13;
			this.edtDesconto.Name = "edtDesconto";
			this.edtDesconto.Size = new System.Drawing.Size(97, 20);
			this.edtDesconto.TabIndex = 12;
			this.edtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label10
			// 
			this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label10.Location = new System.Drawing.Point(8, 272);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(80, 20);
			this.label10.TabIndex = 106;
			this.label10.Text = "Desconto";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtMsg1
			// 
			this.edtMsg1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtMsg1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtMsg1.Location = new System.Drawing.Point(93, 298);
			this.edtMsg1.MaxLength = 80;
			this.edtMsg1.Name = "edtMsg1";
			this.edtMsg1.Size = new System.Drawing.Size(566, 20);
			this.edtMsg1.TabIndex = 14;
			// 
			// label11
			// 
			this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label11.Location = new System.Drawing.Point(8, 298);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(80, 20);
			this.label11.TabIndex = 108;
			this.label11.Text = "Mensagem 1";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtMsg2
			// 
			this.edtMsg2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtMsg2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtMsg2.Location = new System.Drawing.Point(93, 324);
			this.edtMsg2.MaxLength = 80;
			this.edtMsg2.Name = "edtMsg2";
			this.edtMsg2.Size = new System.Drawing.Size(566, 20);
			this.edtMsg2.TabIndex = 15;
			// 
			// label12
			// 
			this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label12.Location = new System.Drawing.Point(8, 324);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(80, 20);
			this.label12.TabIndex = 110;
			this.label12.Text = "Mensagem 2";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtMsg3
			// 
			this.edtMsg3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtMsg3.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtMsg3.Location = new System.Drawing.Point(93, 350);
			this.edtMsg3.MaxLength = 80;
			this.edtMsg3.Name = "edtMsg3";
			this.edtMsg3.Size = new System.Drawing.Size(566, 20);
			this.edtMsg3.TabIndex = 16;
			// 
			// label13
			// 
			this.label13.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label13.Location = new System.Drawing.Point(8, 350);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(80, 20);
			this.label13.TabIndex = 112;
			this.label13.Text = "Mensagem 3";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtMsg4
			// 
			this.edtMsg4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtMsg4.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtMsg4.Location = new System.Drawing.Point(93, 376);
			this.edtMsg4.MaxLength = 80;
			this.edtMsg4.Name = "edtMsg4";
			this.edtMsg4.Size = new System.Drawing.Size(566, 20);
			this.edtMsg4.TabIndex = 17;
			// 
			// label14
			// 
			this.label14.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label14.Location = new System.Drawing.Point(8, 376);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(80, 20);
			this.label14.TabIndex = 114;
			this.label14.Text = "Mensagem 4";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtDVAgencia
			// 
			this.edtDVAgencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtDVAgencia.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtDVAgencia.Location = new System.Drawing.Point(133, 142);
			this.edtDVAgencia.MaxLength = 1;
			this.edtDVAgencia.Name = "edtDVAgencia";
			this.edtDVAgencia.Size = new System.Drawing.Size(13, 20);
			this.edtDVAgencia.TabIndex = 6;
			this.edtDVAgencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// edtDVConta
			// 
			this.edtDVConta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtDVConta.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtDVConta.Location = new System.Drawing.Point(147, 168);
			this.edtDVConta.MaxLength = 1;
			this.edtDVConta.Name = "edtDVConta";
			this.edtDVConta.Size = new System.Drawing.Size(13, 20);
			this.edtDVConta.TabIndex = 8;
			this.edtDVConta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// edtPrazo
			// 
			this.edtPrazo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtPrazo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtPrazo.Location = new System.Drawing.Point(288, 273);
			this.edtPrazo.MaxLength = 4;
			this.edtPrazo.Name = "edtPrazo";
			this.edtPrazo.Size = new System.Drawing.Size(34, 20);
			this.edtPrazo.TabIndex = 13;
			this.edtPrazo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label15
			// 
			this.label15.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label15.Location = new System.Drawing.Point(202, 273);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(80, 20);
			this.label15.TabIndex = 118;
			this.label15.Text = "Dias Prazo";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(562, 402);
			this.btnCancela.Name = "btnCancela";
			this.btnCancela.Size = new System.Drawing.Size(100, 25);
			this.btnCancela.TabIndex = 19;
			this.btnCancela.Text = "C&ancela";
			this.btnCancela.UseVisualStyleBackColor = true;
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(457, 402);
			this.btnConfirma.Name = "btnConfirma";
			this.btnConfirma.Size = new System.Drawing.Size(100, 25);
			this.btnConfirma.TabIndex = 18;
			this.btnConfirma.Text = "&Confirma";
			this.btnConfirma.UseVisualStyleBackColor = true;
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// fParametrosRemessa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(674, 430);
			this.Controls.Add(this.btnCancela);
			this.Controls.Add(this.btnConfirma);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.edtPrazo);
			this.Controls.Add(this.edtDVConta);
			this.Controls.Add(this.edtDVAgencia);
			this.Controls.Add(this.edtMsg4);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.edtMsg3);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.edtMsg2);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.edtMsg1);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.edtDesconto);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.edtAtraso);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.edtBonificacao);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.edtMulta);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.edtConta);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.edtAgencia);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.edtCarteira);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.edtNosso);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.edtRemessa);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.edtRazao);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.edtCodigo);
			this.Controls.Add(this.lblCodigo);
			this.Name = "fParametrosRemessa";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Parâmetros Remessa";
			this.Load += new System.EventHandler(this.FParametrosRemessaLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		public System.Windows.Forms.Button btnConfirma;
		public System.Windows.Forms.Button btnCancela;
		public System.Windows.Forms.TextBox edtPrazo;
		public System.Windows.Forms.TextBox edtDVConta;
		public System.Windows.Forms.TextBox edtDVAgencia;
		public System.Windows.Forms.TextBox edtMsg4;
		public System.Windows.Forms.TextBox edtMsg3;
		public System.Windows.Forms.TextBox edtMsg2;
		public System.Windows.Forms.TextBox edtMsg1;
		public System.Windows.Forms.TextBox edtDesconto;
		public System.Windows.Forms.TextBox edtAtraso;
		public System.Windows.Forms.TextBox edtBonificacao;
		public System.Windows.Forms.TextBox edtMulta;
		public System.Windows.Forms.TextBox edtConta;
		public System.Windows.Forms.TextBox edtAgencia;
		public System.Windows.Forms.TextBox edtCarteira;
		public System.Windows.Forms.TextBox edtNosso;
		public System.Windows.Forms.TextBox edtRemessa;
		public System.Windows.Forms.TextBox edtRazao;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblCodigo;
		public System.Windows.Forms.TextBox edtCodigo;
	}
}
