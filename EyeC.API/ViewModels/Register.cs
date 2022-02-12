using System.ComponentModel.DataAnnotations;

namespace EyeC.API.ViewModels
{
    public class Register
    {
        [Required(ErrorMessage = "First name is required.")]
        [MaxLength(40)]
        public string FirstName { get; set; } = String.Empty;

        [Required(ErrorMessage = "Last name is required.")]
        [MaxLength(40)]
        public string LastName { get; set; } = String.Empty;

        [Required(ErrorMessage = "User name is required.")]
        [MaxLength(40)]
        public string UserName { get; set; } = String.Empty;

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress]
        public string Email { get; set; } = String.Empty;

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = String.Empty;

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords mismatch.")]
        public string ConfirmPassword { get; set; } = String.Empty;
    }
}