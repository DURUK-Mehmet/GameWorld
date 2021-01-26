using GameWorld.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorld.ManagerService.Adapters
{
    public class MernisServiceAdapter : ICheckIfRealPersonService
    {
        public bool checkIfRealPerson(Person person)
        {
            bool check=false;
            MernisServiceReference.KPSPublicSoapClient client = new MernisServiceReference.KPSPublicSoapClient();
            check = Convert.ToBoolean(client.TCKimlikNoDogrulaAsync(person.NaturalId, person.FirstName.ToUpper(),
                person.LastName.ToUpper(), person.YearOfBirth));
            return check;
        }
    }
}
