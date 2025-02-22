using HomelessAnimalsShelter.Core;
using HomelessAnimalsShelter.Core.Dtos;
namespace HomelessAnimalsShelter.DAL
{
	public class AnimalRepository
	{
        public AnimalDto GetAnimalById(int id)
        {
            using (Context context = new Context())
            {
                return context.Animals.Where(a => a.Id == id).First();
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
    }
}
