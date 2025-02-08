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
                    Email = "user@example.com",
                    ApplicationDate = DateTime.Now,
                    PetID = 101,
                    IsApproved = true, // Approved application
                    IsDeleted = false,
                    ProcessedBy = "admin@localhost.com",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new AdoptionApplication
                {
                    Id = 2,
                    Email = "pending_user@example.com",
                    ApplicationDate = DateTime.Now,
                    PetID = 102,
                    IsApproved = false, // Pending application
                    IsDeleted = false,
                    ProcessedBy = null,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new AdoptionApplication
                {
                    Id = 3,
                    Email = "deleted_user@example.com",
                    ApplicationDate = DateTime.Now.AddDays(-10),
                    PetID = 103,
                    IsApproved = false,
                    IsDeleted = true, // Soft deleted application
                    ProcessedBy = null,
                    DateCreated = DateTime.Now.AddDays(-10),
                    DateUpdated = DateTime.Now.AddDays(-10),
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
