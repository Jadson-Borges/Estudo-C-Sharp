using System;
using System.Globalization;

namespace CALCULO_RETANGULO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();
            

            Console.WriteLine("Informe a Largura do retângulo:");
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe a Altura do retângulo:");
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("O retângulo tem as seguintes medidas:");
            Console.WriteLine("Medidas: " + retangulo);

        }
    }
}
