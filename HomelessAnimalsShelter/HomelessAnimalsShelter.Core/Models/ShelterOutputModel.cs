namespace HomelessAnimalsShelter.Core.Models
{
	public class ShelterOutputModel
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string Description { get; set; }

		public string City { get; set; }

		public List<int> AnimalList { get; set; } = new List<int>();
	}
}
