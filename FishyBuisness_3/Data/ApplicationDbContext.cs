using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FishyBuisness_3.Models;

namespace FishyBuisness_3.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}
	    public DbSet<FishyBuisness_3.Models.Fish> Fish { get; set; } = default!;
        public DbSet<FishyBuisness_3.Models.ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<WarehouseItem> WarehouseItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Konfiguracja relacji między WarehouseItem, Product i Warehouse
            modelBuilder.Entity<WarehouseItem>()
                .HasOne(wi => wi.Product)
                .WithMany()
                .HasForeignKey(wi => wi.ProductId);

            modelBuilder.Entity<WarehouseItem>()
                .HasOne(wi => wi.Warehouse)
                .WithMany()
                .HasForeignKey(wi => wi.WarehouseId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
