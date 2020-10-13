using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationValidationWithMST
{
    public class UserDataValidation
    {
        /// <summary>
        /// Regular Expression for matching parameters
        /// </summary>
        public static string FIRSTNAME_REGX = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string LASTNAME_REGX = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string EMAIL_REGX = "[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?";
        public static string MOBILENUMBER_REGX = "^[0-9]{2}[ ][0-9]{10}$";
        public static string PASSWORD_UC8 = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[^0-9a-zA-Z])(?!.*[^0-9a-zA-Z].*[^0-9a-zA-Z]).{8,}$";

        /// <summary>
        /// Determines whether [is valid first name] [the specified first name].
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <returns>
        ///   <c>true</c> if [if the patter matches] [the specified first name]; otherwise, <c>false</c>.
        /// </returns>
        public bool isValidEmailID(string emailId)
        {
            return Regex.IsMatch(emailId, EMAIL_REGX);
        }

        /// <summary>
        /// Determines whether [is valid first name] [the specified first name].
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <returns>
        ///   <c>true</c> if [is valid first name] [the specified first name]; otherwise, <c>false</c>.
        /// </returns>
        public bool isValidName(string firstName)
        {
            return Regex.IsMatch(firstName, FIRSTNAME_REGX);
        }

        /// <summary>
        /// Determines whether [is valid mobile number] [the specified mobile number].
        /// </summary>
        /// <param name="mobileNumber">The mobile number.</param>
        /// <returns>
        ///   <c>true</c> if [is valid mobile number] [the specified mobile number]; otherwise, <c>false</c>.
        /// </returns>
        public bool isValidMobileNumber(string mobileNumber)
        {
            return Regex.IsMatch(mobileNumber, MOBILENUMBER_REGX);
        }

        /// <summary>
        /// Determines whether [is valid password u c8] [the specified password].
        /// </summary>
        /// <param name="password">The password.</param>
        /// <returns>
        ///   <c>true</c> if [is valid password u c8] [the specified password]; otherwise, <c>false</c>.
        /// </returns>
        public bool isValidPasswordUC8(string password)
        {
            return Regex.IsMatch(password, PASSWORD_UC8);
        }

    }
}
