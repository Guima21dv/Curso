using System;
using System.Collections.Generic;
using System.Text;

namespace sec14_exe_fix1.Services.Interfaces
{
    public interface IPaymentService
    {
        double CalcularJuros(double valor, int mes);
        double CalcularTaxa(double valor);
    }
}
