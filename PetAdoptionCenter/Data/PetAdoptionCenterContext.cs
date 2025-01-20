using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PetAdoptionCenter.Configurations.Entities;
using PetAdoptionCenter.Data;
using PetAdoptionCenter.Domain;

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
        public DbSet<PetAdoptionCenter.Domain.Pet> Pet { get; set; } = default!;
        public DbSet<PetAdoptionCenter.Domain.Staff> Staff { get; set; } = default!;
        public DbSet<PetAdoptionCenter.Domain.User> User { get; set; } = default!;
        public DbSet<PetAdoptionCenter.Domain.AdoptionApplication> AdoptionApplication { get; set; } = default!;
        public DbSet<PetAdoptionCenter.Domain.Volunteer> Volunteer { get; set; } = default!;
    }
}
