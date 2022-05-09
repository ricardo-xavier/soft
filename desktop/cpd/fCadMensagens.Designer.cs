/*
 * Criado por SharpDevelop.
 * Usuário: Ricardo
 * Data: 02/03/2011
 * Hora: 21:29
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace cpd
{
	partial class fCadMensagens
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox edtMensagem;
		
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
			this.edtMensagem = new System.Windows.Forms.TextBox();
			this.pnlEdicao.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(403, 251);
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(293, 251);
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
			this.edtDescricao.Location = new System.Drawing.Point(290, 10);
			this.edtDescricao.MaxLength = 4000;
			this.edtDescricao.Size = new System.Drawing.Size(146, 20);
			// 
			// lblCodigo
			// 
			this.lblCodigo.Location = new System.Drawing.Point(19, 9);
			this.lblCodigo.Size = new System.Drawing.Size(40, 20);
			this.lblCodigo.Text = "Data";
			this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblDescricao
			// 
			this.lblDescricao.Location = new System.Drawing.Point(236, 9);
			this.lblDescricao.Size = new System.Drawing.Size(62, 20);
			this.lblDescricao.Text = "Usuário";
			this.lblDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnlEdicao
			// 
			this.pnlEdicao.Controls.Add(this.edtMensagem);
			this.pnlEdicao.Size = new System.Drawing.Size(523, 285);
			this.pnlEdicao.Controls.SetChildIndex(this.lblCodigo, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblDescricao, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtCodigo, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtDescricao, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.btnConfirma, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.btnCancela, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtMensagem, 0);
			// 
			// btnFecha
			// 
			this.btnFecha.Location = new System.Drawing.Point(415, 133);
			// 
			// btnAltera
			// 
			this.btnAltera.Location = new System.Drawing.Point(415, 103);
			this.btnAltera.Click += new System.EventHandler(this.BtnAlteraClick);
			// 
			// btnExclui
			// 
			this.btnExclui.Location = new System.Drawing.Point(415, 73);
			this.btnExclui.Click += new System.EventHandler(this.BtnExcluiClick);
			// 
			// btnInclui
			// 
			this.btnInclui.Location = new System.Drawing.Point(415, 43);
			this.btnInclui.Click += new System.EventHandler(this.BtnIncluiClick);
			// 
			// edtMensagem
			// 
			this.edtMensagem.Location = new System.Drawing.Point(19, 49);
			this.edtMensagem.Multiline = true;
			this.edtMensagem.Name = "edtMensagem";
			this.edtMensagem.Size = new System.Drawing.Size(484, 176);
			this.edtMensagem.TabIndex = 4;
			// 
			// fCadMensagens
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(547, 490);
			this.Name = "fCadMensagens";
			this.Text = "Mensagens";
			this.Load += new System.EventHandler(this.fCadMensagensLoad);
			this.pnlEdicao.ResumeLayout(false);
			this.pnlEdicao.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
