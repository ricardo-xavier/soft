/*
 * Projeto  : SoftPlace
 * Programa : Globais - Variaveis Globais
 * Autor    : Ricardo Costa Xavier
 * Data     : 05/04/08
 * 
 * 2012-11-04 - SeparaPedido
 * 
 * 02/05/2014 - telefone com 9 dígitos
 */
using System;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Xml;
using System.Data;

namespace classes
{
	public static class Globais
	{
		public static FbConnection bd=null;
		public static string sBanco="";
		public static string sUsuario="";
		public static string sFilial="";	
		public static bool bAdministrador=false;
		
		public static DateTime StrToDateTime(string s)
		{
			System.Globalization.CultureInfo ci =  new System.Globalization.CultureInfo("en-US");
			return DateTime.Parse(s, ci);
		}
		
		public static float StrToFloat(string s)
		{
			float f=0;
			float.TryParse(s, out f);
			return f;
		}
		
		public static int StrToInt(string s)
		{
			int i=0;
			int.TryParse(s, out i);
			return i;
		}
		
		public static short StrToShort(string str)
		{
			short s=0;
			short.TryParse(str, out s);
			return s;
		}

		public static void DesfazFormula(ref float valor, string formula, float ipi, float frete, float frete_real)
		{
			float fator=0;
			int len=formula.Trim().Length;
			for (int i=len-4; i>=0; i-=4)
			{
				int x=0;
				if (formula[i+1] == ',') 
				{
					i -= 3;
					x = 3;
				}
				if (formula[i] == 'x')
				{
					fator = (Globais.StrToFloat(formula.Substring(i+1, 3+x)) - 1) * 100;
				}
				else
				if (formula.Substring(i, 4).CompareTo("+IPI") == 0)
				{
					fator = ipi;
				}
				else
				if (formula.Substring(i, 4).CompareTo("+FRE") == 0)
				{
					fator = frete;
				}				
				else
				{
					fator = Globais.StrToFloat(formula.Substring(i, 4+x));
				}
				if (formula.Substring(i, 4).CompareTo("+FRR") != 0)					
					valor = (valor * 100) / (100 + fator);
				else
					valor = valor + frete_real;
			}
		}
		
		public static void CalculaFormula(ref float valor, string formula, float ipi, float frete, float frete_real)			
		{
			float fator=0;
			int len=formula.Trim().Length;
			for (int i=0; i<len; i+=4)
			{
				int x=0;
				if (((i+4) < len) && (formula[i+4] == ','))
				{
					x = 3;
				}
				if (formula[i] == 'x')
				{
					fator = Globais.StrToFloat(formula.Substring(i+1, 3+x));
					valor *= fator;
					i += x;
					continue;
				}
				if (formula.Substring(i, 4).CompareTo("+IPI") == 0)
				{
					fator = ipi;
					valor += (valor * fator / (float)100);
				}
				else
				if (formula.Substring(i, 4).CompareTo("+FRE") == 0)
				{
					fator = frete;
					valor += (valor * fator / (float)100);
				}					
				else
				if (formula.Substring(i, 4).CompareTo("+FRR") == 0)
				{
					valor += frete_real;
				}									
				else
				{
					fator = Globais.StrToFloat(formula.Substring(i, 4+x));
					valor += (valor * fator / (float)100);
				}
				i += x;
			}
		}

		public static void MostraFormula(ref float valor, string formula, float ipi, float frete, float frete_real, DataTable tab)			
		{
			float fator;
			int len=formula.Trim().Length;
			for (int i=0; i<len; i+=4)
			{
				int x=0;
				if (((i+4) < len) && (formula[i+4] == ','))
				{
					x = 3;
				}
				if (formula[i] == 'x')
				{
					fator = Globais.StrToFloat(formula.Substring(i+1, 3+x));
					valor *= fator;
					tab.Rows.Add(new object[] {formula.Substring(i, 4+x), valor});
					i += x;
					continue;
				}
				if (formula.Substring(i, 4).CompareTo("+IPI") == 0)
				{
					fator = ipi;
					valor += (valor * fator / (float)100);
					tab.Rows.Add(new object[] {"IPI +" + ipi.ToString("#0.##") + "%", valor});
				}
				else
				if (formula.Substring(i, 4).CompareTo("+FRE") == 0)
				{
					fator = frete;
					valor += (valor * fator / (float)100);
					tab.Rows.Add(new object[] {"FRETE +" + frete.ToString("#0") + "%", valor});
				}					
				else
				if (formula.Substring(i, 4).CompareTo("+FRR") == 0)
				{
					valor += frete_real;
					tab.Rows.Add(new object[] {"FRETE REAL +" + frete_real.ToString("#,###,##0.00"), valor});
				}									
				else
				{
					fator = Globais.StrToFloat(formula.Substring(i, 4+x));
					valor += (valor * fator / (float)100);
					tab.Rows.Add(new object[] {formula.Substring(i, 4+x)+"%", valor});				
				}
				i += x;
			}
		}
		
		public static float Arredonda(float f)
		{
			double d = f;
			return (float)Math.Round(d, 2);
		}
		
		public static bool ValidaCombo(ComboBox combo, string s, string msg)
		{
			int c;
			s = s.Trim();
			if (s.Length == 0) return true;
			int cc = combo.Items.Count;
			for (int i=0; i<combo.Items.Count; i++)
			{
				c = combo.Items[i].ToString().Trim().CompareTo(s);
				if (c == 0) return true;
				//if (c > 0) break;
			}
			MessageBox.Show(s, msg, MessageBoxButtons.OK, MessageBoxIcon.Warning);
			return false;
		}
		
		public static void CarregaIni(ref string sBanco, ref string sUltimoUsuario, ref string sUltimaFilial)
		{
			XmlDocument xml;
			XmlNodeList list;
			XmlNode node;
			
			xml = new XmlDocument();
			xml.Load("soft.xml");		
			list = xml.GetElementsByTagName("BancoDados");			
			node = list[0];
			sBanco = node.InnerText;
			Globais.sBanco = sBanco;
			list = xml.GetElementsByTagName("UltimoUsuario");			
			node = list[0];
			sUltimoUsuario = node.InnerText;
			list = xml.GetElementsByTagName("UltimaFilial");			
			node = list[0];
			sUltimaFilial = node.InnerText;
		}
		
		public static void GravaIni(string sBanco, string sUltimoUsuario, string sUltimaFilial)		
		{
			XmlDocument xml;
			XmlNodeList list;
			XmlNode node;
			
			xml = new XmlDocument();
			xml.Load("soft.xml");		
			list = xml.GetElementsByTagName("UltimoUsuario");			
			node = list[0];
			node.InnerText = Globais.sUsuario;
			list = xml.GetElementsByTagName("UltimaFilial");			
			node = list[0];
			node.InnerText = Globais.sFilial;
			Globais.sBanco = sBanco;
			xml.Save("soft.xml");		
		}
		
		public static string ErroExclusao(string msg1, string msg2)
		{
			if (!msg2.Contains("FOREIGN KEY")) return msg2;
			int x1 = msg2.IndexOf("on table");
			if (x1 < 0) return msg2;
			int x2 = msg2.IndexOf('"', x1);
			if (x2 < 0) return msg2;
			int x3 = msg2.IndexOf('"', x2+1);
			if (x3 < 0) return msg2;
			return msg1 + " na tabela " + msg2.Substring(x2, x3-x2+1);
		}
		
		public static void SeparaPedido(string ped, ref string fornecedor, ref DateTime data, ref string orcamento, ref string pedido)
		{
			string[] partes = ped.Split(' ');
			fornecedor = partes[0].Trim();
			int k = 2;
			try {
				data = DateTime.Parse(partes[1].Trim());
			}
			catch {
				k = 3;
				fornecedor = fornecedor + " " + partes[1].Trim();
				data = DateTime.Parse(partes[2].Trim());
			}
			orcamento = partes[k++].Trim();
			pedido = partes[k++].Trim();	
		}
	}
	
	public static class CNPJ
	{
		public static string PoeEdicao(string buf)
		{
			string zeros = "00000000000000";
			if (buf.Length < 14)
				buf = zeros.Substring(0, 14-buf.Length) + buf;
			return buf.Substring(0, 2) + "." + buf.Substring(2, 3) + "." + buf.Substring(5, 3) + "/" +
					buf.Substring(8, 4) + "-" + buf.Substring(12, 2);
		}
		public static string TiraEdicao(string buf)
		{
			return buf.Substring(0, 2) + buf.Substring(3, 3) + buf.Substring(7, 3) + 
					buf.Substring(11, 4) + buf.Substring(16, 2);
		}
	}
	
	public static class CPF
	{
		public static string PoeEdicao(string buf)
		{
			string zeros = "00000000000";
			if (buf.Length < 11)
				buf = zeros.Substring(0, 11-buf.Length) + buf;
			return buf.Substring(0, 3) + "." + buf.Substring(3, 3) + "." + buf.Substring(6, 3) + 
					"-" + buf.Substring(9, 2);
		}
		public static string TiraEdicao(string buf)
		{
			return buf.Substring(0, 3) + buf.Substring(4, 3) + buf.Substring(8, 3) + 
					buf.Substring(12, 2);
		}
	}

	public static class FONES
	{
		public static string Concatena(object objFixo, object objCelular)
		{
			string fones = "";
			string fixo = null;
			string celular = null;
			if (objFixo != null) {
				fixo = objFixo.ToString().Trim();
				if (fixo.Replace("0", "").Equals("")) {
					fixo = null;
				}
			}
			if (objCelular != null) {
				celular = objCelular.ToString().Trim();
				if (celular.Equals("") || celular.Replace("0", "").Equals("")) {
					celular = null;
				}
			}				
			if (fixo != null) {
				if (celular != null) {
					fones = FONE.PoeEdicao(fixo) + "/" + CELULAR.PoeEdicao(celular);
				} else {
					fones = FONE.PoeEdicao(fixo);
				}
			} else if (celular != null) {
				fones = CELULAR.PoeEdicao(celular);
			}			
			return fones;
		}
		
		public static string Concatena(string fone1, string fone2, string celular,
		                              string fone1Parceiro, string fone2Parceiro, string celularParceiro)
		{
			string fones = "";
			if ((fone1 != null) && (fone1.Trim().Length > 0) && !fone1.Equals("0000000000")) {
				fones += FONE.PoeEdicao(fone1);
			}
			if ((fone2 != null) && (fone2.Trim().Length > 0) && !fone2.Equals("0000000000")) {
				if (!fones.Equals("")) fones += " - ";
				fones += FONE.PoeEdicao(fone2);
			}
			if ((celular != null) && (celular.Trim().Length > 0) && !celular.Equals("0000000000")) {
				if (!fones.Equals("")) fones += " - ";
				fones += CELULAR.PoeEdicao(celular);
			}
			if (fones.Equals("")) {
				if ((fone1Parceiro != null) && (fone1Parceiro.Trim().Length > 0) && !fone1Parceiro.Equals("0000000000")) {
					fones += FONE.PoeEdicao(fone1Parceiro);
				}
				if ((fone2Parceiro != null) && (fone2Parceiro.Trim().Length > 0) && !fone2Parceiro.Equals("0000000000")) {
					if (!fones.Equals("")) fones += " - ";
					fones += FONE.PoeEdicao(fone2Parceiro);
				}
				if ((celularParceiro != null) && (celularParceiro.Trim().Length > 0) && !celularParceiro.Equals("0000000000")) {
					if (!fones.Equals("")) fones += " - ";
					fones += CELULAR.PoeEdicao(celularParceiro);
				}				
			}
			return fones;
		}
		
	}
	
	public static class FONE
	{
		public static string PoeEdicao(string buf)
		{
			if (buf == null) return "(00)0000-0000";
			string zeros = "0000000000";
			if (buf.Length < 10)
				buf = zeros.Substring(0, 10-buf.Length) + buf;
			return "(" + buf.Substring(0, 2) + ")" + buf.Substring(2, 4) + "-" + buf.Substring(6,4);
		}
		public static string TiraEdicao(string buf)
		{
			if (buf.Trim().Length != 13)
			{
				return "0000000000";
			}
			return buf.Substring(1, 2) + buf.Substring(4, 4) + buf.Substring(9, 4);
		}
	}
	
	public static class CELULAR
	{
		public static string PoeEdicao(string buf)
		{
			if (buf == null) return "(00)00000-0000";
			const string zeros = "00000000000";
			if (buf.Length < 10)
				buf = zeros.Substring(0, 10-buf.Length) + buf;
			if (buf.Length == 10)
				return "(" + buf.Substring(0, 2) + ")" + buf.Substring(2, 4) + "-" + buf.Substring(6, 4);
			else
				return "(" + buf.Substring(0, 2) + ")" + buf.Substring(2, 5) + "-" + buf.Substring(7, 4);
		}
		public static string TiraEdicao(string buf)
		{
			if ((buf.Trim().Length != 13) && (buf.Trim().Length != 14))
			{
				return "00000000000";
			}
			if (buf.Trim().Length == 13)
				return buf.Substring(1, 2) + buf.Substring(4, 4) + buf.Substring(9, 4);
			else
				return buf.Substring(1, 2) + buf.Substring(4, 5) + buf.Substring(10, 4);
		}
	}
	
	public static class CEP
	{
		public static string PoeEdicao(string buf)
		{
			if (buf == null) return "00.000-000";
			string zeros = "00000000";
			if (buf.Length < 8)
				buf = zeros.Substring(0, 8-buf.Length) + buf;
			return buf.Substring(0, 2) + "." + buf.Substring(2, 3) + "-" + buf.Substring(5, 3);
		}
		public static string TiraEdicao(string buf)
		{
			if (buf.Trim().Length != 10)
			{
				return "00000000";
			}
			return buf.Substring(0, 2) + buf.Substring(3, 3) + buf.Substring(7, 3);
		}
	}	

/*	
	public static class Trace
	{
		private static DateTime ti;
		private static int nivel;
		private static FbCommand cmd;
		
		public static void Verifica()
		{
			try
			{
				cmd =  new FbCommand("select nivel from controle_log", Globais.bd);
				nivel = (int)cmd.ExecuteScalar();
				if (nivel != 0)
				{
					cmd =  new FbCommand("insert into log values(@data, @sql, @linhas, @tempo)", Globais.bd);
					cmd.Parameters.Add("@data", FbDbType.TimeStamp);
					cmd.Parameters.Add("@sql", FbDbType.VarChar, 4000);				
					cmd.Parameters.Add("@linhas", FbDbType.Integer);
					cmd.Parameters.Add("@tempo", FbDbType.Integer);
					cmd.Prepare();
				}
			}
			catch (Exception e)
			{
				nivel = 0;
				MessageBox.Show(e.Message);
			}
		}		
		
		public static void IniciaComando()
		{
			if (nivel == 0) return;
			ti = DateTime.Now;
		}
	
		public static void FinalizaComando(string sql, int linhas)
		{
			if (nivel == 0) return;
			DateTime tf = DateTime.Now;
			TimeSpan ts = tf.Subtract(ti);
			try
			{
				cmd.Parameters["@data"].Value = DateTime.Now;
				cmd.Parameters["@sql"].Value = sql;
				cmd.Parameters["@linhas"].Value = linhas;
				cmd.Parameters["@tempo"].Value = ts.Seconds;
				cmd.ExecuteNonQuery();
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}			
		}
	}
*/	
}
