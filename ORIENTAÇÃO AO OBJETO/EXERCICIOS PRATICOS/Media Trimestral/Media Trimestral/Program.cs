using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Trimestral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.WriteLine("Digite o nome do aluno:");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite a primeira nota:");
            aluno.n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a segunda nota:");
            aluno.n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a terceira nota:");
            aluno.n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL: " + aluno.Media().ToString("F2", CultureInfo.InvariantCulture));
            aluno.Situacao();

        }
    }
}
