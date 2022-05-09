/*
 * Auditoria de Parceiros
 * 
 * User: Ricardo
 * Date: 12/07/2020
 */
using System;
using System.Collections.Generic;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using classes;

namespace basico
{
	public class AuditoriaDao
	{
		
		public AuditoriaDao()
		{
		}
		
		public static List<Parceiro> AuditaCpfCnpj() 
		{
			
			FbCommand cmd =  new FbCommand("select NRO_CPF_CNPJ, " +
			                     		   "       COD_PARCEIRO, " +
			                     		   "       NOM_PARCEIRO, " +
			                     		   "       IDT_FISJUR " +			                     		   
			                     		   "from PARCEIROS " +
			                     		   "order by NRO_CPF_CNPJ, COD_PARCEIRO",
			                     		   Globais.bd);
			
			Dictionary<string, List<Parceiro>> dic = new Dictionary<string, List<Parceiro>>();
			
			FbDataReader reader = cmd.ExecuteReader();
			Parceiro anterior = new Parceiro();
			anterior.setCpfCnpj("?");
			while (reader.Read())
			{
				string cpfCnpj = !reader.IsDBNull(0) ? reader.GetString(0).Trim() : "";
				Console.WriteLine(cpfCnpj);
				if (cpfCnpj.Equals(""))
				{
					continue;
				}				
				long l = 0;
				long.TryParse(cpfCnpj, out l);
				if (l == 0)
				{
					continue;
				}
				string codigo = !reader.IsDBNull(1) ? reader.GetString(1).Trim() : "";
				string nome = !reader.IsDBNull(2) ? reader.GetString(2).Trim() : "";
				string tipo = !reader.IsDBNull(3) ? reader.GetString(3).Trim() : "F";
				if (tipo.Equals("F"))
				{
					cpfCnpj = CPF.PoeEdicao(cpfCnpj);
				} 
				else
				{
					cpfCnpj = CNPJ.PoeEdicao(cpfCnpj);
				}
				
				Parceiro parceiro = new Parceiro();
				parceiro.setCpfCnpj(cpfCnpj);
				parceiro.setCodigo(codigo);
				parceiro.setNome(nome);
				
				if (anterior.getCpfCnpj().Equals(cpfCnpj)) 
				{
					List<Parceiro> lista = dic.ContainsKey(cpfCnpj) ? dic[cpfCnpj] : null;
					if (lista == null) {
						lista = new List<Parceiro>();
						lista.Add(anterior);
					}
					lista.Add(parceiro);
					dic[cpfCnpj] = lista;
				}
				
				anterior = parceiro;
			}
			reader.Close();
			
			List<Parceiro> repetidos = new List<Parceiro>();
			foreach (List<Parceiro> lista in dic.Values)
			{
				foreach (Parceiro parceiro in lista)
				{
					repetidos.Add(parceiro);
				}
			}
			
			return repetidos;
		}
	
		public static List<Parceiro> AuditaFones() 
		{
			
			FbCommand cmd =  new FbCommand("select NRO_FONE1, " +
			                               "       NRO_FONE2, " +
			                               "       NRO_CELULAR, " +
			                     		   "       COD_PARCEIRO, " +
			                     		   "       NOM_PARCEIRO " +
			                     		   "from PARCEIROS ",
			                     		   Globais.bd);
			
			Dictionary<string, List<Parceiro>> dic = new Dictionary<string, List<Parceiro>>();
			
			FbDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				string fone1 = !reader.IsDBNull(0) ? reader.GetString(0).Trim() : "";
				string fone2 = !reader.IsDBNull(1) ? reader.GetString(1).Trim() : "";
				string celular = !reader.IsDBNull(2) ? reader.GetString(2).Trim() : "";
				string codigo = !reader.IsDBNull(3) ? reader.GetString(3).Trim() : "";
				string nome = !reader.IsDBNull(4) ? reader.GetString(4).Trim() : "";
				
				Parceiro parceiro = new Parceiro();
				parceiro.setFone1(fone1);
				parceiro.setFone2(fone2);
				parceiro.setCelular(celular);
				parceiro.setCodigo(codigo);
				parceiro.setNome(nome);
				
				verificaFone(fone1, parceiro, dic);
				verificaFone(fone2, parceiro, dic);
				verificaFone(celular, parceiro, dic);
				
			}
			reader.Close();
			
			List<Parceiro> repetidos = new List<Parceiro>();
			foreach (List<Parceiro> lista in dic.Values)
			{
				if (lista.Count < 2)
				{
					continue;
				}
				foreach (Parceiro parceiro in lista)
				{
					repetidos.Add(parceiro);
				}
			}
			
			return repetidos;
		}
		
		
		private static void verificaFone(String fone, Parceiro parceiro, Dictionary<string, List<Parceiro>> dic) 
		{	
			if (fone.Equals("")) 
			{
				return;
			}
			long l = 0;
			long.TryParse(fone, out l);
			if (l == 0)
			{
				return;
			}
			
			if (!dic.ContainsKey(fone))
			{
				List<Parceiro> novaLista = new List<Parceiro>();
				novaLista.Add(parceiro);
				dic[fone] = novaLista;
				return;
			}
			
			List<Parceiro> lista = dic[fone];
			foreach (Parceiro p in lista)
			{
				if (p.getCodigo().Equals(parceiro.getCodigo()))
				{
					return;
				}
			}
			
			lista.Add(parceiro);
		}
		
	}
	
}
