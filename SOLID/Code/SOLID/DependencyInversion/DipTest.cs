using SOLID.DependencyInversion.Bad;
using SOLID.DependencyInversion.Better.BusinessLogic.AbstractClass;
using SOLID.DependencyInversion.Entity;
using SOLID.DependencyInversion.Good;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace SOLID.DependencyInversion
{
    public class DipTest
    {
        public static void RunExampleDip() {

            var peopleEntity = new PeopleEntity
            {
                Name = "John",
                Address = "Calle 31"

            };

            // Bad
            // new Logic().Operation(peopleEntity);

            // Good
            //var provider = new FactoryProvider(Good.Enumeration.EnumProvider.MongoDatabase).GetProvider();
            //new LogicGood(provider).Operation(peopleEntity);

            // Better
            DependencyInjection.Configure();
            LogicAbstractBetter logic = DependencyInjection.MainUnityContainer.Resolve<LogicAbstractBetter>();
            logic.Operation(peopleEntity);

            Console.ReadLine();
        }
    }
}
