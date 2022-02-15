using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationProgram;
using ReflectionAndAnnotation;

namespace UserRegistrationTesting
{
    [TestClass]
    public class TestUsersReg
    {
        //Test case for validating first name
        [TestCategory("User Name")]
        [TestMethod]
        [DataRow("Raj", "Raj")]
        [DataRow("Rajkumar", "Rajkumar")]
        [DataRow("As", "First name should starts with Cap and should have minimum 3 characters")]
        [DataRow("rajkumar", "First name should starts with Cap and should have minimum 3 characters")]
        [DataRow("raj4124", "First name should starts with Cap and should have minimum 3 characters")]
        [DataRow(null, "Object reference not set to an instance of an object.")]
        [DataRow("", "First name should not be empty")]
        //Arrange   
        public void TestFirstName(string userData, string expected)
        {
            ///Act
            string actual = RegexPattern.CheckFirstName(userData);
            ///Asert
            Assert.AreEqual(expected, actual);
        }

        //Test case for validating last name
        [TestCategory("User Name")]
        [TestMethod]
        [DataRow("Verma", "Verma")]
        [DataRow("Pandey", "Pandey")]
        [DataRow("Pa", "Last name should starts with Cap and should have minimum 3 characters")]
        [DataRow("verma", "Last name should starts with Cap and should have minimum 3 characters")]
        [DataRow("raj4124", "Last name should starts with Cap and should have minimum 3 characters")]
        [DataRow(null, "Object reference not set to an instance of an object.")]
        [DataRow("", "Last name should not be empty")]
        //Arrange   
        public void TestLastName(string userData, string expected)
        {
            ///Act
            string actual = RegexPattern.CheckLastName(userData);
            ///Asert
            Assert.AreEqual(expected, actual);
        }

        //Test case for validating Email Id
        [TestCategory("User EmailId")]
        [TestMethod]
        [DataRow("abc@gmail.com", "abc@gmail.com")]
        [DataRow("abc-100@yahoo.com", "abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com", "abc.100@yahoo.com")]
        [DataRow("abc111@yahoo.com", "abc111@yahoo.com")]
        [DataRow("abc111@abc.com", "abc111@abc.com")]
        [DataRow("abc-100@abc.net", "abc-100@abc.net")]
        [DataRow("abc.100@abc.com.au", "abc.100@abc.com.au")]
        [DataRow("abc@1.com", "abc@1.com")]
        [DataRow("abc@gmail.com.com", "abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com", "abc+100@gmail.com")]
        [DataRow("abc", "The given email id is not valid")]
        [DataRow("abc@.com.my", "The given email id is not valid")]
        [DataRow("abc123@.com", "The given email id is not valid")]
        [DataRow("abc123@.com.com", "The given email id is not valid")]
        [DataRow("abc()*@gmail.com", "The given email id is not valid")]
        [DataRow(".abc@abc.com", "The given email id is not valid")]
        [DataRow("abc@%*.com", "The given email id is not valid")]
        [DataRow("abc..2002@gmail.com", "The given email id is not valid")]
        [DataRow("abc.@gmail.com", "The given email id is not valid")]
        [DataRow("abc@abc@gmail.com", "The given email id is not valid")]
        [DataRow("abc@gmail.com.1a", "The given email id is not valid")]
        [DataRow("abc@gmail.com.aa.au", "The given email id is not valid")]
        [DataRow(null, "Object reference not set to an instance of an object.")]
        [DataRow("", "Email id should not be empty")]
        //Arrange   
        public void TestUserEmailId(string userData, string expected)
        {
            ///Act
            string actual = RegexPattern.CheckEmail(userData);
            ///Asert
            Assert.AreEqual(expected, actual);
        }

        //Test case for validating phone number
        [TestCategory("User Phone Number")]
        [TestMethod]
        [DataRow("91 1254987267", "91 1254987267")]
        [DataRow("91 7894561302", "91 7894561302")]
        [DataRow("91 9984290505", "91 9984290505")]
        [DataRow("91 0842905050", "The mobile number should follow 91 10 digits E.g. 91 9919819801")]
        [DataRow("919842905050", "The mobile number should follow 91 10 digits E.g. 91 9919819801")]
        [DataRow("919842905", "The mobile number should follow 91 10 digits E.g. 91 9919819801")]
        [DataRow("91 984290", "The mobile number should follow 91 10 digits E.g. 91 9919819801")]
        [DataRow("91 984290505000000", "The mobile number should follow 91 10 digits E.g. 91 9919819801")]
        [DataRow(null, "Object reference not set to an instance of an object.")]
        [DataRow("", "Mobile number should not be empty")]
        public void TestUserPhoneNumber(string userData, string expected)
        {
            ///Act
            string actual = RegexPattern.CheckMobileNumber(userData);
            ///Asert
            Assert.AreEqual(expected, actual);
        }

        //Test case for validating password
        [TestCategory("User Password")]
        [TestMethod]
        [DataRow("Rajkumar@1234", "Rajkumar@1234")]
        [DataRow("raJkV#Ver123", "raJkV#Ver123")]
        [DataRow("verma@Raj1V", "verma@Raj1V")]
        [DataRow("@VermA124", "@VermA124")]
        [DataRow("123@RajK", "123@RajK")]
        [DataRow("Vr-raj123", "Vr-raj123")]
        [DataRow("Rajk_123", "Rajk_123")]
        [DataRow("Rajk.1234", "Rajk.1234")]
        [DataRow("Rajk)@1234", "The given password is not valid")]
        [DataRow("Rajk@verma", "The given password is not valid")]
        [DataRow("raj1234", "The given password is not valid")]
        [DataRow("raj@1234", "The given password is not valid")]
        [DataRow("@raj#24verma", "The given password is not valid")]
        [DataRow(")raj425", "The given password is not valid")]
        [DataRow("raj5432)", "The given password is not valid")]
        [DataRow("raj-kumar@24V", "The given password is not valid")]
        [DataRow("rajKumar@v", "The given password is not valid")]
        [DataRow(null, "Value cannot be null.\r\nParameter name: input")]
        [DataRow("", "Password should not be empty")]
        public void TestUserPassword(string userData, string expected)
        {
            ///Act
            string actual = RegexPattern.CheckPassword(userData);
            ///Asert
            Assert.AreEqual(expected, actual);
        }

        //Test case for properties not found and if found setting properties(UC13)
        [TestCategory("Reflection")]
        [TestMethod]
        [DataRow("FirstName", "Raj", "Raj")]
        [DataRow("LastName", "Verma", "Verma")]
        [DataRow("EmailId", "abc123@yahoo.com", "abc123@yahoo.com")]
        [DataRow("PhoneNum", "91 9874561230", "91 9874561230")]
        [DataRow("Password", "abc_1234", "abc_1234")]
        [DataRow("firstName", "Raj", "No such field found")]
        [DataRow("lastName", "verma", "No such field found")]
        [DataRow("emailId", "verma", "No such field found")]
        [DataRow("password", "verma", "No such field found")]
        [DataRow("phoneNum", "verma", "No such field found")]
        public void TestSetFeild(string propertyName, string propertyValue, string expected)
        {
            try
            {
                UserRegReflector userRegReflector = new UserRegReflector();
                ///Act
                var actual = userRegReflector.SetProperty(propertyName, propertyValue);
                ///Asert
                Assert.AreEqual(expected, actual);
            }
            catch (UserRegCustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }         
        }
    }
}
