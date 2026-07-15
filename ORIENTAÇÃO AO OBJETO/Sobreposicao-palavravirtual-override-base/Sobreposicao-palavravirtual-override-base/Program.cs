using Sobreposicao_palavravirtual_override_base.Entities;

namespace Sobreposicao_palavravirtual_override_base
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alef", 1000);
            Account acc1 = new SavingsAccount (1002, "João", 1500, 0.01);
            Account acc2 = new BusinessAccount (1002, "Sergio", 1500, 0.01);

            acc.Withdraw(10.0);
            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);


            Console.WriteLine(acc.Balance);
            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}
