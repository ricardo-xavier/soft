using System;
using System.IO;

namespace classes {
	
	public static class Log {
		
		public static void Grava(string usuario, string msg) {
			try {
				string dir = Directory.GetCurrentDirectory();
				Console.WriteLine(dir);
				StreamWriter log = new StreamWriter("softbd.log", true);
				log.WriteLine(DateTime.Now + " " + usuario + " " 
			              	+ System.Security.Principal.WindowsIdentity.GetCurrent().Name + " "
			              	+ System.Reflection.Assembly.GetEntryAssembly().GetName().Name + " "
			              	+ msg);
				log.Close();
			} catch {}
		}
		
	}
	
}
