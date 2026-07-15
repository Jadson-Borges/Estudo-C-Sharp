using Heranca_e_Polimorfismo.Entities;
using System.Globalization;
namespace Heranca_e_Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Informe o numero de Produtos: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Produto comum, usado ou importado? (c/u/i): ");
                char cui = char.Parse(Console.ReadLine());

                Console.WriteLine($"Produto #{i} Dados: ");
                Console.Write("Nome: ");
                string name = Console.ReadLine();

                Console.Write("Preço: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (cui == 'u')
                {
                    Console.Write("Data de Fabricação? (dia/mes/ano): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                    list.Add(new UseProduct(name, price, manufactureDate));
                }
                else if (cui == 'i')
                {
                    Console.WriteLine("Preço da alfandegá: ");
                    double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);                   
                    list.Add(new ImporteProduct(name, price, customFee));
                }
                else
                {
                    list.Add(new Product(name, price));
                    
                }                                
            }
            Console.WriteLine("----------------------------------------");

            foreach (Product product in list)
            {
                Console.WriteLine();
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
