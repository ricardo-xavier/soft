package main

import (
	"bufio"
	"fmt"
	"os"
	"strings"
)

type Produto struct {
	Codigo string
	SubCodigo string
	Preco string
}

func (produto Produto) toString() string {
	return fmt.Sprintf("[%s] [%s] [%s]", produto.Codigo, produto.SubCodigo, produto.Preco)
}

var produtos []Produto

func main() {
	for a:=1; a<len(os.Args); a++ {
		carregaCsv(os.Args[a])
	}
}

func carregaCsv(csv string) {

	fmt.Println(csv)
	file, err := os.Open(os.Args[1])
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
				getProdutos(scanner, subCodigos)
/*
				for _, produto := range(produtos) {
					fmt.Println(produto.toString())
				}
*/
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
		if sub == "Código" || sub == "Descrição" || sub == "" {
			continue
		}
		subCodigos = append(subCodigos, sub)
	}
	if len(subCodigos) == 0 {
		subCodigos = append(subCodigos, "-")
	}
	return subCodigos
}

func getProdutos(scanner *bufio.Scanner, subCodigos []string) {
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
			panic(text)
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
