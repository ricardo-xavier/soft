/*
 * Usuário: Ricardo
 * Data: 26/03/2008
 * Hora: 22:36
 * 
 */
namespace cpd
{
	partial class frmControleAcesso
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dbgUsuarios = new System.Windows.Forms.DataGridView();
			this.dbgFiliais = new System.Windows.Forms.DataGridView();
			this.dbgSistemas = new System.Windows.Forms.DataGridView();
			this.dbgProgramas = new System.Windows.Forms.DataGridView();
			this.lblUsuarios = new System.Windows.Forms.Label();
			this.lblFiliais = new System.Windows.Forms.Label();
			this.lblSistemas = new System.Windows.Forms.Label();
			this.lblProgramas = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dbgUsuarios)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dbgFiliais)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dbgSistemas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dbgProgramas)).BeginInit();
			this.SuspendLayout();
			// 
			// dbgUsuarios
			// 
			this.dbgUsuarios.AllowUserToAddRows = false;
			this.dbgUsuarios.AllowUserToDeleteRows = false;
			this.dbgUsuarios.AllowUserToResizeColumns = false;
			this.dbgUsuarios.AllowUserToResizeRows = false;
			this.dbgUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dbgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dbgUsuarios.DefaultCellStyle = dataGridViewCellStyle1;
			this.dbgUsuarios.Location = new System.Drawing.Point(12, 32);
			this.dbgUsuarios.MultiSelect = false;
			this.dbgUsuarios.Name = "dbgUsuarios";
			this.dbgUsuarios.ReadOnly = true;
			this.dbgUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dbgUsuarios.Size = new System.Drawing.Size(300, 156);
			this.dbgUsuarios.TabIndex = 13;
			this.dbgUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DbgUsuariosCellClick);
			// 
			// dbgFiliais
			// 
			this.dbgFiliais.AllowUserToAddRows = false;
			this.dbgFiliais.AllowUserToDeleteRows = false;
			this.dbgFiliais.AllowUserToResizeColumns = false;
			this.dbgFiliais.AllowUserToResizeRows = false;
			this.dbgFiliais.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dbgFiliais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dbgFiliais.DefaultCellStyle = dataGridViewCellStyle2;
			this.dbgFiliais.Location = new System.Drawing.Point(339, 32);
			this.dbgFiliais.MultiSelect = false;
			this.dbgFiliais.Name = "dbgFiliais";
			this.dbgFiliais.ReadOnly = true;
			this.dbgFiliais.Size = new System.Drawing.Size(300, 156);
			this.dbgFiliais.TabIndex = 14;
			this.dbgFiliais.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DbgFiliaisCellDoubleClick);
			this.dbgFiliais.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DbgFiliaisCellClick);
			// 
			// dbgSistemas
			// 
			this.dbgSistemas.AllowUserToAddRows = false;
			this.dbgSistemas.AllowUserToDeleteRows = false;
			this.dbgSistemas.AllowUserToResizeColumns = false;
			this.dbgSistemas.AllowUserToResizeRows = false;
			this.dbgSistemas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dbgSistemas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dbgSistemas.DefaultCellStyle = dataGridViewCellStyle3;
			this.dbgSistemas.Location = new System.Drawing.Point(12, 220);
			this.dbgSistemas.MultiSelect = false;
			this.dbgSistemas.Name = "dbgSistemas";
			this.dbgSistemas.ReadOnly = true;
			this.dbgSistemas.Size = new System.Drawing.Size(300, 156);
			this.dbgSistemas.TabIndex = 15;
			this.dbgSistemas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DbgSistemasCellDoubleClick);
			this.dbgSistemas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DbgSistemasCellClick);
			// 
			// dbgProgramas
			// 
			this.dbgProgramas.AllowUserToAddRows = false;
			this.dbgProgramas.AllowUserToDeleteRows = false;
			this.dbgProgramas.AllowUserToResizeColumns = false;
			this.dbgProgramas.AllowUserToResizeRows = false;
			this.dbgProgramas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dbgProgramas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dbgProgramas.DefaultCellStyle = dataGridViewCellStyle4;
			this.dbgProgramas.Location = new System.Drawing.Point(339, 220);
			this.dbgProgramas.MultiSelect = false;
			this.dbgProgramas.Name = "dbgProgramas";
			this.dbgProgramas.ReadOnly = true;
			this.dbgProgramas.Size = new System.Drawing.Size(300, 156);
			this.dbgProgramas.TabIndex = 16;
			this.dbgProgramas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DbgProgramasCellDoubleClick);
			// 
			// lblUsuarios
			// 
			this.lblUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsuarios.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblUsuarios.Location = new System.Drawing.Point(12, 9);
			this.lblUsuarios.Name = "lblUsuarios";
			this.lblUsuarios.Size = new System.Drawing.Size(100, 20);
			this.lblUsuarios.TabIndex = 25;
			this.lblUsuarios.Text = "Usuários";
			this.lblUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblFiliais
			// 
			this.lblFiliais.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFiliais.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblFiliais.Location = new System.Drawing.Point(339, 9);
			this.lblFiliais.Name = "lblFiliais";
			this.lblFiliais.Size = new System.Drawing.Size(100, 20);
			this.lblFiliais.TabIndex = 26;
			this.lblFiliais.Text = "Filiais";
			this.lblFiliais.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblSistemas
			// 
			this.lblSistemas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSistemas.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblSistemas.Location = new System.Drawing.Point(12, 197);
			this.lblSistemas.Name = "lblSistemas";
			this.lblSistemas.Size = new System.Drawing.Size(100, 20);
			this.lblSistemas.TabIndex = 27;
			this.lblSistemas.Text = "Sistemas";
			this.lblSistemas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblProgramas
			// 
			this.lblProgramas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProgramas.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblProgramas.Location = new System.Drawing.Point(339, 197);
			this.lblProgramas.Name = "lblProgramas";
			this.lblProgramas.Size = new System.Drawing.Size(100, 20);
			this.lblProgramas.TabIndex = 28;
			this.lblProgramas.Text = "Programas";
			this.lblProgramas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// frmControleAcesso
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(653, 379);
			this.Controls.Add(this.lblProgramas);
			this.Controls.Add(this.lblSistemas);
			this.Controls.Add(this.lblFiliais);
			this.Controls.Add(this.lblUsuarios);
			this.Controls.Add(this.dbgProgramas);
			this.Controls.Add(this.dbgSistemas);
			this.Controls.Add(this.dbgFiliais);
			this.Controls.Add(this.dbgUsuarios);
			this.Name = "frmControleAcesso";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CPD - Controle de Acesso";
			this.Load += new System.EventHandler(this.FrmControleAcessoLoad);
			((System.ComponentModel.ISupportInitialize)(this.dbgUsuarios)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dbgFiliais)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dbgSistemas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dbgProgramas)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lblProgramas;
		private System.Windows.Forms.Label lblSistemas;
		private System.Windows.Forms.Label lblFiliais;
		private System.Windows.Forms.Label lblUsuarios;
		private System.Windows.Forms.DataGridView dbgProgramas;
		private System.Windows.Forms.DataGridView dbgSistemas;
		private System.Windows.Forms.DataGridView dbgFiliais;
		private System.Windows.Forms.DataGridView dbgUsuarios;
	}
}
