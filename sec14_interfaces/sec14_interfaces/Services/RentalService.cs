using Sec14.Entities;
using System;
namespace Sec14.Services
{
    class RentalService
    {
        public double PricePerHour { get;private set; }
        public double PricePerDay { get; private set; }

        private BrazilTaxService _brazilTaxService = new BrazilTaxService(); // FORMA INADEQUADA
        public RentalService(double pricePerHour, double pricePerDay)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }

        public void ProcessInvoice(CarRental c)
        {
            TimeSpan Duration = c.Finish.Subtract(c.Start);

            double basicPayment = 0.0;
            if(Duration.TotalHours <= 12)
            {
                basicPayment = PricePerHour * Math.Ceiling(Duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(Duration.TotalDays);
            }
            c.Invoice = new Invoice(basicPayment, _brazilTaxService.Tax(basicPayment));
        }
    }
}
