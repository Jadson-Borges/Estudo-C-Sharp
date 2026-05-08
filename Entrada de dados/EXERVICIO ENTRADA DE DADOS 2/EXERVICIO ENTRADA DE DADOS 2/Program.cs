using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERVICIO_ENTRADA_DE_DADOS_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string nomeCompleto = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa:");
            int nquartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu ultimo nome idade e altura");
            string[] frase = Console.ReadLine().Split(' ');
            string cor = frase[0];
            int idade = int.Parse(frase[1], CultureInfo.InvariantCulture);
            double altura = double.Parse(frase[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Sua cor é " + cor + ", sua idade é " + idade + " e sua altura é " + altura.ToString("F2", CultureInfo.InvariantCulture));
           

        }
    }
}
