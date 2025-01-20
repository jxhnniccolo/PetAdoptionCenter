namespace PetAdoptionCenter.Domain
{
    public class Model : BaseDomainModel
    {
        public string? Status { get; set; }
        public DateTime? ApplicationDate { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public int UserID { get; set; }
        public string? PetID { get; set; }
        public string? ProcessedBy { get; set; }
    }
}
