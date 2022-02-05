/*
 * Criado por SharpDevelop.
 * Usuário: Ricardo
 * Data: 12/08/2008
 * Hora: 23:33
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace pagar
{
	partial class fGraficoFixoVariavel
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
			this.btnConfirma = new System.Windows.Forms.Button();
			this.c2 = new System.Windows.Forms.Panel();
			this.btnCancela = new System.Windows.Forms.Button();
			this.d1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dtpFinal = new System.Windows.Forms.DateTimePicker();
			this.v2 = new System.Windows.Forms.Label();
			this.c1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.dtpInicial = new System.Windows.Forms.DateTimePicker();
			this.v1 = new System.Windows.Forms.Label();
			this.d2 = new System.Windows.Forms.Label();
			this.pnlGrafico = new System.Windows.Forms.Panel();
			this.pnlGrafico.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(110, 49);
			this.btnConfirma.Name = "btnConfirma";
			this.btnConfirma.Size = new System.Drawing.Size(100, 25);
			this.btnConfirma.TabIndex = 121;
			this.btnConfirma.Text = "&Confirma";
			this.btnConfirma.UseVisualStyleBackColor = true;
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// c2
			// 
			this.c2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.c2.Location = new System.Drawing.Point(332, 42);
			this.c2.Name = "c2";
			this.c2.Size = new System.Drawing.Size(50, 20);
			this.c2.TabIndex = 130;
			this.c2.Visible = false;
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(216, 49);
			this.btnCancela.Name = "btnCancela";
			this.btnCancela.Size = new System.Drawing.Size(100, 25);
			this.btnCancela.TabIndex = 122;
			this.btnCancela.Text = "&Fecha";
			this.btnCancela.UseVisualStyleBackColor = true;
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
			// 
			// d1
			// 
			this.d1.Location = new System.Drawing.Point(398, 12);
			this.d1.Name = "d1";
			this.d1.Size = new System.Drawing.Size(124, 20);
			this.d1.TabIndex = 129;
			this.d1.Text = "label5";
			this.d1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.d1.Visible = false;
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label2.Location = new System.Drawing.Point(166, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 23);
			this.label2.TabIndex = 120;
			this.label2.Text = "Final";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpFinal
			// 
			this.dtpFinal.CustomFormat = "dd/MM/yyyy";
			this.dtpFinal.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpFinal.Location = new System.Drawing.Point(206, 12);
			this.dtpFinal.Name = "dtpFinal";
			this.dtpFinal.Size = new System.Drawing.Size(110, 20);
			this.dtpFinal.TabIndex = 119;
			// 
			// v2
			// 
			this.v2.Location = new System.Drawing.Point(266, 42);
			this.v2.Name = "v2";
			this.v2.Size = new System.Drawing.Size(60, 20);
			this.v2.TabIndex = 131;
			this.v2.Text = "label3";
			this.v2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.v2.Visible = false;
			// 
			// c1
			// 
			this.c1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.c1.Location = new System.Drawing.Point(332, 12);
			this.c1.Name = "c1";
			this.c1.Size = new System.Drawing.Size(50, 20);
			this.c1.TabIndex = 127;
			this.c1.Visible = false;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(7, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 23);
			this.label1.TabIndex = 118;
			this.label1.Text = "Inicial";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpInicial
			// 
			this.dtpInicial.CustomFormat = "dd/MM/yyyy";
			this.dtpInicial.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpInicial.Location = new System.Drawing.Point(47, 12);
			this.dtpInicial.Name = "dtpInicial";
			this.dtpInicial.Size = new System.Drawing.Size(110, 20);
			this.dtpInicial.TabIndex = 117;
			// 
			// v1
			// 
			this.v1.Location = new System.Drawing.Point(266, 12);
			this.v1.Name = "v1";
			this.v1.Size = new System.Drawing.Size(60, 20);
			this.v1.TabIndex = 128;
			this.v1.Text = "label3";
			this.v1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.v1.Visible = false;
			// 
			// d2
			// 
			this.d2.Location = new System.Drawing.Point(398, 42);
			this.d2.Name = "d2";
			this.d2.Size = new System.Drawing.Size(124, 20);
			this.d2.TabIndex = 132;
			this.d2.Text = "label5";
			this.d2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.d2.Visible = false;
			// 
			// pnlGrafico
			// 
			this.pnlGrafico.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.pnlGrafico.Controls.Add(this.d2);
			this.pnlGrafico.Controls.Add(this.v2);
			this.pnlGrafico.Controls.Add(this.c2);
			this.pnlGrafico.Controls.Add(this.d1);
			this.pnlGrafico.Controls.Add(this.v1);
			this.pnlGrafico.Controls.Add(this.c1);
			this.pnlGrafico.Location = new System.Drawing.Point(7, 57);
			this.pnlGrafico.Name = "pnlGrafico";
			this.pnlGrafico.Size = new System.Drawing.Size(57, 421);
			this.pnlGrafico.TabIndex = 116;
			this.pnlGrafico.Visible = false;
			this.pnlGrafico.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGraficoPaint);
			// 
			// fGraficoFixoVariavel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(330, 86);
			this.Controls.Add(this.btnConfirma);
			this.Controls.Add(this.btnCancela);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dtpFinal);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dtpInicial);
			this.Controls.Add(this.pnlGrafico);
			this.Name = "fGraficoFixoVariavel";
			this.Text = "Gráfico Fixo x Variável";
			this.Load += new System.EventHandler(this.FGraficoFixoVariavelLoad);
			this.pnlGrafico.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Panel pnlGrafico;
		private System.Windows.Forms.Label d2;
		private System.Windows.Forms.Label v1;
		public System.Windows.Forms.DateTimePicker dtpInicial;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel c1;
		private System.Windows.Forms.Label v2;
		public System.Windows.Forms.DateTimePicker dtpFinal;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label d1;
		public System.Windows.Forms.Button btnCancela;
		private System.Windows.Forms.Panel c2;
		public System.Windows.Forms.Button btnConfirma;
	}
}
