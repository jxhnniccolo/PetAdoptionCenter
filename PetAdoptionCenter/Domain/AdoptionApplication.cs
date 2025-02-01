using Microsoft.Extensions.Configuration.UserSecrets;

namespace PetAdoptionCenter.Domain
{
    public class AdoptionApplication : BaseDomainModel
    {
        public string? Status { get; set; }
        public DateTime? ApplicationDate { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public int UserID { get; set; }
        public string? PetID { get; set; }
        public string? ProcessedBy { get; set; }
    }
}
