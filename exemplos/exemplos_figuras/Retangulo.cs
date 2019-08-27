using System;
using System.Collections.Generic;
using System.Text;

namespace exemplos_figuras
{
    class Retangulo : Figura
    {
        public double a, b;

        public Retangulo(double a, double b, string cor) : base(cor)
        {
            this.a = a;
            this.b = b;
        
        }

        public override double area()
        {
            return a * b;
        }
        public override double perimetro()
        {
            return 2 * (a + b);
        }
    }
}
