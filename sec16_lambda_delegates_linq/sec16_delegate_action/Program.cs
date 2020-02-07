using sec16_delegate_action.Entities;
using System;
using System.Collections.Generic;

namespace sec16_delegate_action
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

            //list.ForEach(UpdatePrice);
            list.ForEach(p => p.Price += p.Price * 0.1);



            foreach(Product p in list)
            {
                Console.WriteLine(p);
            }
            Console.ReadLine();
        }

        public static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}
