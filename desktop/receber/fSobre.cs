/*
 * Projeto  : SoftPlace
 * Sistema  : Faturamento
 * Programa : fSobre - Tela Sobre
 * Autor    : Ricardo Costa Xavier
 * Data     : 19/08/08
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using templates;

namespace receber
{
	public partial class fSobre : tSobre
	{
		public fSobre()
		{
			InitializeComponent();
			lblSistema.Text = "Módulo Faturamento";
			lblVersao.Text = "Versão 1.4.0 (24/10/11)";
		}
	}
}
