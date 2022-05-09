/*
 * Usuário: Ricardo
 * Data: 22/03/2008
 * Hora: 0:40
 * 
 */
namespace cpd
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
			this.mnuCPD = new System.Windows.Forms.MenuStrip();
			this.mniArquivo = new System.Windows.Forms.ToolStripMenuItem();
			this.mniSair = new System.Windows.Forms.ToolStripMenuItem();
			this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mniUsuarios = new System.Windows.Forms.ToolStripMenuItem();
			this.mniFiliais = new System.Windows.Forms.ToolStripMenuItem();
			this.mniUtilitarios = new System.Windows.Forms.ToolStripMenuItem();
			this.mniControleAcesso = new System.Windows.Forms.ToolStripMenuItem();
			this.mniAjuda = new System.Windows.Forms.ToolStripMenuItem();
			this.mniSobre = new System.Windows.Forms.ToolStripMenuItem();
			this.mensagensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.imgSoftplace)).BeginInit();
			this.mnuCPD.SuspendLayout();
			this.SuspendLayout();
			// 
			// mnuCPD
			// 
			this.mnuCPD.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.mniArquivo,
			this.cadastrosToolStripMenuItem,
			this.mniUtilitarios,
			this.mniAjuda});
			this.mnuCPD.Location = new System.Drawing.Point(0, 0);
			this.mnuCPD.Name = "mnuCPD";
			this.mnuCPD.Size = new System.Drawing.Size(584, 24);
			this.mnuCPD.TabIndex = 1;
			this.mnuCPD.Text = "mnuCPD";
			// 
			// mniArquivo
			// 
			this.mniArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.mniSair});
			this.mniArquivo.Name = "mniArquivo";
			this.mniArquivo.Size = new System.Drawing.Size(61, 20);
			this.mniArquivo.Text = "&Arquivo";
			// 
			// mniSair
			// 
			this.mniSair.Name = "mniSair";
			this.mniSair.Size = new System.Drawing.Size(93, 22);
			this.mniSair.Text = "&Sair";
			this.mniSair.Click += new System.EventHandler(this.MniSairClick);
			// 
			// cadastrosToolStripMenuItem
			// 
			this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.mniUsuarios,
			this.mniFiliais});
			this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
			this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
			this.cadastrosToolStripMenuItem.Text = "&Cadastros";
			// 
			// mniUsuarios
			// 
			this.mniUsuarios.Name = "mniUsuarios";
			this.mniUsuarios.Size = new System.Drawing.Size(119, 22);
			this.mniUsuarios.Text = "&Usuários";
			this.mniUsuarios.Click += new System.EventHandler(this.MniUsuariosClick);
			// 
			// mniFiliais
			// 
			this.mniFiliais.Name = "mniFiliais";
			this.mniFiliais.Size = new System.Drawing.Size(119, 22);
			this.mniFiliais.Text = "&Filiais";
			this.mniFiliais.Click += new System.EventHandler(this.MniFiliaisClick);
			// 
			// mniUtilitarios
			// 
			this.mniUtilitarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.mniControleAcesso,
			this.mensagensToolStripMenuItem});
			this.mniUtilitarios.Name = "mniUtilitarios";
			this.mniUtilitarios.Size = new System.Drawing.Size(69, 20);
			this.mniUtilitarios.Text = "&Utilitários";
			// 
			// mniControleAcesso
			// 
			this.mniControleAcesso.Name = "mniControleAcesso";
			this.mniControleAcesso.Size = new System.Drawing.Size(176, 22);
			this.mniControleAcesso.Text = "&Controle de Acesso";
			this.mniControleAcesso.Click += new System.EventHandler(this.MniControleAcessoClick);
			// 
			// mniAjuda
			// 
			this.mniAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.mniSobre});
			this.mniAjuda.Name = "mniAjuda";
			this.mniAjuda.Size = new System.Drawing.Size(50, 20);
			this.mniAjuda.Text = "Ajuda";
			// 
			// mniSobre
			// 
			this.mniSobre.Name = "mniSobre";
			this.mniSobre.Size = new System.Drawing.Size(104, 22);
			this.mniSobre.Text = "Sobre";
			this.mniSobre.Click += new System.EventHandler(this.MniSobreClick);
			// 
			// mensagensToolStripMenuItem
			// 
			this.mensagensToolStripMenuItem.Name = "mensagensToolStripMenuItem";
			this.mensagensToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.mensagensToolStripMenuItem.Text = "Mensagens";
			this.mensagensToolStripMenuItem.Click += new System.EventHandler(this.MensagensToolStripMenuItemClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.ClientSize = new System.Drawing.Size(584, 414);
			this.Controls.Add(this.mnuCPD);
			this.Name = "MainForm";
			this.Text = "Sistema SOFT - CPD - v2.1.1 (03/01/21)";
			this.Controls.SetChildIndex(this.imgSoftplace, 0);
			this.Controls.SetChildIndex(this.mnuCPD, 0);
			((System.ComponentModel.ISupportInitialize)(this.imgSoftplace)).EndInit();
			this.mnuCPD.ResumeLayout(false);
			this.mnuCPD.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.MenuStrip mnuCPD;
		private System.Windows.Forms.ToolStripMenuItem mniSobre;
		private System.Windows.Forms.ToolStripMenuItem mniArquivo;
		private System.Windows.Forms.ToolStripMenuItem mniSair;
		private System.Windows.Forms.ToolStripMenuItem mniAjuda;
		private System.Windows.Forms.ToolStripMenuItem mniUsuarios;
		private System.Windows.Forms.ToolStripMenuItem mniFiliais;
		private System.Windows.Forms.ToolStripMenuItem mniUtilitarios;
		private System.Windows.Forms.ToolStripMenuItem mniControleAcesso;
		private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mensagensToolStripMenuItem;
	}
}
