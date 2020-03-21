using SOLID.DependencyInversion.Better.Persistence.Interfaces;
using SOLID.DependencyInversion.Entity;
using System;

namespace SOLID.DependencyInversion.Better.Persistence
{
    /// <summary>
    /// Class to access to the Mongo Database
    /// </summary>
    public class MongoDatabaseBetter : IDatabaseBetter
    {
        /// <summary>
        /// View documentation of <see cref="IDatabaseBetter.Persist(PeopleEntity)"/> interface
        /// </summary>
        public void Persist(PeopleEntity peopleEntity)
        {
            Console.WriteLine($"Data for: {peopleEntity.Name} - saved in Mongo database Better");
        }
    }
}
