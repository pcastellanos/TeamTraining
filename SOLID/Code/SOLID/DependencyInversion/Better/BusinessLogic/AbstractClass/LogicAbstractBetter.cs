using SOLID.DependencyInversion.Better.Persistence.Interfaces;
using SOLID.DependencyInversion.Entity;

namespace SOLID.DependencyInversion.Better.BusinessLogic.AbstractClass
{
    /// <summary>
    /// Business logic to abtract behavior related to add people to the database
    /// </summary>
    public abstract class LogicAbstractBetter
    {
        /// <summary>
        /// Gets instance to the Database provider
        /// </summary>
        internal IDatabaseBetter _databaseBetter;

        /// <summary>
        /// Initializes a new instance of the <see cref="LogicAbstractBetter"/> class
        /// </summary>
        /// <param name="databaseBetter">Database provider instance</param>
        public LogicAbstractBetter(IDatabaseBetter databaseBetter)
        {
            _databaseBetter = databaseBetter;
        }

        /// <summary>
        /// Adds people to the database
        /// </summary>
        /// <param name="peopleEntity">People information</param>
        public abstract void AddPeople(PeopleEntity peopleEntity);
    }
}
