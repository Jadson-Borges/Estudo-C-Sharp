using Excecoes.Entities;
using Excecoes.Entities.Exceptions;
using System.Globalization;
namespace Excecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Entre com os dados da Conta: ");
                Console.Write("Numero da conta:");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Titular da conta: ");
                string holder = Console.ReadLine();

                Console.Write("Saldo inicial: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Limite de saque: ");
                double withDrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(number, holder, balance, withDrawLimit);

                Console.WriteLine();
                Console.WriteLine("Informe o valo a ser sacado da conta: ");
                double withDraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                account.WithDraw(withDraw);
                Console.WriteLine("Novo Saldo: " + account.Balance.ToString("f2", CultureInfo.InvariantCulture));
            }
            catch (DomainException e)

            {
                Console.WriteLine("Erro no processo: " + e.Message);
            }

            
        }
    }
}
