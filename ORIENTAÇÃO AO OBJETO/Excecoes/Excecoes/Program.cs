using System;
using Excecoes.Entities;
using Excecoes.Entities.Exceptions;

namespace Excecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine();
                Console.Write("Room number: ");
                int numbeRoom = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());


                Reservation reservation = new Reservation(numbeRoom, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:");

                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

            }

            catch (DomainException e)
            {
                Console.WriteLine("Erro in reservation: " + e.Message);
            }

            Console.WriteLine();

            //metodo retorno string apenas para fins de estudo essa é só ruim!!
            //Console.WriteLine();
            //Console.Write("Room number: ");
            //int numbeRoom = int.Parse(Console.ReadLine());
            //Console.Write("Check-in date (dd/MM/yyyy): ");
            //DateTime checkIn = DateTime.Parse(Console.ReadLine());
            //Console.Write("Check-out date (dd/MM/yyyy): ");
            //DateTime checkOut = DateTime.Parse(Console.ReadLine());

            //if (checkOut <= checkIn)
            //{
            //    Console.WriteLine("Erro in reservation: Check-out date must be after check-in");
            //}
            //else
            //{
            //    Reservation reservation = new Reservation(numbeRoom, checkIn, checkOut);
            //    Console.WriteLine("Reservation: " + reservation);

            //    Console.WriteLine();
            //    Console.WriteLine("Enter data to update the reservation:");

            //    Console.Write("Check-in date (dd/MM/yyyy): ");
            //    checkIn = DateTime.Parse(Console.ReadLine());
            //    Console.Write("Check-out date (dd/MM/yyyy): ");
            //    checkOut = DateTime.Parse(Console.ReadLine());

            //    string error = reservation.UpdateDates(checkIn, checkOut);

            //    if (error != null)
            //    {
            //        Console.WriteLine("Error in reservation: " + error);
            //    }

            //    else
            //    {

            //        Console.WriteLine("Reservation: " + reservation);
            //    }
            //}


            Console.WriteLine();

            //solução muito ruim apenas para fins de estudo!!!
            //Console.Write("Room number: ");
            //int numbeRoom = int.Parse(Console.ReadLine());
            //Console.Write("Check-in date (dd/MM/yyyy): ");
            //DateTime checkIn = DateTime.Parse(Console.ReadLine());            
            //Console.Write("Check-out date (dd/MM/yyyy): ");
            //DateTime checkOut = DateTime.Parse(Console.ReadLine());

            //if (checkOut <= checkIn)
            //{
            //    Console.WriteLine("Erro in reservation: Check-out date must be after check-in");
            //}
            //else
            //{
            //    Reservation reservation = new Reservation(numbeRoom, checkIn, checkOut);
            //    Console.WriteLine("Reservation: " + reservation);

            //    Console.WriteLine();
            //    Console.WriteLine("Enter data to update the reservation:");

            //    Console.Write("Check-in date (dd/MM/yyyy): ");
            //    checkIn = DateTime.Parse(Console.ReadLine());
            //    Console.Write("Check-out date (dd/MM/yyyy): ");
            //    checkOut = DateTime.Parse(Console.ReadLine());

            //    DateTime now = DateTime.Now;
            //    if (checkIn < now || checkOut < now)
            //    {
            //        Console.WriteLine("Erro in reservation: Reservation dates for update must be future dates");
            //    }
            //    else if (checkOut <= checkIn)
            //    {
            //        Console.WriteLine("Erro in reservation: Check-out date must be after check-in");
            //    }
            //    else
            //    {
            //        reservation.UpdateDates(checkIn, checkOut);
            //        Console.WriteLine("Reservation: " + reservation);
            //    }
            //}



        }
    }
}
