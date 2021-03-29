using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class OrderManager : IOrderService
    {
        public void Add(Order order, Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignNumber + ": Numaralı Kampanyadan Yararlandınız." );
            Console.WriteLine(order.OrderId + ": Siparişiniz Alındı." + "Sipariş Açıklaması:" + order.OrderDescription);
        }

        public void Delete(Order order)
        {
            Console.WriteLine(order.OrderId + ": Nolu Siparişiniz İptal Edildi." + "Sipariş Açıklaması:" + order.OrderDescription);
        }

        public void Update(Order order)
        {
            Console.WriteLine(order.OrderId + ": Nolu Siparişiniz Güncellendi." + "Sipariş Açıklaması:" + order.OrderDescription);
        }
    }
}
