/*
 * Projeto  : SoftPlace
 * Sistema  : CPD
 * Programa : fCadTabelas - Cadastro de Tabelas de Precos
 * Autor    : Ricardo Costa Xavier
 * Data     : 27/04/08
 */
using System;
using System.Windows.Forms;
using templates;
using classes;

namespace basico
{
	public partial class frmCadTabelas : tCadastroSimples
	{
		private cTabelas tabelas;
		private string col_sorted;
		private SortOrder ord_sorted;	
		
		void AlteraComponentes()
		{
			edtParceiro.CharacterCasing = CharacterCasing.Upper;			
			edtCodigo.CharacterCasing = CharacterCasing.Upper;
			dgvCadastro.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCadastroRowEnter);
			dgvCadastro.Sorted += new System.EventHandler(this.DgvCadastroSorted);
			btnFecha.Top += 30;
			btnFecha.TabIndex = 7;
			btnPrecos.Top -= 30;
			btnPrecos.TabIndex = 6;			
			dgvCadastro.Width += 200;
		}
		
		void InicializaCampos()
		{
			edtParceiro.Text = "";			
			edtCodigo.Text = "";
			edtDescricao.Text = "";
			ckbDefault.Checked = false;
			chkAtivo.Checked = true;
		}				
		
		public void SetaEdicaoLocal(bool enabled)
		{
			edtParceiro.Enabled = enabled;			
			btnParceiros.Enabled = enabled;						
			edtCodigo.Enabled = enabled;
			edtDescricao.Enabled = enabled;
			ckbDefault.Enabled = enabled;
			chkAtivo.Enabled = enabled;
		}
		
		public void AtualizaDadosLocal(int i)
		{
			edtParceiro.Text = dgvCadastro.Rows[i].Cells[0].Value.ToString().Trim();			
			edtCodigo.Text = dgvCadastro.Rows[i].Cells[1].Value.ToString().Trim();			
			edtDescricao.Text = dgvCadastro.Rows[i].Cells[2].Value.ToString().Trim();
			ckbDefault.Checked = dgvCadastro.Rows[i].Cells[3].Value.ToString().Trim() == "S";	
			chkAtivo.Checked = dgvCadastro.Rows[i].Cells[4].Value.ToString().Trim() == "S";
		}
		
		public frmCadTabelas()
		{
			col_sorted = "";
			ord_sorted = SortOrder.Ascending;
			InitializeComponent();
			AlteraComponentes();				
		}
		
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			string msg="";
			bool result;
			string parceiro = edtParceiro.Text.Trim();
			string codigo = edtCodigo.Text.Trim();
			string idt_default = ckbDefault.Checked ? "S" : "N";
			string idt_ativo = chkAtivo.Checked ? "S" : "N";
			if (edtParceiro.Text.Trim().Equals(""))
			{
				cParceiros parceiros = new cParceiros();
				string des="", fisjur="";
				if (!parceiros.Procura(edtParceiro.Text, ref des, ref fisjur))
				{
					MessageBox.Show(edtParceiro.Text, "Parceiro não Cadastrado", 
				                	MessageBoxButtons.OK, 
				                	MessageBoxIcon.Warning);
					edtParceiro.Focus();
					return;				
				}
			}
			if (acao == 'I') 
			{
				acao = 'i';
				return;
			}
			if (acao == 'A') 
			{
				acao = 'a';
				return;
			}			
			if (acao == 'i')
				result = tabelas.Inclui(parceiro, codigo, edtDescricao.Text, idt_default, idt_ativo, ref msg);
			else
				result = tabelas.Altera(parceiro, codigo, edtDescricao.Text, idt_default, idt_ativo, ref msg);
			if (!result)
			{
				if (acao == 'i')
					MessageBox.Show(codigo+"\n"+msg, "Erro na inclusão da tabela", MessageBoxButtons.OK, MessageBoxIcon.Error);
				else
					MessageBox.Show(codigo+"\n"+msg, "Erro na alteração da tabela", MessageBoxButtons.OK, MessageBoxIcon.Error);				
			}
			this.Cursor = Cursors.WaitCursor;
			tabelas.Carrega(dgvCadastro, chkAtivos.Checked);
			Grid.Sort(dgvCadastro, col_sorted, ord_sorted);									
			this.Cursor = Cursors.Default;
			int selecionado = Procura(parceiro, codigo);
			if (selecionado >= 0)
			{
				dgvCadastro.Rows[selecionado].Cells[0].Selected = true;
				AtualizaDados(selecionado);
				AtualizaDadosLocal(selecionado);				
			}
			DesabilitaEdicao();
			SetaEdicaoLocal(false);			
		}
		
		void BtnExcluiClick(object sender, EventArgs e)
		{
			string msg="";
			bool result;
			if (acao == 'c') return;
			string parceiro = edtParceiro.Text.Trim();
			string codigo = edtCodigo.Text.Trim();
			result = tabelas.Exclui(parceiro, codigo, ref msg);
			if (!result)
			{
				MessageBox.Show(parceiro + "-" + codigo + "\r\n" + Globais.ErroExclusao("Tabela encontrada", msg), "Erro na exclusão da tabela", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			this.Cursor = Cursors.WaitCursor;
			tabelas.Carrega(dgvCadastro, chkAtivos.Checked);
			Grid.Sort(dgvCadastro, col_sorted, ord_sorted);									
			this.Cursor = Cursors.Default;
			if (dgvCadastro.Rows.Count == 0)
			{
				InicializaCampos();
			}
		}
		
		void FrmCadTabelasLoad(object sender, EventArgs e)
		{
			tabelas = new cTabelas();
			this.Cursor = Cursors.WaitCursor;
			tabelas.Carrega(dgvCadastro, chkAtivos.Checked);
			Grid.Sort(dgvCadastro, col_sorted, ord_sorted);									
			this.Cursor = Cursors.Default;
			SetaEdicaoLocal(false);					

		}
		
		void DgvCadastroRowEnter(object sender, DataGridViewCellEventArgs e)
		{
			AtualizaDadosLocal(e.RowIndex);
		}		
		
		void BtnIncluiClick(object sender, EventArgs e)
		{
			SetaEdicaoLocal(true);
			InicializaCampos();
			edtParceiro.Focus();
		}
		
		void BtnAlteraClick(object sender, EventArgs e)
		{
			if (acao == 'c') return;
			SetaEdicaoLocal(true);
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
			frmCad.ReadOnly = !acesso.PermissaoPrograma(Globais.sUsuario, Globais.sFilial, 2, "fCadParceiros");
			frmCad.ShowDialog();
			edtParceiro.Text = frmCad.edtCodigo.Text;
			edtParceiro.Focus();
		}
		
		void BtnPrecosClick(object sender, EventArgs e)
		{
			if (dgvCadastro.Rows.Count == 0) return;			
			frmPrecos frm = new frmPrecos();
			frm.parceiro = edtParceiro.Text;
			frm.tabela = edtCodigo.Text;
			frm.ShowDialog();				
		}
		
				
		void DgvCadastroSorted(object sender, EventArgs e)
		{
			col_sorted = dgvCadastro.SortedColumn.HeaderText;
			ord_sorted = dgvCadastro.SortOrder;			
		}
		
		void ChkAtivosCheckedChanged(object sender, EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			tabelas.Carrega(dgvCadastro, chkAtivos.Checked);
			Grid.Sort(dgvCadastro, col_sorted, ord_sorted);									
			this.Cursor = Cursors.Default;
		}
		

		public int ProcuraLinha(int i, string parceiro, string codigo)
		{
			string parceiroI = dgvCadastro.Rows[i].Cells[0].Value.ToString().Trim();
			string codigoI = dgvCadastro.Rows[i].Cells[1].Value.ToString().Trim();
			if (parceiroI.Equals(parceiro) && codigoI.Equals(codigo))
			{
				return i;
			}
			return -1;
		}
		
		public int Procura(string parceiro, string codigo)
		{
			int r=-1;
			if (selecionado > dgvCadastro.Rows.Count)
				selecionado = dgvCadastro.Rows.Count;
			if (dir == 'd')
			{
				for (int i=selecionado+1; i<dgvCadastro.Rows.Count; i++)
					if ((r = ProcuraLinha(i, parceiro, codigo)) >= 0) break;
			}
			else
			{
				for (int i=selecionado-1; i>=0; i--)
					if ((r = ProcuraLinha(i, parceiro, codigo)) >= 0) break;
			}
			return r;
		}
		
	}
}
