using System;
using System.Globalization;

namespace mod04_exefix01
{
    class ContaBancaria
    {
        //Declaração de atributos
        public string Num_conta { get; private set; }
        public string Nome_titular { get; set; }
        public double Saldo { get; private set; }

        protected const int TARIFA = 5;

        public ContaBancaria(string num_conta, string nome_titular)
        {
            this.Num_conta = num_conta;
            this.Nome_titular = nome_titular;
            Console.WriteLine("\nDados da conta:");
            Console.WriteLine(ToString());
        }
        public ContaBancaria(string num_conta, string nome_titular, double saldo)
        {
            this.Num_conta = num_conta;
            this.Nome_titular = nome_titular;
            this.Saldo = saldo;
            Console.WriteLine("\nDados da conta:");
            Console.WriteLine(ToString());
        }
        public void depositar(double dep)
        {
            Saldo += dep;
            Console.WriteLine("Conta Atualizada: ");
            Console.WriteLine(ToString());
        }
        public void saque(double saq)
        {   
            Saldo -= saq + TARIFA;
            Console.WriteLine("Conta Atualizada: ");
            Console.WriteLine(ToString());
        }
        public override string ToString()
        {
            return "Conta: " + Num_conta + ", Titular: " + Nome_titular + ", Saldo: R$ " 
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
