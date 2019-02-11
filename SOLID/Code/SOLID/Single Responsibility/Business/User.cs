using SOLID.Single_Responsibility.Entities;
using SOLID.Single_Responsibility.Interfaces;

namespace SOLID.Single_Responsibility.Business
{
    /// <summary>
    /// Defines business methods for the User
    /// </summary>
    internal class User
    {
        private readonly IUserCreateService userCreateService;

        /// <summary>
        /// Creates a new instance of <see cref="User"/>
        /// </summary>
        /// <param name="userCreateService">IUserCreateService instance</param>
        public User(IUserCreateService userCreateService)
        {
            this.userCreateService = userCreateService;
        }

        /// <summary>
        /// Creates an User
        /// </summary>
        /// <returns>User's information</returns>
        internal UserDTO CreateUser(UserDTO userInfo)
        {
            return userCreateService.Save(userInfo);
        }
    }
}