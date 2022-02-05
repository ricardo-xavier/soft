/*
 * Usuário: Ricardo
 * Data: 22/04/2008
 * Hora: 23:01
 * 
 */
namespace basico
{
	partial class frmCadProdutos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadProdutos));
			this.lblSubCodigo = new System.Windows.Forms.Label();
			this.edtSubCodigo = new System.Windows.Forms.TextBox();
			this.lblMedida = new System.Windows.Forms.Label();
			this.edtMedida = new System.Windows.Forms.TextBox();
			this.gbxPendencia = new System.Windows.Forms.GroupBox();
			this.edtTexto = new System.Windows.Forms.TextBox();
			this.gbxFoto = new System.Windows.Forms.GroupBox();
			this.imgProduto = new System.Windows.Forms.PictureBox();
			this.btnParceiros = new System.Windows.Forms.Button();
			this.edtParceiro = new System.Windows.Forms.TextBox();
			this.lblParceiro = new System.Windows.Forms.Label();
			this.edtIPI = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.chkGenerico = new System.Windows.Forms.CheckBox();
			this.pnlEdicao.SuspendLayout();
			this.gbxPendencia.SuspendLayout();
			this.gbxFoto.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgProduto)).BeginInit();
			this.SuspendLayout();
			// 
			// btnLocaliza
			// 
			this.btnLocaliza.Click += new System.EventHandler(this.BtnLocalizaClick);
			// 
			// edtLocaliza
			// 
			this.edtLocaliza.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(803, 287);
			this.btnCancela.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.btnCancela.TabIndex = 12;
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(656, 287);
			this.btnConfirma.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.btnConfirma.TabIndex = 11;
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// edtCodigo
			// 
			this.edtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtCodigo.Location = new System.Drawing.Point(100, 49);
			this.edtCodigo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.edtCodigo.MaxLength = 20;
			this.edtCodigo.Size = new System.Drawing.Size(193, 23);
			this.edtCodigo.TabIndex = 4;
			// 
			// edtDescricao
			// 
			this.edtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtDescricao.Location = new System.Drawing.Point(100, 86);
			this.edtDescricao.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.edtDescricao.MaxLength = 50;
			this.edtDescricao.Size = new System.Drawing.Size(473, 23);
			this.edtDescricao.TabIndex = 6;
			// 
			// lblCodigo
			// 
			this.lblCodigo.Location = new System.Drawing.Point(13, 49);
			this.lblCodigo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lblCodigo.Size = new System.Drawing.Size(80, 25);
			// 
			// lblDescricao
			// 
			this.lblDescricao.Location = new System.Drawing.Point(13, 86);
			this.lblDescricao.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lblDescricao.Size = new System.Drawing.Size(80, 25);
			// 
			// pnlEdicao
			// 
			this.pnlEdicao.Controls.Add(this.chkGenerico);
			this.pnlEdicao.Controls.Add(this.edtIPI);
			this.pnlEdicao.Controls.Add(this.label1);
			this.pnlEdicao.Controls.Add(this.btnParceiros);
			this.pnlEdicao.Controls.Add(this.edtParceiro);
			this.pnlEdicao.Controls.Add(this.lblParceiro);
			this.pnlEdicao.Controls.Add(this.gbxFoto);
			this.pnlEdicao.Controls.Add(this.gbxPendencia);
			this.pnlEdicao.Controls.Add(this.edtMedida);
			this.pnlEdicao.Controls.Add(this.lblMedida);
			this.pnlEdicao.Controls.Add(this.edtSubCodigo);
			this.pnlEdicao.Controls.Add(this.lblSubCodigo);
			this.pnlEdicao.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.pnlEdicao.Size = new System.Drawing.Size(955, 336);
			this.pnlEdicao.Controls.SetChildIndex(this.btnConfirma, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.btnCancela, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblCodigo, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblDescricao, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtCodigo, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtDescricao, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblSubCodigo, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtSubCodigo, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblMedida, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtMedida, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.gbxPendencia, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.gbxFoto, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblParceiro, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtParceiro, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.btnParceiros, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.label1, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtIPI, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.chkGenerico, 0);
			// 
			// btnFecha
			// 
			this.btnFecha.Location = new System.Drawing.Point(819, 160);
			this.btnFecha.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.btnFecha.Click += new System.EventHandler(this.BtnFechaClick);
			// 
			// btnAltera
			// 
			this.btnAltera.Location = new System.Drawing.Point(819, 123);
			this.btnAltera.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.btnAltera.Click += new System.EventHandler(this.BtnAlteraClick);
			// 
			// btnExclui
			// 
			this.btnExclui.Location = new System.Drawing.Point(819, 86);
			this.btnExclui.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.btnExclui.Click += new System.EventHandler(this.BtnExcluiClick);
			// 
			// btnInclui
			// 
			this.btnInclui.Location = new System.Drawing.Point(819, 49);
			this.btnInclui.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.btnInclui.Click += new System.EventHandler(this.BtnIncluiClick);
			// 
			// lblSubCodigo
			// 
			this.lblSubCodigo.ForeColor = System.Drawing.Color.Red;
			this.lblSubCodigo.Location = new System.Drawing.Point(304, 48);
			this.lblSubCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblSubCodigo.Name = "lblSubCodigo";
			this.lblSubCodigo.Size = new System.Drawing.Size(93, 25);
			this.lblSubCodigo.TabIndex = 65;
			this.lblSubCodigo.Text = "Sub-Código";
			this.lblSubCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtSubCodigo
			// 
			this.edtSubCodigo.BackColor = System.Drawing.SystemColors.Info;
			this.edtSubCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtSubCodigo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtSubCodigo.Location = new System.Drawing.Point(405, 48);
			this.edtSubCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.edtSubCodigo.MaxLength = 5;
			this.edtSubCodigo.Name = "edtSubCodigo";
			this.edtSubCodigo.Size = new System.Drawing.Size(53, 23);
			this.edtSubCodigo.TabIndex = 5;
			// 
			// lblMedida
			// 
			this.lblMedida.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblMedida.Location = new System.Drawing.Point(13, 123);
			this.lblMedida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblMedida.Name = "lblMedida";
			this.lblMedida.Size = new System.Drawing.Size(80, 25);
			this.lblMedida.TabIndex = 67;
			this.lblMedida.Text = "Medidas";
			this.lblMedida.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtMedida
			// 
			this.edtMedida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtMedida.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtMedida.Location = new System.Drawing.Point(100, 123);
			this.edtMedida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.edtMedida.MaxLength = 20;
			this.edtMedida.Name = "edtMedida";
			this.edtMedida.Size = new System.Drawing.Size(193, 23);
			this.edtMedida.TabIndex = 7;
			// 
			// gbxPendencia
			// 
			this.gbxPendencia.Controls.Add(this.edtTexto);
			this.gbxPendencia.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.gbxPendencia.Location = new System.Drawing.Point(13, 192);
			this.gbxPendencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.gbxPendencia.Name = "gbxPendencia";
			this.gbxPendencia.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.gbxPendencia.Size = new System.Drawing.Size(600, 126);
			this.gbxPendencia.TabIndex = 9;
			this.gbxPendencia.TabStop = false;
			this.gbxPendencia.Text = "Descrição Detalhada";
			// 
			// edtTexto
			// 
			this.edtTexto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtTexto.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtTexto.Location = new System.Drawing.Point(19, 21);
			this.edtTexto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.edtTexto.Multiline = true;
			this.edtTexto.Name = "edtTexto";
			this.edtTexto.Size = new System.Drawing.Size(567, 98);
			this.edtTexto.TabIndex = 10;
			this.edtTexto.DoubleClick += new System.EventHandler(this.EdtTextoDoubleClick);
			// 
			// gbxFoto
			// 
			this.gbxFoto.Controls.Add(this.imgProduto);
			this.gbxFoto.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.gbxFoto.Location = new System.Drawing.Point(640, 12);
			this.gbxFoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.gbxFoto.Name = "gbxFoto";
			this.gbxFoto.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.gbxFoto.Size = new System.Drawing.Size(296, 212);
			this.gbxFoto.TabIndex = 10;
			this.gbxFoto.TabStop = false;
			this.gbxFoto.Text = "Foto";
			// 
			// imgProduto
			// 
			this.imgProduto.Enabled = false;
			this.imgProduto.Location = new System.Drawing.Point(13, 18);
			this.imgProduto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.imgProduto.Name = "imgProduto";
			this.imgProduto.Size = new System.Drawing.Size(269, 186);
			this.imgProduto.TabIndex = 0;
			this.imgProduto.TabStop = false;
			this.imgProduto.Paint += new System.Windows.Forms.PaintEventHandler(this.ImgProdutoPaint);
			// 
			// btnParceiros
			// 
			this.btnParceiros.Image = ((System.Drawing.Image)(resources.GetObject("btnParceiros.Image")));
			this.btnParceiros.Location = new System.Drawing.Point(319, 11);
			this.btnParceiros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnParceiros.Name = "btnParceiros";
			this.btnParceiros.Size = new System.Drawing.Size(48, 28);
			this.btnParceiros.TabIndex = 3;
			this.btnParceiros.UseVisualStyleBackColor = true;
			this.btnParceiros.Click += new System.EventHandler(this.BtnParceirosClick);
			// 
			// edtParceiro
			// 
			this.edtParceiro.BackColor = System.Drawing.SystemColors.Info;
			this.edtParceiro.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtParceiro.Location = new System.Drawing.Point(100, 12);
			this.edtParceiro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.edtParceiro.MaxLength = 50;
			this.edtParceiro.Name = "edtParceiro";
			this.edtParceiro.Size = new System.Drawing.Size(193, 23);
			this.edtParceiro.TabIndex = 2;
			// 
			// lblParceiro
			// 
			this.lblParceiro.ForeColor = System.Drawing.Color.Red;
			this.lblParceiro.Location = new System.Drawing.Point(13, 12);
			this.lblParceiro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblParceiro.Name = "lblParceiro";
			this.lblParceiro.Size = new System.Drawing.Size(80, 25);
			this.lblParceiro.TabIndex = 73;
			this.lblParceiro.Text = "Parceiro";
			this.lblParceiro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtIPI
			// 
			this.edtIPI.BackColor = System.Drawing.SystemColors.Window;
			this.edtIPI.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtIPI.Location = new System.Drawing.Point(520, 123);
			this.edtIPI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.edtIPI.MaxLength = 50;
			this.edtIPI.Name = "edtIPI";
			this.edtIPI.Size = new System.Drawing.Size(53, 23);
			this.edtIPI.TabIndex = 8;
			this.edtIPI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.edtIPI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EdtIPIKeyPress);
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(380, 123);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(133, 25);
			this.label1.TabIndex = 80;
			this.label1.Text = "% IPI";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// chkGenerico
			// 
			this.chkGenerico.Location = new System.Drawing.Point(100, 155);
			this.chkGenerico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.chkGenerico.Name = "chkGenerico";
			this.chkGenerico.Size = new System.Drawing.Size(139, 30);
			this.chkGenerico.TabIndex = 9;
			this.chkGenerico.Text = "Especial";
			this.chkGenerico.UseVisualStyleBackColor = true;
			// 
			// frmCadProdutos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(988, 590);
			this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.Name = "frmCadProdutos";
			this.Text = "Cadastros Básicos - Produtos";
			this.Load += new System.EventHandler(this.FrmCadProdutosLoad);
			this.pnlEdicao.ResumeLayout(false);
			this.pnlEdicao.PerformLayout();
			this.gbxPendencia.ResumeLayout(false);
			this.gbxPendencia.PerformLayout();
			this.gbxFoto.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.imgProduto)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		public System.Windows.Forms.CheckBox chkGenerico;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox edtIPI;
		private System.Windows.Forms.Label lblParceiro;
		private System.Windows.Forms.TextBox edtParceiro;
		private System.Windows.Forms.Button btnParceiros;
		private System.Windows.Forms.TextBox edtTexto;
		private System.Windows.Forms.TextBox edtMedida;
		private System.Windows.Forms.GroupBox gbxPendencia;
		private System.Windows.Forms.PictureBox imgProduto;
		private System.Windows.Forms.GroupBox gbxFoto;
		private System.Windows.Forms.Label lblMedida;
		private System.Windows.Forms.Label lblSubCodigo;
		public System.Windows.Forms.TextBox edtSubCodigo;
	}
}
