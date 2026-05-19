using System;
using System.Globalization;

namespace Aula_03_Emcapsulamento
{
    internal class Produtos
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produtos() { } //construtor vazio

        public Produtos(string nome, double preco, int quantidade) //contrutor preenchendo todos os campos
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public Produtos(string nome, double preco)// construtor reduzindo os campos informados
        {
            _nome = nome;
            _preco = preco;

        }
        // metodo get para retornar as informações
        public string GetNome() 
        {
            return _nome;
        }

        public double GetPreco() 
        {
            return _preco;
        }

        public int GetQuantidade() 
        {
            return _quantidade;
        }

        // metodo set para inserir informalções!
        public void SetNome (string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }


        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdProduto(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RMProduto(int quantidade)
        {
            _quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome + " - Valor de Estoque: R$ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)
                + " - Quantidade do estoque atual: " + _quantidade + " Unidades, "
                + " Valor unitário: R$ " + _preco.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
