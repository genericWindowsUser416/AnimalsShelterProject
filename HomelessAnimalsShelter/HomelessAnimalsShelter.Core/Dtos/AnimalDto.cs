namespace HomelessAnimalsShelter.Core.Dtos
{
	public class AnimalDto
	{
		public int? Id { get; set; }

		public string Name { get; set; }

		public string Description { get; set; }

		public List<string> TagList { get; set; } = new List<string>();
	}
}
