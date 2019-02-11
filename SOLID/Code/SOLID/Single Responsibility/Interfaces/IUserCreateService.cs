using SOLID.Single_Responsibility.Entities;

namespace SOLID.Single_Responsibility.Interfaces
{
    /// <summary>
    /// Defines methods to create an User
    /// </summary>
    internal interface IUserCreateService
    {
        /// <summary>
        /// Creates a new user
        /// </summary>
        /// <param name="userInfo">User's information</param>
        /// <returns>New user created</returns>
        UserDTO Save(UserDTO userInfo);
    }
}