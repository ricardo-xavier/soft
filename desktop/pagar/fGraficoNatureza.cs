/*
 * Criado por SharpDevelop.
 * Usuário: Ricardo
 * Data: 27/07/2008
 * Hora: 21:46
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
	public partial class fGraficoNatureza : Form
	{
		//private bool selecionado;
		cTitulosPagar titulos_pagar;
		cTitulosXeceber titulos_receber;
		ArrayList valores;
		ArrayList descricoes;
		private char origem;
		
		public fGraficoNatureza(char origem)
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
			
			Graphics g = e.Graphics;
			Pen blackPen =  new Pen(Color.Black, 1);
		    Rectangle rect =  new Rectangle(0, 0, 200, 200);
     		g.DrawPie(blackPen, rect, 0, 30);
     		SolidBrush brush = new SolidBrush(Color.Red);
     		g.FillPie(brush, rect, 0, 30);
     		*/
		}
		
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			valores.Clear();
			descricoes.Clear();
			if (origem == 'p')
				titulos_pagar.AgrupaPorVencimento(dtpInicial.Value, dtpFinal.Value, ref valores, ref descricoes, 11);
			else
				titulos_receber.AgrupaPorVencimento(dtpInicial.Value, dtpFinal.Value, ref valores, ref descricoes, 11);
			
			FileStream fs = new FileStream("despesas_natureza.pdf", FileMode.Create);
			Document doc = new Document(PageSize.LETTER.Rotate());
			PdfWriter writer = PdfWriter.GetInstance(doc, fs);
			doc.Open();
			PdfContentByte buf = writer.DirectContent;
			Graficos.Cabecalho(doc, "Despesas x Natureza", "");
			Graficos.Pizza(buf, valores, descricoes, 200, 250, 120);
			doc.NewPage();
			if (origem == 'p')
				cTitulosPagar.GeraDespesasNatureza(doc, dtpInicial.Value, dtpFinal.Value);
			else
				cTitulosXeceber.GeraDespesasNatureza(doc, dtpInicial.Value, dtpFinal.Value);;
			doc.Close();
			System.Diagnostics.Process.Start("explorer", "despesas_natureza.pdf");
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
						c1.BackColor = System.Drawing.Color.FromArgb(255, 255, 0, 0);
						break;
					case 1:
						v2.Text = valor;
						d2.Text = descricao;
						v2.Visible = true;
						c2.Visible = true;
						d2.Visible = true;
						c2.BackColor = System.Drawing.Color.FromArgb(255, 0, 255, 0);						
						break;
					case 2:
						v3.Text = valor;
						d3.Text = descricao;
						v3.Visible = true;
						c3.Visible = true;
						d3.Visible = true;
						c3.BackColor = System.Drawing.Color.FromArgb(255, 0, 0, 255);						
						break;
					case 3:
						v4.Text = valor;
						d4.Text = descricao;
						v4.Visible = true;
						c4.Visible = true;
						d4.Visible = true;
						c4.BackColor = System.Drawing.Color.FromArgb(255, 255, 255, 0);						
						break;
					case 4:
						v5.Text = valor;
						d5.Text = descricao;
						v5.Visible = true;
						c5.Visible = true;
						d5.Visible = true;
						c5.BackColor = System.Drawing.Color.FromArgb(255, 0, 255, 255);						
						break;
					case 5:
						v6.Text = valor;
						d6.Text = descricao;
						v6.Visible = true;
						c6.Visible = true;
						d6.Visible = true;
						c6.BackColor = System.Drawing.Color.FromArgb(255, 255, 0, 255);												
						break;
					case 6:
						v7.Text = valor;
						d7.Text = descricao;
						v7.Visible = true;
						c7.Visible = true;
						d7.Visible = true;
						c7.BackColor = System.Drawing.Color.FromArgb(255, 255, 128, 0);
						break;
					case 7:
						v8.Text = valor;
						d8.Text = descricao;
						v8.Visible = true;
						c8.Visible = true;
						d8.Visible = true;
						c8.BackColor = System.Drawing.Color.FromArgb(255, 0, 255, 128);
						break;
					case 8:
						v9.Text = valor;
						d9.Text = descricao;
						v9.Visible = true;
						c9.Visible = true;
						d9.Visible = true;
						c9.BackColor = System.Drawing.Color.FromArgb(255, 128, 0, 255);
						break;
					case 9:
						v10.Text = valor;
						d10.Text = descricao;
						v10.Visible = true;
						c10.Visible = true;
						d10.Visible = true;
						c10.BackColor = System.Drawing.Color.FromArgb(255, 255, 128, 128);
						break;
					case 10:
						v11.Text = valor;
						d11.Text = descricao;
						v11.Visible = true;
						c11.Visible = true;
						d11.Visible = true;
						c11.BackColor = System.Drawing.Color.FromArgb(255, 128, 255, 128);
						break;
					case 11:
						v12.Text = valor;
						d12.Text = descricao;
						v12.Visible = true;
						c12.Visible = true;
						d12.Visible = true;
						c12.BackColor = System.Drawing.Color.FromArgb(255, 128, 128, 255);
						break;
				}
				
			}
			selecionado = true;
			pnlGrafico.Refresh();
			*/
		}
		
		void FGraficoNaturezaLoad(object sender, EventArgs e)
		{
			//selecionado = false;
		}
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void BtnListaClick(object sender, EventArgs e)
		{
			if (valores == null) return;
			ArrayList valores_lista = new ArrayList();
			ArrayList descricoes_lista = new ArrayList();
			if (origem == 'p')
				titulos_pagar.AgrupaPorVencimento(dtpInicial.Value, dtpFinal.Value, ref valores_lista, ref descricoes_lista, 99999);
			else
				titulos_receber.AgrupaPorVencimento(dtpInicial.Value, dtpFinal.Value, ref valores_lista, ref descricoes_lista, 99999);			
			if (titulos_pagar.Lista("por_natureza.pdf", descricoes_lista, valores_lista, origem))
				System.Diagnostics.Process.Start("explorer", "por_natureza.pdf");
			valores_lista.Clear();
			descricoes_lista.Clear();			
		}
	}
}
