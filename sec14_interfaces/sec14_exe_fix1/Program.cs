using sec14_exe_fix1.Entities;
using sec14_exe_fix1.Services;
using System;
using System.Globalization;

namespace sec14_exe_fix1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroContrato;
            DateTime dataContrato;
            double valorTotal;
            int numeroParcelas;
            
            try
            {
                Console.WriteLine("Forneça os dados do contrato");
                Console.Write("Número do contrato: ");
                numeroContrato = int.Parse(Console.ReadLine());
                Console.Write("Data (dd/MM/aaaa): ");
                dataContrato = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.Write("Valor do contrato: ");
                valorTotal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Número de parcelas: ");
                numeroParcelas = int.Parse(Console.ReadLine());
                Contrato contrato = new Contrato(numeroContrato, dataContrato, valorTotal, numeroParcelas);
                ContratoService service = new ContratoService(new PayPalPaymentService());
                service.GerarParcelas(contrato);
                Console.WriteLine();
                Console.WriteLine(contrato.ToString());
                Console.ReadLine();
                
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro durante a execução do programa:/n{ex.Message}");
            }
            

        }
    }
}
