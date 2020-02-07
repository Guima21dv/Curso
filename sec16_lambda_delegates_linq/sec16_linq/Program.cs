using System;
using System.Linq;

namespace sec16_linq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]{ 2, 3, 4, 5 };

            var result = numbers.Where(x => x / 2 == 0).Select(x => x * 2);

            var result2 = (from number in numbers.OfType<int>()
                          where number / 2 == 0
                          select number * 2).ToList();


            foreach(int x in result2)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }
    }
}
