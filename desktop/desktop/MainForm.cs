/*

2.0 24/03/19
- não abrir outra conexão ao chamar o form da agenda a partir de outro executável (sem passar pelo main)
- retirada do parâmetro sSession (não estava sendo usado e provocava erro ao chamar a agenda pelo desktop e depois chamar o pagar) 

2.1 28/04/19
- não deixar alterar os itens de um orçamento que tem pedido

 */
using System;
using System.IO;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using classes;
using templates;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using acao;
using agenda;

namespace desktop
{
	public partial class MainForm : Form
	{
		private string sBanco;
		private string sUltimoUsuario;
		private string sUltimaFilial;
		private string[] comandos;
		private System.Windows.Forms.Timer timer;
		private string col_sorted;
		private SortOrder ord_sorted;		
		
		[STAThread]
		public static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
		private void ConectaBanco()
		{
			// carrega dados do último acesso
			XmlDocument xml = new XmlDocument();
			xml.Load("soft.xml");		
			XmlNodeList list;
			XmlNode node;
			list = xml.GetElementsByTagName("BancoDados");			
			node = list[0];
			sBanco = node.InnerText;
			Globais.sBanco = sBanco;
			list = xml.GetElementsByTagName("UltimoUsuario");			
			node = list[0];
			sUltimoUsuario = node.InnerText;
			list = xml.GetElementsByTagName("UltimaFilial");			
			node = list[0];
			sUltimaFilial = node.InnerText;
			
			// conecta ao banco
			string parametros = "User=SYSDBA;" +
								"Password=masterkey;" +
								"Database=" + sBanco;
			Globais.bd = new FbConnection(parametros);
			try
			{
				Log.Grava(Globais.sUsuario, parametros);
				Globais.bd.Open();
				//Trace.Verifica();
			}
			catch (Exception err)
			{
				Log.Grava(Globais.sUsuario, "erro:" + err.Message);
				MessageBox.Show("Erro na conexão com o banco de dados:\n" + sBanco +
				                "\n" + err.Message);
				Close();
			}						
		}
		
		public MainForm()
		{
			InitializeComponent();
			Grid.Inicializa();
			if (File.Exists("imagens\\logo1.jpg"))
				imgLogo.Image = Image.FromFile("imagens\\logo1.jpg");
			/*
			int x1 = imgLogo.Width;
			int y1 = imgLogo.Height;;
			int x2 = imgLogo.Image.Width;
			int y2 = imgLogo.Image.Height;
			if (x2 > x1) {
				int x = x2 - x1;
				imgLogo.Left -= x;
				imgLogo.Width += x;
			}
			if (y2 > y1) {
				int y = y2 - y1;
				imgLogo.Height += y;
			}
			x1 = imgLogo.Width;
			y1 = imgLogo.Height;;
			*/
			
			ConectaBanco();
			CarregaTabelaPrecos();
			comandos = new string[10];
		}
		
		void CarregaTabelaPrecos() {
			/*
			StreamReader stream = new StreamReader("c:\\temp\\classica.txt");
			StreamWriter saida = new StreamWriter("c:\\temp\\saida.txt");
			string linha;
			while ((linha = stream.ReadLine()) != null) 
			{
				string[] partes = linha.Split('\t');
				string codigo;
				string subcod;
				string preco;
				
				int t = partes[0].Length;
				codigo = partes[0].Substring(0, t-1);
				subcod = partes[0].Substring(t-1);
				preco = partes[2].Replace(".", "").Replace(",", ".");				
				
				string sql = "update PRECOS set " +
						 "VLR_PRECO=" + preco + " " +
				    	 "where COD_PARCEIRO='CLASSICA DESIGN' and " +
				    	 "      COD_TABELA='2016' and " +
				    	 "      COD_PRODUTO='" + codigo + "' and " +
				    	 "      SUB_CODIGO='" + subcod + "'";
				FbCommand cmd = new FbCommand(sql, Globais.bd);
				int n = cmd.ExecuteNonQuery();
				if (n != 1)
				{
					codigo = partes[0];
					subcod = "-";
					string sql2 = "update PRECOS set " +
						 "VLR_PRECO=" + preco + " " +
				    	 "where COD_PARCEIRO='CLASSICA DESIGN' and " +
				    	 "      COD_TABELA='2016' and " +
				    	 "      COD_PRODUTO='" + codigo + "' and " +
				    	 "      SUB_CODIGO='" + subcod + "'";
					FbCommand cmd2 = new FbCommand(sql2, Globais.bd);
					n = cmd2.ExecuteNonQuery();
					if (n != 1)
					{
						codigo = partes[0].Substring(0, t-2);
						subcod = partes[0].Substring(t-2);
						string sql3 = "update PRECOS set " +
							 "VLR_PRECO=" + preco + " " +
					    	 "where COD_PARCEIRO='CLASSICA DESIGN' and " +
					    	 "      COD_TABELA='2016' and " +
					    	 "      COD_PRODUTO='" + codigo + "' and " +
					    	 "      SUB_CODIGO='" + subcod + "'";
						FbCommand cmd3 = new FbCommand(sql3, Globais.bd);
						n = cmd3.ExecuteNonQuery();
						if (n != 1)
						{
							saida.WriteLine(linha);
						}

					}
				}
			}
			stream.Close();
			saida.Close();
			*/
		}
		
		void MainFormShown(object sender, EventArgs e)
		{			
			// login
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
			lblUsuario.Text = "Usuário: " + Globais.sUsuario;
			lblFilial.Text = "Filial: " + Globais.sFilial;

			// verifica atualizações
			cAtualizador atualizador = new cAtualizador();
			atualizador = null;
			
			lblAvisos.Visible = true;
			cAvisos avisos = new cAvisos();
			avisos.Processa(lblAvisos);			
			lblAvisos.Visible = false;
				
			// regrava dados do último acesso
			XmlDocument xml = new XmlDocument();
			xml.Load("soft.xml");		
			XmlNodeList list;
			XmlNode node;
			list = xml.GetElementsByTagName("UltimoUsuario");			
			node = list[0];
			node.InnerText = Globais.sUsuario;
			list = xml.GetElementsByTagName("UltimaFilial");			
			node = list[0];
			node.InnerText = Globais.sFilial;
			xml.Save("soft.xml");
			
			Button[] botoes = new Button[10];
			cSistemas sistemas = new cSistemas();
			ArrayList lista = sistemas.ListaAcesso(Globais.bAdministrador, Globais.sUsuario, Globais.sFilial);
			int y=10;
			int b=0;
			for (int i=0; i<lista.Count; i+=2)
			{
				botoes[b] = new Button();
				botoes[b].SetBounds(10, y, 200, 25);
				botoes[b].Text = lista[i].ToString();
				this.Controls.Add(botoes[b]);			
				botoes[b].TabIndex = b;
				botoes[b].Click += new System.EventHandler(this.Button1Click);
				comandos[b] = lista[i+1].ToString();
				y += 30;
				b++;
			}
			
			/*
			int y2Imagem = imgLogo.Top + imgLogo.Height + 10;
			if (y < y2Imagem) 
				y = y2Imagem;
			int y1Aniversariantes = lblAniversariantes.Top;
			int dif = y1Aniversariantes - y;
			if (dif > 0) {
				lblAniversariantes.Top -= dif;
				dgvAniversariantes.Top -= dif;
				lblAgenda.Top -= dif;
				dgvHistorico.Top -= dif;
				tbPendencia.Top -= dif;
				this.Height -= dif;
			}
			*/
			
			string sql = "select " +
				"COD_PARCEIRO,COD_PARCEIRO,extract(day from DAT_NASCIMENTO),'P',IDT_CLIENTE,IDT_CONSULTOR,IDT_FORNECEDOR,IDT_FISJUR from PARCEIROS " +
				"where IDT_FISJUR='F' and extract(month from DAT_NASCIMENTO) = " + DateTime.Now.Month.ToString() +
				" union select " +
				"COD_CONTATO,COD_PARCEIRO,extract(day from DAT_NASCIMENTO),'C','N','N','N','?' from CONTATOS " +
				"where extract(month from DAT_NASCIMENTO) = " + DateTime.Now.Month.ToString() +
				" union select " +
				"NOM_FUNCIONARIO,' ',extract(day from DAT_NASCIMENTO),'F','N','N','N','?' from FUNCIONARIOS " +
				"where extract(month from DAT_NASCIMENTO) = " + DateTime.Now.Month.ToString();
			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			adapter.SelectCommand = new FbCommand(sql, Globais.bd);
			adapter.Fill(table);
			dgvAniversariantes.DataSource = table;
			
			table.Columns[0].ColumnName = "Nome";
			table.Columns[1].ColumnName = "Empresa";
			table.Columns[2].ColumnName = "Dia";
			table.Columns[3].ColumnName = "Tipo";
			dgvAniversariantes.Columns[4].Visible = false;
			dgvAniversariantes.Columns[5].Visible = false;
			dgvAniversariantes.Columns[6].Visible = false;
			dgvAniversariantes.Columns[7].Visible = false;
			dgvAniversariantes.Columns["Empresa"].Width = 60;
			dgvAniversariantes.Columns["Dia"].Width = 20;
			dgvAniversariantes.Columns["Tipo"].Width = 90;
			
			foreach (DataGridViewRow row in dgvAniversariantes.Rows)
			{
				if (row.Cells[3].Value.ToString().Equals("P")) {
					if (row.Cells[7].Value.ToString().Equals("F"))
						row.Cells[1].Value = "";
					if (row.Cells[4].Value.ToString().Equals("S"))
						row.Cells[3].Value = "Cliente";
					if (row.Cells[5].Value.ToString().Equals("S")) {						
						if (row.Cells[4].Value.ToString().Equals("S"))
						{
							row.Cells[3].Value = "Cliente/Consultor";
						}
						else				
							row.Cells[3].Value = "Consultor";
					}
					if (row.Cells[6].Value.ToString().Equals("S"))
						row.Cells[3].Value = "Fornecedor";
				}
				if (row.Cells[3].Value.ToString().Equals("C")) {
					row.Cells[3].Value = "Contato";
				}
				if (row.Cells[3].Value.ToString().Equals("F")) {
					row.Cells[3].Value = "Funcionário";
				}								
			}			
			dgvAniversariantes.Sort(dgvAniversariantes.Columns[2], System.ComponentModel.ListSortDirection.Ascending);
/*			
			StreamWriter sw = new StreamWriter(new FileStream("c:\\softplace\\teste.sql", FileMode.Create));
			sw.WriteLine(table.Rows.Count);
			sw.WriteLine(sql);
			sw.Close();
*/			
				
			
			//this.Height = y + 40;			
			//if (this.Height < 266) this.Height = 266;

			timer = new System.Windows.Forms.Timer();
			timer.Interval = 60000;
			timer.Tick += new EventHandler(EventoTimer);
			timer.Start();
 
			CarregaHistorico();
			col_sorted = "";
			ord_sorted = SortOrder.Ascending;			
			tbMensagem.Text = cMensagens.UltimaMensagem();
			
		}
		
		void EventoTimer(object sender, EventArgs e) {
			if (this.ContainsFocus)
			{
				//MessageBox.Show("carrega");
				if ((dgvHistorico != null) && (dgvHistorico.CurrentRow != null))
				{
					int i = dgvHistorico.CurrentRow.Index;
					CarregaHistorico();
					Grid.Sort(dgvHistorico, col_sorted, ord_sorted);
					if (i >= 0)
					{
						if ((dgvHistorico != null) && (dgvHistorico.Rows != null)
						    && (dgvHistorico.Rows.Count > i)) 
						{
							dgvHistorico.Rows[i].Cells[1].Selected = true;
						}
					}
				}
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			string adm =  Globais.bAdministrador ? "S" : "N";
			int i = ((Button)sender).TabIndex;
			System.Diagnostics.Process.Start(comandos[i], Globais.sUsuario + " " + Globais.sFilial + " " + adm);
		}
		
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
		}
		
		void CarregaHistorico()
		{
			this.Cursor = Cursors.WaitCursor;
			AcaoDAO.CarregaHistoricoPorUsuario(dgvHistorico, Globais.sUsuario);
			Colore();
			this.Cursor = Cursors.Default;
		}		
		
		void DgvHistoricoRowEnter(object sender, DataGridViewCellEventArgs e)
		{
			string pendencia = dgvHistorico.Rows[e.RowIndex].Cells["Pendência"].Value.ToString();
			tbPendencia.Text = pendencia;
		}	
		
		void Colore()
		{
			foreach (DataGridViewRow row in  dgvHistorico.Rows)
			{
				DataGridViewCell cell = row.Cells["Situação"];		
				DateTime dt = DateTime.Parse(row.Cells["Previsão"].Value.ToString());
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
		}
		
		void DgvHistoricoSorted(object sender, EventArgs e)
		{
			col_sorted = dgvHistorico.SortedColumn.HeaderText;
			ord_sorted = dgvHistorico.SortOrder;			
			Colore();
		}
		
		void DgvHistoricoMouseDoubleClick(object sender, MouseEventArgs e)
		{
			DataGridView.HitTestInfo hti = dgvHistorico.HitTest(e.X, e.Y);
			if (hti.RowIndex == -1)
			{
				return;
			}
			int i = hti.RowIndex;
			string[] args = new string[6];
			args[0] = Globais.sUsuario;
			args[1] = Globais.sFilial;
			args[2] = Globais.bAdministrador ? "S" : "N";			
			string usuario = dgvHistorico.Rows[i].Cells["CodUsuario"].Value.ToString().Trim();
			DateTime data = DateTime.Parse(dgvHistorico.Rows[i].Cells["Agendamento"].Value.ToString());
			args[3] = usuario;
			args[4] = data.ToString().Trim();
			args[5] = "999999";
			frmAgenda frm = new frmAgenda(args);
			frm.ShowDialog();
			//CarregaHistorico();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			//CarregaHistorico();
		}
		
		void MainFormActivated(object sender, EventArgs e)
		{
			//CarregaHistorico();
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
	}
}
