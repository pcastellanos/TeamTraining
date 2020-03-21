using SOLID.DependencyInversion.Entity;
using SOLID.DependencyInversion.Good.Persistence.Interfaces;
using System;

namespace SOLID.DependencyInversion.Good
{
    /// <summary>
    /// Business logic to simulate saving info to the database
    /// </summary>
    public class LogicGood
    {
        /// <summary>
        /// Gets the Database provider instance
        /// </summary>
        IDatabaseGood _databaseGood;

        /// <summary>
        /// Initializes a new instance of the <see cref="LogicGood"/> class
        /// </summary>
        /// <param name="databaseGood">Database provider instance</param>
        public LogicGood(IDatabaseGood databaseGood)
        {
            _databaseGood = databaseGood;
        }

        /// <summary>
        /// Adds people to the database
        /// </summary>
        /// <param name="peopleEntity">People information</param>
        public void Operation(PeopleEntity peopleEntity)
        {
            if (string.IsNullOrEmpty(peopleEntity.Address))
            {
                throw new Exception("Address is null");
            }

            _databaseGood.Persist(peopleEntity);
        }
    }
}
