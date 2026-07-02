using Exercicio_Contrato.Entities.Enums;
using Exercicio_Contrato.Entities;
using System;
using System.Globalization;

namespace Exercicio_Contrato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do Departamento: ");
            string deptName = Console.ReadLine();

            Console.WriteLine("Dados do trabalhador: ");
            Console.Write("Nome: ");
            string name = Console.ReadLine();

            Console.Write("Nivel ( Junior / MidLevel / Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Salario Base: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departament dept = new Departament(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.WriteLine("Quantos contratos de trabalho? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Informe a data do contrato #{i}");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("valor por Hora: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Duração em (horas): ");
                int hours = int.Parse(Console.ReadLine());

                HoursContract contract = new HoursContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.Write("Entre com o mês e ano para calcular a Renda (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Nome: " + worker.Name);
            Console.WriteLine("Departamento: " + worker.Departament.Name);
            Console.WriteLine("Renda de " + monthAndYear + ": " + worker.Income(year, month).ToString("f2"), CultureInfo.InvariantCulture);
        }
    }
}
