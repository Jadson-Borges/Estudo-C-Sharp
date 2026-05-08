using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_Logicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool n1 = 2 > 3 || 4 > 3; // 2 é maior que 3, ou seja, false, e 4 é maior que 3, ou seja, true. Logo, n1 é true, pois a operação OR exige que pelo menos uma das condições seja verdadeira.
            bool n2 = 2 > 3 && 4 > 3; // 2 é maior que 3, ou seja, false, e 4 é maior que 3, ou seja, true. Logo, n1 é true. Já n2 é false, pois a operação AND exige que ambas as condições sejam verdadeiras.
            bool n3 = !(2 > 3) && 4 != 3; // Negação de 2 > 3, ou seja, !false = true, e 4 é diferente de 3, ou seja, true. Logo, n3 é true.
            bool n4 = n1 || n2 && n3; // n1 é true, n2 é false, e n3 é true. A operação AND tem precedência sobre a operação OR, então primeiro é avaliada n2 && n3, que resulta em false. Em seguida, é avaliada n1 || false, que resulta em true. Portanto, n4 é true.

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);

        }
    }
}
