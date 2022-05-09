/*
 * Criado por SharpDevelop.
 * Usuário: Ricardo
 * Data: 07/11/2008
 * Hora: 21:42
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace desktop
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.imgLogo = new System.Windows.Forms.PictureBox();
			this.lblUsuario = new System.Windows.Forms.Label();
			this.lblFilial = new System.Windows.Forms.Label();
			this.dgvAniversariantes = new System.Windows.Forms.DataGridView();
			this.lblAniversariantes = new System.Windows.Forms.Label();
			this.lblAvisos = new System.Windows.Forms.Label();
			this.lblAgenda = new System.Windows.Forms.Label();
			this.dgvHistorico = new System.Windows.Forms.DataGridView();
			this.tbPendencia = new System.Windows.Forms.TextBox();
			this.tbMensagem = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvAniversariantes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).BeginInit();
			this.SuspendLayout();
			// 
			// imgLogo
			// 
			this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
			this.imgLogo.Location = new System.Drawing.Point(571, 12);
			this.imgLogo.Name = "imgLogo";
			this.imgLogo.Size = new System.Drawing.Size(175, 160);
			this.imgLogo.TabIndex = 3;
			this.imgLogo.TabStop = false;
			// 
			// lblUsuario
			// 
			this.lblUsuario.Location = new System.Drawing.Point(571, 202);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(175, 23);
			this.lblUsuario.TabIndex = 4;
			this.lblUsuario.Text = "Usuário:";
			this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblFilial
			// 
			this.lblFilial.Location = new System.Drawing.Point(571, 225);
			this.lblFilial.Name = "lblFilial";
			this.lblFilial.Size = new System.Drawing.Size(175, 23);
			this.lblFilial.TabIndex = 5;
			this.lblFilial.Text = "Filial:";
			this.lblFilial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dgvAniversariantes
			// 
			this.dgvAniversariantes.AllowUserToAddRows = false;
			this.dgvAniversariantes.AllowUserToDeleteRows = false;
			this.dgvAniversariantes.AllowUserToResizeColumns = false;
			this.dgvAniversariantes.AllowUserToResizeRows = false;
			this.dgvAniversariantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvAniversariantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvAniversariantes.DefaultCellStyle = dataGridViewCellStyle5;
			this.dgvAniversariantes.Location = new System.Drawing.Point(6, 300);
			this.dgvAniversariantes.MultiSelect = false;
			this.dgvAniversariantes.Name = "dgvAniversariantes";
			this.dgvAniversariantes.ReadOnly = true;
			this.dgvAniversariantes.RowHeadersVisible = false;
			this.dgvAniversariantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvAniversariantes.Size = new System.Drawing.Size(740, 112);
			this.dgvAniversariantes.TabIndex = 7;
			// 
			// lblAniversariantes
			// 
			this.lblAniversariantes.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblAniversariantes.Location = new System.Drawing.Point(6, 277);
			this.lblAniversariantes.Name = "lblAniversariantes";
			this.lblAniversariantes.Size = new System.Drawing.Size(128, 20);
			this.lblAniversariantes.TabIndex = 67;
			this.lblAniversariantes.Text = "Aniversariantes do Mês";
			this.lblAniversariantes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblAvisos
			// 
			this.lblAvisos.Location = new System.Drawing.Point(6, 239);
			this.lblAvisos.Name = "lblAvisos";
			this.lblAvisos.Size = new System.Drawing.Size(380, 23);
			this.lblAvisos.TabIndex = 68;
			this.lblAvisos.Visible = false;
			// 
			// lblAgenda
			// 
			this.lblAgenda.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblAgenda.Location = new System.Drawing.Point(6, 415);
			this.lblAgenda.Name = "lblAgenda";
			this.lblAgenda.Size = new System.Drawing.Size(128, 20);
			this.lblAgenda.TabIndex = 69;
			this.lblAgenda.Text = "Agenda";
			this.lblAgenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dgvHistorico
			// 
			this.dgvHistorico.AllowUserToAddRows = false;
			this.dgvHistorico.AllowUserToDeleteRows = false;
			this.dgvHistorico.AllowUserToResizeColumns = false;
			this.dgvHistorico.AllowUserToResizeRows = false;
			this.dgvHistorico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvHistorico.DefaultCellStyle = dataGridViewCellStyle6;
			this.dgvHistorico.Location = new System.Drawing.Point(6, 437);
			this.dgvHistorico.MultiSelect = false;
			this.dgvHistorico.Name = "dgvHistorico";
			this.dgvHistorico.ReadOnly = true;
			this.dgvHistorico.RowHeadersVisible = false;
			this.dgvHistorico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvHistorico.Size = new System.Drawing.Size(740, 112);
			this.dgvHistorico.TabIndex = 70;
			this.dgvHistorico.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvHistoricoRowEnter);
			this.dgvHistorico.Sorted += new System.EventHandler(this.DgvHistoricoSorted);
			this.dgvHistorico.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DgvHistoricoMouseDoubleClick);
			// 
			// tbPendencia
			// 
			this.tbPendencia.Location = new System.Drawing.Point(6, 555);
			this.tbPendencia.Multiline = true;
			this.tbPendencia.Name = "tbPendencia";
			this.tbPendencia.ReadOnly = true;
			this.tbPendencia.Size = new System.Drawing.Size(740, 103);
			this.tbPendencia.TabIndex = 71;
			// 
			// tbMensagem
			// 
			this.tbMensagem.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.tbMensagem.Location = new System.Drawing.Point(247, 12);
			this.tbMensagem.Multiline = true;
			this.tbMensagem.Name = "tbMensagem";
			this.tbMensagem.ReadOnly = true;
			this.tbMensagem.Size = new System.Drawing.Size(263, 235);
			this.tbMensagem.TabIndex = 72;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(352, 266);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 74;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Visible = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(750, 656);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.tbMensagem);
			this.Controls.Add(this.tbPendencia);
			this.Controls.Add(this.dgvHistorico);
			this.Controls.Add(this.lblAgenda);
			this.Controls.Add(this.lblAvisos);
			this.Controls.Add(this.lblAniversariantes);
			this.Controls.Add(this.dgvAniversariantes);
			this.Controls.Add(this.lblFilial);
			this.Controls.Add(this.lblUsuario);
			this.Controls.Add(this.imgLogo);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sistema SOFT - v2.1.1 (03/01/21)";
			this.Activated += new System.EventHandler(this.MainFormActivated);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.Shown += new System.EventHandler(this.MainFormShown);
			((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvAniversariantes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.TextBox tbMensagem;
		private System.Windows.Forms.Label lblAgenda;
		public System.Windows.Forms.PictureBox imgLogo;
		private System.Windows.Forms.TextBox tbPendencia;
		public System.Windows.Forms.DataGridView dgvHistorico;
		private System.Windows.Forms.Label lblAvisos;
		public System.Windows.Forms.DataGridView dgvAniversariantes;
		private System.Windows.Forms.Label lblAniversariantes;
		private System.Windows.Forms.Label lblFilial;
		private System.Windows.Forms.Label lblUsuario;
		private System.Windows.Forms.Button button2;
	}
}
