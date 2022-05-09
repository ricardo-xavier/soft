/*
 * Usuário: Ricardo
 * Data: 27/04/2008
 * Hora: 19:44
 * 
 */
namespace basico
{
	partial class frmCadCaracteristicas
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadCaracteristicas));
			this.lblParceiro = new System.Windows.Forms.Label();
			this.edtParceiro = new System.Windows.Forms.TextBox();
			this.btnFornecedor = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.edtConsultor = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.edtVendedor = new System.Windows.Forms.TextBox();
			this.gbxObservacao = new System.Windows.Forms.GroupBox();
			this.edtObservacao = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.edtLimiar = new System.Windows.Forms.TextBox();
			this.gbxRacional = new System.Windows.Forms.GroupBox();
			this.edtRacional = new System.Windows.Forms.TextBox();
			this.btnComissoes = new System.Windows.Forms.Button();
			this.btnCopia = new System.Windows.Forms.Button();
			this.chkAtivo = new System.Windows.Forms.CheckBox();
			this.chkFiltroAtivos = new System.Windows.Forms.CheckBox();
			this.edtFormulaPedido = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.edtServico = new System.Windows.Forms.TextBox();
			this.edtDias = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.edtFilial = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.edtFrete = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabControl2 = new System.Windows.Forms.TabControl();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.edtFilialServicos = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.edtFilialProdutos = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.edtConsultorServicos = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.edtConsultorProdutos = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.edtVendedorServicos = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.edtVendedorProdutos = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.cbxTermosAprovacao = new System.Windows.Forms.ComboBox();
			this.label24 = new System.Windows.Forms.Label();
			this.cbxCondicoesMontagem = new System.Windows.Forms.ComboBox();
			this.label23 = new System.Windows.Forms.Label();
			this.cbxTermosGarantia = new System.Windows.Forms.ComboBox();
			this.label22 = new System.Windows.Forms.Label();
			this.cbxInformacoesFornecimento = new System.Windows.Forms.ComboBox();
			this.label21 = new System.Windows.Forms.Label();
			this.cbxIntroducoes = new System.Windows.Forms.ComboBox();
			this.label20 = new System.Windows.Forms.Label();
			this.chkIPI = new System.Windows.Forms.CheckBox();
			this.pnlEdicao.SuspendLayout();
			this.gbxObservacao.SuspendLayout();
			this.gbxRacional.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.tabControl2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(776, 335);
			this.btnCancela.TabIndex = 18;
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(670, 335);
			this.btnConfirma.TabIndex = 17;
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// edtCodigo
			// 
			this.edtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
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
			this.lblDescricao.Text = "Fórmula";
			// 
			// pnlEdicao
			// 
			this.pnlEdicao.Controls.Add(this.chkIPI);
			this.pnlEdicao.Controls.Add(this.tabControl2);
			this.pnlEdicao.Controls.Add(this.edtFrete);
			this.pnlEdicao.Controls.Add(this.label13);
			this.pnlEdicao.Controls.Add(this.edtFilial);
			this.pnlEdicao.Controls.Add(this.label12);
			this.pnlEdicao.Controls.Add(this.edtDias);
			this.pnlEdicao.Controls.Add(this.label5);
			this.pnlEdicao.Controls.Add(this.groupBox1);
			this.pnlEdicao.Controls.Add(this.edtFormulaPedido);
			this.pnlEdicao.Controls.Add(this.label4);
			this.pnlEdicao.Controls.Add(this.chkAtivo);
			this.pnlEdicao.Controls.Add(this.gbxRacional);
			this.pnlEdicao.Controls.Add(this.edtLimiar);
			this.pnlEdicao.Controls.Add(this.label3);
			this.pnlEdicao.Controls.Add(this.gbxObservacao);
			this.pnlEdicao.Controls.Add(this.edtVendedor);
			this.pnlEdicao.Controls.Add(this.label2);
			this.pnlEdicao.Controls.Add(this.edtConsultor);
			this.pnlEdicao.Controls.Add(this.label1);
			this.pnlEdicao.Controls.Add(this.btnFornecedor);
			this.pnlEdicao.Controls.Add(this.edtParceiro);
			this.pnlEdicao.Controls.Add(this.lblParceiro);
			this.pnlEdicao.Location = new System.Drawing.Point(10, 275);
			this.pnlEdicao.Size = new System.Drawing.Size(883, 368);
			this.pnlEdicao.Controls.SetChildIndex(this.lblParceiro, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtParceiro, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.btnFornecedor, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.label1, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtConsultor, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.label2, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtVendedor, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.gbxObservacao, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.label3, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtLimiar, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.gbxRacional, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.chkAtivo, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.label4, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtFormulaPedido, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.groupBox1, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblCodigo, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblDescricao, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtCodigo, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtDescricao, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.btnConfirma, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.btnCancela, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.label5, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtDias, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.label12, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtFilial, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.label13, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtFrete, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.tabControl2, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.chkIPI, 0);
			// 
			// btnFecha
			// 
			this.btnFecha.Location = new System.Drawing.Point(793, 192);
			this.btnFecha.TabIndex = 8;
			// 
			// btnAltera
			// 
			this.btnAltera.Location = new System.Drawing.Point(793, 100);
			this.btnAltera.Click += new System.EventHandler(this.BtnAlteraClick);
			// 
			// btnExclui
			// 
			this.btnExclui.Location = new System.Drawing.Point(793, 70);
			this.btnExclui.Click += new System.EventHandler(this.BtnExcluiClick);
			// 
			// btnInclui
			// 
			this.btnInclui.Location = new System.Drawing.Point(793, 40);
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
			// btnFornecedor
			// 
			this.btnFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("btnFornecedor.Image")));
			this.btnFornecedor.Location = new System.Drawing.Point(267, 9);
			this.btnFornecedor.Name = "btnFornecedor";
			this.btnFornecedor.Size = new System.Drawing.Size(36, 23);
			this.btnFornecedor.TabIndex = 1;
			this.btnFornecedor.UseVisualStyleBackColor = true;
			this.btnFornecedor.Click += new System.EventHandler(this.BtnFornecedorClick);
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(10, 100);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 20);
			this.label1.TabIndex = 78;
			this.label1.Text = "% Consultor";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtConsultor
			// 
			this.edtConsultor.BackColor = System.Drawing.SystemColors.Window;
			this.edtConsultor.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtConsultor.Location = new System.Drawing.Point(115, 100);
			this.edtConsultor.MaxLength = 50;
			this.edtConsultor.Name = "edtConsultor";
			this.edtConsultor.Size = new System.Drawing.Size(41, 20);
			this.edtConsultor.TabIndex = 5;
			this.edtConsultor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.edtConsultor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EdtConsultorKeyPress);
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label2.Location = new System.Drawing.Point(180, 100);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 20);
			this.label2.TabIndex = 80;
			this.label2.Text = "% Vendedor";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtVendedor
			// 
			this.edtVendedor.BackColor = System.Drawing.SystemColors.Window;
			this.edtVendedor.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtVendedor.Location = new System.Drawing.Point(265, 100);
			this.edtVendedor.MaxLength = 50;
			this.edtVendedor.Name = "edtVendedor";
			this.edtVendedor.Size = new System.Drawing.Size(41, 20);
			this.edtVendedor.TabIndex = 6;
			this.edtVendedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.edtVendedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EdtConsultorKeyPress);
			// 
			// gbxObservacao
			// 
			this.gbxObservacao.Controls.Add(this.edtObservacao);
			this.gbxObservacao.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.gbxObservacao.Location = new System.Drawing.Point(50, 130);
			this.gbxObservacao.Name = "gbxObservacao";
			this.gbxObservacao.Size = new System.Drawing.Size(453, 60);
			this.gbxObservacao.TabIndex = 9;
			this.gbxObservacao.TabStop = false;
			this.gbxObservacao.Text = "Observação";
			// 
			// edtObservacao
			// 
			this.edtObservacao.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtObservacao.Location = new System.Drawing.Point(14, 17);
			this.edtObservacao.Multiline = true;
			this.edtObservacao.Name = "edtObservacao";
			this.edtObservacao.Size = new System.Drawing.Size(426, 40);
			this.edtObservacao.TabIndex = 7;
			this.edtObservacao.DoubleClick += new System.EventHandler(this.EdtObservacaoDoubleClick);
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label3.Location = new System.Drawing.Point(479, 101);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 20);
			this.label3.TabIndex = 81;
			this.label3.Text = "% Limiar";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtLimiar
			// 
			this.edtLimiar.BackColor = System.Drawing.SystemColors.Window;
			this.edtLimiar.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtLimiar.Location = new System.Drawing.Point(565, 100);
			this.edtLimiar.MaxLength = 50;
			this.edtLimiar.Name = "edtLimiar";
			this.edtLimiar.Size = new System.Drawing.Size(41, 20);
			this.edtLimiar.TabIndex = 8;
			this.edtLimiar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.edtLimiar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EdtConsultorKeyPress);
			// 
			// gbxRacional
			// 
			this.gbxRacional.Controls.Add(this.edtRacional);
			this.gbxRacional.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.gbxRacional.Location = new System.Drawing.Point(50, 200);
			this.gbxRacional.Name = "gbxRacional";
			this.gbxRacional.Size = new System.Drawing.Size(453, 60);
			this.gbxRacional.TabIndex = 10;
			this.gbxRacional.TabStop = false;
			this.gbxRacional.Text = "Racional";
			// 
			// edtRacional
			// 
			this.edtRacional.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtRacional.Location = new System.Drawing.Point(14, 17);
			this.edtRacional.Multiline = true;
			this.edtRacional.Name = "edtRacional";
			this.edtRacional.Size = new System.Drawing.Size(426, 40);
			this.edtRacional.TabIndex = 7;
			this.edtRacional.DoubleClick += new System.EventHandler(this.EdtRacionalDoubleClick);
			// 
			// btnComissoes
			// 
			this.btnComissoes.Location = new System.Drawing.Point(793, 130);
			this.btnComissoes.Name = "btnComissoes";
			this.btnComissoes.Size = new System.Drawing.Size(100, 25);
			this.btnComissoes.TabIndex = 6;
			this.btnComissoes.Text = "Comissões";
			this.btnComissoes.UseVisualStyleBackColor = true;
			this.btnComissoes.Click += new System.EventHandler(this.BtnComissoesClick);
			// 
			// btnCopia
			// 
			this.btnCopia.Location = new System.Drawing.Point(793, 160);
			this.btnCopia.Name = "btnCopia";
			this.btnCopia.Size = new System.Drawing.Size(100, 25);
			this.btnCopia.TabIndex = 7;
			this.btnCopia.Text = "&Copia";
			this.btnCopia.UseVisualStyleBackColor = true;
			this.btnCopia.Click += new System.EventHandler(this.EdtCopiaClick);
			// 
			// chkAtivo
			// 
			this.chkAtivo.Checked = true;
			this.chkAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkAtivo.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkAtivo.Location = new System.Drawing.Point(330, 340);
			this.chkAtivo.Name = "chkAtivo";
			this.chkAtivo.Size = new System.Drawing.Size(104, 24);
			this.chkAtivo.TabIndex = 16;
			this.chkAtivo.Text = "Ativo";
			this.chkAtivo.UseVisualStyleBackColor = true;
			// 
			// chkFiltroAtivos
			// 
			this.chkFiltroAtivos.Checked = true;
			this.chkFiltroAtivos.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkFiltroAtivos.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkFiltroAtivos.Location = new System.Drawing.Point(10, 245);
			this.chkFiltroAtivos.Name = "chkFiltroAtivos";
			this.chkFiltroAtivos.Size = new System.Drawing.Size(106, 24);
			this.chkFiltroAtivos.TabIndex = 10;
			this.chkFiltroAtivos.Text = "Somente Ativos";
			this.chkFiltroAtivos.UseVisualStyleBackColor = true;
			this.chkFiltroAtivos.CheckedChanged += new System.EventHandler(this.ChkFiltroAtivoCheckedChanged);
			// 
			// edtFormulaPedido
			// 
			this.edtFormulaPedido.BackColor = System.Drawing.SystemColors.Window;
			this.edtFormulaPedido.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtFormulaPedido.Location = new System.Drawing.Point(415, 70);
			this.edtFormulaPedido.MaxLength = 30;
			this.edtFormulaPedido.Name = "edtFormulaPedido";
			this.edtFormulaPedido.Size = new System.Drawing.Size(216, 20);
			this.edtFormulaPedido.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label4.Location = new System.Drawing.Point(359, 70);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(50, 20);
			this.label4.TabIndex = 83;
			this.label4.Text = "Pedido";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.edtServico);
			this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.groupBox1.Location = new System.Drawing.Point(50, 270);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(453, 60);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Serviço";
			// 
			// edtServico
			// 
			this.edtServico.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtServico.Location = new System.Drawing.Point(14, 17);
			this.edtServico.Multiline = true;
			this.edtServico.Name = "edtServico";
			this.edtServico.Size = new System.Drawing.Size(426, 40);
			this.edtServico.TabIndex = 7;
			this.edtServico.DoubleClick += new System.EventHandler(this.EdtServicoDoubleClick);
			// 
			// edtDias
			// 
			this.edtDias.BackColor = System.Drawing.SystemColors.Window;
			this.edtDias.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtDias.Location = new System.Drawing.Point(115, 340);
			this.edtDias.MaxLength = 2;
			this.edtDias.Name = "edtDias";
			this.edtDias.Size = new System.Drawing.Size(20, 20);
			this.edtDias.TabIndex = 13;
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label5.Location = new System.Drawing.Point(10, 340);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 20);
			this.label5.TabIndex = 11;
			this.label5.Text = "Dias p/ Montagem";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtFilial
			// 
			this.edtFilial.BackColor = System.Drawing.SystemColors.Window;
			this.edtFilial.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtFilial.Location = new System.Drawing.Point(415, 101);
			this.edtFilial.MaxLength = 50;
			this.edtFilial.Name = "edtFilial";
			this.edtFilial.Size = new System.Drawing.Size(41, 20);
			this.edtFilial.TabIndex = 7;
			this.edtFilial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label12
			// 
			this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label12.Location = new System.Drawing.Point(330, 101);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(80, 20);
			this.label12.TabIndex = 86;
			this.label12.Text = "% Filial";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtFrete
			// 
			this.edtFrete.BackColor = System.Drawing.SystemColors.Window;
			this.edtFrete.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtFrete.Location = new System.Drawing.Point(715, 100);
			this.edtFrete.MaxLength = 50;
			this.edtFrete.Name = "edtFrete";
			this.edtFrete.Size = new System.Drawing.Size(41, 20);
			this.edtFrete.TabIndex = 9;
			this.edtFrete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label13
			// 
			this.label13.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label13.Location = new System.Drawing.Point(629, 101);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(80, 20);
			this.label13.TabIndex = 88;
			this.label13.Text = "% Frete";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(128, 275);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(448, 199);
			this.tabControl1.TabIndex = 89;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.groupBox3);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(440, 173);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "tabPage1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.textBox1);
			this.groupBox3.Controls.Add(this.label14);
			this.groupBox3.Controls.Add(this.textBox2);
			this.groupBox3.Controls.Add(this.label15);
			this.groupBox3.Controls.Add(this.textBox3);
			this.groupBox3.Controls.Add(this.label16);
			this.groupBox3.Controls.Add(this.textBox4);
			this.groupBox3.Controls.Add(this.label17);
			this.groupBox3.Controls.Add(this.textBox5);
			this.groupBox3.Controls.Add(this.label18);
			this.groupBox3.Controls.Add(this.textBox6);
			this.groupBox3.Controls.Add(this.label19);
			this.groupBox3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.groupBox3.Location = new System.Drawing.Point(41, 47);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(358, 176);
			this.groupBox3.TabIndex = 13;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Descontos Comissão";
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.Window;
			this.textBox1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(119, 145);
			this.textBox1.MaxLength = 30;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(216, 20);
			this.textBox1.TabIndex = 12;
			// 
			// label14
			// 
			this.label14.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label14.Location = new System.Drawing.Point(2, 145);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(110, 20);
			this.label14.TabIndex = 98;
			this.label14.Text = "Filial/Serviços";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.SystemColors.Window;
			this.textBox2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(119, 120);
			this.textBox2.MaxLength = 30;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(216, 20);
			this.textBox2.TabIndex = 10;
			// 
			// label15
			// 
			this.label15.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label15.Location = new System.Drawing.Point(2, 120);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(110, 20);
			this.label15.TabIndex = 96;
			this.label15.Text = "Filial/Produtos";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox3
			// 
			this.textBox3.BackColor = System.Drawing.SystemColors.Window;
			this.textBox3.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox3.Location = new System.Drawing.Point(119, 95);
			this.textBox3.MaxLength = 30;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(216, 20);
			this.textBox3.TabIndex = 8;
			// 
			// label16
			// 
			this.label16.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label16.Location = new System.Drawing.Point(2, 95);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(110, 20);
			this.label16.TabIndex = 94;
			this.label16.Text = "Consultor/Serviços";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox4
			// 
			this.textBox4.BackColor = System.Drawing.SystemColors.Window;
			this.textBox4.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox4.Location = new System.Drawing.Point(119, 70);
			this.textBox4.MaxLength = 30;
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(216, 20);
			this.textBox4.TabIndex = 4;
			// 
			// label17
			// 
			this.label17.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label17.Location = new System.Drawing.Point(2, 70);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(110, 20);
			this.label17.TabIndex = 92;
			this.label17.Text = "Consultor/Produtos";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox5
			// 
			this.textBox5.BackColor = System.Drawing.SystemColors.Window;
			this.textBox5.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox5.Location = new System.Drawing.Point(119, 45);
			this.textBox5.MaxLength = 30;
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(216, 20);
			this.textBox5.TabIndex = 2;
			// 
			// label18
			// 
			this.label18.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label18.Location = new System.Drawing.Point(2, 45);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(110, 20);
			this.label18.TabIndex = 90;
			this.label18.Text = "Vendedor/Serviços";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox6
			// 
			this.textBox6.BackColor = System.Drawing.SystemColors.Window;
			this.textBox6.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox6.Location = new System.Drawing.Point(119, 20);
			this.textBox6.MaxLength = 30;
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(216, 20);
			this.textBox6.TabIndex = 0;
			// 
			// label19
			// 
			this.label19.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label19.Location = new System.Drawing.Point(2, 20);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(110, 20);
			this.label19.TabIndex = 88;
			this.label19.Text = "Vendedor/Produtos";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(440, 173);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tabControl2
			// 
			this.tabControl2.Controls.Add(this.tabPage3);
			this.tabControl2.Controls.Add(this.tabPage4);
			this.tabControl2.Location = new System.Drawing.Point(520, 137);
			this.tabControl2.Name = "tabControl2";
			this.tabControl2.SelectedIndex = 0;
			this.tabControl2.Size = new System.Drawing.Size(356, 184);
			this.tabControl2.TabIndex = 89;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.edtFilialServicos);
			this.tabPage3.Controls.Add(this.label11);
			this.tabPage3.Controls.Add(this.edtFilialProdutos);
			this.tabPage3.Controls.Add(this.label10);
			this.tabPage3.Controls.Add(this.edtConsultorServicos);
			this.tabPage3.Controls.Add(this.label9);
			this.tabPage3.Controls.Add(this.edtConsultorProdutos);
			this.tabPage3.Controls.Add(this.label8);
			this.tabPage3.Controls.Add(this.edtVendedorServicos);
			this.tabPage3.Controls.Add(this.label7);
			this.tabPage3.Controls.Add(this.edtVendedorProdutos);
			this.tabPage3.Controls.Add(this.label6);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(348, 158);
			this.tabPage3.TabIndex = 0;
			this.tabPage3.Text = "Descontos Comissão";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// edtFilialServicos
			// 
			this.edtFilialServicos.BackColor = System.Drawing.SystemColors.Window;
			this.edtFilialServicos.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtFilialServicos.Location = new System.Drawing.Point(124, 131);
			this.edtFilialServicos.MaxLength = 30;
			this.edtFilialServicos.Name = "edtFilialServicos";
			this.edtFilialServicos.Size = new System.Drawing.Size(216, 20);
			this.edtFilialServicos.TabIndex = 104;
			// 
			// label11
			// 
			this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label11.Location = new System.Drawing.Point(7, 131);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(110, 20);
			this.label11.TabIndex = 110;
			this.label11.Text = "Filial/Serviços";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtFilialProdutos
			// 
			this.edtFilialProdutos.BackColor = System.Drawing.SystemColors.Window;
			this.edtFilialProdutos.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtFilialProdutos.Location = new System.Drawing.Point(124, 106);
			this.edtFilialProdutos.MaxLength = 30;
			this.edtFilialProdutos.Name = "edtFilialProdutos";
			this.edtFilialProdutos.Size = new System.Drawing.Size(216, 20);
			this.edtFilialProdutos.TabIndex = 103;
			// 
			// label10
			// 
			this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label10.Location = new System.Drawing.Point(7, 106);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(110, 20);
			this.label10.TabIndex = 109;
			this.label10.Text = "Filial/Produtos";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtConsultorServicos
			// 
			this.edtConsultorServicos.BackColor = System.Drawing.SystemColors.Window;
			this.edtConsultorServicos.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtConsultorServicos.Location = new System.Drawing.Point(124, 81);
			this.edtConsultorServicos.MaxLength = 30;
			this.edtConsultorServicos.Name = "edtConsultorServicos";
			this.edtConsultorServicos.Size = new System.Drawing.Size(216, 20);
			this.edtConsultorServicos.TabIndex = 102;
			// 
			// label9
			// 
			this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label9.Location = new System.Drawing.Point(7, 81);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(110, 20);
			this.label9.TabIndex = 108;
			this.label9.Text = "Consultor/Serviços";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtConsultorProdutos
			// 
			this.edtConsultorProdutos.BackColor = System.Drawing.SystemColors.Window;
			this.edtConsultorProdutos.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtConsultorProdutos.Location = new System.Drawing.Point(124, 56);
			this.edtConsultorProdutos.MaxLength = 30;
			this.edtConsultorProdutos.Name = "edtConsultorProdutos";
			this.edtConsultorProdutos.Size = new System.Drawing.Size(216, 20);
			this.edtConsultorProdutos.TabIndex = 101;
			// 
			// label8
			// 
			this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label8.Location = new System.Drawing.Point(7, 56);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(110, 20);
			this.label8.TabIndex = 107;
			this.label8.Text = "Consultor/Produtos";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtVendedorServicos
			// 
			this.edtVendedorServicos.BackColor = System.Drawing.SystemColors.Window;
			this.edtVendedorServicos.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtVendedorServicos.Location = new System.Drawing.Point(124, 31);
			this.edtVendedorServicos.MaxLength = 30;
			this.edtVendedorServicos.Name = "edtVendedorServicos";
			this.edtVendedorServicos.Size = new System.Drawing.Size(216, 20);
			this.edtVendedorServicos.TabIndex = 100;
			// 
			// label7
			// 
			this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label7.Location = new System.Drawing.Point(7, 31);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(110, 20);
			this.label7.TabIndex = 106;
			this.label7.Text = "Vendedor/Serviços";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtVendedorProdutos
			// 
			this.edtVendedorProdutos.BackColor = System.Drawing.SystemColors.Window;
			this.edtVendedorProdutos.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtVendedorProdutos.Location = new System.Drawing.Point(124, 6);
			this.edtVendedorProdutos.MaxLength = 30;
			this.edtVendedorProdutos.Name = "edtVendedorProdutos";
			this.edtVendedorProdutos.Size = new System.Drawing.Size(216, 20);
			this.edtVendedorProdutos.TabIndex = 99;
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label6.Location = new System.Drawing.Point(7, 6);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(110, 20);
			this.label6.TabIndex = 105;
			this.label6.Text = "Vendedor/Produtos";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.cbxTermosAprovacao);
			this.tabPage4.Controls.Add(this.label24);
			this.tabPage4.Controls.Add(this.cbxCondicoesMontagem);
			this.tabPage4.Controls.Add(this.label23);
			this.tabPage4.Controls.Add(this.cbxTermosGarantia);
			this.tabPage4.Controls.Add(this.label22);
			this.tabPage4.Controls.Add(this.cbxInformacoesFornecimento);
			this.tabPage4.Controls.Add(this.label21);
			this.tabPage4.Controls.Add(this.cbxIntroducoes);
			this.tabPage4.Controls.Add(this.label20);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(348, 158);
			this.tabPage4.TabIndex = 1;
			this.tabPage4.Text = "Proposta Comercial";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// cbxTermosAprovacao
			// 
			this.cbxTermosAprovacao.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxTermosAprovacao.FormattingEnabled = true;
			this.cbxTermosAprovacao.Location = new System.Drawing.Point(176, 128);
			this.cbxTermosAprovacao.Name = "cbxTermosAprovacao";
			this.cbxTermosAprovacao.Size = new System.Drawing.Size(166, 22);
			this.cbxTermosAprovacao.TabIndex = 116;
			// 
			// label24
			// 
			this.label24.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label24.Location = new System.Drawing.Point(34, 128);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(136, 20);
			this.label24.TabIndex = 117;
			this.label24.Text = "Termo de Aprovação";
			this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxCondicoesMontagem
			// 
			this.cbxCondicoesMontagem.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxCondicoesMontagem.FormattingEnabled = true;
			this.cbxCondicoesMontagem.Location = new System.Drawing.Point(176, 100);
			this.cbxCondicoesMontagem.Name = "cbxCondicoesMontagem";
			this.cbxCondicoesMontagem.Size = new System.Drawing.Size(166, 22);
			this.cbxCondicoesMontagem.TabIndex = 114;
			// 
			// label23
			// 
			this.label23.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label23.Location = new System.Drawing.Point(34, 100);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(136, 20);
			this.label23.TabIndex = 115;
			this.label23.Text = "Condições para Montagem";
			this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxTermosGarantia
			// 
			this.cbxTermosGarantia.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxTermosGarantia.FormattingEnabled = true;
			this.cbxTermosGarantia.Location = new System.Drawing.Point(176, 72);
			this.cbxTermosGarantia.Name = "cbxTermosGarantia";
			this.cbxTermosGarantia.Size = new System.Drawing.Size(166, 22);
			this.cbxTermosGarantia.TabIndex = 112;
			// 
			// label22
			// 
			this.label22.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label22.Location = new System.Drawing.Point(34, 72);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(136, 20);
			this.label22.TabIndex = 113;
			this.label22.Text = "Termo de Garantia";
			this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxInformacoesFornecimento
			// 
			this.cbxInformacoesFornecimento.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxInformacoesFornecimento.FormattingEnabled = true;
			this.cbxInformacoesFornecimento.Location = new System.Drawing.Point(176, 44);
			this.cbxInformacoesFornecimento.Name = "cbxInformacoesFornecimento";
			this.cbxInformacoesFornecimento.Size = new System.Drawing.Size(166, 22);
			this.cbxInformacoesFornecimento.TabIndex = 110;
			// 
			// label21
			// 
			this.label21.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label21.Location = new System.Drawing.Point(6, 44);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(164, 20);
			this.label21.TabIndex = 111;
			this.label21.Text = "Informações de Fornecimento";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxIntroducoes
			// 
			this.cbxIntroducoes.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxIntroducoes.FormattingEnabled = true;
			this.cbxIntroducoes.Location = new System.Drawing.Point(176, 16);
			this.cbxIntroducoes.Name = "cbxIntroducoes";
			this.cbxIntroducoes.Size = new System.Drawing.Size(166, 22);
			this.cbxIntroducoes.TabIndex = 108;
			this.cbxIntroducoes.Text = "12345678901234567890";
			// 
			// label20
			// 
			this.label20.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label20.Location = new System.Drawing.Point(34, 16);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(136, 20);
			this.label20.TabIndex = 109;
			this.label20.Text = "Introdução";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// chkIPI
			// 
			this.chkIPI.Checked = true;
			this.chkIPI.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkIPI.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkIPI.Location = new System.Drawing.Point(194, 340);
			this.chkIPI.Name = "chkIPI";
			this.chkIPI.Size = new System.Drawing.Size(104, 24);
			this.chkIPI.TabIndex = 15;
			this.chkIPI.Text = "Imprime IPI";
			this.chkIPI.UseVisualStyleBackColor = true;
			// 
			// frmCadCaracteristicas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(905, 649);
			this.Controls.Add(this.chkFiltroAtivos);
			this.Controls.Add(this.btnCopia);
			this.Controls.Add(this.btnComissoes);
			this.Controls.Add(this.tabControl1);
			this.Name = "frmCadCaracteristicas";
			this.Text = "Cadastros Básicos - Características de Venda";
			this.Load += new System.EventHandler(this.FrmCadCaracteristicasLoad);
			this.Controls.SetChildIndex(this.tabControl1, 0);
			this.Controls.SetChildIndex(this.btnExclui, 0);
			this.Controls.SetChildIndex(this.btnAltera, 0);
			this.Controls.SetChildIndex(this.btnFecha, 0);
			this.Controls.SetChildIndex(this.btnComissoes, 0);
			this.Controls.SetChildIndex(this.btnCopia, 0);
			this.Controls.SetChildIndex(this.btnInclui, 0);
			this.Controls.SetChildIndex(this.chkFiltroAtivos, 0);
			this.Controls.SetChildIndex(this.pnlEdicao, 0);
			this.Controls.SetChildIndex(this.edtLocaliza, 0);
			this.Controls.SetChildIndex(this.btnLocaliza, 0);
			this.Controls.SetChildIndex(this.btnUp, 0);
			this.Controls.SetChildIndex(this.btnDown, 0);
			this.pnlEdicao.ResumeLayout(false);
			this.pnlEdicao.PerformLayout();
			this.gbxObservacao.ResumeLayout(false);
			this.gbxObservacao.PerformLayout();
			this.gbxRacional.ResumeLayout(false);
			this.gbxRacional.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.tabControl2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.tabPage4.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.CheckBox chkIPI;
		public System.Windows.Forms.ComboBox cbxIntroducoes;
		public System.Windows.Forms.ComboBox cbxTermosGarantia;
		public System.Windows.Forms.ComboBox cbxTermosAprovacao;
		public System.Windows.Forms.ComboBox cbxCondicoesMontagem;
		public System.Windows.Forms.ComboBox cbxInformacoesFornecimento;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabControl tabControl2;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox edtFrete;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox edtFilial;
		private System.Windows.Forms.TextBox edtVendedorProdutos;
		private System.Windows.Forms.TextBox edtFilialServicos;
		private System.Windows.Forms.TextBox edtFilialProdutos;
		private System.Windows.Forms.TextBox edtConsultorServicos;
		private System.Windows.Forms.TextBox edtConsultorProdutos;
		private System.Windows.Forms.TextBox edtVendedorServicos;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox edtDias;
		public System.Windows.Forms.TextBox edtServico;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnCopia;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox edtFormulaPedido;
		private System.Windows.Forms.CheckBox chkFiltroAtivos;
		private System.Windows.Forms.CheckBox chkAtivo;
		private System.Windows.Forms.Button btnComissoes;
		public System.Windows.Forms.TextBox edtRacional;
		private System.Windows.Forms.GroupBox gbxRacional;
		private System.Windows.Forms.GroupBox gbxObservacao;
		private System.Windows.Forms.TextBox edtLimiar;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.TextBox edtObservacao;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox edtConsultor;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox edtVendedor;
		private System.Windows.Forms.Button btnFornecedor;
		private System.Windows.Forms.Label lblParceiro;
		private System.Windows.Forms.TextBox edtParceiro;
	}
}
