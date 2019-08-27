using System;
using System.Collections.Generic;
using System.Globalization;
using sec10_exe_fix_contribuinte.Entities;

namespace sec10_exe_fix_contribuinte
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double sum = 0;
            List<Contribuinte> list = new List<Contribuinte>();

            Console.Write("Enter the number of tax payers: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double faturamento_anual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double despesas_saude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new PessoaFisica(name, faturamento_anual, despesas_saude));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int funcionarios = int.Parse(Console.ReadLine());
                    list.Add(new PessoaJuridica(name, faturamento_anual, funcionarios));
                }
            }

            Console.WriteLine("\nTAXES PAID:");
            foreach (Contribuinte cont in list)
            {
                Console.WriteLine(cont.ToString());
                sum += cont.Imposto();
            }

            Console.WriteLine("\nTOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();


        }
    }
}
