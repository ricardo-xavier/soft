/*
 * Criado por SharpDevelop.
 * Usuário: ricar_000
 * Data: 05/07/2015
 * Hora: 0:03
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace acao
{
	partial class Estatisticas
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
			this.dgvAcoes = new System.Windows.Forms.DataGridView();
			this.btnFecha = new System.Windows.Forms.Button();
			this.dgvOrcamentos = new System.Windows.Forms.DataGridView();
			this.lblTotalAcoes = new System.Windows.Forms.Label();
			this.lblQtdTotalAcoes = new System.Windows.Forms.Label();
			this.lblVlrAcoes = new System.Windows.Forms.Label();
			this.lblPerAcoes = new System.Windows.Forms.Label();
			this.lblPerConcretizados = new System.Windows.Forms.Label();
			this.lblVlrConcretizados = new System.Windows.Forms.Label();
			this.lblQtdConcretizados = new System.Windows.Forms.Label();
			this.lblConcretizados = new System.Windows.Forms.Label();
			this.lblPerConcretizadas = new System.Windows.Forms.Label();
			this.lblVlrConcretizadas = new System.Windows.Forms.Label();
			this.lblQtdConcretizadas = new System.Windows.Forms.Label();
			this.lblConcretizadas = new System.Windows.Forms.Label();
			this.lblProbabilidade = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.lblPerOrcamentos = new System.Windows.Forms.Label();
			this.lblVlrOrcamentos = new System.Windows.Forms.Label();
			this.lblQtdTotalOrcamentos = new System.Windows.Forms.Label();
			this.lblTotalOrcamentos = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvAcoes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvOrcamentos)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvAcoes
			// 
			this.dgvAcoes.AllowUserToAddRows = false;
			this.dgvAcoes.AllowUserToDeleteRows = false;
			this.dgvAcoes.AllowUserToResizeColumns = false;
			this.dgvAcoes.AllowUserToResizeRows = false;
			this.dgvAcoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvAcoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvAcoes.DefaultCellStyle = dataGridViewCellStyle1;
			this.dgvAcoes.Location = new System.Drawing.Point(5, 5);
			this.dgvAcoes.MultiSelect = false;
			this.dgvAcoes.Name = "dgvAcoes";
			this.dgvAcoes.ReadOnly = true;
			this.dgvAcoes.RowHeadersVisible = false;
			this.dgvAcoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvAcoes.Size = new System.Drawing.Size(580, 200);
			this.dgvAcoes.TabIndex = 91;
			// 
			// btnFecha
			// 
			this.btnFecha.Location = new System.Drawing.Point(485, 540);
			this.btnFecha.Name = "btnFecha";
			this.btnFecha.Size = new System.Drawing.Size(100, 25);
			this.btnFecha.TabIndex = 161;
			this.btnFecha.Text = "&Fecha";
			this.btnFecha.UseVisualStyleBackColor = true;
			this.btnFecha.Click += new System.EventHandler(this.BtnFechaClick);
			// 
			// dgvOrcamentos
			// 
			this.dgvOrcamentos.AllowUserToAddRows = false;
			this.dgvOrcamentos.AllowUserToDeleteRows = false;
			this.dgvOrcamentos.AllowUserToResizeColumns = false;
			this.dgvOrcamentos.AllowUserToResizeRows = false;
			this.dgvOrcamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvOrcamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvOrcamentos.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvOrcamentos.Location = new System.Drawing.Point(5, 285);
			this.dgvOrcamentos.MultiSelect = false;
			this.dgvOrcamentos.Name = "dgvOrcamentos";
			this.dgvOrcamentos.ReadOnly = true;
			this.dgvOrcamentos.RowHeadersVisible = false;
			this.dgvOrcamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvOrcamentos.Size = new System.Drawing.Size(580, 200);
			this.dgvOrcamentos.TabIndex = 162;
			this.dgvOrcamentos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DgvOrcamentosMouseDoubleClick);
			// 
			// lblTotalAcoes
			// 
			this.lblTotalAcoes.BackColor = System.Drawing.Color.SlateGray;
			this.lblTotalAcoes.Location = new System.Drawing.Point(5, 208);
			this.lblTotalAcoes.Name = "lblTotalAcoes";
			this.lblTotalAcoes.Size = new System.Drawing.Size(100, 23);
			this.lblTotalAcoes.TabIndex = 163;
			this.lblTotalAcoes.Text = "TOTAL";
			this.lblTotalAcoes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblQtdTotalAcoes
			// 
			this.lblQtdTotalAcoes.BackColor = System.Drawing.Color.SlateGray;
			this.lblQtdTotalAcoes.Location = new System.Drawing.Point(104, 208);
			this.lblQtdTotalAcoes.Name = "lblQtdTotalAcoes";
			this.lblQtdTotalAcoes.Size = new System.Drawing.Size(306, 23);
			this.lblQtdTotalAcoes.TabIndex = 165;
			this.lblQtdTotalAcoes.Text = "0";
			this.lblQtdTotalAcoes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblVlrAcoes
			// 
			this.lblVlrAcoes.BackColor = System.Drawing.Color.SlateGray;
			this.lblVlrAcoes.Location = new System.Drawing.Point(284, 80);
			this.lblVlrAcoes.Name = "lblVlrAcoes";
			this.lblVlrAcoes.Size = new System.Drawing.Size(141, 23);
			this.lblVlrAcoes.TabIndex = 166;
			this.lblVlrAcoes.Text = "R$ 0,00";
			this.lblVlrAcoes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblVlrAcoes.Visible = false;
			// 
			// lblPerAcoes
			// 
			this.lblPerAcoes.BackColor = System.Drawing.Color.SlateGray;
			this.lblPerAcoes.Location = new System.Drawing.Point(409, 208);
			this.lblPerAcoes.Name = "lblPerAcoes";
			this.lblPerAcoes.Size = new System.Drawing.Size(159, 23);
			this.lblPerAcoes.TabIndex = 167;
			this.lblPerAcoes.Text = "100";
			this.lblPerAcoes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblPerConcretizados
			// 
			this.lblPerConcretizados.BackColor = System.Drawing.Color.DarkOrange;
			this.lblPerConcretizados.Location = new System.Drawing.Point(469, 511);
			this.lblPerConcretizados.Name = "lblPerConcretizados";
			this.lblPerConcretizados.Size = new System.Drawing.Size(97, 23);
			this.lblPerConcretizados.TabIndex = 171;
			this.lblPerConcretizados.Text = "0";
			this.lblPerConcretizados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblPerConcretizados.Visible = false;
			// 
			// lblVlrConcretizados
			// 
			this.lblVlrConcretizados.BackColor = System.Drawing.Color.DarkOrange;
			this.lblVlrConcretizados.Location = new System.Drawing.Point(344, 511);
			this.lblVlrConcretizados.Name = "lblVlrConcretizados";
			this.lblVlrConcretizados.Size = new System.Drawing.Size(126, 23);
			this.lblVlrConcretizados.TabIndex = 170;
			this.lblVlrConcretizados.Text = "R$ 0,00";
			this.lblVlrConcretizados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblVlrConcretizados.Visible = false;
			// 
			// lblQtdConcretizados
			// 
			this.lblQtdConcretizados.BackColor = System.Drawing.Color.DarkOrange;
			this.lblQtdConcretizados.Location = new System.Drawing.Point(104, 511);
			this.lblQtdConcretizados.Name = "lblQtdConcretizados";
			this.lblQtdConcretizados.Size = new System.Drawing.Size(244, 23);
			this.lblQtdConcretizados.TabIndex = 169;
			this.lblQtdConcretizados.Text = "0";
			this.lblQtdConcretizados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblQtdConcretizados.Visible = false;
			// 
			// lblConcretizados
			// 
			this.lblConcretizados.BackColor = System.Drawing.Color.DarkOrange;
			this.lblConcretizados.Location = new System.Drawing.Point(5, 511);
			this.lblConcretizados.Name = "lblConcretizados";
			this.lblConcretizados.Size = new System.Drawing.Size(100, 23);
			this.lblConcretizados.TabIndex = 168;
			this.lblConcretizados.Text = "Concretizados";
			this.lblConcretizados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblConcretizados.Visible = false;
			// 
			// lblPerConcretizadas
			// 
			this.lblPerConcretizadas.BackColor = System.Drawing.Color.DarkOrange;
			this.lblPerConcretizadas.Location = new System.Drawing.Point(409, 231);
			this.lblPerConcretizadas.Name = "lblPerConcretizadas";
			this.lblPerConcretizadas.Size = new System.Drawing.Size(159, 23);
			this.lblPerConcretizadas.TabIndex = 175;
			this.lblPerConcretizadas.Text = "0";
			this.lblPerConcretizadas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblVlrConcretizadas
			// 
			this.lblVlrConcretizadas.BackColor = System.Drawing.Color.DarkOrange;
			this.lblVlrConcretizadas.Location = new System.Drawing.Point(284, 103);
			this.lblVlrConcretizadas.Name = "lblVlrConcretizadas";
			this.lblVlrConcretizadas.Size = new System.Drawing.Size(141, 23);
			this.lblVlrConcretizadas.TabIndex = 174;
			this.lblVlrConcretizadas.Text = "R$ 0,00";
			this.lblVlrConcretizadas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblVlrConcretizadas.Visible = false;
			// 
			// lblQtdConcretizadas
			// 
			this.lblQtdConcretizadas.BackColor = System.Drawing.Color.DarkOrange;
			this.lblQtdConcretizadas.Location = new System.Drawing.Point(104, 231);
			this.lblQtdConcretizadas.Name = "lblQtdConcretizadas";
			this.lblQtdConcretizadas.Size = new System.Drawing.Size(306, 23);
			this.lblQtdConcretizadas.TabIndex = 173;
			this.lblQtdConcretizadas.Text = "0";
			this.lblQtdConcretizadas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblConcretizadas
			// 
			this.lblConcretizadas.BackColor = System.Drawing.Color.DarkOrange;
			this.lblConcretizadas.Location = new System.Drawing.Point(5, 231);
			this.lblConcretizadas.Name = "lblConcretizadas";
			this.lblConcretizadas.Size = new System.Drawing.Size(100, 23);
			this.lblConcretizadas.TabIndex = 172;
			this.lblConcretizadas.Text = "Concretizadas";
			this.lblConcretizadas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblProbabilidade
			// 
			this.lblProbabilidade.BackColor = System.Drawing.Color.DarkOrange;
			this.lblProbabilidade.Location = new System.Drawing.Point(424, 254);
			this.lblProbabilidade.Name = "lblProbabilidade";
			this.lblProbabilidade.Size = new System.Drawing.Size(144, 23);
			this.lblProbabilidade.TabIndex = 179;
			this.lblProbabilidade.Text = "0";
			this.lblProbabilidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.DarkOrange;
			this.label6.Location = new System.Drawing.Point(284, 254);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(141, 23);
			this.label6.TabIndex = 178;
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.DarkOrange;
			this.label7.Location = new System.Drawing.Point(137, 254);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(149, 23);
			this.label7.TabIndex = 177;
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.DarkOrange;
			this.label8.Location = new System.Drawing.Point(5, 254);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(135, 23);
			this.label8.TabIndex = 176;
			this.label8.Text = "Probalidade Fechamento";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPerOrcamentos
			// 
			this.lblPerOrcamentos.BackColor = System.Drawing.Color.SlateGray;
			this.lblPerOrcamentos.Location = new System.Drawing.Point(373, 542);
			this.lblPerOrcamentos.Name = "lblPerOrcamentos";
			this.lblPerOrcamentos.Size = new System.Drawing.Size(97, 23);
			this.lblPerOrcamentos.TabIndex = 183;
			this.lblPerOrcamentos.Text = "100";
			this.lblPerOrcamentos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lblPerOrcamentos.Visible = false;
			// 
			// lblVlrOrcamentos
			// 
			this.lblVlrOrcamentos.BackColor = System.Drawing.Color.SlateGray;
			this.lblVlrOrcamentos.Location = new System.Drawing.Point(409, 488);
			this.lblVlrOrcamentos.Name = "lblVlrOrcamentos";
			this.lblVlrOrcamentos.Size = new System.Drawing.Size(159, 23);
			this.lblVlrOrcamentos.TabIndex = 182;
			this.lblVlrOrcamentos.Text = "R$ 0,00";
			this.lblVlrOrcamentos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblQtdTotalOrcamentos
			// 
			this.lblQtdTotalOrcamentos.BackColor = System.Drawing.Color.SlateGray;
			this.lblQtdTotalOrcamentos.Location = new System.Drawing.Point(104, 488);
			this.lblQtdTotalOrcamentos.Name = "lblQtdTotalOrcamentos";
			this.lblQtdTotalOrcamentos.Size = new System.Drawing.Size(306, 23);
			this.lblQtdTotalOrcamentos.TabIndex = 181;
			this.lblQtdTotalOrcamentos.Text = "0";
			this.lblQtdTotalOrcamentos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblTotalOrcamentos
			// 
			this.lblTotalOrcamentos.BackColor = System.Drawing.Color.SlateGray;
			this.lblTotalOrcamentos.Location = new System.Drawing.Point(5, 488);
			this.lblTotalOrcamentos.Name = "lblTotalOrcamentos";
			this.lblTotalOrcamentos.Size = new System.Drawing.Size(100, 23);
			this.lblTotalOrcamentos.TabIndex = 180;
			this.lblTotalOrcamentos.Text = "TOTAL";
			this.lblTotalOrcamentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(5, 540);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(228, 23);
			this.label1.TabIndex = 184;
			this.label1.Text = "Duplo click para mergulhar nos Orçamentos";
			// 
			// Estatisticas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(596, 570);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblPerOrcamentos);
			this.Controls.Add(this.lblVlrOrcamentos);
			this.Controls.Add(this.lblQtdTotalOrcamentos);
			this.Controls.Add(this.lblTotalOrcamentos);
			this.Controls.Add(this.lblProbabilidade);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.lblPerConcretizadas);
			this.Controls.Add(this.lblVlrConcretizadas);
			this.Controls.Add(this.lblQtdConcretizadas);
			this.Controls.Add(this.lblConcretizadas);
			this.Controls.Add(this.lblPerConcretizados);
			this.Controls.Add(this.lblVlrConcretizados);
			this.Controls.Add(this.lblQtdConcretizados);
			this.Controls.Add(this.lblConcretizados);
			this.Controls.Add(this.lblPerAcoes);
			this.Controls.Add(this.lblVlrAcoes);
			this.Controls.Add(this.lblQtdTotalAcoes);
			this.Controls.Add(this.lblTotalAcoes);
			this.Controls.Add(this.dgvOrcamentos);
			this.Controls.Add(this.btnFecha);
			this.Controls.Add(this.dgvAcoes);
			this.Name = "Estatisticas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Estatisticas";
			((System.ComponentModel.ISupportInitialize)(this.dgvAcoes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvOrcamentos)).EndInit();
			this.ResumeLayout(false);

		}
		public System.Windows.Forms.Button btnFecha;
		public System.Windows.Forms.DataGridView dgvAcoes;
		public System.Windows.Forms.DataGridView dgvOrcamentos;
		private System.Windows.Forms.Label lblTotalAcoes;
		private System.Windows.Forms.Label lblConcretizados;
		private System.Windows.Forms.Label lblQtdTotalAcoes;
		private System.Windows.Forms.Label lblVlrAcoes;
		private System.Windows.Forms.Label lblPerAcoes;
		private System.Windows.Forms.Label lblPerConcretizados;
		private System.Windows.Forms.Label lblVlrConcretizados;
		private System.Windows.Forms.Label lblQtdConcretizados;
		private System.Windows.Forms.Label lblPerConcretizadas;
		private System.Windows.Forms.Label lblVlrConcretizadas;
		private System.Windows.Forms.Label lblQtdConcretizadas;
		private System.Windows.Forms.Label lblConcretizadas;
		private System.Windows.Forms.Label lblProbabilidade;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lblPerOrcamentos;
		private System.Windows.Forms.Label lblVlrOrcamentos;
		private System.Windows.Forms.Label lblQtdTotalOrcamentos;
		private System.Windows.Forms.Label lblTotalOrcamentos;
		private System.Windows.Forms.Label label1;
	}
}
