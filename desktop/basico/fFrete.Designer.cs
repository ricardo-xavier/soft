/*
 * Criado por SharpDevelop.
 * Usuário: Ricardo
 * Data: 21/08/2010
 * Hora: 19:56
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace basico
{
	partial class fFrete
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
			this.label2 = new System.Windows.Forms.Label();
			this.edtAtual = new System.Windows.Forms.TextBox();
			this.btnCancela = new System.Windows.Forms.Button();
			this.btnConfirma = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.edtValor = new System.Windows.Forms.TextBox();
			this.chkAdicionar = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.edtNovo = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label2.Location = new System.Drawing.Point(34, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 20);
			this.label2.TabIndex = 127;
			this.label2.Text = "Frete Atual";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtAtual
			// 
			this.edtAtual.BackColor = System.Drawing.SystemColors.Window;
			this.edtAtual.Enabled = false;
			this.edtAtual.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtAtual.Location = new System.Drawing.Point(108, 22);
			this.edtAtual.MaxLength = 20;
			this.edtAtual.Name = "edtAtual";
			this.edtAtual.Size = new System.Drawing.Size(111, 20);
			this.edtAtual.TabIndex = 124;
			this.edtAtual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(282, 113);
			this.btnCancela.Name = "btnCancela";
			this.btnCancela.Size = new System.Drawing.Size(100, 25);
			this.btnCancela.TabIndex = 6;
			this.btnCancela.Text = "C&ancela";
			this.btnCancela.UseVisualStyleBackColor = true;
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(176, 113);
			this.btnConfirma.Name = "btnConfirma";
			this.btnConfirma.Size = new System.Drawing.Size(100, 25);
			this.btnConfirma.TabIndex = 4;
			this.btnConfirma.Text = "&Confirma";
			this.btnConfirma.UseVisualStyleBackColor = true;
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(34, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 20);
			this.label1.TabIndex = 129;
			this.label1.Text = "Valor";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtValor
			// 
			this.edtValor.BackColor = System.Drawing.SystemColors.Window;
			this.edtValor.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtValor.Location = new System.Drawing.Point(108, 48);
			this.edtValor.MaxLength = 20;
			this.edtValor.Name = "edtValor";
			this.edtValor.Size = new System.Drawing.Size(111, 20);
			this.edtValor.TabIndex = 0;
			this.edtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.edtValor.TextChanged += new System.EventHandler(this.EdtValorTextChanged);
			// 
			// chkAdicionar
			// 
			this.chkAdicionar.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkAdicionar.Location = new System.Drawing.Point(243, 48);
			this.chkAdicionar.Name = "chkAdicionar";
			this.chkAdicionar.Size = new System.Drawing.Size(139, 20);
			this.chkAdicionar.TabIndex = 2;
			this.chkAdicionar.Text = "Adicionar ao valor atual";
			this.chkAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.chkAdicionar.UseVisualStyleBackColor = true;
			this.chkAdicionar.CheckedChanged += new System.EventHandler(this.ChkAdicionarCheckedChanged);
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label3.Location = new System.Drawing.Point(34, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 20);
			this.label3.TabIndex = 132;
			this.label3.Text = "Novo Valor";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtNovo
			// 
			this.edtNovo.BackColor = System.Drawing.SystemColors.Window;
			this.edtNovo.Enabled = false;
			this.edtNovo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtNovo.Location = new System.Drawing.Point(108, 74);
			this.edtNovo.MaxLength = 20;
			this.edtNovo.Name = "edtNovo";
			this.edtNovo.Size = new System.Drawing.Size(111, 20);
			this.edtNovo.TabIndex = 131;
			this.edtNovo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// fFrete
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(391, 150);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.edtNovo);
			this.Controls.Add(this.chkAdicionar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.edtValor);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.edtAtual);
			this.Controls.Add(this.btnCancela);
			this.Controls.Add(this.btnConfirma);
			this.Name = "fFrete";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Frete";
			this.Load += new System.EventHandler(this.FFreteLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		public System.Windows.Forms.TextBox edtAtual;
		public System.Windows.Forms.TextBox edtNovo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox chkAdicionar;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.Button btnConfirma;
		public System.Windows.Forms.Button btnCancela;
		public System.Windows.Forms.TextBox edtValor;
		private System.Windows.Forms.Label label2;
	}
}
