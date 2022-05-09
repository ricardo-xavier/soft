/*
 * Projeto  : SoftPlace
 * Sistema  : CPD
 * Programa : fControleAcesso - Controle de Acesso
 * Autor    : Ricardo Costa Xavier
 * Data     : 26/03/2008
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using classes;

namespace cpd
{
	public partial class frmControleAcesso : Form
	{
		private cUsuarios usuarios;
		private cFiliais filiais;
		private cSistemas sistemas;
		private cProgramas programas;
		private cControleAcesso controle;
		private int iUsuario, iFilial, iSistema;
		
		public frmControleAcesso()
		{
			InitializeComponent();
		}
		
		void ColoreFiliais()
		{
			string usuario = dbgUsuarios.Rows[iUsuario].Cells[0].Value.ToString().Trim();
			FbCommand cmd =  new FbCommand("select 1 from USUARIOS_FILIAIS where COD_USUARIO=@usuario and COD_FILIAL=@filial", Globais.bd);
			FbDataReader reader;
			cmd.Parameters.Add("@usuario", FbDbType.Char);
			cmd.Parameters.Add("@filial", FbDbType.Char);
			foreach (DataGridViewRow row in  dbgFiliais.Rows)
			{
				DataGridViewCell cell = row.Cells[0];
				string filial = cell.Value.ToString().Trim();
				cmd.Parameters["@usuario"].Value = usuario;
				cmd.Parameters["@filial"].Value = filial;
				reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
				if (!reader.Read())
				{
					row.DefaultCellStyle.BackColor = Color.Red;			
					row.DefaultCellStyle.SelectionBackColor = Color.Red;
				}
				else
				{
					row.DefaultCellStyle.BackColor = Color.Green;
					row.DefaultCellStyle.SelectionBackColor = Color.Green;
				}
				reader.Close();
			}			
		}
		
		void ColoreSistemas()
		{
			string usuario = dbgUsuarios.Rows[iUsuario].Cells[0].Value.ToString().Trim();
			string filial = dbgFiliais.Rows[iFilial].Cells[0].Value.ToString().Trim();
			FbCommand cmd =  new FbCommand("select 1 from USUARIOS_SISTEMAS where COD_USUARIO=@usuario and COD_FILIAL=@filial and COD_SISTEMA=@sistema", Globais.bd);
			FbDataReader reader;
			cmd.Parameters.Add("@usuario", FbDbType.Char);
			cmd.Parameters.Add("@filial", FbDbType.Char);
			cmd.Parameters.Add("@sistema", FbDbType.Integer);			
			foreach (DataGridViewRow row in  dbgSistemas.Rows)
			{
				DataGridViewCell cell = row.Cells[0];
				int sistema  = Globais.StrToInt(cell.Value.ToString());
				cmd.Parameters["@usuario"].Value = usuario;
				cmd.Parameters["@filial"].Value = filial;
				cmd.Parameters["@sistema"].Value = sistema;
				reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
				if (!reader.Read()) 
				{
					row.DefaultCellStyle.BackColor = Color.Red;			
					row.DefaultCellStyle.SelectionBackColor = Color.Red;
				}
				else
				{
					row.DefaultCellStyle.BackColor = Color.Green;
					row.DefaultCellStyle.SelectionBackColor = Color.Green;
				}
				reader.Close();
			}			
		}
		
		void ColoreProgramas()
		{
			string usuario = dbgUsuarios.Rows[iUsuario].Cells[0].Value.ToString().Trim();
			string filial = dbgFiliais.Rows[iFilial].Cells[0].Value.ToString().Trim();
			int sistema = Globais.StrToInt(dbgSistemas.Rows[iSistema].Cells[0].Value.ToString());
			FbCommand cmd =  new FbCommand("select 1 from USUARIOS_PROGRAMAS where COD_USUARIO=@usuario and COD_FILIAL=@filial and COD_SISTEMA=@sistema and COD_PROGRAMA=@programa", Globais.bd);
			FbDataReader reader;
			cmd.Parameters.Add("@usuario", FbDbType.Char);
			cmd.Parameters.Add("@filial", FbDbType.Char);
			cmd.Parameters.Add("@sistema", FbDbType.Integer);			
			cmd.Parameters.Add("@programa", FbDbType.Char);			
			foreach (DataGridViewRow row in  dbgProgramas.Rows)
			{
				DataGridViewCell cell = row.Cells[0];
				string programa  = cell.Value.ToString().Trim();
				cmd.Parameters["@usuario"].Value = usuario;
				cmd.Parameters["@filial"].Value = filial;
				cmd.Parameters["@sistema"].Value = sistema;
				cmd.Parameters["@programa"].Value = programa;
				reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
				if (!reader.Read()) 
				{
					row.DefaultCellStyle.BackColor = Color.Red;			
					row.DefaultCellStyle.SelectionBackColor = Color.Red;
				}
				else
				{
					row.DefaultCellStyle.BackColor = Color.Green;
					row.DefaultCellStyle.SelectionBackColor = Color.Green;
				}
				reader.Close();
			}			
		}
		
		void CarregaProgramas()
		{
			int sistema = Globais.StrToInt(dbgSistemas.Rows[iSistema].Cells[0].Value.ToString());
			programas = new cProgramas();
			this.Cursor = Cursors.WaitCursor;
			programas.Carrega(dbgProgramas, sistema);
			this.Cursor = Cursors.Default;
		}
			
		void FrmControleAcessoLoad(object sender, EventArgs e)
		{
			controle = new cControleAcesso();
			
			usuarios = new cUsuarios();
			this.Cursor = Cursors.WaitCursor;
			usuarios.Carrega(dbgUsuarios, "where IDT_ADMINISTRADOR <> 'S'");
			this.Cursor = Cursors.Default;
			if (dbgUsuarios.Rows.Count == 0) Close();
			iUsuario = 0;
			
			filiais = new cFiliais();
			this.Cursor = Cursors.WaitCursor;
			filiais.Carrega(dbgFiliais);
			this.Cursor = Cursors.Default;
			if (dbgFiliais.Rows.Count == 0) Close();
			iFilial = 0;
			
			sistemas = new cSistemas();
			this.Cursor = Cursors.WaitCursor;
			sistemas.Carrega(dbgSistemas, "where COD_SISTEMA <> 1");
			this.Cursor = Cursors.Default;
			if (dbgSistemas.Rows.Count == 0) Close();
			iSistema = 0;
			
			ColoreFiliais();
			ColoreSistemas();
			CarregaProgramas();
			ColoreProgramas();
		}
		
		void DbgUsuariosCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (iUsuario == e.RowIndex) return;
			iUsuario = e.RowIndex;
			ColoreFiliais();
			ColoreSistemas();
			ColoreProgramas();
		}
		
		void DbgFiliaisCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (iFilial == e.RowIndex) return;
			iFilial = e.RowIndex;
			ColoreSistemas();
			ColoreProgramas();
		}
		
		void DbgSistemasCellClick(object sender, DataGridViewCellEventArgs e)
		{
			int i = e.RowIndex;
			int j = iSistema;
			if (iSistema == e.RowIndex) return;
			iSistema = e.RowIndex;
			CarregaProgramas();
			ColoreProgramas();
		}
		
		void DbgFiliaisCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			string msg="";
			iFilial = e.RowIndex;
			DataGridViewRow row = dbgFiliais.Rows[iFilial];
			if (row.DefaultCellStyle.BackColor == Color.Green)
			{
				row.DefaultCellStyle.BackColor = Color.Red;
				row.DefaultCellStyle.SelectionBackColor = Color.Red;
				controle.ExcluiFilial(dbgUsuarios.Rows[iUsuario].Cells[0].Value.ToString().Trim(),
				                      dbgFiliais.Rows[iFilial].Cells[0].Value.ToString().Trim(),
				                      ref msg);				
			}
			else
			{
				row.DefaultCellStyle.BackColor = Color.Green;			
				row.DefaultCellStyle.SelectionBackColor = Color.Green;			
				controle.IncluiFilial(dbgUsuarios.Rows[iUsuario].Cells[0].Value.ToString().Trim(),
				                      dbgFiliais.Rows[iFilial].Cells[0].Value.ToString().Trim(),
				                      ref msg);
			}
			DbgFiliaisCellClick(sender, e);
		}		
		
		void DbgSistemasCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			string msg="";
			iSistema = e.RowIndex;
			DataGridViewRow row = dbgSistemas.Rows[iSistema];
			if (row.DefaultCellStyle.BackColor == Color.Green)
			{
				row.DefaultCellStyle.BackColor = Color.Red;
				row.DefaultCellStyle.SelectionBackColor = Color.Red;
				controle.ExcluiSistema(dbgUsuarios.Rows[iUsuario].Cells[0].Value.ToString().Trim(),
				                      dbgFiliais.Rows[iFilial].Cells[0].Value.ToString().Trim(),
				                      Globais.StrToInt(dbgSistemas.Rows[iSistema].Cells[0].Value.ToString()),
				                      ref msg);		
			}
			else
			{
				row.DefaultCellStyle.BackColor = Color.Green;			
				row.DefaultCellStyle.SelectionBackColor = Color.Green;			
				controle.IncluiSistema(dbgUsuarios.Rows[iUsuario].Cells[0].Value.ToString().Trim(),
				                      dbgFiliais.Rows[iFilial].Cells[0].Value.ToString().Trim(),
				                      Globais.StrToInt(dbgSistemas.Rows[iSistema].Cells[0].Value.ToString()),
				                      ref msg);				
			}
			DbgSistemasCellClick(sender, e);
		}
		
		void DbgProgramasCellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			string msg="";
			int iPrograma = e.RowIndex;
			DataGridViewRow row = dbgProgramas.Rows[iPrograma];
			if (row.DefaultCellStyle.BackColor == Color.Green)
			{
				row.DefaultCellStyle.BackColor = Color.Red;
				row.DefaultCellStyle.SelectionBackColor = Color.Red;
				controle.ExcluiPrograma(dbgUsuarios.Rows[iUsuario].Cells[0].Value.ToString().Trim(),
				                      dbgFiliais.Rows[iFilial].Cells[0].Value.ToString().Trim(),
				                      Globais.StrToInt(dbgSistemas.Rows[iSistema].Cells[0].Value.ToString()),
				                      dbgProgramas.Rows[iPrograma].Cells[0].Value.ToString().Trim(),
				                      ref msg);		
			}
			else
			{
				row.DefaultCellStyle.BackColor = Color.Green;			
				row.DefaultCellStyle.SelectionBackColor = Color.Green;			
				controle.IncluiPrograma(dbgUsuarios.Rows[iUsuario].Cells[0].Value.ToString().Trim(),
				                      dbgFiliais.Rows[iFilial].Cells[0].Value.ToString().Trim(),
				                      Globais.StrToInt(dbgSistemas.Rows[iSistema].Cells[0].Value.ToString()),
				                      dbgProgramas.Rows[iPrograma].Cells[0].Value.ToString().Trim(),				                      
				                      ref msg);				
			}
		}
	}
}
