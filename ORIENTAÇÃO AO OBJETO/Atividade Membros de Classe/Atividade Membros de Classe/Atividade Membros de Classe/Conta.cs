using System;
using System.Globalization;

namespace Atividade_Membros_de_Classe
{
    internal class Conta
    {
        // =========================
        // PROPRIEDADES AUTOIMPLEMENTADAS
        // =========================
        public int NumeroConta { get; private set; } 
        public string NomeConta { get; private set; }
        public decimal Saldo { get; private set; }

        // =========================
        // CONSTRUTOR
        // =========================

        public Conta ( int numeroConta, string nomeConta, decimal saldo)
        {
            NumeroConta = numeroConta;
            NomeConta = nomeConta;
            Saldo = saldo;

        }

        // =========================
        // OUTROS MÉTODOS DA CLASSE
        // =========================

        public void Deposito (decimal saldo)
        {
            Saldo += saldo; 
        }

        public void Saque (decimal saldo)
        {
            Saldo -= saldo + 5;
        }

        public override string ToString()
        {
            return "Conta: "
                + NumeroConta
                + " Titular: "
                + NomeConta
                + " Saldo: "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
