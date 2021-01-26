using GameWorld.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorld.DataAccess
{
    interface ILoggerService
    {
        void Add(IEntity entity);
        void Update(IEntity entity);
        void Delete(IEntity entity);

    }
}
