using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO_ESTRUTURA_FOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Atividade 1
            //escreva um programa que leia um valor inteiro e mostre na tela os números ímpares de 1 até o valor lido.
            //Console.WriteLine("Escreva o valor a ser dividido: ");
            //int valor = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //for (int i = 1; i <= valor; i++)
            //{
            //     if (i % 2 != 0)
            //        Console.WriteLine(i);
            //}

            //------------------------------------------------------------------------------------------------------------
            //Atividade 2

            Console.WriteLine("Digite um valor: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string resultado = "";

            for (int i = 1; i <= x; i++)
            {

                if (i >= 10 && i <= 20)
                {
                    resultado += i.ToString("F2", CultureInfo.InvariantCulture) + "\n";
                    Console.WriteLine("");
                }
                
            }

            Console.WriteLine("Números fora do intervalo de 10 a 20:");
            Console.WriteLine(resultado);

            //-------------------------------------------------------------------------------------------------------------
            //atividade 3
            //Programa para fazer a media ponderada de 3 valores, onde o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem peso 5. O programa deve ler os 3 valores e mostrar a média ponderada na tela. O programa deve repetir esse processo para um número n de vezes, onde n é um valor inteiro lido no início do programa.
            //int n = 3;

            //string resultado = "";

            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine("Digite os proximos valores:");
            //    string[]  valores = Console.ReadLine().Split(' ');
            //    double valor1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
            //    double valor2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
            //    double valor3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            //    double media = ((valor1 * 2) + (valor2 * 3) + (valor3 * 5)) / 10;

            //    resultado += media.ToString("F1", CultureInfo.InvariantCulture) + "\n";
            //}

            //Console.WriteLine("Suas médias são: ");
            //Console.WriteLine(resultado.ToString(), ("f1"), CultureInfo.InvariantCulture);

            //-------------------------------------------------------------------------------------------------------------
            //Atividade 4



        }
    }
}
