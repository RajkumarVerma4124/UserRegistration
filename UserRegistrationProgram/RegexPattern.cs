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
    }
}
