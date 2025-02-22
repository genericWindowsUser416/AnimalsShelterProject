using HomelessAnimalsShelter.Core.Dtos;

namespace HomelessAnimalsShelter.DAL
{
	public class ReviewRepository
	{
		public ReviewDto GetReviewById(int id)
		{
			using (Context context = new Context())
			{
				return context.Reviews.Where(r => r.Id == id).First();
			}
		}

		public List<ReviewDto> GetAllReviews()
		{
			using (Context context = new Context())
			{
				return context.Reviews
							  .Select(r => new ReviewDto
							  {
								  Id = r.Id,
								  Description = r.Description,
								  User = r.User,
								  Shelter = r.Shelter,
								  Rating = r.Rating
							  })
							  .ToList();
			}
		}
	}
}
