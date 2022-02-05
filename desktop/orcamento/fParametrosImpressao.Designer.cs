/*
 * Criado por SharpDevelop.
 * Usuário: Ricardo
 * Data: 19/10/2008
 * Hora: 8:48
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace orcamento
{
	partial class fParametrosImpressao
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
			this.btnCancela = new System.Windows.Forms.Button();
			this.btnConfirma = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.chkMostrarMedidas = new System.Windows.Forms.CheckBox();
			this.chkTotalProdServ = new System.Windows.Forms.CheckBox();
			this.chkTermoAprovacao = new System.Windows.Forms.CheckBox();
			this.chkConsolidadoItem = new System.Windows.Forms.CheckBox();
			this.chkCondicoesMontagem = new System.Windows.Forms.CheckBox();
			this.chkConsolidado = new System.Windows.Forms.CheckBox();
			this.chkTermoGarantia = new System.Windows.Forms.CheckBox();
			this.rbtOrcamento = new System.Windows.Forms.RadioButton();
			this.chkInformacoesFornecimento = new System.Windows.Forms.CheckBox();
			this.chkIntroducao = new System.Windows.Forms.CheckBox();
			this.chkValores = new System.Windows.Forms.CheckBox();
			this.chkEnderecoFilial = new System.Windows.Forms.CheckBox();
			this.chkDetalhada = new System.Windows.Forms.CheckBox();
			this.chkResumida = new System.Windows.Forms.CheckBox();
			this.chkFoto = new System.Windows.Forms.CheckBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.chkOrdenaCaracteristica = new System.Windows.Forms.CheckBox();
			this.chkSinal = new System.Windows.Forms.CheckBox();
			this.chkValor = new System.Windows.Forms.CheckBox();
			this.chkSituacao = new System.Windows.Forms.CheckBox();
			this.chkConsultor = new System.Windows.Forms.CheckBox();
			this.chkCliente = new System.Windows.Forms.CheckBox();
			this.chkVendedor = new System.Windows.Forms.CheckBox();
			this.chkCodigo = new System.Windows.Forms.CheckBox();
			this.chkData = new System.Windows.Forms.CheckBox();
			this.chkFornecedor = new System.Windows.Forms.CheckBox();
			this.rbtListagem = new System.Windows.Forms.RadioButton();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCancela
			// 
			this.btnCancela.Location = new System.Drawing.Point(607, 44);
			this.btnCancela.Name = "btnCancela";
			this.btnCancela.Size = new System.Drawing.Size(100, 25);
			this.btnCancela.TabIndex = 25;
			this.btnCancela.Text = "C&ancela";
			this.btnCancela.UseVisualStyleBackColor = true;
			this.btnCancela.Click += new System.EventHandler(this.BtnCancelaClick);
			// 
			// btnConfirma
			// 
			this.btnConfirma.Location = new System.Drawing.Point(607, 13);
			this.btnConfirma.Name = "btnConfirma";
			this.btnConfirma.Size = new System.Drawing.Size(100, 25);
			this.btnConfirma.TabIndex = 24;
			this.btnConfirma.Text = "&Confirma";
			this.btnConfirma.UseVisualStyleBackColor = true;
			this.btnConfirma.Click += new System.EventHandler(this.BtnConfirmaClick);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.chkMostrarMedidas);
			this.panel1.Controls.Add(this.chkTotalProdServ);
			this.panel1.Controls.Add(this.chkTermoAprovacao);
			this.panel1.Controls.Add(this.chkConsolidadoItem);
			this.panel1.Controls.Add(this.chkCondicoesMontagem);
			this.panel1.Controls.Add(this.chkConsolidado);
			this.panel1.Controls.Add(this.chkTermoGarantia);
			this.panel1.Controls.Add(this.rbtOrcamento);
			this.panel1.Controls.Add(this.chkInformacoesFornecimento);
			this.panel1.Controls.Add(this.chkIntroducao);
			this.panel1.Controls.Add(this.chkValores);
			this.panel1.Controls.Add(this.chkEnderecoFilial);
			this.panel1.Controls.Add(this.chkDetalhada);
			this.panel1.Controls.Add(this.chkResumida);
			this.panel1.Controls.Add(this.chkFoto);
			this.panel1.Location = new System.Drawing.Point(2, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(599, 236);
			this.panel1.TabIndex = 0;
			// 
			// chkMostrarMedidas
			// 
			this.chkMostrarMedidas.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkMostrarMedidas.Location = new System.Drawing.Point(378, 208);
			this.chkMostrarMedidas.Name = "chkMostrarMedidas";
			this.chkMostrarMedidas.Size = new System.Drawing.Size(191, 22);
			this.chkMostrarMedidas.TabIndex = 25;
			this.chkMostrarMedidas.Text = "Mostrar medidas";
			this.chkMostrarMedidas.UseVisualStyleBackColor = true;
			// 
			// chkTotalProdServ
			// 
			this.chkTotalProdServ.Checked = true;
			this.chkTotalProdServ.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkTotalProdServ.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkTotalProdServ.Location = new System.Drawing.Point(378, 184);
			this.chkTotalProdServ.Name = "chkTotalProdServ";
			this.chkTotalProdServ.Size = new System.Drawing.Size(191, 22);
			this.chkTotalProdServ.TabIndex = 24;
			this.chkTotalProdServ.Text = "Mostrar total Produto/Serviço";
			this.chkTotalProdServ.UseVisualStyleBackColor = true;
			// 
			// chkTermoAprovacao
			// 
			this.chkTermoAprovacao.Checked = true;
			this.chkTermoAprovacao.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkTermoAprovacao.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkTermoAprovacao.Location = new System.Drawing.Point(153, 110);
			this.chkTermoAprovacao.Name = "chkTermoAprovacao";
			this.chkTermoAprovacao.Size = new System.Drawing.Size(132, 24);
			this.chkTermoAprovacao.TabIndex = 6;
			this.chkTermoAprovacao.Text = "Termo de Aprovação";
			this.chkTermoAprovacao.UseVisualStyleBackColor = true;
			// 
			// chkConsolidadoItem
			// 
			this.chkConsolidadoItem.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkConsolidadoItem.Location = new System.Drawing.Point(378, 160);
			this.chkConsolidadoItem.Name = "chkConsolidadoItem";
			this.chkConsolidadoItem.Size = new System.Drawing.Size(205, 22);
			this.chkConsolidadoItem.TabIndex = 13;
			this.chkConsolidadoItem.Text = "Consolidar por Item";
			this.chkConsolidadoItem.UseVisualStyleBackColor = true;
			// 
			// chkCondicoesMontagem
			// 
			this.chkCondicoesMontagem.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkCondicoesMontagem.Location = new System.Drawing.Point(153, 85);
			this.chkCondicoesMontagem.Name = "chkCondicoesMontagem";
			this.chkCondicoesMontagem.Size = new System.Drawing.Size(157, 24);
			this.chkCondicoesMontagem.TabIndex = 5;
			this.chkCondicoesMontagem.Text = "Condições para Montagem";
			this.chkCondicoesMontagem.UseVisualStyleBackColor = true;
			// 
			// chkConsolidado
			// 
			this.chkConsolidado.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkConsolidado.Location = new System.Drawing.Point(378, 135);
			this.chkConsolidado.Name = "chkConsolidado";
			this.chkConsolidado.Size = new System.Drawing.Size(205, 22);
			this.chkConsolidado.TabIndex = 12;
			this.chkConsolidado.Text = "Consolidar Orçamentos";
			this.chkConsolidado.UseVisualStyleBackColor = true;
			// 
			// chkTermoGarantia
			// 
			this.chkTermoGarantia.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkTermoGarantia.Location = new System.Drawing.Point(153, 60);
			this.chkTermoGarantia.Name = "chkTermoGarantia";
			this.chkTermoGarantia.Size = new System.Drawing.Size(119, 24);
			this.chkTermoGarantia.TabIndex = 4;
			this.chkTermoGarantia.Text = "Termo de Garantia";
			this.chkTermoGarantia.UseVisualStyleBackColor = true;
			// 
			// rbtOrcamento
			// 
			this.rbtOrcamento.Checked = true;
			this.rbtOrcamento.Location = new System.Drawing.Point(10, 9);
			this.rbtOrcamento.Name = "rbtOrcamento";
			this.rbtOrcamento.Size = new System.Drawing.Size(104, 24);
			this.rbtOrcamento.TabIndex = 1;
			this.rbtOrcamento.TabStop = true;
			this.rbtOrcamento.Text = "Orçamento";
			this.rbtOrcamento.UseVisualStyleBackColor = true;
			this.rbtOrcamento.Click += new System.EventHandler(this.RbtOrcamentoClick);
			// 
			// chkInformacoesFornecimento
			// 
			this.chkInformacoesFornecimento.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkInformacoesFornecimento.Location = new System.Drawing.Point(153, 35);
			this.chkInformacoesFornecimento.Name = "chkInformacoesFornecimento";
			this.chkInformacoesFornecimento.Size = new System.Drawing.Size(173, 24);
			this.chkInformacoesFornecimento.TabIndex = 3;
			this.chkInformacoesFornecimento.Text = "Informações de Fornecimento";
			this.chkInformacoesFornecimento.UseVisualStyleBackColor = true;
			// 
			// chkIntroducao
			// 
			this.chkIntroducao.Checked = true;
			this.chkIntroducao.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkIntroducao.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkIntroducao.Location = new System.Drawing.Point(153, 10);
			this.chkIntroducao.Name = "chkIntroducao";
			this.chkIntroducao.Size = new System.Drawing.Size(78, 24);
			this.chkIntroducao.TabIndex = 2;
			this.chkIntroducao.Text = "Introdução";
			this.chkIntroducao.UseVisualStyleBackColor = true;
			// 
			// chkValores
			// 
			this.chkValores.Checked = true;
			this.chkValores.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkValores.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkValores.Location = new System.Drawing.Point(378, 110);
			this.chkValores.Name = "chkValores";
			this.chkValores.Size = new System.Drawing.Size(205, 22);
			this.chkValores.TabIndex = 11;
			this.chkValores.Text = "Mostrar Valores";
			this.chkValores.UseVisualStyleBackColor = true;
			// 
			// chkEnderecoFilial
			// 
			this.chkEnderecoFilial.Checked = true;
			this.chkEnderecoFilial.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkEnderecoFilial.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkEnderecoFilial.Location = new System.Drawing.Point(378, 85);
			this.chkEnderecoFilial.Name = "chkEnderecoFilial";
			this.chkEnderecoFilial.Size = new System.Drawing.Size(205, 22);
			this.chkEnderecoFilial.TabIndex = 10;
			this.chkEnderecoFilial.Text = "Endereço da Filial";
			this.chkEnderecoFilial.UseVisualStyleBackColor = true;
			// 
			// chkDetalhada
			// 
			this.chkDetalhada.Checked = true;
			this.chkDetalhada.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkDetalhada.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkDetalhada.Location = new System.Drawing.Point(378, 60);
			this.chkDetalhada.Name = "chkDetalhada";
			this.chkDetalhada.Size = new System.Drawing.Size(205, 22);
			this.chkDetalhada.TabIndex = 9;
			this.chkDetalhada.Text = "Mostrar descrição detalhada";
			this.chkDetalhada.UseVisualStyleBackColor = true;
			// 
			// chkResumida
			// 
			this.chkResumida.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkResumida.Location = new System.Drawing.Point(378, 35);
			this.chkResumida.Name = "chkResumida";
			this.chkResumida.Size = new System.Drawing.Size(205, 22);
			this.chkResumida.TabIndex = 8;
			this.chkResumida.Text = "Mostrar descrição resumida";
			this.chkResumida.UseVisualStyleBackColor = true;
			// 
			// chkFoto
			// 
			this.chkFoto.Checked = true;
			this.chkFoto.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkFoto.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkFoto.Location = new System.Drawing.Point(378, 10);
			this.chkFoto.Name = "chkFoto";
			this.chkFoto.Size = new System.Drawing.Size(205, 22);
			this.chkFoto.TabIndex = 7;
			this.chkFoto.Text = "Mostra fotos";
			this.chkFoto.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.chkOrdenaCaracteristica);
			this.panel2.Controls.Add(this.chkSinal);
			this.panel2.Controls.Add(this.chkValor);
			this.panel2.Controls.Add(this.chkSituacao);
			this.panel2.Controls.Add(this.chkConsultor);
			this.panel2.Controls.Add(this.chkCliente);
			this.panel2.Controls.Add(this.chkVendedor);
			this.panel2.Controls.Add(this.chkCodigo);
			this.panel2.Controls.Add(this.chkData);
			this.panel2.Controls.Add(this.chkFornecedor);
			this.panel2.Controls.Add(this.rbtListagem);
			this.panel2.Location = new System.Drawing.Point(2, 254);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(599, 133);
			this.panel2.TabIndex = 1;
			// 
			// chkOrdenaCaracteristica
			// 
			this.chkOrdenaCaracteristica.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkOrdenaCaracteristica.Location = new System.Drawing.Point(378, 108);
			this.chkOrdenaCaracteristica.Name = "chkOrdenaCaracteristica";
			this.chkOrdenaCaracteristica.Size = new System.Drawing.Size(191, 22);
			this.chkOrdenaCaracteristica.TabIndex = 24;
			this.chkOrdenaCaracteristica.Text = "Quebrar por característica";
			this.chkOrdenaCaracteristica.UseVisualStyleBackColor = true;
			// 
			// chkSinal
			// 
			this.chkSinal.Checked = true;
			this.chkSinal.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkSinal.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkSinal.Location = new System.Drawing.Point(378, 85);
			this.chkSinal.Name = "chkSinal";
			this.chkSinal.Size = new System.Drawing.Size(133, 22);
			this.chkSinal.TabIndex = 23;
			this.chkSinal.Text = "Sinal";
			this.chkSinal.UseVisualStyleBackColor = true;
			// 
			// chkValor
			// 
			this.chkValor.Checked = true;
			this.chkValor.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkValor.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkValor.Location = new System.Drawing.Point(378, 60);
			this.chkValor.Name = "chkValor";
			this.chkValor.Size = new System.Drawing.Size(133, 22);
			this.chkValor.TabIndex = 22;
			this.chkValor.Text = "Valor";
			this.chkValor.UseVisualStyleBackColor = true;
			// 
			// chkSituacao
			// 
			this.chkSituacao.Checked = true;
			this.chkSituacao.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkSituacao.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkSituacao.Location = new System.Drawing.Point(378, 35);
			this.chkSituacao.Name = "chkSituacao";
			this.chkSituacao.Size = new System.Drawing.Size(133, 22);
			this.chkSituacao.TabIndex = 21;
			this.chkSituacao.Text = "Situação";
			this.chkSituacao.UseVisualStyleBackColor = true;
			// 
			// chkConsultor
			// 
			this.chkConsultor.Checked = true;
			this.chkConsultor.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkConsultor.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkConsultor.Location = new System.Drawing.Point(378, 10);
			this.chkConsultor.Name = "chkConsultor";
			this.chkConsultor.Size = new System.Drawing.Size(133, 22);
			this.chkConsultor.TabIndex = 20;
			this.chkConsultor.Text = "Consultor";
			this.chkConsultor.UseVisualStyleBackColor = true;
			// 
			// chkCliente
			// 
			this.chkCliente.Checked = true;
			this.chkCliente.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkCliente.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkCliente.Location = new System.Drawing.Point(153, 110);
			this.chkCliente.Name = "chkCliente";
			this.chkCliente.Size = new System.Drawing.Size(205, 22);
			this.chkCliente.TabIndex = 19;
			this.chkCliente.Text = "Cliente";
			this.chkCliente.UseVisualStyleBackColor = true;
			// 
			// chkVendedor
			// 
			this.chkVendedor.Checked = true;
			this.chkVendedor.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkVendedor.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkVendedor.Location = new System.Drawing.Point(153, 85);
			this.chkVendedor.Name = "chkVendedor";
			this.chkVendedor.Size = new System.Drawing.Size(205, 22);
			this.chkVendedor.TabIndex = 18;
			this.chkVendedor.Text = "Vendedor";
			this.chkVendedor.UseVisualStyleBackColor = true;
			// 
			// chkCodigo
			// 
			this.chkCodigo.Checked = true;
			this.chkCodigo.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkCodigo.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkCodigo.Location = new System.Drawing.Point(153, 60);
			this.chkCodigo.Name = "chkCodigo";
			this.chkCodigo.Size = new System.Drawing.Size(205, 22);
			this.chkCodigo.TabIndex = 17;
			this.chkCodigo.Text = "Código";
			this.chkCodigo.UseVisualStyleBackColor = true;
			// 
			// chkData
			// 
			this.chkData.Checked = true;
			this.chkData.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkData.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkData.Location = new System.Drawing.Point(153, 35);
			this.chkData.Name = "chkData";
			this.chkData.Size = new System.Drawing.Size(205, 22);
			this.chkData.TabIndex = 16;
			this.chkData.Text = "Data";
			this.chkData.UseVisualStyleBackColor = true;
			// 
			// chkFornecedor
			// 
			this.chkFornecedor.Checked = true;
			this.chkFornecedor.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkFornecedor.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.chkFornecedor.Location = new System.Drawing.Point(153, 10);
			this.chkFornecedor.Name = "chkFornecedor";
			this.chkFornecedor.Size = new System.Drawing.Size(205, 22);
			this.chkFornecedor.TabIndex = 15;
			this.chkFornecedor.Text = "Fornecedor";
			this.chkFornecedor.UseVisualStyleBackColor = true;
			// 
			// rbtListagem
			// 
			this.rbtListagem.Location = new System.Drawing.Point(10, 10);
			this.rbtListagem.Name = "rbtListagem";
			this.rbtListagem.Size = new System.Drawing.Size(104, 24);
			this.rbtListagem.TabIndex = 14;
			this.rbtListagem.TabStop = true;
			this.rbtListagem.Text = "Listagem";
			this.rbtListagem.UseVisualStyleBackColor = true;
			this.rbtListagem.Click += new System.EventHandler(this.RbtListagemClick);
			// 
			// fParametrosImpressao
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(716, 403);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnCancela);
			this.Controls.Add(this.btnConfirma);
			this.Name = "fParametrosImpressao";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Parâmetros para Impressão";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.CheckBox chkOrdenaCaracteristica;
		private System.Windows.Forms.CheckBox chkMostrarMedidas;
		private System.Windows.Forms.CheckBox chkTotalProdServ;
		private System.Windows.Forms.CheckBox chkIntroducao;
		private System.Windows.Forms.CheckBox chkInformacoesFornecimento;
		private System.Windows.Forms.CheckBox chkTermoGarantia;
		private System.Windows.Forms.CheckBox chkCondicoesMontagem;
		private System.Windows.Forms.CheckBox chkTermoAprovacao;
		private System.Windows.Forms.CheckBox chkConsolidadoItem;
		private System.Windows.Forms.CheckBox chkConsolidado;
		private System.Windows.Forms.CheckBox chkVendedor;
		private System.Windows.Forms.CheckBox chkCliente;
		private System.Windows.Forms.CheckBox chkConsultor;
		private System.Windows.Forms.CheckBox chkSituacao;
		private System.Windows.Forms.CheckBox chkValor;
		private System.Windows.Forms.CheckBox chkSinal;
		private System.Windows.Forms.CheckBox chkCodigo;
		private System.Windows.Forms.CheckBox chkData;
		private System.Windows.Forms.CheckBox chkFornecedor;
		public System.Windows.Forms.RadioButton rbtListagem;
		private System.Windows.Forms.Panel panel2;
		public System.Windows.Forms.RadioButton rbtOrcamento;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.CheckBox chkValores;
		private System.Windows.Forms.CheckBox chkEnderecoFilial;
		public System.Windows.Forms.Button btnConfirma;
		public System.Windows.Forms.Button btnCancela;
		private System.Windows.Forms.CheckBox chkDetalhada;
		private System.Windows.Forms.CheckBox chkResumida;
		private System.Windows.Forms.CheckBox chkFoto;
	}
}
