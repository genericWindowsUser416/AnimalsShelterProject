using HomelessAnimalsShelter.Core.Dtos;

namespace HomelessAnimalsShelter.DAL
{
	public class ShelterRepository
	{
		public List<ShelterDto> GetAllShelters()
		{
			var s1 = new ShelterDto()
			{
				Id = 1,
				Name = "Прют QQQ",
				Description = "лучший приют 2025",
				City = "Омск"
			};

			var s2 = new ShelterDto()
			{
				Id = 2,
				Name = "Прют WWW",
				Description = "лучший приют 2026",
				City = "Оренбург"
			};

			var s3 = new ShelterDto()
			{
				Id = 3,
				Name = "Приют ещё один",
				Description = "лучший приют 2301",
				City = "Москва"
			};

			return new List<ShelterDto> { s1, s2, s3 };
		}

		public ShelterDto GetShelterById(int id)
		{
			return new ShelterDto()
			{
				Id = id,
				Name = "Приют такой-то",
				Description = "лучший приют всегда",
				City = "Там"
			};
		}
	}
}
