namespace SOLID.Single_Responsibility.Entities
{
    /// <summary>
    /// Class to define attributes for the User
    /// </summary>
    internal class UserDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public bool ValidateEmail()
        {
            return Email.Contains("@");
        }

        public bool ValidateUser()
        {
            return !string.IsNullOrEmpty(Name) &&
                !string.IsNullOrEmpty(Email) &&
                Age > 18;
        }

        public UserDTO SaveUser()
        {
            return SaveInDB();
        }

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