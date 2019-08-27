using System;
using sec10_abstract_class2.Entities.Enums;
using System.Collections.Generic;
using System.Text;

namespace sec10_abstract_class2.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
