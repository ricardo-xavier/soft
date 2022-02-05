/*
 * Projeto  : SoftPlace
 * Programa : cContatos - Classe de Contatos
 * Autor    : Ricardo Costa Xavier
 * Data     : 13/04/08
 */
using System;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;

namespace classes
{
	public class cContatos
	{
		public cContatos()
		{
		}
		
		public void Carrega(DataGridView grid, string where)
		{
			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			adapter.SelectCommand = new FbCommand("select COD_CONTATO," +
												  "       NOM_CONTATO," +
												  "       NRO_FONE1," +												  
												  "       NRO_FONE2," +
												  "       NRO_CELULAR," +												  
												  "       DES_EMAIL, " +
												  "       DES_PAPEL, " +												  
												  "       IDT_ATIVO," +
												  "       DAT_NASCIMENTO " +
			                                      "from CONTATOS " +
			                                      where + " " +
			                                      "order by COD_PARCEIRO, COD_CONTATO", 
			                                      Globais.bd);
			adapter.Fill(table);
			table.Columns[0].ColumnName = "Código";
			table.Columns[1].ColumnName = "Nome";
			table.Columns[5].ColumnName = "Papel";
			grid.DataSource = table;
			grid.Columns[2].Visible = false; // fone1
			grid.Columns[3].Visible = false; // fone2			
			grid.Columns[4].Visible = false; // celular
			//grid.Columns[5].Visible = false; // papel
			grid.Columns[6].Visible = false; // email	
			grid.Columns[7].Visible = false; // ativo			
			grid.Columns[8].Visible = false; // nascimento
		}
		
		public bool Inclui(string parceiro, string codigo, string nome, string fone1, string fone2,
		                   string celular, string email, string papel, 
		                   bool idt_nascimento, DateTime dat_nascimento,		                   
		                   string ativo, ref string msg)
		{
			string sql = "insert into CONTATOS values(" +
						 "'"  + parceiro + "'," +
						 "'"  + codigo + "'," +
						 "'"  + nome + "'," +				
						 "'"  + fone1 + "'," +
						 "'"  + fone2 + "'," +
						 "'"  + celular + "'," +				
						 "'"  + email + "'," +
						 "'"  + papel + "'," +				
						 "'"  + ativo + "',";
			if (idt_nascimento)
				sql += "'" + dat_nascimento.ToString("M/d/yyyy") + "')";
			else
				sql += "null)";				
			FbCommand cmd = new FbCommand(sql, Globais.bd);
			try
			{
				Log.Grava(Globais.sUsuario, cmd.CommandText);
				cmd.ExecuteNonQuery();
			}
			catch (Exception err)
			{
				Log.Grava(Globais.sUsuario, "erro:" + err.Message);
				msg = err.Message;
				return false;
			}
			msg = "OK";
			return true;
		}
		
		public bool Altera(string parceiro, string codigo, string nome, 
		                   string fone1, string fone2, string celular,
		                   string email, string papel, 
		                   bool idt_nascimento, DateTime dat_nascimento,		                   		                   
		                   string ativo, ref string msg)
		{
			string sql = "update CONTATOS set " +
						 "nom_contato='" + nome + "', " + 
						 "nro_fone1='" + fone1 + "', " + 
						 "nro_fone2='" + fone2 + "', " + 
						 "nro_celular='" + celular + "', " + 				
						 "des_email='" + email + "', " + 				
						 "des_papel='" + papel + "', ";
			if (idt_nascimento)
				sql += "dat_nascimento='" + dat_nascimento.ToString("M/d/yyyy") + "',";				
			else
				sql += "dat_nascimento=null,";
			sql = sql +  "idt_ativo='" + ativo + "' " + 											
				    	 "where COD_PARCEIRO='" + parceiro + "' and " +				    	 	
				    	 "      COD_CONTATO='" + codigo + "'";
			FbCommand cmd = new FbCommand(sql, Globais.bd);
			try
			{
				Log.Grava(Globais.sUsuario, cmd.CommandText);
				cmd.ExecuteNonQuery();
			}
			catch (Exception err)
			{
				Log.Grava(Globais.sUsuario, "erro:" + err.Message);
				msg = err.Message;
				return false;
			}
			msg = "OK";
			return true;
		}
		
		public bool Exclui(string parceiro, string codigo, ref string msg)
		{
			string sql = "delete from CONTATOS " +
				    	 "where COD_PARCEIRO='" + parceiro + "' and " +
				    	 "      COD_CONTATO='" + codigo + "'";
			FbCommand cmd = new FbCommand(sql, Globais.bd);
			try
			{
				Log.Grava(Globais.sUsuario, cmd.CommandText);
				cmd.ExecuteNonQuery();
			}
			catch (Exception err)
			{
				Log.Grava(Globais.sUsuario, "erro:" + err.Message);
				msg = err.Message;
				return false;
			}
			msg = "OK";
			return true;
		}
		
		
		public string Email(string parceiro, string codigo)
		{
			string email="";
			FbCommand cmd =  new FbCommand("select DES_EMAIL from CONTATOS " +
				    	 "where COD_PARCEIRO='" + parceiro + "' and " +
				    	 "      COD_CONTATO='" + codigo + "'", 
 						 Globais.bd);				    	 
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			if (reader.Read())
				email = reader.GetString(0).Trim();
			reader.Close();
			return email;
		}
		
	}
}
