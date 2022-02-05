/*
 * Criado por SharpDevelop.
 * Usuário: Ricardo
 * Data: 25/10/2009
 * Hora: 11:09
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace pedido
{
	partial class fComissao
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnCancela = new System.Windows.Forms.Button();
			this.btnConfirma = new System.Windows.Forms.Button();
			this.rbtFilial = new System.Windows.Forms.RadioButton();
			this.rbtConsultor = new System.Windows.Forms.RadioButton();
			this.rbtVendedor = new System.Windows.Forms.RadioButton();
			this.dgvCadastro = new System.Windows.Forms.DataGridView();
			this.Fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Orcamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ValorPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Calculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Comissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.isel = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PG = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.CodPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Justificativa = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FornecedorOrcamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnAlteraComissao = new System.Windows.Forms.Button();
			this.edtTotValor = new System.Windows.Forms.TextBox();
			this.edtTotCalculo = new System.Windows.Forms.TextBox();
			this.edtTotRecalculo = new System.Windows.Forms.TextBox();
			this.edtTotPago = new System.Windows.Forms.TextBox();
			this.edtTotComissao = new System.Windows.Forms.TextBox();
			this.btnFecha = new System.Windows.Forms.Button();
			this.edtValorPago = new System.Windows.Forms.TextBox();
			this.edtValorPagar = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnImprime = new System.Windows.Forms.Button();
			this.chkTodos = new System.Windows.Forms.CheckBox();
			this.edtTotPedido = new System.Windows.Forms.TextBox();
			this.edtJustificativa = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCadastro)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnCancela);
			this.groupBox1.Controls.Add(this.btnConfirma);
			this.groupBox1.Controls.Add(this.rbtFilial);
			this.groupBox1.Controls.Add(this.rbtConsultor);
			this.groupBox1.Controls.Add(this.rbtVendedor);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(909, 61);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(803, 18);
			this.btnCancela.Name = "btnCancela";
			this.btnCancela.Size = new System.Drawing.Size(100, 25);
			this.btnCancela.TabIndex = 4;
			this.btnCancela.Text = "C&ancela";
			this.btnCancela.UseVisualStyleBackColor = true;
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(697, 18);
			this.btnConfirma.Name = "btnConfirma";
			this.btnConfirma.Size = new System.Drawing.Size(100, 25);
			this.btnConfirma.TabIndex = 2;
			this.btnConfirma.Text = "&Confirma";
			this.btnConfirma.UseVisualStyleBackColor = true;
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// rbtFilial
			// 
			this.rbtFilial.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.rbtFilial.Location = new System.Drawing.Point(211, 19);
			this.rbtFilial.Name = "rbtFilial";
			this.rbtFilial.Size = new System.Drawing.Size(104, 24);
			this.rbtFilial.TabIndex = 24;
			this.rbtFilial.Text = "Por Filial";
			this.rbtFilial.UseVisualStyleBackColor = true;
			this.rbtFilial.CheckedChanged += new System.EventHandler(this.RbtVendedorCheckedChanged);
			// 
			// rbtConsultor
			// 
			this.rbtConsultor.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.rbtConsultor.Location = new System.Drawing.Point(113, 19);
			this.rbtConsultor.Name = "rbtConsultor";
			this.rbtConsultor.Size = new System.Drawing.Size(104, 24);
			this.rbtConsultor.TabIndex = 23;
			this.rbtConsultor.Text = "Por Consultor";
			this.rbtConsultor.UseVisualStyleBackColor = true;
			this.rbtConsultor.CheckedChanged += new System.EventHandler(this.RbtVendedorCheckedChanged);
			// 
			// rbtVendedor
			// 
			this.rbtVendedor.Checked = true;
			this.rbtVendedor.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.rbtVendedor.Location = new System.Drawing.Point(12, 19);
			this.rbtVendedor.Name = "rbtVendedor";
			this.rbtVendedor.Size = new System.Drawing.Size(104, 24);
			this.rbtVendedor.TabIndex = 22;
			this.rbtVendedor.TabStop = true;
			this.rbtVendedor.Text = "Por Vendedor";
			this.rbtVendedor.UseVisualStyleBackColor = true;
			this.rbtVendedor.CheckedChanged += new System.EventHandler(this.RbtVendedorCheckedChanged);
			// 
			// dgvCadastro
			// 
			this.dgvCadastro.AllowUserToAddRows = false;
			this.dgvCadastro.AllowUserToDeleteRows = false;
			this.dgvCadastro.AllowUserToResizeColumns = false;
			this.dgvCadastro.AllowUserToResizeRows = false;
			this.dgvCadastro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvCadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCadastro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Fornecedor,
									this.Data,
									this.Orcamento,
									this.Pedido,
									this.Cliente,
									this.Vendedor,
									this.ValorPedido,
									this.Valor,
									this.Calculo,
									this.Pago,
									this.Comissao,
									this.isel,
									this.PG,
									this.CodPedido,
									this.Justificativa,
									this.FornecedorOrcamento});
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvCadastro.DefaultCellStyle = dataGridViewCellStyle6;
			this.dgvCadastro.Location = new System.Drawing.Point(12, 79);
			this.dgvCadastro.MultiSelect = false;
			this.dgvCadastro.Name = "dgvCadastro";
			this.dgvCadastro.ReadOnly = true;
			this.dgvCadastro.RowHeadersVisible = false;
			this.dgvCadastro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCadastro.Size = new System.Drawing.Size(909, 359);
			this.dgvCadastro.TabIndex = 6;
			this.dgvCadastro.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCadastroRowEnter);
			// 
			// Fornecedor
			// 
			this.Fornecedor.FillWeight = 102.6884F;
			this.Fornecedor.HeaderText = "Fornecedor";
			this.Fornecedor.Name = "Fornecedor";
			this.Fornecedor.ReadOnly = true;
			// 
			// Data
			// 
			this.Data.FillWeight = 99.37303F;
			this.Data.HeaderText = "Data";
			this.Data.Name = "Data";
			this.Data.ReadOnly = true;
			// 
			// Orcamento
			// 
			this.Orcamento.FillWeight = 117.1475F;
			this.Orcamento.HeaderText = "Orçamento";
			this.Orcamento.Name = "Orcamento";
			this.Orcamento.ReadOnly = true;
			// 
			// Pedido
			// 
			this.Pedido.FillWeight = 52.15687F;
			this.Pedido.HeaderText = "Pedido";
			this.Pedido.Name = "Pedido";
			this.Pedido.ReadOnly = true;
			// 
			// Cliente
			// 
			this.Cliente.FillWeight = 189.4921F;
			this.Cliente.HeaderText = "Cliente";
			this.Cliente.Name = "Cliente";
			this.Cliente.ReadOnly = true;
			// 
			// Vendedor
			// 
			this.Vendedor.FillWeight = 102.6884F;
			this.Vendedor.HeaderText = "Vendedor";
			this.Vendedor.Name = "Vendedor";
			this.Vendedor.ReadOnly = true;
			// 
			// ValorPedido
			// 
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.ValorPedido.DefaultCellStyle = dataGridViewCellStyle1;
			this.ValorPedido.FillWeight = 98.81976F;
			this.ValorPedido.HeaderText = "Vlr Pedido";
			this.ValorPedido.Name = "ValorPedido";
			this.ValorPedido.ReadOnly = true;
			// 
			// Valor
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.Valor.DefaultCellStyle = dataGridViewCellStyle2;
			this.Valor.FillWeight = 98.42299F;
			this.Valor.HeaderText = "Vlr Liquido";
			this.Valor.Name = "Valor";
			this.Valor.ReadOnly = true;
			// 
			// Calculo
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.Calculo.DefaultCellStyle = dataGridViewCellStyle3;
			this.Calculo.FillWeight = 76.40134F;
			this.Calculo.HeaderText = "%Cálculo";
			this.Calculo.Name = "Calculo";
			this.Calculo.ReadOnly = true;
			// 
			// Pago
			// 
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.Pago.DefaultCellStyle = dataGridViewCellStyle4;
			this.Pago.FillWeight = 62.79982F;
			this.Pago.HeaderText = "%Pago";
			this.Pago.Name = "Pago";
			this.Pago.ReadOnly = true;
			// 
			// Comissao
			// 
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.Comissao.DefaultCellStyle = dataGridViewCellStyle5;
			this.Comissao.FillWeight = 80.16679F;
			this.Comissao.HeaderText = "Comissão";
			this.Comissao.Name = "Comissao";
			this.Comissao.ReadOnly = true;
			// 
			// isel
			// 
			this.isel.HeaderText = "isel";
			this.isel.Name = "isel";
			this.isel.ReadOnly = true;
			this.isel.Visible = false;
			// 
			// PG
			// 
			this.PG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.PG.FillWeight = 121.8274F;
			this.PG.HeaderText = "PG";
			this.PG.Name = "PG";
			this.PG.ReadOnly = true;
			this.PG.Width = 25;
			// 
			// CodPedido
			// 
			this.CodPedido.HeaderText = "CodPedido";
			this.CodPedido.Name = "CodPedido";
			this.CodPedido.ReadOnly = true;
			this.CodPedido.Visible = false;
			// 
			// Justificativa
			// 
			this.Justificativa.HeaderText = "Justificativa";
			this.Justificativa.Name = "Justificativa";
			this.Justificativa.ReadOnly = true;
			this.Justificativa.Visible = false;
			// 
			// FornecedorOrcamento
			// 
			this.FornecedorOrcamento.HeaderText = "Fornecedor Orçamento";
			this.FornecedorOrcamento.Name = "FornecedorOrcamento";
			this.FornecedorOrcamento.ReadOnly = true;
			this.FornecedorOrcamento.Visible = false;
			// 
			// btnAlteraComissao
			// 
			this.btnAlteraComissao.Location = new System.Drawing.Point(9, 498);
			this.btnAlteraComissao.Name = "btnAlteraComissao";
			this.btnAlteraComissao.Size = new System.Drawing.Size(100, 25);
			this.btnAlteraComissao.TabIndex = 8;
			this.btnAlteraComissao.Text = "Altera &Valor/PG";
			this.btnAlteraComissao.UseVisualStyleBackColor = true;
			this.btnAlteraComissao.Click += new System.EventHandler(this.BtnAlteraComissaoClick);
			// 
			// edtTotValor
			// 
			this.edtTotValor.BackColor = System.Drawing.SystemColors.Info;
			this.edtTotValor.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtTotValor.Location = new System.Drawing.Point(627, 444);
			this.edtTotValor.Name = "edtTotValor";
			this.edtTotValor.ReadOnly = true;
			this.edtTotValor.Size = new System.Drawing.Size(76, 20);
			this.edtTotValor.TabIndex = 59;
			this.edtTotValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// edtTotCalculo
			// 
			this.edtTotCalculo.BackColor = System.Drawing.SystemColors.Info;
			this.edtTotCalculo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtTotCalculo.Location = new System.Drawing.Point(709, 444);
			this.edtTotCalculo.Name = "edtTotCalculo";
			this.edtTotCalculo.ReadOnly = true;
			this.edtTotCalculo.Size = new System.Drawing.Size(48, 20);
			this.edtTotCalculo.TabIndex = 60;
			this.edtTotCalculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// edtTotRecalculo
			// 
			this.edtTotRecalculo.BackColor = System.Drawing.SystemColors.Info;
			this.edtTotRecalculo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtTotRecalculo.Location = new System.Drawing.Point(381, 444);
			this.edtTotRecalculo.Name = "edtTotRecalculo";
			this.edtTotRecalculo.ReadOnly = true;
			this.edtTotRecalculo.Size = new System.Drawing.Size(75, 20);
			this.edtTotRecalculo.TabIndex = 61;
			this.edtTotRecalculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.edtTotRecalculo.Visible = false;
			// 
			// edtTotPago
			// 
			this.edtTotPago.BackColor = System.Drawing.SystemColors.Info;
			this.edtTotPago.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtTotPago.Location = new System.Drawing.Point(763, 444);
			this.edtTotPago.Name = "edtTotPago";
			this.edtTotPago.ReadOnly = true;
			this.edtTotPago.Size = new System.Drawing.Size(55, 20);
			this.edtTotPago.TabIndex = 62;
			this.edtTotPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// edtTotComissao
			// 
			this.edtTotComissao.BackColor = System.Drawing.SystemColors.Info;
			this.edtTotComissao.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtTotComissao.Location = new System.Drawing.Point(824, 444);
			this.edtTotComissao.Name = "edtTotComissao";
			this.edtTotComissao.ReadOnly = true;
			this.edtTotComissao.Size = new System.Drawing.Size(71, 20);
			this.edtTotComissao.TabIndex = 63;
			this.edtTotComissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btnFecha
			// 
			this.btnFecha.Location = new System.Drawing.Point(223, 498);
			this.btnFecha.Name = "btnFecha";
			this.btnFecha.Size = new System.Drawing.Size(100, 25);
			this.btnFecha.TabIndex = 12;
			this.btnFecha.Text = "&Fecha";
			this.btnFecha.UseVisualStyleBackColor = true;
			this.btnFecha.Click += new System.EventHandler(this.BtnFechaClick);
			// 
			// edtValorPago
			// 
			this.edtValorPago.BackColor = System.Drawing.SystemColors.Info;
			this.edtValorPago.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtValorPago.Location = new System.Drawing.Point(824, 470);
			this.edtValorPago.Name = "edtValorPago";
			this.edtValorPago.ReadOnly = true;
			this.edtValorPago.Size = new System.Drawing.Size(71, 20);
			this.edtValorPago.TabIndex = 67;
			this.edtValorPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// edtValorPagar
			// 
			this.edtValorPagar.BackColor = System.Drawing.SystemColors.Info;
			this.edtValorPagar.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtValorPagar.Location = new System.Drawing.Point(824, 496);
			this.edtValorPagar.Name = "edtValorPagar";
			this.edtValorPagar.ReadOnly = true;
			this.edtValorPagar.Size = new System.Drawing.Size(71, 20);
			this.edtValorPagar.TabIndex = 68;
			this.edtValorPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label5.Location = new System.Drawing.Point(763, 470);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(46, 20);
			this.label5.TabIndex = 144;
			this.label5.Text = "Pago";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(763, 496);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 20);
			this.label1.TabIndex = 145;
			this.label1.Text = "Pagar";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnImprime
			// 
			this.btnImprime.Location = new System.Drawing.Point(115, 498);
			this.btnImprime.Name = "btnImprime";
			this.btnImprime.Size = new System.Drawing.Size(100, 25);
			this.btnImprime.TabIndex = 146;
			this.btnImprime.Text = "&Imprime";
			this.btnImprime.UseVisualStyleBackColor = true;
			this.btnImprime.Click += new System.EventHandler(this.BtnImprimeClick);
			// 
			// chkTodos
			// 
			this.chkTodos.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkTodos.Location = new System.Drawing.Point(12, 444);
			this.chkTodos.Name = "chkTodos";
			this.chkTodos.Size = new System.Drawing.Size(217, 24);
			this.chkTodos.TabIndex = 160;
			this.chkTodos.Text = "Marca/desmarca todos pagamentos";
			this.chkTodos.UseVisualStyleBackColor = true;
			this.chkTodos.CheckedChanged += new System.EventHandler(this.ChkTodosCheckedChanged);
			// 
			// edtTotPedido
			// 
			this.edtTotPedido.BackColor = System.Drawing.SystemColors.Info;
			this.edtTotPedido.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtTotPedido.Location = new System.Drawing.Point(545, 444);
			this.edtTotPedido.Name = "edtTotPedido";
			this.edtTotPedido.ReadOnly = true;
			this.edtTotPedido.Size = new System.Drawing.Size(76, 20);
			this.edtTotPedido.TabIndex = 161;
			this.edtTotPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// edtJustificativa
			// 
			this.edtJustificativa.BackColor = System.Drawing.SystemColors.Info;
			this.edtJustificativa.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtJustificativa.Location = new System.Drawing.Point(80, 471);
			this.edtJustificativa.Name = "edtJustificativa";
			this.edtJustificativa.ReadOnly = true;
			this.edtJustificativa.Size = new System.Drawing.Size(677, 20);
			this.edtJustificativa.TabIndex = 163;
			this.edtJustificativa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label2.Location = new System.Drawing.Point(12, 471);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 20);
			this.label2.TabIndex = 164;
			this.label2.Text = "Justificativa";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// fComissao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(931, 527);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.edtJustificativa);
			this.Controls.Add(this.edtTotPedido);
			this.Controls.Add(this.chkTodos);
			this.Controls.Add(this.btnImprime);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.edtTotComissao);
			this.Controls.Add(this.edtTotCalculo);
			this.Controls.Add(this.edtTotValor);
			this.Controls.Add(this.edtValorPagar);
			this.Controls.Add(this.edtValorPago);
			this.Controls.Add(this.btnFecha);
			this.Controls.Add(this.edtTotPago);
			this.Controls.Add(this.btnAlteraComissao);
			this.Controls.Add(this.edtTotRecalculo);
			this.Controls.Add(this.dgvCadastro);
			this.Controls.Add(this.groupBox1);
			this.Name = "fComissao";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Comissão";
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvCadastro)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox edtJustificativa;
		private System.Windows.Forms.DataGridViewTextBoxColumn FornecedorOrcamento;
		private System.Windows.Forms.TextBox edtTotPedido;
		private System.Windows.Forms.DataGridViewTextBoxColumn ValorPedido;
		private System.Windows.Forms.CheckBox chkTodos;
		public System.Windows.Forms.Button btnImprime;
		private System.Windows.Forms.DataGridViewTextBoxColumn Justificativa;
		public System.Windows.Forms.Button btnAlteraComissao;
		private System.Windows.Forms.TextBox edtValorPago;
		private System.Windows.Forms.TextBox edtValorPagar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridViewTextBoxColumn CodPedido;
		public System.Windows.Forms.Button btnFecha;
		private System.Windows.Forms.DataGridViewTextBoxColumn isel;
		private System.Windows.Forms.DataGridViewCheckBoxColumn PG;
		private System.Windows.Forms.TextBox edtTotComissao;
		private System.Windows.Forms.TextBox edtTotPago;
		private System.Windows.Forms.TextBox edtTotRecalculo;
		private System.Windows.Forms.TextBox edtTotCalculo;
		private System.Windows.Forms.TextBox edtTotValor;
		public System.Windows.Forms.Button btnConfirma;
		public System.Windows.Forms.Button btnCancela;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
		private System.Windows.Forms.DataGridViewTextBoxColumn Pedido;
		private System.Windows.Forms.DataGridViewTextBoxColumn Orcamento;
		private System.Windows.Forms.DataGridViewTextBoxColumn Data;
		private System.Windows.Forms.DataGridViewTextBoxColumn Fornecedor;
		private System.Windows.Forms.DataGridViewTextBoxColumn Pago;
		private System.Windows.Forms.DataGridViewTextBoxColumn Calculo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Vendedor;
		private System.Windows.Forms.DataGridViewTextBoxColumn Comissao;
		private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
		public System.Windows.Forms.DataGridView dgvCadastro;
		public System.Windows.Forms.RadioButton rbtVendedor;
		public System.Windows.Forms.RadioButton rbtConsultor;
		public System.Windows.Forms.RadioButton rbtFilial;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
