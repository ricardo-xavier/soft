/*
 * Criado por SharpDevelop.
 * Usuário: Ricardo
 * Data: 05/09/2008
 * Hora: 21:36
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using classes;

namespace receber
{
	/// <summary>
	/// Description of fParametrosRemessa.
	/// </summary>
	public partial class fParametrosRemessa : Form
	{
		public fParametrosRemessa()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void FParametrosRemessaLoad(object sender, EventArgs e)
		{
			cParametrosRemessa prms = new cParametrosRemessa();
			prms.Le();
			edtCodigo.Text = prms.COD_EMPRESA;
			edtRazao.Text = prms.NOM_EMPRESA;
			edtRemessa.Text = prms.NRO_REMESSA.ToString();
			edtNosso.Text = prms.NRO_NOSSO.ToString();
			edtCarteira.Text = prms.COD_CARTEIRA.ToString();
			edtAgencia.Text = prms.COD_AGENCIA.ToString();
			edtDVAgencia.Text = prms.DIG_AGENCIA.ToString();
			edtConta.Text = prms.COD_CONTA.ToString();
			edtDVConta.Text = prms.DIG_CONTA.ToString();
			edtMulta.Text = prms.PER_MULTA.ToString("#0.00");
			edtBonificacao.Text = prms.VLR_BONIFICACAO.ToString("##,###,##0.00");
			edtAtraso.Text = prms.VLR_ATRASO.ToString("#,###,###,##0.00");
			edtPrazo.Text = prms.QTD_PRAZO_DESCONTO.ToString();
			edtDesconto.Text = prms.VLR_DESCONTO.ToString("#,###,###,##0.00");
			edtMsg1.Text = prms.DES_MENSAGEM1;
			edtMsg2.Text = prms.DES_MENSAGEM2;
			edtMsg3.Text = prms.DES_MENSAGEM3;
			edtMsg4.Text = prms.DES_MENSAGEM4;
		}
		
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			cParametrosRemessa prms = new cParametrosRemessa();
			prms.COD_EMPRESA = edtCodigo.Text;
			prms.NOM_EMPRESA = edtRazao.Text;
			prms.NRO_REMESSA = Globais.StrToInt(edtRemessa.Text);
			prms.NRO_NOSSO = Globais.StrToInt(edtNosso.Text);
			prms.COD_CARTEIRA = Globais.StrToInt(edtCarteira.Text);
			prms.COD_AGENCIA = Globais.StrToInt(edtAgencia.Text);
			prms.DIG_AGENCIA = Globais.StrToShort(edtDVAgencia.Text);
			prms.COD_CONTA = Globais.StrToInt(edtConta.Text);
			prms.DIG_CONTA = Globais.StrToShort(edtDVConta.Text);
			prms.PER_MULTA = Globais.StrToFloat(edtMulta.Text);
			prms.VLR_BONIFICACAO = Globais.StrToFloat(edtBonificacao.Text);
			prms.VLR_ATRASO = Globais.StrToFloat(edtAtraso.Text);
			prms.QTD_PRAZO_DESCONTO = Globais.StrToShort(edtPrazo.Text);
			prms.VLR_DESCONTO = Globais.StrToFloat(edtDesconto.Text);
			prms.DES_MENSAGEM1 = edtMsg1.Text;
			prms.DES_MENSAGEM2 = edtMsg2.Text;
			prms.DES_MENSAGEM3 = edtMsg3.Text;
			prms.DES_MENSAGEM4 = edtMsg4.Text;
			string msg="";
			if (!prms.Altera(ref msg))
			{
				MessageBox.Show(msg, "Erro na gravação", MessageBoxButtons.OK, MessageBoxIcon.Error);				
			}
			Close();
		}
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
