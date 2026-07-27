using Comparison_tipos.Entities;
namespace Comparison_tipos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            //Guarda o método em uma variável (delegate) e depois o passa ao Sort().
            //Comparison<Product> comp = CompareProducts;
            //list.Sort(comp);

            //Usa um método já existente para comparar.
            //list.Sort(CompareProducts);

            //Cria uma função anônima (lambda) diretamente na chamada do Sort().
            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

            //Comparação do tipo?
            //static int CompareProducts(Product p1, Product p2)
            //{
            //    return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
            //}
        }
    }
}
