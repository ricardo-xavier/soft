/*
 * User: Ricardo
 * Date: 08/06/2018
 */
using System;
using System.Net;
using System.IO;

namespace classes
{
	public class Transferencia
	{
		public Transferencia()
		{
		}
		
		public static void Salva(String arquivo, String destino) {
			
			FileStream fs = null;
							
			try {
			
				//HttpWebRequest httpWebRequest = (HttpWebRequest) WebRequest.Create("http://ricardoxavier.no-ip.org/soft-ws/softws/salva/" + destino);
				HttpWebRequest httpWebRequest = (HttpWebRequest) WebRequest.Create("http://servidor:8080/softws/softws/salva/" + destino);
				httpWebRequest.ContentType = "application/json";
				httpWebRequest.Method = "POST";
			
				fs = new FileStream(arquivo, FileMode.Open);
			
				byte[] bytes = new byte[fs.Length];
				int n = fs.Read(bytes, 0, (int)fs.Length);
				String conteudo = Convert.ToBase64String(bytes);
			
				using (StreamWriter streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
				{
				
	    			String json = "{\"conteudo\":\"" + conteudo + "\"}";

	    			streamWriter.Write(json);
	    			streamWriter.Flush();
	    			streamWriter.Close();
				}

				HttpWebResponse httpResponse = (HttpWebResponse) httpWebRequest.GetResponse();
				using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
				{
	    			String result = streamReader.ReadToEnd();
	    			Console.WriteLine(result);
				}
			
				fs.Close();
				
			} catch (Exception) {
				
			} finally {
				if (fs != null) {
					fs.Close();
				}
			}
		}
	}
}
