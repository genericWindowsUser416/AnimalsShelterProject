namespace HomelessAnimalsShelter.Core.Dtos
{
	public class ShelterDto
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string Description { get; set; }

		public string City { get; set; }

		public int Buyer_Id { get; set; }

		public List<int> AnimalList { get; set; } = new List<int>();
	}
}
