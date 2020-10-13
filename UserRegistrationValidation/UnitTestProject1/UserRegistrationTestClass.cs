using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationValidationWithMST;

namespace UnitTestProject1
{
    [TestClass]
    public class UserRegistrationTestClass
    {
        public static bool actual = true;
        /// <summary>
        /// To test the First name mathing case
        /// </summary>
        [TestCategory("Names")]
        [TestMethod]
        public void TestingInputForFirstName()
        {
            //Arrange
            UserDataValidation userDataValidation = new UserDataValidation();
            //Act
            bool expected = userDataValidation.isValidName("Praveen");
            //Assert
            Assert.IsTrue(expected);
        }
        /// <summary>
        /// To test the Last name
        /// </summary>
        [TestCategory("Names")]
        [TestMethod]
        public void TestingInputForLastName()
        {
            //Arrange
            UserDataValidation userDataValidation = new UserDataValidation();
            //Act
            bool expected = userDataValidation.isValidName("Upadhyay");
            //Assert
            Assert.IsTrue(expected);
        }
        /// <summary>
        /// To test the mobile number matching case
        /// </summary>
        [TestCategory("Mobile Number")]
        [TestMethod]
        public void TestingInputForMobileNumber()
        {
            //Arrange
            UserDataValidation userDataValidation = new UserDataValidation();
            //Act
            bool expected = userDataValidation.isValidMobileNumber("91 9450347680");
            //Assert
            Assert.IsTrue(expected);
        }
        /// <summary>
        /// To test the e-mail matching case
        /// </summary>
        [TestCategory("E-Mail")]
        [TestMethod]
        public void TestingInputForEmailId()
        {
            //Arrange
            UserDataValidation userDataValidation = new UserDataValidation();
            //Act
            bool expected = userDataValidation.isValidEmailID("praveen-capgemini@gmail.co.in");
            //Assert
            Assert.IsTrue(expected);
        }
        /// <summary>
        /// To test the password matching case
        /// </summary>
        [TestCategory("Password")]
        [TestMethod]
        public void TestingInputForPassword()
        {
            //Arrange
            UserDataValidation userDataValidation = new UserDataValidation();
            //Act
            bool expected = userDataValidation.isValidPasswordUC8("Praveen@1");
            //Assert
            Assert.IsTrue(expected);
        }
    }
}
