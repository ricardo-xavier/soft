/*
 * Projeto  : SoftPlace
 * Programa : cRemessa - Remessa Bradesco
 * Autor    : Ricardo Costa Xavier
 * Data     : 07/09/08
 */
using System;
using System.IO;
using System.Text;
using System.Collections;

namespace classes
{
	/// <summary>
	/// Classe Remessa Bradesco
	/// </summary>
	public class cRemessa
	{
		private string arquivo;
		public string COD_EMPRESA;
		public string NOM_EMPRESA;
		public int NRO_REMESSA;
		
		public cRemessa()
		{
		}
		
		private FileStream AbreArquivo()
		{
			// CB DD MM ?? .REM (.RST para teste)
			// CB = Cobrança Bradesco
			// DD = dia da geração
			// MM = mês da geração
			// ?? = sequencia do arquivo no dia
			string dia = DateTime.Now.Day.ToString("00");
			string mes = DateTime.Now.Month.ToString("00");
			string sequencia="";
			FileStream fs;
			for (int seq=0; seq<100; seq++)
			{
				sequencia = seq.ToString("00");
				arquivo = "CB" + dia + mes + sequencia + ".RST";
				try
				{
					fs = new FileStream(arquivo, FileMode.Open);
					fs.Close();
				}
				catch (Exception)
				{
					break;
				}
			}
			fs = new FileStream(arquivo, FileMode.Create);
			return fs;	
		}
		
		private void GeraHeader(StreamWriter sw)
		{
			sw.Write("0"); // identificacao do registro
			sw.Write("1"); // identificacao do arquivo remessa
			sw.Write("REMESSA");
			sw.Write("01"); // codigo de servico
			sw.Write("COBRANCA".PadRight(15, ' '));
			sw.Write(COD_EMPRESA.PadRight(20, ' '));
			sw.Write(NOM_EMPRESA.PadRight(30, ' '));
			sw.Write("237");
			sw.Write("Bradesco".PadRight(15, ' '));
			sw.Write(DateTime.Now.Day.ToString("00") + 
			         DateTime.Now.Month.ToString("00") + 
			         DateTime.Now.Year.ToString("0000").Substring(2,2)); // data da gravacao
			sw.Write("".PadRight(8, ' '));
			sw.Write("MX"); // micro a micro
			sw.Write(NRO_REMESSA.ToString("0000000"));
			sw.Write("".PadRight(277, ' '));
			sw.Write("000001"); // numero sequencial do registro
			sw.WriteLine();
			sw.Flush();
		}
		
		public bool GeraRemessa(ref string arquivo, string where)
		{
			FileStream fs = AbreArquivo();
			StreamWriter sw = new StreamWriter(fs, Encoding.ASCII);
			GeraHeader(sw);
			cTitulosXeceber titulos = new cTitulosXeceber();
			titulos.DadosRemessa(where);
			sw.Close();
			
			arquivo = this.arquivo;
			return true;
		}
	}
}
