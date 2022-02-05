/*
 * Projeto  : SoftPlace
 * Sistema  : CPD
 * Programa : fAgenda - Agenda
 * Autor    : Ricardo Costa Xavier
 * Data     : 21/04/08
 * 
 * 07/03/2015 - chamada pela ação comercial
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using templates;
using classes;
using basico;

namespace agenda
{
	public partial class frmAgenda : tCadastroSimples
	{
		private cAgenda agenda;
		public string where;
		private string filtro_usuario;
		private string filtro_responsavel;
		private string filtro_pessoal;
		private string filtro_data;
		private string filtro_natureza;
		private string cod_parceiro;
		private string des_parceiro;
		private bool juridica;
		private bool login;
		private string fornecedor;
		private string usuarioAcao;
		private DateTime data;
		private short orcamento;
		private short pedido;
		private short nro_pedido;
		private string idt_data_prevista;
		private DateTime data_prevista;
		private string cliente;
		private string col_sorted;
		private SortOrder ord_sorted;				
		private string usuario_sel;
		private string data_sel;
		private int seqAcao;
		private static bool fromMain = false;
		
		[STAThread]		
		public static void Main(string[] args)
		{
			fromMain = true;
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new frmAgenda(args));
		}
		
		void Colore()
		{
			foreach (DataGridViewRow row in  dgvCadastro.Rows)
			{
				//DateTime sol = DateTime.Parse(row.Cells[9].Value.ToString());
				DataGridViewCell cell = row.Cells[13];		
				//if (!dtpSolucao.Checked)
				string sol = row.Cells[9].Value.ToString().Trim();
				if (sol.CompareTo("") == 0)
				{
					DateTime dt = DateTime.Parse(row.Cells[2].Value.ToString());
					cell.Style.ForeColor = Color.Black;										
					cell.Style.SelectionForeColor = Color.Black;
					if (dt.Date < DateTime.Today.Date) 
					{
						cell.Style.BackColor = Color.Red;
						cell.Style.SelectionBackColor = Color.Red;
						cell.Value = "Atrasado";
					}
					else
					if (dt.Date > DateTime.Today.Date) 
					{
						cell.Style.BackColor = Color.Green;
						cell.Style.SelectionBackColor = Color.Green;
						cell.Value = "Aberto";
					}
					else
					{
						cell.Style.BackColor = Color.Yellow;
						cell.Style.SelectionBackColor = Color.Yellow;
						cell.Value = "Hoje";
					}
				}
				else 
				{
					cell.Value = "Solucionado";
				}
			}			
		}
		
		void AlteraComponentes()
		{
			dgvCadastro.Left = 262;
			dgvCadastro.Width = 525;
			dgvCadastro.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCadastroRowEnter);
			dtpSolucao.Checked = false;
			dtpEncerrado.Checked = false;
		}
		
		void InicializaCampos()
		{
			edtDescricao.Text = "x";			
			edtUsuario.Text = Globais.sUsuario;
			dtpCodigo.Value = DateTime.Now;			
			edtCodigo.Text = edtUsuario.Text + "-" + dtpCodigo.Text;
			dtpAgenda.Value = DateTime.Now;
			cbxUsuarios.Text = Globais.sUsuario;
			edtParceiro.Text = "";
			edtContato.Text = "";			
			cbxPrioridades.Text = "2 - Normal";
			edtPendencia.Text = "";			
			dtpSolucao.Value = DateTime.Now;
			dtpSolucao.Checked = false;			
			edtSolucao.Text = "";			
			ckbPessoal.Checked = false;
			ckbCancelado.Checked = false;	
			dtpEncerrado.Value = DateTime.Now;
			dtpEncerrado.Checked = false;			
		}		
		
		public void SetaEdicaoLocal(bool enabled)
		{
			btnEmail.Enabled = !enabled;
			btnImprime.Enabled = !enabled;
			
			edtCodigo.Enabled = false;
			dtpCodigo.Enabled = false;			
			dtpAgenda.Enabled = enabled;			
			cbxUsuarios.Enabled = enabled;
			//edtParceiro.Enabled = enabled;
			btnParceiros.Enabled = enabled;
			edtContato.Enabled = enabled;			
			btnContatos.Enabled = enabled;
			//btnEmail.Enabled = !enabled;			
			cbxPrioridades.Enabled = enabled;
			cbxNaturezas.Enabled = enabled;			
			//btnNatureza.Enabled = enabled;						
			ckbPessoal.Enabled = enabled;
			edtPendencia.ReadOnly = !enabled;
			dtpSolucao.Enabled = enabled;			
			edtSolucao.ReadOnly = !enabled;
			ckbPessoal.Enabled = enabled;
			ckbCancelado.Enabled = enabled;			
			calAgenda.Enabled = !enabled;
			cbxFiltroUsuarios.Enabled = !enabled;
			cbxFiltroResponsaveis.Enabled = !enabled;			
			cbxPessoal.Enabled = !enabled;
			btnCadAnexos.Enabled = !enabled;
			btnAbreAnexo.Enabled = !enabled;		
			dtpEncerrado.Enabled = enabled;						
		}
		
		public void CarregaAnexos(string usuario, DateTime data) 
		{
			agenda.CarregaAnexos(dgvAnexos, usuario, data);
			dgvAnexos.Columns["Código"].Width = 133;
			dgvAnexos.Columns["Arquivo"].Visible = false;						
			/*
			int n = dgvAnexos.Rows.Count;
			int i;
			for (i=0; i<n; i++)
			{
				switch (i) 
				{
					case 1: 
						linkLabel1.Visible = true;
						linkLabel1.Text = dgvAnexos.Rows[i-1].Cells[0].Value.ToString().Trim();
						break;
					case 2: 
						linkLabel2.Visible = true;
						linkLabel2.Text = dgvAnexos.Rows[i-1].Cells[0].Value.ToString().Trim();						
						break;
					case 3: 
						linkLabel3.Visible = true;
						linkLabel3.Text = dgvAnexos.Rows[i-1].Cells[0].Value.ToString().Trim();												
						break;
					case 4: 
						linkLabel4.Visible = true;
						linkLabel4.Text = dgvAnexos.Rows[i-1].Cells[0].Value.ToString().Trim();												
						break;
					case 5: 
						linkLabel5.Visible = true;
						linkLabel5.Text = dgvAnexos.Rows[i-1].Cells[0].Value.ToString().Trim();												
						break;
					case 6: 
						linkLabel6.Visible = true;
						linkLabel6.Text = dgvAnexos.Rows[i-1].Cells[0].Value.ToString().Trim();												
						break;
					case 7: 
						linkLabel7.Visible = true;
						linkLabel7.Text = dgvAnexos.Rows[i-1].Cells[0].Value.ToString().Trim();												
						break;
					case 8: 
						linkLabel8.Visible = true;
						linkLabel8.Text = dgvAnexos.Rows[i-1].Cells[0].Value.ToString().Trim();												
						break;
				}
			}
			for (; i<8; i++)
			{
				switch (i) 
				{
					case 1: 
						linkLabel1.Visible = false;
						break;
					case 2: 
						linkLabel2.Visible = false;
						break;
					case 3: 
						linkLabel3.Visible = false;
						break;
					case 4: 
						linkLabel4.Visible = false;
						break;
					case 5: 
						linkLabel5.Visible = false;
						break;
					case 6: 
						linkLabel6.Visible = false;
						break;
					case 7: 
						linkLabel7.Visible = false;
						break;
					case 8: 
						linkLabel1.Visible = false;
						break;
				}
			}
			*/
		}
		
		public void AtualizaDadosLocal(int i)
		{
			edtUsuario.Text = dgvCadastro.Rows[i].Cells[0].Value.ToString();
			dtpCodigo.Value = DateTime.Parse(dgvCadastro.Rows[i].Cells[1].Value.ToString());	
			edtCodigo.Text = edtUsuario.Text + "-" + dtpCodigo.Text;			
			dtpAgenda.Value = DateTime.Parse(dgvCadastro.Rows[i].Cells[2].Value.ToString());	
			cbxUsuarios.Text = dgvCadastro.Rows[i].Cells[3].Value.ToString();
			CarregaAnexos(edtUsuario.Text.Trim(), dtpCodigo.Value);
			if (dgvCadastro.Rows[i].Cells[4].Value != null)
				edtParceiro.Text = dgvCadastro.Rows[i].Cells[4].Value.ToString().Trim();
			else
				edtParceiro.Text = "";
			edtContato.Text = dgvCadastro.Rows[i].Cells[5].Value.ToString().Trim();						
			char c = dgvCadastro.Rows[i].Cells[6].Value.ToString()[0];
			for (int x=0; x<cbxPrioridades.Items.Count; x++)
			{
				if (cbxPrioridades.Items[x].ToString()[0] == c)
				{
					cbxPrioridades.Text = cbxPrioridades.Items[x].ToString();
					break;
				}
			}
			cbxNaturezas.Text = dgvCadastro.Rows[i].Cells[7].Value.ToString().Trim();
			edtPendencia.Text = dgvCadastro.Rows[i].Cells[8].Value.ToString().Trim();			
			dtpSolucao.Checked = false;
			if (dgvCadastro.Rows[i].Cells[9] != null)
			{
				string s = dgvCadastro.Rows[i].Cells[9].Value.ToString().Trim();
				if (s.CompareTo("") != 0)
				{
					dtpSolucao.Value = DateTime.Parse(dgvCadastro.Rows[i].Cells[9].Value.ToString());
					dtpSolucao.Checked = true;
				}
			}
			edtSolucao.Text = dgvCadastro.Rows[i].Cells[10].Value.ToString().Trim();			
			ckbPessoal.Checked = (dgvCadastro.Rows[i].Cells[11].Value.ToString().CompareTo("S") == 0);
			ckbCancelado.Checked = (dgvCadastro.Rows[i].Cells[11].Value.ToString().CompareTo("S") == 0);			
			dtpEncerrado.Checked = false;
			if (dgvCadastro.Rows[i].Cells[29] != null)
			{
				string s = dgvCadastro.Rows[i].Cells[29].Value.ToString().Trim();
				if (!s.Equals(""))
				{
					dtpEncerrado.Value = DateTime.Parse(s);
					dtpEncerrado.Checked = true;
				}
			}
			
			string observacao = dgvCadastro.Rows[i].Cells[30].Value.ToString().Trim();
			toolTip1.SetToolTip(btnApp, observacao);
		}
		
		public frmAgenda(string[] args)
		{
			InitializeComponent();
			Grid.Inicializa();			
			this.dgvCadastro.Sorted += new System.EventHandler(this.DgvCadastroSorted);
			fornecedor = "";
			usuarioAcao = "";
			if (args.Length > 0) 
			{
				login = false;
				Globais.sUsuario = args[0];
				Globais.sFilial = args[1];
				Globais.bAdministrador = args[2][0] == 'S';			
			}
			else login = true;
			AlteraComponentes();
			if (args.Length == 11) // pedido
			{
				fornecedor = args[3];
				data = DateTime.Parse(args[4]);
				orcamento = short.Parse(args[5]);
				pedido = short.Parse(args[6]);
				idt_data_prevista = args[7];
				data_prevista = DateTime.Parse(args[8]);
				cliente = args[9];
				nro_pedido  = short.Parse(args[10]);
			}
			seqAcao = 0;
			if (args.Length == 5) // ação comercial - link
			{
				edtFiltroParceiro.Text = args[3];
				seqAcao = int.Parse(args[4]);
			}			
			if (args.Length == 6) // ação comercial - duplo click
			{
				usuarioAcao = args[3];
				data = DateTime.Parse(args[4]);
				seqAcao = int.Parse(args[5]);
			}
		}
		
		private void Carrega() 
		{
			string[] partes = filtro_data.Split('/');
			DateTime data = Convert.ToDateTime(partes[1] + "/" + partes[0] + "/" + partes[2] + " 03:00:00");
			string usuario = "";
			if (filtro_usuario.CompareTo("Todos") != 0)
				usuario = filtro_usuario;
			string responsavel = "";
			if (filtro_responsavel.CompareTo("Todos") != 0)
				responsavel = filtro_responsavel;
			string pessoal = "";
			if (filtro_pessoal.CompareTo("Todos") != 0)
				pessoal = filtro_pessoal.Substring(0,1);
			string natureza = "";
			if (filtro_natureza.CompareTo("Todas") != 0)
				natureza = filtro_natureza;
			string parceiro = "";
			if (edtFiltroParceiro.Text.Trim().Length > 0)
				parceiro = edtFiltroParceiro.Text.Trim();
			
			this.Cursor = Cursors.WaitCursor;
			agenda.Carrega(dgvCadastro, where);
			this.Cursor = Cursors.Default;
		}
		
		public string MontaFiltro()
		{
			string where = "where (DAT_PREVISAO >= '" + filtro_data + "' or DAT_SOLUCAO is null)";
			if (filtro_usuario.CompareTo("Todos") != 0)
			{
				where = where + " and COD_USUARIO='" + filtro_usuario + "'";
			}
			if (filtro_responsavel.CompareTo("Todos") != 0)
			{
				where = where + " and COD_RESPONSAVEL='" + filtro_responsavel + "'";
			}
			if (filtro_pessoal.CompareTo("Todos") != 0)
			{
				where = where + " and IDT_PESSOAL='" + filtro_pessoal.Substring(0,1) + "'";
			}
			if (filtro_natureza.CompareTo("Todas") != 0)
			{
				where = where + " and COD_NATUREZA='" + filtro_natureza + "'";
			}
			if (edtFiltroParceiro.Text.Trim().Length > 0)
			{
				where = where + " and a.COD_PARCEIRO='" + edtFiltroParceiro.Text.Trim() + "'";
			}
			if (chkApp.Checked)
			{
				where = where + " and a.DAT_APP is not null";
			}
			return where;
		}
		
		void FrmAgendaLoad(object sender, EventArgs e)
		{
			if (fromMain) {
				
				string sBanco="";
				string sUltimoUsuario="";
				string sUltimaFilial="";

				Globais.CarregaIni(ref sBanco, ref sUltimoUsuario, ref sUltimaFilial);
				string parametros = "User=SYSDBA;" +
									"Password=masterkey;" +
									"Database=" + sBanco;
				Globais.bd = new FbConnection(parametros);
				try {
					Log.Grava(Globais.sUsuario, parametros);
					Globais.bd.Open();
				} catch (Exception err) {
					Log.Grava(Globais.sUsuario, "erro:" + err.Message);
					MessageBox.Show("Erro na conexão com o banco de dados:\n" + sBanco +
				    	            "\n" + err.Message);
					Close();
					return;
				}

				if (login) {
					frmLogin frm = new frmLogin();
					frm.admin = false;
					frm.sUltimoUsuario = sUltimoUsuario;
					frm.sUltimaFilial = sUltimaFilial;
					frm.ShowDialog();
					if (!frm.bOK) {
						Close();
						return;
					} else {
						Globais.GravaIni(sBanco, sUltimoUsuario, sUltimaFilial);
					}
			
					cControleAcesso acesso = new cControleAcesso();
					if (!Globais.bAdministrador &&  !acesso.PermissaoSistema(Globais.sUsuario, Globais.sFilial, 3)) {
						MessageBox.Show("Usuário sem permissão para esse Sistema", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
						Close();
					}
				}
			}

			agenda = new cAgenda();			
			cUsuarios usuarios = new cUsuarios();			
			
			this.Cursor = Cursors.WaitCursor;
			usuarios.Carrega(cbxFiltroUsuarios);
			this.Cursor = Cursors.Default;
			
			cbxFiltroUsuarios.Items.Add("Todos");
			filtro_usuario = "Todos";
			cbxFiltroUsuarios.Text = filtro_usuario;
			
			this.Cursor = Cursors.WaitCursor;
			usuarios.Carrega(cbxFiltroResponsaveis);
			this.Cursor = Cursors.Default;
			cbxFiltroResponsaveis.Items.Add("Todos");
			if (Globais.bAdministrador)
			{
				filtro_responsavel = "Todos";
			}
			else
			{
				filtro_responsavel = Globais.sUsuario.Trim();
			}
			cbxFiltroResponsaveis.Text = filtro_responsavel;
			
			cbxPessoal.Items.Add("Todos");
			cbxPessoal.Items.Add("Somente Pessoais");
			cbxPessoal.Items.Add("Não Pessoais");
			filtro_pessoal = "Não Pessoais";
			cbxPessoal.Text = filtro_pessoal;
			
			filtro_data = System.DateTime.Today.ToString("M/d/yyyy");
			
			cbxPrioridades.Items.Add("0 - Urgente");
			cbxPrioridades.Items.Add("1 - Importante");
			cbxPrioridades.Items.Add("2 - Normal");
			cbxPrioridades.Text = "2 - Normal";
			
			cNaturezas naturezas = new cNaturezas();
			this.Cursor = Cursors.WaitCursor;
			naturezas.Carrega(cbxNaturezas);
			this.Cursor = Cursors.Default;
			
			this.Cursor = Cursors.WaitCursor;			
			naturezas.Carrega(cbxFiltroNaturezas);			
			this.Cursor = Cursors.Default;
			filtro_natureza = "Todas";
			cbxFiltroNaturezas.Items.Add("Todas");			
			cbxFiltroNaturezas.Text = "Todas";
			
			this.Cursor = Cursors.WaitCursor;
			usuarios.Carrega(cbxUsuarios);
			this.Cursor = Cursors.Default;
			cbxUsuarios.Text = Globais.sUsuario;

			InicializaCampos();
			where = MontaFiltro();			

			acao = '?';
			string usuario_agenda="";
			DateTime data_agenda=DateTime.Now;			
			if (fornecedor.Length > 0)
			{
				where = " where 1=2";
				trace.grava("procura agendamento: " + fornecedor + " " + data.ToString("d/M/yyyy") + " " + orcamento.ToString() + " " + pedido.ToString());
				if (cPedidos.LeAgendamento(fornecedor, data, orcamento, pedido, ref usuario_agenda, ref data_agenda))
				{
					trace.grava("agendamento recuperado");
					acao = 'a';
					//where = where + " or ((COD_USUARIO = '" + usuario_agenda +"') and (DAT_AGENDAMENTO = '" + data_agenda.ToString("M/d/yyyy") + "')) ";
					where = " where (COD_USUARIO = '" + usuario_agenda +"') and (DAT_AGENDAMENTO = '" + data_agenda.ToString("M/d/yyyy HH:mm:ss") + "') ";
				}
				else
				{
					trace.grava("novo agendamento");
					acao = 'i';
				}
			}
			if (seqAcao > 0)
			{
				if (usuarioAcao.Length > 0)
				{
					trace.grava("procura agendamento: " + usuarioAcao + " " + data.ToString("d/M/yyyy") + " " + orcamento.ToString() + " " + pedido.ToString());
					acao = 'a';
					usuario_agenda = usuarioAcao;
					data_agenda = data;
					where = " where (COD_USUARIO = '" + usuarioAcao +"') and (DAT_AGENDAMENTO = '" + data_agenda.ToString("M/d/yyyy HH:mm:ss") + "') ";
					trace.grava("procura agendamento: " + where);
				}
				else
				{
					trace.grava("novo agendamento");
					acao = 'i';
				}
			}
			this.Cursor = Cursors.WaitCursor;
			//agenda.Carrega(dgvCadastro, where);
			Carrega();
			trace.grava("agendamentos carregados");
			if ((fornecedor.Length > 0) && (acao == 'a' ) && (dgvCadastro.Rows.Count == 0))
			{
				acao = 'i';
				where = " where 1=2";
				//agenda.Carrega(dgvCadastro, where);		
				Carrega();
			}
			this.Cursor = Cursors.Default;
			col_sorted = "";
			ord_sorted = SortOrder.Ascending;						
			Colore();
			
			SetaEdicaoLocal(false);						
			bool enable = (edtUsuario.Text.Trim().CompareTo(Globais.sUsuario.Trim()) == 0) ||
						  (cbxUsuarios.Text.Trim().CompareTo(Globais.sUsuario.Trim()) == 0);
			btnExclui.Enabled = enable;
			btnAltera.Enabled = enable;
			btnCadAnexos.Enabled = enable;
			btnAbreAnexo.Enabled = enable;			

			if (fornecedor.Length > 0)
			{
				HabilitaEdicao();			
				SetaEdicaoLocal(true);
				if (acao == 'a')
				{
					foreach (DataGridViewRow row in  dgvCadastro.Rows)
					{
						string u = row.Cells[0].Value.ToString();
						DateTime d = DateTime.Parse(row.Cells[1].Value.ToString());
						if ((u.CompareTo(usuario_agenda) == 0) && (d == data_agenda)) 
						{
							row.Cells[0].Selected = true;
							break;
						}
					}
					dtpAgenda.Focus();									
				}
				else
				{
					edtDescricao.Text = "";					
					InicializaCampos();									
					edtPendencia.Text = "Montagem Pedido: " +
								fornecedor + " " +
								data.ToString("d/M/yyyy") + " " +
								orcamento.ToString() + " " +
								nro_pedido.ToString();
					edtParceiro.Text = cliente;
					if (idt_data_prevista.Equals("S"))
						dtpAgenda.Value = data_prevista;
					cbxUsuarios.Text = Globais.sUsuario;			
					edtPendencia.Focus();
				}
			}
				
			if (seqAcao > 0)
			{
				if (seqAcao != 999999) {
					HabilitaEdicao();			
					SetaEdicaoLocal(true);
				}
				if (acao == 'a')
				{
					trace.grava("modo alteracao");
					dtpAgenda.Focus();									
				}
				else
				{
					trace.grava("modo inclusao");
					InicializaCampos();									
					cbxUsuarios.Text = Globais.sUsuario;
					edtParceiro.Text = edtFiltroParceiro.Text;
					edtPendencia.Focus();
				}
			}
		}
		
		void DgvCadastroRowEnter(object sender, DataGridViewCellEventArgs e)
		{
			AtualizaDadosLocal(e.RowIndex);
			bool enable = (edtUsuario.Text.Trim().CompareTo(Globais.sUsuario.Trim()) == 0) ||
						  (cbxUsuarios.Text.Trim().CompareTo(Globais.sUsuario.Trim()) == 0);
			btnExclui.Enabled = enable;
			btnAltera.Enabled = enable;
			btnCadAnexos.Enabled = enable;
			btnAbreAnexo.Enabled = enable;			
		}
		
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			string msg="";
			bool result;
			string pessoal = (ckbPessoal.Checked) ? "S" : "N";
			string cancelado = (ckbCancelado.Checked) ? "S" : "N";			
			
/*
			if (edtParceiro.Text.Trim().CompareTo("") != 0)
			{
				cParceiros parceiros = new cParceiros();
				string des="";
				if (!parceiros.Procura(edtParceiro.Text, ref des))
				{
					MessageBox.Show(edtParceiro.Text, "Parceiro não Cadastrado", 
				                	MessageBoxButtons.OK, 
				                	MessageBoxIcon.Warning);
					edtParceiro.Focus();
					return;				
				}
			}
*/			
			if (!Globais.ValidaCombo(cbxUsuarios, cbxUsuarios.Text, "Responsavel não Cadastrado"))
			{
				cbxUsuarios.Focus();
				return;				
			}

			if (!Globais.ValidaCombo(cbxPrioridades, cbxPrioridades.Text, "Prioridade não Cadastrada"))
			{
				cbxPrioridades.Focus();
				return;				
			}

			if (!Globais.ValidaCombo(cbxNaturezas, cbxNaturezas.Text, "Natureza não Cadastrada"))
			{
				cbxNaturezas.Focus();
				return;				
			}
			
			string natureza = cbxNaturezas.Text.Trim();
			if (natureza.Equals(""))
			{
				MessageBox.Show("Natureza", "Campo obrigatório", 
				                MessageBoxButtons.OK, 
				                MessageBoxIcon.Warning);
				cbxNaturezas.Focus();
				return;
			}

			string parceiro = edtParceiro.Text.Trim();
			string contato = edtContato.Text.Trim();
			if (parceiro.Equals("") && contato.Equals(""))
			{
				MessageBox.Show("Contato", "Campo obrigatório", 
				                MessageBoxButtons.OK, 
				                MessageBoxIcon.Warning);
				edtContato.Focus();
				return;
			}
			
			
			if (acao == 'i')
			{
				if (fornecedor.Length > 0)				
				{
					cPedidos.IncluiAgendamento(fornecedor, data, orcamento, pedido, edtUsuario.Text, dtpCodigo.Value, dtpAgenda.Value);
				}
				result = agenda.Inclui(edtUsuario.Text, 
			                       dtpCodigo.Value,
								   dtpAgenda.Value,
			                       cbxUsuarios.Text,
			                       edtParceiro.Text,
			                       edtContato.Text,
			                       cbxPrioridades.Text.Substring(0, 1),
			                       cbxNaturezas.Text,
			                       edtPendencia.Text,
			                       dtpSolucao.Checked,
			                       dtpSolucao.Value,				                       
			                       edtSolucao.Text,				                       
			                       pessoal,
			                       cancelado,
			                       seqAcao == 999999 ? 0 : seqAcao,
			                       ref msg);
			}
			else
				result = agenda.Altera(edtUsuario.Text,
				                       dtpCodigo.Value,
									   dtpAgenda.Value,
				                       cbxUsuarios.Text,
				                       edtParceiro.Text,
				                       edtContato.Text,
				                       cbxPrioridades.Text.Substring(0, 1),
				                       cbxNaturezas.Text,
				                       edtPendencia.Text,
				                       dtpSolucao.Checked,
				                       dtpSolucao.Value,				                       
				                       edtSolucao.Text,				                       
				                       pessoal,
				                       cancelado,
				                       dtpEncerrado.Checked,
				                       dtpEncerrado.Value,
				                       ref msg);
			if (!result)
			{
				if (acao == 'i')
					MessageBox.Show(msg, "Erro na inclusão da agenda", MessageBoxButtons.OK, MessageBoxIcon.Error);
				else
					MessageBox.Show(msg, "Erro na alteração da agenda", MessageBoxButtons.OK, MessageBoxIcon.Error);				
			}
			
			if (dtpSolucao.Checked) 
			{
				if (fornecedor.Length > 0)
					cPedidos.SolucionaAgendamento(fornecedor, data, orcamento, pedido, dtpSolucao.Value);
				else
					cPedidos.SolucionaAgendamento(edtUsuario.Text, dtpCodigo.Value, dtpSolucao.Value);
			}
					
			this.Cursor = Cursors.WaitCursor;
			//agenda.Carrega(dgvCadastro, where);
			Carrega();
			this.Cursor = Cursors.Default;
			Colore();			

			Grid.Sort(dgvCadastro, col_sorted, ord_sorted);												
			if ((acao == 'a') || (acao == 'A'))
			{
				for (int i=0; i<dgvCadastro.Rows.Count; i++)
				{
					string usuario = dgvCadastro.Rows[i].Cells["Usuário"].Value.ToString().Trim();
					string data = dgvCadastro.Rows[i].Cells["Data Agendamento"].Value.ToString().Trim();

					if (usuario.Equals(usuario_sel) && data.Equals(data_sel))
					{
						dgvCadastro.Rows[i].Cells[0].Selected = true;
						AtualizaDados(i);
						AtualizaDadosLocal(i);				
						break;
					}
				}				
			}
/*			
			int selecionado = Procura(edtUsuario.Text, true);
			if (selecionado >= 0)
			{
				dgvCadastro.Rows[selecionado].Cells[0].Selected = true;
				AtualizaDados(selecionado);
				AtualizaDadosLocal(selecionado);				
			}
*/			
			
			DesabilitaEdicao();
			SetaEdicaoLocal(false);			
		}
		
		void BtnExcluiClick(object sender, EventArgs e)
		{
			string msg="";
			bool result;
			if (acao == 'c') return;
			result = agenda.Exclui(edtUsuario.Text, dtpCodigo.Value, ref msg);
			if (!result)
			{
				MessageBox.Show(edtCodigo.Text, "Erro na exclusão do agendamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			this.Cursor = Cursors.WaitCursor;
			//agenda.Carrega(dgvCadastro, where);
			Carrega();
			this.Cursor = Cursors.Default;
			Colore();			
			if (dgvCadastro.Rows.Count == 0)
			{
				InicializaCampos();
			}
		}
		
		void BtnIncluiClick(object sender, EventArgs e)
		{
			SetaEdicaoLocal(true);
			InicializaCampos();
			cbxUsuarios.Text = Globais.sUsuario;			
			dtpAgenda.Focus();
		}
		
		void BtnAlteraClick(object sender, EventArgs e)
		{
			if (acao == 'c') return;
			if (dgvCadastro.Rows.Count == 0) return;
			int i = dgvCadastro.CurrentRow.Index;									
			usuario_sel = dgvCadastro.Rows[i].Cells["Usuário"].Value.ToString().Trim();
			data_sel = dgvCadastro.Rows[i].Cells["Data Agendamento"].Value.ToString().Trim();
			SetaEdicaoLocal(true);
			dtpAgenda.Focus();
		}
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			if (dgvCadastro.Rows.Count == 0)
			{
				InicializaCampos();
			}
			else
			{
				AtualizaDados(dgvCadastro.CurrentRow.Index);
				AtualizaDadosLocal(dgvCadastro.CurrentRow.Index);				
			}
			SetaEdicaoLocal(false);					
		}
		
		void CbxFiltroUsuariosSelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbxFiltroUsuarios.Text.Trim().CompareTo(filtro_usuario) == 0) return;
			filtro_usuario = cbxFiltroUsuarios.Text.Trim();
			where = MontaFiltro();
			InicializaCampos();
			this.Cursor = Cursors.WaitCursor;
			//agenda.Carrega(dgvCadastro, where);
			Carrega();
			this.Cursor = Cursors.Default;
			Colore();			
			dgvCadastro.Focus();
		}
		
		void CbxPessoalSelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbxPessoal.Text.Trim().CompareTo(filtro_pessoal) == 0) return;
			filtro_pessoal = cbxPessoal.Text.Trim();
			/*
			if (filtro_pessoal.CompareTo("Não Pessoais") != 0)
			{
				cbxFiltroUsuarios.Text = Globais.sUsuario;
				filtro_usuario = cbxFiltroUsuarios.Text.Trim();
				cbxFiltroResponsaveis.Text = Globais.sUsuario;
				filtro_responsavel = cbxFiltroResponsaveis.Text.Trim();
			}
			*/
			where = MontaFiltro();
			InicializaCampos();
			this.Cursor = Cursors.WaitCursor;
			//agenda.Carrega(dgvCadastro, where);
			Carrega();
			this.Cursor = Cursors.Default;
			Colore();			
			dgvCadastro.Focus();			
		}
		
		void CalAgendaDateChanged(object sender, DateRangeEventArgs e)
		{
			string s = calAgenda.SelectionRange.Start.Date.ToString("M/d/yyyy");
			if (s.CompareTo(filtro_data) == 0) return;
			filtro_data = s;
			where = MontaFiltro();
			InicializaCampos();
			this.Cursor = Cursors.WaitCursor;
			//agenda.Carrega(dgvCadastro, where);
			Carrega();
			this.Cursor = Cursors.Default;
			Colore();			
			dgvCadastro.Focus();			
		}
		
		void BtnParceirosClick(object sender, EventArgs e)
		{
			cControleAcesso acesso = new cControleAcesso();
			/*
			if (!acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fConParceiros")) return;				
			frmConParceiros frm = new frmConParceiros();
			frm.ShowDialog();
			if (frm.cancela) return;
			*/
				
			frmCadParceiros frmCad = new frmCadParceiros(true);
			//frmCad.where = frm.filtro;
			frmCad.where = "";
			frmCad.codigo = edtParceiro.Text;
			frmCad.ReadOnly = !acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fCadParceiros");
			frmCad.ShowDialog();
			if (frmCad.result)
			{
				cod_parceiro = frmCad.edtCodigo.Text;
				des_parceiro = frmCad.edtDescricao.Text;
				juridica = frmCad.rbtJuridica.Checked;
				edtParceiro.Text = cod_parceiro;
			}
			//edtParceiro.Focus();
			edtContato.Focus();
		}
		
		void BtnContatosClick(object sender, EventArgs e)
		{
			cControleAcesso acesso = new cControleAcesso();			
			//if (!acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fConParceiros")) return;			
			frmCadContatos frm = new frmCadContatos(true);
			frm.ReadOnly = !acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fCadParceiros");
			frm.parceiro = edtParceiro.Text;
			cParceiros parceiros = new cParceiros();
			string des="", fisjur="";
			parceiros.Procura(edtParceiro.Text, ref des, ref fisjur);
			frm.des_parceiro = des;
			frm.juridica = fisjur.Equals("J");
			frm.ShowDialog();				
			edtContato.Text = frm.edtCodigo.Text;
			edtContato.Focus();
		}
		
		void EdtPendenciaDoubleClick(object sender, EventArgs e)
		{
			frmEditaMemo frm = new frmEditaMemo();
			frm.Text = "Pendência";
			frm.edtMemo.Text = edtPendencia.Text;
			frm.ShowDialog();
			if (frm.ok && edtPendencia.ReadOnly)
			{
				edtPendencia.Text = frm.edtMemo.Text;
			}
		}
		
		void EdtSolucaoDoubleClick(object sender, EventArgs e)
		{
			frmEditaMemo frm = new frmEditaMemo();
			frm.Text = "Solução";
			frm.edtMemo.Text = edtSolucao.Text;
			frm.ShowDialog();
			if (frm.ok && edtPendencia.ReadOnly)
			{
				edtSolucao.Text = frm.edtMemo.Text;
			}
		}
/*		
		void BtnNaturezaClick(object sender, EventArgs e)
		{
			cControleAcesso acesso = new cControleAcesso();			
			if (!acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fCadNaturezas")) return;			
			frmCadNaturezas frm = new frmCadNaturezas();
			frm.ShowDialog();				
			cNaturezas naturezas = new cNaturezas();
			cbxNaturezas.Items.Clear();
			naturezas.Carrega(cbxNaturezas);
			cbxNaturezas.Text = frm.edtCodigo.Text;
			cbxNaturezas.Focus();
		}
*/		
		void BtnCadAnexosClick(object sender, EventArgs e)
		{
			if (dgvCadastro.Rows.Count == 0) return;
			frmAnexos frmCad = new frmAnexos();
			frmCad.usuario = cbxUsuarios.Text;
			frmCad.data_agendamento = dtpCodigo.Value;
			frmCad.ShowDialog();
			CarregaAnexos(edtUsuario.Text.Trim(), dtpCodigo.Value);
			dgvCadastro.Focus();
		}
		
		void AbreAnexo(string codigo)
		{
			string fn = agenda.CarregaAnexo(edtUsuario.Text, dtpCodigo.Value, codigo);
			System.Diagnostics.Process.Start("explorer", fn);
			//File.Delete(fn);
		}
		
		void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			AbreAnexo(linkLabel1.Text);
		}
		
		void LinkLabel2LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			AbreAnexo(linkLabel2.Text);
		}
		
		void LinkLabel3LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			AbreAnexo(linkLabel3.Text);
		}
		
		void LinkLabel4LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			AbreAnexo(linkLabel4.Text);
		}
		
		void LinkLabel5LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			AbreAnexo(linkLabel5.Text);
		}
		
		void LinkLabel6LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			AbreAnexo(linkLabel6.Text);
		}
		
		void LinkLabel7LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			AbreAnexo(linkLabel7.Text);
		}
		
		void LinkLabel8LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			AbreAnexo(linkLabel8.Text);
		}
		
		void EdtParceiroLeave(object sender, EventArgs e)
		{
/*			
			if (edtParceiro.Text.Trim().CompareTo("") != 0)
			{
				cParceiros parceiros = new cParceiros();
				string des="";
				if (!parceiros.Procura(edtParceiro.Text, ref des))
				{
					DialogResult r = MessageBox.Show(edtParceiro.Text, "Cadastrar Parceiro?", 
			                                 	MessageBoxButtons.YesNo, 
			                                 	MessageBoxIcon.Question);
					if (r == DialogResult.Yes) {
						frmCadParceiros frm = new frmCadParceiros();
						frm.codigo = edtParceiro.Text;
						frm.where = "where COD_PARCEIRO like '" + frm.codigo + "'";
						frm.ShowDialog();
					}
					edtParceiro.Focus();
					return;				
				}
			}
*/			
		}
		
		void EdtContatoDoubleClick(object sender, EventArgs e)
		{
/*			
			cContatos contatos = new cContatos();
			string email = contatos.Email(edtParceiro.Text, edtContato.Text);
			System.Diagnostics.Process.Start("explorer", "mailto:" + email);
*/			
		}
		
		void CbxFiltroResponsaveisSelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbxFiltroResponsaveis.Text.Trim().CompareTo(filtro_responsavel) == 0) return;
			filtro_responsavel = cbxFiltroResponsaveis.Text.Trim();
			where = MontaFiltro();
			InicializaCampos();
			this.Cursor = Cursors.WaitCursor;
			//agenda.Carrega(dgvCadastro, where);
			Carrega();
			this.Cursor = Cursors.Default;
			Colore();			
			dgvCadastro.Focus();
		}
		
		void BtnParceirosMouseClick(object sender, MouseEventArgs e)
		{
		}
		
		void BtnEmailClick(object sender, EventArgs e)
		{
			if (dgvCadastro.Rows.Count == 0) return;
			cContatos contatos = new cContatos();
			string email = contatos.Email(edtParceiro.Text, edtContato.Text);
			//System.Diagnostics.Process.Start("explorer", "\"mailto:" + email + "?body=" + edtPendencia.Text + "\"");
			if (edtPendencia.Text.Trim().CompareTo("") == 0)
				System.Diagnostics.Process.Start("\"mailto:" + email.Trim());
			else
				System.Diagnostics.Process.Start("\"mailto:" + email.Trim() + "?body=" + edtPendencia.Text + "\"");			
		}
		
		void ImgClientesClick(object sender, EventArgs e)
		{
			cControleAcesso acesso = new cControleAcesso();
			/*			
			if (!acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fConParceiros")) return;				
			frmConParceiros frm = new frmConParceiros();
			frm.ShowDialog();
			if (frm.cancela) return;
			*/
				
			frmCadParceiros frmCad = new frmCadParceiros(true);
			//frmCad.where = frm.filtro;
			//frmCad.codigo = edtParceiro.Text;
			frmCad.where = "";
			frmCad.codigo = "";
			frmCad.ReadOnly = !acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fCadParceiros");
			frmCad.ShowDialog();
		}
		
		void CbxFiltroNaturezasSelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbxFiltroNaturezas.Text.Trim().CompareTo(filtro_natureza) == 0) return;
			filtro_natureza = cbxFiltroNaturezas.Text.Trim();
			where = MontaFiltro();
			InicializaCampos();
			this.Cursor = Cursors.WaitCursor;
			//agenda.Carrega(dgvCadastro, where);
			Carrega();
			this.Cursor = Cursors.Default;
			Colore();			
			dgvCadastro.Focus();			
		}
		
		void BtnParceiroClick(object sender, EventArgs e)
		{
			cControleAcesso acesso = new cControleAcesso();			
			frmCadParceiros frmCad = new frmCadParceiros(true);
			frmCad.where = "";
			frmCad.codigo = edtParceiro.Text;
			frmCad.ReadOnly = !acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fCadParceiros");
			frmCad.ShowDialog();
			if (frmCad.result)
			{
				edtParceiro.Text = frmCad.edtCodigo.Text;
			}
			edtParceiro.Focus();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			cControleAcesso acesso = new cControleAcesso();			
			frmCadParceiros frmCad = new frmCadParceiros(true);
			frmCad.where = "";
			frmCad.codigo = edtFiltroParceiro.Text;
			frmCad.ReadOnly = !acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fCadParceiros");
			frmCad.ShowDialog();
			if (frmCad.result)
			{
				edtFiltroParceiro.Text = frmCad.edtCodigo.Text;
			}
			edtFiltroParceiro.Focus();
		}
		
		void BtnAplicaClick(object sender, EventArgs e)
		{
			where = MontaFiltro();
			InicializaCampos();
			this.Cursor = Cursors.WaitCursor;
			//agenda.Carrega(dgvCadastro, where);
			Carrega();
			this.Cursor = Cursors.Default;
			Colore();			
			dgvCadastro.Focus();			
		}
		
		void BtnImprimeClick(object sender, EventArgs e)
		{
			fParametrosImpressao frm = new fParametrosImpressao();
			frm.dataInicial = frm.dataFinal = calAgenda.SelectionRange.Start.Date;
			frm.titulo = "Agenda";
			frm.ShowDialog();
			if (!frm.result) return;			
			
			//string pdf = "c:\\softplace\\agenda.pdf";
			string pdf = "agenda.pdf";
			if (agenda.Gera(dgvCadastro, pdf, frm.idtInicial, frm.dataInicial, frm.idtFinal, frm.dataFinal, frm.titulo))
				System.Diagnostics.Process.Start("explorer", pdf);
		}
		
		void DgvCadastroSorted(object sender, EventArgs e)
		{
			col_sorted = dgvCadastro.SortedColumn.HeaderText;
			string s = col_sorted;
			ord_sorted = dgvCadastro.SortOrder;			
			Colore();
		}		
		
		void BtnAbreAnexoClick(object sender, EventArgs e)
		{
			if (dgvAnexos.Rows.Count == 0) return;
			int i = dgvAnexos.CurrentRow.Index;
			AbreAnexo(dgvAnexos.Rows[i].Cells[0].Value.ToString().Trim());									
		}
		
		void BtnAppClick(object sender, EventArgs e)
		{
			Clipboard.SetText(toolTip1.GetToolTip(btnApp));
		}
	}
}
