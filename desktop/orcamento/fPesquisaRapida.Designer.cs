/*
 * Criado por SharpDevelop.
 * Usuário: Ricardo
 * Data: 20/06/2008
 * Hora: 20:10
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace orcamento
{
	partial class fPesquisaRapida
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
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnConfirma = new System.Windows.Forms.Button();
			this.edtCodigoProduto = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblDescricaoProduto = new System.Windows.Forms.Label();
			this.edtDescricaoProduto = new System.Windows.Forms.TextBox();
			this.dgvProdutos = new System.Windows.Forms.DataGridView();
			this.btnCancela = new System.Windows.Forms.Button();
			this.edtMedidas = new System.Windows.Forms.TextBox();
			this.lblMedidas = new System.Windows.Forms.Label();
			this.edtTexto = new System.Windows.Forms.TextBox();
			this.gbxPendencia = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
			this.gbxPendencia.SuspendLayout();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
			this.label3.Location = new System.Drawing.Point(12, 343);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(389, 20);
			this.label3.TabIndex = 105;
			this.label3.Text = "Para selecionar, dê um duplo clique sobre o item marcado .";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
			this.label2.Location = new System.Drawing.Point(12, 320);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(421, 20);
			this.label2.TabIndex = 104;
			this.label2.Text = "Digite nos campos Descrição ou Código para posicionar na lista.";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(498, 315);
			this.btnConfirma.Name = "btnConfirma";
			this.btnConfirma.Size = new System.Drawing.Size(100, 25);
			this.btnConfirma.TabIndex = 103;
			this.btnConfirma.Text = "&Confirma";
			this.btnConfirma.UseVisualStyleBackColor = true;
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// edtCodigoProduto
			// 
			this.edtCodigoProduto.BackColor = System.Drawing.SystemColors.Window;
			this.edtCodigoProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtCodigoProduto.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtCodigoProduto.Location = new System.Drawing.Point(77, 37);
			this.edtCodigoProduto.MaxLength = 50;
			this.edtCodigoProduto.Name = "edtCodigoProduto";
			this.edtCodigoProduto.Size = new System.Drawing.Size(146, 20);
			this.edtCodigoProduto.TabIndex = 99;
			this.edtCodigoProduto.TextChanged += new System.EventHandler(this.EdtCodigoProdutoTextChanged);
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(2, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 20);
			this.label1.TabIndex = 102;
			this.label1.Text = "Código";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblDescricaoProduto
			// 
			this.lblDescricaoProduto.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblDescricaoProduto.Location = new System.Drawing.Point(2, 7);
			this.lblDescricaoProduto.Name = "lblDescricaoProduto";
			this.lblDescricaoProduto.Size = new System.Drawing.Size(70, 20);
			this.lblDescricaoProduto.TabIndex = 101;
			this.lblDescricaoProduto.Text = "Descrição";
			this.lblDescricaoProduto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtDescricaoProduto
			// 
			this.edtDescricaoProduto.BackColor = System.Drawing.SystemColors.Window;
			this.edtDescricaoProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtDescricaoProduto.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtDescricaoProduto.Location = new System.Drawing.Point(77, 7);
			this.edtDescricaoProduto.MaxLength = 50;
			this.edtDescricaoProduto.Name = "edtDescricaoProduto";
			this.edtDescricaoProduto.Size = new System.Drawing.Size(356, 20);
			this.edtDescricaoProduto.TabIndex = 98;
			this.edtDescricaoProduto.TextChanged += new System.EventHandler(this.EdtDescricaoProdutoTextChanged);
			// 
			// dgvProdutos
			// 
			this.dgvProdutos.AllowUserToAddRows = false;
			this.dgvProdutos.AllowUserToDeleteRows = false;
			this.dgvProdutos.AllowUserToResizeColumns = false;
			this.dgvProdutos.AllowUserToResizeRows = false;
			this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProdutos.Location = new System.Drawing.Point(12, 63);
			this.dgvProdutos.MultiSelect = false;
			this.dgvProdutos.Name = "dgvProdutos";
			this.dgvProdutos.ReadOnly = true;
			this.dgvProdutos.RowHeadersVisible = false;
			this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvProdutos.Size = new System.Drawing.Size(586, 90);
			this.dgvProdutos.TabIndex = 100;
			this.dgvProdutos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProdutosRowEnter);
			this.dgvProdutos.DoubleClick += new System.EventHandler(this.DgvProdutosDoubleClick);
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(498, 346);
			this.btnCancela.Name = "btnCancela";
			this.btnCancela.Size = new System.Drawing.Size(100, 25);
			this.btnCancela.TabIndex = 106;
			this.btnCancela.Text = "C&ancela";
			this.btnCancela.UseVisualStyleBackColor = true;
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
			// 
			// edtMedidas
			// 
			this.edtMedidas.BackColor = System.Drawing.SystemColors.Window;
			this.edtMedidas.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtMedidas.Location = new System.Drawing.Point(77, 170);
			this.edtMedidas.MaxLength = 20;
			this.edtMedidas.Name = "edtMedidas";
			this.edtMedidas.ReadOnly = true;
			this.edtMedidas.Size = new System.Drawing.Size(146, 20);
			this.edtMedidas.TabIndex = 107;
			// 
			// lblMedidas
			// 
			this.lblMedidas.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblMedidas.Location = new System.Drawing.Point(2, 170);
			this.lblMedidas.Name = "lblMedidas";
			this.lblMedidas.Size = new System.Drawing.Size(70, 20);
			this.lblMedidas.TabIndex = 108;
			this.lblMedidas.Text = "Medidas";
			this.lblMedidas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtTexto
			// 
			this.edtTexto.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtTexto.Location = new System.Drawing.Point(14, 17);
			this.edtTexto.Multiline = true;
			this.edtTexto.Name = "edtTexto";
			this.edtTexto.ReadOnly = true;
			this.edtTexto.Size = new System.Drawing.Size(426, 80);
			this.edtTexto.TabIndex = 8;
			// 
			// gbxPendencia
			// 
			this.gbxPendencia.Controls.Add(this.edtTexto);
			this.gbxPendencia.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.gbxPendencia.Location = new System.Drawing.Point(2, 200);
			this.gbxPendencia.Name = "gbxPendencia";
			this.gbxPendencia.Size = new System.Drawing.Size(450, 102);
			this.gbxPendencia.TabIndex = 109;
			this.gbxPendencia.TabStop = false;
			this.gbxPendencia.Text = "Descrição Detalhada";
			// 
			// fPesquisaRapida
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(610, 375);
			this.Controls.Add(this.gbxPendencia);
			this.Controls.Add(this.edtMedidas);
			this.Controls.Add(this.lblMedidas);
			this.Controls.Add(this.btnCancela);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnConfirma);
			this.Controls.Add(this.edtCodigoProduto);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblDescricaoProduto);
			this.Controls.Add(this.edtDescricaoProduto);
			this.Controls.Add(this.dgvProdutos);
			this.Location = new System.Drawing.Point(100, 230);
			this.Name = "fPesquisaRapida";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Sistema SOFT - Pesquisa Rápida de Produtos";
			((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
			this.gbxPendencia.ResumeLayout(false);
			this.gbxPendencia.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.GroupBox gbxPendencia;
		private System.Windows.Forms.TextBox edtTexto;
		private System.Windows.Forms.Label lblMedidas;
		private System.Windows.Forms.TextBox edtMedidas;
		public System.Windows.Forms.Button btnConfirma;
		public System.Windows.Forms.Button btnCancela;
		public System.Windows.Forms.DataGridView dgvProdutos;
		private System.Windows.Forms.TextBox edtDescricaoProduto;
		private System.Windows.Forms.Label lblDescricaoProduto;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox edtCodigoProduto;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}
