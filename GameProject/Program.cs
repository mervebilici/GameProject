using System;

namespace GameProject
{
    class Program
    {
        private static object userValidationService;

        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 23, FirstName = "MERVE", LastName = "BİLİCİ", IdentityNumber = 12345, BirthYear = 1999 });

            Console.WriteLine("---------------------------------------------");

            Campaign campaign = new Campaign();
            campaign.CampaignStartDate = new DateTime(2021, 01, 01);
            campaign.CampaignFinishDate = new DateTime(2021, 11, 01);
            campaign.CampaignNumber = 00254;
            campaign.CampaignName = "11 AY İNDİRİMLERİ";

            Console.WriteLine("---------------------------------------------");

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);
            campaignManager.Update(campaign);
            campaignManager.Delete(campaign);

            Console.WriteLine("---------------------------------------------");

            Order order = new Order { OrderId = 01, OrderDescription = "Siparişim alınınca bilgiledirilmek istiyorum" };
            Order order2 = new Order { OrderId = 02, OrderDescription = "Siparişimi güncellemek istiyorum" };
            Order order3 = new Order { OrderId = 03, OrderDescription = "Siparişimi iptal etmek istiyorum" };

            Console.WriteLine("---------------------------------------------");

            OrderManager orderManager = new OrderManager();
            orderManager.Add(order, campaign);
            orderManager.Update(order2);
            orderManager.Delete(order3);
        }
    }
}
