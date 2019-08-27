using System.Globalization;

namespace sec10_exe_fix_contribuinte.Entities
{
    class PessoaJuridica : Contribuinte
    {
        public int Funcionarios { get; set; }

        public PessoaJuridica(string nome, double rendaAnual, int funcionarios) : base(nome, rendaAnual)
        {
            Funcionarios = funcionarios;
        }

        public override double Imposto()
        {
            if(Funcionarios <= 10)
            {
                return RendaAnual * 0.16;
            }
            else
            {
                return RendaAnual * 0.14;
            }
        }
        public override string ToString()
        {
            return Nome + ": $ " + Imposto().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
