using Microsoft.AspNetCore.Identity;

namespace EmployeeAdminPortal.Models.Entities
{
    public class Employee : IdentityUser
    {
        public Guid Id { get; set; }

        public required string Name { get; set; }

        public required string Email { get; set; }

        public string? Phone { get; set; }

        public decimal Salary { get; set; }

    }
}