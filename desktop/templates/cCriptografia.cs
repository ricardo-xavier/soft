/*
 * Projeto  : SoftPlace
 * Sistema  : CPD
 * Programa : cCriptografia - Criptografia de senhas
 * Autor    : Ricardo Costa Xavier
 * Data     : 22/03/2008
 */
using System;
using System.Security.Cryptography;
using System.Text;

namespace classes
{
	public class cCriptografia
	{
		public cCriptografia()
		{
		}
		
		public string Criptografa(string senha) 
		{
			MD5 md5 = MD5.Create();
			byte[] inputBytes = Encoding.ASCII.GetBytes(senha);
			byte[] hash = md5.ComputeHash(inputBytes);
			StringBuilder sb = new StringBuilder();
			for (int i=0; i<hash.Length; i++)
				sb.Append(hash[i].ToString("X2"));
			return sb.ToString();
		}
	}
}
