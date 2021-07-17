package xavier.ricardo.softws.tipos;

public class Produto {
	
	private String fornecedor;
	private String codigo;
	private String subCodigo;
	private String descricao;
	private String tabela;
	private String caracteristica;
	private double preco;
	public String getFornecedor() {
		return fornecedor;
	}
	public void setFornecedor(String fornecedor) {
		this.fornecedor = fornecedor;
	}
	public String getCodigo() {
		return codigo;
	}
	public void setCodigo(String codigo) {
		this.codigo = codigo;
	}
	public String getSubCodigo() {
		return subCodigo;
	}
	public void setSubCodigo(String subCodigo) {
		this.subCodigo = subCodigo;
	}
	public String getDescricao() {
		return descricao;
	}
	public void setDescricao(String descricao) {
		this.descricao = descricao;
	}
	
	public String toHtml() {
		return "<h4>" + fornecedor + "</h4>"
				+  "<h4>" + tabela + "</h4>"
				+  "<h4>" + caracteristica + "</h4>"
				+  "<h4>" + codigo + " - " + subCodigo + "</h4>"
				+  "<h4>" + descricao + "</h4>"
				+  "<h4>" + String.format("R$ %.2f", preco) + "</h4>"
				+  "<img src=\"/foto/" + codigo.trim() + subCodigo.trim() + ".jpg\" alt=\"foto\">";

	}

	public String getTabela() {
		return tabela;
	}

	public void setTabela(String tabela) {
		this.tabela = tabela;
	}

	public String getCaracteristica() {
		return caracteristica;
	}

	public void setCaracteristica(String caracteristica) {
		this.caracteristica = caracteristica;
	}

	public double getPreco() {
		return preco;
	}

	public void setPreco(double preco) {
		this.preco = preco;
	}
}
