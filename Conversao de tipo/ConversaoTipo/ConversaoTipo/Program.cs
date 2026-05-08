using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoTipo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a = 10.5f;
            double b = a; // Conversão implícita de float para double

            Console.WriteLine(b);

            double c;
            int d;

            c = 1.5;
            d = (int)c; // Conversão explícita de double para int (perda de precisão)
            //d = c;// Erro de compilação: conversão explícita necessária

            Console.WriteLine(d);

            int e = 5;
            int f = 2;


            //double resultado = e / f; // Divisão entre inteiros resulta em um inteiro (2), depois convertido para double (2.0)
            double resultado = (double)e / f; // Conversão explícita de 'e' para double antes da divisão, resultando em 2.5
            Console.WriteLine(resultado);

        }
    }
}
