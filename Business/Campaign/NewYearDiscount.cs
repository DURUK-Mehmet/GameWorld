using System;
using System.Collections.Generic;
using System.Text;
using GameWorld.Entities;

namespace GameWorld.Business.Campaign
{
    class NewYearDiscount : ICampaignService
    {
        public void Discount(IEntity entity)
        {
            Console.WriteLine("Yeni Yıl İndirimi Yapıldı");
        }
    }
}
