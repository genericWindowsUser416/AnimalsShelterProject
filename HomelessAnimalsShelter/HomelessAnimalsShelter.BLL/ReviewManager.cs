using AutoMapper;
using HomelessAnimalsShelter.Core.Models;
using HomelessAnimalsShelter.BLL.Mappers;
using HomelessAnimalsShelter.DAL;

namespace HomelessAnimalsShelter.BLL
{
	public class ReviewManager
	{
		private ReviewRepository _repository;
		private Mapper _mapper;

		public ReviewManager()
		{
			MapperConfiguration configuration = new MapperConfiguration(
				cfg => {
					cfg.AddProfile(new ReviewMapperProfile());
				});

			_mapper = new Mapper(configuration);

			_repository = new ReviewRepository();
		}

		public List<ReviewOutputModel> GetAllReviews()
		{
			return _mapper.Map<List<ReviewOutputModel>>(_repository.GetAllReviews());
		}

		public ReviewOutputModel GetReviewById(int id)
		{
			return _mapper.Map<ReviewOutputModel>(_repository.GetReviewById(id));
		}
	}
}
