/*
 * Classe Parceiro
 * Usuário: Ricardo
 * Data: 14/10/2008
 */

using System;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using System.Collections;
using classes;

namespace basico
{
	public class Parceiro
	{
		#region Propriedades
		private string codigo;
		private string nome;
		private string fone1;
		private string fone2;
		private string celular;
		private string fax;
		private string email;
		private string cpfCnpj;
		public ArrayList contatos;
		#endregion
		
		public Parceiro()
		{
			this.nome = "";
			this.fone1 = "";
			this.fone2 = "";
			this.celular = "";
			this.fax = "";
			this.email = "";
			this.contatos = new ArrayList();
		}

		#region Métodos get e set
		public void setCodigo(string codigo)
		{
			this.codigo = codigo;
		}
		
		public string getCodigo()
		{
			return codigo;
		}
		
		public void setNome(string nome)
		{
			this.nome = nome;
		}
		
		public string getNome()
		{
			return nome;
		}
		
		public void setFone1(string fone1)
		{
			this.fone1 = fone1;
		}
		
		public string getFone1()
		{
			return fone1;
		}
		
		public void setFone2(string fone2)
		{
			this.fone2 = fone2;
		}
		
		public string getFone2()
		{
			return fone2;
		}
		
		public void setCelular(string celular)
		{
			this.celular = celular;
		}
		
		public string getCelular()
		{
			return celular;
		}
		
		public void setFax(string fax)
		{
			this.fax = fax;
		}
		
		public string getFax()
		{
			return fax;
		}

		public void setEmail(string email)
		{
			this.email = email;
		}
		
		public string getEmail()
		{
			return email;
		}
		
		public void setCpfCnpj(string cpfCnpj)
		{
			this.cpfCnpj = cpfCnpj;
		}
		
		public string getCpfCnpj()
		{
			return cpfCnpj;
		}
		
		#endregion
		
		#region Métodos públicos
		public bool Le(string cod_parceiro)
		{
			FbCommand cmd =  new FbCommand("select " +
			                               "NOM_PARCEIRO," +
			                               "NRO_FONE1," +
			                               "NRO_FONE2," +
			                               "NRO_CELULAR," +
			                               "NRO_FAX," +
			                               "DES_EMAIL " +
			                               "from PARCEIROS " +
			                               "where COD_PARCEIRO='" + cod_parceiro + "'",
			                               Globais.bd);
			FbDataReader reader = null;
			try
			{
				reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
				if (reader.Read())
				{
					codigo = cod_parceiro;
					nome = !reader.IsDBNull(0) ? reader.GetString(0).Trim() : "";
					fone1 = !reader.IsDBNull(1) ? reader.GetString(1).Trim() : "";
					fone2 = !reader.IsDBNull(2) ? reader.GetString(2).Trim() : "";
					celular = !reader.IsDBNull(3) ? reader.GetString(3).Trim() : "";
					fax = !reader.IsDBNull(4) ? reader.GetString(4).Trim() : "";
					email = !reader.IsDBNull(5) ? reader.GetString(5).Trim() : "";
					reader.Close();
					return true;;
				}
				reader.Close();
				return false;
			}
			catch (Exception e)
			{
				Log.Grava(Globais.sUsuario, "erro:" + e.Message);
				string erro = e.Message;
				return false;
			}
		}
		
		public void ListaContatos(string cod_parceiro, bool primeiro)
		{
			FbCommand cmd =  new FbCommand("select " +
			                               "COD_CONTATO," +
			                               "NOM_CONTATO," +
			                               "NRO_FONE1," +
			                               "NRO_FONE2," +
			                               "NRO_CELULAR," +
			                               "DES_EMAIL," +
			                               "DES_PAPEL " +
			                               "from CONTATOS " +
			                               "where COD_PARCEIRO='" + cod_parceiro + "'",
			                               Globais.bd);
			FbDataReader reader = null;
			try
			{
				reader = cmd.ExecuteReader(primeiro ? CommandBehavior.SingleRow : CommandBehavior.Default);
				while (reader.Read())
				{
					Contato contato = new Contato();
					contato.setCodigo(!reader.IsDBNull(0) ? reader.GetString(0).Trim() : "");
					contato.setNome(!reader.IsDBNull(1) ? reader.GetString(1).Trim() : "");
					contato.setFone1(!reader.IsDBNull(2) ? reader.GetString(2).Trim() : "");
					contato.setFone2(!reader.IsDBNull(3) ? reader.GetString(3).Trim() : "");
					contato.setCelular(!reader.IsDBNull(4) ? reader.GetString(4).Trim() : "");
					contato.setEmail(!reader.IsDBNull(5) ? reader.GetString(5).Trim() : "");
					contato.setPapel(!reader.IsDBNull(6) ? reader.GetString(6).Trim() : "");
					contatos.Add(contato);
				}
				reader.Close();
			}
			catch (Exception e)
			{
				Log.Grava(Globais.sUsuario, "erro:" + e.Message);
				string erro = e.Message;
			}
		}
		
		#endregion
	}
}
