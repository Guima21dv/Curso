using System;
using System.Globalization;
using System.Collections.Generic;
using sec10_abstract_class.Entities;
namespace sec10_abstract_class
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> acc_list = new List<Account>();
            acc_list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            acc_list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            acc_list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
            acc_list.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));

            double sum = 0.0;

            foreach(Account acc in acc_list)
            {
                sum += acc.Balance;
            }

            Console.WriteLine(sum.ToString("F2", CultureInfo.InvariantCulture));

            foreach(Account acc in acc_list)
            {
                acc.Withdraw(10.0);
            }
            foreach(Account acc in acc_list)
            {
                Console.WriteLine("Conta: {0}, saldo atualizado: ${1}", acc.Number, acc.Balance);
            }
        }
    }
}
