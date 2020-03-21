using SOLID.DependencyInversion.Better.BusinessLogic.AbstractClass;
using SOLID.DependencyInversion.Better.Persistence.Interfaces;
using SOLID.DependencyInversion.Entity;
using System;

namespace SOLID.DependencyInversion.Better.BusinessLogic
{
    /// <summary>
    /// Business logic to simulate saving info to the database
    /// </summary>
    public class LogicTwoBetter : LogicAbstractBetter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogicTwoBetter"/> class
        /// </summary>
        /// <param name="databaseBetter">Database provider instance</param>
        public LogicTwoBetter(IDatabaseBetter databaseBetter) : base(databaseBetter)
        {
        }

        /// <summary>
        /// View documention of the <see cref="LogicAbstractBetter.AddPeople(PeopleEntity)"/> class
        /// </summary>
        public override void AddPeople(PeopleEntity peopleEntity)
        {
            if (string.IsNullOrEmpty(peopleEntity.Address))
            {
                throw new Exception("Address is null");
            }

            _databaseBetter.Persist(peopleEntity);
        }
    }
}
