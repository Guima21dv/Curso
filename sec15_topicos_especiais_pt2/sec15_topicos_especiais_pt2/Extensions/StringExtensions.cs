using System;
using System.Collections.Generic;
using System.Text;

namespace sec15_topicos_especiais_pt2.Extensions
{
    static class StringExtensions
    {
        public static string Cut(this string obj, int count)
        {
            if(obj.Length <= count)
            {
                return obj;
            }
            else
            {
                return obj.Substring(0, count) + "...";
            }
        }
    }
}
