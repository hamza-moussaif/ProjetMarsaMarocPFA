using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectPFA.Models.Domain;

namespace ProjectPFA.Data
{
    public class PFADbContext : IdentityDbContext<User>
    {
        public PFADbContext(DbContextOptions<PFADbContext> options)
            : base(options)
        {
        }

        public DbSet<Demande> Demandes { get; set; }
        public DbSet<Affectation> Affectations { get; set; }
        public DbSet<Engin> Engins { get; set; }
      

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Create roles
            var assistantRole = new IdentityRole("Assistant")
            {
                NormalizedName = "ASSISTANT"
            };
            var demandeurRole = new IdentityRole("Demandeur")
            {
                NormalizedName = "DEMANDEUR"
            };


            // Seed roles into the database
            builder.Entity<IdentityRole>().HasData(assistantRole, demandeurRole);
        }
    }
}