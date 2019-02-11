namespace SOLID.Single_Responsibility.Interfaces
{
    /// <summary>
    /// Defines methods to create validations on Emails accounts
    /// </summary>
    internal interface IEmailValidator
    {
        /// <summary>
        /// Validate an Email account
        /// </summary>
        /// <param name="email">Email info</param>
        /// <returns>Returns whether an email is valid </returns>
        bool Validate(string email);
    }
}