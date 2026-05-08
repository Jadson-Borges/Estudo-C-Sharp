using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntradaDeDados2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar ao usuário que digite um número
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine()); // Converter a entrada do usuário para um número inteiro int.Parse() é usado para converter a string retornada por Console.ReadLine() em um número inteiro. Se o usuário digitar algo que não seja um número válido, isso lançará uma exceção.
            Console.WriteLine(numero);

        }
    }
}
