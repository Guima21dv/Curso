using System;
using sec15_topicos_especiais_pt2.Extensions;

namespace sec15_topicos_especiais_pt2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2018, 11, 16, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}
