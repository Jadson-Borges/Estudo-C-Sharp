using System;
using System.Globalization;

namespace Hospedagem
{
    internal class Hospede
    {
        public string NomeHospede { get; set; }
        public string EmailHospede { get; set; }

        public Hospede(string nomeHospede, string emailHospede)
        {
            NomeHospede = nomeHospede;
            EmailHospede = emailHospede;
        }

        public override string ToString()
        {
            return NomeHospede
                   + ", "
                   + EmailHospede;
        }
    }
}
