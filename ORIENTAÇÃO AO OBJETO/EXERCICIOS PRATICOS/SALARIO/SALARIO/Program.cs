using System;
using System.Globalization;

namespace SALARIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            Console.WriteLine("Informe o nome do funcionário:");
            funcionario.Nome = Console.ReadLine();

            Console.WriteLine("Informe o salário bruto:");
            funcionario.SalarioB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe o imposto:");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do funcionario: " + funcionario.ToString());


            Console.WriteLine("Informe a porcentagem de aumento:");
            funcionario.Porcentagem = int.Parse(Console.ReadLine());

            Console.WriteLine("Salario atualizado: " + funcionario.Aumento(), ("F2", CultureInfo.InvariantCulture));
        }
    }
}
