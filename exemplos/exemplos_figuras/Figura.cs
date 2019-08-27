using System;
using System.Collections.Generic;
using System.Text;

namespace exemplos_figuras
{
    abstract class Figura
    {
        public string cor { get; set; }

        public Figura(string cor)
        {
            this.cor = cor;
        }
        public abstract double area();
        public abstract double perimetro();
    }
}
