using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntradaDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
             //Console.ReadLine();//Lê uma linha de texto do console e retorna uma string quando o usuário pressiona Enter. O texto digitado é armazenado na variável.
            Console.WriteLine("Digite uma frase:");
            string frase = Console.ReadLine();

            Console.WriteLine("Digite as cores:");
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            Console.WriteLine("informe as cores secundarias:");
            //string cores = Console.ReadLine();
            //string[] lista = cores.Split(' '); //O método Split é usado para dividir a string cores em um array de strings, usando o espaço como delimitador. Cada cor secundária digitada pelo usuário será armazenada em um elemento do array lista.
            string [] lista = Console.ReadLine().Split(' ');
            string a = lista[0];
            string b = lista[1];
            string c = lista[2];



            Console.WriteLine("sua frase é: " + frase);
            Console.WriteLine("suas cores são: " + x + ", " + y + ", " + z);
            Console.WriteLine("suas cores secundarias são: " + a + ", " + b + ", " + c);
         
        }
    }
}
