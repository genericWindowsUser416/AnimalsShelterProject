namespace HomelessAnimalsShelter.Core.Models
{
    public class TagOutputModel
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public List<int> AnimalList { get; set; } = new List<int>();
    }
}
