/*
 * Criado por SharpDevelop.
 * Usuário: Ricardo
 * Data: 09/05/2009
 * Hora: 21:57
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace pedido
{
	partial class fAlteraComissao
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
			this.label2 = new System.Windows.Forms.Label();
			this.edtJustificativa = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.edtPercentual = new System.Windows.Forms.TextBox();
			this.edtValor = new System.Windows.Forms.TextBox();
			this.chkPago = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(345, 89);
			this.btnCancela.Name = "btnCancela";
			this.btnCancela.Size = new System.Drawing.Size(100, 25);
			this.btnCancela.TabIndex = 12;
			this.btnCancela.Text = "C&ancela";
			this.btnCancela.UseVisualStyleBackColor = true;
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(239, 89);
			this.btnConfirma.Name = "btnConfirma";
			this.btnConfirma.Size = new System.Drawing.Size(100, 25);
			this.btnConfirma.TabIndex = 10;
			this.btnConfirma.Text = "&Confirma";
			this.btnConfirma.UseVisualStyleBackColor = true;
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label2.Location = new System.Drawing.Point(12, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 20);
			this.label2.TabIndex = 123;
			this.label2.Text = "Justificativa";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtJustificativa
			// 
			this.edtJustificativa.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtJustificativa.Location = new System.Drawing.Point(86, 38);
			this.edtJustificativa.Name = "edtJustificativa";
			this.edtJustificativa.Size = new System.Drawing.Size(356, 20);
			this.edtJustificativa.TabIndex = 6;
			// 
			// label7
			// 
			this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label7.Location = new System.Drawing.Point(54, 12);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(12, 20);
			this.label7.TabIndex = 122;
			this.label7.Text = "%";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtPercentual
			// 
			this.edtPercentual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtPercentual.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtPercentual.Location = new System.Drawing.Point(7, 12);
			this.edtPercentual.MaxLength = 50;
			this.edtPercentual.Name = "edtPercentual";
			this.edtPercentual.Size = new System.Drawing.Size(41, 20);
			this.edtPercentual.TabIndex = 2;
			this.edtPercentual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.edtPercentual.TextChanged += new System.EventHandler(this.EdtPercentTextChanged);
			// 
			// edtValor
			// 
			this.edtValor.BackColor = System.Drawing.SystemColors.Window;
			this.edtValor.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtValor.Location = new System.Drawing.Point(86, 12);
			this.edtValor.MaxLength = 20;
			this.edtValor.Name = "edtValor";
			this.edtValor.Size = new System.Drawing.Size(111, 20);
			this.edtValor.TabIndex = 4;
			this.edtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.edtValor.TextChanged += new System.EventHandler(this.EdtValorTextChanged);
			// 
			// chkPago
			// 
			this.chkPago.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.chkPago.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkPago.Location = new System.Drawing.Point(19, 64);
			this.chkPago.Name = "chkPago";
			this.chkPago.Size = new System.Drawing.Size(80, 20);
			this.chkPago.TabIndex = 8;
			this.chkPago.Text = "Pago";
			this.chkPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.chkPago.UseVisualStyleBackColor = true;
			// 
			// fAlteraComissao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(452, 130);
			this.Controls.Add(this.chkPago);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.edtJustificativa);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.edtPercentual);
			this.Controls.Add(this.edtValor);
			this.Controls.Add(this.btnCancela);
			this.Controls.Add(this.btnConfirma);
			this.Name = "fAlteraComissao";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Altera Valor da Comissão";
			this.Load += new System.EventHandler(this.FAlteraComissaoLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox edtJustificativa;
		public System.Windows.Forms.TextBox edtPercentual;
		private System.Windows.Forms.CheckBox chkPago;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.TextBox edtValor;
		public System.Windows.Forms.Button btnConfirma;
		public System.Windows.Forms.Button btnCancela;
	}
}
