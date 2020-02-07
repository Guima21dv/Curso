using sec16_delegate_func.Entities;
using System.Linq;
using System;
using System.Collections.Generic;

namespace sec16_delegate_func
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tabled", 350.00));
            list.Add(new Product("HD Case", 80.90));

            Func<Product, string> func = NameUpper; 

            List<string> result = list.Select(NameUpper).ToList();

            foreach(Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}
