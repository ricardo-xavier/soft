/*
 * Created by SharpDevelop.
 * User: Ricardo
 * Date: 27/09/2014
 * Time: 17:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace acao
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnDown = new System.Windows.Forms.Button();
			this.btnUp = new System.Windows.Forms.Button();
			this.label16 = new System.Windows.Forms.Label();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.btnFiltro = new System.Windows.Forms.Button();
			this.edtLocaliza = new System.Windows.Forms.TextBox();
			this.dgvAcoes = new System.Windows.Forms.DataGridView();
			this.dgvContatos = new System.Windows.Forms.DataGridView();
			this.dgvHistorico = new System.Windows.Forms.DataGridView();
			this.btnFecha = new System.Windows.Forms.Button();
			this.btnAltera = new System.Windows.Forms.Button();
			this.btnExclui = new System.Windows.Forms.Button();
			this.btnInclui = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.btnProdutos = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.btnConsultor = new System.Windows.Forms.Button();
			this.btnCliente = new System.Windows.Forms.Button();
			this.btnObservacao = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.btnOrcamentos = new System.Windows.Forms.Button();
			this.lnkContatos = new System.Windows.Forms.LinkLabel();
			this.lnkAgenda = new System.Windows.Forms.LinkLabel();
			this.btnConcorrentes = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.btnEstatisticas = new System.Windows.Forms.Button();
			this.imgClientes = new System.Windows.Forms.PictureBox();
			this.lblTotalAcoes = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvAcoes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvContatos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgClientes)).BeginInit();
			this.SuspendLayout();
			// 
			// btnDown
			// 
			this.btnDown.Image = ((System.Drawing.Image)(resources.GetObject("btnDown.Image")));
			this.btnDown.Location = new System.Drawing.Point(284, 10);
			this.btnDown.Name = "btnDown";
			this.btnDown.Size = new System.Drawing.Size(36, 25);
			this.btnDown.TabIndex = 20;
			this.btnDown.UseVisualStyleBackColor = true;
			this.btnDown.Click += new System.EventHandler(this.BtnDownClick);
			// 
			// btnUp
			// 
			this.btnUp.Image = ((System.Drawing.Image)(resources.GetObject("btnUp.Image")));
			this.btnUp.Location = new System.Drawing.Point(322, 10);
			this.btnUp.Name = "btnUp";
			this.btnUp.Size = new System.Drawing.Size(36, 25);
			this.btnUp.TabIndex = 30;
			this.btnUp.UseVisualStyleBackColor = true;
			this.btnUp.Click += new System.EventHandler(this.BtnUpClick);
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(16, 11);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(60, 20);
			this.label16.TabIndex = 166;
			this.label16.Text = "Localiza";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnRefresh
			// 
			this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
			this.btnRefresh.Location = new System.Drawing.Point(403, 10);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(36, 25);
			this.btnRefresh.TabIndex = 50;
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.BtnRefreshClick);
			// 
			// btnFiltro
			// 
			this.btnFiltro.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltro.Image")));
			this.btnFiltro.Location = new System.Drawing.Point(364, 10);
			this.btnFiltro.Name = "btnFiltro";
			this.btnFiltro.Size = new System.Drawing.Size(36, 25);
			this.btnFiltro.TabIndex = 40;
			this.btnFiltro.UseVisualStyleBackColor = true;
			this.btnFiltro.Click += new System.EventHandler(this.BtnFiltroClick);
			// 
			// edtLocaliza
			// 
			this.edtLocaliza.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtLocaliza.Location = new System.Drawing.Point(82, 12);
			this.edtLocaliza.MaxLength = 30;
			this.edtLocaliza.Name = "edtLocaliza";
			this.edtLocaliza.Size = new System.Drawing.Size(195, 20);
			this.edtLocaliza.TabIndex = 10;
			this.edtLocaliza.TextChanged += new System.EventHandler(this.EdtLocalizaTextChanged);
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
			this.dgvAcoes.Location = new System.Drawing.Point(14, 41);
			this.dgvAcoes.MultiSelect = false;
			this.dgvAcoes.Name = "dgvAcoes";
			this.dgvAcoes.ReadOnly = true;
			this.dgvAcoes.RowHeadersVisible = false;
			this.dgvAcoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvAcoes.Size = new System.Drawing.Size(927, 309);
			this.dgvAcoes.TabIndex = 90;
			this.dgvAcoes.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAcoesRowEnter);
			this.dgvAcoes.Sorted += new System.EventHandler(this.DgvAcoesSorted);
			this.dgvAcoes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DgvAcoesMouseDoubleClick);
			// 
			// dgvContatos
			// 
			this.dgvContatos.AllowUserToAddRows = false;
			this.dgvContatos.AllowUserToDeleteRows = false;
			this.dgvContatos.AllowUserToResizeColumns = false;
			this.dgvContatos.AllowUserToResizeRows = false;
			this.dgvContatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvContatos.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvContatos.Location = new System.Drawing.Point(12, 392);
			this.dgvContatos.MultiSelect = false;
			this.dgvContatos.Name = "dgvContatos";
			this.dgvContatos.ReadOnly = true;
			this.dgvContatos.RowHeadersVisible = false;
			this.dgvContatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvContatos.Size = new System.Drawing.Size(929, 110);
			this.dgvContatos.TabIndex = 100;
			this.dgvContatos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvContatosRowEnter);
			this.dgvContatos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DgvContatosMouseDoubleClick);
			// 
			// dgvHistorico
			// 
			this.dgvHistorico.AllowUserToAddRows = false;
			this.dgvHistorico.AllowUserToDeleteRows = false;
			this.dgvHistorico.AllowUserToResizeColumns = false;
			this.dgvHistorico.AllowUserToResizeRows = false;
			this.dgvHistorico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvHistorico.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvHistorico.Location = new System.Drawing.Point(12, 522);
			this.dgvHistorico.MultiSelect = false;
			this.dgvHistorico.Name = "dgvHistorico";
			this.dgvHistorico.ReadOnly = true;
			this.dgvHistorico.RowHeadersVisible = false;
			this.dgvHistorico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvHistorico.Size = new System.Drawing.Size(929, 110);
			this.dgvHistorico.TabIndex = 110;
			this.dgvHistorico.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DgvHistoricoMouseDoubleClick);
			// 
			// btnFecha
			// 
			this.btnFecha.Location = new System.Drawing.Point(841, 638);
			this.btnFecha.Name = "btnFecha";
			this.btnFecha.Size = new System.Drawing.Size(100, 25);
			this.btnFecha.TabIndex = 160;
			this.btnFecha.Text = "&Fecha";
			this.btnFecha.UseVisualStyleBackColor = true;
			this.btnFecha.Click += new System.EventHandler(this.BtnFechaClick);
			// 
			// btnAltera
			// 
			this.btnAltera.Location = new System.Drawing.Point(629, 638);
			this.btnAltera.Name = "btnAltera";
			this.btnAltera.Size = new System.Drawing.Size(100, 25);
			this.btnAltera.TabIndex = 140;
			this.btnAltera.Text = "&Altera";
			this.btnAltera.UseVisualStyleBackColor = true;
			this.btnAltera.Click += new System.EventHandler(this.BtnAlteraClick);
			// 
			// btnExclui
			// 
			this.btnExclui.Location = new System.Drawing.Point(523, 638);
			this.btnExclui.Name = "btnExclui";
			this.btnExclui.Size = new System.Drawing.Size(100, 25);
			this.btnExclui.TabIndex = 130;
			this.btnExclui.Text = "&Exclui";
			this.btnExclui.UseVisualStyleBackColor = true;
			this.btnExclui.Click += new System.EventHandler(this.BtnExcluiClick);
			// 
			// btnInclui
			// 
			this.btnInclui.Location = new System.Drawing.Point(417, 638);
			this.btnInclui.Name = "btnInclui";
			this.btnInclui.Size = new System.Drawing.Size(100, 25);
			this.btnInclui.TabIndex = 120;
			this.btnInclui.Text = "&Inclui";
			this.btnInclui.UseVisualStyleBackColor = true;
			this.btnInclui.Click += new System.EventHandler(this.BtnIncluiClick);
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(12, 373);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(202, 16);
			this.label1.TabIndex = 175;
			this.label1.Text = "Contatos";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnProdutos
			// 
			this.btnProdutos.Location = new System.Drawing.Point(735, 638);
			this.btnProdutos.Name = "btnProdutos";
			this.btnProdutos.Size = new System.Drawing.Size(100, 25);
			this.btnProdutos.TabIndex = 150;
			this.btnProdutos.Text = "&Produtos";
			this.btnProdutos.UseVisualStyleBackColor = true;
			this.btnProdutos.Click += new System.EventHandler(this.BtnProdutosClick);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Red;
			this.label2.Location = new System.Drawing.Point(16, 635);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(363, 16);
			this.label2.TabIndex = 178;
			this.label2.Text = "Duplo click para mergulhar no Agendamento ou no Contato";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnConsultor
			// 
			this.btnConsultor.Location = new System.Drawing.Point(691, 10);
			this.btnConsultor.Name = "btnConsultor";
			this.btnConsultor.Size = new System.Drawing.Size(80, 25);
			this.btnConsultor.TabIndex = 70;
			this.btnConsultor.Text = "Consultor";
			this.btnConsultor.UseVisualStyleBackColor = true;
			this.btnConsultor.Click += new System.EventHandler(this.BtnConsultorClick);
			// 
			// btnCliente
			// 
			this.btnCliente.Location = new System.Drawing.Point(607, 10);
			this.btnCliente.Name = "btnCliente";
			this.btnCliente.Size = new System.Drawing.Size(80, 25);
			this.btnCliente.TabIndex = 60;
			this.btnCliente.Text = "Cliente";
			this.btnCliente.UseVisualStyleBackColor = true;
			this.btnCliente.Click += new System.EventHandler(this.BtnClienteClick);
			// 
			// btnObservacao
			// 
			this.btnObservacao.Location = new System.Drawing.Point(776, 10);
			this.btnObservacao.Name = "btnObservacao";
			this.btnObservacao.Size = new System.Drawing.Size(80, 25);
			this.btnObservacao.TabIndex = 80;
			this.btnObservacao.Text = "Observação";
			this.btnObservacao.UseVisualStyleBackColor = true;
			this.btnObservacao.Click += new System.EventHandler(this.BtnObservacaoClick);
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label3.Location = new System.Drawing.Point(12, 503);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(363, 16);
			this.label3.TabIndex = 182;
			this.label3.Text = "Histórico";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnOrcamentos
			// 
			this.btnOrcamentos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnOrcamentos.Location = new System.Drawing.Point(514, 10);
			this.btnOrcamentos.Name = "btnOrcamentos";
			this.btnOrcamentos.Size = new System.Drawing.Size(92, 25);
			this.btnOrcamentos.TabIndex = 59;
			this.btnOrcamentos.Text = "Orçamentos";
			this.btnOrcamentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnOrcamentos.UseVisualStyleBackColor = true;
			this.btnOrcamentos.Click += new System.EventHandler(this.BtnOrcamentosClick);
			// 
			// lnkContatos
			// 
			this.lnkContatos.Location = new System.Drawing.Point(841, 373);
			this.lnkContatos.Name = "lnkContatos";
			this.lnkContatos.Size = new System.Drawing.Size(100, 16);
			this.lnkContatos.TabIndex = 191;
			this.lnkContatos.TabStop = true;
			this.lnkContatos.Text = "Cadastro";
			this.lnkContatos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lnkContatos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkContatosLinkClicked);
			// 
			// lnkAgenda
			// 
			this.lnkAgenda.Location = new System.Drawing.Point(841, 503);
			this.lnkAgenda.Name = "lnkAgenda";
			this.lnkAgenda.Size = new System.Drawing.Size(100, 16);
			this.lnkAgenda.TabIndex = 192;
			this.lnkAgenda.TabStop = true;
			this.lnkAgenda.Text = "Agenda";
			this.lnkAgenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.lnkAgenda.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkAgendaLinkClicked);
			// 
			// btnConcorrentes
			// 
			this.btnConcorrentes.Location = new System.Drawing.Point(861, 10);
			this.btnConcorrentes.Name = "btnConcorrentes";
			this.btnConcorrentes.Size = new System.Drawing.Size(80, 25);
			this.btnConcorrentes.TabIndex = 85;
			this.btnConcorrentes.Text = "Concorrentes";
			this.btnConcorrentes.UseVisualStyleBackColor = true;
			this.btnConcorrentes.Click += new System.EventHandler(this.BtnConcorrentesClick);
			// 
			// button1
			// 
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button1.Location = new System.Drawing.Point(407, 403);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(51, 25);
			this.button1.TabIndex = 193;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Visible = false;
			// 
			// button2
			// 
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button2.Location = new System.Drawing.Point(464, 403);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(51, 25);
			this.button2.TabIndex = 194;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Visible = false;
			// 
			// btnEstatisticas
			// 
			this.btnEstatisticas.Image = ((System.Drawing.Image)(resources.GetObject("btnEstatisticas.Image")));
			this.btnEstatisticas.Location = new System.Drawing.Point(444, 10);
			this.btnEstatisticas.Name = "btnEstatisticas";
			this.btnEstatisticas.Size = new System.Drawing.Size(36, 25);
			this.btnEstatisticas.TabIndex = 51;
			this.btnEstatisticas.UseVisualStyleBackColor = true;
			this.btnEstatisticas.Click += new System.EventHandler(this.BtnEstatisticasClick);
			// 
			// imgClientes
			// 
			this.imgClientes.Image = ((System.Drawing.Image)(resources.GetObject("imgClientes.Image")));
			this.imgClientes.Location = new System.Drawing.Point(485, 11);
			this.imgClientes.Name = "imgClientes";
			this.imgClientes.Size = new System.Drawing.Size(22, 22);
			this.imgClientes.TabIndex = 195;
			this.imgClientes.TabStop = false;
			this.imgClientes.Click += new System.EventHandler(this.ImgClientesClick);
			// 
			// lblTotalAcoes
			// 
			this.lblTotalAcoes.ForeColor = System.Drawing.Color.Red;
			this.lblTotalAcoes.Location = new System.Drawing.Point(776, 350);
			this.lblTotalAcoes.Name = "lblTotalAcoes";
			this.lblTotalAcoes.Size = new System.Drawing.Size(165, 23);
			this.lblTotalAcoes.TabIndex = 196;
			this.lblTotalAcoes.Text = "XX ações selecionadas";
			this.lblTotalAcoes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(946, 664);
			this.Controls.Add(this.lblTotalAcoes);
			this.Controls.Add(this.imgClientes);
			this.Controls.Add(this.btnEstatisticas);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnConcorrentes);
			this.Controls.Add(this.lnkAgenda);
			this.Controls.Add(this.lnkContatos);
			this.Controls.Add(this.btnOrcamentos);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnObservacao);
			this.Controls.Add(this.btnConsultor);
			this.Controls.Add(this.btnCliente);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnProdutos);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnFecha);
			this.Controls.Add(this.btnAltera);
			this.Controls.Add(this.btnExclui);
			this.Controls.Add(this.btnInclui);
			this.Controls.Add(this.dgvHistorico);
			this.Controls.Add(this.dgvContatos);
			this.Controls.Add(this.btnDown);
			this.Controls.Add(this.btnUp);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.btnFiltro);
			this.Controls.Add(this.edtLocaliza);
			this.Controls.Add(this.dgvAcoes);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sistema SOFT - Ação Comercial - v2.9.1 (19/02/22)";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgvAcoes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvContatos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvHistorico)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgClientes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.Button btnEstatisticas;
		public System.Windows.Forms.Button button2;
		public System.Windows.Forms.Button button1;
		public System.Windows.Forms.Button btnConcorrentes;
		private System.Windows.Forms.LinkLabel lnkAgenda;
		private System.Windows.Forms.LinkLabel lnkContatos;
		public System.Windows.Forms.Button btnOrcamentos;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.Button btnObservacao;
		public System.Windows.Forms.Button btnCliente;
		public System.Windows.Forms.Button btnConsultor;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.DataGridView dgvHistorico;
		public System.Windows.Forms.DataGridView dgvContatos;
		public System.Windows.Forms.Button btnProdutos;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolTip toolTip1;
		public System.Windows.Forms.Button btnInclui;
		public System.Windows.Forms.Button btnExclui;
		public System.Windows.Forms.Button btnAltera;
		public System.Windows.Forms.Button btnFecha;
		public System.Windows.Forms.DataGridView dgvAcoes;
		public System.Windows.Forms.TextBox edtLocaliza;
		private System.Windows.Forms.Button btnFiltro;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.Label label16;
		public System.Windows.Forms.Button btnUp;
		public System.Windows.Forms.Button btnDown;
		private System.Windows.Forms.PictureBox imgClientes;
		private System.Windows.Forms.Label lblTotalAcoes;
	}
}
