using HomelessAnimalsShelter.Core.Dtos;

namespace HomelessAnimalsShelter.DAL
{
	public class ReviewRepository
	{
		public List<ReviewDto> GetAllReviews()
		{
			var r1 = new ReviewDto()
			{
				Id = 1,
				Rating = 5,
				Description = "Всё супер"
			};

			var r2 = new ReviewDto()
			{
				Id = 2,
				Rating = 3,
				Description = "Нормально"
			};

			var r3 = new ReviewDto()
			{
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
				Id = 4,
				Rating = 4,
				Description = "WWW"
			};
		}
	}
}
