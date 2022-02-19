using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionAndAnnotation
{
    /// <summary>
    /// Using reflection to check all the annotation are satisfied or not
    /// </summary>
    public class ValidateUserRegisteration
    {
        private readonly UserRegAnnotation userRegAnnotation;

        //Default Constructor
        public ValidateUserRegisteration(){ }

        //Parameterized constructor
        public ValidateUserRegisteration(UserRegAnnotation annotation)
        {
            this.userRegAnnotation = annotation;
        }

        //Method to take the input value from user and setting feild using reflection(UC13)
        public void ValidateUser()
        {
            //Taking input from the user for user registraton and storing in an object
            Console.Write("Enter your first name : ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your last name : ");
            string lastName = Console.ReadLine();
            Console.Write("Enter your email Id : ");
            string EmailId = Console.ReadLine();
            Console.Write("Enter your phone Number : ");
            string PhoneNum = Console.ReadLine();
            Console.Write("Enter your password : ");
            string Password = Console.ReadLine();
            
            //Set field Values using Reflection
            UserRegReflector userReg = new UserRegReflector();
            userReg.SetProperty("FirstName", firstName);
            userReg.SetProperty("LastName", lastName);
            userReg.SetProperty("EmailId", EmailId);
            userReg.SetProperty("PhoneNum", PhoneNum);
            userReg.SetProperty("Password", Password);

            //Invoking the TestUserRegAnnotationProperties using reflection(UC13)
            userReg.InvokeAnalyserMethod("TestUserRegAnnotationProperties");
            Console.ReadLine();
        }

        //Method to check the valid annotations
        public void TestUserRegAnnotationProperties()
        {
            ValidationContext validationContext = new ValidationContext(userRegAnnotation);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(userRegAnnotation, validationContext, validationResults, true);
            if (!valid)
            {
                foreach (ValidationResult validationResult in validationResults)
                    Console.WriteLine("{0}", validationResult.ErrorMessage);
            }
            else
                Console.WriteLine("Satisfied all validations for user registration");
            Console.ReadLine();
        }
    }
}
