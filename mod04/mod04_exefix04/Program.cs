using System;
using System.Globalization;
using System.Collections.Generic;

namespace mod04_exefix04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, pos;
            string cpf, nome;
            double salario;
            List<Funcionario> list = new List<Funcionario>();


            Console.Write("Quantos funcionários serão cadastrados? ");
            n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Dados do " + i + "º funcionário: ");
                Console.Write("CPF: ");
                cpf = Console.ReadLine();
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                Console.Write("Salário: ");
                
                salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                pos = list.FindIndex(x => x.cpf == cpf);
                Console.WriteLine();
                if (pos != -1)
                {
                    Console.WriteLine("CPF JÁ CADASTRADO!");
                }
                else
                {
                    list.Add(new Funcionario(cpf, nome, salario));
                }
            }
            cpf = "";
            Console.Write("Digite o CPF do funcionário que terá aumento: ");
            cpf = Console.ReadLine();
            pos = list.FindIndex(x => x.cpf == cpf); //x => x.cpf == cpf é uma expressão LAMBDA que significa, x para todo x.cpf que é igual a cpf
            if(pos == -1)
            {
                Console.WriteLine("CPF INEXISTENTE!");
            }
            else
            {
                Console.Write("\nDigite a porcentagem de aumento: ");
                list[pos].aumentoSalario(
                        double.Parse(Console.ReadLine(),
                            CultureInfo.InvariantCulture)
                    );
            }
            Console.WriteLine("\nListagem atualizada de funcionários: ");
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());

            }
            Console.ReadLine();
        }
    }
}
