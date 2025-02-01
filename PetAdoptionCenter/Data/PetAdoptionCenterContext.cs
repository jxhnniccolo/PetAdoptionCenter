using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PetAdoptionCenter.Configurations.Entities;
using PetAdoptionCenter.Data;
using PetAdoptionCenter.Domain;

namespace PetAdoptionCenter.Data
{
    public class PetAdoptionCenterContext(DbContextOptions<PetAdoptionCenterContext> options) : IdentityDbContext<PetAdoptionCenterUser>(options)
    {

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new PetSeed());
            builder.ApplyConfiguration(new VolunteerSeed());
            builder.ApplyConfiguration(new Configurations.Entities.AdoptionApplicationSeed());
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
