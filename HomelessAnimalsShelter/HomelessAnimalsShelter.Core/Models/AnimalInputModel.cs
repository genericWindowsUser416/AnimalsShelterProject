using HomelessAnimalsShelter.Core.Dtos;

namespace HomelessAnimalsShelter.Core.Models
{
    public class AnimalInputModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<string> TagDtos { get; set; } = new List<string>();
    }
}
