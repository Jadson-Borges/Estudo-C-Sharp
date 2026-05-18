using System;
using System.Globalization;

namespace Estrutura_Condicional_2
{
    internal class Calculadora
    {
        public static double Pi = 3.14;

        public static double Circuferencia (double rc)
        {
            return 2 * Pi * rc;
        }

        public static double Volume (double rv)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(rv, 3);
        }
    }
}
