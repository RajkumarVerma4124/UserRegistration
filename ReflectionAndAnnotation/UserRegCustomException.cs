using System;

namespace ReflectionAndAnnotation
{
    /// <summary>
    /// Creating User Registeration Custom Class Exception
    /// </summary>
    public class UserRegCustomException:Exception
    {
        ExceptionType type;
        public enum ExceptionType
        {
            FIELD_NOT_EXIST, METHOD_NOT_FOUND, CONSTRUCTOR_NOT_FOUND, CLASS_NOT_FOUND
        }
        public UserRegCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }   
    }
}
