using SOLID.DependencyInversion.Bad;
using SOLID.DependencyInversion.Entity;
using System;

namespace SOLID.DependencyInversion
{
    /// <summary>
    /// Class to show Dependency Inversion Test Case
    /// </summary>
    public class DipTest
    {
        public static void RunExampleDip() {

            var peopleEntity = new PeopleEntity
            {
                Name = "John Henao",
                Address = "Calle 31"
            };

            // Bad
            new Logic().AddPeople(peopleEntity);

            // Good
            //var provider = new FactoryDatabaseProvider(DatabaseProvider.SqlDatabase).GetProvider();
            //new LogicGood(provider).AddPeople(peopleEntity);

            // Better
            //DependencyInjection.Configure();
            //LogicAbstractBetter logic = DependencyInjection.MainUnityContainer.Resolve<LogicAbstractBetter>();
            //logic.AddPeople(peopleEntity);

            Console.ReadLine();
        }
    }
}
