using SOLID.Single_Responsibility.Entities;
using SOLID.Single_Responsibility.Interfaces;

namespace SOLID.Single_Responsibility.Services
{
    /// <summary>
    /// Implementation of <see cref="IUserCreateService"/>
    /// </summary>
    internal class UserCreateService : IUserCreateService
    {
        /// <summary>
        /// Implementation of <see cref="IUserCreateService.Save(UserDTO)"/>
        /// </summary>
        public UserDTO Save(UserDTO userInfo)
        {
            // Save user on the dabase, service, etc.
            return SaveInDB();
        }

        /// <summary>
        /// Logic to create an User in the database
        /// </summary>
        /// <returns>User's information</returns>
        private UserDTO SaveInDB()
        {
            return new UserDTO
            {
                Id = 1,
                Name = "Test",
                Age = 20,
                Email = "test@test.com"
            };
        }
    }
}