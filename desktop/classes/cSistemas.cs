/*
 * Projeto  : SoftPlace
 * Programa : cSistemas - Classe de Sistemas
 * Autor    : Ricardo Costa Xavier
 * Data     : 25/03/2008
 * 
 * 
 * 21/03/2018 - Ricardo - não mostrar Orçamentos para usuários comuns
 * 
 */
using System;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using System.Collections;
using System.IO;
using System.Text;

namespace classes
{
	public class cSistemas
	{
		public cSistemas()
		{
		}
		
		public void Carrega(DataGridView grid, string where)
		{
			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			adapter.SelectCommand = new FbCommand("select COD_SISTEMA," +
			                                      "DES_SISTEMA " +
			                                      "from SISTEMAS " + 
			                                      where + " " +
			                                      "order by COD_SISTEMA", 
			                                      Globais.bd);
			adapter.Fill(table);
			table.Columns[0].ColumnName = "Código";
			table.Columns[1].ColumnName = "Descrição";
			grid.DataSource = table;
		}
		
		public bool Inclui(string codigo, string descricao, ref string msg)
		{
			string sql = "insert into SISTEMAS values(" +
						 "'"  + codigo + "'," +
						 "'"  + descricao + "')";
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
		
		public bool Altera(string codigo, string descricao, ref string msg)
		{
			string sql = "update SISTEMAS set " +
						 "DES_SISTEMA='" + descricao + "' " + 
				    	 "where COD_SISTEMA=" + codigo;
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
			string sql = "delete from SISTEMAS " +
						 "where COD_SISTEMA=" + codigo;
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
			
		public ArrayList ListaAcesso(bool adm, string usuario, string filial)
		{
			
			ArrayList lista = new ArrayList();
			FbCommand cmd;
			if (adm)			
				cmd =  new FbCommand("select DES_SISTEMA,NOM_EXECUTAVEL from SISTEMAS order by SEQ",
				                     Globais.bd);
			else
				cmd =  new FbCommand("select a.DES_SISTEMA,a.NOM_EXECUTAVEL from SISTEMAS a, usuarios_sistemas b " + 
				                     "where a.cod_sistema=b.cod_sistema and " +
				                     "b.cod_usuario='" + Globais.sUsuario + "' and " +
				                     "b.cod_filial='" + Globais.sFilial + "' order by a.SEQ",
				                     Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			while (reader.Read())
			{
				string desc = reader.GetString(0).Trim();
				string exec = reader.GetString(1).Trim();
				if (desc.Contains("Orcamento Acao"))
				{
					continue;
				}
				lista.Add(desc);
				lista.Add(exec);
			}
			reader.Close();
			return lista;
		}
	}
}
