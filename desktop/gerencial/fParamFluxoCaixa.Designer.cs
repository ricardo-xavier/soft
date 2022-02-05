/*
 * Criado por SharpDevelop.
 * Usuário: Ricardo
 * Data: 27/06/2010
 * Hora: 20:49
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace gerencial
{
	partial class fParamFluxoCaixa
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
			this.edtTitulo = new System.Windows.Forms.TextBox();
			this.lblItem = new System.Windows.Forms.Label();
			this.btnCancela = new System.Windows.Forms.Button();
			this.btnConfirma = new System.Windows.Forms.Button();
			this.gbxPeriodo = new System.Windows.Forms.GroupBox();
			this.chkVencimento = new System.Windows.Forms.CheckBox();
			this.label11 = new System.Windows.Forms.Label();
			this.dtpDataF = new System.Windows.Forms.DateTimePicker();
			this.label14 = new System.Windows.Forms.Label();
			this.dtpDataI = new System.Windows.Forms.DateTimePicker();
			this.edtValor = new System.Windows.Forms.TextBox();
			this.lblValor = new System.Windows.Forms.Label();
			this.chkPagos = new System.Windows.Forms.CheckBox();
			this.chkAbertos = new System.Windows.Forms.CheckBox();
			this.gbxPeriodo.SuspendLayout();
			this.SuspendLayout();
			// 
			// edtTitulo
			// 
			this.edtTitulo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtTitulo.Location = new System.Drawing.Point(100, 10);
			this.edtTitulo.MaxLength = 50;
			this.edtTitulo.Name = "edtTitulo";
			this.edtTitulo.Size = new System.Drawing.Size(356, 20);
			this.edtTitulo.TabIndex = 0;
			this.edtTitulo.Text = "Fluxo de Caixa";
			// 
			// lblItem
			// 
			this.lblItem.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblItem.Location = new System.Drawing.Point(15, 10);
			this.lblItem.Name = "lblItem";
			this.lblItem.Size = new System.Drawing.Size(80, 20);
			this.lblItem.TabIndex = 128;
			this.lblItem.Text = "Título";
			this.lblItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(356, 175);
			this.btnCancela.Name = "btnCancela";
			this.btnCancela.Size = new System.Drawing.Size(100, 25);
			this.btnCancela.TabIndex = 8;
			this.btnCancela.Text = "C&ancela";
			this.btnCancela.UseVisualStyleBackColor = true;
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(250, 175);
			this.btnConfirma.Name = "btnConfirma";
			this.btnConfirma.Size = new System.Drawing.Size(100, 25);
			this.btnConfirma.TabIndex = 6;
			this.btnConfirma.Text = "&Confirma";
			this.btnConfirma.UseVisualStyleBackColor = true;
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// gbxPeriodo
			// 
			this.gbxPeriodo.Controls.Add(this.chkVencimento);
			this.gbxPeriodo.Controls.Add(this.label11);
			this.gbxPeriodo.Controls.Add(this.dtpDataF);
			this.gbxPeriodo.Controls.Add(this.label14);
			this.gbxPeriodo.Controls.Add(this.dtpDataI);
			this.gbxPeriodo.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.gbxPeriodo.Location = new System.Drawing.Point(15, 75);
			this.gbxPeriodo.Name = "gbxPeriodo";
			this.gbxPeriodo.Size = new System.Drawing.Size(368, 83);
			this.gbxPeriodo.TabIndex = 4;
			this.gbxPeriodo.TabStop = false;
			this.gbxPeriodo.Text = "Período";
			// 
			// chkVencimento
			// 
			this.chkVencimento.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkVencimento.Location = new System.Drawing.Point(85, 45);
			this.chkVencimento.Name = "chkVencimento";
			this.chkVencimento.Size = new System.Drawing.Size(260, 24);
			this.chkVencimento.TabIndex = 135;
			this.chkVencimento.Text = "Por data de vencimento(lançamentos futuros)";
			this.chkVencimento.UseVisualStyleBackColor = true;
			this.chkVencimento.Visible = false;
			// 
			// label11
			// 
			this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label11.Location = new System.Drawing.Point(200, 20);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(25, 20);
			this.label11.TabIndex = 80;
			this.label11.Text = "até";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpDataF
			// 
			this.dtpDataF.Checked = false;
			this.dtpDataF.CustomFormat = "dd/MM/yyyy";
			this.dtpDataF.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpDataF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDataF.Location = new System.Drawing.Point(235, 20);
			this.dtpDataF.Name = "dtpDataF";
			this.dtpDataF.ShowCheckBox = true;
			this.dtpDataF.Size = new System.Drawing.Size(110, 20);
			this.dtpDataF.TabIndex = 2;
			// 
			// label14
			// 
			this.label14.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label14.Location = new System.Drawing.Point(5, 20);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(70, 20);
			this.label14.TabIndex = 76;
			this.label14.Text = "De";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpDataI
			// 
			this.dtpDataI.Checked = false;
			this.dtpDataI.CustomFormat = "dd/MM/yyyy";
			this.dtpDataI.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpDataI.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDataI.Location = new System.Drawing.Point(85, 19);
			this.dtpDataI.Name = "dtpDataI";
			this.dtpDataI.ShowCheckBox = true;
			this.dtpDataI.Size = new System.Drawing.Size(110, 20);
			this.dtpDataI.TabIndex = 0;
			// 
			// edtValor
			// 
			this.edtValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtValor.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtValor.Location = new System.Drawing.Point(100, 40);
			this.edtValor.MaxLength = 50;
			this.edtValor.Name = "edtValor";
			this.edtValor.Size = new System.Drawing.Size(90, 20);
			this.edtValor.TabIndex = 2;
			this.edtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lblValor
			// 
			this.lblValor.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblValor.Location = new System.Drawing.Point(15, 40);
			this.lblValor.Name = "lblValor";
			this.lblValor.Size = new System.Drawing.Size(80, 20);
			this.lblValor.TabIndex = 133;
			this.lblValor.Text = "Valor Inicial";
			this.lblValor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// chkPagos
			// 
			this.chkPagos.Checked = true;
			this.chkPagos.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkPagos.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkPagos.Location = new System.Drawing.Point(100, 40);
			this.chkPagos.Name = "chkPagos";
			this.chkPagos.Size = new System.Drawing.Size(69, 24);
			this.chkPagos.TabIndex = 134;
			this.chkPagos.Text = "Pagos";
			this.chkPagos.UseVisualStyleBackColor = true;
			this.chkPagos.Visible = false;
			// 
			// chkAbertos
			// 
			this.chkAbertos.Checked = true;
			this.chkAbertos.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkAbertos.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkAbertos.Location = new System.Drawing.Point(175, 40);
			this.chkAbertos.Name = "chkAbertos";
			this.chkAbertos.Size = new System.Drawing.Size(104, 24);
			this.chkAbertos.TabIndex = 135;
			this.chkAbertos.Text = "Abertos";
			this.chkAbertos.UseVisualStyleBackColor = true;
			this.chkAbertos.Visible = false;
			// 
			// fParamFluxoCaixa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(472, 212);
			this.Controls.Add(this.chkAbertos);
			this.Controls.Add(this.chkPagos);
			this.Controls.Add(this.edtValor);
			this.Controls.Add(this.lblValor);
			this.Controls.Add(this.gbxPeriodo);
			this.Controls.Add(this.btnCancela);
			this.Controls.Add(this.btnConfirma);
			this.Controls.Add(this.edtTitulo);
			this.Controls.Add(this.lblItem);
			this.Name = "fParamFluxoCaixa";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Parâmetros para Impressão do Fluxo de Caixa";
			this.gbxPeriodo.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		public System.Windows.Forms.CheckBox chkAbertos;
		public System.Windows.Forms.CheckBox chkPagos;
		public System.Windows.Forms.Label lblValor;
		public System.Windows.Forms.TextBox edtValor;
		private System.Windows.Forms.DateTimePicker dtpDataI;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.DateTimePicker dtpDataF;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.GroupBox gbxPeriodo;
		public System.Windows.Forms.Button btnConfirma;
		public System.Windows.Forms.Button btnCancela;
		public System.Windows.Forms.Label lblItem;
		public System.Windows.Forms.TextBox edtTitulo;
		public System.Windows.Forms.CheckBox chkVencimento;
	}
}
