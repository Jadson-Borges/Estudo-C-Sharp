using Metod_Abstract.Etities.Enum;
namespace Metod_Abstract.Etities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape (Color color)
        {
            Color = color;
        }
        public abstract double Area();
        
    }
} 