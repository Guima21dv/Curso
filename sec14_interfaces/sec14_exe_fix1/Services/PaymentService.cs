using sec14_exe_fix1.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace sec14_exe_fix1.Services
{
    internal class PayPalPaymentService : IPaymentService
    {
        private const double PorcentagemTaxa = 0.02;
        private const double JuroMensal = 0.01;

        public double CalcularValorParcela(double valor, int mes)
        {
            return valor * JuroMensal * mes;
        }
    }
}
