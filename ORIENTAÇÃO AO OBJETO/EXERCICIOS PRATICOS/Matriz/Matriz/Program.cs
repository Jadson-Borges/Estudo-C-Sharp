using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero de Linhas: ");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero de Colunas: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[m, n];

            

            for (int i = 0; i < n; i++)
            {               
                string[] valor = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++ )
                {
                    if (valor.Length != m)
                    { 
                    matriz[i, j] = int.Parse(valor[j]);
                    }
                    else
                    {
                        Console.WriteLine("Valor invalido!");
                    }
                }
            }

        }
    }
}
