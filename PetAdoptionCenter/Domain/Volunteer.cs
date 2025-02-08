namespace PetAdoptionCenter.Domain
{
    public class Volunteer : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }

        // Replacing Status with IsApproved
        public bool IsApproved { get; set; } = false; // Default to false (Pending approval)
    }
}
