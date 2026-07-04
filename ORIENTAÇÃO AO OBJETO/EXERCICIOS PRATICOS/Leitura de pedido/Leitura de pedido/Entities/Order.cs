using Leitura_de_pedido.Entities.Enums;
using System.Globalization;
namespace Leitura_de_pedido.Entities
{
    internal class Order
    {
        public DateTime Momment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Order(DateTime momment, OrderStatus status, Client client)
        {
            Momment = momment;
            Status = status;
            Client = client;
        }

        public void AddItems(OrderItem items)
        {
            Items.Add(items);
        }

        public void RemoveItems(OrderItem items)
        {
            Items.Remove(items);
        }
        public double TotalItems()
        {
            double sum = 0;
            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }

            return sum;
        }

        public override string ToString()
        {
            StringWriter sw = new StringWriter();

            sw.WriteLine("ORDER SUMMARY:");
            sw.WriteLine("Order moment: " + Momment);
            sw.WriteLine("Order status: " + Status);
            sw.WriteLine("Client: " + Client);
            sw.WriteLine("Order items:");

            foreach (OrderItem item in Items)
            {
                sw.WriteLine(item);
            }

            sw.WriteLine("Total price: $" + TotalItems().ToString("F2", CultureInfo.InvariantCulture));

            return sw.ToString();
        }
    }
}
