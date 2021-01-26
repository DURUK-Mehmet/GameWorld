using System;
using System.Collections.Generic;
using System.Text;
using GameWorld.Entities;

namespace GameWorld.Business.Sales
{
    interface ISalesService
    {
        void Buy(Person person, Game game);
        void Refund(Person person, Game game);
    }
}
