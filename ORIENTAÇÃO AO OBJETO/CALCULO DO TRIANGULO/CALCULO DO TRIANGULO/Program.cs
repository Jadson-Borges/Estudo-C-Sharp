using System;
using System.Globalization;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace CALCULO_DO_TRIANGULO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Fazer um programa para ler as medidas dos lados de dois triângulos X e Y, calcular suas áreas e mostrar o resultado. O programa deve utilizar uma função para calcular a área a partir das medidas dos lados, conforme fórmula de Heron.
            Console.WriteLine("Entre com as medidas do triângulo X:");
            double xA, xB, xC, yA, yB, yC;

            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xA + xB + xC) / 2.0;// Calculando o semiperímetro para o triângulo X
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));// Fórmula de Heron para calcular a área do triângulo X

            p = (yA + yB + yC) / 2.0;// Recalculando o semiperímetro para o triângulo Y
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));// Fórmula de Heron para calcular a área do triângulo Y

            Console.WriteLine("Área do triângulo X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área do triângulo Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("O triângulo X tem a maior área.");
            }
            else
            {
                Console.WriteLine("O triângulo Y tem a maior área.");
            }
        }
    }
}
