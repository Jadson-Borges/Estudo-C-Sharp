
namespace Carga_de_Trabalho.Entities
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public List<Employee> List { get; set; } = new List<Employee>();

        public Employee()
        {

        }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment(double payment)
        {
           return ValuePerHour * Hours;
        }

        public 
    }
}
