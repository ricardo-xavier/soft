/*
 * Criado por SharpDevelop.
 * Usuário: Ricardo
 * Data: 30/09/2008
 * Hora: 20:20
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace basico
{
	partial class fCodigoCopia
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
			this.lblParceiro = new System.Windows.Forms.Label();
			this.btnCopia = new System.Windows.Forms.Button();
			this.btnCancela = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// edtCodigo
			// 
			this.edtCodigo.BackColor = System.Drawing.SystemColors.Info;
			this.edtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtCodigo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtCodigo.Location = new System.Drawing.Point(117, 12);
			this.edtCodigo.MaxLength = 50;
			this.edtCodigo.Name = "edtCodigo";
			this.edtCodigo.Size = new System.Drawing.Size(146, 20);
			this.edtCodigo.TabIndex = 75;
			// 
			// lblParceiro
			// 
			this.lblParceiro.ForeColor = System.Drawing.Color.Red;
			this.lblParceiro.Location = new System.Drawing.Point(12, 12);
			this.lblParceiro.Name = "lblParceiro";
			this.lblParceiro.Size = new System.Drawing.Size(100, 20);
			this.lblParceiro.TabIndex = 76;
			this.lblParceiro.Text = "Novo Código";
			this.lblParceiro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnCopia
			// 
			this.btnCopia.Location = new System.Drawing.Point(57, 50);
			this.btnCopia.Name = "btnCopia";
			this.btnCopia.Size = new System.Drawing.Size(100, 25);
			this.btnCopia.TabIndex = 77;
			this.btnCopia.Text = "Copia";
			this.btnCopia.UseVisualStyleBackColor = true;
			this.btnCopia.Click += new System.EventHandler(this.BtnCopiaClick);
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(163, 50);
			this.btnCancela.Name = "btnCancela";
			this.btnCancela.Size = new System.Drawing.Size(100, 25);
			this.btnCancela.TabIndex = 78;
			this.btnCancela.Text = "Cancela";
			this.btnCancela.UseVisualStyleBackColor = true;
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
			// 
			// fCodigoCopia
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 84);
			this.Controls.Add(this.btnCancela);
			this.Controls.Add(this.btnCopia);
			this.Controls.Add(this.edtCodigo);
			this.Controls.Add(this.lblParceiro);
			this.Name = "fCodigoCopia";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Copia Característica";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnCancela;
		private System.Windows.Forms.Button btnCopia;
		private System.Windows.Forms.Label lblParceiro;
		private System.Windows.Forms.TextBox edtCodigo;
	}
}
