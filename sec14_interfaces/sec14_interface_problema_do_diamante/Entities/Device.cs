using System;
using System.Collections.Generic;
using System.Text;

namespace sec14_interface_problema_do_diamante.Entities
{
    abstract class Device
    {
        public int SerialNumber { get; set; }

        public abstract void ProcessDoc(string document);
    }
}
