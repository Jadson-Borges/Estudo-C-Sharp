using System;
using System.Globalization;
namespace SALARIO
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioB;
        public double Imposto;
        public int Porcentagem;

        public double SalarioL()
        {
            return SalarioB - Imposto;
        }

       
        override public string ToString()
        {
            return "O funcionario " + Nome + " tem um salario de $ " + SalarioL().ToString("F2", CultureInfo.InvariantCulture);
        }

        public double Aumento()
        {
            return SalarioL() + (SalarioL() * Porcentagem / 100);
        }

    }
}

