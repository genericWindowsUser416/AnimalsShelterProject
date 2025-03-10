﻿namespace HomelessAnimalsShelter.Core.Models
{
    public class DonationOutputModel
    {
		public int Id { get; set; }

		public string? Name { get; set; }

		public string? Description { get; set; }

		public int Shelter_Id { get; set; }

		public Decimal NeededMoney { get; set; }

		public Decimal CollectedMoney { get; set; }
	}
}
