using System;
using System.Collections.Generic;
using System.Text;

namespace sec10_exe_fix_contribuinte.Entities
{
    abstract class Contribuinte
    {
        public string Nome { get; set; }

        public double RendaAnual { get; set; }

        protected Contribuinte(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public abstract double Imposto();
    }
}
