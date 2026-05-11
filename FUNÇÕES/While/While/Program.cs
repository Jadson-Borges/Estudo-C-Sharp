using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Faça um programa que leia um número e mostre a raiz quadrada desse número. Se o número for negativo, mostre uma mensagem dizendo que não é possível calcular a raiz quadrada de um número negativo.
            Console.Write("Escreva um número:");

            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x >= 0) //enquanto o número for positivo ou zero, o programa irá calcular a raiz quadrada
            {
                double raiz = Math.Sqrt(x); //calcula a raiz quadrada do número
                Console.WriteLine("sua raiz é: " + raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("Digite outro numero");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Número negativo!");

        }

    }
}
