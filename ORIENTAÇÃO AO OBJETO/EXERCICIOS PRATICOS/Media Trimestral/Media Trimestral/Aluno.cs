using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Trimestral
{
    internal class Aluno
    {
       public string Nome;
        public double n1, n2, n3;

        public double Media()
        {
            return n1 + n2 + n3;
        }

        public void Situacao()
        {
            if (Media() >= 60.0) 
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado, Faltam " + (60.0 - Media()) + " pontos.");
            }
        }

    }
}
