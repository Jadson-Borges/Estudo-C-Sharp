using System.Globalization;
namespace Interface.Entities
{
    internal class Installment
    {
        public DateTime DueDate { get; set; }
        public double Ammount { get; set; }

        public Installment (DateTime dueDate, double ammount)
        {
            DueDate = dueDate;
            Ammount = ammount;
        }

        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy")
                + " - "
                + Ammount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
