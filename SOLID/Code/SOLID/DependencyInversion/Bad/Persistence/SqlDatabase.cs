using SOLID.DependencyInversion.Entity;
using System;

namespace SOLID.DependencyInversion.Bad.Persistence
{
    /// <summary>
    /// Class to access to the SQL Database
    /// </summary>
    public class SqlDatabase
    {
        /// <summary>
        /// Persists info to the database
        /// </summary>
        /// <param name="peopleEntity">People information</param>
        public void Persist(PeopleEntity peopleEntity)
        {
            Console.WriteLine($"Data for: {peopleEntity.Name} - saved in SqlDatabase");
        }
    }
}
