namespace No_Interface.Service
{
    internal class BrazilTaxService : ITaxService
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