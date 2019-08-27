using System;
using sec09_enumeracao.Entities;
using sec09_enumeracao.Entities.Enums;

namespace sec09_enumeracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment

            };
            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString(); // convertendo um tipo ENUM para string.
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); // convertendo um tipo string em ENUM com .parse <T> OBS: A string deve ser alguma constante do tipo enumerado, escrita exatamente.
            
        }
    }
}
