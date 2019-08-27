using System;
using System.Globalization;
using sec10_abstract_class2.Entities.Enums;
using System.Collections.Generic;
using System.Text;

namespace sec10_abstract_class2.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }


        public Rectangle() { }

        public Rectangle(Color color, double width, double height) : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
