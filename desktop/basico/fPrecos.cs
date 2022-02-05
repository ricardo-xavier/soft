/*
 * Projeto  : SoftPlace
 * Sistema  : CPD
 * Programa : fPrecos - Manutencao de Precos
 * Autor    : Ricardo Costa Xavier
 * Data     : 27/04/08
 */
using System;
using System.Windows.Forms;
using classes;

namespace basico
{
	public partial class frmPrecos : Form
	{
		public string parceiro;
		public string tabela;
		//private string valor;
		cTabelas tabelas;
		
		public frmPrecos()
		{
			InitializeComponent();
		}
		
		void FrmPrecosLoad(object sender, EventArgs e)
		{
			tabelas = new cTabelas();
			tabelas.CarregaPrecos(dgvCadastro, parceiro, tabela);
		}
		
		void BtnConfirmaClick(object sender, EventArgs e)
		{
/*			
			string codigo, sub_codigo, msg="", vlr1, vlr2;
			foreach (DataGridViewRow row in dgvCadastro.Rows)
			{
				vlr1 = row.Cells["Valor"].Value.ToString();
				vlr2 = row.Cells["Novo Valor"].Value.ToString();
				if (!vlr1.Equals(vlr2))
				{
					codigo = row.Cells["Código"].Value.ToString().Trim();
					sub_codigo = row.Cells["Sub-Código"].Value.ToString().Trim();
					vlr2.Replace(',', '.');
					tabelas.AlteraValor(parceiro, tabela, codigo, sub_codigo, vlr2, ref msg);
				}
			}
*/			
			Close();
		}
		
		public int Procura(string buf, bool bSomenteCodigo)
		{
			int i, j, cols;
			cols = bSomenteCodigo ? 1 : dgvCadastro.Columns.Count;
			for (i=0; i<dgvCadastro.Rows.Count; i++)
			{
				for (j=0; j<cols; j++)
				{
					string s1 = dgvCadastro.Rows[i].Cells[j].Value.ToString().ToUpper().Trim();
					string s2 = buf.ToUpper().Trim();
					string s3;
					if (s2.StartsWith("*")) 
					{
						if (s2.EndsWith("*")) // *XXXXX*
						{
							s3 = s2.Substring(1, s2.Length-2);
							if (s1.Contains(s3))
							{
								return i;
							}
						}
						else // *XXXXX
						{
							s3 = s2.Substring(1, s2.Length-1);
							if (s1.EndsWith(s3))
							{
								return i;
							}
						}
					}
					else 
					{
						if (s2.EndsWith("*")) // XXXXX*
						{
							s3 = s2.Substring(0, s2.Length-1);
							if (s1.StartsWith(s3))
							{
								return i;
							}
						}
						else // XXXXX
						{
							if (s1.CompareTo(s2) == 0)
							{
								return i;
							}
						}
					}
				}
			}
			return -1;
		}		
		
		void BtnLocalizaClick(object sender, EventArgs e)
		{
			int i = Procura(edtLocaliza.Text, false);
			if (i >= 0)
			{
				dgvCadastro.Rows[i].Cells["Código"].Selected = true;
			}
		}

		void DgvCadastroCellLeave(object sender, DataGridViewCellEventArgs e)
		{
/*
			string novo_valor;
			novo_valor = dgvCadastro.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
			MessageBox.Show("DgvCadastroCellLeave: " + valor + " " + novo_valor);
			if (!novo_valor.Equals(valor))
			{
				string codigo = dgvCadastro.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
				string sub_codigo = dgvCadastro.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
				string msg="";
				tabelas.AlteraValor(parceiro, tabela, codigo, sub_codigo, novo_valor, ref msg);
			}
*/			
		}
		
		void DgvCadastroCellEnter(object sender, DataGridViewCellEventArgs e)
		{
/*
			valor = dgvCadastro.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
*/			
		}
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void DgvCadastroRowLeave(object sender, DataGridViewCellEventArgs e)
		{
/*			
			string codigo, sub_codigo, msg="", vlr1, vlr2;
			DataGridViewRow row = dgvCadastro.Rows[e.RowIndex];
			vlr1 = row.Cells["Valor"].Value.ToString();
			vlr2 = row.Cells["Novo Valor"].Value.ToString();
			MessageBox.Show("DgvCadastroRowLeave: " + vlr1 + " " + vlr2);
			if (!vlr1.Equals(vlr2))
			{
				codigo = row.Cells["Código"].Value.ToString().Trim();
				sub_codigo = row.Cells["Sub-Código"].Value.ToString().Trim();
				vlr2.Replace(',', '.');
				tabelas.AlteraValor(parceiro, tabela, codigo, sub_codigo, vlr2, ref msg);
			}
*/			
		}
		
		void DgvCadastroCellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			string codigo, sub_codigo, msg="", vlr1, vlr2;
			DataGridViewRow row = dgvCadastro.Rows[e.RowIndex];
			vlr1 = row.Cells["Valor"].Value.ToString();
			vlr2 = row.Cells["Novo Valor"].Value.ToString();
			//MessageBox.Show("DgvCadastroCellEndEdit: " + vlr1 + " " + vlr2);
			if (!vlr1.Equals(vlr2))
			{
				codigo = row.Cells["Código"].Value.ToString().Trim();
				sub_codigo = row.Cells["Sub-Código"].Value.ToString().Trim();
				vlr2.Replace(',', '.');
				tabelas.AlteraValor(parceiro, tabela, codigo, sub_codigo, vlr2, ref msg);
				if (!msg.Equals("OK")) 
					MessageBox.Show(msg);
			}			
		}
	}
}
