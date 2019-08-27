using System;
using System.Collections.Generic;
using System.Text;
using sec10_abstract_class2.Entities.Enums;
namespace sec10_abstract_class2.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape() { }
        protected Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
