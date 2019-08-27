using System;
using System.Collections.Generic;
using System.Text;

namespace exemplos_figuras
{
    class Triangulo : Figura
    {
        public double a, b, c;

        public Triangulo(double a, double b, double c, string cor) : base(cor)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double area()
        {
            double p = (a + b + c) / 2.0;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public override double perimetro()
        {
            return a + b + c;
        }
    }
}
