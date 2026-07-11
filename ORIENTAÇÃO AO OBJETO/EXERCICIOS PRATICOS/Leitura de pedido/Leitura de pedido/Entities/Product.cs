using System;
using System.Collections.Generic;
<<<<<<< HEAD
=======
using System.Globalization;
>>>>>>> 031d2e8f579cc4b252fa352e328954c7b4325ed3
using System.Text;

namespace Leitura_de_pedido.Entities
{
    internal class Product
    {
<<<<<<< HEAD
        public string Name { get; set; }
=======
        public string NameProduct { get; set; }
>>>>>>> 031d2e8f579cc4b252fa352e328954c7b4325ed3
        public double Price { get; set; }


        public Product()
        {

        }

<<<<<<< HEAD
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

=======
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

>>>>>>> 031d2e8f579cc4b252fa352e328954c7b4325ed3
    }
}
