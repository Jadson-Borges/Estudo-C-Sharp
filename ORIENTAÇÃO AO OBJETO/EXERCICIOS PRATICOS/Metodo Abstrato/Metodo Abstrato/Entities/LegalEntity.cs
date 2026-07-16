using System;
using System.Collections.Generic;
using System.Text;

namespace Metodo_Abstrato.Entities
{
    internal class LegalEntity : Taxpayer
    {
        public int NumberOfEmployees { get; set; }

        public LegalEntity (string name, double annualIncome, int numberOfEmployees)
            : base (name, annualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            if (NumberOfEmployees <= 10)
            {
                return AnnualIncome * 0.16;
            }
            else
            {
                return AnnualIncome * 0.14;
            }
        }
    }
}
