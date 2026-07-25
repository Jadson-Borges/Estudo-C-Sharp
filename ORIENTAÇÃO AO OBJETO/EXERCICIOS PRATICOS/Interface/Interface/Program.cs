using Interface.Entities;
using Interface.Services;
using System.Globalization;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Número do contrato: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Data (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(
                Console.ReadLine(),
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture);

            Console.Write("Valor do contrato: ");
            double total = double.Parse(
                Console.ReadLine(),
                CultureInfo.InvariantCulture);

            Console.Write("Número de parcelas: ");
            int months = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, total);

            ContractService contractService =
                new ContractService(new PaypalService());

            contractService.ProcessContract(contract, months);

            Console.WriteLine();
            Console.WriteLine("PARCELAS:");

            foreach (Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}
