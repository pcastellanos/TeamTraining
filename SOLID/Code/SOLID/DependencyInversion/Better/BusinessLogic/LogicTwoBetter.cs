using SOLID.DependencyInversion.Better.BusinessLogic.AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLID.DependencyInversion.Entity;
using SOLID.DependencyInversion.Better.Persistence.Interfaces;

namespace SOLID.DependencyInversion.Better.BusinessLogic
{
    public class LogicTwoBetter : LogicAbstractBetter
    {
        public LogicTwoBetter(IDatabaseBetter databaseBetter) : base(databaseBetter)
        {
        }

        public override void Operation(PeopleEntity peopleEntity)
        {
            if (string.IsNullOrEmpty(peopleEntity.Address))
                throw new Exception("Address is null");

            _databaseBetter.Persist(peopleEntity);
        }
    }
}
