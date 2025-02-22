using HomelessAnimalsShelter.Core.Dtos;

namespace HomelessAnimalsShelter.DAL
{
	public class DonationRepository
	{
		public DonationDto GetDonationById(int id)
		{
			using (Context context = new Context())
			{
				return context.Donations.Where(r => r.Id == id).First();
			}
		}

		public List<DonationDto> GetAllDonations()
		{
			using (Context context = new Context())
			{
				return context.Donations
							  .Select(d => new DonationDto
							  {
								  Id = d.Id,
								  Name = d.Name,
								  Description = d.Description,
								  Shelter = d.Shelter,
								  NeededMoney = d.NeededMoney,
								  CollectedMoney = d.CollectedMoney
							  })
							  .ToList();
			}
		}
	}
}
