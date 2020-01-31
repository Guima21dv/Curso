using sec14_interface_problema_do_diamante.Entities;
using System;

namespace sec14_interface_problema_do_diamante
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer() { SerialNumber = 1080 };
            p.ProcessDoc("My letter");
            p.Print("my Letter!");

            Scanner s = new Scanner() { SerialNumber = 2003 };
            s.ProcessDoc("My email");
            Console.WriteLine(s.Scan());

            ComboDevice c = new ComboDevice() { SerialNumber = 3921 };
            c.ProcessDoc("My disertation!");
            c.Print("My disertation");
            Console.WriteLine(c.Scan());
            Console.ReadLine();
        }
    }
}
