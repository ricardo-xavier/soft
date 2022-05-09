/*
 * Criado por SharpDevelop.
 * Usuário: Ricardo
 * Data: 16/05/2010
 * Hora: 17:52
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace basico
{
	partial class fImpressaoParceiros
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
			this.grpPessoa = new System.Windows.Forms.GroupBox();
			this.chkJuridica = new System.Windows.Forms.CheckBox();
			this.chkFisica = new System.Windows.Forms.CheckBox();
			this.label9 = new System.Windows.Forms.Label();
			this.dtpOrcamentoF = new System.Windows.Forms.DateTimePicker();
			this.label13 = new System.Windows.Forms.Label();
			this.dtpOrcamentoI = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.dtpPedidoF = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.dtpPedidoI = new System.Windows.Forms.DateTimePicker();
			this.btnCancela = new System.Windows.Forms.Button();
			this.btnConfirma = new System.Windows.Forms.Button();
			this.edtTitulo = new System.Windows.Forms.TextBox();
			this.lblItem = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.chkConsultor = new System.Windows.Forms.CheckBox();
			this.chkCliente = new System.Windows.Forms.CheckBox();
			this.chkFornecedor = new System.Windows.Forms.CheckBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.chkContatos = new System.Windows.Forms.CheckBox();
			this.chkDatNascimento = new System.Windows.Forms.CheckBox();
			this.chkDataCadastro = new System.Windows.Forms.CheckBox();
			this.chkIM = new System.Windows.Forms.CheckBox();
			this.chkIE = new System.Windows.Forms.CheckBox();
			this.chkEmail = new System.Windows.Forms.CheckBox();
			this.chkFone = new System.Windows.Forms.CheckBox();
			this.chkEndereco = new System.Windows.Forms.CheckBox();
			this.chkCpfCnpj = new System.Windows.Forms.CheckBox();
			this.chkTipoPessoa = new System.Windows.Forms.CheckBox();
			this.chkPapel = new System.Windows.Forms.CheckBox();
			this.chkNome = new System.Windows.Forms.CheckBox();
			this.chkCodigo = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.dtpCadastroF = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.dtpCadastroI = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.dtpNascimentoF = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.dtpNascimentoI = new System.Windows.Forms.DateTimePicker();
			this.btnMailing = new System.Windows.Forms.Button();
			this.dlgSave = new System.Windows.Forms.SaveFileDialog();
			this.grpPessoa.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpPessoa
			// 
			this.grpPessoa.Controls.Add(this.chkJuridica);
			this.grpPessoa.Controls.Add(this.chkFisica);
			this.grpPessoa.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.grpPessoa.Location = new System.Drawing.Point(12, 12);
			this.grpPessoa.Name = "grpPessoa";
			this.grpPessoa.Size = new System.Drawing.Size(172, 50);
			this.grpPessoa.TabIndex = 0;
			this.grpPessoa.TabStop = false;
			this.grpPessoa.Text = "Tipo Pessoa";
			// 
			// chkJuridica
			// 
			this.chkJuridica.Checked = true;
			this.chkJuridica.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkJuridica.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkJuridica.Location = new System.Drawing.Point(81, 19);
			this.chkJuridica.Name = "chkJuridica";
			this.chkJuridica.Size = new System.Drawing.Size(80, 24);
			this.chkJuridica.TabIndex = 10;
			this.chkJuridica.Text = "Jurídica";
			this.chkJuridica.UseVisualStyleBackColor = true;
			// 
			// chkFisica
			// 
			this.chkFisica.Checked = true;
			this.chkFisica.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkFisica.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkFisica.Location = new System.Drawing.Point(8, 19);
			this.chkFisica.Name = "chkFisica";
			this.chkFisica.Size = new System.Drawing.Size(80, 24);
			this.chkFisica.TabIndex = 9;
			this.chkFisica.Text = "Física";
			this.chkFisica.UseVisualStyleBackColor = true;
			// 
			// label9
			// 
			this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label9.Location = new System.Drawing.Point(224, 119);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(25, 20);
			this.label9.TabIndex = 90;
			this.label9.Text = "até";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpOrcamentoF
			// 
			this.dtpOrcamentoF.Checked = false;
			this.dtpOrcamentoF.CustomFormat = "dd/MM/yyyy";
			this.dtpOrcamentoF.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpOrcamentoF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpOrcamentoF.Location = new System.Drawing.Point(259, 119);
			this.dtpOrcamentoF.Name = "dtpOrcamentoF";
			this.dtpOrcamentoF.ShowCheckBox = true;
			this.dtpOrcamentoF.Size = new System.Drawing.Size(110, 20);
			this.dtpOrcamentoF.TabIndex = 14;
			// 
			// label13
			// 
			this.label13.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label13.Location = new System.Drawing.Point(19, 119);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(80, 20);
			this.label13.TabIndex = 89;
			this.label13.Text = "Orçamentos de";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpOrcamentoI
			// 
			this.dtpOrcamentoI.Checked = false;
			this.dtpOrcamentoI.CustomFormat = "dd/MM/yyyy";
			this.dtpOrcamentoI.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpOrcamentoI.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpOrcamentoI.Location = new System.Drawing.Point(104, 119);
			this.dtpOrcamentoI.Name = "dtpOrcamentoI";
			this.dtpOrcamentoI.ShowCheckBox = true;
			this.dtpOrcamentoI.Size = new System.Drawing.Size(110, 20);
			this.dtpOrcamentoI.TabIndex = 12;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(224, 145);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(25, 20);
			this.label1.TabIndex = 94;
			this.label1.Text = "até";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpPedidoF
			// 
			this.dtpPedidoF.Checked = false;
			this.dtpPedidoF.CustomFormat = "dd/MM/yyyy";
			this.dtpPedidoF.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpPedidoF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpPedidoF.Location = new System.Drawing.Point(259, 145);
			this.dtpPedidoF.Name = "dtpPedidoF";
			this.dtpPedidoF.ShowCheckBox = true;
			this.dtpPedidoF.Size = new System.Drawing.Size(110, 20);
			this.dtpPedidoF.TabIndex = 18;
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label2.Location = new System.Drawing.Point(19, 145);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 20);
			this.label2.TabIndex = 93;
			this.label2.Text = "Pedidos de";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpPedidoI
			// 
			this.dtpPedidoI.Checked = false;
			this.dtpPedidoI.CustomFormat = "dd/MM/yyyy";
			this.dtpPedidoI.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpPedidoI.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpPedidoI.Location = new System.Drawing.Point(104, 145);
			this.dtpPedidoI.Name = "dtpPedidoI";
			this.dtpPedidoI.ShowCheckBox = true;
			this.dtpPedidoI.Size = new System.Drawing.Size(110, 20);
			this.dtpPedidoI.TabIndex = 16;
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(359, 408);
			this.btnCancela.Name = "btnCancela";
			this.btnCancela.Size = new System.Drawing.Size(100, 25);
			this.btnCancela.TabIndex = 28;
			this.btnCancela.Text = "C&ancela";
			this.btnCancela.UseVisualStyleBackColor = true;
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(149, 408);
			this.btnConfirma.Name = "btnConfirma";
			this.btnConfirma.Size = new System.Drawing.Size(100, 25);
			this.btnConfirma.TabIndex = 24;
			this.btnConfirma.Text = "&Confirma";
			this.btnConfirma.UseVisualStyleBackColor = true;
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// edtTitulo
			// 
			this.edtTitulo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtTitulo.Location = new System.Drawing.Point(104, 171);
			this.edtTitulo.MaxLength = 50;
			this.edtTitulo.Name = "edtTitulo";
			this.edtTitulo.Size = new System.Drawing.Size(356, 20);
			this.edtTitulo.TabIndex = 20;
			this.edtTitulo.Text = "Listagem de Parceiros";
			// 
			// lblItem
			// 
			this.lblItem.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblItem.Location = new System.Drawing.Point(18, 170);
			this.lblItem.Name = "lblItem";
			this.lblItem.Size = new System.Drawing.Size(80, 20);
			this.lblItem.TabIndex = 128;
			this.lblItem.Text = "Título";
			this.lblItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.chkConsultor);
			this.groupBox1.Controls.Add(this.chkCliente);
			this.groupBox1.Controls.Add(this.chkFornecedor);
			this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.groupBox1.Location = new System.Drawing.Point(190, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(270, 50);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Papel";
			// 
			// chkConsultor
			// 
			this.chkConsultor.Checked = true;
			this.chkConsultor.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkConsultor.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkConsultor.Location = new System.Drawing.Point(171, 19);
			this.chkConsultor.Name = "chkConsultor";
			this.chkConsultor.Size = new System.Drawing.Size(80, 24);
			this.chkConsultor.TabIndex = 11;
			this.chkConsultor.Text = "Consultor";
			this.chkConsultor.UseVisualStyleBackColor = true;
			// 
			// chkCliente
			// 
			this.chkCliente.Checked = true;
			this.chkCliente.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkCliente.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkCliente.Location = new System.Drawing.Point(94, 19);
			this.chkCliente.Name = "chkCliente";
			this.chkCliente.Size = new System.Drawing.Size(80, 24);
			this.chkCliente.TabIndex = 10;
			this.chkCliente.Text = "Cliente";
			this.chkCliente.UseVisualStyleBackColor = true;
			// 
			// chkFornecedor
			// 
			this.chkFornecedor.Checked = true;
			this.chkFornecedor.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkFornecedor.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkFornecedor.Location = new System.Drawing.Point(8, 19);
			this.chkFornecedor.Name = "chkFornecedor";
			this.chkFornecedor.Size = new System.Drawing.Size(80, 24);
			this.chkFornecedor.TabIndex = 9;
			this.chkFornecedor.Text = "Fornecedor";
			this.chkFornecedor.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.chkContatos);
			this.groupBox2.Controls.Add(this.chkDatNascimento);
			this.groupBox2.Controls.Add(this.chkDataCadastro);
			this.groupBox2.Controls.Add(this.chkIM);
			this.groupBox2.Controls.Add(this.chkIE);
			this.groupBox2.Controls.Add(this.chkEmail);
			this.groupBox2.Controls.Add(this.chkFone);
			this.groupBox2.Controls.Add(this.chkEndereco);
			this.groupBox2.Controls.Add(this.chkCpfCnpj);
			this.groupBox2.Controls.Add(this.chkTipoPessoa);
			this.groupBox2.Controls.Add(this.chkPapel);
			this.groupBox2.Controls.Add(this.chkNome);
			this.groupBox2.Controls.Add(this.chkCodigo);
			this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.groupBox2.Location = new System.Drawing.Point(11, 197);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(448, 203);
			this.groupBox2.TabIndex = 22;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Campos";
			// 
			// chkContatos
			// 
			this.chkContatos.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkContatos.Location = new System.Drawing.Point(300, 19);
			this.chkContatos.Name = "chkContatos";
			this.chkContatos.Size = new System.Drawing.Size(118, 24);
			this.chkContatos.TabIndex = 21;
			this.chkContatos.Text = "Contatos";
			this.chkContatos.UseVisualStyleBackColor = true;
			// 
			// chkDatNascimento
			// 
			this.chkDatNascimento.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkDatNascimento.Location = new System.Drawing.Point(148, 169);
			this.chkDatNascimento.Name = "chkDatNascimento";
			this.chkDatNascimento.Size = new System.Drawing.Size(118, 24);
			this.chkDatNascimento.TabIndex = 20;
			this.chkDatNascimento.Text = "Data Nascimento";
			this.chkDatNascimento.UseVisualStyleBackColor = true;
			// 
			// chkDataCadastro
			// 
			this.chkDataCadastro.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkDataCadastro.Location = new System.Drawing.Point(148, 139);
			this.chkDataCadastro.Name = "chkDataCadastro";
			this.chkDataCadastro.Size = new System.Drawing.Size(118, 24);
			this.chkDataCadastro.TabIndex = 19;
			this.chkDataCadastro.Text = "Data Cadastro";
			this.chkDataCadastro.UseVisualStyleBackColor = true;
			// 
			// chkIM
			// 
			this.chkIM.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkIM.Location = new System.Drawing.Point(148, 109);
			this.chkIM.Name = "chkIM";
			this.chkIM.Size = new System.Drawing.Size(118, 24);
			this.chkIM.TabIndex = 18;
			this.chkIM.Text = "Incrição Municipal";
			this.chkIM.UseVisualStyleBackColor = true;
			// 
			// chkIE
			// 
			this.chkIE.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkIE.Location = new System.Drawing.Point(148, 79);
			this.chkIE.Name = "chkIE";
			this.chkIE.Size = new System.Drawing.Size(118, 24);
			this.chkIE.TabIndex = 17;
			this.chkIE.Text = "Incrição Estadual";
			this.chkIE.UseVisualStyleBackColor = true;
			// 
			// chkEmail
			// 
			this.chkEmail.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkEmail.Location = new System.Drawing.Point(148, 49);
			this.chkEmail.Name = "chkEmail";
			this.chkEmail.Size = new System.Drawing.Size(90, 24);
			this.chkEmail.TabIndex = 16;
			this.chkEmail.Text = "Email";
			this.chkEmail.UseVisualStyleBackColor = true;
			// 
			// chkFone
			// 
			this.chkFone.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkFone.Location = new System.Drawing.Point(148, 19);
			this.chkFone.Name = "chkFone";
			this.chkFone.Size = new System.Drawing.Size(90, 24);
			this.chkFone.TabIndex = 15;
			this.chkFone.Text = "Fone";
			this.chkFone.UseVisualStyleBackColor = true;
			// 
			// chkEndereco
			// 
			this.chkEndereco.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkEndereco.Location = new System.Drawing.Point(8, 169);
			this.chkEndereco.Name = "chkEndereco";
			this.chkEndereco.Size = new System.Drawing.Size(90, 24);
			this.chkEndereco.TabIndex = 14;
			this.chkEndereco.Text = "Endereço";
			this.chkEndereco.UseVisualStyleBackColor = true;
			// 
			// chkCpfCnpj
			// 
			this.chkCpfCnpj.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkCpfCnpj.Location = new System.Drawing.Point(8, 139);
			this.chkCpfCnpj.Name = "chkCpfCnpj";
			this.chkCpfCnpj.Size = new System.Drawing.Size(90, 24);
			this.chkCpfCnpj.TabIndex = 13;
			this.chkCpfCnpj.Text = "Cpf/Cnpj";
			this.chkCpfCnpj.UseVisualStyleBackColor = true;
			// 
			// chkTipoPessoa
			// 
			this.chkTipoPessoa.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkTipoPessoa.Location = new System.Drawing.Point(8, 109);
			this.chkTipoPessoa.Name = "chkTipoPessoa";
			this.chkTipoPessoa.Size = new System.Drawing.Size(90, 24);
			this.chkTipoPessoa.TabIndex = 12;
			this.chkTipoPessoa.Text = "Tipo Pessoa";
			this.chkTipoPessoa.UseVisualStyleBackColor = true;
			// 
			// chkPapel
			// 
			this.chkPapel.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkPapel.Location = new System.Drawing.Point(8, 79);
			this.chkPapel.Name = "chkPapel";
			this.chkPapel.Size = new System.Drawing.Size(80, 24);
			this.chkPapel.TabIndex = 11;
			this.chkPapel.Text = "Papel";
			this.chkPapel.UseVisualStyleBackColor = true;
			// 
			// chkNome
			// 
			this.chkNome.Checked = true;
			this.chkNome.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkNome.Enabled = false;
			this.chkNome.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkNome.Location = new System.Drawing.Point(8, 49);
			this.chkNome.Name = "chkNome";
			this.chkNome.Size = new System.Drawing.Size(80, 24);
			this.chkNome.TabIndex = 10;
			this.chkNome.Text = "Nome";
			this.chkNome.UseVisualStyleBackColor = true;
			// 
			// chkCodigo
			// 
			this.chkCodigo.Checked = true;
			this.chkCodigo.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkCodigo.Enabled = false;
			this.chkCodigo.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkCodigo.Location = new System.Drawing.Point(8, 19);
			this.chkCodigo.Name = "chkCodigo";
			this.chkCodigo.Size = new System.Drawing.Size(80, 24);
			this.chkCodigo.TabIndex = 9;
			this.chkCodigo.Text = "Código";
			this.chkCodigo.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label3.Location = new System.Drawing.Point(224, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(25, 20);
			this.label3.TabIndex = 134;
			this.label3.Text = "até";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpCadastroF
			// 
			this.dtpCadastroF.Checked = false;
			this.dtpCadastroF.CustomFormat = "dd/MM/yyyy";
			this.dtpCadastroF.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpCadastroF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpCadastroF.Location = new System.Drawing.Point(259, 68);
			this.dtpCadastroF.Name = "dtpCadastroF";
			this.dtpCadastroF.ShowCheckBox = true;
			this.dtpCadastroF.Size = new System.Drawing.Size(110, 20);
			this.dtpCadastroF.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label4.Location = new System.Drawing.Point(19, 68);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 20);
			this.label4.TabIndex = 133;
			this.label4.Text = "Cadastro de";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpCadastroI
			// 
			this.dtpCadastroI.Checked = false;
			this.dtpCadastroI.CustomFormat = "dd/MM/yyyy";
			this.dtpCadastroI.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpCadastroI.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpCadastroI.Location = new System.Drawing.Point(104, 68);
			this.dtpCadastroI.Name = "dtpCadastroI";
			this.dtpCadastroI.ShowCheckBox = true;
			this.dtpCadastroI.Size = new System.Drawing.Size(110, 20);
			this.dtpCadastroI.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label5.Location = new System.Drawing.Point(224, 94);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(25, 20);
			this.label5.TabIndex = 138;
			this.label5.Text = "até";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpNascimentoF
			// 
			this.dtpNascimentoF.Checked = false;
			this.dtpNascimentoF.CustomFormat = "dd/MM";
			this.dtpNascimentoF.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpNascimentoF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpNascimentoF.Location = new System.Drawing.Point(259, 94);
			this.dtpNascimentoF.Name = "dtpNascimentoF";
			this.dtpNascimentoF.ShowCheckBox = true;
			this.dtpNascimentoF.Size = new System.Drawing.Size(80, 20);
			this.dtpNascimentoF.TabIndex = 10;
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label6.Location = new System.Drawing.Point(19, 94);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 20);
			this.label6.TabIndex = 137;
			this.label6.Text = "Nascimento de";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dtpNascimentoI
			// 
			this.dtpNascimentoI.Checked = false;
			this.dtpNascimentoI.CustomFormat = "dd/MM";
			this.dtpNascimentoI.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpNascimentoI.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpNascimentoI.Location = new System.Drawing.Point(104, 94);
			this.dtpNascimentoI.Name = "dtpNascimentoI";
			this.dtpNascimentoI.ShowCheckBox = true;
			this.dtpNascimentoI.Size = new System.Drawing.Size(80, 20);
			this.dtpNascimentoI.TabIndex = 8;
			// 
			// btnMailing
			// 
			this.btnMailing.Location = new System.Drawing.Point(253, 408);
			this.btnMailing.Name = "btnMailing";
			this.btnMailing.Size = new System.Drawing.Size(100, 25);
			this.btnMailing.TabIndex = 26;
			this.btnMailing.Text = "&Mailing";
			this.btnMailing.UseVisualStyleBackColor = true;
			this.btnMailing.Click += new System.EventHandler(this.BtnMailingClick);
			// 
			// dlgSave
			// 
			this.dlgSave.Filter = "Arquivo separado por vírguta(*.csv)|*.csv";
			// 
			// fImpressaoParceiros
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(472, 444);
			this.Controls.Add(this.btnMailing);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.dtpNascimentoF);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.dtpNascimentoI);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dtpCadastroF);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dtpCadastroI);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.edtTitulo);
			this.Controls.Add(this.lblItem);
			this.Controls.Add(this.btnCancela);
			this.Controls.Add(this.btnConfirma);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dtpPedidoF);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dtpPedidoI);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.dtpOrcamentoF);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.dtpOrcamentoI);
			this.Controls.Add(this.grpPessoa);
			this.Name = "fImpressaoParceiros";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Parâmetros de Impressão";
			this.Load += new System.EventHandler(this.FImpressaoParceirosLoad);
			this.grpPessoa.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.SaveFileDialog dlgSave;
		public System.Windows.Forms.Button btnMailing;
		private System.Windows.Forms.CheckBox chkContatos;
		private System.Windows.Forms.DateTimePicker dtpNascimentoI;
		private System.Windows.Forms.DateTimePicker dtpNascimentoF;
		private System.Windows.Forms.DateTimePicker dtpCadastroI;
		private System.Windows.Forms.DateTimePicker dtpCadastroF;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox chkDatNascimento;
		private System.Windows.Forms.CheckBox chkCodigo;
		private System.Windows.Forms.CheckBox chkNome;
		private System.Windows.Forms.CheckBox chkPapel;
		private System.Windows.Forms.CheckBox chkTipoPessoa;
		private System.Windows.Forms.CheckBox chkCpfCnpj;
		private System.Windows.Forms.CheckBox chkEndereco;
		private System.Windows.Forms.CheckBox chkFone;
		private System.Windows.Forms.CheckBox chkEmail;
		private System.Windows.Forms.CheckBox chkIE;
		private System.Windows.Forms.CheckBox chkIM;
		private System.Windows.Forms.CheckBox chkDataCadastro;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox chkFornecedor;
		private System.Windows.Forms.CheckBox chkCliente;
		private System.Windows.Forms.CheckBox chkConsultor;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DateTimePicker dtpPedidoF;
		private System.Windows.Forms.DateTimePicker dtpPedidoI;
		private System.Windows.Forms.CheckBox chkFisica;
		private System.Windows.Forms.CheckBox chkJuridica;
		private System.Windows.Forms.DateTimePicker dtpOrcamentoI;
		private System.Windows.Forms.DateTimePicker dtpOrcamentoF;
		public System.Windows.Forms.Label lblItem;
		public System.Windows.Forms.TextBox edtTitulo;
		public System.Windows.Forms.Button btnConfirma;
		public System.Windows.Forms.Button btnCancela;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.GroupBox grpPessoa;
	}
}
