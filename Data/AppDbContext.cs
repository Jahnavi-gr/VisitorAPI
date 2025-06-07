using Microsoft.EntityFrameworkCore;
using VisitorAPI.Models;

namespace VisitorAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Visitor> Visitors { get; set; }

         // Override OnModelCreating to configure model
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Visitor>()
                .Property(v => v.IsBlacklisted)
                .HasColumnName("is_blacklisted");
            
            modelBuilder.Entity<Visitor>()
                .Property(v => v.VisitDate)
                .HasColumnName("visit_date");

            modelBuilder.Entity<Visitor>()
                .Property(v => v.Company)
                .HasColumnName("company");

            modelBuilder.Entity<Visitor>()
                .Property(v => v.Reason)
                .HasColumnName("reason");    
        }
    }
}
