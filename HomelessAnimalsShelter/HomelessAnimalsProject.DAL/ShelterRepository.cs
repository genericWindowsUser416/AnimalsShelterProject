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
				Buyer_Id = 1,
				Name = "Прют QQQ",
				Description = "лучший приют 2025",
				City = "Омск",
				AnimalList = { 1, 2, 3, 4 },
			};

			var s2 = new ShelterDto()
			{
				Id = 2,
				Buyer_Id = 2,
				Name = "Прют WWW",
				Description = "лучший приют 2026",
				City = "Оренбург",
				AnimalList = { 5, 6, 7, 8 },
			};

			var s3 = new ShelterDto()
			{
				Id = 3,
				Buyer_Id = 3,
				Name = "Приют ещё один",
				Description = "лучший приют 2301",
				City = "Москва",
				AnimalList = { 9, 10, 11, 12 },
			};

			return new List<ShelterDto> { s1, s2, s3 };
		}

		public ShelterDto GetShelterById(int id)
		{
			return new ShelterDto()
			{
				Id = id,
				Buyer_Id = 5,
				Name = "Приют такой-то",
				Description = "лучший приют всегда",
				City = "Там",
				AnimalList = { 13, 14, 15 },
			};
		}
	}
}
