using SOLID.DependencyInversion.Entity;
using SOLID.DependencyInversion.Good.Persistence.Interfaces;
using System;

namespace SOLID.DependencyInversion.Good.Persistence
{
    /// <summary>
    /// Class to access to the Mongo Database
    /// </summary>
    public class MongoDatabase : IDatabaseGood
    {
        /// <summary>
        /// View documentation of <see cref="IDatabaseGood.Persist(PeopleEntity)"/> interface
        /// </summary>
        public void Persist(PeopleEntity peopleEntity)
        {
            Console.WriteLine($"Data for: {peopleEntity.Name} - saved in MongoDatabase Good");
        }
    }
}
