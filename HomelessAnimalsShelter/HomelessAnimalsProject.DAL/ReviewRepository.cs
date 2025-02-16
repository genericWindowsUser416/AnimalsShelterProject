using HomelessAnimalsShelter.Core.Dtos;

namespace HomelessAnimalsShelter.DAL
{
	public class ReviewRepository
	{
		public List<ReviewDto> GetAllReviews()
		{
			var r1 = new ReviewDto()
			{
				Buyer_Id = 1,
				Shelter_Id = 1,
				Id = 1,
				Rating = 5,
				Description = "Всё супер"
			};

			var r2 = new ReviewDto()
			{
				Buyer_Id = 2,
				Shelter_Id = 1,
				Id = 2,
				Rating = 3,
				Description = "Нормально"
			};

			var r3 = new ReviewDto()
			{
				Buyer_Id = 3,
				Shelter_Id = 2,
				Id = 3,
				Rating = 2,
				Description = "QQQ"
			};

			return new List<ReviewDto> { r1, r2, r3 };
		}

		public ReviewDto GetReviewById(int id)
		{
			return new ReviewDto()
			{
				Buyer_Id = 3,
				Shelter_Id = 5,
				Id = 4,
				Rating = 4,
				Description = "WWW"
			};
		}
	}
}
