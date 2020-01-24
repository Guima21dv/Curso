using sec14_exe_fix1.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace sec14_exe_fix1.Entities
{
    public class Contrato
    {
        public int NumeroContrato { get; private set; }
        public DateTime DataContrato { get; private set; }
        public double ValorTotal { get; private set; }
        public List<Parcela> Parcelas { get; private set; }
        public int QuantidadeParcelas { get; private set; }

        public Contrato(int numeroContrato, DateTime dataContrato, double valorTotal, int quantidadeParcelas)
        {
            NumeroContrato = numeroContrato;
            DataContrato = dataContrato;
            ValorTotal = valorTotal;
            QuantidadeParcelas = quantidadeParcelas;
        }

        public void GerarParcelas()
        {
            for(int i = 0; i < QuantidadeParcelas; i++)
            {

            }
        }

        public override string ToString()
        {
            string output = "Installments:";
            
            foreach(Parcela p in Parcelas)
            {
                output += $"\n{p.ToString()}";
            }

            return output;
            

        }
    }
}
