using sec_16_exe_resolvido.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace sec_16_exe_resolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<Product> list = new List<Product>();

            using(StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] field = sr.ReadLine().Split(',');
                    list.Add(new Product(field[0], double.Parse(field[1], CultureInfo.InvariantCulture)));
                }
            }

            var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Average price = " + avg.ToString("F2", CultureInfo.InvariantCulture));

            var names = list.Where(x => x.Price < avg).OrderByDescending(x => x.Name).Select(x => x.Name);
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();
        }
    }
}
