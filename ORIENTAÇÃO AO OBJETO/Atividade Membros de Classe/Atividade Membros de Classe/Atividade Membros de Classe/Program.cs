using System;
using System.Globalization;

namespace Atividade_Membros_de_Classe
{
    internal class Program
    {
        // =========================
        // MÉTODO PRINCIPAL (ENTRY POINT)
        // =========================
        static void Main(string[] args)
        {
            // =========================
            // ENTRADA DE DADOS
            // =========================
            Console.WriteLine("Entre com o numero d Conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o titulo da Conta: ");
            string nomeConta = Console.ReadLine();

            Console.WriteLine("Haverá deposito inicial (s/n)? ");
            bool resposta = Console.ReadLine().Trim().ToLower() == "s";

            // =========================
            // DECLARAÇÃO DE OBJETO
            // =========================
            Conta conta;

            // =========================
            // ESTRUTURA CONDICIONAL
            // =========================
            if (resposta)
            {
                // =========================
                // PROCESSAMENTO / REGRA DE NEGÓCIO
                // =========================
                Console.WriteLine("Informe o deposito inicial", CultureInfo.InvariantCulture);
                decimal saldo = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                // =========================
                // INSTANCIAÇÃO DE OBJETO
                // =========================
                conta = new Conta (numeroConta, nomeConta, saldo);

                // =========================
                // SAÍDA DE DADOS
                // =========================
                Console.WriteLine("Dados da Conta:");
                Console.WriteLine(conta);

                // =========================
                // CHAMADA DE MÉTODO
                // =========================
                Console.WriteLine("Informe um novo deposito", CultureInfo.InvariantCulture);
                saldo = decimal.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Deposito(saldo);
                Console.WriteLine(conta);

                // =========================
                // CHAMADA DE MÉTODO
                // =========================
                Console.WriteLine("Efetue um Saque", CultureInfo.InvariantCulture);
                saldo = decimal.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Saque(saldo);
                Console.WriteLine(conta);
            }

            else 

            {
                conta = new Conta(numeroConta, nomeConta, 0);

                Console.WriteLine("Dados da Conta:");
                Console.WriteLine(conta);
            }

            Console.WriteLine("Fim do Programa!");
        }
    }   
}
