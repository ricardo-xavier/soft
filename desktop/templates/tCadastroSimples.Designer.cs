/*
 * Usuário: Ricardo
 * Data: 01/04/2008
 * Hora: 20:42
 * 
 */
namespace templates
{
	partial class tCadastroSimples
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tCadastroSimples));
			this.dgvCadastro = new System.Windows.Forms.DataGridView();
			this.btnInclui = new System.Windows.Forms.Button();
			this.btnExclui = new System.Windows.Forms.Button();
			this.btnAltera = new System.Windows.Forms.Button();
			this.btnFecha = new System.Windows.Forms.Button();
			this.pnlEdicao = new System.Windows.Forms.Panel();
			this.btnCancela = new System.Windows.Forms.Button();
			this.btnConfirma = new System.Windows.Forms.Button();
			this.edtDescricao = new System.Windows.Forms.TextBox();
			this.edtCodigo = new System.Windows.Forms.TextBox();
			this.lblDescricao = new System.Windows.Forms.Label();
			this.lblCodigo = new System.Windows.Forms.Label();
			this.edtLocaliza = new System.Windows.Forms.TextBox();
			this.btnLocaliza = new System.Windows.Forms.Button();
			this.btnDown = new System.Windows.Forms.Button();
			this.btnUp = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvCadastro)).BeginInit();
			this.pnlEdicao.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvCadastro
			// 
			this.dgvCadastro.AllowUserToAddRows = false;
			this.dgvCadastro.AllowUserToDeleteRows = false;
			this.dgvCadastro.AllowUserToResizeColumns = false;
			this.dgvCadastro.AllowUserToResizeRows = false;
			this.dgvCadastro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvCadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCadastro.Location = new System.Drawing.Point(10, 40);
			this.dgvCadastro.MultiSelect = false;
			this.dgvCadastro.Name = "dgvCadastro";
			this.dgvCadastro.ReadOnly = true;
			this.dgvCadastro.RowHeadersVisible = false;
			this.dgvCadastro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCadastro.Size = new System.Drawing.Size(300, 156);
			this.dgvCadastro.TabIndex = 2;
			this.dgvCadastro.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCadastroRowEnter);
			// 
			// btnInclui
			// 
			this.btnInclui.Location = new System.Drawing.Point(320, 40);
			this.btnInclui.Name = "btnInclui";
			this.btnInclui.Size = new System.Drawing.Size(100, 25);
			this.btnInclui.TabIndex = 3;
			this.btnInclui.Text = "&Inclui";
			this.btnInclui.UseVisualStyleBackColor = true;
			this.btnInclui.Click += new System.EventHandler(this.BtnIncluiClick);
			// 
			// btnExclui
			// 
			this.btnExclui.Location = new System.Drawing.Point(320, 70);
			this.btnExclui.Name = "btnExclui";
			this.btnExclui.Size = new System.Drawing.Size(100, 25);
			this.btnExclui.TabIndex = 4;
			this.btnExclui.Text = "&Exclui";
			this.btnExclui.UseVisualStyleBackColor = true;
			this.btnExclui.Click += new System.EventHandler(this.BtnExcluiClick);
			// 
			// btnAltera
			// 
			this.btnAltera.Location = new System.Drawing.Point(320, 100);
			this.btnAltera.Name = "btnAltera";
			this.btnAltera.Size = new System.Drawing.Size(100, 25);
			this.btnAltera.TabIndex = 5;
			this.btnAltera.Text = "&Altera";
			this.btnAltera.UseVisualStyleBackColor = true;
			this.btnAltera.Click += new System.EventHandler(this.BtnAlteraClick);
			// 
			// btnFecha
			// 
			this.btnFecha.Location = new System.Drawing.Point(320, 130);
			this.btnFecha.Name = "btnFecha";
			this.btnFecha.Size = new System.Drawing.Size(100, 25);
			this.btnFecha.TabIndex = 6;
			this.btnFecha.Text = "&Fecha";
			this.btnFecha.UseVisualStyleBackColor = true;
			this.btnFecha.Click += new System.EventHandler(this.BtnFechaClick);
			// 
			// pnlEdicao
			// 
			this.pnlEdicao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlEdicao.Controls.Add(this.btnCancela);
			this.pnlEdicao.Controls.Add(this.btnConfirma);
			this.pnlEdicao.Controls.Add(this.edtDescricao);
			this.pnlEdicao.Controls.Add(this.edtCodigo);
			this.pnlEdicao.Controls.Add(this.lblDescricao);
			this.pnlEdicao.Controls.Add(this.lblCodigo);
			this.pnlEdicao.Location = new System.Drawing.Point(10, 200);
			this.pnlEdicao.Name = "pnlEdicao";
			this.pnlEdicao.Size = new System.Drawing.Size(420, 130);
			this.pnlEdicao.TabIndex = 7;
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(310, 90);
			this.btnCancela.Name = "btnCancela";
			this.btnCancela.Size = new System.Drawing.Size(100, 25);
			this.btnCancela.TabIndex = 21;
			this.btnCancela.Text = "C&ancela";
			this.btnCancela.UseVisualStyleBackColor = true;
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(200, 90);
			this.btnConfirma.Name = "btnConfirma";
			this.btnConfirma.Size = new System.Drawing.Size(100, 25);
			this.btnConfirma.TabIndex = 20;
			this.btnConfirma.Text = "&Confirma";
			this.btnConfirma.UseVisualStyleBackColor = true;
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// edtDescricao
			// 
			this.edtDescricao.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtDescricao.Location = new System.Drawing.Point(115, 40);
			this.edtDescricao.MaxLength = 30;
			this.edtDescricao.Name = "edtDescricao";
			this.edtDescricao.Size = new System.Drawing.Size(216, 20);
			this.edtDescricao.TabIndex = 3;
			// 
			// edtCodigo
			// 
			this.edtCodigo.BackColor = System.Drawing.SystemColors.Info;
			this.edtCodigo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtCodigo.Location = new System.Drawing.Point(115, 10);
			this.edtCodigo.MaxLength = 10;
			this.edtCodigo.Name = "edtCodigo";
			this.edtCodigo.Size = new System.Drawing.Size(76, 20);
			this.edtCodigo.TabIndex = 2;
			// 
			// lblDescricao
			// 
			this.lblDescricao.ForeColor = System.Drawing.Color.Red;
			this.lblDescricao.Location = new System.Drawing.Point(10, 40);
			this.lblDescricao.Name = "lblDescricao";
			this.lblDescricao.Size = new System.Drawing.Size(100, 20);
			this.lblDescricao.TabIndex = 1;
			this.lblDescricao.Text = "Descrição";
			this.lblDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblCodigo
			// 
			this.lblCodigo.ForeColor = System.Drawing.Color.Red;
			this.lblCodigo.Location = new System.Drawing.Point(10, 10);
			this.lblCodigo.Name = "lblCodigo";
			this.lblCodigo.Size = new System.Drawing.Size(100, 20);
			this.lblCodigo.TabIndex = 0;
			this.lblCodigo.Text = "Código";
			this.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtLocaliza
			// 
			this.edtLocaliza.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtLocaliza.Location = new System.Drawing.Point(10, 14);
			this.edtLocaliza.MaxLength = 30;
			this.edtLocaliza.Name = "edtLocaliza";
			this.edtLocaliza.Size = new System.Drawing.Size(195, 20);
			this.edtLocaliza.TabIndex = 0;
			this.edtLocaliza.TextChanged += new System.EventHandler(this.EdtLocalizaTextChanged);
			// 
			// btnLocaliza
			// 
			this.btnLocaliza.Location = new System.Drawing.Point(210, 10);
			this.btnLocaliza.Name = "btnLocaliza";
			this.btnLocaliza.Size = new System.Drawing.Size(100, 25);
			this.btnLocaliza.TabIndex = 1;
			this.btnLocaliza.Text = "&Localiza";
			this.btnLocaliza.UseVisualStyleBackColor = true;
			this.btnLocaliza.Click += new System.EventHandler(this.BtnLocalizaClick);
			// 
			// btnDown
			// 
			this.btnDown.Image = ((System.Drawing.Image)(resources.GetObject("btnDown.Image")));
			this.btnDown.Location = new System.Drawing.Point(317, 10);
			this.btnDown.Name = "btnDown";
			this.btnDown.Size = new System.Drawing.Size(36, 23);
			this.btnDown.TabIndex = 8;
			this.btnDown.UseVisualStyleBackColor = true;
			this.btnDown.Click += new System.EventHandler(this.BtnDownClick);
			// 
			// btnUp
			// 
			this.btnUp.Image = ((System.Drawing.Image)(resources.GetObject("btnUp.Image")));
			this.btnUp.Location = new System.Drawing.Point(359, 10);
			this.btnUp.Name = "btnUp";
			this.btnUp.Size = new System.Drawing.Size(36, 23);
			this.btnUp.TabIndex = 9;
			this.btnUp.UseVisualStyleBackColor = true;
			this.btnUp.Click += new System.EventHandler(this.BtnUpClick);
			// 
			// tCadastroSimples
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(434, 334);
			this.Controls.Add(this.btnDown);
			this.Controls.Add(this.btnUp);
			this.Controls.Add(this.btnLocaliza);
			this.Controls.Add(this.edtLocaliza);
			this.Controls.Add(this.pnlEdicao);
			this.Controls.Add(this.btnFecha);
			this.Controls.Add(this.btnAltera);
			this.Controls.Add(this.btnExclui);
			this.Controls.Add(this.btnInclui);
			this.Controls.Add(this.dgvCadastro);
			this.Name = "tCadastroSimples";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "tCadastroSimples";
			this.Load += new System.EventHandler(this.TCadastroSimplesLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgvCadastro)).EndInit();
			this.pnlEdicao.ResumeLayout(false);
			this.pnlEdicao.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		public System.Windows.Forms.Button btnUp;
		public System.Windows.Forms.Button btnDown;
		public System.Windows.Forms.Button btnLocaliza;
		public System.Windows.Forms.TextBox edtLocaliza;
		public System.Windows.Forms.Button btnCancela;
		public System.Windows.Forms.Button btnConfirma;
		public System.Windows.Forms.TextBox edtCodigo;
		public System.Windows.Forms.TextBox edtDescricao;
		public System.Windows.Forms.Label lblCodigo;
		public System.Windows.Forms.Label lblDescricao;
		public System.Windows.Forms.Panel pnlEdicao;
		public System.Windows.Forms.Button btnFecha;
		public System.Windows.Forms.Button btnAltera;
		public System.Windows.Forms.Button btnExclui;
		public System.Windows.Forms.Button btnInclui;
		public System.Windows.Forms.DataGridView dgvCadastro;
	}
}
