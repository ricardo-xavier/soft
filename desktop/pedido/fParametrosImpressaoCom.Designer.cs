/*
 * Criado por SharpDevelop.
 * Usuário: Ricardo
 * Data: 09/09/2009
 * Hora: 21:44
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace pedido
{
	partial class fParametrosImpressaoCom
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
			this.rbtFilial = new System.Windows.Forms.RadioButton();
			this.rbtConsultor = new System.Windows.Forms.RadioButton();
			this.chkPago = new System.Windows.Forms.CheckBox();
			this.chkPagar = new System.Windows.Forms.CheckBox();
			this.edtTitulo = new System.Windows.Forms.TextBox();
			this.lblItem = new System.Windows.Forms.Label();
			this.rbtVendedor = new System.Windows.Forms.RadioButton();
			this.chkJustificativas = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(340, 148);
			this.btnCancela.Name = "btnCancela";
			this.btnCancela.Size = new System.Drawing.Size(100, 25);
			this.btnCancela.TabIndex = 10;
			this.btnCancela.Text = "C&ancela";
			this.btnCancela.UseVisualStyleBackColor = true;
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(234, 148);
			this.btnConfirma.Name = "btnConfirma";
			this.btnConfirma.Size = new System.Drawing.Size(100, 25);
			this.btnConfirma.TabIndex = 8;
			this.btnConfirma.Text = "&Confirma";
			this.btnConfirma.UseVisualStyleBackColor = true;
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// rbtFilial
			// 
			this.rbtFilial.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.rbtFilial.Location = new System.Drawing.Point(219, 12);
			this.rbtFilial.Name = "rbtFilial";
			this.rbtFilial.Size = new System.Drawing.Size(104, 24);
			this.rbtFilial.TabIndex = 28;
			this.rbtFilial.Text = "Por Filial";
			this.rbtFilial.UseVisualStyleBackColor = true;
			this.rbtFilial.Visible = false;
			// 
			// rbtConsultor
			// 
			this.rbtConsultor.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.rbtConsultor.Location = new System.Drawing.Point(121, 12);
			this.rbtConsultor.Name = "rbtConsultor";
			this.rbtConsultor.Size = new System.Drawing.Size(104, 24);
			this.rbtConsultor.TabIndex = 27;
			this.rbtConsultor.Text = "Por Consultor";
			this.rbtConsultor.UseVisualStyleBackColor = true;
			this.rbtConsultor.Visible = false;
			// 
			// chkPago
			// 
			this.chkPago.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.chkPago.Checked = true;
			this.chkPago.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkPago.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkPago.Location = new System.Drawing.Point(45, 42);
			this.chkPago.Name = "chkPago";
			this.chkPago.Size = new System.Drawing.Size(55, 20);
			this.chkPago.TabIndex = 2;
			this.chkPago.Text = "Pago";
			this.chkPago.UseVisualStyleBackColor = true;
			// 
			// chkPagar
			// 
			this.chkPagar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.chkPagar.Checked = true;
			this.chkPagar.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkPagar.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkPagar.Location = new System.Drawing.Point(33, 68);
			this.chkPagar.Name = "chkPagar";
			this.chkPagar.Size = new System.Drawing.Size(67, 20);
			this.chkPagar.TabIndex = 4;
			this.chkPagar.Text = "A Pagar";
			this.chkPagar.UseVisualStyleBackColor = true;
			// 
			// edtTitulo
			// 
			this.edtTitulo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtTitulo.Location = new System.Drawing.Point(84, 94);
			this.edtTitulo.MaxLength = 50;
			this.edtTitulo.Name = "edtTitulo";
			this.edtTitulo.Size = new System.Drawing.Size(356, 20);
			this.edtTitulo.TabIndex = 6;
			// 
			// lblItem
			// 
			this.lblItem.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblItem.Location = new System.Drawing.Point(0, 93);
			this.lblItem.Name = "lblItem";
			this.lblItem.Size = new System.Drawing.Size(80, 20);
			this.lblItem.TabIndex = 126;
			this.lblItem.Text = "Título";
			this.lblItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// rbtVendedor
			// 
			this.rbtVendedor.Checked = true;
			this.rbtVendedor.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.rbtVendedor.Location = new System.Drawing.Point(20, 12);
			this.rbtVendedor.Name = "rbtVendedor";
			this.rbtVendedor.Size = new System.Drawing.Size(104, 24);
			this.rbtVendedor.TabIndex = 26;
			this.rbtVendedor.TabStop = true;
			this.rbtVendedor.Text = "Por Vendedor";
			this.rbtVendedor.UseVisualStyleBackColor = true;
			this.rbtVendedor.Visible = false;
			// 
			// chkJustificativas
			// 
			this.chkJustificativas.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.chkJustificativas.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkJustificativas.Location = new System.Drawing.Point(84, 120);
			this.chkJustificativas.Name = "chkJustificativas";
			this.chkJustificativas.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.chkJustificativas.Size = new System.Drawing.Size(131, 20);
			this.chkJustificativas.TabIndex = 127;
			this.chkJustificativas.Text = "Imprimir Justificativas";
			this.chkJustificativas.UseVisualStyleBackColor = true;
			// 
			// fParametrosImpressaoCom
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(452, 179);
			this.Controls.Add(this.chkJustificativas);
			this.Controls.Add(this.edtTitulo);
			this.Controls.Add(this.lblItem);
			this.Controls.Add(this.chkPagar);
			this.Controls.Add(this.chkPago);
			this.Controls.Add(this.rbtFilial);
			this.Controls.Add(this.rbtConsultor);
			this.Controls.Add(this.rbtVendedor);
			this.Controls.Add(this.btnCancela);
			this.Controls.Add(this.btnConfirma);
			this.Name = "fParametrosImpressaoCom";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Parâmetros para Impressão de Comissão";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.CheckBox chkJustificativas;
		public System.Windows.Forms.Label lblItem;
		public System.Windows.Forms.TextBox edtTitulo;
		private System.Windows.Forms.CheckBox chkPago;
		private System.Windows.Forms.CheckBox chkPagar;
		public System.Windows.Forms.RadioButton rbtVendedor;
		public System.Windows.Forms.RadioButton rbtConsultor;
		public System.Windows.Forms.RadioButton rbtFilial;
		public System.Windows.Forms.Button btnConfirma;
		public System.Windows.Forms.Button btnCancela;
	}
}
