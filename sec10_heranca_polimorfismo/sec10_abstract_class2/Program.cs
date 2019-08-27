using System;
using System.Globalization;
using sec10_abstract_class2.Entities;
using sec10_abstract_class2.Entities.Enums;
using System.Collections.Generic;

namespace sec10_abstract_class2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Color color;

            Console.Write("Enter the number of shapes: ");
            n = int.Parse(Console.ReadLine());
            List<Shape> list = new List<Shape>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Shape #{0} data:", i);
                Console.Write("Rectangle or circle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                color = Enum.Parse<Color>(Console.ReadLine());
                if(ch == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(color, width, height));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));
                }
            }

            Console.WriteLine("\nSHAPE AREAS: ");
            foreach(Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.ReadLine();

        }
    }
}
