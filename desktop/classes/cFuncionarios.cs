/*
 * Projeto  : SoftPlace
 * Programa : cFuncionarios - Classe de Funcionarios
 * Autor    : Ricardo Costa Xavier
 * Data     : 08/04/08
 */
using System;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;

namespace classes
{
	public class cFuncionarios
	{
		public cFuncionarios()
		{
		}
		
		public void Carrega(DataGridView grid)
		{
			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			adapter.SelectCommand = new FbCommand("select cod_funcionario," +
			                                      "       nom_funcionario," +
												  "       des_logradouro," +
												  "       nro_endereco," +
												  "       des_complemento," +
												  "       nom_bairro," +
												  "       nom_cidade," +
												  "       cod_estado," +
												  "       nro_cep," +
												  "       nro_fone1," +
												  "       nro_fone2," +
												  "       nro_fone3," +
												  "       cod_cargo," +
												  "       des_email," +
												  "       idt_ativo," +
												  "       DAT_NASCIMENTO," +
												  "       nro_identidade," +
												  "       nro_cpf " +
			                                      "from funcionarios " +
			                                      "order by cod_funcionario", 
			                                      Globais.bd);
			adapter.Fill(table);
			table.Columns[0].ColumnName = "Código";
			table.Columns[1].ColumnName = "Nome";
			table.Columns[12].ColumnName = "Cargo";
			grid.DataSource = table;
			grid.Columns[2].Visible = false; // logradouro
			grid.Columns[3].Visible = false; // nro
			grid.Columns[4].Visible = false; // complemento
			grid.Columns[5].Visible = false; // bairro
			grid.Columns[6].Visible = false; // cidade
			grid.Columns[7].Visible = false; // estado
			grid.Columns[8].Visible = false; // cep			
			grid.Columns[9].Visible = false; // fone1
			grid.Columns[10].Visible = false; // fone2			
			grid.Columns[11].Visible = false; // fone3	
			//grid.Columns[12].Visible = false; // cargo
			grid.Columns[13].Visible = false; // email	
			grid.Columns[14].Visible = false; // idt ativo
			grid.Columns[15].Visible = false; // nascimento
			grid.Columns[16].Visible = false; // identidade
			grid.Columns[17].Visible = false; // cpf
		}
		
		
		public bool Inclui(string codigo, string nome,
		                   string logr, string nro, string compl, string bairro, string cidade,
		                   string estado, string cep, string fone1, string fone2, string fone3,
		                   string cargo, string email, 
		                   bool idt_nascimento, DateTime dat_nascimento,
		                   string identidade, string cpf,
		                   string ativo, ref string msg)
		{
			string _estado;
			if (estado.Trim().CompareTo("") == 0)
			{
				_estado = "null,";	
			}
			else
			{
				_estado = "'"  + estado + "',";
			}
			string _cargo;
			if (cargo.Trim().CompareTo("") == 0)
			{
				_cargo = "null,";	
			}
			else
			{
				_cargo = "'"  + cargo + "',";
			}
			string sql = "insert into FUNCIONARIOS values(" +
						 "'"  + codigo + "'," +
						 "'"  + nome + "'," +
						 "'"  + logr + "'," +
						 "'"  + nro + "'," +
						 "'"  + compl + "'," +
						 "'"  + bairro + "'," +
						 "'"  + cidade + "'," +
						 _estado + 
						 "'"  + cep + "'," +
						 "'"  + fone1 + "'," +
						 "'"  + fone2 + "'," +
						 "'"  + fone3 + "'," +				
						 _cargo +				
						 "'"  + email + "'," +
						 "'"  + ativo + "',";
			if (idt_nascimento)
				sql += "'" + dat_nascimento.ToString("M/d/yyyy") + "',";
			else
				sql += "null,";
			sql += "'"  + identidade + "',";
			sql += "'"  + cpf + "')";
						 
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
		
		public bool Altera(string codigo, string nome,
		                   string logr, string nro, string compl, string bairro, string cidade,
		                   string estado, string cep, string fone1, string fone2, string fone3,
		                   string cargo, string email, 
		                   bool idt_nascimento, DateTime dat_nascimento,
		                   string identidade, string cpf,
		                   string ativo, ref string msg)
		{
			string sql = "update FUNCIONARIOS set " +
						 "nom_funcionario='" + nome + "', " + 
						 "des_logradouro='" + logr + "', " + 
						 "nro_endereco='" + nro + "', " + 
						 "des_complemento='" + compl + "', " + 
						 "nom_bairro='" + bairro + "', " + 
						 "nom_cidade='" + cidade + "', ";
			if (estado.Trim().CompareTo("") != 0)
			{
				sql = sql + "cod_estado='" + estado + "', ";
			}
			sql = sql +	 "nro_cep='" + cep + "', " + 
						 "nro_fone1='" + fone1 + "', " + 
						 "nro_fone2='" + fone2 + "', " + 
						 "nro_fone3='" + fone3 + "', ";
			if (cargo.Trim().CompareTo("") != 0)				
			{
				sql = sql + "cod_cargo='" + cargo + "', ";
			}
			if (idt_nascimento)
				sql += "dat_nascimento='" + dat_nascimento.ToString("M/d/yyyy") + "',";			
			else
				sql += "dat_nascimento=null,";
			sql = sql +  "des_email='" + email + "', " + 				
						 "nro_identidade='" + identidade + "'," + 								
						 "nro_cpf='" + cpf + "'," + 								
						 "idt_ativo='" + ativo + "' " + 								
				    	 "where COD_FUNCIONARIO='" + codigo + "'";
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
		
		public bool Exclui(string codigo, ref string msg)
		{
			string sql = "delete from FUNCIONARIOS " +
						 "where COD_FUNCIONARIO='" + codigo + "'";
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
		
		public bool Existe(string codigo)
		{
			bool existe;
			string sql = 
				"select first 1 COD_FUNCIONARIO " +
				"from FUNCIONARIOS " +
				"where COD_FUNCIONARIO='" + codigo + "'";
			FbCommand cmd = new FbCommand(sql, Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			existe = reader.Read();
			reader.Close();
			return existe;
		}
	}
}
