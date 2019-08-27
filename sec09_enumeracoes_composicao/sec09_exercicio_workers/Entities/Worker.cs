using System;
using System.Collections.Generic;
using sec09_exercicio_workers.Entities.Enums;

namespace sec09_exercicio_workers.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public List<HourContract> Contracts { get; private set; } = new List<HourContract>();
        public Department Department { get; set; }

        public Worker() { }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract) {
            this.Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            this.Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double total = BaseSalary;
            foreach (HourContract item in Contracts){
                if(item.Date.Month == month && item.Date.Year == year)
                {
                    total += item.TotalValue();
                }
            }
            return total;
        }
    }
}
