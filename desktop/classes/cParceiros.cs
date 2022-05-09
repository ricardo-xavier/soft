/*
 * Projeto  : SoftPlace
 * Programa : cParceiros - Classe de Parceiros
 * Autor    : Ricardo Costa Xavier
 * Data     : 10/04/08
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
	public class cParceiro
	{
		public string NOM_PARCEIRO;                    //CHAR(50) Not Null
		public string IDT_FISJUR;                      //CHAR(1) Nullable
		public string NRO_CPF_CNPJ;                    //CHAR(14) Nullable
		public string DES_LOGRADOURO;                  //CHAR(50) Nullable
		public string NRO_ENDERECO;                    //CHAR(6) Nullable
		public string DES_COMPLEMENTO;                 //CHAR(20) Nullable
		public string NOM_BAIRRO;                      //CHAR(50) Nullable
		public string NOM_CIDADE;                      //CHAR(50) Nullable
		public string COD_ESTADO;                      //CHAR(2) Nullable
		public string NRO_CEP;                         //CHAR(8) Nullable
		public string DES_LOGRADOURO_ENTREGA;          //CHAR(50) Nullable
		public string NRO_ENDERECO_ENTREGA;            //CHAR(6) Nullable
		public string DES_COMPLEMENTO_ENTREGA;         //CHAR(20) Nullable
		public string NOM_BAIRRO_ENTREGA;              //CHAR(50) Nullable
		public string NOM_CIDADE_ENTREGA;              //CHAR(50) Nullable
		public string COD_ESTADO_ENTREGA;              //CHAR(2) Nullable
		public string NRO_CEP_ENTREGA;                 //CHAR(8) Nullable
		public string NRO_FONE1;                       //CHAR(10) Nullable
		public string NRO_CELULAR;                     //CHAR(10) Nullable
		
		public cParceiro()
		{
		}
		
		public bool Le(string codigo)
		{
			FbCommand cmd =  new FbCommand("select " +
					"NOM_PARCEIRO," +
					"IDT_FISJUR," +
					"NRO_CPF_CNPJ," +
					"DES_LOGRADOURO," +
					"NRO_ENDERECO," +
					"DES_COMPLEMENTO," +
					"NOM_BAIRRO," +
					"NOM_CIDADE," +
					"COD_ESTADO," +
					"NRO_CEP," +
					"DES_LOGRADOURO_ENTREGA," +
					"NRO_ENDERECO_ENTREGA," +
					"DES_COMPLEMENTO_ENTREGA," +
					"NOM_BAIRRO_ENTREGA," +
					"NOM_CIDADE_ENTREGA," +
					"COD_ESTADO_ENTREGA," +
					"NRO_CEP_ENTREGA," +
					"NRO_FONE1," +
					"NRO_CELULAR " +
					"from PARCEIROS where COD_PARCEIRO='" + codigo + "'", Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			if (!reader.Read())
			{
				reader.Close();
				return false;
			}
			NOM_PARCEIRO = reader.GetString(0).Trim();
			IDT_FISJUR = reader.GetString(1).Trim();
			NRO_CPF_CNPJ = reader.GetString(2).Trim();
			DES_LOGRADOURO = reader.GetString(3).Trim();
			NRO_ENDERECO = reader.GetString(4).Trim();
			DES_COMPLEMENTO = reader.GetString(5).Trim();
			NOM_BAIRRO = reader.GetString(6).Trim();
			NOM_CIDADE = reader.GetString(7).Trim();
			COD_ESTADO = reader.GetString(8).Trim();
			NRO_CEP = reader.GetString(9).Trim();
			DES_LOGRADOURO_ENTREGA = reader.GetString(10).Trim();
			NRO_ENDERECO_ENTREGA = reader.GetString(11).Trim();
			DES_COMPLEMENTO_ENTREGA = reader.GetString(12).Trim();
			NOM_BAIRRO_ENTREGA = reader.GetString(13).Trim();
			NOM_CIDADE_ENTREGA = reader.GetString(14).Trim();
			COD_ESTADO_ENTREGA = reader.GetString(15).Trim();
			NRO_CEP_ENTREGA = reader.GetString(16).Trim();
			NRO_FONE1 = reader.GetString(17).Trim();
			NRO_CELULAR = reader.GetString(18).Trim();
			reader.Close();
			return true;
		}
		
	}
	
	public class cParceiros
	{
		public cParceiros()
		{
		}
		
		public int NumClientes()
		{
			FbCommand cmd =  new FbCommand("select count(*) from PARCEIROS where IDT_CLIENTE='S'", Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			if (!reader.Read())
			{
				reader.Close();				
				return 0;
			}
			int n = reader.GetInt32(0);
			reader.Close();
			return n;
		}
		
		public int NumFornecedores()
		{
			FbCommand cmd =  new FbCommand("select count(*) from PARCEIROS where IDT_FORNECEDOR='S'", Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			if (!reader.Read())
			{
				reader.Close();				
				return 0;
			}
			int n = reader.GetInt32(0);
			reader.Close();
			return n;
		}
		
		public int NumConsultores()
		{
			FbCommand cmd =  new FbCommand("select count(*) from PARCEIROS where IDT_CONSULTOR='S'", Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			if (!reader.Read())
			{
				reader.Close();				
				return 0;
			}
			int n = reader.GetInt32(0);
			reader.Close();
			return n;
		}
		
		public bool Procura(string codigo, ref string nome, ref string fisjur)
		{
			FbCommand cmd =  new FbCommand("select NOM_PARCEIRO,IDT_FISJUR from PARCEIROS where COD_PARCEIRO='" + codigo + "'", Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			if (!reader.Read())
			{
				reader.Close();
				return false;
			}
			nome = reader.GetString(0).Trim();
			fisjur = reader.GetString(1).Trim();
			reader.Close();
			return true;
		}
		
		public string ProcuraPorCpfCnpj(string cpfCnpj)
		{
			FbCommand cmd =  new FbCommand("select NOM_PARCEIRO from PARCEIROS where NRO_CPF_CNPJ='" + cpfCnpj.Trim() + "'", Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			if (!reader.Read())
			{
				reader.Close();
				return null;
			}
			string nome = reader.GetString(0).Trim(); 
			reader.Close();
			return nome;
		}
		
		public void Carrega(DataGridView grid, string where)
		{
			FbDataAdapter adapter = new FbDataAdapter();
			DataTable table = new DataTable();
			adapter.SelectCommand = new FbCommand("select COD_PARCEIRO," +
			                                      "       NOM_PARCEIRO," +
												  "       IDT_CLIENTE, " +			                                      
												  "       IDT_FORNECEDOR, " +			                                      
												  "       IDT_CONSULTOR, " +			                                      												  
			                                      "       IDT_FISJUR," +			                                      
			                                      "       NRO_CPF_CNPJ," +
			                                      "       nro_inscricao_estadual," +
			                                      "       nro_inscricao_municipal," +
												  "       DES_LOGRADOURO," +
												  "       NRO_ENDERECO," +
												  "       DES_COMPLEMENTO," +
												  "       NOM_BAIRRO," +
												  "       NOM_CIDADE," +
												  "       COD_ESTADO," +
												  "       NRO_CEP," +
												  "       DES_LOGRADOURO_ENTREGA," +
												  "       NRO_ENDERECO_ENTREGA," +
												  "       DES_COMPLEMENTO_ENTREGA," +
												  "       NOM_BAIRRO_ENTREGA," +
												  "       NOM_CIDADE_ENTREGA," +
												  "       COD_ESTADO_ENTREGA," +
												  "       NRO_CEP_ENTREGA," +
												  "       DES_LOGRADOURO_COBRANCA," +
												  "       NRO_ENDERECO_COBRANCA," +
												  "       DES_COMPLEMENTO_COBRANCA," +
												  "       NOM_BAIRRO_COBRANCA," +
												  "       NOM_CIDADE_COBRANCA," +
												  "       COD_ESTADO_COBRANCA," +
												  "       NRO_CEP_COBRANCA," +
												  "       NRO_FONE1," +
												  "       NRO_FONE2," +												  
												  "       NRO_CELULAR," +
												  "       NRO_FAX," +												  
												  "       DES_EMAIL, " +
												  "       IDT_ATIVO, " +	
												  "       NRO_PEDIDO," +
												  "       DAT_CADASTRO, " +
												  "       DAT_NASCIMENTO, " +
												  "       TIRA_ACENTOS(COD_PARCEIRO) as COD_PARCEIRO_PESQUISA, " +
												  "       TIRA_ACENTOS(NOM_PARCEIRO) as NOM_PARCEIRO2_PESQUISA " +
			                                      "from PARCEIROS " +
			                                      where + " " +
			                                      "order by COD_PARCEIRO", 
			                                      Globais.bd);
			adapter.Fill(table);
			table.Columns[0].ColumnName = "Código";
			table.Columns[1].ColumnName = "Nome";
			table.Columns[6].ColumnName = "Cnpj/Cpf";
			grid.DataSource = table;
			grid.Columns[2].Visible = false; // cliente
			grid.Columns[3].Visible = false; // fornecedor
			grid.Columns[4].Visible = false; // consultor
			grid.Columns[5].Visible = false; // fisjur
			grid.Columns[6].Visible = true; // cpf_cnpj
			grid.Columns[7].Visible = false; // ins est
			grid.Columns[8].Visible = false; // ins mun
			grid.Columns[9].Visible = false; // logradouro
			grid.Columns[10].Visible = false; // nro
			grid.Columns[11].Visible = false; // complemento
			grid.Columns[12].Visible = false; // bairro
			grid.Columns[13].Visible = false; // cidade
			grid.Columns[14].Visible = false; // estado
			grid.Columns[15].Visible = false; // cep			
			grid.Columns[16].Visible = false; // logradouro
			grid.Columns[17].Visible = false; // nro
			grid.Columns[18].Visible = false; // complemento
			grid.Columns[19].Visible = false; // bairro
			grid.Columns[20].Visible = false; // cidade
			grid.Columns[21].Visible = false; // estado
			grid.Columns[22].Visible = false; // cep			
			grid.Columns[23].Visible = false; // logradouro
			grid.Columns[24].Visible = false; // nro
			grid.Columns[25].Visible = false; // complemento
			grid.Columns[26].Visible = false; // bairro
			grid.Columns[27].Visible = false; // cidade
			grid.Columns[28].Visible = false; // estado
			grid.Columns[29].Visible = false; // cep			
			grid.Columns[30].Visible = false; // fone1
			grid.Columns[31].Visible = false; // fone2			
			grid.Columns[32].Visible = false; // celular
			grid.Columns[33].Visible = false; // fax
			grid.Columns[34].Visible = false; // email	
			grid.Columns[35].Visible = false; // ativo			
			grid.Columns[36].Visible = false; // pedido
			grid.Columns[37].Visible = false; // alteracao
			grid.Columns[38].Visible = false; // nascimento
			grid.Columns[39].Visible = false; // COD_PARCEIRO_PESQUISA
			grid.Columns[40].Visible = false; // NOM_PARCEIRO_PESQUISA
			
			grid.Columns["Código"].Width = 80;
			grid.Columns["Cnpj/Cpf"].Width = 80;
		}
		
		public bool Inclui(string codigo, string nome, 
		                   string cliente, string fornecedor, string consultor,
		                   string fisjur, string cpf_cnpj,
		                   string insest, string insmun,
		                   string logr, string nro, string compl, 
		                   string bairro, string cidade,
		                   string estado, string cep, 
		                   string logr_entrega, string nro_entrega, string compl_entrega, 
		                   string bairro_entrega, string cidade_entrega,
		                   string estado_entrega, string cep_entrega, 
		                   string logr_cobranca, string nro_cobranca, string compl_cobranca, 
		                   string bairro_cobranca, string cidade_cobranca,
		                   string estado_cobranca, string cep_cobranca, 
		                   string fone1, string fone2, string celular, string fax,
		                   string email, 
		                   bool idt_nascimento, DateTime dat_nascimento,
		                   string ativo, int nro_pedido, ref string msg)
		{
			string _estado;
			if (estado.Trim().CompareTo("") == 0)
			{
				_estado = "null,";	
			}
			else
			{
				_estado = "'"  + estado + "',";
			}
			string _estado_entrega;
			if (estado_entrega.Trim().CompareTo("") == 0)
			{
				_estado_entrega = "null,";	
			}
			else
			{
				_estado_entrega = "'"  + estado_entrega + "',";
			}
			string _estado_cobranca;
			if (estado_cobranca.Trim().CompareTo("") == 0)
			{
				_estado_cobranca = "null,";	
			}
			else
			{
				_estado_cobranca = "'"  + estado_cobranca + "',";
			}
			string sql = "insert into PARCEIROS values(" +
						 "'"  + codigo + "'," +
 						 "'"  + nome + "'," +
 						 "'"  + cliente + "'," +				
 						 "'"  + fornecedor + "'," +				
 						 "'"  + consultor + "'," +								
 						 "'"  + fisjur + "'," +								
						 "'"  + cpf_cnpj + "'," +
						 "'"  + logr + "'," +
						 "'"  + nro + "'," +
						 "'"  + compl + "'," +
						 "'"  + bairro + "'," +
						 "'"  + cidade + "'," +
						 _estado + 
						 "'"  + cep + "'," +
						 "'"  + logr_entrega + "'," +
						 "'"  + nro_entrega + "'," +
						 "'"  + compl_entrega + "'," +
						 "'"  + bairro_entrega + "'," +
						 "'"  + cidade_entrega + "'," +
						 _estado_entrega + 
						 "'"  + cep_entrega + "'," +
						 "'"  + logr_cobranca + "'," +
						 "'"  + nro_cobranca + "'," +
						 "'"  + compl_cobranca + "'," +
						 "'"  + bairro_cobranca + "'," +
						 "'"  + cidade_cobranca + "'," +
						 _estado_cobranca + 
						 "'"  + cep_cobranca + "'," +
						 "'"  + fone1 + "'," +
						 "'"  + fone2 + "'," +				
						 "'"  + celular + "'," +
						 "'"  + fax + "'," +				
						 "'"  + email + "'," +
						 "'"  + ativo + "'," +			
						 "'"  + insest + "'," +
						 "'"  + insmun + "'," +
						 nro_pedido + "," +
						 "'"  + DateTime.Today.Date.ToString("M/d/yyyy") + "',";
			if (idt_nascimento)
				sql += "'" + dat_nascimento.ToString("M/d/yyyy") + "')";
			else
				sql += "null)";
			/*
			FileStream fs = new FileStream("softplace.log", FileMode.Create);
			StreamWriter sw = new StreamWriter(fs);
			sw.WriteLine(sql);
			sw.Close();			
			*/
			
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
		
		public bool IncluiRapido(string codigo, string nome, 
		                   string fone1, string fone2, string celular, string fax,
		                   string email, ref string msg)
		{
			string sql = "insert into PARCEIROS " +
						"(COD_PARCEIRO,NOM_PARCEIRO,IDT_CLIENTE,IDT_FORNECEDOR,IDT_CONSULTOR," +
						"NRO_FONE1,NRO_FONE2,NRO_CELULAR,NRO_FAX,DES_EMAIL,IDT_ATIVO,IDT_FISJUR,DAT_CADASTRO) " +
						"values(" +
						 "'"  + codigo + "'," +
 						 "'"  + nome + "'," +
 						 "'S'," +
						 "'N'," +				
					     "'N'," +				
						 "'"  + fone1 + "'," +
						 "'"  + fone2 + "'," +				
						 "'"  + celular + "'," +
						 "'"  + fax + "'," +				
						 "'"  + email + "'," +				
						 "'S', 'J'," +
						 "'"  + DateTime.Today.Date.ToString("M/d/yyyy") + "')";
			
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
		
		
		public bool Altera(string codigo, string nome,
		                   string cliente, string fornecedor, string consultor,		                   
		                   string fisjur, string cpf_cnpj,
		                   string insest, string insmun,
		                   string logr, string nro, string compl, 
		                   string bairro, string cidade,
		                   string estado, string cep, 
		                   string logr_entrega, string nro_entrega, string compl_entrega, 
		                   string bairro_entrega, string cidade_entrega,
		                   string estado_entrega, string cep_entrega, 
		                   string logr_cobranca, string nro_cobranca, string compl_cobranca, 
		                   string bairro_cobranca, string cidade_cobranca,
		                   string estado_cobranca, string cep_cobranca, 
		                   string fone1, string fone2, string celular, string fax,
		                   string email, 
		                   bool idt_nascimento, DateTime dat_nascimento,		                   
		                   string ativo, int nro_pedido, ref string msg)
		{
			string sql = "update PARCEIROS set " +
						 "nom_parceiro='" + nome + "', " + 
						 "idt_cliente='" + cliente + "', " + 				
						 "idt_fornecedor='" + fornecedor + "', " + 				
						 "idt_consultor='" + consultor + "', " + 								
						 "idt_fisjur='" + fisjur + "', " + 								
						 "nro_cpf_cnpj='" + cpf_cnpj + "', " + 
						 "nro_inscricao_estadual='" + insest + "', " + 
						 "nro_inscricao_municipal='" + insmun + "', " + 				
						 "des_logradouro='" + logr + "', " + 
						 "nro_endereco='" + nro + "', " + 
						 "des_complemento='" + compl + "', " + 
						 "nom_bairro='" + bairro + "', " + 
						 "nom_cidade='" + cidade + "', " +
						 "nro_cep='" + cep + "', " + 
						 "des_logradouro_entrega='" + logr_entrega + "', " + 
						 "nro_endereco_entrega='" + nro_entrega + "', " + 
						 "des_complemento_entrega='" + compl_entrega + "', " + 
						 "nom_bairro_entrega='" + bairro_entrega + "', " + 
						 "nom_cidade_entrega='" + cidade_entrega + "', " +
						 "nro_cep_entrega='" + cep_entrega + "', " + 
						 "des_logradouro_cobranca='" + logr_cobranca + "', " + 
						 "nro_endereco_cobranca='" + nro_cobranca + "', " + 
						 "des_complemento_cobranca='" + compl_cobranca + "', " + 
						 "nom_bairro_cobranca='" + bairro_cobranca + "', " + 
						 "nom_cidade_cobranca='" + cidade_cobranca + "', " +
						 "nro_cep_cobranca='" + cep_cobranca + "', " + 
						 "nro_fone1='" + fone1 + "', " + 
						 "nro_fone2='" + fone2 + "', " + 				
						 "nro_celular='" + celular + "', " + 
						 "nro_fax='" + fax + "', " + 				
						 "des_email='" + email + "', " +
						 "nro_pedido=" + nro_pedido + ", ";			
			if (estado.Trim().CompareTo("") != 0)
			{
				sql = sql + "cod_estado='" + estado + "', ";
			}
			if (estado_entrega.Trim().CompareTo("") != 0)
			{
				sql = sql + "cod_estado_entrega='" + estado_entrega + "', ";
			}
			if (estado_cobranca.Trim().CompareTo("") != 0)
			{
				sql = sql + "cod_estado_cobranca='" + estado_cobranca + "', ";
			}
			if (idt_nascimento)
				sql += "dat_nascimento='" + dat_nascimento.ToString("M/d/yyyy") + "',";
			else
				sql += "dat_nascimento=null,";
			sql = sql +  "idt_ativo='" + ativo + "' " + 								
				    	 "where COD_PARCEIRO='" + codigo + "'";
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
			string sql = "delete from PARCEIROS " +
						 "where COD_PARCEIRO='" + codigo + "'";
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
		
		public bool Existe(string codigo)
		{
			bool existe;
			string sql = 
				"select first 1 COD_PARCEIRO " +
				"from PARCEIROS " +
				"where COD_PARCEIRO='" + codigo + "'";
			FbCommand cmd = new FbCommand(sql, Globais.bd);
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
			existe = reader.Read();
			reader.Close();
			return existe;
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
			Celula cell;
			Chunk chunk;
			chunk = new Chunk(titulo, FontFactory.GetFont(BaseFont.HELVETICA_BOLD, 16));
			cell = new Celula(new Phrase(chunk));
			cell.Padding = 1;
			//cell.Colspan = 11;
			table.AddCell(cell);
			return table;
		}
		
		private PdfPTable Parte13()
		{
			Tabela table = new Tabela(1);
			Celula cell;
			cell = new Celula(Frase("DATA: ", DateTime.Now.ToString("dd/MM/yyyyy"), 10));			
			table.AddCell(cell);
			cell = new Celula(Frase("FILIAL: ", Globais.sFilial, 10));			
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
		
		private void Detalhes(PDF pdf, FbDataReader reader, int c,
					bool idt_codigo, bool idt_nome, bool idt_papel,
					bool idt_tipo_pessoa, bool idt_cpf_cnpj, bool idt_endereco, bool idt_fone, bool idt_email,
					bool idt_ie, bool idt_im, bool idt_dat_cadastro, bool idt_dat_nascimento, bool idt_contatos,
					bool idt_nascimentoI, DateTime nascimentoI, bool idt_nascimentoF, DateTime nascimentoF)
		{
			pdf.CriaTabela(c, 0);			
			pdf.AdicionaCelula("Código", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, 1);
			pdf.AdicionaCelula("Nome", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, 2);
			if (idt_papel) pdf.AdicionaCelula("Papel", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, 1);
			if (idt_tipo_pessoa) pdf.AdicionaCelula("Tipo", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, 1);
			if (idt_cpf_cnpj) pdf.AdicionaCelula("Cpf/Cnpj", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, 1);
			if (idt_endereco) pdf.AdicionaCelula("Endereço", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, 4);
			if (idt_fone) pdf.AdicionaCelula("Fone", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, 2);
			if (idt_email) pdf.AdicionaCelula("email", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, 2);
			if (idt_ie) pdf.AdicionaCelula("Insc.Est.", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, 1);
			if (idt_im) pdf.AdicionaCelula("Insc.Mun.", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, 1);
			if (idt_dat_cadastro) pdf.AdicionaCelula("Cadastro", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, 1);
			if (idt_dat_nascimento) pdf.AdicionaCelula("Nascimento", BaseFont.HELVETICA_BOLD, 6, Color.LIGHT_GRAY, 1);
			
			int i=0;
			while (reader.Read())
			{					
				i++;
				//if (i == 100) break;
				string codigo = !reader.IsDBNull(0) ? reader.GetString(0) : "";
				string nome = !reader.IsDBNull(1) ? reader.GetString(1) : "";
				string papel="";
				string cliente = !reader.IsDBNull(2) ? reader.GetString(2) : "N";
				string fornecedor = !reader.IsDBNull(3) ? reader.GetString(3) : "N";
				string consultor = !reader.IsDBNull(4) ? reader.GetString(4) : "N";
				if (cliente.Equals("S")) papel = "cliente";
				if (fornecedor.Equals("S")) papel = "fornecedor";
				if (consultor.Equals("S")) papel = "consultor";
				string tipo = !reader.IsDBNull(5) ? reader.GetString(5) : "F";
				string cpf_cnpj="";
				if (tipo.Equals("F"))
					cpf_cnpj = !reader.IsDBNull(6) ? CPF.PoeEdicao(reader.GetString(6)) : "";
				else
					cpf_cnpj = !reader.IsDBNull(6) ? CPF.PoeEdicao(reader.GetString(6)) : "";
				string endereco="";
				for (i=7; i<=13; i++)
				{
					endereco = endereco += !reader.IsDBNull(i) ? reader.GetString(i).Trim() : "";
					if (i != 13) endereco += "-";
				}
				string fone="";
				for (i=14; i<=15; i++)
				{
					fone = fone += !reader.IsDBNull(i) ? FONE.PoeEdicao(reader.GetString(i)) : "";
					if (i != 15) fone += "-";
				}				
				string email = !reader.IsDBNull(16) ? reader.GetString(16) : "";
				string ie = !reader.IsDBNull(17) ? reader.GetString(17) : "";
				string im = !reader.IsDBNull(18) ? reader.GetString(18) : "";
				string cadastro = !reader.IsDBNull(19) ? reader.GetDateTime(19).ToString("dd/MM/yyyy") : "";
				string nascimento = !reader.IsDBNull(20) ? reader.GetDateTime(20).ToString("dd/MM/yyyy") : "";
														
				pdf.AdicionaCelula(codigo, BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 1);
				pdf.AdicionaCelula(nome, BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 2);
				if (idt_papel) pdf.AdicionaCelula(papel, BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 1);
				if (idt_tipo_pessoa) pdf.AdicionaCelula(tipo, BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 1);
				if (idt_cpf_cnpj) pdf.AdicionaCelula(cpf_cnpj, BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 1);
				if (idt_endereco) pdf.AdicionaCelula(endereco, BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 4);
				if (idt_fone) pdf.AdicionaCelula(fone, BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 2);
				if (idt_email) pdf.AdicionaCelula(email, BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 2);
				if (idt_ie) pdf.AdicionaCelula(ie, BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 1);
				if (idt_im) pdf.AdicionaCelula(im, BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 1);
				if (idt_dat_cadastro) pdf.AdicionaCelula(cadastro, BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 1);				
				if (idt_dat_nascimento) pdf.AdicionaCelula(nascimento, BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 1);				
				
				if (idt_contatos) {
					string sql = "select NOM_CONTATO,DES_EMAIl,DAT_NASCIMENTO " +
								 "from CONTATOS where COD_PARCEIRO = '" + codigo + "'";
					if (idt_nascimentoI) {
						string inicio = (nascimentoI.Month * 100 + nascimentoI.Day).ToString();
						sql += " and (extract(month from DAT_NASCIMENTO) * 100 + extract(day from DAT_NASCIMENTO) >= " + inicio + ")";
					}
					if (idt_nascimentoF) {
						string fim = (nascimentoF.Month * 100 + nascimentoF.Day).ToString();
						sql += " and (extract(month from DAT_NASCIMENTO) * 100 + extract(day from DAT_NASCIMENTO) <= " + fim + ")";
					}
					FbCommand cmd =  new FbCommand(sql, Globais.bd);				
					FbDataReader reader2 = cmd.ExecuteReader(CommandBehavior.Default);								
					while (reader2.Read()) {
					    string nome_contato = !reader2.IsDBNull(0) ? reader2.GetString(0) : "";
					    string email_contato = !reader2.IsDBNull(1) ? reader2.GetString(1) : "";
					    string nascimento_contato = !reader2.IsDBNull(2) ? reader2.GetDateTime(2).ToString("dd/MM/yyyy") : "-";
						int C = 2;
						if (idt_email) C += 2;
						if (idt_dat_nascimento) C++;
						pdf.AdicionaCelula("", BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, c-C);
						pdf.AdicionaCelula(nome_contato, BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 2);
						if (idt_email)
							pdf.AdicionaCelula(email_contato, BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 2);
						if (idt_dat_nascimento)
							pdf.AdicionaCelula(nascimento_contato, BaseFont.HELVETICA, 6, Element.ALIGN_LEFT, 1);
					}
					reader2.Close();
				}
			}
			pdf.AdicionaTabela();										
		}
				
		public bool Gera(string arquivo, string titulo, bool fisica, bool juridica, 
		                 bool idt_cadastroI, DateTime cadastroI, bool idt_cadastroF, DateTime cadastroF, 
		                 bool idt_nascimentoI, DateTime nascimentoI, bool idt_nascimentoF, DateTime nascimentoF, 		                 
		                 bool idt_orcamentoI, DateTime orcamentoI, bool idt_orcamentoF, DateTime orcamentoF, 
		                 bool idt_pedidoI, DateTime pedidoI, bool idt_pedidoF, DateTime pedidoF,
						 bool fornecedor, bool cliente, bool consultor, bool idt_codigo, bool idt_nome, bool idt_papel,
						 bool idt_tipo_pessoa, bool idt_cpf_cnpj, bool idt_endereco, bool idt_fone, bool idt_email,
						 bool idt_ie, bool idt_im, bool idt_dat_cadastro, bool idt_dat_nascimento, bool idt_contatos,
						 string mailing)
		{
			if (!fisica && !juridica) return false;
			
			PDF pdf = null;
			if (mailing == null) {
				pdf = new PDF(arquivo);
				pdf.Abre();
				Parte1(pdf, titulo);
			}
			
			int c=3;
			if (idt_papel) c++;
			if (idt_tipo_pessoa) c++;
			if (idt_cpf_cnpj) c++;
			if (idt_endereco) c+=4;
			if (idt_fone) c+=2;
			if (idt_email) c+=2;
			if (idt_ie) c++;
			if (idt_im) c++;
			if (idt_dat_cadastro) c++;
			if (idt_dat_nascimento) c++;
			
			string sql = "select p.COD_PARCEIRO, p.NOM_PARCEIRO," +
						"p.IDT_CLIENTE, p.IDT_FORNECEDOR, p.IDT_CONSULTOR, p.IDT_FISJUR, p.NRO_CPF_CNPJ," +
						"p.DES_LOGRADOURO, p.NRO_ENDERECO, p.DES_COMPLEMENTO, p.NOM_BAIRRO, p.NOM_CIDADE, p.COD_ESTADO, p.NRO_CEP, " +
						"p.NRO_FONE1, p.NRO_CELULAR, p.DES_EMAIL, p.NRO_INSCRICAO_ESTADUAL, p.NRO_INSCRICAO_MUNICIPAL, p.DAT_CADASTRO,p.DAT_NASCIMENTO " +
						"from parceiros p ";
			string where = "";
			if (!idt_pedidoI && !idt_pedidoF)			
			{
				if (!fisica)
				{
					where = "where p.idt_fisjur <> 'F' ";
				}
				if (!juridica)
				{
					where = "where p.idt_fisjur <> 'J' ";
				}
			}
			
			if (idt_cadastroI || idt_cadastroF)
			{
				if (idt_cadastroI)
				{
					if (where.Length > 0)
						where = where + " and ";
					else
						where = "where ";					
					where = where + "p.DAT_CADASTRO >= '" + cadastroI.ToString("M/d/yyyy") + "' ";
				}
				if (idt_cadastroF)
				{
					if (where.Length > 0)
						where = where + " and ";
					else
						where = "where ";										
					where = where + "p.DAT_CADASTRO <= '" + cadastroF.ToString("M/d/yyyy") + "' ";
				}				
			}
			

			if (idt_nascimentoI || idt_nascimentoF)
			{
				if (idt_nascimentoI)
				{
					if (where.Length > 0)
						where = where + " and ";
					else
						where = "where ";										
					//where = where + "p.DAT_NASCIMENTO >= '" + nascimentoI.ToString("M/d/yyyy") + "' ";					
					string inicio = (nascimentoI.Month * 100 + nascimentoI.Day).ToString();
					where = where + "(";
					if (idt_contatos) where += "(";
					where +=
						"(p.IDT_FISJUR = 'F') and " + 
						"(extract(month from p.DAT_NASCIMENTO) * 100 + extract(day from p.DAT_NASCIMENTO) >= " + inicio + ")";
					if (idt_contatos) {
						where +=
							") or (" +
								"(p.IDT_FISJUR = 'J') and " + 
								"exists(select 1 from CONTATOS c where c.COD_PARCEIRO=p.COD_PARCEIRO and " + 
									"(extract(month from c.DAT_NASCIMENTO) * 100 + extract(day from c.DAT_NASCIMENTO) >= " + inicio + ")" +
								")" +
							")";
					}
					where += ") ";
				}
				if (idt_nascimentoF)
				{
					if (where.Length > 0)
						where = where + " and ";
					else
						where = "where ";										
					//where = where + "p.DAT_NASCIMENTO <= '" + nascimentoF.ToString("M/d/yyyy") + "' ";
					string fim = (nascimentoF.Month * 100 + nascimentoF.Day).ToString();
					where = where + "(";
					if (idt_contatos) where += "(";
					where +=
						"(p.IDT_FISJUR = 'F') and " + 
						"(extract(month from p.DAT_NASCIMENTO) * 100 + extract(day from p.DAT_NASCIMENTO) <= " + fim + ")";
					if (idt_contatos) {
						where +=
							") or (" +
								"(p.IDT_FISJUR = 'J') and " + 
								"exists(select 1 from CONTATOS c where c.COD_PARCEIRO=p.COD_PARCEIRO and " + 
									"(extract(month from c.DAT_NASCIMENTO) * 100 + extract(day from c.DAT_NASCIMENTO) <= " + fim + ")" +
								")" +
							")";
					}
					where += ") ";
				}				
			}			
			

			if (idt_orcamentoI || idt_orcamentoF)
			{
				if (where.Length > 0)
				{
					where = where + " and ";
				}
				else
				{
					where = "where ";
				}
				where = where + "exists(select 1 from orcamentos o where o.COD_CLIENTE=p.COD_PARCEIRO ";
				if (idt_orcamentoI)
				{
					where = where + "and o.DAT_ORCAMENTO >= '" + orcamentoI.ToString("M/d/yyyy") + "' ";
				}
				if (idt_orcamentoF)
				{
					where = where + "and o.DAT_ORCAMENTO <= '" + orcamentoF.ToString("M/d/yyyy") + "' ";
				}				
				where = where + ") ";
			}

			if (idt_pedidoI || idt_pedidoF)
			{
				where = "where exists(select 1 from orcamentos o " +
					"inner join pedidos ped on ped.COD_FORNECEDOR=o.COD_FORNECEDOR and " +
					"ped.DAT_ORCAMENTO=o.DAT_ORCAMENTO and " +
					"ped.COD_ORCAMENTO=o.COD_ORCAMENTO and ped.COD_PEDIDO=1 " +
					"where o.COD_CLIENTE=p.COD_PARCEIRO ";
				if (idt_pedidoI)
				{
					where = where + "and ped.DAT_PEDIDO >= '" + pedidoI.ToString("M/d/yyyy") + "' ";
				}
				if (idt_pedidoF)
				{
					where = where + "and ped.DAT_PEDIDO <= '" + pedidoF.ToString("M/d/yyyy") + "' ";
				}				
				where = where + ") ";
					
				if (!fisica)
				{
					where = where + "and p.idt_fisjur <> 'F' ";
				}
				if (!juridica)
				{
					where = where + "and p.idt_fisjur <> 'J' ";
				}
				
			}			
			
			if (!(fornecedor && cliente && consultor))
			{
				if (cliente) 
				{
					if (where.Length > 0)
					{
						where = where + " and ";
					}
					else
					{
						where = "where ";
					}				
					where = where + "p.IDT_CLIENTE = 'S'";
				}
				if (fornecedor) 
				{
					if (where.Length > 0)
					{
						where = where + " and ";
					}
					else
					{
						where = "where ";
					}									
					where = where + "p.IDT_FORNECEDOR = 'S'";
				}
				if (consultor) 
				{
					if (where.Length > 0)
					{
						where = where + " and ";
					}
					else
					{
						where = "where ";
					}									
					where = where + "p.IDT_CONSULTOR = 'S'";
				}
			}
			sql = sql + where + " order by p.COD_PARCEIRO";
			//StreamWriter sw = new StreamWriter(new FileStream("c:\\softplace\\teste.sql", FileMode.Create));
			//sw.WriteLine(sql);
			//sw.Close();
			
			FbCommand cmd =  new FbCommand(sql, Globais.bd);				
			FbDataReader reader = cmd.ExecuteReader(CommandBehavior.Default);			
			
			if (mailing == null) {
				Detalhes(pdf, reader, c,
						idt_codigo, idt_nome, idt_papel,
						idt_tipo_pessoa, idt_cpf_cnpj, idt_endereco, idt_fone, idt_email,
						idt_ie, idt_im, idt_dat_cadastro, idt_dat_nascimento, idt_contatos,
						idt_nascimentoI, nascimentoI, idt_nascimentoF, nascimentoF);
				pdf.Fecha();
				reader.Close();
			}
			else {
				int n=0;
				StreamWriter sw = new StreamWriter(new FileStream(mailing, FileMode.Create));
				sw.WriteLine("Nome;End. de email");
				while (reader.Read())
				{					
					string codigo = !reader.IsDBNull(0) ? reader.GetString(0).Trim() : "";
					string nome = !reader.IsDBNull(1) ? reader.GetString(1).Trim() : "";
					string email = !reader.IsDBNull(16) ? reader.GetString(16).Trim() : "";
					if (email.Length > 0) {
						sw.WriteLine(nome + ";" + email);
						n++;
					}
					if (idt_contatos) {
						string sql2 = "select NOM_CONTATO,DES_EMAIl,DAT_NASCIMENTO " +
									 "from CONTATOS where COD_PARCEIRO = '" + codigo + "'";
						if (idt_nascimentoI) {
							string inicio = (nascimentoI.Month * 100 + nascimentoI.Day).ToString();
							sql += " and (extract(month from DAT_NASCIMENTO) * 100 + extract(day from DAT_NASCIMENTO) >= " + inicio + ")";
						}
						if (idt_nascimentoF) {
							string fim = (nascimentoF.Month * 100 + nascimentoF.Day).ToString();
							sql += " and (extract(month from DAT_NASCIMENTO) * 100 + extract(day from DAT_NASCIMENTO) <= " + fim + ")";
						}
						FbCommand cmd2 =  new FbCommand(sql, Globais.bd);				
						FbDataReader reader2 = cmd.ExecuteReader(CommandBehavior.Default);								
						while (reader2.Read()) {
							string nome_contato = !reader2.IsDBNull(0) ? reader2.GetString(0).Trim() : "";
							string email_contato = !reader2.IsDBNull(1) ? reader2.GetString(1).Trim() : "";
							if (email_contato.Length > 0) {
								sw.WriteLine(nome_contato + ";" + email_contato);							
								n++;
							}
						}
						reader2.Close();
					}					
				}
				sw.Close();				
				MessageBox.Show("Mailing gerado com sucesso\r\n" + n.ToString() + " registros gerados");
			}
			return true;
		}
	}
}
