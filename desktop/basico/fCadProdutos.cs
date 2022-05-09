/*
 * Projeto  : SoftPlace
 * Sistema  : CPD
 * Programa : fCadProdutos - Cadastro de Produtos
 * Autor    : Ricardo Costa Xavier
 * Data     : 22/04/08
 * 
 * 29/03/2014 - Ricardo - Permitir somente caixa alta nos dados dos produtos
 */
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using System.IO;
using templates;
using classes;

namespace basico
{
	public partial class frmCadProdutos : tCadastroSimples
	{
		private cProdutos produtos;
		private Image image;
		private string xParceiro;
		public string xCodigo;
		private string xSubCodigo;
		private string xDescricao;
		private string xMedida;
		private string xTexto;
		public string where;		
		public bool ReadOnly;
		public bool result;
		private DataTable table;
		
		void AlteraComponentes()
		{
			edtParceiro.CharacterCasing = CharacterCasing.Upper;			
			edtCodigo.CharacterCasing = CharacterCasing.Upper;
			edtSubCodigo.CharacterCasing = CharacterCasing.Upper;
			dgvCadastro.Width = 570;
			dgvCadastro.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCadastroRowEnter);
		}
		
		void InicializaCampos()
		{
			edtParceiro.Text = "";			
			edtCodigo.Text = "";
			edtSubCodigo.Text = "";			
			edtDescricao.Text = "";
			edtMedida.Text = "";
			edtIPI.Text = "0,00";
			edtTexto.Text = "";
			chkGenerico.Checked = false;
			imgProduto.Image = null;
		}		
		
		public void SetaEdicaoLocal(bool enabled)
		{
			edtParceiro.Enabled = enabled;			
			btnParceiros.Enabled = enabled;						
			edtCodigo.Enabled = enabled;
			edtSubCodigo.Enabled = enabled;
			edtDescricao.Enabled = enabled;
			edtMedida.Enabled = enabled;
			edtIPI.Enabled = enabled;
			chkGenerico.Enabled = enabled;
			//edtTexto.Enabled = enabled;
		}
		
		public void AtualizaDadosLocal(int i)
		{
			
			string img;
			edtParceiro.Text = dgvCadastro.Rows[i].Cells[0].Value.ToString().Trim();			
			edtCodigo.Text = dgvCadastro.Rows[i].Cells[1].Value.ToString().Trim();			
			edtSubCodigo.Text = dgvCadastro.Rows[i].Cells[2].Value.ToString().Trim();			
			edtDescricao.Text = dgvCadastro.Rows[i].Cells[3].Value.ToString().Trim();
			edtTexto.Text = dgvCadastro.Rows[i].Cells[4].Value.ToString().Trim();
			edtMedida.Text = dgvCadastro.Rows[i].Cells[5].Value.ToString().Trim();	
			float valor = Globais.StrToFloat(dgvCadastro.Rows[i].Cells[6].Value.ToString().Trim());
			chkGenerico.Checked = dgvCadastro.Rows[i].Cells[7].Value.ToString().Trim().Equals("S");
			edtIPI.Text = valor.ToString("#0.00");
			imgProduto.Image = null;
			img = "imagens\\" + edtCodigo.Text + edtSubCodigo.Text + ".jpg";
			image = null;
			if (File.Exists(img))
				image = Image.FromFile(img);
			else
			{
				img = "imagens\\" + edtCodigo.Text + edtSubCodigo.Text + ".bmp";
				if (File.Exists(img))
					image = Image.FromFile(img);
				else
				{
					img = "imagens\\" + edtCodigo.Text + ".jpg";
					if (!File.Exists(img)) 
					{
						string img2 = "imagens\\" + edtCodigo.Text + "-.jpg";
						if (File.Exists(img2)) 
						{
							img = "imagens\\" + edtCodigo.Text + edtSubCodigo.Text + ".jpg";
							System.IO.File.Copy(img2, img, true);
							image = Image.FromFile(img);
						}
						else
						{
							img2 = "imagens\\" + edtCodigo.Text + "AL.jpg";
							if (File.Exists(img2)) 
							{
								img = "imagens\\" + edtCodigo.Text + edtSubCodigo.Text + ".jpg";
								System.IO.File.Copy(img2, img, true);
								image = Image.FromFile(img);
							}							
						}
					}
				}
			}
		}
		
		public frmCadProdutos(bool duplo)
		{
			ReadOnly = false;			
			InitializeComponent();
			AlteraComponentes();	
			if (duplo)
				dgvCadastro.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCadastroCellDoubleClick);						
		}
		
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			string msg="";
			bool result;
			string parceiro = edtParceiro.Text.Trim();
			string codigo = edtCodigo.Text.Trim();
			string subcodigo = edtSubCodigo.Text.Trim();
			if (subcodigo.CompareTo("") == 0)
			{
				MessageBox.Show("SubCódigo", "Campo obrigatório", 
				                MessageBoxButtons.OK, 
				                MessageBoxIcon.Warning);
				edtSubCodigo.Focus();
				return;
			}
			if (edtParceiro.Text.Trim().CompareTo("") != 0)
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
			{
				result = produtos.Inclui(parceiro, codigo, subcodigo, edtDescricao.Text, 
				                         edtTexto.Text, edtMedida.Text,
				                         Globais.StrToFloat(edtIPI.Text),
				                         chkGenerico.Checked ? "S" : "N",
				                         ref msg);
				xParceiro = edtParceiro.Text;
				xCodigo = edtCodigo.Text;
				xSubCodigo = edtSubCodigo.Text;
				xDescricao = edtDescricao.Text;
				xMedida = edtMedida.Text;
				xTexto = edtTexto.Text;
			}
			else
				result = produtos.Altera(parceiro, codigo, subcodigo, edtDescricao.Text, 
				                         edtTexto.Text, edtMedida.Text,
				                         Globais.StrToFloat(edtIPI.Text),		
				                         chkGenerico.Checked ? "S" : "N",
				                         ref msg);
			if (!result)
			{
				if (acao == 'i')
					MessageBox.Show(codigo+"\n"+msg, "Erro na inclusão do produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
				else
					MessageBox.Show(codigo+"\n"+msg, "Erro na alteração do produto", MessageBoxButtons.OK, MessageBoxIcon.Error);				
			}
			else {
				if (acao == 'i')
				{
					DataRow row = table.NewRow();
					row[0] = parceiro;
					row[1] = codigo;
					row[2] = subcodigo;
					row[3] = edtDescricao.Text;
					row[4] = edtTexto.Text;
					row[5] = edtMedida.Text;
					row[6] = Globais.StrToFloat(edtIPI.Text);
					row[7] = chkGenerico.Checked ? "S" : "N";
					table.Rows.Add(row);
					int selecionado = Procura(codigo, false);
					if (selecionado >= 0)
					{
						for (int i=selecionado; i<dgvCadastro.Rows.Count; i++)
						{
							if (dgvCadastro.Rows[i].Cells[2].Value.ToString().Trim().CompareTo(subcodigo) == 0)
							{
								selecionado = i;
								break;
							}
						}
						dgvCadastro.Rows[selecionado].Cells[0].Selected = true;
						AtualizaDados(selecionado);
						AtualizaDadosLocal(selecionado);				
					}
				}
				else
				{
					int selecionado = dgvCadastro.CurrentRow.Index;	
					dgvCadastro.Rows[selecionado].Cells[0].Value = parceiro;
					dgvCadastro.Rows[selecionado].Cells[1].Value = codigo;
					dgvCadastro.Rows[selecionado].Cells[2].Value = subcodigo;
					dgvCadastro.Rows[selecionado].Cells[3].Value = edtDescricao.Text;
					dgvCadastro.Rows[selecionado].Cells[4].Value = edtTexto.Text;
					dgvCadastro.Rows[selecionado].Cells[5].Value = edtMedida.Text;
					dgvCadastro.Rows[selecionado].Cells[6].Value = Globais.StrToFloat(edtIPI.Text);
					dgvCadastro.Rows[selecionado].Cells[7].Value = chkGenerico.Checked ? "S" : "N";
					//produtos.Carrega(dgvCadastro, ref table, "");
				}
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
			string subcodigo = edtSubCodigo.Text.Trim();
			result = produtos.Exclui(parceiro, codigo, subcodigo, ref msg);
			if (!result)
			{
				MessageBox.Show(codigo + "-" + subcodigo + "\r\n" + Globais.ErroExclusao("Produto encontrado", msg), "Erro na exclusão do produto", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			int selecionado = dgvCadastro.CurrentRow.Index;	
			table.Rows.RemoveAt(selecionado);
			//produtos.Carrega(dgvCadastro, ref table, "");
			int n = dgvCadastro.Rows.Count;
			if (dgvCadastro.Rows.Count == 0)
			{
				InicializaCampos();
			}
			else 
			{
				if (selecionado == n) selecionado--;
				dgvCadastro.Rows[selecionado].Cells[0].Selected = true;
				AtualizaDados(selecionado);
				AtualizaDadosLocal(selecionado);				
			}
		}
		
		void FrmCadProdutosLoad(object sender, EventArgs e)
		{
			produtos = new cProdutos();
			this.Cursor = Cursors.WaitCursor;
			produtos.Carrega(dgvCadastro, ref table, where);
			this.Cursor = Cursors.Default;
			int n = table.Rows.Count;
			if ((xCodigo != null) && (xCodigo.Trim().Length > 0))
			{
				int selecionado = Procura(xCodigo, false);
				if (selecionado >= 0)
				{
					dgvCadastro.Rows[selecionado].Cells[0].Selected = true;
					AtualizaDados(selecionado);
					AtualizaDadosLocal(selecionado);				
				}
			}
			
			SetaEdicaoLocal(false);					
			xParceiro = "";
			xCodigo = "";
			xSubCodigo = "";
			xDescricao = "";
			xMedida = "";
			xTexto = "";
			if (ReadOnly)
			{
				btnConfirma.Visible = false;
				btnCancela.Visible = false;
				btnInclui.Visible = false;
				btnExclui.Visible = false;
				btnAltera.Visible = false;
			}
			result = false;
		}
		
		void DgvCadastroRowEnter(object sender, DataGridViewCellEventArgs e)
		{
			AtualizaDadosLocal(e.RowIndex);
		}		
		
		void BtnIncluiClick(object sender, EventArgs e)
		{
			SetaEdicaoLocal(true);
			InicializaCampos();
			edtParceiro.Text = xParceiro;
			edtCodigo.Text = xCodigo;
			edtSubCodigo.Text = xSubCodigo;
			edtDescricao.Text = xDescricao;
			edtMedida.Text = xMedida;
			edtTexto.Text = xTexto;
			edtParceiro.Focus();
		}
		
		void BtnAlteraClick(object sender, EventArgs e)
		{
			if (acao == 'c') return;
			SetaEdicaoLocal(true);
		}
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			SetaEdicaoLocal(false);									
		}
		
		void EdtTextoDoubleClick(object sender, EventArgs e)
		{
			frmEditaMemo frm = new frmEditaMemo();
			frm.edtMemo.Text = edtTexto.Text;
			frm.Text = "Descrição Detalhada";
			frm.ShowDialog();
			if (frm.ok)
			{
				edtTexto.Text = frm.edtMemo.Text;
			}
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
		
		void ImgProdutoPaint(object sender, PaintEventArgs e)
		{
			if (image != null)
			{
				int h = image.Height;
				int w = image.Width;
				while ((w > 200) || (h > 150)) 
				{
					w = (int)(w * 0.9);
					h = (int)(h * 0.9);
				}
				e.Graphics.DrawImage(image, 5, 5, w, h);
			}
		}
	
		void dgvCadastroCellDoubleClick(object sender, DataGridViewCellEventArgs e)		
		{
			result = true;
			Close();
		}
		
		void BtnFechaClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void EdtIPIKeyPress(object sender, KeyPressEventArgs e)
		{
			TextBox edt = (TextBox)sender;
			if ((e.KeyChar == ',') && !edt.Text.Contains(","))
			{
				e.Handled = false;
				return;
			}
			if (e.KeyChar > 31 && (e.KeyChar < '0' || e.KeyChar > '9'))
			{
				e.Handled = true;
				return;
			}
		}
		
		void BtnLocalizaClick(object sender, EventArgs e)
		{
			
		}
		
	}
}
