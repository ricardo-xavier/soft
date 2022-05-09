/*
 * Criado por SharpDevelop.
 * Usuário: Ricardo
 * Data: 04/06/2008
 * Hora: 21:04
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace orcamento
{
	partial class frmCadItens
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadItens));
			this.lblOrcamento = new System.Windows.Forms.Label();
			this.btnProduto = new System.Windows.Forms.Button();
			this.edtProduto = new System.Windows.Forms.TextBox();
			this.lblProduto = new System.Windows.Forms.Label();
			this.lblQtde = new System.Windows.Forms.Label();
			this.edtQtde = new System.Windows.Forms.TextBox();
			this.lblMedidas = new System.Windows.Forms.Label();
			this.edtMedidas = new System.Windows.Forms.TextBox();
			this.lblPrecoTabela = new System.Windows.Forms.Label();
			this.lblPrecoVenda = new System.Windows.Forms.Label();
			this.gbxFoto = new System.Windows.Forms.GroupBox();
			this.imgProduto = new System.Windows.Forms.PictureBox();
			this.ckbEspecial = new System.Windows.Forms.CheckBox();
			this.edtSubCodigo = new System.Windows.Forms.TextBox();
			this.edtPrecoFormula = new System.Windows.Forms.TextBox();
			this.edtPrecoTotal = new System.Windows.Forms.TextBox();
			this.btnPesquisaRapida = new System.Windows.Forms.Button();
			this.btnCalculo = new System.Windows.Forms.Button();
			this.btnQrcode = new System.Windows.Forms.Button();
			this.gbxPendencia = new System.Windows.Forms.GroupBox();
			this.edtTexto = new System.Windows.Forms.TextBox();
			this.edtDescricaoProd = new System.Windows.Forms.TextBox();
			this.edtArea = new System.Windows.Forms.TextBox();
			this.lblArea = new System.Windows.Forms.Label();
			this.btnDuplica = new System.Windows.Forms.Button();
			this.edtEspecificos = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvFormula = new System.Windows.Forms.DataGridView();
			this.edtPrecoGenerico = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.ckbGenerico = new System.Windows.Forms.CheckBox();
			this.pnlEdicao.SuspendLayout();
			this.gbxFoto.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgProduto)).BeginInit();
			this.gbxPendencia.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvFormula)).BeginInit();
			this.SuspendLayout();
			this.dgvCadastro.Sorted += new System.EventHandler(this.DgvCadastroSorted);
			// 
			// btnLocaliza
			// 
			this.btnLocaliza.Location = new System.Drawing.Point(280, 43);
			this.btnLocaliza.Margin = new System.Windows.Forms.Padding(5);
			// 
			// edtLocaliza
			// 
			this.edtLocaliza.Location = new System.Drawing.Point(13, 48);
			this.edtLocaliza.Margin = new System.Windows.Forms.Padding(5);
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(817, 367);
			this.btnCancela.Margin = new System.Windows.Forms.Padding(5);
			this.btnCancela.TabIndex = 32;
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(671, 367);
			this.btnConfirma.Margin = new System.Windows.Forms.Padding(5);
			this.btnConfirma.TabIndex = 30;
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// edtCodigo
			// 
			this.edtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtCodigo.Location = new System.Drawing.Point(811, 4);
			this.edtCodigo.Margin = new System.Windows.Forms.Padding(5);
			this.edtCodigo.MaxLength = 30;
			this.edtCodigo.Size = new System.Drawing.Size(287, 23);
			this.edtCodigo.Visible = false;
			// 
			// edtDescricao
			// 
			this.edtDescricao.BackColor = System.Drawing.SystemColors.Info;
			this.edtDescricao.Location = new System.Drawing.Point(153, 12);
			this.edtDescricao.Margin = new System.Windows.Forms.Padding(5);
			this.edtDescricao.MaxLength = 4;
			this.edtDescricao.ReadOnly = true;
			this.edtDescricao.Size = new System.Drawing.Size(44, 23);
			this.edtDescricao.TabIndex = 0;
			// 
			// lblCodigo
			// 
			this.lblCodigo.Location = new System.Drawing.Point(811, 4);
			this.lblCodigo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lblCodigo.Size = new System.Drawing.Size(177, 31);
			this.lblCodigo.Text = "Área";
			this.lblCodigo.Visible = false;
			// 
			// lblDescricao
			// 
			this.lblDescricao.Location = new System.Drawing.Point(13, 12);
			this.lblDescricao.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lblDescricao.Size = new System.Drawing.Size(177, 31);
			this.lblDescricao.Text = "Sequencia";
			// 
			// pnlEdicao
			// 
			this.pnlEdicao.Controls.Add(this.ckbGenerico);
			this.pnlEdicao.Controls.Add(this.edtPrecoGenerico);
			this.pnlEdicao.Controls.Add(this.label2);
			this.pnlEdicao.Controls.Add(this.dgvFormula);
			this.pnlEdicao.Controls.Add(this.edtEspecificos);
			this.pnlEdicao.Controls.Add(this.label1);
			this.pnlEdicao.Controls.Add(this.edtArea);
			this.pnlEdicao.Controls.Add(this.lblArea);
			this.pnlEdicao.Controls.Add(this.edtDescricaoProd);
			this.pnlEdicao.Controls.Add(this.gbxPendencia);
			this.pnlEdicao.Controls.Add(this.btnCalculo);
			this.pnlEdicao.Controls.Add(this.btnQrcode);
			this.pnlEdicao.Controls.Add(this.btnPesquisaRapida);
			this.pnlEdicao.Controls.Add(this.edtPrecoTotal);
			this.pnlEdicao.Controls.Add(this.edtPrecoFormula);
			this.pnlEdicao.Controls.Add(this.edtSubCodigo);
			this.pnlEdicao.Controls.Add(this.ckbEspecial);
			this.pnlEdicao.Controls.Add(this.gbxFoto);
			this.pnlEdicao.Controls.Add(this.lblPrecoVenda);
			this.pnlEdicao.Controls.Add(this.lblPrecoTabela);
			this.pnlEdicao.Controls.Add(this.edtMedidas);
			this.pnlEdicao.Controls.Add(this.lblMedidas);
			this.pnlEdicao.Controls.Add(this.edtQtde);
			this.pnlEdicao.Controls.Add(this.lblQtde);
			this.pnlEdicao.Controls.Add(this.btnProduto);
			this.pnlEdicao.Controls.Add(this.edtProduto);
			this.pnlEdicao.Controls.Add(this.lblProduto);
			this.pnlEdicao.Location = new System.Drawing.Point(13, 277);
			this.pnlEdicao.Margin = new System.Windows.Forms.Padding(5);
			this.pnlEdicao.Size = new System.Drawing.Size(959, 419);
			this.pnlEdicao.Controls.SetChildIndex(this.lblProduto, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtProduto, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.btnProduto, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblQtde, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtQtde, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblMedidas, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtMedidas, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblPrecoTabela, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblPrecoVenda, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.gbxFoto, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.ckbEspecial, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtSubCodigo, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtPrecoFormula, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtPrecoTotal, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.btnPesquisaRapida, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.btnCalculo, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.btnQrcode, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.gbxPendencia, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtDescricaoProd, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblArea, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtArea, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.label1, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtEspecificos, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.dgvFormula, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblCodigo, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblDescricao, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtCodigo, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtDescricao, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.btnConfirma, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.btnCancela, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.label2, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtPrecoGenerico, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.ckbGenerico, 0);
			// 
			// btnFecha
			// 
			this.btnFecha.Location = new System.Drawing.Point(827, 233);
			this.btnFecha.Margin = new System.Windows.Forms.Padding(5);
			this.btnFecha.TabIndex = 7;
			// 
			// btnAltera
			// 
			this.btnAltera.Location = new System.Drawing.Point(827, 156);
			this.btnAltera.Margin = new System.Windows.Forms.Padding(5);
			this.btnAltera.Click += new System.EventHandler(this.BtnAlteraClick);
			// 
			// btnExclui
			// 
			this.btnExclui.Location = new System.Drawing.Point(827, 119);
			this.btnExclui.Margin = new System.Windows.Forms.Padding(5);
			this.btnExclui.Click += new System.EventHandler(this.BtnExcluiClick);
			// 
			// btnInclui
			// 
			this.btnInclui.Location = new System.Drawing.Point(827, 82);
			this.btnInclui.Margin = new System.Windows.Forms.Padding(5);
			this.btnInclui.Click += new System.EventHandler(this.BtnIncluiClick);
			// 
			// lblOrcamento
			// 
			this.lblOrcamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOrcamento.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblOrcamento.Location = new System.Drawing.Point(16, 10);
			this.lblOrcamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblOrcamento.Name = "lblOrcamento";
			this.lblOrcamento.Size = new System.Drawing.Size(843, 25);
			this.lblOrcamento.TabIndex = 25;
			this.lblOrcamento.Text = "Orçamento:";
			this.lblOrcamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnProduto
			// 
			this.btnProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnProduto.Image")));
			this.btnProduto.Location = new System.Drawing.Point(475, 48);
			this.btnProduto.Margin = new System.Windows.Forms.Padding(4);
			this.btnProduto.Name = "btnProduto";
			this.btnProduto.Size = new System.Drawing.Size(48, 28);
			this.btnProduto.TabIndex = 10;
			this.btnProduto.UseVisualStyleBackColor = true;
			this.btnProduto.Click += new System.EventHandler(this.BtnProdutoClick);
			// 
			// edtProduto
			// 
			this.edtProduto.BackColor = System.Drawing.SystemColors.Window;
			this.edtProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtProduto.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtProduto.Location = new System.Drawing.Point(153, 49);
			this.edtProduto.Margin = new System.Windows.Forms.Padding(4);
			this.edtProduto.MaxLength = 20;
			this.edtProduto.Name = "edtProduto";
			this.edtProduto.ReadOnly = true;
			this.edtProduto.Size = new System.Drawing.Size(193, 23);
			this.edtProduto.TabIndex = 4;
			this.edtProduto.TextChanged += new System.EventHandler(this.EdtProdutoTextChanged);
			this.edtProduto.Enter += new System.EventHandler(this.EdtProdutoEnter);
			this.edtProduto.Leave += new System.EventHandler(this.EdtProdutoLeave);
			// 
			// lblProduto
			// 
			this.lblProduto.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblProduto.Location = new System.Drawing.Point(13, 49);
			this.lblProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblProduto.Name = "lblProduto";
			this.lblProduto.Size = new System.Drawing.Size(133, 25);
			this.lblProduto.TabIndex = 77;
			this.lblProduto.Text = "Produto";
			this.lblProduto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblQtde
			// 
			this.lblQtde.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblQtde.Location = new System.Drawing.Point(13, 160);
			this.lblQtde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblQtde.Name = "lblQtde";
			this.lblQtde.Size = new System.Drawing.Size(133, 25);
			this.lblQtde.TabIndex = 80;
			this.lblQtde.Text = "Quantidade";
			this.lblQtde.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtQtde
			// 
			this.edtQtde.BackColor = System.Drawing.SystemColors.Window;
			this.edtQtde.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtQtde.Location = new System.Drawing.Point(153, 160);
			this.edtQtde.Margin = new System.Windows.Forms.Padding(4);
			this.edtQtde.MaxLength = 4;
			this.edtQtde.Name = "edtQtde";
			this.edtQtde.Size = new System.Drawing.Size(44, 23);
			this.edtQtde.TabIndex = 18;
			this.edtQtde.Text = "0";
			this.edtQtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.edtQtde.TextChanged += new System.EventHandler(this.EdtQtdeTextChanged);
			// 
			// lblMedidas
			// 
			this.lblMedidas.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblMedidas.Location = new System.Drawing.Point(13, 123);
			this.lblMedidas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblMedidas.Name = "lblMedidas";
			this.lblMedidas.Size = new System.Drawing.Size(133, 25);
			this.lblMedidas.TabIndex = 82;
			this.lblMedidas.Text = "Medidas";
			this.lblMedidas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtMedidas
			// 
			this.edtMedidas.BackColor = System.Drawing.SystemColors.Window;
			this.edtMedidas.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtMedidas.Location = new System.Drawing.Point(153, 123);
			this.edtMedidas.Margin = new System.Windows.Forms.Padding(4);
			this.edtMedidas.MaxLength = 20;
			this.edtMedidas.Name = "edtMedidas";
			this.edtMedidas.Size = new System.Drawing.Size(193, 23);
			this.edtMedidas.TabIndex = 16;
			// 
			// lblPrecoTabela
			// 
			this.lblPrecoTabela.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblPrecoTabela.Location = new System.Drawing.Point(13, 224);
			this.lblPrecoTabela.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPrecoTabela.Name = "lblPrecoTabela";
			this.lblPrecoTabela.Size = new System.Drawing.Size(133, 25);
			this.lblPrecoTabela.TabIndex = 85;
			this.lblPrecoTabela.Text = "Preço Unitário";
			this.lblPrecoTabela.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblPrecoVenda
			// 
			this.lblPrecoVenda.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblPrecoVenda.Location = new System.Drawing.Point(13, 261);
			this.lblPrecoVenda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPrecoVenda.Name = "lblPrecoVenda";
			this.lblPrecoVenda.Size = new System.Drawing.Size(133, 25);
			this.lblPrecoVenda.TabIndex = 88;
			this.lblPrecoVenda.Text = "Preço Total";
			this.lblPrecoVenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// gbxFoto
			// 
			this.gbxFoto.Controls.Add(this.imgProduto);
			this.gbxFoto.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.gbxFoto.Location = new System.Drawing.Point(640, 86);
			this.gbxFoto.Margin = new System.Windows.Forms.Padding(4);
			this.gbxFoto.Name = "gbxFoto";
			this.gbxFoto.Padding = new System.Windows.Forms.Padding(4);
			this.gbxFoto.Size = new System.Drawing.Size(296, 212);
			this.gbxFoto.TabIndex = 14;
			this.gbxFoto.TabStop = false;
			this.gbxFoto.Text = "Foto";
			// 
			// imgProduto
			// 
			this.imgProduto.Enabled = false;
			this.imgProduto.Location = new System.Drawing.Point(13, 18);
			this.imgProduto.Margin = new System.Windows.Forms.Padding(4);
			this.imgProduto.Name = "imgProduto";
			this.imgProduto.Size = new System.Drawing.Size(269, 186);
			this.imgProduto.TabIndex = 0;
			this.imgProduto.TabStop = false;
			this.imgProduto.Paint += new System.Windows.Forms.PaintEventHandler(this.ImgProdutoPaint);
			// 
			// ckbEspecial
			// 
			this.ckbEspecial.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.ckbEspecial.Location = new System.Drawing.Point(227, 160);
			this.ckbEspecial.Margin = new System.Windows.Forms.Padding(4);
			this.ckbEspecial.Name = "ckbEspecial";
			this.ckbEspecial.Size = new System.Drawing.Size(99, 27);
			this.ckbEspecial.TabIndex = 20;
			this.ckbEspecial.Text = "Manual";
			this.ckbEspecial.UseVisualStyleBackColor = true;
			this.ckbEspecial.CheckedChanged += new System.EventHandler(this.CkbEspecialCheckedChanged);
			// 
			// edtSubCodigo
			// 
			this.edtSubCodigo.BackColor = System.Drawing.SystemColors.Window;
			this.edtSubCodigo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtSubCodigo.Location = new System.Drawing.Point(356, 49);
			this.edtSubCodigo.Margin = new System.Windows.Forms.Padding(4);
			this.edtSubCodigo.MaxLength = 5;
			this.edtSubCodigo.Name = "edtSubCodigo";
			this.edtSubCodigo.ReadOnly = true;
			this.edtSubCodigo.Size = new System.Drawing.Size(53, 23);
			this.edtSubCodigo.TabIndex = 6;
			this.edtSubCodigo.TextChanged += new System.EventHandler(this.EdtSubCodigoTextChanged);
			// 
			// edtPrecoFormula
			// 
			this.edtPrecoFormula.BackColor = System.Drawing.SystemColors.Window;
			this.edtPrecoFormula.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtPrecoFormula.Location = new System.Drawing.Point(153, 224);
			this.edtPrecoFormula.Margin = new System.Windows.Forms.Padding(4);
			this.edtPrecoFormula.MaxLength = 20;
			this.edtPrecoFormula.Name = "edtPrecoFormula";
			this.edtPrecoFormula.Size = new System.Drawing.Size(147, 23);
			this.edtPrecoFormula.TabIndex = 22;
			this.edtPrecoFormula.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.edtPrecoFormula.TextChanged += new System.EventHandler(this.EdtPrecoFormulaTextChanged);
			// 
			// edtPrecoTotal
			// 
			this.edtPrecoTotal.BackColor = System.Drawing.SystemColors.Window;
			this.edtPrecoTotal.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtPrecoTotal.Location = new System.Drawing.Point(153, 261);
			this.edtPrecoTotal.Margin = new System.Windows.Forms.Padding(4);
			this.edtPrecoTotal.MaxLength = 20;
			this.edtPrecoTotal.Name = "edtPrecoTotal";
			this.edtPrecoTotal.Size = new System.Drawing.Size(147, 23);
			this.edtPrecoTotal.TabIndex = 26;
			this.edtPrecoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btnPesquisaRapida
			// 
			this.btnPesquisaRapida.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisaRapida.Image")));
			this.btnPesquisaRapida.Location = new System.Drawing.Point(419, 48);
			this.btnPesquisaRapida.Margin = new System.Windows.Forms.Padding(4);
			this.btnPesquisaRapida.Name = "btnPesquisaRapida";
			this.btnPesquisaRapida.Size = new System.Drawing.Size(48, 28);
			this.btnPesquisaRapida.TabIndex = 8;
			this.btnPesquisaRapida.UseVisualStyleBackColor = true;
			this.btnPesquisaRapida.Click += new System.EventHandler(this.BtnPesquisaRapidaClick);
			// 
			// btnCalculo
			// 
			this.btnCalculo.Image = ((System.Drawing.Image)(resources.GetObject("btnCalculo.Image")));
			this.btnCalculo.Location = new System.Drawing.Point(309, 223);
			this.btnCalculo.Margin = new System.Windows.Forms.Padding(4);
			this.btnCalculo.Name = "btnCalculo";
			this.btnCalculo.Size = new System.Drawing.Size(48, 28);
			this.btnCalculo.TabIndex = 24;
			this.btnCalculo.UseVisualStyleBackColor = true;
			this.btnCalculo.MouseEnter += new System.EventHandler(this.BtnCalculoMouseEnter);
			this.btnCalculo.MouseLeave += new System.EventHandler(this.BtnCalculoMouseLeave);
			// 
			// btnQrcode
			// 
			System.ComponentModel.ComponentResourceManager resourcesConsulta = new System.ComponentModel.ComponentResourceManager(typeof(fConsultaPreco));
			this.btnQrcode.Image = ((System.Drawing.Image)(resourcesConsulta.GetObject("btnQrcode.Image")));
			this.btnQrcode.Location = new System.Drawing.Point(309, 258);
			this.btnQrcode.Name = "btnQrcode";
			this.btnQrcode.Size = new System.Drawing.Size(48, 28);
			this.btnQrcode.TabIndex = 116;
			this.btnQrcode.UseVisualStyleBackColor = true;
			this.btnQrcode.Click += new System.EventHandler(this.BtnQrcodeClick);
			// 
			// gbxPendencia
			// 
			this.gbxPendencia.Controls.Add(this.edtTexto);
			this.gbxPendencia.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.gbxPendencia.Location = new System.Drawing.Point(13, 298);
			this.gbxPendencia.Margin = new System.Windows.Forms.Padding(4);
			this.gbxPendencia.Name = "gbxPendencia";
			this.gbxPendencia.Padding = new System.Windows.Forms.Padding(4);
			this.gbxPendencia.Size = new System.Drawing.Size(600, 101);
			this.gbxPendencia.TabIndex = 28;
			this.gbxPendencia.TabStop = false;
			this.gbxPendencia.Text = "Descrição Detalhada";
			// 
			// edtTexto
			// 
			this.edtTexto.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtTexto.Location = new System.Drawing.Point(19, 21);
			this.edtTexto.Margin = new System.Windows.Forms.Padding(4);
			this.edtTexto.Multiline = true;
			this.edtTexto.Name = "edtTexto";
			this.edtTexto.Size = new System.Drawing.Size(567, 73);
			this.edtTexto.TabIndex = 8;
			// 
			// edtDescricaoProd
			// 
			this.edtDescricaoProd.BackColor = System.Drawing.SystemColors.Window;
			this.edtDescricaoProd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtDescricaoProd.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtDescricaoProd.Location = new System.Drawing.Point(531, 49);
			this.edtDescricaoProd.Margin = new System.Windows.Forms.Padding(4);
			this.edtDescricaoProd.MaxLength = 50;
			this.edtDescricaoProd.Name = "edtDescricaoProd";
			this.edtDescricaoProd.Size = new System.Drawing.Size(380, 23);
			this.edtDescricaoProd.TabIndex = 12;
			// 
			// edtArea
			// 
			this.edtArea.BackColor = System.Drawing.SystemColors.Window;
			this.edtArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtArea.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtArea.Location = new System.Drawing.Point(356, 12);
			this.edtArea.Margin = new System.Windows.Forms.Padding(4);
			this.edtArea.MaxLength = 30;
			this.edtArea.Name = "edtArea";
			this.edtArea.Size = new System.Drawing.Size(287, 23);
			this.edtArea.TabIndex = 1;
			// 
			// lblArea
			// 
			this.lblArea.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblArea.Location = new System.Drawing.Point(216, 12);
			this.lblArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblArea.Name = "lblArea";
			this.lblArea.Size = new System.Drawing.Size(133, 25);
			this.lblArea.TabIndex = 93;
			this.lblArea.Text = "Área";
			this.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnDuplica
			// 
			this.btnDuplica.Location = new System.Drawing.Point(827, 194);
			this.btnDuplica.Margin = new System.Windows.Forms.Padding(4);
			this.btnDuplica.Name = "btnDuplica";
			this.btnDuplica.Size = new System.Drawing.Size(133, 31);
			this.btnDuplica.TabIndex = 6;
			this.btnDuplica.Text = "&Duplica Área";
			this.btnDuplica.UseVisualStyleBackColor = true;
			this.btnDuplica.Click += new System.EventHandler(this.BtnDuplicaClick);
			// 
			// edtEspecificos
			// 
			this.edtEspecificos.BackColor = System.Drawing.SystemColors.Window;
			this.edtEspecificos.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtEspecificos.Location = new System.Drawing.Point(153, 86);
			this.edtEspecificos.Margin = new System.Windows.Forms.Padding(4);
			this.edtEspecificos.MaxLength = 50;
			this.edtEspecificos.Name = "edtEspecificos";
			this.edtEspecificos.Size = new System.Drawing.Size(473, 23);
			this.edtEspecificos.TabIndex = 14;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(13, 86);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(120, 25);
			this.label1.TabIndex = 95;
			this.label1.Text = "Cod Específicos";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dgvFormula
			// 
			this.dgvFormula.AllowUserToAddRows = false;
			this.dgvFormula.AllowUserToDeleteRows = false;
			this.dgvFormula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvFormula.ColumnHeadersVisible = false;
			this.dgvFormula.Location = new System.Drawing.Point(493, 38);
			this.dgvFormula.Margin = new System.Windows.Forms.Padding(4);
			this.dgvFormula.Name = "dgvFormula";
			this.dgvFormula.RowHeadersVisible = false;
			this.dgvFormula.Size = new System.Drawing.Size(272, 266);
			this.dgvFormula.TabIndex = 96;
			this.dgvFormula.Visible = false;
			// 
			// edtPrecoGenerico
			// 
			this.edtPrecoGenerico.BackColor = System.Drawing.SystemColors.Window;
			this.edtPrecoGenerico.Enabled = false;
			this.edtPrecoGenerico.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtPrecoGenerico.Location = new System.Drawing.Point(153, 192);
			this.edtPrecoGenerico.Margin = new System.Windows.Forms.Padding(4);
			this.edtPrecoGenerico.MaxLength = 20;
			this.edtPrecoGenerico.Name = "edtPrecoGenerico";
			this.edtPrecoGenerico.Size = new System.Drawing.Size(147, 23);
			this.edtPrecoGenerico.TabIndex = 21;
			this.edtPrecoGenerico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.edtPrecoGenerico.TextChanged += new System.EventHandler(this.EdtPrecoGenericoTextChanged);
			this.edtPrecoGenerico.Leave += new System.EventHandler(this.EdtPrecoGenericoLeave);
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label2.Location = new System.Drawing.Point(13, 192);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(133, 25);
			this.label2.TabIndex = 98;
			this.label2.Text = "Preço Tabela";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ckbGenerico
			// 
			this.ckbGenerico.Enabled = false;
			this.ckbGenerico.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.ckbGenerico.Location = new System.Drawing.Point(333, 160);
			this.ckbGenerico.Margin = new System.Windows.Forms.Padding(4);
			this.ckbGenerico.Name = "ckbGenerico";
			this.ckbGenerico.Size = new System.Drawing.Size(99, 27);
			this.ckbGenerico.TabIndex = 99;
			this.ckbGenerico.Text = "Especial";
			this.ckbGenerico.UseVisualStyleBackColor = true;
			// 
			// frmCadItens
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1048, 695);
			this.Controls.Add(this.btnDuplica);
			this.Controls.Add(this.lblOrcamento);
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "frmCadItens";
			this.Text = "Sistema SOFT - Itens do Orçamento ";
			this.Load += new System.EventHandler(this.FCadItensLoad);
			this.Controls.SetChildIndex(this.lblOrcamento, 0);
			this.Controls.SetChildIndex(this.btnDuplica, 0);
			this.Controls.SetChildIndex(this.btnUp, 0);
			this.Controls.SetChildIndex(this.btnDown, 0);
			this.Controls.SetChildIndex(this.btnInclui, 0);
			this.Controls.SetChildIndex(this.btnExclui, 0);
			this.Controls.SetChildIndex(this.btnAltera, 0);
			this.Controls.SetChildIndex(this.btnFecha, 0);
			this.Controls.SetChildIndex(this.pnlEdicao, 0);
			this.Controls.SetChildIndex(this.edtLocaliza, 0);
			this.Controls.SetChildIndex(this.btnLocaliza, 0);
			this.pnlEdicao.ResumeLayout(false);
			this.pnlEdicao.PerformLayout();
			this.gbxFoto.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.imgProduto)).EndInit();
			this.gbxPendencia.ResumeLayout(false);
			this.gbxPendencia.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvFormula)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.TextBox edtEspecificos;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.Button btnDuplica;
		private System.Windows.Forms.Label lblArea;
		private System.Windows.Forms.TextBox edtArea;
		private System.Windows.Forms.TextBox edtDescricaoProd;
		private System.Windows.Forms.TextBox edtTexto;
		private System.Windows.Forms.GroupBox gbxPendencia;
		private System.Windows.Forms.TextBox edtPrecoFormula;
		private System.Windows.Forms.Button btnCalculo;
		private System.Windows.Forms.Button btnQrcode;
		private System.Windows.Forms.DataGridView dgvFormula;
		private System.Windows.Forms.Button btnPesquisaRapida;
		private System.Windows.Forms.TextBox edtPrecoTotal;
		private System.Windows.Forms.TextBox edtSubCodigo;
		private System.Windows.Forms.Label lblQtde;
		private System.Windows.Forms.TextBox edtQtde;
		private System.Windows.Forms.Label lblMedidas;
		private System.Windows.Forms.TextBox edtMedidas;
		private System.Windows.Forms.Label lblPrecoTabela;
		private System.Windows.Forms.Label lblPrecoVenda;
		private System.Windows.Forms.PictureBox imgProduto;
		private System.Windows.Forms.GroupBox gbxFoto;
		private System.Windows.Forms.CheckBox ckbEspecial;
		private System.Windows.Forms.Label lblProduto;
		private System.Windows.Forms.TextBox edtProduto;
		private System.Windows.Forms.Button btnProduto;
		private System.Windows.Forms.Label lblOrcamento;
		private System.Windows.Forms.TextBox edtPrecoGenerico;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox ckbGenerico;
	}
}
