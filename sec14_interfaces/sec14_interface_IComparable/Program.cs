using sec14_interface_IComparable.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace sec14_interface_IComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\gguimaraes\source\repos\curso csharp\Curso\sec14_interfaces\temp.csv";
            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    List<Employee> nomes = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        nomes.Add(new Employee(sr.ReadLine()));
                    }
                    nomes.Sort();
                    foreach(Employee emp in nomes)
                    {
                        Console.WriteLine(emp);
                    }
                    Console.ReadLine();
                }
            }catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
