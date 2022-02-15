using System;
using System.Reflection;

namespace ReflectionAndAnnotation
{
    /// <summary>
    /// Setting property feild using reflection(UC13)
    /// </summary>
    public class UserRegReflector
    {
        //Create object for Class UserRegAnnotation
        UserRegAnnotation userReg = new UserRegAnnotation();

        //Method To Use Create MoodAnalyser with Parameter Constructor Using Reflection(UC13)
        public object CreateUserRegObject(string className, string constructor, UserRegAnnotation userReg)
        {
            Type type = typeof(ValidateUserRegisteration);
            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if (type.Name.Equals(constructor))
                {
                    ConstructorInfo constructorInfo = type.GetConstructor(new[] { typeof(UserRegAnnotation) });
                    var obj = constructorInfo.Invoke(new object[] { userReg });
                    return obj;
                }
                else
                    throw new UserRegCustomException(UserRegCustomException.ExceptionType.CONSTRUCTOR_NOT_FOUND, "No Such Constructor");
            }
            else
                throw new UserRegCustomException(UserRegCustomException.ExceptionType.CLASS_NOT_FOUND, "No Such Class");
        }

        //Method to set the field dynamically using reflection(UC13)
        public string SetProperty(string PropertyName, string userValue)
        {   
            Type type = userReg.GetType();
            //Get Property for which value is to be assigned
            PropertyInfo propertyInfo = type.GetProperty(PropertyName);
            //Set Value for that Property
            if(propertyInfo == null)
                throw new UserRegCustomException(UserRegCustomException.ExceptionType.FIELD_NOT_EXIST, "No such field found");
            else
            { 
                if (PropertyName.Equals(propertyInfo.Name))
                {
                    propertyInfo.SetValue(userReg, userValue, null);
                    return userValue;
                }
            }
            return default;
        }

        //Method to Use Reflection To Invoke Method(UC13)
        public void InvokeAnalyserMethod(string methodName)
        {
            try
            {
                UserRegReflector regReflector = new UserRegReflector();
                Type type = typeof(ValidateUserRegisteration);
                MethodInfo methodInfo = type.GetMethod(methodName);
                object testUserRegObject = regReflector.CreateUserRegObject("ReflectionAndAnnotation.ValidateUserRegisteration", "ValidateUserRegisteration", userReg);
                object method = methodInfo.Invoke(testUserRegObject, null);
            }
            catch (NullReferenceException)
            {
                throw new UserRegCustomException(UserRegCustomException.ExceptionType.METHOD_NOT_FOUND, "No Such Method");
            }
        }
    }
}
