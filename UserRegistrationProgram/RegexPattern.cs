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
        //Method to check and take the first name using regex(UC1)
        public static void CheckFirstName()
        {
            Console.Write("Enter Your First Name : ");
            string firstName = Console.ReadLine();

            //Pattern for checking the first name that starts with cap and has min 3 characters(UC1)
            string fNamePattern = "(^[A-Z]{1}[a-z]{2,}$)";
            if (Regex.IsMatch(firstName, fNamePattern))
                Console.WriteLine("The entered first name is valid\n");
            else
            {
                Console.WriteLine("First name should starts with Cap and should have minimum 3 characters\n");
                CheckFirstName();
            }
        }

        //Method to check and take the last name using regex(UC2)
        public static void CheckLastName()
        {
            Console.Write("Enter Your First Name : ");
            string lastName = Console.ReadLine();

            //Pattern for checking the last name that starts with cap and has min 3 characters(UC2)
            string lNamePattern = "(^[A-Z]{1}[a-z]{2,}$)";
            if (Regex.IsMatch(lastName, lNamePattern))
                Console.WriteLine("The given last name is valid\n");
            else
            {
                Console.WriteLine("Last name should starts with Cap and should have minimum 3 characters\n");
                CheckLastName();
            }
        }

        //Method to check and take the valid email using regex(UC3)
        public static void CheckEmail()
        {
            Console.Write("Enter Your Email Id : ");
            string emailId = Console.ReadLine();

            //Pattern for checking the email id(UC3)
            string emailIdPattern = "^[a-zA-Z0-9]{3,7}([._+-][0-9a-zA-Z]{1,7})*@[0-9a-zA-Z]+[.]?([a-zA-Z]{2,4})+[.]?([a-zA-Z]{2,3})*$";
            if (Regex.IsMatch(emailId, emailIdPattern))
                Console.WriteLine("The given email id is valid\n");
            else
            {
                Console.WriteLine("The given email id is not valid\n");
                CheckEmail();
            }
        }

        //Method to check and take the valid mobile number using regex(UC4)
        public static void CheckMobileNumber()
        {
            Console.Write("Enter Your Mobile Number : ");
            string mobileNum = Console.ReadLine();

            //Pattern for checking the mobile number(UC4)
            string mobNumPattern = "^91[ ][1-9][0-9]{9}$";
            if (Regex.IsMatch(mobileNum, mobNumPattern))
                Console.WriteLine("The given mobile number is valid\n");
            else
            {
                Console.WriteLine("The number should follow 91 10 digits E.g. 91 9919819801\n");
                CheckMobileNumber();
            }
        }

        //Method to check and take the valid password using regex(UC5,UC6,UC7 & UC8)
        public static void CheckPassword()
        {
            Console.Write("Enter Your password : ");
            string password = Console.ReadLine();

            //Pattern for checking the password for having atleast one uppercase and number and exactly one special character(UC5,UC6,UC7 & UC8)
            string passwordPattern = "^(?=.*[A-Z])(?=.*[\\d])(?=.*[\\W])[a-zA-Z0-9[~!@#$%^&*()_+{}:\"<>?]{8,}$";
            string specialChar = "[~!@#$%^&*()_+{}:\" <>?]";
            int count = Regex.Matches(password, specialChar).Count;
            Console.WriteLine(count);
            if (Regex.IsMatch(password, passwordPattern) && count == 1)
                Console.WriteLine("The given password is valid\n");
            else
            {
                Console.WriteLine("The given password is not valid\n");
                CheckPassword();
            }
        }
    }
}
