using SOLID.DependencyInversion.Bad.Persistence;
using SOLID.DependencyInversion.Entity;
using System;

namespace SOLID.DependencyInversion.Bad
{
    /// <summary>
    /// Business logic to simulate saving info to the database
    /// </summary>
    public class Logic
    {
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

            new SqlDatabase().Persist(peopleEntity);
        }
    }
}
