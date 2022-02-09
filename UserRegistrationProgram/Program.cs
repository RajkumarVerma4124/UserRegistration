using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Displaying the welcome message
            Console.WriteLine("Welcome To The User Registration Program\n");

            //Validating user entered a valid firstname or not(UC1)
           
            RegexPattern.CheckFirstName();
            Console.ReadLine();
        }
    }
}
