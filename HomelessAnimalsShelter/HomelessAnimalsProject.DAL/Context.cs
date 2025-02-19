using Microsoft.EntityFrameworkCore;
using HomelessAnimalsShelter.Core.Dtos;

namespace HomelessAnimalsShelter.Core
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
			string connectionString = "";
			optionsBuilder.UseNpgsql(connectionString);
		}
	}
}
