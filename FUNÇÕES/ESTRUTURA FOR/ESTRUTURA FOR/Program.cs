using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTRUTURA_FOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Faça um programa que leia um número inteiro N e depois N números inteiros.
            Console.Write("Informe quantos numeros inteiros deseja informar:");
            int n = int.Parse(Console.ReadLine());

            int valor;
            int soma = 0;
            // O programa deve calcular e mostrar a soma dos N números inteiros digitados.
            for (int x = 1; x <= n; x++)
            {
                Console.WriteLine("valor #"+ x +":");
                valor = int.Parse(Console.ReadLine());
                soma += valor; // soma = soma + valor
            }

            

            Console.WriteLine("A soma dos valores digitados é: " +soma);

        }
    }
}
