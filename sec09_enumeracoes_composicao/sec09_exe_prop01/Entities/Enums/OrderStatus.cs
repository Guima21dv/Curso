using System;
using System.Collections.Generic;
using System.Text;

namespace sec09_exe_prop01.Entities.Enums
{
    enum OrderStatus : int
    {
        endingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    };
}
