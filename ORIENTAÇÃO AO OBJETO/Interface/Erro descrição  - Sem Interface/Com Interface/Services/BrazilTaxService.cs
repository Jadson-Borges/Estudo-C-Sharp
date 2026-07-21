
namespace Com_Interface.Services
{
    internal class BrazilTaxService
    {
        public double Tax(double ammount)
        {
            if (ammount <= 100)
            {
                return ammount * 0.2;
            }
            else
            {
                return ammount * 0.15;
            }
        }
    }
}
