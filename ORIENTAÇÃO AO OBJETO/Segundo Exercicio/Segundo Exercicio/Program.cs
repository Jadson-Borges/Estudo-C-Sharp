using System;

namespace Segundo_Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produtos p = new Produtos();

            Console.WriteLine("Entre os dados do produto");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());

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
