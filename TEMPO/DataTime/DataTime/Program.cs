using System;
using System.Globalization;

namespace DataTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime data = DateTime.Parse("2000-08-15");
            DateTime data1 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime data2 = DateTime.Parse("15/08/2000 13:05:58");
            

            DateTime data3 = DateTime.ParseExact("2000-08-15","yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime data4 = DateTime.ParseExact("2000-08-15 13:05:58","yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);


            Console.WriteLine(data);
            Console.WriteLine(data1);
            Console.WriteLine(data2);
            Console.WriteLine(data3);
            Console.WriteLine(data4);

        //    DateTime data1 = new DateTime();
        //    DateTime data2 = new DateTime(2018, 11, 25);
        //    DateTime data3 = new DateTime(2018, 11, 25, 20, 45, 3);
        //    DateTime data4 = new DateTime(2018, 11, 25, 20, 45, 3, 500);

        //    DateTime data5 = DateTime.Now;
        //    DateTime data6 = DateTime.Today;
        //    //horario universal
        //    DateTime data7 = DateTime.UtcNow;



        //    Console.WriteLine(data1);
        //    Console.WriteLine(data2);
        //    Console.WriteLine(data3);
        //    Console.WriteLine(data4);
        //    Console.WriteLine(data5);
        //    Console.WriteLine(data6);
        //    Console.WriteLine(data7);
        }
    }
}
