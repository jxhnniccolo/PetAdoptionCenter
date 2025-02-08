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
                    Name = "Luna",
                    Species = "Dog",
                    Breeed = "Poodle",
                    Age = 10,
                    Description = "Male",
                    ImageUrl = "Image/luna.jpg", // Added image URL
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Pet
                {
                    Id = 2,
                    Name = "Crunchy",
                    Species = "Dog",
                    Breeed = "Poodle",
                    Age = 7,
                    Description = "Female",
                    ImageUrl = "Image/crunchy.jpg", // Added image URL
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Pet
                {
                    Id = 3,
                    Name = "Leo",
                    Species = "Cat",
                    Breeed = "Maine Coon",
                    Age = 2,
                    Description = "Male",
                    ImageUrl = "Image/cat_leo.jpg", // Added image URL
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
