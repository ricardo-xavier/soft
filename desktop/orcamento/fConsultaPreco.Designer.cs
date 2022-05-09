/*
 * Criado por SharpDevelop.
 * Usuário: Ricardo
 * Data: 25/10/2008
 * Hora: 9:10
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace orcamento
{
	partial class fConsultaPreco
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fConsultaPreco));
			this.btnPesquisaRapida = new System.Windows.Forms.Button();
			this.edtSubCodigo = new System.Windows.Forms.TextBox();
			this.edtProduto = new System.Windows.Forms.TextBox();
			this.lblProduto = new System.Windows.Forms.Label();
			this.btnCalculo = new System.Windows.Forms.Button();
			this.edtPrecoTotal = new System.Windows.Forms.TextBox();
			this.edtPrecoFormula = new System.Windows.Forms.TextBox();
			this.lblPrecoVenda = new System.Windows.Forms.Label();
			this.lblPrecoTabela = new System.Windows.Forms.Label();
			this.edtQtde = new System.Windows.Forms.TextBox();
			this.lblQtde = new System.Windows.Forms.Label();
			this.btnFornecedor = new System.Windows.Forms.Button();
			this.edtFornecedor = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnFecha = new System.Windows.Forms.Button();
			this.cbxTabelas = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cbxCaracteristicas = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.gbxFoto = new System.Windows.Forms.GroupBox();
			this.imgProduto = new System.Windows.Forms.PictureBox();
			this.dgvFormula = new System.Windows.Forms.DataGridView();
			this.edtLimiar = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnQrcode = new System.Windows.Forms.Button();
			this.gbxFoto.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgProduto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvFormula)).BeginInit();
			this.SuspendLayout();
			// 
			// btnPesquisaRapida
			// 
			this.btnPesquisaRapida.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisaRapida.Image")));
			this.btnPesquisaRapida.Location = new System.Drawing.Point(323, 99);
			this.btnPesquisaRapida.Name = "btnPesquisaRapida";
			this.btnPesquisaRapida.Size = new System.Drawing.Size(36, 23);
			this.btnPesquisaRapida.TabIndex = 6;
			this.btnPesquisaRapida.UseVisualStyleBackColor = true;
			this.btnPesquisaRapida.Click += new System.EventHandler(this.BtnPesquisaRapidaClick);
			// 
			// edtSubCodigo
			// 
			this.edtSubCodigo.BackColor = System.Drawing.SystemColors.Window;
			this.edtSubCodigo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtSubCodigo.Location = new System.Drawing.Point(276, 100);
			this.edtSubCodigo.MaxLength = 5;
			this.edtSubCodigo.Name = "edtSubCodigo";
			this.edtSubCodigo.ReadOnly = true;
			this.edtSubCodigo.Size = new System.Drawing.Size(41, 20);
			this.edtSubCodigo.TabIndex = 5;
			this.edtSubCodigo.TextChanged += new System.EventHandler(this.EdtSubCodigoTextChanged);
			// 
			// edtProduto
			// 
			this.edtProduto.BackColor = System.Drawing.SystemColors.Window;
			this.edtProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtProduto.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtProduto.Location = new System.Drawing.Point(124, 100);
			this.edtProduto.MaxLength = 20;
			this.edtProduto.Name = "edtProduto";
			this.edtProduto.ReadOnly = true;
			this.edtProduto.Size = new System.Drawing.Size(146, 20);
			this.edtProduto.TabIndex = 4;
			this.edtProduto.TextChanged += new System.EventHandler(this.EdtProdutoTextChanged);
			// 
			// lblProduto
			// 
			this.lblProduto.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblProduto.Location = new System.Drawing.Point(19, 100);
			this.lblProduto.Name = "lblProduto";
			this.lblProduto.Size = new System.Drawing.Size(100, 20);
			this.lblProduto.TabIndex = 81;
			this.lblProduto.Text = "Produto";
			this.lblProduto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnCalculo
			// 
			this.btnCalculo.Image = ((System.Drawing.Image)(resources.GetObject("btnCalculo.Image")));
			this.btnCalculo.Location = new System.Drawing.Point(241, 160);
			this.btnCalculo.Name = "btnCalculo";
			this.btnCalculo.Size = new System.Drawing.Size(36, 23);
			this.btnCalculo.TabIndex = 9;
			this.btnCalculo.UseVisualStyleBackColor = true;
			this.btnCalculo.MouseEnter += new System.EventHandler(this.BtnCalculoMouseEnter);
			this.btnCalculo.MouseLeave += new System.EventHandler(this.BtnCalculoMouseLeave);
			// 
			// edtPrecoTotal
			// 
			this.edtPrecoTotal.BackColor = System.Drawing.SystemColors.Info;
			this.edtPrecoTotal.Enabled = false;
			this.edtPrecoTotal.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtPrecoTotal.Location = new System.Drawing.Point(124, 190);
			this.edtPrecoTotal.MaxLength = 20;
			this.edtPrecoTotal.Name = "edtPrecoTotal";
			this.edtPrecoTotal.Size = new System.Drawing.Size(111, 20);
			this.edtPrecoTotal.TabIndex = 10;
			this.edtPrecoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// edtPrecoFormula
			// 
			this.edtPrecoFormula.BackColor = System.Drawing.SystemColors.Info;
			this.edtPrecoFormula.Enabled = false;
			this.edtPrecoFormula.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtPrecoFormula.Location = new System.Drawing.Point(124, 160);
			this.edtPrecoFormula.MaxLength = 20;
			this.edtPrecoFormula.Name = "edtPrecoFormula";
			this.edtPrecoFormula.Size = new System.Drawing.Size(111, 20);
			this.edtPrecoFormula.TabIndex = 8;
			this.edtPrecoFormula.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lblPrecoVenda
			// 
			this.lblPrecoVenda.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblPrecoVenda.Location = new System.Drawing.Point(19, 190);
			this.lblPrecoVenda.Name = "lblPrecoVenda";
			this.lblPrecoVenda.Size = new System.Drawing.Size(100, 20);
			this.lblPrecoVenda.TabIndex = 95;
			this.lblPrecoVenda.Text = "Preço Total";
			this.lblPrecoVenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblPrecoTabela
			// 
			this.lblPrecoTabela.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblPrecoTabela.Location = new System.Drawing.Point(19, 160);
			this.lblPrecoTabela.Name = "lblPrecoTabela";
			this.lblPrecoTabela.Size = new System.Drawing.Size(100, 20);
			this.lblPrecoTabela.TabIndex = 94;
			this.lblPrecoTabela.Text = "Preço Unitário";
			this.lblPrecoTabela.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtQtde
			// 
			this.edtQtde.BackColor = System.Drawing.SystemColors.Window;
			this.edtQtde.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtQtde.Location = new System.Drawing.Point(124, 130);
			this.edtQtde.MaxLength = 4;
			this.edtQtde.Name = "edtQtde";
			this.edtQtde.Size = new System.Drawing.Size(34, 20);
			this.edtQtde.TabIndex = 7;
			this.edtQtde.Text = "1";
			this.edtQtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.edtQtde.TextChanged += new System.EventHandler(this.EdtQtdeTextChanged);
			// 
			// lblQtde
			// 
			this.lblQtde.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblQtde.Location = new System.Drawing.Point(19, 130);
			this.lblQtde.Name = "lblQtde";
			this.lblQtde.Size = new System.Drawing.Size(100, 20);
			this.lblQtde.TabIndex = 93;
			this.lblQtde.Text = "Quantidade";
			this.lblQtde.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnFornecedor
			// 
			this.btnFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("btnFornecedor.Image")));
			this.btnFornecedor.Location = new System.Drawing.Point(284, 9);
			this.btnFornecedor.Name = "btnFornecedor";
			this.btnFornecedor.Size = new System.Drawing.Size(36, 23);
			this.btnFornecedor.TabIndex = 1;
			this.btnFornecedor.UseVisualStyleBackColor = true;
			this.btnFornecedor.Click += new System.EventHandler(this.BtnFornecedorClick);
			// 
			// edtFornecedor
			// 
			this.edtFornecedor.BackColor = System.Drawing.SystemColors.Control;
			this.edtFornecedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtFornecedor.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtFornecedor.Location = new System.Drawing.Point(124, 10);
			this.edtFornecedor.MaxLength = 50;
			this.edtFornecedor.Name = "edtFornecedor";
			this.edtFornecedor.Size = new System.Drawing.Size(146, 20);
			this.edtFornecedor.TabIndex = 0;
			this.edtFornecedor.TextChanged += new System.EventHandler(this.EdtFornecedorTextChanged);
			this.edtFornecedor.Leave += new System.EventHandler(this.EdtFornecedorLeave);
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(34, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 20);
			this.label1.TabIndex = 99;
			this.label1.Text = "Fornecedor";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnFecha
			// 
			this.btnFecha.Location = new System.Drawing.Point(241, 283);
			this.btnFecha.Name = "btnFecha";
			this.btnFecha.Size = new System.Drawing.Size(100, 25);
			this.btnFecha.TabIndex = 11;
			this.btnFecha.Text = "&Fecha";
			this.btnFecha.UseVisualStyleBackColor = true;
			this.btnFecha.Click += new System.EventHandler(this.BtnFechaClick);
			// 
			// cbxTabelas
			// 
			this.cbxTabelas.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxTabelas.FormattingEnabled = true;
			this.cbxTabelas.Location = new System.Drawing.Point(124, 40);
			this.cbxTabelas.Name = "cbxTabelas";
			this.cbxTabelas.Size = new System.Drawing.Size(166, 22);
			this.cbxTabelas.TabIndex = 2;
			this.cbxTabelas.SelectedIndexChanged += new System.EventHandler(this.CbxTabelasSelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label2.Location = new System.Drawing.Point(34, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 20);
			this.label2.TabIndex = 111;
			this.label2.Text = "Tabela Preços";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxCaracteristicas
			// 
			this.cbxCaracteristicas.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxCaracteristicas.FormattingEnabled = true;
			this.cbxCaracteristicas.Location = new System.Drawing.Point(124, 70);
			this.cbxCaracteristicas.Name = "cbxCaracteristicas";
			this.cbxCaracteristicas.Size = new System.Drawing.Size(166, 22);
			this.cbxCaracteristicas.TabIndex = 3;
			this.cbxCaracteristicas.SelectedIndexChanged += new System.EventHandler(this.CbxCaracteristicasSelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label6.Location = new System.Drawing.Point(4, 70);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(110, 20);
			this.label6.TabIndex = 110;
			this.label6.Text = "Característica Venda";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// gbxFoto
			// 
			this.gbxFoto.Controls.Add(this.imgProduto);
			this.gbxFoto.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.gbxFoto.Location = new System.Drawing.Point(360, 100);
			this.gbxFoto.Name = "gbxFoto";
			this.gbxFoto.Size = new System.Drawing.Size(222, 172);
			this.gbxFoto.TabIndex = 112;
			this.gbxFoto.TabStop = false;
			this.gbxFoto.Text = "Foto";
			// 
			// imgProduto
			// 
			this.imgProduto.Enabled = false;
			this.imgProduto.Location = new System.Drawing.Point(10, 15);
			this.imgProduto.Name = "imgProduto";
			this.imgProduto.Size = new System.Drawing.Size(202, 151);
			this.imgProduto.TabIndex = 0;
			this.imgProduto.TabStop = false;
			this.imgProduto.Paint += new System.Windows.Forms.PaintEventHandler(this.ImgProdutoPaint);
			// 
			// dgvFormula
			// 
			this.dgvFormula.AllowUserToAddRows = false;
			this.dgvFormula.AllowUserToDeleteRows = false;
			this.dgvFormula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvFormula.ColumnHeadersVisible = false;
			this.dgvFormula.Location = new System.Drawing.Point(283, 92);
			this.dgvFormula.Name = "dgvFormula";
			this.dgvFormula.RowHeadersVisible = false;
			this.dgvFormula.Size = new System.Drawing.Size(204, 216);
			this.dgvFormula.TabIndex = 114;
			this.dgvFormula.Visible = false;
			// 
			// edtLimiar
			// 
			this.edtLimiar.BackColor = System.Drawing.SystemColors.Info;
			this.edtLimiar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtLimiar.Enabled = false;
			this.edtLimiar.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtLimiar.Location = new System.Drawing.Point(124, 220);
			this.edtLimiar.MaxLength = 20;
			this.edtLimiar.Name = "edtLimiar";
			this.edtLimiar.ReadOnly = true;
			this.edtLimiar.Size = new System.Drawing.Size(62, 20);
			this.edtLimiar.TabIndex = 113;
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label3.Location = new System.Drawing.Point(60, 220);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 20);
			this.label3.TabIndex = 114;
			this.label3.Text = "Limiar";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnQrcode
			// 
			this.btnQrcode.Image = ((System.Drawing.Image)(resources.GetObject("btnQrcode.Image")));
			this.btnQrcode.Location = new System.Drawing.Point(241, 189);
			this.btnQrcode.Name = "btnQrcode";
			this.btnQrcode.Size = new System.Drawing.Size(36, 23);
			this.btnQrcode.TabIndex = 116;
			this.btnQrcode.UseVisualStyleBackColor = true;
			this.btnQrcode.Click += new System.EventHandler(this.BtnQrcodeClick);
			// 
			// fConsultaPreco
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(593, 315);
			this.Controls.Add(this.btnQrcode);
			this.Controls.Add(this.dgvFormula);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.edtLimiar);
			this.Controls.Add(this.gbxFoto);
			this.Controls.Add(this.cbxTabelas);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cbxCaracteristicas);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnFecha);
			this.Controls.Add(this.btnFornecedor);
			this.Controls.Add(this.edtFornecedor);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCalculo);
			this.Controls.Add(this.edtPrecoTotal);
			this.Controls.Add(this.edtPrecoFormula);
			this.Controls.Add(this.lblPrecoVenda);
			this.Controls.Add(this.lblPrecoTabela);
			this.Controls.Add(this.edtQtde);
			this.Controls.Add(this.lblQtde);
			this.Controls.Add(this.btnPesquisaRapida);
			this.Controls.Add(this.edtSubCodigo);
			this.Controls.Add(this.edtProduto);
			this.Controls.Add(this.lblProduto);
			this.Name = "fConsultaPreco";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Consulta de Preços";
			this.gbxFoto.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.imgProduto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvFormula)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox edtLimiar;
		private System.Windows.Forms.PictureBox imgProduto;
		private System.Windows.Forms.GroupBox gbxFoto;
		private System.Windows.Forms.Label label6;
		public System.Windows.Forms.ComboBox cbxCaracteristicas;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.ComboBox cbxTabelas;
		public System.Windows.Forms.Button btnFecha;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.TextBox edtFornecedor;
		private System.Windows.Forms.Button btnFornecedor;
		private System.Windows.Forms.DataGridView dgvFormula;
		private System.Windows.Forms.Label lblQtde;
		private System.Windows.Forms.TextBox edtQtde;
		private System.Windows.Forms.Label lblPrecoTabela;
		private System.Windows.Forms.Label lblPrecoVenda;
		private System.Windows.Forms.TextBox edtPrecoFormula;
		private System.Windows.Forms.TextBox edtPrecoTotal;
		private System.Windows.Forms.Button btnCalculo;
		private System.Windows.Forms.Label lblProduto;
		private System.Windows.Forms.TextBox edtProduto;
		private System.Windows.Forms.TextBox edtSubCodigo;
		private System.Windows.Forms.Button btnPesquisaRapida;
		private System.Windows.Forms.Button btnQrcode;
	}
}
