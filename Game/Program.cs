using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthDay = 1994,

                FirstName = "ilke",
                LastName = "Başalak",
                ıdentityNumber = 5678
            });




            Order order1 = new Order()
            {
                Id = 2,
                OrderPrice = 100,
                GameName = "Volerant"
            };

            Order order2 = new Order()
            {
                Id = 3,
                OrderPrice = 200,
                GameName = "LoL"
            };


            Campaing campaign1 = new Campaing()
            {
                Id = 4,
                DiscountRate = 20,
                Name = "Hoşgeldin Kampanyası"
            };
            Campaing campaign2 = new Campaing()
            {
                Id = 5,
                DiscountRate = 20,
                Name = "Güle güle Kampanyası"
            };


            OrderManager orderManager = new OrderManager();
            orderManager.Add(order1);
            orderManager.Delete(order2);
           
          CampaingManager campaignManager = new CampaingManager();

            campaignManager.Add(campaign2);
            campaignManager.ApplyDiscount(campaign2, order1);
            campaignManager.Delete(campaign2);



            Console.ReadLine();

        }


        }
}
    

