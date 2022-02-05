/*
 * Criado por SharpDevelop.
 * Usuário: Ricardo
 * Data: 16/05/2009
 * Hora: 10:41
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
 
using classes;

namespace basico
{
	partial class fSelecionaPedido
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSelecionaPedido));
			this.edtLocaliza = new System.Windows.Forms.TextBox();
			this.dgvCadastro = new System.Windows.Forms.DataGridView();
			this.btnCancela = new System.Windows.Forms.Button();
			this.btnConfirma = new System.Windows.Forms.Button();
			this.label13 = new System.Windows.Forms.Label();
			this.btnFiltro = new System.Windows.Forms.Button();
			this.btnDown = new System.Windows.Forms.Button();
			this.btnUp = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvCadastro)).BeginInit();
			this.SuspendLayout();
			// 
			// edtLocaliza
			// 
			this.edtLocaliza.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtLocaliza.Location = new System.Drawing.Point(75, 5);
			this.edtLocaliza.MaxLength = 30;
			this.edtLocaliza.Name = "edtLocaliza";
			this.edtLocaliza.Size = new System.Drawing.Size(195, 20);
			this.edtLocaliza.TabIndex = 2;
			this.edtLocaliza.TextChanged += new System.EventHandler(this.EdtLocalizaTextChanged);
			// 
			// dgvCadastro
			// 
			this.dgvCadastro.AllowUserToAddRows = false;
			this.dgvCadastro.AllowUserToDeleteRows = false;
			this.dgvCadastro.AllowUserToResizeColumns = false;
			this.dgvCadastro.AllowUserToResizeRows = false;
			this.dgvCadastro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvCadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvCadastro.DefaultCellStyle = dataGridViewCellStyle1;
			this.dgvCadastro.Location = new System.Drawing.Point(10, 33);
			this.dgvCadastro.MultiSelect = false;
			this.dgvCadastro.Name = "dgvCadastro";
			this.dgvCadastro.RowHeadersVisible = false;
			this.dgvCadastro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCadastro.Size = new System.Drawing.Size(910, 336);
			this.dgvCadastro.TabIndex = 12;
			this.dgvCadastro.Sorted += new System.EventHandler(this.DgvCadastroSorted);
			this.dgvCadastro.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCadastroCellDoubleClick);
			this.dgvCadastro.DoubleClick += new System.EventHandler(this.DgvCadastroDoubleClick);
			this.dgvCadastro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCadastroCellClick);
			this.dgvCadastro.CurrentCellDirtyStateChanged += new System.EventHandler(this.DgvCadastroCurrentCellDirtyStateChanged);
			this.dgvCadastro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCadastroCellContentClick);
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(822, 377);
			this.btnCancela.Name = "btnCancela";
			this.btnCancela.Size = new System.Drawing.Size(100, 25);
			this.btnCancela.TabIndex = 16;
			this.btnCancela.Text = "C&ancela";
			this.btnCancela.UseVisualStyleBackColor = true;
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(716, 377);
			this.btnConfirma.Name = "btnConfirma";
			this.btnConfirma.Size = new System.Drawing.Size(100, 25);
			this.btnConfirma.TabIndex = 14;
			this.btnConfirma.Text = "&Confirma";
			this.btnConfirma.UseVisualStyleBackColor = true;
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.Red;
			this.label13.Location = new System.Drawing.Point(10, 377);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(399, 18);
			this.label13.TabIndex = 149;
			this.label13.Text = "Marque as caixas de checagem para selecionar mais de um pedido";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnFiltro
			// 
			this.btnFiltro.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltro.Image")));
			this.btnFiltro.Location = new System.Drawing.Point(360, 4);
			this.btnFiltro.Name = "btnFiltro";
			this.btnFiltro.Size = new System.Drawing.Size(36, 22);
			this.btnFiltro.TabIndex = 6;
			this.btnFiltro.UseVisualStyleBackColor = true;
			this.btnFiltro.Click += new System.EventHandler(this.BtnFiltroClick);
			// 
			// btnDown
			// 
			this.btnDown.Image = ((System.Drawing.Image)(resources.GetObject("btnDown.Image")));
			this.btnDown.Location = new System.Drawing.Point(280, 4);
			this.btnDown.Name = "btnDown";
			this.btnDown.Size = new System.Drawing.Size(36, 22);
			this.btnDown.TabIndex = 8;
			this.btnDown.UseVisualStyleBackColor = true;
			this.btnDown.Click += new System.EventHandler(this.BtnDownClick);
			// 
			// btnUp
			// 
			this.btnUp.Image = ((System.Drawing.Image)(resources.GetObject("btnUp.Image")));
			this.btnUp.Location = new System.Drawing.Point(320, 4);
			this.btnUp.Name = "btnUp";
			this.btnUp.Size = new System.Drawing.Size(36, 22);
			this.btnUp.TabIndex = 10;
			this.btnUp.UseVisualStyleBackColor = true;
			this.btnUp.Click += new System.EventHandler(this.BtnUpClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(10, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 20);
			this.label1.TabIndex = 150;
			this.label1.Text = "Localiza";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// fSelecionaPedido
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(926, 408);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnDown);
			this.Controls.Add(this.btnUp);
			this.Controls.Add(this.btnFiltro);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.btnCancela);
			this.Controls.Add(this.btnConfirma);
			this.Controls.Add(this.edtLocaliza);
			this.Controls.Add(this.dgvCadastro);
			this.Name = "fSelecionaPedido";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Seleção de Pedido";
			this.Load += new System.EventHandler(this.FSelecionaPedidoLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgvCadastro)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.Button btnUp;
		public System.Windows.Forms.Button btnDown;
		private System.Windows.Forms.Label label13;
		public System.Windows.Forms.Button btnConfirma;
		public System.Windows.Forms.Button btnCancela;
		public System.Windows.Forms.DataGridView dgvCadastro;
		public System.Windows.Forms.TextBox edtLocaliza;
		private System.Windows.Forms.Button btnFiltro;
	}
}
