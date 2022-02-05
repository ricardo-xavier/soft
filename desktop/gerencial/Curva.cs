/*
 * Sistema Gerencial
 * Curvas Vendedor/Consultor
 * Autor: Ricardo Costa Xavier
 * Data : 10/07/2010
 */
using System;
using FirebirdSql.Data.FirebirdClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data;
using classes;
using pdf;
using System.Collections;
using System.IO;

namespace gerencial
{
	/// <summary>
	/// Curvas Vendedor/Consultor
	/// </summary>
	public class Curva
	{
		public Curva()
		{
		}
		
		public bool Gera(char tipo, string arquivo, string titulo, bool idt_inicial, DateTime data_inicial, bool idt_final, DateTime data_final, bool pagos, bool abertos)
		{
			FluxoCaixa fluxo = new FluxoCaixa();
			
			/*
			PDF pdf = new PDF(arquivo);
			pdf.Abre();
			fluxo.Parte1(pdf, titulo, idt_inicial, data_inicial, idt_final, data_final);
			*/
			
			FileStream fs = new FileStream(arquivo, FileMode.Create);
			Document doc = new Document(PageSize.LETTER.Rotate());
			PdfWriter writer = PdfWriter.GetInstance(doc, fs);
			doc.Open();
			PdfContentByte buf = writer.DirectContent;
			
			string periodo = "";
			if (idt_inicial || idt_final)
			{
				periodo = "Período: ";
				if (idt_inicial && idt_final)
				{
					periodo += "de " + data_inicial.ToString("dd/MM/yyyy") + " até " + data_final.ToString("dd/MM/yyyy");
				}
				else
				{
					if (idt_inicial)
					{
						periodo += "a partir de " + data_inicial.ToString("dd/MM/yyyy");
					}
					else
					{
						periodo += "até " + data_final.ToString("dd/MM/yyyy");
					}
				}					
			}
			
			if (pagos && !abertos)
				Graficos.Cabecalho(doc, titulo+"- Pagos", periodo);
			else
			if (!pagos && abertos)
				Graficos.Cabecalho(doc, titulo+"- Abertos", periodo);
			else
				Graficos.Cabecalho(doc, titulo, periodo);
			
									
			string where;
			string where2="";
			string col_cod;
			string col_per;
			if (tipo == 'v')
			{
				col_cod = "O.COD_VENDEDOR";
				col_per = "P.PER_VENDEDOR";
				if (pagos && abertos)
					where = "where P.DAT_PEDIDO is not null ";
				else
				if (pagos)
					where = "where P.IDT_VENDEDOR = 'S' and P.DAT_PEDIDO is not null ";
				else
					where = "where P.IDT_VENDEDOR <> 'S' and P.DAT_PEDIDO is not null ";
					
			}
			else
			if (tipo == 'c')
			{
				col_cod = "O.COD_CONSULTOR";
				col_per = "P.PER_CONSULTOR";								
				if (pagos && abertos)
					where = "where P.DAT_PEDIDO is not null ";
				else
				if (pagos)
					where = "where P.IDT_CONSULTOR = 'S' and P.DAT_PEDIDO is not null ";
				else
					where = "where P.IDT_CONSULTOR <> 'S' and P.DAT_PEDIDO is not null ";
			}
			else
			{
				col_cod = "P.COD_FORNECEDOR";
				col_per = "0";								
				where = "where P.COD_PEDIDO = '1' and P.DAT_PEDIDO is not null ";
				where2 = "where P.COD_PEDIDO = '2' and P.DAT_PEDIDO is not null ";
			}				
			if (idt_inicial || idt_final) 
			{
				if (idt_inicial && idt_final)
				{
					where += "and (P.DAT_PEDIDO between '" + data_inicial.ToString("M/d/yyyy") + "' and '" + data_final.ToString("M/d/yyyy") + "') ";
					where2 += "and (P.DAT_PEDIDO between '" + data_inicial.ToString("M/d/yyyy") + "' and '" + data_final.ToString("M/d/yyyy") + "') ";
				}
				else
				{
					if (idt_inicial)
					{
						where += "and (P.DAT_PEDIDO >= '" + data_inicial.ToString("M/d/yyyy") + "') ";
						where2 += "and (P.DAT_PEDIDO >= '" + data_inicial.ToString("M/d/yyyy") + "') ";
					}
					else
					{
						where += "and (P.DAT_PEDIDO <= '" + data_final.ToString("M/d/yyyy") + "') ";
						where2 += "and (P.DAT_PEDIDO <= '" + data_final.ToString("M/d/yyyy") + "') ";
					}
				}
			}
			string sql = 
				"select " +
				col_cod + "," +
				"P.VLR_PEDIDO," +				
				col_per + "," +
				"O.PER_CONSULTOR as PER_CONSULTOR_ORC," +
				"O.VLR_ORCAMENTO," +
				"O.VLR_DESCONTO," +
				"O.COD_CARACTERISTICA," +
				"C.PER_LIMIAR," +
				"C.PER_FILIAL," +
				"O.COD_FORNECEDOR," +
				"P.VLR_FRETE," +
				"C.PER_FRETE," +
				"P.DAT_ORCAMENTO," +
				"P.COD_ORCAMENTO," +
				"P.COD_PEDIDO " +
				"from PEDIDOS P " +
				"inner join ORCAMENTOS O " +
				"on O.COD_FORNECEDOR=P.COD_FORNECEDOR and O.DAT_ORCAMENTO=P.DAT_ORCAMENTO and O.COD_ORCAMENTO=P.COD_ORCAMENTO " +
				"inner join CARACTERISTICAS C " +
				"on C.COD_FORNECEDOR=O.COD_FORNECEDOR and C.COD_CARACTERISTICA=O.COD_CARACTERISTICA " +				
				where;			
			if (tipo == 'f')
			{
				sql = sql +
				"union " +				
				"select " +
				"'SERVICO-' || P.COD_FORNECEDOR," +
				"P.VLR_PEDIDO," +				
				col_per + "," +
				"O.PER_CONSULTOR as PER_CONSULTOR_ORC, " +
				"O.VLR_ORCAMENTO," +
				"O.VLR_DESCONTO," +
				"O.COD_CARACTERISTICA," +
				"C.PER_LIMIAR," +
				"C.PER_FILIAL," +
				"O.COD_FORNECEDOR," +
				"P.VLR_FRETE," +
				"C.PER_FRETE," +
				"P.DAT_ORCAMENTO," +
				"P.COD_ORCAMENTO," +
				"P.COD_PEDIDO " +
				"from PEDIDOS P " +
				"inner join ORCAMENTOS O " +
				"on O.COD_FORNECEDOR=P.COD_FORNECEDOR and O.DAT_ORCAMENTO=P.DAT_ORCAMENTO and O.COD_ORCAMENTO=P.COD_ORCAMENTO " +
				"inner join CARACTERISTICAS C " +
				"on C.COD_FORNECEDOR=O.COD_FORNECEDOR and C.COD_CARACTERISTICA=O.COD_CARACTERISTICA " +									
				where2;				
			}
			sql = sql +
				"order by 1";
			StreamWriter log = new StreamWriter("gerencial.log");
			log.WriteLine(sql);
			log.Flush();
			FbCommand cmd = new FbCommand(sql, Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			
			string codigo;
			float valor;
			float percentual;
			string ultimo="";
			float total=0;
			ArrayList valores = new ArrayList();
			ArrayList descricoes = new ArrayList();
								
			VendedorConsultor vendedor_consultor=null;
			ArrayList lista = new ArrayList();
			cOrcamentos orcamento = new cOrcamentos();
			cComissaoLimiar comissao = new cComissaoLimiar();
			cCaracteristicas carac = new cCaracteristicas();

			while (reader.Read())
			{
				codigo = reader.GetString(0);				
				valor = reader.GetFloat(1);
				percentual = reader.GetFloat(2);
									
				float vlr_itens = reader.GetFloat(4);
				float vlr_desconto = reader.GetFloat(5);
				string caracteristica = reader.GetString(6);
				float limiar = reader.GetFloat(7);
				string fornecedor = reader.GetString(9);
				
				float vlr_frete = reader.IsDBNull(10) ? 0 : reader.GetFloat(10);
				float per_frete = reader.IsDBNull(11) ? 0 : reader.GetFloat(11);
				DateTime dat_orcamento = reader.GetDateTime(12);
				short cod_orcamento = reader.GetInt16(13);
				short cod_pedido = reader.GetInt16(14);				
				float vlr_frete_item=0;
				if (vlr_frete > 0)
				{
					vlr_frete_item = cPedidos.RateiaFrete(fornecedor, dat_orcamento, cod_orcamento, cod_pedido, ref vlr_frete);
				}
					
				string venpro="", venser="", conpro="", conser="", filpro="", filser="";
				carac.FormulasComissao(fornecedor, caracteristica, ref venpro, ref venser, ref conpro, ref conser, ref filpro, ref filser);
				
				if (percentual == 0)
				{
					
					if (tipo == 'v')
					{
						if (codigo.StartsWith("SERVICO-"))
						{
							//Globais.CalculaFormula(ref valor, venser, 0, per_frete, vlr_frete_item);
						}
						else
						{
							//Globais.CalculaFormula(ref valor, venpro, 0, per_frete, vlr_frete_item);
						}												
						percentual = reader.GetFloat(3); // consultor
						float vlr_orcamento = vlr_itens - vlr_desconto;
						float sinal = orcamento.CalculaSinal(fornecedor, caracteristica, vlr_itens, vlr_desconto, percentual, limiar);
						percentual = comissao.Calcula(fornecedor, caracteristica, valor, sinal);
					}
					else
					if (tipo == 'c')
					{
						if (codigo.StartsWith("SERVICO-"))
						{
							//Globais.CalculaFormula(ref valor, conser, 0, per_frete, vlr_frete_item);
						}
						else
						{
							//Globais.CalculaFormula(ref valor, conpro, 0, per_frete, vlr_frete_item);
						}						
						percentual = reader.GetFloat(3);
					}
					else
					{
						if (codigo.StartsWith("SERVICO-"))
						{
							//Globais.CalculaFormula(ref valor, filser, 0, per_frete, vlr_frete_item);
							percentual = 100;
						}
						else
						{
							//Globais.CalculaFormula(ref valor, filpro, 0, per_frete, vlr_frete_item);
							percentual = reader.GetFloat(8);
						}
					}
				}
				if (!codigo.Equals(ultimo))
				{
					if (!ultimo.Equals(""))
					{
						lista.Add(vendedor_consultor);
					}
					ultimo = codigo;
					vendedor_consultor = new VendedorConsultor();
					vendedor_consultor.codigo = codigo;
					vendedor_consultor.vendas = 0;
					vendedor_consultor.percentual = 0;
					vendedor_consultor.n = 0;
				}
				vendedor_consultor.vendas += valor;
				vendedor_consultor.percentual += percentual;
				if (percentual > 0.01) vendedor_consultor.n++;
				total += valor;				
				log.WriteLine(valor.ToString() + " " + total.ToString());
				log.Flush();
			}
			log.Close();
			if (!ultimo.Equals(""))
			{
				lista.Add(vendedor_consultor);
			}			
			reader.Close();										
			
			foreach (VendedorConsultor vc in lista)
			{
				valores.Add(vc.vendas);
				descricoes.Add(vc.codigo);
			}
			
			//if (valores.Count > 12)
			//{
				ArrayList valores12 = new ArrayList();
				ArrayList descricoes12 = new ArrayList();
				int max = valores.Count > 12 ? 11 : valores.Count;
				//for (int i=0; i<11; i++)
				for (int i=0; i<max; i++)
				{
					float maior=-1;					
					int v=0, imaior=-1;	
					foreach (float vlr in valores)
					{
						if (vlr > maior)
						{
							maior = vlr;
							imaior = v;
						}
						v++;
					}
					float vmaior = float.Parse(valores[imaior].ToString());
					string dmaior = descricoes[imaior].ToString();
					valores12.Add(vmaior);
					descricoes12.Add(dmaior);
					valores.RemoveAt(imaior);
					descricoes.RemoveAt(imaior);
				}
				if (valores.Count > 12)
				{
					float voutros = 0;
					foreach (float vlr in valores)
					{
						voutros += vlr;
					}
					valores12.Add(voutros);
					descricoes12.Add("OUTROS");
				}
				Graficos.Pizza(buf, valores12, descricoes12, 200, 250, 120);
			//}
			//else 
				//Graficos.Pizza(buf, valores, descricoes, 200, 250, 120);
			doc.NewPage();			

			Tabela table = new Tabela(tipo == 'f' ? 3 : 4);
			if (tipo == 'v')
				fluxo.AdicionaCelula(table, "Vendedor", BaseFont.HELVETICA_BOLD, 8, iTextSharp.text.Color.LIGHT_GRAY, 1);
			else
			if (tipo == 'c')				
				fluxo.AdicionaCelula(table, "Consultor", BaseFont.HELVETICA_BOLD, 8, iTextSharp.text.Color.LIGHT_GRAY, 1);
			else
				fluxo.AdicionaCelula(table, "Fornecedor", BaseFont.HELVETICA_BOLD, 8, iTextSharp.text.Color.LIGHT_GRAY, 1);
			fluxo.AdicionaCelula(table, "Vendas", BaseFont.HELVETICA_BOLD, 8, iTextSharp.text.Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 1);
			fluxo.AdicionaCelula(table, "% Total", BaseFont.HELVETICA_BOLD, 8, iTextSharp.text.Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 1);
			if (tipo != 'f')
				fluxo.AdicionaCelula(table, "Média Comissão", BaseFont.HELVETICA_BOLD, 8, iTextSharp.text.Color.LIGHT_GRAY, Element.ALIGN_RIGHT, 1);			
			foreach (VendedorConsultor vc in lista)
			{
				fluxo.AdicionaCelula(table, vc.codigo, BaseFont.HELVETICA, 8, Element.ALIGN_LEFT, 1);
				fluxo.AdicionaCelula(table, vc.vendas.ToString("#,###,##0.00"), BaseFont.HELVETICA, 8, Element.ALIGN_RIGHT, 1);
				fluxo.AdicionaCelula(table, (vc.vendas * 100 / total).ToString("#,###,##0.00"), BaseFont.HELVETICA, 8, Element.ALIGN_RIGHT, 1);
				if (tipo != 'f')				
					fluxo.AdicionaCelula(table, (vc.percentual / vc.n).ToString("#,###,##0.00"), BaseFont.HELVETICA, 8, Element.ALIGN_RIGHT, 1);
			}
				
			fluxo.AdicionaCelula(table, "Total", BaseFont.HELVETICA_BOLD, 8, Color.GRAY, 1);
			fluxo.AdicionaCelula(table, total.ToString("#,###,##0.00"), BaseFont.HELVETICA, 8, Color.GRAY, Element.ALIGN_RIGHT, 1);
			fluxo.AdicionaCelula(table, "", BaseFont.HELVETICA_BOLD, 8, Color.GRAY, tipo == 'f' ? 1 : 2);
			doc.Add(table);
			doc.Close();
			return true;			
		}
		
	}
	
	public class VendedorConsultor
	{
		public string codigo;
		public float vendas;
		public float percentual;
		public int n;
	}

}
