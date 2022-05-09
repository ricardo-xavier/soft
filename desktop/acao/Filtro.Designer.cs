/*
 * Criado por SharpDevelop.
 * Usuário: Ricardo
 * Data: 7/3/2015
 * Hora: 10:48
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace acao
{
	partial class Filtro
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Filtro));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.cbxUsuarios = new System.Windows.Forms.ComboBox();
			this.lblVendedor = new System.Windows.Forms.Label();
			this.btnCliente = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cbxVendedores = new System.Windows.Forms.ComboBox();
			this.btnConsultor = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.dtpPrevisaoF = new System.Windows.Forms.DateTimePicker();
			this.label13 = new System.Windows.Forms.Label();
			this.dtpPrevisaoI = new System.Windows.Forms.DateTimePicker();
			this.btnOrigem = new System.Windows.Forms.Button();
			this.edtOrigem = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.dgvSituacoes = new System.Windows.Forms.DataGridView();
			this.chkTodas = new System.Windows.Forms.CheckBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSituacoes)).BeginInit();
			this.SuspendLayout();
			// 
			// lblCodigo
			// 
			this.lblCodigo.Text = "Parceiro";
			// 
			// lblDescricao
			// 
			this.lblDescricao.Text = "Consultor";
			// 
			// edtCodigo
			// 
			this.edtCodigo.BackColor = System.Drawing.SystemColors.Control;
			this.edtCodigo.ReadOnly = true;
			this.edtCodigo.Size = new System.Drawing.Size(146, 20);
			this.edtCodigo.TabIndex = 10;
			// 
			// edtDescricao
			// 
			this.edtDescricao.ReadOnly = true;
			this.edtDescricao.Size = new System.Drawing.Size(146, 20);
			this.edtDescricao.TabIndex = 30;
			// 
			// lblTitulo
			// 
			this.lblTitulo.Text = "Filtro de Ações Comerciais";
			// 
			// btnLimpa
			// 
			this.btnLimpa.TabIndex = 130;
			this.btnLimpa.Click += new System.EventHandler(this.BtnLimpaClick);
			// 
			// btnCancela
			// 
			this.btnCancela.TabIndex = 120;
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
			// 
			// btnConfirma
			// 
			this.btnConfirma.TabIndex = 110;
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.chkTodas);
			this.panel1.Controls.Add(this.dgvSituacoes);
			this.panel1.Controls.Add(this.btnConsultor);
			this.panel1.Controls.Add(this.btnCliente);
			this.panel1.Controls.Add(this.btnOrigem);
			this.panel1.Controls.Add(this.cbxVendedores);
			this.panel1.Controls.Add(this.edtOrigem);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.dtpPrevisaoF);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label13);
			this.panel1.Controls.Add(this.dtpPrevisaoI);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 46);
			this.panel1.Size = new System.Drawing.Size(380, 275);
			this.panel1.Controls.SetChildIndex(this.label1, 0);
			this.panel1.Controls.SetChildIndex(this.dtpPrevisaoI, 0);
			this.panel1.Controls.SetChildIndex(this.label13, 0);
			this.panel1.Controls.SetChildIndex(this.label2, 0);
			this.panel1.Controls.SetChildIndex(this.label9, 0);
			this.panel1.Controls.SetChildIndex(this.dtpPrevisaoF, 0);
			this.panel1.Controls.SetChildIndex(this.label6, 0);
			this.panel1.Controls.SetChildIndex(this.edtOrigem, 0);
			this.panel1.Controls.SetChildIndex(this.cbxVendedores, 0);
			this.panel1.Controls.SetChildIndex(this.btnOrigem, 0);
			this.panel1.Controls.SetChildIndex(this.btnCliente, 0);
			this.panel1.Controls.SetChildIndex(this.btnConsultor, 0);
			this.panel1.Controls.SetChildIndex(this.lblCodigo, 0);
			this.panel1.Controls.SetChildIndex(this.lblDescricao, 0);
			this.panel1.Controls.SetChildIndex(this.edtCodigo, 0);
			this.panel1.Controls.SetChildIndex(this.edtDescricao, 0);
			this.panel1.Controls.SetChildIndex(this.dgvSituacoes, 0);
			this.panel1.Controls.SetChildIndex(this.chkTodas, 0);
			// 
			// cbxUsuarios
			// 
			this.cbxUsuarios.BackColor = System.Drawing.SystemColors.Window;
			this.cbxUsuarios.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxUsuarios.FormattingEnabled = true;
			this.cbxUsuarios.Location = new System.Drawing.Point(117, 9);
			this.cbxUsuarios.Name = "cbxUsuarios";
			this.cbxUsuarios.Size = new System.Drawing.Size(166, 22);
			this.cbxUsuarios.TabIndex = 109;
			// 
			// lblVendedor
			// 
			this.lblVendedor.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblVendedor.Location = new System.Drawing.Point(12, 9);
			this.lblVendedor.Name = "lblVendedor";
			this.lblVendedor.Size = new System.Drawing.Size(100, 20);
			this.lblVendedor.TabIndex = 115;
			this.lblVendedor.Text = "Vendedor";
			this.lblVendedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnCliente
			// 
			this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
			this.btnCliente.Location = new System.Drawing.Point(267, 9);
			this.btnCliente.Name = "btnCliente";
			this.btnCliente.Size = new System.Drawing.Size(36, 23);
			this.btnCliente.TabIndex = 20;
			this.btnCliente.UseVisualStyleBackColor = true;
			this.btnCliente.Click += new System.EventHandler(this.BtnClienteClick);
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(9, 149);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 20);
			this.label1.TabIndex = 122;
			this.label1.Text = "Situação";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label2.Location = new System.Drawing.Point(10, 94);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 20);
			this.label2.TabIndex = 124;
			this.label2.Text = "Vendedor";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxVendedores
			// 
			this.cbxVendedores.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxVendedores.FormattingEnabled = true;
			this.cbxVendedores.Location = new System.Drawing.Point(115, 92);
			this.cbxVendedores.Name = "cbxVendedores";
			this.cbxVendedores.Size = new System.Drawing.Size(146, 22);
			this.cbxVendedores.TabIndex = 50;
			// 
			// btnConsultor
			// 
			this.btnConsultor.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultor.Image")));
			this.btnConsultor.Location = new System.Drawing.Point(267, 39);
			this.btnConsultor.Name = "btnConsultor";
			this.btnConsultor.Size = new System.Drawing.Size(36, 23);
			this.btnConsultor.TabIndex = 40;
			this.btnConsultor.UseVisualStyleBackColor = true;
			this.btnConsultor.Click += new System.EventHandler(this.BtnConsultorClick);
			// 
			// label9
			// 
			this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label9.Location = new System.Drawing.Point(223, 119);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(25, 20);
			this.label9.TabIndex = 129;
			this.label9.Text = "até";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpPrevisaoF
			// 
			this.dtpPrevisaoF.Checked = false;
			this.dtpPrevisaoF.CustomFormat = "dd/MM/yyyy";
			this.dtpPrevisaoF.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpPrevisaoF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpPrevisaoF.Location = new System.Drawing.Point(254, 120);
			this.dtpPrevisaoF.Name = "dtpPrevisaoF";
			this.dtpPrevisaoF.ShowCheckBox = true;
			this.dtpPrevisaoF.Size = new System.Drawing.Size(110, 20);
			this.dtpPrevisaoF.TabIndex = 70;
			// 
			// label13
			// 
			this.label13.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label13.Location = new System.Drawing.Point(30, 120);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(80, 20);
			this.label13.TabIndex = 128;
			this.label13.Text = "Previsão de";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpPrevisaoI
			// 
			this.dtpPrevisaoI.Checked = false;
			this.dtpPrevisaoI.CustomFormat = "dd/MM/yyyy";
			this.dtpPrevisaoI.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpPrevisaoI.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpPrevisaoI.Location = new System.Drawing.Point(115, 120);
			this.dtpPrevisaoI.Name = "dtpPrevisaoI";
			this.dtpPrevisaoI.ShowCheckBox = true;
			this.dtpPrevisaoI.Size = new System.Drawing.Size(110, 20);
			this.dtpPrevisaoI.TabIndex = 60;
			// 
			// btnOrigem
			// 
			this.btnOrigem.Image = ((System.Drawing.Image)(resources.GetObject("btnOrigem.Image")));
			this.btnOrigem.Location = new System.Drawing.Point(267, 65);
			this.btnOrigem.Name = "btnOrigem";
			this.btnOrigem.Size = new System.Drawing.Size(36, 23);
			this.btnOrigem.TabIndex = 44;
			this.btnOrigem.UseVisualStyleBackColor = true;
			this.btnOrigem.Click += new System.EventHandler(this.BtnOrigemClick);
			// 
			// edtOrigem
			// 
			this.edtOrigem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtOrigem.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtOrigem.Location = new System.Drawing.Point(115, 67);
			this.edtOrigem.MaxLength = 50;
			this.edtOrigem.Name = "edtOrigem";
			this.edtOrigem.ReadOnly = true;
			this.edtOrigem.Size = new System.Drawing.Size(146, 20);
			this.edtOrigem.TabIndex = 42;
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label6.Location = new System.Drawing.Point(25, 66);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 20);
			this.label6.TabIndex = 191;
			this.label6.Text = "Origem";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dgvSituacoes
			// 
			this.dgvSituacoes.AllowUserToAddRows = false;
			this.dgvSituacoes.AllowUserToDeleteRows = false;
			this.dgvSituacoes.AllowUserToResizeColumns = false;
			this.dgvSituacoes.AllowUserToResizeRows = false;
			this.dgvSituacoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvSituacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvSituacoes.DefaultCellStyle = dataGridViewCellStyle1;
			this.dgvSituacoes.Location = new System.Drawing.Point(115, 149);
			this.dgvSituacoes.MultiSelect = false;
			this.dgvSituacoes.Name = "dgvSituacoes";
			this.dgvSituacoes.RowHeadersVisible = false;
			this.dgvSituacoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSituacoes.Size = new System.Drawing.Size(246, 90);
			this.dgvSituacoes.TabIndex = 80;
			// 
			// chkTodas
			// 
			this.chkTodas.Location = new System.Drawing.Point(217, 244);
			this.chkTodas.Name = "chkTodas";
			this.chkTodas.Size = new System.Drawing.Size(144, 24);
			this.chkTodas.TabIndex = 81;
			this.chkTodas.Text = "Marca/Desmarca Todas";
			this.chkTodas.UseVisualStyleBackColor = true;
			this.chkTodas.CheckedChanged += new System.EventHandler(this.ChkTodasCheckedChanged);
			// 
			// Filtro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(505, 344);
			this.Controls.Add(this.cbxUsuarios);
			this.Controls.Add(this.lblVendedor);
			this.Name = "Filtro";
			this.Text = "Filtro";
			this.Load += new System.EventHandler(this.FiltroLoad);
			this.Controls.SetChildIndex(this.lblVendedor, 0);
			this.Controls.SetChildIndex(this.cbxUsuarios, 0);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.btnConfirma, 0);
			this.Controls.SetChildIndex(this.btnCancela, 0);
			this.Controls.SetChildIndex(this.btnLimpa, 0);
			this.Controls.SetChildIndex(this.lblTitulo, 0);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvSituacoes)).EndInit();
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.CheckBox chkTodas;
		private System.Windows.Forms.DateTimePicker dtpPrevisaoI;
		private System.Windows.Forms.DateTimePicker dtpPrevisaoF;
		public System.Windows.Forms.DataGridView dgvSituacoes;
		private System.Windows.Forms.Button btnConsultor;
		private System.Windows.Forms.Button btnCliente;
		private System.Windows.Forms.Label label6;
		public System.Windows.Forms.TextBox edtOrigem;
		private System.Windows.Forms.Button btnOrigem;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label9;
		public System.Windows.Forms.ComboBox cbxVendedores;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblVendedor;
		public System.Windows.Forms.ComboBox cbxUsuarios;
	}
}
