/*
 * Usuário: Ricardo
 * Data: 02/04/2008
 * Hora: 22:47
 * 
 */
namespace templates
{
	partial class MenuPagar
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPagar));
			this.barraStatus = new System.Windows.Forms.StatusStrip();
			this.stUsuario = new System.Windows.Forms.ToolStripStatusLabel();
			this.stFilial = new System.Windows.Forms.ToolStripStatusLabel();
			this.imgSoftplace = new System.Windows.Forms.PictureBox();
			this.barraStatus.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgSoftplace)).BeginInit();
			this.SuspendLayout();
			// 
			// barraStatus
			// 
			this.barraStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.stUsuario,
			this.stFilial});
			this.barraStatus.Location = new System.Drawing.Point(0, 392);
			this.barraStatus.Name = "barraStatus";
			this.barraStatus.Size = new System.Drawing.Size(584, 22);
			this.barraStatus.TabIndex = 1;
			// 
			// stUsuario
			// 
			this.stUsuario.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
			this.stUsuario.Margin = new System.Windows.Forms.Padding(0);
			this.stUsuario.Name = "stUsuario";
			this.stUsuario.Size = new System.Drawing.Size(4, 22);
			// 
			// stFilial
			// 
			this.stFilial.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
			this.stFilial.Name = "stFilial";
			this.stFilial.Size = new System.Drawing.Size(4, 17);
			// 
			// imgSoftplace
			// 
			this.imgSoftplace.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imgSoftplace.ErrorImage")));
			this.imgSoftplace.Location = new System.Drawing.Point(409, 29);
			this.imgSoftplace.Name = "imgSoftplace";
			this.imgSoftplace.Size = new System.Drawing.Size(175, 160);
			this.imgSoftplace.TabIndex = 2;
			this.imgSoftplace.TabStop = false;
			// 
			// MenuPagar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 414);
			this.Controls.Add(this.imgSoftplace);
			this.Controls.Add(this.barraStatus);
			this.Name = "MenuPagar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sistema SOFT ";
			this.Load += new System.EventHandler(this.TMenuLoad);
			this.Shown += new System.EventHandler(this.TMenuShown);
			this.barraStatus.ResumeLayout(false);
			this.barraStatus.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgSoftplace)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		public System.Windows.Forms.PictureBox imgSoftplace;
		private System.Windows.Forms.ToolStripStatusLabel stFilial;
		private System.Windows.Forms.ToolStripStatusLabel stUsuario;
		private System.Windows.Forms.StatusStrip barraStatus;
	}
}
