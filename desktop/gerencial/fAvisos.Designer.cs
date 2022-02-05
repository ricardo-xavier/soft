/*
 * Criado por SharpDevelop.
 * Usuário: Ricardo
 * Data: 19/11/2010
 * Hora: 20:17
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace gerencial
{
	partial class fAvisos
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
			this.edtDiasAgenda = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.gbxAgenda = new System.Windows.Forms.GroupBox();
			this.edtDiaAgenda = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.cbxDiaAgenda = new System.Windows.Forms.ComboBox();
			this.cbxFrequenciaAgenda = new System.Windows.Forms.ComboBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.btnCancela = new System.Windows.Forms.Button();
			this.btnConfirma = new System.Windows.Forms.Button();
			this.gbxOrcamento = new System.Windows.Forms.GroupBox();
			this.edtDiaOrcamento = new System.Windows.Forms.TextBox();
			this.label24 = new System.Windows.Forms.Label();
			this.cbxDiaOrcamento = new System.Windows.Forms.ComboBox();
			this.cbxFrequenciaOrcamento = new System.Windows.Forms.ComboBox();
			this.label23 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.edtDiasOrcamento = new System.Windows.Forms.TextBox();
			this.gbxSmtp = new System.Windows.Forms.GroupBox();
			this.lblRemetente = new System.Windows.Forms.Label();
			this.edtRemetente = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.edtSenha = new System.Windows.Forms.TextBox();
			this.lblUsuario = new System.Windows.Forms.Label();
			this.edtUsuario = new System.Windows.Forms.TextBox();
			this.edtPorta = new System.Windows.Forms.TextBox();
			this.lblPorta = new System.Windows.Forms.Label();
			this.lblServidor = new System.Windows.Forms.Label();
			this.edtServidor = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.edtDiaFaturamento = new System.Windows.Forms.TextBox();
			this.cbxDiaFaturamento = new System.Windows.Forms.ComboBox();
			this.label18 = new System.Windows.Forms.Label();
			this.cbxFrequenciaFaturamento = new System.Windows.Forms.ComboBox();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.edtDiasFaturamento = new System.Windows.Forms.TextBox();
			this.edtDiaMontagem = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.cbxDiaMontagem = new System.Windows.Forms.ComboBox();
			this.cbxFrequenciaMontagem = new System.Windows.Forms.ComboBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.edtDiasMontagem = new System.Windows.Forms.TextBox();
			this.edtDiaEntrega = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cbxDiaEntrega = new System.Windows.Forms.ComboBox();
			this.cbxFrequenciaEntrega = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.edtDiasEntrega = new System.Windows.Forms.TextBox();
			this.edtDiaConfirmacaoEntrega = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cbxDiaConfirmacaoEntrega = new System.Windows.Forms.ComboBox();
			this.cbxFrequenciaConfirmacaoEntrega = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.edtDiasConfirmacaoEntrega = new System.Windows.Forms.TextBox();
			this.gbxAgenda.SuspendLayout();
			this.gbxOrcamento.SuspendLayout();
			this.gbxSmtp.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// edtDiasAgenda
			// 
			this.edtDiasAgenda.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtDiasAgenda.Location = new System.Drawing.Point(185, 15);
			this.edtDiasAgenda.MaxLength = 50;
			this.edtDiasAgenda.Name = "edtDiasAgenda";
			this.edtDiasAgenda.Size = new System.Drawing.Size(27, 20);
			this.edtDiasAgenda.TabIndex = 129;
			this.edtDiasAgenda.Text = "0";
			// 
			// label11
			// 
			this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label11.Location = new System.Drawing.Point(6, 15);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(173, 20);
			this.label11.TabIndex = 130;
			this.label11.Text = "Agendamentos abertos a mais de:";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// gbxAgenda
			// 
			this.gbxAgenda.Controls.Add(this.edtDiaAgenda);
			this.gbxAgenda.Controls.Add(this.label14);
			this.gbxAgenda.Controls.Add(this.cbxDiaAgenda);
			this.gbxAgenda.Controls.Add(this.cbxFrequenciaAgenda);
			this.gbxAgenda.Controls.Add(this.label13);
			this.gbxAgenda.Controls.Add(this.label12);
			this.gbxAgenda.Controls.Add(this.label11);
			this.gbxAgenda.Controls.Add(this.edtDiasAgenda);
			this.gbxAgenda.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.gbxAgenda.Location = new System.Drawing.Point(12, 109);
			this.gbxAgenda.Name = "gbxAgenda";
			this.gbxAgenda.Size = new System.Drawing.Size(421, 80);
			this.gbxAgenda.TabIndex = 1;
			this.gbxAgenda.TabStop = false;
			this.gbxAgenda.Text = "Agenda";
			// 
			// edtDiaAgenda
			// 
			this.edtDiaAgenda.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtDiaAgenda.Location = new System.Drawing.Point(345, 45);
			this.edtDiaAgenda.MaxLength = 50;
			this.edtDiaAgenda.Name = "edtDiaAgenda";
			this.edtDiaAgenda.Size = new System.Drawing.Size(27, 20);
			this.edtDiaAgenda.TabIndex = 135;
			this.edtDiaAgenda.Text = "0";
			// 
			// label14
			// 
			this.label14.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label14.Location = new System.Drawing.Point(254, 45);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(85, 20);
			this.label14.TabIndex = 134;
			this.label14.Text = "Dia da semana";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxDiaAgenda
			// 
			this.cbxDiaAgenda.FormattingEnabled = true;
			this.cbxDiaAgenda.Location = new System.Drawing.Point(345, 45);
			this.cbxDiaAgenda.Name = "cbxDiaAgenda";
			this.cbxDiaAgenda.Size = new System.Drawing.Size(70, 21);
			this.cbxDiaAgenda.TabIndex = 133;
			this.cbxDiaAgenda.Text = "Semanal";
			// 
			// cbxFrequenciaAgenda
			// 
			this.cbxFrequenciaAgenda.FormattingEnabled = true;
			this.cbxFrequenciaAgenda.Location = new System.Drawing.Point(185, 45);
			this.cbxFrequenciaAgenda.Name = "cbxFrequenciaAgenda";
			this.cbxFrequenciaAgenda.Size = new System.Drawing.Size(63, 21);
			this.cbxFrequenciaAgenda.TabIndex = 132;
			this.cbxFrequenciaAgenda.Text = "Semanal";
			this.cbxFrequenciaAgenda.SelectedIndexChanged += new System.EventHandler(this.CbxFrequenciaAgendaSelectedIndexChanged);
			// 
			// label13
			// 
			this.label13.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label13.Location = new System.Drawing.Point(6, 45);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(173, 20);
			this.label13.TabIndex = 132;
			this.label13.Text = "Frequencia";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label12
			// 
			this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label12.Location = new System.Drawing.Point(218, 15);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(30, 20);
			this.label12.TabIndex = 131;
			this.label12.Text = "dias";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnCancela
			// 
			this.btnCancela.BackColor = System.Drawing.SystemColors.Control;
			this.btnCancela.Location = new System.Drawing.Point(791, 295);
			this.btnCancela.Name = "btnCancela";
			this.btnCancela.Size = new System.Drawing.Size(100, 25);
			this.btnCancela.TabIndex = 4;
			this.btnCancela.Text = "C&ancela";
			this.btnCancela.UseVisualStyleBackColor = false;
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(685, 295);
			this.btnConfirma.Name = "btnConfirma";
			this.btnConfirma.Size = new System.Drawing.Size(100, 25);
			this.btnConfirma.TabIndex = 3;
			this.btnConfirma.Text = "&Confirma";
			this.btnConfirma.UseVisualStyleBackColor = true;
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// gbxOrcamento
			// 
			this.gbxOrcamento.Controls.Add(this.edtDiaOrcamento);
			this.gbxOrcamento.Controls.Add(this.label24);
			this.gbxOrcamento.Controls.Add(this.cbxDiaOrcamento);
			this.gbxOrcamento.Controls.Add(this.cbxFrequenciaOrcamento);
			this.gbxOrcamento.Controls.Add(this.label23);
			this.gbxOrcamento.Controls.Add(this.label22);
			this.gbxOrcamento.Controls.Add(this.label21);
			this.gbxOrcamento.Controls.Add(this.edtDiasOrcamento);
			this.gbxOrcamento.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.gbxOrcamento.Location = new System.Drawing.Point(12, 195);
			this.gbxOrcamento.Name = "gbxOrcamento";
			this.gbxOrcamento.Size = new System.Drawing.Size(421, 81);
			this.gbxOrcamento.TabIndex = 2;
			this.gbxOrcamento.TabStop = false;
			this.gbxOrcamento.Text = "Orçamentos";
			// 
			// edtDiaOrcamento
			// 
			this.edtDiaOrcamento.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtDiaOrcamento.Location = new System.Drawing.Point(345, 45);
			this.edtDiaOrcamento.MaxLength = 50;
			this.edtDiaOrcamento.Name = "edtDiaOrcamento";
			this.edtDiaOrcamento.Size = new System.Drawing.Size(27, 20);
			this.edtDiaOrcamento.TabIndex = 135;
			this.edtDiaOrcamento.Text = "0";
			// 
			// label24
			// 
			this.label24.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label24.Location = new System.Drawing.Point(254, 45);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(85, 20);
			this.label24.TabIndex = 134;
			this.label24.Text = "Dia da semana";
			this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxDiaOrcamento
			// 
			this.cbxDiaOrcamento.FormattingEnabled = true;
			this.cbxDiaOrcamento.Location = new System.Drawing.Point(345, 45);
			this.cbxDiaOrcamento.Name = "cbxDiaOrcamento";
			this.cbxDiaOrcamento.Size = new System.Drawing.Size(70, 21);
			this.cbxDiaOrcamento.TabIndex = 133;
			this.cbxDiaOrcamento.Text = "Semanal";
			// 
			// cbxFrequenciaOrcamento
			// 
			this.cbxFrequenciaOrcamento.FormattingEnabled = true;
			this.cbxFrequenciaOrcamento.Location = new System.Drawing.Point(185, 45);
			this.cbxFrequenciaOrcamento.Name = "cbxFrequenciaOrcamento";
			this.cbxFrequenciaOrcamento.Size = new System.Drawing.Size(63, 21);
			this.cbxFrequenciaOrcamento.TabIndex = 132;
			this.cbxFrequenciaOrcamento.Text = "Semanal";
			this.cbxFrequenciaOrcamento.SelectedIndexChanged += new System.EventHandler(this.CbxFrequenciaOrcamentoSelectedIndexChanged);
			// 
			// label23
			// 
			this.label23.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label23.Location = new System.Drawing.Point(6, 45);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(173, 20);
			this.label23.TabIndex = 132;
			this.label23.Text = "Frequencia";
			this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label22
			// 
			this.label22.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label22.Location = new System.Drawing.Point(218, 15);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(30, 20);
			this.label22.TabIndex = 131;
			this.label22.Text = "dias";
			this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label21
			// 
			this.label21.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label21.Location = new System.Drawing.Point(6, 15);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(173, 20);
			this.label21.TabIndex = 130;
			this.label21.Text = "Orçamentos abertos a mais de:";
			this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtDiasOrcamento
			// 
			this.edtDiasOrcamento.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtDiasOrcamento.Location = new System.Drawing.Point(185, 15);
			this.edtDiasOrcamento.MaxLength = 50;
			this.edtDiasOrcamento.Name = "edtDiasOrcamento";
			this.edtDiasOrcamento.Size = new System.Drawing.Size(27, 20);
			this.edtDiasOrcamento.TabIndex = 129;
			this.edtDiasOrcamento.Text = "0";
			// 
			// gbxSmtp
			// 
			this.gbxSmtp.Controls.Add(this.lblRemetente);
			this.gbxSmtp.Controls.Add(this.edtRemetente);
			this.gbxSmtp.Controls.Add(this.label5);
			this.gbxSmtp.Controls.Add(this.edtSenha);
			this.gbxSmtp.Controls.Add(this.lblUsuario);
			this.gbxSmtp.Controls.Add(this.edtUsuario);
			this.gbxSmtp.Controls.Add(this.edtPorta);
			this.gbxSmtp.Controls.Add(this.lblPorta);
			this.gbxSmtp.Controls.Add(this.lblServidor);
			this.gbxSmtp.Controls.Add(this.edtServidor);
			this.gbxSmtp.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.gbxSmtp.Location = new System.Drawing.Point(12, 12);
			this.gbxSmtp.Name = "gbxSmtp";
			this.gbxSmtp.Size = new System.Drawing.Size(421, 91);
			this.gbxSmtp.TabIndex = 0;
			this.gbxSmtp.TabStop = false;
			this.gbxSmtp.Text = "Dados para envio de email(SMTP)";
			// 
			// lblRemetente
			// 
			this.lblRemetente.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblRemetente.Location = new System.Drawing.Point(4, 67);
			this.lblRemetente.Name = "lblRemetente";
			this.lblRemetente.Size = new System.Drawing.Size(59, 20);
			this.lblRemetente.TabIndex = 141;
			this.lblRemetente.Text = "Remetente";
			this.lblRemetente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtRemetente
			// 
			this.edtRemetente.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtRemetente.Location = new System.Drawing.Point(69, 68);
			this.edtRemetente.MaxLength = 100;
			this.edtRemetente.Name = "edtRemetente";
			this.edtRemetente.Size = new System.Drawing.Size(246, 20);
			this.edtRemetente.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label5.Location = new System.Drawing.Point(252, 41);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(59, 20);
			this.label5.TabIndex = 139;
			this.label5.Text = "Senha";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtSenha
			// 
			this.edtSenha.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtSenha.Location = new System.Drawing.Point(317, 42);
			this.edtSenha.MaxLength = 100;
			this.edtSenha.Name = "edtSenha";
			this.edtSenha.PasswordChar = '*';
			this.edtSenha.Size = new System.Drawing.Size(83, 20);
			this.edtSenha.TabIndex = 3;
			// 
			// lblUsuario
			// 
			this.lblUsuario.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblUsuario.Location = new System.Drawing.Point(6, 41);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(59, 20);
			this.lblUsuario.TabIndex = 137;
			this.lblUsuario.Text = "Usuário";
			this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtUsuario
			// 
			this.edtUsuario.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtUsuario.Location = new System.Drawing.Point(71, 42);
			this.edtUsuario.MaxLength = 20;
			this.edtUsuario.Name = "edtUsuario";
			this.edtUsuario.Size = new System.Drawing.Size(146, 20);
			this.edtUsuario.TabIndex = 2;
			// 
			// edtPorta
			// 
			this.edtPorta.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtPorta.Location = new System.Drawing.Point(373, 16);
			this.edtPorta.MaxLength = 50;
			this.edtPorta.Name = "edtPorta";
			this.edtPorta.Size = new System.Drawing.Size(27, 20);
			this.edtPorta.TabIndex = 1;
			this.edtPorta.Text = "25";
			// 
			// lblPorta
			// 
			this.lblPorta.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblPorta.Location = new System.Drawing.Point(307, 15);
			this.lblPorta.Name = "lblPorta";
			this.lblPorta.Size = new System.Drawing.Size(60, 20);
			this.lblPorta.TabIndex = 131;
			this.lblPorta.Text = "Porta";
			this.lblPorta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblServidor
			// 
			this.lblServidor.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblServidor.Location = new System.Drawing.Point(6, 15);
			this.lblServidor.Name = "lblServidor";
			this.lblServidor.Size = new System.Drawing.Size(59, 20);
			this.lblServidor.TabIndex = 130;
			this.lblServidor.Text = "Servidor";
			this.lblServidor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtServidor
			// 
			this.edtServidor.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtServidor.Location = new System.Drawing.Point(71, 16);
			this.edtServidor.MaxLength = 100;
			this.edtServidor.Name = "edtServidor";
			this.edtServidor.Size = new System.Drawing.Size(246, 20);
			this.edtServidor.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.edtDiaFaturamento);
			this.groupBox1.Controls.Add(this.cbxDiaFaturamento);
			this.groupBox1.Controls.Add(this.label18);
			this.groupBox1.Controls.Add(this.cbxFrequenciaFaturamento);
			this.groupBox1.Controls.Add(this.label19);
			this.groupBox1.Controls.Add(this.label20);
			this.groupBox1.Controls.Add(this.label25);
			this.groupBox1.Controls.Add(this.edtDiasFaturamento);
			this.groupBox1.Controls.Add(this.edtDiaMontagem);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.cbxDiaMontagem);
			this.groupBox1.Controls.Add(this.cbxFrequenciaMontagem);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.label16);
			this.groupBox1.Controls.Add(this.label17);
			this.groupBox1.Controls.Add(this.edtDiasMontagem);
			this.groupBox1.Controls.Add(this.edtDiaEntrega);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.cbxDiaEntrega);
			this.groupBox1.Controls.Add(this.cbxFrequenciaEntrega);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.edtDiasEntrega);
			this.groupBox1.Controls.Add(this.edtDiaConfirmacaoEntrega);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.cbxDiaConfirmacaoEntrega);
			this.groupBox1.Controls.Add(this.cbxFrequenciaConfirmacaoEntrega);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.edtDiasConfirmacaoEntrega);
			this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.groupBox1.Location = new System.Drawing.Point(439, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(455, 264);
			this.groupBox1.TabIndex = 136;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Pedidos";
			// 
			// edtDiaFaturamento
			// 
			this.edtDiaFaturamento.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtDiaFaturamento.Location = new System.Drawing.Point(369, 217);
			this.edtDiaFaturamento.MaxLength = 50;
			this.edtDiaFaturamento.Name = "edtDiaFaturamento";
			this.edtDiaFaturamento.Size = new System.Drawing.Size(27, 20);
			this.edtDiaFaturamento.TabIndex = 160;
			this.edtDiaFaturamento.Text = "0";
			// 
			// cbxDiaFaturamento
			// 
			this.cbxDiaFaturamento.FormattingEnabled = true;
			this.cbxDiaFaturamento.Location = new System.Drawing.Point(369, 217);
			this.cbxDiaFaturamento.Name = "cbxDiaFaturamento";
			this.cbxDiaFaturamento.Size = new System.Drawing.Size(70, 21);
			this.cbxDiaFaturamento.TabIndex = 159;
			this.cbxDiaFaturamento.Text = "Semanal";
			// 
			// label18
			// 
			this.label18.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label18.Location = new System.Drawing.Point(278, 218);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(85, 20);
			this.label18.TabIndex = 158;
			this.label18.Text = "Dia da semana";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxFrequenciaFaturamento
			// 
			this.cbxFrequenciaFaturamento.FormattingEnabled = true;
			this.cbxFrequenciaFaturamento.Location = new System.Drawing.Point(209, 218);
			this.cbxFrequenciaFaturamento.Name = "cbxFrequenciaFaturamento";
			this.cbxFrequenciaFaturamento.Size = new System.Drawing.Size(63, 21);
			this.cbxFrequenciaFaturamento.TabIndex = 156;
			this.cbxFrequenciaFaturamento.Text = "Semanal";
			this.cbxFrequenciaFaturamento.SelectedIndexChanged += new System.EventHandler(this.CbxFrequenciaFaturamentoSelectedIndexChanged);
			// 
			// label19
			// 
			this.label19.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label19.Location = new System.Drawing.Point(30, 218);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(173, 20);
			this.label19.TabIndex = 155;
			this.label19.Text = "Frequencia";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label20
			// 
			this.label20.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label20.Location = new System.Drawing.Point(242, 188);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(30, 20);
			this.label20.TabIndex = 154;
			this.label20.Text = "dias";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label25
			// 
			this.label25.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label25.Location = new System.Drawing.Point(6, 188);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(197, 20);
			this.label25.TabIndex = 153;
			this.label25.Text = "Sem faturamento a mais de:";
			this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtDiasFaturamento
			// 
			this.edtDiasFaturamento.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtDiasFaturamento.Location = new System.Drawing.Point(209, 188);
			this.edtDiasFaturamento.MaxLength = 50;
			this.edtDiasFaturamento.Name = "edtDiasFaturamento";
			this.edtDiasFaturamento.Size = new System.Drawing.Size(27, 20);
			this.edtDiasFaturamento.TabIndex = 152;
			this.edtDiasFaturamento.Text = "0";
			// 
			// edtDiaMontagem
			// 
			this.edtDiaMontagem.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtDiaMontagem.Location = new System.Drawing.Point(369, 161);
			this.edtDiaMontagem.MaxLength = 50;
			this.edtDiaMontagem.Name = "edtDiaMontagem";
			this.edtDiaMontagem.Size = new System.Drawing.Size(27, 20);
			this.edtDiaMontagem.TabIndex = 151;
			this.edtDiaMontagem.Text = "0";
			// 
			// label10
			// 
			this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label10.Location = new System.Drawing.Point(278, 161);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(85, 20);
			this.label10.TabIndex = 150;
			this.label10.Text = "Dia da semana";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxDiaMontagem
			// 
			this.cbxDiaMontagem.FormattingEnabled = true;
			this.cbxDiaMontagem.Location = new System.Drawing.Point(369, 161);
			this.cbxDiaMontagem.Name = "cbxDiaMontagem";
			this.cbxDiaMontagem.Size = new System.Drawing.Size(70, 21);
			this.cbxDiaMontagem.TabIndex = 149;
			this.cbxDiaMontagem.Text = "Semanal";
			// 
			// cbxFrequenciaMontagem
			// 
			this.cbxFrequenciaMontagem.FormattingEnabled = true;
			this.cbxFrequenciaMontagem.Location = new System.Drawing.Point(209, 161);
			this.cbxFrequenciaMontagem.Name = "cbxFrequenciaMontagem";
			this.cbxFrequenciaMontagem.Size = new System.Drawing.Size(63, 21);
			this.cbxFrequenciaMontagem.TabIndex = 148;
			this.cbxFrequenciaMontagem.Text = "Semanal";
			this.cbxFrequenciaMontagem.SelectedIndexChanged += new System.EventHandler(this.CbxFrequenciaMontagemSelectedIndexChanged);
			// 
			// label15
			// 
			this.label15.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label15.Location = new System.Drawing.Point(30, 161);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(173, 20);
			this.label15.TabIndex = 147;
			this.label15.Text = "Frequencia";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label16
			// 
			this.label16.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label16.Location = new System.Drawing.Point(242, 131);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(30, 20);
			this.label16.TabIndex = 146;
			this.label16.Text = "dias";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label17
			// 
			this.label17.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label17.Location = new System.Drawing.Point(6, 131);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(197, 20);
			this.label17.TabIndex = 145;
			this.label17.Text = "Sem montagem a mais de:";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtDiasMontagem
			// 
			this.edtDiasMontagem.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtDiasMontagem.Location = new System.Drawing.Point(209, 131);
			this.edtDiasMontagem.MaxLength = 50;
			this.edtDiasMontagem.Name = "edtDiasMontagem";
			this.edtDiasMontagem.Size = new System.Drawing.Size(27, 20);
			this.edtDiasMontagem.TabIndex = 144;
			this.edtDiasMontagem.Text = "0";
			// 
			// edtDiaEntrega
			// 
			this.edtDiaEntrega.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtDiaEntrega.Location = new System.Drawing.Point(369, 101);
			this.edtDiaEntrega.MaxLength = 50;
			this.edtDiaEntrega.Name = "edtDiaEntrega";
			this.edtDiaEntrega.Size = new System.Drawing.Size(27, 20);
			this.edtDiaEntrega.TabIndex = 143;
			this.edtDiaEntrega.Text = "0";
			// 
			// label6
			// 
			this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label6.Location = new System.Drawing.Point(278, 101);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(85, 20);
			this.label6.TabIndex = 142;
			this.label6.Text = "Dia da semana";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxDiaEntrega
			// 
			this.cbxDiaEntrega.FormattingEnabled = true;
			this.cbxDiaEntrega.Location = new System.Drawing.Point(369, 101);
			this.cbxDiaEntrega.Name = "cbxDiaEntrega";
			this.cbxDiaEntrega.Size = new System.Drawing.Size(70, 21);
			this.cbxDiaEntrega.TabIndex = 141;
			this.cbxDiaEntrega.Text = "Semanal";
			// 
			// cbxFrequenciaEntrega
			// 
			this.cbxFrequenciaEntrega.FormattingEnabled = true;
			this.cbxFrequenciaEntrega.Location = new System.Drawing.Point(209, 101);
			this.cbxFrequenciaEntrega.Name = "cbxFrequenciaEntrega";
			this.cbxFrequenciaEntrega.Size = new System.Drawing.Size(63, 21);
			this.cbxFrequenciaEntrega.TabIndex = 140;
			this.cbxFrequenciaEntrega.Text = "Semanal";
			this.cbxFrequenciaEntrega.SelectedIndexChanged += new System.EventHandler(this.CbxFrequenciaEntregaSelectedIndexChanged);
			// 
			// label7
			// 
			this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label7.Location = new System.Drawing.Point(30, 101);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(173, 20);
			this.label7.TabIndex = 139;
			this.label7.Text = "Frequencia";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label8.Location = new System.Drawing.Point(242, 71);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(30, 20);
			this.label8.TabIndex = 138;
			this.label8.Text = "dias";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label9
			// 
			this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label9.Location = new System.Drawing.Point(6, 71);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(197, 20);
			this.label9.TabIndex = 137;
			this.label9.Text = "Sem entrega efetiva a mais de:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtDiasEntrega
			// 
			this.edtDiasEntrega.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtDiasEntrega.Location = new System.Drawing.Point(209, 71);
			this.edtDiasEntrega.MaxLength = 50;
			this.edtDiasEntrega.Name = "edtDiasEntrega";
			this.edtDiasEntrega.Size = new System.Drawing.Size(27, 20);
			this.edtDiasEntrega.TabIndex = 136;
			this.edtDiasEntrega.Text = "0";
			// 
			// edtDiaConfirmacaoEntrega
			// 
			this.edtDiaConfirmacaoEntrega.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtDiaConfirmacaoEntrega.Location = new System.Drawing.Point(369, 45);
			this.edtDiaConfirmacaoEntrega.MaxLength = 50;
			this.edtDiaConfirmacaoEntrega.Name = "edtDiaConfirmacaoEntrega";
			this.edtDiaConfirmacaoEntrega.Size = new System.Drawing.Size(27, 20);
			this.edtDiaConfirmacaoEntrega.TabIndex = 135;
			this.edtDiaConfirmacaoEntrega.Text = "0";
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(278, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 20);
			this.label1.TabIndex = 134;
			this.label1.Text = "Dia da semana";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxDiaConfirmacaoEntrega
			// 
			this.cbxDiaConfirmacaoEntrega.FormattingEnabled = true;
			this.cbxDiaConfirmacaoEntrega.Location = new System.Drawing.Point(369, 45);
			this.cbxDiaConfirmacaoEntrega.Name = "cbxDiaConfirmacaoEntrega";
			this.cbxDiaConfirmacaoEntrega.Size = new System.Drawing.Size(70, 21);
			this.cbxDiaConfirmacaoEntrega.TabIndex = 133;
			this.cbxDiaConfirmacaoEntrega.Text = "Semanal";
			// 
			// cbxFrequenciaConfirmacaoEntrega
			// 
			this.cbxFrequenciaConfirmacaoEntrega.FormattingEnabled = true;
			this.cbxFrequenciaConfirmacaoEntrega.Location = new System.Drawing.Point(209, 45);
			this.cbxFrequenciaConfirmacaoEntrega.Name = "cbxFrequenciaConfirmacaoEntrega";
			this.cbxFrequenciaConfirmacaoEntrega.Size = new System.Drawing.Size(63, 21);
			this.cbxFrequenciaConfirmacaoEntrega.TabIndex = 132;
			this.cbxFrequenciaConfirmacaoEntrega.Text = "Semanal";
			this.cbxFrequenciaConfirmacaoEntrega.SelectedIndexChanged += new System.EventHandler(this.CbxFrequenciaConfirmacaoEntregaSelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label2.Location = new System.Drawing.Point(30, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(173, 20);
			this.label2.TabIndex = 132;
			this.label2.Text = "Frequencia";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label3.Location = new System.Drawing.Point(242, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(30, 20);
			this.label3.TabIndex = 131;
			this.label3.Text = "dias";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label4.Location = new System.Drawing.Point(6, 15);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(197, 20);
			this.label4.TabIndex = 130;
			this.label4.Text = "Sem comfirmação de entrega a mais de:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// edtDiasConfirmacaoEntrega
			// 
			this.edtDiasConfirmacaoEntrega.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.edtDiasConfirmacaoEntrega.Location = new System.Drawing.Point(209, 15);
			this.edtDiasConfirmacaoEntrega.MaxLength = 50;
			this.edtDiasConfirmacaoEntrega.Name = "edtDiasConfirmacaoEntrega";
			this.edtDiasConfirmacaoEntrega.Size = new System.Drawing.Size(27, 20);
			this.edtDiasConfirmacaoEntrega.TabIndex = 129;
			this.edtDiasConfirmacaoEntrega.Text = "0";
			// 
			// fAvisos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(903, 336);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.gbxSmtp);
			this.Controls.Add(this.gbxOrcamento);
			this.Controls.Add(this.btnCancela);
			this.Controls.Add(this.btnConfirma);
			this.Controls.Add(this.gbxAgenda);
			this.Name = "fAvisos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Avisos";
			this.Load += new System.EventHandler(this.FAvisosLoad);
			this.gbxAgenda.ResumeLayout(false);
			this.gbxAgenda.PerformLayout();
			this.gbxOrcamento.ResumeLayout(false);
			this.gbxOrcamento.PerformLayout();
			this.gbxSmtp.ResumeLayout(false);
			this.gbxSmtp.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
		}
		public System.Windows.Forms.TextBox edtDiasConfirmacaoEntrega;
		public System.Windows.Forms.Label label4;
		public System.Windows.Forms.Label label3;
		public System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbxFrequenciaConfirmacaoEntrega;
		private System.Windows.Forms.ComboBox cbxDiaConfirmacaoEntrega;
		public System.Windows.Forms.Label label1;
		public System.Windows.Forms.TextBox edtDiaConfirmacaoEntrega;
		public System.Windows.Forms.TextBox edtDiasEntrega;
		public System.Windows.Forms.Label label9;
		public System.Windows.Forms.Label label8;
		public System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cbxFrequenciaEntrega;
		private System.Windows.Forms.ComboBox cbxDiaEntrega;
		public System.Windows.Forms.Label label6;
		public System.Windows.Forms.TextBox edtDiaEntrega;
		public System.Windows.Forms.TextBox edtDiasMontagem;
		public System.Windows.Forms.Label label17;
		public System.Windows.Forms.Label label16;
		public System.Windows.Forms.Label label15;
		private System.Windows.Forms.ComboBox cbxFrequenciaMontagem;
		private System.Windows.Forms.ComboBox cbxDiaMontagem;
		public System.Windows.Forms.Label label10;
		public System.Windows.Forms.TextBox edtDiaMontagem;
		public System.Windows.Forms.TextBox edtDiasFaturamento;
		public System.Windows.Forms.Label label25;
		public System.Windows.Forms.Label label20;
		public System.Windows.Forms.Label label19;
		private System.Windows.Forms.ComboBox cbxFrequenciaFaturamento;
		public System.Windows.Forms.Label label18;
		private System.Windows.Forms.ComboBox cbxDiaFaturamento;
		public System.Windows.Forms.TextBox edtDiaFaturamento;
		private System.Windows.Forms.GroupBox groupBox1;
		public System.Windows.Forms.TextBox edtRemetente;
		public System.Windows.Forms.Label lblRemetente;
		public System.Windows.Forms.Label label24;
		public System.Windows.Forms.Label label23;
		public System.Windows.Forms.Label label22;
		public System.Windows.Forms.Label label21;
		public System.Windows.Forms.TextBox edtUsuario;
		public System.Windows.Forms.TextBox edtSenha;
		public System.Windows.Forms.TextBox edtServidor;
		public System.Windows.Forms.Label lblServidor;
		public System.Windows.Forms.Label lblPorta;
		public System.Windows.Forms.TextBox edtPorta;
		public System.Windows.Forms.Label lblUsuario;
		public System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox gbxSmtp;
		private System.Windows.Forms.ComboBox cbxDiaAgenda;
		private System.Windows.Forms.ComboBox cbxFrequenciaAgenda;
		public System.Windows.Forms.TextBox edtDiasOrcamento;
		private System.Windows.Forms.ComboBox cbxFrequenciaOrcamento;
		private System.Windows.Forms.ComboBox cbxDiaOrcamento;
		public System.Windows.Forms.TextBox edtDiaOrcamento;
		private System.Windows.Forms.GroupBox gbxOrcamento;
		public System.Windows.Forms.Label label12;
		public System.Windows.Forms.Label label13;
		public System.Windows.Forms.TextBox edtDiaAgenda;
		public System.Windows.Forms.Label label14;
		private System.Windows.Forms.GroupBox gbxAgenda;
		public System.Windows.Forms.Label label11;
		public System.Windows.Forms.TextBox edtDiasAgenda;
		public System.Windows.Forms.Button btnConfirma;
		public System.Windows.Forms.Button btnCancela;
	}
}
