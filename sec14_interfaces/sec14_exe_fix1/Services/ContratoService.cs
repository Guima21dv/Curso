using sec14_exe_fix1.Entities;
using sec14_exe_fix1.Services.Interfaces;
using System;

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
            double baseCalculo = contrato.ValorTotal / contrato.QuantidadeParcelas;
            double calculoJuros = 0;
            double valorTotal = 0;
            for (int i = 1; i <= contrato.QuantidadeParcelas; i++)
            {
                DateTime data = contrato.DataContrato.AddMonths(i);
                calculoJuros = baseCalculo + _paymentService.CalcularJuros(baseCalculo, i);
                valorTotal = calculoJuros + _paymentService.CalcularTaxa(calculoJuros);
                contrato.AdicionarParcela(new Parcela(data, valorTotal));
            }
        }
    }
}
