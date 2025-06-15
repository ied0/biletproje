using biletproje.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace biletproje.Data
{
	public class biletprojeDbContext : IdentityDbContext
	{
		public biletprojeDbContext() { }
		public biletprojeDbContext(DbContextOptions<biletprojeDbContext> options) : base(options) { }
		public DbSet<Movie> Movies { get; set; }
		public DbSet<Showtime> Showtimes { get; set; }
		public DbSet<Showdate> Showdates { get; set; }
		public DbSet<Reservation> Reservations { get; set; }
		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
			builder.Seed();
		}
	}
}
