/*
 * Usuário: Ricardo
 * Data: 27/04/2008
 * Hora: 19:44
 * 
 */
namespace basico
{
	partial class frmCadTabelas
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadTabelas));
			this.lblParceiro = new System.Windows.Forms.Label();
			this.edtParceiro = new System.Windows.Forms.TextBox();
			this.btnParceiros = new System.Windows.Forms.Button();
			this.btnPrecos = new System.Windows.Forms.Button();
			this.ckbDefault = new System.Windows.Forms.CheckBox();
			this.chkAtivo = new System.Windows.Forms.CheckBox();
			this.chkAtivos = new System.Windows.Forms.CheckBox();
			this.pnlEdicao.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnUp
			// 
			this.btnUp.Location = new System.Drawing.Point(582, 12);
			// 
			// btnDown
			// 
			this.btnDown.Location = new System.Drawing.Point(540, 12);
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(532, 141);
			this.btnCancela.TabIndex = 6;
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(422, 141);
			this.btnConfirma.TabIndex = 5;
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// edtCodigo
			// 
			this.edtCodigo.Location = new System.Drawing.Point(115, 40);
			this.edtCodigo.MaxLength = 20;
			this.edtCodigo.Size = new System.Drawing.Size(146, 20);
			// 
			// edtDescricao
			// 
			this.edtDescricao.Location = new System.Drawing.Point(115, 70);
			// 
			// lblCodigo
			// 
			this.lblCodigo.Location = new System.Drawing.Point(10, 40);
			// 
			// lblDescricao
			// 
			this.lblDescricao.Location = new System.Drawing.Point(10, 70);
			// 
			// pnlEdicao
			// 
			this.pnlEdicao.Controls.Add(this.chkAtivo);
			this.pnlEdicao.Controls.Add(this.ckbDefault);
			this.pnlEdicao.Controls.Add(this.btnParceiros);
			this.pnlEdicao.Controls.Add(this.edtParceiro);
			this.pnlEdicao.Controls.Add(this.lblParceiro);
			this.pnlEdicao.Location = new System.Drawing.Point(9, 226);
			this.pnlEdicao.Size = new System.Drawing.Size(639, 173);
			this.pnlEdicao.Controls.SetChildIndex(this.lblCodigo, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblDescricao, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtCodigo, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtDescricao, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.btnConfirma, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.btnCancela, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblParceiro, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtParceiro, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.btnParceiros, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.ckbDefault, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.chkAtivo, 0);
			// 
			// btnFecha
			// 
			this.btnFecha.Location = new System.Drawing.Point(543, 132);
			// 
			// btnAltera
			// 
			this.btnAltera.Location = new System.Drawing.Point(543, 102);
			this.btnAltera.Click += new System.EventHandler(this.BtnAlteraClick);
			// 
			// btnExclui
			// 
			this.btnExclui.Location = new System.Drawing.Point(543, 72);
			this.btnExclui.Click += new System.EventHandler(this.BtnExcluiClick);
			// 
			// btnInclui
			// 
			this.btnInclui.Location = new System.Drawing.Point(543, 42);
			this.btnInclui.Click += new System.EventHandler(this.BtnIncluiClick);
			// 
			// lblParceiro
			// 
			this.lblParceiro.ForeColor = System.Drawing.Color.Red;
			this.lblParceiro.Location = new System.Drawing.Point(10, 10);
			this.lblParceiro.Name = "lblParceiro";
			this.lblParceiro.Size = new System.Drawing.Size(100, 20);
			this.lblParceiro.TabIndex = 74;
			this.lblParceiro.Text = "Parceiro";
			this.lblParceiro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtParceiro
			// 
			this.edtParceiro.BackColor = System.Drawing.SystemColors.Info;
			this.edtParceiro.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtParceiro.Location = new System.Drawing.Point(115, 10);
			this.edtParceiro.MaxLength = 50;
			this.edtParceiro.Name = "edtParceiro";
			this.edtParceiro.Size = new System.Drawing.Size(146, 20);
			this.edtParceiro.TabIndex = 0;
			// 
			// btnParceiros
			// 
			this.btnParceiros.Image = ((System.Drawing.Image)(resources.GetObject("btnParceiros.Image")));
			this.btnParceiros.Location = new System.Drawing.Point(270, 9);
			this.btnParceiros.Name = "btnParceiros";
			this.btnParceiros.Size = new System.Drawing.Size(36, 23);
			this.btnParceiros.TabIndex = 1;
			this.btnParceiros.UseVisualStyleBackColor = true;
			this.btnParceiros.Click += new System.EventHandler(this.BtnParceirosClick);
			// 
			// btnPrecos
			// 
			this.btnPrecos.Location = new System.Drawing.Point(543, 162);
			this.btnPrecos.Name = "btnPrecos";
			this.btnPrecos.Size = new System.Drawing.Size(100, 25);
			this.btnPrecos.TabIndex = 8;
			this.btnPrecos.Text = "Preços";
			this.btnPrecos.UseVisualStyleBackColor = true;
			this.btnPrecos.Click += new System.EventHandler(this.BtnPrecosClick);
			// 
			// ckbDefault
			// 
			this.ckbDefault.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.ckbDefault.Location = new System.Drawing.Point(60, 100);
			this.ckbDefault.Name = "ckbDefault";
			this.ckbDefault.Size = new System.Drawing.Size(100, 22);
			this.ckbDefault.TabIndex = 4;
			this.ckbDefault.Text = "Default";
			this.ckbDefault.UseVisualStyleBackColor = true;
			// 
			// chkAtivo
			// 
			this.chkAtivo.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkAtivo.Location = new System.Drawing.Point(140, 100);
			this.chkAtivo.Name = "chkAtivo";
			this.chkAtivo.Size = new System.Drawing.Size(100, 22);
			this.chkAtivo.TabIndex = 75;
			this.chkAtivo.Text = "Ativa";
			this.chkAtivo.UseVisualStyleBackColor = true;
			// 
			// chkAtivos
			// 
			this.chkAtivos.Checked = true;
			this.chkAtivos.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkAtivos.Location = new System.Drawing.Point(12, 196);
			this.chkAtivos.Name = "chkAtivos";
			this.chkAtivos.Size = new System.Drawing.Size(162, 24);
			this.chkAtivos.TabIndex = 10;
			this.chkAtivos.Text = "Mostrar somente ativas";
			this.chkAtivos.UseVisualStyleBackColor = true;
			this.chkAtivos.CheckedChanged += new System.EventHandler(this.ChkAtivosCheckedChanged);
			// 
			// frmCadTabelas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(660, 406);
			this.Controls.Add(this.chkAtivos);
			this.Controls.Add(this.btnPrecos);
			this.Name = "frmCadTabelas";
			this.Text = "Cadastros Básicos - Tabelas de Preços";
			this.Load += new System.EventHandler(this.FrmCadTabelasLoad);
			this.Controls.SetChildIndex(this.btnUp, 0);
			this.Controls.SetChildIndex(this.btnDown, 0);
			this.Controls.SetChildIndex(this.btnInclui, 0);
			this.Controls.SetChildIndex(this.btnExclui, 0);
			this.Controls.SetChildIndex(this.btnAltera, 0);
			this.Controls.SetChildIndex(this.btnFecha, 0);
			this.Controls.SetChildIndex(this.pnlEdicao, 0);
			this.Controls.SetChildIndex(this.edtLocaliza, 0);
			this.Controls.SetChildIndex(this.btnLocaliza, 0);
			this.Controls.SetChildIndex(this.btnPrecos, 0);
			this.Controls.SetChildIndex(this.chkAtivos, 0);
			this.pnlEdicao.ResumeLayout(false);
			this.pnlEdicao.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.CheckBox chkAtivo;
		private System.Windows.Forms.CheckBox ckbDefault;
		private System.Windows.Forms.Button btnPrecos;
		private System.Windows.Forms.Label lblParceiro;
		private System.Windows.Forms.TextBox edtParceiro;
		private System.Windows.Forms.Button btnParceiros;
		private System.Windows.Forms.CheckBox chkAtivos;
	}
}
