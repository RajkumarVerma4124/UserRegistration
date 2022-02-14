using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserRegisterWithAnnotation;

namespace UserRegWithAnnotations
{
    /// <summary>
    /// Using reflection to check all the annotation are satisfied or not
    /// </summary>
    public class Program
    {
        //Main entry of the program
        public static void Main(string[] args)
        {
            //Calling the object of annotation to initialize the value given by user
            UserRegAnnotation annotation = new UserRegAnnotation();
            
            //Taking input from the user for user registraton
            Console.Write("Enter your first name : ");
            annotation.FirstName = Console.ReadLine();
            Console.Write("Enter your last name : ");
            annotation.LastName = Console.ReadLine();
            Console.Write("Enter your email Id : ");
            annotation.EmailId = Console.ReadLine();
            Console.Write("Enter your phone Number : ");
            annotation.PhoneNum = Console.ReadLine();
            Console.Write("Enter your password : ");
            annotation.Password = Console.ReadLine();
            TestUserRegAnnotationFields(annotation);
            Console.ReadLine();
        }

        //Method to check the valid annotations 
        public static void TestUserRegAnnotationFields(UserRegAnnotation annotation)
        {
            ValidationContext validationContext = new ValidationContext(annotation, null, null);
            List<ValidationResult> validationResults = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(annotation, validationContext, validationResults, true);
            if (!valid)
            {
                foreach (ValidationResult validationResult in validationResults)
                {
                    Console.WriteLine("{0}", validationResult.ErrorMessage);
                }
            }
            else
            {
                Console.WriteLine("Satisfied all validations for user registration");
            }
            Console.ReadLine();
        }
    }
}
