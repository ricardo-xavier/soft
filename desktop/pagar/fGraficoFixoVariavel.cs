/*
 * Criado por SharpDevelop.
 * Usuário: Ricardo
 * Data: 12/08/2008
 * Hora: 23:33
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using graficos;
using classes;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace pagar
{
	/// <summary>
	/// Description of fGraficoFixoVariavel.
	/// </summary>
	public partial class fGraficoFixoVariavel : Form
	{
		cTitulosPagar titulos_pagar;
		cTitulosXeceber titulos_receber;
		ArrayList valores;
		ArrayList descricoes;
		private char origem;
		
		public fGraficoFixoVariavel(char origem)
		{
			this.origem = origem;
			InitializeComponent();
			if (origem == 'p')
				titulos_pagar = new cTitulosPagar();
			else
				titulos_receber = new cTitulosXeceber();
			valores = new ArrayList();
			descricoes = new ArrayList();
			dtpInicial.Value = DateTime.Now;
			int d = DateTime.Now.Day;
			int m = DateTime.Now.Month;
			int a = DateTime.Now.Year;
			dtpInicial.Value = Globais.StrToDateTime(string.Format("{0}/{1}/{2}", m, 1, a));
			if (m == 12) a++;
			else m++;
			dtpFinal.Value = Globais.StrToDateTime(string.Format("{0}/{1}/{2}", m, 1, a)).AddDays(-1);
		}
		
		void PnlGraficoPaint(object sender, PaintEventArgs e)
		{
			/*
			if (!selecionado) return;
			GraficoPizza grafico = new GraficoPizza(e.Graphics, valores, descricoes);
			*/
		}
		
		void FGraficoFixoVariavelLoad(object sender, EventArgs e)
		{
			//selecionado = false;			
		}
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			valores.Clear();
			descricoes.Clear();
			if (origem == 'p')
				titulos_pagar.FixoVariavel(dtpInicial.Value, dtpFinal.Value, ref valores, ref descricoes);
			else
				titulos_receber.FixoVariavel(dtpInicial.Value, dtpFinal.Value, ref valores, ref descricoes);
						
			FileStream fs = new FileStream("fixo_variavel.pdf", FileMode.Create);
			Document doc = new Document(PageSize.LETTER.Rotate());
			PdfWriter writer = PdfWriter.GetInstance(doc, fs);
			doc.Open();
			PdfContentByte buf = writer.DirectContent;
			Graficos.Cabecalho(doc, "Fixo x Variável", "");
			Graficos.Pizza(buf, valores, descricoes, 200, 250, 120);
			doc.Close();
			System.Diagnostics.Process.Start("explorer", "fixo_variavel.pdf");
			Close();
			
			/*
			int i=0;
			foreach (string descricao in descricoes)
			{
				int j = 0;
				string valor="";
				foreach (float v in valores)
				{
					valor = v.ToString("#,###,##0.00");
					if (j++ == i) break;
				}
				switch (i++)
				{
					case 0:
						v1.Text = valor;
						d1.Text = descricao;
						v1.Visible = true;
						c1.Visible = true;
						d1.Visible = true;
						c1.BackColor = Color.FromArgb(255, 255, 0, 0);
						break;
					case 1:
						v2.Text = valor;
						d2.Text = descricao;
						v2.Visible = true;
						c2.Visible = true;
						d2.Visible = true;
						c2.BackColor = Color.FromArgb(255, 0, 255, 0);						
						break;
				}
				
			}
			selecionado = true;
			pnlGrafico.Refresh();
			*/
		}
	}
}
