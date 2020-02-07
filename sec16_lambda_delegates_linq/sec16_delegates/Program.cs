using sec16_delegates.Service;
using System;

namespace sec16_delegates
{

    delegate double BinaryNumericOperartion(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {

            double a = 10;
            double b = 12;

            BinaryNumericOperartion op = CalculationService.Sum;

            double result = op(a, b);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
