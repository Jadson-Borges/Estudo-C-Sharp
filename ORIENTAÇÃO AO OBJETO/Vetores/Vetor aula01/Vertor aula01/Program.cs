using System;
using System.Globalization;
using System.Net.Http.Headers;

namespace Vertor_aula01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double [n];

            for (int i=0; i<n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double soma = 0;
            for (int i=0; i<n; i++)
            {
                soma += vect[i];
            }

            double media = soma / n;

            Console.WriteLine("Resultado: " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
