namespace HomelessAnimalsShelter.Core.Dtos
{
	public class ShelterDto
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string Description { get; set; }

		public string City { get; set; }

		public List<DonationDto> DonationDtos { get; set; }

		public UserDto User { get; set; }

		public List<AnimalDto> AnimalDtos { get; set; }
	}
}
