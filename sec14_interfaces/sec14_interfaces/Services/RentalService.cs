using Sec14.Entities;
using sec14_interfaces.Services.Interfaces;
using System;
namespace Sec14.Services
{
    internal class RentalService
    {
        public double PricePerHour { get;private set; }
        public double PricePerDay { get; private set; }

        //private BrazilTaxService _brazilTaxService = new BrazilTaxService(); // FORMA INADEQUADA
        private readonly ITaxService _taxService;
        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            _taxService = taxService;
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

            double tax = _taxService.Tax(basicPayment);
            c.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
