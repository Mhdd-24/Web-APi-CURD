using Microsoft.AspNetCore.Identity;

namespace EmployeeAdminPortal.Models
{
    public class AppUser: IdentityUser
    {
        public string? FullName { get; set; }
    }
}