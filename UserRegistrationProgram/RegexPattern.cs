using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProgram
{
    /// <summary>
    /// User Registration Program To Check The User Details Using Regex And Refactoring The Code Using ambda Function
    /// </summary>
    public class RegexPattern
    {
        //Method to check and take the first name using regex and custom exception handling and refactor using lambda expression(UC1,UC10 & UC14)
        public static Func<string, string> CheckFirstName = (firstName) =>
        {
            try
            {
                //Pattern for checking the first name that starts with cap and has min 3 characters(UC1)
                string fNamePattern = "(^[A-Z]{1}[a-z]{2,}$)";

                if (firstName.Equals(""))
                {
                    throw new UserRegistrationException(UserRegistrationException.ExceptionTypes.EMPTY_MESSAGE_EXCEPTION, "First name should not be empty");
                }
                if (Regex.IsMatch(firstName, fNamePattern))
                {
                    Console.Write("The entered first name is valid : ");
                    return firstName;
                }
                else
                {
                    throw new UserRegistrationException(UserRegistrationException.ExceptionTypes.INVALID_MESSAGE_EXCEPTION, "First name should starts with Cap and should have minimum 3 characters");
                }
            }
            catch (UserRegistrationException ex)
            {
                return ex.Message;
            }
            catch (NullReferenceException ex)
            {
                return ex.Message;
            }

        };

        //Method to check and take the last name using regex and refactor using lambda expression(UC2,UC10 UC14)
        public static Func<string, string> CheckLastName = (lastName) =>
        {
            try
            {
                //Pattern for checking the last name that starts with cap and has min 3 characters(UC2)
                string lNamePattern = "(^[A-Z]{1}[a-z]{2,}$)";

                if (lastName.Equals(""))
                {
                    throw new UserRegistrationException(UserRegistrationException.ExceptionTypes.EMPTY_MESSAGE_EXCEPTION, "Last name should not be empty");
                }
                if (Regex.IsMatch(lastName, lNamePattern))
                {
                    Console.Write("The given last name is valid : ");
                    return lastName;
                }
                else
                {
                    throw new UserRegistrationException(UserRegistrationException.ExceptionTypes.INVALID_MESSAGE_EXCEPTION, "Last name should starts with Cap and should have minimum 3 characters");
                }
            }
            catch (UserRegistrationException ex)
            {
                return ex.Message;
            }
            catch (NullReferenceException ex)
            {
                return ex.Message;
            }
        };

        //Method to check and take the valid email using regex and refactor using lambda expression(UC3,UC10 UC14)
        public static Func<string, string> CheckEmail = (emailId) =>
        {
            try
            {
                //Pattern for checking the email id(UC3)
                string emailIdPattern = "^[a-zA-Z0-9]{3,}([._+-][0-9a-zA-Z]{2,})*@[0-9a-zA-Z]+[.]?([a-zA-Z]{2,4})+[.]?([a-zA-Z]{2,3})*$";

                if (emailId.Equals(""))
                {
                    throw new UserRegistrationException(UserRegistrationException.ExceptionTypes.EMPTY_MESSAGE_EXCEPTION, "Email id should not be empty");
                }
                if (Regex.IsMatch(emailId, emailIdPattern))
                {
                    Console.Write("The given email id is valid : ");
                    NLog.SuccessInfo("The given email id is valid " + emailId);
                    return emailId;
                }
                else
                {
                    throw new UserRegistrationException(UserRegistrationException.ExceptionTypes.INVALID_MESSAGE_EXCEPTION, "The given email id is not valid");
                }
            }
            catch (UserRegistrationException ex)
            {
                return ex.Message;
            }
            catch (NullReferenceException ex)
            {
                return ex.Message;
            }
        };

        //Method to check and take the valid mobile number using regex and refactor using lambda expression(UC4,UC10 UC14)
        public static Func<string, string> CheckMobileNumber = (mobileNum) =>
        {
            try
            {
                //Pattern for checking the mobile number(UC4)
                string mobNumPattern = "^91[ ][1-9][0-9]{9}$";

                if (mobileNum.Equals(""))
                {
                    throw new UserRegistrationException(UserRegistrationException.ExceptionTypes.EMPTY_MESSAGE_EXCEPTION, "Mobile number should not be empty");
                }
                if (Regex.IsMatch(mobileNum, mobNumPattern))
                {
                    Console.Write("The given mobile number is valid : ");
                    return mobileNum;
                }
                else
                {
                    throw new UserRegistrationException(UserRegistrationException.ExceptionTypes.INVALID_MESSAGE_EXCEPTION, "The mobile number should follow 91 10 digits E.g. 91 9919819801");
                }
            }
            catch (UserRegistrationException ex)
            {
                return ex.Message;
            }
            catch (NullReferenceException ex)
            {
                return ex.Message;
            }
        };

        //Method to check and take the valid password using regex and refactor using lambda expression(UC5,UC6,UC7,UC8,UC10 UC14)
        public static Func<string, string> CheckPassword = (password) =>
        {
            try
            {
                //Pattern for checking the password for having atleast one uppercase and number and exactly one special character(UC5,UC6,UC7 & UC8)
                string passwordPattern = "^(?=.*[A-Z])(?=.*[\\d])(?=.*[\\W_])[a-zA-Z0-9\\[~!\\.@_#\\$%^\\/&*()+\\-{}:\"<>?\\]]{8,}$";
                string specialChar = "[\\[~!\\.@#$%_^&*\\/()+\\-{}:\" <>?\\]]";
                int count = Regex.Matches(password, specialChar).Count;

                if (password.Equals(""))
                {
                    throw new UserRegistrationException(UserRegistrationException.ExceptionTypes.EMPTY_MESSAGE_EXCEPTION, "Password should not be empty");
                }
                if (Regex.IsMatch(password, passwordPattern) && count == 1)
                {
                    Console.Write("The given password is valid : ");
                    return password;
                }
                else
                {
                    throw new UserRegistrationException(UserRegistrationException.ExceptionTypes.INVALID_MESSAGE_EXCEPTION, "The given password is not valid");
                }
            }
            catch (UserRegistrationException ex)
            {
                return ex.Message;
            }
            catch (ArgumentNullException ex)
            {
                return ex.Message;
            }
        };
    }
}
