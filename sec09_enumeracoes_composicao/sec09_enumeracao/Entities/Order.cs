using System;
using sec09_enumeracao.Entities.Enums;

namespace sec09_enumeracao.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public override string ToString()
        {
            return Id + ", " + Moment + ", " + Status;
        }
    }
}
