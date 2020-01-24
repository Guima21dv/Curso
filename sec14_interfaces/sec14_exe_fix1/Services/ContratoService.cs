using sec14_exe_fix1.Entities;
using sec14_exe_fix1.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace sec14_exe_fix1.Services
{
    public class ContratoService
    {
        private readonly IPaymentService _paymentService;

        public ContratoService(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }
        public void GerarParcelas(Contrato contrato)
        {
            double baseCalc = contrato.ValorTotal / contrato.QuantidadeParcelas;
            for (int i = 1; i <= contrato.QuantidadeParcelas; i++)
            {
                DateTime data = contrato.DataContrato.AddMonths(i);
                double valorParcela = baseCalc * 
                Parcela parcela = new Parcela(data, ) );
            }
        }
    }
}
