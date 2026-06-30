namespace Exercicio_Contrato.Entities
{
    internal class HoursContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        //constructor void
        public HoursContract ()
        {
            
        }

        public HoursContract (DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        //function calculo ValuePerHour

        public double TotalHours ()
        {
            return ValuePerHour * Hours;
        }
    }
}
