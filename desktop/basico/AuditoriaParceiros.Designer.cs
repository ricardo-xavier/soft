/*
 * Created by SharpDevelop.
 * User: Ricardo
 * Date: 12/07/2020
 * Time: 11:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace basico
{
	partial class AuditoriaParceiros
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblInsEst;
		public System.Windows.Forms.DataGridView dgvCpfCnpj;
		public System.Windows.Forms.DataGridView dgvFones;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSair;
		
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
			this.lblInsEst = new System.Windows.Forms.Label();
			this.dgvCpfCnpj = new System.Windows.Forms.DataGridView();
			this.dgvFones = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSair = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvCpfCnpj)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvFones)).BeginInit();
			this.SuspendLayout();
			// 
			// lblInsEst
			// 
			this.lblInsEst.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblInsEst.Location = new System.Drawing.Point(12, 6);
			this.lblInsEst.Name = "lblInsEst";
			this.lblInsEst.Size = new System.Drawing.Size(227, 20);
			this.lblInsEst.TabIndex = 76;
			this.lblInsEst.Text = "Parceiros com CPF/CNPJ repetido";
			this.lblInsEst.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dgvCpfCnpj
			// 
			this.dgvCpfCnpj.AllowUserToAddRows = false;
			this.dgvCpfCnpj.AllowUserToDeleteRows = false;
			this.dgvCpfCnpj.AllowUserToResizeColumns = false;
			this.dgvCpfCnpj.AllowUserToResizeRows = false;
			this.dgvCpfCnpj.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvCpfCnpj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCpfCnpj.Location = new System.Drawing.Point(12, 29);
			this.dgvCpfCnpj.MultiSelect = false;
			this.dgvCpfCnpj.Name = "dgvCpfCnpj";
			this.dgvCpfCnpj.ReadOnly = true;
			this.dgvCpfCnpj.RowHeadersVisible = false;
			this.dgvCpfCnpj.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCpfCnpj.Size = new System.Drawing.Size(680, 246);
			this.dgvCpfCnpj.TabIndex = 77;
			// 
			// dgvFones
			// 
			this.dgvFones.AllowUserToAddRows = false;
			this.dgvFones.AllowUserToDeleteRows = false;
			this.dgvFones.AllowUserToResizeColumns = false;
			this.dgvFones.AllowUserToResizeRows = false;
			this.dgvFones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvFones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvFones.Location = new System.Drawing.Point(12, 307);
			this.dgvFones.MultiSelect = false;
			this.dgvFones.Name = "dgvFones";
			this.dgvFones.ReadOnly = true;
			this.dgvFones.RowHeadersVisible = false;
			this.dgvFones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvFones.Size = new System.Drawing.Size(880, 246);
			this.dgvFones.TabIndex = 79;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(12, 284);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(227, 20);
			this.label1.TabIndex = 78;
			this.label1.Text = "Parceiros com telefone repetido";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnSair
			// 
			this.btnSair.Location = new System.Drawing.Point(792, 29);
			this.btnSair.Name = "btnSair";
			this.btnSair.Size = new System.Drawing.Size(100, 25);
			this.btnSair.TabIndex = 80;
			this.btnSair.Text = "&Fecha";
			this.btnSair.UseVisualStyleBackColor = true;
			this.btnSair.Click += new System.EventHandler(this.BtnSairClick);
			// 
			// AuditoriaParceiros
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(904, 564);
			this.Controls.Add(this.btnSair);
			this.Controls.Add(this.dgvFones);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvCpfCnpj);
			this.Controls.Add(this.lblInsEst);
			this.Name = "AuditoriaParceiros";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AuditoriaParceiros";
			this.Load += new System.EventHandler(this.AuditoriaParceirosLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgvCpfCnpj)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvFones)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
