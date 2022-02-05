/*
 * Projeto  : SoftPlace
 * Sistema  : CPD
 * Programa : fCodigoCopia - Le o novo código para cópia
 * Autor    : Ricardo Costa Xavier
 * Data     : 30/05/08
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using classes;

namespace basico
{
	public partial class fCodigoCopia : Form
	{
		private string parceiro;
		private string codigo_origem;
		private string formula;
		private string formula_pedido;
		private float consultor;
		private float vendedor;
		private float filial;
		private float limiar;
		private string observacao;
		private string racional;
		private string servico;
		private string ativo;
		private short dias;
		private string venpro;
		private string venser;
		private string conpro;
		private string conser;
		private string filpro;
		private string filser;
		private float frete;
		private string introducao;		
		private string fornecimento;		
		private string garantia;		
		private string condicao;		
		private string aceite;		
		private string imprime_ipi;
		public string novo_codigo;
		
		public fCodigoCopia(string parceiro, string codigo_origem, string formula, string formula_pedido, float consultor, float vendedor, float filial, float limiar, string observacao, string racional, string servico, string ativo, short dias, string venpro, string venser, string conpro, string conser, string filpro, string filser, float frete,
		                   string introducao, string fornecimento, string garantia, string condicao, string aceite, string imprime_ipi)
		{
			InitializeComponent();
			this.parceiro = parceiro;
			this.codigo_origem = codigo_origem;
			this.formula = formula;
			this.formula_pedido = formula_pedido;
			this.consultor = consultor;
			this.vendedor = vendedor;
			this.filial = filial;
			this.limiar = limiar;
			this.observacao = observacao;
			this.racional = racional;
			this.servico = servico;
			this.ativo = ativo;
			this.dias = dias;
			this.venpro = venpro;			
			this.venser = venser;			
			this.conpro = conpro;			
			this.conser = conser;			
			this.filpro = filpro;			
			this.filser = filser;						
			this.frete = frete;
			this.introducao = introducao;
			this.fornecimento = fornecimento;
			this.garantia = garantia;
			this.condicao = condicao;
			this.aceite = aceite;			
			this.imprime_ipi = imprime_ipi;						
		}
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void BtnCopiaClick(object sender, EventArgs e)
		{
			if (edtCodigo.Text.Trim().Length == 0)
			{
				MessageBox.Show("Código", "Campo obrigatório", 
				                MessageBoxButtons.OK, 
				                MessageBoxIcon.Warning);
				edtCodigo.Focus();
				return;
			}
			string msg="";
			cCaracteristicas caracteristicas = new cCaracteristicas();
			novo_codigo = edtCodigo.Text.Trim();
			if (!caracteristicas.Copia(edtCodigo.Text.Trim(), parceiro, codigo_origem, formula, formula_pedido, consultor, vendedor, filial, limiar, observacao, racional, servico, ativo, dias, venpro, venser, conpro, conser, filpro, filser, frete, introducao, fornecimento, garantia, condicao, aceite, imprime_ipi, ref msg))
			{
				MessageBox.Show(edtCodigo.Text, "Erro na cópia da característica", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			Close();
		}
	}
}
