using System;
using System.Windows.Forms;
using System.Drawing;

namespace classes
{
	public static class Grid
	{
		public static int selecionado;		
		public static int col;				
		private static char dir;		
		private static string COM_ACENTUACAO = "ÁÉÍÓÚÃÕÂÊÔÀÇ";
		private static string SEM_ACENTUACAO = "AEIOUAOAEOAC";
		
		public static void Inicializa()
		{
			selecionado = -1;
			col = 0;
			dir = 'd';
		}
		
		private static string TiraAcentuacao(String s)
		{
			char[] aux = s.ToCharArray();
			for (int i=0; i<aux.Length; i++) 
			{
				int pos = COM_ACENTUACAO.IndexOf(s[i]);
				if (pos >= 0) {
					aux[i] = SEM_ACENTUACAO[pos];
				} else {
					aux[i] = s[i];
				}
			}
			return new string(aux);
		}
	
		private static int ProcuraLinha(DataGridView grid, int lin, string buf)
		{
			string BUF = TiraAcentuacao(buf.ToUpper());
			if (BUF.Equals("*") || BUF.Equals("**"))
			{
				return -1;
			}
			string aux;
			int colVis = col;
			for (col=0; col<grid.Columns.Count; col++)
			{
				bool obsPedido = grid.Columns[col].HeaderText.Equals("Observação")
					&& (col > 0)
					&& grid.Columns[col-1].HeaderText.Equals("IDT Data Real Montagem");
				if (!grid.Columns[col].Visible && !grid.Columns[col].HeaderText.StartsWith("!") && !obsPedido)
				{
					continue;
				}
				string cell = TiraAcentuacao(grid.Rows[lin].Cells[col].Value.ToString().ToUpper().Trim());
				if (BUF.StartsWith("*"))  // *XXXXX*
				{
					aux = BUF.Substring(1, BUF.Length-2);
					if (cell.Contains(aux))
					{
						if (!grid.Rows[lin].Cells[col].Visible)
						{
							col = colVis;
						}
						return lin;
					}
				}
				else  // XXXXX*
				{
					aux = BUF.Substring(0, BUF.Length-1);
					if (cell.StartsWith(aux))
					{
						if (!grid.Rows[lin].Cells[col].Visible)
						{
							col = colVis;
						}						
						return lin;
					}
				}
			}
			col = colVis;
			return -1;
		}		
		
		private static int Procura(DataGridView grid, string buf)
		{
			int r=-1;
			if (!buf.StartsWith("*")) buf = "*" + buf;
			if (selecionado > grid.Rows.Count)
				selecionado = grid.Rows.Count;
			if (dir == 'd')
			{
				for (int lin=selecionado+1; lin<grid.Rows.Count; lin++)
					if ((r = ProcuraLinha(grid, lin, buf)) >= 0) break;
			}
			else
			{
				for (int lin=selecionado-1; lin>=0; lin--)
					if ((r = ProcuraLinha(grid, lin, buf)) >= 0) break;
			}
			return r;
		}			
		
		public static void Localiza(DataGridView grid, string texto)
		{
			//if (selecionado != -1)
			//{
				//grid.Rows[selecionado].Cells[col].Selected = false;
			//}	
			Inicializa();
			if (texto.Length == 0)
			{
				if (grid.Rows.Count == 0) return;
				grid.Rows[0].Cells[0].Selected = true;
				return;
			}
			int lin=-1;
			lin = Procura(grid, texto+"*");
			if (lin >= 0)
			{
				selecionado = lin;
				if (grid.Rows[lin].Cells[col].Visible)
				{
					grid.Rows[lin].Cells[col].Selected = true;
				}
				else
				{
					for (int c=0; c<grid.Rows[lin].Cells.Count; c++)
					{
						if (grid.Rows[lin].Cells[c].Visible)
						{
							grid.Rows[lin].Cells[c].Selected = true;
							col = c;
							break;
						}						
					}
				}
			}			
		}		

		public static void Anterior(DataGridView grid, string texto)
		{
			if (grid.Rows.Count == 0) return;
			int colsel = col;
			dir = 's';
			int lin=-1;
			if (texto.IndexOf('*') == -1)
				lin = Procura(grid, texto+"*");
			else
				lin = Procura(grid, texto);
			if (lin >= 0)
			{
				selecionado = lin;
				grid.Rows[lin].Cells[col].Selected = true;
			}	
			else
			{
				if (selecionado != -1)
				{
					col = colsel;
					grid.Rows[selecionado].Cells[col].Selected = true;
				}
			}
		}		
		
		public static void Proximo(DataGridView grid, string texto)		
		{
			if (grid.Rows.Count == 0) return;
			int colsel = col;
			dir = 'd';
			int lin=-1;
			if (texto.IndexOf('*') == -1)
				lin = Procura(grid, texto+"*");
			else
				lin = Procura(grid, texto);
			if (lin >= 0)
			{
				selecionado = lin;
				grid.Rows[lin].Cells[col].Selected = true;
			}						
			else
			{
				if (selecionado != -1)
				{
					col = colsel;
					grid.Rows[selecionado].Cells[col].Selected = true;
				}
			}			
		}

		public static void Sort(DataGridView grid, string coluna, SortOrder ordem)
		{
			if (coluna.Length > 0)
			{
				foreach (DataGridViewColumn col in grid.Columns)				
				{
					if (col.Visible && col.HeaderText.Equals(coluna))
					{
						grid.Sort(col, ordem == SortOrder.Ascending ?
			    	             System.ComponentModel.ListSortDirection.Ascending :
			        	         System.ComponentModel.ListSortDirection.Descending);
						break;
					}
				}
			}			
		}

		public static void Posiciona(DataGridView grid, string chave)
		{
			for (int i=0; i<grid.Rows.Count; i++)
			{
				string s = grid.Rows[i].Cells["Chave"].Value.ToString();
				if (grid.Rows[i].Cells["Chave"].Value.ToString().Equals(chave))
				{
					grid.Rows[i].Cells[0].Selected = true;
					return;
				}
			}
			if (grid.Rows.Count > 0)
			{
				grid.Rows[0].Cells[0].Selected = true;
			}			
		}

		public static void MarcaSelecionados(DataGridView grid)
		{
			foreach (DataGridViewRow row in grid.Rows)
			{
				if ((bool)row.Cells["S"].Value)
				{
					row.DefaultCellStyle.BackColor = Color.SkyBlue;
				}
				else
				{
					row.DefaultCellStyle.BackColor = Color.White;
				}			
			}			
		}
	}
}
