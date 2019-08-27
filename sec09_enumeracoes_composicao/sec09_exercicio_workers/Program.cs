using System;
using System.Globalization;
using sec09_exercicio_workers.Entities.Enums;
using sec09_exercicio_workers.Entities;

namespace sec09_exercicio_workers
{
    class Program
    {
        static void Main(string[] args)
        {
            string department_name, worker_name, worker_level;
            double worker_salary, value;
            int n, duration;
            DateTime contract_date;
            Worker worker;
            

            Console.Write("Enter department's name: ");
            department_name = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            worker_name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            worker_level = Console.ReadLine();
            Console.Write("Base salary: ");
            worker_salary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            worker = new Worker(worker_name, Enum.Parse<WorkerLevel>(worker_level), worker_salary, new Department(department_name));

            Console.Write("How many contracts to this worker? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter #{0} contract data: ", i);
                Console.Write("Date (DD/MM/YYYY): ");
                contract_date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                duration = int.Parse(Console.ReadLine());
                worker.AddContract(new HourContract(duration, value, contract_date));
            }
            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string reference_date = Console.ReadLine();
            int month = int.Parse(reference_date.Substring(0, 2));
            int year = int.Parse(reference_date.Substring(3));
            Console.WriteLine("Name: {0}", worker.Name);
            Console.WriteLine("Department: {0}", worker.Department.Name);
            Console.WriteLine("Income for {0}: {1}", reference_date,
                worker.Income(month, year).ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();

        }
    }
}
