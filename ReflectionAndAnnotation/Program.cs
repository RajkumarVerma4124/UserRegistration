using System;

namespace ReflectionAndAnnotation
{
    public class Program
    {
        //Main entry of the program
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the user registeration with reflection and annotation program");

            //Creating object of ValidateUserRegisteration to call validate user method(UC13)
            ValidateUserRegisteration userReg = new ValidateUserRegisteration();
            userReg.ValidateUser();
        }
    }
}
