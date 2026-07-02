using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = new string[] {"Maria", "Jadson", "Jose" };

            //para cada - foreach substitui o FOR
            foreach (string obj in vetor)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
