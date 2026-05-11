using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_Condicional_Atividade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--------------------------------------------------------------------------------------------------
            //EXERCICIO 1
            // Faça um programa que peça um número e informe se o número é positivo ou negativo.
            //Console.WriteLine("Digite um numero:");
            //int numero = int.Parse(Console.ReadLine());

            //if (numero >= 0) { 
            //    Console.WriteLine("O numero é positivo");
            //}
            //else { 
            //Console.WriteLine("O numero é negativo");
            //}

            //--------------------------------------------------------------------------------------------------
            //EXERCICIO 2

            //Console.WriteLine("Digite um numero:");

            //int numero = int.Parse(Console.ReadLine());

            //if (numero % 2 == 0)
            //{
            //    Console.WriteLine("O numero é PAR");
            //}

            //else {
            //    Console.WriteLine("O numero é IMPAR");
            //}

            //--------------------------------------------------------------------------------------------------
            //EXERCICIO 3
            //Faça um programa que leia dois números e informe se eles são múltiplos ou não.
            //Console.WriteLine("Digite um numero:");
            //int n1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite um numero:");
            //int n2 = int.Parse(Console.ReadLine());

            //if (n1 % n2 == 0 || n2 % n1 == 0)
            //{
            //    Console.WriteLine("Numeros multiplos");
            //}

            //else
            //{
            //    Console.WriteLine("Numeros não são multiplos");
            //}


            //--------------------------------------------------------------------------------------------------
            //EXERCICIO 4
            //Faça um programa que leia a hora de início e a hora de término de um jogo, em horas inteiras.

            //Console.WriteLine("Informe a hora que iniciou e a hora que terminou");

            //string[] horas = Console.ReadLine().Split(' ');
            //int horaInicial = int.Parse(horas[0]);
            //int horaFinal = int.Parse(horas[1]);

            //int duracao;

            //if (horaInicial < horaFinal)
            //{
            //    duracao = horaFinal + horaInicial;
            //    Console.WriteLine("A duração foi de: " + duracao);
            //}
            //else
            //{
            //    duracao = 24 - horaInicial + horaFinal;
            //    Console.WriteLine("A duração foi de: " + duracao);
            //}


            //--------------------------------------------------------------------------------------------------
            //EXERCICIO 5
            //Um restaurante oferece um menu com 5 opções de refeição. Escreva um programa que leia o código da refeição escolhida e a quantidade, e calcule o valor a ser pago.
            //Console.WriteLine("Digite o codigo do produto:");

            //int codigo = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a quantidade: ");
            //int quant = int.Parse(Console.ReadLine());

            //double valor;

            //if (codigo == 1)
            //{
            //    valor = quant * 4.00;
            //    Console.WriteLine("valor a apagar no cachorro Quente é de: " + valor.ToString("f2"));

            //}
            //else if (codigo == 2)
            //{

            //    valor = quant * 4.50;
            //    Console.WriteLine("Valor a pagar no X-Salada: " + valor.ToString("f2"));
            //}
            //else if (codigo == 3)
            //{

            //    valor = quant * 5.00;
            //    Console.WriteLine("Valor a pagar no X-Bacon: " + valor.ToString("f2"));
            //}
            //else if (codigo == 4) { 

            //    valor = quant * 2.00;
            //    Console.WriteLine("Valor a pagar na Torrada Simples: " + valor.ToString("f2"));
            //}
            //else if (codigo == 5)
            //{
            //    valor = quant * 1.50;
            //    Console.WriteLine("Valor a pagar no Refrigerante: " + valor.ToString("f2"));
            //}
            //else {
            //    Console.WriteLine("Codigo do produto invalido");
            //}

            //--------------------------------------------------------------------------------------------------
            //EXERCICIO 6
            //Faça um programa que leia um valor e informe em qual intervalo ele se encontra: [0,25], (25,50], (50,75], (75,100]. Caso o valor não esteja em nenhum desses intervalos, informe que ele está fora dos intervalos.
            //Console.WriteLine("Digite um valor:");

            //double valor = double.Parse(Console.ReadLine());

            //if (valor >= 0 && valor <= 25)
            //{
            //    Console.WriteLine("Intervalo [0,25]");
            //}
            //else if (valor > 25 && valor <= 50)
            //{
            //    Console.WriteLine("Intervalo (25,50]");
            //}
            //else if (valor > 50 && valor <= 75)
            //{
            //    Console.WriteLine("Intervalo (50,75]");
            //}
            //else if (valor > 75 && valor <= 100)
            //{
            //    Console.WriteLine("Intervalo (75,100]");
            //}
            //else
            //{
            //    Console.WriteLine("Fora de intervalo");
            //}

            //--------------------------------------------------------------------------------------------------
            //EXERCICIO 7
            //Faça um programa que leia as coordenadas (X,Y) de um ponto no plano cartesiano e informe em qual quadrante o ponto se encontra. Se o ponto estiver na origem (0,0), informe que ele está na origem.

            //Console.WriteLine("Digite o primeiro valor: ");
            //double x = double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o segundo valor: ");
            //double y = double.Parse(Console.ReadLine());

            //if (x == 0 && y == 0)
            //{
            //    Console.WriteLine("Origem");
            //}
            //else if (x > 0 && y > 0)
            //{
            //    Console.WriteLine("Q1");
            //}
            //else if (x < 0 && y > 0)
            //{
            //    Console.WriteLine("Q2");
            //}
            //else if (x < 0 && y < 0)
            //{
            //    Console.WriteLine("Q3");

            //}

            //else
            //{
            //    Console.WriteLine("Q4");
            //}

            //--------------------------------------------------------------------------------------------------
            //EXERCICIO 8
            Console.WriteLine("informe sua renda para o calculo do imposto: ");

            double renda = double.Parse(Console.ReadLine());

            double imposto;
            if (renda <= 2000.0)
            {
                imposto = 0.0;
            }
            else if (renda <= 3000.0)
            {
                imposto = (renda - 2000.0) * 0.08;
            }
            else if (renda <= 4500.0)
            {
                imposto = (renda - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else
            {
                imposto = (renda - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (imposto == 0.0)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
