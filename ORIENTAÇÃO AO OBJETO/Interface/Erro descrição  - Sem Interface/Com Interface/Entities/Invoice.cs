using System.Globalization;


namespace Com_Interface.Entities
{
    internal class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            return " Pagamento Basico: "
                + BasicPayment.ToString(CultureInfo.InvariantCulture)
                + " Imposto: "
                + Tax.ToString(CultureInfo.InvariantCulture)
                + " Pagamento Total: "
                + TotalPayment.ToString(CultureInfo.InvariantCulture);
        }
    }
}
