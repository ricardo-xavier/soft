/*
 * Projeto  : SoftPlace
 * Programa : cFiliais - Classe de Filiais
 * Autor    : Ricardo Costa Xavier
 * Data     : 25/03/2008
 */
using System;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;

namespace classes
{
	public class cFiliais
	{
		public cFiliais()
		{
		}
		
		public void Carrega(DataGridView grid)
		{
			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			adapter.SelectCommand = new FbCommand("select COD_FILIAL," +
			                                      "       NOM_FILIAL," +
			                                      "       NRO_CNPJ," +
			                                      "       NRO_INSCRICAO_ESTADUAL," +
			                                      "       NRO_INSCRICAO_MUNICIPAL," +
												  "       DES_LOGRADOURO," +
												  "       NRO_ENDERECO," +
												  "       DES_COMPLEMENTO," +
												  "       NOM_BAIRRO," +
												  "       NOM_CIDADE," +
												  "       COD_ESTADO," +
												  "       NRO_CEP," +
												  "       NRO_FONE1," +
												  "       NRO_FONE2," +
												  "       NRO_FAX," +												  
												  "       DES_EMAIL, " +
												  "       DES_DIRETORIO " +
			                                      "from FILIAIS " +
			                                      "order by COD_FILIAL", 
			                                      Globais.bd);
			adapter.Fill(table);
			table.Columns[0].ColumnName = "Código";
			table.Columns[1].ColumnName = "Nome";
			grid.DataSource = table;
			grid.Columns[2].Visible = false; // cnpj
			grid.Columns[3].Visible = false; // ins est
			grid.Columns[4].Visible = false; // ins mun
			grid.Columns[5].Visible = false; // logradouro
			grid.Columns[6].Visible = false; // nro
			grid.Columns[7].Visible = false; // complemento
			grid.Columns[8].Visible = false; // bairro
			grid.Columns[9].Visible = false; // cidade
			grid.Columns[10].Visible = false; // estado
			grid.Columns[11].Visible = false; // cep			
			grid.Columns[12].Visible = false; // fone1
			grid.Columns[13].Visible = false; // fone2			
			grid.Columns[14].Visible = false; // fax
			grid.Columns[15].Visible = false; // email	
			grid.Columns[16].Visible = false; // diretorio	
		}
		
		public void Carrega(ComboBox cbx)
		{
			string codigo, descricao;
			FbCommand cmd =  new FbCommand("select COD_FILIAL," +
			                               "       NOM_FILIAL " +
			                               "from FILIAIS " +
			                               "order by COD_FILIAL", 
			                               Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			while (reader.Read())
			{
				codigo = reader.GetString(0).Trim();
				descricao = reader.GetString(1).Trim();
				cbx.Items.Add(codigo + " " + descricao);
			}
			reader.Close();
		}
		
		public bool Inclui(string codigo, string nome, string cnpj, string insest, string insmun,
		                   string logr, string nro, string compl, string bairro, string cidade,
		                   string estado, string cep, string fone1, string fone2, string fax, string email, 
		                   string diretorio, ref string msg)
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
			string sql = "insert into FILIAIS values(" +
						 "'"  + codigo + "'," +
 						 "'"  + nome + "'," +
						 "'"  + cnpj + "'," +
						 "'"  + insest + "'," +
						 "'"  + insmun + "'," +
						 "'"  + logr + "'," +
						 "'"  + nro + "'," +
						 "'"  + compl + "'," +
						 "'"  + bairro + "'," +
						 "'"  + cidade + "'," +
						 _estado + 
						 "'"  + cep + "'," +
						 "'"  + fone1 + "'," +
						 "'"  + fone2 + "'," +
						 "'"  + fax + "'," +			
						 "'"  + email + "'," +							
						 "'"  + diretorio + "')";
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
		
		public bool Altera(string codigo, string nome, string cnpj, string insest, string insmun,
		                   string logr, string nro, string compl, string bairro, string cidade,
		                   string estado, string cep, string fone1, string fone2, string fax, string email, 
		                   string diretorio, ref string msg)
		{
			string sql = "update FILIAIS set " +
						 "nom_filial='" + nome + "', " + 
						 "nro_cnpj='" + cnpj + "', " + 
						 "nro_inscricao_estadual='" + insest + "', " + 
						 "nro_inscricao_municipal='" + insmun + "', " + 
						 "des_logradouro='" + logr + "', " + 
						 "nro_endereco='" + nro + "', " + 
						 "des_complemento='" + compl + "', " + 
						 "nom_bairro='" + bairro + "', " + 
						 "nom_cidade='" + cidade + "', ";
			if (estado.Trim().CompareTo("") != 0)
			{
				sql = sql + "cod_estado='" + estado + "', ";
			}
				
			sql = sql +  "nro_cep='" + cep + "', " + 
						 "nro_fone1='" + fone1 + "', " + 
						 "nro_fone2='" + fone2 + "', " + 
						 "nro_fax='" + fax + "', " + 				
						 "des_email='" + email + "', " + 				
						 "des_diretorio='" + diretorio + "' " + 
				    	 "where COD_FILIAL='" + codigo + "'";
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
			string sql = "delete from FILIAIS " +
						 "where COD_FILIAL='" + codigo + "'";
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
	
		public string Diretorio(string codigo) {
			string diretorio="";
			FbCommand cmd =  new FbCommand("select DES_DIRETORIO " +
			                               "from FILIAIS " +
			                               "where COD_FILIAL = '" + codigo.Trim() + "'" ,
			                               Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			if (reader.Read())
			{
				diretorio = reader.GetString(0).Trim();
			}
			reader.Close();			
			return diretorio;
		}
	}
}
