using HomelessAnimalsShelter.Core.Dtos;

namespace HomelessAnimalsShelter.DAL
{
	public class DonationRepository
	{
		public List<DonationDto> GetAllDonations()
		{
			var d1 = new DonationDto()
			{
				Id = 1,
				Name = "QQQ",
				Description = "WWW",
				NeededMoney = 1000,
				CollectedMoney = 0
			};

			var d2 = new DonationDto()
			{
				Id = 2,
				Name = "WWW",
				Description = "QQQ",
				NeededMoney = 1500,
				CollectedMoney = 0
			};

			var d3 = new DonationDto()
			{
				Id = 3,
				Name = "DDD",
				Description = "QQQWWW",
				NeededMoney = 500,
				CollectedMoney = 0
			};

			return new List<DonationDto> { d1, d2, d3 };
		}

		public DonationDto GetDonationById(int id)
		{
			return new DonationDto()
			{
				Id = 4,
				Name = "donate 3000",
				Description = "DDD",
				NeededMoney = 9999,
				CollectedMoney = 0
			};
		}
	}
}
