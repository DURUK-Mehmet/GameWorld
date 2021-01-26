using System;
using GameWorld.Business.Campaign;
using GameWorld.Business.Sales;
using GameWorld.DataAccess;
using GameWorld.Entities;
using GameWorld.ManagerService.Adapters;
using GameWorld.ManagerService;
using System.Collections.Generic;

namespace GameWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            ILoggerService fileLogger = new FileLogger();
            ILoggerService dataBaseLogger = new DataBaseLogger();

            ICheckIfRealPersonService checkIfRealPersonService = new MernisServiceAdapter();

            IPersonService personManager = new PersonManager(
                new List<ILoggerService> { dataBaseLogger, fileLogger }, 
                new List<ICheckIfRealPersonService> { checkIfRealPersonService }
                );

            Game battlefield4 = new Game() { Id = 1, Name = "Battlefield 4 Premium", Price = Convert.ToDouble(450) };
            Game overwatch = new Game() { Id = 2, Name = "Overwatch", Price = Convert.ToDouble(600) };

            Person salih = new Person()
            {
                Id = 3,
                FirstName = "Mehmet",
                LastName = "Duruk",
                NaturalId = 28765512118,
                NickName = "TheSensei",
                YearOfBirth = 199826
            };
            personManager.Add(salih);

            ICampaignService newRegistrationCampaign = new NewRegistrationDiscount();
            ICampaignService newYearCampaign = new NewYearDiscount();

            ISalesService salesService = new SalesManager(new List<ICampaignService> { newRegistrationCampaign, newYearCampaign });
            salesService.Buy(salih, battlefield4);
            salesService.Refund(salih, overwatch);

        }
    }
}
