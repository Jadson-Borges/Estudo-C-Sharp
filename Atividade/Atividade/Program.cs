using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string produto = "Compurador";
            string produto2 = "Mesa de escritorio";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.00;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine(produto + " cujo preço é $" + preco1.ToString("F2"));
            Console.WriteLine(produto2 + ", cujo preço é $ " + preco2.ToString("F2"));
            Console.WriteLine("Registro:");
            Console.WriteLine(idade + " de idade, codigo" + codigo + " e gênero: " + genero);

            Console.WriteLine("Medida com oito casas decimais: " + medida.ToString("F8"));
            Console.WriteLine("Arredondado (trés casas decimais): " + medida.ToString("f3"));
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("f3", CultureInfo.InvariantCulture));
            
        }
    }
}
