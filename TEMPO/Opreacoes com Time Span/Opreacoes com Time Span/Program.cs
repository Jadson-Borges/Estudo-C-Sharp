using System;


namespace Opreacoes_com_Time_Span
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine();

            Console.WriteLine(t);
            Console.WriteLine("Dias: " + t.Days);
            Console.WriteLine("Horas: " + t.Hours);
            Console.WriteLine("Minutos: " + t.Minutes);
            Console.WriteLine("Milisegundos: " + t.Milliseconds);
            Console.WriteLine("Segundos: " + t.Seconds);
            Console.WriteLine("Ticks: " + t.Ticks);
            Console.WriteLine();


            Console.WriteLine("Total de Dias: " + t.TotalDays);
            Console.WriteLine("Total de Horas: " + t.TotalHours);
            Console.WriteLine("Total de Minutos: " + t.TotalMinutes);
            Console.WriteLine("Total de Segundos: " + t.TotalSeconds);
            Console.WriteLine("Total de Milisegundos: " + t.TotalMilliseconds);

            Console.WriteLine("===================================");
            Console.WriteLine();

            TimeSpan hora = new TimeSpan(1, 30, 10);
            TimeSpan hora1 = new TimeSpan(0, 10, 5);

            TimeSpan horaSoma = hora.Add(hora1);
            TimeSpan horaSub = hora.Subtract(hora1);
            TimeSpan horaMult = hora.Multiply(2.0);
            TimeSpan horaDiv = hora.Divide(2.0);


            Console.WriteLine("hora: " + hora);
            Console.WriteLine("hora1: " + hora1);
            Console.WriteLine("soma: " + horaSoma);
            Console.WriteLine("subtração: " + horaSub);
            Console.WriteLine("subtração: " + horaMult);
            Console.WriteLine("subtração: " + horaDiv);


        }
    }
}
