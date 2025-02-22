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
							  .Select(s => new ReviewDto
							  {
								  Id = s.Id,
								  Description = s.Description,
								  User = s.User,
								  Shelter = s.Shelter,
								  Rating = s.Rating
							  })
							  .ToList();
			}
		}
	}
}
