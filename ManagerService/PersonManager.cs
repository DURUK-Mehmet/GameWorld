using System;
using System.Collections.Generic;
using System.Text;
using GameWorld;
using GameWorld.DataAccess;
using GameWorld.Entities;
using GameWorld.ManagerService;
using GameWorld.ManagerService.Adapters;

namespace GameWorld.ManagerService
{
    class PersonManager : IPersonService
    {
        readonly List<ILoggerService> _loggerServices;
        readonly List<ICheckIfRealPersonService> _checkIfRealPersonServices;
        public PersonManager(List<ILoggerService> loggerServices ,List<ICheckIfRealPersonService> checkIfRealPersonServices)
        {
            _loggerServices = loggerServices;
            _checkIfRealPersonServices = checkIfRealPersonServices;
        }
        public void Add(IEntity person)
        {

            try
            {
                foreach (var realPersonService in _checkIfRealPersonServices)
                {
                    realPersonService.checkIfRealPerson((Person)person);
                }
                foreach (var logger in _loggerServices)
                {
                    logger.Add(person);
                }
            }
            catch (Exception exception)
            {

                Console.WriteLine(exception.Message);
            }
        }

        public void Delete(IEntity person)
        {
            foreach (var logger in _loggerServices)
            {
                logger.Delete(person);
            }
        }

        public void Update(IEntity person)
        {
            foreach (var logger in _loggerServices)
            {
                logger.Update(person);
            }
        }
    }
}
