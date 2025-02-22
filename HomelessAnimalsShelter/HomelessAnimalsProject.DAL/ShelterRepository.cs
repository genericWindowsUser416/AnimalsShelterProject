using HomelessAnimalsShelter.Core.Dtos;

namespace HomelessAnimalsShelter.DAL
{
	public class ShelterRepository
	{
		public ShelterDto GetShelterById(int id)
		{
			using (Context context = new Context())
			{
				return context.Shelters.Where(s => s.Id == id).First();
			}
		}

		public List<ShelterDto> GetAllShelters()
		{
			using (Context context = new Context())
			{
				return context.Shelters
							  .Select(s => new ShelterDto
							  {
								  Id = s.Id,
								  Name = s.Name,
								  Description = s.Description,
								  City = s.City,
								  DonationDtos = s.DonationDtos,
								  User = s.User,
								  AnimalDtos = s.AnimalDtos
							  })
							  .ToList();
			}
		}
	}
}
