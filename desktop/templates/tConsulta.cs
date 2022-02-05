/*
 * Projeto  : SoftPlace
 * Sistema  : CPD
 * Programa : tConsulta - Template de Consultas
 * Autor    : Ricardo Costa Xavier
 * Data     : 17/04/08
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace templates
{
	public partial class tConsulta : Form
	{
		public string filtro;		
		public bool cancela;
		
		public tConsulta()
		{
			InitializeComponent();
		}
		
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			filtro = "";
			cancela = false;
		}
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			cancela = true;			
		}
		
		void BtnLimpaClick(object sender, EventArgs e)
		{
			edtCodigo.Text = "";
			edtDescricao.Text = "";
		}
	}
}
