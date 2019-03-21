using SOLID.DependencyInversion.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversion.Good.Persistence.Interfaces
{
    public interface IDatabaseGood
    {

        void Persist(PeopleEntity peopleEntity);
    }
}
