/*
 * Projeto  : SoftPlace
 * Programa : tSobre - Template Tela Sobre
 * Autor    : Ricardo Costa Xavier
 * Data     : 02/04/08
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace templates
{
	public partial class tSobre : Form
	{
		public tSobre()
		{
			InitializeComponent();
		}
		
		void BtnOKClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
