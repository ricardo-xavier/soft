/*
 * Criado por SharpDevelop.
 * Usuário: Ricardo
 * Data: 15/1/2015
 * Hora: 15:33
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace acao
{
	partial class fObservacao
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
			this.edtObservacao = new System.Windows.Forms.TextBox();
			this.btnFecha = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// edtObservacao
			// 
			this.edtObservacao.BackColor = System.Drawing.SystemColors.Info;
			this.edtObservacao.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtObservacao.Location = new System.Drawing.Point(3, 3);
			this.edtObservacao.Multiline = true;
			this.edtObservacao.Name = "edtObservacao";
			this.edtObservacao.ReadOnly = true;
			this.edtObservacao.Size = new System.Drawing.Size(402, 214);
			this.edtObservacao.TabIndex = 176;
			// 
			// btnFecha
			// 
			this.btnFecha.Location = new System.Drawing.Point(170, 226);
			this.btnFecha.Name = "btnFecha";
			this.btnFecha.Size = new System.Drawing.Size(100, 25);
			this.btnFecha.TabIndex = 177;
			this.btnFecha.Text = "&Fecha";
			this.btnFecha.UseVisualStyleBackColor = true;
			this.btnFecha.Click += new System.EventHandler(this.BtnFechaClick);
			// 
			// fObservacao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(410, 257);
			this.Controls.Add(this.btnFecha);
			this.Controls.Add(this.edtObservacao);
			this.Name = "fObservacao";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Observação";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		public System.Windows.Forms.Button btnFecha;
		public System.Windows.Forms.TextBox edtObservacao;
	}
}
