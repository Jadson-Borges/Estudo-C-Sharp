using System;
using System.Globalization;
using System.Runtime.Remoting.Channels;


namespace Correção_de_Atividade_Saldo_Bancario
{
    internal class Program
    {
        static void Main(string[] args) {

            Conta conta;

            Console.WriteLine("Informe o Numero da Conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o Titular da Conta: ");
            string titular = Console.ReadLine();

            Console.WriteLine("Tem Saldo inicial? (s/n)");
            char resultado = char.Parse(Console.ReadLine());

            //Caso o usuario digite s ou S no Terminal

            if (resultado == 's' || resultado == 'S') 
            {
                Console.WriteLine("entre com o valor de Deposito inicial: ");
                decimal saldo = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
                conta = new Conta(numeroConta, titular, saldo);
            }

            //Caso não
            else
            {
                conta = new Conta (numeroConta, titular);
            }


            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.WriteLine("Informe um valor de Deposito:");
            decimal saldoConta = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(saldoConta);
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.WriteLine("Informe o valor a ser sacado:");
            saldoConta = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saldoConta);
            Console.WriteLine(conta);

        }

    }
}
