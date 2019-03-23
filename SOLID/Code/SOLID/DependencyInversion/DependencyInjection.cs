using SOLID.DependencyInversion.Better.BusinessLogic;
using SOLID.DependencyInversion.Better.BusinessLogic.AbstractClass;
using SOLID.DependencyInversion.Better.Persistence;
using SOLID.DependencyInversion.Better.Persistence.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace SOLID.DependencyInversion
{
    public static class DependencyInjection
    {

        public static IUnityContainer MainUnityContainer { get; }

        static DependencyInjection() {
            MainUnityContainer = new UnityContainer();
        }

        public static void Configure() {
            MainUnityContainer.RegisterType<IDatabaseBetter, OracleDatabaseBetter>();
            MainUnityContainer.RegisterType<LogicAbstractBetter, LogicTwoBetter>();

        }
    }
}
