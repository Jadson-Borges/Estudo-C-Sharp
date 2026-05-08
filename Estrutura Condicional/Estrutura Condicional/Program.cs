using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_Condicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Estrutura condicional if simples
            //int x = 10;            
            //Console.WriteLine("Bom dia");
            //if (x > 10) {
            //Console.WriteLine("Boa tarde");
            //}
            //Console.WriteLine("Boa noite"); 
            //------------------------------------------------------------------------


            //Estrutura condicional if composta
            //int n1 = int.Parse(Console.ReadLine());


            //if (n1 % 2 == 0)
            //{
            //    Console.WriteLine("Par");
            //}
            //else
            //{
            //    Console.WriteLine("Ímpar");
            //}
            //------------------------------------------------------------------------

            //condição composta aninhada ou encadeada
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            if (n1 > n2)
            {
                Console.WriteLine("Primeiro é maior");
            }
            else if (n2 > n1)
            {
                Console.WriteLine("Segundo é maior");
            }
            else
            {
                Console.WriteLine("São iguais");
            }
        }
    }
}