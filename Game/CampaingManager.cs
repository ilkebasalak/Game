using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class CampaingManager : ICampaingService
    {
        public void Add(Campaing campaign)
        {
            Console.WriteLine("Kampanya eklendi");
        }

        public void ApplyDiscount(Campaing campaing, Order order)
        {
            Console.WriteLine(campaing.Name + "  isimli kampanya " + order.Id + "  siparişinize uygulandı.");
        }

        public void Delete(Campaing campaign)
        {
            Console.WriteLine("Kampanyanız silinmiştir.");
        }

        public void Update(Campaing campaign)
        {
            Console.WriteLine("Kampanyanız güncellendi.");
        }






    }
            

    
}
