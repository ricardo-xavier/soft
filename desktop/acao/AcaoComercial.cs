using System;

namespace acao
{
	public class AcaoComercial
	{
		private int seqAcao;
		private string codCliente;
		private string desObra;
		private DateTime datPrevisao;
		private string desProduto;
		private string codVendedor;
		private string codConsultor;
		private string codOrigem;
		private string idtSituacao;
		private string txtObservacao;
		private string txtConcorrentes;
				
		public int SeqAcao
		{
			get { return seqAcao; }
			set { seqAcao = value; }
		}
		
		public string CodCliente
		{
			get { return codCliente; }
			set { codCliente = value; }
		}
		
		public string DesObra
		{
			get { return desObra; }
			set { desObra = value; }
		}
		
		public DateTime DatPrevisao
		{
			get { return datPrevisao; }
			set { datPrevisao = value; }
		}
		
		public string DesProduto
		{
			get { return desProduto; }
			set { desProduto = value; }
		}
		
		public string CodVendedor
		{
			get { return codVendedor; }
			set { codVendedor = value; }
		}
		
		public string CodConsultor
		{
			get { return codConsultor; }
			set { codConsultor = value; }
		}
		
		public string CodOrigem
		{
			get { return codOrigem; }
			set { codOrigem = value; }
		}
		
		public string IdtSituacao
		{
			get { return idtSituacao; }
			set { idtSituacao = value; }
		}
		
		public string TxtObservacao
		{
			get { return txtObservacao; }
			set { txtObservacao = value; }
		}		
		
		public string TxtConcorrentes
		{
			get { return txtConcorrentes; }
			set { txtConcorrentes = value; }
		}		
		
		public AcaoComercial()
		{
		}
	}
}
