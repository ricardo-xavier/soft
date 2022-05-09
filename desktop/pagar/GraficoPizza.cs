/*
 * Desenha um gráfico de pizza
 * Ricardo Costa Xavier
 * 28/07/08
 * 
 */

using System;
using System.Drawing;
using System.Collections;

namespace graficos
{
	public class GraficoPizza
	{
		public GraficoPizza(Graphics g, ArrayList valores, ArrayList descricoes)
		{
			float total=0;
			float p=0, a=0;
			int cor=0;
			Color[] cores;
			
			foreach (float valor in valores)
			{
				total += valor;
			}
			cores = new Color[12];
			cores[0] = Color.FromArgb(255, 255, 0, 0);
			cores[1] = Color.FromArgb(255, 0, 255, 0);
			cores[2] = Color.FromArgb(255, 0, 0, 255);
			cores[3] = Color.FromArgb(255, 255, 255, 0);
			cores[4] = Color.FromArgb(255, 255, 0, 255);
			cores[5] = Color.FromArgb(255, 0, 255, 255);
			cores[6] = Color.FromArgb(255, 255, 128, 0);
			cores[7] = Color.FromArgb(255, 0, 255, 128);
			cores[8] = Color.FromArgb(255, 128, 0, 255);
			cores[9] = Color.FromArgb(255, 255, 128, 128);
			cores[10] = Color.FromArgb(255, 128, 255, 128);
			cores[11] = Color.FromArgb(255, 128, 128, 255);
			Rectangle area =  new Rectangle(10, 10, 250, 250);
			foreach (float valor in valores)
			{
				a = valor * 360F / total;
				SolidBrush brush = new SolidBrush(cores[cor++]);
     			g.FillPie(brush, area, p, a);
     			Pen pen = new Pen(Color.Black, 1);
     			g.DrawPie(pen, area, p, a);
     			p += a;
			}
		}
	}
}
