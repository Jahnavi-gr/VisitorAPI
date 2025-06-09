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
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Visitor table mapping
            modelBuilder.Entity<Visitor>().ToTable("visitors");
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

            // Employee table mapping (optional - if needed to rename columns or map table name)
            modelBuilder.Entity<Employee>().ToTable("employees");
            // You can configure employee fields here if needed
        }
    }
}
