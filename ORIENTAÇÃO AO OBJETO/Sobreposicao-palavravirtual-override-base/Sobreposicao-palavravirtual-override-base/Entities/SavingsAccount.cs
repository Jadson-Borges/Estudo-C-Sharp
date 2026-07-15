namespace Sobreposicao_palavravirtual_override_base.Entities
{
    internal class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {

        }
        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdraw(double ammount)
        {
            //Balance -= ammount;
            base.Withdraw(ammount);
            Balance -= 2.0;
        }
    }
}
