using System;

namespace sec7_prop_ops_datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(d);// Imprimin do objeto inteiro, com todas as informações 
            //Impressão das propriedades do objeto DateTime.
            Console.WriteLine("1)Date: {0}", d.Date);
            Console.WriteLine("2)Day: {0}", d.Day);
            Console.WriteLine("3)DayOfWeek: {0}", d.DayOfWeek);
            Console.WriteLine("4)DayOfYear: {0}", d.DayOfYear);
            Console.WriteLine("5)Hour: {0}", d.Hour);
            Console.WriteLine("6)Kind: {0}", d.Kind);
            Console.WriteLine("7)Millisecond: {0}", d.Millisecond);
            Console.WriteLine("8)Minute: {0}", d.Minute);
            Console.WriteLine("9)Month: {0}", d.Month);
            Console.WriteLine("10)Second: {0}", d.Second);
            Console.WriteLine("11)Ticks: {0}", d.Ticks);
            Console.WriteLine("12)TimeOfDay: {0}", d.TimeOfDay);
            Console.WriteLine("13)Year: {0}", d.Year);

            DateTime d2 = new DateTime(2001, 8, 15, 13, 45, 58);
            Console.WriteLine(d2.ToLongDateString());
            Console.WriteLine(d2.ToLongTimeString());
            Console.WriteLine(d2.ToShortDateString());
            Console.WriteLine(d2.ToString());
            string format1 = d2.ToString("yyyy-MM-dd HH:mm:ss");

            Console.WriteLine();

            //Operações com DateTime

            Console.WriteLine(d2.AddHours(2));
            Console.WriteLine(d2.AddDays(7));
            Console.WriteLine(d2.AddMinutes(3));
            Console.WriteLine(d2.AddMonths(12));//d2 = 15/08/2002
            DateTime d3 = new DateTime(2000, 10, 12);
            TimeSpan t1 = d2.Subtract(d3); //307.10........
            Console.WriteLine(t1);
            Console.ReadLine();
        }
    }
}
