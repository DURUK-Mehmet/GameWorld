using System;
using System.Collections.Generic;
using System.Text;
using GameWorld.Entities;

namespace GameWorld.Business.Campaign
{
    interface ICampaignService
    {
        void Discount(IEntity entity);
    }
}
