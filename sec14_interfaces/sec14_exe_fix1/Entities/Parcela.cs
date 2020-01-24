using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace sec14_exe_fix1.Entities
{
    public class Parcela
    {
        public DateTime DataVencimento { get; private set; }
        public double ValorParcela { get; private set; }

        public Parcela(DateTime dataVencimento, double valorParcela)
        {
            DataVencimento = dataVencimento;
            ValorParcela = valorParcela;
        }

        public override string ToString()
        {
            return $"{DataVencimento.ToString("dd/MM/yyy")} - {ValorParcela.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
