using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiros_Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //============================================================================================
            //atividade 1
            //Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha.

            //Pessoa pessoa1, pessoa2;
            //pessoa1 = new Pessoa();
            //pessoa2 = new Pessoa();

            //Console.WriteLine("informe o nome da primeira Pessoa:");
            //pessoa1.Nome = Console.ReadLine();
            //Console.WriteLine("informe a idade da primeira Pessoa:");
            //pessoa1.Idade = int.Parse(Console.ReadLine());

            //Console.WriteLine("informe o nome da segunda Pessoa:");
            //pessoa2.Nome = Console.ReadLine();
            //Console.WriteLine("informe a idade da segunda Pessoa:");
            //pessoa2.Idade = int.Parse(Console.ReadLine());

            //Console.WriteLine("Segue os dados da primeira Pessoa");
            //Console.WriteLine("Nome: " + pessoa1.Nome);
            //Console.WriteLine("Idade: " + pessoa1.Idade);
            //Console.WriteLine("Segue os dados da segunda Pessoa");
            //Console.WriteLine("Nome: " + pessoa2.Nome);
            //Console.WriteLine("Idade: " + pessoa2.Idade);

            //if (pessoa1.Idade > pessoa2.Idade)
            //{
            //    Console.WriteLine("A pessoa mais velha é: " + pessoa1.Nome);
            //}
            //else if (pessoa2.Idade > pessoa1.Idade)
            //{
            //    Console.WriteLine("A pessoa mais velha é: " + pessoa2.Nome);
            //}
            //else
            //{
            //    Console.WriteLine("As pessoas tem a mesma idade");
            //}

            //=============================================================================================
            //Atividade 2
            // Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário médio dos funcionários.

            Funcionario f1, f2;
            f1 = new Funcionario();
            f2 = new Funcionario();

            Console.WriteLine("Informe o nome do Primeiro Funcionario");
            f1.Nome = Console.ReadLine().ToString(CultureInfo.InvariantCulture);
            Console.WriteLine("Informe o salario do Primeiro Funcionario");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe o nome do Segundo Funcionario");
            f2.Nome = Console.ReadLine().ToString(CultureInfo.InvariantCulture);
            Console.WriteLine("Informe o salario do Segundo Funcionario");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double mediaSalario = (f1.Salario + f2.Salario) / 2;

            Console.WriteLine("Dados do Primeiro Funcionario:");
            Console.WriteLine("Nome: " + f1.Nome);
            Console.WriteLine("Salario: " + f1.Salario.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Dados do Segundo Funcionario:");
            Console.WriteLine("Nome: " + f2.Nome);
            Console.WriteLine("Salario: " + f2.Salario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("A media salarial é: " + mediaSalario.ToString("F2", CultureInfo.InvariantCulture));

            //=============================================================================================

        }
    }
}
