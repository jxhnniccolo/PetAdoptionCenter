using Microsoft.AspNetCore.Http.HttpResults;
using System.Net;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetAdoptionCenter.Domain;

namespace PetAdoptionCenter.Configurations.Entities
{
    public class VolunteerSeed : IEntityTypeConfiguration<Volunteer>
    {
        public void Configure(EntityTypeBuilder<Volunteer> builder)
        {
            builder.HasData(
                new Volunteer { 
                    Id = 1,
                    Name = "john",
                    Email = "john@admin.com",
                    PhoneNumber = "987654321",
                    Address = "punggol",
                    Status = "Open",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Volunteer
                {
                    Id = 2,
                    Name = "fitri",
                    Email = "fitri@admin.com",
                    PhoneNumber = "987654321",
                    Address = "punggol",
                    Status = "Open",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
