using System;
using System.Globalization;

namespace sec10_exercicio_employee.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public Double ValuePerHour { get; set; }

        public Employee()
        {
        }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }

        public override string ToString()
        {
            return Name + " - $ " + Payment().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
