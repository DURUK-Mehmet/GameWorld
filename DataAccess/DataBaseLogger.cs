using GameWorld.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorld.DataAccess

{
    class DataBaseLogger : Person, ILoggerService
    {
        public void Add(IEntity entity)
        {
            Console.WriteLine(entity.Id + " No'lu " + FirstName +" "+ LastName + "Kişi Veritabanına kaydedildi");
        }

        public void Delete(IEntity entity)
        {
            Console.WriteLine(entity.Id + " No'lu " + FirstName + " " + LastName + "Kişi Veritabanından Silindi");
        }

        public void Update(IEntity entity)
        {
            Console.WriteLine(entity.Id + " No'lu " + FirstName + " " + LastName + "Kişi VeritabanındaGüncellendi");
        }
    }
}
