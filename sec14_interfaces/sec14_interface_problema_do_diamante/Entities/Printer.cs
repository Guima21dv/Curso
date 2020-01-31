using System;
using System.Collections.Generic;
using System.Text;

namespace sec14_interface_problema_do_diamante.Entities
{
    class Printer : Device, IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine("Printer print " + document);
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Printer processing " + document);
        }
    }
}
