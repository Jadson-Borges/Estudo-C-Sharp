namespace Heranca_e_Polimorfismo.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product ()
        {

        }

        public Product (string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return "ETIQUETA DE PREÇO: "
                + Name
                + " $ "
                + Price;
        }
    }
}
