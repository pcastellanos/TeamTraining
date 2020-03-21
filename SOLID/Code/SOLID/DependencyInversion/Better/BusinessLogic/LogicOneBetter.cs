using SOLID.DependencyInversion.Better.BusinessLogic.AbstractClass;
using SOLID.DependencyInversion.Better.Persistence.Interfaces;
using SOLID.DependencyInversion.Entity;
using System;

namespace SOLID.DependencyInversion.Better.BusinessLogic
{
    /// <summary>
    /// Business logic to simulate saving info to the database
    /// </summary>
    public class LogicOneBetter : LogicAbstractBetter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogicOneBetter"/> class
        /// </summary>
        /// <param name="databaseBetter">Database provider instance</param>
        public LogicOneBetter(IDatabaseBetter databaseBetter) : base(databaseBetter)
        {
        }

        /// <summary>
        /// View documention of the <see cref="LogicAbstractBetter.Operation(PeopleEntity)"/> clas
        /// </summary>
        public override void Operation(PeopleEntity peopleEntity)
        {
            if (string.IsNullOrEmpty(peopleEntity.Name))
            {
                throw new Exception("Name is null");
            }

            _databaseBetter.Persist(peopleEntity);
        }
    }
}
