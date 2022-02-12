using System.ComponentModel.DataAnnotations;

namespace EyeC.API.ViewModels
{
    public class Login
    {
        [Required(ErrorMessage = "User name or Email is required.")]
        [EmailAddress]
        public string Email { get; set; } = String.Empty;

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = String.Empty;
    }
}