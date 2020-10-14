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
            try
            {
                string expected = userDataValidation.isValidName("praveen");
            }
            catch(UserRegistrationCustomException exception)
            {
                //Assert
                Assert.AreEqual("Invalid Entry", exception.Message);
            }
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
            try
            {
                string expected = userDataValidation.isValidName("upadhyay");
            }
            catch (UserRegistrationCustomException exception)
            {
                //Assert
                Assert.AreEqual("Invalid Entry", exception.Message);
            }
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
            try
            {
                string expected = userDataValidation.isValidMobileNumber("9450357780");
            }
            catch (UserRegistrationCustomException exception)
            {
                //Assert
                Assert.AreEqual("Invalid Entry", exception.Message);
            }
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
            try
            {
                string expected = userDataValidation.isValidEmailID("praveencapgemini@gmail.co.in");
            }
            catch (UserRegistrationCustomException exception)
            {
                //Assert
                Assert.AreEqual("Invalid Entry", exception.Message);
            }
        }
        /// <summary>
        /// Test Case For Multiple Email Entries
        /// </summary>
        [DataRow("praveencapgemini@gmail.co.in")]
        [DataRow("praveen-capgemini@gmail.co.in")]
        [DataRow("praveencapgemini@gmail.co.nz")]
        [TestCategory("Validate Multiple E-Mail")]
        [TestMethod]
        public void TestingInputForMultipleEmailId(string emailId)
        {
            //Arrange
            UserDataValidation userDataValidation = new UserDataValidation();
            try
            {
                    string expected = userDataValidation.isValidEmailID(emailId);
                    Assert.AreEqual("Correct Entry", expected);
            }
            catch (UserRegistrationCustomException exception)
            {
                //Assert
                Assert.AreEqual("Invalid Entry", exception.Message);
            }
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
            try
            {
                string expected = userDataValidation.isValidPasswordUC8("praveen76@#");
            }
            catch (UserRegistrationCustomException exception)
            {
                //Assert
                Assert.AreEqual("Invalid Entry", exception.Message);
            }
        }
    }
}
