using SOLID.Single_Responsibility.Entities;

namespace SOLID.Single_Responsibility.Interfaces
{
    /// <summary>
    /// Defines methods to create validations on User Info
    /// </summary>
    internal interface IUserValidator
    {
        /// <summary>
        /// Validate the user info
        /// </summary>
        /// <param name="userInfo">User's information</param>
        /// <returns>Returns whether an user is valid </returns>
        bool IsValid(UserDTO userInfo);
    }
}