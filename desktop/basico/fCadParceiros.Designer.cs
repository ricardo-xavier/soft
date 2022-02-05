/*
 * Usuário: Ricardo
 * Data: 11/04/2008
 * Hora: 0:06
 * 
 */
namespace basico
{
	partial class frmCadParceiros
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
			this.edtEmail = new System.Windows.Forms.TextBox();
			this.lblEmail = new System.Windows.Forms.Label();
			this.edtCelular = new System.Windows.Forms.TextBox();
			this.edtFone1 = new System.Windows.Forms.TextBox();
			this.lblFone = new System.Windows.Forms.Label();
			this.edtCNPJ = new System.Windows.Forms.TextBox();
			this.lblCNPJ = new System.Windows.Forms.Label();
			this.grpTipo = new System.Windows.Forms.GroupBox();
			this.ckbConsultor = new System.Windows.Forms.CheckBox();
			this.ckbFornecedor = new System.Windows.Forms.CheckBox();
			this.ckbCliente = new System.Windows.Forms.CheckBox();
			this.grpPessoa = new System.Windows.Forms.GroupBox();
			this.rbtJuridica = new System.Windows.Forms.RadioButton();
			this.rbtFisica = new System.Windows.Forms.RadioButton();
			this.ckbAtivo = new System.Windows.Forms.CheckBox();
			this.btnContatos = new System.Windows.Forms.Button();
			this.lblFAX = new System.Windows.Forms.Label();
			this.edtFAX = new System.Windows.Forms.TextBox();
			this.tabEndereco = new System.Windows.Forms.TabPage();
			this.edtNumero = new System.Windows.Forms.TextBox();
			this.lblNumero = new System.Windows.Forms.Label();
			this.edtCEP = new System.Windows.Forms.TextBox();
			this.edtCidade = new System.Windows.Forms.TextBox();
			this.edtBairro = new System.Windows.Forms.TextBox();
			this.edtComplemento = new System.Windows.Forms.TextBox();
			this.edtLogradouro = new System.Windows.Forms.TextBox();
			this.lblCEP = new System.Windows.Forms.Label();
			this.cbxEstados = new System.Windows.Forms.ComboBox();
			this.lblEstado = new System.Windows.Forms.Label();
			this.lblBairro = new System.Windows.Forms.Label();
			this.lblCidade = new System.Windows.Forms.Label();
			this.lblComplemento = new System.Windows.Forms.Label();
			this.lblLogradouro = new System.Windows.Forms.Label();
			this.tabEntrega = new System.Windows.Forms.TabPage();
			this.edtNumeroEntrega = new System.Windows.Forms.TextBox();
			this.lblNumeroEntrega = new System.Windows.Forms.Label();
			this.edtCEPEntrega = new System.Windows.Forms.TextBox();
			this.edtCidadeEntrega = new System.Windows.Forms.TextBox();
			this.edtBairroEntrega = new System.Windows.Forms.TextBox();
			this.edtComplementoEntrega = new System.Windows.Forms.TextBox();
			this.edtLogradouroEntrega = new System.Windows.Forms.TextBox();
			this.lblCEPEntrega = new System.Windows.Forms.Label();
			this.cbxEstadosEntrega = new System.Windows.Forms.ComboBox();
			this.label4lblEstadoEntrega = new System.Windows.Forms.Label();
			this.lblBairroEntrega = new System.Windows.Forms.Label();
			this.lblCidadeEntrega = new System.Windows.Forms.Label();
			this.lblComplementoEntrega = new System.Windows.Forms.Label();
			this.lblLogradouroEntrega = new System.Windows.Forms.Label();
			this.tabEnderecos = new System.Windows.Forms.TabControl();
			this.tabCobranca = new System.Windows.Forms.TabPage();
			this.edtNumeroCobranca = new System.Windows.Forms.TextBox();
			this.lblNumeroCobranca = new System.Windows.Forms.Label();
			this.edtCEPCobranca = new System.Windows.Forms.TextBox();
			this.edtCidadeCobranca = new System.Windows.Forms.TextBox();
			this.edtBairroCobranca = new System.Windows.Forms.TextBox();
			this.edtComplementoCobranca = new System.Windows.Forms.TextBox();
			this.edtLogradouroCobranca = new System.Windows.Forms.TextBox();
			this.lblCEPCobranca = new System.Windows.Forms.Label();
			this.cbxEstadosCobranca = new System.Windows.Forms.ComboBox();
			this.lblEstadoCobranca = new System.Windows.Forms.Label();
			this.lblBairroCobranca = new System.Windows.Forms.Label();
			this.lblCidadeCobranca = new System.Windows.Forms.Label();
			this.lblComplementoCobranca = new System.Windows.Forms.Label();
			this.lblLogradouroCobranca = new System.Windows.Forms.Label();
			this.lblCelular = new System.Windows.Forms.Label();
			this.edtFone2 = new System.Windows.Forms.TextBox();
			this.edtInsMun = new System.Windows.Forms.TextBox();
			this.lblInsMun = new System.Windows.Forms.Label();
			this.edtInsEst = new System.Windows.Forms.TextBox();
			this.lblInsEst = new System.Windows.Forms.Label();
			this.edtPedido = new System.Windows.Forms.TextBox();
			this.lblPedido = new System.Windows.Forms.Label();
			this.dtpAlteracao = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.btnImprime = new System.Windows.Forms.Button();
			this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAuditoria = new System.Windows.Forms.Button();
			this.pnlEdicao.SuspendLayout();
			this.grpTipo.SuspendLayout();
			this.grpPessoa.SuspendLayout();
			this.tabEndereco.SuspendLayout();
			this.tabEntrega.SuspendLayout();
			this.tabEnderecos.SuspendLayout();
			this.tabCobranca.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(584, 366);
			this.btnCancela.TabIndex = 23;
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(474, 366);
			this.btnConfirma.TabIndex = 22;
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// edtCodigo
			// 
			this.edtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.edtCodigo.Location = new System.Drawing.Point(95, 10);
			this.edtCodigo.Size = new System.Drawing.Size(146, 20);
			// 
			// edtDescricao
			// 
			this.edtDescricao.Location = new System.Drawing.Point(96, 80);
			this.edtDescricao.MaxLength = 50;
			this.edtDescricao.Size = new System.Drawing.Size(356, 20);
			this.edtDescricao.TabIndex = 5;
			// 
			// lblCodigo
			// 
			this.lblCodigo.Size = new System.Drawing.Size(80, 20);
			// 
			// lblDescricao
			// 
			this.lblDescricao.Location = new System.Drawing.Point(10, 80);
			this.lblDescricao.Size = new System.Drawing.Size(80, 20);
			this.lblDescricao.Text = "*Razão Social";
			// 
			// pnlEdicao
			// 
			this.pnlEdicao.Controls.Add(this.dtpNascimento);
			this.pnlEdicao.Controls.Add(this.label1);
			this.pnlEdicao.Controls.Add(this.dtpAlteracao);
			this.pnlEdicao.Controls.Add(this.label3);
			this.pnlEdicao.Controls.Add(this.edtPedido);
			this.pnlEdicao.Controls.Add(this.lblPedido);
			this.pnlEdicao.Controls.Add(this.edtInsMun);
			this.pnlEdicao.Controls.Add(this.lblInsMun);
			this.pnlEdicao.Controls.Add(this.edtInsEst);
			this.pnlEdicao.Controls.Add(this.lblInsEst);
			this.pnlEdicao.Controls.Add(this.edtFone2);
			this.pnlEdicao.Controls.Add(this.lblCelular);
			this.pnlEdicao.Controls.Add(this.grpPessoa);
			this.pnlEdicao.Controls.Add(this.grpTipo);
			this.pnlEdicao.Controls.Add(this.edtCNPJ);
			this.pnlEdicao.Controls.Add(this.lblCNPJ);
			this.pnlEdicao.Controls.Add(this.tabEnderecos);
			this.pnlEdicao.Controls.Add(this.lblFone);
			this.pnlEdicao.Controls.Add(this.edtFone1);
			this.pnlEdicao.Controls.Add(this.edtEmail);
			this.pnlEdicao.Controls.Add(this.lblEmail);
			this.pnlEdicao.Controls.Add(this.ckbAtivo);
			this.pnlEdicao.Controls.Add(this.edtFAX);
			this.pnlEdicao.Controls.Add(this.edtCelular);
			this.pnlEdicao.Controls.Add(this.lblFAX);
			this.pnlEdicao.Size = new System.Drawing.Size(690, 398);
			this.pnlEdicao.TabIndex = 8;
			this.pnlEdicao.Controls.SetChildIndex(this.lblFAX, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtCelular, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtFAX, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.ckbAtivo, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblEmail, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtEmail, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtFone1, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblFone, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.tabEnderecos, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblCNPJ, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtCNPJ, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.grpTipo, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.grpPessoa, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblCelular, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtFone2, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtDescricao, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.btnConfirma, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.btnCancela, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblCodigo, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblDescricao, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtCodigo, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblInsEst, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtInsEst, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblInsMun, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtInsMun, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblPedido, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtPedido, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.label3, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.dtpAlteracao, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.label1, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.dtpNascimento, 0);
			// 
			// btnFecha
			// 
			this.btnFecha.Location = new System.Drawing.Point(590, 98);
			this.btnFecha.Click += new System.EventHandler(this.BtnFechaClick);
			// 
			// btnAltera
			// 
			this.btnAltera.Location = new System.Drawing.Point(590, 68);
			this.btnAltera.Click += new System.EventHandler(this.BtnAlteraClick);
			// 
			// btnExclui
			// 
			this.btnExclui.Location = new System.Drawing.Point(590, 38);
			this.btnExclui.Click += new System.EventHandler(this.BtnExcluiClick);
			// 
			// btnInclui
			// 
			this.btnInclui.Location = new System.Drawing.Point(590, 8);
			this.btnInclui.Click += new System.EventHandler(this.BtnIncluiClick);
			// 
			// edtEmail
			// 
			this.edtEmail.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtEmail.Location = new System.Drawing.Point(101, 310);
			this.edtEmail.MaxLength = 50;
			this.edtEmail.Name = "edtEmail";
			this.edtEmail.Size = new System.Drawing.Size(356, 20);
			this.edtEmail.TabIndex = 18;
			// 
			// lblEmail
			// 
			this.lblEmail.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblEmail.Location = new System.Drawing.Point(16, 310);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(80, 20);
			this.lblEmail.TabIndex = 70;
			this.lblEmail.Text = "email";
			this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtCelular
			// 
			this.edtCelular.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtCelular.Location = new System.Drawing.Point(397, 280);
			this.edtCelular.MaxLength = 14;
			this.edtCelular.Name = "edtCelular";
			this.edtCelular.Size = new System.Drawing.Size(104, 20);
			this.edtCelular.TabIndex = 16;
			this.edtCelular.Enter += new System.EventHandler(this.EdtCelularEnter);
			this.edtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EdtNUMERICOKeyPress);
			this.edtCelular.Leave += new System.EventHandler(this.EdtCelularLeave);
			// 
			// edtFone1
			// 
			this.edtFone1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtFone1.Location = new System.Drawing.Point(101, 280);
			this.edtFone1.MaxLength = 13;
			this.edtFone1.Name = "edtFone1";
			this.edtFone1.Size = new System.Drawing.Size(97, 20);
			this.edtFone1.TabIndex = 14;
			this.edtFone1.Enter += new System.EventHandler(this.EdtFone1Enter);
			this.edtFone1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EdtNUMERICOKeyPress);
			this.edtFone1.Leave += new System.EventHandler(this.EdtFone1Leave);
			// 
			// lblFone
			// 
			this.lblFone.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblFone.Location = new System.Drawing.Point(16, 280);
			this.lblFone.Name = "lblFone";
			this.lblFone.Size = new System.Drawing.Size(80, 20);
			this.lblFone.TabIndex = 69;
			this.lblFone.Text = "Fone";
			this.lblFone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtCNPJ
			// 
			this.edtCNPJ.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtCNPJ.Location = new System.Drawing.Point(515, 80);
			this.edtCNPJ.MaxLength = 14;
			this.edtCNPJ.Name = "edtCNPJ";
			this.edtCNPJ.Size = new System.Drawing.Size(132, 20);
			this.edtCNPJ.TabIndex = 6;
			this.edtCNPJ.Enter += new System.EventHandler(this.EdtCNPJEnter);
			this.edtCNPJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EdtNUMERICOKeyPress);
			this.edtCNPJ.Leave += new System.EventHandler(this.EdtCNPJLeave);
			// 
			// lblCNPJ
			// 
			this.lblCNPJ.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCNPJ.Location = new System.Drawing.Point(460, 80);
			this.lblCNPJ.Name = "lblCNPJ";
			this.lblCNPJ.Size = new System.Drawing.Size(50, 20);
			this.lblCNPJ.TabIndex = 59;
			this.lblCNPJ.Text = "CNPJ";
			this.lblCNPJ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// grpTipo
			// 
			this.grpTipo.Controls.Add(this.ckbConsultor);
			this.grpTipo.Controls.Add(this.ckbFornecedor);
			this.grpTipo.Controls.Add(this.ckbCliente);
			this.grpTipo.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.grpTipo.Location = new System.Drawing.Point(320, 27);
			this.grpTipo.Name = "grpTipo";
			this.grpTipo.Size = new System.Drawing.Size(254, 43);
			this.grpTipo.TabIndex = 4;
			this.grpTipo.TabStop = false;
			this.grpTipo.Text = "Papel";
			// 
			// ckbConsultor
			// 
			this.ckbConsultor.Location = new System.Drawing.Point(165, 15);
			this.ckbConsultor.Name = "ckbConsultor";
			this.ckbConsultor.Size = new System.Drawing.Size(89, 22);
			this.ckbConsultor.TabIndex = 2;
			this.ckbConsultor.Text = "Consultor";
			this.ckbConsultor.UseVisualStyleBackColor = true;
			// 
			// ckbFornecedor
			// 
			this.ckbFornecedor.Location = new System.Drawing.Point(74, 15);
			this.ckbFornecedor.Name = "ckbFornecedor";
			this.ckbFornecedor.Size = new System.Drawing.Size(80, 22);
			this.ckbFornecedor.TabIndex = 1;
			this.ckbFornecedor.Text = "Fornecedor";
			this.ckbFornecedor.UseVisualStyleBackColor = true;
			// 
			// ckbCliente
			// 
			this.ckbCliente.Location = new System.Drawing.Point(10, 15);
			this.ckbCliente.Name = "ckbCliente";
			this.ckbCliente.Size = new System.Drawing.Size(70, 22);
			this.ckbCliente.TabIndex = 0;
			this.ckbCliente.Text = "Cliente";
			this.ckbCliente.UseVisualStyleBackColor = true;
			// 
			// grpPessoa
			// 
			this.grpPessoa.Controls.Add(this.rbtJuridica);
			this.grpPessoa.Controls.Add(this.rbtFisica);
			this.grpPessoa.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.grpPessoa.Location = new System.Drawing.Point(95, 35);
			this.grpPessoa.Name = "grpPessoa";
			this.grpPessoa.Size = new System.Drawing.Size(203, 35);
			this.grpPessoa.TabIndex = 3;
			this.grpPessoa.TabStop = false;
			this.grpPessoa.Text = "Tipo Pessoa";
			// 
			// rbtJuridica
			// 
			this.rbtJuridica.Location = new System.Drawing.Point(98, 11);
			this.rbtJuridica.Name = "rbtJuridica";
			this.rbtJuridica.Size = new System.Drawing.Size(75, 22);
			this.rbtJuridica.TabIndex = 1;
			this.rbtJuridica.TabStop = true;
			this.rbtJuridica.Text = "Jurídica";
			this.rbtJuridica.UseVisualStyleBackColor = true;
			this.rbtJuridica.Click += new System.EventHandler(this.RbtJuridicaClick);
			// 
			// rbtFisica
			// 
			this.rbtFisica.Location = new System.Drawing.Point(12, 11);
			this.rbtFisica.Name = "rbtFisica";
			this.rbtFisica.Size = new System.Drawing.Size(80, 22);
			this.rbtFisica.TabIndex = 0;
			this.rbtFisica.TabStop = true;
			this.rbtFisica.Text = "Física";
			this.rbtFisica.UseVisualStyleBackColor = true;
			this.rbtFisica.Click += new System.EventHandler(this.RbtFisicaClick);
			// 
			// ckbAtivo
			// 
			this.ckbAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ckbAtivo.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.ckbAtivo.Location = new System.Drawing.Point(484, 310);
			this.ckbAtivo.Name = "ckbAtivo";
			this.ckbAtivo.Size = new System.Drawing.Size(128, 24);
			this.ckbAtivo.TabIndex = 19;
			this.ckbAtivo.Text = "Ativo";
			this.ckbAtivo.UseVisualStyleBackColor = true;
			// 
			// btnContatos
			// 
			this.btnContatos.Location = new System.Drawing.Point(590, 129);
			this.btnContatos.Name = "btnContatos";
			this.btnContatos.Size = new System.Drawing.Size(100, 25);
			this.btnContatos.TabIndex = 7;
			this.btnContatos.Text = "&Contatos";
			this.btnContatos.UseVisualStyleBackColor = true;
			this.btnContatos.Click += new System.EventHandler(this.BtnContatosClick);
			// 
			// lblFAX
			// 
			this.lblFAX.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblFAX.Location = new System.Drawing.Point(473, 280);
			this.lblFAX.Name = "lblFAX";
			this.lblFAX.Size = new System.Drawing.Size(60, 20);
			this.lblFAX.TabIndex = 71;
			this.lblFAX.Text = "FAX";
			this.lblFAX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtFAX
			// 
			this.edtFAX.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtFAX.Location = new System.Drawing.Point(539, 280);
			this.edtFAX.MaxLength = 13;
			this.edtFAX.Name = "edtFAX";
			this.edtFAX.Size = new System.Drawing.Size(97, 20);
			this.edtFAX.TabIndex = 17;
			this.edtFAX.Enter += new System.EventHandler(this.EdtFAXEnter);
			this.edtFAX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EdtNUMERICOKeyPress);
			this.edtFAX.Leave += new System.EventHandler(this.EdtFAXLeave);
			// 
			// tabEndereco
			// 
			this.tabEndereco.BackColor = System.Drawing.SystemColors.Control;
			this.tabEndereco.Controls.Add(this.edtNumero);
			this.tabEndereco.Controls.Add(this.lblNumero);
			this.tabEndereco.Controls.Add(this.edtCEP);
			this.tabEndereco.Controls.Add(this.edtCidade);
			this.tabEndereco.Controls.Add(this.edtBairro);
			this.tabEndereco.Controls.Add(this.edtComplemento);
			this.tabEndereco.Controls.Add(this.edtLogradouro);
			this.tabEndereco.Controls.Add(this.lblCEP);
			this.tabEndereco.Controls.Add(this.cbxEstados);
			this.tabEndereco.Controls.Add(this.lblEstado);
			this.tabEndereco.Controls.Add(this.lblBairro);
			this.tabEndereco.Controls.Add(this.lblCidade);
			this.tabEndereco.Controls.Add(this.lblComplemento);
			this.tabEndereco.Controls.Add(this.lblLogradouro);
			this.tabEndereco.Location = new System.Drawing.Point(4, 22);
			this.tabEndereco.Name = "tabEndereco";
			this.tabEndereco.Padding = new System.Windows.Forms.Padding(3);
			this.tabEndereco.Size = new System.Drawing.Size(670, 107);
			this.tabEndereco.TabIndex = 0;
			this.tabEndereco.Text = "Endereço";
			// 
			// edtNumero
			// 
			this.edtNumero.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtNumero.Location = new System.Drawing.Point(537, 11);
			this.edtNumero.MaxLength = 6;
			this.edtNumero.Name = "edtNumero";
			this.edtNumero.Size = new System.Drawing.Size(48, 20);
			this.edtNumero.TabIndex = 1;
			// 
			// lblNumero
			// 
			this.lblNumero.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblNumero.Location = new System.Drawing.Point(470, 10);
			this.lblNumero.Name = "lblNumero";
			this.lblNumero.Size = new System.Drawing.Size(60, 20);
			this.lblNumero.TabIndex = 78;
			this.lblNumero.Text = "Número";
			this.lblNumero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtCEP
			// 
			this.edtCEP.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtCEP.Location = new System.Drawing.Point(585, 70);
			this.edtCEP.MaxLength = 10;
			this.edtCEP.Name = "edtCEP";
			this.edtCEP.Size = new System.Drawing.Size(76, 20);
			this.edtCEP.TabIndex = 6;
			this.edtCEP.Enter += new System.EventHandler(this.EdtCEPEnter);
			this.edtCEP.Leave += new System.EventHandler(this.EdtCEPLeave);
			// 
			// edtCidade
			// 
			this.edtCidade.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtCidade.Location = new System.Drawing.Point(95, 70);
			this.edtCidade.MaxLength = 50;
			this.edtCidade.Name = "edtCidade";
			this.edtCidade.Size = new System.Drawing.Size(356, 20);
			this.edtCidade.TabIndex = 4;
			// 
			// edtBairro
			// 
			this.edtBairro.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtBairro.Location = new System.Drawing.Point(305, 40);
			this.edtBairro.MaxLength = 50;
			this.edtBairro.Name = "edtBairro";
			this.edtBairro.Size = new System.Drawing.Size(356, 20);
			this.edtBairro.TabIndex = 3;
			// 
			// edtComplemento
			// 
			this.edtComplemento.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtComplemento.Location = new System.Drawing.Point(95, 40);
			this.edtComplemento.MaxLength = 20;
			this.edtComplemento.Name = "edtComplemento";
			this.edtComplemento.Size = new System.Drawing.Size(146, 20);
			this.edtComplemento.TabIndex = 2;
			// 
			// edtLogradouro
			// 
			this.edtLogradouro.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtLogradouro.Location = new System.Drawing.Point(95, 10);
			this.edtLogradouro.MaxLength = 50;
			this.edtLogradouro.Name = "edtLogradouro";
			this.edtLogradouro.Size = new System.Drawing.Size(356, 20);
			this.edtLogradouro.TabIndex = 0;
			// 
			// lblCEP
			// 
			this.lblCEP.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCEP.Location = new System.Drawing.Point(550, 70);
			this.lblCEP.Name = "lblCEP";
			this.lblCEP.Size = new System.Drawing.Size(30, 20);
			this.lblCEP.TabIndex = 76;
			this.lblCEP.Text = "CEP";
			this.lblCEP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxEstados
			// 
			this.cbxEstados.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxEstados.FormattingEnabled = true;
			this.cbxEstados.Location = new System.Drawing.Point(490, 70);
			this.cbxEstados.Name = "cbxEstados";
			this.cbxEstados.Size = new System.Drawing.Size(50, 22);
			this.cbxEstados.TabIndex = 5;
			// 
			// lblEstado
			// 
			this.lblEstado.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblEstado.Location = new System.Drawing.Point(450, 70);
			this.lblEstado.Name = "lblEstado";
			this.lblEstado.Size = new System.Drawing.Size(30, 20);
			this.lblEstado.TabIndex = 75;
			this.lblEstado.Text = "UF";
			this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblBairro
			// 
			this.lblBairro.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblBairro.Location = new System.Drawing.Point(259, 40);
			this.lblBairro.Name = "lblBairro";
			this.lblBairro.Size = new System.Drawing.Size(40, 20);
			this.lblBairro.TabIndex = 70;
			this.lblBairro.Text = "Bairro";
			this.lblBairro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblCidade
			// 
			this.lblCidade.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCidade.Location = new System.Drawing.Point(10, 70);
			this.lblCidade.Name = "lblCidade";
			this.lblCidade.Size = new System.Drawing.Size(80, 20);
			this.lblCidade.TabIndex = 67;
			this.lblCidade.Text = "Cidade";
			this.lblCidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblComplemento
			// 
			this.lblComplemento.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblComplemento.Location = new System.Drawing.Point(10, 40);
			this.lblComplemento.Name = "lblComplemento";
			this.lblComplemento.Size = new System.Drawing.Size(80, 20);
			this.lblComplemento.TabIndex = 65;
			this.lblComplemento.Text = "Complemento";
			this.lblComplemento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblLogradouro
			// 
			this.lblLogradouro.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblLogradouro.Location = new System.Drawing.Point(10, 10);
			this.lblLogradouro.Name = "lblLogradouro";
			this.lblLogradouro.Size = new System.Drawing.Size(80, 20);
			this.lblLogradouro.TabIndex = 63;
			this.lblLogradouro.Text = "Logradouro";
			this.lblLogradouro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tabEntrega
			// 
			this.tabEntrega.BackColor = System.Drawing.SystemColors.Control;
			this.tabEntrega.Controls.Add(this.edtNumeroEntrega);
			this.tabEntrega.Controls.Add(this.lblNumeroEntrega);
			this.tabEntrega.Controls.Add(this.edtCEPEntrega);
			this.tabEntrega.Controls.Add(this.edtCidadeEntrega);
			this.tabEntrega.Controls.Add(this.edtBairroEntrega);
			this.tabEntrega.Controls.Add(this.edtComplementoEntrega);
			this.tabEntrega.Controls.Add(this.edtLogradouroEntrega);
			this.tabEntrega.Controls.Add(this.lblCEPEntrega);
			this.tabEntrega.Controls.Add(this.cbxEstadosEntrega);
			this.tabEntrega.Controls.Add(this.label4lblEstadoEntrega);
			this.tabEntrega.Controls.Add(this.lblBairroEntrega);
			this.tabEntrega.Controls.Add(this.lblCidadeEntrega);
			this.tabEntrega.Controls.Add(this.lblComplementoEntrega);
			this.tabEntrega.Controls.Add(this.lblLogradouroEntrega);
			this.tabEntrega.Location = new System.Drawing.Point(4, 22);
			this.tabEntrega.Name = "tabEntrega";
			this.tabEntrega.Padding = new System.Windows.Forms.Padding(3);
			this.tabEntrega.Size = new System.Drawing.Size(670, 107);
			this.tabEntrega.TabIndex = 1;
			this.tabEntrega.Text = "Entrega";
			// 
			// edtNumeroEntrega
			// 
			this.edtNumeroEntrega.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtNumeroEntrega.Location = new System.Drawing.Point(537, 10);
			this.edtNumeroEntrega.MaxLength = 6;
			this.edtNumeroEntrega.Name = "edtNumeroEntrega";
			this.edtNumeroEntrega.Size = new System.Drawing.Size(48, 20);
			this.edtNumeroEntrega.TabIndex = 80;
			// 
			// lblNumeroEntrega
			// 
			this.lblNumeroEntrega.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblNumeroEntrega.Location = new System.Drawing.Point(470, 10);
			this.lblNumeroEntrega.Name = "lblNumeroEntrega";
			this.lblNumeroEntrega.Size = new System.Drawing.Size(60, 20);
			this.lblNumeroEntrega.TabIndex = 92;
			this.lblNumeroEntrega.Text = "Número";
			this.lblNumeroEntrega.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtCEPEntrega
			// 
			this.edtCEPEntrega.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtCEPEntrega.Location = new System.Drawing.Point(585, 70);
			this.edtCEPEntrega.MaxLength = 10;
			this.edtCEPEntrega.Name = "edtCEPEntrega";
			this.edtCEPEntrega.Size = new System.Drawing.Size(76, 20);
			this.edtCEPEntrega.TabIndex = 85;
			this.edtCEPEntrega.Enter += new System.EventHandler(this.EdtCEPEntregaEnter);
			this.edtCEPEntrega.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EdtNUMERICOKeyPress);
			this.edtCEPEntrega.Leave += new System.EventHandler(this.EdtCEPEntregaLeave);
			// 
			// edtCidadeEntrega
			// 
			this.edtCidadeEntrega.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtCidadeEntrega.Location = new System.Drawing.Point(95, 70);
			this.edtCidadeEntrega.MaxLength = 50;
			this.edtCidadeEntrega.Name = "edtCidadeEntrega";
			this.edtCidadeEntrega.Size = new System.Drawing.Size(356, 20);
			this.edtCidadeEntrega.TabIndex = 83;
			// 
			// edtBairroEntrega
			// 
			this.edtBairroEntrega.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtBairroEntrega.Location = new System.Drawing.Point(305, 40);
			this.edtBairroEntrega.MaxLength = 50;
			this.edtBairroEntrega.Name = "edtBairroEntrega";
			this.edtBairroEntrega.Size = new System.Drawing.Size(356, 20);
			this.edtBairroEntrega.TabIndex = 82;
			// 
			// edtComplementoEntrega
			// 
			this.edtComplementoEntrega.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtComplementoEntrega.Location = new System.Drawing.Point(95, 40);
			this.edtComplementoEntrega.MaxLength = 20;
			this.edtComplementoEntrega.Name = "edtComplementoEntrega";
			this.edtComplementoEntrega.Size = new System.Drawing.Size(146, 20);
			this.edtComplementoEntrega.TabIndex = 81;
			// 
			// edtLogradouroEntrega
			// 
			this.edtLogradouroEntrega.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtLogradouroEntrega.Location = new System.Drawing.Point(95, 10);
			this.edtLogradouroEntrega.MaxLength = 50;
			this.edtLogradouroEntrega.Name = "edtLogradouroEntrega";
			this.edtLogradouroEntrega.Size = new System.Drawing.Size(356, 20);
			this.edtLogradouroEntrega.TabIndex = 79;
			// 
			// lblCEPEntrega
			// 
			this.lblCEPEntrega.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCEPEntrega.Location = new System.Drawing.Point(550, 70);
			this.lblCEPEntrega.Name = "lblCEPEntrega";
			this.lblCEPEntrega.Size = new System.Drawing.Size(30, 20);
			this.lblCEPEntrega.TabIndex = 91;
			this.lblCEPEntrega.Text = "CEP";
			this.lblCEPEntrega.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxEstadosEntrega
			// 
			this.cbxEstadosEntrega.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxEstadosEntrega.FormattingEnabled = true;
			this.cbxEstadosEntrega.Location = new System.Drawing.Point(490, 70);
			this.cbxEstadosEntrega.Name = "cbxEstadosEntrega";
			this.cbxEstadosEntrega.Size = new System.Drawing.Size(50, 22);
			this.cbxEstadosEntrega.TabIndex = 84;
			// 
			// label4lblEstadoEntrega
			// 
			this.label4lblEstadoEntrega.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label4lblEstadoEntrega.Location = new System.Drawing.Point(450, 70);
			this.label4lblEstadoEntrega.Name = "label4lblEstadoEntrega";
			this.label4lblEstadoEntrega.Size = new System.Drawing.Size(30, 20);
			this.label4lblEstadoEntrega.TabIndex = 90;
			this.label4lblEstadoEntrega.Text = "UF";
			this.label4lblEstadoEntrega.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblBairroEntrega
			// 
			this.lblBairroEntrega.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblBairroEntrega.Location = new System.Drawing.Point(259, 40);
			this.lblBairroEntrega.Name = "lblBairroEntrega";
			this.lblBairroEntrega.Size = new System.Drawing.Size(40, 20);
			this.lblBairroEntrega.TabIndex = 89;
			this.lblBairroEntrega.Text = "Bairro";
			this.lblBairroEntrega.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblCidadeEntrega
			// 
			this.lblCidadeEntrega.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCidadeEntrega.Location = new System.Drawing.Point(10, 70);
			this.lblCidadeEntrega.Name = "lblCidadeEntrega";
			this.lblCidadeEntrega.Size = new System.Drawing.Size(80, 20);
			this.lblCidadeEntrega.TabIndex = 88;
			this.lblCidadeEntrega.Text = "Cidade";
			this.lblCidadeEntrega.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblComplementoEntrega
			// 
			this.lblComplementoEntrega.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblComplementoEntrega.Location = new System.Drawing.Point(10, 40);
			this.lblComplementoEntrega.Name = "lblComplementoEntrega";
			this.lblComplementoEntrega.Size = new System.Drawing.Size(80, 20);
			this.lblComplementoEntrega.TabIndex = 87;
			this.lblComplementoEntrega.Text = "Complemento";
			this.lblComplementoEntrega.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblLogradouroEntrega
			// 
			this.lblLogradouroEntrega.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblLogradouroEntrega.Location = new System.Drawing.Point(10, 10);
			this.lblLogradouroEntrega.Name = "lblLogradouroEntrega";
			this.lblLogradouroEntrega.Size = new System.Drawing.Size(80, 20);
			this.lblLogradouroEntrega.TabIndex = 86;
			this.lblLogradouroEntrega.Text = "Logradouro";
			this.lblLogradouroEntrega.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tabEnderecos
			// 
			this.tabEnderecos.Controls.Add(this.tabEndereco);
			this.tabEnderecos.Controls.Add(this.tabEntrega);
			this.tabEnderecos.Controls.Add(this.tabCobranca);
			this.tabEnderecos.Location = new System.Drawing.Point(10, 140);
			this.tabEnderecos.Name = "tabEnderecos";
			this.tabEnderecos.SelectedIndex = 0;
			this.tabEnderecos.Size = new System.Drawing.Size(678, 133);
			this.tabEnderecos.TabIndex = 9;
			// 
			// tabCobranca
			// 
			this.tabCobranca.BackColor = System.Drawing.SystemColors.Control;
			this.tabCobranca.Controls.Add(this.edtNumeroCobranca);
			this.tabCobranca.Controls.Add(this.lblNumeroCobranca);
			this.tabCobranca.Controls.Add(this.edtCEPCobranca);
			this.tabCobranca.Controls.Add(this.edtCidadeCobranca);
			this.tabCobranca.Controls.Add(this.edtBairroCobranca);
			this.tabCobranca.Controls.Add(this.edtComplementoCobranca);
			this.tabCobranca.Controls.Add(this.edtLogradouroCobranca);
			this.tabCobranca.Controls.Add(this.lblCEPCobranca);
			this.tabCobranca.Controls.Add(this.cbxEstadosCobranca);
			this.tabCobranca.Controls.Add(this.lblEstadoCobranca);
			this.tabCobranca.Controls.Add(this.lblBairroCobranca);
			this.tabCobranca.Controls.Add(this.lblCidadeCobranca);
			this.tabCobranca.Controls.Add(this.lblComplementoCobranca);
			this.tabCobranca.Controls.Add(this.lblLogradouroCobranca);
			this.tabCobranca.Location = new System.Drawing.Point(4, 22);
			this.tabCobranca.Name = "tabCobranca";
			this.tabCobranca.Size = new System.Drawing.Size(670, 107);
			this.tabCobranca.TabIndex = 2;
			this.tabCobranca.Text = "Cobrança";
			// 
			// edtNumeroCobranca
			// 
			this.edtNumeroCobranca.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtNumeroCobranca.Location = new System.Drawing.Point(537, 10);
			this.edtNumeroCobranca.MaxLength = 6;
			this.edtNumeroCobranca.Name = "edtNumeroCobranca";
			this.edtNumeroCobranca.Size = new System.Drawing.Size(48, 20);
			this.edtNumeroCobranca.TabIndex = 94;
			// 
			// lblNumeroCobranca
			// 
			this.lblNumeroCobranca.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblNumeroCobranca.Location = new System.Drawing.Point(470, 10);
			this.lblNumeroCobranca.Name = "lblNumeroCobranca";
			this.lblNumeroCobranca.Size = new System.Drawing.Size(60, 20);
			this.lblNumeroCobranca.TabIndex = 106;
			this.lblNumeroCobranca.Text = "Número";
			this.lblNumeroCobranca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtCEPCobranca
			// 
			this.edtCEPCobranca.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtCEPCobranca.Location = new System.Drawing.Point(585, 70);
			this.edtCEPCobranca.MaxLength = 10;
			this.edtCEPCobranca.Name = "edtCEPCobranca";
			this.edtCEPCobranca.Size = new System.Drawing.Size(76, 20);
			this.edtCEPCobranca.TabIndex = 99;
			this.edtCEPCobranca.Enter += new System.EventHandler(this.EdtCEPCobrancaEnter);
			this.edtCEPCobranca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EdtNUMERICOKeyPress);
			this.edtCEPCobranca.Leave += new System.EventHandler(this.EdtCEPCobrancaLeave);
			// 
			// edtCidadeCobranca
			// 
			this.edtCidadeCobranca.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtCidadeCobranca.Location = new System.Drawing.Point(95, 70);
			this.edtCidadeCobranca.MaxLength = 50;
			this.edtCidadeCobranca.Name = "edtCidadeCobranca";
			this.edtCidadeCobranca.Size = new System.Drawing.Size(356, 20);
			this.edtCidadeCobranca.TabIndex = 97;
			// 
			// edtBairroCobranca
			// 
			this.edtBairroCobranca.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtBairroCobranca.Location = new System.Drawing.Point(305, 40);
			this.edtBairroCobranca.MaxLength = 50;
			this.edtBairroCobranca.Name = "edtBairroCobranca";
			this.edtBairroCobranca.Size = new System.Drawing.Size(356, 20);
			this.edtBairroCobranca.TabIndex = 96;
			// 
			// edtComplementoCobranca
			// 
			this.edtComplementoCobranca.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtComplementoCobranca.Location = new System.Drawing.Point(95, 40);
			this.edtComplementoCobranca.MaxLength = 20;
			this.edtComplementoCobranca.Name = "edtComplementoCobranca";
			this.edtComplementoCobranca.Size = new System.Drawing.Size(146, 20);
			this.edtComplementoCobranca.TabIndex = 95;
			// 
			// edtLogradouroCobranca
			// 
			this.edtLogradouroCobranca.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtLogradouroCobranca.Location = new System.Drawing.Point(95, 10);
			this.edtLogradouroCobranca.MaxLength = 50;
			this.edtLogradouroCobranca.Name = "edtLogradouroCobranca";
			this.edtLogradouroCobranca.Size = new System.Drawing.Size(356, 20);
			this.edtLogradouroCobranca.TabIndex = 93;
			// 
			// lblCEPCobranca
			// 
			this.lblCEPCobranca.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCEPCobranca.Location = new System.Drawing.Point(550, 70);
			this.lblCEPCobranca.Name = "lblCEPCobranca";
			this.lblCEPCobranca.Size = new System.Drawing.Size(30, 20);
			this.lblCEPCobranca.TabIndex = 105;
			this.lblCEPCobranca.Text = "CEP";
			this.lblCEPCobranca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxEstadosCobranca
			// 
			this.cbxEstadosCobranca.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxEstadosCobranca.FormattingEnabled = true;
			this.cbxEstadosCobranca.Location = new System.Drawing.Point(490, 70);
			this.cbxEstadosCobranca.Name = "cbxEstadosCobranca";
			this.cbxEstadosCobranca.Size = new System.Drawing.Size(50, 22);
			this.cbxEstadosCobranca.TabIndex = 98;
			// 
			// lblEstadoCobranca
			// 
			this.lblEstadoCobranca.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblEstadoCobranca.Location = new System.Drawing.Point(450, 70);
			this.lblEstadoCobranca.Name = "lblEstadoCobranca";
			this.lblEstadoCobranca.Size = new System.Drawing.Size(30, 20);
			this.lblEstadoCobranca.TabIndex = 104;
			this.lblEstadoCobranca.Text = "UF";
			this.lblEstadoCobranca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblBairroCobranca
			// 
			this.lblBairroCobranca.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblBairroCobranca.Location = new System.Drawing.Point(259, 40);
			this.lblBairroCobranca.Name = "lblBairroCobranca";
			this.lblBairroCobranca.Size = new System.Drawing.Size(40, 20);
			this.lblBairroCobranca.TabIndex = 103;
			this.lblBairroCobranca.Text = "Bairro";
			this.lblBairroCobranca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblCidadeCobranca
			// 
			this.lblCidadeCobranca.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCidadeCobranca.Location = new System.Drawing.Point(10, 70);
			this.lblCidadeCobranca.Name = "lblCidadeCobranca";
			this.lblCidadeCobranca.Size = new System.Drawing.Size(80, 20);
			this.lblCidadeCobranca.TabIndex = 102;
			this.lblCidadeCobranca.Text = "Cidade";
			this.lblCidadeCobranca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblComplementoCobranca
			// 
			this.lblComplementoCobranca.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblComplementoCobranca.Location = new System.Drawing.Point(10, 40);
			this.lblComplementoCobranca.Name = "lblComplementoCobranca";
			this.lblComplementoCobranca.Size = new System.Drawing.Size(80, 20);
			this.lblComplementoCobranca.TabIndex = 101;
			this.lblComplementoCobranca.Text = "Complemento";
			this.lblComplementoCobranca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblLogradouroCobranca
			// 
			this.lblLogradouroCobranca.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblLogradouroCobranca.Location = new System.Drawing.Point(10, 10);
			this.lblLogradouroCobranca.Name = "lblLogradouroCobranca";
			this.lblLogradouroCobranca.Size = new System.Drawing.Size(80, 20);
			this.lblLogradouroCobranca.TabIndex = 100;
			this.lblLogradouroCobranca.Text = "Logradouro";
			this.lblLogradouroCobranca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblCelular
			// 
			this.lblCelular.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCelular.Location = new System.Drawing.Point(330, 280);
			this.lblCelular.Name = "lblCelular";
			this.lblCelular.Size = new System.Drawing.Size(60, 20);
			this.lblCelular.TabIndex = 72;
			this.lblCelular.Text = "Celular";
			this.lblCelular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtFone2
			// 
			this.edtFone2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtFone2.Location = new System.Drawing.Point(217, 280);
			this.edtFone2.MaxLength = 13;
			this.edtFone2.Name = "edtFone2";
			this.edtFone2.Size = new System.Drawing.Size(97, 20);
			this.edtFone2.TabIndex = 15;
			this.edtFone2.Enter += new System.EventHandler(this.EdtFone2Enter);
			this.edtFone2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EdtNUMERICOKeyPress);
			this.edtFone2.Leave += new System.EventHandler(this.EdtFone2Leave);
			// 
			// edtInsMun
			// 
			this.edtInsMun.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtInsMun.Location = new System.Drawing.Point(341, 110);
			this.edtInsMun.MaxLength = 15;
			this.edtInsMun.Name = "edtInsMun";
			this.edtInsMun.Size = new System.Drawing.Size(111, 20);
			this.edtInsMun.TabIndex = 8;
			// 
			// lblInsMun
			// 
			this.lblInsMun.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblInsMun.Location = new System.Drawing.Point(255, 109);
			this.lblInsMun.Name = "lblInsMun";
			this.lblInsMun.Size = new System.Drawing.Size(80, 20);
			this.lblInsMun.TabIndex = 76;
			this.lblInsMun.Text = "Insc. Municipal";
			this.lblInsMun.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtInsEst
			// 
			this.edtInsEst.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtInsEst.Location = new System.Drawing.Point(96, 110);
			this.edtInsEst.MaxLength = 14;
			this.edtInsEst.Name = "edtInsEst";
			this.edtInsEst.Size = new System.Drawing.Size(104, 20);
			this.edtInsEst.TabIndex = 7;
			// 
			// lblInsEst
			// 
			this.lblInsEst.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblInsEst.Location = new System.Drawing.Point(10, 110);
			this.lblInsEst.Name = "lblInsEst";
			this.lblInsEst.Size = new System.Drawing.Size(80, 20);
			this.lblInsEst.TabIndex = 75;
			this.lblInsEst.Text = "Insc. Estadual";
			this.lblInsEst.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtPedido
			// 
			this.edtPedido.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtPedido.Location = new System.Drawing.Point(515, 111);
			this.edtPedido.MaxLength = 9;
			this.edtPedido.Name = "edtPedido";
			this.edtPedido.Size = new System.Drawing.Size(69, 20);
			this.edtPedido.TabIndex = 9;
			// 
			// lblPedido
			// 
			this.lblPedido.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblPedido.Location = new System.Drawing.Point(459, 110);
			this.lblPedido.Name = "lblPedido";
			this.lblPedido.Size = new System.Drawing.Size(50, 20);
			this.lblPedido.TabIndex = 78;
			this.lblPedido.Text = "Pedido";
			this.lblPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpAlteracao
			// 
			this.dtpAlteracao.CustomFormat = "dd/MM/yyyy HH:mm:ss";
			this.dtpAlteracao.Enabled = false;
			this.dtpAlteracao.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpAlteracao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpAlteracao.Location = new System.Drawing.Point(101, 370);
			this.dtpAlteracao.Name = "dtpAlteracao";
			this.dtpAlteracao.Size = new System.Drawing.Size(170, 20);
			this.dtpAlteracao.TabIndex = 21;
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label3.Location = new System.Drawing.Point(16, 370);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 20);
			this.label3.TabIndex = 125;
			this.label3.Text = "Cadastro";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnImprime
			// 
			this.btnImprime.Location = new System.Drawing.Point(590, 160);
			this.btnImprime.Name = "btnImprime";
			this.btnImprime.Size = new System.Drawing.Size(100, 25);
			this.btnImprime.TabIndex = 10;
			this.btnImprime.Text = "I&mprime";
			this.btnImprime.UseVisualStyleBackColor = true;
			this.btnImprime.Click += new System.EventHandler(this.BtnImprimeClick);
			// 
			// dtpNascimento
			// 
			this.dtpNascimento.Checked = false;
			this.dtpNascimento.CustomFormat = "dd/MM/yyyy";
			this.dtpNascimento.Enabled = false;
			this.dtpNascimento.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpNascimento.Location = new System.Drawing.Point(101, 340);
			this.dtpNascimento.Name = "dtpNascimento";
			this.dtpNascimento.ShowCheckBox = true;
			this.dtpNascimento.Size = new System.Drawing.Size(108, 20);
			this.dtpNascimento.TabIndex = 20;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(16, 340);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 20);
			this.label1.TabIndex = 127;
			this.label1.Text = "Nascimento";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnAuditoria
			// 
			this.btnAuditoria.Location = new System.Drawing.Point(401, 9);
			this.btnAuditoria.Name = "btnAuditoria";
			this.btnAuditoria.Size = new System.Drawing.Size(100, 25);
			this.btnAuditoria.TabIndex = 11;
			this.btnAuditoria.Text = "Auditoria";
			this.btnAuditoria.UseVisualStyleBackColor = true;
			this.btnAuditoria.Click += new System.EventHandler(this.btnAuditoriaClick);
			// 
			// frmCadParceiros
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(704, 610);
			this.Controls.Add(this.btnAuditoria);
			this.Controls.Add(this.btnImprime);
			this.Controls.Add(this.btnContatos);
			this.Name = "frmCadParceiros";
			this.Text = "Cadastros Básicos - Parceiros";
			this.Load += new System.EventHandler(this.FrmCadParceirosLoad);
			this.Controls.SetChildIndex(this.btnFecha, 0);
			this.Controls.SetChildIndex(this.btnAltera, 0);
			this.Controls.SetChildIndex(this.btnExclui, 0);
			this.Controls.SetChildIndex(this.btnInclui, 0);
			this.Controls.SetChildIndex(this.btnContatos, 0);
			this.Controls.SetChildIndex(this.btnUp, 0);
			this.Controls.SetChildIndex(this.btnDown, 0);
			this.Controls.SetChildIndex(this.pnlEdicao, 0);
			this.Controls.SetChildIndex(this.edtLocaliza, 0);
			this.Controls.SetChildIndex(this.btnLocaliza, 0);
			this.Controls.SetChildIndex(this.btnImprime, 0);
			this.Controls.SetChildIndex(this.btnAuditoria, 0);
			this.pnlEdicao.ResumeLayout(false);
			this.pnlEdicao.PerformLayout();
			this.grpTipo.ResumeLayout(false);
			this.grpPessoa.ResumeLayout(false);
			this.tabEndereco.ResumeLayout(false);
			this.tabEndereco.PerformLayout();
			this.tabEntrega.ResumeLayout(false);
			this.tabEntrega.PerformLayout();
			this.tabEnderecos.ResumeLayout(false);
			this.tabCobranca.ResumeLayout(false);
			this.tabCobranca.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		public System.Windows.Forms.DateTimePicker dtpNascimento;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnImprime;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.DateTimePicker dtpAlteracao;
		private System.Windows.Forms.Label lblPedido;
		private System.Windows.Forms.TextBox edtPedido;
		private System.Windows.Forms.Label lblInsEst;
		private System.Windows.Forms.TextBox edtInsEst;
		private System.Windows.Forms.Label lblInsMun;
		private System.Windows.Forms.TextBox edtInsMun;
		private System.Windows.Forms.TextBox edtFone1;
		private System.Windows.Forms.TextBox edtFone2;
		private System.Windows.Forms.TextBox edtCelular;
		private System.Windows.Forms.Label lblCelular;
		private System.Windows.Forms.TextBox edtBairroCobranca;
		private System.Windows.Forms.ComboBox cbxEstadosCobranca;
		private System.Windows.Forms.Label lblLogradouroCobranca;
		private System.Windows.Forms.Label lblComplementoCobranca;
		private System.Windows.Forms.Label lblCidadeCobranca;
		private System.Windows.Forms.Label lblBairroCobranca;
		private System.Windows.Forms.Label lblEstadoCobranca;
		private System.Windows.Forms.Label lblCEPCobranca;
		private System.Windows.Forms.TextBox edtLogradouroCobranca;
		private System.Windows.Forms.TextBox edtComplementoCobranca;
		private System.Windows.Forms.TextBox edtCidadeCobranca;
		private System.Windows.Forms.TextBox edtCEPCobranca;
		private System.Windows.Forms.Label lblNumeroCobranca;
		private System.Windows.Forms.TextBox edtNumeroCobranca;
		private System.Windows.Forms.TabPage tabCobranca;
		private System.Windows.Forms.ComboBox cbxEstadosEntrega;
		private System.Windows.Forms.TextBox edtLogradouroEntrega;
		private System.Windows.Forms.TextBox edtComplementoEntrega;
		private System.Windows.Forms.TextBox edtCidadeEntrega;
		private System.Windows.Forms.TextBox edtCEPEntrega;
		private System.Windows.Forms.TabControl tabEnderecos;
		private System.Windows.Forms.TabPage tabEndereco;
		private System.Windows.Forms.TabPage tabEntrega;
		private System.Windows.Forms.Label lblLogradouroEntrega;
		private System.Windows.Forms.Label lblComplementoEntrega;
		private System.Windows.Forms.Label lblCidadeEntrega;
		private System.Windows.Forms.Label lblBairroEntrega;
		private System.Windows.Forms.Label label4lblEstadoEntrega;
		private System.Windows.Forms.Label lblCEPEntrega;
		private System.Windows.Forms.TextBox edtBairroEntrega;
		private System.Windows.Forms.Label lblNumeroEntrega;
		private System.Windows.Forms.TextBox edtNumeroEntrega;
		private System.Windows.Forms.TextBox edtFAX;
		private System.Windows.Forms.CheckBox ckbConsultor;
		private System.Windows.Forms.CheckBox ckbFornecedor;
		private System.Windows.Forms.CheckBox ckbCliente;
		private System.Windows.Forms.Label lblFAX;
		private System.Windows.Forms.Button btnContatos;
		private System.Windows.Forms.CheckBox ckbAtivo;
		private System.Windows.Forms.Label lblCNPJ;
		private System.Windows.Forms.TextBox edtCNPJ;
		private System.Windows.Forms.Label lblLogradouro;
		private System.Windows.Forms.TextBox edtLogradouro;
		private System.Windows.Forms.Label lblNumero;
		private System.Windows.Forms.TextBox edtNumero;
		private System.Windows.Forms.Label lblComplemento;
		private System.Windows.Forms.TextBox edtComplemento;
		private System.Windows.Forms.Label lblBairro;
		private System.Windows.Forms.TextBox edtBairro;
		private System.Windows.Forms.Label lblCidade;
		private System.Windows.Forms.TextBox edtCidade;
		private System.Windows.Forms.Label lblEstado;
		private System.Windows.Forms.ComboBox cbxEstados;
		private System.Windows.Forms.Label lblCEP;
		private System.Windows.Forms.TextBox edtCEP;
		private System.Windows.Forms.Label lblFone;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.TextBox edtEmail;
		private System.Windows.Forms.GroupBox grpTipo;
		private System.Windows.Forms.RadioButton rbtFisica;
		public System.Windows.Forms.RadioButton rbtJuridica;
		private System.Windows.Forms.GroupBox grpPessoa;
		private System.Windows.Forms.Button btnAuditoria;
	}
}
