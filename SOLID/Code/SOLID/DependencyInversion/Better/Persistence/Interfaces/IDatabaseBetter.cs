using SOLID.DependencyInversion.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversion.Better.Persistence.Interfaces
{
    public interface IDatabaseBetter
    {
        void Persist(PeopleEntity peopleEntity);
    }
}
