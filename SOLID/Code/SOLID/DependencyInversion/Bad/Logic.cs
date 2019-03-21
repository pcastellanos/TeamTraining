using SOLID.DependencyInversion.Bad.Persistence;
using SOLID.DependencyInversion.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversion.Bad
{
    public class Logic
    {

        public void Operation(PeopleEntity peopleEntity) {

            if (string.IsNullOrEmpty(peopleEntity.Address))
                throw new Exception("Address is null");


            new SqlDatabase().Persist(peopleEntity);

        }
    }
}
