using System.Globalization;
namespace Herdar_vs_Cumprir_Contrato.Entities
{
    internal class Rectangle: AbstractShape
    {
        public double Widht { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Widht * Height;
        }

        public override string ToString()
        {
            return "Retangle color = "
                + Color
                + " With = "
                + Widht.ToString("F2", CultureInfo.InvariantCulture)
                + " Height = "
                + Height.ToString("F2", CultureInfo.InvariantCulture)
                + ", Area = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
