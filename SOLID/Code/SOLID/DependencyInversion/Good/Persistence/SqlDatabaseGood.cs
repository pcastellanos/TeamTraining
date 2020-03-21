using SOLID.DependencyInversion.Entity;
using SOLID.DependencyInversion.Good.Persistence.Interfaces;
using System;

namespace SOLID.DependencyInversion.Good.Persistence
{
    /// <summary>
    /// Class to access to the SQL Database
    /// </summary>
    public class SqlDatabaseGood : IDatabaseGood
    {
        /// <summary>
        /// View documentation of <see cref="IDatabaseGood.Persist(PeopleEntity)"/> interface
        /// </summary>
        public void Persist(PeopleEntity peopleEntity)
        {
            Console.WriteLine($"Data for: {peopleEntity.Name} - saved in SqlDatabase Good");
        }
    }
}
