using GameWorld.Business.Campaign;
using GameWorld.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorld.Business.Sales
{
    class SalesManager : ISalesService
    {
        readonly List<ICampaignService> _campaignService; 

        public SalesManager(List<ICampaignService> campaignService)
        {
            _campaignService = campaignService;
        }

        public void Buy(Person person, Game game)
        {
            foreach (var sale in _campaignService)
            {
                sale.Discount(game);
            }
            Console.WriteLine(person.FirstName + " " + person.LastName + " İsimli " + person.NickName + " Kullanıcı " + game.Name + "Oyununu Aldı");
        }

        public void Refund(Person person, Game game)
        {
            Console.WriteLine(person.FirstName + " " + person.LastName + " İsimli " + person.NickName + " Kullanıcı " + game.Name + "Oyununu Geri İade Etti");

        }
    }
}
