using Atividade_Polimorfismo.Entities;
using System.Globalization;

namespace Atividade_Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Numero de funcionarios? ");
            int n = int.Parse(Console.ReadLine());

            List <Employee> list = new List<Employee>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados do trabalhador #{i}");

                Console.Write("Tercerizado? :");
                char bo = char.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string name = Console.ReadLine();

                Console.Write("Horas: ");
                int hours = int.Parse(Console.ReadLine());
                
                Console.Write("Valor por horas: ");
                double valuePerHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (bo == 'y')
                {
                    Console.Write("Informe o valor das despesas: ");
                    double addicionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHours, addicionalCharge));
                }

                else
                {
                    list.Add(new Employee(name, hours, valuePerHours));
                }
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");

            Console.WriteLine("Pagamento: ");

            foreach (Employee emp in list)
            {
                Console.WriteLine("Nome: " + emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));

            }
        }
    }
}
