/*
 * Usuário: Ricardo
 * Data: 02/04/2008
 * Hora: 23:43
 * 
 */
namespace templates
{
	partial class tSobre
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tSobre));
			this.lblProjeto = new System.Windows.Forms.Label();
			this.lblSistema = new System.Windows.Forms.Label();
			this.lblVersao = new System.Windows.Forms.Label();
			this.btnOK = new System.Windows.Forms.Button();
			this.imgSoftPlace = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.imgSoftPlace)).BeginInit();
			this.SuspendLayout();
			// 
			// lblProjeto
			// 
			this.lblProjeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProjeto.Location = new System.Drawing.Point(215, 9);
			this.lblProjeto.Name = "lblProjeto";
			this.lblProjeto.Size = new System.Drawing.Size(135, 25);
			this.lblProjeto.TabIndex = 0;
			this.lblProjeto.Text = "Sistema SOFT";
			// 
			// lblSistema
			// 
			this.lblSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSistema.Location = new System.Drawing.Point(200, 46);
			this.lblSistema.Name = "lblSistema";
			this.lblSistema.Size = new System.Drawing.Size(250, 25);
			this.lblSistema.TabIndex = 1;
			this.lblSistema.Text = "Módulo";
			// 
			// lblVersao
			// 
			this.lblVersao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVersao.Location = new System.Drawing.Point(200, 71);
			this.lblVersao.Name = "lblVersao";
			this.lblVersao.Size = new System.Drawing.Size(250, 25);
			this.lblVersao.TabIndex = 2;
			this.lblVersao.Text = "Versão";
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(350, 150);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(100, 25);
			this.btnOK.TabIndex = 3;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.BtnOKClick);
			// 
			// imgSoftPlace
			// 
			this.imgSoftPlace.Image = ((System.Drawing.Image)(resources.GetObject("imgSoftPlace.Image")));
			this.imgSoftPlace.Location = new System.Drawing.Point(12, 9);
			this.imgSoftPlace.Name = "imgSoftPlace";
			this.imgSoftPlace.Size = new System.Drawing.Size(182, 166);
			this.imgSoftPlace.TabIndex = 4;
			this.imgSoftPlace.TabStop = false;
			// 
			// tSobre
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(459, 181);
			this.Controls.Add(this.imgSoftPlace);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.lblVersao);
			this.Controls.Add(this.lblSistema);
			this.Controls.Add(this.lblProjeto);
			this.Name = "tSobre";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sistema SOFT";
			((System.ComponentModel.ISupportInitialize)(this.imgSoftPlace)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.PictureBox imgSoftPlace;
		public System.Windows.Forms.Button btnOK;
		public System.Windows.Forms.Label lblSistema;
		public System.Windows.Forms.Label lblVersao;
		public System.Windows.Forms.Label lblProjeto;
	}
}
