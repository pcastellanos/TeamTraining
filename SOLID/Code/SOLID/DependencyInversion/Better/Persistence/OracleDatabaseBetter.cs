using SOLID.DependencyInversion.Better.Persistence.Interfaces;
using SOLID.DependencyInversion.Entity;
using System;

namespace SOLID.DependencyInversion.Better.Persistence
{
    /// <summary>
    /// Class to access to the Oracle Database
    /// </summary>
    public class OracleDatabaseBetter : IDatabaseBetter
    {
        /// <summary>
        /// View documentation of <see cref="IDatabaseBetter.Persist(PeopleEntity)"/> interface
        /// </summary>
        public void Persist(PeopleEntity peopleEntity)
        {
            Console.WriteLine($"Data for: {peopleEntity.Name} - saved in Oracle Better");
        }
    }
}
