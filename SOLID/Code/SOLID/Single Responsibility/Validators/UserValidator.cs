using SOLID.Single_Responsibility.Entities;
using SOLID.Single_Responsibility.Interfaces;

namespace SOLID.Single_Responsibility.Validators
{
    /// <summary>
    /// Implementation of <see cref="IUserValidator"/>
    /// </summary>
    internal class UserValidator : IUserValidator
    {
        /// <summary>
        /// Implementation of <see cref="IUserValidator.IsValid(UserDTO)"/>
        /// </summary>
        public bool IsValid(UserDTO userInfo)
        {
            // Validates the user information
            return !string.IsNullOrEmpty(userInfo.Name) &&
                !string.IsNullOrEmpty(userInfo.Email) &&
                userInfo.Age > 18;
        }
    }
}