using HomelessAnimalsShelter.Core;
using HomelessAnimalsShelter.Core.Dtos;
namespace HomelessAnimalsShelter.DAL
{
	public class AnimalRepository
	{
		public List<AnimalDto> GetAllAnimals()
		{
			var a1 = new AnimalDto()
			{
				Id = 1,
				Name = "Кот",
				Description = "Спит"
			};

			var a2 = new AnimalDto()
			{
				Id = 2,
				Name = "Собака",
				Description = "Быстро бегает",
			};

			var a3 = new AnimalDto()
			{
				Id = 3,
				Name = "Морская свинка",
				Description = "Спит"
			};

			return new List<AnimalDto> { a1, a2, a3 };
		}

		public AnimalDto GetAnimalById(int id)
		{
			return new AnimalDto()
			{
				Id = id,
				Name = "Глеб",
				Description = "олег"
			};
		}
	}
}
