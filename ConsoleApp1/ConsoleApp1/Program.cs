using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número e descubra seu fatorial: ");
            int n = int.Parse(Console.ReadLine());
            fatorial(n);

        }
        public static void fatorial(int n)
        {
            long fatorial = 1;
            for (int i = 1; i < n; i++)
            {
                fatorial += fatorial * i;
            }
            Console.WriteLine(fatorial);
            Console.Read();
        }
    }
}
