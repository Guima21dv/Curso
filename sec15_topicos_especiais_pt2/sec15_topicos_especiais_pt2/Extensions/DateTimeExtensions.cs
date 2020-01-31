using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace sec15_topicos_especiais_pt2.Extensions
{
    static class DateTimeExtensions
    {
        public static string ElapsedTime(this DateTime obj)
        {
            TimeSpan duration = DateTime.Now.Subtract(obj);
            if(duration.TotalHours < 24)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";
            }
            return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days";
        }
    }
}
