using Excecoes.Entities.Exceptions;

namespace Excecoes.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double ammount)
        {
            Balance += ammount;
        }

        public void WithDraw(double ammount)
        {
            
            if (Balance <= 0)
            {
                throw new DomainException("Valor de Saque menor que o saldo ou zerado, operação não realizada!");
            }
            if (ammount > WithDrawLimit)
            {
                throw new DomainException("Valor de saque maior que o limite permitido, operação negada!");
            }
            if ( ammount > Balance )
            {
                throw new DomainException("Saldo insuficiente! ");
            }

            Balance -= ammount;

        }
    }
}