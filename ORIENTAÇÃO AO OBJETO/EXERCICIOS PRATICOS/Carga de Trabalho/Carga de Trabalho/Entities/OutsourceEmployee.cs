
namespace Carga_de_Trabalho.Entities
{
    internal class OutsourceEmployee : Employee
    {
        public double AdditionalCharge { get; set; }


        public OutsourceEmployee ()
        {

        }

        public OutsourceEmployee (string name, int hours, double valuePerHours, double additionalCharge)
            : base(name, hours, valuePerHours)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment(double payment)
        {
            return base.Payment(payment);
            Payment += AdditionalCharge * 0,12;

        }
    }
}
