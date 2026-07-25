using Herdar_vs_Cumprir_Contrato.Enums;

namespace Herdar_vs_Cumprir_Contrato.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
