using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operacao_com_Data_Time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);

            DateTime x = new DateTime(2002, 8, 15, 13, 45, 58, 275);
            
            //DateTime y1 = x.Add(timeSpan);
            DateTime y2 = x.AddDays(1);
            DateTime y3 = x.AddHours(2);
            DateTime y4 = x.AddMilliseconds(1);
            DateTime y5 = x.AddMinutes(4);
            DateTime y6 = x.AddMonths(3);
            DateTime y7 = x.AddSeconds(1);
            DateTime y8 = x.AddTicks(900);
            DateTime y9 = x.AddYears(10);
            //DateTime y10 = x.Subtract(TimeSpan);
            TimeSpan y11 = x.Subtract(d);

            Console.WriteLine(x);
            //Console.WriteLine(y1);
            Console.WriteLine(y2);
            Console.WriteLine(y3);
            Console.WriteLine(y4);
            Console.WriteLine(y5);
            Console.WriteLine(y6);
            Console.WriteLine(y7);
            Console.WriteLine(y8);
            Console.WriteLine(y9);
            //Console.WriteLine(y10);
            Console.WriteLine(y11);
        }
    }
}
