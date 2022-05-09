/*
 * Projeto  : SoftPlace
 * Sistema  : CPD
 * Programa : MainForm - Form Principal
 * Autor    : Ricardo Costa Xavier
 * Data     : 22/03/2008
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using templates;
using classes;

namespace cpd
{
	public partial class MainForm : tMenu
	{
		[STAThread]
		public static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm(args));
		}
		
		public MainForm(string [] args)
		{
			InitializeComponent();
			admin = true;
			if (args.Length > 0) 
			{
				login = false;
				Globais.sUsuario = args[0];
				Globais.sFilial = args[1];
				Globais.bAdministrador = args[2][0] == 'S';
			}
			else login = true;
		}
		
		void MniSairClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void MniUsuariosClick(object sender, EventArgs e)
		{
			frmCadUsuarios frm = new frmCadUsuarios();
			frm.ShowDialog();
		}
		
		void MniFiliaisClick(object sender, EventArgs e)
		{
			frmCadFiliais frm = new frmCadFiliais();
			frm.ShowDialog();
		}
		
		void MniSistemasClick(object sender, EventArgs e)
		{
			frmCadSistemas frm = new frmCadSistemas();
			frm.ShowDialog();
		}
		
		void MniControleAcessoClick(object sender, EventArgs e)
		{
			frmControleAcesso frm = new frmControleAcesso();
			frm.ShowDialog();
		}
		
		void MniSobreClick(object sender, EventArgs e)
		{
			frmSobre frm = new frmSobre();
			frm.ShowDialog();
		}
		void MensagensToolStripMenuItemClick(object sender, EventArgs e)
		{
			fCadMensagens msg = new fCadMensagens();
			msg.ShowDialog();
		}
	}
}
