/*
 * Criado por SharpDevelop.
 * Usuário: Ricardo
 * Data: 02/03/2011
 * Hora: 21:29
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace basico
{
	partial class fCondicoesMontagem
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
			this.pnlEdicao.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(485, 251);
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(375, 251);
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// edtCodigo
			// 
			this.edtCodigo.Location = new System.Drawing.Point(65, 10);
			this.edtCodigo.MaxLength = 20;
			this.edtCodigo.Size = new System.Drawing.Size(146, 20);
			// 
			// edtDescricao
			// 
			this.edtDescricao.Location = new System.Drawing.Point(19, 63);
			this.edtDescricao.MaxLength = 4000;
			this.edtDescricao.Multiline = true;
			this.edtDescricao.Size = new System.Drawing.Size(566, 184);
			// 
			// lblCodigo
			// 
			this.lblCodigo.Location = new System.Drawing.Point(19, 9);
			this.lblCodigo.Size = new System.Drawing.Size(40, 20);
			this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblDescricao
			// 
			this.lblDescricao.Location = new System.Drawing.Point(19, 39);
			this.lblDescricao.Size = new System.Drawing.Size(62, 20);
			this.lblDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnlEdicao
			// 
			this.pnlEdicao.Size = new System.Drawing.Size(603, 285);
			// 
			// btnFecha
			// 
			this.btnFecha.Location = new System.Drawing.Point(512, 130);
			// 
			// btnAltera
			// 
			this.btnAltera.Location = new System.Drawing.Point(512, 100);
			// 
			// btnExclui
			// 
			this.btnExclui.Location = new System.Drawing.Point(512, 70);
			this.btnExclui.Click += new System.EventHandler(this.BtnExcluiClick);
			// 
			// btnInclui
			// 
			this.btnInclui.Location = new System.Drawing.Point(512, 40);
			// 
			// fCondicoesMontagem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(624, 490);
			this.Name = "fCondicoesMontagem";
			this.Text = "Condições de Montagem";
			this.Load += new System.EventHandler(this.fCondicoesMontagemLoad);
			this.pnlEdicao.ResumeLayout(false);
			this.pnlEdicao.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
	}
}
