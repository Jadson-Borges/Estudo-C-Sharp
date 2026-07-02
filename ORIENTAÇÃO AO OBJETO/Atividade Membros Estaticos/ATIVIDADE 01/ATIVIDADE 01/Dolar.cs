using System;
using System.Globalization;

namespace ATIVIDADE_01
{
    internal class Dolar
    {
        public static double ValorD = 3.10;
        
        public static double ConversorDeMoeda (double valorC)
        {
            return ValorD * valorC * (1 + 0.06);
        }
        
    }
}
