/*
 * Projeto  : SoftPlace
 * Sistema  : CPD
 * Programa : fSobre - Tela Sobre
 * Autor    : Ricardo Costa Xavier
 * Data     : 02/04/08
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using templates;

namespace cpd
{
	public partial class frmSobre : tSobre
	{
		public frmSobre()
		{
			InitializeComponent();
			lblSistema.Text = "Módulo CPD";
			lblVersao.Text = "Versão 1.4.0 (24/10/11)";
		}
	}
}
