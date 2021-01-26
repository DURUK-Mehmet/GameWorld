using GameWorld.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorld.ManagerService
{
    interface IPersonService
    {
        void Add(IEntity entity);
        void Delete(IEntity entity);
        void Update(IEntity entity);
    }
}
