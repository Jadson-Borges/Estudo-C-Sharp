using System;
using System.Globalization;


namespace Correção_de_Atividade_Saldo_Bancario
{
    internal class Conta
    {
        //Propriedades
        public int NumeroConta { get; private set; }
        public string Titular { get; set; }
        public decimal Saldo { get; private set; }

        //Construtor 1 sem deposito inicial
        public Conta(int numeroConta, string titular)
        {
            NumeroConta = numeroConta;
            Titular = titular;

        }

        //Contrutor 2 com deposito inicial
        public Conta(int numeroConta, string titular, decimal depositoInicial) : this (numeroConta, titular)// this é para reaproveitar o construtor 1
        {
            //Saldo = saldo;
            Deposito (depositoInicial);
        }

        public void Deposito (decimal valorDeposito)
        {
           Saldo += valorDeposito;
        }

        public void Saque (decimal valorSaque) 
        {
            Saldo -= valorSaque + 5;
        }

        //classe ToString para retornar resultado!
        public override string ToString()
        {
            return  "Sua conta é: "
                    + NumeroConta
                    + ", O titular é: "
                    + Titular
                    + ", e o Saldo é: $ "
                    + Saldo.ToString("F2", CultureInfo.InvariantCulture)
                    ;
        }
    }
}
