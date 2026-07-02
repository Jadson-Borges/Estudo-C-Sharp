using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produtos p = new Produtos("TV", 500.00, 10);

            p.Nome = "TV 4k";
            
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Valor);
            Console.WriteLine(p.Quantidade);
            
        }
    }
}
