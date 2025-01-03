using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PetAdoptionCenter.Configurations.Entities;
using PetAdoptionCenter.Data;

namespace PetAdoptionCenter.Data
{
    public class PetAdoptionCenterContext(DbContextOptions<PetAdoptionCenterContext> options) : IdentityDbContext<PetAdoptionCenterUser>(options)
    {

        public DbSet<PetAdoptionCenter.Domain.Make> Make { get; set; } = default!;
        public DbSet<PetAdoptionCenter.Domain.Model> Model { get; set; } = default!;
        public DbSet<PetAdoptionCenter.Domain.Colour> Colour { get; set; } = default!;
        public DbSet<PetAdoptionCenter.Domain.Vehicle> Vehicle { get; set; } = default!;
        public DbSet<PetAdoptionCenter.Domain.Booking> Booking { get; set; } = default!;
        public DbSet<PetAdoptionCenter.Domain.Customer> Customer { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ColourSeed());
            builder.ApplyConfiguration(new MakeSeed());
            builder.ApplyConfiguration(new ModelSeed());
            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserRoleSeed());
            builder.ApplyConfiguration(new UserSeed());
        }
    }
}
