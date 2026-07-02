using Leitura_de_pedido.Entities.Enums;
namespace Leitura_de_pedido.Entities
{
    internal class Order
    {
        public DateTime Momement { get; set; }
        public OrderStatus Status { get; set; }
    }
}
