using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expressao_condicional_ternaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor = double.Parse(Console.ReadLine());
            double desconto = (valor > 20) ? valor * 0.1 : valor * 0.05;
            
            Console.WriteLine(desconto);
        }
    }
}
