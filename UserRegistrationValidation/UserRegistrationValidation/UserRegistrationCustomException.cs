using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationValidationWithMST
{
    public class UserRegistrationCustomException : Exception
    {
        /// <summary>
        /// Enumerating two message as constant variables 0-Empty Message and 1-Null Message
        /// </summary>
        public enum ExceptionType
        {
            WRONG_FIRSTNAME, WRONG_LASTNAME, WRONG_EMAIL, WRONG_MOBILENUMBER, WRONG_PASSWORD
        }
        public readonly ExceptionType type;

        public UserRegistrationCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
