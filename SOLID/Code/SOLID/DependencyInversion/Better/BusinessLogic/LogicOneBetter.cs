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
    public class LogicOneBetter : LogicAbstractBetter
    {
        public LogicOneBetter(IDatabaseBetter databaseBetter) : base(databaseBetter)
        {
        }

        public override void Operation(PeopleEntity peopleEntity)
        {
            if (string.IsNullOrEmpty(peopleEntity.Name))
                throw new Exception("Name is null");

            _databaseBetter.Persist(peopleEntity);
        }
    }
}
