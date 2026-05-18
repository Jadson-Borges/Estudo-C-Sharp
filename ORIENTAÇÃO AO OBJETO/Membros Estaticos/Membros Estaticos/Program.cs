using System;
using System.Globalization;


namespace Membros_Estaticos
{
    internal class Program
    {
        static double Pi = 3.14; //usa o static pois o valor é fixo se o valor fosse mutavél ou seja não tivesse sido declarado o programa iria quebrar.
        static void Main(string[] args)
        {
            Console.WriteLine("Informe  o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double circ = Circuferencia(raio); //garda o resultado do calculo da circuferencia do Raio.

            double vol = Volume(raio);

            Console.Write(" Circuferencia é: " + circ.ToString(("F2"), CultureInfo.InvariantCulture));
            Console.Write(" Volume é: " + vol.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(" Valor de PI é: " +Pi);
        }

        static double Circuferencia (double rc){ //r é a variavel que armazena o valor de raio que foi digitado anteriormente.
            return 2* Pi * rc;
        }

        static double Volume(double rv) 
        {
            return 4 / 3 * Pi * Math.Pow(rv, 3) ;
        }
    }
}
