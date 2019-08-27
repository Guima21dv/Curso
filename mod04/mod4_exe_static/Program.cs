using System;
using System.Globalization;

namespace mod4_exe_static
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cot = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor a ser pag em reais = " + ConversorDeMoeda.converte(cot, qtd).ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
