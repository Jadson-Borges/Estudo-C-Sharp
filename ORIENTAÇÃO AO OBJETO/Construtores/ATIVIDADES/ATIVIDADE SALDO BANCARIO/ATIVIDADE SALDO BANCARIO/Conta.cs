using System;
using System.Globalization;

namespace ATIVIDADE_SALDO_BANCARIO
{
    internal class Conta
    {
        public int NumConta { get; private set; }
        public string Nome { get; private set; }
        public double Saldo { get; private set; }

        public Conta(int numConta, string nome, double saldo)
        {
            NumConta = numConta;
            Nome = nome;
            Saldo = saldo;
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= valor + 5.0; // taxa do saque
        }

        public override string ToString()
        {
            return "Conta: "
                + NumConta
                + ", Titular: "
                + Nome
                + ", Saldo: R$ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}