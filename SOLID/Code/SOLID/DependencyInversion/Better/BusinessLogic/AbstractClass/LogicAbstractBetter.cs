using SOLID.DependencyInversion.Better.Persistence.Interfaces;
using SOLID.DependencyInversion.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversion.Better.BusinessLogic.AbstractClass
{
    public abstract class LogicAbstractBetter
    {
        internal IDatabaseBetter _databaseBetter;
        public LogicAbstractBetter(IDatabaseBetter databaseBetter) {
            _databaseBetter = databaseBetter;
        }

        public abstract void Operation(PeopleEntity peopleEntity);


    }
}
