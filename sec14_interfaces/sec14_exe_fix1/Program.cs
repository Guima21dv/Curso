using sec14_exe_fix1.Entities;
using System;
using System.Globalization;

namespace sec14_exe_fix1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int numeroContrato;
            DateTime dataContrato;
            double valorTotal;
            int numeroParcelas;
            
            try
            {
                Console.WriteLine("Enter contract data");
                Console.Write("Number: ");
                numeroContrato = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Date (dd/MM/yyyy)");
                dataContrato = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.WriteLine();
                Console.Write("Contract value: ");
                valorTotal = double.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Enter number of installments: ");
                numeroParcelas = int.Parse(Console.ReadLine());
                Contrato contrato = new Contrato(numeroContrato, dataContrato, valorTotal, numeroParcelas);
                Console.WriteLine(contrato.ToString());
                
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro durante a execução do programa:/n{ex.Message}");
            }
            

        }
    }
}
