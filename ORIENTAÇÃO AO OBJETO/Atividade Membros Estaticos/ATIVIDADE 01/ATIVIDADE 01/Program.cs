using System;
using System.Globalization;

namespace ATIVIDADE_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a cotação do dólar? " + Dolar.ValorD);

            Console.WriteLine("Quantos dólares você vai comprar? ");
            double valorc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("o Valor a ser pago em reais é = " + Dolar.ConversorDeMoeda(valorc).ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
