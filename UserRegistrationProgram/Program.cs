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

            while(true)
            {
                Console.WriteLine("1: Enter Your First Name \n2: Enter Your Last Name \n3: Enter Your Email Id \n4: Enter Your Mobile Number \n5: Exit");
                Console.Write("Enter a choice from above : ");
                bool resVal = int.TryParse(Console.ReadLine(), out int choice);
                if(resVal)
                {
                    switch(choice)
                    {
                        case 1:
                            //Validating that user entered a valid firstname or not(UC1)
                            RegexPattern.CheckFirstName();
                            break;
                        case 2:
                            //Validating that user entered a valid lastname or not(UC2)
                            RegexPattern.CheckLastName();
                            break;
                        case 3:
                            //Validating that user entered a valid lastname or not(UC3)
                            RegexPattern.CheckEmail();
                            break;
                        case 4:
                            //Validating that user entered a valid mobile number or not(UC4)
                            RegexPattern.CheckMobileNumber();
                            break;
                        case 5:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Enter a valid choice\n");
                            continue;
                    }
                }
                else
                    Console.WriteLine("Enter some input value\n");
            }
        }
    }
}
