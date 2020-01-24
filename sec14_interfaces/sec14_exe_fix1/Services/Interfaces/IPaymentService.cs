using System;
using System.Collections.Generic;
using System.Text;

namespace sec14_exe_fix1.Services.Interfaces
{
    public interface IPaymentService
    {
        double CalcularValorParcela(double valor, int meses);
    }
}
