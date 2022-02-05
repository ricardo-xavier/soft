/*
 * Projeto  : SoftPlace
 * Programa : tMenu - Template de Menu
 * Autor    : Ricardo Costa Xavier
 * Data     : 02/04/08
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Xml;
using classes;
using System.IO;

namespace templates
{
	public partial class tMenu : Form
	{
		public bool   login;
		public bool   admin;
		public string sSenha;		
		private string sBanco;
		private string sUltimoUsuario;
		private string sUltimaFilial;
		
		public tMenu()
		{
			InitializeComponent();
			if (File.Exists("imagens\\logo1.jpg"))
				imgSoftplace.Image = Image.FromFile("imagens\\logo1.jpg");			
			login = true;
		}
		
		void TMenuShown(object sender, EventArgs e)
		{
			if (login)
			{
				frmLogin frm = new frmLogin();
				frm.admin = admin;
				frm.sUltimoUsuario = sUltimoUsuario;
				frm.sUltimaFilial = sUltimaFilial;
				frm.ShowDialog();
				if (!frm.bOK)
				{
					Close();
				}
				else 
				{
					stUsuario.Text = "Usuário: " + Globais.sUsuario;
					stFilial.Text = "Filial: " + Globais.sFilial;
					XmlDocument xml = new XmlDocument();
					xml.Load("soft.xml");		
					XmlNodeList list;
					XmlNode node;
					list = xml.GetElementsByTagName("UltimoUsuario");			
					node = list[0];
					node.InnerText = Globais.sUsuario;
					list = xml.GetElementsByTagName("UltimaFilial");			
					node = list[0];
					node.InnerText = Globais.sFilial;
					xml.Save("soft.xml");		
				}
			}
			else
			{
				stUsuario.Text = "Usuário: " + Globais.sUsuario;
				stFilial.Text = "Filial: " + Globais.sFilial;
			}
		}
		
		void TMenuLoad(object sender, EventArgs e)
		{
			XmlDocument xml = new XmlDocument();
			xml.Load("soft.xml");		
			XmlNodeList list;
			XmlNode node;
			list = xml.GetElementsByTagName("BancoDados");			
			node = list[0];
			sBanco = node.InnerText;
			list = xml.GetElementsByTagName("UltimoUsuario");			
			node = list[0];
			sUltimoUsuario = node.InnerText;
			list = xml.GetElementsByTagName("UltimaFilial");			
			node = list[0];
			sUltimaFilial = node.InnerText;
			string parametros = "User=SYSDBA;" +
								"Password=masterkey;" +
								"Database=" + sBanco;
			Globais.bd = new FbConnection(parametros);
			try
			{
				Log.Grava(Globais.sUsuario, parametros);
				Globais.bd.Open();
				//Trace.Verifica();
			}
			catch (Exception err)
			{
				Log.Grava(Globais.sUsuario, "erro:" + err.Message);
				MessageBox.Show("Erro na conexão com o banco de dados:\n" + sBanco +
				                "\n" + err.Message);
				Close();
			}
		}
	}
}
