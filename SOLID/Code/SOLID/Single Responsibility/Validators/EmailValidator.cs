using SOLID.Single_Responsibility.Interfaces;

namespace SOLID.Single_Responsibility.Validators
{
    /// <summary>
    /// Implementation of <see cref="IEmailValidator"/>
    /// </summary>
    internal class EmailValidator : IEmailValidator
    {
        /// <summary>
        /// Implementation of <see cref="IEmailValidator.Validate(string)"/>
        /// </summary>
        public bool Validate(string email)
        {
            return email.Contains("@");
        }
    }
}