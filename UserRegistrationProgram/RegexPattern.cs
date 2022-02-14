using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistrationProgram
{
    public class RegexPattern
    {
        //Method to check and take the first name using regex and custom exception handling(UC1 & UC10)
        public static string CheckFirstName(string firstName)
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
            catch(UserRegistrationException ex)
            {
                return ex.Message;
            }
            catch (NullReferenceException ex)
            {
                return ex.Message;
            }

        }

        //Method to check and take the last name using regex(UC2)
        public static string CheckLastName(string lastName)
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
        }

        //Method to check and take the valid email using regex(UC3)
        public static string CheckEmail(string emailId)
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
        }

        //Method to check and take the valid mobile number using regex(UC4)
        public static string CheckMobileNumber(string mobileNum)
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
            catch(UserRegistrationException ex)
            {
                return ex.Message;
            }
            catch (NullReferenceException ex)
            {
                return ex.Message;
            }
        }

        //Method to check and take the valid password using regex(UC5,UC6,UC7 & UC8)
        public static string CheckPassword(string password)
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
        }
    }
}
