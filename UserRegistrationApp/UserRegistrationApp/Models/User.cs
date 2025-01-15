using System.ComponentModel.DataAnnotations;

namespace UserRegistrationApp.Models
{
    public class User
    {
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required.")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password and Confirm Password must match.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Age is required.")]
        [Range(21, 30, ErrorMessage = "Age must be between 21 and 30.")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "User ID is required.")]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*\d).{7,20}$",
            ErrorMessage = "User ID must be 7-20 characters long, contain at least one capital letter and one digit.")]
        public string UserId { get; set; }
    }
}