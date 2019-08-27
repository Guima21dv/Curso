using System;
using sec11_criando_excecoes.Entities.Exceptions;
using sec11_criando_excecoes.Entities;

namespace sec11_criando_excecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number: ");

                int room = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/mm/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/mm/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());


                Reservation reservation = new Reservation(room, checkIn, checkOut);
                Console.WriteLine(reservation.ToString());

                Console.WriteLine();

                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Check-in date (dd/mm/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/mm/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());


                //DateTime now = DateTime.Now;
                //if(checkIn < now || checkOut < now)
                //{
                //    Console.WriteLine("Erro in reservation: reservation dates for update must be future dates.");
                //}
                //else if(checkOut <= checkIn)
                //{
                //    Console.WriteLine("Error in reservation: Check-out needs to be after check-in.");
                //}
                //else
                //{
                //    reservation.UpdateDates(checkIn, checkOut);
                //    Console.WriteLine("Reservation: " + reservation);
                //}
                Console.WriteLine("Reservation: " + reservation);
                Console.ReadLine();
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
        }
    }
}
