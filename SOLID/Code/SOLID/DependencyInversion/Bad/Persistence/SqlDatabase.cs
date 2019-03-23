using SOLID.DependencyInversion.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversion.Bad.Persistence
{
    public class SqlDatabase
    {


        public void Persist(PeopleEntity peopleEntity) {

            Console.WriteLine("Data saved in SqlDatabase");


        }
    }
}
