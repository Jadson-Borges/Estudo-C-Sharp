using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Leitura_de_pedido.Entities
{
    internal class Product
    {
        public string NameProduct { get; set; }
        public double Price { get; set; }


        public Product()
        {

        }

        public Product(string nameProduct, double price)
        {
            NameProduct = nameProduct;
            Price = price;
        }

        public override string ToString()
        {
            return NameProduct
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
