using System;
using System.Globalization;

namespace Aula_02_Sobrecarga
{
    internal class Produtos
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produtos() { } //construtor vazio

        public Produtos(string nome, double preco, int quantidade) //contrutor preenchendo todos os campos
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produtos(string nome, double preco)// construtor reduzindo os campos informados
        {
            Nome = nome;
            Preco = preco;
            
        }


        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdProduto(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RMProduto(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome + " - Valor de Estoque: R$ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)
                + " - Quantidade do estoque atual: " + Quantidade + " Unidades, "
                + " Valor unitário: R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}