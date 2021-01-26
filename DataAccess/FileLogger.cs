using GameWorld.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorld.DataAccess
{
    class FileLogger : Person, ILoggerService
    {
        public void Add(IEntity entity)
        {
            Console.WriteLine(entity.Id + " No'lu " + FirstName + " " + LastName + "Kişi Dosya Sistemine kaydedildi");
        }

        public void Delete(IEntity entity)
        {
            Console.WriteLine(entity.Id + " No'lu " + FirstName + " " + LastName + "Kişi Dosya Sisteminden Silindi");
        }

        public void Update(IEntity entity)
        {
            Console.WriteLine(entity.Id + " No'lu " + FirstName + " " + LastName + "Kişi Dosya Sisteminde Günecellendi");
        }
    }
}
