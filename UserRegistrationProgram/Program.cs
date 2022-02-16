using System;

namespace UserRegistrationProgram
{
    /// <summary>
    /// Program for validating user registartion feild using regex
    /// </summary>
    public class Program
    {
        //Declaring variable
        public static string result, firstName, lastName, emailId, mobileNum, password;
        public static void Main(string[] args)
        {
            //Displaying the welcome message
            Console.WriteLine("Welcome To The User Registration Program");
            
            //User registration progrm with exception handling
            try
            {
                while (true)
                {
                    Console.WriteLine("\n1: First Name \n2: Last Name \n3: Email Id \n4: Mobile Number \n5: Password \n6: Display \n7: Exit");
                    Console.Write("Enter a choice from above : ");
                    bool resVal = int.TryParse(Console.ReadLine(), out int choice);
                    if (resVal)
                    {
                        switch (choice)
                        {
                            case 1:
                                //Validating that user entered a valid firstname or not(UC1)
                                Console.Write("Enter Your First Name : ");
                                firstName = Console.ReadLine();
                                result = RegexPattern.CheckFirstName(firstName);
                                Console.Write(result);
                                break;
                            case 2:
                                //Validating that user entered a valid lastname or not(UC2)
                                Console.Write("Enter Your Last Name : ");
                                lastName = Console.ReadLine();
                                result = RegexPattern.CheckLastName(lastName);
                                Console.Write(result);
                                break;
                            case 3:
                                //Validating that user entered a valid lastname or not(UC3)
                                Console.Write("Enter Your Email Id : ");
                                emailId = Console.ReadLine();
                                result = RegexPattern.CheckEmail(emailId);
                                Console.Write(result);
                                break;
                            case 4:
                                //Validating that user entered a valid mobile number or not(UC4)
                                Console.Write("Enter Your Mobile Number : ");
                                mobileNum = Console.ReadLine();
                                result = RegexPattern.CheckMobileNumber(mobileNum);
                                Console.Write(result);
                                break;
                            case 5:
                                //Validating that user entered a valid password or not(UC5)
                                Console.Write("Enter Your password : ");
                                password = Console.ReadLine();
                                result = RegexPattern.CheckPassword(password);
                                Console.Write(result);
                                break;
                            case 6:
                                //Displaying the user entered details
                                Display();
                                break;
                            case 7:
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

        //Method to display user enterd details
        public static void Display()
        {
            Console.WriteLine("\nUser Details Are Listed Below");
            Console.WriteLine("Your First Name Is: {0}", firstName);
            Console.WriteLine("Your Last Name Is: {0}", lastName);
            Console.WriteLine("Your Email Id Is: {0}", emailId);
            Console.WriteLine("Your Phone number Is: {0}", mobileNum);
            Console.WriteLine("Your Password Is: {0}", password);
        }
    }
}
