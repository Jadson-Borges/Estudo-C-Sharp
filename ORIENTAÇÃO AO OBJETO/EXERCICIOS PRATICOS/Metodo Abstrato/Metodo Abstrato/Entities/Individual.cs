
namespace Metodo_Abstrato.Entities
{
    internal class Individual : Taxpayer
    {
        public double HealthcareSpending { get; set; }


        public Individual(string name, double annualIncome, double healthcareSpending)
            : base (name, annualIncome)
            {
            HealthcareSpending = healthcareSpending;
            }

        public override double Tax()
        {
            if (AnnualIncome < 20000.00 )
            {
                return (AnnualIncome * 0.15) - (HealthcareSpending * 0.50);  
            }

            else
            {
                return (AnnualIncome * 0.25) - (HealthcareSpending * 0.50);
            }            
        }

    }

}
