/*
 * Projeto  : SoftPlace
 * Sistema  : CPD
 * Programa : fConParceiros - Consulta de Parceiros
 * Autor    : Ricardo Costa Xavier
 * Data     : 17/04/08
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using templates;

namespace basico
{
	public partial class frmConParceiros : tConsulta
	{
		public frmConParceiros()
		{
			InitializeComponent();
			edtCodigo.CharacterCasing = CharacterCasing.Upper;			
		}
		
		void GrpPessoaEnter(object sender, EventArgs e)
		{
			
		}
		
		void BtnLimpaClick(object sender, EventArgs e)
		{
			ckbFisica.Checked = true;
			ckbJuridica.Checked = true;
			ckbCliente.Checked = true;
			ckbFornecedor.Checked = true;
			ckbConsultor.Checked = true;
		}
		
		void BtnConfirmaClick(object sender, EventArgs e)
		{
			bool where=true;
			string codigo = edtCodigo.Text.Trim();
			string descricao = edtDescricao.Text.Trim();
			
			if (codigo.CompareTo("") != 0)
			{
				if (codigo.Contains("*")) 
					filtro = filtro + "where COD_PARCEIRO like '" + codigo.Replace('*', '%') + "'";
				else
					filtro = filtro + "where COD_PARCEIRO='" + codigo + "'";
				where = false;
			}
			
			if (descricao.CompareTo("") != 0)
			{
				if (where) 
					filtro = filtro + "where ";
				else
					filtro = filtro + " and ";
				if (descricao.Contains("*")) 
				{
					descricao.Replace('*', '%');
					filtro = filtro + "DES_PARCEIRO like '" + codigo + "'";
				}
				else
					filtro = filtro + "DES_PARCEIRO='" + codigo + "'";
				where = false;
			}
			
			if (ckbFisica.Checked && !ckbJuridica.Checked)
			{
				if (where) 
					filtro = filtro + "where IDT_FISJUR='F'";
				else
					filtro = filtro + " and IDT_FISJUR='F'";
				where = false;
			}
			
			if (!ckbFisica.Checked && ckbJuridica.Checked)
			{
				if (where) 
					filtro = filtro + "where IDT_FISJUR='J'";
				else
					filtro = filtro + " and IDT_FISJUR='J'";
				where = false;
			}
			
			if (!ckbCliente.Checked)
			{
				if (where) 
					filtro = filtro + "where IDT_CLIENTE<>'S'";
				else
					filtro = filtro + " and IDT_CLIENTE<>'S'";
				where = false;
			}
			
			if (!ckbFornecedor.Checked)
			{
				if (where) 
					filtro = filtro + "where IDT_FORNECEDOR<>'S'";
				else
					filtro = filtro + " and IDT_FORNECEDOR<>'S'";
				where = false;
			}
			
			if (!ckbConsultor.Checked)
			{
				if (where) 
					filtro = filtro + "where IDT_CONSULTOR<>'S'";
				else
					filtro = filtro + " and IDT_CONSULTOR<>'S'";
				where = false;
			}
			Close();
		}
		
		void BtnCancelaClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void FrmConParceirosLoad(object sender, EventArgs e)
		{
		}
	}
}
