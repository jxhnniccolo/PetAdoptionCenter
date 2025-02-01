using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetAdoptionCenter.Domain;

namespace PetAdoptionCenter.Configurations.Entities
{
    public class PetSeed : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder.HasData(
                new Pet
                {
                    Id = 1,
                    Name = "Black",
                    Species = "Dog",
                    Breeed = "poodle",
                    Age = 18,
                    Description = "Male",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Pet
                {
                    Id = 2,
                    Name = "white",
                    Species = "Dog",
                    Breeed = "poodle",
                    Age = 7,
                    Description = "Female",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );

        }
    }
}
