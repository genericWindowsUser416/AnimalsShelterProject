namespace HomelessAnimalsShelter.Core.Dtos
{
	internal class ReviewDto
	{
		public int Id { get; set; }

		public int Buyer_Id { get; set; }

		public int Shelter_Id { get; set; }

		public string Description { get; set; }

		public int Rating { get; set; }
	}
}
