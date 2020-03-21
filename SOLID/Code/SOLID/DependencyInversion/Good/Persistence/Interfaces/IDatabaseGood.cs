using SOLID.DependencyInversion.Entity;

namespace SOLID.DependencyInversion.Good.Persistence.Interfaces
{
    /// <summary>
    /// Defines contracts to access to the Database
    /// </summary>
    public interface IDatabaseGood
    {
        /// <summary>
        /// Persists info to the database
        /// </summary>
        /// <param name="peopleEntity">People information</param>
        void Persist(PeopleEntity peopleEntity);
    }
}
