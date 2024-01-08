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


    }
}



// FishName, FishDescription, Spieces, Habitat, Lenght, Weight, Price