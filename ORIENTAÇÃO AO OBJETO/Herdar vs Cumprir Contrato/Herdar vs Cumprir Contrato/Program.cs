using Herdar_vs_Cumprir_Contrato.Entities;
using Herdar_vs_Cumprir_Contrato.Enums;
using System.Globalization;
namespace Herdar_vs_Cumprir_Contrato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape circle = new Circle() { Radius = 2, Color = Color.White };
            IShape retangle = new Rectangle() { Widht = 3.50, Height = 4.2, Color = Color.Black };

            Console.WriteLine(circle);
            Console.WriteLine(retangle);
        }
    }
}
