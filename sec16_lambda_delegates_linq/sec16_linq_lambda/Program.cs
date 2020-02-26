using System;
using System.Linq;
using System.Collections.Generic;
using sec16_linq_lambda.Entities;
namespace sec16_linq_lambda
{
    class Program
    {
        static void Print<T>(string title, IEnumerable<T> collection)
        {
            Console.WriteLine(title);
            foreach(T item in collection)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };

            string[] productNames = new string[] {"Computer", "Hammer", "TV", "Notebook","Saw", "Tabist",
            "Camera", "Printer","MacBook","Sound Bar", "Level"};
            double[] productPrices = new double[] { 1100, 90, 1700, 1300, 80, 700, 700, 350, 1800, 700, 70 };
            Category[] productCategories = new Category[] { c2, c1, c3, c2, c1, c2, c3, c3, c2, c3, c1 };
            


            List<Product> products = new List<Product>() {
                new Product(){ Id = 1, Name = "Computer", Price = 1100.00, Category = c2},
                new Product(){ Id = 2, Name = "Hammer", Price = 90.00, Category = c1},
                new Product(){ Id = 3, Name = "TV", Price = 1700.00, Category = c3},
                new Product(){ Id = 4, Name = "Notebook", Price = 1300.00, Category = c2},
                new Product(){ Id = 5, Name = "Saw", Price = 80.00, Category = c1},
                new Product(){ Id = 6, Name = "Tabist", Price = 700.00, Category = c2},
                new Product(){ Id = 7, Name = "Camera", Price = 700.00, Category = c3},
                new Product(){ Id = 8, Name = "Printer", Price = 350.00, Category = c3},
                new Product(){ Id = 9, Name = "MacBook", Price = 1800.00, Category = c2},
                new Product(){ Id = 10, Name = "Sound Bar", Price = 700.00, Category = c3},
                new Product(){ Id = 11, Name = "Level", Price = 70.00, Category = c1},

            };

            //IEnumerable<Product> r1 = products.Where(x => x.Category.Tier == 1 && x.Price < 900.0);
            var r1 =
                from p in products
                where p.Category.Id == 1 && p.Price < 900.00
                select p;
            Print("TIER 1 AND PRICE < 900: ", r1);
            Console.WriteLine();
            //var r2 = products.Where(x => x.Category.Name == "Tools").Select(x => x.Name);
            var r2 =
                from p in products
                where p.Category.Name == "Tools"
                select p.Name;
            Print("NAMES OF PRODUCTS FROM TOOLS:", r2);
            //var r3 = products.Where(x => x.Name[0] == 'C').Select(x => new { x.Name, x.Price, CategoryName = x.Category.Name });
            var r3 =
                from p in products
                where p.Name[0] == 'C'
                select new { p.Name, p.Price, CategoryName = p.Category.Name };
            Print("NAME STARTED WITH 'C' AND ANONYMOUS OBJECT:", r3);
            //var r4 = products.Where(x => x.Category.Tier == 1).OrderBy(x => x.Price).ThenBy(x => x.Name);
            var r4 = from p in products
                     where p.Category.Tier == 1
                     orderby p.Name
                     orderby p.Price
                     select p;

            Print("TIER 1 ORDER BY PRICE THEN BY NAME:", r4);
            //var r5 = r4.Skip(2).Take(4);
            var r5 = (from p in r4
                      select p).Skip(2).Take(4);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME:", r5);
            var r6 = products.First();
            Console.WriteLine("First teste 1: " + r6);
            var r7 = products.Where(x => x.Price > 3000).FirstOrDefault();
            Console.WriteLine("First teste2: "+ r7);
            var r8 = products.Where(x => x.Id == 3).SingleOrDefault();
            Console.WriteLine("Single or default teste1: " + r8);
            var r9 = products.Where(x => x.Id == 44).SingleOrDefault();
            Console.WriteLine("Single or default teste2: " + r9);
            var r10 = products.Max(x => x.Price);
            Console.WriteLine("MAX Price" + r10);
            var r11 = products.Min(x => x.Price);
            Console.WriteLine("MIN Price" + r11);
            var r12 = products.Where(x => x.Category.Id == 1).Sum(x => x.Price);
            Console.WriteLine("Category 1 SUM Prices: " + r12);
            var r13 = products.Where(x => x.Category.Id == 1).Average(x => x.Price);
            Console.WriteLine("Category 1 Average prices: " + r13);
            var r14 = products.Where(x => x.Category.Id == 5).Select(x => x.Price).DefaultIfEmpty().Average();
            Console.WriteLine("Category 5 Average prices secure: " + r14);
            var r15 = products.Where(x => x.Category.Id == 1).Select(x => x.Price).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine("Category 1 aggregate sum: " + r15);
            //var r16 = products.GroupBy(x => x.Category);
            var r16 = from p in products
                      group p by p.Category;
            foreach(IGrouping<Category, Product> group in r16)
            {
                Console.WriteLine("Category " + group.Key.Name + ": ");
                foreach(Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }




            //for(int i = 1; i <= productNames.Length; i++)
            //{
            //    products.Add(new Product()
            //    {
            //        Id = i,
            //        Name = productNames[i - 1],
            //        Price = productPrices[i - 1],
            //        Category = productCategories[i - 1]
            //    });
            //}
        }
    }
}
