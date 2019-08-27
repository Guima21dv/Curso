using System;

namespace sec7_datetimekind_iso8601
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2000, 8, 15, 13,5,58,DateTimeKind.Local);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d1 Kind: " + d1.Kind);
            Console.WriteLine("d1 to local: " + d1.ToLocalTime());
            Console.WriteLine("d1 to UTC: " + d1.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d2 kind: " + d2.Kind);
            Console.WriteLine("d2 to local: " + d2.ToLocalTime());
            Console.WriteLine("d2 to UTC: "+ d2.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d3: " + d3);
            Console.WriteLine("d3 kind: " + d3.Kind);
            Console.WriteLine("d3 to local: " + d3.ToLocalTime());
            Console.WriteLine("d3 to UTC: " + d3.ToUniversalTime());
            Console.WriteLine();
            DateTime d4 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d5 = DateTime.Parse("2000-08-15T13:05:58Z");
            Console.WriteLine("d4: " + d4);
            Console.WriteLine("d4 kind: " + d4.Kind);
            Console.WriteLine("d4 to local: " + d4.ToLocalTime());
            Console.WriteLine("d4 to UTC: "+ d4.ToUniversalTime());
            Console.WriteLine();
            Console.WriteLine("d5: " + d5);
            Console.WriteLine("d5 kind: " + d5.Kind);
            Console.WriteLine("d5 to local: " + d5.ToLocalTime());
            Console.WriteLine("d5 to uct: " + d5.ToUniversalTime());
            Console.ReadLine();

        }
    }
}
