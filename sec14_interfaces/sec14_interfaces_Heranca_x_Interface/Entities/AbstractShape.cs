using sec14_interfaces_Heranca_x_Interface.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace sec14_interfaces_Heranca_x_Interface.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
