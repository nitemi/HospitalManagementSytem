using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CareTrackPlus.Api.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            SeedRoles(modelBuilder);
        }
        private static void SeedRoles(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData
                (
                new IdentityRole() { Name= "Admin", ConcurrencyStamp= "1", NormalizedName="Admin" },
                new IdentityRole() { Name = "Reception", ConcurrencyStamp = "2", NormalizedName = "Reception" },
                new IdentityRole() { Name = "Doctor", ConcurrencyStamp = "3", NormalizedName = "Doctor" },
                new IdentityRole() { Name = "Nurse", ConcurrencyStamp = "4", NormalizedName = "Nurse" },
                new IdentityRole() { Name = "Pharmacy", ConcurrencyStamp = "5", NormalizedName = "Pharmacy" },
                new IdentityRole() { Name = "Laboratory", ConcurrencyStamp = "6", NormalizedName = "Laboratory" }
            );
        }
    }
}
