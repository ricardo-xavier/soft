/*
 * Usuário: Ricardo
 * Data: 27/04/2008
 * Hora: 21:51
 * 
 */
namespace basico
{
	partial class frmPrecos
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
			this.btnLocaliza = new System.Windows.Forms.Button();
			this.edtLocaliza = new System.Windows.Forms.TextBox();
			this.dgvCadastro = new System.Windows.Forms.DataGridView();
			this.btnConfirma = new System.Windows.Forms.Button();
			this.btnCancela = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvCadastro)).BeginInit();
			this.SuspendLayout();
			// 
			// btnLocaliza
			// 
			this.btnLocaliza.Location = new System.Drawing.Point(212, 3);
			this.btnLocaliza.Name = "btnLocaliza";
			this.btnLocaliza.Size = new System.Drawing.Size(100, 25);
			this.btnLocaliza.TabIndex = 4;
			this.btnLocaliza.Text = "&Localiza";
			this.btnLocaliza.UseVisualStyleBackColor = true;
			this.btnLocaliza.Click += new System.EventHandler(this.BtnLocalizaClick);
			// 
			// edtLocaliza
			// 
			this.edtLocaliza.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtLocaliza.Location = new System.Drawing.Point(12, 7);
			this.edtLocaliza.MaxLength = 30;
			this.edtLocaliza.Name = "edtLocaliza";
			this.edtLocaliza.Size = new System.Drawing.Size(195, 20);
			this.edtLocaliza.TabIndex = 3;
			// 
			// dgvCadastro
			// 
			this.dgvCadastro.AllowUserToAddRows = false;
			this.dgvCadastro.AllowUserToDeleteRows = false;
			this.dgvCadastro.AllowUserToResizeColumns = false;
			this.dgvCadastro.AllowUserToResizeRows = false;
			this.dgvCadastro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvCadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCadastro.Location = new System.Drawing.Point(12, 33);
			this.dgvCadastro.MultiSelect = false;
			this.dgvCadastro.Name = "dgvCadastro";
			this.dgvCadastro.RowHeadersVisible = false;
			this.dgvCadastro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCadastro.Size = new System.Drawing.Size(745, 416);
			this.dgvCadastro.TabIndex = 5;
			this.dgvCadastro.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCadastroCellLeave);
			this.dgvCadastro.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCadastroRowLeave);
			this.dgvCadastro.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCadastroCellEndEdit);
			this.dgvCadastro.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCadastroCellEnter);
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(770, 33);
			this.btnConfirma.Name = "btnConfirma";
			this.btnConfirma.Size = new System.Drawing.Size(100, 25);
			this.btnConfirma.TabIndex = 6;
			this.btnConfirma.Text = "&Confirma";
			this.btnConfirma.UseVisualStyleBackColor = true;
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(770, 64);
			this.btnCancela.Name = "btnCancela";
			this.btnCancela.Size = new System.Drawing.Size(100, 25);
			this.btnCancela.TabIndex = 7;
			this.btnCancela.Text = "C&ancela";
			this.btnCancela.UseVisualStyleBackColor = true;
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
			// 
			// frmPrecos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 461);
			this.Controls.Add(this.btnCancela);
			this.Controls.Add(this.btnConfirma);
			this.Controls.Add(this.btnLocaliza);
			this.Controls.Add(this.edtLocaliza);
			this.Controls.Add(this.dgvCadastro);
			this.Name = "frmPrecos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastros Básicos - Preços";
			this.Load += new System.EventHandler(this.FrmPrecosLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgvCadastro)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		public System.Windows.Forms.Button btnCancela;
		public System.Windows.Forms.Button btnConfirma;
		public System.Windows.Forms.DataGridView dgvCadastro;
		public System.Windows.Forms.TextBox edtLocaliza;
		public System.Windows.Forms.Button btnLocaliza;
	}
}
