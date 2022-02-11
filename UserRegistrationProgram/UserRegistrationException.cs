using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationProgram
{
    public class UserRegistrationException: Exception
    {
        //Declaring exception type 
        public ExceptionTypes type;

        //Using enum to differentiate the mood analysis errors(UC3)
        public enum ExceptionTypes
        {
            INVALID_MESSAGE_EXCEPTION,
            EMPTY_MESSAGE_EXCEPTION
        }

        //Constructor to initialize the enum exception types(UC3)
        public UserRegistrationException(ExceptionTypes type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
