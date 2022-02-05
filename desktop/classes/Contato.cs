/*
 * Classe Contato
 * Usuário: Ricardo
 * Data: 14/10/2008
 */

using System;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using classes;
using System.IO;

namespace basico
{
	public class Contato
	{
		#region Propriedades
		private string codigo;
		private string nome;
		private string fone1;
		private string fone2;
		private string celular;
		private string email;
		private string papel;
		#endregion
		
		public Contato()
		{
			this.nome = "";
			this.fone1 = "";
			this.fone2 = "";
			this.celular = "";
			this.email = "";
			this.papel = "";
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
		
		public void setEmail(string email)
		{
			this.email = email;
		}
		
		public string getEmail()
		{
			return email;
		}
		
		public void setPapel(string papel)
		{
			this.papel = papel;
		}
		
		public string getPapel()
		{
			return papel;
		}
		
		#endregion
		
		#region Métodos públicos
		#endregion
	}
}
