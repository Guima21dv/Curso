using System;
using System.Globalization;

using System.Collections.Generic;
using sec14_interfaces_Heranca_x_Interface.Enums;
using sec14_interfaces_Heranca_x_Interface.Entities;

namespace sec14_interfaces_Heranca_x_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape s1 = new Circle() { Radius = 2.0, Color = Color.Blue };
            IShape s2 = new Rectangle() { Width = 3.5, Height = 4.2, Color = Color.Black };
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.ReadLine();
        }
    }
}
