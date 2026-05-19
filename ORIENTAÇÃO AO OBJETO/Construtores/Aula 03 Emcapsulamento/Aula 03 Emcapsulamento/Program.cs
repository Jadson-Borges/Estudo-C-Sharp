using System;
using System.Globalization;

namespace Aula_03_Emcapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produtos p = new Produtos("TV", 500.00, 10);

            p.SetNome("TV 4K");

            Console.WriteLine(p.GetNome());
        }
    }
}
