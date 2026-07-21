

namespace Interface.Services
{
    internal interface IOnlinePaymentService
    {
        double Interest(double ammount, int months);
        double PaymentFee(double ammount);
    }
}
