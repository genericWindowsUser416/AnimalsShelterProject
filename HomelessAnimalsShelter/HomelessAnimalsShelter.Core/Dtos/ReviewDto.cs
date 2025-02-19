namespace HomelessAnimalsShelter.Core.Dtos
{
	public class ReviewDto
	{
		public int Id { get; set; }

		public string Description { get; set; }

		public UserDto User { get; set; }

		public ShelterDto Shelter { get; set; }

		public int Rating { get; set; }
	}
}
