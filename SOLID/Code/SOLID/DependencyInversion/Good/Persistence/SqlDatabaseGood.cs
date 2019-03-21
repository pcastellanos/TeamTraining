using SOLID.DependencyInversion.Good.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.DependencyInversion.Entity;

namespace SOLID.DependencyInversion.Good.Persistence
{
    public class SqlDatabaseGood : IDatabaseGood
    {
        public void Persist(PeopleEntity peopleEntity)
        {
            Console.WriteLine("Data saved in SqlDatabase Good");
        }
    }
}
