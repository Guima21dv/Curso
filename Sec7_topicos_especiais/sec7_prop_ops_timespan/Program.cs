using System;

namespace sec7_prop_ops_timespan
{
    class Program
    {
        static void Main(string[] args)
        {//PROPRIEDADES DO TIMESPAN
            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);

            Console.WriteLine();

            TimeSpan t4 = new TimeSpan(2, 3, 5, 7, 11);
            Console.WriteLine("Days: {0}", t4.Days);
            Console.WriteLine("Hours: {0}", t4.Hours);
            Console.WriteLine("Minutes: {0}", t4.Minutes);
            Console.WriteLine("Seconds: {0}", t4.Seconds);
            Console.WriteLine("Milliseconds: {0}", t4.Milliseconds);
            Console.WriteLine("Ticks: {0}", t4.Ticks);
            Console.WriteLine();
            Console.WriteLine("TotalDays: {0}", t4.TotalDays);
            Console.WriteLine("TotalHours: {0}", t4.TotalHours);
            Console.WriteLine("TotalMinutes: {0}", t4.TotalMinutes);
            Console.WriteLine("TotalSeconds: {0}", t4.TotalSeconds);
            Console.WriteLine("TotalMiliseconds: {0}", t4.TotalMilliseconds);
            Console.WriteLine();
            Console.WriteLine();

            //OPERAÇÕES COM TIMESPAN
            TimeSpan t5 = new TimeSpan(1,30,10);
            TimeSpan t6 = new TimeSpan(0, 10, 5);
            TimeSpan sum = t5.Add(t6);
            TimeSpan subtract = t5.Subtract(t6);
            TimeSpan mult = t5.Multiply(2);
            TimeSpan divide = t5.Divide(2);
            Console.WriteLine();
            Console.WriteLine(sum);
            Console.WriteLine(subtract);
            Console.WriteLine(mult);
            Console.WriteLine(divide);
            Console.ReadLine();
        }
    }
}
