/*
 * Projeto  : SoftPlace
 * Programa : tCadastroSimples - Template de Cadastro Simples
 * Autor    : Ricardo Costa Xavier
 * Data     : 01/04/08
 * 
 * acao: i - inclui
 *       e - exclui
 *       a - altera
 *       c - cancela
 * 
 * 04/05/2017 - reposicionar por area + produto para itens de orcamento
 * 
 */
using System;
using System.Windows.Forms;

namespace templates
{
	public partial class tCadastroSimples : Form
	{
		public char acao;
		public int selecionado;		
		public char dir;		
		
		public tCadastroSimples()
		{
			InitializeComponent();
		}
		
		public void DesabilitaEdicao()
		{
			edtCodigo.Enabled = false;
			edtDescricao.Enabled = false;
			btnConfirma.Enabled = false;
			btnCancela.Enabled = false;
			btnInclui.Enabled = true;
			btnExclui.Enabled = true;
			btnAltera.Enabled = true;
			btnFecha.Enabled = true;
			dgvCadastro.Enabled = true;
		}
		
		public void HabilitaEdicao()
		{
			edtCodigo.Enabled = true;
			edtDescricao.Enabled = true;
			btnConfirma.Enabled = true;
			btnCancela.Enabled = true;
			btnInclui.Enabled = false;
			btnExclui.Enabled = false;
			btnAltera.Enabled = false;
			btnFecha.Enabled = false;
			dgvCadastro.Enabled = false;
		}		
		
		public void AtualizaDados(int i)
		{
			edtCodigo.Text = dgvCadastro.Rows[i].Cells[0].Value.ToString().Trim();
			edtDescricao.Text = dgvCadastro.Rows[i].Cells[1].Value.ToString().Trim();
		}
		
		public int ProcuraLinha(int i, string buf, bool bSomenteCodigo)
		{
			int cols = bSomenteCodigo ? 1 : dgvCadastro.Columns.Count;
			for (int j=0; j<cols; j++)
			{
				if (!dgvCadastro.Columns[j].Visible && !dgvCadastro.Columns[j].Name.EndsWith("_PESQUISA")) continue;
				string s1 = dgvCadastro.Rows[i].Cells[j].Value.ToString().ToUpper().Trim();
				string s2 = buf.ToUpper().Trim();
				string s3;
				if (s2.StartsWith("*")) 
				{
					if (s2.EndsWith("*")) // *XXXXX*
					{
						s3 = s2.Substring(1, s2.Length-2);
						if (s1.Contains(s3)) return i;
					}
					else // *XXXXX
					{
						s3 = s2.Substring(1, s2.Length-1);
						if (s1.EndsWith(s3)) return i;
					}
				}
				else 
				{
					if (s2.EndsWith("*")) // XXXXX*
					{
						s3 = s2.Substring(0, s2.Length-1);
						if (s1.StartsWith(s3)) return i;
					}
					else // XXXXX
					{
						if (s1.CompareTo(s2) == 0) return i;
					}
				}
			}
			return -1;
		}
		
		public int Procura(string buf, bool bSomenteCodigo)
		{
			int r=-1;
			if (selecionado > dgvCadastro.Rows.Count)
				selecionado = dgvCadastro.Rows.Count;
			if (dir == 'd')
			{
				for (int i=selecionado+1; i<dgvCadastro.Rows.Count; i++)
					if ((r = ProcuraLinha(i, buf, bSomenteCodigo)) >= 0) break;
			}
			else
			{
				for (int i=selecionado-1; i>=0; i--)
					if ((r = ProcuraLinha(i, buf, bSomenteCodigo)) >= 0) break;
			}
			return r;
		}
		
		public int ProcuraLinhaItem(int i, string area, string codigo)
		{
			checked {
				string text0 = this.dgvCadastro.Rows[i].Cells[0].Value.ToString().ToUpper().Trim();
				string text1 = this.dgvCadastro.Rows[i].Cells[2].Value.ToString().ToUpper().Trim();
				if (text0.Equals(area) && text1.Equals(codigo)) {
					return i;
				}
				return -1;
			}
		}
		
		public int ProcuraItem(string area, string codigo)
		{
			int result = -1;
			if (this.selecionado > this.dgvCadastro.Rows.Count) {
				this.selecionado = this.dgvCadastro.Rows.Count;
			}
			checked {
				if (this.dir == 'd') {
					for (int i = this.selecionado + 1; i < this.dgvCadastro.Rows.Count; i++) {
						if ((result = this.ProcuraLinhaItem(i, area, codigo)) >= 0) {
							break;
						}
					}
				}
				else {
					for (int i = this.selecionado - 1; i >= 0; i--) {
						if ((result = this.ProcuraLinhaItem(i, area, codigo)) >= 0) {
							break;
						}
					}
				}
				return result;
			}
		}		
		
		void TCadastroSimplesLoad(object sender, EventArgs e)
		{
			DesabilitaEdicao();
			selecionado = 0;			
			dir = 'd';			
		}
		
		void DgvCadastroRowEnter(object sender, DataGridViewCellEventArgs e)
		{
			AtualizaDados(e.RowIndex);
		}
		
		void BtnIncluiClick(object sender, EventArgs e)
		{
			HabilitaEdicao();			
			edtCodigo.Text = "";
			edtDescricao.Text = "";
			edtCodigo.Focus();
			acao = 'i';				
		}
		
		void BtnAlteraClick(object sender, EventArgs e)
		{
			if (dgvCadastro.Rows.Count == 0) {
				acao = 'c';
				return;
			}
			HabilitaEdicao();
			edtCodigo.Enabled = false;
			edtDescricao.Focus();
			acao = 'a';						
		}
		
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			string codigo = edtCodigo.Text.Trim();			
			if (codigo.CompareTo("") == 0)
			{
				MessageBox.Show(lblCodigo.Text, "Campo obrigatório", 
				                MessageBoxButtons.OK, 
				                MessageBoxIcon.Warning);
				edtCodigo.Focus();
				acao = (acao == 'i') ? 'I' : 'A';
				return;
			}
			string descricao = edtDescricao.Text.Trim();
			if (descricao.CompareTo("") == 0)
			{
				MessageBox.Show(lblDescricao.Text, "Campo obrigatório", 
				                MessageBoxButtons.OK, 
				                MessageBoxIcon.Warning);
				edtDescricao.Focus();
				acao = (acao == 'i') ? 'I' : 'A';
				return;
			}
		}
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			DesabilitaEdicao();				
		}
		
		void BtnFechaClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void BtnExcluiClick(object sender, EventArgs e)
		{
			if (dgvCadastro.Rows.Count == 0) {
				acao = 'c';
				return;
			}
			DialogResult r = MessageBox.Show(edtCodigo.Text, "Confirma a exclusão?", 
			                                 MessageBoxButtons.YesNo, 
			                                 MessageBoxIcon.Question);
			if (r == DialogResult.No) {
				acao = 'c';
				return;
			}
			acao = 'e';
		}
		
		void BtnLocalizaClick(object sender, EventArgs e)
		{
			int i = Procura(edtLocaliza.Text, false);
			if (i >= 0)
			{
				dgvCadastro.Rows[i].Cells[0].Selected = true;
			}
		}
				
		void BtnDownClick(object sender, EventArgs e)
		{
			if (dgvCadastro.Rows.Count == 0) return;
			selecionado = dgvCadastro.CurrentRow.Index;						
			dir = 'd';
			int i=-1;
			if (edtLocaliza.Text.IndexOf('*') == -1)
				i = Procura("*"+edtLocaliza.Text+"*", false);
			else
				i = Procura(edtLocaliza.Text, false);
			if (i >= 0)
			{
				dgvCadastro.Rows[i].Cells[1].Selected = true;
			}
		}
		
		void BtnUpClick(object sender, EventArgs e)
		{
			if (dgvCadastro.Rows.Count == 0) return;
			selecionado = dgvCadastro.CurrentRow.Index;						
			dir = 's';
			int i=-1;
			if (edtLocaliza.Text.IndexOf('*') == -1)
				i = Procura("*"+edtLocaliza.Text+"*", false);
			else
				i = Procura(edtLocaliza.Text, false);
			if (i >= 0)
			{
				dgvCadastro.Rows[i].Cells[1].Selected = true;
			}
		}
		
		void EdtLocalizaTextChanged(object sender, EventArgs e)
		{
			selecionado = 0;
			dir = 'd';
			if (edtLocaliza.Text.Trim().Length == 0)
			{
				if (dgvCadastro.Rows.Count == 0) return;
				dgvCadastro.Rows[0].Cells[1].Selected = true;
				return;
			}
			int i=-1;
			string texto = edtLocaliza.Text;
			if (texto.IndexOf('*') == -1)
			{
				texto = "*" + texto.Trim() + "*";
			}
			i = Procura(texto, false);
			if (i >= 0)
			{
				selecionado = i;
				for (int c=1; c<dgvCadastro.Rows[i].Cells.Count; c++)
				{
					if (dgvCadastro.Rows[i].Cells[c].Visible)
					{
						dgvCadastro.Rows[i].Cells[c].Selected = true;
						break;
					}
				}
			}
		}
	}
}
