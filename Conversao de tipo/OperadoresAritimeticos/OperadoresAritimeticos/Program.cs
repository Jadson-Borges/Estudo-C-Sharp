using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresAritimeticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1 = 10;
            double n2 = 5;
            // Operadores Aritméticos: +, -, *, /, %
            double resultadoSoma = n1 + n2;
            double resultadoSubtracao = n1 - n2;
            double resultadoMultiplicacao = n1 * n2;
            double resultadoDivisao = n1 / n2;
            double resultadoResto = n1 % n2;
            double resultCalculo = (n1 + n2) * 2;// A ordem de precedência é a mesma da matemática, ou seja, primeiro os parênteses, depois multiplicação e divisão, e por último adição e subtração
            double resultCalculo2 = n1 + n2 * 2;// Nesse caso, a multiplicação tem precedência sobre a adição, então o resultado será 10 + (5 * 2) = 20
            double resto = 17 % 3;

            // Divisão entre inteiros e ponto flutuante
            double resultadoCalculo3 = 10/8; // O resultado será 1, pois a divisão entre dois números inteiros retorna um número inteiro, ou seja, o resultado é arredondado para baixo. Se quisermos obter um resultado com casas decimais, devemos usar números de ponto flutuante (double ou float) em vez de inteiros.
            double resultadoCalculo4 = 10.0/8.0; // O resultado será 1.25, pois a divisão entre dois números de ponto flutuante retorna um número de ponto flutuante, ou seja, o resultado é preciso e não arredondado.
            double resultadoCalculo5 = (double)10/8;// O resultado será 1.25, pois ao fazer o cast de um dos operandos para double, a divisão é realizada como uma divisão de ponto flutuante, retornando um resultado preciso e não arredondado.

            //calculo de baskara
            double a = 1.0, b = -3.0, c = 2.0;
            double delta = b * b - 4.0 * a * c;
            //double delta = Math.Pow(b, 2.0) - 4.0 * a * c; // Outra forma de calcular o delta usando a função Math.Pow para elevar b ao quadrado ou  ao cubo, por exemplo, seria Math.Pow(b, 3.0) para elevar b ao cubo.
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine(resultadoSoma);
            Console.WriteLine(resultadoSubtracao);
            Console.WriteLine(resultadoMultiplicacao);
            Console.WriteLine(resultadoDivisao);
            Console.WriteLine(resultadoResto);
            Console.WriteLine(resultCalculo);
            Console.WriteLine(resultCalculo2);
            Console.WriteLine(resto);
            Console.WriteLine(resultadoCalculo3);
            Console.WriteLine(resultadoCalculo4);
            Console.WriteLine(resultadoCalculo5);
            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
        }
    }
}
