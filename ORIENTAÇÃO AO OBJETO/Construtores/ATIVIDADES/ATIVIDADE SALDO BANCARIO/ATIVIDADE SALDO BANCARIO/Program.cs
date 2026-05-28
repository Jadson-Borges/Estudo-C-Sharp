using System;
using System.Globalization;

namespace ATIVIDADE_SALDO_BANCARIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o numero da conta: ");
            int numConta = int.Parse(Console.ReadLine());

            Console.Write("Entre o Titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            bool temSaldo = (Console.ReadLine().ToLower() == "s");

            Conta conta;

            if (temSaldo)
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                conta = new Conta(numConta, nome, saldo);
            }
            else
            {
                conta = new Conta(numConta, nome, 0);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Informe valor do depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            conta.Deposito(deposito);

            Console.WriteLine("Dados atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Informe o valor do saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            conta.Saque(saque);

            Console.WriteLine("Dados atualizados:");
            Console.WriteLine(conta);
        }
    }
}