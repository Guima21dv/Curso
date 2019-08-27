using System;
using System.Globalization;
using System.Collections.Generic;
using sec10_exe_fix_product.Entities;


namespace sec10_exe_fix_product
{
    class Program
    {
        static void Main(string[] args)
        {
            //VARIÁVEIS
            int n;
            List<Product> list_prod = new List<Product>();

            //-------------------------------------------------------------------------------------------

            Console.Write("Enter the number of products: ");
            n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Product #{0} data:", i);
                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(ch == 'c')
                {
                    list_prod.Add(new Product(name, price));
                }
                else if (ch == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    list_prod.Add(new UsedProduct(name, price, manufactureDate));
                }
                else
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list_prod.Add(new ImportedProduct(name, price, customsFee));
                }
            }

            Console.WriteLine("\nPRICE TAGS: ");
            foreach (Product prod in list_prod)
            {
                Console.WriteLine(prod.PriceTag());
            }
            Console.ReadLine();
        }
    }
}
