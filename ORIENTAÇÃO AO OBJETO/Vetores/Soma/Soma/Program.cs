using System;
namespace Soma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = Calculadora.Soma(2, 5);
            int n2 = Calculadora.Soma(2, 4, 3);

            Console.WriteLine(n1);
            Console.WriteLine(n2);
        }
    }
}
