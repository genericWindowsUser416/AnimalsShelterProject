using Microsoft.EntityFrameworkCore;
using HomelessAnimalsShelter.Core.Dtos;

namespace HomelessAnimalsShelter.DAL
{
	public class Context : DbContext
	{
		public DbSet<UserDto> Users { get; set; }

		public DbSet<ShelterDto> Shelters { get; set; }

		public DbSet<AnimalDto> Animals { get; set; }

		public DbSet<TagDto> Tags { get; set; }

		public DbSet<ReviewDto> Reviews { get; set; }

		public DbSet<DonationDto> Donations { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			string connectionString = Environment.GetEnvironmentVariable("HOMELESSANIMALSSHELTERIIN_ACCESS")!;
			optionsBuilder.UseNpgsql(connectionString);
		}
	}
}
