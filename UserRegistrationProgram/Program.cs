using System;

namespace UserRegistrationProgram
{
    /// <summary>
    /// Program for validating user registartion feild using regex
    /// </summary>
    public class Program
    {
        //Declaring variable
        public static string result;
        public static void Main(string[] args)
        {
            //Displaying the welcome message
            Console.WriteLine("Welcome To The User Registration Program");
            
            //User registration progrm with exception handling
            try
            {
                while (true)
                {
                    Console.WriteLine("\n1: Enter Your First Name \n2: Enter Your Last Name \n3: Enter Your Email Id \n4: Enter Your Mobile Number \n5: Enter Your Password \n6: Exit");
                    Console.Write("Enter a choice from above : ");
                    bool resVal = int.TryParse(Console.ReadLine(), out int choice);
                    if (resVal)
                    {
                        switch (choice)
                        {
                            case 1:
                                //Validating that user entered a valid firstname or not(UC1)
                                Console.Write("Enter Your First Name : ");
                                string firstName = Console.ReadLine();
                                result = RegexPattern.CheckFirstName(firstName);
                                Console.Write(result);
                                break;
                            case 2:
                                //Validating that user entered a valid lastname or not(UC2)
                                Console.Write("Enter Your Last Name : ");
                                string lastName = Console.ReadLine();
                                result = RegexPattern.CheckLastName(lastName);
                                Console.Write(result);
                                break;
                            case 3:
                                //Validating that user entered a valid lastname or not(UC3)
                                Console.Write("Enter Your Email Id : ");
                                string emailId = Console.ReadLine();
                                result = RegexPattern.CheckEmail(emailId);
                                Console.Write(result);
                                break;
                            case 4:
                                //Validating that user entered a valid mobile number or not(UC4)
                                Console.Write("Enter Your Mobile Number : ");
                                string mobileNum = Console.ReadLine();
                                result = RegexPattern.CheckMobileNumber(mobileNum);
                                Console.Write(result);
                                break;
                            case 5:
                                //Validating that user entered a valid password or not(UC5)
                                Console.Write("Enter Your password : ");
                                string password = Console.ReadLine();
                                result = RegexPattern.CheckPassword(password);
                                Console.Write(result);
                                break;
                            case 6:
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Enter a valid choice");
                                continue;
                        }
                    }
                    else
                        Console.WriteLine("Enter some input value");
                }
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
