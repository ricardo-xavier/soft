/*
 * Usuário: Ricardo
 * Data: 17/04/2008
 * Hora: 23:29
 * 
 */
namespace basico
{
	partial class frmConParceiros
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
			this.grpPessoa = new System.Windows.Forms.GroupBox();
			this.ckbJuridica = new System.Windows.Forms.CheckBox();
			this.ckbFisica = new System.Windows.Forms.CheckBox();
			this.grpTipo = new System.Windows.Forms.GroupBox();
			this.ckbConsultor = new System.Windows.Forms.CheckBox();
			this.ckbFornecedor = new System.Windows.Forms.CheckBox();
			this.ckbCliente = new System.Windows.Forms.CheckBox();
			this.panel1.SuspendLayout();
			this.grpPessoa.SuspendLayout();
			this.grpTipo.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblDescricao
			// 
			this.lblDescricao.Text = "Nome";
			// 
			// edtCodigo
			// 
			this.edtCodigo.MaxLength = 20;
			this.edtCodigo.Size = new System.Drawing.Size(146, 20);
			// 
			// lblTitulo
			// 
			this.lblTitulo.Text = "Seleção de Parceiros";
			// 
			// btnLimpa
			// 
			this.btnLimpa.Click += new System.EventHandler(this.BtnLimpaClick);
			// 
			// btnCancela
			// 
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
			// 
			// btnConfirma
			// 
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.grpTipo);
			this.panel1.Controls.Add(this.grpPessoa);
			this.panel1.Size = new System.Drawing.Size(364, 184);
			this.panel1.Controls.SetChildIndex(this.grpPessoa, 0);
			this.panel1.Controls.SetChildIndex(this.lblCodigo, 0);
			this.panel1.Controls.SetChildIndex(this.lblDescricao, 0);
			this.panel1.Controls.SetChildIndex(this.edtCodigo, 0);
			this.panel1.Controls.SetChildIndex(this.edtDescricao, 0);
			this.panel1.Controls.SetChildIndex(this.grpTipo, 0);
			// 
			// grpPessoa
			// 
			this.grpPessoa.Controls.Add(this.ckbJuridica);
			this.grpPessoa.Controls.Add(this.ckbFisica);
			this.grpPessoa.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.grpPessoa.Location = new System.Drawing.Point(80, 70);
			this.grpPessoa.Name = "grpPessoa";
			this.grpPessoa.Size = new System.Drawing.Size(254, 43);
			this.grpPessoa.TabIndex = 8;
			this.grpPessoa.TabStop = false;
			this.grpPessoa.Text = "Tipo Pessoa";
			this.grpPessoa.Enter += new System.EventHandler(this.GrpPessoaEnter);
			// 
			// ckbJuridica
			// 
			this.ckbJuridica.Checked = true;
			this.ckbJuridica.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ckbJuridica.Location = new System.Drawing.Point(84, 15);
			this.ckbJuridica.Name = "ckbJuridica";
			this.ckbJuridica.Size = new System.Drawing.Size(70, 22);
			this.ckbJuridica.TabIndex = 2;
			this.ckbJuridica.Text = "Jurídica";
			this.ckbJuridica.UseVisualStyleBackColor = true;
			// 
			// ckbFisica
			// 
			this.ckbFisica.Checked = true;
			this.ckbFisica.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ckbFisica.Location = new System.Drawing.Point(10, 15);
			this.ckbFisica.Name = "ckbFisica";
			this.ckbFisica.Size = new System.Drawing.Size(70, 22);
			this.ckbFisica.TabIndex = 1;
			this.ckbFisica.Text = "Física";
			this.ckbFisica.UseVisualStyleBackColor = true;
			// 
			// grpTipo
			// 
			this.grpTipo.Controls.Add(this.ckbConsultor);
			this.grpTipo.Controls.Add(this.ckbFornecedor);
			this.grpTipo.Controls.Add(this.ckbCliente);
			this.grpTipo.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.grpTipo.Location = new System.Drawing.Point(80, 120);
			this.grpTipo.Name = "grpTipo";
			this.grpTipo.Size = new System.Drawing.Size(254, 43);
			this.grpTipo.TabIndex = 9;
			this.grpTipo.TabStop = false;
			this.grpTipo.Text = "Papel";
			// 
			// ckbConsultor
			// 
			this.ckbConsultor.Checked = true;
			this.ckbConsultor.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ckbConsultor.Location = new System.Drawing.Point(170, 15);
			this.ckbConsultor.Name = "ckbConsultor";
			this.ckbConsultor.Size = new System.Drawing.Size(70, 22);
			this.ckbConsultor.TabIndex = 2;
			this.ckbConsultor.Text = "Consultor";
			this.ckbConsultor.UseVisualStyleBackColor = true;
			// 
			// ckbFornecedor
			// 
			this.ckbFornecedor.Checked = true;
			this.ckbFornecedor.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ckbFornecedor.Location = new System.Drawing.Point(84, 15);
			this.ckbFornecedor.Name = "ckbFornecedor";
			this.ckbFornecedor.Size = new System.Drawing.Size(80, 22);
			this.ckbFornecedor.TabIndex = 1;
			this.ckbFornecedor.Text = "Fornecedor";
			this.ckbFornecedor.UseVisualStyleBackColor = true;
			// 
			// ckbCliente
			// 
			this.ckbCliente.Checked = true;
			this.ckbCliente.CheckState = System.Windows.Forms.CheckState.Checked;
			this.ckbCliente.Location = new System.Drawing.Point(10, 15);
			this.ckbCliente.Name = "ckbCliente";
			this.ckbCliente.Size = new System.Drawing.Size(70, 22);
			this.ckbCliente.TabIndex = 0;
			this.ckbCliente.Text = "Cliente";
			this.ckbCliente.UseVisualStyleBackColor = true;
			// 
			// frmConParceiros
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(510, 246);
			this.Name = "frmConParceiros";
			this.Text = "Seleção de Parceiros";
			this.Load += new System.EventHandler(this.FrmConParceirosLoad);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.grpPessoa.ResumeLayout(false);
			this.grpTipo.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.CheckBox ckbFisica;
		private System.Windows.Forms.CheckBox ckbJuridica;
		public System.Windows.Forms.CheckBox ckbCliente;
		public System.Windows.Forms.CheckBox ckbFornecedor;
		public System.Windows.Forms.CheckBox ckbConsultor;
		private System.Windows.Forms.GroupBox grpTipo;
		private System.Windows.Forms.GroupBox grpPessoa;
	}
}
