/*
 * Projeto  : SoftPlace
 * Sistema  : Básico
 * Programa : fImpressaoParceiros - Filtros de impressão
 * Autor    : Ricardo Costa Xavier
 * Data     : 16/05/10
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace basico
{
	public partial class fImpressaoParceiros : Form
	{
		public string titulo;
		public bool fisica;
		public bool juridica;
		public bool idt_cadastroI;
		public DateTime cadastroI;
		public bool idt_cadastroF;
		public DateTime cadastroF;
		public bool idt_nascimentoI;
		public DateTime nascimentoI;
		public bool idt_nascimentoF;
		public DateTime nascimentoF;		
		public bool idt_orcamentoI;
		public DateTime orcamentoI;
		public bool idt_orcamentoF;
		public DateTime orcamentoF;
		public bool idt_pedidoI;
		public DateTime pedidoI;
		public bool idt_pedidoF;
		public DateTime pedidoF;		
		public bool fornecedor;
		public bool cliente;
		public bool consultor;
		public bool idt_codigo;         // 1
		public bool idt_nome;           // 2
		public bool idt_papel;          // 1
		public bool idt_tipo_pessoa;    // 1
		public bool idt_cpf_cnpj;       // 1
		public bool idt_endereco;       // 4
		public bool idt_fone;           // 2
		public bool idt_email;          // 2
		public bool idt_ie;             // 1
		public bool idt_im;             // 1
		public bool idt_dat_cadastro;   // 1		
		public bool idt_dat_nascimento; // 1				
		public bool idt_contatos;
		public bool result;
		public string mailing;
						
		public fImpressaoParceiros()
		{			
			InitializeComponent();
		}
		
		void FImpressaoParceirosLoad(object sender, EventArgs e)
		{
			result = false;	
		}
		
		void SetaRetorno()
		{
			titulo = edtTitulo.Text;
			fisica = chkFisica.Checked;
			juridica = chkJuridica.Checked;
			idt_cadastroI = dtpCadastroI.Checked;
			cadastroI = dtpCadastroI.Value;
			idt_cadastroF = dtpCadastroF.Checked;
			cadastroF = dtpCadastroF.Value;			
			idt_nascimentoI = dtpNascimentoI.Checked;
			nascimentoI = dtpNascimentoI.Value;
			idt_nascimentoF = dtpNascimentoF.Checked;
			nascimentoF = dtpNascimentoF.Value;						
			idt_orcamentoI = dtpOrcamentoI.Checked;
			orcamentoI = dtpOrcamentoI.Value;
			idt_orcamentoF = dtpOrcamentoF.Checked;
			orcamentoF = dtpOrcamentoF.Value;			
			idt_pedidoI = dtpPedidoI.Checked;
			pedidoI = dtpPedidoI.Value;			
			idt_pedidoF = dtpPedidoF.Checked;
			pedidoF = dtpPedidoF.Value;						
			fornecedor = chkFornecedor.Checked;
			cliente = chkCliente.Checked;
			consultor = chkConsultor.Checked;
			idt_codigo = chkCodigo.Checked;
			idt_nome = chkNome.Checked;
			idt_papel = chkPapel.Checked;
			idt_tipo_pessoa = chkTipoPessoa.Checked;
			idt_cpf_cnpj = chkCpfCnpj.Checked;
			idt_endereco = chkEndereco.Checked;
			idt_fone = chkFone.Checked;
			idt_email = chkEmail.Checked;
			idt_ie = chkIE.Checked;
			idt_im = chkIM.Checked;
			idt_dat_cadastro = chkDataCadastro.Checked;
			idt_dat_nascimento = chkDatNascimento.Checked;			
			idt_contatos = chkContatos.Checked;						
		}
		
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			result = true;
			mailing = null;
			SetaRetorno();
			Close();
		}
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			result = false;
			Close();
		}
		
		void BtnMailingClick(object sender, EventArgs e)
		{
			mailing = (dlgSave.ShowDialog() == DialogResult.OK) ? dlgSave.FileName : null;			
			result = true;
			SetaRetorno();						
			Close();			
		}
	}
}
