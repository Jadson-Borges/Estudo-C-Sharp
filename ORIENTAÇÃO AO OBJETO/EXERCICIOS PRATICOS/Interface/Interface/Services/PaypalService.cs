
namespace Interface.Services
{
    internal class PaypalService : IOnlinePaymentService
    {
        public double Interest(double ammount, int months)
        {
            return ammount * 0.01 * months;
        }

        public double PaymentFee(double ammount)
        {
            return ammount * 0.02;
        }
    }
}
