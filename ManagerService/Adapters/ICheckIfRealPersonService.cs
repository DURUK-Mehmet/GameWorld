using System;
using System.Collections.Generic;
using System.Text;
using GameWorld.Entities;

namespace GameWorld.ManagerService.Adapters
{
    interface ICheckIfRealPersonService
    {
        bool checkIfRealPerson(Person person);
    }
}
