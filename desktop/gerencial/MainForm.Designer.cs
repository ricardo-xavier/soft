/*
 * Criado por SharpDevelop.
 * Usuário: Ricardo
 * Data: 27/06/2010
 * Hora: 20:25
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace gerencial
{
	partial class MainForm
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
			this.btnFluxoCaixa = new System.Windows.Forms.Button();
			this.btnCurvaVendedor = new System.Windows.Forms.Button();
			this.btnCurvaConsultor = new System.Windows.Forms.Button();
			this.btnCurvaFornecedor = new System.Windows.Forms.Button();
			this.btnAvisos = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.imgSoftplace)).BeginInit();
			this.SuspendLayout();
			// 
			// imgSoftplace
			// 
			this.imgSoftplace.Location = new System.Drawing.Point(297, 12);
			// 
			// btnFluxoCaixa
			// 
			this.btnFluxoCaixa.Location = new System.Drawing.Point(12, 12);
			this.btnFluxoCaixa.Name = "btnFluxoCaixa";
			this.btnFluxoCaixa.Size = new System.Drawing.Size(253, 23);
			this.btnFluxoCaixa.TabIndex = 3;
			this.btnFluxoCaixa.Text = "Fluxo de Caixa";
			this.btnFluxoCaixa.UseVisualStyleBackColor = true;
			this.btnFluxoCaixa.Click += new System.EventHandler(this.BtnFluxoCaixaClick);
			// 
			// btnCurvaVendedor
			// 
			this.btnCurvaVendedor.Location = new System.Drawing.Point(12, 41);
			this.btnCurvaVendedor.Name = "btnCurvaVendedor";
			this.btnCurvaVendedor.Size = new System.Drawing.Size(253, 23);
			this.btnCurvaVendedor.TabIndex = 4;
			this.btnCurvaVendedor.Text = "Curva Vendedor";
			this.btnCurvaVendedor.UseVisualStyleBackColor = true;
			this.btnCurvaVendedor.Click += new System.EventHandler(this.BtnCurvaVendedorClick);
			// 
			// btnCurvaConsultor
			// 
			this.btnCurvaConsultor.Location = new System.Drawing.Point(12, 70);
			this.btnCurvaConsultor.Name = "btnCurvaConsultor";
			this.btnCurvaConsultor.Size = new System.Drawing.Size(253, 23);
			this.btnCurvaConsultor.TabIndex = 5;
			this.btnCurvaConsultor.Text = "Curva Consultor";
			this.btnCurvaConsultor.UseVisualStyleBackColor = true;
			this.btnCurvaConsultor.Click += new System.EventHandler(this.BtnCurvaConsultorClick);
			// 
			// btnCurvaFornecedor
			// 
			this.btnCurvaFornecedor.Location = new System.Drawing.Point(12, 99);
			this.btnCurvaFornecedor.Name = "btnCurvaFornecedor";
			this.btnCurvaFornecedor.Size = new System.Drawing.Size(253, 23);
			this.btnCurvaFornecedor.TabIndex = 6;
			this.btnCurvaFornecedor.Text = "Curva Fornecedor";
			this.btnCurvaFornecedor.UseVisualStyleBackColor = true;
			this.btnCurvaFornecedor.Click += new System.EventHandler(this.BtnCurvaFornecedorClick);
			// 
			// btnAvisos
			// 
			this.btnAvisos.Location = new System.Drawing.Point(12, 128);
			this.btnAvisos.Name = "btnAvisos";
			this.btnAvisos.Size = new System.Drawing.Size(253, 23);
			this.btnAvisos.TabIndex = 7;
			this.btnAvisos.Text = "Avisos";
			this.btnAvisos.UseVisualStyleBackColor = true;
			this.btnAvisos.Click += new System.EventHandler(this.BtnAvisosClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 350);
			this.Controls.Add(this.btnAvisos);
			this.Controls.Add(this.btnCurvaFornecedor);
			this.Controls.Add(this.btnCurvaConsultor);
			this.Controls.Add(this.btnCurvaVendedor);
			this.Controls.Add(this.btnFluxoCaixa);
			this.Name = "MainForm";
			this.Text = "Sistema SOFT - Gerencial - v2.0.2 (28/11/21)";
			this.Shown += new System.EventHandler(this.MainFormShown);
			this.Controls.SetChildIndex(this.btnFluxoCaixa, 0);
			this.Controls.SetChildIndex(this.imgSoftplace, 0);
			this.Controls.SetChildIndex(this.btnCurvaVendedor, 0);
			this.Controls.SetChildIndex(this.btnCurvaConsultor, 0);
			this.Controls.SetChildIndex(this.btnCurvaFornecedor, 0);
			this.Controls.SetChildIndex(this.btnAvisos, 0);
			((System.ComponentModel.ISupportInitialize)(this.imgSoftplace)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnAvisos;
		private System.Windows.Forms.Button btnCurvaFornecedor;
		private System.Windows.Forms.Button btnCurvaConsultor;
		private System.Windows.Forms.Button btnCurvaVendedor;
		private System.Windows.Forms.Button btnFluxoCaixa;
	}
}
