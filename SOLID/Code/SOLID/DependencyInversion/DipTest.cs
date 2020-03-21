using SOLID.DependencyInversion.Bad;
using SOLID.DependencyInversion.Better;
using SOLID.DependencyInversion.Better.BusinessLogic.AbstractClass;
using SOLID.DependencyInversion.Entity;
using SOLID.DependencyInversion.Good;
using SOLID.DependencyInversion.Good.Enumeration;
using System;
using Unity;

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
            new Logic().Operation(peopleEntity);

            // Good
            //var provider = new FactoryDatabaseProvider(DatabaseProvider.SqlDatabase).GetProvider();
            //new LogicGood(provider).Operation(peopleEntity);

            // Better
            //DependencyInjection.Configure();
            //LogicAbstractBetter logic = DependencyInjection.MainUnityContainer.Resolve<LogicAbstractBetter>();
            //logic.Operation(peopleEntity);

            Console.ReadLine();
        }
    }
}
