using System;

namespace Matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de linhas: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de colunas: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[m, n];

            // Leitura da matriz
            for (int i = 0; i < m; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(valores[j]);
                }
            }

            // Leitura do número X
            Console.Write("Digite o valor que deseja procurar: ");
            int x = int.Parse(Console.ReadLine());

            // Procura o X na matriz
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] == x)
                    {
                        Console.WriteLine($"Posição {i},{j}:");

                        // Esquerda
                        if (j > 0)
                        {
                            Console.WriteLine("Esquerda: " + matriz[i, j - 1]);
                        }

                        // Acima
                        if (i > 0)
                        {
                            Console.WriteLine("Acima: " + matriz[i - 1, j]);
                        }

                        // Direita
                        if (j < n - 1)
                        {
                            Console.WriteLine("Direita: " + matriz[i, j + 1]);
                        }

                        // Abaixo
                        if (i < m - 1)
                        {
                            Console.WriteLine("Abaixo: " + matriz[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}