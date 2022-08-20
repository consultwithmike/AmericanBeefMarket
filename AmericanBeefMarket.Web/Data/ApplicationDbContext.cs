using AmericanBeefMarket.DataModel;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AmericanBeefMarket.Web.Data
{
	public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{
		public DbSet<Customer> Customers { get; set; }

		public DbSet<Ranch> Ranches { get; set; }

		public DbSet<Item> Items { get; set; }

		public DbSet<Order> Orders { get; set; }

		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
				: base(options)
		{
		}
	}
}
