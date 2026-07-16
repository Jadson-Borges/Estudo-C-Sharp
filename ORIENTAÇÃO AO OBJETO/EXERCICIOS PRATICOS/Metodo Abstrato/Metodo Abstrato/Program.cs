using Metodo_Abstrato.Entities;
using System.Globalization;
namespace Metodo_Abstrato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Taxpayer> list = new List<Taxpayer>();

            Console.WriteLine("Entre com o numero de Pagadores: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Contribuinte #{i} Dados: ");
                Console.WriteLine("Pessoa Fisica ou empresa? (f/e): ");

                char fe = char.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string name = Console.ReadLine();

                Console.Write("Renda Anual: ");
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                

                if (fe == 'e')
                {
                    Console.Write("Numero de Funcionarios: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());

                    list.Add(new LegalEntity(name, annualIncome, numberOfEmployees));
                }
                else
                { 
                Console.Write("Despesas de saúde: ");
                double healthcareSpending = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Individual(name, annualIncome, healthcareSpending));
                }

            }


            Console.WriteLine();
            Console.WriteLine("TAXA PAGA:");


            foreach (Taxpayer taxpayer in list)
            {
                
                Console.Write(taxpayer.Name + ": " + taxpayer.Tax().ToString("f2", CultureInfo.InvariantCulture));
            }


        }
    }
}
