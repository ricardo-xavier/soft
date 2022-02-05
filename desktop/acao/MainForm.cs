using System;
using System.Drawing;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using templates;
using classes;
using basico;
using agenda;


/*
 * v0.2.0 (18/10/14) - inclui/exclui (com campos limitados)
 * v0.3.0 (19/10/14) - login, funções de grid
 * v0.4.0 (20/10/14) - campos adicionados a tabela/grid
 * v0.5.0 (22/10/14) - correção login duplo / ajuste colunas grid / campos restantes no form
 * v0.6.0 (29/10/14) - observação / acertos no form(vendedor, consultor)
 * v0.7.0 (15/01/15) - mostrar observação com duplo clickc
 * v0.8.0 (17/01/15) - alteração
 * v0.9.0 (07/02/15) - produtos
 * v0.10.0 (19/02/15) - mostrar descrição da origem e da situação no grid
 * v0.11.0 (06/03/15) - contatos e histórico
 * v0.12.0 (18/03/15) - ajustes na tela
 *                      filtro por usuario
 * v0.13.0 (23/03/15) - filtro
 * v0.14.0 (05/04/15) - contato e situação no histórico
 *                      alteração na ordem dos filtros
 *                      duplo click em contatos
 *                      link para cadastro de contatos
 *                      link para agenda
 *                      tabela de relacionamento entre agendamentos e ações
 * v0.15.0 (19/04/15) - * no histórico
 *                      correção - limpar o grid de histórico quando não tem contato
 *                      destaque para o código na manutenção
 *                      inclusão do campo concorrentes e sua manutenção e visualização
 * v0.16.0 (02/05/15) - inversão dos campos observação e concorrentes no formulário
 *                      idt para apresentar automaticamente uma situação
 *                      indicador de orçamento
 *                      chamada do orçamento
 * v0.17.0 (07/05/15) - recarregar no duplo click de contatos e históricos
 *                      diminuir imagens do botão de orçamentos
 *                      colorir a situação das ações
 * v0.18.0 (17/05/15) - colunas primeiro e último contato
 *                      tempo de negócio(hint)
 *                      tempo sem retorno(hint)
 *                      marca/desmarca todas as situações no filtro
 * v0.19.0 (18/05/15) - alterações na tela
 *                      marcação de ações sem resposta
 * v0.20.0 (05/07/15) - estatísticas
 * v1.0.0  (21/10/15) - carregar inicialmente somento do usuário logado
 * 
 * 
 * v1.12.0 (28/07/18) - mergulhar nos orçamentos pelas estatísticas
 */

namespace acao
{
	public partial class MainForm : Form
	{
		private bool login;
		private string col_sorted;
		private SortOrder ord_sorted;
		private string cliente;
		private string consultor;
		private string usuario;
		private Filtro frmFiltro;
		private string acaoSelecionada;
		
		public MainForm(string[] args)
		{
			InitializeComponent();
			Grid.Inicializa();
			if (args.Length > 0) 
			{
				login = false;
				Globais.sUsuario = args[0];
				Globais.sFilial = args[1];
				Globais.bAdministrador = args[2][0] == 'S';
			}
			else login = true;
			if (!Globais.bAdministrador)
			{
				usuario = Globais.sUsuario;
			}
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			string sBanco="";
			string sUltimoUsuario="";
			string sUltimaFilial="";			
			Globais.CarregaIni(ref sBanco, ref sUltimoUsuario, ref sUltimaFilial);
			string parametros = "User=SYSDBA;" +
								"Password=masterkey;" +
								"Database=" + sBanco;
			Globais.bd = new FbConnection(parametros);
			try
			{
				Log.Grava(Globais.sUsuario, parametros);
				Globais.bd.Open();
			}
			catch (Exception err)
			{
				Log.Grava(Globais.sUsuario, "erro:" + err.Message);
				MessageBox.Show("Erro na conexão com o banco de dados:\n" + sBanco +
				                "\n" + err.Message);
				Close();
				return;
			}
			
			if (login)
			{
				frmLogin frm = new frmLogin();
				frm.admin = false;
				frm.sUltimoUsuario = sUltimoUsuario;
				frm.sUltimaFilial = sUltimaFilial;
				frm.ShowDialog();
				if (!frm.bOK)
				{
					Close();
					return;
				}
				else
				{
					Globais.GravaIni(sBanco, sUltimoUsuario, sUltimaFilial);
				}
			
				cControleAcesso acesso = new cControleAcesso();
				if (!Globais.bAdministrador &&  !acesso.PermissaoSistema(Globais.sUsuario, Globais.sFilial, 9))
				{
					MessageBox.Show("Usuário sem permissão para esse Sistema", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
					Close();
				}
			}
			frmFiltro = new Filtro();			
			if (!Globais.bAdministrador)
			{
				frmFiltro.vendedor = Globais.sUsuario;
			}
			CarregaAcoes();
			col_sorted = "";
			ord_sorted = SortOrder.Ascending;			
		}
		
		void CarregaAcoes()
		{
			this.Cursor = Cursors.WaitCursor;
			AcaoDAO.Carrega(dgvAcoes, 
					frmFiltro.cliente,
					frmFiltro.consultor,
					frmFiltro.origem,
					frmFiltro.vendedor,
					frmFiltro.situacoes,
					frmFiltro.idt_previsaoI,
					frmFiltro.previsaoI,
					frmFiltro.idt_previsaoF,
					frmFiltro.previsaoF
	              	);
			this.Cursor = Cursors.Default;
			ColoreAcoes();
			lblTotalAcoes.Text = dgvAcoes.RowCount.ToString() + " ações selecionadas";
		}
		
		void CarregaContatos(string cliente, string seq)
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			btnOrcamentos.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
			this.Cursor = Cursors.WaitCursor;
			dgvHistorico.DataSource = null;
			AcaoDAO.CarregaContatos(dgvContatos, cliente, seq);
			if (dgvContatos.RowCount == 0)
			{
				AcaoDAO.CarregaParceiro(dgvContatos, cliente);
			}
			bool temOrcamento = AcaoDAO.VerificaOrcamento(cliente, seq);
			if (temOrcamento)
				btnOrcamentos.Image = button1.Image;
			else
				btnOrcamentos.Image = button2.Image;
			this.Cursor = Cursors.Default;
		}
		
		void CarregaHistorico(string cliente, string contato, int seqAcao)
		{
			this.Cursor = Cursors.WaitCursor;
			AcaoDAO.CarregaHistorico(dgvHistorico, cliente, contato, seqAcao);
			Colore();
			this.Cursor = Cursors.Default;
		}		
		
		void BtnFechaClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void BtnIncluiClick(object sender, EventArgs e)
		{
			fCadAcao form = new fCadAcao();
			try
			{
				form.ShowDialog();
			}
			catch (Exception ex)
			{
				Log.Grava(Globais.sUsuario, "erro:" + ex.Message);
				MessageBox.Show("Erro na inclusão:\n" + ex.Message);				
				return;
			}
			CarregaAcoes();
			Grid.Sort(dgvAcoes, col_sorted, ord_sorted);
			Grid.MarcaSelecionados(dgvAcoes);
			Grid.Posiciona(dgvAcoes, form.Seq.ToString());
		}
		
		void BtnExcluiClick(object sender, EventArgs e)
		{
			if (dgvAcoes.Rows.Count == 0) 
			{
				return;
			}
			int i = dgvAcoes.CurrentRow.Index;
			string codigo = dgvAcoes.Rows[i].Cells[0].Value.ToString();
			DialogResult r = MessageBox.Show(codigo, "Confirma a exclusão?",
			                                 MessageBoxButtons.YesNo,
			                                 MessageBoxIcon.Question);
			if (r == DialogResult.No) {
				return;
			}
			AcaoComercial acao = new AcaoComercial();
			acao.SeqAcao = Globais.StrToInt(codigo);
			this.Cursor = Cursors.WaitCursor;
			try
			{				
				AcaoDAO.Exclui(acao);
			}
			catch (Exception ex)
			{
				Log.Grava(Globais.sUsuario, "erro:" + ex.Message);
				MessageBox.Show("Erro na exclusão:\n" + ex.Message);
				return;
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
			CarregaAcoes();
			Grid.Sort(dgvAcoes, col_sorted, ord_sorted);					
			Grid.MarcaSelecionados(dgvAcoes);			
		}
		
		void DgvAcoesMouseDoubleClick(object sender, MouseEventArgs e)
		{
			DataGridView.HitTestInfo hti = dgvAcoes.HitTest(e.X, e.Y);
			if (hti.RowIndex == -1)
			{
				return;
			}
			int i = hti.RowIndex;
			fObservacao frm = new fObservacao("Observação", dgvAcoes.Rows[i].Cells["Observação"].Value.ToString());
			frm.ShowDialog();
		}
		
		void BtnAlteraClick(object sender, EventArgs e)
		{
			if (dgvAcoes.Rows.Count == 0) 
			{
				return;
			}			
			fCadAcao form = new fCadAcao();
			try
			{
				form.Alteracao = true;
				form.Acao = new AcaoComercial();
				int i = dgvAcoes.CurrentRow.Index;
				form.Acao.SeqAcao = int.Parse(dgvAcoes.Rows[i].Cells["Cod"].Value.ToString());
				form.Acao.CodCliente = dgvAcoes.Rows[i].Cells["Cliente"].Value.ToString();
				form.Acao.DesObra = dgvAcoes.Rows[i].Cells["Obra"].Value.ToString();
				form.Acao.DatPrevisao = (DateTime) dgvAcoes.Rows[i].Cells["Previsão"].Value;
				form.Acao.CodVendedor = dgvAcoes.Rows[i].Cells["Vendedor"].Value.ToString();
				form.Acao.CodConsultor = dgvAcoes.Rows[i].Cells["Consultor"].Value.ToString();
				form.Acao.CodOrigem = dgvAcoes.Rows[i].Cells["CodOrigem"].Value.ToString();
				form.Acao.IdtSituacao = dgvAcoes.Rows[i].Cells["CodSituacao"].Value.ToString();
				form.Acao.TxtObservacao = dgvAcoes.Rows[i].Cells["Observação"].Value.ToString();
				form.ShowDialog();
			}
			catch (Exception ex)
			{
				Log.Grava(Globais.sUsuario, "erro:" + ex.Message);
				MessageBox.Show("Erro na alteração:\n" + ex.Message);
				return;
			}
			CarregaAcoes();
			Grid.Sort(dgvAcoes, col_sorted, ord_sorted);
			Grid.MarcaSelecionados(dgvAcoes);
			Grid.Posiciona(dgvAcoes, form.Seq.ToString());
		}
		
		void BtnProdutosClick(object sender, EventArgs e)
		{
			if (dgvAcoes.Rows.Count == 0) 
			{
				return;
			}						
						
			int i = dgvAcoes.CurrentRow.Index;
			int seqAcao = int.Parse(dgvAcoes.Rows[i].Cells["Cod"].Value.ToString());			
			fProdutosAcao form = new fProdutosAcao(seqAcao);
			form.ShowDialog();
			
			CarregaAcoes();
			Grid.Sort(dgvAcoes, col_sorted, ord_sorted);
			Grid.MarcaSelecionados(dgvAcoes);
			Grid.Posiciona(dgvAcoes, seqAcao.ToString());			
		}
		
		void DgvAcoesRowEnter(object sender, DataGridViewCellEventArgs e)
		{
			cliente = dgvAcoes.Rows[e.RowIndex].Cells["Cliente"].Value.ToString();
			consultor = dgvAcoes.Rows[e.RowIndex].Cells["Consultor"].Value.ToString();
			int i = e.RowIndex;
			acaoSelecionada = dgvAcoes.Rows[i].Cells[0].Value.ToString();
			CarregaContatos(cliente, acaoSelecionada);
		}
		
		void DgvContatosRowEnter(object sender, DataGridViewCellEventArgs e)
		{
			string contato = dgvContatos.Rows[e.RowIndex].Cells["CodContato"].Value.ToString();
			string codigo;
			if (dgvAcoes.Rows.Count == 0)
			{
				codigo = "0";
			}
			else 
			{
				codigo = acaoSelecionada;
				//int i = (dgvAcoes.CurrentRow != null) ? dgvAcoes.CurrentRow.Index : 0;
				//codigo = dgvAcoes.Rows[i].Cells[0].Value.ToString();
			}
			CarregaHistorico(cliente, contato, int.Parse(codigo));
		}
		
		void DgvHistoricoMouseDoubleClick(object sender, MouseEventArgs e)
		{
			DataGridView.HitTestInfo hti = dgvHistorico.HitTest(e.X, e.Y);
			if (hti.RowIndex == -1)
			{
				return;
			}
			int i = hti.RowIndex;
			int j = dgvAcoes.CurrentRow.Index;
			string codigo = dgvAcoes.Rows[j].Cells[0].Value.ToString();
			string[] args = new string[6];
			args[0] = Globais.sUsuario;
			args[1] = Globais.sFilial;
			args[2] = Globais.bAdministrador ? "S" : "N";			
			string usuario = dgvHistorico.Rows[i].Cells["CodUsuario"].Value.ToString().Trim();
			DateTime data = DateTime.Parse(dgvHistorico.Rows[i].Cells["Agendamento"].Value.ToString());
			args[3] = usuario;
			args[4] = data.ToString().Trim();
			args[5] = codigo;
			trace.grava("agendamento duplo click");
			frmAgenda frm = new frmAgenda(args);
			frm.ShowDialog();
			
			i = dgvContatos.CurrentRow.Index;
			string contato = dgvContatos.Rows[i].Cells["CodContato"].Value.ToString();			
			CarregaHistorico(cliente, contato, int.Parse(codigo));
		}
		
		void BtnFiltroClick(object sender, EventArgs e)
		{
			frmFiltro = new Filtro();			
			if (!Globais.bAdministrador)
			{
				frmFiltro.vendedor = Globais.sUsuario;
			}			
			frmFiltro.ShowDialog();
			if (frmFiltro.result)
			{				
				int i = -1;
				int seq = 0;
				if (dgvAcoes.Rows.Count > 0) {
					i = dgvAcoes.CurrentRow.Index;
					seq = int.Parse(dgvAcoes.Rows[i].Cells["Cod"].Value.ToString());			
				}
				CarregaAcoes();			
				if (i > -1) {
					Grid.Sort(dgvAcoes, col_sorted, ord_sorted);
					Grid.MarcaSelecionados(dgvAcoes);
					Grid.Posiciona(dgvAcoes, seq.ToString());				
				}
			}
		}
		
		void BtnRefreshClick(object sender, EventArgs e)
		{
			int i = -1;
			int seq = 0;
			if (dgvAcoes.Rows.Count > 0) {
				i = dgvAcoes.CurrentRow.Index;
				seq = int.Parse(dgvAcoes.Rows[i].Cells["Cod"].Value.ToString());			
			}			
			CarregaAcoes();
			if (i > -1) {
				Grid.Sort(dgvAcoes, col_sorted, ord_sorted);
				Grid.MarcaSelecionados(dgvAcoes);
				Grid.Posiciona(dgvAcoes, seq.ToString());			
			}
		}
		
		void BtnClienteClick(object sender, EventArgs e)
		{
			if (dgvAcoes.Rows.Count == 0) return;
			cControleAcesso acesso = new cControleAcesso();
			if (!acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fConParceiros")) return;				
			frmCadParceiros frmCad = new frmCadParceiros(true);
			frmCad.where = "where COD_PARCEIRO='" + cliente + "'";
			frmCad.codigo = cliente;
			frmCad.ReadOnly = !acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fCadParceiros");
			frmCad.ShowDialog();
		}
		
		void BtnConsultorClick(object sender, EventArgs e)
		{
			if (dgvAcoes.Rows.Count == 0) return;
			cControleAcesso acesso = new cControleAcesso();
			if (!acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fConParceiros")) return;
			frmCadParceiros frmCad = new frmCadParceiros(true);
			frmCad.where = "where COD_PARCEIRO='" + consultor + "'";
			frmCad.codigo = consultor;
			frmCad.ReadOnly = !acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fCadParceiros");
			frmCad.ShowDialog();
		}
		
		void BtnObservacaoClick(object sender, EventArgs e)
		{
			if (dgvAcoes.Rows.Count == 0) return;
			int i = dgvAcoes.CurrentRow.Index;
			fObservacao frm = new fObservacao("Observação", dgvAcoes.Rows[i].Cells["Observação"].Value.ToString());
			frm.ShowDialog();			
		}
		
		void ColoreAcoes()
		{
			foreach (DataGridViewRow row in dgvAcoes.Rows)
			{
				DataGridViewCell cell = row.Cells["Situação"];		
				string menor = row.Cells["Menor"].Value.ToString().Trim();
				string maior = row.Cells["Maior"].Value.ToString().Trim();
				string igual = row.Cells["Igual"].Value.ToString().Trim();
				if (!menor.Equals(""))
				{
					cell.Style.BackColor = Color.Red;
				}
				else
				if (!igual.Equals("") && maior.Equals(""))
				{
					cell.Style.BackColor = Color.Yellow;
				}
				else
				if (!maior.Equals(""))
				{
					cell.Style.BackColor = Color.Green;
				}					
				row.Cells["S"].Value = false;
				
				cell = row.Cells["Último"];	
				int tempo = 0;
				int.TryParse(row.Cells["TempoSemRetorno"].Value.ToString(), out tempo);
				if (tempo > 30)
				{
					cell.Style.BackColor = Color.Orange;
				}				
			}			
		}
		
		void Colore()
		{
			bool temAgendaAberta = false;
			bool agendaDesatualizada = false;
			foreach (DataGridViewRow row in  dgvHistorico.Rows)
			{
				DataGridViewCell cell = row.Cells["Situação"];		
				string sol = row.Cells["Solução"].Value.ToString().Trim();
				string pertenceAcao = row.Cells["PertenceAcao"].Value.ToString();
				string asterisco = pertenceAcao.Equals("") ? "" : "*";
				if (sol.Equals(""))
				{
					if (asterisco.Equals("*"))
					{
						temAgendaAberta = true;
					}					
					DateTime dt = DateTime.Parse(row.Cells["Previsão"].Value.ToString());
					cell.Style.ForeColor = Color.Black;										
					cell.Style.SelectionForeColor = Color.Black;
					if (dt.Date < DateTime.Today.Date) 
					{
						cell.Style.BackColor = Color.Red;
						cell.Style.SelectionBackColor = Color.Red;
						cell.Value = asterisco + "Atrasado";
						if (asterisco.Equals("*"))
						{
							agendaDesatualizada = true;
						}
					}
					else
					if (dt.Date > DateTime.Today.Date) 
					{
						cell.Style.BackColor = Color.Green;
						cell.Style.SelectionBackColor = Color.Green;
						cell.Value = asterisco + "Aberto";
					}
					else
					{
						cell.Style.BackColor = Color.Yellow;
						cell.Style.SelectionBackColor = Color.Yellow;
						cell.Value = asterisco + "Hoje";
					}
				}
				else
				{
					cell.Value = asterisco + "Solucionado";
				}
			}
			btnOrcamentos.Enabled = temAgendaAberta && !agendaDesatualizada;
		}
		
		void LnkContatosLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (dgvContatos.Rows.Count > 0)
			{
				int i = dgvContatos.CurrentRow.Index;
				string papel = dgvContatos.Rows[i].Cells["Papel"].Value.ToString().Trim();
				if ((papel != null) && papel.Trim().Equals("."))
				{	
					frmCadParceiros frmParceiros = new frmCadParceiros(false);
					frmParceiros.where = "where COD_PARCEIRO='" + cliente.Trim() + "'";
					frmParceiros.ReadOnly = false;
					frmParceiros.ShowDialog();
					CarregaContatos(cliente, acaoSelecionada);
					return;
				}
			}
			
			frmCadContatos frm = new frmCadContatos(false);
			frm.parceiro = cliente;
			frm.ShowDialog();
			CarregaContatos(cliente, acaoSelecionada);
		}
		
		void DgvContatosMouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (dgvContatos.Rows.Count == 0)
			{
				return;
			}
			
			int i = dgvContatos.CurrentRow.Index;
			string papel = dgvContatos.Rows[i].Cells["Papel"].Value.ToString().Trim();
			string contato = dgvContatos.Rows[i].Cells["CodContato"].Value.ToString().Trim();
			if ((papel != null) && papel.Trim().Equals("."))
			{
				frmCadParceiros frm = new frmCadParceiros(false);
				frm.where = "where COD_PARCEIRO='" + cliente.Trim() + "'";
				frm.ReadOnly = true;
				frm.ShowDialog();
			}
			else
			{
				frmCadContatos frm = new frmCadContatos(false);
				frm.parceiro = cliente;
				frm.cod_contato = contato;
				frm.ReadOnly = true;
				frm.ShowDialog();				
			}
			CarregaContatos(cliente, acaoSelecionada);
		}
		
		void LnkAgendaLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (dgvAcoes.Rows.Count == 0)
			{
				return;
			}
			int i = dgvAcoes.CurrentRow.Index;
			string codigo = dgvAcoes.Rows[i].Cells[0].Value.ToString();
			
			string[] args = new string[5];
			args[0] = Globais.sUsuario;
			args[1] = Globais.sFilial;
			args[2] = Globais.bAdministrador ? "S" : "N";
			args[3] = cliente;
			args[4] = codigo;
			trace.grava("agendamento link");
			frmAgenda frm = new frmAgenda(args);
			frm.ShowDialog();
			
			i = dgvContatos.CurrentRow.Index;
			string contato = dgvContatos.Rows[i].Cells["CodContato"].Value.ToString();
			CarregaHistorico(cliente, contato, int.Parse(codigo));
		}
		
		void BtnConcorrentesClick(object sender, EventArgs e)
		{
			if (dgvAcoes.Rows.Count == 0) return;
			int i = dgvAcoes.CurrentRow.Index;
			fObservacao frm = new fObservacao("Concorrentes", dgvAcoes.Rows[i].Cells["Concorrentes"].Value.ToString());
			frm.ShowDialog();
		}
		
		void BtnOrcamentosClick(object sender, EventArgs e)
		{
			string[] args = new string[5];
			args[0] = Globais.sUsuario;
			args[1] = Globais.sFilial;
			args[2] = Globais.bAdministrador ? "S" : "N";
			args[3] = "-clienteacao";
			int i = dgvAcoes.CurrentRow.Index;
			string seq = dgvAcoes.Rows[i].Cells["Cod"].Value.ToString();
			string clientes = "'" + cliente.Trim() + "'" + AcaoDAO.ClientesAcaoIn(seq);
			args[4] = clientes;
			orcamento.MainForm frm = new orcamento.MainForm(args);
			frm.ShowDialog();			
		}
		
		void BtnEstatisticasClick(object sender, EventArgs e)
		{
			string vendedor = Globais.sUsuario;
			if (Globais.bAdministrador) {
				SelecaoVendedor frm = new SelecaoVendedor();
				frm.ShowDialog();
				if (frm.vendedor == null)
					return;
				vendedor = frm.vendedor;
			}
			Estatisticas frmEstatisticas = new Estatisticas(vendedor);
			frmEstatisticas.ShowDialog();
		}
		
		void DgvAcoesSorted(object sender, EventArgs e)
		{
			col_sorted = dgvAcoes.SortedColumn.HeaderText;
			ord_sorted = dgvAcoes.SortOrder;			
			ColoreAcoes();
		}
		
		void EdtLocalizaTextChanged(object sender, EventArgs e)
		{
			Grid.Localiza(dgvAcoes, edtLocaliza.Text.Trim());
		}
		
		void BtnDownClick(object sender, EventArgs e)
		{
			Grid.Proximo(dgvAcoes, edtLocaliza.Text.Trim());	
		}
		
		void BtnUpClick(object sender, EventArgs e)
		{
			Grid.Anterior(dgvAcoes, edtLocaliza.Text.Trim());
		}
		
		void ImgClientesClick(object sender, EventArgs e)
		{
			cControleAcesso acesso = new cControleAcesso();
			frmCadParceiros frmCad = new frmCadParceiros(true);
			frmCad.where = "";
			frmCad.codigo = "";
			frmCad.ReadOnly = !acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fCadParceiros");
			frmCad.ShowDialog();
	
		}
	}
}
