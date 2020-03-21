using SOLID.DependencyInversion.Better.BusinessLogic;
using SOLID.DependencyInversion.Better.BusinessLogic.AbstractClass;
using SOLID.DependencyInversion.Better.Persistence;
using SOLID.DependencyInversion.Better.Persistence.Interfaces;
using Unity;

namespace SOLID.DependencyInversion.Better
{
    /// <summary>
    /// Class to manage the Dependency Injection of the project
    /// </summary>
    public static class DependencyInjection
    {
        /// <summary>
        /// Gets information from the Unity Container
        /// </summary>
        public static IUnityContainer MainUnityContainer { get; }

        /// <summary>
        /// Builder to create objects just one time along the application's live
        /// </summary>
        static DependencyInjection() {
            MainUnityContainer = new UnityContainer();
        }

        /// <summary>
        /// Configures instances for the application
        /// </summary>
        public static void Configure() {
            MainUnityContainer.RegisterType<IDatabaseBetter, OracleDatabaseBetter>();
            MainUnityContainer.RegisterType<LogicAbstractBetter, LogicTwoBetter>();
        }
    }
}
