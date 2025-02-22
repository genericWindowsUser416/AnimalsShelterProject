namespace HomelessAnimalsShelter.Core.Dtos
{
	public class TagDto
	{
		public int Id { get; set; }

		public string? Name { get; set; }

		public List<AnimalDto>? AnimalDtos { get; set; }
	}
}
