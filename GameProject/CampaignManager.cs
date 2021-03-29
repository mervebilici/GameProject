using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya Başarıyla Eklendi!");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya Silindi...");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya Güncellendi!");
        }
    }
}
