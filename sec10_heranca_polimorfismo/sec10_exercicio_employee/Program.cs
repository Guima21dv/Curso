using System;
using System.Globalization;
using sec10_exercicio_employee.Entities;
using System.Collections.Generic;
namespace sec10_exercicio_employee
{
    class Program
    {
        static void Main(string[] args)
        {
            //VARIÁVEIS
            int n, hours;
            string name;
            double valuePerHour, additionalCharge;
            List <Employee> emp_list = new List<Employee>();

            // --------------------------------------------------

            Console.Write("Enter the number of employees: ");
            n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Employee #{0} data: ", i);
                Console.Write("Outsourced (y/n)? ");
                char outsourced = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Hours: ");
                hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (outsourced == 'y')
                {
                    
                    Console.Write("Additional charge: ");
                    additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    emp_list.Add(new OutsourceEmployee(name, hours, valuePerHour, additionalCharge));

                }
                else
                { 
                    emp_list.Add(new Employee(name, hours, valuePerHour));
                }
               
            }
            Console.WriteLine("\nPAYMENTS:");
            foreach (Employee item in emp_list)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();
        }
    }
}
