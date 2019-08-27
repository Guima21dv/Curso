using System;
using System.Collections.Generic;
using System.Text;

namespace sec10_heranca_polimorfismo_aula.Entities
{
    sealed class SavingsAccount : Account //´CLASSES SELADAS NÃO PODEM SER HERDADAS POR SUBCLASSES E MÉTODOS SELADOS NÃO PODEM SER SOBRESCRITOS(MAS TEM QUE SE UM MÉTODO QUE JÁ É SOBRESCRITO!)
    {
        public double InterestRate { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += InterestRate * Balance;
        }

        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}
