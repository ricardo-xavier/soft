/*
 * Projeto  : SoftPlace
 * Programa : cAgenda - Classe de Agenda
 * Autor    : Ricardo Costa Xavier
 * Data     : 21/04/08
 */
using System;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using System.IO;
using pdf;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace classes
{
	public class cAgenda
	{
		public int num_atrasados;
		public int num_hoje;
		public int num_futuros;
		public int num_atrasados_pessoais;
		public int num_hoje_pessoais;
		public int num_futuros_pessoais;
		
		public cAgenda()
		{
		}
		
		public void Conta()
		{
			num_atrasados = 0;
			num_hoje = 0;
			num_futuros = 0;
			num_atrasados_pessoais = 0;
			num_hoje_pessoais = 0;
			num_futuros_pessoais = 0;
			FbCommand cmd =  new FbCommand("select DAT_PREVISAO,IDT_PESSOAL from AGENDA where DAT_SOLUCAO is null and COD_USUARIO='" + Globais.sUsuario + "'", Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			while (reader.Read())
			{
				if (reader.GetDateTime(0) < DateTime.Today.Date)
				{
					num_atrasados++;
					if (reader.GetString(1).Trim().CompareTo("S") == 0)
						num_atrasados_pessoais++;
					
				}
				else
				if (reader.GetDateTime(0) > DateTime.Today.Date)
				{
					num_futuros++;
					if (reader.GetString(1).Trim().CompareTo("S") == 0)
						num_futuros_pessoais++;
				}
				else
				{
					num_hoje++;
					if (reader.GetString(1).Trim().CompareTo("S") == 0)
						num_hoje_pessoais++;
				}
			}
			reader.Close();
		}
		
		public int NumPendencias(string where)
		{
			FbCommand cmd =  new FbCommand("select count(*) from AGENDA where DAT_SOLUCAO is null" + where, Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);
			if (!reader.Read())
			{
				return 0;
			}
			int n = reader.GetInt32(0);
			reader.Close();
			return n;
		}
		
		public void Carrega(DataGridView grid, string where)
		{
			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			adapter.SelectCommand = new FbCommand("select a.COD_USUARIO," + //0
												  "       a.DAT_AGENDAMENTO," + //1
												  "       a.DAT_PREVISAO," + //2
												  "       a.COD_RESPONSAVEL," + //3
												  "       a.COD_PARCEIRO," + //4
												  "       a.COD_CONTATO," + //5
												  "       a.IDT_PRIORIDADE," + //6
												  "       a.COD_NATUREZA," + //7
												  "       a.DES_PENDENCIA," + //8
												  "       a.DAT_SOLUCAO, " + //9
												  "       a.DES_SOLUCAO," + //10
												  "       a.IDT_PESSOAL," + //11
												  "       a.IDT_CANCELADO," + //12
												  "       ' '," + //13
												  "       p.NOM_PARCEIRO," + //14
												  "       p.DES_LOGRADOURO,p.NRO_ENDERECO,p.DES_COMPLEMENTO,NOM_BAIRRO," + //15-18
												  "       p.DES_LOGRADOURO_ENTREGA,p.NRO_ENDERECO_ENTREGA,p.DES_COMPLEMENTO_ENTREGA,NOM_BAIRRO_ENTREGA," + //19-22
												  "       p.NRO_FONE1," + //23
												  "       c.NOM_CONTATO," + //24
												  "       c.DES_PAPEL," + //25
												  "       c.NRO_FONE1, " + //26
												  "       p.NRO_CELULAR, " + //27
												  "       c.NRO_CELULAR, " + //28
												  "       a.DAT_APP, " + //29
												  "       a.DES_ENCERRAMENTO " + //30
			                                      "from AGENDA a " +
												  "left outer join PARCEIROS p " +
												  "on p.COD_PARCEIRO=a.COD_PARCEIRO " +			                                      
												  "left outer join CONTATOS c " +
												  "on c.COD_PARCEIRO=a.COD_PARCEIRO and c.COD_CONTATO=a.COD_CONTATO " +
												  //"on c.COD_PARCEIRO=p.COD_PARCEIRO " +
												  //"and c.COD_CONTATO in (select first 1 COD_CONTATO from CONTATOS c2 where c2.COD_PARCEIRO=p.COD_PARCEIRO) " +
			                                      where + " " +
			                                      "order by a.COD_USUARIO,a.DAT_AGENDAMENTO", 
			                                      Globais.bd);
			adapter.Fill(table);
			table.Columns[0].ColumnName = "Usuário";
			table.Columns[1].ColumnName = "Data Agendamento";
			table.Columns[2].ColumnName = "Data";			
			table.Columns[3].ColumnName = "Responsável";						
			table.Columns[4].ColumnName = "Parceiro";						
			table.Columns[5].ColumnName = "Contato";									
			table.Columns[6].ColumnName = "Prioridade";
			table.Columns[7].ColumnName = "Natureza";
			table.Columns[8].ColumnName = "Pendência";
			table.Columns[9].ColumnName = "Data Solução";
			table.Columns[10].ColumnName = "Solução";
			table.Columns[11].ColumnName = "Pessoal";
			table.Columns[12].ColumnName = "Cancelado";
			table.Columns[13].ColumnName = "Situação";
			table.Columns[14].ColumnName = "Razão";
			table.Columns[15].ColumnName = "Rua";
			table.Columns[16].ColumnName = "Nro";
			table.Columns[17].ColumnName = "Compl";
			table.Columns[18].ColumnName = "Bairro";
			table.Columns[19].ColumnName = "RuaEntrega";
			table.Columns[20].ColumnName = "NroEntrega";
			table.Columns[21].ColumnName = "ComplEntrega";
			table.Columns[22].ColumnName = "BairroEntrega";
			table.Columns[23].ColumnName = "Fone";			
			table.Columns[24].ColumnName = "NomeContato";			
			table.Columns[25].ColumnName = "Papel";			
			table.Columns[26].ColumnName = "FoneContato";
			table.Columns[27].ColumnName = "Celular";	
			table.Columns[28].ColumnName = "CelularContato";	
			table.Columns[29].ColumnName = "DatApp";	
			table.Columns[30].ColumnName = "ObsApp";	
			grid.DataSource = table;
			grid.Columns[1].Visible = false; // data
			grid.Columns[4].Visible = false; // parceiro
			grid.Columns[5].Visible = false; // contato
			//grid.Columns[6].Visible = false; // prioridade
			grid.Columns[7].Visible = false; // natureza
			grid.Columns[8].Visible = false; // pendencia
			grid.Columns[9].Visible = false; // dat_solucao			
			grid.Columns[10].Visible = false; // solucao
			grid.Columns[11].Visible = false; // pessoal
			grid.Columns[12].Visible = false; // cancelado
			for (int i=14; i<31; i++)
				grid.Columns[i].Visible = false;
		}
		
		public void CarregaAnexos(DataGridView grid, string usuario, DateTime data)
		{
			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			adapter.SelectCommand = new FbCommand("select COD_ANEXO," +
												  "       DES_ARQ_ANEXO " +			                                      			                                      			                                      
			                                      "from ANEXOS " +
				    	                          "where COD_USUARIO='" + usuario + "' and " +
                          				    	  "      DAT_AGENDAMENTO='" + data.ToString("M/d/yyyy HH:mm:ss") + "' " +
			                                      "order by COD_ANEXO",
			                                      Globais.bd);
			adapter.Fill(table);			
			table.Columns[0].ColumnName = "Código";
			table.Columns[1].ColumnName = "Arquivo";
			grid.DataSource = table;
		}
		
		public string CarregaAnexo(string usuario, DateTime data, string codigo)
		{
			Byte[] conteudo;
			FileStream fs = null;
			FbCommand cmd = new FbCommand("select des_conteudo,des_arq_anexo from anexos " +
				    	                  "where COD_USUARIO='" + usuario + "' and " +
                          				  "      DAT_AGENDAMENTO='" + data.ToString("M/d/yyyy HH:mm:ss") + "' and " +
                          				  "      COD_ANEXO='" + codigo + "'",
			                              Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			if (!reader.Read()) return null;
			string arq = reader.GetString(1).Trim();
			string ext="";
			int i = arq.LastIndexOf('.');
			if (i > 0)
			{
				ext = arq.Substring(i, arq.Length-i);
			}
			conteudo = new Byte[(reader.GetBytes(0, 0, null, 0, int.MaxValue))];
			reader.GetBytes(0, 0, conteudo, 0, conteudo.Length);
			reader.Close();
			//fs = new FileStream("tmp_" + codigo + ext, FileMode.Create, FileAccess.Write); 
			fs = new FileStream("anexo" + ext, FileMode.Create, FileAccess.Write); 
			fs.Write(conteudo, 0, conteudo.Length);
			fs.Close();
			//return "tmp_" + codigo + ext;
			return "anexo" + ext;
		}
		
		
		public bool Inclui(string usuario, DateTime data_agendamento,
		                   DateTime data_previsao, string responsavel,
						   string parceiro, string contato,
						   string prioridade, string natureza,
		                   string pendencia, 
		                   bool solucionado,
		                   DateTime data_solucao, string solucao,
		                   string idt_pessoal, string idt_cancelado,
		                   int seqAcao,
		                   ref string msg)
		{
			//CultureInfo ci = new CultureInfo("en-US");
			/*
			int codigo=1;
			FbCommand cmd = new FbCommand("select max(COD_AGENDA) from AGENDA " +
				    	                  "where COD_USUARIO='" + usuario + "'",
			                              Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			if (reader.Read())
			{
				if (!reader.IsDBNull(0))
					codigo = reader.GetInt32(0) + 1;
			}
			reader.Close();
			*/
			
			string _natureza;
			if (natureza.Trim().CompareTo("") == 0)
				_natureza = "null";
			else
				_natureza= "'" + natureza + "'";				
			
			string _data_solucao;
			if (!solucionado)
				_data_solucao = "null";
			else
				_data_solucao = "'" + data_solucao.ToString("M/d/yyyy HH:mm:ss") + "'";

			string fk_parceiro;
			if (parceiro.Trim().Length > 0)
				fk_parceiro = "'" + parceiro + "'";
			else
				fk_parceiro = "null";
			string sql = "insert into AGENDA (COD_USUARIO,DAT_AGENDAMENTO,DAT_PREVISAO,COD_RESPONSAVEL,COD_PARCEIRO," +
				         "COD_CONTATO,IDT_PRIORIDADE,COD_NATUREZA,DES_PENDENCIA,DAT_SOLUCAO,DES_SOLUCAO,IDT_PESSOAL,IDT_CANCELADO) " +
				         "values(" +
						 "'"  + usuario + "'," +								
						 "'"  + data_agendamento.ToString("M/d/yyyy HH:mm:ss") + "'," +
						 "'"  + data_previsao.ToString("M/d/yyyy HH:mm:ss") + "'," +		
						 "'"  + responsavel + "'," +												
						 fk_parceiro + "," +
						 "'"  + contato + "'," +
						 "'"  + prioridade + "'," +
						 _natureza + "," +		
						 "'"  + pendencia + "'," +				
						 _data_solucao + "," +					
						 "'"  + solucao + "'," +								
						 "'"  + idt_pessoal + "'," +				
						 "'"  + idt_cancelado + "')";
			FbCommand cmd = new FbCommand(sql, Globais.bd);
			try
			{
				Log.Grava(Globais.sUsuario, cmd.CommandText);
				cmd.ExecuteNonQuery();
				if (seqAcao != 0) {
					sql = "insert into AGENDAMENTOS_ACOES values(" +
						seqAcao + "," +
						"'"  + usuario + "'," +
						"'"  + data_agendamento.ToString("M/d/yyyy HH:mm:ss") + "'," +
						"'"  + data_agendamento.ToString("M/d/yyyy HH:mm:ss") + "')";
					cmd = new FbCommand(sql, Globais.bd);
					Log.Grava(Globais.sUsuario, cmd.CommandText);
					cmd.ExecuteNonQuery();
				}
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
		
		public bool IncluiAnexo(string usuario, DateTime data_agendamento,
		                   string codigo, string arquivo,
		                   ref string msg)
		{
			
			FileStream fs = new FileStream(arquivo, FileMode.OpenOrCreate, FileAccess.Read);
			byte[] conteudo= new byte[fs.Length];
			fs.Read(conteudo, 0, System.Convert.ToInt32(fs.Length));
			fs.Close();
/*			
			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			adapter.SelectCommand = new FbCommand(
										  "select DAT_AGENDA,COD_USUARIO,COD_ANEXO,DES_ARQ_ANEXO,DES_CONTEUDO from anexos " +
				    	                  "where DAT_AGENDA='" + data.ToString("M/d/yyyy HH:mm:ss") + "' and " +
                          				  "      COD_USUARIO='" + usuario + "' and " +
                          				  "      COD_ANEXO='" + codigo + "'",
			                              Globais.bd);
			adapter.Fill(table);
			DataRow row = table.NewRow();
			row[0] = data;
			row[1] = usuario;
			row[2] = codigo;
			row[3] = arquivo;
			row[4] = conteudo;
			adapter.Update(table);
*/			

			string sql = "insert into ANEXOS values(" +
						 "'"  + usuario + "'," +								
						 "'"  + data_agendamento.ToString("M/d/yyyy HH:mm:ss") + "'," +
						 "'"  + codigo + "'," +				
						 "'"  + arquivo + "', ?)";
				
			FbCommand cmd = new FbCommand(sql, Globais.bd);
			FbParameter prm = cmd.Parameters.Add("blob", FbDbType.Binary, conteudo.Length);
			prm.Direction = ParameterDirection.Output;
			prm.Value = conteudo;
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
		
		public bool Altera(string usuario, DateTime data_agendamento,
		                   DateTime data_previsao, string responsavel,
						   string parceiro, string contato,
						   string prioridade, string natureza,
		                   string pendencia, 
		                   bool solucionado,
		                   DateTime data_solucao, string solucao,
		                   string idt_pessoal, string idt_cancelado,		
						   bool encerrado, DateTime data_encerramento, 		                   
		                   ref string msg)
		{
			AtualizaUltimoContatoAcao(usuario, data_agendamento, data_previsao, solucionado, data_solucao);
			string _natureza;			
			if (natureza.Trim().CompareTo("") == 0)
				_natureza= "null";
			else
				_natureza= "'" + natureza + "'";				
			
			string _data_solucao;
			if (!solucionado)
				_data_solucao = "null";
			else
				_data_solucao = "'" + data_solucao.ToString("M/d/yyyy HH:mm:ss") + "'";
			
			string _data_encerramento;
			if (!encerrado)
				_data_encerramento = "null";
			else
				_data_encerramento = "'" + data_encerramento.ToString("M/d/yyyy HH:mm:ss") + "'";

			string fk_parceiro;
			if (parceiro.Trim().Length > 0)
				fk_parceiro = "'" + parceiro + "'";
			else
				fk_parceiro = "null";
			string sql = "update AGENDA set " +
						 "dat_previsao='" + data_previsao.ToString("M/d/yyyy HH:mm:ss") + "'," +				
						 "cod_responsavel='" + responsavel + "', " + 								
						 "cod_parceiro=" + fk_parceiro + ", " + 												
						 "cod_contato='" + contato + "', " + 																
						 "idt_prioridade='" + prioridade + "', " +
						 "cod_natureza=" + _natureza + ", " + 					
						 "des_pendencia='" + pendencia + "', " + 							
						 "dat_solucao=" + _data_solucao + "," +				
						 "des_solucao='" + solucao + "', " + 												
						 "idt_pessoal='" + idt_pessoal + "', " + 				
						 "idt_cancelado='" + idt_cancelado + "', " + 								
						  "dat_app=" + _data_encerramento + " " +		
				    	 "where COD_USUARIO='" + usuario + "' and " +
                         "      DAT_AGENDAMENTO='" + data_agendamento.ToString("M/d/yyyy HH:mm:ss") + "'";
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
		
		public bool Exclui(string usuario, DateTime data, ref string msg)
		{
			string sql = "delete from AGENDA " +
				    	 "where COD_USUARIO='" + usuario + "' and " +
                         "      DAT_AGENDAMENTO='" + data.ToString("M/d/yyyy HH:mm:ss") + "'";
			FbCommand cmd = new FbCommand(sql, Globais.bd);
			try
			{
				Log.Grava(Globais.sUsuario, cmd.CommandText);
				cmd.ExecuteNonQuery();
				sql = "delete from AGENDAMENTOS_ACOES " +
						"where COD_USUARIO='" + usuario + "' and " +
						"      DAT_AGENDAMENTO='" + data.ToString("M/d/yyyy HH:mm:ss") + "'";
				cmd = new FbCommand(sql, Globais.bd);
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
		
		public bool ExcluiAnexo(string usuario, DateTime data, string codigo, ref string msg)
		{
			string sql = "delete from ANEXOS " +
				    	 "where COD_USUARIO='" + usuario + "' and " +
                         "      DAT_AGENDAMENTO='" + data.ToString("M/d/yyyy HH:mm:ss") + "' and " +
                         "      COD_ANEXO='" + codigo + "'";
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

		private Phrase Frase(string texto, int tamanho)
		{
			Chunk chunk;
			Phrase phrase = new Phrase();
			chunk = new Chunk(texto, FontFactory.GetFont(BaseFont.HELVETICA, tamanho));
			phrase.Add(chunk);
			return phrase;
		}
		
		private Phrase Frase(string texto1, string texto2, int tamanho)
		{
			Chunk chunk;
			Phrase phrase = new Phrase();
			chunk = new Chunk(texto1, FontFactory.GetFont(BaseFont.HELVETICA, tamanho));
			phrase.Add(chunk);
			chunk = new Chunk(texto2, FontFactory.GetFont(BaseFont.HELVETICA_BOLD, tamanho));			
			phrase.Add(chunk);
			return phrase;
		}
		
		private PdfPTable Parte11()
		{
			Tabela table = new Tabela(1);
			PdfPCell cell;
			Chunk chunk;
			string logo = "imagens\\logo_rel.jpg";
			Image img;
			float largura=80F;
			float altura=100F;
			try
			{
				img = Image.GetInstance(logo);
				float w=img.Width;
				float h=img.Height;
				while ((w > largura) || (h > altura))
				{
					w *= 0.9F;
					h *= 0.9F;
				}
				img.ScaleAbsolute(w, h);
				chunk = new Chunk(img, 0, 0);
			}
			catch
			{
				chunk = new Chunk("");
			}
			cell = new PdfPCell(new Phrase(chunk));
			cell.BorderWidth = 0;
			table.AddCell(cell);
			return table;
		}

		private PdfPTable Parte12(string titulo)
		{
			Tabela table = new Tabela(1);
			Chunk chunk = new Chunk(titulo, FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 16));
			Celula cell = new Celula(new Phrase(chunk));
			cell.Padding = 1;
			//cell.Colspan = 11;
			//cell = new Celula(Frase(titulo, 10));
			table.AddCell(cell);
			return table;
		}
		
		private PdfPTable Parte13()
		{
			Tabela table = new Tabela(1);
			Celula cell;
			cell = new Celula(Frase("DATA: ", DateTime.Now.ToString("dd/MM/yyyyy"), 10));			
			table.AddCell(cell);
			return table;
		}
		
		private void Parte1(PDF pdf, string titulo)
		{
			Tabela table = new Tabela(22);
			PdfPCell cell;
			
			cell = new PdfPCell();
			cell.AddElement(Parte11());
			cell.Colspan = 4;
			table.AddCell(cell);
			
			cell = new PdfPCell();
			cell.AddElement(Parte12(titulo));
			cell.Colspan = 11;
			table.AddCell(cell);

			cell = new PdfPCell();
			cell.AddElement(Parte13());
			cell.Colspan = 7;
			table.AddCell(cell);

			pdf.doc.Add(table);
		}
		
		public bool Gera(DataGridView grid, string arquivo, bool idtI, DateTime dataI, bool idtF, DateTime dataF, string titulo)
		{
			/*
			FbCommand cmd;
			FbDataReader reader;
			
			cmd =  new FbCommand("select " +
			                     "a.NRO_NF," +
			                     "a.SEQ_TITULO," +
			                     "a.COD_CLIENTE," +
			                     "b.DES_NATUREZA," +
			                     "a.DAT_EMISSAO," +
			                     "a.DAT_VENCIMENTO," +
			                     "a.VLR_PREVISTO," +
			                     "a.VLR_RECEBIDO," +
			                     "a.DAT_RECEBIMENTO," +
			                     "c.DES_FORMA," +
			                     "a.TXT_OBSERVACAO " +
								 "from TITULOS_RECEBER a " +
								 "left outer join NATUREZAS_RECEBIMENTO b " +
								 "on b.COD_NATUREZA = a.COD_NATUREZA " +
								 "left outer join FORMAS_RECEBIMENTO c " +
								 "on c.COD_FORMA = a.COD_FORMA " +				
			                     where + " " +
			                     "order by a.DAT_VENCIMENTO",
			                     Globais.bd);
			reader = cmd.ExecuteReader(CommandBehavior.Default);
			*/
			
			PDF pdf = new PDF(arquivo);
			pdf.Abre();		
			
			/*
			pdf.CriaTabela(2, 0);
			pdf.AdicionaCelula("imagens\\logo_rel.jpg", 1000, 1000);
			pdf.AdicionaCelula(titulo, BaseFont.HELVETICA_BOLD, 16);
			pdf.AdicionaTabela();
			*/
			Parte1(pdf, titulo);
			
			pdf.CriaTabela(11, 0);
			
			pdf.AdicionaCelula("Responsável", BaseFont.HELVETICA_BOLD, 6, /*Color.LIGHT_GRAY,*/Element.ALIGN_LEFT, 2);	
			pdf.AdicionaCelula("Previsão", BaseFont.HELVETICA_BOLD, 6, /*Color.LIGHT_GRAY,*/Element.ALIGN_LEFT, 2);			
			pdf.AdicionaCelula("Realização", BaseFont.HELVETICA_BOLD, 6, /*Color.LIGHT_GRAY,*/Element.ALIGN_LEFT, 1);			
			pdf.AdicionaCelula("Usuário", BaseFont.HELVETICA_BOLD, 6, /*Color.LIGHT_GRAY,*/Element.ALIGN_LEFT, 3);			
			pdf.AdicionaCelula("Pri", BaseFont.HELVETICA_BOLD, 6, /*Color.LIGHT_GRAY,*/Element.ALIGN_LEFT, 1);
			pdf.AdicionaCelula("Natureza", BaseFont.HELVETICA_BOLD, 6, /*Color.LIGHT_GRAY,*/Element.ALIGN_LEFT, 2);
			
			pdf.AdicionaCelula("", BaseFont.HELVETICA_BOLD, 6, /*Color.LIGHT_GRAY,*/Element.ALIGN_LEFT, 2);								
			pdf.AdicionaCelula("Parceiro", BaseFont.HELVETICA_BOLD, 6, /*Color.LIGHT_GRAY,*/Element.ALIGN_LEFT, 3);	
			pdf.AdicionaCelula("Endereço", BaseFont.HELVETICA_BOLD, 6, /*Color.LIGHT_GRAY,*/Element.ALIGN_LEFT, 4);			
			pdf.AdicionaCelula("Fone", BaseFont.HELVETICA_BOLD, 6, /*Color.LIGHT_GRAY,*/Element.ALIGN_LEFT, 2);					
			
			pdf.AdicionaCelula("", BaseFont.HELVETICA_BOLD, 6, /*Color.LIGHT_GRAY,*/Element.ALIGN_LEFT, 2);											
			pdf.AdicionaCelula("Contato", BaseFont.HELVETICA_BOLD, 6, /*Color.LIGHT_GRAY,*/Element.ALIGN_LEFT, 3);	
			pdf.AdicionaCelula("Papel", BaseFont.HELVETICA_BOLD, 6, /*Color.LIGHT_GRAY,*/Element.ALIGN_LEFT, 4);					
			pdf.AdicionaCelula("Fone", BaseFont.HELVETICA_BOLD, 6, /*Color.LIGHT_GRAY,*/Element.ALIGN_LEFT, 2);

			pdf.AdicionaCelula("", BaseFont.HELVETICA_BOLD, 6, /*Color.LIGHT_GRAY,*/Element.ALIGN_LEFT, 2);
			pdf.AdicionaCelula("Descrição", BaseFont.HELVETICA_BOLD, 6, /*Color.LIGHT_GRAY,*/Element.ALIGN_LEFT, 9);								

			pdf.AdicionaCelulaLinha("", BaseFont.HELVETICA_BOLD, 6, /*Color.LIGHT_GRAY,*/Element.ALIGN_LEFT, 2);											
			pdf.AdicionaCelulaLinha("Solução", BaseFont.HELVETICA_BOLD, 6, /*Color.LIGHT_GRAY,*/Element.ALIGN_LEFT, 9);

			foreach (DataGridViewRow row in  grid.Rows)
			{
				DateTime data = DateTime.Parse(row.Cells["Data"].Value.ToString());
				if (idtI && (data.Date < dataI.Date))
				{
					continue;
				}
				if (idtF && (data.Date > dataF.Date))
				{
					continue;
				}				
				
				data = DateTime.Parse(row.Cells["Data"].Value.ToString());
				pdf.AdicionaCelula(row.Cells["Responsável"].Value.ToString().Trim(), BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 2);	
				pdf.AdicionaCelula(data.ToString("d/M/yyyy HH:mm"), BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 2);							
				if ((row.Cells["Data Solução"].Value != null) && (!row.Cells["Data Solução"].Value.ToString().Trim().Equals("")))
				{
					data = DateTime.Parse(row.Cells["Data Solução"].Value.ToString());				
					pdf.AdicionaCelula(data.ToString("d/M/yyyy"), BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 1);
				}
				else
					pdf.AdicionaCelula("", BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 1);
				pdf.AdicionaCelula(row.Cells["Usuário"].Value.ToString().Trim(), BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 3);							
				switch (row.Cells["Prioridade"].Value.ToString()[0])
				{
					case '0': pdf.AdicionaCelula("Urgente", BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 1); break;
					case '1': pdf.AdicionaCelula("Importante", BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 1); break;
					case '2': pdf.AdicionaCelula("Normal", BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 1); break;
				}
				pdf.AdicionaCelula(row.Cells["Natureza"].Value.ToString().Trim(), BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 2);
				
			
				pdf.AdicionaCelula("", BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 2);								
				if (row.Cells["Razão"].Value != null)
					pdf.AdicionaCelula(row.Cells["Razão"].Value.ToString().Trim(), BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 3);	
				else
					pdf.AdicionaCelula("", BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 2);
				string endereco="";
				if ((row.Cells["RuaEntrega"].Value != null) && (!row.Cells["RuaEntrega"].Value.ToString().Trim().Equals("")))
				{
					endereco = row.Cells["RuaEntrega"].Value.ToString().Trim() + " - " +
						row.Cells["NroEntrega"].Value.ToString().Trim() + " - " +
						row.Cells["ComplEntrega"].Value.ToString().Trim() + " - " +
						row.Cells["BairroEntrega"].Value.ToString().Trim();
				}
				else
				{
					endereco = row.Cells["Rua"].Value.ToString().Trim() + " - " +
						row.Cells["Nro"].Value.ToString().Trim() + " - " +
						row.Cells["Compl"].Value.ToString().Trim() + " - " +
						row.Cells["Bairro"].Value.ToString().Trim();					
				}
				pdf.AdicionaCelula(endereco, BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 4);			
				
				string fones = FONES.Concatena(row.Cells["Fone"].Value, row.Cells["Celular"].Value);
				pdf.AdicionaCelula(fones, BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 2);
			
				pdf.AdicionaCelula("", BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 2);											
				if (row.Cells["NomeContato"].Value != null)
				{
					pdf.AdicionaCelula(row.Cells["NomeContato"].Value.ToString().Trim(), BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 3);	
					pdf.AdicionaCelula(row.Cells["Papel"].Value.ToString().Trim(), BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 4);	
					
					fones = FONES.Concatena(row.Cells["FoneContato"].Value, row.Cells["CelularContato"].Value);
					pdf.AdicionaCelula(fones, BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 2);
				}
				else
					pdf.AdicionaCelula("", BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 9);				

				pdf.AdicionaCelula("", BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 2);											
				pdf.AdicionaCelula(row.Cells["Pendência"].Value.ToString().Trim(), BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 9);								

				pdf.AdicionaCelula("", BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 2);											
				if (row.Cells["Solução"].Value != null)
					pdf.AdicionaCelula(row.Cells["Solução"].Value.ToString().Trim(), BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 9);				
				else
					pdf.AdicionaCelula("", BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 9);		
				
				pdf.AdicionaTabela();
				
				pdf.CriaTabela(128, 0);
				for (int i=0; i<128; i++) {
					Cell cell = new Cell(new Paragraph(""));	
					cell.BorderWidthBottom = i % 2;			
					pdf.tabela.AddCell(cell);
				}
				
				pdf.AdicionaTabela();
				pdf.CriaTabela(11, 0);
			}
			pdf.AdicionaTabela();			
			pdf.Fecha();
			return true;
		}
		
		public static void AtualizaUltimoContatoAcao(string usuario, 
		                                             DateTime dataAgendamento,
		                                             DateTime dataPrevisao,
		                                             bool solucionado,
		                                             DateTime dataSolucao) {

			// verifica se a data de previsão foi alterada	
			// ou se a data de solução > data contato			
			bool dataAlterada = true;
			DateTime dataContato = dataPrevisao;
			string sql = "select DAT_PREVISAO from AGENDA "
			    + "where COD_USUARIO='" + usuario + "' "
			    + "  and DAT_AGENDAMENTO='" + dataAgendamento.ToString("M/d/yyyy HH:mm:ss") + "'";			
			FbCommand cmd =  new FbCommand(sql, Globais.bd);
			FbDataReader cursor = cmd.ExecuteReader(CommandBehavior.Default);
			if (cursor.Read()) {
				DateTime dataPrevisaoAnterior = cursor.GetDateTime(0);
				if (dataPrevisaoAnterior == dataPrevisao) {
					dataAlterada = false;
				}
				if (solucionado && (dataSolucao > dataPrevisao)) {
					dataAlterada = true;
					dataContato = dataSolucao;
				}
			}			
			cursor.Close();
			
			if (!dataAlterada) {
				return;
			}
			
			sql = "update AGENDAMENTOS_ACOES "
				+ "set DAT_CONTATO='" + dataContato.ToString("M/d/yyyy HH:mm:ss") + "' "
			    + "where COD_USUARIO='" + usuario + "' "
			    + "  and DAT_AGENDAMENTO='" + dataAgendamento.ToString("M/d/yyyy HH:mm:ss") + "'";			
			cmd = new FbCommand(sql, Globais.bd);
			try {
				Log.Grava(Globais.sUsuario, cmd.CommandText);
				cmd.ExecuteNonQuery();
			} catch (Exception err) {
				Log.Grava(Globais.sUsuario, "erro:" + err.Message);
			}
		}
	}
	
}
