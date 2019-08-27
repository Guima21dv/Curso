using System;

namespace mod04_exefix02 { 
    class Program
    {
        static void Main(string[] args)
        {
            Quarto[] quartos = new Quarto[10];
            Console.Write("Quantos aluguéis serão registrados? ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Dados do " + i + "° aluguel: ");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int pos = int.Parse(Console.ReadLine());
                quartos[pos] = new Quarto(nome, email);
            }
            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if (quartos[i] != null)
                {
                    Console.WriteLine(i + ": " + quartos[i]);
                }
            }

            Console.ReadLine();

        }

    }
}   

