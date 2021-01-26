using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorld.Entities
{
    public class Person : IEntity
    {
        public int Id { get; set; }
        public string NickName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long NaturalId { get; set; }
        public int YearOfBirth { get; set; }
    }
}
