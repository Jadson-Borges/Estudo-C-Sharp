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
            //Escreva um programa que leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida. Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando essas informações na tela.
            //int n = int.Parse(Console.ReadLine());

            //int cont_in = 0;
            //int cont_out = 0;

            //for (int i = 0; i < n; i++)
            //{
            //    int x = int.Parse(Console.ReadLine());
            //    if (x >= 10 && x <= 20)
            //    {
            //        cont_in = cont_in + 1;
            //    }
            //    else
            //    {
            //        cont_out = cont_out + 1;
            //    }
            //}

            //Console.WriteLine(cont_in + " in");
            //Console.WriteLine(cont_out + " out");

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
            //Escreva um programa que leia um valor inteiro N. Este valor será a quantidade de pares de valores inteiros X e Y que serão lidos em seguida. Para cada par lido, mostre o resultado da divisão de X por Y, com uma casa decimal. Se a divisão for impossível, mostre a mensagem "divisao impossivel".

            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{

            //    string[] line = Console.ReadLine().Split(' ');
            //    int x = int.Parse(line[0]);
            //    int y = int.Parse(line[1]);

            //    if (y == 0)
            //    {
            //        Console.WriteLine("divisao impossivel");
            //    }
            //    else
            //    {
            //        double div = (double)x / y;
            //        Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture));
            //    }
            //}

            //-------------------------------------------------------------------------------------------------------------
            //Atividade 5
            //Escreva um programa que leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida. Para cada valor lido, mostre o fatorial de X.
            //int n = int.Parse(Console.ReadLine());

            //int fat = 1;
            //for (int i = 1; i <= n; i++)
            //{
            //    fat = fat * i;
            //}

            //Console.WriteLine(fat);

            //-------------------------------------------------------------------------------------------------------------
            //Atividade 6
            //Ler um número inteiro N e calcular todos os seus divisores.
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //    if (n % i == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //-------------------------------------------------------------------------------------------------------------
            //Atividade 7

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

                int primeiro = i;
                int segundo = i * i;
                int terceiro = i * i * i;
                Console.WriteLine($"{primeiro} {segundo} {terceiro}");
            }

        }
    }
}
