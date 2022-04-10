using System;
using System.Text;

namespace classes
{
	public class Acentuacao
	{
		
		private static string COM_ACENTUACAO = "áéíóúãõâêôàçÁÉÍÓÚÃÕÂÊÔÀÇ";
		private static string SEM_ACENTUACAO = "aeiouaoaeoacAEIOUAOAEOAC";

		public Acentuacao()
		{
		}
		
		public static string TiraAcentos(string s)
		{
			StringBuilder sb = new StringBuilder();
			for (int i=0; i < s.Length; i++)
			{
				int p = COM_ACENTUACAO.IndexOf(s[i]);
				if (p >= 0) {
					sb.Append(SEM_ACENTUACAO[p]);
				} else {
					sb.Append(s[i]);
				}
			}
			
			return sb.ToString();
			
		}
		

	}
}
