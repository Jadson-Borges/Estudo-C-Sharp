using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_Comparativos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Operadores comparativos são usados para comparar dois valores e retornar um resultado booleano (verdadeiro ou falso).
            int a = 10;
            bool n1 = a > 10;
            bool n2 = a < 10;
            bool n3 = a >= 10;
            bool n4 = a <= 10;
            bool n5 = a == 10;
            bool n6 = a != 10;

            Console.WriteLine("a > 10: " + n1);
            Console.WriteLine("a < 10: " + n2);
            Console.WriteLine("a >= 10: " + n3);
            Console.WriteLine("a <= 10: " + n4);
            Console.WriteLine("a == 10: " + n5);
            Console.WriteLine("a != 10: " + n6);
            
        }
    }
}
