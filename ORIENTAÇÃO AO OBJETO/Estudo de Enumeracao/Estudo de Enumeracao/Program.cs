
using System;
using Estudo_de_Enumeracao.Entities;
using Estudo_de_Enumeracao.Entities.Enums;

namespace Estudo_de_Enumeracao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string conversaoParaString = OrderStatus.PendingPayment.ToString();
            OrderStatus conversaoDeString = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(conversaoParaString);
            Console.WriteLine(conversaoDeString);
        }
    }
}
