using sec16_delegate_predicate.Entities;
using System;
using System.Collections.Generic;

namespace sec16_delegate_predicate
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

            list.RemoveAll(p => p.Price >= 100.0); //ou list.RemoveAll(ProductTeste);
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
            Console.ReadLine();
        }

        public static bool ProductTeste(Product p)
        {
            return p.Price >= 100.00;
        }
    }
}
