using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01_Matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matriz  = new int[n, n];

            for (int i = 0; i < n; i++) 
            {
                string[] vetor = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int .Parse(vetor[j]);
                }               
            }

            Console.WriteLine("Diagonal:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(matriz[i, i] + " ");
            }

            int contador = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        contador++;
                    }

                }
            }
            Console.WriteLine(contador);

        }
    }
}
