/*
 * Criado por SharpDevelop.
 * Usuário: Ricardo
 * Data: 09/05/2009
 * Hora: 21:57
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using basico;

namespace pedido
{

	public partial class fAlteraValor : Form
	{
		public bool result;
	
		public fAlteraValor()
		{
			InitializeComponent();
			result = false;
		}
		
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			result = true;
			Close();
		}
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			result = false;
			Close();
		}
		
		void BtnConsultorClick(object sender, EventArgs e)
		{
			frmCadParceiros frmCad = new frmCadParceiros(true);
			frmCad.where = "";
			frmCad.bConsultores = true;
			frmCad.codigo = edtConsultor.Text;
			frmCad.ReadOnly = true;
			frmCad.ShowDialog();
			if (frmCad.result)
			{
				edtConsultor.Text = frmCad.edtCodigo.Text;
			}
			
		}
	}
}
