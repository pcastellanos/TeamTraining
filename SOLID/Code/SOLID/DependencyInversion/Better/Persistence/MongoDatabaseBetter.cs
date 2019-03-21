using SOLID.DependencyInversion.Better.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.DependencyInversion.Entity;

namespace SOLID.DependencyInversion.Better.Persistence
{
    public class MongoDatabaseBetter : IDatabaseBetter
    {
        public void Persist(PeopleEntity peopleEntity)
        {
            Console.WriteLine("Data saved in Mongo database better");
        }
    }
}
