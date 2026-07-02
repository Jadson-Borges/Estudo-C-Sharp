using System;
using System.Globalization;

namespace Aula_01_Contrutores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre os dados do produto");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produtos p = new Produtos(nome, preco, quantidade);            

            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            p.AdProduto(int.Parse(Console.ReadLine()));
            Console.WriteLine("Estoque atualizado: " + p);

            Console.WriteLine("Digite o numero de produtos a ser removido do estoque: ");
            p.RMProduto(int.Parse(Console.ReadLine()));
            Console.WriteLine("Estoque atualizado: " + p);

        }
    }
}