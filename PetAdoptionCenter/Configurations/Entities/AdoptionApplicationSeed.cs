using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetAdoptionCenter.Domain;

namespace PetAdoptionCenter.Configurations.Entities
{
    public class AdoptionApplicationSeed : IEntityTypeConfiguration<AdoptionApplication>
    {
        public void Configure(EntityTypeBuilder<AdoptionApplication> builder)
        {
            builder.HasData(
                new AdoptionApplication
                {
                    Id = 1,
                    Status = "Open",
                    ApplicationDate = DateTime.Now,
                    ApprovalDate = DateTime.Now,
                    UserID = 23,
                    PetID = "dog",
                    ProcessedBy = "ADMIN",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
