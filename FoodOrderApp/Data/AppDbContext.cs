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
            modelBuilder.Entity<MenuItem>()
                .Property(m => m.Id)
                .ValueGeneratedOnAdd();
        }
    }
}
