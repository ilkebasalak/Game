using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    internal class OrderManager : IorderService
    {
        public void Add(Order order)
        {
            Console.WriteLine(order.GameName + "  isimli oyununuz sepete eklendi.");
        }

        public void Delete(Order order)
        {
            Console.WriteLine(order.GameName + "  isimli oyununuz sepetten kaldırıldı.");
        }

        public void Update(Order order)
        {
            Console.WriteLine(order.Id + "  nolu siparişiniz güncellendi.");
        }
    }
}
