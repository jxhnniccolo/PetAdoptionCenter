namespace PetAdoptionCenter.Domain
{
    public class Pet:BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Species { get; set; }
        public string? Breeed { get; set; }
        public string? Age { get; set; }
        public string? Description { get; set; }

        public string? Added_by { get; set; }

    }
}
