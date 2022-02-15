using System.ComponentModel.DataAnnotations;

namespace ReflectionAndAnnotation
{
    /// <summary>
    /// Declaring properties of user registration and using inbuilt annotations(UC12)
    /// </summary>
    public class UserRegAnnotation
    {
        //Checking the pattern for first name and giving required annotations for first name property
        [Required(ErrorMessage = "{0} should not be empty")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "First name should starts with Cap and should have minimum 3 characters")]
        [RegularExpression(@"^[A-Z]{1}[a-z]{2,}$", ErrorMessage = "First name is not valid")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        //Checking the pattern for lirst name and giving required annotations for last name property
        [Required(ErrorMessage = "{0} should not be empty")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Lirst name should starts with Cap and should have minimum 3 characters")]
        [RegularExpression(@"^[A-Z]{1}[a-z]{2,}$", ErrorMessage = "Last name is not valid")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        //Checking the pattern for email and giving required annotations for emailId property
        [Required(ErrorMessage = "{0} should not be empty")]
        [RegularExpression(@"^[a-zA-Z0-9]{3,}([._+-][0-9a-zA-Z]{2,})*@[0-9a-zA-Z]+[.]?([a-zA-Z]{2,4})+[.]?([a-zA-Z]{2,3})*$", ErrorMessage = "Email id is not valid")]
        [DataType(DataType.EmailAddress)]
        public string EmailId { get; set; }

        //Checking the pattern for phone number and giving required annotations for phone num property
        [Required(ErrorMessage = "{0} should not be empty")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(13, MinimumLength = 13, ErrorMessage = "Phone number is not valid")]
        [RegularExpression(@"^91[ ][1-9][0-9]{9}$", ErrorMessage = "The mobile number should follow 91 10 digits E.g. 91 9919819801")]
        [Phone]
        public string PhoneNum { get; set; }

        //Checking the pattern for password and giving required annotations for password property
        [Required(ErrorMessage = "{0} should not be empty")]
        [RegularExpression(@"(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=[^.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\]*[.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\][^.,:;'!@#$%^&*_+=|(){}[?\-\]\/\\]*$).{8,}$", ErrorMessage = "Passsword is not valid")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
