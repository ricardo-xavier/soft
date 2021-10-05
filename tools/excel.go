package main

import (
	"bufio"
	"fmt"
	"math"
	"os"
	"strconv"
	"strings"
)

type Produto struct {
	Codigo string
	SubCodigo string
	Preco string
}

func (produto Produto) ToString() string {
	return fmt.Sprintf("[%s] [%s] [%s]", produto.Codigo, produto.SubCodigo, produto.Preco)
}

var produtos []Produto
var produtosBd []Produto
var m map[string]Produto

func main() {
	m = make(map[string]Produto)
	carregaBd()
	for a:=1; a<len(os.Args); a++ {
		carregaCsv(os.Args[a])
	}
	comparaPrecos()
}

func comparaPrecos() {
	encontrados := 0
	alteradosComPreco := 0
	alteradosSemPreco := 0

	for _, produtoBd := range(produtosBd) {
		chave := produtoBd.Codigo + ":" + produtoBd.SubCodigo
		//fmt.Printf("= [%s]\n", chave)
		produto, encontrado := m[chave]
		if encontrado {
			encontrados++
			if produto.Preco != produtoBd.Preco {
				if produtoBd.Preco == "0.00" {
					alteradosSemPreco++
				} else {
					alteradosComPreco++
					precoBd,_ := strconv.ParseFloat(produtoBd.Preco, 64)
					precoPlanilha,_ := strconv.ParseFloat(produto.Preco, 64)
					if math.Abs(precoBd - precoPlanilha) > 0.02 {
						fmt.Println(produto.ToString() + " " + produtoBd.Preco)
					}
				}
				fmt.Printf("update PRECOS set VLR_PRECO=%s where COD_PARCEIRO='TECNOFLEX' and COD_TABELA='PADRAOJUL2021' and COD_PRODUTO='%s' and SUB_CODIGO='%s';\n", produto.Preco, produto.Codigo, produto.SubCodigo)
			}
		}
	}

	fmt.Printf("Produtos no banco...........: %d\n", len(produtosBd))
	fmt.Printf("Produtos na planilha........: %d\n", len(produtos))
	fmt.Printf("Produtos encontrados........: %d\n", encontrados);
	fmt.Printf("Produtos alterados com preco: %d\n", alteradosComPreco);
	fmt.Printf("Produtos alterados sem preco: %d\n", alteradosSemPreco);
}

func carregaBd() {
	file, err := os.Open("precos.txt")
	if err != nil {
		panic(err)
	}
	scanner := bufio.NewScanner(file)
	for scanner.Scan() {
		text := scanner.Text()
		words := strings.Split(text, ";")
		var produto Produto
		produto.Codigo = strings.TrimSpace(words[0])
		produto.SubCodigo = strings.TrimSpace(words[1])
		produto.Preco = strings.TrimSpace(words[2])
		produtosBd = append(produtosBd, produto)
	}
	file.Close();
}

func carregaCsv(csv string) {

	fmt.Println(csv)
	file, err := os.Open(csv)
	if err != nil {
		panic(err)
	}

	scanner := bufio.NewScanner(file)
	for scanner.Scan() {
		text := scanner.Text()
		words := strings.Split(text, ";")
		for _, word := range(words) {
			if word == "Código" {
				subCodigos := getSubCodigos(words)
				carregaTabela(scanner, subCodigos)
				for _, produto := range(produtos) {
					//fmt.Println(produto.toString())
					chave := produto.Codigo + ":" + produto.SubCodigo
					//fmt.Printf("+ [%s]\n", chave)
					m[chave] = produto
				}
			}
		}
	}

	fmt.Println(len(produtos))
	file.Close();
}

func getSubCodigos(words []string) []string {
	var subCodigos []string
	for _, sub := range(words) {
		sub = strings.TrimSpace(sub)
		if sub == "Código" || sub == "Descrição" || sub == "Dimensão" || sub == "" {
			continue
		}
		subCodigos = append(subCodigos, sub)
	}
	if len(subCodigos) == 0 {
		subCodigos = append(subCodigos, "-")
	}
	return subCodigos
}

func carregaTabela(scanner *bufio.Scanner, subCodigos []string) {
	for scanner.Scan() {
		text := scanner.Text()
		words := strings.Split(text, ";")
		codigo := ""
		var precos []string
		for _, word := range(words) {
			word = strings.TrimSpace(word)
			if word == "" {
				continue
			}
			if codigo == "" {
				codigo = word
			}
			if strings.Contains(word, "R$") {
				precos = append(precos, word)
			}	
		}
		if codigo == "" || len(precos) == 0 {
			break
		}
		if len(subCodigos) != len(precos) {
			break
		}
		p := 0
		for _, subCodigo := range(subCodigos) {
			for _, subSubCodigo := range(strings.Split(subCodigo, "|")) {
				var produto Produto
				produto.Codigo = codigo
				produto.SubCodigo = strings.TrimSpace(subSubCodigo)
				produto.Preco = strings.ReplaceAll(precos[p], "R$", "")
				produto.Preco = strings.ReplaceAll(produto.Preco, ".", "")
				produto.Preco = strings.ReplaceAll(produto.Preco, ",", ".")
				produto.Preco = strings.TrimSpace(produto.Preco)
				produtos = append(produtos, produto)
			}
			p++
		}
	}
}
