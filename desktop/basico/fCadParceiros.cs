/*
 * Projeto  : SoftPlace
 * Sistema  : CPD
 * Programa : fCadParceiros - Cadastro de Parceiros
 * Autor    : Ricardo Costa Xavier
 * Data     : 10/04/08
 */
using System;
using System.Windows.Forms;
using templates;
using classes;

namespace basico
{
	public partial class frmCadParceiros : tCadastroSimples
	{
		private cParceiros parceiros;
		public string where;
		public bool bClientes;
		public bool bFornecedores;
		public bool bConsultores;
		public bool ReadOnly;
		public string codigo;
		public bool result;
		private string nomeAlteracao;
		
		void AlteraComponentes()
		{
			edtCodigo.MaxLength = 20;
			edtCodigo.CharacterCasing = CharacterCasing.Upper;
			dgvCadastro.Width = 570;
			btnFecha.TabIndex = 7;
			btnFecha.Top += 30;
			btnContatos.TabIndex = 6;
			btnContatos.Top -= 30;
			dgvCadastro.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCadastroRowEnter);
		}
		
		void InicializaCampos()
		{
			edtCodigo.Text = "";
			edtDescricao.Text = "";
			ckbCliente.Checked = false;
			ckbFornecedor.Checked = false;
			ckbConsultor.Checked = false;			
			rbtJuridica.Checked = true;
			edtCNPJ.Text = CNPJ.PoeEdicao("");
			lblCNPJ.Text = "CNPJ";			
			edtCNPJ.MaxLength = 14;
			edtCNPJ.Width = 132;
			edtInsEst.Text = "";
			edtInsMun.Text = "";
			edtLogradouro.Text = "";
			edtNumero.Text = "";
			edtComplemento.Text = "";
			edtBairro.Text = "";
			edtCidade.Text = "";
			cbxEstados.SelectedIndex = (cbxEstados.Items.Count > 0) ? 0 : -1;
			edtCEP.Text = CEP.PoeEdicao("");
			edtLogradouroEntrega.Text = "";
			edtNumeroEntrega.Text = "";
			edtComplementoEntrega.Text = "";
			edtBairroEntrega.Text = "";
			edtCidadeEntrega.Text = "";
			cbxEstadosEntrega.SelectedIndex = (cbxEstadosEntrega.Items.Count > 0) ? 0 : -1;
			edtCEPEntrega.Text = CEP.PoeEdicao("");
			edtLogradouroCobranca.Text = "";
			edtNumeroCobranca.Text = "";
			edtComplementoCobranca.Text = "";
			edtBairroCobranca.Text = "";
			edtCidadeCobranca.Text = "";
			cbxEstadosCobranca.SelectedIndex = (cbxEstadosCobranca.Items.Count > 0) ? 0 : -1;
			edtCEPCobranca.Text = CEP.PoeEdicao("");
			edtFone1.Text = FONE.PoeEdicao("");
			edtFone2.Text = FONE.PoeEdicao("");			
			edtCelular.Text = CELULAR.PoeEdicao("");
			edtFAX.Text = FONE.PoeEdicao("");			
			edtEmail.Text = "";
			edtPedido.Text = "0";
			dtpNascimento.Value = DateTime.Now;
			dtpNascimento.Checked = false;			
			ckbAtivo.Checked = true;
		}		
		
		public void SetaEdicaoLocal(bool enabled)
		{
			ckbCliente.Enabled = enabled;
			ckbFornecedor.Enabled = enabled;
			ckbConsultor.Enabled = enabled;
			rbtFisica.Enabled = enabled;
			rbtJuridica.Enabled = enabled;
			edtCNPJ.Enabled = enabled;
			edtInsEst.Enabled = enabled;			
			edtInsMun.Enabled = enabled;			
			edtLogradouro.Enabled = enabled;
			edtNumero.Enabled = enabled;
			edtComplemento.Enabled = enabled;
			edtBairro.Enabled = enabled;
			edtCidade.Enabled = enabled;
			cbxEstados.Enabled = enabled;
			edtCEP.Enabled = enabled;
			edtLogradouroEntrega.Enabled = enabled;
			edtNumeroEntrega.Enabled = enabled;
			edtComplementoEntrega.Enabled = enabled;
			edtBairroEntrega.Enabled = enabled;
			edtCidadeEntrega.Enabled = enabled;
			cbxEstadosEntrega.Enabled = enabled;
			edtCEPEntrega.Enabled = enabled;
			edtLogradouroCobranca.Enabled = enabled;
			edtNumeroCobranca.Enabled = enabled;
			edtComplementoCobranca.Enabled = enabled;
			edtBairroCobranca.Enabled = enabled;
			edtCidadeCobranca.Enabled = enabled;
			cbxEstadosCobranca.Enabled = enabled;
			edtCEPCobranca.Enabled = enabled;
			edtFone1.Enabled = enabled;
			edtFone2.Enabled = enabled;			
			edtCelular.Enabled = enabled;
			edtFAX.Enabled = enabled;			
			edtEmail.Enabled = enabled;
			edtPedido.Enabled = enabled && ckbFornecedor.Checked;
			dtpNascimento.Enabled = enabled && rbtFisica.Checked;
			ckbAtivo.Enabled = enabled;
			btnContatos.Enabled = !enabled;
		}
		
		public void AtualizaDadosLocal(int i)
		{
			ckbCliente.Checked = (dgvCadastro.Rows[i].Cells[2].Value.ToString().CompareTo("S") == 0);
			ckbFornecedor.Checked = (dgvCadastro.Rows[i].Cells[3].Value.ToString().CompareTo("S") == 0);
			ckbConsultor.Checked = (dgvCadastro.Rows[i].Cells[4].Value.ToString().CompareTo("S") == 0);
			string pessoa = dgvCadastro.Rows[i].Cells[5].Value.ToString().Trim();
			rbtFisica.Checked = (pessoa.CompareTo("F") == 0);
			rbtJuridica.Checked = (pessoa.CompareTo("J") == 0);
			if (rbtJuridica.Checked)
			{
				lblDescricao.Text = "Razão Social";
				edtCNPJ.Text = CNPJ.PoeEdicao(dgvCadastro.Rows[i].Cells[6].Value.ToString().Trim());
				lblCNPJ.Text = "CNPJ";
				edtCNPJ.MaxLength = 14;
				edtCNPJ.Width = 132;
			}
			else 
			{
				lblDescricao.Text = "Nome";
				edtCNPJ.Text = CPF.PoeEdicao(dgvCadastro.Rows[i].Cells[6].Value.ToString().Trim());
				lblCNPJ.Text = "CPF";
				edtCNPJ.MaxLength = 11;
				edtCNPJ.Width = 104;
			}
			edtInsEst.Text = dgvCadastro.Rows[i].Cells[7].Value.ToString().Trim();
			edtInsMun.Text = dgvCadastro.Rows[i].Cells[8].Value.ToString().Trim();			
			edtLogradouro.Text = dgvCadastro.Rows[i].Cells[9].Value.ToString().Trim();
			edtNumero.Text = dgvCadastro.Rows[i].Cells[10].Value.ToString().Trim();
			edtComplemento.Text = dgvCadastro.Rows[i].Cells[11].Value.ToString().Trim();
			edtBairro.Text = dgvCadastro.Rows[i].Cells[12].Value.ToString().Trim();
			edtCidade.Text = dgvCadastro.Rows[i].Cells[13].Value.ToString().Trim();
			cbxEstados.Text = dgvCadastro.Rows[i].Cells[14].Value.ToString().Trim();
			edtCEP.Text = CEP.PoeEdicao(dgvCadastro.Rows[i].Cells[15].Value.ToString().Trim());
			edtLogradouroEntrega.Text = dgvCadastro.Rows[i].Cells[16].Value.ToString().Trim();
			edtNumeroEntrega.Text = dgvCadastro.Rows[i].Cells[17].Value.ToString().Trim();
			edtComplementoEntrega.Text = dgvCadastro.Rows[i].Cells[18].Value.ToString().Trim();
			edtBairroEntrega.Text = dgvCadastro.Rows[i].Cells[19].Value.ToString().Trim();
			edtCidadeEntrega.Text = dgvCadastro.Rows[i].Cells[20].Value.ToString().Trim();
			cbxEstadosEntrega.Text = dgvCadastro.Rows[i].Cells[21].Value.ToString().Trim();
			edtCEPEntrega.Text = CEP.PoeEdicao(dgvCadastro.Rows[i].Cells[22].Value.ToString().Trim());
			edtLogradouroCobranca.Text = dgvCadastro.Rows[i].Cells[23].Value.ToString().Trim();
			edtNumeroCobranca.Text = dgvCadastro.Rows[i].Cells[24].Value.ToString().Trim();
			edtComplementoCobranca.Text = dgvCadastro.Rows[i].Cells[25].Value.ToString().Trim();
			edtBairroCobranca.Text = dgvCadastro.Rows[i].Cells[26].Value.ToString().Trim();
			edtCidadeCobranca.Text = dgvCadastro.Rows[i].Cells[27].Value.ToString().Trim();
			cbxEstadosCobranca.Text = dgvCadastro.Rows[i].Cells[28].Value.ToString().Trim();
			edtCEPCobranca.Text = CEP.PoeEdicao(dgvCadastro.Rows[i].Cells[29].Value.ToString().Trim());
			edtFone1.Text = FONE.PoeEdicao(dgvCadastro.Rows[i].Cells[30].Value.ToString().Trim());
			edtFone2.Text = FONE.PoeEdicao(dgvCadastro.Rows[i].Cells[31].Value.ToString().Trim());			
			edtCelular.Text = CELULAR.PoeEdicao(dgvCadastro.Rows[i].Cells[32].Value.ToString().Trim());
			edtFAX.Text = FONE.PoeEdicao(dgvCadastro.Rows[i].Cells[33].Value.ToString().Trim());			
			edtEmail.Text = dgvCadastro.Rows[i].Cells[34].Value.ToString().Trim();		
			ckbAtivo.Checked = (dgvCadastro.Rows[i].Cells[35].Value.ToString().Trim().CompareTo("S") == 0);
			edtPedido.Text = dgvCadastro.Rows[i].Cells[36].Value.ToString().Trim();		
			dtpAlteracao.Value = DateTime.Parse(dgvCadastro.Rows[i].Cells[37].Value.ToString());
			try {
				dtpNascimento.Value = DateTime.Parse(dgvCadastro.Rows[i].Cells[38].Value.ToString());			
				dtpNascimento.Checked = true;
			}
			catch {
				dtpNascimento.Value = DateTime.Now;
				dtpNascimento.Checked = false;
			}
		}

		public frmCadParceiros(bool duplo)
		{
			bClientes = false;
			bFornecedores = false;
			bConsultores = false;
			ReadOnly = false;
			where = "";
			InitializeComponent();
			AlteraComponentes();
			if (duplo)
				dgvCadastro.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCadastroCellDoubleClick);			
		}
		
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			string msg="";
			string cpf_cnpj;
			bool result;
			string codigo = edtCodigo.Text.Trim();
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
			if (cbxEstados.Text.Trim().CompareTo("") != 0)
			{
				if (!cbxEstados.Items.Contains(cbxEstados.Text.Trim()))
				{
					MessageBox.Show(cbxEstados.Text, "Estado não Cadastrado", 
				                	MessageBoxButtons.OK, 
				                	MessageBoxIcon.Warning);
					cbxEstados.Focus();
					return;				
				}
			}
			if (!ckbCliente.Checked && !ckbFornecedor.Checked && !ckbConsultor.Checked)
			{
				MessageBox.Show("Tipo: cliente/fornecedor/consultor", "Campo Obrigatório", 
				                MessageBoxButtons.OK, 
				                MessageBoxIcon.Warning);
				ckbCliente.Focus();
				return;				
			}
			string cliente = (ckbCliente.Checked) ? "S" : "N";
			string fornecedor = (ckbFornecedor.Checked) ? "S" : "N";
			string consultor = (ckbConsultor.Checked) ? "S" : "N";			
			string pessoa = rbtFisica.Checked ? "F" : "J";
			string ativo = ckbAtivo.Checked ? "S" : "N";
			if (edtCNPJ.MaxLength == 14)
				cpf_cnpj = CNPJ.TiraEdicao(edtCNPJ.Text);
			else
				cpf_cnpj = CPF.TiraEdicao(edtCNPJ.Text);			

			if (!cpf_cnpj.Replace("0", "").Equals(""))
			{
				string nomeCpfCnpj = parceiros.ProcuraPorCpfCnpj(cpf_cnpj);
				if (nomeCpfCnpj != null) 
				{
					if ((acao != 'a') || (nomeAlteracao == null) || !nomeAlteracao.Equals(nomeCpfCnpj.Trim())) 
					{
						MessageBox.Show("Já existe um parceiro com esse cpf/cnpj\r\n" + nomeCpfCnpj, "Aviso",  
			    	            MessageBoxButtons.OK, 
			    	            MessageBoxIcon.Warning);		
					}
				}
			}
			
			if (acao == 'i') 
			{
				result = parceiros.Inclui(codigo, edtDescricao.Text, 
				                        cliente,
				                        fornecedor,
				                        consultor,				                        
				                        pessoa,
				                        cpf_cnpj,
				                        edtInsEst.Text,
				                        edtInsMun.Text,
										edtLogradouro.Text,
										edtNumero.Text,
										edtComplemento.Text,
										edtBairro.Text,
										edtCidade.Text,
										cbxEstados.Text,
										CEP.TiraEdicao(edtCEP.Text),
										edtLogradouroEntrega.Text,
										edtNumeroEntrega.Text,
										edtComplementoEntrega.Text,
										edtBairroEntrega.Text,
										edtCidadeEntrega.Text,
										cbxEstadosEntrega.Text,
										CEP.TiraEdicao(edtCEPEntrega.Text),
										edtLogradouroCobranca.Text,
										edtNumeroCobranca.Text,
										edtComplementoCobranca.Text,
										edtBairroCobranca.Text,
										edtCidadeCobranca.Text,
										cbxEstadosCobranca.Text,
										CEP.TiraEdicao(edtCEPCobranca.Text),
										FONE.TiraEdicao(edtFone1.Text),
										FONE.TiraEdicao(edtFone2.Text),										
										CELULAR.TiraEdicao(edtCelular.Text),
										FONE.TiraEdicao(edtFAX.Text),										
										edtEmail.Text,
										dtpNascimento.Checked,
										dtpNascimento.Value,
										ativo,
										Globais.StrToInt(edtPedido.Text),
				                        ref msg);
			}
			else
				result = parceiros.Altera(codigo, edtDescricao.Text,
				                        cliente,
				                        fornecedor,
				                        consultor,				                        
				                        pessoa,
				                        cpf_cnpj,
				                        edtInsEst.Text,
				                        edtInsMun.Text,
										edtLogradouro.Text,
										edtNumero.Text,										
										edtComplemento.Text,
										edtBairro.Text,
										edtCidade.Text,
										cbxEstados.Text,
										CEP.TiraEdicao(edtCEP.Text),
										edtLogradouroEntrega.Text,
										edtNumeroEntrega.Text,
										edtComplementoEntrega.Text,
										edtBairroEntrega.Text,
										edtCidadeEntrega.Text,
										cbxEstadosEntrega.Text,
										CEP.TiraEdicao(edtCEPEntrega.Text),
										edtLogradouroCobranca.Text,
										edtNumeroCobranca.Text,
										edtComplementoCobranca.Text,
										edtBairroCobranca.Text,
										edtCidadeCobranca.Text,
										cbxEstadosCobranca.Text,
										CEP.TiraEdicao(edtCEPCobranca.Text),
										FONE.TiraEdicao(edtFone1.Text),
										FONE.TiraEdicao(edtFone2.Text),										
										CELULAR.TiraEdicao(edtCelular.Text),
										FONE.TiraEdicao(edtFAX.Text),										
										edtEmail.Text,
										dtpNascimento.Checked,
										dtpNascimento.Value,										
										ativo,
										Globais.StrToInt(edtPedido.Text),
				                        ref msg);
			if (!result)
			{
				if (acao == 'i')
					MessageBox.Show(codigo+"\n"+msg, "Erro na inclusão do parceiro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				else
					MessageBox.Show(codigo+"\n"+msg, "Erro na alteração do parceiro", MessageBoxButtons.OK, MessageBoxIcon.Error);				
			}
			this.Cursor = Cursors.WaitCursor;
			parceiros.Carrega(dgvCadastro, where);
			this.Cursor = Cursors.Default;
			int selecionado = Procura(codigo, true);
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
			result = parceiros.Exclui(edtCodigo.Text, ref msg);
			if (!result)
			{
				MessageBox.Show(edtCodigo.Text + "\r\n" + Globais.ErroExclusao("Parceiro encontrado", msg), "Erro na exclusão do parceiro", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			this.Cursor = Cursors.WaitCursor;
			parceiros.Carrega(dgvCadastro, where);
			this.Cursor = Cursors.Default;
			if (dgvCadastro.Rows.Count == 0)
			{
				InicializaCampos();
			}
		}
		
		void FrmCadParceirosLoad(object sender, EventArgs e)
		{
			parceiros = new cParceiros();
			if (bClientes) where = "where IDT_CLIENTE = 'S'";
			else
			if (bFornecedores) where = "where IDT_FORNECEDOR = 'S'";				
			else
			if (bConsultores) where = "where IDT_CONSULTOR = 'S'";				
			if (ReadOnly)
			{
				btnConfirma.Visible = false;
				btnCancela.Visible = false;
				btnInclui.Visible = false;
				btnExclui.Visible = false;
				btnAltera.Visible = false;
				//btnFecha.Text = "Seleciona";
			}
			this.Cursor = Cursors.WaitCursor;
			parceiros.Carrega(dgvCadastro, where);
			this.Cursor = Cursors.Default;
			cEstados estados = new cEstados();
			this.Cursor = Cursors.WaitCursor;
			estados.Carrega(cbxEstados);
			this.Cursor = Cursors.Default;
			this.Cursor = Cursors.WaitCursor;
			estados.Carrega(cbxEstadosEntrega);
			this.Cursor = Cursors.Default;
			this.Cursor = Cursors.WaitCursor;
			estados.Carrega(cbxEstadosCobranca);			
			this.Cursor = Cursors.Default;
			SetaEdicaoLocal(false);		
			result = false;
/*			
			if (dgvCadastro.Rows.Count == 0)			
			{
				if (codigo.Trim().CompareTo("") != 0)
				{
					HabilitaEdicao();			
					edtDescricao.Text = "";
					acao = 'i';				
					SetaEdicaoLocal(true);
					InicializaCampos();
					edtCodigo.Text = codigo;			
					edtCodigo.Focus();					
				}
			}
*/			
		}
		
		void DgvCadastroRowEnter(object sender, DataGridViewCellEventArgs e)
		{
			AtualizaDadosLocal(e.RowIndex);
		}
				
		void BtnIncluiClick(object sender, EventArgs e)
		{
			SetaEdicaoLocal(true);
			nomeAlteracao = null;
			InicializaCampos();
		}
		
		void BtnAlteraClick(object sender, EventArgs e)
		{
			if (acao == 'c') return;
			nomeAlteracao = edtDescricao.Text.Trim();
			SetaEdicaoLocal(true);
		}
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			SetaEdicaoLocal(false);						
		}
		
		void EdtNUMERICOKeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar > 31 && (e.KeyChar < '0' || e.KeyChar > '9'))
			{
				e.Handled = true;
			}
		}
		
		void EdtCNPJEnter(object sender, EventArgs e)
		{
			if (edtCNPJ.MaxLength == 14)
				edtCNPJ.Text = CNPJ.TiraEdicao(edtCNPJ.Text);
			else
				edtCNPJ.Text = CPF.TiraEdicao(edtCNPJ.Text);
		}
		
		void EdtCNPJLeave(object sender, EventArgs e)
		{
			if (edtCNPJ.MaxLength == 14)
				edtCNPJ.Text = CNPJ.PoeEdicao(edtCNPJ.Text);
			else
				edtCNPJ.Text = CPF.PoeEdicao(edtCNPJ.Text);			
		}
		
		void EdtFone1Enter(object sender, EventArgs e)
		{
			edtFone1.Text = FONE.TiraEdicao(edtFone1.Text);
		}
		
		void EdtFone1Leave(object sender, EventArgs e)
		{
			edtFone1.Text = FONE.PoeEdicao(edtFone1.Text);
		}
		
		void EdtFone2Enter(object sender, EventArgs e)
		{
			edtFone2.Text = FONE.TiraEdicao(edtFone2.Text);
		}
		
		void EdtFone2Leave(object sender, EventArgs e)
		{
			edtFone2.Text = FONE.PoeEdicao(edtFone2.Text);
		}
		
		void EdtCelularEnter(object sender, EventArgs e)
		{
			edtCelular.Text = CELULAR.TiraEdicao(edtCelular.Text);
		}
		
		void EdtCelularLeave(object sender, EventArgs e)
		{
			edtCelular.Text = CELULAR.PoeEdicao(edtCelular.Text);
		}
		
		void EdtFAXEnter(object sender, EventArgs e)
		{
			edtFAX.Text = FONE.TiraEdicao(edtFAX.Text);
		}
		
		void EdtFAXLeave(object sender, EventArgs e)
		{
			edtFAX.Text = FONE.PoeEdicao(edtFAX.Text);
		}
		
		void EdtCEPEnter(object sender, EventArgs e)
		{
			edtCEP.Text = CEP.TiraEdicao(edtCEP.Text);
		}
		
		void EdtCEPLeave(object sender, EventArgs e)
		{
			edtCEP.Text = CEP.PoeEdicao(edtCEP.Text);
		}

		void EdtCEPEntregaEnter(object sender, EventArgs e)
		{
			edtCEPEntrega.Text = CEP.TiraEdicao(edtCEPEntrega.Text);
		}
		
		void EdtCEPEntregaLeave(object sender, EventArgs e)
		{
			edtCEPEntrega.Text = CEP.PoeEdicao(edtCEPEntrega.Text);
		}
		
		void EdtCEPCobrancaEnter(object sender, EventArgs e)
		{
			edtCEPCobranca.Text = CEP.TiraEdicao(edtCEPCobranca.Text);
		}
		
		void EdtCEPCobrancaLeave(object sender, EventArgs e)
		{
			edtCEPCobranca.Text = CEP.PoeEdicao(edtCEPCobranca.Text);
		}
		
		void BtnContatosClick(object sender, EventArgs e)
		{
			if (dgvCadastro.Rows.Count == 0) return;			
			frmCadContatos frm = new frmCadContatos(true);
			frm.parceiro = edtCodigo.Text;
			frm.des_parceiro = edtDescricao.Text;
			frm.juridica = rbtJuridica.Checked;
			frm.ShowDialog();				
		}
		
		void RbtFisicaClick(object sender, EventArgs e)
		{
			dtpNascimento.Enabled = true;
			lblDescricao.Text = "Nome";			
			lblCNPJ.Text = "CPF";
			edtCNPJ.MaxLength = 11;
			edtCNPJ.Width = 104;
			if (edtCNPJ.Text.Length == 18)
			{
				edtCNPJ.Text = CNPJ.TiraEdicao(edtCNPJ.Text).Substring(0, 11);
				edtCNPJ.Text = CPF.PoeEdicao(edtCNPJ.Text);
			}
		}
		
		void RbtJuridicaClick(object sender, EventArgs e)
		{
			dtpNascimento.Enabled = false;
			lblDescricao.Text = "Razão Social";
			lblCNPJ.Text = "CNPJ";
			edtCNPJ.MaxLength = 14;
			edtCNPJ.Width = 132;
			if (edtCNPJ.Text.Length == 14)
			{
				edtCNPJ.Text = CPF.TiraEdicao(edtCNPJ.Text) + "000";
				edtCNPJ.Text = CNPJ.PoeEdicao(edtCNPJ.Text);
			}
		}
		
		void BtnFechaClick(object sender, EventArgs e)
		{
			result = false;
		}
		
		void dgvCadastroCellDoubleClick(object sender, DataGridViewCellEventArgs e)		
		{
			result = true;
			Close();
		}
		
		void BtnImprimeClick(object sender, EventArgs e)
		{
			fImpressaoParceiros frm = new fImpressaoParceiros();
			frm.ShowDialog();
			if (!frm.result) return;
			string pdf = "parceiros.pdf";
			if (parceiros.Gera(pdf, frm.titulo, frm.fisica, frm.juridica, 
			                   frm.idt_cadastroI, frm.cadastroI, frm.idt_cadastroF, frm.cadastroF, 
			                   frm.idt_nascimentoI, frm.nascimentoI, frm.idt_nascimentoF, frm.nascimentoF, 			                   
			                   frm.idt_orcamentoI, frm.orcamentoI, frm.idt_orcamentoF, frm.orcamentoF, 
			                   frm.idt_pedidoI, frm.pedidoI, frm.idt_pedidoF, frm.pedidoF,
			                   frm.fornecedor, frm.cliente, frm.consultor, frm.idt_codigo, frm.idt_nome, frm.idt_papel, frm.idt_tipo_pessoa,
			                   frm.idt_cpf_cnpj, frm.idt_endereco, frm.idt_fone, frm.idt_email, frm.idt_ie, frm.idt_im, frm.idt_dat_cadastro, frm.idt_dat_nascimento,
			                   frm.idt_contatos, frm.mailing))
				if (frm.mailing == null) System.Diagnostics.Process.Start("explorer", pdf);
		}
		
		void btnAuditoriaClick(object sender, EventArgs e)
		{
			AuditoriaParceiros frm = new AuditoriaParceiros();
			frm.Show();
		}
	}
}
