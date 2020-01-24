using System;
using Sec14.Entities;
using System.Globalization;
using Sec14.Services;

namespace Sec14
{
    class Program
    {
        static void Main(string[] args)
        {
            CarRental carRental;
            DateTime StartTemp = new DateTime();
            DateTime ReturnTemp = new DateTime();
            string Model;
            double PricePerHour, PricePerDay;
            RentalService rentalService;

            Console.WriteLine("Enter rental data:");
            Console.Write("Car Model: ");
            Model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            StartTemp = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm", CultureInfo.InvariantCulture);
            Console.WriteLine("Finish (dd/MM/yyyy hh:mm): ");
            ReturnTemp = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm", CultureInfo.InvariantCulture);

            carRental = new CarRental(StartTemp, ReturnTemp, new Vehicle(Model));

            Console.Write("Enter price per hour: ");
            PricePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            PricePerDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            rentalService = new RentalService(PricePerHour, PricePerDay);
            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("INVOICE:");
            Console.WriteLine(carRental.Invoice);
        }
    }
}
