using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO_ESTRUTURA_WHILE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-----------------------------------------------------------------------------------
            //Exercicio 1

            //o programa ira solicitar a senha, caso a senha seja diferente de 2002 o programa ira solicitar novamente, caso seja igual a 2002 o programa ira encerrar
            //Console.WriteLine("Digite a senha: ");
            //int senha = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //while (senha != 2002)
            //{
            //    Console.WriteLine("Senha Invalida! Tente novamente: ");
            //    senha = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //}

            //Console.WriteLine("Senha Correta!");
            //-----------------------------------------------------------------------------------
            //Exercicio 2

            //ao escrever as variaveis X e Y, o programa ira identificar em qual quadrante do plano cartesiano elas se encontram, caso sejam iguais a zero o programa ira encerrar
            //Console.WriteLine("Escreva as variaveis X e Y: ");

            //string[] var = Console.ReadLine().Split(' ');
            //double x = double.Parse(var[0], CultureInfo.InvariantCulture);
            //double y = double.Parse(var[1], CultureInfo.InvariantCulture);

            //while (x != 0 && y !=0 ) {
            //    if (x > 0 && y > 0)
            //    {
            //        Console.WriteLine("primeiro");
            //    }
            //    else if (x > 0 && y < 0) {

            //        Console.WriteLine("quarto");
            //    }
            //    else if (x < 0 && y < 0)
            //    {
            //        Console.WriteLine("terceiro");

            //    }
            //    else
            //    {
            //        Console.WriteLine("segundo");
            //    }

            //    Console.WriteLine("Escreva as variaveis X e Y: ");
            //    var = Console.ReadLine().Split(' ');
            //    x = double.Parse(var[0], CultureInfo.InvariantCulture);
            //    y = double.Parse(var[1], CultureInfo.InvariantCulture);
            //}

            //-----------------------------------------------------------------------------------
            //Exercicio 3

            Console.WriteLine("Digite o codigo do combustivel: ");
            int codigo = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;



            while (codigo != 4)
            {
                if (codigo == 1)
                {
                    alcool++;
                    Console.WriteLine("Alcool");
                }

                else if (codigo == 2)
                {
                    gasolina++;
                    Console.WriteLine("Gasolina");
                }
                else if (codigo == 3)
                {
                    diesel++;
                    Console.WriteLine("Diesel");
                }
                else
                {
                    Console.WriteLine("Codigo Invalido");
                }

                Console.WriteLine("Digite o codigo do combustivel novamente! ");
                codigo = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("MUITO OBRIGADO!");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);

        }
    }
}
