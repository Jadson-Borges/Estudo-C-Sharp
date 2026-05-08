using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //operadores de atribuição são usados para atribuir valores a variáveis. Eles combinam uma operação com a atribuição, permitindo que você modifique o valor de uma variável de forma concisa. Aqui estão alguns exemplos de operadores de atribuição em C#:
            int a = 10; // Declaração e atribuição de valor para a variável a   
            Console.WriteLine("O valor de a é: " + a);

            a += 2; // Operação de adição e atribuição, equivalente a a = a + 2
            Console.WriteLine("O valor de a somando 2 é: " + a);

            a -= 2; // Operação de subtração e atribuição, equivalente a a = a - 2
            Console.WriteLine("O valor de a subtraindo 2 é: " + a);

            a *= 2; // Operação de multiplicação e atribuição, equivalente a a = a * 2
            Console.WriteLine("O valor de a mutliplicando 2 é: " + a);

            a /= 2; // Operação de divisão e atribuição, equivalente a a = a / 2
            Console.WriteLine("O valor de a dividindo 2 é: " + a);

            a %= 2; // Operação de módulo e atribuição, equivalente a a = a % 2, que calcula o resto da divisão de a por 2
            Console.WriteLine("O resto de 2 é: " + a);

            //operadores de atribuição para strings
            string letra = "TESTE";

            Console.WriteLine("O valor da letra é: " + letra);

            letra += " de STRING"; // Operação de concatenação e atribuição, equivalente a letra = letra + " de STRING", que adiciona a string " de STRING" ao final da string original "TESTE"
            Console.WriteLine(letra);

            //operadores de incremento e decremento
            int b = 10;
            b++;// O operador de pós-incremento incrementa o valor de b, mas a expressão retorna o valor original de b antes do incremento, então a linha Console.WriteLine(b) imprime 10, e depois b é incrementado para 11
            Console.WriteLine(b);

            b--;
            Console.WriteLine(b);

            int c = ++b;// O operador de pré-incremento incrementa o valor de b antes de atribuí-lo a c, então c recebe o valor incrementado de b, que é 11
            Console.WriteLine(c);


        }
    }
}
