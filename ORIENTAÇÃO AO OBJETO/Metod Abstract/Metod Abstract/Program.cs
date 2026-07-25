using Metod_Abstract.Etities.Enum;
using Metod_Abstract.Etities;
using System.Globalization;
namespace Metod_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Shape> list = new List<Shape> ();
            Console.Write("Entre com o numero de figuras: ");

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados da #{i} Figura: ");
                Console.WriteLine("Retangulo ou circulo? (r/c)? ");
                char rc = char.Parse(Console.ReadLine());

                Console.WriteLine("Cor: (Black/ White/ Red)");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (rc == 'r')
                {
                    Console.WriteLine("informe a Altura: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.WriteLine("Informe a Largura: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.WriteLine("Informe o Raio: ");
                    double radius = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                    list.Add(new Circle(radius, color));
                }
            }
            Console.WriteLine();
            Console.WriteLine("areas da figura: ");

            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
