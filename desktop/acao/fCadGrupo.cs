using System;
using System.Windows.Forms;
using System.Data;

namespace acao
{
	public partial class fCadGrupo : Form
	{
		private int seq;
		
		public fCadGrupo(int seq)
		{
			this.seq = seq;
			InitializeComponent();
			this.Cursor = Cursors.WaitCursor;
			string where = "";			
			if (seq != 0)
			{
				where = "where SEQ_ACAO = " + seq;
			}			
			AcaoDAO.ClientesAcao(dgvClientes, where);
			this.Cursor = Cursors.Default;
		}
		
		void BtnAplicaClick(object sender, EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			string where = "where COD_PARCEIRO not in (select COD_CLIENTE from CLIENTES_ACAO "
					+ "where SEQ_ACAO = " + seq + ")";
			string filtro=edtFiltro.Text.Trim();
			if (!filtro.Equals(""))
			{
				where += " and ( COD_PARCEIRO like '%" + filtro + "%' " +
					" or NRO_CPF_CNPJ like '%" + filtro + "%' )";
			}
			AcaoDAO.ClientesDisponiveis(dgvDisponiveis, where);
			this.Cursor = Cursors.Default;
		}
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			AcaoDAO.AtualizaClientesAcao(seq, dgvClientes);
			Close();
		}
		
		void BtnIncluiClick(object sender, EventArgs e)
		{
			if (dgvDisponiveis.Rows.Count == 0)
			{
				return;
			}
			int i = dgvDisponiveis.CurrentRow.Index;
			DataTable tab = (DataTable)dgvClientes.DataSource;
			if (tab == null)
			{
				tab = new DataTable();
				tab.Clear();
				tab.Columns.Add("Cliente");
				tab.Columns.Add("Cpf/Cnpj");
				dgvClientes.DataSource = tab;
			}
			
			int outraAcao = AcaoDAO.AcaoCliente(dgvDisponiveis.Rows[i].Cells[0].Value.ToString().Trim());
			if (outraAcao != 0) 
			{
				MessageBox.Show("Já existe outra ação para esse cliente\r\n" + outraAcao, "Aviso",  
		    	            MessageBoxButtons.OK, 
		    	            MessageBoxIcon.Warning);		
			}
			
			string[] row = new string[] { dgvDisponiveis.Rows[i].Cells[0].Value.ToString(), 
				dgvDisponiveis.Rows[i].Cells[1].Value.ToString()};
			tab.Rows.Add(row);
			dgvDisponiveis.Rows.Remove(dgvDisponiveis.CurrentRow);
		}
		
		void BtnIncluiTodosClick(object sender, EventArgs e)
		{
			if (dgvDisponiveis.Rows.Count == 0)
			{
				return;
			}
			DataTable tab = (DataTable)dgvClientes.DataSource;
			if (tab == null)
			{
				tab = new DataTable();
				tab.Clear();
				tab.Columns.Add("Cliente");
				tab.Columns.Add("Cpf/Cnpj");
				dgvClientes.DataSource = tab;
			}			
			for (int i=0; i<dgvDisponiveis.Rows.Count; i++)
			{
				
				int outraAcao = AcaoDAO.AcaoCliente(dgvDisponiveis.Rows[i].Cells[0].Value.ToString().Trim());
				if (outraAcao != 0) 
				{
					MessageBox.Show("Já existe outra ação para esse cliente\r\n" + outraAcao, "Aviso",  
			    	            MessageBoxButtons.OK, 
			    	            MessageBoxIcon.Warning);		
				}
				
				string[] row = new string[] { dgvDisponiveis.Rows[i].Cells[0].Value.ToString(), 
					dgvDisponiveis.Rows[i].Cells[1].Value.ToString()};
				tab.Rows.Add(row);
			}
			while (dgvDisponiveis.Rows.Count > 0)
			{
				dgvDisponiveis.Rows.RemoveAt(0);
			}
		}
		
		void BtnExcluiClick(object sender, EventArgs e)
		{
			if (dgvClientes.Rows.Count == 0)
			{
				return;
			}
			int i = dgvClientes.CurrentRow.Index;
			DataTable tab = (DataTable)dgvDisponiveis.DataSource;
			if (tab == null)
			{
				tab = new DataTable();
				tab.Clear();
				tab.Columns.Add("Cliente");
				tab.Columns.Add("Cpf/Cnpj");
				dgvDisponiveis.DataSource = tab;
			}			
			string[] row = new string[] { dgvClientes.Rows[i].Cells[0].Value.ToString(), 
				dgvClientes.Rows[i].Cells[1].Value.ToString()};
			tab.Rows.Add(row);
			dgvClientes.Rows.Remove(dgvClientes.CurrentRow);
		}
		
		void BtnExcluiTodosClick(object sender, EventArgs e)
		{
			if (dgvClientes.Rows.Count == 0)
			{
				return;
			}
			DataTable tab = (DataTable)dgvDisponiveis.DataSource;
			if (tab == null)
			{
				tab = new DataTable();
				tab.Clear();
				tab.Columns.Add("Cliente");
				tab.Columns.Add("Cpf/Cnpj");
				dgvDisponiveis.DataSource = tab;
			}			
			for (int i=0; i<dgvClientes.Rows.Count; i++)
			{
				string[] row = new string[] { dgvClientes.Rows[i].Cells[0].Value.ToString(), 
					dgvClientes.Rows[i].Cells[1].Value.ToString()};
				tab.Rows.Add(row);
			}
			while (dgvClientes.Rows.Count > 0)
			{
				dgvClientes.Rows.RemoveAt(0);
			}	
		}
	}
}
