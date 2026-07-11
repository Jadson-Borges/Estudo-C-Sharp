using System.Diagnostics.CodeAnalysis;
<<<<<<< HEAD
=======
using System.Globalization;
>>>>>>> 031d2e8f579cc4b252fa352e328954c7b4325ed3
namespace Leitura_de_pedido.Entities
{
    internal class OrderItem
    {
<<<<<<< HEAD
        public int Quantily { get; set; }
        public double Price { get; set; }

        public OrderItem(int quatily, double price)
        {
            Quantily = Quantily;
            Price = price;
=======
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set;  }

        public OrderItem ()
        {
        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
>>>>>>> 031d2e8f579cc4b252fa352e328954c7b4325ed3
        }

        public double SubTotal()
        {
<<<<<<< HEAD
            return Price * Quantily;
=======
            return Price * Quantity;
        }

        public override string ToString()
        {
            return Product.NameProduct
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + Quantity
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
>>>>>>> 031d2e8f579cc4b252fa352e328954c7b4325ed3
        }
    }
}
