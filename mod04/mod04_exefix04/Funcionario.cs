using System;
using System.Collections.Generic;
using System.Globalization;

namespace mod04_exefix04
{
    class Funcionario
    {
        public string cpf { get; private set; }
        public string nome { get; set; }
        public double salario { get; private set; }

        public Funcionario(string cpf, string nome, double salario)
        {
            this.cpf = cpf;
            this.nome = nome;
            this.salario = salario;
        }

        public void aumentoSalario(double percent)
        {
            salario = salario * (percent/100 + 1.00);
        }
        public override string ToString()
        {
            return cpf + ", " + nome + ", " + salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
