using HomelessAnimalsShelter.Core;
using HomelessAnimalsShelter.Core.Dtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
namespace HomelessAnimalsShelter.DAL
{
	public class AnimalRepository
	{
        public AnimalDto GetAnimalById(int id)
        {
            using (Context context = new Context())
            {
                return context.Animals.Include(a => a.TagDtos).Where(a => a.Id == id).First();
            }
        }

        public List<AnimalDto> GetAllAnimals()
        {
            using (Context context = new Context())
            {
                return context.Animals
                              .Select(a => new AnimalDto
                              {
                                  Id = a.Id,
                                  Name = a.Name,
                                  Description = a.Description,
                                  TagDtos = a.TagDtos,
                                  Shelter = a.Shelter
                              })
                              .ToList();
            }
        }

		public List<AnimalDto> GetAnimalsByShelterId(int shelterId)
		{
			using (Context context = new Context())
			{
				return context.Animals.Include(a => a.TagDtos).Include(a => a.Shelter).Where(a => a.Shelter == context.Shelters.Where(s => s.Id == shelterId).First()).ToList();
			}
		}
	}
}
