using FoodOrderApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodOrderApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<MenuItem> MenuItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MenuItem>().HasKey(m => m.Id);
            modelBuilder.Entity<MenuItem>().Property(m => m.Name).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<MenuItem>().Property(m => m.Description).HasMaxLength(500).IsRequired();
            modelBuilder.Entity<MenuItem>().Property(m => m.ImageUrl).HasMaxLength(2048).IsRequired();
            modelBuilder.Entity<MenuItem>().Property(m => m.Price).HasColumnType("decimal(8,2)").IsRequired();
            modelBuilder.Entity<MenuItem>().Property(m => m.IsAvailable).IsRequired();
        }
    }
}
