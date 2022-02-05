/*
 * Projeto  : SoftPlace
 * Sistema  : CPD
 * Programa : fEditaMemo - Edicao Ampliada de Memo
 * Autor    : Ricardo Costa Xavier
 * Data     : 21/04/08
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace basico
{
	public partial class frmEditaMemo : Form
	{
		public bool ok;
		
		public frmEditaMemo()
		{
			InitializeComponent();
			ok = false;
		}
		
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			ok = true;
			Close();
		}
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
