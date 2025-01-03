using Microsoft.AspNetCore.Identity;

namespace PetAdoptionCenter.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class PetAdoptionCenterUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
