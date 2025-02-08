namespace PetAdoptionCenter.Domain
{
    public class AdoptionApplication : BaseDomainModel
    {
        public string Email { get; set; } = null!;
        public DateTime? ApplicationDate { get; set; }
        public int PetID { get; set; }
        public bool IsApproved { get; set; } = false; // Default to false (Pending approval)
        public bool IsDeleted { get; set; } = false; // Tracks soft deletion
        public string? ProcessedBy { get; set; }
    }
}
