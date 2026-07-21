

namespace Com_Interface.Entities
{
    internal class CarRental
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Vehicle Vehicle { get; set; }
        public Invoice Invoice { get; set; }

        public CarRental(DateTime start, DateTime finishin, Vehicle vehicle)
        {
            Start = start;
            Finish = finishin;
            Vehicle = vehicle;
        }
    }
}
