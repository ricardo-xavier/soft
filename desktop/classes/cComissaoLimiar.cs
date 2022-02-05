/*
 * Projeto  : SoftPlace
 * Programa : cComissaoLimiar - Classe de Comissao x Limiar
 * Autor    : Ricardo Costa Xavier
 * Data     : 12/09/08
 * Alteração:
 * 30/01/10 - acerto no update
 */
using System;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;

namespace classes
{
	public class cComissaoLimiar
	{
		public cComissaoLimiar()
		{
		}
		
		public void Carrega(string fornecedor, string caracteristica, DataGridView grid)
		{
			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			adapter.SelectCommand = new FbCommand("select QTD_LIMIAR,PER_COMISSAO " +
			                                      "from COMISSAO_LIMIAR " +
			                                      "where cod_fornecedor='" + fornecedor + "' and " +
			                                      "      cod_caracteristica='" + caracteristica + "' " +
			                                      "order by QTD_LIMIAR", 
			                                      Globais.bd);
			adapter.Fill(table);
			table.Columns[0].ColumnName = "Limiar";
			table.Columns[1].ColumnName = "Comissão";
			grid.DataSource = table;
		}
		
		public bool Inclui(string fornecedor, string caracteristica, short limiar, float comissao, ref string msg)
		{
			string sql = "insert into COMISSAO_LIMIAR values(" +
						 "'" + fornecedor + "'," +
						 "'" + caracteristica + "'," +
						 limiar + "," +
						 comissao.ToString().Replace(',','.') + ")";
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
		
		public bool Altera(string fornecedor, string caracteristica, short limiar, float comissao, ref string msg)
		{
			string sql = "update COMISSAO_LIMIAR set " +
						 "PER_COMISSAO=" + comissao.ToString().Replace(',','.') + " " + 
				    	 "where " +
				         "cod_fornecedor='" + fornecedor + "' and " +
						 "cod_caracteristica='" + caracteristica + "' and " +
				         "QTD_LIMIAR=" + limiar;
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
		
		public bool Exclui(string fornecedor, string caracteristica, short limiar, ref string msg)
		{
			string sql = "delete from COMISSAO_LIMIAR " +
						 "where cod_fornecedor='" + fornecedor + "' and " +
						 "      cod_caracteristica='" + caracteristica + "' and " +
						 "      QTD_LIMIAR=" + limiar;
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
		
		// Calcula a comissao do vendedor de acordo com o sinal indicador do orcamento
		public float Calcula(string cod_fornecedor, string cod_caracteristica, float vlr_orcamento, float sinal)
		{
			cCaracteristicas caracteristica = new cCaracteristicas();
			float comissao_default = caracteristica.Comissao(cod_fornecedor, cod_caracteristica);
			string sql = "select QTD_LIMIAR,PER_COMISSAO " +
			             "from COMISSAO_LIMIAR " +
			             "where cod_fornecedor='" + cod_fornecedor + "' and " +
						 "      cod_caracteristica='" + cod_caracteristica + "' " +
			             "order by QTD_LIMIAR";
			FbCommand cmd = new FbCommand(sql, Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			float comissao=0f;
			float limiar=0f;
			bool existe=false;
			while (reader.Read())
			{
				existe = true;
				limiar = reader.GetFloat(0);
				comissao = reader.GetFloat(1);		
				if (sinal < (limiar+0.5)) break;
			}
			reader.Close();
			if (!existe) return comissao_default;
			return comissao;
		}
	}
}
