using sec14_exe_fix1.Services.Interfaces;

namespace sec14_exe_fix1.Services
{
    internal class PayPalPaymentService : IPaymentService
    {
        private const double PorcentagemTaxa = 0.02;
        private const double JuroMensal = 0.01;

        public double CalcularJuros(double valor, int mes)
        {
            return valor * JuroMensal * mes;
        }

        public double CalcularTaxa(double valor)
        {
            return valor * PorcentagemTaxa;
        }
    }
}
