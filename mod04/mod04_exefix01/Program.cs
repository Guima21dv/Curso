using System;
using System.Globalization;

namespace mod04_exefix01
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, conta;
            char op;
            ContaBancaria ac;
            Console.Write("Digite o número da conta: ");
            conta = Console.ReadLine();
            Console.Write("Digite o nome do titular da conta: ");
            nome = Console.ReadLine();
            Console.Write("Deseja fazer um deposito inicial?(s/n) ");
            op = char.Parse(Console.ReadLine());
            if(op == 's')
            {
                Console.Write("Digite o valor do depósito inicial? ");
                double inic = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                ac = new ContaBancaria(conta, nome, inic);
            }
            else
            {
                ac = new ContaBancaria(conta, nome);
            }
            Console.Write("\nDigite o valor para deposito: ");
            ac.depositar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.Write("\nDigite o valor para saque: ");
            ac.saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
