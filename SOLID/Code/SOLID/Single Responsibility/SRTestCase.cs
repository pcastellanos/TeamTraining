using SOLID.Single_Responsibility.Entities;
using SOLID.Single_Responsibility.Interfaces;
using Unity;

namespace SOLID.Single_Responsibility
{
    /// <summary>
    /// Class to show Single Responsibility Test Case
    /// </summary>
    internal static class SRTestCase
    {
        private static IEmailValidator emailValidator;
        private static IUserValidator userValidator;
        private static IUserCreateService userCreateService;

        /// <summary>
        /// Creates a User
        /// </summary>
        internal static void CreateUser()
        {
            UserDTO user = new UserDTO();
            user.Name = "test";
            user.Age = 15;
            user.Email = "test.com";

            user.ValidateUser();
            user.ValidateEmail();
            user.SaveUser();

            // Using Single Responsibility
            GetInstances();
            userValidator.IsValid(user);
            emailValidator.Validate(user.Email);
            userCreateService.Save(user);
        }

        /// <summary>
        /// Gets instance of the Unity Container
        /// </summary>
        private static void GetInstances()
        {
            SRDependencyInjection.Register();
            UnityContainer container = SRDependencyInjection.Container;

            emailValidator = container.Resolve<IEmailValidator>();
            userValidator = container.Resolve<IUserValidator>();
            userCreateService = container.Resolve<IUserCreateService>();
        }
    }
}