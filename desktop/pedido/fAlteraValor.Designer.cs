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
	partial class fAlteraValor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAlteraValor));
			this.edtValor = new System.Windows.Forms.TextBox();
			this.lblPrecoVenda = new System.Windows.Forms.Label();
			this.btnCancela = new System.Windows.Forms.Button();
			this.btnConfirma = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.edtPedido = new System.Windows.Forms.TextBox();
			this.btnConsultor = new System.Windows.Forms.Button();
			this.edtConsultor = new System.Windows.Forms.TextBox();
			this.lblConsultor = new System.Windows.Forms.Label();
			this.ckbRecebido = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// edtValor
			// 
			this.edtValor.BackColor = System.Drawing.SystemColors.Window;
			this.edtValor.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtValor.Location = new System.Drawing.Point(122, 19);
			this.edtValor.MaxLength = 20;
			this.edtValor.Name = "edtValor";
			this.edtValor.Size = new System.Drawing.Size(111, 20);
			this.edtValor.TabIndex = 0;
			this.edtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lblPrecoVenda
			// 
			this.lblPrecoVenda.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblPrecoVenda.Location = new System.Drawing.Point(17, 19);
			this.lblPrecoVenda.Name = "lblPrecoVenda";
			this.lblPrecoVenda.Size = new System.Drawing.Size(100, 20);
			this.lblPrecoVenda.TabIndex = 90;
			this.lblPrecoVenda.Text = "Valor";
			this.lblPrecoVenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(218, 125);
			this.btnCancela.Name = "btnCancela";
			this.btnCancela.Size = new System.Drawing.Size(100, 25);
			this.btnCancela.TabIndex = 7;
			this.btnCancela.Text = "C&ancela";
			this.btnCancela.UseVisualStyleBackColor = true;
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(112, 125);
			this.btnConfirma.Name = "btnConfirma";
			this.btnConfirma.Size = new System.Drawing.Size(100, 25);
			this.btnConfirma.TabIndex = 6;
			this.btnConfirma.Text = "&Confirma";
			this.btnConfirma.UseVisualStyleBackColor = true;
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label5.Location = new System.Drawing.Point(56, 44);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(60, 20);
			this.label5.TabIndex = 145;
			this.label5.Text = "Pedido";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtPedido
			// 
			this.edtPedido.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtPedido.Location = new System.Drawing.Point(122, 45);
			this.edtPedido.Name = "edtPedido";
			this.edtPedido.Size = new System.Drawing.Size(69, 20);
			this.edtPedido.TabIndex = 1;
			// 
			// btnConsultor
			// 
			this.btnConsultor.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultor.Image")));
			this.btnConsultor.Location = new System.Drawing.Point(282, 69);
			this.btnConsultor.Name = "btnConsultor";
			this.btnConsultor.Size = new System.Drawing.Size(36, 23);
			this.btnConsultor.TabIndex = 3;
			this.btnConsultor.UseVisualStyleBackColor = true;
			this.btnConsultor.Click += new System.EventHandler(this.BtnConsultorClick);
			// 
			// edtConsultor
			// 
			this.edtConsultor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtConsultor.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtConsultor.Location = new System.Drawing.Point(122, 71);
			this.edtConsultor.MaxLength = 50;
			this.edtConsultor.Name = "edtConsultor";
			this.edtConsultor.ReadOnly = true;
			this.edtConsultor.Size = new System.Drawing.Size(146, 20);
			this.edtConsultor.TabIndex = 2;
			// 
			// lblConsultor
			// 
			this.lblConsultor.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblConsultor.Location = new System.Drawing.Point(32, 71);
			this.lblConsultor.Name = "lblConsultor";
			this.lblConsultor.Size = new System.Drawing.Size(80, 20);
			this.lblConsultor.TabIndex = 148;
			this.lblConsultor.Text = "Consultor";
			this.lblConsultor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ckbRecebido
			// 
			this.ckbRecebido.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.ckbRecebido.Location = new System.Drawing.Point(122, 97);
			this.ckbRecebido.Name = "ckbRecebido";
			this.ckbRecebido.Size = new System.Drawing.Size(100, 22);
			this.ckbRecebido.TabIndex = 5;
			this.ckbRecebido.Text = "Recebido";
			this.ckbRecebido.UseVisualStyleBackColor = true;
			// 
			// fAlteraValor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(324, 158);
			this.Controls.Add(this.ckbRecebido);
			this.Controls.Add(this.btnConsultor);
			this.Controls.Add(this.edtConsultor);
			this.Controls.Add(this.lblConsultor);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.edtPedido);
			this.Controls.Add(this.btnCancela);
			this.Controls.Add(this.btnConfirma);
			this.Controls.Add(this.edtValor);
			this.Controls.Add(this.lblPrecoVenda);
			this.Name = "fAlteraValor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Altera Valor do Pedido";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		public System.Windows.Forms.CheckBox ckbRecebido;
		private System.Windows.Forms.Label lblConsultor;
		public System.Windows.Forms.TextBox edtConsultor;
		private System.Windows.Forms.Button btnConsultor;
		public System.Windows.Forms.TextBox edtPedido;
		private System.Windows.Forms.Label label5;
		public System.Windows.Forms.TextBox edtValor;
		public System.Windows.Forms.Button btnConfirma;
		public System.Windows.Forms.Button btnCancela;
		private System.Windows.Forms.Label lblPrecoVenda;
	}
}
