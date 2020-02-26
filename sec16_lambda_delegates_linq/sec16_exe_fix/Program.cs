using sec16_exe_fix.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace sec16_exe_fix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            Console.Write("Enter salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employee> list = new List<Employee>();
            using(StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] data = sr.ReadLine().Split(',');
                    list.Add(new Employee(data[0], data[1], double.Parse(data[2], CultureInfo.InvariantCulture)));
                }
            }

        }
    }
}
