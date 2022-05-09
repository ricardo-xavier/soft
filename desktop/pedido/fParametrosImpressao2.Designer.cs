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
	partial class fParametrosImpressao2
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.rbtFabrica = new System.Windows.Forms.RadioButton();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.edtTitulo = new System.Windows.Forms.TextBox();
			this.chkDetalhes = new System.Windows.Forms.CheckBox();
			this.chkQuebraCaracteristica = new System.Windows.Forms.CheckBox();
			this.rbtListagem = new System.Windows.Forms.RadioButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lblObservacao = new System.Windows.Forms.Label();
			this.edtObservacao = new System.Windows.Forms.TextBox();
			this.chkPorFabrica = new System.Windows.Forms.CheckBox();
			this.chkPorCliente = new System.Windows.Forms.CheckBox();
			this.chkPorPedido = new System.Windows.Forms.CheckBox();
			this.chkPorItem = new System.Windows.Forms.CheckBox();
			this.chkConsolidado = new System.Windows.Forms.CheckBox();
			this.rbtPedido = new System.Windows.Forms.RadioButton();
			this.panel5 = new System.Windows.Forms.Panel();
			this.chkMostrarValores = new System.Windows.Forms.CheckBox();
			this.chkMostrarSubCodigo = new System.Windows.Forms.CheckBox();
			this.btnCancela = new System.Windows.Forms.Button();
			this.btnConfirma = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel5.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(746, 371);
			this.panel1.TabIndex = 0;
			// 
			// panel4
			// 
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel4.Controls.Add(this.rbtFabrica);
			this.panel4.Location = new System.Drawing.Point(3, 320);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(735, 37);
			this.panel4.TabIndex = 3;
			// 
			// rbtFabrica
			// 
			this.rbtFabrica.Location = new System.Drawing.Point(7, 3);
			this.rbtFabrica.Name = "rbtFabrica";
			this.rbtFabrica.Size = new System.Drawing.Size(134, 24);
			this.rbtFabrica.TabIndex = 16;
			this.rbtFabrica.TabStop = true;
			this.rbtFabrica.Text = "Pedido de Fábrica";
			this.rbtFabrica.UseVisualStyleBackColor = true;
			this.rbtFabrica.CheckedChanged += new System.EventHandler(this.RbtFabricaCheckedChanged);
			// 
			// panel3
			// 
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.label1);
			this.panel3.Controls.Add(this.edtTitulo);
			this.panel3.Controls.Add(this.chkDetalhes);
			this.panel3.Controls.Add(this.chkQuebraCaracteristica);
			this.panel3.Controls.Add(this.rbtListagem);
			this.panel3.Location = new System.Drawing.Point(3, 216);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(735, 98);
			this.panel3.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(171, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 77;
			this.label1.Text = "Título";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtTitulo
			// 
			this.edtTitulo.Location = new System.Drawing.Point(277, 64);
			this.edtTitulo.Name = "edtTitulo";
			this.edtTitulo.Size = new System.Drawing.Size(451, 20);
			this.edtTitulo.TabIndex = 76;
			// 
			// chkDetalhes
			// 
			this.chkDetalhes.Location = new System.Drawing.Point(159, 34);
			this.chkDetalhes.Name = "chkDetalhes";
			this.chkDetalhes.Size = new System.Drawing.Size(267, 24);
			this.chkDetalhes.TabIndex = 75;
			this.chkDetalhes.Text = "Detalhes de Pedidos/NFs";
			this.chkDetalhes.UseVisualStyleBackColor = true;
			// 
			// chkQuebraCaracteristica
			// 
			this.chkQuebraCaracteristica.Location = new System.Drawing.Point(159, 4);
			this.chkQuebraCaracteristica.Name = "chkQuebraCaracteristica";
			this.chkQuebraCaracteristica.Size = new System.Drawing.Size(267, 24);
			this.chkQuebraCaracteristica.TabIndex = 74;
			this.chkQuebraCaracteristica.Text = "Quebra por característica de venda";
			this.chkQuebraCaracteristica.UseVisualStyleBackColor = true;
			// 
			// rbtListagem
			// 
			this.rbtListagem.Location = new System.Drawing.Point(7, 4);
			this.rbtListagem.Name = "rbtListagem";
			this.rbtListagem.Size = new System.Drawing.Size(104, 24);
			this.rbtListagem.TabIndex = 17;
			this.rbtListagem.TabStop = true;
			this.rbtListagem.Text = "Listagem";
			this.rbtListagem.UseVisualStyleBackColor = true;
			this.rbtListagem.CheckedChanged += new System.EventHandler(this.RbtListagemCheckedChanged);
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.lblObservacao);
			this.panel2.Controls.Add(this.edtObservacao);
			this.panel2.Controls.Add(this.chkPorFabrica);
			this.panel2.Controls.Add(this.chkPorCliente);
			this.panel2.Controls.Add(this.chkPorPedido);
			this.panel2.Controls.Add(this.chkPorItem);
			this.panel2.Controls.Add(this.chkConsolidado);
			this.panel2.Controls.Add(this.rbtPedido);
			this.panel2.Location = new System.Drawing.Point(3, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(735, 212);
			this.panel2.TabIndex = 1;
			// 
			// lblObservacao
			// 
			this.lblObservacao.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblObservacao.Location = new System.Drawing.Point(277, 128);
			this.lblObservacao.Name = "lblObservacao";
			this.lblObservacao.Size = new System.Drawing.Size(191, 25);
			this.lblObservacao.TabIndex = 79;
			this.lblObservacao.Text = "Observação para Fábrica";
			this.lblObservacao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// edtObservacao
			// 
			this.edtObservacao.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtObservacao.Location = new System.Drawing.Point(277, 156);
			this.edtObservacao.Multiline = true;
			this.edtObservacao.Name = "edtObservacao";
			this.edtObservacao.Size = new System.Drawing.Size(451, 45);
			this.edtObservacao.TabIndex = 78;
			// 
			// chkPorFabrica
			// 
			this.chkPorFabrica.Location = new System.Drawing.Point(189, 128);
			this.chkPorFabrica.Name = "chkPorFabrica";
			this.chkPorFabrica.Size = new System.Drawing.Size(104, 24);
			this.chkPorFabrica.TabIndex = 77;
			this.chkPorFabrica.Text = "Por Fábrica";
			this.chkPorFabrica.UseVisualStyleBackColor = true;
			// 
			// chkPorCliente
			// 
			this.chkPorCliente.Location = new System.Drawing.Point(189, 98);
			this.chkPorCliente.Name = "chkPorCliente";
			this.chkPorCliente.Size = new System.Drawing.Size(104, 24);
			this.chkPorCliente.TabIndex = 76;
			this.chkPorCliente.Text = "Por Cliente";
			this.chkPorCliente.UseVisualStyleBackColor = true;
			// 
			// chkPorPedido
			// 
			this.chkPorPedido.Location = new System.Drawing.Point(189, 68);
			this.chkPorPedido.Name = "chkPorPedido";
			this.chkPorPedido.Size = new System.Drawing.Size(104, 24);
			this.chkPorPedido.TabIndex = 75;
			this.chkPorPedido.Text = "Por Pedido";
			this.chkPorPedido.UseVisualStyleBackColor = true;
			// 
			// chkPorItem
			// 
			this.chkPorItem.Location = new System.Drawing.Point(189, 38);
			this.chkPorItem.Name = "chkPorItem";
			this.chkPorItem.Size = new System.Drawing.Size(104, 24);
			this.chkPorItem.TabIndex = 74;
			this.chkPorItem.Text = "Por Item";
			this.chkPorItem.UseVisualStyleBackColor = true;
			// 
			// chkConsolidado
			// 
			this.chkConsolidado.Location = new System.Drawing.Point(159, 8);
			this.chkConsolidado.Name = "chkConsolidado";
			this.chkConsolidado.Size = new System.Drawing.Size(104, 24);
			this.chkConsolidado.TabIndex = 73;
			this.chkConsolidado.Text = "Consolidado";
			this.chkConsolidado.UseVisualStyleBackColor = true;
			// 
			// rbtPedido
			// 
			this.rbtPedido.Checked = true;
			this.rbtPedido.Location = new System.Drawing.Point(3, 7);
			this.rbtPedido.Name = "rbtPedido";
			this.rbtPedido.Size = new System.Drawing.Size(104, 24);
			this.rbtPedido.TabIndex = 0;
			this.rbtPedido.TabStop = true;
			this.rbtPedido.Text = "Pedido";
			this.rbtPedido.UseVisualStyleBackColor = true;
			this.rbtPedido.CheckedChanged += new System.EventHandler(this.RbtPedidoCheckedChanged);
			// 
			// panel5
			// 
			this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel5.Controls.Add(this.chkMostrarValores);
			this.panel5.Controls.Add(this.chkMostrarSubCodigo);
			this.panel5.Location = new System.Drawing.Point(12, 389);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(746, 33);
			this.panel5.TabIndex = 3;
			// 
			// chkMostrarValores
			// 
			this.chkMostrarValores.Checked = true;
			this.chkMostrarValores.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkMostrarValores.Location = new System.Drawing.Point(193, 3);
			this.chkMostrarValores.Name = "chkMostrarValores";
			this.chkMostrarValores.Size = new System.Drawing.Size(104, 24);
			this.chkMostrarValores.TabIndex = 20;
			this.chkMostrarValores.Text = "Mostrar Valores";
			this.chkMostrarValores.UseVisualStyleBackColor = true;
			// 
			// chkMostrarSubCodigo
			// 
			this.chkMostrarSubCodigo.Checked = true;
			this.chkMostrarSubCodigo.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkMostrarSubCodigo.Location = new System.Drawing.Point(11, 3);
			this.chkMostrarSubCodigo.Name = "chkMostrarSubCodigo";
			this.chkMostrarSubCodigo.Size = new System.Drawing.Size(153, 24);
			this.chkMostrarSubCodigo.TabIndex = 18;
			this.chkMostrarSubCodigo.Text = "Mostra Sub-Código";
			this.chkMostrarSubCodigo.UseVisualStyleBackColor = true;
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(115, 428);
			this.btnCancela.Name = "btnCancela";
			this.btnCancela.Size = new System.Drawing.Size(100, 25);
			this.btnCancela.TabIndex = 24;
			this.btnCancela.Text = "C&ancela";
			this.btnCancela.UseVisualStyleBackColor = true;
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(9, 428);
			this.btnConfirma.Name = "btnConfirma";
			this.btnConfirma.Size = new System.Drawing.Size(100, 25);
			this.btnConfirma.TabIndex = 22;
			this.btnConfirma.Text = "&Confirma";
			this.btnConfirma.UseVisualStyleBackColor = true;
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// fParametrosImpressao2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(767, 465);
			this.Controls.Add(this.btnCancela);
			this.Controls.Add(this.btnConfirma);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel1);
			this.Name = "fParametrosImpressao2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Parâmetros para Impressão";
			this.panel1.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.TextBox edtTitulo;
		private System.Windows.Forms.CheckBox chkQuebraCaracteristica;
		private System.Windows.Forms.CheckBox chkDetalhes;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.Button btnConfirma;
		public System.Windows.Forms.Button btnCancela;
		private System.Windows.Forms.CheckBox chkMostrarSubCodigo;
		private System.Windows.Forms.CheckBox chkMostrarValores;
		private System.Windows.Forms.Panel panel5;
		public System.Windows.Forms.RadioButton rbtPedido;
		private System.Windows.Forms.CheckBox chkConsolidado;
		private System.Windows.Forms.CheckBox chkPorItem;
		private System.Windows.Forms.CheckBox chkPorPedido;
		private System.Windows.Forms.CheckBox chkPorCliente;
		private System.Windows.Forms.CheckBox chkPorFabrica;
		private System.Windows.Forms.TextBox edtObservacao;
		private System.Windows.Forms.Label lblObservacao;
		private System.Windows.Forms.Panel panel2;
		public System.Windows.Forms.RadioButton rbtListagem;
		private System.Windows.Forms.Panel panel3;
		public System.Windows.Forms.RadioButton rbtFabrica;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel1;
	}
}
