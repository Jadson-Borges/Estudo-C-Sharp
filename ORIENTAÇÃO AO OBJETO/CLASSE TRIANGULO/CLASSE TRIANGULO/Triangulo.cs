using System;


namespace CLASSE_TRIANGULO
{
    internal class Triangulo
    {
        // Variáveis públicas para armazenar as medidas dos lados do triângulo
        public double A; 
        public double B;
        public double C;

        //METODO PARA CALCULAR A ÁREA DO TRIÂNGULO
        // O método Area() calcula a área do triângulo usando a fórmula de Heron
        public double Area()
        {
            double p = (A + B + C) / 2.0; // Calcula o semiperímetro
           return Math.Sqrt(p * (p - A) * (p - B) * (p - C)); // Retorna a área usando a fórmula de Heron
           
        }
    }
}
