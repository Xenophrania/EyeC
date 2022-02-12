using Microsoft.AspNetCore.Identity;

namespace EyeC.Infrastructure.Entities
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;
    }
}