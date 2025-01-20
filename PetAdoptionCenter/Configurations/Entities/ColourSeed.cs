using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetAdoptionCenter.Domain;

namespace PetAdoptionCenter.Configurations.Entities
{
    public class ColourSeed : IEntityTypeConfiguration<Colour>
    {
        public void Configure(EntityTypeBuilder<Colour> builder)
        {
            builder.HasData(
                new Colour
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
                new Colour
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
