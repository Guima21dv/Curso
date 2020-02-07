using sec16_multicast_delegates.Service;
using System;

namespace sec16_multicast_delegates
{

    delegate void BinaryNumericOperartion(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperartion op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;

            op.Invoke(a, b);
            Console.ReadLine();
        }
    }
}
