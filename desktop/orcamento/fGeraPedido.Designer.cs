/*
 * Criado por SharpDevelop.
 * Usuário: Ricardo
 * Data: 19/10/2008
 * Hora: 8:48
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
 using System;
namespace orcamento
{
	partial class fGeraPedido
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGeraPedido));
			this.btnCancela = new System.Windows.Forms.Button();
			this.btnConfirma = new System.Windows.Forms.Button();
			this.edtProdutos = new System.Windows.Forms.TextBox();
			this.edtServicos = new System.Windows.Forms.TextBox();
			this.lblRegistros = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.dtpEntrega = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.dtpMontagem = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.cbxCondicoesPagto = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.edtTransportadora = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.btnTransportadora = new System.Windows.Forms.Button();
			this.edtSinal = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.grpFrete = new System.Windows.Forms.GroupBox();
			this.rbtFornecedor = new System.Windows.Forms.RadioButton();
			this.rbtCliente = new System.Windows.Forms.RadioButton();
			this.grpFrete.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(218, 236);
			this.btnCancela.Name = "btnCancela";
			this.btnCancela.Size = new System.Drawing.Size(100, 25);
			this.btnCancela.TabIndex = 18;
			this.btnCancela.Text = "C&ancela";
			this.btnCancela.UseVisualStyleBackColor = true;
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(112, 236);
			this.btnConfirma.Name = "btnConfirma";
			this.btnConfirma.Size = new System.Drawing.Size(100, 25);
			this.btnConfirma.TabIndex = 16;
			this.btnConfirma.Text = "&Confirma";
			this.btnConfirma.UseVisualStyleBackColor = true;
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// edtProdutos
			// 
			this.edtProdutos.BackColor = System.Drawing.SystemColors.Info;
			this.edtProdutos.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtProdutos.Location = new System.Drawing.Point(95, 10);
			this.edtProdutos.Name = "edtProdutos";
			this.edtProdutos.ReadOnly = true;
			this.edtProdutos.Size = new System.Drawing.Size(115, 20);
			this.edtProdutos.TabIndex = 0;
			this.edtProdutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// edtServicos
			// 
			this.edtServicos.BackColor = System.Drawing.SystemColors.Info;
			this.edtServicos.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtServicos.Location = new System.Drawing.Point(95, 40);
			this.edtServicos.Name = "edtServicos";
			this.edtServicos.ReadOnly = true;
			this.edtServicos.Size = new System.Drawing.Size(115, 20);
			this.edtServicos.TabIndex = 2;
			this.edtServicos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lblRegistros
			// 
			this.lblRegistros.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblRegistros.Location = new System.Drawing.Point(20, 40);
			this.lblRegistros.Name = "lblRegistros";
			this.lblRegistros.Size = new System.Drawing.Size(70, 20);
			this.lblRegistros.TabIndex = 74;
			this.lblRegistros.Text = "Serviços";
			this.lblRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblTotal
			// 
			this.lblTotal.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblTotal.Location = new System.Drawing.Point(20, 10);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(70, 20);
			this.lblTotal.TabIndex = 73;
			this.lblTotal.Text = "Produtos";
			this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpEntrega
			// 
			this.dtpEntrega.CustomFormat = "dd/MM/yyyy";
			this.dtpEntrega.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpEntrega.Location = new System.Drawing.Point(95, 70);
			this.dtpEntrega.Name = "dtpEntrega";
			this.dtpEntrega.ShowCheckBox = true;
			this.dtpEntrega.Size = new System.Drawing.Size(110, 20);
			this.dtpEntrega.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label3.Location = new System.Drawing.Point(20, 70);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 20);
			this.label3.TabIndex = 125;
			this.label3.Text = "Entrega";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpMontagem
			// 
			this.dtpMontagem.CustomFormat = "dd/MM/yyyy";
			this.dtpMontagem.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpMontagem.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpMontagem.Location = new System.Drawing.Point(95, 100);
			this.dtpMontagem.Name = "dtpMontagem";
			this.dtpMontagem.ShowCheckBox = true;
			this.dtpMontagem.Size = new System.Drawing.Size(110, 20);
			this.dtpMontagem.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(20, 100);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 20);
			this.label1.TabIndex = 127;
			this.label1.Text = "Montagem";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxCondicoesPagto
			// 
			this.cbxCondicoesPagto.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxCondicoesPagto.FormattingEnabled = true;
			this.cbxCondicoesPagto.Location = new System.Drawing.Point(95, 130);
			this.cbxCondicoesPagto.Name = "cbxCondicoesPagto";
			this.cbxCondicoesPagto.Size = new System.Drawing.Size(220, 22);
			this.cbxCondicoesPagto.TabIndex = 8;
			// 
			// label10
			// 
			this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label10.Location = new System.Drawing.Point(0, 130);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(90, 20);
			this.label10.TabIndex = 137;
			this.label10.Text = "Condição Pagto";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtTransportadora
			// 
			this.edtTransportadora.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtTransportadora.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtTransportadora.Location = new System.Drawing.Point(95, 160);
			this.edtTransportadora.MaxLength = 50;
			this.edtTransportadora.Name = "edtTransportadora";
			this.edtTransportadora.ReadOnly = true;
			this.edtTransportadora.Size = new System.Drawing.Size(146, 20);
			this.edtTransportadora.TabIndex = 10;
			// 
			// label11
			// 
			this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label11.Location = new System.Drawing.Point(10, 160);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(80, 20);
			this.label11.TabIndex = 141;
			this.label11.Text = "Transportadora";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnTransportadora
			// 
			this.btnTransportadora.Image = ((System.Drawing.Image)(resources.GetObject("btnTransportadora.Image")));
			this.btnTransportadora.Location = new System.Drawing.Point(255, 159);
			this.btnTransportadora.Name = "btnTransportadora";
			this.btnTransportadora.Size = new System.Drawing.Size(36, 23);
			this.btnTransportadora.TabIndex = 12;
			this.btnTransportadora.UseVisualStyleBackColor = true;
			this.btnTransportadora.Click += new System.EventHandler(this.BtnTransportadoraClick);
			// 
			// edtSinal
			// 
			this.edtSinal.BackColor = System.Drawing.SystemColors.Info;
			this.edtSinal.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtSinal.Location = new System.Drawing.Point(277, 40);
			this.edtSinal.Name = "edtSinal";
			this.edtSinal.ReadOnly = true;
			this.edtSinal.Size = new System.Drawing.Size(41, 20);
			this.edtSinal.TabIndex = 142;
			this.edtSinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label2.Location = new System.Drawing.Point(221, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 20);
			this.label2.TabIndex = 143;
			this.label2.Text = "Sinal";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// grpFrete
			// 
			this.grpFrete.Controls.Add(this.rbtFornecedor);
			this.grpFrete.Controls.Add(this.rbtCliente);
			this.grpFrete.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.grpFrete.Location = new System.Drawing.Point(20, 186);
			this.grpFrete.Name = "grpFrete";
			this.grpFrete.Size = new System.Drawing.Size(203, 35);
			this.grpFrete.TabIndex = 14;
			this.grpFrete.TabStop = false;
			this.grpFrete.Text = "Frete";
			// 
			// rbtFornecedor
			// 
			this.rbtFornecedor.Location = new System.Drawing.Point(98, 11);
			this.rbtFornecedor.Name = "rbtFornecedor";
			this.rbtFornecedor.Size = new System.Drawing.Size(99, 22);
			this.rbtFornecedor.TabIndex = 1;
			this.rbtFornecedor.Text = "Fornecedor";
			this.rbtFornecedor.UseVisualStyleBackColor = true;
			// 
			// rbtCliente
			// 
			this.rbtCliente.Checked = true;
			this.rbtCliente.Location = new System.Drawing.Point(12, 11);
			this.rbtCliente.Name = "rbtCliente";
			this.rbtCliente.Size = new System.Drawing.Size(80, 22);
			this.rbtCliente.TabIndex = 0;
			this.rbtCliente.TabStop = true;
			this.rbtCliente.Text = "Cliente";
			this.rbtCliente.UseVisualStyleBackColor = true;
			// 
			// fGeraPedido
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(324, 273);
			this.Controls.Add(this.grpFrete);
			this.Controls.Add(this.edtSinal);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnTransportadora);
			this.Controls.Add(this.edtTransportadora);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.cbxCondicoesPagto);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.dtpMontagem);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dtpEntrega);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.edtProdutos);
			this.Controls.Add(this.edtServicos);
			this.Controls.Add(this.lblRegistros);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.btnCancela);
			this.Controls.Add(this.btnConfirma);
			this.Name = "fGeraPedido";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Gera Pedido";
			this.Load += new System.EventHandler(this.FGeraPedidoLoad);
			this.grpFrete.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.GroupBox grpFrete;
		private System.Windows.Forms.RadioButton rbtCliente;
		public System.Windows.Forms.RadioButton rbtFornecedor;
		private System.Windows.Forms.TextBox edtSinal;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.DateTimePicker dtpMontagem;
		public System.Windows.Forms.DateTimePicker dtpEntrega;
		private System.Windows.Forms.TextBox edtServicos;
		private System.Windows.Forms.TextBox edtProdutos;
		private System.Windows.Forms.Button btnTransportadora;
		private System.Windows.Forms.Label label11;
		public System.Windows.Forms.TextBox edtTransportadora;
		private System.Windows.Forms.Label label10;
		public System.Windows.Forms.ComboBox cbxCondicoesPagto;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Label lblRegistros;
		public System.Windows.Forms.Button btnConfirma;
		public System.Windows.Forms.Button btnCancela;
	}
}
