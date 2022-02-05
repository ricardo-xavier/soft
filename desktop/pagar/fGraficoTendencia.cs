/*
 * Criado por SharpDevelop.
 * Usuário: Ricardo
 * Data: 07/08/2008
 * Hora: 22:34
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using classes;
using System.Collections;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace pagar
{
	public partial class fGraficoTendencia : Form
	{
		cTitulosPagar titulos_pagar;
		cTitulosXeceber titulos_receber;
		ArrayList valores;
		ArrayList datas;		
		//private float d;
		private char origem;
		
		public fGraficoTendencia(char origem)
		{
			this.origem = origem;
			InitializeComponent();
			if (origem == 'p')
				titulos_pagar = new cTitulosPagar();
			else
				titulos_receber = new cTitulosXeceber();
			valores = new ArrayList();
			datas = new ArrayList();
			dtpInicial.Value = DateTime.Now;
			int d = DateTime.Now.Day;
			int m = DateTime.Now.Month;
			int a = DateTime.Now.Year;
			System.Globalization.CultureInfo _ci =  new System.Globalization.CultureInfo("en-US");
			dtpInicial.Value = DateTime.Parse(string.Format("{0}/{1}/{2}", m, 1, a), _ci);
			if (m == 12) a++;
			else m++;
			dtpFinal.Value = DateTime.Parse(string.Format("{0}/{1}/{2}", m, 1, a), _ci).AddDays(-1);
		}
		
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			string natureza = cbxNaturezas.Text.Trim();
			if (natureza.Length == 0)
			{
				MessageBox.Show("Natureza", "Campo Obrigatório", 
				                MessageBoxButtons.OK, 
				                MessageBoxIcon.Warning);
				cbxNaturezas.Focus();
				return;			
			}
			
			int mes=dtpInicial.Value.Month, ano=dtpInicial.Value.Year, n=0;
			while ((ano < dtpFinal.Value.Year) || ((ano == dtpFinal.Value.Year) && (mes <= dtpFinal.Value.Month))) {
				n++;
				mes++;
				if (mes > 12)
				{
					mes = 1;
					ano++;
				}				
			}
			if (n > 12) {
				MessageBox.Show("O período selecionado deve ser de no máximo 12 meses", "Intervalo", 
				                MessageBoxButtons.OK, 
				                MessageBoxIcon.Warning);
				cbxNaturezas.Focus();
				return;							
			}
			
			n = cbxNaturezas.SelectedIndex;	
			natureza = cbxCodNaturezas.Items[n].ToString();
			string des_natureza = cbxNaturezas.Items[n].ToString();
			valores.Clear();
			datas.Clear();
			float max=0;
			if (origem == 'p')
				max = titulos_pagar.SomaPorVencimento(natureza, dtpInicial.Value, dtpFinal.Value, ref valores, ref datas);
			else
				max = titulos_receber.SomaPorVencimento(natureza, dtpInicial.Value, dtpFinal.Value, ref valores, ref datas);
			
			FileStream fs = new FileStream("tendencia.pdf", FileMode.Create);
			Document doc = new Document(PageSize.LETTER.Rotate());
			PdfWriter writer = PdfWriter.GetInstance(doc, fs);
			doc.Open();
			PdfContentByte buf = writer.DirectContent;
			Graficos.Cabecalho(doc, "Tendência", des_natureza);
			Graficos.Barras(buf, valores, datas, 150, max);
			doc.Close();
			System.Diagnostics.Process.Start("explorer", "tendencia.pdf");
			Close();
			/*
			float vlr=100;
			while (vlr < max) vlr *= 2;
			d = vlr / 10;
			label12.Text = vlr.ToString("#,###,##0.00"); vlr-=d;
			label11.Text = vlr.ToString("#,###,##0.00"); vlr-=d;
			label10.Text = vlr.ToString("#,###,##0.00"); vlr-=d;
			label9.Text = vlr.ToString("#,###,##0.00"); vlr-=d;
			label8.Text = vlr.ToString("#,###,##0.00"); vlr-=d;
			label7.Text = vlr.ToString("#,###,##0.00"); vlr-=d;
			label6.Text = vlr.ToString("#,###,##0.00"); vlr-=d;
			label5.Text = vlr.ToString("#,###,##0.00"); vlr-=d;
			label4.Text = vlr.ToString("#,###,##0.00"); vlr-=d;
			label3.Text = vlr.ToString("#,###,##0.00"); 
			int i=0;
			int x=115;
			Pen pen = new Pen(Color.Black, 1);
			foreach (string descricao in datas)
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
					case 2:
						v3.Text = valor;
						d3.Text = descricao;
						v3.Visible = true;
						c3.Visible = true;
						d3.Visible = true;
						c3.BackColor = Color.FromArgb(255, 0, 0, 255);						
						break;
					case 3:
						v4.Text = valor;
						d4.Text = descricao;
						v4.Visible = true;
						c4.Visible = true;
						d4.Visible = true;
						c4.BackColor = Color.FromArgb(255, 255, 255, 0);						
						break;
					case 4:
						v5.Text = valor;
						d5.Text = descricao;
						v5.Visible = true;
						c5.Visible = true;
						d5.Visible = true;
						c5.BackColor = Color.FromArgb(255, 0, 255, 255);						
						break;
					case 5:
						v6.Text = valor;
						d6.Text = descricao;
						v6.Visible = true;
						c6.Visible = true;
						d6.Visible = true;
						c6.BackColor = Color.FromArgb(255, 255, 0, 255);												
						break;
					case 6:
						v7.Text = valor;
						d7.Text = descricao;
						v7.Visible = true;
						c7.Visible = true;
						d7.Visible = true;
						c7.BackColor = Color.FromArgb(255, 255, 128, 0);
						break;
					case 7:
						v8.Text = valor;
						d8.Text = descricao;
						v8.Visible = true;
						c8.Visible = true;
						d8.Visible = true;
						c8.BackColor = Color.FromArgb(255, 0, 255, 128);
						break;
					case 8:
						v9.Text = valor;
						d9.Text = descricao;
						v9.Visible = true;
						c9.Visible = true;
						d9.Visible = true;
						c9.BackColor = Color.FromArgb(255, 128, 0, 255);
						break;
					case 9:
						v10.Text = valor;
						d10.Text = descricao;
						v10.Visible = true;
						c10.Visible = true;
						d10.Visible = true;
						c10.BackColor = Color.FromArgb(255, 255, 128, 128);
						break;
					case 10:
						v11.Text = valor;
						d11.Text = descricao;
						v11.Visible = true;
						c11.Visible = true;
						d11.Visible = true;
						c11.BackColor = Color.FromArgb(255, 128, 255, 128);
						break;
					case 11:
						v12.Text = valor;
						d12.Text = descricao;
						v12.Visible = true;
						c12.Visible = true;
						d12.Visible = true;
						c12.BackColor = Color.FromArgb(255, 128, 128, 255);
						break;
					case 12:
						v13.Text = valor;
						d13.Text = descricao;
						v13.Visible = true;
						c13.Visible = true;
						d13.Visible = true;
						c13.BackColor = Color.FromArgb(255, 128, 128, 0);
						break;						
				}
				x += 40;
			}
			pnlGrafico.Refresh();
			*/
		}
		
		void FGraficoTendenciaLoad(object sender, EventArgs e)
		{
			if (origem == 'p')
			{
				cNaturezasPagamento naturezas = new cNaturezasPagamento();
				this.Cursor = Cursors.WaitCursor;
				naturezas.Carrega(cbxNaturezas, cbxCodNaturezas);
				this.Cursor = Cursors.Default;
			}
			else
			{
				cNaturezasRecebimento naturezas = new cNaturezasRecebimento();
				this.Cursor = Cursors.WaitCursor;
				naturezas.Carrega(cbxNaturezas, cbxCodNaturezas);
				this.Cursor = Cursors.Default;
			}
		}
		
		void PnlGraficoPaint(object sender, PaintEventArgs e)
		{
			/*
			Pen pen = new Pen(Color.Black, 1);
			e.Graphics.DrawLine(pen, 110, 10, 110, 320);
			for (int y=320; y>=20; y-=30)
			{
				e.Graphics.DrawLine(pen, 100, y, 620, y);
			}
			for (int x=110; x<=620; x+=40)
			{
				e.Graphics.DrawLine(pen, x, 320, x, 325);
			}
			int x1=115;
			int i=0;
			int y1;
			SolidBrush brush=null;
			foreach (string descricao in datas)
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
						brush = new SolidBrush(Color.FromArgb(255, 255, 0, 0));
						break;
					case 1:
						brush = new SolidBrush(Color.FromArgb(255, 0, 255, 0));
						break;
					case 2:
						brush = new SolidBrush(Color.FromArgb(255, 0, 0, 255));
						break;
					case 3:
						brush = new SolidBrush(Color.FromArgb(255, 255, 255, 0));
						break;
					case 4:
						brush = new SolidBrush(Color.FromArgb(255, 0, 255, 255));
						break;
					case 5:
						brush = new SolidBrush(Color.FromArgb(255, 255, 0, 255));
						break;
					case 6:
						brush = new SolidBrush(Color.FromArgb(255, 255, 128, 0));
						break;
					case 7:
						brush = new SolidBrush(Color.FromArgb(255, 0, 255, 128));
						break;
					case 8:
						brush = new SolidBrush(Color.FromArgb(255, 128, 0, 255));
						break;
					case 9:
						brush = new SolidBrush(Color.FromArgb(255, 255, 128, 128));
						break;
					case 10:
						brush = new SolidBrush(Color.FromArgb(255, 128, 255, 128));
						break;
					case 11:
						brush = new SolidBrush(Color.FromArgb(255, 128, 128, 255));
						break;
					case 12:
						brush = new SolidBrush(Color.FromArgb(255, 128, 128, 0));
						break;						
				}
				y1 = 320 - ((int)(Globais.StrToFloat(valor) / d * 30));
				e.Graphics.FillRectangle(brush, x1, y1, 30, 320-y1);
				e.Graphics.DrawRectangle(pen, x1, y1, 30, 320-y1);
				x1 += 40;
			}
			*/
		}
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
