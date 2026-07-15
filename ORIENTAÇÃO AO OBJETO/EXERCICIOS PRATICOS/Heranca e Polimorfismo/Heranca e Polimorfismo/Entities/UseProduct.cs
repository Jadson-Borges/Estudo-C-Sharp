namespace Heranca_e_Polimorfismo.Entities
{
    internal class UseProduct: Product
    {
        public DateTime ManufactureDate { get; set; }

        public UseProduct() 
        {
        }

        public UseProduct(string name, double price, DateTime manufactureDate)
            : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return Name + " (usado) " + " $ " + Price + " " + ManufactureDate.ToString("dd/MM/yyyy");
        }

    }
}
