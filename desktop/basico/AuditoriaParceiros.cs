/*
 * Auditoria de Parceiros
 * User: Ricardo
 * Date: 12/07/2020
 * 
 */
using System;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;
using classes;

namespace basico
{
	public partial class AuditoriaParceiros : Form
	{
		public AuditoriaParceiros()
		{
			InitializeComponent();
		}
		
		void AuditoriaParceirosLoad(object sender, EventArgs e)
		{
		
			this.Cursor = Cursors.WaitCursor;			
			
			DataTable tabCpfCnpj = new DataTable();
			tabCpfCnpj.Columns.Add("Cpf/Cnpj", typeof(string));
			tabCpfCnpj.Columns.Add("Código", typeof(string));
			tabCpfCnpj.Columns.Add("Nome", typeof(string));
			
			List<Parceiro> repetidos = AuditoriaDao.AuditaCpfCnpj();
			foreach (Parceiro parceiro in repetidos)
			{
				tabCpfCnpj.Rows.Add(new object[] { parceiro.getCpfCnpj(), parceiro.getCodigo(), parceiro.getNome()});
			}
			
			dgvCpfCnpj.DataSource = tabCpfCnpj;
			dgvCpfCnpj.Columns["Cpf/Cnpj"].Width = 100;
			dgvCpfCnpj.Columns["Código"].Width = 150;
			dgvCpfCnpj.Columns["Nome"].Width = 350;
			
			DataTable tabFones = new DataTable();
			tabFones.Columns.Add("Fone1", typeof(string));
			tabFones.Columns.Add("Fone2", typeof(string));
			tabFones.Columns.Add("Celular", typeof(string));
			tabFones.Columns.Add("Código", typeof(string));
			tabFones.Columns.Add("Nome", typeof(string));
			
			repetidos = AuditoriaDao.AuditaFones();
			foreach (Parceiro parceiro in repetidos)
			{
				tabFones.Rows.Add(new object[] { 
				                  	FONE.PoeEdicao(parceiro.getFone1()),
									FONE.PoeEdicao(parceiro.getFone2()), 
									CELULAR.PoeEdicao(parceiro.getCelular()), 									
				                  	parceiro.getCodigo(), 
				                  	parceiro.getNome()});
			}
			
			dgvFones.DataSource = tabFones;
			dgvFones.Columns["Fone1"].Width = 100;
			dgvFones.Columns["Fone2"].Width = 100;
			dgvFones.Columns["Celular"].Width = 100;
			dgvFones.Columns["Código"].Width = 150;
			dgvFones.Columns["Nome"].Width = 350;
			
			this.Cursor = Cursors.Default;			

		}
		
		void BtnSairClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
