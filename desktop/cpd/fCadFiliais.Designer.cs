/*
 * Usuário: Ricardo
 * Data: 23/03/2008
 * Hora: 0:20
 * 
 */
namespace cpd
{
	partial class frmCadFiliais
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
			this.lblCNPJ = new System.Windows.Forms.Label();
			this.edtCNPJ = new System.Windows.Forms.TextBox();
			this.lblInsEst = new System.Windows.Forms.Label();
			this.edtInsEst = new System.Windows.Forms.TextBox();
			this.lblInsMun = new System.Windows.Forms.Label();
			this.edtInsMun = new System.Windows.Forms.TextBox();
			this.lblLogradouro = new System.Windows.Forms.Label();
			this.edtLogradouro = new System.Windows.Forms.TextBox();
			this.lblNumero = new System.Windows.Forms.Label();
			this.edtNumero = new System.Windows.Forms.TextBox();
			this.lblComplemento = new System.Windows.Forms.Label();
			this.edtComplemento = new System.Windows.Forms.TextBox();
			this.lblBairro = new System.Windows.Forms.Label();
			this.edtBairro = new System.Windows.Forms.TextBox();
			this.lblCidade = new System.Windows.Forms.Label();
			this.edtCidade = new System.Windows.Forms.TextBox();
			this.lblEstado = new System.Windows.Forms.Label();
			this.cbxEstados = new System.Windows.Forms.ComboBox();
			this.lblCEP = new System.Windows.Forms.Label();
			this.edtCEP = new System.Windows.Forms.TextBox();
			this.lblFone = new System.Windows.Forms.Label();
			this.edtFone1 = new System.Windows.Forms.TextBox();
			this.edtFone2 = new System.Windows.Forms.TextBox();
			this.lblEmail = new System.Windows.Forms.Label();
			this.edtEmail = new System.Windows.Forms.TextBox();
			this.edtFAX = new System.Windows.Forms.TextBox();
			this.lblFAX = new System.Windows.Forms.Label();
			this.edtServidor = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.edtIP = new System.Windows.Forms.TextBox();
			this.pnlEdicao.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(593, 265);
			this.btnCancela.TabIndex = 20;
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(483, 265);
			this.btnConfirma.TabIndex = 19;
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// edtCodigo
			// 
			this.edtCodigo.Location = new System.Drawing.Point(95, 10);
			this.edtCodigo.Size = new System.Drawing.Size(27, 20);
			// 
			// edtDescricao
			// 
			this.edtDescricao.Location = new System.Drawing.Point(95, 40);
			this.edtDescricao.MaxLength = 50;
			this.edtDescricao.Size = new System.Drawing.Size(356, 20);
			// 
			// lblCodigo
			// 
			this.lblCodigo.Size = new System.Drawing.Size(80, 20);
			// 
			// lblDescricao
			// 
			this.lblDescricao.Size = new System.Drawing.Size(80, 20);
			this.lblDescricao.Text = "*Nome";
			// 
			// pnlEdicao
			// 
			this.pnlEdicao.Controls.Add(this.edtIP);
			this.pnlEdicao.Controls.Add(this.label2);
			this.pnlEdicao.Controls.Add(this.edtServidor);
			this.pnlEdicao.Controls.Add(this.label1);
			this.pnlEdicao.Controls.Add(this.edtFAX);
			this.pnlEdicao.Controls.Add(this.lblFAX);
			this.pnlEdicao.Controls.Add(this.edtEmail);
			this.pnlEdicao.Controls.Add(this.lblEmail);
			this.pnlEdicao.Controls.Add(this.edtFone2);
			this.pnlEdicao.Controls.Add(this.edtFone1);
			this.pnlEdicao.Controls.Add(this.lblFone);
			this.pnlEdicao.Controls.Add(this.edtCEP);
			this.pnlEdicao.Controls.Add(this.lblCEP);
			this.pnlEdicao.Controls.Add(this.cbxEstados);
			this.pnlEdicao.Controls.Add(this.lblEstado);
			this.pnlEdicao.Controls.Add(this.edtCidade);
			this.pnlEdicao.Controls.Add(this.lblCidade);
			this.pnlEdicao.Controls.Add(this.edtBairro);
			this.pnlEdicao.Controls.Add(this.lblBairro);
			this.pnlEdicao.Controls.Add(this.edtComplemento);
			this.pnlEdicao.Controls.Add(this.lblComplemento);
			this.pnlEdicao.Controls.Add(this.edtNumero);
			this.pnlEdicao.Controls.Add(this.lblNumero);
			this.pnlEdicao.Controls.Add(this.edtLogradouro);
			this.pnlEdicao.Controls.Add(this.lblLogradouro);
			this.pnlEdicao.Controls.Add(this.edtInsMun);
			this.pnlEdicao.Controls.Add(this.lblInsMun);
			this.pnlEdicao.Controls.Add(this.edtInsEst);
			this.pnlEdicao.Controls.Add(this.lblInsEst);
			this.pnlEdicao.Controls.Add(this.edtCNPJ);
			this.pnlEdicao.Controls.Add(this.lblCNPJ);
			this.pnlEdicao.Size = new System.Drawing.Size(700, 300);
			this.pnlEdicao.Controls.SetChildIndex(this.lblCNPJ, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtCNPJ, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.btnConfirma, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.btnCancela, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblCodigo, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblDescricao, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtCodigo, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtDescricao, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblInsEst, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtInsEst, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblInsMun, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtInsMun, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblLogradouro, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtLogradouro, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblNumero, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtNumero, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblComplemento, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtComplemento, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblBairro, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtBairro, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblCidade, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtCidade, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblEstado, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.cbxEstados, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblCEP, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtCEP, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblFone, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtFone1, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtFone2, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblEmail, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtEmail, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.lblFAX, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtFAX, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.label1, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtServidor, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.label2, 0);
			this.pnlEdicao.Controls.SetChildIndex(this.edtIP, 0);
			// 
			// btnFecha
			// 
			this.btnFecha.Location = new System.Drawing.Point(600, 130);
			// 
			// btnAltera
			// 
			this.btnAltera.Location = new System.Drawing.Point(600, 100);
			this.btnAltera.Click += new System.EventHandler(this.BtnAlteraClick);
			// 
			// btnExclui
			// 
			this.btnExclui.Location = new System.Drawing.Point(600, 70);
			this.btnExclui.Click += new System.EventHandler(this.BtnExcluiClick);
			// 
			// btnInclui
			// 
			this.btnInclui.Location = new System.Drawing.Point(600, 40);
			// 
			// lblCNPJ
			// 
			this.lblCNPJ.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCNPJ.Location = new System.Drawing.Point(460, 40);
			this.lblCNPJ.Name = "lblCNPJ";
			this.lblCNPJ.Size = new System.Drawing.Size(50, 20);
			this.lblCNPJ.TabIndex = 22;
			this.lblCNPJ.Text = "CNPJ";
			this.lblCNPJ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtCNPJ
			// 
			this.edtCNPJ.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtCNPJ.Location = new System.Drawing.Point(515, 40);
			this.edtCNPJ.MaxLength = 18;
			this.edtCNPJ.Name = "edtCNPJ";
			this.edtCNPJ.Size = new System.Drawing.Size(132, 20);
			this.edtCNPJ.TabIndex = 4;
			this.edtCNPJ.Enter += new System.EventHandler(this.EdtCNPJEnter);
			this.edtCNPJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EdtNUMERICOKeyPress);
			this.edtCNPJ.Leave += new System.EventHandler(this.EdtCNPJLeave);
			// 
			// lblInsEst
			// 
			this.lblInsEst.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblInsEst.Location = new System.Drawing.Point(10, 70);
			this.lblInsEst.Name = "lblInsEst";
			this.lblInsEst.Size = new System.Drawing.Size(80, 20);
			this.lblInsEst.TabIndex = 24;
			this.lblInsEst.Text = "Insc. Estadual";
			this.lblInsEst.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtInsEst
			// 
			this.edtInsEst.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtInsEst.Location = new System.Drawing.Point(95, 70);
			this.edtInsEst.MaxLength = 14;
			this.edtInsEst.Name = "edtInsEst";
			this.edtInsEst.Size = new System.Drawing.Size(104, 20);
			this.edtInsEst.TabIndex = 5;
			// 
			// lblInsMun
			// 
			this.lblInsMun.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblInsMun.Location = new System.Drawing.Point(200, 70);
			this.lblInsMun.Name = "lblInsMun";
			this.lblInsMun.Size = new System.Drawing.Size(80, 20);
			this.lblInsMun.TabIndex = 26;
			this.lblInsMun.Text = "Insc. Municipal";
			this.lblInsMun.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtInsMun
			// 
			this.edtInsMun.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtInsMun.Location = new System.Drawing.Point(290, 70);
			this.edtInsMun.MaxLength = 15;
			this.edtInsMun.Name = "edtInsMun";
			this.edtInsMun.Size = new System.Drawing.Size(111, 20);
			this.edtInsMun.TabIndex = 6;
			// 
			// lblLogradouro
			// 
			this.lblLogradouro.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblLogradouro.Location = new System.Drawing.Point(10, 100);
			this.lblLogradouro.Name = "lblLogradouro";
			this.lblLogradouro.Size = new System.Drawing.Size(80, 20);
			this.lblLogradouro.TabIndex = 28;
			this.lblLogradouro.Text = "Logradouro";
			this.lblLogradouro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtLogradouro
			// 
			this.edtLogradouro.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtLogradouro.Location = new System.Drawing.Point(95, 100);
			this.edtLogradouro.MaxLength = 50;
			this.edtLogradouro.Name = "edtLogradouro";
			this.edtLogradouro.Size = new System.Drawing.Size(356, 20);
			this.edtLogradouro.TabIndex = 7;
			// 
			// lblNumero
			// 
			this.lblNumero.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblNumero.Location = new System.Drawing.Point(460, 100);
			this.lblNumero.Name = "lblNumero";
			this.lblNumero.Size = new System.Drawing.Size(50, 20);
			this.lblNumero.TabIndex = 30;
			this.lblNumero.Text = "Número";
			this.lblNumero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtNumero
			// 
			this.edtNumero.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtNumero.Location = new System.Drawing.Point(515, 100);
			this.edtNumero.MaxLength = 6;
			this.edtNumero.Name = "edtNumero";
			this.edtNumero.Size = new System.Drawing.Size(48, 20);
			this.edtNumero.TabIndex = 8;
			// 
			// lblComplemento
			// 
			this.lblComplemento.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblComplemento.Location = new System.Drawing.Point(10, 130);
			this.lblComplemento.Name = "lblComplemento";
			this.lblComplemento.Size = new System.Drawing.Size(80, 20);
			this.lblComplemento.TabIndex = 32;
			this.lblComplemento.Text = "Complemento";
			this.lblComplemento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtComplemento
			// 
			this.edtComplemento.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtComplemento.Location = new System.Drawing.Point(95, 130);
			this.edtComplemento.MaxLength = 20;
			this.edtComplemento.Name = "edtComplemento";
			this.edtComplemento.Size = new System.Drawing.Size(146, 20);
			this.edtComplemento.TabIndex = 9;
			// 
			// lblBairro
			// 
			this.lblBairro.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblBairro.Location = new System.Drawing.Point(260, 130);
			this.lblBairro.Name = "lblBairro";
			this.lblBairro.Size = new System.Drawing.Size(60, 20);
			this.lblBairro.TabIndex = 34;
			this.lblBairro.Text = "Bairro";
			this.lblBairro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtBairro
			// 
			this.edtBairro.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtBairro.Location = new System.Drawing.Point(330, 130);
			this.edtBairro.MaxLength = 50;
			this.edtBairro.Name = "edtBairro";
			this.edtBairro.Size = new System.Drawing.Size(356, 20);
			this.edtBairro.TabIndex = 10;
			// 
			// lblCidade
			// 
			this.lblCidade.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCidade.Location = new System.Drawing.Point(10, 160);
			this.lblCidade.Name = "lblCidade";
			this.lblCidade.Size = new System.Drawing.Size(80, 20);
			this.lblCidade.TabIndex = 36;
			this.lblCidade.Text = "Cidade";
			this.lblCidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtCidade
			// 
			this.edtCidade.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtCidade.Location = new System.Drawing.Point(95, 160);
			this.edtCidade.MaxLength = 50;
			this.edtCidade.Name = "edtCidade";
			this.edtCidade.Size = new System.Drawing.Size(356, 20);
			this.edtCidade.TabIndex = 11;
			// 
			// lblEstado
			// 
			this.lblEstado.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblEstado.Location = new System.Drawing.Point(460, 160);
			this.lblEstado.Name = "lblEstado";
			this.lblEstado.Size = new System.Drawing.Size(50, 20);
			this.lblEstado.TabIndex = 38;
			this.lblEstado.Text = "Estado";
			this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxEstados
			// 
			this.cbxEstados.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbxEstados.FormattingEnabled = true;
			this.cbxEstados.Location = new System.Drawing.Point(515, 160);
			this.cbxEstados.Name = "cbxEstados";
			this.cbxEstados.Size = new System.Drawing.Size(50, 22);
			this.cbxEstados.TabIndex = 12;
			// 
			// lblCEP
			// 
			this.lblCEP.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCEP.Location = new System.Drawing.Point(580, 160);
			this.lblCEP.Name = "lblCEP";
			this.lblCEP.Size = new System.Drawing.Size(30, 20);
			this.lblCEP.TabIndex = 40;
			this.lblCEP.Text = "CEP";
			this.lblCEP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtCEP
			// 
			this.edtCEP.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtCEP.Location = new System.Drawing.Point(610, 160);
			this.edtCEP.MaxLength = 10;
			this.edtCEP.Name = "edtCEP";
			this.edtCEP.Size = new System.Drawing.Size(76, 20);
			this.edtCEP.TabIndex = 13;
			this.edtCEP.Enter += new System.EventHandler(this.EdtCEPEnter);
			this.edtCEP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EdtNUMERICOKeyPress);
			this.edtCEP.Leave += new System.EventHandler(this.EdtCEPLeave);
			// 
			// lblFone
			// 
			this.lblFone.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblFone.Location = new System.Drawing.Point(10, 190);
			this.lblFone.Name = "lblFone";
			this.lblFone.Size = new System.Drawing.Size(80, 20);
			this.lblFone.TabIndex = 42;
			this.lblFone.Text = "Fone";
			this.lblFone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtFone1
			// 
			this.edtFone1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtFone1.Location = new System.Drawing.Point(95, 190);
			this.edtFone1.MaxLength = 13;
			this.edtFone1.Name = "edtFone1";
			this.edtFone1.Size = new System.Drawing.Size(97, 20);
			this.edtFone1.TabIndex = 14;
			this.edtFone1.Enter += new System.EventHandler(this.EdtFone1Enter);
			this.edtFone1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EdtNUMERICOKeyPress);
			this.edtFone1.Leave += new System.EventHandler(this.EdtFone1Leave);
			// 
			// edtFone2
			// 
			this.edtFone2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtFone2.Location = new System.Drawing.Point(210, 190);
			this.edtFone2.MaxLength = 13;
			this.edtFone2.Name = "edtFone2";
			this.edtFone2.Size = new System.Drawing.Size(97, 20);
			this.edtFone2.TabIndex = 15;
			this.edtFone2.Enter += new System.EventHandler(this.EdtFone2Enter);
			this.edtFone2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EdtNUMERICOKeyPress);
			this.edtFone2.Leave += new System.EventHandler(this.EdtFone2Leave);
			// 
			// lblEmail
			// 
			this.lblEmail.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblEmail.Location = new System.Drawing.Point(10, 220);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(80, 20);
			this.lblEmail.TabIndex = 45;
			this.lblEmail.Text = "email";
			this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtEmail
			// 
			this.edtEmail.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtEmail.Location = new System.Drawing.Point(95, 220);
			this.edtEmail.MaxLength = 50;
			this.edtEmail.Name = "edtEmail";
			this.edtEmail.Size = new System.Drawing.Size(356, 20);
			this.edtEmail.TabIndex = 17;
			// 
			// edtFAX
			// 
			this.edtFAX.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtFAX.Location = new System.Drawing.Point(390, 190);
			this.edtFAX.MaxLength = 13;
			this.edtFAX.Name = "edtFAX";
			this.edtFAX.Size = new System.Drawing.Size(97, 20);
			this.edtFAX.TabIndex = 16;
			this.edtFAX.Enter += new System.EventHandler(this.EdtFAXEnter);
			this.edtFAX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EdtNUMERICOKeyPress);
			this.edtFAX.Leave += new System.EventHandler(this.EdtFAXLeave);
			// 
			// lblFAX
			// 
			this.lblFAX.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblFAX.Location = new System.Drawing.Point(320, 190);
			this.lblFAX.Name = "lblFAX";
			this.lblFAX.Size = new System.Drawing.Size(60, 20);
			this.lblFAX.TabIndex = 73;
			this.lblFAX.Text = "FAX";
			this.lblFAX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtServidor
			// 
			this.edtServidor.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtServidor.Location = new System.Drawing.Point(95, 246);
			this.edtServidor.MaxLength = 50;
			this.edtServidor.Name = "edtServidor";
			this.edtServidor.Size = new System.Drawing.Size(356, 20);
			this.edtServidor.TabIndex = 18;
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(10, 246);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 20);
			this.label1.TabIndex = 75;
			this.label1.Text = "Servidor";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label2.Location = new System.Drawing.Point(10, 273);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 20);
			this.label2.TabIndex = 76;
			this.label2.Text = "IP Servidor";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtIP
			// 
			this.edtIP.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtIP.Location = new System.Drawing.Point(95, 274);
			this.edtIP.MaxLength = 50;
			this.edtIP.Name = "edtIP";
			this.edtIP.Size = new System.Drawing.Size(356, 20);
			this.edtIP.TabIndex = 77;
			// 
			// frmCadFiliais
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.ClientSize = new System.Drawing.Size(714, 504);
			this.Name = "frmCadFiliais";
			this.Text = "CPD - Cadastro de Filiais";
			this.Load += new System.EventHandler(this.FrmCadFiliaisLoad);
			this.pnlEdicao.ResumeLayout(false);
			this.pnlEdicao.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.Label lblFAX;
		private System.Windows.Forms.TextBox edtFAX;
		private System.Windows.Forms.ComboBox cbxEstados;
		private System.Windows.Forms.TextBox edtFone1;
		private System.Windows.Forms.TextBox edtNumero;
		private System.Windows.Forms.TextBox edtLogradouro;
		private System.Windows.Forms.TextBox edtInsMun;
		private System.Windows.Forms.TextBox edtInsEst;
		private System.Windows.Forms.Label lblCNPJ;
		private System.Windows.Forms.TextBox edtCNPJ;
		private System.Windows.Forms.Label lblInsEst;
		private System.Windows.Forms.Label lblInsMun;
		private System.Windows.Forms.Label lblLogradouro;
		private System.Windows.Forms.Label lblNumero;
		private System.Windows.Forms.Label lblComplemento;
		private System.Windows.Forms.TextBox edtComplemento;
		private System.Windows.Forms.Label lblBairro;
		private System.Windows.Forms.TextBox edtBairro;
		private System.Windows.Forms.Label lblCidade;
		private System.Windows.Forms.TextBox edtCidade;
		private System.Windows.Forms.Label lblEstado;
		private System.Windows.Forms.Label lblCEP;
		private System.Windows.Forms.TextBox edtCEP;
		private System.Windows.Forms.Label lblFone;
		private System.Windows.Forms.TextBox edtFone2;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.TextBox edtEmail;
		private System.Windows.Forms.TextBox edtServidor;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox edtIP;
		private System.Windows.Forms.Label label2;
	}
}
