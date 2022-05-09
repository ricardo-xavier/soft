/*
 * Criado por SharpDevelop.
 * Usuário: Ricardo
 * Data: 12/09/2008
 * Hora: 18:55
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */

using System;
using System.Drawing;
using System.Windows.Forms;

namespace pagar
{
	/// <summary>
	/// Description of fSelecaoQuebra.
	/// </summary>
	public partial class fSelecaoQuebra : Form
	{
		public char quebra;
		
		public fSelecaoQuebra()
		{
			InitializeComponent();
		}
		
		void FSelecaoQuebraLoad(object sender, EventArgs e)
		{
			quebra = 'c';			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			quebra = 'v';
			Close();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			quebra = 'p';
			Close();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			Close();
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			quebra = 'n';
			Close();
		}
	}
}
