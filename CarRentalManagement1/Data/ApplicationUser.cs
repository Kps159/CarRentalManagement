using Microsoft.AspNetCore.Identity;

namespace CarRentalManagement1.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}