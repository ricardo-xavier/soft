/*
 * Created by SharpDevelop.
 * User: Ricardo
 * Date: 18/07/2016
 * Time: 20:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace acao
{
	partial class fCadGrupo
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		public System.Windows.Forms.DataGridView dgvDisponiveis;
		public System.Windows.Forms.DataGridView dgvClientes;
		private System.Windows.Forms.Button btnInclui;
		private System.Windows.Forms.Button btnIncluiTodos;
		private System.Windows.Forms.Button btnExclui;
		private System.Windows.Forms.Button btnExcluiTodos;
		private System.Windows.Forms.TextBox edtFiltro;
		private System.Windows.Forms.Button btnAplica;
		public System.Windows.Forms.Button btnConfirma;
		public System.Windows.Forms.Button btnCancela;
		
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvDisponiveis = new System.Windows.Forms.DataGridView();
			this.dgvClientes = new System.Windows.Forms.DataGridView();
			this.btnInclui = new System.Windows.Forms.Button();
			this.btnIncluiTodos = new System.Windows.Forms.Button();
			this.btnExclui = new System.Windows.Forms.Button();
			this.btnExcluiTodos = new System.Windows.Forms.Button();
			this.edtFiltro = new System.Windows.Forms.TextBox();
			this.btnAplica = new System.Windows.Forms.Button();
			this.btnConfirma = new System.Windows.Forms.Button();
			this.btnCancela = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvDisponiveis)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvDisponiveis
			// 
			this.dgvDisponiveis.AllowUserToAddRows = false;
			this.dgvDisponiveis.AllowUserToDeleteRows = false;
			this.dgvDisponiveis.AllowUserToResizeColumns = false;
			this.dgvDisponiveis.AllowUserToResizeRows = false;
			this.dgvDisponiveis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvDisponiveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvDisponiveis.DefaultCellStyle = dataGridViewCellStyle1;
			this.dgvDisponiveis.Location = new System.Drawing.Point(12, 39);
			this.dgvDisponiveis.MultiSelect = false;
			this.dgvDisponiveis.Name = "dgvDisponiveis";
			this.dgvDisponiveis.ReadOnly = true;
			this.dgvDisponiveis.RowHeadersVisible = false;
			this.dgvDisponiveis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDisponiveis.Size = new System.Drawing.Size(335, 290);
			this.dgvDisponiveis.TabIndex = 30;
			// 
			// dgvClientes
			// 
			this.dgvClientes.AllowUserToAddRows = false;
			this.dgvClientes.AllowUserToDeleteRows = false;
			this.dgvClientes.AllowUserToResizeColumns = false;
			this.dgvClientes.AllowUserToResizeRows = false;
			this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvClientes.Location = new System.Drawing.Point(391, 39);
			this.dgvClientes.MultiSelect = false;
			this.dgvClientes.Name = "dgvClientes";
			this.dgvClientes.ReadOnly = true;
			this.dgvClientes.RowHeadersVisible = false;
			this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvClientes.Size = new System.Drawing.Size(335, 290);
			this.dgvClientes.TabIndex = 80;
			// 
			// btnInclui
			// 
			this.btnInclui.Location = new System.Drawing.Point(351, 61);
			this.btnInclui.Name = "btnInclui";
			this.btnInclui.Size = new System.Drawing.Size(34, 23);
			this.btnInclui.TabIndex = 40;
			this.btnInclui.Text = ">";
			this.btnInclui.UseVisualStyleBackColor = true;
			this.btnInclui.Click += new System.EventHandler(this.BtnIncluiClick);
			// 
			// btnIncluiTodos
			// 
			this.btnIncluiTodos.Location = new System.Drawing.Point(351, 90);
			this.btnIncluiTodos.Name = "btnIncluiTodos";
			this.btnIncluiTodos.Size = new System.Drawing.Size(34, 23);
			this.btnIncluiTodos.TabIndex = 50;
			this.btnIncluiTodos.Text = ">>";
			this.btnIncluiTodos.UseVisualStyleBackColor = true;
			this.btnIncluiTodos.Click += new System.EventHandler(this.BtnIncluiTodosClick);
			// 
			// btnExclui
			// 
			this.btnExclui.Location = new System.Drawing.Point(351, 119);
			this.btnExclui.Name = "btnExclui";
			this.btnExclui.Size = new System.Drawing.Size(34, 23);
			this.btnExclui.TabIndex = 60;
			this.btnExclui.Text = "<";
			this.btnExclui.UseVisualStyleBackColor = true;
			this.btnExclui.Click += new System.EventHandler(this.BtnExcluiClick);
			// 
			// btnExcluiTodos
			// 
			this.btnExcluiTodos.Location = new System.Drawing.Point(351, 148);
			this.btnExcluiTodos.Name = "btnExcluiTodos";
			this.btnExcluiTodos.Size = new System.Drawing.Size(34, 23);
			this.btnExcluiTodos.TabIndex = 70;
			this.btnExcluiTodos.Text = "<<";
			this.btnExcluiTodos.UseVisualStyleBackColor = true;
			this.btnExcluiTodos.Click += new System.EventHandler(this.BtnExcluiTodosClick);
			// 
			// edtFiltro
			// 
			this.edtFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtFiltro.Location = new System.Drawing.Point(12, 12);
			this.edtFiltro.Name = "edtFiltro";
			this.edtFiltro.Size = new System.Drawing.Size(246, 20);
			this.edtFiltro.TabIndex = 10;
			// 
			// btnAplica
			// 
			this.btnAplica.Location = new System.Drawing.Point(272, 10);
			this.btnAplica.Name = "btnAplica";
			this.btnAplica.Size = new System.Drawing.Size(75, 23);
			this.btnAplica.TabIndex = 20;
			this.btnAplica.Text = "Aplica";
			this.btnAplica.UseVisualStyleBackColor = true;
			this.btnAplica.Click += new System.EventHandler(this.BtnAplicaClick);
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(520, 335);
			this.btnConfirma.Name = "btnConfirma";
			this.btnConfirma.Size = new System.Drawing.Size(100, 25);
			this.btnConfirma.TabIndex = 90;
			this.btnConfirma.Text = "Confirma";
			this.btnConfirma.UseVisualStyleBackColor = true;
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(626, 335);
			this.btnCancela.Name = "btnCancela";
			this.btnCancela.Size = new System.Drawing.Size(100, 25);
			this.btnCancela.TabIndex = 100;
			this.btnCancela.Text = "Cancela";
			this.btnCancela.UseVisualStyleBackColor = true;
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
			// 
			// fCadGrupo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(729, 370);
			this.Controls.Add(this.btnCancela);
			this.Controls.Add(this.btnConfirma);
			this.Controls.Add(this.btnAplica);
			this.Controls.Add(this.edtFiltro);
			this.Controls.Add(this.btnExcluiTodos);
			this.Controls.Add(this.btnExclui);
			this.Controls.Add(this.btnIncluiTodos);
			this.Controls.Add(this.btnInclui);
			this.Controls.Add(this.dgvClientes);
			this.Controls.Add(this.dgvDisponiveis);
			this.Name = "fCadGrupo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Clientes Ação";
			((System.ComponentModel.ISupportInitialize)(this.dgvDisponiveis)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
