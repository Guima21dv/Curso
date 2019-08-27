using System;
using System.Globalization;
using sec09_exe_prop01.Entities.Enums;
using sec09_exe_prop01.Entities;

namespace sec09_exe_prop01
{
    class Program
    {
        static void Main(string[] args)
        {
            //VARIÁVEIS
            string client_name, product_name, client_email;
            DateTime client_birth_date;
            OrderStatus os;
            Order order;
            double product_price;
            int product_quantity, n;
            // PROGRAM
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            client_name = Console.ReadLine();
            Console.Write("Email: ");
            client_email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            client_birth_date = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            os = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");

            order = new Order(
                DateTime.Now,
                os,
                new Client(client_name, client_email, client_birth_date)
                );

            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter #{0} item data:", i);
                Console.Write("Product name: ");
                product_name = Console.ReadLine();
                Console.Write("Product price: ");
                product_price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                product_quantity = int.Parse(Console.ReadLine());
                order.AddItem(
                    new OrderItem(
                            product_quantity,
                            new Product(product_name, product_price)
                            )
                        );
            }

            //SHOW IN OUTPUT
            Console.WriteLine();
            Console.WriteLine(order);
            Console.ReadLine();
        }
    }
}
