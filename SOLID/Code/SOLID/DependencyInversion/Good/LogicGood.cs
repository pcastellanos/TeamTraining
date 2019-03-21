using SOLID.DependencyInversion.Entity;
using SOLID.DependencyInversion.Good.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversion.Good
{
    public class LogicGood
    {
        IDatabaseGood _databaseGood;
        public LogicGood(IDatabaseGood databaseGood) {
            _databaseGood = databaseGood;
        }

        public void Operation(PeopleEntity peopleEntity)
        {


            if (string.IsNullOrEmpty(peopleEntity.Address))
                throw new Exception("Address is null");



            _databaseGood.Persist(peopleEntity);

        }
    }
}
