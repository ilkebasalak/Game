using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    interface ICampaingService
    {
        void Add(Campaing campaign);
        void Update(Campaing campaign);

        void Delete(Campaing campaign);

        void ApplyDiscount(Campaing campaing, Order order);
    }
        
}
