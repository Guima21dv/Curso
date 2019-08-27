using System;
using sec10_heranca_polimorfismo_aula.Entities;

namespace sec10_heranca_polimorfismo_aula
{
    class Program
    {
        static void Main(string[] args)
        {
            //Account acc = new Account(1001, "Alex", 0.0);
            //BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            ////UPCASTING

            //Account acc1 = bacc;
            //Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            //Account acc3 = new SavingsAccount(1004, "Ana", 0.0, 0.01);
            ////DOWNCASTING

            ////BusinessAccount bacc2 = (BusinessAccount)acc2;
            //if (acc3 is BusinessAccount)
            //{
            //    BusinessAccount bacc3 = (BusinessAccount)acc3;
            //}

            ////SYNTAX ALTERNATIVA PARA CASTING

            //bacc = acc2 as BusinessAccount;

            ////BusinessAccount bacc3 = (BusinessAccount)acc3;//isso gera erro em tempo de execução



            ////SOBREPOSIÇÃO OU SOBRECRITA(VIRTUAL OVERRIDE
            Account acc1 = new Account(1001, "Joao", 100.0);
            Account acc2 = new SavingsAccount(1002, "Maria", 500.0, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);

            Console.ReadLine();

        }
    }
}
