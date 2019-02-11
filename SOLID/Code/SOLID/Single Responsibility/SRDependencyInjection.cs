using SOLID.Single_Responsibility.Interfaces;
using SOLID.Single_Responsibility.Services;
using SOLID.Single_Responsibility.Validators;
using Unity;

namespace SOLID.Single_Responsibility
{
    /// <summary>
    /// Class to register dependencies
    /// </summary>
    internal static class SRDependencyInjection
    {
        /// <summary>
        /// Gets or sets the container information
        /// </summary>
        public static UnityContainer Container { get; set; }

        /// <summary>
        /// Registers dependencies
        /// </summary>
        internal static void Register()
        {
            Container = new UnityContainer();
            Container.RegisterType<IEmailValidator, EmailValidator>();
            Container.RegisterType<IUserValidator, UserValidator>();
            Container.RegisterType<IUserCreateService, UserCreateService>();
        }
    }
}