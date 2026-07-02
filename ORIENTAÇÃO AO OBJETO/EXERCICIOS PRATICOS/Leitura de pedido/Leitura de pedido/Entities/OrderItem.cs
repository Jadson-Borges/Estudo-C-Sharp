using System.Diagnostics.CodeAnalysis;
namespace Leitura_de_pedido.Entities
{
    internal class OrderItem
    {
        public int Quantily { get; set; }
        public double Price { get; set; }

        public OrderItem(int quatily, double price)
        {
            Quantily = Quantily;
            Price = price;
        }

        public double SubTotal()
        {
            return Price * Quantily;
        }
    }
}
